using CoreLibrary.Data;
using Microsoft.AspNetCore.Mvc;
using ModelsLibrary.Models;

namespace API.Controllers;

public class CategoryController : Controller
{
    private readonly AppDbContext _context;
    
    public CategoryController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        List<Category> CategoryList = _context.Categories.ToList();
        return View(CategoryList);
    }
}