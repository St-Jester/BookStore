using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStoreClessLibrary;
using System.ServiceModel;
namespace BookStoreHost
{
    public partial class AdminConsole : Form
    {
        DataManager db = new DataManager();
        ServiceHost host;
        public AdminConsole()
        {
            InitializeComponent();
            bool exists = (from p in db.genres
                           select p).FirstOrDefault() != null;
            if(exists)
            {
                InstallGenresButton.Enabled = false;
                journal.Text += "Genres added \n" ;
            }
            exists = false;
            exists = (from p in db.authors
                      select p).FirstOrDefault() != null;
            if(exists)
            {
                InstallAuthorsButton.Enabled = false;
                journal.Text += "Authors added"+ "\n";

            }
            exists = false;
            exists = (from p in db.books
                      select p).FirstOrDefault() != null;
            if (exists)
            {
                BookButton.Enabled = false;
                journal.Text += $"Books added \n";

                var gnrID = db.genres.FirstOrDefault(d => d.Name == "Fiction").Id;
                MessageBox.Show(gnrID.ToString());
                var aid = db.authors.FirstOrDefault(d => d.Name == "F. Scott Fitzgerald").Id;
                MessageBox.Show(aid.ToString());
                var FoundAuthorAndGenre = (from p in db.books
                                           where p.Author_Id == aid
                                           && p.Genre_Id == gnrID
                                           select p).ToList();
                foreach (var item in FoundAuthorAndGenre)
                {
                    journal.Text += item.Title;
                }

            }
        }

        private void InstallGenres()
        {
            Genre[] arr = new Genre[3]
            {
                new Genre() {Name = "Fiction" },
                new Genre() {Name = "Fantasy" },
                new Genre() {Name = "Dystopia" }
            };

            db.genres.AddRange(arr);
            db.SaveChanges();
                journal.Text += $"Genres added /n";

        }
        private void InstallAuthors()
        {
            
            Author[] arr = new Author[6]
            {
                new Author() {Name = "F. Scott Fitzgerald" },
                new Author() {Name = "George Orwell" },
                new Author() {Name = "J. R. R. Tolkien" },
                new Author() {Name = "Aldous Huxley" },
                new Author() {Name = "James Joyce" },
                new Author() {Name = "Harper Lee" }
            };

            db.authors.AddRange(arr);
            db.SaveChanges();
            journal.Text += $"Authors added \n";


        }

        private void AdminConsole_Load(object sender, EventArgs e)
        {
            host = new ServiceHost(typeof(BookStoreService));
            host.Open();
            journal.Text += $"{DateTime.Now.ToString()} started service \n";
        }

        private void AdminConsole_FormClosed(object sender, FormClosedEventArgs e)
        {
          if(host != null)
            {
                host.Close();
                journal.Text += $"{DateTime.Now.ToString()} stopped service \n";
            }
        }

        private void InstallGenresButton_Click(object sender, EventArgs e)
        {
            InstallGenresButton.Enabled = false;
            InstallGenres();
        }

        private void InstallAuthorsButton_Click(object sender, EventArgs e)
        {
            InstallAuthorsButton.Enabled = false;
            InstallAuthors();
        }

       
        private void BookButton_Click(object sender, EventArgs e)
        {
            BookButton.Enabled = false;
            InstallBooks();
        }

        private void InstallBooks()
        {
            Book[] books = new Book[8]
            {
               new Book(){Title = "The Great Gatsby", Author_Id = 1, Genre_Id = 1},
               new Book(){Title = "Nineteen Eighty-Four", Author_Id = 2, Genre_Id = 3},
               new Book(){Title = "Animal Farm: A Fairy Story", Author_Id = 2, Genre_Id = 3},
               new Book(){Title = "To Kill a Mockingbird", Author_Id = 6, Genre_Id = 1},
               new Book(){Title = "The Lord of the Rings", Author_Id = 3, Genre_Id = 2},
               new Book(){Title = "Hobbit", Author_Id = 3, Genre_Id = 2},
               new Book(){Title = "Brave New World", Author_Id = 4, Genre_Id = 3},
               new Book(){Title = "Ulysses", Author_Id = 5, Genre_Id = 1},
            };
            db.books.AddRange(books);
            db.SaveChanges();
            journal.Text += $"Books added \n";

            
             
        }
    }
}
