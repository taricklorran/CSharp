using System.Text.Json;
namespace ScreenSound_04.Modelos;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> ListaMusicaFavoritas { get; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaMusicaFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaMusicaFavoritas.Add(musica);
    }

    public void ExibirMusicaFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");
        foreach(var musica in ListaMusicaFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaMusicaFavoritas
        });
        string nomeArquivo = $"musicas-favoritas-{Nome}.json";
        File.WriteAllText(nomeArquivo, json);
        Console.WriteLine($"O arquivo Json foi criado com sucesso! {Path.GetFullPath(nomeArquivo)}");
    }
}
