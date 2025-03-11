using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class LibroService
{
    private readonly BibliotecaValeContext _context;

    public LibroService(BibliotecaValeContext context)
    {
        _context = context;
    }

    public List<Libro> GetAll()
    {
        return _context.Libri.ToList();
    }

    public Libro GetById(int id)
    {
        return _context.Libri.Find(id);
    }

    public void Add(Libro libro)
    {
        _context.Libri.Add(libro);
        _context.SaveChanges();
    }

    public void Update(Libro libro)
    {
        _context.Libri.Update(libro);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var libro = _context.Libri.Find(id);
        if (libro != null)
        {
            _context.Libri.Remove(libro);
            _context.SaveChanges();
        }
    }
}
