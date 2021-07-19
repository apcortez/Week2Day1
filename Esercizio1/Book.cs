using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1
{
    class Book
    {   public string ISBN { get; set; }
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public double Prezzo { get; set; }
        public GenereEnum Genere { get; set; }
        public Book()
        {

        }
        public Book(string ISBN, string Titolo, String Autore, double prezzo, GenereEnum Genere)
        {
            this.ISBN = ISBN;
            this.Titolo = Titolo;
            this.Autore = Autore;
            this.Genere = Genere;
        }
        
    }
    enum GenereEnum
    {
        COMMEDIA, HORROR, FANTASY, ROMANTICO
    }
}
