using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Library
{
    [Serializable]
    public class ApproxyParameters
    {
        private int step;
        private int halfperiod;
        private int degree;

        public ApproxyParameters() { }


        public ApproxyParameters(int _step, int _halfperiod, int _degree)
        {
            step = _step;
            halfperiod = _halfperiod;
            degree = _degree;

        }

        public int GetStep => step;
        public int GetHalfPeriod => halfperiod;
        public int GetDegree => degree;
    }
}
