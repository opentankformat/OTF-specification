namespace otfSampleDataGenerator.utils
{
    using System;
    using System.Reflection;

    public class DummyDataGenerator
    {
        public static T GenerateDummyData<T>() where T : new()
        {
            return (T)GenerateDummyData(typeof(T), 0);
        }

        private static object GenerateDummyData(Type type, int depth)
        {
            if (depth > 99)  // Limit the recursion depth to prevent infinite loops
                return null;

            if (type.IsValueType || type == typeof(string))
            {
                return GetDefaultValue(type);
            }
            else if (type.IsClass)
            {
                object instance = Activator.CreateInstance(type);

                FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

                foreach (FieldInfo field in fields)
                {
                    Type fieldType = field.FieldType;

                    if (fieldType.IsArray)
                    {
                        Type elementType = fieldType.GetElementType();
                        Array array = Array.CreateInstance(elementType, 2);

                        for (int i = 0; i < 2; i++)
                        {
                            array.SetValue(GenerateDummyData(elementType, depth + 1), i);
                        }

                        field.SetValue(instance, array);
                    }
                    else if (fieldType.IsClass)
                    {
                        object fieldValue = GenerateDummyData(fieldType, depth + 1);
                        field.SetValue(instance, fieldValue);
                    }
                    else if (fieldType.IsValueType)
                    {
                        var v = GetDefaultValue(field.FieldType);
                        if (v != null) 
                        {
                            field.SetValue(instance, v);
                        };
                    }
                }

                return instance;
            }
            else
            {
                return null;
            }
        }

        private static object GetDefaultValue(Type type)
        {
            //if (type.IsValueType)
            //{
            //    return Activator.CreateInstance(type);
            //}
            if (type == typeof(string))
            {
                return "DummyString";
            }
            else if (type == typeof(int))
            {
                return 1;
            }
            else if (type == typeof(DateTime))
            {
                return DateTime.Now;
            }
            else if (type == typeof(float))
            {
                return 1;
            }
            else if (type == typeof(double))
            {
                return 1;
            }
            else if (type == typeof(bool))
            {
                return true;
            }
            else
            {
                return null;
            }
        }
    }

}