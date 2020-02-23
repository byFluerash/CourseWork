using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CW_Library;

namespace CourseWork_Server
{
    class Calculation
    {
        public Calculation() { }

        //заданная функция
        public double Function(double x)
        {
            Random rand = new Random();
            x += rand.NextDouble() + 0.5;
            double f = Math.Pow(Math.E, -Math.Sin(x)) * (Math.Cos(x) + 2 * Math.Atan(x));
            return f;
        }

        //расчет точек графика функции
        public List<Tuple<double, double>> CalculateFunction(int L, int N)
        {
            var graph_func = new List<Tuple<double, double>>();
            double h = 0.01;
            for (double i = -L; i <= L; i += h)
            {
                graph_func.Add(new Tuple<double, double>(i, Function(i)));
            }
            return graph_func;
        }

        //реализуемый метод интегрирования
        public double ApproxyFunction(double x, int halfperiod, double h, int degree)
        {
            double ak = 0;
            double bk = 0;
            int N = (int)(2 * halfperiod / h);
            double a0 = coef_a0(x, h, N);
            double P = a0;
            for (int k = 0; k < degree; k++)
            {
                ak += coef_ak(x, halfperiod, degree, h, N);
                bk += coef_bk(x, halfperiod, degree, h, N);
                P += (ak * Math.Cos(k * Math.PI * x / halfperiod) + bk * Math.Sin(k * Math.PI * x / halfperiod));
            }
            return P;
        }

        //вычисление коэфициента a0
        public double coef_a0(double x, double h, int N)
        {
            double a0 = 0;
            for (int i = 0; i <= N; i++)
            {
                a0 += Function(x);
            }
            a0 = a0 * 1 / (N + 1);
            return a0;
        }

        //вычисление коэфициента ak
        public double coef_ak(double x, int halfperiod, int k, double h, int N)
        {
            double ak = 0;
            for (int i = 0; i <= N; i++)
            {
                ak += Function(x) * Math.Cos(k * Math.PI * ((2 * i / N) - halfperiod));
            }
            ak = ak * 2 / (N + 1);
            return ak;
        }


        //вычисление коэфициента bk
        public double coef_bk(double x, int halfperiod, int k, double h, int N)
        {
            double bk = 0;
            for (int i = 0; i <= N; i++)
            {
                bk += Function(x) * Math.Cos(k * Math.PI * ((2 * i / N) - halfperiod));
            }
            bk = bk * 2 / (N + 1); ;
            return bk;
        }


        //расчет h
        public double CalcH(int T, int n)
        {
            return (double)T / n;
        }



        //расчет точек функции интегрирования
        public List<Tuple<double, double>> CalculateApproxyFunction(int n, int halfperiod, int degree)
        {                            //  tk      xxk
            var graph_approxy = new List<Tuple<double, double>>();
            double h = CalcH(2 * halfperiod, n);
            for (double i = -halfperiod; i <= halfperiod; i += h)
            {
                graph_approxy.Add(new Tuple<double, double>(i, ApproxyFunction(i, halfperiod, h, degree)));
            }
            return graph_approxy;
        }

        //расчет параметров для построения графиков в клиенте
        public GraphParameters CalcParams(int step, int halfperiod, int degree)
        {
            List<Tuple<double, double>> functionPoints;
            List<Tuple<double, double>> approxyPoints;

            approxyPoints = CalculateApproxyFunction(step, halfperiod, degree);
            functionPoints = CalculateFunction(halfperiod, step);


            return new GraphParameters(functionPoints, approxyPoints);
        }
    }
}
