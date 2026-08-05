using System.Text.Json;

namespace ScreenSoundAPI.Modelos;

internal class MusicaFavoritas
{
    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; }

    public MusicaFavoritas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as musicas favoritas -> {Nome}");
        foreach(var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
        Console.WriteLine();
    }

    public void GerarArquivoJson() 
    {
        string Json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas,
        });

        string nomeDoArquivo = $"musicas_favoritas_{Nome}.json";


        File.WriteAllText(nomeDoArquivo, Json);
        Console.WriteLine($"O arquivo JSON foi gerado com sucesso!{Path.GetFullPath(nomeDoArquivo)}");
    }

}
