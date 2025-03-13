using BusinessLayer.Concrete;
using DataAccsesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.About;

public class AboutList: ViewComponent
{
    private AboutManager aboutmanager = new AboutManager(new EfAbaoutDal());

    public IViewComponentResult Invoke()
    {
        var values = aboutmanager.TGetList();
        return View(values);
    }


}