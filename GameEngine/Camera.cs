using System.Windows.Controls;
using GameEngine.interfaces;

namespace GameEngine
{
    public class Camera : IGameObject
    {
        public GameManager GameManager { get; set; }
        public static Canvas DisplayCanvas;
        public int Initiative { get; } = -100;
        public bool IsActive { get; } = true;
        public Vector2 Position { get; set; } = new Vector2(0, 0);
        public ScreenObject ScreenObject { get; set; } = null;
        public IGameObject Target { get; set; } = null;

        public void Action()
        {
            //RefreshScreen();
        }

        public Camera(Canvas displayCanvas, GameManager gameManager)
        {
            DisplayCanvas = displayCanvas;
            GameManager = gameManager;
        }
        public void RefreshScreen()
        {
            foreach (var gameObject in GameManager.GameObjects)
            {
                if (gameObject.ScreenObject != null)
                {
                    gameObject.ScreenObject.Reposition(gameObject.Position.X - Position.X, (float)(DisplayCanvas.Height / ScreenObject.PixelsPerUnit) - gameObject.Position.Y + Position.Y);
                }
            }
        }
        private bool IsVectorInScreen(Vector2 pos)
        {
            if ((!(pos.X > (Position.X))) || !(pos.X < (Position.X + DisplayCanvas.Width))) return false;
            return (pos.Y > (Position.Y)) && pos.Y < (Position.Y + DisplayCanvas.Height);
        }
    }
}
