using ScreenSoundAPI.Filtros;
using ScreenSoundAPI.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{


    try
    {
        string respotas = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(respotas)!;
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarMusicasPorGenero(musicas, "rock");
        //LinqFilter.FiltrarMusicasPorArtista(musicas, "U2");
        LinqFilter.FiltrarMusicasPorAno(musicas, 2000);

    } catch (Exception ex) 
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}