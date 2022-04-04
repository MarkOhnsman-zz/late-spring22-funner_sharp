namespace funner_sharp.models
{
  // AccessModifiers (public, internal, protected, private)
  public class Cat
  {
    // name
    // Public Property with backing private field
    // private string? _name;
    // public string? Name
    // {
    //   get
    //   {
    //     return _name;
    //   }
    //   set
    //   {
    //     _name = value;
    //   }
    //   }
    //access modifier, data type, name, getter setter
    public string? Name { get; private set; }
    public int Age { get; set; }
    public string? Color { get; set; }
    public bool Adoptable { get; set; }


    // access modifier, return type, name (param type, param name)
    // void means it returns nothing
    public void ChangeName(string name)
    {
      if (name.Length > 3)
      {
        Name = name;
        return;
      }
      throw new Exception("YOU MUST PROVIDE MORE THAN 3 Letters");
    }

    // constructor is a method with no return type, and the name matchs the class
    public Cat(string? name, int age, string? color)
    {
      Name = name;
      Age = age;
      Color = color;
      Adoptable = true;
    }
  }
}
