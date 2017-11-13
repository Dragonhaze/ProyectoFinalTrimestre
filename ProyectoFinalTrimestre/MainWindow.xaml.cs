
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

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

       

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            int opcion = Combobox1.SelectedIndex;



            switch (opcion)
            {
                case 0:
                    Window1 window = new Window1();

                    window.ShowDialog();
                    break;

                case 1:
                    MessageBox.Show("Opcion2");
                    break;
                case 2:
                    MessageBox.Show("Opcion3");
                    break;
                case 3:
                    MessageBox.Show("Opcion3");
                    break;
                case 4:
                    MessageBox.Show("Opcion3");
                    break;
                case 5:
                    MessageBox.Show("Opcion3");
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

                texto.Text += Personas.buscarPersona(i);

            }
        }
    }
    static class Personas
    {
        private static ArrayList personas = new ArrayList();

        public static ArrayList GetPersonas()
        {
            return personas;
        }

        public static void SetPersonas(ArrayList value)
        {
            personas = value;
        }

        public static string buscarPersona(int i)
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
