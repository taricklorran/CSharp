class Musica
{
    //construtor
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome {  get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel {  get; set; } //-->vira propriedade public int teste --> atributo
    public string DescricaoResumida 
    { 
        get {  return $"A música {Nome} pertence a banda {Artista}."; }
    } //--> atalho prop + tab


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"duração: {Duracao}");
        if ( Disponivel )
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
        
    }
}

