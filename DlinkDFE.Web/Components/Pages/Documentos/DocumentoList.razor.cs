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
        protected IEnumerable<Documento> FilteredDocumentos => ApplyFilter(DocumentosList);

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
            DocumentosList = DocumentoService.GetDocumentosAsync();
            ApplyFilters();
        }

        protected void ApplyFilters()
        {
            ApplyFilter(DocumentosList);
            StateHasChanged(); // Atualiza a UI para aplicar filtros
        }

        private IEnumerable<Documento> ApplyFilter(IEnumerable<Documento> documentos)
        {
            var filtered = documentos;

            if (!string.IsNullOrWhiteSpace(_searchString))
            {
                filtered = filtered.Where(x => x.Status.Contains(_searchString, StringComparison.OrdinalIgnoreCase)
                                                || x.Numero.Contains(_searchString, StringComparison.OrdinalIgnoreCase)
                                                || x.Destinatario.Contains(_searchString, StringComparison.OrdinalIgnoreCase)
                                                || x.Modelo.Contains(_searchString, StringComparison.OrdinalIgnoreCase)
                                                || x.Valor.ToString().Contains(_searchString, StringComparison.OrdinalIgnoreCase)
                                                || x.Emissao.ToString().Contains(_searchString, StringComparison.OrdinalIgnoreCase));
            }

            if (_selectedStatuses.Any())
            {
                filtered = filtered.Where(x => _selectedStatuses.Contains(x.Status));
            }

            if (_selectedModels.Any())
            {
                filtered = filtered.Where(x => _selectedModels.Contains(x.Modelo));
            }

            return filtered;
        }


        protected async Task OnModelChanged(IEnumerable<string> selectedValues)
        {
            _selectedModels = new HashSet<string>(selectedValues);
            // A chamada ao serviço deve considerar a lista completa e não substituir
            DocumentosList = DocumentoService.GetDocumentosAsync(); // Atualiza a lista completa
            ApplyFilters(); // Aplica os filtros com a nova seleção
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
                ApplyFilters();
            }
        }
    }
}
