using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1
{
    class BookManager
    {
        static List<Book> books = new List<Book>();
        //Dictionary<string, Book> books2 = new Dictionary<string Book>();

        internal static Book GetByIsbn(string isbn)
        {
            foreach(Book book in books)
            {
                if(book.ISBN == isbn)
                {
                    return book;
                }
            }
            return null;
        }

        internal static GenereEnum getGenere()
        {
            Console.WriteLine($"Premi {(int)GenereEnum.COMMEDIA} per scegliere {GenereEnum.COMMEDIA}");
            Console.WriteLine($"Premi {(int)GenereEnum.HORROR} per scegliere {GenereEnum.HORROR}");
            Console.WriteLine($"Premi {(int)GenereEnum.FANTASY} per scegliere {GenereEnum.FANTASY}");
            Console.WriteLine($"Premi {(int)GenereEnum.ROMANTICO} per scegliere {GenereEnum.ROMANTICO}");
            int g;
            while(!int.TryParse(Console.ReadLine(), out g)|| g<0 || g > 4)
            {
                Console.WriteLine("Devi inserire un genere valido. Riprova: ");
            }
            return (GenereEnum)g;
        }

        internal static void addBook(string isbn, string titolo, string autore, double prezzo, GenereEnum genere)
        {
            Book book = new Book(isbn, titolo, autore, prezzo, genere);
            books.Add(book);
            Console.WriteLine($"Il libro con ISBN {isbn} e titolo {titolo} è stato aggiunto nella libreria");
        }

        internal static void removeBook(Book bookToFind)
        {
            books.Remove(bookToFind);
            Console.WriteLine($"Libro con ISBN {bookToFind.ISBN} è stato rimosso con successo\n");
        }

        internal static void View(GenereEnum genere)
        {
            Console.WriteLine($"Lista libri di genere {genere}");
            if (books != null)
            {
                foreach (Book book in books)
                {
                    if (book.Genere == genere)
                    {
                        Console.WriteLine(" ISBN: " + book.ISBN + " Titolo: " + book.Titolo + " Autore: " + book.Autore);
                    }
                }
            }
            else
            {
                Console.WriteLine("Non ci sono libri di questo genere");
            }
            Console.WriteLine("\n");
        }

        internal static void View()
        {
            if (books != null)
            {
                Console.WriteLine("***Lista Libri***");
                foreach (Book book in books)
                {
                    Console.WriteLine(" ISBN: " + book.ISBN + " Titolo: " + book.Titolo + " Autore: " + book.Autore);
                }
            }
            else { Console.WriteLine("Non ci sono libri nella libreria.");
            }
            Console.WriteLine("\n");

        }
    }
}
