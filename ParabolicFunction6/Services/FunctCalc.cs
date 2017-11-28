using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ParabolicFunction6.Models;

namespace ParabolicFunction6.Services
{
    public class FunctCalc
    {
        public List<PointXY> getPoints()
        {
            return Points;
        }
        
        public static List<PointXY> Points = new List<PointXY>{ };

        private double CalcY(double a, double b, double c, double x)
        {
            return x * x * a + x * b + c;
        }

        public void GeneratePoints(FormModel fm)
        {
            Points.Clear();
            int count = 0;
            double i = fm.lowerBound;
            double step = fm.step;
            while ((i <= fm.upperBound)&&(count < 100000)&&(step!=0f)) {
                Points.Add(new PointXY { x = i, y = CalcY(fm.koef_a, fm.koef_b, fm.koef_c, i) });
                i += step;
                count++;
            }
        }

        
    }
}