using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace markoGalavićXMLforma
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBoxIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrezime_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRazred_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUnos1_Click(object sender, EventArgs e)
        {
            public static List<Osoba> CreateList()
            {
                List<Osoba> ListaOsoba = new List<Osoba>
            {
                new Osoba
                {
                    Ime = textBoxIme
                    Prezime = textBoxPrezime
                    EmailAdresa = textBoxEmail
                    Razred = textBoxRazred
                },
                new Osoba
                {
                    Ime = textBoxIme
                    Prezime = textBoxPrezime
                    EmailAdresa = textBoxEmail
                    Razred = textBoxRazred
                },
                new Osoba
                {
                     Ime = textBoxIme
                    Prezime = textBoxPrezime
                    EmailAdresa = textBoxEmail
                    Razred = textBoxRazred
                },
                new Osoba
                {
                    Ime = textBoxIme
                    Prezime = textBoxPrezime
                    EmailAdresa = textBoxEmail
                    Razred = textBoxRazred
                },
                new Osoba
                {
                    Ime = textBoxIme
                    Prezime = textBoxPrezime
                    EmailAdresa = textBoxEmail
                    Razred = textBoxRazred
                },
                new Osoba
                {
                     Ime = textBoxIme
                    Prezime = textBoxPrezime
                    EmailAdresa = textBoxEmail
                    Razred = textBoxRazred
                },
                new Osoba
                {
                     Ime = textBoxIme
                    Prezime = textBoxPrezime
                    EmailAdresa = textBoxEmail
                    Razred = textBoxRazred
                },
                
            };
                return ListaKlijenata;
            }
    
    

        private void buttonZavrsi1_Click(object sender, EventArgs e)
        {
            Form2.Close();
        }
    }
}
