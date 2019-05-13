using System.Linq;
using CriarArt.Context;
using CriarArt.Models;
using Microsoft.Extensions.DependencyInjection;

namespace CriarArt.Helpers
{
    public static class StartupDatabase
    {
        public static void FillData(IServiceCollection servicesCollection)
        {
            using (var services = servicesCollection.BuildServiceProvider())
            {
                var context = services.GetRequiredService<OracleContext>();

                var productContext = context.Products;

                if (productContext.Any()) return;

                productContext.Add(new Product
                {
                    Name = "Caneca de Cerâmica Personalizada",
                    Description = @"Caneca Porcelana 325 ml Personalizada. <br>
                        Estampa realizada direto na caneca garantindo qualidade nas cores e imagem. <br>
                        Personalizamos com qualquer tema. ",
                    Image = "https://img.elo7.com.br/product/zoom/1C2BF1E/caneca-de-porcelana-personalizada-festas.jpg",
                    Price = 25.99M
                });

                productContext.Add(new Product
                {
                    Name = "Caneca Lousa",
                    Description = @"Caneca Lousa é ideal para quem tem imaginação, pois pode escrever e desenhar o que quiser com giz.<br>
                        Após pagamento 10 dias úteis para o envio.",
                    Image = "https://img.elo7.com.br/product/zoom/7CDB4E/caneca-dia-dos-professores-dia-das-criancas.jpg",
                    Price = 11.30M
                });

                productContext.Add(new Product
                {
                    Name = "Caneca Supernatural",
                    Description = @"Caneca Supernatural. <br>
                        Estampa realizada direto na caneca garantindo qualidade nas cores e imagem.",
                    Image = "https://img.elo7.com.br/product/zoom/19F46B9/caneca-supernatural-supernatural-serie-caneca-castelo.jpg",
                    Price = 39.99M
                });

                context.SaveChanges();
            }
        }
    }
}
