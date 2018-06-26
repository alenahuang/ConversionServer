using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConversionServer.Models
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
        public double getInFeet()
        {
            return inFeet;
        }
        public double getOutFeet()
        {
            return outFeet;
        }
        public double getInYards()
        {
            return inYards;
        }
        public double getOutYards()
        {
            return outYards;
        }
        public void setAll(double inFeet, double outFeet, double inYards, double outYards)
        {
            this.inFeet = inFeet;
            this.outFeet = outFeet;
            this.inYards = inYards;
            this.outYards = outYards;
        }
    }
}
