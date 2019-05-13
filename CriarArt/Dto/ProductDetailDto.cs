using CriarArt.Models;

namespace CriarArt.Dto
{
    public class ProductDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        public ProductDetailDto()
        {
        }

        public ProductDetailDto(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Price = product.Price;
            Image = product.Image;
            Description = product.Description;
        }

        public ProductDetailDto ToProductListDto(Product product)
        {
            return new ProductDetailDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Image = product.Image,
                Description = product.Description
            };
        }
    }
}
