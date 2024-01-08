﻿using AutoMapper;
using CarWorkshop.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Application.CarWorkshop.Queries.GetCarWorkshopByEncodedName
{
    public class GetCarWorkshopByEncodedNameQueriesHandler : IRequestHandler<GetCarWorkshopByEncodedNameQueries, CarWorkshopDTO>
    {
        private readonly ICarWorkshopRepository _carWorkshopRepository;
        private readonly IMapper _mapper;

        public GetCarWorkshopByEncodedNameQueriesHandler(ICarWorkshopRepository carWorkshopRepository, IMapper mapper)
        {
            _carWorkshopRepository = carWorkshopRepository;
            _mapper = mapper;
        }
        public async Task<CarWorkshopDTO> Handle(GetCarWorkshopByEncodedNameQueries request, CancellationToken cancellationToken)
        {
            var carWorkshop = await _carWorkshopRepository.GetByEncodedName(request.EncodedName);
            var dto = _mapper.Map<CarWorkshopDTO>(carWorkshop);
            return dto;
        }
    }
}
