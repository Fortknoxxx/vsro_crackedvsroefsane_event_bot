﻿// Decompiled with Syinea's Decompiler
// Type: ns8.Class80
// Assembly: My_EventBot_ßy_Mehmet_Yıldız_ML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B7172642-DC7D-4477-97BD-E927F8349F37
// Assembly location: C:\Users\Syinea\Downloads\CrackedMyEventBot\CrackedVsroEfsane.exe

using ns2;
using System.IO;

namespace ns8
{
  internal static class Class80
  {
    internal sealed class Class81
    {
      internal static readonly int[] int_0 = new int[29]
      {
        3,
        4,
        5,
        6,
        7,
        8,
        9,
        10,
        11,
        13,
        15,
        17,
        19,
        23,
        27,
        31,
        35,
        43,
        51,
        59,
        67,
        83,
        99,
        115,
        131,
        163,
        195,
        227,
        258
      };
      internal static readonly int[] int_1 = new int[29]
      {
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        1,
        1,
        1,
        1,
        2,
        2,
        2,
        2,
        3,
        3,
        3,
        3,
        4,
        4,
        4,
        4,
        5,
        5,
        5,
        5,
        0
      };
      internal static readonly int[] int_2 = new int[30]
      {
        1,
        2,
        3,
        4,
        5,
        7,
        9,
        13,
        17,
        25,
        33,
        49,
        65,
        97,
        129,
        193,
        257,
        385,
        513,
        769,
        1025,
        1537,
        2049,
        3073,
        4097,
        6145,
        8193,
        12289,
        16385,
        24577
      };
      internal static readonly int[] int_3 = new int[30]
      {
        0,
        0,
        0,
        0,
        1,
        1,
        2,
        2,
        3,
        3,
        4,
        4,
        5,
        5,
        6,
        6,
        7,
        7,
        8,
        8,
        9,
        9,
        10,
        10,
        11,
        11,
        12,
        12,
        13,
        13
      };
      internal int int_4;
      internal int int_5;
      internal int int_6;
      internal int int_7;
      internal int int_8;
      internal bool bool_0;
      internal Class80.Class82 class82_0;
      internal Class80.Class83 class83_0;
      internal Class80.Class85 class85_0;
      internal Class80.Class84 class84_0;
      internal Class80.Class84 class84_1;

      public Class81(byte[] byte_0)
      {
        this.class82_0 = new Class80.Class82();
        this.class83_0 = new Class80.Class83();
        this.int_4 = 2;
        Class73.smethod_252(byte_0.Length, byte_0, 0, this.class82_0);
      }
    }

    internal sealed class Class82
    {
      internal byte[] byte_0;
      internal int int_0;
      internal int int_1;
      internal uint uint_0;
      internal int int_2;
    }

    internal sealed class Class83
    {
      internal byte[] byte_0 = new byte[32768];
      internal int int_0;
      internal int int_1;
    }

    internal sealed class Class84
    {
      internal short[] short_0;
      public static readonly Class80.Class84 class84_0;
      public static readonly Class80.Class84 class84_1;

      static Class84()
      {
        byte[] byte_0_1 = new byte[288];
        int num1 = 0;
        while (num1 < 144)
          byte_0_1[num1++] = (byte) 8;
        while (num1 < 256)
          byte_0_1[num1++] = (byte) 9;
        while (num1 < 280)
          byte_0_1[num1++] = (byte) 7;
        while (num1 < 288)
          byte_0_1[num1++] = (byte) 8;
        Class80.Class84.class84_0 = new Class80.Class84(byte_0_1);
        byte[] byte_0_2 = new byte[32];
        int num2 = 0;
        while (num2 < 32)
          byte_0_2[num2++] = (byte) 5;
        Class80.Class84.class84_1 = new Class80.Class84(byte_0_2);
      }

      public Class84(byte[] byte_0)
      {
        Class73.smethod_82(byte_0, this);
      }
    }

    internal sealed class Class85
    {
      internal static readonly int[] int_0 = new int[3]
      {
        3,
        3,
        11
      };
      internal static readonly int[] int_1 = new int[3]
      {
        2,
        3,
        7
      };
      internal static readonly int[] int_9 = new int[19]
      {
        16,
        17,
        18,
        0,
        8,
        7,
        9,
        6,
        10,
        5,
        11,
        4,
        12,
        3,
        13,
        2,
        14,
        1,
        15
      };
      internal byte[] byte_0;
      internal byte[] byte_1;
      internal Class80.Class84 class84_0;
      internal int int_2;
      internal int int_3;
      internal int int_4;
      internal int int_5;
      internal int int_6;
      internal int int_7;
      internal byte byte_2;
      internal int int_8;
    }

    internal sealed class Class86
    {
      private static readonly int[] int_0 = new int[19]
      {
        16,
        17,
        18,
        0,
        8,
        7,
        9,
        6,
        10,
        5,
        11,
        4,
        12,
        3,
        13,
        2,
        14,
        1,
        15
      };
      internal static readonly byte[] byte_0 = new byte[16]
      {
        (byte) 0,
        (byte) 8,
        (byte) 4,
        (byte) 12,
        (byte) 2,
        (byte) 10,
        (byte) 6,
        (byte) 14,
        (byte) 1,
        (byte) 9,
        (byte) 5,
        (byte) 13,
        (byte) 3,
        (byte) 11,
        (byte) 7,
        (byte) 15
      };
      private static readonly short[] short_0 = new short[286];
      private static readonly byte[] byte_1 = new byte[286];
      private static readonly short[] short_1;
      private static readonly byte[] byte_2;

      static Class86()
      {
        int index1;
        for (index1 = 0; index1 < 144; Class80.Class86.byte_1[index1++] = (byte) 8)
          Class80.Class86.short_0[index1] = Class73.smethod_7(48 + index1 << 8);
        for (; index1 < 256; Class80.Class86.byte_1[index1++] = (byte) 9)
          Class80.Class86.short_0[index1] = Class73.smethod_7(256 + index1 << 7);
        for (; index1 < 280; Class80.Class86.byte_1[index1++] = (byte) 7)
          Class80.Class86.short_0[index1] = Class73.smethod_7(index1 - 256 << 9);
        for (; index1 < 286; Class80.Class86.byte_1[index1++] = (byte) 8)
          Class80.Class86.short_0[index1] = Class73.smethod_7(index1 - 88 << 8);
        Class80.Class86.short_1 = new short[30];
        Class80.Class86.byte_2 = new byte[30];
        for (int index2 = 0; index2 < 30; ++index2)
        {
          Class80.Class86.short_1[index2] = Class73.smethod_7(index2 << 11);
          Class80.Class86.byte_2[index2] = (byte) 5;
        }
      }
    }

    internal sealed class Stream1 : MemoryStream
    {
      public Stream1(byte[] byte_0)
        : base(byte_0, false)
      {
      }
    }
  }
}
