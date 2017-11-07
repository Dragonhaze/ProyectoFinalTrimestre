
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
   /* public partial class MainWindow : Window
    {
        Personas personajes = new Personas();
        public MainWindow()
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
            string nombre, apellidos, dni, fechanac, role;
            char sexo;
            int peso = 0, altura = 0;

            nombre = textbox1.Text;
            apellidos = textbox2.Text;
            dni = textbox3.Text;

            if (radio1.IsChecked == true)
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
            }

            fechanac = date.Text;
            if (!String.IsNullOrEmpty(textbox5.Text))
            {
                peso = Convert.ToInt32(textbox5.Text);
            }
            if (!String.IsNullOrEmpty(textbox6.Text))
            {
                altura = Convert.ToInt32(textbox6.Text);
            }

            role = rol.Text;

            Persona persona = new Persona(role, nombre, apellidos, "", dni, sexo, fechanac, peso, altura);

            personajes.addPersona(persona);

            MessageBox.Show("Has metido a " + persona.Nombre + " en el array.");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {


            for (int i = 0; i < personajes.GetPersonas().Count; i++)
            {

                texto.Text += personajes.buscarPersona(i);

            }
        }
    }
    class Personas
    {
        private ArrayList personas;





        public Personas() => this.SetPersonas(new ArrayList());

        public ArrayList GetPersonas()
        {
            return personas;
        }

        public void SetPersonas(ArrayList value)
        {
            personas = value;
        }

        public string buscarPersona(int i)
        {
            return personas[i].ToString();
        }

        public void addPersona(Persona persona)
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

        private string rol;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private string dni;
        private char sexo;
        private string fechanac;
        private int peso;
        private int altura;

        public Persona()
        {

        }

        public Persona(string rol, string nombre, string apellido1, string apellido2, string dni, char sexo, string fechanac, int peso, int altura)
        {
            this.rol = rol;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.dni = dni;
            this.sexo = sexo;
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
            return nombre + " " + apellido1 + " " + apellido2 + '\n' +
                    "Rol: " + rol + '\n' +
                    "DNI: " + dni + '\n' +
                    "Sexo: " + sexo + '\n' +
                    "Fecha Nacimiento: " + fechanac + '\n' +
                    "Peso: " + peso + '\n' +
                    "Altura: " + altura + '\n';
        }
    }*/
}
