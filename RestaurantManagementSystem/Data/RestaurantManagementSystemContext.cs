using Microsoft.EntityFrameworkCore;
using RestaurantManagementSystem.Models;

namespace RestaurantManagementSystem.Data
{
    public class RestaurantManagementSystemContext : DbContext
    {
        public RestaurantManagementSystemContext(DbContextOptions<RestaurantManagementSystemContext> options)
            : base(options){}

        public DbSet<Table> Tables { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<BookingTable> BookingTables { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<Role>().HasData
            (
                new Role { RoleId = 1, RoleName = "Admin" },
                new Role { RoleId = 2, RoleName = "Employee" },
                new Role { RoleId = 3, RoleName = "Customer" }
            );

            var customerPasswordHash = BCrypt.Net.BCrypt.HashPassword("customer123");
            var employeePasswordHash = BCrypt.Net.BCrypt.HashPassword("employee123");
            var adminPasswordHash = BCrypt.Net.BCrypt.HashPassword("admin123");

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    FirstName = "Admin",
                    LastName = "Istrator",
                    Email = "admin.istrator@thedot.com",
                    PhoneNumber = "+4670123456",
                    PasswordHash = adminPasswordHash,
                    RoleId = 1
                },
                new User
                {
                    UserId = 2,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@thedot.com",
                    PhoneNumber = "+4670123457",
                    PasswordHash = employeePasswordHash,
                    RoleId = 2
                },
                new User
                {
                    UserId = 3,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane.smith@thedot.com",
                    PhoneNumber = "+4670123458",
                    PasswordHash = employeePasswordHash,
                    RoleId = 2
                },
                new User
                {
                    UserId = 4,
                    FirstName = "James",
                    LastName = "Brown",
                    Email = "james.brown@thedot.com",
                    PhoneNumber = "+4670123459",
                    PasswordHash = employeePasswordHash,
                    RoleId = 2
                },
                new User
                {
                    UserId = 5,
                    FirstName = "Alice",
                    LastName = "Johnson",
                    Email = "alice.johnson@email.com",
                    PhoneNumber = "+4670123460",
                    PasswordHash = customerPasswordHash,
                    RoleId = 3
                },
                new User
                {
                    UserId = 6,
                    FirstName = "Bob",
                    LastName = "Williams",
                    Email = "bob.williams@email.com",
                    PhoneNumber = "+4670123461",
                    PasswordHash = customerPasswordHash,
                    RoleId = 3
                },
                new User
                {
                    UserId = 7,
                    FirstName = "Charlie",
                    LastName = "Miller",
                    Email = "charlie.miller@email.com",
                    PhoneNumber = "+4670123462",
                    PasswordHash = customerPasswordHash,
                    RoleId = 3
                },
                new User
                {
                    UserId = 8,
                    FirstName = "Diana",
                    LastName = "Davis",
                    Email = "diana.davis@email.com",
                    PhoneNumber = "+4670123463",
                    PasswordHash = customerPasswordHash,
                    RoleId = 3
                },
                new User
                {
                    UserId = 9,
                    FirstName = "Ethan",
                    LastName = "Wilson",
                    Email = "ethan.wilson@email.com",
                    PhoneNumber = "+4670123464",
                    PasswordHash = customerPasswordHash,
                    RoleId = 3
                },
                new User
                {
                    UserId = 10,
                    FirstName = "Fiona",
                    LastName = "Taylor",
                    Email = "fiona.taylor@email.com",
                    PhoneNumber = "+4670123465",
                    PasswordHash = customerPasswordHash,
                    RoleId = 3
                },
                new User
                {
                    UserId = 11,
                    FirstName = "George",
                    LastName = "Moore",
                    Email = "george.moore@email.com",
                    PhoneNumber = "+4670123466",
                    PasswordHash = customerPasswordHash,
                    RoleId = 3
                },
                new User
                {
                    UserId = 12,
                    FirstName = "Hannah",
                    LastName = "Anderson",
                    Email = "hannah.anderson@email.com",
                    PhoneNumber = "+4670123467",
                    PasswordHash = customerPasswordHash,
                    RoleId = 3
                },
                new User
                {
                    UserId = 13,
                    FirstName = "Ian",
                    LastName = "Thomas",
                    Email = "ian.thomas@email.com",
                    PhoneNumber = "+4670123468",
                    PasswordHash = customerPasswordHash,
                    RoleId = 3
                },
                new User
                {
                    UserId = 14,
                    FirstName = "Julia",
                    LastName = "Jackson",
                    Email = "julia.jackson@email.com",
                    PhoneNumber = "+4670123469",
                    PasswordHash = customerPasswordHash,
                    RoleId = 3
                }
            );

