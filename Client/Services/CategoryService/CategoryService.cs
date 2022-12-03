namespace BlazorEcommerce.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;
        public CategoryService(HttpClient htpp)
        {
            _http = htpp;
        }
        public List<Category> Categories { get; set; } = new List<Category>();

        public async Task GetCategories()
        {
            var response =
                await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/Category");
            if (response != null && response.Data != null)
                Categories = response.Data;
        }
    }
}
