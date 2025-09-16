

using Task3;

    Author rect = new Author("John Doe", 45, "USA", 5);
                Console.WriteLine(rect.Introduce());
                Console.WriteLine($"Возраст после дня рождения: {rect.CelebrateBirthday()}");
                
                Book book1 = new Book("The Great Adventure", "Adventure", 300);
                Book book2 = new Book("Mystery of the Night", "Mystery", 250);
                
                rect.AddBook(book1);
                rect.AddBook(book2);

                Console.WriteLine("Список книг автора:");
                rect.ListBooks();