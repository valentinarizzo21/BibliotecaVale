using Microsoft.AspNetCore.Mvc;

public class LibroController : Controller
{
    private readonly LibroService _libroService;

    public LibroController(LibroService libroService)
    {
        _libroService = libroService;
    }

    public IActionResult Index()
    {
        var libri = _libroService.GetAll();
        return View(libri);
    }

    public IActionResult Details(int id)
    {
        var libro = _libroService.GetById(id);
        if (libro == null)
            return NotFound();
        return View(libro);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Libro libro)
    {
        if (ModelState.IsValid)
        {
            _libroService.Add(libro);
            return RedirectToAction("Index");
        }
        return View(libro);
    }

    public IActionResult Edit(int id)
    {
        var libro = _libroService.GetById(id);
        if (libro == null)
            return NotFound();
        return View(libro);
    }

    [HttpPost]
    public IActionResult Edit(Libro libro)
    {
        if (ModelState.IsValid)
        {
            _libroService.Update(libro);
            return RedirectToAction("Index");
        }
        return View(libro);
    }

    public IActionResult Delete(int id)
    {
        var libro = _libroService.GetById(id);
        if (libro == null)
            return NotFound();
        return View(libro);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        _libroService.Delete(id);
        return RedirectToAction("Index");
    }
}