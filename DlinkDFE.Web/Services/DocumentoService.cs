using System.Collections.Generic;
using System.Linq;
using DlinkDFE.Web.MockData;

namespace DlinkDFE.Web.Services
{
    public class DocumentoService
    {
        public List<Documento> GetDocumentosAsync(string searchString = null, HashSet<string> statuses = null, HashSet<string> modelos = null)
        {
            var documentos = DocumentosMockData.GetDocumentosAsync();

            if (!string.IsNullOrWhiteSpace(searchString))
            {
                documentos = documentos.Where(x => x.Status.Contains(searchString, StringComparison.OrdinalIgnoreCase)
                                                || x.Numero.Contains(searchString, StringComparison.OrdinalIgnoreCase)
                                                || x.Destinatario.Contains(searchString, StringComparison.OrdinalIgnoreCase)
                                                || x.Modelo.Contains(searchString, StringComparison.OrdinalIgnoreCase)
                                                || x.Valor.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase)
                                                || x.Emissao.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (statuses != null && statuses.Any())
            {
                documentos = documentos.Where(x => statuses.Contains(x.Status)).ToList();
            }

            if (modelos != null && modelos.Any())
            {
                documentos = documentos.Where(x => modelos.Contains(x.Modelo)).ToList();
            }

            return documentos;
        }
    }
}
