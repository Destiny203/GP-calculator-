using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

 namespace _2nd
{
    internal class Program
    {
        static void Print_array(double[] array)
        {
            for (double i = 0; i < array.Length; i++)
            {
                Write(array[(int)i] + ", ");
            }
            WriteLine();
        }

        static void Main(string[] args)
        {
           double course_num, score, unit, i = 0, j, gradepoint, totalCL, totalGP;
            double CGPA;
            Write("enter no of courses: ");
            course_num = double.Parse(ReadLine());
            double[] main_score = new double[(int)course_num];
            double[] main_unit = new double[(int)course_num];
            double[] grade = new double[(int)course_num];
            double[] main_gradePoint = new double[(int)course_num];
            Clear();

            while (i < course_num)
            {
                Write("Enter Score: ");
                score = double.Parse(ReadLine());
                main_score[(int)i] = score;
                Write("Enter Unit: ");
                unit = double.Parse(ReadLine());
                main_unit[(int)i] = unit;
                Clear();
                if (score <=100 && score  >= 70)
                {

                    j = 5;
                    grade[(int)i] = j;

                }
                else  if (score >= 60)
                {
                    j = 4;
                    grade[(int)i] = j;

                }
                else if (score >= 50)
                {
                    j = 3;
                    grade[(int)i] = j;
                }
                else if (score >= 45)
                {
                    j = 2;
                    grade[(int)i] = j;

                }
                else if (score >= 40)
                {
                    j = 1;
                    grade[(int)i] = j;

                }
                else
                {
                    j = 0;
                    grade[(int)i] = j;

                }
                gradepoint = j * unit;
                main_gradePoint[(int)i] = gradepoint;

                i++;
            }
            Write("score = ");
            Print_array(main_score);
            Write("unit = ");
            Print_array(main_unit);
            Write("grade score = ");
            Print_array(grade);
            Write("grade point = ");
            Print_array(main_gradePoint);
            totalCL = main_unit.Sum();
            WriteLine("Total credit load: "+totalCL);
            totalGP = main_gradePoint.Sum();
            WriteLine("Total grade point: "+totalGP);
            CGPA = totalGP / totalCL;
            WriteLine("CGPA: "+CGPA);
            ReadLine();
        }

    }
}
          

