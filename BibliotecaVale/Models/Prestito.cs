public class Prestito
{
    public int Id { get; set; }
    public int LibroId { get; set; }
    public Libro Libro { get; set; }
    public DateTime DataPrestito { get; set; }
    public DateTime DataRestituzione { get; set; }
    public bool Restituito { get; set; }
}