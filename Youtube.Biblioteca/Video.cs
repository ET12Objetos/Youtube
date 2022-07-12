namespace Youtube.Biblioteca;

public class Video
{
    private string? titulo;
    private int duracion;
    private int visualizaciones;
    private int likes;

    public Video(string? titulo, int duracion, int visualizaciones, int likes)
    {
        this.titulo = titulo;
        this.duracion = duracion;
        this.visualizaciones = visualizaciones;
        this.likes = likes;
    }

    public void Informar()
    {
        Console.WriteLine($"Titulo: {titulo}");
        Console.WriteLine($"Duracion (segundos): {duracion}");
        Console.WriteLine($"Visualizaciones: {visualizaciones}");
        Console.WriteLine($"Likes: {likes}");
    }
}
