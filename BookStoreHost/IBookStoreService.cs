using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BookStoreClessLibrary;
namespace BookStoreHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBookStoreService" in both code and config file together.
    [ServiceContract]
    public interface IBookStoreService
    {
        [OperationContract]
        List<Genre> GetGenres();

        [OperationContract]
        List<Author> GetAuthors();

        [OperationContract]
        List<Book> GetBooks();

        [OperationContract]
        List<Book> SelectBooksByParameters(string genrs = "", string author = "");
    }
}
