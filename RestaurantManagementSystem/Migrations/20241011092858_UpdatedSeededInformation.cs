using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestaurantManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSeededInformation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "MenuName" },
                values: new object[,]
                {
                    { 1, "Appetizer" },
                    { 2, "Main Courses" },
                    { 3, "Dessert" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "Email", "LastName", "PasswordHash", "PhoneNumber" },
                values: new object[] { "admin.istrator@thedot.com", "Istrator", "$2a$11$zLInQr447xgkoLeSE0ovg.jpgSUG.HJE9N.VB4CkSuSbZBTxFFrxi", "+4670123456" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PhoneNumber" },
                values: new object[] { "john.doe@thedot.com", "John", "Doe", "$2a$11$13qKeWbKz56OoNRTVLOhXeOv9v/9Un3/ltT2TD9RKFQcN.UQ8lWZO", "+4670123457" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PhoneNumber", "RoleId" },
                values: new object[] { "jane.smith@thedot.com", "Jane", "Smith", "$2a$11$13qKeWbKz56OoNRTVLOhXeOv9v/9Un3/ltT2TD9RKFQcN.UQ8lWZO", "+4670123458", 2 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "LastName", "PasswordHash", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { 4, "james.brown@thedot.com", "James", "Brown", "$2a$11$13qKeWbKz56OoNRTVLOhXeOv9v/9Un3/ltT2TD9RKFQcN.UQ8lWZO", "+4670123459", 2 },
                    { 5, "alice.johnson@email.com", "Alice", "Johnson", "$2a$11$NqCW.bVZtcDHpeaae7wjjOqloknawi8bjpSKNlZepsBE4m9rc1PrS", "+4670123460", 3 },
                    { 6, "bob.williams@email.com", "Bob", "Williams", "$2a$11$NqCW.bVZtcDHpeaae7wjjOqloknawi8bjpSKNlZepsBE4m9rc1PrS", "+4670123461", 3 },
                    { 7, "charlie.miller@email.com", "Charlie", "Miller", "$2a$11$NqCW.bVZtcDHpeaae7wjjOqloknawi8bjpSKNlZepsBE4m9rc1PrS", "+4670123462", 3 },
                    { 8, "diana.davis@email.com", "Diana", "Davis", "$2a$11$NqCW.bVZtcDHpeaae7wjjOqloknawi8bjpSKNlZepsBE4m9rc1PrS", "+4670123463", 3 },
                    { 9, "ethan.wilson@email.com", "Ethan", "Wilson", "$2a$11$NqCW.bVZtcDHpeaae7wjjOqloknawi8bjpSKNlZepsBE4m9rc1PrS", "+4670123464", 3 },
                    { 10, "fiona.taylor@email.com", "Fiona", "Taylor", "$2a$11$NqCW.bVZtcDHpeaae7wjjOqloknawi8bjpSKNlZepsBE4m9rc1PrS", "+4670123465", 3 },
                    { 11, "george.moore@email.com", "George", "Moore", "$2a$11$NqCW.bVZtcDHpeaae7wjjOqloknawi8bjpSKNlZepsBE4m9rc1PrS", "+4670123466", 3 },
                    { 12, "hannah.anderson@email.com", "Hannah", "Anderson", "$2a$11$NqCW.bVZtcDHpeaae7wjjOqloknawi8bjpSKNlZepsBE4m9rc1PrS", "+4670123467", 3 },
                    { 13, "ian.thomas@email.com", "Ian", "Thomas", "$2a$11$NqCW.bVZtcDHpeaae7wjjOqloknawi8bjpSKNlZepsBE4m9rc1PrS", "+4670123468", 3 },
                    { 14, "julia.jackson@email.com", "Julia", "Jackson", "$2a$11$NqCW.bVZtcDHpeaae7wjjOqloknawi8bjpSKNlZepsBE4m9rc1PrS", "+4670123469", 3 }
                });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "DishId", "Description", "DishName", "IsAvailable", "MenuId", "Popular", "Price" },
                values: new object[,]
                {
                    { 1, "A refined take on the classic Caprese, with creamy mozzarella, ripe heirloom tomatoes, and a drizzle of fragrant basil pesto.", "Caprese D'Oro", true, 1, true, 28.00m },
                    { 2, "A delicate seabass carpaccio served over crisp red cabbage slaw, garnished with pink peppercorns and a drizzle of citrus olive oil.", "Carpaccio di Branzino", true, 1, true, 42.00m },
                    { 3, "A symphony of grilled vegetables, including zucchini, eggplant, and roasted peppers, drizzled with a delicate balsamic reduction.", "Verdure alla Griglia", true, 1, true, 28.00m },
                    { 4, "Freshly made tagliolini pasta wrapped in a delicate creamy sauce, topped with succulent shrimp marinated in herbs and citrus.", "Tagliolini Primavera", true, 2, true, 38.00m },
                    { 5, "Soft, pillowy gnocchi paired with a fragrant seafood medley of clams, infused with garlic, white wine, and a touch of lemon.", "Gnocchi di Mare", true, 2, true, 45.00m },
                    { 6, "A vibrant dish of fresh pasta mingling with sweet cherry tomatoes, tender tuna, and zesty oranges.", "Pasta Tricolore", true, 2, true, 42.00m },
                    { 7, "A lavish platter of lightly battered and fried seafood, featuring crispy prawns, calamari, and anchovies.", "Fritto Misto", true, 2, true, 48.00m },
                    { 8, "A trio of hand-cut raw delicacies featuring buttery salmon, tender tuna, and delicate seabass, served with citrus and avocado cream.", "Tris di Crudo", true, 2, true, 55.00m },
                    { 9, "Exquisitely seared tuna wrapped in a crispy golden crust, set on a bed of julienned vegetables, and paired with a balsamic reduction.", "Tonno Dorato", true, 2, true, 52.00m },
                    { 10, "A gourmet open-faced tart with house-smoked anchovies, fennel, sun-dried tomatoes, and a hint of citrus zest.", "Alici Affumicate", true, 2, true, 35.00m },
                    { 11, "Luxuriously creamy tagliolini pasta adorned with fragrant shaved black truffles, offering an intense depth of flavor.", "Tagliolini al Tartufo", true, 2, true, 65.00m },
                    { 12, "A succulent Florentine-style T-bone steak, grilled to perfection and served with crispy potato wedges.", "Bistecca Fiorentina", true, 2, true, 75.00m },
                    { 13, "Creamy Parmesan risotto topped with crispy kale and semi-dried tomatoes. A perfect blend of richness and texture that melts in your mouth.", "Risotto al Parmigiano", true, 2, true, 40.00m },
                    { 14, "Handcrafted paccheri pasta enveloped in a luscious tomato basil sauce, with a garnish of fresh basil leaves.", "Paccheri al Pomodoro", true, 2, true, 35.00m },
                    { 15, "Delicately sliced beef carpaccio topped with a golden-fried egg yolk and a hint of truffle mayo.", "Carpaccio di Manzo", true, 2, true, 58.00m },
                    { 16, "Perfectly seared cod fillet served with sautéed mushrooms and salty samphire, finished with a creamy white wine sauce.", "Merluzzo con Funghi e Salicornia", true, 2, true, 62.00m },
                    { 17, "Al dente rigatoni pasta tossed with savory Italian sausage and finished with crispy breadcrumbs and a sprinkle of chili threads.", "Rigatoni con Salsiccia", true, 2, true, 38.00m },
                    { 18, "Crisp corn tortillas filled with a refreshing mix of lightly marinated seafood, cucumber slices, and vine-ripened tomatoes.", "Tacos di Mare", true, 3, true, 36.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "Email", "LastName", "PasswordHash", "PhoneNumber" },
                values: new object[] { "admin@test.com", "Seeded", "$2a$11$C2e7m3VouZjzrzR7VqqP4uNLV5Hr2bpP9ygWFLh1Vro6Y.HAgc02u", "1234567890" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PhoneNumber" },
                values: new object[] { "employee@test.com", "Employee", "Seeded", "$2a$11$Jd1da9OJI8yAB6Cceryhae2NB69MiOP8aagAhzYkR9AQ98v93K4zG", "1234567890" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PhoneNumber", "RoleId" },
                values: new object[] { "customer@test.com", "Customer", "Seeded", "$2a$11$maM5aNPWIsSX/GbxcA15r.TKA7oiW/zaVOOuakHvEZenL5brhMMm6", "1234567890", 3 });
        }
    }
}
