using AutoMapper;
using LCWaikiki_Bootcamp_Week_1_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_1_Homework.Repositories;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Queries.GetAll
{
    public class ProductGetAllQueryHandler : IRequestHandler<ProductGetAllQuery, ResponseDto<List<ProductDto>>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductGetAllQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<ResponseDto<List<ProductDto>>> Handle(ProductGetAllQuery request, CancellationToken cancellationToken)
        {
            var response = await _productRepository.GetProducts();
            return ResponseDto<List<ProductDto>>.Success(_mapper.Map<List<ProductDto>>(response), 200);
        }
    }
}
