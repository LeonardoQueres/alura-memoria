namespace UsuarioLib;

public class UsuarioDto(string nome, string email, List<string> telefones)
{
    public string Nome { get; set; } = nome;
    public string Email { get; set; } = email;
    public List<string> Telefones { get; set; } = telefones;
}