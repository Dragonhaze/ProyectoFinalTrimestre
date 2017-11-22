using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
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

            int nope = 0;
            for (int i = 0; i < Personas.GetPersonas().Count; i++)
            {
                if( Personas.GetPersonas()[i].Dni == persona.Dni)
                {
                    nope = 1;
                    SoundPlayer My_JukeBox = new SoundPlayer(@"Sounds/nope.wav");
                    try
                    {
                        My_JukeBox.Play();
                    }
                    catch (FileNotFoundException ex)
                    {
                        
                        Console.WriteLine(ex);
                    }
                    MessageBox.Show("Ya hay una persona con el mismo DNI");
                    
                }
            }
            if( nope == 0)
            {
                SoundPlayer My_JukeBox2 = new SoundPlayer(@"Sounds/item.wav");
                try
                {
                    My_JukeBox2.Play();
                }
                catch (FileNotFoundException ex)
                {
                    // Write error.
                    Console.WriteLine(ex);
                }

                Personas.addPersona(persona);
                Task.Delay(700).Wait();
                this.Close();
            }
            else
            {
                

                Textbox1.Clear();
                Textbox2.Clear();
                Textbox3.Clear();
                Textbox6.Clear();
                Textbox5.Clear();
                date.ClearValue(DatePicker.SelectedDateProperty);
            }
            

            
            
        }
    }
}
