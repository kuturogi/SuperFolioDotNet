using DataAccsesLayer.Abstract;
using DataAccsesLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccsesLayer.EntityFramework;

public class EfContactDal:GenericRepository<Contact>,IContactDal
{
    
}