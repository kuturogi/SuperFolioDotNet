using BusinessLayer.Concrete;
using DataAccsesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Service;

public class ServiceList: ViewComponent
{
    private ServiceManager servicemanager = new ServiceManager(new EfServiceDal());

    public IViewComponentResult Invoke()
    {
        var values = servicemanager.TGetList();
        return View(values);
    }
}