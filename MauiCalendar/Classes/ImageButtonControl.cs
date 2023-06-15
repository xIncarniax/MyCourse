using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCourse
{
    public class ImageButtonControl : ContentView
    {
        private readonly Image image;

        public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create(
            nameof(ImageSource),
            typeof(ImageSource),
            typeof(ImageButtonControl),
            default(ImageSource),
            propertyChanged: OnImageSourceChanged);

        public ImageSource ImageSource
        {
            get => (ImageSource)GetValue(ImageSourceProperty);
            set => SetValue(ImageSourceProperty, value);
        }

        public static readonly BindableProperty ImageWidthProperty = BindableProperty.Create(
            nameof(ImageWidth),
            typeof(double),
            typeof(ImageButtonControl),
            default(double),
            propertyChanged: OnImageWidthChanged);

        public double ImageWidth
        {
            get => (double)GetValue(ImageWidthProperty);
            set => SetValue(ImageWidthProperty, value);
        }

        public static readonly BindableProperty ImageHeightProperty = BindableProperty.Create(
            nameof(ImageHeight),
            typeof(double),
            typeof(ImageButtonControl),
            default(double),
            propertyChanged: OnImageHeightChanged);

        public double ImageHeight
        {
            get => (double)GetValue(ImageHeightProperty);
            set => SetValue(ImageHeightProperty, value);
        }

        public event EventHandler Clicked;

        public ImageButtonControl()
        {
            image = new Image
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            Content = image;

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += OnTapped;
            image.GestureRecognizers.Add(tapGestureRecognizer);
        }

        private static void OnImageSourceChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (ImageButtonControl)bindable;
            control.image.Source = (ImageSource)newValue;
        }

        private static void OnImageWidthChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (ImageButtonControl)bindable;
            control.image.WidthRequest = (double)newValue;
        }

        private static void OnImageHeightChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (ImageButtonControl)bindable;
            control.image.HeightRequest = (double)newValue;
        }

        private void OnTapped(object sender, EventArgs e)
        {
            Clicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
