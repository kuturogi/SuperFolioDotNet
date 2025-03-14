using BusinessLayer.Concrete;
using DataAccsesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Skill;

public class SkillList: ViewComponent
{
    private SkillManager skillmanager = new SkillManager(new EfSkillDal());
    
    public IViewComponentResult Invoke()
    {
        var values = skillmanager.TGetList();
        return View(values);
    }
}