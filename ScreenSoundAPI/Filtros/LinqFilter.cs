using ScreenSoundAPI.Modelos;
using System.Data;
using System.Linq;

namespace ScreenSoundAPI.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGeneros = musicas.Select(genero => genero.Genero).Distinct().ToList();
        foreach(var genero in todosOsGeneros)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarMusicasPorGenero(List<Musica> musicas, string genero)
    {
        var artistasPorGenero = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(artista => artista.Artista).Distinct().ToList();
        foreach(var artista in artistasPorGenero)
        {
            Console.WriteLine($"Exibindo artistar por gênero musical: {genero}");
            foreach(var artista1 in artistasPorGenero)
            {
                Console.WriteLine($"- {artista1}");
            }
        }
    }

    public static void FiltrarMusicasPorArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var MusiscasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in MusiscasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarMusicasPorAno(List<Musica> musicas, int ano)
    {
        var musicasPorAno = musicas.Where(musica => musica.Ano == ano)
            .OrderBy(musica => musica.Nome)
            .Select(musicas => musicas.Nome)
            .Distinct()
            .ToList();

        Console.WriteLine($"Exibindo músicas do ano: {ano}");
        foreach (var musica in musicasPorAno)
        {
            Console.WriteLine($"- {musica}");
        }
    }

    internal static void FiltrarMusicasDoSustenido(List<Musica> musicas)
    {
        var musicasEmDoSustenido = musicas
            .Where(musica => musica.Tonalidade.Equals("C#"))
            .Select(musica => musica.Nome)
            .ToList();

        Console.WriteLine("Musicas em Do Sustenido:");
        foreach (var musica in musicasEmDoSustenido)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}
