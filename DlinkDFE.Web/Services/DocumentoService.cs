using DlinkDFE.Web.MockData;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DlinkDFE.Web.Services
{
    public class DocumentoService
    {
        private readonly IEnumerable<Documento> _documentos;

        public DocumentoService()
        {
            _documentos = DocumentosMockData.GetDocumentosAsync(); // Mock data source
        }

        public Task<IEnumerable<Documento>> GetDocumentosAsync(string searchString, HashSet<string> statuses, HashSet<string> models)
        {
            var documentos = _documentos.Where(d =>
                (string.IsNullOrWhiteSpace(searchString) || d.Numero.Contains(searchString, StringComparison.OrdinalIgnoreCase)) &&
                (!statuses.Any() || statuses.Contains(d.Status)) &&
                (!models.Any() || models.Contains(d.Modelo)))
                .ToList();

            return Task.FromResult(documentos.AsEnumerable());
        }
    }
}
