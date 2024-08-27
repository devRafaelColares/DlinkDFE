using DlinkDFE.Web.MockData;

namespace DlinkDFE.Web.Services
{
    public class DocumentoService
    {
        public List<Documento> GetDocumentosAsync()
        {
            return DocumentosMockData.GetDocumentosAsync();
        }
    }
}
