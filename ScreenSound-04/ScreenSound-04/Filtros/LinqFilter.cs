using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosGenerosMusicais(List<Musica> musicas)
    {
        var todosGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach(var genero in todosGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistaGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistaGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");
        foreach(var artista in artistaGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicaUmArtista(List<Musica> musicas, string nomeArtista)
    {
        var musicasArtista = musicas.Where(musica => musica.Artista!.Equals(nomeArtista)).ToList();
        Console.WriteLine(nomeArtista);
        foreach(var musica in musicasArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    internal static void FiltrarMusicaCSharp(List<Musica> musicas)
    {
        var musicasEmCSharp = musicas.Where(musica => musica.Tonalidade.Equals("C#")).Select(musica => musica.Nome).ToList();
        Console.WriteLine("Músicas em C#:");
        foreach (var musica in musicasEmCSharp)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}
