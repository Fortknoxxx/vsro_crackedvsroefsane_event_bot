// Decompiled with Syinea's Decompiler
// Type: ns3.Class6
// Assembly: My_EventBot_ßy_Mehmet_Yıldız_ML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B7172642-DC7D-4477-97BD-E927F8349F37
// Assembly location: C:\Users\Syinea\Downloads\CrackedMyEventBot\CrackedVsroEfsane.exe

using System;

namespace ns3
{
  internal sealed class Class6
  {
    internal byte[] byte_0;
    internal int int_0;
    internal int int_1;
    internal object object_0;

    public Class6()
    {
      this.byte_0 = (byte[]) null;
      this.int_0 = 0;
      this.int_1 = 0;
      this.object_0 = new object();
    }

    public Class6(int int_2, int int_3, int int_4)
    {
      this.byte_0 = new byte[int_2];
      this.int_0 = int_3;
      this.int_1 = int_4;
      this.object_0 = new object();
    }

    public Class6(int int_2)
    {
      this.byte_0 = new byte[int_2];
      this.int_0 = 0;
      this.int_1 = 0;
      this.object_0 = new object();
    }

    public Class6(byte[] byte_1, int int_2, int int_3, bool bool_0)
    {
      if (bool_0)
      {
        this.byte_0 = byte_1;
      }
      else
      {
        this.byte_0 = new byte[byte_1.Length];
        Buffer.BlockCopy((Array) byte_1, 0, (Array) this.byte_0, 0, byte_1.Length);
      }
      this.int_0 = int_2;
      this.int_1 = int_3;
      this.object_0 = new object();
    }
  }
}
