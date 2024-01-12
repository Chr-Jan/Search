using Search.Models;

namespace Search.Data
{
    public class SeedData
    {
        private static List<Human> humans;

        static SeedData()
        {
            humans = new List<Human>
            {
                new Human {Id = 1, Name = "Bob", Age = 32, Handsome = true},
                new Human {Id = 2, Name = "Reimer", Age = 24, Handsome = false},
                new Human {Id = 3, Name = "Stive", Age = 12, Handsome = false },
                new Human {Id = 4, Name = "Chris", Age = 36, Handsome = true },
                new Human {Id = 5, Name = "Nimbler", Age = 101, Handsome = true}
            };
        }

        public static List<Human> GetHumans()
        {
            return humans;
        }
    }
}
