using System;
using System.Collections.Generic;

namespace GradeBook
{
public class Book
{
    public Book(string name)
    {    
        this.name = name;
        grades = new List<double>();        
    }

    public void AddGrade(double grade){
        grades.Add(grade);
    }

    public Statistics getStatistics(){
        var result = new Statistics();
        Double total = 0;


        foreach (double grade in grades){
            result.High = Math.Max(grade, result.High);
            result.Low = Math.Min(grade, result.Low);
            total += grade;
        }

        result.Average = total/grades.Count;

        return result;

    }

    public String getName(){
        return name;
    }

    public void setName(String name){
        this.name = name;
    }
    
    private string name;
    private List<double> grades;
}
}
