using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Application.CarWorkshop.Queries.GetCarWorkshopByEncodedName
{
    public class GetCarWorkshopByEncodedNameQueries : IRequest<CarWorkshopDTO>
    {
        public string EncodedName { get; set; }

        public GetCarWorkshopByEncodedNameQueries(string encodedName)
        {
            EncodedName = encodedName;
        }
    }
}
