namespace DlinkDFE.Web.MockData
{
    public static class UsuariosMockData
    {
        public static Usuario GetUsuarioLogado()
        {
            return new Usuario
            {
                Nome = "Usuário Teste",
                FotoPerfil = "/images/user.png"
            };
        }
    }

    public class Usuario
    {
        public string Nome { get; set; }
        public string FotoPerfil { get; set; }
    }
}
