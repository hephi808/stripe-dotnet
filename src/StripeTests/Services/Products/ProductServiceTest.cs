namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class ProductServiceTest : BaseStripeTest
    {
        private const string ProductId = "prod_123";

        private ProductService service;
        private ProductCreateOptions createOptions;
        private ProductUpdateOptions updateOptions;
        private ProductListOptions listOptions;

        public ProductServiceTest()
        {
            this.service = new ProductService();

            this.createOptions = new ProductCreateOptions()
            {
                Attributes = new string[]
                {
                    "attr1",
                    "attr2",
                },
                Name = "product name",
                PackageDimensions = new PackageDimensionOptions
                {
                    Height = 100,
                    Length = 100,
                    Weight = 100,
                    Width = 100,
                },
                Type = "good",
            };

            this.updateOptions = new ProductUpdateOptions()
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new ProductListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var product = this.service.Create(this.createOptions);
            Assert.NotNull(product);
            Assert.Equal("product", product.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var product = await this.service.CreateAsync(this.createOptions);
            Assert.NotNull(product);
            Assert.Equal("product", product.Object);
        }

        [Fact]
        public void Delete()
        {
            var deleted = this.service.Delete(ProductId);
            Assert.NotNull(deleted);
        }

        [Fact]
        public async Task DeleteAsync()
        {
            var deleted = await this.service.DeleteAsync(ProductId);
            Assert.NotNull(deleted);
        }

        [Fact]
        public void Get()
        {
            var product = this.service.Get(ProductId);
            Assert.NotNull(product);
            Assert.Equal("product", product.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var product = await this.service.GetAsync(ProductId);
            Assert.NotNull(product);
            Assert.Equal("product", product.Object);
        }

        [Fact]
        public void List()
        {
            var products = this.service.List(this.listOptions);
            Assert.NotNull(products);
            Assert.Equal("list", products.Object);
            Assert.Single(products.Data);
            Assert.Equal("product", products.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var products = await this.service.ListAsync(this.listOptions);
            Assert.NotNull(products);
            Assert.Equal("list", products.Object);
            Assert.Single(products.Data);
            Assert.Equal("product", products.Data[0].Object);
        }

        [Fact]
        public void Update()
        {
            var product = this.service.Update(ProductId, this.updateOptions);
            Assert.NotNull(product);
            Assert.Equal("product", product.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var product = await this.service.UpdateAsync(ProductId, this.updateOptions);
            Assert.NotNull(product);
            Assert.Equal("product", product.Object);
        }
    }
}