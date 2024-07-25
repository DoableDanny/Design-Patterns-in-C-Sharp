// Subclass representing a car, inheriting from Vehicle
namespace ConsoleApp1.Inheritance

// Inheritance involves creating new classes (subclasses or derived classes) based on existing classes (superclasses or base classes). Subclasses inherit properties and behaviors from their superclasses and can also add new features or override existing ones. Inheritance is often described in terms of an "is-a" relationship.

{
  public class Car : Vehicle
  {
    public int NumberOfDoors { get; set; }
    public int NumberOfWheels { get; set; }
  }
}