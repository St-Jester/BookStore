﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookStoreClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IBookStoreService")]
    public interface IBookStoreService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookStoreService/GetGenres", ReplyAction="http://tempuri.org/IBookStoreService/GetGenresResponse")]
        BookStoreClessLibrary.Genre[] GetGenres();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookStoreService/GetGenres", ReplyAction="http://tempuri.org/IBookStoreService/GetGenresResponse")]
        System.Threading.Tasks.Task<BookStoreClessLibrary.Genre[]> GetGenresAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookStoreService/GetAuthors", ReplyAction="http://tempuri.org/IBookStoreService/GetAuthorsResponse")]
        BookStoreClessLibrary.Author[] GetAuthors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookStoreService/GetAuthors", ReplyAction="http://tempuri.org/IBookStoreService/GetAuthorsResponse")]
        System.Threading.Tasks.Task<BookStoreClessLibrary.Author[]> GetAuthorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookStoreService/GetBooks", ReplyAction="http://tempuri.org/IBookStoreService/GetBooksResponse")]
        BookStoreClessLibrary.Book[] GetBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookStoreService/GetBooks", ReplyAction="http://tempuri.org/IBookStoreService/GetBooksResponse")]
        System.Threading.Tasks.Task<BookStoreClessLibrary.Book[]> GetBooksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookStoreService/SelectBooksByParameters", ReplyAction="http://tempuri.org/IBookStoreService/SelectBooksByParametersResponse")]
        BookStoreClessLibrary.Book[] SelectBooksByParameters(string genrs, string author);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookStoreService/SelectBooksByParameters", ReplyAction="http://tempuri.org/IBookStoreService/SelectBooksByParametersResponse")]
        System.Threading.Tasks.Task<BookStoreClessLibrary.Book[]> SelectBooksByParametersAsync(string genrs, string author);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookStoreServiceChannel : BookStoreClient.ServiceReference1.IBookStoreService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BookStoreServiceClient : System.ServiceModel.ClientBase<BookStoreClient.ServiceReference1.IBookStoreService>, BookStoreClient.ServiceReference1.IBookStoreService {
        
        public BookStoreServiceClient() {
        }
        
        public BookStoreServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookStoreServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookStoreServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookStoreServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BookStoreClessLibrary.Genre[] GetGenres() {
            return base.Channel.GetGenres();
        }
        
        public System.Threading.Tasks.Task<BookStoreClessLibrary.Genre[]> GetGenresAsync() {
            return base.Channel.GetGenresAsync();
        }
        
        public BookStoreClessLibrary.Author[] GetAuthors() {
            return base.Channel.GetAuthors();
        }
        
        public System.Threading.Tasks.Task<BookStoreClessLibrary.Author[]> GetAuthorsAsync() {
            return base.Channel.GetAuthorsAsync();
        }
        
        public BookStoreClessLibrary.Book[] GetBooks() {
            return base.Channel.GetBooks();
        }
        
        public System.Threading.Tasks.Task<BookStoreClessLibrary.Book[]> GetBooksAsync() {
            return base.Channel.GetBooksAsync();
        }
        
        public BookStoreClessLibrary.Book[] SelectBooksByParameters(string genrs, string author) {
            return base.Channel.SelectBooksByParameters(genrs, author);
        }
        
        public System.Threading.Tasks.Task<BookStoreClessLibrary.Book[]> SelectBooksByParametersAsync(string genrs, string author) {
            return base.Channel.SelectBooksByParametersAsync(genrs, author);
        }
    }
}