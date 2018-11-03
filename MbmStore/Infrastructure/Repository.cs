using MbmStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Infrastructure
{
    public static class Repository
    {
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();
        // Definerer listerne til produkter og fakturaer

        static Repository()
        {
            Book harrypotter1 = new Book(1, "J.K. Rowling", "Harry Potter and the Philosopher's Stone", 100, "Bloomsbury", 1997, "0-7475-3269-9", "thephilosophersstone.jpg");
            harrypotter1.Category = "Book";
            Book lordoftherings1 = new Book(2, "J.R.R. Tolkien", "The Fellowship of the Ring", 150, "George Allen & Unwin", 1954, "0-345-24032-4", "thefellowship.jpg");
            lordoftherings1.Category = "Book";
            Book gameofthrones1 = new Book(3, "George R.R. Martin", "A Game of Thrones", 120, "Bantam Spectra", 1996, "0-553-10354-7", "agameofthrones.jpg");
            gameofthrones1.Category = "Book";
            // Definerer nogle bøger med deres properties

            MusicCD metallica1 = new MusicCD(4, "Metallica", "Metallica", 100, 1991, "metallica.jpg");
            metallica1.Category = "Music CD";
            MusicCD acdc1 = new MusicCD(5, "AC/DC", "Highway to Hell", 170, 1979, "highwaytohell.jpg");
            acdc1.Category = "Music CD";
            MusicCD redhotchilipeppers1 = new MusicCD(6, "Red Hot Chili Peppers", "Californication", 180, 1999, "californication.jpg");
            redhotchilipeppers1.Category = "Music CD";
            // Definerer nogle cd'er med deres properties

            Track metallica01 = new Track("Enter Sandman", "Hammett, Ulrich, Hetfield", new TimeSpan(0, 5, 34));
            Track metallica02 = new Track("Sad But True", "Ulrich, Hetfield", new TimeSpan(0, 5, 24));
            Track metallica03 = new Track("Holier Than Thou", "Hetfield, Ulrich", new TimeSpan(0, 3, 48));

            Track highway1 = new Track("Highway to Hell", "Angus Young, Malcolm Young, Bon Scott", new TimeSpan(0, 3, 29));
            Track highway2 = new Track("Girls Got Rhythm", "Angus Young, Malcolm Young, Bon Scott", new TimeSpan(0, 3, 24));
            Track highway3 = new Track("Walk All Over You", "Angus Young, Malcolm Young, Bon Scott", new TimeSpan(0, 5, 10));

            Track californication1 = new Track("Around the World", "Flea, John Frusciante, Anthony Kiedis, Chad Smith", new TimeSpan(0, 3, 58));
            Track californication2 = new Track("Californication", "Flea, John Frusciante, Anthony Kiedis, Chad Smith", new TimeSpan(0, 5, 21));
            Track californication3 = new Track("Easily", "Flea, John Frusciante, Anthony Kiedis, Chad Smith", new TimeSpan(0, 3, 51));
            // Definerer nogle numre med deres properties

            Movie thegodfather = new Movie(7, "The Godfather", 100, "thegodfather.jpg", "Francis Ford Coppola");
            thegodfather.Category = "Movie";
            Movie thematrix = new Movie(8, "The Matrix", 100, "thematrix.jpg", "The Wachowski Brothers");
            thematrix.Category = "Movie";
            Movie forrestgump = new Movie(9, "Forrest Gump", 100, "forrestgump.jpg", "Robert Zemeckis");
            forrestgump.Category = "Movie";
            // Definerer nogle film med deres properties

            Products.Add(harrypotter1);
            Products.Add(lordoftherings1);
            Products.Add(gameofthrones1);

            Products.Add(metallica1);
            Products.Add(acdc1);
            Products.Add(redhotchilipeppers1);

            Products.Add(thegodfather);
            Products.Add(thematrix);
            Products.Add(forrestgump);

            metallica1.addTrack(metallica01);
            metallica1.addTrack(metallica02);
            metallica1.addTrack(metallica03);

            acdc1.addTrack(highway1);
            acdc1.addTrack(highway2);
            acdc1.addTrack(highway3);

            redhotchilipeppers1.addTrack(californication1);
            redhotchilipeppers1.addTrack(californication2);
            redhotchilipeppers1.addTrack(californication3);
            // Indsætter produkterne i de forskellige lister, som de tilhører

            Customer customer1 = new Customer(1, "Peter", "Petersen", "Petersvej, 12", "1220", "Petersby", new DateTime(1991, 11, 22));
            Customer customer2 = new Customer(2, "Rasmus", "Rasmussen", "Rasmussvej, 24", "2440", "Rasmussby", new DateTime(1992, 02, 08));
            // Definerer et par kunder med deres properties

            Invoice invoice1 = new Invoice(1, new DateTime(2011, 01, 01), customer1);
            Invoice invoice2 = new Invoice(1, new DateTime(2012, 02, 02), customer2);
            // Definerer nogle fakturaer med deres properties

            OrderItem orderitem1 = new OrderItem(harrypotter1, 2);
            OrderItem orderitem2 = new OrderItem(metallica1, 1);
            OrderItem orderitem3 = new OrderItem(gameofthrones1, 1);
            OrderItem orderitem4 = new OrderItem(lordoftherings1, 1);
            OrderItem orderitem5 = new OrderItem(forrestgump, 2);
            // Definerer orderne med de forskellige produkter og antallet af dem

            invoice1.AddOrderItem(orderitem1);
            invoice1.AddOrderItem(orderitem2);

            invoice2.AddOrderItem(orderitem3);
            invoice2.AddOrderItem(orderitem4);
            invoice2.AddOrderItem(orderitem5);
            // Tilføjer orderne til de forskellige fakturaer

            Invoices.Add(invoice1);
            Invoices.Add(invoice2);
            // Tilføjer fakturaerne til faktura listen
        }
    }
}
