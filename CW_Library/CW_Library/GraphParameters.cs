using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Library
{
    [Serializable]
    public class GraphParameters
    {
        private List<Tuple<double, double>> functionPoints;
        private List<Tuple<double, double>> approxyPoints;

        public GraphParameters() { }


        public GraphParameters(List<Tuple<double, double>> _functionPoints, List<Tuple<double, double>> _approxyPoints)
        {
            functionPoints = _functionPoints;
            approxyPoints = _approxyPoints;
        }

        public List<Tuple<double, double>> GetFunctionPoints => functionPoints;
        public List<Tuple<double, double>> GetApproxyPoints => approxyPoints;

    }
}
