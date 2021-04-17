namespace Exchanger
{
    static class Exchanger
    {
        public static decimal USDtoCAN(decimal USDAmount)
        {
            return 1.25427M * USDAmount;
        }
        public static decimal USDtoGBP(decimal USDAmount)
        {
            return 0.72523M * USDAmount;
        }
        public static decimal USDtoEUR(decimal USDAmount)
        {
            return 0.83572M * USDAmount;
        }
        public static decimal CANtoUSD(decimal CANAmount)
        {
            return 0.79728M * CANAmount;
        }
        public static decimal CANtoGBP(decimal CANAmount)
        {
            return 0.57848M * CANAmount;
        }
        public static decimal CANtoEUR(decimal CANAmount)
        {
            return 0.66645M * CANAmount;
        }
        public static decimal EURtoUSD(decimal EURAmount)
        {
            return 1.19648M * EURAmount;
        }
        public static decimal EURtoCAN(decimal EURAmount)
        {
            return 1.50040M * EURAmount;
        }
        public static decimal EURtoGBP(decimal EURAmount)
        {
            return 0.86826M * EURAmount;
        }
        public static decimal GBPtoUSD(decimal GBPAmount)
        {
            return 1.37887M * GBPAmount;
        }
        public static decimal GBPtoCAN(decimal GBPAmount)
        {
            return 1.72947M * GBPAmount;
        }
        public static decimal GBPtoEUR(decimal GBPAmount)
        {
            return 1.15195M * GBPAmount;
        }

    }
}
