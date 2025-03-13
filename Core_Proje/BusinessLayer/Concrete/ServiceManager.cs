using BusinessLayer.Abstract;
using DataAccsesLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BusinessLayer.Concrete;

public class ServiceManager: IGenericService<Service>
{
     IServiceDal _serviceDal;

     public ServiceManager(IServiceDal serviceDal)
     {
         _serviceDal = serviceDal;
     }
    public void TAdd(Service t)
    {
         _serviceDal.Insert(t);
    }

    public void TDelete(Service t)
    {
        _serviceDal.Delete(t);
    }

    public void TUpdate(Service t)
    {
        _serviceDal.Update(t);
    }

    public List<Service> TGetList()
    {
       return _serviceDal.GetList();
        
    }

    public Service TGetByID(int id)
    {
        return _serviceDal.GetByID(id);
    }
}