using System.Windows;
using System.Windows.Media;

namespace PersianCalendarWPF
{
    public class InfoElement : DependencyObject
    {
        public static readonly DependencyProperty HeaderColorProperty = DependencyProperty.RegisterAttached(
            "HeaderColor", typeof(Brush), typeof(InfoElement), new PropertyMetadata(default(Brush)));

        public static void SetHeaderColor(DependencyObject element, Brush value) => element.SetValue(HeaderColorProperty, value);

        public static Brush GetHeaderColor(DependencyObject element) => (Brush)element.GetValue(HeaderColorProperty);

        public static readonly DependencyProperty DefaultTextColorProperty = DependencyProperty.RegisterAttached(
           "DefaultTextColor", typeof(Brush), typeof(InfoElement), new PropertyMetadata(default(Brush)));

        public static void SetDefaultTextColor(DependencyObject element, Brush value) => element.SetValue(DefaultTextColorProperty, value);

        public static Brush GetDefaultTextColor(DependencyObject element) => (Brush)element.GetValue(DefaultTextColorProperty);

        public static readonly DependencyProperty MouseHoverBackgroundColorProperty = DependencyProperty.RegisterAttached(
           "MouseHoverBackgroundColor", typeof(Brush), typeof(InfoElement), new PropertyMetadata(default(Brush)));

        public static void SetMouseHoverBackgroundColor(DependencyObject element, Brush value) => element.SetValue(MouseHoverBackgroundColorProperty, value);

        public static Brush GetMouseHoverBackgroundColor(DependencyObject element) => (Brush)element.GetValue(MouseHoverBackgroundColorProperty);

        public static readonly DependencyProperty MouseHoverForegroundColorProperty = DependencyProperty.RegisterAttached(
           "MouseHoverForegroundColor", typeof(Brush), typeof(InfoElement), new PropertyMetadata(default(Brush)));

        public static void SetMouseHoverForegroundColor(DependencyObject element, Brush value) => element.SetValue(MouseHoverForegroundColorProperty, value);

        public static Brush GetMouseHoverForegroundColor(DependencyObject element) => (Brush)element.GetValue(MouseHoverForegroundColorProperty);

        public static readonly DependencyProperty PressedBorderProperty = DependencyProperty.RegisterAttached(
           "PressedBorderColor", typeof(Brush), typeof(InfoElement), new PropertyMetadata(default(Brush)));

        public static void SetPressedBorderColor(DependencyObject element, Brush value) => element.SetValue(PressedBorderProperty, value);

        public static Brush GetPressedBorderColor(DependencyObject element) => (Brush)element.GetValue(PressedBorderProperty);

        public static readonly DependencyProperty SelectedBackgroundProperty = DependencyProperty.RegisterAttached(
           "SelectedBackgroundColor", typeof(Brush), typeof(InfoElement), new PropertyMetadata(default(Brush)));

        public static void SetSelectedBackgroundColor(DependencyObject element, Brush value) => element.SetValue(SelectedBackgroundProperty, value);

        public static Brush GetSelectedBackgroundColor(DependencyObject element) => (Brush)element.GetValue(SelectedBackgroundProperty);
    }
}