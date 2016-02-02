using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace GameEngine
{
    /// <summary>
    /// Represents a Object that is to be displayed on the Screen(Canvas)
    /// </summary>
    public class ScreenObject
    {
        public const int PixelsPerUnit = 100;
        private Image _image;
        private string _imageSource;
        private Action<object, MouseButtonEventArgs> uIElement_OnMouseDown;

        public Vector2 PivotPoint { get; set; } = new Vector2(0.5f,0.5f);

        public Image Image
        {
            get
            {
                return _image;
            }
            private set
            {
                Camera.DisplayCanvas.Children.Add(value);
                _image = value;
            }
        }
        public string ImageSource
        {
            get
            {
                return _imageSource;
            }
            set
            {
                if (value == _imageSource) return;
                var bitmap = new BitmapImage(new Uri("pack://application:,,,/Images/" + value, UriKind.Absolute));
                if (Image == null)
                {
                    Image = new Image()
                    {
                        Source = bitmap,
                        Width = bitmap.Width,
                        Height = bitmap.Height
                    };
                }
                else
                {
                    Image.Source = bitmap;
                }
                _imageSource = "pack://application:,,,/Images/" + value;
            }
        }
        public int ZIndex { get; set; }
        public ScreenObject(string source, int zIndex = 0, MouseButtonEventHandler uIElement_OnMouseDown = null)
        {
            ImageSource = source;
            ZIndex = zIndex;
            if(uIElement_OnMouseDown != null)
                Image.MouseDown += uIElement_OnMouseDown;
        }
        public void Reposition(float x, float y)
        {
            Canvas.SetTop(Image, (y * PixelsPerUnit) - Image.Height * PivotPoint.Y);
            Canvas.SetLeft(Image, (x * PixelsPerUnit) - Image.Height * PivotPoint.X);
            //Canvas.SetTop(Image, (y*PixelsPerUnit));
            //Canvas.SetLeft(Image, (x*PixelsPerUnit));
            Panel.SetZIndex(Image, ZIndex);
        }
        public Vector2 ToCanvasPosition()
        {
            return new Vector2((float)Canvas.GetLeft(Image), (float)Canvas.GetTop(Image));
        }

        public void SetOpacity(double value)
        {
            Image.Opacity = value;
        }
    }
}
