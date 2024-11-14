### Assignment Notes: Updating Migrations and Seeding Data

For this week's assignment, we will be working with an updated `Item` model and a pre-populated `.sql` file with seed data. Since the `Item.cs` model has been updated from previous weeks, **you will need to add a new migration** to account for these changes. Additionally, you’ll need to add another migration specifically to incorporate the `.sql` file for data seeding.

### Steps to Complete the Assignment

1. **Review the Updated `Item.cs` Model**
   - Ensure your `Item` class includes the new properties:
     ```csharp
     public class Item
     {
         public int Id { get; set; }
         public string Name { get; set; }
         public string Type { get; set; }
         public int Attack { get; set; }
         public int Defense { get; set; }
         public decimal Weight { get; set; }
         public int Value { get; set; }
     }
     ```
   - Verify that the `Item` class in your code matches this structure, as these properties will be used for seeding and querying.

2. **Create a New Migration for the Updated Item Model**
   - Run the following command to create a new migration that captures the schema updates:
     ```bash
     dotnet ef migrations add UpdateItemModel
     ```
   - This will generate the necessary changes to update the database schema to match the new `Item` model.

3. **Apply the Migration to Update the Database**
   - Use the following command to apply the migration and update your database schema:
     ```bash
     dotnet ef database update
     ```

4. **Implement the Data Seeding Migration Using the Provided `.sql` File**
   - We’ve provided a SQL file with 100+ items to seed your database. To apply this, you’ll need a new migration, such as `SeedItems`.

   - Use the following code in your migration file to seed the data:

     ```csharp
     public partial class SeedItems : BaseMigration 
     {
         protected override void Up(MigrationBuilder migrationBuilder)
         {
             RunSql(migrationBuilder);
         }

         protected override void Down(MigrationBuilder migrationBuilder)
         {
             RunSqlRollback(migrationBuilder);
         }
     }
     ```

   - Ensure that `RunSql` and `RunSqlRollback` contain the necessary SQL commands from the `.sql` file to insert and rollback the seed data for `Item`.

5. **Run the Seed Migration**
   - After creating the migration for seeding, update the database with:
     ```bash
     dotnet ef database update
     ```

### Important Tips

- **Checking Migrations:** Always verify your migrations before updating the database to ensure they correctly reflect your schema changes.
- **Data Integrity:** Running the seed migration multiple times without a proper rollback can result in duplicate entries. Be cautious and confirm data consistency after running migrations.
- **Error Handling:** If you encounter any issues, check your migration files for syntax errors or conflicting data. Reapply or roll back migrations as needed.

This assignment not only ensures that your database is in sync with the current application but also prepares you for future updates and database management. 
