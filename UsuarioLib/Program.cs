using UsuarioLib;

Usuario usuario = 
    new(
        "Daniel", 
        "daniel@email.com",
        ["12345678"]);

Usuario usuario2 =
    new(
        "Luis",
        "luis@email.com",
        ["87654321"]);


//12345678
usuario.ExibeTelefones();

//efetuar a padronização
usuario.PadronizaTelefones();

//912345678
usuario.ExibeTelefones();