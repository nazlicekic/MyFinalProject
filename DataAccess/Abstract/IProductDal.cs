using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{//interfacesin operasyonları public kendisi degil
    //benim veritanında kullanacağım operasyonlar yer alıcak.
    //Sunu getir bunu getir. Sepete bisey alıp koyma
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
       
    }
}

//Code Refactoring 