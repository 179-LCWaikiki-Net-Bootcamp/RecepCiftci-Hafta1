using AutoMapper;
using LCWaikiki_Bootcamp_Week_1_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_1_Homework.Repositories;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Commands.ProductInsert
{
    public class ProductInsertCommandHandler : IRequestHandler<ProductInsertCommand, ResponseDto<string>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductInsertCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<ResponseDto<string>> Handle(ProductInsertCommand request, CancellationToken cancellationToken)
        {
            await _productRepository.SaveProduct(request);
            return ResponseDto<string>.Success($"{request.Name} product saved to database", 201);
        }
    }
}
