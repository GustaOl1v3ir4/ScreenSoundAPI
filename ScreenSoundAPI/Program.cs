using ScreenSoundAPI.Filtros;
using ScreenSoundAPI.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{


    try
    {
        string respotas = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(respotas)!;

        LinqFilter.FiltrarMusicasDoSustenido(musicas);

        //musicas[1].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarMusicasPorGenero(musicas, "rock");
        //LinqFilter.FiltrarMusicasPorArtista(musicas, "U2");
        //LinqFilter.FiltrarMusicasPorAno(musicas, 2000);

        //var MusicasFavoritas = new MusicaFavoritas("Gustavo");
        //MusicasFavoritas.AdicionarMusicasFavoritas(musicas[1]);
        //MusicasFavoritas.AdicionarMusicasFavoritas(musicas[377]);
        //MusicasFavoritas.AdicionarMusicasFavoritas(musicas[6]);
        //MusicasFavoritas.AdicionarMusicasFavoritas(musicas[4]);
        //MusicasFavoritas.AdicionarMusicasFavoritas(musicas[1400]);

        //MusicasFavoritas.ExibirMusicasFavoritas();
        //MusicasFavoritas.GerarArquivoJson();

    } catch (Exception ex) 
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}