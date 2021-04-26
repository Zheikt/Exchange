using System;

namespace Exchanger
{
    static class Exchanger
    {
        public static decimal USDtoCAN(decimal USDAmount)
        {
            return Math.Round(1.25427M * USDAmount,2,MidpointRounding.AwayFromZero);
        }
        public static decimal USDtoGBP(decimal USDAmount)
        {
            return Math.Round(0.72523M * USDAmount, 2, MidpointRounding.AwayFromZero);
        }
        public static decimal USDtoEUR(decimal USDAmount)
        {
            return Math.Round(0.83572M * USDAmount,2,MidpointRounding.AwayFromZero);
        }
        public static decimal CANtoUSD(decimal CANAmount)
        {
            return Math.Round(0.79728M * CANAmount,2,MidpointRounding.AwayFromZero);
        }
        public static decimal CANtoEUR(decimal CANAmount)
        {
            return Math.Round(0.66645M * CANAmount,2,MidpointRounding.AwayFromZero);
        }
        public static decimal CANtoGBP(decimal CANAmount)
        {
            return Math.Round(0.57848M * CANAmount,2,MidpointRounding.AwayFromZero);
        }
        public static decimal EURtoUSD(decimal EURAmount)
        {
            return Math.Round(1.19648M * EURAmount,2,MidpointRounding.AwayFromZero);
        }
        public static decimal EURtoCAN(decimal EURAmount)
        {
            return Math.Round(1.50040M * EURAmount,2,MidpointRounding.AwayFromZero);
        }
        public static decimal EURtoGBP(decimal EURAmount)
        {
            return Math.Round(0.86826M * EURAmount,2,MidpointRounding.AwayFromZero);
        }
        public static decimal GBPtoUSD(decimal GBPAmount)
        {
            return Math.Round(1.37887M * GBPAmount,2,MidpointRounding.AwayFromZero);
        }
        public static decimal GBPtoCAN(decimal GBPAmount)
        {
            return Math.Round(1.72947M * GBPAmount,2,MidpointRounding.AwayFromZero);
        }
        public static decimal GBPtoEUR(decimal GBPAmount)
        {
            return Math.Round(1.15195M * GBPAmount,2,MidpointRounding.AwayFromZero);
        }

    }
}
