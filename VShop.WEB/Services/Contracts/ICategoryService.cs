using VShop.WEB.Models;

namespace VShop.WEB.Services.Contracts;

public interface ICategoryService
{
    Task<IEnumerable<CategoryViewModel>> GetAllCategories();
}
