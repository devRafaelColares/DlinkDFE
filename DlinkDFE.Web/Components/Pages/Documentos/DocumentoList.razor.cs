using Microsoft.AspNetCore.Components;
using DlinkDFE.Web.Services;
using MudBlazor;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DlinkDFE.Web.MockData;

namespace DlinkDFE.Web.Components.Pages.Documentos
{
    public class DocumentoListBase : ComponentBase
    {
        [Inject]
        protected DocumentoService DocumentoService { get; set; }

        protected IEnumerable<Documento> DocumentosList { get; set; } = new List<Documento>();
        protected IEnumerable<Documento> FilteredDocumentos => DocumentosList;

        protected string _searchString;
        protected HashSet<string> _selectedStatuses = new HashSet<string>();
        protected HashSet<string> _selectedModels = new HashSet<string>();
        protected MudMessageBox _mudMessageBox;

        public string[] _statusOptions = new string[]
        {
            "Autorizado", "Pendente", "Inutilizado", "Cancelado", "Rejeitado"
        };

        public string[] _modelOptions = new string[]
        {
            "55", "65"
        };

        protected override async Task OnInitializedAsync()
        {
            await LoadDocumentosAsync();
        }

        private async Task LoadDocumentosAsync()
        {
            DocumentosList = DocumentoService.GetDocumentosAsync(_searchString, _selectedStatuses, _selectedModels);
            // No momento, não aplicamos filtros adicionais aqui
            // ApplyFilters(); // Não necessário se os filtros são aplicados pelo serviço
        }

        protected async Task OnModelChanged(IEnumerable<string> selectedValues)
        {
            _selectedModels = new HashSet<string>(selectedValues);
            await LoadDocumentosAsync(); // Atualiza a lista completa com os novos filtros
        }

        protected async Task ShowCancelConfirmation()
        {
            bool? result = await _mudMessageBox.ShowAsync();
            if (result == true)
            {
                // Lógica para cancelar o documento
                DocumentosList = DocumentosList.Where(d => d.Status != "Cancelado").ToList();
                // ApplyFilters(); // Se a lógica de cancelamento requer novos filtros, use aqui
            }
        }
    }
}
