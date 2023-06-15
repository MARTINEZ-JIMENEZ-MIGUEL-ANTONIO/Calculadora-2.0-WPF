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

namespace Calculadora2_WPF
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

        public void ButtonClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Button button = (Button)sender;//
                string value = (string)button.Content;
                if(IsNumber(value))
                {
                    HandleNumber(value);
                }
            }
            catch (Exception)
            {

                throw new Exception("");
            }
        }
        //Metodo Auxiliares
        private bool IsNumber(string num)
        {
            /*if(double.TryParse(num,out _))
            {
                return true;
            }
                return false;*/
            return double.TryParse(num,out _);
        }
        private void HandleNumber(string value)
        {
            if(String.IsNullOrEmpty(Screen.Text))//Si el TextBox Esta vacio mande mensaje
            {
                Screen.Text = value;
            }
            else
            {
                Screen.Text += value;//Concatenar El Numero
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
