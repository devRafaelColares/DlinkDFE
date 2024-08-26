using DlinkDFE.Web.MockData;

namespace DlinkDFE.Web.Services
{
    public class UsuarioService
    {
        public Usuario GetUsuarioLogado()
        {
            return UsuariosMockData.GetUsuarioLogado();
        }
    }
}
