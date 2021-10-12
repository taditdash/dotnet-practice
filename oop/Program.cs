using System;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Inheritance
            // Inheritance.cs
            // ---------------

            // -- Base Class constructor called. --
            //BaseClass BaseClass = new BaseClass();

            // -- Base Class + Derived Class constructors called. --
            //DerivedClass DerivedClass = new DerivedClass();
            //BaseClass DerivedClass = new DerivedClass();
            
            // --- Base Class to Derive Class type assignment.
            // Cannot implicitly convert type 'oop.BaseClass' to 'oop.DerivedClass'.
            // An explicit conversion exists (are you missing a cast? ---
            //DerivedClass DerivedClass = new BaseClass();

            // -- Multiple Base class -- 
            // Class 'DerivedClassWithMultipleBaseClass' cannot have multiple base classes:
            // 'BaseClass' and 'AnotherBaseClass'
            //DerivedClassWithMultipleBaseClass DerivedClassWithMultipleBaseClass
            //    = new DerivedClassWithMultipleBaseClass();

            // -- Base Class method call.
            // -- OUTPUT --
            // BaseClass Constructor
            // BaseClassMethod
            // ------------
            // BaseClass BaseClass = new BaseClass();
            // BaseClass.BaseClassMethod();

            // -- Derived Class method call.
            // -- OUTPUT --
            // BaseClass Constructor
            // DerivedClass Constructor
            // DerivedClassMethod
            // ------------
            // DerivedClass DerivedClass = new DerivedClass();
            // DerivedClass.DerivedClassMethod();

            // -- Derived Class method call by casting it to Base Class.
            // -- OUTPUT --
            // 'BaseClass' does not contain a definition for 'DerivedClassMethod' 
            // and no accessible extension method 'DerivedClassMethod' accepting a 
            // first argument of type 'BaseClass' could be found
            // ------------
            // BaseClass DerivedClass = new DerivedClass();
            // DerivedClass.DerivedClassMethod();

            // -- Same method both in Base Class and Derived Class.
            // Call the method by a DerivedClass object boxed to Base Class.
            // -- OUTPUT --
            // BaseClass Constructor
            // DerivedClass Constructor
            // BaseClass: MethodWithSameNameInBaseAndDerivedClass called
            // ------------
            // BaseClass DerivedClass = new DerivedClass();
            // DerivedClass.MethodWithSameNameInBaseAndDerivedClass();

            // -- Same method both in Base Class and Derived Class.
            // Call the method by a DerivedClass object.
            // -- OUTPUT --
            // BaseClass Constructor
            // DerivedClass Constructor
            // DerivedClass: MethodWithSameNameInBaseAndDerivedClass called
            // ------------
            // DerivedClass DerivedClass = new DerivedClass();
            // DerivedClass.MethodWithSameNameInBaseAndDerivedClass();

            // -- Same method both in Base Class and Derived Class with override in derived class.
            // Call the method by a DerivedClass object.
            // -- OUTPUT --
            // BaseClass Constructor
            // DerivedClass Constructor
            // BaseClass: MethodWithSameNameInBaseAndDerivedClass called
            // ------------
            DerivedClass DerivedClass = new DerivedClass();
            DerivedClass.MethodThatCanBeOverriden();

            #endregion
        }
    }
}
