using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflactionDemoProject
{
    public class CustomerInfoClass
    {
        public static void CuntumerInfoMethord()
        {
            Type type = Type.GetType("ReflactionDemoProject.CustemerClass");
            Console.WriteLine("Full Name : {0}", type.FullName);
            Console.WriteLine("Full Name : {0}", type.Name);
            Console.WriteLine("Full Name : {0}", type.Namespace);

            PropertyInfo[] propertyInfos = type.GetProperties();

            foreach (PropertyInfo property in propertyInfos)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }

            ConstructorInfo[] constructorInfo = type.GetConstructors();

            foreach (ConstructorInfo constructor in constructorInfo)
            {
                Console.WriteLine(constructor.ToString());
            }

            MethodInfo[] methodInfos = type.GetMethods();
            foreach (MethodInfo Info in methodInfos)
            {
                Console.WriteLine(Info.ReturnType.Name+" "+Info.Name);
            }
        }
    }
}
