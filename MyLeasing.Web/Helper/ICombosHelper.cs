using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyLeasing.Web.Helper
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboPropertyTypes();
    }
}