Episodio ep1 = new(2, "Técnica de facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("João");

Episodio ep2 = new(1, "Técnica de aprendizado", 67);
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Marcos");
ep2.AdicionarConvidados("Flavia");

Podecast podcast = new("Podcast especial", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();



/*
 Banda queen = new Banda("Queen");

Album albumQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true
};

//Poderia ter deixado e passado um por um mas posso usar chaves e passar tudo de uma vez
Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false
};

albumQueen.AdicionarMusica(musica1);
albumQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumQueen.ExibirMusicasAlbum();
queen.ExibirDiscografia();
*/