using WinOverview.Models;

namespace WinOverview.Data
{
    public static class EmployeRepository
    {
        private static List<Enploye> _employes = new List<Enploye>
        {
            new Enploye {
                Id = 1,
                Name = "John Doe",
                Description = "Senior Developer",
                Position = PositionType.Developer,
                HireDate = new DateTime(2020, 1, 15),
                CreatedAt = new DateTime(2020, 1, 15),
                UpdatedAt = DateTime.Now,
            },
            new Enploye {
                Id = 2,
                Name = "Jane Smith",
                Description = "QA Engineer",
                Position = PositionType.Tester,
                HireDate = new DateTime(2021, 3, 22),
                CreatedAt = new DateTime(2021, 3, 22),
                UpdatedAt = DateTime.Now,
            },
            new Enploye {
                Id = 3,
                Name = "Alice Johnson",
                Description = "UI Designer",
                Position = PositionType.Designer,
                HireDate = new DateTime(2019, 11, 5),
                CreatedAt = new DateTime(2019, 11, 5),
                UpdatedAt = DateTime.Now,
            },
            new Enploye {
                Id = 4,
                Name = "Bob Brown",
                Description = "Junior Developer",
                Position = PositionType.Developer,
                HireDate = new DateTime(2022, 7, 30),
                CreatedAt = new DateTime(2022, 7, 30),
                UpdatedAt = DateTime.Now,
            }
        };

        public static List<Enploye> GetAll() => _employes;

        public static Enploye? GetById(int id) => _employes.FirstOrDefault(e => e.Id == id);

        public static void Remove(int id)
        {
            var employe = GetById(id);
            if (employe != null)
            {
                _employes.Remove(employe);
            }
            else
            {
                throw new NullReferenceException("Employe not found");
            }
        }

        public static void Add(Enploye employe)
        {
            _employes.Add(employe);
        }

    }
}
