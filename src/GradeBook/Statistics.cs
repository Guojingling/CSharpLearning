
namespace GradeBook
{
public class Statistics
{
    public Statistics()
    {    
        High = double.MinValue; 
        Low = double.MaxValue;
        Average = double.MinValue;       
    }

 
    public double High;
    public double Low;
    public double Average;
}
}