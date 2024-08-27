using DlinkDFE.Web.MockData;

namespace DlinkDFE.Web.Services
{
    public class DocumentoService
    {
        public List<Documento> GetDocumentosAsync()
        {
            return DocumentosMockData.GetDocumentosAsync();
        }

        public List<Documento> GetListDocumentosByModeloAsync(string modelo)
        {
            return DocumentosMockData.GetDocumentosAsync()
                .Where(d => d.Modelo.Equals(modelo, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
