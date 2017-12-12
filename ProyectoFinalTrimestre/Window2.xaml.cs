using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace ProyectoFinalTrimestre
{
    /// <summary>
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            String text = TextDNI.Text;

            String resultado = Personas.buscarPersonaPorDNI(text);

            MessageBox.Show(resultado);

            this.Close();
        }
    }
}
