using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace my_books.Model
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDBContext>();

                if(!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {

                        Title = "Title1",
                        Description = "Description1",
                        IsRead = "true",
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate=4,
                        Genre="Biography",
                        Author="First Author",
                        CoverUrl="https...",
                        DateAdded=DateTime.Now

                    }, new Book()
                    {

                        Title = "Title2",
                        Description = "Description2",
                        IsRead = "false",
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    },
                    new Book()
                    {

                        Title = "Title3",
                        Description = "Description3",
                        IsRead = "true",
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    }, new Book()
                    {

                        Title = "Title4",
                        Description = "Description4",
                        IsRead = "false",
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    },
                    new Book()
                    {

                        Title = "Title1",
                        Description = "Description1",
                        IsRead = "true",
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    }, new Book()
                    {

                        Title = "Title2",
                        Description = "Description2",
                        IsRead = "false",
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    },
                    new Book()
                    {

                        Title = "Title3",
                        Description = "Description3",
                        IsRead = "true",
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    }, new Book()
                    {

                        Title = "Title4",
                        Description = "Description4",
                        IsRead = "false",
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    },
                    new Book()
                    {

                        Title = "Title1",
                        Description = "Description1",
                        IsRead = "true",
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    }, new Book()
                    {

                        Title = "Title2",
                        Description = "Description2",
                        IsRead = "false",
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    },
                    new Book()
                    {

                        Title = "Title3",
                        Description = "Description3",
                        IsRead = "true",
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    }, new Book()
                    {

                        Title = "Title4",
                        Description = "Description4",
                        IsRead = "false",
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    },
                    new Book()
                    {

                        Title = "Title1",
                        Description = "Description1",
                        IsRead = "true",
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    }, new Book()
                    {

                        Title = "Title2",
                        Description = "Description2",
                        IsRead = "false",
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    },
                    new Book()
                    {

                        Title = "Title3",
                        Description = "Description3",
                        IsRead = "true",
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    }, new Book()
                    {

                        Title = "Title4",
                        Description = "Description4",
                        IsRead = "false",
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    },
                    new Book()
                    {

                        Title = "Title1",
                        Description = "Description1",
                        IsRead = "true",
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    }, new Book()
                    {

                        Title = "Title2",
                        Description = "Description2",
                        IsRead = "false",
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    },
                    new Book()
                    {

                        Title = "Title3",
                        Description = "Description3",
                        IsRead = "true",
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    }, new Book()
                    {

                        Title = "Title4",
                        Description = "Description4",
                        IsRead = "false",
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    },
                    new Book()
                    {

                        Title = "Title1",
                        Description = "Description1",
                        IsRead = "true",
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    }, new Book()
                    {

                        Title = "Title2",
                        Description = "Description2",
                        IsRead = "false",
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    },
                    new Book()
                    {

                        Title = "Title3",
                        Description = "Description3",
                        IsRead = "true",
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    }, new Book()
                    {

                        Title = "Title4",
                        Description = "Description4",
                        IsRead = "false",
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    },
                    new Book()
                    {

                        Title = "Title1",
                        Description = "Description1",
                        IsRead = "true",
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    }, new Book()
                    {

                        Title = "Title2",
                        Description = "Description2",
                        IsRead = "false",
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    },
                    new Book()
                    {

                        Title = "Title3",
                        Description = "Description3",
                        IsRead = "true",
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    }, new Book()
                    {

                        Title = "Title4",
                        Description = "Description4",
                        IsRead = "false",
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    },
                    new Book()
                    {

                        Title = "Title1",
                        Description = "Description1",
                        IsRead = "true",
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    }, new Book()
                    {

                        Title = "Title2",
                        Description = "Description2",
                        IsRead = "false",
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    },
                    new Book()
                    {

                        Title = "Title3",
                        Description = "Description3",
                        IsRead = "true",
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    }, new Book()
                    {

                        Title = "Title4",
                        Description = "Description4",
                        IsRead = "false",
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now

                    }


                    ); ;

                    context.SaveChanges();
                }
            }
        }
    }
}
