﻿using LibraryBackend.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryBackend.Services
{
    public class BookService : IBookService
    {
        private readonly LibraryBackendContext _context;
        private readonly ILogger _logger;

        public BookService(ILogger<BookService> logger, LibraryBackendContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task Add(Book book)
        {
            await _context.Book.AddAsync(book);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid Id)
        {
            var book = await Get(Id);

            _context.Book.Remove(book);

            await _context.SaveChangesAsync();
        }

        public async Task<Book> Get(Guid Id)
        {
            var book = await _context.Book.FindAsync(Id);
            return book;
        }

        public async Task<List<Book>> GetAll()
        {
            return await _context.Book.ToListAsync();
        }

        public async Task Update(Book NewBook)
        {
            var book = await Get(NewBook.Id);
            book.Id = NewBook.Id;
            book.Author = NewBook.Author;
            book.Publisher = NewBook.Publisher;
            book.YearOfPublication = NewBook.YearOfPublication;

            await _context.SaveChangesAsync();
        }
    }
}
