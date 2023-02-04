
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SDC_Task
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string CurrentShape = "Rectangle";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShapeSelectors_Click(object sender, RoutedEventArgs e)
        {
            RectangleShape.Visibility = Visibility.Collapsed;
            CircleShape.Visibility = Visibility.Collapsed;
            TriangleShape.Visibility = Visibility.Collapsed;

            switch (((RadioButton)sender).Name)
            {
                case "Rectangle":
                    RectangleShape.Visibility = Visibility.Visible;
                    CurrentShape = "Rectangle";
                    break;
                case "Circle":
                    CircleShape.Visibility = Visibility.Visible;
                    CurrentShape = "Circle";
                    break;
                case "Triangle":
                    TriangleShape.Visibility = Visibility.Visible;
                    CurrentShape = "Triangle";
                    break;
                default:
                    break;
            }
        }

        private void WidthSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            RectangleShape.Width = WidthSlider.Value * 50;
            CircleShape.Width = WidthSlider.Value * 50;
        }
        private void HeightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            RectangleShape.Height = HeightSlider.Value * 50;
            CircleShape.Height = HeightSlider.Value * 50;
        }


    }
}
