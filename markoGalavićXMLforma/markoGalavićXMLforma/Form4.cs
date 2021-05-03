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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonOdustani1_Click(object sender, EventArgs e)
        {
            Form4.Close();
        }

        private void buttonFiltriraj1_Click(object sender, EventArgs e)
        {
            var osoba_nestedQueries = from s in ListaOsoba
                                         where s.Email == "ic@email.com"
                                             (from std in standardList
                                              where std.Prezime == "Horvatin"
                                              select std.StandardID).FirstOrDefault()
                                         select s;

            nestedQueries.ToList().ForEach(s => Console.WriteLine(s.Ime));
        }
    }
}
