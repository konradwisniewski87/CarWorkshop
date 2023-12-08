using CarWorkshop.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Infrastructure.Seeders
{
    public class CarWorkshopSeeder
    {
        private readonly CarWorkshopDbContext dbContext;

        public CarWorkshopSeeder(CarWorkshopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task Seed()
        {
            if(await this.dbContext.Database.CanConnectAsync())
            {
                if(!dbContext.CarWorkshops.Any())//check is empty
                {
                    var mazdaAso = new Domain.Entities.CarWorkshop()
                    {
                        Name = "Mazda ASO",
                        Description = "Autoryzowany serwis Mazda",
                        ContactDetails = new()
                        {
                            City = "Radom",
                            Street = "Warszawska 6",
                            PostCode = "26-600",
                            PhoneNumber = "+48602876678"
                        }
                    };
                    mazdaAso.EncodeName();
                    dbContext.CarWorkshops.Add(mazdaAso);
                    await dbContext.SaveChangesAsync(); 
                }
            }
        }
    }
}
