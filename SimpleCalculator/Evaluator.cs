using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Evaluator
    {
        private Parser parser { get; set; }

        public Evaluator()
        {
            parser = new Parser();
        }
    }
}
