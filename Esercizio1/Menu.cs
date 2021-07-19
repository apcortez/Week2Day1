using System;

namespace Esercizio1
{   
    internal class Menu
    { //•inserire un nuovo libro(verificando, tramite il codice ISBN, che non ci sia già)
      //•eliminare un libro
      //•visualizzare tutti i libri
      //•visualizzare i libri per genere
        internal static void Start()
        {
            char scelta;
            do
            {
                Console.WriteLine("Benvenuto! Scegli l'operazione da fare:");
            Console.WriteLine("1 - Aggiungi un libro");
            Console.WriteLine("2 - Elimina un libro");
            Console.WriteLine("3 - Visualizza tutti i libri in magazzino");
            Console.WriteLine("4 - Visualizza i libri per genere");
            Console.WriteLine("0 - Per uscire");
           

                scelta = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
                switch (scelta)
                {
                    case '1':
                        //aggiungi libro
                        AddNewBook();
                        break;
                    case '2':
                        RemoveBook();
                        break;
                    case '3':
                        ViewBook();
                        break;
                    case '4':
                        ViewBookGenere();
                        break;
                    case '0':
                        return;
                    default:
                        Console.WriteLine("Scelta non valida");
                        break;
                }
            } while (scelta != '0');
            Console.WriteLine("\n");
        }

        private static void ViewBookGenere()
        {
            
            //inserire  genere
            GenereEnum genere = BookManager.getGenere();
            BookManager.View(genere);
        }

        private static void ViewBook()
        {
            BookManager.View();
        }

        private static void RemoveBook()
        {
            string isbn;
            do
            {
                Console.WriteLine("Inserisci il codice ISBN  del libro da rimuovere(10 cifre): ");
                isbn = Console.ReadLine();
            } while (isbn.Length != 10);

          
            Book bookToFind = BookManager.GetByIsbn(isbn);
            if (bookToFind != null)
            {
                BookManager.removeBook(bookToFind);
            }
            else
            {
                Console.WriteLine("Errore! Il libro non è stato trovato.");
            }
        }

        private static void AddNewBook()
        {
            string isbn, titolo, autore;
            double prezzo;
           
            do 
            {
                Console.WriteLine("Inserisci il codice ISBN (10 cifre): ");
                isbn = Console.ReadLine();
            } while (isbn.Length != 10);

            //se esista già un libre con questo codice ISBN segnalalo
            //altrimenti chiedi autore, titolo, prezzo, genere
            Book bookToFind = BookManager.GetByIsbn(isbn);
            if(bookToFind == null)
            {
                //inserire titolo 
                do
                {
                    Console.WriteLine("Inserisci il titolo: ");
                    titolo = Console.ReadLine();

                } while (titolo.Length == 0);

                //inserire autore
                do
                {
                    Console.WriteLine("Inserisci il autore: ");
                    
                    autore = Console.ReadLine();

                } while (autore.Length == 0);

                //inserire prezzo
                Console.WriteLine("Inserire il prezzo del libro:");
                while(!double.TryParse(Console.ReadLine(), out prezzo) || prezzo<0 )
                {
                    Console.WriteLine("Devi inserire un prezzo valido. Riprova");
                }

                //inserire  genere
                GenereEnum genere = BookManager.getGenere();

                BookManager.addBook(isbn, titolo, autore, prezzo, genere);
            }
            else
            {
                Console.WriteLine("Libro già nel magazzino");
            }
        }
    }
}