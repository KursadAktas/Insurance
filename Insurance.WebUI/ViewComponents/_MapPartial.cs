using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebUI.ViewComponents
{
	public class _MapPartial : ViewComponent
	{
		
		public IViewComponentResult Invoke()
		{
			InsuranceContext agricultureContext = new InsuranceContext(); //harita bilgisini viewbag ile taşıyorum.
			var values = agricultureContext.Adresses.Select(x=>x.MapInfo).FirstOrDefault();
			ViewBag.v = values;
			return View();
		}
	}
}
