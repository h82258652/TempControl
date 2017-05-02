using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.Controls
{
    public class Carousel : ItemsControl
    {
        public static readonly DependencyProperty IsLoopEnabledProperty = DependencyProperty.Register(nameof(IsLoopEnabled), typeof(bool), typeof(Carousel), new PropertyMetadata(false, OnIsLoopEnabledChanged));

        public static readonly DependencyProperty OrientationProperty = DependencyProperty.Register(nameof(Orientation), typeof(Orientation), typeof(Carousel), new PropertyMetadata(Orientation.Horizontal, OnOrientationChanged));

        static Carousel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Carousel), new FrameworkPropertyMetadata(typeof(Carousel)));
        }

        public event SelectionChangedEventHandler SelectionChanged;

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

        public int SelectedIndex
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public object SelectedItem
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public object SelectedValue
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string SelectedValuePath
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new CarouselItem();
        }

        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return item is CarouselItem;
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