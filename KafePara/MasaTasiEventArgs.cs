using System;

namespace KafePara
{
    public class MasaTasiEventArgs : EventArgs
    {
        public MasaTasiEventArgs(int eskiMasaNo, int yeniMasaNo)
        {
            EskiMasaNo = eskiMasaNo;
            YeniMasaNo = yeniMasaNo;
        }

        public int EskiMasaNo { get; }
        public int YeniMasaNo { get; }
    }
}