            modelBuilder.Entity<Menu>().HasData(
                new Menu
                {
                    MenuId = 1,
                    MenuName = "Appetizer"
                },
                new Menu
                {
                    MenuId = 2,
                    MenuName = "Main Courses"
                },
                new Menu
                {
                    MenuId = 3,
                    MenuName = "Dessert"
                }
            );

            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    DishId = 1,
                    DishName = "Caprese D'Oro",
                    Description = "A refined take on the classic Caprese, with creamy mozzarella, ripe heirloom tomatoes, and a drizzle of fragrant basil pesto.",
                    Price = 28.00m,
                    IsAvailable = true,
                    Popular = false,
                    MenuId = 1
                },
                new Dish
                {
                    DishId = 2,
                    DishName = "Carpaccio di Branzino",
                    Description = "A delicate seabass carpaccio served over crisp red cabbage slaw, garnished with pink peppercorns and a drizzle of citrus olive oil.",
                    Price = 42.00m,
                    IsAvailable = true,
                    Popular = false,
                    MenuId = 1
                },
                new Dish
                {
                    DishId = 3,
                    DishName = "Verdure alla Griglia",
                    Description = "A symphony of grilled vegetables, including zucchini, eggplant, and roasted peppers, drizzled with a delicate balsamic reduction.",
                    Price = 28.00m,
                    IsAvailable = true,
                    Popular = false,
                    MenuId = 1
                },
                new Dish
                {
                    DishId = 4,
                    DishName = "Tacos di Mare",
                    Description = "Crisp corn tortillas filled with a refreshing mix of lightly marinated seafood, cucumber slices, and vine-ripened tomatoes.",
                    Price = 36.00m,
                    IsAvailable = true,
                    Popular = false,
                    MenuId = 1
                },
                new Dish
                {
                    DishId = 5,
                    DishName = "Frittura di Calamari",
                    Description = "Crispy golden calamari, lightly battered and served with a zesty lemon aioli.",
                    Price = 22.00m,
                    IsAvailable = true,
                    Popular = true,
                    MenuId = 1
                },
                new Dish
                {
                    DishId = 6,
                    DishName = "Bruschetta al Pomodoro",
                    Description = "Grilled sourdough topped with juicy cherry tomatoes, basil, and a splash of extra virgin olive oil.",
                    Price = 16.00m,
                    IsAvailable = true,
                    Popular = false,
                    MenuId = 1
                },
                new Dish
                {
                    DishId = 7,
                    DishName = "Zuppa di Funghi",
                    Description = "A creamy wild mushroom soup garnished with truffle oil and freshly ground black pepper.",
                    Price = 20.00m,
                    IsAvailable = true,
                    Popular = true,
                    MenuId = 1
                },
                new Dish
                {
                    DishId = 8,
                    DishName = "Insalata di Rucola",
                    Description = "A simple and fresh arugula salad, tossed with shaved parmesan and a tangy lemon vinaigrette.",
                    Price = 18.00m,
                    IsAvailable = true,
                    Popular = false,
                    MenuId = 1
                },

