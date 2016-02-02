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
        }

        private void InitGoblins()
        {
            var rnd = new Random();
            var num = 5;
            for (var i = 0; i < num; i++)
            {
                var gob = new Goblin
                {
                    Position = new Vector2((float) rnd.NextDouble()*5f + .5f, (float) rnd.NextDouble()*5f + .1f),
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
            if (e.Key == Key.Enter)
            {
                _gm.RunTurn();
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
            var pos = _gm.CurrentCharacter.Position;
            var maxDistance = 2;
                //TODO fix tilesize/units (GM.CurrentCharacter as Character)?.Race.BaseSpeed.Tiles ?? 0;
            //clamp movement..
            if (pos.Distance(_movePosition) > maxDistance)
                _movePosition = pos + pos.Normalize(_movePosition)*maxDistance;
            // TODO Validate that target is floor
        }

        private void PointerCanvasDown(object sender, MouseButtonEventArgs e)
        {
            // removed all code here, think it was mostly test code.
            // Is this needed ?
        }
    }
}