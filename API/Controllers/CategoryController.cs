using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

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
        List<Category> categoryList = _context.Categories.ToList();
        return View(categoryList);
    }

    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Create(Category category)
    {
        if (category.Name == category.DisplayOrder.ToString())
        {
            ModelState.AddModelError("Name", "Display Order cannot match the Name");
        }
        if (ModelState.IsValid)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            TempData["Success"] = "Category created successfully";
            return RedirectToAction("Index");
        }
        return View();
    }
    public IActionResult Edit(int id)
    {
        if (id == 0)
        {
            return NotFound();
        }
        
        Category category = _context.Categories.FirstOrDefault(c => c.Id == id);

        if (category == null)
        {
            return NotFound();
        }
        
        return View(category);
    }
    
    [HttpPost]
    public IActionResult Edit(Category category)
    {
        if (ModelState.IsValid)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            TempData["Success"] = "Category updated successfully";
            return RedirectToAction("Index");
        }
        return View();
    }
    
    public IActionResult Delete(int id)
    {
        if (id == 0)
        {
            return NotFound();
        }
        
        Category category = _context.Categories.Find(id);

        if (category == null)
        {
            return NotFound();
        }
        
        return View(category);
    }
    
    [HttpPost, ActionName("Delete")]
    public IActionResult DeletePost(int id)
    {
        Category category = _context.Categories.Find(id);
        if (category == null)
        {
            return NotFound();
        }
        _context.Categories.Remove(category);
        _context.SaveChanges();
        TempData["Success"] = "Category deleted successfully";
        return RedirectToAction("Index");
    }
}