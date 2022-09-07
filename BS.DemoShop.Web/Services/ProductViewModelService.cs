﻿using BS.DemoShop.Core.Entities;
using BS.DemoShop.Core.Extensions;
using BS.DemoShop.Core.Interfaces;
using BS.DemoShop.Web.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BS.DemoShop.Web.Services
{
    public class ProductViewModelService
    {
        private readonly IRepository<Product> _productRepo;
        private readonly IRepository<ProductDetail> _productDetailRepo;
        private readonly IProductRepository _productRepository;

        public ProductViewModelService(
            IRepository<Product> productRepo,
            IRepository<ProductDetail> productDetailRepo,
            IProductRepository productRepository
            )
        {
            _productRepo = productRepo;
            _productDetailRepo = productDetailRepo;
            _productRepository = productRepository;
        }

        public ProductViewModel GetById(int id)
        {

            var product = _productRepo.GetAllReadOnly().FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return default;
            }

            var productDetails = _productDetailRepo.GetAll()
                .Where(x => x.ProductId == product.Id)
                .Select(pd => new ProductDetailViewModel { Id = pd.Id, Name = pd.Name, UnitPrice = pd.UnitPrice })
                .ToList();

            var result = new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                ImgPath = product.ImgPath,
                ProductDetails = productDetails,
                CreatedTime = product.CreatedTime.ToTaiwaneseTime(),
                LastUpdatedTime = product.UpdatedTime?.ToTaiwaneseTime()
            };

            return result;
        }

        public IEnumerable<ProductViewModel> GetAllProduct()
        {
            var products = _productRepository.GetAllReadOnly().Select(p => new ProductViewModel
            {
                Id = p.Id,
                Name = p.Name,
                ImgPath = p.ImgPath,
                CreatedTime = p.CreatedTime.ToTaiwaneseTime()
            }).ToList();

            var productDetails = _productDetailRepo.GetAllReadOnly().Where(pd => products.Select(p => p.Id).Contains(pd.ProductId)).ToList();

            foreach (var product in products)
            {
                if(productDetails.Any(pd=>pd.ProductId == product.Id))
                {
                    product.Price = productDetails.FirstOrDefault()?.UnitPrice ?? 0;
                }
                yield return product;
            }
        }

        public void CreateProduct(CreateProductViewModel input)
        {
            var product = new Product
            {
                Name = input.Name,
                ImgPath = input.ImgPath,
                CreatedTime = DateTime.UtcNow,
                ProductDetailses = input.ProductDetail.Select(x => new ProductDetail { Name = x.SpecName, UnitPrice = x.UnitPrice, CreatedTime = DateTime.UtcNow }).ToList()

            };
            _productRepository.Add(product);

        }

        public void CreateProductByRepository(CreateProductViewModel input)
        {
            var product = new Product
            {
                Name = input.Name,
                ImgPath = input.ImgPath,
                CreatedTime = DateTime.UtcNow
            };
            var productDetails = input.ProductDetail.Select(x => new ProductDetail { Name = x.SpecName, UnitPrice = x.UnitPrice, CreatedTime = DateTime.UtcNow });
            _productRepository.CreateProductAndDetails(product, productDetails);
        }

        public void CreateDetail(CreateDetailViewModel input)
        {
            _productDetailRepo.Add(new ProductDetail
            {
                Name = input.SpecName,
                UnitPrice = input.UnitPrice,
                CreatedTime = DateTime.UtcNow,
                ProductId = input.ProductId,
            });
        }

        public void UpdateProduct(ProductViewModel input)
        {
            var now = DateTime.UtcNow;
            var productSource = _productRepository.GetAll().First(x => x.Id == input.Id);

            productSource.Name = input.Name;
            productSource.ImgPath = input.ImgPath;
            productSource.UpdatedTime = now;


            var detailSource = _productDetailRepo.GetAll()
                .Where(x => x.ProductId == input.Id).ToList();

            foreach (var entity in detailSource)
            {
                var inputDetail = input.ProductDetails.First(x => x.Id == entity.Id);
                entity.Name = inputDetail.Name;
                entity.UnitPrice = inputDetail.UnitPrice;
                entity.UpdatedTime = now;
            }
            productSource.ProductDetailses = detailSource;

            _productRepository.Update(productSource);

        }

        public void DeleteProduct(ProductViewModel input)
        {

            var productEntity = _productRepository.GetAll().First(x => x.Id == input.Id);
            _productRepository.Delete(productEntity);
        }

        public async Task<ProductViewModel> CreateProductWithDetail(CreateDefaultProductDTO input)
        {
            var defaultProductDetail = new ProductDetail("預設規格", 100);
            
            var productEntity = await _productRepository.CreateProductWithDetail(input.Name, input.ImgPath, "預設商品", defaultProductDetail);
            var result = new ProductViewModel
            {
                Id = productEntity.Id,
                Name = productEntity.Name,
                Price = productEntity.ProductDetailses.First().UnitPrice,
                ImgPath = productEntity.ImgPath,
                CreatedTime = productEntity.CreatedTime,
                LastUpdatedTime = productEntity.UpdatedTime,
                ProductDetails = productEntity.ProductDetailses.Select(x => new ProductDetailViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    UnitPrice = x.UnitPrice
                }).ToList()
            };
            return result;
        }
    }
}
