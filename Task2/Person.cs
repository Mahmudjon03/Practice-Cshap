 var pr1=new Person(){
    FirstName="Ivan",
    LastName="Ivanov",
    BirthData=new DateTime(1993,03,12),
    From="Russia"};

    pr1.FullInfo();






public class Person{
    public string FirstName;
    public string LastName;
    public DateTime BirthData;
    public string From;

  public void FullInfo(){
    System.Console.WriteLine($"My name is {FirstName} {LastName}");
    System.Console.WriteLine($"My birth  is  {BirthData}");
    System.Console.WriteLine($"My from is {From}");

  }}
