using DotNetAppEF.Models;
using System;
using System.Linq;

namespace DotNetAppEF.Data
{
    public static class DbInitializer
    {
        public static void Initialize(PeopleContext context)
        {
            context.Database.EnsureCreated();

            // Look for any person.
            if (context.People.Any())
            {
                return;   // DB has been seeded
            }

            var people = new Person[]
            {
            new Person{Name="Carson",Email="example@Alexander",Phone=12345678,Cell=123456789,Address="rua dos bobos, numero:zero"},
            new Person{Name="Meredith",Email="example@Alonso",Phone=12345678,Cell=123456789,Address="rua dos bobos, numero:zero"},
            new Person{Name="Arturo",Email="example@Anand",Phone=12345678,Cell=123456789,Address="rua dos bobos, numero:zero"},
            new Person{Name="Gytis",Email="example@Barzdukas",Phone=12345678,Cell=123456789,Address="rua dos bobos, numero:zero"},
            new Person{Name="Yan",Email="example@Li",Phone=12345678,Cell=123456789,Address="rua dos bobos, numero:zero"},
            new Person{Name="Peggy",Email="example@Justice",Phone=12345678,Cell=123456789,Address="rua dos bobos, numero:zero"},
            new Person{Name="Laura",Email="example@Norman",Phone=12345678,Cell=123456789,Address="rua dos bobos, numero:zero"},
            new Person{Name="Nino",Email="example@Olivetto",Phone=12345678,Cell=123456789,Address="rua dos bobos, numero:zero"}
            };
            foreach (Person s in people)
            {
                context.People.Add(s);
            }
            context.SaveChanges();
        }
    }
}
