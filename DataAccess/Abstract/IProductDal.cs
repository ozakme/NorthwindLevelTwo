using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.Abstract;

namespace DataAccess.Abstract
{
    public interface IProductDal: IEntityRepository<Product>
    {
        //listeleme
        //ekleme
        //silme
        //güncelleme
    }
}
