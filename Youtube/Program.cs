using Youtube.Biblioteca;

Console.Write("Ingrese titulo: ");
string? titulo = Console.ReadLine();
Console.Write("Ingrese duracion (en segundos): ");
int duracion = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese cantidad visualizaciones: ");
int visualizaciones = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese cantidad likes: ");
int likes = Convert.ToInt32(Console.ReadLine());

Video unVideo = new Video(titulo, duracion, visualizaciones, likes);
unVideo.Informar();
