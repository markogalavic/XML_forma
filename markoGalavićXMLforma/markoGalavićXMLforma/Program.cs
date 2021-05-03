using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace markoGalavićXMLforma
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            List<Osoba> ListaOsoba = CreateList();

            var dokumentXmlKlijenti = new XDocument();
            var rootElem = new XElement("lista_klijenata");
            dokumentXmlKlijenti.Add(rootElem);
            foreach (Klijent_class customer in ListaKlijenata)
            {
                //Pravi novi element koji predstavlja svojstvo Ime
                var customerElem = new XElement("Klijent");

                //Dodaje element koji predstavlja svojstvo Ime za element customer
                var ImeElem = new XElement("Ime", customer.Ime);
                customerElem.Add(ImeElem);

                //Dodaje element koji predstavlja svojstvo Prezime za element customer
                var PrezimeElem = new XElement("Prezime", customer.Prezime);
                customerElem.Add(PrezimeElem);

                //Dodaje element koji predstavlja svojstvo EmailAdresa za element customer
                var EmailAdresa = new XElement("EmailAdress", customer.EmailAdresa);
                customerElem.Add(EmailAdresa);

                //Dodaje element customer u XML dokument
                rootElem.Add(customerElem);

            }
            Console.WriteLine(dokumentXmlKlijenti.ToString());
            Console.Read();
        }
    }
}
