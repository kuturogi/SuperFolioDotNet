using DataAccsesLayer.Abstract;
using DataAccsesLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccsesLayer.EntityFramework;

public class EfExperienceDal:GenericRepository<Experience>, IExperienceDal
{
    
}