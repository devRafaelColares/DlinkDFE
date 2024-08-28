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
        protected IEnumerable<Documento> FilteredDocumentos => DocumentosList
            .Where(d => (string.IsNullOrWhiteSpace(_searchString) || d.Numero.Contains(_searchString, StringComparison.OrdinalIgnoreCase)) &&
                        (!_selectedStatuses.Any() || _selectedStatuses.Contains(d.Status)) &&
                        (!_selectedModels.Any() || _selectedModels.Contains(d.Modelo)))
            .ToList();

        protected string _searchString;
        protected HashSet<string> _selectedStatuses = new HashSet<string>();
        protected HashSet<string> _selectedModels = new HashSet<string>();
        protected MudMessageBox _mudMessageBox;
        
        [Parameter]
        public int ValorInicial { get; set; }
        
        [Parameter]
        public int ValorFinal { get; set; }

        [Parameter]
        public string EmissaoOuAutorizacao { get; set; }

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
            DocumentosList = await DocumentoService.GetDocumentosAsync(_searchString, _selectedStatuses, _selectedModels);
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
            }
        }

        public void ResetFilters()
        {
            _searchString = string.Empty;
            _selectedStatuses.Clear();
            _selectedModels.Clear();
            StateHasChanged();
        }
    }
}
