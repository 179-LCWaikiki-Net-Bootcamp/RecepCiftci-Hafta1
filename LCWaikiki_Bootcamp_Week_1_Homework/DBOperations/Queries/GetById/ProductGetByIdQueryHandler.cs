using AutoMapper;
using LCWaikiki_Bootcamp_Week_1_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_1_Homework.Repositories;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Queries.GetById
{
    public class ProductGetByIdQueryHandler : IRequestHandler<ProductGetByIdQuery, ResponseDto<ProductDto>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductGetByIdQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<ResponseDto<ProductDto>> Handle(ProductGetByIdQuery request, CancellationToken cancellationToken)
        {
            var response = await _productRepository.GetProductById(request.Id);
            return ResponseDto<ProductDto>.Success(_mapper.Map<ProductDto>(response));
        }
    }
}
