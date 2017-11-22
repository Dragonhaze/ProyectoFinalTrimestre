using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
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

namespace ProyectoFinalTrimestre
{
    /// <summary>
    /// Lógica de interacción para Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            buscarPersonaPorNombre(textbox.Text);
        }
        
        public void buscarPersonaPorNombre(String nombre)
        {
            SoundPlayer My_JukeBox = new SoundPlayer(@"Sounds/nope.wav");
            SoundPlayer My_JukeBox2 = new SoundPlayer(@"Sounds/item.wav");

            if (nombre == "")
            {
                try
                {
                    My_JukeBox.Play();
                }
                catch (FileNotFoundException ex)
                {

                    Console.WriteLine(ex);
                }
                MessageBox.Show("Introduce un nombre");
                
            }
            else
            {
                texto.Text = "";
                for (int i = Personas.GetPersonas().Count - 1; i >= 0; i--)
                {
                    if (Personas.GetPersonas()[i].Nombre == nombre)
                    {
                        texto.Text += Personas.buscarPersonaPorIndex(i);
                        Personas.removePersona(Personas.GetPersonas()[i]);
                        try
                        {
                            My_JukeBox2.Play();
                        }
                        catch (FileNotFoundException ex) {Console.WriteLine(ex);}
                    }
                }
                if(texto.Text == "")
                {
                    texto.Text = "No se ha encontrado a nadie con ese nombre";
                    try
                    {
                        My_JukeBox.Play();
                    }
                    catch (FileNotFoundException ex)
                    {
                        Console.WriteLine(ex);
                    }

                }
            }
        }
    }
}
