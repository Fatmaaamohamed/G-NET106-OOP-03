namespace Smart_Delivery_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part01

            #region Question01

            /* a) Method Overloading (Compile-Time): Multiple methods in the same class with the same name but different parameters (type, number, or order).
                  Method Overriding (Run-Time): A subclass provides a specific implementation of a method already declared in its parent class using the exact 
                  same signature (name, parameters, and return type).
             
             
               b) Early binding is resolved at compile time by the compiler,bases the call on the variable's reference type,uses new or no keywords and applies to overloading,
                  method hiding, static, and non-virtual methodsis faster due to fixed target resolution but offers less flexibility.
                  
                  late binding is resolved at run time by the CLR, relies on the actual object in memory , uses virtual and override keywords and applies to method overriding,
                  abstract methods, and interface methods, is slightly slower due to runtime per-call lookups but enables dynamic polymorphism.
             
             
             
             */


            #endregion


            #region Question02

            /*
             a) The sealed keyword prevents other classes from inheriting from it. It locks the entire class definition,
                ensuring that its behavior cannot be modified or extended through subclassing.


             b) Sealed Class: Prevents inheritance entirely. No class can derive from a sealed class.
              
                Sealed Method: Prevents further overriding of a specific method down the inheritance chain while still allowing the class itself to be inherited.
                It must always be combined with the override keyword (public sealed override void Method()) in a derived class.
             

             c) No,Because applying sealed override to a method locks its behavior at that point in the inheritance hierarchy.
             
             
             */



            #endregion

            #endregion

            #region Question09
            Driver driver = new Driver { DriverName = "Ahmed Mohamed" };


            DeliveryCenter center = new DeliveryCenter("Main Delivery Center");

            center.AssignedDriver = driver;

            Console.WriteLine("===================================");
            Console.WriteLine($"Delivery Center: {center.CenterName}");
            Console.WriteLine("===================================");
            Console.WriteLine($"Driver : {center.AssignedDriver?.DriverName}");
            Console.WriteLine();

            StandardShipment standard = new StandardShipment(
                "SH001",
                "Laptop",
                3m,
                70m,
                new DeliveryAddress { City = "Cairo" }
            );

            ExpressShipment express = new ExpressShipment(
                "SH002",
                "Mobile Phone",
                2m,
                60m,
                new DeliveryAddress { City = "Giza" },
                30m
            );

            InternationalShipment international = new InternationalShipment(
                "SH003",
                "Television",
                3m,
                120m,
                new DeliveryAddress { City = "Berlin" },
                "Germany",
                100m
            );


            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);

            center.PrintAllShipments();
            Console.WriteLine();


            Console.WriteLine("Printing Using DeliveryHelper...");
            Console.WriteLine("-----------------------------------");
            DeliveryHelper.PrintShipmentDetails(standard);
            Console.WriteLine("Standard Shipment Printed Successfully.\n");

            DeliveryHelper.PrintShipmentDetails(express);
            Console.WriteLine("Express Shipment Printed Successfully.\n");

            DeliveryHelper.PrintShipmentDetails(international);
            Console.WriteLine("International Shipment Printed Successfully.");
            Console.WriteLine("===================================\n");

            Console.WriteLine("Updating Weight...");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Original Weight : {standard.Weight} KG");

            standard.UpdateWeight(5m);
            Console.WriteLine($"Updated Weight : {standard.Weight} KG");

            standard.UpdateWeight(5m, 0.5m);
            Console.WriteLine($"Updated Weight After Packing : {standard.Weight} KG");
            Console.WriteLine("===================================\n");

          
            Console.WriteLine("Printing Using Shipment[]...");
            Console.WriteLine("-----------------------------------");
            Shipment[] mixedShipments = new Shipment[] { standard, express, international };

            foreach (Shipment s in mixedShipments)
            {
                if (s is StandardShipment)
                    Console.WriteLine("Standard Shipment...");
                else if (s is ExpressShipment)
                    Console.WriteLine("Express Shipment...");
                else if (s is InternationalShipment)
                    Console.WriteLine("International Shipment...");

                s.PrintShipment();
                Console.WriteLine();
            }
        }

            #endregion
    }
}
