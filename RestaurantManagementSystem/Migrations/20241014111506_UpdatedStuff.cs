using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestaurantManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedStuff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 4,
                columns: new[] { "Description", "DishName", "MenuId", "Popular", "Price" },
                values: new object[] { "Crisp corn tortillas filled with a refreshing mix of lightly marinated seafood, cucumber slices, and vine-ripened tomatoes.", "Tacos di Mare", 1, false, 36.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 5,
                columns: new[] { "Description", "DishName", "MenuId", "Price" },
                values: new object[] { "Crispy golden calamari, lightly battered and served with a zesty lemon aioli.", "Frittura di Calamari", 1, 22.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 6,
                columns: new[] { "Description", "DishName", "MenuId", "Popular", "Price" },
                values: new object[] { "Grilled sourdough topped with juicy cherry tomatoes, basil, and a splash of extra virgin olive oil.", "Bruschetta al Pomodoro", 1, false, 16.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 7,
                columns: new[] { "Description", "DishName", "MenuId", "Popular", "Price" },
                values: new object[] { "A creamy wild mushroom soup garnished with truffle oil and freshly ground black pepper.", "Zuppa di Funghi", 1, true, 20.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 8,
                columns: new[] { "Description", "DishName", "MenuId", "Popular", "Price" },
                values: new object[] { "A simple and fresh arugula salad, tossed with shaved parmesan and a tangy lemon vinaigrette.", "Insalata di Rucola", 1, false, 18.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 9,
                columns: new[] { "Description", "DishName", "Price" },
                values: new object[] { "Freshly made tagliolini pasta wrapped in a delicate creamy sauce, topped with succulent shrimp marinated in herbs and citrus.", "Tagliolini Primavera", 38.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 10,
                columns: new[] { "Description", "DishName", "Popular", "Price" },
                values: new object[] { "Soft, pillowy gnocchi paired with a fragrant seafood medley of clams, infused with garlic, white wine, and a touch of lemon.", "Gnocchi di Mare", true, 45.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 11,
                columns: new[] { "Description", "DishName", "Price" },
                values: new object[] { "A vibrant dish of fresh pasta mingling with sweet cherry tomatoes, tender tuna, and zesty oranges.", "Pasta Tricolore", 42.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 12,
                columns: new[] { "Description", "DishName", "Price" },
                values: new object[] { "A lavish platter of lightly battered and fried seafood, featuring crispy prawns, calamari, and anchovies.", "Fritto Misto", 48.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 13,
                columns: new[] { "Description", "DishName", "Popular", "Price" },
                values: new object[] { "A trio of hand-cut raw delicacies featuring buttery salmon, tender tuna, and delicate seabass, served with citrus and avocado cream.", "Tris di Crudo", true, 55.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 14,
                columns: new[] { "Description", "DishName", "Price" },
                values: new object[] { "Exquisitely seared tuna wrapped in a crispy golden crust, set on a bed of julienned vegetables, and paired with a balsamic reduction.", "Tonno Dorato", 52.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 15,
                columns: new[] { "Description", "DishName", "Price" },
                values: new object[] { "A gourmet open-faced tart with house-smoked anchovies, fennel, sun-dried tomatoes, and a hint of citrus zest.", "Alici Affumicate", 35.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 16,
                columns: new[] { "Description", "DishName", "Popular", "Price" },
                values: new object[] { "Luxuriously creamy tagliolini pasta adorned with fragrant shaved black truffles, offering an intense depth of flavor.", "Tagliolini al Tartufo", true, 65.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 17,
                columns: new[] { "Description", "DishName", "Price" },
                values: new object[] { "A succulent Florentine-style T-bone steak, grilled to perfection and served with crispy potato wedges.", "Bistecca Fiorentina", 75.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 18,
                columns: new[] { "Description", "DishName", "MenuId", "Price" },
                values: new object[] { "Creamy Parmesan risotto topped with crispy kale and semi-dried tomatoes. A perfect blend of richness and texture that melts in your mouth.", "Risotto al Parmigiano", 2, 40.00m });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "DishId", "Description", "DishName", "IsAvailable", "MenuId", "Popular", "Price" },
                values: new object[,]
                {
                    { 19, "Handcrafted paccheri pasta enveloped in a luscious tomato basil sauce, with a garnish of fresh basil leaves.", "Paccheri al Pomodoro", true, 2, false, 35.00m },
                    { 20, "Delicately sliced beef carpaccio topped with a golden-fried egg yolk and a hint of truffle mayo.", "Carpaccio di Manzo", true, 2, false, 58.00m },
                    { 21, "Perfectly seared cod fillet served with sautéed mushrooms and salty samphire, finished with a creamy white wine sauce.", "Merluzzo con Funghi e Salicornia", true, 2, false, 62.00m },
                    { 22, "Al dente rigatoni pasta tossed with savory Italian sausage and finished with crispy breadcrumbs and a sprinkle of chili threads.", "Rigatoni con Salsiccia", true, 2, false, 38.00m },
                    { 23, "Layers of espresso-soaked ladyfingers, rich mascarpone cream, and a dusting of fine cocoa powder.", "Tiramisù Classico", true, 3, true, 24.00m },
                    { 24, "A silky smooth lemon panna cotta, served with a raspberry coulis and candied lemon peel.", "Panna Cotta al Limone", true, 3, true, 22.00m },
                    { 25, "A flourless chocolate and almond cake, rich and moist, served with a dollop of vanilla mascarpone.", "Torta Caprese", true, 3, false, 26.00m },
                    { 26, "Light choux pastries filled with vanilla cream, drizzled with warm dark chocolate sauce.", "Profiteroles al Cioccolato", true, 3, true, 28.00m },
                    { 27, "Crisp cannoli shells filled with sweet ricotta cream and garnished with pistachios and chocolate chips.", "Cannoli Siciliani", true, 3, false, 20.00m },
                    { 28, "A delicate Italian custard served over fresh strawberries and topped with a sprinkling of shaved almonds.", "Zabaglione con Fragole", true, 3, false, 23.00m },
                    { 29, "Artisanal gelato in a variety of flavors, including pistachio, vanilla bean, and dark chocolate.", "Gelato Artigianale", true, 3, false, 14.00m },
                    { 30, "A refreshing lemon sorbet, perfect for cleansing the palate after a rich meal.", "Sorbetto al Limone", true, 3, false, 12.00m },
                    { 31, "A scoop of vanilla gelato 'drowned' in a shot of hot espresso, creating a simple yet luxurious treat.", "Affogato al Caffè", true, 3, false, 16.00m }
                });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 1,
                column: "Description",
                value: "A corner table by the window with a view of the city skyline.");

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 2,
                column: "Description",
                value: "Secluded near a bookshelf wall, perfect for an intimate dinner.");

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 3,
                column: "Description",
                value: "Spacious table beneath a chandelier with views of the fountain.");

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 4,
                column: "Description",
                value: "Cozy alcove near the wine cellar with a view of the sommelier.");

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 5,
                column: "Description",
                value: "Window-side table with street views, perfect for a romantic dinner.");

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 6,
                column: "Description",
                value: "Grand table at the heart of the restaurant, ideal for celebrations.");

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 7,
                column: "Description",
                value: "Near the fireplace, offering a cozy, warm atmosphere for family dinners.");

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 8,
                column: "Description",
                value: "On an elevated platform with a view of the entire restaurant.");

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 9,
                column: "Description",
                value: "Near the piano, perfect for music lovers enjoying live performances.");

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 10,
                column: "Description",
                value: "View of the open kitchen for those who enjoy watching the chefs at work.");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$issytT5cbVCzA4EUkLOuZuqhmyQq9U9gkKOXLAbOOwMFzc9LVgKOO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$5JDpokuXCUKV0TVB1BD27us0N6mK570jfIiWgnz7Nt43NFGYmSSPy");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "PasswordHash",
                value: "$2a$11$5JDpokuXCUKV0TVB1BD27us0N6mK570jfIiWgnz7Nt43NFGYmSSPy");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "PasswordHash",
                value: "$2a$11$5JDpokuXCUKV0TVB1BD27us0N6mK570jfIiWgnz7Nt43NFGYmSSPy");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "PasswordHash",
                value: "$2a$11$VungrPK3INq5LqGtG4L8aePMBRTZrGApaSephKhpp2DGQUP4.FYk2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "PasswordHash",
                value: "$2a$11$VungrPK3INq5LqGtG4L8aePMBRTZrGApaSephKhpp2DGQUP4.FYk2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "PasswordHash",
                value: "$2a$11$VungrPK3INq5LqGtG4L8aePMBRTZrGApaSephKhpp2DGQUP4.FYk2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                column: "PasswordHash",
                value: "$2a$11$VungrPK3INq5LqGtG4L8aePMBRTZrGApaSephKhpp2DGQUP4.FYk2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                column: "PasswordHash",
                value: "$2a$11$VungrPK3INq5LqGtG4L8aePMBRTZrGApaSephKhpp2DGQUP4.FYk2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                column: "PasswordHash",
                value: "$2a$11$VungrPK3INq5LqGtG4L8aePMBRTZrGApaSephKhpp2DGQUP4.FYk2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                column: "PasswordHash",
                value: "$2a$11$VungrPK3INq5LqGtG4L8aePMBRTZrGApaSephKhpp2DGQUP4.FYk2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                column: "PasswordHash",
                value: "$2a$11$VungrPK3INq5LqGtG4L8aePMBRTZrGApaSephKhpp2DGQUP4.FYk2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                column: "PasswordHash",
                value: "$2a$11$VungrPK3INq5LqGtG4L8aePMBRTZrGApaSephKhpp2DGQUP4.FYk2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                column: "PasswordHash",
                value: "$2a$11$VungrPK3INq5LqGtG4L8aePMBRTZrGApaSephKhpp2DGQUP4.FYk2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 31);

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 4,
                columns: new[] { "Description", "DishName", "MenuId", "Popular", "Price" },
                values: new object[] { "Freshly made tagliolini pasta wrapped in a delicate creamy sauce, topped with succulent shrimp marinated in herbs and citrus.", "Tagliolini Primavera", 2, true, 38.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 5,
                columns: new[] { "Description", "DishName", "MenuId", "Price" },
                values: new object[] { "Soft, pillowy gnocchi paired with a fragrant seafood medley of clams, infused with garlic, white wine, and a touch of lemon.", "Gnocchi di Mare", 2, 45.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 6,
                columns: new[] { "Description", "DishName", "MenuId", "Popular", "Price" },
                values: new object[] { "A vibrant dish of fresh pasta mingling with sweet cherry tomatoes, tender tuna, and zesty oranges.", "Pasta Tricolore", 2, true, 42.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 7,
                columns: new[] { "Description", "DishName", "MenuId", "Popular", "Price" },
                values: new object[] { "A lavish platter of lightly battered and fried seafood, featuring crispy prawns, calamari, and anchovies.", "Fritto Misto", 2, false, 48.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 8,
                columns: new[] { "Description", "DishName", "MenuId", "Popular", "Price" },
                values: new object[] { "A trio of hand-cut raw delicacies featuring buttery salmon, tender tuna, and delicate seabass, served with citrus and avocado cream.", "Tris di Crudo", 2, true, 55.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 9,
                columns: new[] { "Description", "DishName", "Price" },
                values: new object[] { "Exquisitely seared tuna wrapped in a crispy golden crust, set on a bed of julienned vegetables, and paired with a balsamic reduction.", "Tonno Dorato", 52.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 10,
                columns: new[] { "Description", "DishName", "Popular", "Price" },
                values: new object[] { "A gourmet open-faced tart with house-smoked anchovies, fennel, sun-dried tomatoes, and a hint of citrus zest.", "Alici Affumicate", false, 35.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 11,
                columns: new[] { "Description", "DishName", "Price" },
                values: new object[] { "Luxuriously creamy tagliolini pasta adorned with fragrant shaved black truffles, offering an intense depth of flavor.", "Tagliolini al Tartufo", 65.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 12,
                columns: new[] { "Description", "DishName", "Price" },
                values: new object[] { "A succulent Florentine-style T-bone steak, grilled to perfection and served with crispy potato wedges.", "Bistecca Fiorentina", 75.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 13,
                columns: new[] { "Description", "DishName", "Popular", "Price" },
                values: new object[] { "Creamy Parmesan risotto topped with crispy kale and semi-dried tomatoes. A perfect blend of richness and texture that melts in your mouth.", "Risotto al Parmigiano", false, 40.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 14,
                columns: new[] { "Description", "DishName", "Price" },
                values: new object[] { "Handcrafted paccheri pasta enveloped in a luscious tomato basil sauce, with a garnish of fresh basil leaves.", "Paccheri al Pomodoro", 35.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 15,
                columns: new[] { "Description", "DishName", "Price" },
                values: new object[] { "Delicately sliced beef carpaccio topped with a golden-fried egg yolk and a hint of truffle mayo.", "Carpaccio di Manzo", 58.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 16,
                columns: new[] { "Description", "DishName", "Popular", "Price" },
                values: new object[] { "Perfectly seared cod fillet served with sautéed mushrooms and salty samphire, finished with a creamy white wine sauce.", "Merluzzo con Funghi e Salicornia", false, 62.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 17,
                columns: new[] { "Description", "DishName", "Price" },
                values: new object[] { "Al dente rigatoni pasta tossed with savory Italian sausage and finished with crispy breadcrumbs and a sprinkle of chili threads.", "Rigatoni con Salsiccia", 38.00m });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 18,
                columns: new[] { "Description", "DishName", "MenuId", "Price" },
                values: new object[] { "Crisp corn tortillas filled with a refreshing mix of lightly marinated seafood, cucumber slices, and vine-ripened tomatoes.", "Tacos di Mare", 3, 36.00m });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 1,
                column: "Description",
                value: "A corner table by the large bay window, offering a stunning view of the city skyline. The soft glow of candlelight enhances the cozy yet sophisticated ambiance.");

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 2,
                column: "Description",
                value: "Intimate and secluded, this table is tucked away near a bookshelf wall adorned with vintage books. Perfect for a private dinner with soft, warm lighting.");

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 3,
                column: "Description",
                value: "A spacious table set beneath an elegant chandelier, surrounded by velvet curtains. Ideal for group gatherings, with a luxurious feel and a commanding view of the restaurant’s centerpiece fountain.");

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 4,
                column: "Description",
                value: "Nestled in a cozy alcove near the wine cellar, this table offers a secluded, intimate dining experience with a rich, aromatic ambiance and a view of the sommelier at work.");

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 5,
                column: "Description",
                value: "A window-side table with a direct view of the streetlights and evening passersby. Enveloped in soft leather chairs, it's perfect for a romantic dinner with a touch of urban charm.");

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 6,
                column: "Description",
                value: "Positioned at the heart of the restaurant, this grand table is ideal for celebrations. Surrounded by low-hanging pendant lights and lush greenery, it brings a touch of nature into the luxurious setting.");

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 7,
                column: "Description",
                value: "Located near the crackling fireplace, this table exudes warmth and coziness. The perfect setting for a family dinner, with the added comfort of soft armchairs and ambient lighting.");

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 8,
                column: "Description",
                value: "Situated on the elevated dining platform, offering a bird’s eye view of the entire restaurant. The dim lighting and plush seating make it ideal for larger groups seeking an exclusive experience.");

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 9,
                column: "Description",
                value: "A small, intimate table placed near the piano, where live music fills the air. With velvet upholstery and low lighting, it’s an unforgettable experience for music lovers.");

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 10,
                column: "Description",
                value: "This table offers a view of the chef’s open kitchen, allowing diners to watch the artistry unfold. Luxurious yet vibrant, it’s perfect for those who enjoy the theater of fine dining.");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$WPSTi5rsoQ4bygvCSGHIze9bztgI4QCvVfc7W.V7KgKu7gFmopQB6");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$4BxFB2IcLGWKxgBnVfWCtOG7OfxZ1DjCrbpOk98b.SSct39Vlg6.K");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "PasswordHash",
                value: "$2a$11$4BxFB2IcLGWKxgBnVfWCtOG7OfxZ1DjCrbpOk98b.SSct39Vlg6.K");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "PasswordHash",
                value: "$2a$11$4BxFB2IcLGWKxgBnVfWCtOG7OfxZ1DjCrbpOk98b.SSct39Vlg6.K");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "PasswordHash",
                value: "$2a$11$2I7hyxNZOEYpbnS89PZDNucKd5C5HZparOjN41Dt0/6LB1G/BkMZO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "PasswordHash",
                value: "$2a$11$2I7hyxNZOEYpbnS89PZDNucKd5C5HZparOjN41Dt0/6LB1G/BkMZO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "PasswordHash",
                value: "$2a$11$2I7hyxNZOEYpbnS89PZDNucKd5C5HZparOjN41Dt0/6LB1G/BkMZO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                column: "PasswordHash",
                value: "$2a$11$2I7hyxNZOEYpbnS89PZDNucKd5C5HZparOjN41Dt0/6LB1G/BkMZO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                column: "PasswordHash",
                value: "$2a$11$2I7hyxNZOEYpbnS89PZDNucKd5C5HZparOjN41Dt0/6LB1G/BkMZO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                column: "PasswordHash",
                value: "$2a$11$2I7hyxNZOEYpbnS89PZDNucKd5C5HZparOjN41Dt0/6LB1G/BkMZO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                column: "PasswordHash",
                value: "$2a$11$2I7hyxNZOEYpbnS89PZDNucKd5C5HZparOjN41Dt0/6LB1G/BkMZO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                column: "PasswordHash",
                value: "$2a$11$2I7hyxNZOEYpbnS89PZDNucKd5C5HZparOjN41Dt0/6LB1G/BkMZO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                column: "PasswordHash",
                value: "$2a$11$2I7hyxNZOEYpbnS89PZDNucKd5C5HZparOjN41Dt0/6LB1G/BkMZO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                column: "PasswordHash",
                value: "$2a$11$2I7hyxNZOEYpbnS89PZDNucKd5C5HZparOjN41Dt0/6LB1G/BkMZO");
        }
    }
}
