using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using CommandHandler.enums;
using CommandHandler.interfaces;
using EntityData.Characters;
using EntityData.Interfaces;
using EntityData.Monsters;
using GameEngine;
using GameEngine.interfaces;

namespace Game
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly Camera _camera;
        private readonly GameManager _gm;
        private IGameObject _currentTarget;
        private Vector2 _movePosition;

        public MainWindow()
        {
            InitializeComponent();
            _gm = new GameManager();
            _camera = new Camera(MainCanvas, _gm);
            InitLevel();
            InitParty();
            InitGoblins();
            InitCamera();
            InitLog();
        }

        private void InitLog()
        {
            GameEngine.Game.OnGameLoggedEntry += UpdateLog;
        }

        private void UpdateLog(string message)
        {
            GameLog.CaretIndex = GameLog.Text.Length;
            GameLog.Text += message + Environment.NewLine;
            GameLog.ScrollToEnd();
            GameLog.CaretIndex = GameLog.Text.Length;
        }

        private void InitGoblins()
        {
            var rnd = new Random();
            var num = 5;
            for (var i = 0; i < num; i++)
            {
                var gob = new Goblin
                {
                    Name = "Gerblin " + i,
                    Position = new Vector2((float) rnd.NextDouble()*6f + .6f, (float) rnd.NextDouble()*4f + 1f),
                    ScreenObject = new ScreenObject("Goblin.png", 0, UIElement_OnMouseDown)
                };
                gob.ScreenObject.Image.MouseEnter += Image_MouseEnter;
                _gm.Register(gob);
            }
        }

        private void InitParty()
        {
            string[] names = {"Urban", "Jurgen", "Adylf"};
            var i = 2f;
            foreach (var name in names)
            {
                var bs = new BasicFighter(name) {ScreenObject = new ScreenObject("basicFighter.png")};
                bs.ScreenObject.Image.MouseDown += UIElement_OnMouseDown;
                bs.ScreenObject.Image.MouseEnter += Image_MouseEnter;
                bs.Position = new Vector2(i += .5f, 3f);
                ((ICommandable) bs).PlayerControlled = true;
                _gm.Register(bs);
            }
        }

        private void InitLevel()
        {
            var room1 = FileHandler.Load("Dungion1.mkr", "Dungion1.png");
            room1.Position = new Vector2(2.8f, 3.2f);
            room1.ScreenObject.Image.MouseDown += UIElement_OnMouseDown;
            _gm.Register(room1);
        }

        private void InitCamera()
        {
            _gm.Register(_camera);
            _camera.RefreshScreen();
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            var img = sender as Image;
            if (img == null) return;
            var tt = new ToolTip();
            var go =
                _gm.GameObjects.FirstOrDefault(a => a.ScreenObject != null && ReferenceEquals(a.ScreenObject.Image, img))
                    as ICharacter;
            tt.Content = new TextBlock {Text = go?.Name + "\n" + "Hp: " + go?.CurrentHp};
            img.ToolTip = tt;
        }

        private void MainWindow_OnKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Enter:
                    DoGoblinActions();
                    _gm.RunTurn();
                    if (_gm.AvailibleTargets.Count(a => a.IsActive) <= 0)
                        MessageBox.Show("Wheee, you killed them all !!!!");
                    break;
                case Key.Tab:
                    _gm.SelectNextCharacter();
                    break;
            }
        }

        private void DoGoblinActions()
        {
            foreach (var availableTargets in _gm.AvailibleTargets)
            {
                var monster = availableTargets as Monster;
                if (monster == null) continue;
                var minDistance = _gm.Party.Min(a => Vector2.Distance(a.Position, monster.Position));
                var tmpTarget = _gm.Party.Find(a => Math.Abs(Vector2.Distance(a.Position, monster.Position) - minDistance) < 0.1f);
                var monsterRange = 1;
                if (minDistance > monsterRange)
                {
                    monster.AddCommand(Commands.Move);
                    monster.MovePosition = monster.Position + Vector2.Normalize(monster.Position, tmpTarget.Position)*2;
                }
                monster.Target = tmpTarget;
                monster.AddCommand(Commands.MeleeAttack);
            }
        }

        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            var pos = e.GetPosition(MainCanvas);
            _movePosition = _camera.PointToWorldPosition(pos);

            switch (e.ChangedButton)
            {
                case MouseButton.Right:
                    var cm = new ContextMenu();
                    var moveItem = new MenuItem {Header = "Move"};
                    moveItem.Click += Item_Click;

                    var target =
                        _gm.AvailibleTargets.FirstOrDefault(a => ReferenceEquals(a.ScreenObject.Image, sender as Image));
                    if (target != null)
                    {
                        var movAttackItem = new MenuItem {Header = "MoveAndAttack"};
                        movAttackItem.Click += Item_Click;
                        cm.Items.Add(movAttackItem);
                        _currentTarget = target;
                    }
                    cm.Items.Add(moveItem);
                    MainCanvas.ContextMenu = cm;
                    break;
                case MouseButton.Left:
                    //MessageBox.Show(_camera.PointToWorldPosition(pos).X.ToString() + "\n" + _camera.PointToWorldPosition(pos).Y.ToString());
                    break;
            }
        }

        private void Item_Click(object sender, RoutedEventArgs e)
        {
            MainCanvas.ContextMenu = null;
            var item = sender as MenuItem;
            if (item == null) return;
            ValidateMovePosition();
            switch (item.Header.ToString())
            {
                case "MoveAndAttack":
                    _gm.CurrentCharacter.Target = _currentTarget;
                    _gm.CurrentCharacter.MovePosition = _movePosition;
                    (_gm.CurrentCharacter as ICommandable)?.AddCommand(Commands.Move);
                    (_gm.CurrentCharacter as ICommandable)?.AddCommand(Commands.MeleeAttack);
                    break;
                case "Move":
                    _gm.CurrentCharacter.MovePosition = _movePosition;
                    (_gm.CurrentCharacter as ICommandable)?.AddCommand(Commands.Move);
                    break;
            }
        }

        private void ValidateMovePosition()
        {
            var room = _gm.GameObjects.FirstOrDefault(a => a is Room) as Room;
            if (room == null) return;
            var pos = _gm.CurrentCharacter.Position;
            //TODO fix tilesize/pixelsPerUnit. maxDistance = (GM.CurrentCharacter as Character)?.Race.BaseSpeed.Tiles ?? 0;
            var maxDistance = Math.Min(2f, pos.Distance(_movePosition));

            float i;
            // Check if there is a wall in the way.
            for (i = maxDistance; i >= 0; i -= .1f)
            {
                var currentTile = room.GetTile(_camera.WorldPositionToPoint(pos + pos.Normalize(_movePosition)*i));
                if (currentTile == TileTypes.Wall)
                {
                    maxDistance = i;
                }
            }
            // check where the furthest reachable floor tile is
            for (i = maxDistance; i >= 0; i -= .1f)
            {
                var currentTile = room.GetTile(_camera.WorldPositionToPoint(pos + pos.Normalize(_movePosition)*i));
                if (currentTile == TileTypes.Floor || currentTile == TileTypes.Door) break;
            }
            // Set _moveposition to clamped and floor|door checked tile position.
            _movePosition = pos + pos.Normalize(_movePosition)*i;
        }

        private void PointerCanvasDown(object sender, MouseButtonEventArgs e)
        {
            // removed all code here, think it was mostly test code.
            // Is this needed ?
        }
    }
}