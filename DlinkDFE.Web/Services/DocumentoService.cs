using DlinkDFE.Web.MockData;

namespace DlinkDFE.Web.Services
{
    public class DocumentoService
    {
        public List<Documento> GetDocumentosAsync()
        {
            return DocumentosMockData.GetDocumentosAsync();
        }

        public List<Documento> GetListDocumentosByModeloAsync(IEnumerable<string> modelos)
        {
            return DocumentosMockData.GetDocumentosAsync()
                .Where(d => modelos.Contains(d.Modelo, StringComparer.OrdinalIgnoreCase))
                .ToList();
        }

    }
}
