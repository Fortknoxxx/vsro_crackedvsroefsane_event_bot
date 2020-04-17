// Decompiled with Syinea's Decompiler
// Type: ns2.Class4
// Assembly: My_EventBot_ßy_Mehmet_Yıldız_ML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B7172642-DC7D-4477-97BD-E927F8349F37
// Assembly location: C:\Users\Syinea\Downloads\CrackedMyEventBot\CrackedVsroEfsane.exe

using ns0;
using ns1;
using ns3;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace ns2
{
  internal sealed class Class4
  {
    internal static uint[] uint_0 = Class73.smethod_187();
    internal static Random random_0 = new Random();
    internal uint uint_1;
    internal uint uint_2;
    internal uint uint_3;
    internal uint uint_4;
    internal uint uint_5;
    internal uint uint_6;
    internal uint uint_7;
    internal uint uint_8;
    internal ulong ulong_0;
    internal ulong ulong_1;
    internal byte[] byte_0;
    internal ulong ulong_2;
    internal ulong ulong_3;
    internal bool bool_0;
    internal byte byte_1;
    internal Class4.Class5 class5_0;
    internal bool bool_1;
    internal bool bool_2;
    internal byte byte_2;
    internal string string_0;
    internal List<Class1> list_0;
    internal List<Class1> list_1;
    internal List<ushort> list_2;
    internal Class0 class0_0;
    private Class6 class6_0;
    private Class6 class6_1;
    private ushort ushort_0;
    private Class1 class1_0;
    internal object object_0;

    public Class4()
    {
      this.uint_1 = 0U;
      this.uint_2 = 0U;
      this.uint_3 = 0U;
      this.uint_4 = 0U;
      this.uint_5 = 0U;
      this.uint_6 = 0U;
      this.uint_7 = 0U;
      this.uint_8 = 0U;
      this.ulong_0 = 0UL;
      this.ulong_1 = 0UL;
      this.byte_0 = new byte[3];
      this.byte_0[0] = (byte) 0;
      this.byte_0[1] = (byte) 0;
      this.byte_0[2] = (byte) 0;
      this.ulong_2 = 0UL;
      this.ulong_3 = 0UL;
      this.bool_0 = false;
      this.byte_1 = (byte) 0;
      this.class5_0 = new Class4.Class5();
      this.bool_1 = false;
      this.bool_2 = false;
      this.byte_2 = (byte) 0;
      this.string_0 = "SR_Client";
      this.list_1 = new List<Class1>();
      this.list_0 = new List<Class1>();
      this.list_2 = new List<ushort>();
      this.list_2.Add((ushort) 8193);
      this.list_2.Add((ushort) 24832);
      this.list_2.Add((ushort) 24833);
      this.list_2.Add((ushort) 24834);
      this.list_2.Add((ushort) 24835);
      this.list_2.Add((ushort) 24839);
      this.class0_0 = new Class0();
      this.class6_0 = new Class6(8192);
      this.class6_1 = (Class6) null;
      this.ushort_0 = (ushort) 0;
      this.class1_0 = (Class1) null;
      this.object_0 = new object();
    }

    public unsafe void method_0(Class6 class6_2)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(67);
      List<Class6> class6List = new List<Class6>();
      object object0 = this.object_0;
      *(sbyte*) ((IntPtr) voidPtr + 36) = (sbyte) 0;
      try
      {
        // ISSUE: cast to a reference type
        Monitor.Enter(object0, (bool&) ((IntPtr) voidPtr + 36));
        *(int*) voidPtr = Class73.smethod_53(class6_2) - Class73.smethod_84(class6_2);
        *(int*) ((IntPtr) voidPtr + 4) = 0;
label_20:
        *(sbyte*) ((IntPtr) voidPtr + 46) = (sbyte) (*(int*) voidPtr > 0);
        if (*(sbyte*) ((IntPtr) voidPtr + 46) != (sbyte) 0)
        {
          *(int*) ((IntPtr) voidPtr + 8) = *(int*) voidPtr;
          *(int*) ((IntPtr) voidPtr + 12) = Class73.smethod_155(this.class6_0).Length - Class73.smethod_53(this.class6_0);
          *(sbyte*) ((IntPtr) voidPtr + 37) = (sbyte) (*(int*) ((IntPtr) voidPtr + 8) > *(int*) ((IntPtr) voidPtr + 12));
          if (*(sbyte*) ((IntPtr) voidPtr + 37) != (sbyte) 0)
            *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 12);
          *(int*) voidPtr = *(int*) voidPtr - *(int*) ((IntPtr) voidPtr + 8);
          Buffer.BlockCopy((Array) Class73.smethod_155(class6_2), Class73.smethod_84(class6_2) + *(int*) ((IntPtr) voidPtr + 4), (Array) Class73.smethod_155(this.class6_0), Class73.smethod_53(this.class6_0), *(int*) ((IntPtr) voidPtr + 8));
          Class6 class60_1 = this.class6_0;
          Class73.smethod_158(class60_1, Class73.smethod_53(class60_1) + *(int*) ((IntPtr) voidPtr + 8));
          *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + *(int*) ((IntPtr) voidPtr + 8);
          while (true)
          {
            *(sbyte*) ((IntPtr) voidPtr + 45) = (sbyte) (Class73.smethod_53(this.class6_0) > 0);
            if (*(sbyte*) ((IntPtr) voidPtr + 45) != (sbyte) 0)
            {
              *(sbyte*) ((IntPtr) voidPtr + 38) = (sbyte) (this.class6_1 == null);
              if (*(sbyte*) ((IntPtr) voidPtr + 38) != (sbyte) 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 39) = (sbyte) (Class73.smethod_53(this.class6_0) < 2);
                if (*(sbyte*) ((IntPtr) voidPtr + 39) == (sbyte) 0)
                {
                  *(int*) ((IntPtr) voidPtr + 20) = (int) Class73.smethod_155(this.class6_0)[1] << 8 | (int) Class73.smethod_155(this.class6_0)[0];
                  *(sbyte*) ((IntPtr) voidPtr + 40) = (sbyte) ((*(int*) ((IntPtr) voidPtr + 20) & 32768) > 0);
                  if (*(sbyte*) ((IntPtr) voidPtr + 40) != (sbyte) 0)
                  {
                    *(int*) ((IntPtr) voidPtr + 20) = *(int*) ((IntPtr) voidPtr + 20) & (int) short.MaxValue;
                    *(sbyte*) ((IntPtr) voidPtr + 41) = (sbyte) (this.class5_0.byte_1 == (byte) 1);
                    if (*(sbyte*) ((IntPtr) voidPtr + 41) != (sbyte) 0)
                      *(int*) ((IntPtr) voidPtr + 20) = 2 + Class73.smethod_103(this.class0_0, *(int*) ((IntPtr) voidPtr + 20) + 4);
                    else
                      *(int*) ((IntPtr) voidPtr + 20) = *(int*) ((IntPtr) voidPtr + 20) + 6;
                  }
                  else
                    *(int*) ((IntPtr) voidPtr + 20) = *(int*) ((IntPtr) voidPtr + 20) + 6;
                  this.class6_1 = new Class6(*(int*) ((IntPtr) voidPtr + 20), 0, *(int*) ((IntPtr) voidPtr + 20));
                }
                else
                  goto label_20;
              }
              *(int*) ((IntPtr) voidPtr + 16) = Class73.smethod_53(this.class6_1) - Class73.smethod_84(this.class6_1);
              *(sbyte*) ((IntPtr) voidPtr + 42) = (sbyte) (*(int*) ((IntPtr) voidPtr + 16) > Class73.smethod_53(this.class6_0));
              if (*(sbyte*) ((IntPtr) voidPtr + 42) != (sbyte) 0)
                *(int*) ((IntPtr) voidPtr + 16) = Class73.smethod_53(this.class6_0);
              Buffer.BlockCopy((Array) Class73.smethod_155(this.class6_0), 0, (Array) Class73.smethod_155(this.class6_1), Class73.smethod_84(this.class6_1), *(int*) ((IntPtr) voidPtr + 16));
              Class6 class61 = this.class6_1;
              Class73.smethod_6(class61, Class73.smethod_84(class61) + *(int*) ((IntPtr) voidPtr + 16));
              Class6 class60_2 = this.class6_0;
              Class73.smethod_158(class60_2, Class73.smethod_53(class60_2) - *(int*) ((IntPtr) voidPtr + 16));
              *(sbyte*) ((IntPtr) voidPtr + 43) = (sbyte) (Class73.smethod_53(this.class6_0) > 0);
              if (*(sbyte*) ((IntPtr) voidPtr + 43) != (sbyte) 0)
                Buffer.BlockCopy((Array) Class73.smethod_155(this.class6_0), *(int*) ((IntPtr) voidPtr + 16), (Array) Class73.smethod_155(this.class6_0), 0, Class73.smethod_53(this.class6_0));
              *(sbyte*) ((IntPtr) voidPtr + 44) = (sbyte) (Class73.smethod_53(this.class6_1) == Class73.smethod_84(this.class6_1));
              if (*(sbyte*) ((IntPtr) voidPtr + 44) != (sbyte) 0)
              {
                Class73.smethod_6(this.class6_1, 0);
                class6List.Add(this.class6_1);
                this.class6_1 = (Class6) null;
              }
              else
                goto label_20;
            }
            else
              goto label_20;
          }
        }
        else
        {
          *(sbyte*) ((IntPtr) voidPtr + 47) = (sbyte) (class6List.Count > 0);
          if (*(sbyte*) ((IntPtr) voidPtr + 47) == (sbyte) 0)
            return;
          foreach (Class6 class6_0 in class6List)
          {
            *(sbyte*) ((IntPtr) voidPtr + 48) = (sbyte) 0;
            *(int*) ((IntPtr) voidPtr + 24) = (int) Class73.smethod_155(class6_0)[1] << 8 | (int) Class73.smethod_155(class6_0)[0];
            *(sbyte*) ((IntPtr) voidPtr + 51) = (sbyte) ((*(int*) ((IntPtr) voidPtr + 24) & 32768) > 0);
            if (*(sbyte*) ((IntPtr) voidPtr + 51) != (sbyte) 0)
            {
              *(sbyte*) ((IntPtr) voidPtr + 52) = (sbyte) (this.class5_0.byte_1 == (byte) 1);
              if (*(sbyte*) ((IntPtr) voidPtr + 52) != (sbyte) 0)
              {
                *(int*) ((IntPtr) voidPtr + 24) = *(int*) ((IntPtr) voidPtr + 24) & (int) short.MaxValue;
                *(sbyte*) ((IntPtr) voidPtr + 48) = (sbyte) 1;
              }
              else
                *(int*) ((IntPtr) voidPtr + 24) = *(int*) ((IntPtr) voidPtr + 24) & (int) short.MaxValue;
            }
            *(sbyte*) ((IntPtr) voidPtr + 53) = *(sbyte*) ((IntPtr) voidPtr + 48);
            if (*(sbyte*) ((IntPtr) voidPtr + 53) != (sbyte) 0)
            {
              Class0 class00 = this.class0_0;
              byte[] byte_0_1 = Class73.smethod_155(class6_0);
              *(int*) ((IntPtr) voidPtr + 28) = Class73.smethod_53(class6_0) - 2;
              byte[] numArray = Class73.smethod_47(byte_0_1, *(int*) ((IntPtr) voidPtr + 28), 2, class00);
              byte[] byte_0_2 = new byte[6 + *(int*) ((IntPtr) voidPtr + 24)];
              Buffer.BlockCopy((Array) BitConverter.GetBytes((ushort) *(int*) ((IntPtr) voidPtr + 24)), 0, (Array) byte_0_2, 0, 2);
              Buffer.BlockCopy((Array) numArray, 0, (Array) byte_0_2, 2, 4 + *(int*) ((IntPtr) voidPtr + 24));
              Class73.smethod_170(class6_0, (byte[]) null);
              Class73.smethod_170(class6_0, byte_0_2);
            }
            Class2 class2_0 = new Class2(Class73.smethod_155(class6_0));
            *(int*) ((IntPtr) voidPtr + 24) = (int) class2_0.ReadUInt16();
            *(short*) ((IntPtr) voidPtr + 32) = (short) class2_0.ReadUInt16();
            *(sbyte*) ((IntPtr) voidPtr + 49) = (sbyte) class2_0.ReadByte();
            *(sbyte*) ((IntPtr) voidPtr + 50) = (sbyte) class2_0.ReadByte();
            *(sbyte*) ((IntPtr) voidPtr + 54) = (sbyte) this.bool_0;
            if (*(sbyte*) ((IntPtr) voidPtr + 54) != (sbyte) 0)
            {
              *(sbyte*) ((IntPtr) voidPtr + 55) = (sbyte) (this.class5_0.byte_2 == (byte) 1);
              if (*(sbyte*) ((IntPtr) voidPtr + 55) != (sbyte) 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 56) = (sbyte) Class73.smethod_80(true, this);
                *(sbyte*) ((IntPtr) voidPtr + 58) = (sbyte) ((int) *(byte*) ((IntPtr) voidPtr + 49) != (int) *(byte*) ((IntPtr) voidPtr + 56));
                if (*(sbyte*) ((IntPtr) voidPtr + 58) != (sbyte) 0)
                  ;
                if ((*(sbyte*) ((IntPtr) voidPtr + 48) != (sbyte) 0 ? 1 : (this.class5_0.byte_2 != (byte) 1 ? 0 : (this.class5_0.byte_1 == (byte) 0 ? 1 : 0))) != 0 && (*(sbyte*) ((IntPtr) voidPtr + 48) != (sbyte) 0 ? 1 : (this.list_2.Contains(*(ushort*) ((IntPtr) voidPtr + 32)) ? 1 : 0)) != 0)
                {
                  *(int*) ((IntPtr) voidPtr + 24) = *(int*) ((IntPtr) voidPtr + 24) | 32768;
                  Buffer.BlockCopy((Array) BitConverter.GetBytes((ushort) *(int*) ((IntPtr) voidPtr + 24)), 0, (Array) Class73.smethod_155(class6_0), 0, 2);
                }
                Class73.smethod_155(class6_0)[5] = (byte) 0;
                *(sbyte*) ((IntPtr) voidPtr + 57) = (sbyte) Class73.smethod_139(this, Class73.smethod_155(class6_0));
                *(sbyte*) ((IntPtr) voidPtr + 59) = (sbyte) ((int) *(byte*) ((IntPtr) voidPtr + 50) != (int) *(byte*) ((IntPtr) voidPtr + 57));
                if (*(sbyte*) ((IntPtr) voidPtr + 59) != (sbyte) 0)
                  ;
                Class73.smethod_155(class6_0)[4] = (byte) 0;
                if ((*(sbyte*) ((IntPtr) voidPtr + 48) != (sbyte) 0 ? 1 : (this.class5_0.byte_2 != (byte) 1 ? 0 : (this.class5_0.byte_1 == (byte) 0 ? 1 : 0))) != 0 && (*(sbyte*) ((IntPtr) voidPtr + 48) != (sbyte) 0 ? 1 : (this.list_2.Contains(*(ushort*) ((IntPtr) voidPtr + 32)) ? 1 : 0)) != 0)
                {
                  *(int*) ((IntPtr) voidPtr + 24) = *(int*) ((IntPtr) voidPtr + 24) & (int) short.MaxValue;
                  Buffer.BlockCopy((Array) BitConverter.GetBytes((ushort) *(int*) ((IntPtr) voidPtr + 24)), 0, (Array) Class73.smethod_155(class6_0), 0, 2);
                }
              }
            }
            if ((*(ushort*) ((IntPtr) voidPtr + 32) == (ushort) 20480 ? 1 : (*(ushort*) ((IntPtr) voidPtr + 32) == (ushort) 36864 ? 1 : 0)) != 0)
            {
              Class73.smethod_15(class2_0, (bool) *(sbyte*) ((IntPtr) voidPtr + 48), *(ushort*) ((IntPtr) voidPtr + 32), this);
              Class1 class1_0 = new Class1(*(ushort*) ((IntPtr) voidPtr + 32), (bool) *(sbyte*) ((IntPtr) voidPtr + 48), false, Class73.smethod_155(class6_0), 6, *(int*) ((IntPtr) voidPtr + 24));
              Class73.smethod_44(class1_0);
              this.list_0.Add(class1_0);
            }
            else
            {
              *(sbyte*) ((IntPtr) voidPtr + 60) = (sbyte) this.bool_0;
              if (*(sbyte*) ((IntPtr) voidPtr + 60) != (sbyte) 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 61) = (sbyte) !this.bool_1;
                if (*(sbyte*) ((IntPtr) voidPtr + 61) != (sbyte) 0)
                  throw new Exception("[SecurityAPI::Recv] The client has not accepted the handshake.");
              }
              *(sbyte*) ((IntPtr) voidPtr + 62) = (sbyte) (*(ushort*) ((IntPtr) voidPtr + 32) == (ushort) 24589);
              if (*(sbyte*) ((IntPtr) voidPtr + 62) != (sbyte) 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 63) = (sbyte) class2_0.ReadByte();
                *(sbyte*) ((IntPtr) voidPtr + 64) = (sbyte) (*(byte*) ((IntPtr) voidPtr + 63) == (byte) 1);
                if (*(sbyte*) ((IntPtr) voidPtr + 64) != (sbyte) 0)
                {
                  this.ushort_0 = class2_0.ReadUInt16();
                  *(short*) ((IntPtr) voidPtr + 34) = (short) class2_0.ReadUInt16();
                  this.class1_0 = new Class1(*(ushort*) ((IntPtr) voidPtr + 34), (bool) *(sbyte*) ((IntPtr) voidPtr + 48), true);
                }
                else
                {
                  *(sbyte*) ((IntPtr) voidPtr + 65) = (sbyte) (this.class1_0 == null);
                  if (*(sbyte*) ((IntPtr) voidPtr + 65) != (sbyte) 0)
                    throw new Exception("[SecurityAPI::Recv] A malformed 0x600D packet was received.");
                  Class73.smethod_42(this.class1_0, class2_0.ReadBytes(*(int*) ((IntPtr) voidPtr + 24) - 1));
                  --this.ushort_0;
                  *(sbyte*) ((IntPtr) voidPtr + 66) = (sbyte) (this.ushort_0 == (ushort) 0);
                  if (*(sbyte*) ((IntPtr) voidPtr + 66) != (sbyte) 0)
                  {
                    Class73.smethod_44(this.class1_0);
                    this.list_0.Add(this.class1_0);
                    this.class1_0 = (Class1) null;
                  }
                }
              }
              else
              {
                Class1 class1_0 = new Class1(*(ushort*) ((IntPtr) voidPtr + 32), (bool) *(sbyte*) ((IntPtr) voidPtr + 48), false, Class73.smethod_155(class6_0), 6, *(int*) ((IntPtr) voidPtr + 24));
                Class73.smethod_44(class1_0);
                this.list_0.Add(class1_0);
              }
            }
          }
        }
      }
      finally
      {
        if (*(sbyte*) ((IntPtr) voidPtr + 36) != (sbyte) 0)
          Monitor.Exit(object0);
      }
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    internal sealed class Class5
    {
      [FieldOffset(0)]
      public byte byte_0;
      [FieldOffset(1)]
      public byte byte_1;
      [FieldOffset(2)]
      public byte byte_2;
      [FieldOffset(3)]
      public byte byte_3;
      [FieldOffset(4)]
      public byte byte_4;
      [FieldOffset(5)]
      public byte byte_5;
      [FieldOffset(6)]
      public byte byte_6;
      [FieldOffset(7)]
      public byte byte_7;
    }
  }
}
