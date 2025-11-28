using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        public void Add(Product product)  //cretae
        {
            throw new NotImplementedException();
        }


        public List<Product> GetAll() //read
        {
            throw new NotImplementedException();
        }

        public void Update(Product product) //update
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product) //delete
        {
            throw new NotImplementedException();
        }
    }


}
