using System.Web.Mvc;
using Toastr.Helper;

namespace Toastr.Controllers
{
    public abstract class BaseController : Controller
    {
        public Toastr.Helper.Toastr Toastr { get; set; }

        public ToastMessage AddToastMessage(string title, string message, ToastType toastType)
        {
            return Toastr.AddToastMessage(title, message, toastType);
        }
    }
}