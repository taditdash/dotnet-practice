using System;

namespace oop
{
  class BaseClass {
    public BaseClass()
    {
      Console.WriteLine("BaseClass Constructor");
    }

    public void BaseClassMethod() {
      Console.WriteLine("BaseClassMethod");
    }

    public void MethodWithSameNameInBaseAndDerivedClass() {
      Console.WriteLine("BaseClass: MethodWithSameNameInBaseAndDerivedClass called");
    }

    public void MethodThatCanBeOverriden() {
      Console.WriteLine("BaseClass: MethodThatCanBeOverriden called");
    }
  }

  class DerivedClass: BaseClass {
    public DerivedClass()
    {
      Console.WriteLine("DerivedClass Constructor");
    }

    public void DerivedClassMethod() {
      Console.WriteLine("DerivedClassMethod");
    }

    public void MethodWithSameNameInBaseAndDerivedClass() {
      Console.WriteLine("DerivedClass: MethodWithSameNameInBaseAndDerivedClass called");
    }

    public override void MethodThatCanBeOverriden() {
      Console.WriteLine("DerivedClass: MethodThatCanBeOverriden called");
    }
  }

  class AnotherBaseClass {
    public AnotherBaseClass()
    {
      Console.WriteLine("AnotherBaseClass Constructor");
    }
  }

  // Commented as this is producing a build error
  // Inheriting from multiple base class is not possible.
  // Build error is like the below.
  // Class 'DerivedClassWithMultipleBaseClass' cannot have multiple base classes:
  // 'BaseClass' and 'AnotherBaseClass'

  // class DerivedClassWithMultipleBaseClass: BaseClass, AnotherBaseClass {
  //   public DerivedClassWithMultipleBaseClass()
  //   {
  //     Console.WriteLine("DerivedClassWithMultipleBaseClass Constructor");
  //   }
  // }
}