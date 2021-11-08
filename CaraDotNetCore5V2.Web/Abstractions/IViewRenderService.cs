using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Web.Abstractions
{
    public interface IViewRenderService
    {
        Task<string> RenderViewToStringAsync<TModel>(string viewName, TModel model);
    }
}