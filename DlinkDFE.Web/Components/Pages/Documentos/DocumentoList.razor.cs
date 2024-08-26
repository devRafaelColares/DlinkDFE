using Microsoft.AspNetCore.Components;
using DlinkDFE.Web.Services;
using MudBlazor;
using DlinkDFE.Web.MockData;

namespace DlinkDFE.Web.Components.Pages.DocumentoList
{
    public class DocumentoListBase : ComponentBase
    {
        [Inject]
        protected DocumentoService DocumentoService { get; set; }

        protected IEnumerable<Documento> DocumentosList = new List<Documento>();
        protected IEnumerable<Documento> FilteredDocumentos => DocumentosList.Where(_quickFilter);
        protected string _searchString;

        protected MudMessageBox _mudMessageBox;

        protected Func<Documento, bool> _quickFilter => x =>
        {
            if (string.IsNullOrWhiteSpace(_searchString))
                return true;

            if (x.Status.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if (x.Numero.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if (x.Destinatario.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;

            return false;
        };

        protected override Task OnInitializedAsync()
        {
            DocumentosList = DocumentoService.GetDocumentos();
            return Task.CompletedTask;
        }

        protected void ApplyFilters()
        {
            StateHasChanged(); // Atualiza a UI para aplicar filtros
        }

        protected async Task ShowCancelConfirmation()
        {
            bool? result = await _mudMessageBox.ShowAsync();
            if (result == true)
            {
                // Lógica para cancelar o documento
                // Pode incluir uma chamada para o serviço DocumentoService para realizar o cancelamento
                // e/ou atualizar a lista DocumentosList
                // Atualize o estado para refletir a mudança
            }
            else
            {
                // Lógica para quando o cancelamento é abortado pelo usuário
            }
        }
    }
}