                new Dish
                {
                    DishId = 9,
                    DishName = "Tagliolini Primavera",
                    Description = "Freshly made tagliolini pasta wrapped in a delicate creamy sauce, topped with succulent shrimp marinated in herbs and citrus.",
                    Price = 38.00m,
                    IsAvailable = true,
                    Popular = true,
                    MenuId = 2
                },
                new Dish
                {
                    DishId = 10,
                    DishName = "Gnocchi di Mare",
                    Description = "Soft, pillowy gnocchi paired with a fragrant seafood medley of clams, infused with garlic, white wine, and a touch of lemon.",
                    Price = 45.00m,
                    IsAvailable = true,
                    Popular = true,
                    MenuId = 2
                },
                new Dish
                {
                    DishId = 11,
                    DishName = "Pasta Tricolore",
                    Description = "A vibrant dish of fresh pasta mingling with sweet cherry tomatoes, tender tuna, and zesty oranges.",
                    Price = 42.00m,
                    IsAvailable = true,
                    Popular = true,
                    MenuId = 2
                },
                new Dish
                {
                    DishId = 12,
                    DishName = "Fritto Misto",
                    Description = "A lavish platter of lightly battered and fried seafood, featuring crispy prawns, calamari, and anchovies.",
                    Price = 48.00m,
                    IsAvailable = true,
                    Popular = false,
                    MenuId = 2
                },
                new Dish
                {
                    DishId = 13,
                    DishName = "Tris di Crudo",
                    Description = "A trio of hand-cut raw delicacies featuring buttery salmon, tender tuna, and delicate seabass, served with citrus and avocado cream.",
                    Price = 55.00m,
                    IsAvailable = true,
                    Popular = true,
                    MenuId = 2
                },
                new Dish
                {
                    DishId = 14,
                    DishName = "Tonno Dorato",
                    Description = "Exquisitely seared tuna wrapped in a crispy golden crust, set on a bed of julienned vegetables, and paired with a balsamic reduction.",
                    Price = 52.00m,
                    IsAvailable = true,
                    Popular = false,
                    MenuId = 2
                },
                new Dish
                {
                    DishId = 15,
                    DishName = "Alici Affumicate",
                    Description = "A gourmet open-faced tart with house-smoked anchovies, fennel, sun-dried tomatoes, and a hint of citrus zest.",
                    Price = 35.00m,
                    IsAvailable = true,
                    Popular = false,
                    MenuId = 2
                },
                new Dish
                {
                    DishId = 16,
                    DishName = "Tagliolini al Tartufo",
                    Description = "Luxuriously creamy tagliolini pasta adorned with fragrant shaved black truffles, offering an intense depth of flavor.",
                    Price = 65.00m,
                    IsAvailable = true,
                    Popular = true,
                    MenuId = 2
                },
                new Dish
                {
                    DishId = 17,
                    DishName = "Bistecca Fiorentina",
                    Description = "A succulent Florentine-style T-bone steak, grilled to perfection and served with crispy potato wedges.",
                    Price = 75.00m,
                    IsAvailable = true,
                    Popular = false,
                    MenuId = 2
                },
                new Dish
                {
                    DishId = 18,
                    DishName = "Risotto al Parmigiano",
                    Description = "Creamy Parmesan risotto topped with crispy kale and semi-dried tomatoes. A perfect blend of richness and texture that melts in your mouth.",
                    Price = 40.00m,
                    IsAvailable = true,
                    Popular = false,
                    MenuId = 2
                },
                new Dish
                {
                    DishId = 19,
                    DishName = "Paccheri al Pomodoro",
                    Description = "Handcrafted paccheri pasta enveloped in a luscious tomato basil sauce, with a garnish of fresh basil leaves.",
                    Price = 35.00m,
                    IsAvailable = true,
                    Popular = false,
                    MenuId = 2
                },
                new Dish
                {
                    DishId = 20,
                    DishName = "Carpaccio di Manzo",
                    Description = "Delicately sliced beef carpaccio topped with a golden-fried egg yolk and a hint of truffle mayo.",
                    Price = 58.00m,
                    IsAvailable = true,
                    Popular = false,
                    MenuId = 2
                },
                new Dish
                {
                    DishId = 21,
                    DishName = "Merluzzo con Funghi e Salicornia",
                    Description = "Perfectly seared cod fillet served with sautéed mushrooms and salty samphire, finished with a creamy white wine sauce.",
                    Price = 62.00m,
                    IsAvailable = true,
                    Popular = false,
                    MenuId = 2
                },
                new Dish
                {
                    DishId = 22,
                    DishName = "Rigatoni con Salsiccia",
                    Description = "Al dente rigatoni pasta tossed with savory Italian sausage and finished with crispy breadcrumbs and a sprinkle of chili threads.",
                    Price = 38.00m,
                    IsAvailable = true,
                    Popular = false,
                    MenuId = 2
                },
                new Dish
                {
                    DishId = 23,
                    DishName = "Tiramisù Classico",
                    Description = "Layers of espresso-soaked ladyfingers, rich mascarpone cream, and a dusting of fine cocoa powder.",
                    Price = 24.00m,
                    IsAvailable = true,
                    Popular = true,
                    MenuId = 3
                },
                new Dish
                {
                    DishId = 24,
                    DishName = "Panna Cotta al Limone",
                    Description = "A silky smooth lemon panna cotta, served with a raspberry coulis and candied lemon peel.",
                    Price = 22.00m,
                    IsAvailable = true,
                    Popular = true,
                    MenuId = 3
                },
                new Dish
                {
                    DishId = 25,
                    DishName = "Torta Caprese",
                    Description = "A flourless chocolate and almond cake, rich and moist, served with a dollop of vanilla mascarpone.",
                    Price = 26.00m,
                    IsAvailable = true,
                    Popular = false,
                    MenuId = 3
                },
                new Dish
                {
                    DishId = 26,
                    DishName = "Profiteroles al Cioccolato",
                    Description = "Light choux pastries filled with vanilla cream, drizzled with warm dark chocolate sauce.",
                    Price = 28.00m,
                    IsAvailable = true,
                    Popular = true,
                    MenuId = 3
                },
                new Dish
                {
                    DishId = 27,
                    DishName = "Cannoli Siciliani",
                    Description = "Crisp cannoli shells filled with sweet ricotta cream and garnished with pistachios and chocolate chips.",
                    Price = 20.00m,
                    IsAvailable = true,
                    Popular = false,
                    MenuId = 3
                },
                new Dish
                {
                    DishId = 28,
                    DishName = "Zabaglione con Fragole",
                    Description = "A delicate Italian custard served over fresh strawberries and topped with a sprinkling of shaved almonds.",
                    Price = 23.00m,
                    IsAvailable = true,
                    Popular = false,
                    MenuId = 3
                },
                new Dish
                {
                    DishId = 29,
                    DishName = "Gelato Artigianale",
                    Description = "Artisanal gelato in a variety of flavors, including pistachio, vanilla bean, and dark chocolate.",
                    Price = 14.00m,
                    IsAvailable = true,
                    Popular = false,
                    MenuId = 3
                },
                new Dish
                {
                    DishId = 30,
                    DishName = "Sorbetto al Limone",
                    Description = "A refreshing lemon sorbet, perfect for cleansing the palate after a rich meal.",
                    Price = 12.00m,
                    IsAvailable = true,
                    Popular = false,
                    MenuId = 3
                },
                new Dish
                {
                    DishId = 31,
                    DishName = "Affogato al Caffè",
                    Description = "A scoop of vanilla gelato 'drowned' in a shot of hot espresso, creating a simple yet luxurious treat.",
                    Price = 16.00m,
                    IsAvailable = true,
                    Popular = false,
                    MenuId = 3
                }
            );

            modelBuilder.Entity<Table>().HasData(
                new Table
                {
                    TableId = 1,
                    TableNumber = 1,
                    Seats = 4,
                    Description = "A corner table by the window with a view of the city skyline."
                },
                new Table
                {
                    TableId = 2,
                    TableNumber = 2,
                    Seats = 2,
                    Description = "Secluded near a bookshelf wall, perfect for an intimate dinner."
                },
                new Table
                {
                    TableId = 3,
                    TableNumber = 3,
                    Seats = 6,
                    Description = "Spacious table beneath a chandelier with views of the fountain."
                },
                new Table
                {
                    TableId = 4,
                    TableNumber = 4,
                    Seats = 4,
                    Description = "Cozy alcove near the wine cellar with a view of the sommelier."
                },
                new Table
                {
                    TableId = 5,
                    TableNumber = 5,
                    Seats = 2,
                    Description = "Window-side table with street views, perfect for a romantic dinner."
                },
                new Table
                {
                    TableId = 6,
                    TableNumber = 6,
                    Seats = 8,
                    Description = "Grand table at the heart of the restaurant, ideal for celebrations."
                },
                new Table
                {
                    TableId = 7,
                    TableNumber = 7,
                    Seats = 4,
                    Description = "Near the fireplace, offering a cozy, warm atmosphere for family dinners."
                },
                new Table
                {
                    TableId = 8,
                    TableNumber = 8,
                    Seats = 6,
                    Description = "On an elevated platform with a view of the entire restaurant."
                },
                new Table
                {
                    TableId = 9,
                    TableNumber = 9,
                    Seats = 2,
                    Description = "Near the piano, perfect for music lovers enjoying live performances."
                },
                new Table
                {
                    TableId = 10,
                    TableNumber = 10,
                    Seats = 4,
                    Description = "View of the open kitchen for those who enjoy watching the chefs at work."
                }
            );


        }
    }
}