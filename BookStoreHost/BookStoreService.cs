using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BookStoreClessLibrary;

namespace BookStoreHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BookStoreService" in both code and config file together.
    public class BookStoreService : IBookStoreService
    {
        DataManager db = new DataManager();

        public List<Author> GetAuthors()
        {
            var authrs = db.authors.ToList();
            return authrs;
        }

        public List<Genre> GetGenres()
        {
            var gnrs = db.genres.ToList();
            return gnrs;
        }

        public List<Book> GetBooks()
        {
            var bks = db.books.ToList();
            return bks;
        }

        public List<Book> SelectBooksByParameters(string genrs = "", string author = "")
        {
            
            if (genrs != "" && author == "")
            {
                var gnrID = db.genres.FirstOrDefault(d => d.Name == genrs).Id;

                var FoundBook = db.books.Where(b => b.Genre_Id == gnrID).ToList();

                if (FoundBook.Count > 0)
                    return FoundBook;
                else
                    throw new Exception("No data");
            }
            if(genrs == "" && author != "")
            {
                var aid = db.authors.FirstOrDefault(b => b.Name == author).Id;

                var FoundAuthor = db.books.Where(a => a.Author_Id == aid).ToList();

                return FoundAuthor;
            }
            if(genrs != "" && author != "")
            {
                var gnrID = db.genres.FirstOrDefault(d => d.Name == genrs).Id;
                var aid = db.authors.FirstOrDefault(d => d.Name == author).Id;
                var FoundAuthorAndGenre = (from p in db.books
                                          where p.Author_Id == aid
                                          && p.Genre_Id == gnrID
                                          select p).ToList();
                return FoundAuthorAndGenre; 
            }
            return null;
        }
    }
}
