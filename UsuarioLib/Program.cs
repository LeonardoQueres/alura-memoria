using UsuarioLib;

Usuario usuario = 
    new(
        "Daniel", 
        "daniel@email.com",
        ["12345678"]);

//12345678
usuario.ExibeTelefones();

//efetuar a padronização
usuario.PadronizaTelefones();

//912345678
usuario.ExibeTelefones();