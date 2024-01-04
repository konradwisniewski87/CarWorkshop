using CarWorkshop.Application.CarWorkshop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Application.Services
{
    public interface ICarWorkshopService
    {
        Task Create(CarWorkshopDTO carWorkshop);
        Task<IEnumerable<CarWorkshopDTO>> GetAll();
    }
}
