// Decompiled with Syinea's Decompiler
// Type: ns5.Class9
// Assembly: My_EventBot_ßy_Mehmet_Yıldız_ML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B7172642-DC7D-4477-97BD-E927F8349F37
// Assembly location: C:\Users\Syinea\Downloads\CrackedMyEventBot\CrackedVsroEfsane.exe

using ns0;
using ns7;

namespace ns5
{
  internal sealed class Class9
  {
    internal static readonly string[] string_0 = new string[10]
    {
      "need dictionary",
      "stream end",
      "",
      "file error",
      "stream error",
      "data error",
      "insufficient memory",
      "buffer error",
      "incompatible version",
      ""
    };
    internal static readonly int int_0 = 262;
    internal static readonly int int_1 = 286;
    private static readonly int int_2 = 2 * Class9.int_1 + 1;
    internal static Class9.Class10[] class10_0 = new Class9.Class10[10];
    internal Class17 class17_0 = new Class17();
    internal Class17 class17_1 = new Class17();
    internal Class17 class17_2 = new Class17();
    internal short[] short_5 = new short[16];
    internal int[] int_31 = new int[2 * Class9.int_1 + 1];
    internal byte[] byte_3 = new byte[2 * Class9.int_1 + 1];
    internal Class18 class18_0;
    internal int int_3;
    internal byte[] byte_0;
    internal int int_4;
    internal int int_5;
    internal int int_6;
    internal int int_7;
    internal byte byte_1;
    internal int int_8;
    internal int int_9;
    internal int int_10;
    internal int int_11;
    internal byte[] byte_2;
    internal int int_12;
    internal short[] short_0;
    internal short[] short_1;
    internal int int_13;
    internal int int_14;
    internal int int_15;
    internal int int_16;
    internal int int_17;
    internal int int_18;
    internal int int_19;
    internal int int_20;
    internal int int_21;
    internal int int_22;
    internal int int_23;
    internal int int_24;
    internal int int_25;
    internal int int_26;
    internal int int_27;
    internal int int_28;
    internal int int_29;
    internal int int_30;
    internal short[] short_2;
    internal short[] short_3;
    internal short[] short_4;
    internal int int_32;
    internal int int_33;
    internal int int_34;
    internal int int_35;
    internal int int_36;
    internal int int_37;
    internal int int_38;
    internal int int_39;
    internal int int_40;
    internal int int_41;
    internal short short_6;
    internal int int_42;

    internal Class9()
    {
      this.short_2 = new short[Class9.int_2 * 2];
      this.short_3 = new short[122];
      this.short_4 = new short[78];
    }

    static Class9()
    {
      Class9.class10_0[0] = new Class9.Class10(0, 0, 0, 0, 0);
      Class9.class10_0[1] = new Class9.Class10(4, 4, 8, 4, 1);
      Class9.class10_0[2] = new Class9.Class10(4, 5, 16, 8, 1);
      Class9.class10_0[3] = new Class9.Class10(4, 6, 32, 32, 1);
      Class9.class10_0[4] = new Class9.Class10(4, 4, 16, 16, 2);
      Class9.class10_0[5] = new Class9.Class10(8, 16, 32, 32, 2);
      Class9.class10_0[6] = new Class9.Class10(8, 16, 128, 128, 2);
      Class9.class10_0[7] = new Class9.Class10(8, 32, 128, 256, 2);
      Class9.class10_0[8] = new Class9.Class10(32, 128, 258, 1024, 2);
      Class9.class10_0[9] = new Class9.Class10(32, 258, 258, 4096, 2);
    }

    internal sealed class Class10
    {
      internal int int_0;
      internal int int_1;
      internal int int_2;
      internal int int_3;
      internal int int_4;

      internal Class10(int int_5, int int_6, int int_7, int int_8, int int_9)
      {
        this.int_0 = int_5;
        this.int_1 = int_6;
        this.int_2 = int_7;
        this.int_3 = int_8;
        this.int_4 = int_9;
      }
    }
  }
}
