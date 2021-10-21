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

    public virtual void MethodThatCanBeOverriden() {
      Console.WriteLine("BaseClass: MethodThatCanBeOverriden called");
    }

    public void MethodHidingWithNewKeyword() {
      Console.WriteLine("BaseClass: MethodHidingWithNewKeyword called");
    }

    public virtual void VirtualMethodHidingWithNewKeyword() {
      Console.WriteLine("BaseClass: VirtualMethodHidingWithNewKeyword called");
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

    public new void MethodHidingWithNewKeyword() {
      Console.WriteLine("DerivedClass: MethodHidingWithNewKeyword called");
    }

    public override void VirtualMethodHidingWithNewKeyword() {
      Console.WriteLine("DerivedClass: VirtualMethodHidingWithNewKeyword called");
    }
  }

  class OneMoreDerivedClass: DerivedClass {
    public OneMoreDerivedClass()
    {
      Console.WriteLine("OneMoreDerivedClass Constructor");
    }

    public override void MethodThatCanBeOverriden() {
      Console.WriteLine("OneMoreDerivedClass: MethodThatCanBeOverriden called");
    }

    public new void MethodHidingWithNewKeyword() {
      Console.WriteLine("OneMoreDerivedClass: MethodHidingWithNewKeyword called");
    }

    public new void VirtualMethodHidingWithNewKeyword() {
      Console.WriteLine("OneMoreDerivedClass: VirtualMethodHidingWithNewKeyword called");
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