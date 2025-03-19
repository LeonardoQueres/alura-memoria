namespace UsuarioLib;

public class UsuarioDto
{
    public UsuarioDto(string nome, string email, List<string> telefones)
    {
        Nome = nome;
        Email = email;
        Telefones = telefones;
    }

    public string Nome { get; set; }
    public string Email { get; set; }
    public List<string> Telefones { get; set; }
}