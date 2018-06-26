using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConversionServer.Views.Length
{
    public class LengthModel
    {
        private double inFeet, outFeet, inYards, outYards;
        public LengthModel()
        {
            inFeet = 0.0;
            outFeet = 0.0;
            inYards = 0.0;
            outYards = 0.0;
        }
        public double getInFeet() => inFeet;       
        public double getOutFeet() => outFeet;
        public double getInYards() => inYards;
        public double getOutYards() => outYards;
        public void setAll(double inFeet, double outFeet, double inYards, double outYards)
        {
            this.inFeet = inFeet;
            this.outFeet = outFeet;
            this.inYards = inYards;
            this.outYards = outYards;
        }
    }
}
