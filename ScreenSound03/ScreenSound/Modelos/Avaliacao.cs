namespace ScreenSound.Modelos;
//Quando a classe é internal somente o projeto irá enxergar e se quiser que outros projetos enxergam usa o public
internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        Nota = nota;
    }
    public int Nota { get; }

    //static torna a função contida ai não precisa usar o new pode chamar pelo tipo
    public static Avaliacao Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}
