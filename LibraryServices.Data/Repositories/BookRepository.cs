﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryServices.Data.Interfaces;
using LibraryServices.Models;

namespace LibraryServices.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        public List<Book> Books = new List<Book>
        {
            new Book {Id = 0, Title = "The Hitchhiker's Guide to the Galaxy", Author = "Douglas Adams", PublicationYear = 1979, CallNumber = "001-0001", IsAvailable = true},
            new Book {Id = 1, Title = "The Restaurant at the End of the World", Author = "Douglas Adams", PublicationYear = 1980, CallNumber = "001-0002", IsAvailable = true},
            new Book {Id = 2, Title = "Life, the Universe and Everything", Author = "Douglas Adams", PublicationYear = 1982, CallNumber = "001-0003", IsAvailable = false},
            new Book {Id = 3, Title = "So long and thanks for all the fish", Author = "Douglas Adams", PublicationYear = 1984, CallNumber = "001-0004", IsAvailable = false},
            new Book {Id = 4, Title = "Mostly Harmless", Author = "Douglas Adams", PublicationYear = 1992, CallNumber = "001-0005", IsAvailable = true},
        };

        public List<Book> GetAllBooks()
        {
            return Books;
        }

        public Book GetBook(int id)
        {
            var book = Books.FirstOrDefault(x => x.Id == id);
            return book;
        }
    }
}