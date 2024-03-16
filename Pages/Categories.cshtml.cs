namespace MyRazorApp.Pages;

public class Categories : PageModel
{
    public List<Category> CategoryList { get; set; } = new();

    public void Task OnGet(int skip = 0, int take = 25)
    {
        var temp = new List<Category>();

        for (var i = 0; i <= 100; i++)
        {
            temp.Add(item: new Category(i, Title: $"Categoria {i}", Price: i * 10M));
        }

        CategoryList = temp.Skip().Take().ToList();
    }
}

public record Category(int Id, string Title, decimal Price);