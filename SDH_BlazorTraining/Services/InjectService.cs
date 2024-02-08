using MudBlazor;

namespace SDH_BlazorTraining.Services
{
    public class InjectService
    {
        private readonly IDialogService _dialogService;

        public InjectService(IDialogService dialogService)
        {
            _dialogService = dialogService;
        }

        public void ShowMessage(ResponseModel response)
        {
            var parameters = new DialogParameters<MessageBox>();
            parameters.Add(x => x.Response, response);

            var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };

            _dialogService.Show<MessageBox>(response.RespType.ToString(), parameters, options);
        }
    }
    }
}
