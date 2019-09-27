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
using System.IO;

namespace OperacionesMatematicas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBoxOperando1.Text = "0";
            TextBoxOperando2.Text = "0";

        }

        private void TextBoxkOperando1_TextChanged(object sender, TextChangedEventArgs e)
        {
            Operaciones(sender,e);
        }

       
        public void Operaciones(object sender, RoutedEventArgs e)
        {
            if (RadioButtonDivision.IsChecked == true)
            {
               
                try{
                    TextBoxResultado.Text = (int.Parse(TextBlockOperando1.Text) / int.Parse(TextBlockOperando2.Text)).ToString();
                }
                catch(DivideByZeroException e)
                {
                    throw new DivideByZeroException("No se puede dividir por 0", e.Message);
                    TextBoxResultado.Text = "Error";
                }

            }
            else if (RadioButtonMultiplicacion.IsChecked == true)
            {
                TextBoxResultado.Text =( int.Parse(TextBlockOperando1.Text) * int.Parse(TextBlockOperando2.Text)).ToString();
            }
            else if (RadioButtonSuma.IsChecked == true)
            {
                TextBoxResultado.Text = (int.Parse(TextBlockOperando1.Text) + int.Parse(TextBlockOperando2.Text)).ToString();
            }
            else
            {
                TextBoxResultado.Text = (int.Parse(TextBlockOperando1.Text) - int.Parse(TextBlockOperando2.Text)).ToString();
            }
        }

        
    }
}
