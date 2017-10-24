using System;
using System.Collections.Generic;

namespace Prototype
{
    interface Person {
        Person Clone();
    }

    class Tom : Person {

        private readonly String NAME = "Tom";

        public Person Clone()
        {
            return new Tom();
        }

        public override String ToString()
        {
            return this.NAME;
        }
    }
    class Dick : Person
    {

        private readonly String NAME = "Dick";

        public Person Clone()
        {
            return new Dick();
        }

        public override String ToString()
        {
            return this.NAME;
        }
    }
    class Harry : Person
    {

        private readonly String NAME = "Harry";

        public Person Clone()
        {
            return new Harry();
        }

        public override String ToString()
        {
            return this.NAME;
        }
    }

    class Factory
    {

        private static readonly Dictionary<string, Person> prototypes = new Dictionary<string, Person>()
            {
                {"tom", new Tom()},
                {"dick", new Dick()},
                {"harry", new Harry()},

        };
      



       
        public static Person GetProtoype(string type){
            //nullpointerexception
            //if (type == null)
            //{
            //    throw new ArgumentNullException();
            //}
            try
            {

                return prototypes[type].Clone();
            }
            catch (Exception e)
            {
                Console.WriteLine("Prototype with name: " + type + ", doesn't exist");
               // Console.WriteLine("{0} Exception caught", e);
               return null;
            }
            
        }


    }

    class PrototypeFactory{
        public static void Main(string[] args)
    {
            if (args.Length > 0)
            {
                foreach (string type in args)
                {
                    Person prototype = Factory.GetProtoype(type);
                    if (prototype != null)
                    {
                        Console.WriteLine(prototype);
                    }
                }
            }
            else
            {
                Console.WriteLine("Run again with arguments of command string ");
            }

    }


    }

}//end namespace


