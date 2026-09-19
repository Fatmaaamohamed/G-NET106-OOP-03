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

        }
    }
}
