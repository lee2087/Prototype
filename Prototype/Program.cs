using System;
using System.Collections.Generic;

namespace Prototype
{

    /********************************************
         interface Person {
         Person clone();
         }
    */
    interface Person {
        Person Clone();
    }


    /********************************************
        class Tom implements Person {
        private final String NAME = "Tom";

        @Override
        public Person clone() {
            return new Tom();
        }

        @Override
        public String toString() {
            return NAME;
        }
        }
    */
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


    /*******************************************
        class Dick implements Person {
        private final String NAME = "Dick";

        @Override
        public Person clone() {
            return new Dick();
        }

        @Override
        public String toString() {
            return NAME;
        }
        }
    */
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


    /********************************************
        class Harry implements Person {
        private final String NAME = "Harry";

        @Override
        public Person clone() {
            return new Harry();
        }

        @Override
        public String toString() {
            return NAME;
        }
        }
    */
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


    /********************************************
        class Factory {
        private static final Map<String, Person> prototypes = new HashMap<>();

        static {
            prototypes.put("tom", new Tom());
            prototypes.put("dick", new Dick());
            prototypes.put("harry", new Harry());
        }

        public static Person getPrototype(String type) {
            try {
                return prototypes.get(type).clone();
            } catch (NullPointerException ex) {
                System.out.println("Prototype with name: " + type + ", doesn't exist");
                return null;
            }
        }
        }
    */
    class Factory
    {
        private static readonly Dictionary<string, Person> prototypes = new Dictionary<string, Person>()
            {
                {"tom", new Tom()},
                {"dick", new Dick()},
                {"harry", new Harry()}
        };

        public static Person GetProtoype(string type){
            try
            {
              return prototypes[type].Clone();
            }
            catch (Exception e)
            {
                Console.WriteLine("Prototype with name: " + type + ", doesn't exist");
               return null;
            }
            
        }

    }




    /*******************************************
         public class PrototypeFactory {
         public static void main(String[] args) {
            if (args.length > 0) {
                for (String type : args) {
                    Person prototype = Factory.getPrototype(type);
                    if (prototype != null) {
                        System.out.println(prototype);
                    }
                }
            } else {
                System.out.println("Run again with arguments of command string ");
            }
        }
        }
    */
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


