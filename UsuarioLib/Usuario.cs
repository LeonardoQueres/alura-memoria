using System.Diagnostics;

namespace UsuarioLib;

public class Usuario
{

    public Usuario(string nome, string email, List<string> telefone)
    {
        Nome = nome;
        Email = email;
        Telefones = telefone;
        ChaveDeAcesso = [.. new Guid[10]];
        Stopwatch stopwatch = new();
        stopwatch.Start();
        Console.WriteLine("Inicio da execução List");
        for (int i = 0; i < 1000000; i++)
        {
            ChaveDeAcesso.Add(Guid.NewGuid());
        }
        stopwatch.Stop();
        Console.WriteLine($"Tempo Total List em ms: {stopwatch.Elapsed.TotalMilliseconds}");

        ChaveDeAcessoLinkedList = new LinkedList<Guid>();
        ChaveDeAcessoLinkedList.AddFirst(Guid.NewGuid());
        Stopwatch stopwatchLinkedList = new();
        stopwatchLinkedList.Start();
        Console.WriteLine("Inicio da execução LinkedList");
        for (int i = 0; i < 1000000; i++)
        {
            ChaveDeAcessoLinkedList.AddAfter(ChaveDeAcessoLinkedList.First, Guid.NewGuid());
        }
        stopwatchLinkedList.Stop();
        Console.WriteLine($"Tempo Total LinkedList em ms: {stopwatchLinkedList.Elapsed.TotalMilliseconds}");
    }

    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public List<string> Telefones { get; set; }
    public List<Guid> ChaveDeAcesso { get; set; }
    public LinkedList<Guid> ChaveDeAcessoLinkedList { get; set; }

    public void PadronizaTelefones()
    {
        Telefones = [.. Telefones.Select(telefone =>
            telefone.Length == 8 ?
            telefone = "9" + telefone :
            telefone
        )];
    }

    public void ExibeTelefones()
    {
        Telefones.ForEach(telefone => Console.WriteLine(telefone));
    }
}
