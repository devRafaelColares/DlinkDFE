using Microsoft.AspNetCore.Components;
using DlinkDFE.Web.Services;
using MudBlazor;
using DlinkDFE.Web.MockData;
using System.Threading.Tasks;
using System.Linq;

namespace DlinkDFE.Web.Components.Pages.Documentos
{
    public class DocumentoListBase : ComponentBase
    {
        [Inject]
        protected DocumentoService DocumentoService { get; set; }

        protected IEnumerable<Documento> DocumentosList = new List<Documento>();
        protected IEnumerable<Documento> FilteredDocumentos => ApplyFilter(DocumentosList);

        protected string _searchString;
        protected HashSet<string> _selectedStatuses = new HashSet<string>();
        protected MudMessageBox _mudMessageBox;

        public string[] _statusOptions = new string[]
        {
            "Autorizado", "Pendente", "Inutilizado", "Cancelado", "Rejeitado"
        };

        protected override async Task OnInitializedAsync()
        {
            DocumentosList = DocumentoService.GetDocumentosAsync();
        }

        private IEnumerable<Documento> ApplyFilter(IEnumerable<Documento> documentos)
        {
            return documentos
                .Where(x => string.IsNullOrWhiteSpace(_searchString) || 
                            x.Status.Contains(_searchString, StringComparison.OrdinalIgnoreCase) || 
                            x.Numero.Contains(_searchString, StringComparison.OrdinalIgnoreCase) || 
                            x.Destinatario.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                .Where(x => !_selectedStatuses.Any() || _selectedStatuses.Contains(x.Status));
        }

        protected async Task ShowCancelConfirmation()
        {
            bool? result = await _mudMessageBox.ShowAsync();
            if (result == true)
            {
                // Lógica para cancelar o documento
                // Pode incluir uma chamada para o serviço DocumentoService para realizar o cancelamento
                // e/ou atualizar a lista DocumentosList
                DocumentosList = DocumentosList.Where(d => d.Status != "Cancelado").ToList();
                StateHasChanged(); // Atualiza a UI para refletir mudanças na lista de documentos
            }
        }
    }
}
