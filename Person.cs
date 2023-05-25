namespace Lambda_Practice
{
    public class Student
    {
       public int Id ;
       public string Name ;
       public string Phone_Number ;
       public string Address ;
       public int Age ;
       public int TotalMark ;

       public Student(int id,string name, string phone_number,string address, int age,int totalMark){
        this.Id = id;
        this.Name = name;   
        this.Phone_Number = phone_number;
        this.Address = address;
        this.Age = age;
        this.TotalMark = totalMark;
       } 
    }
}