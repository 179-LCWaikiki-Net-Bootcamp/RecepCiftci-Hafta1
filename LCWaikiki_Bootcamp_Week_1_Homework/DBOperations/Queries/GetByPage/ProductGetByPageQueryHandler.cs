using AutoMapper;
using LCWaikiki_Bootcamp_Week_1_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_1_Homework.Repositories;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Queries.GetByPage
{
    public class ProductGetByPageQueryHandler : IRequestHandler<ProductGetByPageQuery, ResponseDto<List<ProductDto>>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductGetByPageQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<ResponseDto<List<ProductDto>>> Handle(ProductGetByPageQuery request, CancellationToken cancellationToken)
        {
            var response = await _productRepository.GetProductsByPage(request.Page, request.PageSize);
            return ResponseDto<List<ProductDto>>.Success(_mapper.Map<List<ProductDto>>(response), 200);
        }
    }
}