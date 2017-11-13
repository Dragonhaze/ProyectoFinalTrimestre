using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProyectoFinalTrimestre
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        public Window1()
        {
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
        
                string nombre, apellidos, dni, fechanac;
               
                int peso = 0, altura = 0;

                nombre = Textbox1.Text;
                apellidos = Textbox2.Text;
                dni = Textbox3.Text;

                /*if (radio1.IsChecked == true)
                {
                    sexo = 'H';
                }
                else if (radio2.IsChecked == true)
                {
                    sexo = 'F';
                }
                else
                {
                    sexo = 'U';
                }*/

                fechanac = date.Text;
                if (!String.IsNullOrEmpty(Textbox5.Text))
                {
                    peso = Convert.ToInt32(Textbox5.Text);
                }
                if (!String.IsNullOrEmpty(Textbox6.Text))
                {
                    altura = Convert.ToInt32(Textbox6.Text);
                }
                

                Persona persona = new Persona( nombre, apellidos, dni, fechanac, peso, altura);
                MessageBox.Show("Has metido a " + persona.Nombre + " en el array.");

                Personas.addPersona(persona);

                

                

                this.Close();
        }
    }
}
