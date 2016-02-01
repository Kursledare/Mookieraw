using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using CommandHandler.enums;
using CommandHandler.interfaces;
using EntityData.Characters;
using EntityData.Interfaces;
using GameEngine;
using GameEngine.interfaces;

namespace Game
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly BasicFighter bs;
        private readonly GameManager GM;
        private readonly BasicFighter bs2;
        private IGameObject CurrentTarget;
        private Camera camera;
        private bool _mouseHandled;
        public MainWindow()
        {
            InitializeComponent();
            GM = new GameManager();
            camera = new Camera(MainCanvas, GM);
            var room1 = FileHandler.Load("Dungion1.mkr", "Dungion1.png");
            room1.Position=new Vector2(2.8f,3.2f);
            bs = new BasicFighter("Urban den förskräcklige");
            bs.Position += new Vector2(3, 3);
            bs.ScreenObject = new ScreenObject("basicFighter.png");
            bs2 = new BasicFighter("Jurgen den Oförskräklige");
            bs2.ScreenObject = new ScreenObject("Goblin.png");
            bs2.ScreenObject.Image.MouseDown += UIElement_OnMouseDown;
            bs2.ScreenObject.Image.MouseEnter += Image_MouseEnter;
            (bs2 as ICommandable).PlayerControlled = false;
            bs2.Position= new Vector2(2,3);
            bs.ScreenObject.Image.MouseEnter += Image_MouseEnter;
            bs.ScreenObject.Image.MouseDown += UIElement_OnMouseDown;
            GM.Register(room1);
            room1.ScreenObject.Image.MouseDown += UIElement_OnMouseDown;
            GM.Register(bs2);
            GM.Register(bs);
            GM.Register(camera);
            camera.RefreshScreen();
            GM.CurrentCharacter = bs;

            //bs.Target = goblin;
            //bs.AddCommand(Commands.Attack);
            //tm.RunTurn();
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            var img = sender as Image;
            var tt = new ToolTip();
            var go = GM.GameObjects.First(a => a.ScreenObject.Image == img) as ICharacter;
            tt.Content=new TextBlock() {Text=go?.Name+"\n"+"Hp: "+go?.CurrentHp};
            img.ToolTip = tt;

        }

        private void MainWindow_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                bs.Target = bs2;
                bs2.Target = bs;
                bs.AddCommand(Commands.MeleeAttack);
                bs2.AddCommand(Commands.MeleeAttack);

                this.Title = "Combat";
                GM.RunTurn();
            }
        }

        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
           
            var target = GM.AvailibleTargets.FirstOrDefault(a=>a.ScreenObject.Image==sender as Image);
            if (target != null)
            {
                _mouseHandled = true;
                var cm = new ContextMenu();
                var item = new MenuItem() { Header = "MoveAndAttack" };
                var item2 = new MenuItem() {Header = "Move"};
                item.Click += Item_Click;
                item2.Click += Item_Click;
                cm.Items.Add(item);
                cm.Items.Add(item2);
                MainCanvas.ContextMenu = cm;
                CurrentTarget = target;
            }

        }

        private void Item_Click(object sender, RoutedEventArgs e)
        {
            var item = sender as MenuItem;
            if (item == null) return;
            if (item.Header.ToString() == "MoveAndAttack")
            {
                GM.CurrentCharacter.Target = CurrentTarget;
                GM.CurrentCharacter.MovePosition = CurrentTarget.Position;
                (GM.CurrentCharacter as ICommandable)?.AddCommand(Commands.Move);
                (GM.CurrentCharacter as ICommandable)?.AddCommand(Commands.MeleeAttack);
            }
        }

        private void PointerCanvasDown(object sender, MouseButtonEventArgs e)
        {
            if (_mouseHandled) return;
            var pos = Mouse.GetPosition(MainCanvas);
            if (e.ChangedButton == MouseButton.Left)
            {
                var room = GM.GameObjects.First(a => a is Room) as Room;
                
                if (room.GetTile(new Vector2((float) pos.X, (float) pos.Y)) == TileTypes.Floor)
                    bs.Position = camera.PointToWorldPosition(pos);
                camera.RefreshScreen();
            }
            if (e.ChangedButton == MouseButton.Right)
            {
                GM.CurrentCharacter.MovePosition = camera.PointToWorldPosition(pos);
                var ic = GM.CurrentCharacter as ICommandable;
                ic?.AddCommand(Commands.Move);
            }
        }
        
    }
}