using AutoMapper;
using LCWaikiki_Bootcamp_Week_1_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_1_Homework.Repositories;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Commands.ProductUpdate
{
    public class ProductUpdateCommandHandler : IRequestHandler<ProductUpdateCommand, ResponseDto<string>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductUpdateCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<ResponseDto<string>> Handle(ProductUpdateCommand request, CancellationToken cancellationToken)
        {
            await _productRepository.UpdateProduct(request);
            return ResponseDto<string>.Success($"Product with {request.Id} updated with given values", 204);
        }
    }
}
