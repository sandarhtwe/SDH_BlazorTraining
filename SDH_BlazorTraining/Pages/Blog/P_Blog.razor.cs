using Radzen.Blazor;

namespace SDH_BlazorTraining.Pages.Blog
{
    public partial class P_Blog
    {
        private BlogDataModel reqModel { get; set; } = new BlogDataModel();
        RadzenDataGrid<BlogDataModel> dataGrid;
        private List<BlogDataModel> dataList;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if(firstRender)
            {

            }
        }

        private void Cancel()
        {
           reqModel = new BlogDataModel();
        }

        private async Task Save()
        {
            Console.WriteLine(reqModel.Blog_Title);
            Console.WriteLine(reqModel.Blog_Author);
            Console.WriteLine(reqModel.Blog_Content);

            await _dbContext.Blogs.AddAsync(reqModel);
            await _dbContext.SaveChangesAsync();

            _injectService.ShowMessage(new ResponseModel("000","Saving Successful",EnumResponseType.Success));
            //reqModel=new BlogDataModel();
        }
    }
}
