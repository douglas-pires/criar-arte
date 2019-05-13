using CriarArt.Models;

namespace CriarArt.Dto
{
    public class ProductListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        public ProductListDto()
        {
        }

        public ProductListDto(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Price = product.Price;
            Image = product.Image;
        }

        public ProductListDto ToProductListDto(Product product)
        {
            return new ProductListDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Image = product.Image
            };
        }
    }
}
