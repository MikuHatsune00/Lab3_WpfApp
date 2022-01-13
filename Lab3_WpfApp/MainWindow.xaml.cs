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
using System.Drawing;



namespace Lab3_WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            { textBox.FontFamily = new FontFamily(fontName); }

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            string fontSize = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            { textBox.FontSize = Convert.ToInt32(fontSize); }
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource == bold)
            {
                if (textBox.FontWeight == FontWeights.Normal)
                {
                    textBox.FontWeight = FontWeights.Bold;
                    bold.Opacity = 0.2;
                }
                else
                {
                    textBox.FontWeight = FontWeights.Normal;
                    bold.Opacity = 1;
                }
            }
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource == italic)
            {
                if (textBox.FontStyle == FontStyles.Normal)
                { textBox.FontStyle = FontStyles.Italic;
                    italic.Opacity = 0.2;
                }
                else { textBox.FontStyle = FontStyles.Normal;
                    italic.Opacity = 1;
                }
            }


        }
        private void Button_Click3(object sender, RoutedEventArgs e)

        {
            if (e.OriginalSource == underline)
            {
                if (textBox.TextDecorations != TextDecorations.Underline)
                {
                    textBox.TextDecorations=TextDecorations.Underline;
                    underline.Opacity = 0.2;
                }
                else
                {
                    textBox.TextDecorations=null;                        
                    underline.Opacity = 1;
                }
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;           
            textBox.Foreground = Brushes.Red;
            
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            if (textBox != null)
            { textBox.Foreground = Brushes.Black; }
        }
    }
}
