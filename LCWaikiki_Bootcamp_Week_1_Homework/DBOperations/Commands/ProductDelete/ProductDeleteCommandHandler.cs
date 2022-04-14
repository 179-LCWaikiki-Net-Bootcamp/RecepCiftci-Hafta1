using AutoMapper;
using LCWaikiki_Bootcamp_Week_1_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_1_Homework.Repositories;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Commands.ProductDelete
{
    public class ProductDeleteCommandHandler : IRequestHandler<ProductDeleteCommand, ResponseDto<string>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductDeleteCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<ResponseDto<string>> Handle(ProductDeleteCommand request, CancellationToken cancellationToken)
        {
            await _productRepository.DeleteProduct(request);
            return ResponseDto<string>.Success($"Product with {request.Id} ID deleted", 204);
        }
    }
}
