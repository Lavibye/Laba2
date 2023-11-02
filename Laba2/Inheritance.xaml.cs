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
using System.Windows.Shapes;

namespace Laba2
{
    /// <summary>
    /// Interaction logic for Inheritance.xaml
    /// </summary>
    public partial class Inheritance : Window
    {
        public Inheritance()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text;
            double x1 = Convert.ToDouble(X1TextBox.Text);
            double y1 = Convert.ToDouble(Y1TextBox.Text);
            double x2 = Convert.ToDouble(X2TextBox.Text);
            double y2 = Convert.ToDouble(Y2TextBox.Text);
            ComboBoxItem selectedColorItem = ColorComboBox.SelectedItem as ComboBoxItem;

            string colorName = selectedColorItem.Content.ToString();
            Color selectedColor;

            switch (colorName)
            {
                case "Червоний":
                    selectedColor = Colors.Red;
                    break;
                case "Зелений":
                    selectedColor = Colors.Green;
                    break;
                case "Синій":
                    selectedColor = Colors.Blue;
                    break;
                default:
                    selectedColor = Colors.Black;
                    break;
            }

            double scaleFactor = Convert.ToDouble(ScaleTextBox1.Text);

            Line line = new Line(name, x1, y1, x2, y2, selectedColor.ToString(), scaleFactor);

            MessageBox.Show($"Довжина лінії: {line.Lenght()}");
        }
    }
}
