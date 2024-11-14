### Assignment: *Week 12 – Advanced LINQ & Inventory Management*

#### Overview
In this assignment, you'll extend the ConsoleRPG project to implement an **Inventory Management System** for players. This involves using advanced LINQ queries to perform actions on a player’s inventory, including searching, sorting, and filtering items. You’ll practice LINQ skills to manage a collection of items and add functionality for using, equipping, and removing items.

#### Objectives
By completing this assignment, you will:
- Gain experience with **advanced LINQ queries** in C#.
- Implement an **Inventory system** for the player, where they can add, equip, use, and remove items from the inventory.
- Extend the **ConsoleRPG game mechanics** using Entity Framework and LINQ to interact with the inventory and items database.

#### Instructions

1. **Setup Inventory Management:**
   - **Add Inventory to Player:** 
     - Create a property `List<Item> Inventory` in the `Player` class to hold a collection of items.
   - **Add Inventory Methods:**
     - Implement methods in the `Player` class for adding, using, equipping, and removing items from the inventory.

2. **Add LINQ Queries for Inventory Operations:**
   - Write LINQ queries to:
     - **Search for an item by name:** Display any matching items by their name.
     - **List items by type (e.g., Weapons, Armor):** Group items by type and display them accordingly.
     - **Sort items:** Provide options to sort items by:
       - Name
       - Attack value
       - Defense value
     - These should be grouped into a **Sort submenu** in the main menu to allow the player to select a sorting option.

3. **Implement Inventory Actions in GameEngine:**
   - Add methods in the `GameEngine` class to handle the player’s inventory actions, using LINQ to:
     - Display the inventory list with sorting and filtering options.
     - Equip or use items based on their properties (e.g., only equipping items with attack or defense stats).
   - Update the menu in `MenuManager` to allow players to:
     - **Search for an item by name**
     - **List items by type**
     - **Sort items** (with a submenu for choosing sort criteria)

   Here’s a sample menu setup in `MenuManager` for reference:

   ```csharp
   Console.WriteLine("\nInventory Management:");
   Console.WriteLine("1. Search for item by name");
   Console.WriteLine("2. List items by type");
   Console.WriteLine("3. Sort items");
   ```

   - Under "3. Sort items," add a **submenu** for sorting criteria:

     ```csharp
     Console.WriteLine("\nSort Options:");
     Console.WriteLine("1. Sort by Name");
     Console.WriteLine("2. Sort by Attack Value");
     Console.WriteLine("3. Sort by Defense Value");
     ```

4. **Update Database Context:**
   - Add sample data to the `GameContext` for various items (e.g., weapons, armor, potions).
   - **Seed Database:** Ensure the database is seeded with a list of items that players can find or use in the game.

#### Stretch Goal (+10%)
1. **Inventory Weight Limit:**
   - Implement a weight system in the `Player` class by adding a `MaxWeight` property.
   - Each item should have a `Weight` property.
   - Add validation to prevent players from adding items that would exceed their `MaxWeight`.
2. **Advanced LINQ Queries for Weight Management:**
   - Use LINQ to calculate the total weight of items in the player’s inventory.
   - Filter items that can be equipped based on the remaining weight limit.

#### Submission Requirements
- Submit your modified files:
  - `Player.cs`, `GameEngine.cs`, `GameContext.cs`, and any relevant files containing LINQ queries and inventory methods.
- Include a short write-up explaining your changes and how the LINQ queries enhance the inventory management experience.

#### Grading Criteria

| **Criteria**                      | **Points** |
|-----------------------------------|------------|
| Inventory management methods added in `Player` class | 40         |
| LINQ queries for search, sort, filter, and count    | 40         |
| Integration of inventory actions in `GameEngine`    | 30         |
| Inventory actions in `MenuManager`                  | 15         |
| Database seeding and context setup                  | 15         |
| Code readability and comments                       | 10         |
| **Stretch Goal (optional)**                        | **+10**    |
| **Total Possible Points**                          | **150 (+10%)** |

