using System.Runtime.Serialization;

namespace Kafe.CoreSystem
{
    public class Person : ISerializable
    {
        public string Name { get; set; }

        public string Sex { get; set; }

        public Person(string name, string sex)
        {
            Name = name;
            Sex = sex;
        }

        public Person()
        {
            Name = "Phanna";
            Sex = "Programmer";
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(nameof(Name), Name);
            info.AddValue(nameof(Sex), Sex);
        }
    }
}