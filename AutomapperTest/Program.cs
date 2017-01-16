using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace AutomapperTest
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoMapperConfig.Config();

            var entity=new EntityA()
            {
                PropertyA = 1,
                PropertyB = 2,
                CreateTime = DateTime.Parse("1970-02-01")
            };


            var viewA = Mapper.Instance.Map<ViewModelA>(entity);

            var viewB = Mapper.Instance.Map<ViewModelB>(entity);

            Console.WriteLine(viewA.PropertyA);

            Console.WriteLine(viewB.PropertyB);
            Console.WriteLine("viewA.CreateTimeFromB {0}", viewA.CreateTimeFromB);
            Console.WriteLine("viewA.CreateTime {0}", viewA.CreateTime);
            Console.WriteLine("viewB.CreateTimeFromB {0}", viewB.CreateTimeFromB);
            Console.WriteLine("viewB.CreateTime {0}", viewB.CreateTime);

            Console.WriteLine();

            var entityB=new EntityB()
            {
                CreateTime =DateTime.Parse("2007-07-07")
            };

             viewA = Mapper.Instance.Map(entityB,viewA);

             viewB = Mapper.Instance.Map(entityB,viewB);

            Console.WriteLine("viewA.CreateTimeFromB {0}", viewA.CreateTimeFromB);
            Console.WriteLine("viewA.CreateTime {0}", viewA.CreateTime);
            Console.WriteLine("viewB.CreateTimeFromB {0}", viewB.CreateTimeFromB);
            Console.WriteLine("viewB.CreateTime {0}", viewB.CreateTime);


            Console.Read();
        }
    }
}
