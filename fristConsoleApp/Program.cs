class Program {
  static void MyCls()
  {
    Console.WriteLine("hi");
  }

  class Car
{
    // Making the field public so it can be accessed from Program.
    public string Color = "red";
}
  static void Main(string[] args){
    MyCls();
    MyCls();
    MyCls();

    Car myObj = new Car();
    Console.WriteLine(myObj.Color);

  }

   
}