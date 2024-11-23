using ConsoleRpgEntities.Models.Abilities.PlayerAbilities;
using ConsoleRpgEntities.Models.Attributes;
using System.ComponentModel.DataAnnotations;
using ConsoleRpgEntities.Models.Equipments;

namespace ConsoleRpgEntities.Models.Characters
{
    public class Player : ITargetable, IPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public int Health { get; set; }
        private Item CurrentItem { get; set;}

        // Foreign key
        public int? EquipmentId { get; set; }

        // Navigation properties
        public virtual List<Item> Inventory { get; set; }
        public virtual Equipment Equipment { get; set; }
        public virtual ICollection<Ability> Abilities { get; set; }

        public void Attack(ITargetable target)
        {
            // Player-specific attack logic
            Console.WriteLine($"{Name} attacks {target.Name} with a {Equipment.Weapon.Name} dealing {Equipment.Weapon.Attack} damage!");
            target.Health -= Equipment.Weapon.Attack;
            System.Console.WriteLine($"{target.Name} has {target.Health} health remaining.");

        }

        public void UseAbility(IAbility ability, ITargetable target)
        {
            if (Abilities.Contains(ability))
            {
                ability.Activate(this, target);
            }
            else
            {
                Console.WriteLine($"{Name} does not have the ability {ability.Name}!");
            }
        }

        public void AddItem(Item item){
            Inventory.Add(item);
        }

        public void RemoveItem(Item item){
            Inventory.Remove(item);
        }

        public void EquipItem(Item item){
            CurrentItem = item;
        }

        public void UnequipItem(Item item){
            if (CurrentItem == item){
                CurrentItem = null;
                Console.WriteLine($"{item} has been unequiped");
            } else {
                Console.WriteLine($"{item} is not currently equiped");
            }
        }

        public void UseEquipedItem(){
            if (CurrentItem != null){
                Console.WriteLine($"{Name} uses the {CurrentItem.Name}");
            } else {
                Console.WriteLine($"{Name} does not have an item equiped!");
            }
        }

        public void FindItem(string item){
            var selectedItem = Inventory.Where(i => i.Name == item);
            foreach (var selected in selectedItem){
                Console.WriteLine(selected);
            }
        }

        public void ListByType(string type){
            var itemType = Inventory.Where(i => i.Type == type);
             foreach (var item in itemType){
                Console.WriteLine(item);
            }
        }

        public void Sort(string choice){
            switch(choice){
                case "1":
                    Inventory.OrderBy(i => i.Name);
                    break;
                case "2":
                    Inventory.OrderBy(i => i.Attack);
                    break;
                case "3":
                    Inventory.OrderBy(i => i.Defense);
                    break;
                default:
                    Console.WriteLine("Not a valid input");
                    break;
            }
        }
    }
}
