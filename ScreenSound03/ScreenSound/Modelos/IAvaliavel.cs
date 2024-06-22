/*
 * Quando for trabalhar com Interface que é garantir que algo seja entregue, devemos iniciar o nome com I maiusculo
 * Não existe execução de código dentro da interface
 */
namespace ScreenSound.Modelos;

internal interface IAvaliavel
{
    void AdicionarNota(Avaliacao nota);
    double Media { get; }
}
