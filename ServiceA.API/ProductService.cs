using System;
using ServiceA.API.Models;

namespace ServiceA.API
{
	public class ProductService
	{
		private readonly HttpClient _client;
		private readonly ILogger<ProductService> _logger;

        public ProductService(HttpClient client, ILogger<ProductService> logger)
        {
            _client = client;
            _logger = logger;
        }

        public async Task<Product> Get(int id)
        {
            var product = await _client.GetFromJsonAsync<Product>($"{id}");

            _logger.LogInformation($"Product : {product.Id}-{product.Name}");

            return product;

        }
    }
}

