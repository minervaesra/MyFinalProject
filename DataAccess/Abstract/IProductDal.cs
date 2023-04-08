using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //ınterface ın kendisi default publicdeğildir ama metodları default public  dir
    public interface IProductDal:IEntityRepository<Product>
    {
       
    }
}
