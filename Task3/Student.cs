public class Student{
    public string FirstName;
    public string LastName  ;
    public int Level;
    public int Grande;

   
    public   void GetGrande(){
        if(Grande>=85){
        System.Console.WriteLine($"Congratulations-{LastName} {FirstName}  achieving above average scores({Grande}) in grande {Level}! Keep up the good work!");
        } else if( Grande > 70 && Grande < 84 ){
        System.Console.WriteLine($" {LastName} {FirstName} , if you're having difficulties with your studies, don't hesitate to seek help. Your current average score is {Grande} in grade {Level} ");
    }else{
        System.Console.WriteLine($" {LastName} {FirstName}  scored {Grande} in grande {Level}! Don't get discouraged.Keep up your work! ");
    }
    }
    }

