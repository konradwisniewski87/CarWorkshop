﻿using CarWorkshop.Domain.Interfaces;
using CarWorkshop.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;

namespace CarWorkshop.Infrastructure.Repositories
{
    internal class CarWorkshopRepository : ICarWorkshopRepository
    {
        private readonly CarWorkshopDbContext _dbContext;

        public CarWorkshopRepository(CarWorkshopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Create(Domain.Entities.CarWorkshop carWorkshop)
        {
            _dbContext.Add(carWorkshop);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Domain.Entities.CarWorkshop>> GetAll()
            => await _dbContext.CarWorkshops.ToListAsync();

        public Task<Domain.Entities.CarWorkshop?> GetByName(string name)
            => _dbContext.CarWorkshops.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower());
    }
}
