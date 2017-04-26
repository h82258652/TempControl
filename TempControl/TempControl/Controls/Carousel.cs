using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TempControl.Controls
{
    public class Carousel : FlipView
    {
        public static readonly DependencyProperty IsLoopEnabledProperty = DependencyProperty.Register(nameof(IsLoopEnabled), typeof(bool), typeof(Carousel), new PropertyMetadata(false, OnIsLoopEnabledChanged));

        public static readonly DependencyProperty OrientationProperty = DependencyProperty.Register(nameof(Orientation), typeof(Orientation), typeof(Carousel), new PropertyMetadata(Orientation.Horizontal, OnOrientationChanged));

        public Carousel()
        {
            DefaultStyleKey = typeof(Carousel);
        }

        public bool IsLoopEnabled
        {
            get
            {
                return (bool)GetValue(IsLoopEnabledProperty);
            }
            set
            {
                SetValue(IsLoopEnabledProperty, value);
            }
        }

        public Orientation Orientation
        {
            get
            {
                return (Orientation)GetValue(OrientationProperty);
            }
            set
            {
                SetValue(OrientationProperty, value);
            }
        }

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }

        private static void OnIsLoopEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void OnOrientationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var obj = (Carousel)d;
            var value = (Orientation)e.NewValue;

            if (Enum.IsDefined(typeof(Orientation), value) == false)
            {
                throw new ArgumentOutOfRangeException(nameof(Orientation));
            }

            throw new NotImplementedException();
        }
    }
}