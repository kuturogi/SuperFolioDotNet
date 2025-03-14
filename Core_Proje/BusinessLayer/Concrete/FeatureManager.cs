using BusinessLayer.Abstract;
using DataAccsesLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class FeatureManager:IGenericService<Feature>
{
     IFeatureDal _featureDal;

     public FeatureManager(IFeatureDal featureDal)
     {
         _featureDal = featureDal;
     }
    
    public void TAdd(Feature t)
    {
        _featureDal.Insert(t);
    }

    public void TDelete(Feature t)
    {
        _featureDal.Delete(t);
    }

    public void TUpdate(Feature t)
    {
        _featureDal.Update(t);
    }

    public List<Feature> TGetList()
    {
        return _featureDal.GetList();
    }

    public Feature TGetByID(int id)
    {
        return _featureDal.GetByID(id);
    }
}