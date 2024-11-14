using ConsoleRpgEntities.Models.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpgEntities.Models.Equipments
{
    public class Inventory
    {
        public int Id { get; set; }

        // Foreign key
        public int PlayerId { get; set; }

        // Navigation properties
        public virtual Player Player { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }

}
