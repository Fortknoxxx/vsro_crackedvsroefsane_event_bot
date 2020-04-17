// Decompiled with Syinea's Decompiler
// Type: ns1.Class12
// Assembly: My_EventBot_ßy_Mehmet_Yıldız_ML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B7172642-DC7D-4477-97BD-E927F8349F37
// Assembly location: C:\Users\Syinea\Downloads\CrackedMyEventBot\CrackedVsroEfsane.exe

using ns0;

namespace ns1
{
  internal sealed class Class12
  {
    internal static readonly int[] int_0 = new int[17]
    {
      0,
      1,
      3,
      7,
      15,
      31,
      63,
      (int) sbyte.MaxValue,
      (int) byte.MaxValue,
      511,
      1023,
      2047,
      4095,
      8191,
      16383,
      (int) short.MaxValue,
      (int) ushort.MaxValue
    };
    internal int int_4 = 0;
    internal int int_1;
    internal int int_2;
    internal int[] int_3;
    internal int int_5;
    internal int int_6;
    internal int int_7;
    internal int int_8;
    internal byte byte_0;
    internal byte byte_1;
    internal int[] int_9;
    internal int int_10;
    internal int[] int_11;
    internal int int_12;

    internal Class12(
      int int_13,
      int int_14,
      int[] int_15,
      int int_16,
      int[] int_17,
      int int_18,
      Class18 class18_0)
    {
      this.int_1 = 0;
      this.byte_0 = (byte) int_13;
      this.byte_1 = (byte) int_14;
      this.int_9 = int_15;
      this.int_10 = int_16;
      this.int_11 = int_17;
      this.int_12 = int_18;
    }

    internal Class12(int int_13, int int_14, int[] int_15, int[] int_16, Class18 class18_0)
    {
      this.int_1 = 0;
      this.byte_0 = (byte) int_13;
      this.byte_1 = (byte) int_14;
      this.int_9 = int_15;
      this.int_10 = 0;
      this.int_11 = int_16;
      this.int_12 = 0;
    }
  }
}
