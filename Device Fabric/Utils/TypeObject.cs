using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Device_Fabric.Utils
{
    public class TypeObject
    {
        public static TypeObject[] GetDerrivedElements(Type elementsParentType)
        {
            Type[] childrenTypes = elementsParentType.GetNestedTypes();

            if (HasProperties(childrenTypes))
                throw new Exception("Внутренние классы не должны иметь полей, так как представляют собой статичный контекст с методами по получению данных.");

            var childrenClasses = new List<TypeObject>();

            foreach (var childType in childrenTypes)
                childrenClasses.Add((TypeObject)Activator.CreateInstance(childType));

            return childrenClasses.ToArray();
        }

        private static bool HasProperties(Type[] types)
        {
            foreach (var type in types)
            {
                if (type.GetProperties().Length != 0)
                    return true;
            }

            return false;
        }
    }
}
