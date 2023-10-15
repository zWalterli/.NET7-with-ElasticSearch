using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elastic.Infrastructure.Abstractions
{
    public class ActorsAggregationModel
    {
        public double TotalAge { get; set; }
        public double TotalMovies { get; set; }
        public double AverageAge { get; set; }
    }
}
