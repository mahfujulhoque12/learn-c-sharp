class Program {
  static void MyCls()
  {
    Console.WriteLine("hi");
  }

  class Car
{
    // Making the field public so it can be accessed from Program.
    public string Color = "red";
    public int maxSpeed = 250;
}
  static void Main(string[] args){
    MyCls();
    MyCls();
    MyCls();

    Car myObj = new Car();
    Car myObj2 = new Car();

    Console.WriteLine(myObj.Color);
    Console.WriteLine(myObj2.Color);
    Console.WriteLine(myObj2.maxSpeed);



  }

   
}