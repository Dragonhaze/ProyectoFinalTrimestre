
using System;
using System.Collections;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Media;
using System.IO;

namespace ProyectoFinalTrimestre
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Persona p;
 
        public MainWindow()
        {

            InitializeComponent();
        }

        

       

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            
            int opcion = Combobox1.SelectedIndex;

            

            switch (opcion)
            {
                case 0:

                    SoundPlayer My_JukeBox = new SoundPlayer(@"Sounds/call.wav");
                    try
                    {
                        My_JukeBox.Play();
                    }
                    catch (FileNotFoundException ex)
                    {
                        // Write error.
                        Console.WriteLine(ex);
                    }

                    Window1 window = new Window1();

                    window.ShowDialog();
                    break;

                case 1:

                    SoundPlayer My_JukeBox2 = new SoundPlayer(@"Sounds/alerted.wav");
                    try
                    {
                        My_JukeBox2.Play();
                    }
                    catch (FileNotFoundException ex)
                    {
                        Console.WriteLine(ex);
                    }

                    texto.Text = String.Empty;
                    for (int i = 0; i < Personas.GetPersonas().Count; i++)
                    {

                        texto.Text += Personas.buscarPersonaPorIndex(i);

                    }


                    

                    break;
                case 2:
                    SoundPlayer My_JukeBox3 = new SoundPlayer(@"Sounds/itemselect.wav");
                    try
                    {
                        My_JukeBox3.Play();
                    }
                    catch (FileNotFoundException ex)
                    {
                        // Write error.
                        Console.WriteLine(ex);
                    }
                    Window2 window2 = new Window2();
                    window2.ShowDialog();
                    break;
                case 3:
                    SoundPlayer My_JukeBox4 = new SoundPlayer(@"Sounds/item2.wav");
                    try
                    {
                        My_JukeBox4.Play();
                    }
                    catch (FileNotFoundException ex)
                    {
                        Console.WriteLine(ex);
                    }
                    MessageBox.Show(Personas.buscarPersonadeMenosPeso());
                    break;
                case 4:
                    SoundPlayer My_JukeBox5 = new SoundPlayer(@"Sounds/item2.wav");
                    try
                    {
                        My_JukeBox5.Play();
                    }
                    catch (FileNotFoundException ex)
                    {
                        Console.WriteLine(ex);
                    }
                    MessageBox.Show(Personas.buscarPersonadeMasAltura());
                    break;
                case 5:
                    SoundPlayer My_JukeBox6 = new SoundPlayer(@"Sounds/ded.wav");
                    try
                    {
                        My_JukeBox6.Play();
                    }
                    catch (FileNotFoundException ex)
                    {
                        Console.WriteLine(ex);
                    }
                    Task.Delay(3500).Wait();
                    this.Close();
                    break;

            }
            


            /* for (int i = 0; i < personajes.GetPersonas().Count; i++)
             {

                 texto.Text += personajes.buscarPersona(i);

             }*/
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {


            for (int i = 0; i < Personas.GetPersonas().Count; i++)
            {

                texto.Text += Personas.buscarPersonaPorIndex(i);

            }
        }
    }
    static class Personas
    {
        private static List<Persona> personas = new List<Persona>();

        public static List<Persona> GetPersonas()
        {
            return personas;
        }

        public static void SetPersonas(List<Persona> value)
        {
            personas = value;
        }

        public static string buscarPersonaPorDNI(string dni)
        {
            for (int i = 0; i < Personas.GetPersonas().Count; i++)
            {

                if (personas[i].Dni == dni)
                {
                    SoundPlayer My_JukeBox = new SoundPlayer(@"Sounds/item.wav");
                    try
                    {
                        My_JukeBox.Play();
                    }
                    catch (FileNotFoundException ex)
                    {
                        // Write error.
                        Console.WriteLine(ex);
                    }
                    return personas[i].ToString();
                }
               
            }
            SoundPlayer My_JukeBox2 = new SoundPlayer(@"Sounds/nope.wav");
            try
            {
                My_JukeBox2.Play();
            }
            catch (FileNotFoundException ex)
            {
                // Write error.
                Console.WriteLine(ex);
            }
            return "No se ha encontrado una persona con ese DNI";
        }

        public static string buscarPersonadeMenosPeso()
        {
            Persona max = new Persona("","","","",1000000,0);
            for (int i = 0; i < Personas.GetPersonas().Count; i++)
            {
                if (personas[i].Peso < max.Peso)
                {
                    max = personas[i];
                }
            }

            return max.ToString();
        }

        public static string buscarPersonadeMasAltura()
        {
            Persona max = new Persona("", "", "", "", 0, 0);
            for (int i = 0; i < Personas.GetPersonas().Count; i++)
            {
                if (personas[i].Altura > max.Altura)
                {
                    max = personas[i];
                }
            }

            return max.ToString();
        }

        public static string buscarPersonaPorIndex(int i)
        {
            return personas[i].ToString();
        }

        public static void addPersona(Persona persona)
        {
            if (persona != null)
            {
                GetPersonas().Add(persona);
            }
        }
    }


    [Serializable]
    class Persona
    {

        private string nombre;
        private string apellido1;
        private string dni;
        private string fechanac;
        private int peso;
        private int altura;

        public Persona()
        {

        }

        public Persona( string nombre, string apellido1, string dni, string fechanac, int peso, int altura)
        {
            
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.dni = dni;           
            this.fechanac = fechanac;
            this.peso = peso;
            this.altura = altura;
        }

        public string Nombre
        {
            get => nombre;
        }

        public string Dni
        {
            get => dni;
        }

        public int Peso
        {
            get => peso;
            set
            {
                if (peso >= 0)
                {
                    peso = value;
                }

                peso = 0;
            }
        }

        public int Altura
        {
            get => altura;
            set
            {
                if (altura >= 0)
                {
                    altura = value;
                }

                peso = 0;
            }
        }


        public override string ToString()
        {
            return nombre + " " + apellido1 + " " + '\n' +
                    "DNI: " + dni + '\n' +
                    "Fecha Nacimiento: " + fechanac + '\n' +
                    "Peso: " + peso + '\n' +
                    "Altura: " + altura + '\n';
        }
    }
}
