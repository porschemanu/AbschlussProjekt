using BibTool.Data.Context;
using BibTool.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Validations;

namespace BibTool.API.Services.BookService
{
    public class BookService : IBookService
    {
        private readonly BibToolContext context;

        public BookService(BibToolContext context)
        {
            this.context = context;
        }

        public async Task<Book?> CreateBook(Book book)
        {



            var author = book.Author;






            try
            {
                context.Add(book);
                context.Authors.Attach(author);
                await context.SaveChangesAsync();
            }
            catch(DbUpdateException e)
            {
                return null;
            }

            return book;
        }

        public Task<Book?> DeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Book?> ReadBook(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Book>> ReadBooks()
        {
            var books = await context.Books.ToListAsync();
            return books;
        }

        public Task<Book?> UpdateBook(int id, Book book)
        {
            throw new NotImplementedException();
        }
    }
}
