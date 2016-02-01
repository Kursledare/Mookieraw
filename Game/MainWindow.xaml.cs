using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using CommandHandler.enums;
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
        private Camera camera;
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
            bs.ScreenObject.Image.MouseEnter += Image_MouseEnter;
            bs.ScreenObject.Image.MouseDown += UIElement_OnMouseDown;
            GM.Register(room1);
            room1.ScreenObject.Image.MouseDown += UIElement_OnMouseDown;
            GM.Register(bs2);
            GM.Register(bs);
            camera.RefreshScreen();

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
            
        }

        private void PointerCanvasDown(object sender, MouseButtonEventArgs e)
        {
            var room = GM.GameObjects.First(a => a is Room) as Room;
            var pos = Mouse.GetPosition(MainCanvas);
            if(room.GetTile(new Vector2((float)pos.X,(float)pos.Y))==TileTypes.Floor)bs.Position = camera.PointToWorldPosition(pos);
            camera.RefreshScreen();
        }
        
    }
}