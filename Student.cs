using System;

class Student : Person
{
public string Id{get; set;}
public string School{get; set;}
public double GPA{get; set;}
public string Major{get; set;}
public string Academicstanding{get; set;}

public Student () : base()
{
Console.WriteLine ("Student Constructor");
Academicstanding= "Good";
}

public Student (string fname, string lname) : base(fname, lname)
{
Console.WriteLine ("Student Constructor");
Academicstanding= "Good";
}

public void SetAcademicStanding()
{
  if (GPA >= 2.25)
  Academicstanding = "Good";
  else
  Academicstanding = "Not Good";
}

// this following mehtod is to override the virtual method in Person
//base.Intro() allows for the override info to be added onto original intro 
public override void Intro()
{
  base.Intro();
  Console.WriteLine ("My name is " + Firstname + " " + Lastname + ", and I study at the " + School);
}
}