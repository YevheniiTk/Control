using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceControl
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book>() {
                                            new Book() {Name = "Some book LINQ", Year =1996, Author ="Author1"},
                                            new Book() {Name = "2", Year =1994, Author ="Author2"},
                                            new Book() {Name = "3", Year =1998, Author ="Author3"},
                                            new Book() {Name = "Book LINQ", Year =2000, Author ="Author1"},
                                            new Book() {Name = "2", Year =1994, Author ="Author2"},
                                            new Book() {Name = "3", Year =1998, Author ="Author1"},
                                            new Book() {Name = "LINQ", Year =2004, Author ="Author1"},
                                            new Book() {Name = "2", Year =1994, Author ="Author2"},
                                            new Book() {Name = "3", Year =1998, Author ="Author1"}
                                         };

            int[] numbers = { 12, 11, 18, 10, 51, 51, 17, 21, 29, 34, 31, 39, 38 };

            string inRussian = "Aыакпкупцпып фцаы";

            var book = books.Where(_ => _.Name.Contains("LINQ"))
                            .Where(_ => _.Year % 4 == 0)
                            .ToList();

            var countChar = inRussian.Select(_ => _)
                                     .Distinct()
                                     .Where(_ => _ != ' ')
                                     .Count();
            
            var sortedNumbers = numbers.OrderBy(_ => _ / 10)
                                       .ThenByDescending(_ => _ % 10)
                                       .ToList();

            var countBooksPreAuthor = books.GroupBy(_ => _.Author)
                                           .Select(_ => $"{_.Key}, {_.Count()} ")
                                           .ToList();
        }
    }
}
