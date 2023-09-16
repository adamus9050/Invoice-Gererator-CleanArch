using Application.Dto.Material.MaterialQuerries.List;
using AutoMapper;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Order.Querry
{
    public class OrderListQuerryHandler : IRequestHandler<OrderListQuerry, IEnumerable<OrderDto>>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        public OrderListQuerryHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<OrderDto>> Handle(OrderListQuerry request, CancellationToken cancellationToken)
        {
            var order = await _orderRepository.GetAll();
            var list = _mapper.Map<IEnumerable<OrderDto>>(order);
            return list;
        }
    }
}
