using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CommandHandler.enums;
using EntityData.Characters;
using EntityData.Monsters;
using GameEngine;
using GameEngine.interfaces;

namespace Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameManager GM;
        private BasicFighter bs;
        public MainWindow()
        {
            InitializeComponent();
            GM = new GameManager();
            var camera = new Camera(MainCanvas, GM);
            var room1 = new Room(new Vector2(0,0), "Dungion.png");
            bs = new BasicFighter("Urban den förskräcklige");
            bs.Position += new Vector2(3,3);
            bs.ScreenObject = new ScreenObject("basicFighter.png");
            var goblin = new Goblin();
            goblin.ScreenObject = new ScreenObject("Goblin.png");
            goblin.ScreenObject.Image.MouseDown += UIElement_OnMouseDown;
            GM.Register(room1);
            room1.ScreenObject.Image.MouseDown += UIElement_OnMouseDown;
            GM.Register(goblin);
            GM.Register(bs);
            camera.RefreshScreen();

            //bs.Target = goblin;
            //bs.AddCommand(Commands.Attack);
            //tm.RunTurn();
        }

        public class Room : IGameObject
        {
            public int Initiative { get; }
            public bool IsActive { get; }
            public Vector2 Position { get; set; }
            public ScreenObject ScreenObject { get; set; }
            public IGameObject Target { get; set; }
            public void Action()
            {
                
            }

            public Room(Vector2 position, string img)
            {
                Position = position;
                ScreenObject = new ScreenObject(img);

            }
        }

        private void MainWindow_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                GM.RunTurn();
            }
        }

        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            var img = (sender as Image);
            var go = GM.GameObjects.First(obj => obj.ScreenObject.Image == img);

            bs.Target = go;
        }

        private void PointerCanvasDown(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}
