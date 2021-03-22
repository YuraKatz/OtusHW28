using System;
using System.Reflection;
 
using Newtonsoft.Json;
 


namespace OtusHW28
{
    public class Animal : IMyCloneable, ICloneable
    {
        public Animal(string name)
        {
            Name = name;
        }

       


        public string Name { get; set; }


        public object Clone()
        {
            return MemberwiseClone();
        }

      
        public override string ToString()
        {
            PropertyInfo[] properties = this.GetType().GetProperties();
            string returnvalue = $"Class Type:{this.GetType()}{ Environment.NewLine}";
            foreach (PropertyInfo prop in properties)
            {
                returnvalue+= $"Property Name: {prop.Name} PropertyValue: {prop.GetValue (this, null)}{ Environment.NewLine}";

            }

            return returnvalue;



        }

        public T MyClone<T> (  )
        {
            var serialized = JsonConvert.SerializeObject(this );
            return JsonConvert.DeserializeObject<T>(serialized);
        }
    }
}