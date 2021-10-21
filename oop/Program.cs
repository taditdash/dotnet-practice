using System;
using System.Runtime.InteropServices;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boxing
            int valToBeBoxed = 40;
            object objValBoxed = valToBeBoxed;

            // Unboxing
            int valUnBoxed = (int)objValBoxed;

            GCHandle gch = GCHandle.Alloc(objValBoxed, GCHandleType.Pinned);
            IntPtr pObj = gch.AddrOfPinnedObject();

            Console.WriteLine(valToBeBoxed);
            //Console.WriteLine(objValBoxed);
            Console.WriteLine(pObj.ToString());
            Console.WriteLine(valToBeBoxed);

            #region Inheritance
            // Inheritance.cs
            // ---------------

            // -- Base Class constructor called. --
            //BaseClass baseClass = new BaseClass();

            // -- Base Class + Derived Class constructors called. --
            //DerivedClass derivedClass = new DerivedClass();
            //BaseClass derivedClass = new DerivedClass();
            
            // --- Base Class to Derive Class type assignment.
            // Cannot implicitly convert type 'oop.BaseClass' to 'oop.DerivedClass'.
            // An explicit conversion exists (are you missing a cast? ---
            //DerivedClass derivedClass = new BaseClass();

            // -- Multiple Base class -- 
            // Class 'DerivedClassWithMultipleBaseClass' cannot have multiple base classes:
            // 'BaseClass' and 'AnotherBaseClass'
            //DerivedClassWithMultipleBaseClass derivedClassWithMultipleBaseClass
            //    = new DerivedClassWithMultipleBaseClass();

            // -- Base Class method call.
            // -- OUTPUT --
            // BaseClass Constructor
            // BaseClassMethod
            // ------------
            // BaseClass baseClass = new BaseClass();
            // baseClass.BaseClassMethod();

            // -- Derived Class method call.
            // -- OUTPUT --
            // BaseClass Constructor
            // DerivedClass Constructor
            // DerivedClassMethod
            // ------------
            // DerivedClass derivedClass = new DerivedClass();
            // derivedClass.DerivedClassMethod();

            // -- Derived Class method call by casting it to Base Class.
            // -- OUTPUT --
            // 'BaseClass' does not contain a definition for 'DerivedClassMethod' 
            // and no accessible extension method 'DerivedClassMethod' accepting a 
            // first argument of type 'BaseClass' could be found
            // ------------
            // BaseClass derivedClass = new DerivedClass();
            // derivedClass.DerivedClassMethod();

            // -- Same method both in Base Class and Derived Class.
            // Call the method by a DerivedClass object boxed to Base Class.
            // -- OUTPUT --
            // BaseClass Constructor
            // DerivedClass Constructor
            // BaseClass: MethodWithSameNameInBaseAndDerivedClass called
            // ------------
            // BaseClass derivedClass = new DerivedClass();
            // derivedClass.MethodWithSameNameInBaseAndDerivedClass();

            // -- Same method both in Base Class and Derived Class.
            // Call the method by a DerivedClass object.
            // -- OUTPUT --
            // BaseClass Constructor
            // DerivedClass Constructor
            // DerivedClass: MethodWithSameNameInBaseAndDerivedClass called
            // ------------
            // DerivedClass derivedClass = new DerivedClass();
            // derivedClass.MethodWithSameNameInBaseAndDerivedClass();

            // -- Same method both in Base Class and Derived Class.
            // Base Class method is virtual and in Derived Class, method is overriden.
            // Call the method by a DerivedClass object.
            // -- OUTPUT --
            // BaseClass Constructor
            // DerivedClass Constructor
            // DerivedClass: MethodThatCanBeOverriden called
            // ------------
            //DerivedClass derivedClass = new DerivedClass();
            //derivedClass.MethodThatCanBeOverriden();

            // -- Same method both in Base Class and Derived Class.
            // Base Class method is virtual and in Derived Class, method is overriden.
            // Call the method by a Base Class object.
            // -- OUTPUT --
            // BaseClass Constructor
            // DerivedClass Constructor
            // DerivedClass: MethodThatCanBeOverriden called
            // ------------
            // BaseClass derivedClass = new DerivedClass();
            // derivedClass.MethodThatCanBeOverriden();

            // -- Same method both in Base Class, Derived Class and OneMoreDerived Class.
            // Base Class method is virtual and in Derived Class and OneMoreDerived Class, method is overriden.
            // Call the method by a OneMoreDerived Class object.
            // -- OUTPUT --
            // BaseClass Constructor
            // DerivedClass Constructor
            // OneMoreDerivedClass Constructor
            // OneMoreDerivedClass: MethodThatCanBeOverriden called
            // ------------
            //OneMoreDerivedClass oneMoreDerivedClass = new OneMoreDerivedClass();
            //oneMoreDerivedClass.MethodThatCanBeOverriden();

            // -- Same method both in Base Class, Derived Class and OneMoreDerived Class.
            // Base Class method is virtual and in Derived Class and OneMoreDerived Class, method is overriden.
            // Call the method by a upcasting to the immediate parent Derived Class.
            // -- OUTPUT --
            // BaseClass Constructor
            // DerivedClass Constructor
            // OneMoreDerivedClass Constructor
            // OneMoreDerivedClass: MethodThatCanBeOverriden called
            // ------------
            //DerivedClass oneMoreDerivedClass = new OneMoreDerivedClass();
            //oneMoreDerivedClass.MethodThatCanBeOverriden();

            // -- OUTPUT --
            // BaseClass Constructor
            // DerivedClass Constructor
            // OneMoreDerivedClass Constructor
            // OneMoreDerivedClass: MethodHidingWithNewKeyword called
            // ------------
            //OneMoreDerivedClass oneMoreDerivedClass = new OneMoreDerivedClass();
            //oneMoreDerivedClass.MethodHidingWithNewKeyword();

            // -- OUTPUT --
            // BaseClass Constructor
            // DerivedClass Constructor
            // OneMoreDerivedClass Constructor
            // DerivedClass: MethodHidingWithNewKeyword called
            // ------------
            // DerivedClass derivedClassOneMoreDerivedClass = new OneMoreDerivedClass();
            // derivedClassOneMoreDerivedClass.MethodHidingWithNewKeyword();

            // -- OUTPUT --
            // BaseClass Constructor
            // DerivedClass Constructor
            // OneMoreDerivedClass Constructor
            // BaseClass: MethodHidingWithNewKeyword called
            // ------------
            // BaseClass baseClassOneMoreDerivedClass = new OneMoreDerivedClass();
            // baseClassOneMoreDerivedClass.MethodHidingWithNewKeyword();

            // -- OUTPUT --
            // BaseClass Constructor
            // DerivedClass Constructor
            // OneMoreDerivedClass Constructor
            // DerivedClass: VirtualMethodHidingWithNewKeyword called
            // ------------
            //BaseClass baseClassOneMoreDerivedClass = new OneMoreDerivedClass();
            //baseClassOneMoreDerivedClass.VirtualMethodHidingWithNewKeyword();

            // -- OUTPUT --
            // BaseClass Constructor
            // DerivedClass Constructor
            // OneMoreDerivedClass Constructor
            // DerivedClass: VirtualMethodHidingWithNewKeyword called
            // ------------
            // DerivedClass derivedClassOneMoreDerivedClass = new OneMoreDerivedClass();
            // derivedClassOneMoreDerivedClass.VirtualMethodHidingWithNewKeyword();

            // -- OUTPUT --
            // BaseClass Constructor
            // DerivedClass Constructor
            // OneMoreDerivedClass Constructor
            // OneMoreDerivedClass: VirtualMethodHidingWithNewKeyword called
            // ------------
            //OneMoreDerivedClass oneMoreDerivedClass = new OneMoreDerivedClass();
            //oneMoreDerivedClass.VirtualMethodHidingWithNewKeyword();

            #endregion
        }
    }
}
