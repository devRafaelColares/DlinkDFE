using DlinkDFE.Web.MockData;

namespace DlinkDFE.Web.Services
{
    public class DocumentoService
    {
        public List<Documento> GetDocumentos()
        {
            return DocumentosMockData.GetDocumentos();
        }
    }
}
