// Decompiled with Syinea's Decompiler
// Type: ns0.Class1
// Assembly: My_EventBot_ßy_Mehmet_Yıldız_ML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B7172642-DC7D-4477-97BD-E927F8349F37
// Assembly location: C:\Users\Syinea\Downloads\CrackedMyEventBot\CrackedVsroEfsane.exe

using ns1;
using System;

namespace ns0
{
  internal sealed class Class1
  {
    internal ushort ushort_0;
    internal Class3 class3_0;
    internal Class2 class2_0;
    internal bool bool_0;
    internal bool bool_1;
    internal bool bool_2;
    internal byte[] byte_0;
    internal object object_0;

    public Class1(ushort ushort_1)
    {
      this.object_0 = new object();
      this.ushort_0 = ushort_1;
      this.bool_0 = false;
      this.bool_1 = false;
      this.class3_0 = new Class3();
      this.class2_0 = (Class2) null;
      this.byte_0 = (byte[]) null;
    }

    public Class1(ushort ushort_1, bool bool_3)
    {
      this.object_0 = new object();
      this.ushort_0 = ushort_1;
      this.bool_0 = bool_3;
      this.bool_1 = false;
      this.class3_0 = new Class3();
      this.class2_0 = (Class2) null;
      this.byte_0 = (byte[]) null;
    }

    public Class1(ushort ushort_1, bool bool_3, bool bool_4)
    {
      if (bool_3 & bool_4)
        throw new Exception("[Packet::Packet] Packets cannot both be massive and encrypted!");
      this.object_0 = new object();
      this.ushort_0 = ushort_1;
      this.bool_0 = bool_3;
      this.bool_1 = bool_4;
      this.class3_0 = new Class3();
      this.class2_0 = (Class2) null;
      this.byte_0 = (byte[]) null;
    }

    public Class1(
      ushort ushort_1,
      bool bool_3,
      bool bool_4,
      byte[] byte_1,
      int int_0,
      int int_1)
    {
      if (bool_3 & bool_4)
        throw new Exception("[Packet::Packet] Packets cannot both be massive and encrypted!");
      this.object_0 = new object();
      this.ushort_0 = ushort_1;
      this.bool_0 = bool_3;
      this.bool_1 = bool_4;
      this.class3_0 = new Class3();
      this.class3_0.Write(byte_1, int_0, int_1);
      this.class2_0 = (Class2) null;
      this.byte_0 = (byte[]) null;
    }
  }
}
