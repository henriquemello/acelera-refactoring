using System;
using System.Collections.Generic;
using System.Text;

namespace PerformanceBiller.Statement.Models
{
    class Action : Perfomance
    {
        public Action(Builders.PerfomanceBuilder builder) : base(builder) { }

        protected override decimal InitialAmount => 10000;

        protected override int MinimiumAudience => 50;

        protected override decimal CalculateGreaterThanAudience()
        => 1000 * (Audience - 50); 
    }
}
