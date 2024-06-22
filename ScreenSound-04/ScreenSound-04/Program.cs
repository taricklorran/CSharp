//https://guilhermeonrails.github.io/api-csharp-songs/songs.json (api que será usado)
using ScreenSound_04.Modelos;
using System.Text.Json;
using ScreenSound_04.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!; //var é estático e por isso não precisei usar new Json...
        LinqFilter.FiltrarMusicaCSharp(musicas);
        //musicas[0].ExibirDetalhesMusica();
        //LinqFilter.FiltrarTodosGenerosMusicais(musicas);
        //LinqOrder.ExibirListaArtistaOrdenado(musicas);
        //LinqFilter.FiltrarArtistaGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicaUmArtista(musicas, "Twenty One Pilots");

        //var musicasPreferidasTarick = new MusicasPreferidas("Tárick");
        //musicasPreferidasTarick.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasTarick.AdicionarMusicasFavoritas(musicas[10]);
        //musicasPreferidasTarick.AdicionarMusicasFavoritas(musicas[60]);
        //musicasPreferidasTarick.AdicionarMusicasFavoritas(musicas[100]);
        //musicasPreferidasTarick.AdicionarMusicasFavoritas(musicas[201]);
        //musicasPreferidasTarick.ExibirMusicaFavoritas();

        //musicasPreferidasTarick.GerarArquivoJson();


    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
    
}