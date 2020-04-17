// Decompiled with Syinea's Decompiler
// Type: ns2.Class73
// Assembly: My_EventBot_ßy_Mehmet_Yıldız_ML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B7172642-DC7D-4477-97BD-E927F8349F37
// Assembly location: C:\Users\Syinea\Downloads\CrackedMyEventBot\CrackedVsroEfsane.exe

using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.Utils.Behaviors;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraTab;
using ns0;
using ns1;
using ns10;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;
using ns8;
using ns9;
using SmartAssembly.MemoryManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ns2
{
  internal sealed class Class73
  {
    static void smethod_0(uint uint_0, int int_0, int int_1, Class29 class29_0)
    {
      if (int_1 == class29_0.int_0)
        return;
      class29_0.int_0 = int_1;
    }

    static string smethod_1(string string_0)
    {
      return Class73.smethod_81(BitConverter.ToString(new SHA384Managed().ComputeHash(Class73.smethod_50(string_0))));
    }

    static unsafe void smethod_2(int int_0, short[] short_0, short[] short_1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(15);
      short[] numArray1 = new short[16];
      short num1 = 0;
      *(int*) voidPtr = 1;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) (*(int*) voidPtr <= 15);
        if (*(sbyte*) ((IntPtr) voidPtr + 12) != (sbyte) 0)
        {
          numArray1[*(int*) voidPtr] = num1 = (short) ((int) num1 + (int) short_1[*(int*) voidPtr - 1] << 1);
          *(int*) voidPtr = *(int*) voidPtr + 1;
        }
        else
          break;
      }
      *(int*) ((IntPtr) voidPtr + 4) = 0;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 14) = (sbyte) (*(int*) ((IntPtr) voidPtr + 4) <= int_0);
        if (*(sbyte*) ((IntPtr) voidPtr + 14) != (sbyte) 0)
        {
          *(int*) ((IntPtr) voidPtr + 8) = (int) short_0[*(int*) ((IntPtr) voidPtr + 4) * 2 + 1];
          *(sbyte*) ((IntPtr) voidPtr + 13) = (sbyte) (*(int*) ((IntPtr) voidPtr + 8) == 0);
          if (*(sbyte*) ((IntPtr) voidPtr + 13) == (sbyte) 0)
          {
            short[] numArray2 = short_0;
            int index = *(int*) ((IntPtr) voidPtr + 4) * 2;
            short num2 = numArray1[*(int*) ((IntPtr) voidPtr + 8)]++;
            int num3 = (int) (short) Class73.smethod_172(*(int*) ((IntPtr) voidPtr + 8), (int) num2);
            numArray2[index] = (short) num3;
          }
          *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + 1;
        }
        else
          break;
      }
    }

    static unsafe void smethod_3(Class17 class17_0, Class9 class9_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(39);
      short[] short0 = class17_0.short_0;
      short[] short2 = class17_0.class15_0.short_2;
      int[] int1 = class17_0.class15_0.int_1;
      *(int*) voidPtr = class17_0.class15_0.int_2;
      *(int*) ((IntPtr) voidPtr + 4) = class17_0.class15_0.int_4;
      *(int*) ((IntPtr) voidPtr + 20) = 0;
      *(int*) ((IntPtr) voidPtr + 12) = 0;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 26) = (sbyte) (*(int*) ((IntPtr) voidPtr + 12) <= 15);
        if (*(sbyte*) ((IntPtr) voidPtr + 26) != (sbyte) 0)
        {
          class9_0.short_5[*(int*) ((IntPtr) voidPtr + 12)] = (short) 0;
          *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + 1;
        }
        else
          break;
      }
      short0[class9_0.int_31[class9_0.int_33] * 2 + 1] = (short) 0;
      int index = class9_0.int_33 + 1;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 31) = (sbyte) (index < Class17.int_1);
        if (*(sbyte*) ((IntPtr) voidPtr + 31) != (sbyte) 0)
        {
          *(int*) ((IntPtr) voidPtr + 8) = class9_0.int_31[index];
          *(int*) ((IntPtr) voidPtr + 12) = (int) short0[(int) short0[*(int*) ((IntPtr) voidPtr + 8) * 2 + 1] * 2 + 1] + 1;
          *(sbyte*) ((IntPtr) voidPtr + 27) = (sbyte) (*(int*) ((IntPtr) voidPtr + 12) > *(int*) ((IntPtr) voidPtr + 4));
          if (*(sbyte*) ((IntPtr) voidPtr + 27) != (sbyte) 0)
          {
            *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 4);
            *(int*) ((IntPtr) voidPtr + 20) = *(int*) ((IntPtr) voidPtr + 20) + 1;
          }
          short0[*(int*) ((IntPtr) voidPtr + 8) * 2 + 1] = (short) *(int*) ((IntPtr) voidPtr + 12);
          *(sbyte*) ((IntPtr) voidPtr + 28) = (sbyte) (*(int*) ((IntPtr) voidPtr + 8) > class17_0.int_7);
          if (*(sbyte*) ((IntPtr) voidPtr + 28) == (sbyte) 0)
          {
            ++class9_0.short_5[*(int*) ((IntPtr) voidPtr + 12)];
            *(int*) ((IntPtr) voidPtr + 16) = 0;
            *(sbyte*) ((IntPtr) voidPtr + 29) = (sbyte) (*(int*) ((IntPtr) voidPtr + 8) >= *(int*) voidPtr);
            if (*(sbyte*) ((IntPtr) voidPtr + 29) != (sbyte) 0)
              *(int*) ((IntPtr) voidPtr + 16) = int1[*(int*) ((IntPtr) voidPtr + 8) - *(int*) voidPtr];
            *(short*) ((IntPtr) voidPtr + 24) = short0[*(int*) ((IntPtr) voidPtr + 8) * 2];
            class9_0.int_38 += (int) *(short*) ((IntPtr) voidPtr + 24) * (*(int*) ((IntPtr) voidPtr + 12) + *(int*) ((IntPtr) voidPtr + 16));
            *(sbyte*) ((IntPtr) voidPtr + 30) = (sbyte) (short2 != null);
            if (*(sbyte*) ((IntPtr) voidPtr + 30) != (sbyte) 0)
              class9_0.int_39 += (int) *(short*) ((IntPtr) voidPtr + 24) * ((int) short2[*(int*) ((IntPtr) voidPtr + 8) * 2 + 1] + *(int*) ((IntPtr) voidPtr + 16));
          }
          ++index;
        }
        else
          break;
      }
      *(sbyte*) ((IntPtr) voidPtr + 32) = (sbyte) (*(int*) ((IntPtr) voidPtr + 20) == 0);
      if (*(sbyte*) ((IntPtr) voidPtr + 32) != (sbyte) 0)
        return;
      do
      {
        *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 4) - 1;
        while (true)
        {
          *(sbyte*) ((IntPtr) voidPtr + 33) = (sbyte) (class9_0.short_5[*(int*) ((IntPtr) voidPtr + 12)] == (short) 0);
          if (*(sbyte*) ((IntPtr) voidPtr + 33) != (sbyte) 0)
            *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) - 1;
          else
            break;
        }
        --class9_0.short_5[*(int*) ((IntPtr) voidPtr + 12)];
        class9_0.short_5[*(int*) ((IntPtr) voidPtr + 12) + 1] = (short) ((int) class9_0.short_5[*(int*) ((IntPtr) voidPtr + 12) + 1] + 2);
        --class9_0.short_5[*(int*) ((IntPtr) voidPtr + 4)];
        *(int*) ((IntPtr) voidPtr + 20) = *(int*) ((IntPtr) voidPtr + 20) - 2;
        *(sbyte*) ((IntPtr) voidPtr + 34) = (sbyte) (*(int*) ((IntPtr) voidPtr + 20) > 0);
      }
      while (*(sbyte*) ((IntPtr) voidPtr + 34) != (sbyte) 0);
      *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 4);
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 38) = (sbyte) ((uint) *(int*) ((IntPtr) voidPtr + 12) > 0U);
        if (*(sbyte*) ((IntPtr) voidPtr + 38) != (sbyte) 0)
        {
          *(int*) ((IntPtr) voidPtr + 8) = (int) class9_0.short_5[*(int*) ((IntPtr) voidPtr + 12)];
          while (true)
          {
            int num;
            do
            {
              *(sbyte*) ((IntPtr) voidPtr + 37) = (sbyte) ((uint) *(int*) ((IntPtr) voidPtr + 8) > 0U);
              if (*(sbyte*) ((IntPtr) voidPtr + 37) != (sbyte) 0)
              {
                num = class9_0.int_31[--index];
                *(sbyte*) ((IntPtr) voidPtr + 35) = (sbyte) (num > class17_0.int_7);
              }
              else
                goto label_26;
            }
            while (*(sbyte*) ((IntPtr) voidPtr + 35) != (sbyte) 0);
            *(sbyte*) ((IntPtr) voidPtr + 36) = (sbyte) ((int) short0[num * 2 + 1] != *(int*) ((IntPtr) voidPtr + 12));
            if (*(sbyte*) ((IntPtr) voidPtr + 36) != (sbyte) 0)
            {
              class9_0.int_38 = (int) ((long) class9_0.int_38 + ((long) *(int*) ((IntPtr) voidPtr + 12) - (long) short0[num * 2 + 1]) * (long) short0[num * 2]);
              short0[num * 2 + 1] = (short) *(int*) ((IntPtr) voidPtr + 12);
            }
            *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) - 1;
          }
label_26:
          *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) - 1;
        }
        else
          break;
      }
    }

    static int smethod_4(
      Class18 class18_0,
      int[] int_0,
      int[] int_1,
      int[][] int_2,
      int[][] int_3)
    {
      int_1[0] = 9;
      int_0[0] = 5;
      int_2[0] = Class14.int_0;
      int_3[0] = Class14.int_1;
      return 0;
    }

    static void smethod_5()
    {
      try
      {
        SqlDataReader sqlDataReader = new SqlCommand("Select Party_No from My_EventBot.._PartyListesi where CharName16='" + Form1.form1_0.textEdit_18.Text + "'", Class65.sqlConnection_0).ExecuteReader();
        sqlDataReader.Read();
        int int32 = Convert.ToInt32(sqlDataReader[0]);
        try
        {
          Class73.smethod_72(int32, Class25.class19_0);
        }
        catch
        {
          Form1.smethod_0("Party kapatma işlemi başarısız.");
        }
      }
      catch (Exception ex)
      {
        Form1.smethod_0("My_EventBot karakterine ait party numarası veritabanından alınamadı. HATA => " + ex.Message);
      }
    }

    static void smethod_6(Class6 class6_0, int int_0)
    {
      lock (class6_0.object_0)
        class6_0.int_0 = int_0;
    }

    static short smethod_7(int int_0)
    {
      return (short) ((int) Class80.Class86.byte_0[int_0 & 15] << 12 | (int) Class80.Class86.byte_0[int_0 >> 4 & 15] << 8 | (int) Class80.Class86.byte_0[int_0 >> 8 & 15] << 4 | (int) Class80.Class86.byte_0[int_0 >> 12]);
    }

    static unsafe void smethod_8(short[] short_0, Class9 class9_0, int int_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(32);
      *(int*) ((IntPtr) voidPtr + 4) = -1;
      *(int*) ((IntPtr) voidPtr + 12) = (int) short_0[1];
      int num = 0;
      *(int*) ((IntPtr) voidPtr + 16) = 7;
      *(int*) ((IntPtr) voidPtr + 20) = 4;
      *(sbyte*) ((IntPtr) voidPtr + 24) = (sbyte) (*(int*) ((IntPtr) voidPtr + 12) == 0);
      if (*(sbyte*) ((IntPtr) voidPtr + 24) != (sbyte) 0)
      {
        *(int*) ((IntPtr) voidPtr + 16) = 138;
        *(int*) ((IntPtr) voidPtr + 20) = 3;
      }
      *(int*) voidPtr = 0;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 31) = (sbyte) (*(int*) voidPtr <= int_0);
        if (*(sbyte*) ((IntPtr) voidPtr + 31) != (sbyte) 0)
        {
          *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 12);
          *(int*) ((IntPtr) voidPtr + 12) = (int) short_0[(*(int*) voidPtr + 1) * 2 + 1];
          if ((++num >= *(int*) ((IntPtr) voidPtr + 16) ? 0 : (*(int*) ((IntPtr) voidPtr + 8) == *(int*) ((IntPtr) voidPtr + 12) ? 1 : 0)) == 0)
          {
            *(sbyte*) ((IntPtr) voidPtr + 25) = (sbyte) (num < *(int*) ((IntPtr) voidPtr + 20));
            if (*(sbyte*) ((IntPtr) voidPtr + 25) != (sbyte) 0)
            {
              do
              {
                Class73.smethod_137(class9_0, *(int*) ((IntPtr) voidPtr + 8), class9_0.short_4);
              }
              while ((uint) --num > 0U);
            }
            else
            {
              *(sbyte*) ((IntPtr) voidPtr + 26) = (sbyte) ((uint) *(int*) ((IntPtr) voidPtr + 8) > 0U);
              if (*(sbyte*) ((IntPtr) voidPtr + 26) != (sbyte) 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 27) = (sbyte) (*(int*) ((IntPtr) voidPtr + 8) != *(int*) ((IntPtr) voidPtr + 4));
                if (*(sbyte*) ((IntPtr) voidPtr + 27) != (sbyte) 0)
                {
                  Class73.smethod_137(class9_0, *(int*) ((IntPtr) voidPtr + 8), class9_0.short_4);
                  --num;
                }
                Class73.smethod_137(class9_0, 16, class9_0.short_4);
                Class73.smethod_61(class9_0, num - 3, 2);
              }
              else
              {
                *(sbyte*) ((IntPtr) voidPtr + 28) = (sbyte) (num <= 10);
                if (*(sbyte*) ((IntPtr) voidPtr + 28) != (sbyte) 0)
                {
                  Class73.smethod_137(class9_0, 17, class9_0.short_4);
                  Class73.smethod_61(class9_0, num - 3, 3);
                }
                else
                {
                  Class73.smethod_137(class9_0, 18, class9_0.short_4);
                  Class73.smethod_61(class9_0, num - 11, 7);
                }
              }
            }
            num = 0;
            *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 8);
            *(sbyte*) ((IntPtr) voidPtr + 29) = (sbyte) (*(int*) ((IntPtr) voidPtr + 12) == 0);
            if (*(sbyte*) ((IntPtr) voidPtr + 29) != (sbyte) 0)
            {
              *(int*) ((IntPtr) voidPtr + 16) = 138;
              *(int*) ((IntPtr) voidPtr + 20) = 3;
            }
            else
            {
              *(sbyte*) ((IntPtr) voidPtr + 30) = (sbyte) (*(int*) ((IntPtr) voidPtr + 8) == *(int*) ((IntPtr) voidPtr + 12));
              if (*(sbyte*) ((IntPtr) voidPtr + 30) != (sbyte) 0)
              {
                *(int*) ((IntPtr) voidPtr + 16) = 6;
                *(int*) ((IntPtr) voidPtr + 20) = 3;
              }
              else
              {
                *(int*) ((IntPtr) voidPtr + 16) = 7;
                *(int*) ((IntPtr) voidPtr + 20) = 4;
              }
            }
          }
          *(int*) voidPtr = *(int*) voidPtr + 1;
        }
        else
          break;
      }
    }

    static unsafe void smethod_9(Class1 class1_0, uint uint_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      object object0 = class1_0.object_0;
      *(sbyte*) voidPtr = (sbyte) 0;
      try
      {
        Monitor.Enter(object0, ref *(bool*) voidPtr);
        *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) class1_0.bool_2;
        if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
          throw new Exception("Cannot Write to a locked Packet.");
        class1_0.class3_0.Write(uint_0);
      }
      finally
      {
        if (*(sbyte*) voidPtr != (sbyte) 0)
          Monitor.Exit(object0);
      }
    }

    static void smethod_10()
    {
      try
      {
        Class78.smethod_0();
      }
      catch (Exception ex)
      {
      }
    }

    static unsafe ushort smethod_11(Class1 class1_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(4);
      object object0 = class1_0.object_0;
      *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) 0;
      try
      {
        // ISSUE: cast to a reference type
        Monitor.Enter(object0, (bool&) ((IntPtr) voidPtr + 2));
        *(sbyte*) ((IntPtr) voidPtr + 3) = (sbyte) !class1_0.bool_2;
        if (*(sbyte*) ((IntPtr) voidPtr + 3) != (sbyte) 0)
          throw new Exception("Cannot Read from an unlocked Packet.");
        *(short*) voidPtr = (short) class1_0.class2_0.ReadUInt16();
      }
      finally
      {
        if (*(sbyte*) ((IntPtr) voidPtr + 2) != (sbyte) 0)
          Monitor.Exit(object0);
      }
      return *(ushort*) voidPtr;
    }

    static unsafe int smethod_12(
      int int_0,
      Class12 class12_0,
      Class11 class11_0,
      Class18 class18_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(71);
      *(int*) ((IntPtr) voidPtr + 12) = 0;
      int int1 = class18_0.int_1;
      *(int*) ((IntPtr) voidPtr + 16) = class18_0.int_2;
      int int_1 = class11_0.int_11;
      *(int*) ((IntPtr) voidPtr + 12) = class11_0.int_10;
      int num1 = class11_0.int_15;
      int num2 = num1 < class11_0.int_14 ? class11_0.int_14 - num1 - 1 : class11_0.int_13 - num1;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 70) = (sbyte) 1;
        *(int*) ((IntPtr) voidPtr + 20) = class12_0.int_1;
        switch (*(int*) ((IntPtr) voidPtr + 20))
        {
          case 0:
            if ((num2 < 258 ? 0 : (*(int*) ((IntPtr) voidPtr + 16) >= 10 ? 1 : 0)) != 0)
            {
              class11_0.int_11 = int_1;
              class11_0.int_10 = *(int*) ((IntPtr) voidPtr + 12);
              class18_0.int_2 = *(int*) ((IntPtr) voidPtr + 16);
              class18_0.long_0 += (long) (int1 - class18_0.int_1);
              class18_0.int_1 = int1;
              class11_0.int_15 = num1;
              *(int*) ((IntPtr) voidPtr + 28) = (int) class12_0.byte_0;
              *(int*) ((IntPtr) voidPtr + 32) = (int) class12_0.byte_1;
              int[] int9 = class12_0.int_9;
              *(int*) ((IntPtr) voidPtr + 36) = class12_0.int_10;
              int[] int11 = class12_0.int_11;
              *(int*) ((IntPtr) voidPtr + 40) = class12_0.int_12;
              int_0 = Class73.smethod_191(*(int*) ((IntPtr) voidPtr + 40), *(int*) ((IntPtr) voidPtr + 28), *(int*) ((IntPtr) voidPtr + 36), int9, *(int*) ((IntPtr) voidPtr + 32), int11, class18_0, class11_0, class12_0);
              int1 = class18_0.int_1;
              *(int*) ((IntPtr) voidPtr + 16) = class18_0.int_2;
              int_1 = class11_0.int_11;
              *(int*) ((IntPtr) voidPtr + 12) = class11_0.int_10;
              num1 = class11_0.int_15;
              num2 = num1 < class11_0.int_14 ? class11_0.int_14 - num1 - 1 : class11_0.int_13 - num1;
              *(sbyte*) ((IntPtr) voidPtr + 44) = (sbyte) ((uint) int_0 > 0U);
              if (*(sbyte*) ((IntPtr) voidPtr + 44) != (sbyte) 0)
              {
                class12_0.int_1 = int_0 == 1 ? 7 : 9;
                continue;
              }
            }
            class12_0.int_5 = (int) class12_0.byte_0;
            class12_0.int_3 = class12_0.int_9;
            class12_0.int_4 = class12_0.int_10;
            class12_0.int_1 = 1;
            goto case 1;
          case 1:
            *(int*) voidPtr = class12_0.int_5;
            while (true)
            {
              *(sbyte*) ((IntPtr) voidPtr + 46) = (sbyte) (*(int*) ((IntPtr) voidPtr + 12) < *(int*) voidPtr);
              if (*(sbyte*) ((IntPtr) voidPtr + 46) != (sbyte) 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 45) = (sbyte) ((uint) *(int*) ((IntPtr) voidPtr + 16) > 0U);
                if (*(sbyte*) ((IntPtr) voidPtr + 45) != (sbyte) 0)
                {
                  int_0 = 0;
                  *(int*) ((IntPtr) voidPtr + 16) = *(int*) ((IntPtr) voidPtr + 16) - 1;
                  int_1 |= ((int) class18_0.byte_0[int1++] & (int) byte.MaxValue) << *(int*) ((IntPtr) voidPtr + 12);
                  *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + 8;
                }
                else
                  goto label_61;
              }
              else
                break;
            }
            *(int*) ((IntPtr) voidPtr + 4) = (class12_0.int_4 + (int_1 & Class12.int_0[*(int*) voidPtr])) * 3;
            int_1 = Class73.smethod_108(class12_0.int_3[*(int*) ((IntPtr) voidPtr + 4) + 1], int_1);
            *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) - class12_0.int_3[*(int*) ((IntPtr) voidPtr + 4) + 1];
            *(int*) ((IntPtr) voidPtr + 8) = class12_0.int_3[*(int*) ((IntPtr) voidPtr + 4)];
            *(sbyte*) ((IntPtr) voidPtr + 47) = (sbyte) (*(int*) ((IntPtr) voidPtr + 8) == 0);
            if (*(sbyte*) ((IntPtr) voidPtr + 47) != (sbyte) 0)
            {
              class12_0.int_6 = class12_0.int_3[*(int*) ((IntPtr) voidPtr + 4) + 2];
              class12_0.int_1 = 6;
              continue;
            }
            *(sbyte*) ((IntPtr) voidPtr + 48) = (sbyte) ((uint) (*(int*) ((IntPtr) voidPtr + 8) & 16) > 0U);
            if (*(sbyte*) ((IntPtr) voidPtr + 48) != (sbyte) 0)
            {
              class12_0.int_7 = *(int*) ((IntPtr) voidPtr + 8) & 15;
              class12_0.int_2 = class12_0.int_3[*(int*) ((IntPtr) voidPtr + 4) + 2];
              class12_0.int_1 = 2;
              continue;
            }
            *(sbyte*) ((IntPtr) voidPtr + 49) = (sbyte) ((*(int*) ((IntPtr) voidPtr + 8) & 64) == 0);
            if (*(sbyte*) ((IntPtr) voidPtr + 49) != (sbyte) 0)
            {
              class12_0.int_5 = *(int*) ((IntPtr) voidPtr + 8);
              class12_0.int_4 = *(int*) ((IntPtr) voidPtr + 4) / 3 + class12_0.int_3[*(int*) ((IntPtr) voidPtr + 4) + 2];
              continue;
            }
            *(sbyte*) ((IntPtr) voidPtr + 50) = (sbyte) ((uint) (*(int*) ((IntPtr) voidPtr + 8) & 32) > 0U);
            if (*(sbyte*) ((IntPtr) voidPtr + 50) != (sbyte) 0)
            {
              class12_0.int_1 = 7;
              continue;
            }
            goto label_60;
          case 2:
            *(int*) voidPtr = class12_0.int_7;
            while (true)
            {
              *(sbyte*) ((IntPtr) voidPtr + 52) = (sbyte) (*(int*) ((IntPtr) voidPtr + 12) < *(int*) voidPtr);
              if (*(sbyte*) ((IntPtr) voidPtr + 52) != (sbyte) 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 51) = (sbyte) ((uint) *(int*) ((IntPtr) voidPtr + 16) > 0U);
                if (*(sbyte*) ((IntPtr) voidPtr + 51) != (sbyte) 0)
                {
                  int_0 = 0;
                  *(int*) ((IntPtr) voidPtr + 16) = *(int*) ((IntPtr) voidPtr + 16) - 1;
                  int_1 |= ((int) class18_0.byte_0[int1++] & (int) byte.MaxValue) << *(int*) ((IntPtr) voidPtr + 12);
                  *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + 8;
                }
                else
                  goto label_62;
              }
              else
                break;
            }
            class12_0.int_2 += int_1 & Class12.int_0[*(int*) voidPtr];
            int_1 >>= *(int*) voidPtr;
            *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) - *(int*) voidPtr;
            class12_0.int_5 = (int) class12_0.byte_1;
            class12_0.int_3 = class12_0.int_11;
            class12_0.int_4 = class12_0.int_12;
            class12_0.int_1 = 3;
            goto case 3;
          case 3:
            *(int*) voidPtr = class12_0.int_5;
            while (true)
            {
              *(sbyte*) ((IntPtr) voidPtr + 54) = (sbyte) (*(int*) ((IntPtr) voidPtr + 12) < *(int*) voidPtr);
              if (*(sbyte*) ((IntPtr) voidPtr + 54) != (sbyte) 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 53) = (sbyte) ((uint) *(int*) ((IntPtr) voidPtr + 16) > 0U);
                if (*(sbyte*) ((IntPtr) voidPtr + 53) != (sbyte) 0)
                {
                  int_0 = 0;
                  *(int*) ((IntPtr) voidPtr + 16) = *(int*) ((IntPtr) voidPtr + 16) - 1;
                  int_1 |= ((int) class18_0.byte_0[int1++] & (int) byte.MaxValue) << *(int*) ((IntPtr) voidPtr + 12);
                  *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + 8;
                }
                else
                  goto label_64;
              }
              else
                break;
            }
            *(int*) ((IntPtr) voidPtr + 4) = (class12_0.int_4 + (int_1 & Class12.int_0[*(int*) voidPtr])) * 3;
            int_1 >>= class12_0.int_3[*(int*) ((IntPtr) voidPtr + 4) + 1];
            *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) - class12_0.int_3[*(int*) ((IntPtr) voidPtr + 4) + 1];
            *(int*) ((IntPtr) voidPtr + 8) = class12_0.int_3[*(int*) ((IntPtr) voidPtr + 4)];
            *(sbyte*) ((IntPtr) voidPtr + 55) = (sbyte) ((uint) (*(int*) ((IntPtr) voidPtr + 8) & 16) > 0U);
            if (*(sbyte*) ((IntPtr) voidPtr + 55) != (sbyte) 0)
            {
              class12_0.int_7 = *(int*) ((IntPtr) voidPtr + 8) & 15;
              class12_0.int_8 = class12_0.int_3[*(int*) ((IntPtr) voidPtr + 4) + 2];
              class12_0.int_1 = 4;
              continue;
            }
            *(sbyte*) ((IntPtr) voidPtr + 56) = (sbyte) ((*(int*) ((IntPtr) voidPtr + 8) & 64) == 0);
            if (*(sbyte*) ((IntPtr) voidPtr + 56) != (sbyte) 0)
            {
              class12_0.int_5 = *(int*) ((IntPtr) voidPtr + 8);
              class12_0.int_4 = *(int*) ((IntPtr) voidPtr + 4) / 3 + class12_0.int_3[*(int*) ((IntPtr) voidPtr + 4) + 2];
              continue;
            }
            goto label_63;
          case 4:
            *(int*) voidPtr = class12_0.int_7;
            while (true)
            {
              *(sbyte*) ((IntPtr) voidPtr + 58) = (sbyte) (*(int*) ((IntPtr) voidPtr + 12) < *(int*) voidPtr);
              if (*(sbyte*) ((IntPtr) voidPtr + 58) != (sbyte) 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 57) = (sbyte) ((uint) *(int*) ((IntPtr) voidPtr + 16) > 0U);
                if (*(sbyte*) ((IntPtr) voidPtr + 57) != (sbyte) 0)
                {
                  int_0 = 0;
                  *(int*) ((IntPtr) voidPtr + 16) = *(int*) ((IntPtr) voidPtr + 16) - 1;
                  int_1 |= ((int) class18_0.byte_0[int1++] & (int) byte.MaxValue) << *(int*) ((IntPtr) voidPtr + 12);
                  *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + 8;
                }
                else
                  goto label_65;
              }
              else
                break;
            }
            class12_0.int_8 += int_1 & Class12.int_0[*(int*) voidPtr];
            int_1 >>= *(int*) voidPtr;
            *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) - *(int*) voidPtr;
            class12_0.int_1 = 5;
            goto case 5;
          case 5:
            int num3 = num1 - class12_0.int_8;
            while (true)
            {
              *(sbyte*) ((IntPtr) voidPtr + 59) = (sbyte) (num3 < 0);
              if (*(sbyte*) ((IntPtr) voidPtr + 59) != (sbyte) 0)
                num3 += class11_0.int_13;
              else
                break;
            }
            while (true)
            {
              *(sbyte*) ((IntPtr) voidPtr + 64) = (sbyte) ((uint) class12_0.int_2 > 0U);
              if (*(sbyte*) ((IntPtr) voidPtr + 64) != (sbyte) 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 60) = (sbyte) (num2 == 0);
                if (*(sbyte*) ((IntPtr) voidPtr + 60) != (sbyte) 0)
                {
                  if ((num1 != class11_0.int_13 ? 0 : ((uint) class11_0.int_14 > 0U ? 1 : 0)) != 0)
                  {
                    num1 = 0;
                    num2 = 0 < class11_0.int_14 ? class11_0.int_14 - num1 - 1 : class11_0.int_13 - num1;
                  }
                  *(sbyte*) ((IntPtr) voidPtr + 61) = (sbyte) (num2 == 0);
                  if (*(sbyte*) ((IntPtr) voidPtr + 61) != (sbyte) 0)
                  {
                    class11_0.int_15 = num1;
                    int_0 = Class73.smethod_144(int_0, class11_0, class18_0);
                    num1 = class11_0.int_15;
                    num2 = num1 < class11_0.int_14 ? class11_0.int_14 - num1 - 1 : class11_0.int_13 - num1;
                    if ((num1 != class11_0.int_13 ? 0 : ((uint) class11_0.int_14 > 0U ? 1 : 0)) != 0)
                    {
                      num1 = 0;
                      num2 = 0 < class11_0.int_14 ? class11_0.int_14 - num1 - 1 : class11_0.int_13 - num1;
                    }
                    *(sbyte*) ((IntPtr) voidPtr + 62) = (sbyte) (num2 == 0);
                    if (*(sbyte*) ((IntPtr) voidPtr + 62) != (sbyte) 0)
                      goto label_66;
                  }
                }
                class11_0.byte_0[num1++] = class11_0.byte_0[num3++];
                --num2;
                *(sbyte*) ((IntPtr) voidPtr + 63) = (sbyte) (num3 == class11_0.int_13);
                if (*(sbyte*) ((IntPtr) voidPtr + 63) != (sbyte) 0)
                  num3 = 0;
                --class12_0.int_2;
              }
              else
                break;
            }
            class12_0.int_1 = 0;
            continue;
          case 6:
            *(sbyte*) ((IntPtr) voidPtr + 65) = (sbyte) (num2 == 0);
            if (*(sbyte*) ((IntPtr) voidPtr + 65) != (sbyte) 0)
            {
              if ((num1 != class11_0.int_13 ? 0 : ((uint) class11_0.int_14 > 0U ? 1 : 0)) != 0)
              {
                num1 = 0;
                num2 = 0 < class11_0.int_14 ? class11_0.int_14 - num1 - 1 : class11_0.int_13 - num1;
              }
              *(sbyte*) ((IntPtr) voidPtr + 66) = (sbyte) (num2 == 0);
              if (*(sbyte*) ((IntPtr) voidPtr + 66) != (sbyte) 0)
              {
                class11_0.int_15 = num1;
                int_0 = Class73.smethod_144(int_0, class11_0, class18_0);
                num1 = class11_0.int_15;
                num2 = num1 < class11_0.int_14 ? class11_0.int_14 - num1 - 1 : class11_0.int_13 - num1;
                if ((num1 != class11_0.int_13 ? 0 : ((uint) class11_0.int_14 > 0U ? 1 : 0)) != 0)
                {
                  num1 = 0;
                  num2 = 0 < class11_0.int_14 ? class11_0.int_14 - num1 - 1 : class11_0.int_13 - num1;
                }
                *(sbyte*) ((IntPtr) voidPtr + 67) = (sbyte) (num2 == 0);
                if (*(sbyte*) ((IntPtr) voidPtr + 67) != (sbyte) 0)
                  goto label_67;
              }
            }
            int_0 = 0;
            class11_0.byte_0[num1++] = (byte) class12_0.int_6;
            --num2;
            class12_0.int_1 = 0;
            continue;
          case 7:
            goto label_68;
          case 8:
            goto label_73;
          case 9:
            goto label_74;
          default:
            goto label_59;
        }
      }
label_59:
      int_0 = -2;
      class11_0.int_11 = int_1;
      class11_0.int_10 = *(int*) ((IntPtr) voidPtr + 12);
      class18_0.int_2 = *(int*) ((IntPtr) voidPtr + 16);
      class18_0.long_0 += (long) (int1 - class18_0.int_1);
      class18_0.int_1 = int1;
      class11_0.int_15 = num1;
      *(int*) ((IntPtr) voidPtr + 24) = Class73.smethod_144(-2, class11_0, class18_0);
      goto label_75;
label_60:
      class12_0.int_1 = 9;
      class18_0.string_0 = "invalid literal/length code";
      int_0 = -3;
      class11_0.int_11 = int_1;
      class11_0.int_10 = *(int*) ((IntPtr) voidPtr + 12);
      class18_0.int_2 = *(int*) ((IntPtr) voidPtr + 16);
      class18_0.long_0 += (long) (int1 - class18_0.int_1);
      class18_0.int_1 = int1;
      class11_0.int_15 = num1;
      *(int*) ((IntPtr) voidPtr + 24) = Class73.smethod_144(-3, class11_0, class18_0);
      goto label_75;
label_61:
      class11_0.int_11 = int_1;
      class11_0.int_10 = *(int*) ((IntPtr) voidPtr + 12);
      class18_0.int_2 = *(int*) ((IntPtr) voidPtr + 16);
      class18_0.long_0 += (long) (int1 - class18_0.int_1);
      class18_0.int_1 = int1;
      class11_0.int_15 = num1;
      *(int*) ((IntPtr) voidPtr + 24) = Class73.smethod_144(int_0, class11_0, class18_0);
      goto label_75;
label_62:
      class11_0.int_11 = int_1;
      class11_0.int_10 = *(int*) ((IntPtr) voidPtr + 12);
      class18_0.int_2 = *(int*) ((IntPtr) voidPtr + 16);
      class18_0.long_0 += (long) (int1 - class18_0.int_1);
      class18_0.int_1 = int1;
      class11_0.int_15 = num1;
      *(int*) ((IntPtr) voidPtr + 24) = Class73.smethod_144(int_0, class11_0, class18_0);
      goto label_75;
label_63:
      class12_0.int_1 = 9;
      class18_0.string_0 = "invalid distance code";
      int_0 = -3;
      class11_0.int_11 = int_1;
      class11_0.int_10 = *(int*) ((IntPtr) voidPtr + 12);
      class18_0.int_2 = *(int*) ((IntPtr) voidPtr + 16);
      class18_0.long_0 += (long) (int1 - class18_0.int_1);
      class18_0.int_1 = int1;
      class11_0.int_15 = num1;
      *(int*) ((IntPtr) voidPtr + 24) = Class73.smethod_144(-3, class11_0, class18_0);
      goto label_75;
label_64:
      class11_0.int_11 = int_1;
      class11_0.int_10 = *(int*) ((IntPtr) voidPtr + 12);
      class18_0.int_2 = *(int*) ((IntPtr) voidPtr + 16);
      class18_0.long_0 += (long) (int1 - class18_0.int_1);
      class18_0.int_1 = int1;
      class11_0.int_15 = num1;
      *(int*) ((IntPtr) voidPtr + 24) = Class73.smethod_144(int_0, class11_0, class18_0);
      goto label_75;
label_65:
      class11_0.int_11 = int_1;
      class11_0.int_10 = *(int*) ((IntPtr) voidPtr + 12);
      class18_0.int_2 = *(int*) ((IntPtr) voidPtr + 16);
      class18_0.long_0 += (long) (int1 - class18_0.int_1);
      class18_0.int_1 = int1;
      class11_0.int_15 = num1;
      *(int*) ((IntPtr) voidPtr + 24) = Class73.smethod_144(int_0, class11_0, class18_0);
      goto label_75;
label_66:
      class11_0.int_11 = int_1;
      class11_0.int_10 = *(int*) ((IntPtr) voidPtr + 12);
      class18_0.int_2 = *(int*) ((IntPtr) voidPtr + 16);
      class18_0.long_0 += (long) (int1 - class18_0.int_1);
      class18_0.int_1 = int1;
      class11_0.int_15 = num1;
      *(int*) ((IntPtr) voidPtr + 24) = Class73.smethod_144(int_0, class11_0, class18_0);
      goto label_75;
label_67:
      class11_0.int_11 = int_1;
      class11_0.int_10 = *(int*) ((IntPtr) voidPtr + 12);
      class18_0.int_2 = *(int*) ((IntPtr) voidPtr + 16);
      class18_0.long_0 += (long) (int1 - class18_0.int_1);
      class18_0.int_1 = int1;
      class11_0.int_15 = num1;
      *(int*) ((IntPtr) voidPtr + 24) = Class73.smethod_144(int_0, class11_0, class18_0);
      goto label_75;
label_68:
      *(sbyte*) ((IntPtr) voidPtr + 68) = (sbyte) (*(int*) ((IntPtr) voidPtr + 12) > 7);
      if (*(sbyte*) ((IntPtr) voidPtr + 68) != (sbyte) 0)
      {
        *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) - 8;
        *(int*) ((IntPtr) voidPtr + 16) = *(int*) ((IntPtr) voidPtr + 16) + 1;
        --int1;
      }
      class11_0.int_15 = num1;
      int_0 = Class73.smethod_144(int_0, class11_0, class18_0);
      num1 = class11_0.int_15;
      int num4 = num1 < class11_0.int_14 ? class11_0.int_14 - num1 - 1 : class11_0.int_13 - num1;
      *(sbyte*) ((IntPtr) voidPtr + 69) = (sbyte) (class11_0.int_14 != class11_0.int_15);
      if (*(sbyte*) ((IntPtr) voidPtr + 69) != (sbyte) 0)
      {
        class11_0.int_11 = int_1;
        class11_0.int_10 = *(int*) ((IntPtr) voidPtr + 12);
        class18_0.int_2 = *(int*) ((IntPtr) voidPtr + 16);
        class18_0.long_0 += (long) (int1 - class18_0.int_1);
        class18_0.int_1 = int1;
        class11_0.int_15 = num1;
        *(int*) ((IntPtr) voidPtr + 24) = Class73.smethod_144(int_0, class11_0, class18_0);
        goto label_75;
      }
      else
        class12_0.int_1 = 8;
label_73:
      int_0 = 1;
      class11_0.int_11 = int_1;
      class11_0.int_10 = *(int*) ((IntPtr) voidPtr + 12);
      class18_0.int_2 = *(int*) ((IntPtr) voidPtr + 16);
      class18_0.long_0 += (long) (int1 - class18_0.int_1);
      class18_0.int_1 = int1;
      class11_0.int_15 = num1;
      *(int*) ((IntPtr) voidPtr + 24) = Class73.smethod_144(1, class11_0, class18_0);
      goto label_75;
label_74:
      int_0 = -3;
      class11_0.int_11 = int_1;
      class11_0.int_10 = *(int*) ((IntPtr) voidPtr + 12);
      class18_0.int_2 = *(int*) ((IntPtr) voidPtr + 16);
      class18_0.long_0 += (long) (int1 - class18_0.int_1);
      class18_0.int_1 = int1;
      class11_0.int_15 = num1;
      *(int*) ((IntPtr) voidPtr + 24) = Class73.smethod_144(-3, class11_0, class18_0);
label_75:
      return *(int*) ((IntPtr) voidPtr + 24);
    }

    static ICryptoTransform smethod_13(byte[] byte_0, bool bool_0, byte[] byte_1)
    {
      using (DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider())
        return bool_0 ? cryptoServiceProvider.CreateDecryptor(byte_1, byte_0) : cryptoServiceProvider.CreateEncryptor(byte_1, byte_0);
    }

    static unsafe uint smethod_14(ref uint uint_0, Class4 class4_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(9);
      *(int*) voidPtr = 0;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) (*(int*) voidPtr < 32);
        if (*(sbyte*) ((IntPtr) voidPtr + 8) != (sbyte) 0)
        {
          uint_0 = (uint) (((int) (((((uint_0 >> 2 ^ uint_0) >> 2 ^ uint_0) >> 1 ^ uint_0) >> 1 ^ uint_0) >> 1) ^ (int) uint_0) & 1 | (((int) uint_0 & 1) << 31 | (int) (uint_0 >> 1)) & -2);
          *(int*) voidPtr = *(int*) voidPtr + 1;
        }
        else
          break;
      }
      *(int*) ((IntPtr) voidPtr + 4) = (int) uint_0;
      return *(uint*) ((IntPtr) voidPtr + 4);
    }

    static unsafe void smethod_15(Class2 class2_0, bool bool_0, ushort ushort_0, Class4 class4_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(58);
      *(sbyte*) ((IntPtr) voidPtr + 36) = (sbyte) bool_0;
      if (*(sbyte*) ((IntPtr) voidPtr + 36) != (sbyte) 0)
        throw new Exception("[SecurityAPI::Handshake] Received an illogical (encrypted) handshake packet.");
      *(sbyte*) ((IntPtr) voidPtr + 37) = (sbyte) class4_0.bool_0;
      if (*(sbyte*) ((IntPtr) voidPtr + 37) != (sbyte) 0)
      {
        *(sbyte*) ((IntPtr) voidPtr + 39) = (sbyte) (class4_0.class5_0.byte_3 == (byte) 0);
        if (*(sbyte*) ((IntPtr) voidPtr + 39) != (sbyte) 0)
        {
          *(sbyte*) ((IntPtr) voidPtr + 40) = (sbyte) (ushort_0 == (ushort) 36864);
          if (*(sbyte*) ((IntPtr) voidPtr + 40) != (sbyte) 0)
          {
            *(sbyte*) ((IntPtr) voidPtr + 41) = (sbyte) class4_0.bool_1;
            if (*(sbyte*) ((IntPtr) voidPtr + 41) != (sbyte) 0)
              throw new Exception("[SecurityAPI::Handshake] Received an illogical handshake packet (duplicate 0x9000).");
            class4_0.bool_1 = true;
          }
          else
          {
            *(sbyte*) ((IntPtr) voidPtr + 42) = (sbyte) (ushort_0 == (ushort) 20480);
            if (*(sbyte*) ((IntPtr) voidPtr + 42) != (sbyte) 0)
              throw new Exception("[SecurityAPI::Handshake] Received an illogical handshake packet (0x5000 with no handshake).");
            throw new Exception("[SecurityAPI::Handshake] Received an illogical handshake packet (programmer error).");
          }
        }
        else
        {
          *(sbyte*) ((IntPtr) voidPtr + 43) = (sbyte) (ushort_0 == (ushort) 36864);
          if (*(sbyte*) ((IntPtr) voidPtr + 43) != (sbyte) 0)
          {
            *(sbyte*) ((IntPtr) voidPtr + 44) = (sbyte) !class4_0.bool_2;
            if (*(sbyte*) ((IntPtr) voidPtr + 44) != (sbyte) 0)
              throw new Exception("[SecurityAPI::Handshake] Received an illogical handshake packet (out of order 0x9000).");
            *(sbyte*) ((IntPtr) voidPtr + 45) = (sbyte) class4_0.bool_1;
            if (*(sbyte*) ((IntPtr) voidPtr + 45) != (sbyte) 0)
              throw new Exception("[SecurityAPI::Handshake] Received an illogical handshake packet (duplicate 0x9000).");
            class4_0.bool_1 = true;
          }
          else
          {
            *(sbyte*) ((IntPtr) voidPtr + 46) = (sbyte) (ushort_0 == (ushort) 20480);
            if (*(sbyte*) ((IntPtr) voidPtr + 46) == (sbyte) 0)
              throw new Exception("[SecurityAPI::Handshake] Received an illogical handshake packet (programmer error).");
            *(sbyte*) ((IntPtr) voidPtr + 47) = (sbyte) class4_0.bool_2;
            if (*(sbyte*) ((IntPtr) voidPtr + 47) != (sbyte) 0)
              throw new Exception("[SecurityAPI::Handshake] Received an illogical handshake packet (duplicate 0x5000).");
            class4_0.bool_2 = true;
            *(long*) voidPtr = 0L;
            class4_0.uint_5 = class2_0.ReadUInt32();
            class4_0.ulong_2 = class2_0.ReadUInt64();
            Class4 class4 = class4_0;
            *(int*) ((IntPtr) voidPtr + 24) = (int) class4_0.uint_3;
            *(int*) ((IntPtr) voidPtr + 28) = (int) class4_0.uint_1;
            *(int*) ((IntPtr) voidPtr + 32) = (int) class4_0.uint_5;
            int num = (int) Class73.smethod_75(*(uint*) ((IntPtr) voidPtr + 32), *(uint*) ((IntPtr) voidPtr + 24), class4_0, *(uint*) ((IntPtr) voidPtr + 28));
            class4.uint_6 = (uint) num;
            *(long*) voidPtr = (long) Class73.smethod_157(class4_0.uint_4, class4_0.uint_5);
            Class73.smethod_185(class4_0, ref *(ulong*) voidPtr, class4_0.uint_6, (byte) ((uint) Class73.smethod_51(Class73.smethod_209(class4_0.uint_6)) & 3U));
            Class0 class00_1 = class4_0.class0_0;
            Class73.smethod_41(BitConverter.GetBytes((ulong) *(long*) voidPtr), class00_1);
            byte[] numArray1 = Class73.smethod_135(class4_0.class0_0, BitConverter.GetBytes(class4_0.ulong_2));
            class4_0.ulong_2 = BitConverter.ToUInt64(numArray1, 0);
            *(long*) voidPtr = (long) Class73.smethod_157(class4_0.uint_5, class4_0.uint_4);
            Class73.smethod_185(class4_0, ref *(ulong*) voidPtr, class4_0.uint_6, (byte) ((uint) Class73.smethod_51(Class73.smethod_209(class4_0.uint_5)) & 7U));
            *(sbyte*) ((IntPtr) voidPtr + 48) = (sbyte) ((long) class4_0.ulong_2 != *(long*) voidPtr);
            if (*(sbyte*) ((IntPtr) voidPtr + 48) != (sbyte) 0)
              throw new Exception("[SecurityAPI::Handshake] Client signature error.");
            *(long*) voidPtr = (long) Class73.smethod_157(class4_0.uint_4, class4_0.uint_5);
            Class73.smethod_185(class4_0, ref *(ulong*) voidPtr, class4_0.uint_6, (byte) ((uint) Class73.smethod_51(Class73.smethod_209(class4_0.uint_6)) & 3U));
            Class0 class00_2 = class4_0.class0_0;
            Class73.smethod_41(BitConverter.GetBytes((ulong) *(long*) voidPtr), class00_2);
            class4_0.ulong_3 = Class73.smethod_157(class4_0.uint_4, class4_0.uint_5);
            Class73.smethod_185(class4_0, ref class4_0.ulong_3, class4_0.uint_6, (byte) ((uint) Class73.smethod_51(Class73.smethod_209(class4_0.uint_4)) & 7U));
            byte[] numArray2 = Class73.smethod_228(class4_0.class0_0, BitConverter.GetBytes(class4_0.ulong_3));
            class4_0.ulong_3 = BitConverter.ToUInt64(numArray2, 0);
            Class73.smethod_185(class4_0, ref class4_0.ulong_1, class4_0.uint_6, (byte) 3);
            Class0 class00_3 = class4_0.class0_0;
            Class73.smethod_41(BitConverter.GetBytes(class4_0.ulong_1), class00_3);
            *(sbyte*) ((IntPtr) voidPtr + 38) = (sbyte) Class73.smethod_55(new Class4.Class5()
            {
              byte_4 = (byte) 1
            });
            Class1 class1_0 = new Class1((ushort) 20480);
            Class73.smethod_162(*(byte*) ((IntPtr) voidPtr + 38), class1_0);
            Class73.smethod_160(class4_0.ulong_3, class1_0);
            class4_0.list_1.Add(class1_0);
          }
        }
      }
      else
      {
        *(sbyte*) ((IntPtr) voidPtr + 50) = (sbyte) (ushort_0 != (ushort) 20480);
        if (*(sbyte*) ((IntPtr) voidPtr + 50) != (sbyte) 0)
          throw new Exception("[SecurityAPI::Handshake] Received an illogical handshake packet (programmer error).");
        *(sbyte*) ((IntPtr) voidPtr + 49) = (sbyte) class2_0.ReadByte();
        Class4.Class5 class5 = Class73.smethod_248(*(byte*) ((IntPtr) voidPtr + 49));
        *(sbyte*) ((IntPtr) voidPtr + 51) = (sbyte) (class4_0.byte_1 == (byte) 0);
        if (*(sbyte*) ((IntPtr) voidPtr + 51) != (sbyte) 0)
        {
          class4_0.byte_1 = *(byte*) ((IntPtr) voidPtr + 49);
          class4_0.class5_0 = class5;
        }
        *(sbyte*) ((IntPtr) voidPtr + 52) = (sbyte) (class5.byte_1 == (byte) 1);
        if (*(sbyte*) ((IntPtr) voidPtr + 52) != (sbyte) 0)
        {
          class4_0.ulong_0 = class2_0.ReadUInt64();
          Class0 class00 = class4_0.class0_0;
          Class73.smethod_41(BitConverter.GetBytes(class4_0.ulong_0), class00);
        }
        *(sbyte*) ((IntPtr) voidPtr + 53) = (sbyte) (class5.byte_2 == (byte) 1);
        if (*(sbyte*) ((IntPtr) voidPtr + 53) != (sbyte) 0)
        {
          class4_0.uint_7 = class2_0.ReadUInt32();
          class4_0.uint_8 = class2_0.ReadUInt32();
          Class73.smethod_37(class4_0.uint_7, class4_0);
        }
        *(sbyte*) ((IntPtr) voidPtr + 54) = (sbyte) (class5.byte_3 == (byte) 1);
        if (*(sbyte*) ((IntPtr) voidPtr + 54) != (sbyte) 0)
        {
          class4_0.ulong_1 = class2_0.ReadUInt64();
          class4_0.uint_2 = class2_0.ReadUInt32();
          class4_0.uint_3 = class2_0.ReadUInt32();
          class4_0.uint_4 = class2_0.ReadUInt32();
          class4_0.uint_1 = Class73.smethod_235() & (uint) int.MaxValue;
          Class4 class4_1 = class4_0;
          *(int*) ((IntPtr) voidPtr + 24) = (int) class4_0.uint_3;
          *(int*) ((IntPtr) voidPtr + 28) = (int) class4_0.uint_1;
          *(int*) ((IntPtr) voidPtr + 32) = (int) class4_0.uint_2;
          int num1 = (int) Class73.smethod_75(*(uint*) ((IntPtr) voidPtr + 32), *(uint*) ((IntPtr) voidPtr + 24), class4_0, *(uint*) ((IntPtr) voidPtr + 28));
          class4_1.uint_5 = (uint) num1;
          Class4 class4_2 = class4_0;
          *(int*) ((IntPtr) voidPtr + 24) = (int) class4_0.uint_3;
          *(int*) ((IntPtr) voidPtr + 28) = (int) class4_0.uint_1;
          *(int*) ((IntPtr) voidPtr + 32) = (int) class4_0.uint_4;
          int num2 = (int) Class73.smethod_75(*(uint*) ((IntPtr) voidPtr + 32), *(uint*) ((IntPtr) voidPtr + 24), class4_0, *(uint*) ((IntPtr) voidPtr + 28));
          class4_2.uint_6 = (uint) num2;
          *(long*) ((IntPtr) voidPtr + 8) = (long) Class73.smethod_157(class4_0.uint_4, class4_0.uint_5);
          // ISSUE: cast to a reference type
          Class73.smethod_185(class4_0, (ulong&) ((IntPtr) voidPtr + 8), class4_0.uint_6, (byte) ((uint) Class73.smethod_51(Class73.smethod_209(class4_0.uint_6)) & 3U));
          Class0 class00 = class4_0.class0_0;
          Class73.smethod_41(BitConverter.GetBytes((ulong) *(long*) ((IntPtr) voidPtr + 8)), class00);
          class4_0.ulong_2 = Class73.smethod_157(class4_0.uint_5, class4_0.uint_4);
          Class73.smethod_185(class4_0, ref class4_0.ulong_2, class4_0.uint_6, (byte) ((uint) Class73.smethod_51(Class73.smethod_209(class4_0.uint_5)) & 7U));
          byte[] numArray = Class73.smethod_228(class4_0.class0_0, BitConverter.GetBytes(class4_0.ulong_2));
          class4_0.ulong_2 = BitConverter.ToUInt64(numArray, 0);
        }
        *(sbyte*) ((IntPtr) voidPtr + 55) = (sbyte) (class5.byte_4 == (byte) 1);
        if (*(sbyte*) ((IntPtr) voidPtr + 55) != (sbyte) 0)
        {
          class4_0.ulong_3 = class2_0.ReadUInt64();
          *(long*) ((IntPtr) voidPtr + 16) = (long) Class73.smethod_157(class4_0.uint_4, class4_0.uint_5);
          // ISSUE: cast to a reference type
          Class73.smethod_185(class4_0, (ulong&) ((IntPtr) voidPtr + 16), class4_0.uint_6, (byte) ((uint) Class73.smethod_51(Class73.smethod_209(class4_0.uint_4)) & 7U));
          byte[] numArray = Class73.smethod_228(class4_0.class0_0, BitConverter.GetBytes((ulong) *(long*) ((IntPtr) voidPtr + 16)));
          *(long*) ((IntPtr) voidPtr + 16) = (long) BitConverter.ToUInt64(numArray, 0);
          *(sbyte*) ((IntPtr) voidPtr + 56) = (sbyte) ((long) class4_0.ulong_3 != *(long*) ((IntPtr) voidPtr + 16));
          if (*(sbyte*) ((IntPtr) voidPtr + 56) != (sbyte) 0)
            throw new Exception("[SecurityAPI::Handshake] Server signature error.");
          Class73.smethod_185(class4_0, ref class4_0.ulong_1, class4_0.uint_6, (byte) 3);
          Class0 class00 = class4_0.class0_0;
          Class73.smethod_41(BitConverter.GetBytes(class4_0.ulong_1), class00);
        }
        if ((class5.byte_3 != (byte) 1 ? 0 : (class5.byte_4 == (byte) 0 ? 1 : 0)) != 0)
        {
          if ((class4_0.bool_2 ? 1 : (class4_0.bool_1 ? 1 : 0)) != 0)
            throw new Exception("[SecurityAPI::Handshake] Received an illogical handshake packet (duplicate 0x5000).");
          Class1 class1_0 = new Class1((ushort) 20480);
          Class73.smethod_9(class1_0, class4_0.uint_5);
          Class73.smethod_160(class4_0.ulong_2, class1_0);
          class4_0.list_1.Insert(0, class1_0);
          class4_0.bool_2 = true;
        }
        else
        {
          *(sbyte*) ((IntPtr) voidPtr + 57) = (sbyte) class4_0.bool_1;
          if (*(sbyte*) ((IntPtr) voidPtr + 57) != (sbyte) 0)
            throw new Exception("[SecurityAPI::Handshake] Received an illogical handshake packet (duplicate 0x5000).");
          Class1 class1 = new Class1((ushort) 36864);
          Class1 class1_0 = new Class1((ushort) 8193, true, false);
          Class73.smethod_120(class1_0, class4_0.string_0);
          Class73.smethod_162(class4_0.byte_2, class1_0);
          class4_0.list_1.Insert(0, class1_0);
          class4_0.list_1.Insert(0, class1);
          class4_0.bool_2 = true;
          class4_0.bool_1 = true;
        }
      }
    }

    static unsafe byte smethod_16(Class1 class1_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(3);
      object object0 = class1_0.object_0;
      *(sbyte*) voidPtr = (sbyte) 0;
      try
      {
        Monitor.Enter(object0, ref *(bool*) voidPtr);
        *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) !class1_0.bool_2;
        if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
          throw new Exception("Cannot Read from an unlocked Packet.");
        *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) class1_0.class2_0.ReadByte();
      }
      finally
      {
        if (*(sbyte*) voidPtr != (sbyte) 0)
          Monitor.Exit(object0);
      }
      return *(byte*) ((IntPtr) voidPtr + 2);
    }

    static unsafe int smethod_17(Class13 class13_0, Class18 class18_0, int int_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(32);
      if ((class18_0 == null || class18_0.class13_0 == null ? 1 : (class18_0.byte_0 == null ? 1 : 0)) != 0)
      {
        *(int*) ((IntPtr) voidPtr + 4) = -2;
      }
      else
      {
        int_0 = int_0 == 4 ? -5 : 0;
        *(int*) voidPtr = -5;
        while (true)
        {
          *(sbyte*) ((IntPtr) voidPtr + 31) = (sbyte) 1;
          *(int*) ((IntPtr) voidPtr + 8) = class18_0.class13_0.int_0;
          switch (*(int*) ((IntPtr) voidPtr + 8))
          {
            case 0:
              *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) (class18_0.int_2 == 0);
              if (*(sbyte*) ((IntPtr) voidPtr + 12) == (sbyte) 0)
              {
                *(int*) voidPtr = int_0;
                --class18_0.int_2;
                ++class18_0.long_0;
                Class13 class130 = class18_0.class13_0;
                byte[] byte0 = class18_0.byte_0;
                int index = class18_0.int_1++;
                int num1;
                int num2 = num1 = (int) byte0[index];
                class130.int_1 = num1;
                *(sbyte*) ((IntPtr) voidPtr + 13) = (sbyte) ((num2 & 15) != 8);
                if (*(sbyte*) ((IntPtr) voidPtr + 13) != (sbyte) 0)
                {
                  class18_0.class13_0.int_0 = 13;
                  class18_0.string_0 = "unknown compression method";
                  class18_0.class13_0.int_2 = 5;
                  continue;
                }
                *(sbyte*) ((IntPtr) voidPtr + 14) = (sbyte) ((class18_0.class13_0.int_1 >> 4) + 8 > class18_0.class13_0.int_4);
                if (*(sbyte*) ((IntPtr) voidPtr + 14) != (sbyte) 0)
                {
                  class18_0.class13_0.int_0 = 13;
                  class18_0.string_0 = "invalid window size";
                  class18_0.class13_0.int_2 = 5;
                  continue;
                }
                class18_0.class13_0.int_0 = 1;
                goto case 1;
              }
              else
                goto label_33;
            case 1:
              *(sbyte*) ((IntPtr) voidPtr + 15) = (sbyte) (class18_0.int_2 == 0);
              if (*(sbyte*) ((IntPtr) voidPtr + 15) == (sbyte) 0)
              {
                *(int*) voidPtr = int_0;
                --class18_0.int_2;
                ++class18_0.long_0;
                int num = (int) class18_0.byte_0[class18_0.int_1++] & (int) byte.MaxValue;
                *(sbyte*) ((IntPtr) voidPtr + 16) = (sbyte) ((uint) (((class18_0.class13_0.int_1 << 8) + num) % 31) > 0U);
                if (*(sbyte*) ((IntPtr) voidPtr + 16) != (sbyte) 0)
                {
                  class18_0.class13_0.int_0 = 13;
                  class18_0.string_0 = "incorrect header check";
                  class18_0.class13_0.int_2 = 5;
                  continue;
                }
                *(sbyte*) ((IntPtr) voidPtr + 17) = (sbyte) ((num & 32) == 0);
                if (*(sbyte*) ((IntPtr) voidPtr + 17) != (sbyte) 0)
                {
                  class18_0.class13_0.int_0 = 7;
                  continue;
                }
                goto label_35;
              }
              else
                goto label_34;
            case 2:
              goto label_36;
            case 3:
              goto label_39;
            case 4:
              goto label_42;
            case 5:
              goto label_45;
            case 6:
              goto label_48;
            case 7:
              *(int*) voidPtr = Class73.smethod_182(class18_0.class13_0.class11_0, class18_0, *(int*) voidPtr);
              *(sbyte*) ((IntPtr) voidPtr + 22) = (sbyte) (*(int*) voidPtr == -3);
              if (*(sbyte*) ((IntPtr) voidPtr + 22) != (sbyte) 0)
              {
                class18_0.class13_0.int_0 = 13;
                class18_0.class13_0.int_2 = 0;
                continue;
              }
              *(sbyte*) ((IntPtr) voidPtr + 23) = (sbyte) (*(int*) voidPtr == 0);
              if (*(sbyte*) ((IntPtr) voidPtr + 23) != (sbyte) 0)
                *(int*) voidPtr = int_0;
              *(sbyte*) ((IntPtr) voidPtr + 24) = (sbyte) (*(int*) voidPtr != 1);
              if (*(sbyte*) ((IntPtr) voidPtr + 24) == (sbyte) 0)
              {
                *(int*) voidPtr = int_0;
                Class11 class110 = class18_0.class13_0.class11_0;
                long[] long0 = class18_0.class13_0.long_0;
                Class73.smethod_227(class18_0, long0, class110);
                *(sbyte*) ((IntPtr) voidPtr + 25) = (sbyte) ((uint) class18_0.class13_0.int_3 > 0U);
                if (*(sbyte*) ((IntPtr) voidPtr + 25) != (sbyte) 0)
                {
                  class18_0.class13_0.int_0 = 12;
                  continue;
                }
                class18_0.class13_0.int_0 = 8;
                goto case 8;
              }
              else
                goto label_49;
            case 8:
              *(sbyte*) ((IntPtr) voidPtr + 26) = (sbyte) (class18_0.int_2 == 0);
              if (*(sbyte*) ((IntPtr) voidPtr + 26) == (sbyte) 0)
              {
                *(int*) voidPtr = int_0;
                --class18_0.int_2;
                ++class18_0.long_0;
                class18_0.class13_0.long_1 = (long) (((int) class18_0.byte_0[class18_0.int_1++] & (int) byte.MaxValue) << 24 & -16777216);
                class18_0.class13_0.int_0 = 9;
                goto case 9;
              }
              else
                goto label_50;
            case 9:
              *(sbyte*) ((IntPtr) voidPtr + 27) = (sbyte) (class18_0.int_2 == 0);
              if (*(sbyte*) ((IntPtr) voidPtr + 27) == (sbyte) 0)
              {
                *(int*) voidPtr = int_0;
                --class18_0.int_2;
                ++class18_0.long_0;
                class18_0.class13_0.long_1 += (long) (((int) class18_0.byte_0[class18_0.int_1++] & (int) byte.MaxValue) << 16) & 16711680L;
                class18_0.class13_0.int_0 = 10;
                goto case 10;
              }
              else
                goto label_51;
            case 10:
              *(sbyte*) ((IntPtr) voidPtr + 28) = (sbyte) (class18_0.int_2 == 0);
              if (*(sbyte*) ((IntPtr) voidPtr + 28) == (sbyte) 0)
              {
                *(int*) voidPtr = int_0;
                --class18_0.int_2;
                ++class18_0.long_0;
                class18_0.class13_0.long_1 += (long) (((int) class18_0.byte_0[class18_0.int_1++] & (int) byte.MaxValue) << 8) & 65280L;
                class18_0.class13_0.int_0 = 11;
                goto case 11;
              }
              else
                goto label_52;
            case 11:
              *(sbyte*) ((IntPtr) voidPtr + 29) = (sbyte) (class18_0.int_2 == 0);
              if (*(sbyte*) ((IntPtr) voidPtr + 29) == (sbyte) 0)
              {
                *(int*) voidPtr = int_0;
                --class18_0.int_2;
                ++class18_0.long_0;
                class18_0.class13_0.long_1 += (long) class18_0.byte_0[class18_0.int_1++] & (long) byte.MaxValue;
                *(sbyte*) ((IntPtr) voidPtr + 30) = (sbyte) ((int) class18_0.class13_0.long_0[0] != (int) class18_0.class13_0.long_1);
                if (*(sbyte*) ((IntPtr) voidPtr + 30) != (sbyte) 0)
                {
                  class18_0.class13_0.int_0 = 13;
                  class18_0.string_0 = "incorrect data check";
                  class18_0.class13_0.int_2 = 5;
                  continue;
                }
                goto label_54;
              }
              else
                goto label_53;
            case 12:
              goto label_55;
            case 13:
              goto label_56;
            default:
              goto label_32;
          }
        }
label_32:
        *(int*) ((IntPtr) voidPtr + 4) = -2;
        goto label_57;
label_33:
        *(int*) ((IntPtr) voidPtr + 4) = *(int*) voidPtr;
        goto label_57;
label_34:
        *(int*) ((IntPtr) voidPtr + 4) = *(int*) voidPtr;
        goto label_57;
label_35:
        class18_0.class13_0.int_0 = 2;
label_36:
        *(sbyte*) ((IntPtr) voidPtr + 18) = (sbyte) (class18_0.int_2 == 0);
        if (*(sbyte*) ((IntPtr) voidPtr + 18) != (sbyte) 0)
        {
          *(int*) ((IntPtr) voidPtr + 4) = *(int*) voidPtr;
          goto label_57;
        }
        else
        {
          *(int*) voidPtr = int_0;
          --class18_0.int_2;
          ++class18_0.long_0;
          class18_0.class13_0.long_1 = (long) (((int) class18_0.byte_0[class18_0.int_1++] & (int) byte.MaxValue) << 24 & -16777216);
          class18_0.class13_0.int_0 = 3;
        }
label_39:
        *(sbyte*) ((IntPtr) voidPtr + 19) = (sbyte) (class18_0.int_2 == 0);
        if (*(sbyte*) ((IntPtr) voidPtr + 19) != (sbyte) 0)
        {
          *(int*) ((IntPtr) voidPtr + 4) = *(int*) voidPtr;
          goto label_57;
        }
        else
        {
          *(int*) voidPtr = int_0;
          --class18_0.int_2;
          ++class18_0.long_0;
          class18_0.class13_0.long_1 += (long) (((int) class18_0.byte_0[class18_0.int_1++] & (int) byte.MaxValue) << 16) & 16711680L;
          class18_0.class13_0.int_0 = 4;
        }
label_42:
        *(sbyte*) ((IntPtr) voidPtr + 20) = (sbyte) (class18_0.int_2 == 0);
        if (*(sbyte*) ((IntPtr) voidPtr + 20) != (sbyte) 0)
        {
          *(int*) ((IntPtr) voidPtr + 4) = *(int*) voidPtr;
          goto label_57;
        }
        else
        {
          *(int*) voidPtr = int_0;
          --class18_0.int_2;
          ++class18_0.long_0;
          class18_0.class13_0.long_1 += (long) (((int) class18_0.byte_0[class18_0.int_1++] & (int) byte.MaxValue) << 8) & 65280L;
          class18_0.class13_0.int_0 = 5;
        }
label_45:
        *(sbyte*) ((IntPtr) voidPtr + 21) = (sbyte) (class18_0.int_2 == 0);
        if (*(sbyte*) ((IntPtr) voidPtr + 21) != (sbyte) 0)
        {
          *(int*) ((IntPtr) voidPtr + 4) = *(int*) voidPtr;
          goto label_57;
        }
        else
        {
          *(int*) voidPtr = int_0;
          --class18_0.int_2;
          ++class18_0.long_0;
          class18_0.class13_0.long_1 += (long) class18_0.byte_0[class18_0.int_1++] & (long) byte.MaxValue;
          class18_0.long_2 = class18_0.class13_0.long_1;
          class18_0.class13_0.int_0 = 6;
          *(int*) ((IntPtr) voidPtr + 4) = 2;
          goto label_57;
        }
label_48:
        class18_0.class13_0.int_0 = 13;
        class18_0.string_0 = "need dictionary";
        class18_0.class13_0.int_2 = 0;
        *(int*) ((IntPtr) voidPtr + 4) = -2;
        goto label_57;
label_49:
        *(int*) ((IntPtr) voidPtr + 4) = *(int*) voidPtr;
        goto label_57;
label_50:
        *(int*) ((IntPtr) voidPtr + 4) = *(int*) voidPtr;
        goto label_57;
label_51:
        *(int*) ((IntPtr) voidPtr + 4) = *(int*) voidPtr;
        goto label_57;
label_52:
        *(int*) ((IntPtr) voidPtr + 4) = *(int*) voidPtr;
        goto label_57;
label_53:
        *(int*) ((IntPtr) voidPtr + 4) = *(int*) voidPtr;
        goto label_57;
label_54:
        class18_0.class13_0.int_0 = 12;
label_55:
        *(int*) ((IntPtr) voidPtr + 4) = 1;
        goto label_57;
label_56:
        *(int*) ((IntPtr) voidPtr + 4) = -3;
      }
label_57:
      return *(int*) ((IntPtr) voidPtr + 4);
    }

    static void smethod_18(string string_0)
    {
      Form1.smethod_0(string_0);
    }

    static void smethod_19(Class18 class18_0)
    {
      class18_0.byte_0 = (byte[]) null;
      class18_0.byte_1 = (byte[]) null;
      class18_0.string_0 = (string) null;
      class18_0.class8_0 = (Class8) null;
    }

    static int smethod_20(Class9 class9_0)
    {
      int num;
      if ((class9_0.int_3 == 42 || class9_0.int_3 == 113 ? 0 : (class9_0.int_3 != 666 ? 1 : 0)) != 0)
      {
        num = -2;
      }
      else
      {
        class9_0.byte_0 = (byte[]) null;
        class9_0.short_1 = (short[]) null;
        class9_0.short_0 = (short[]) null;
        class9_0.byte_2 = (byte[]) null;
        num = class9_0.int_3 == 113 ? -3 : 0;
      }
      return num;
    }

    static void smethod_21(int int_0, Class19 class19_0, int int_1)
    {
      try
      {
        Class1 class1_0 = new Class1((ushort) 28688);
        Class73.smethod_65((ushort) 6, class1_0);
        Class73.smethod_198(class1_0, (object) int_1);
        Class73.smethod_173((object) int_0, class1_0);
        Class73.smethod_162((byte) 3, class1_0);
        class19_0.method_1(class1_0);
      }
      catch (Exception ex)
      {
        Class73.smethod_18("Uniq Spawn Başarısız. UniqID ==> " + (object) int_1 + " Adet ==> " + (object) int_0);
        Class73.smethod_18("Hata acıklaması => " + ex.Message);
      }
    }

    static unsafe byte[] smethod_22(int int_0, int int_1, Class0 class0_0, byte[] byte_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(19);
      *(sbyte*) ((IntPtr) voidPtr + 16) = (sbyte) (int_0 == 0);
      byte[] numArray1;
      if (*(sbyte*) ((IntPtr) voidPtr + 16) != (sbyte) 0)
      {
        numArray1 = (byte[]) null;
      }
      else
      {
        byte[] numArray2 = new byte[Class73.smethod_103(class0_0, int_0)];
        Buffer.BlockCopy((Array) byte_0, int_1, (Array) numArray2, 0, int_0);
        *(int*) voidPtr = int_0;
        while (true)
        {
          *(sbyte*) ((IntPtr) voidPtr + 17) = (sbyte) (*(int*) voidPtr < numArray2.Length);
          if (*(sbyte*) ((IntPtr) voidPtr + 17) != (sbyte) 0)
          {
            numArray2[*(int*) voidPtr] = (byte) 0;
            *(int*) voidPtr = *(int*) voidPtr + 1;
          }
          else
            break;
        }
        *(int*) ((IntPtr) voidPtr + 4) = 0;
        while (true)
        {
          *(sbyte*) ((IntPtr) voidPtr + 18) = (sbyte) (*(int*) ((IntPtr) voidPtr + 4) < numArray2.Length);
          if (*(sbyte*) ((IntPtr) voidPtr + 18) != (sbyte) 0)
          {
            *(int*) ((IntPtr) voidPtr + 8) = (int) BitConverter.ToUInt32(numArray2, *(int*) ((IntPtr) voidPtr + 4));
            *(int*) ((IntPtr) voidPtr + 12) = (int) BitConverter.ToUInt32(numArray2, *(int*) ((IntPtr) voidPtr + 4) + 4);
            // ISSUE: cast to a reference type
            // ISSUE: cast to a reference type
            Class73.smethod_57((uint&) ((IntPtr) voidPtr + 8), class0_0, (uint&) ((IntPtr) voidPtr + 12));
            Buffer.BlockCopy((Array) BitConverter.GetBytes(*(uint*) ((IntPtr) voidPtr + 8)), 0, (Array) numArray2, *(int*) ((IntPtr) voidPtr + 4), 4);
            Buffer.BlockCopy((Array) BitConverter.GetBytes(*(uint*) ((IntPtr) voidPtr + 12)), 0, (Array) numArray2, *(int*) ((IntPtr) voidPtr + 4) + 4, 4);
            *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + 8;
          }
          else
            break;
        }
        numArray1 = numArray2;
      }
      return numArray1;
    }

    static void smethod_23(Class80.Class83 class83_0, int int_0)
    {
      Class80.Class83 class83_1 = class83_0;
      int int1 = class83_0.int_1;
      int num1 = int1 + 1;
      class83_1.int_1 = num1;
      if (int1 == 32768)
        throw new InvalidOperationException();
      byte[] byte0 = class83_0.byte_0;
      Class80.Class83 class83_2 = class83_0;
      int int0 = class83_0.int_0;
      int num2 = int0 + 1;
      class83_2.int_0 = num2;
      int index = int0;
      int num3 = (int) (byte) int_0;
      byte0[index] = (byte) num3;
      class83_0.int_0 &= (int) short.MaxValue;
    }

    static void smethod_24(Class19 class19_0)
    {
      try
      {
        class19_0.socket_0.BeginReceive(class19_0.byte_0, 0, class19_0.byte_0.Length, SocketFlags.None, new AsyncCallback(class19_0.method_0), (object) null);
      }
      catch (Exception ex)
      {
        Class73.smethod_217(class19_0, ex.ToString());
      }
    }

    static unsafe void smethod_25(Form1 form1_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(6);
      try
      {
        *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (form1_0.listBox_0.Items.Count > 0);
        if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
        {
          string str = form1_0.listBox_0.Items[0].ToString();
          *(int*) voidPtr = 0;
          while (true)
          {
            if (*(int*) voidPtr < str.Split('/').Length)
            {
              form1_0.listBox_19.Items.Add((object) str.Split('/')[*(int*) voidPtr]);
              *(int*) voidPtr = *(int*) voidPtr + 1;
            }
            else
              break;
          }
          form1_0.listBox_0.Items.Remove(form1_0.listBox_0.Items[0]);
        }
        else
        {
          *(sbyte*) ((IntPtr) voidPtr + 5) = (sbyte) (form1_0.listBox_0.Items.Count <= 0);
          if (*(sbyte*) ((IntPtr) voidPtr + 5) != (sbyte) 0)
            ;
        }
      }
      catch (Exception ex)
      {
        Form1.smethod_1("HATA => " + ex.Message, Color.Salmon);
      }
    }

    static void smethod_26(Class19 class19_0, string string_0)
    {
      Class1 class1_0 = new Class1((ushort) 28688);
      Class73.smethod_65((ushort) 3, class1_0);
      Class73.smethod_120(class1_0, string_0);
      class19_0.method_1(class1_0);
    }

    static void smethod_27(Form1 form1_0)
    {
      Form1.smethod_0("Lisans Hatası !! Bu uyarının hata oldugunu düşünüyorsanız lütfen Ip adresiniz ve mail adresinizi program yapımcısına gönderip durumu belirtiniz.");
    }

    static unsafe void smethod_28(int int_0, Class9 class9_0, int int_1, int int_2)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(5);
      Class73.smethod_61(class9_0, int_2 - 257, 5);
      Class73.smethod_61(class9_0, int_1 - 1, 5);
      Class73.smethod_61(class9_0, int_0 - 4, 4);
      *(int*) voidPtr = 0;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (*(int*) voidPtr < int_0);
        if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
        {
          Class73.smethod_61(class9_0, (int) class9_0.short_4[(int) Class17.byte_0[*(int*) voidPtr] * 2 + 1], 3);
          *(int*) voidPtr = *(int*) voidPtr + 1;
        }
        else
          break;
      }
      Class73.smethod_8(class9_0.short_2, class9_0, int_2 - 1);
      Class73.smethod_8(class9_0.short_3, class9_0, int_1 - 1);
    }

    static unsafe bool smethod_29(Class4 class4_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(3);
      *(sbyte*) voidPtr = (sbyte) (class4_0.list_1.Count == 0);
      if (*(sbyte*) voidPtr != (sbyte) 0)
      {
        *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) 0;
      }
      else
      {
        *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) class4_0.bool_1;
        if (*(sbyte*) ((IntPtr) voidPtr + 2) != (sbyte) 0)
        {
          *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) 1;
        }
        else
        {
          Class1 class1_0 = class4_0.list_1[0];
          if ((Class73.smethod_89(class1_0) == (ushort) 20480 ? 1 : (Class73.smethod_89(class1_0) == (ushort) 36864 ? 1 : 0)) != 0)
            *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) 1;
          else
            *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) 0;
        }
      }
      return (bool) *(sbyte*) ((IntPtr) voidPtr + 1);
    }

    static void smethod_30(Class80.Class83 class83_0, int int_0, int int_1, int int_2)
    {
      while (int_1-- > 0)
      {
        byte[] byte0 = class83_0.byte_0;
        Class80.Class83 class83 = class83_0;
        int int0 = class83_0.int_0;
        int num1 = int0 + 1;
        class83.int_0 = num1;
        int index = int0;
        int num2 = (int) class83_0.byte_0[int_0++];
        byte0[index] = (byte) num2;
        class83_0.int_0 &= (int) short.MaxValue;
        int_0 &= (int) short.MaxValue;
      }
    }

    static unsafe uint[] smethod_31(Class1 class1_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(31);
      *(sbyte*) ((IntPtr) voidPtr + 26) = (sbyte) Class73.smethod_16(class1_0);
      *(short*) ((IntPtr) voidPtr + 16) = (short) Class73.smethod_11(class1_0);
      *(short*) ((IntPtr) voidPtr + 18) = (short) Class73.smethod_11(class1_0);
      *(short*) ((IntPtr) voidPtr + 20) = (short) Class73.smethod_11(class1_0);
      *(short*) ((IntPtr) voidPtr + 22) = (short) Class73.smethod_11(class1_0);
      *(short*) ((IntPtr) voidPtr + 24) = (short) Class73.smethod_11(class1_0);
      if ((*(ushort*) ((IntPtr) voidPtr + 22) != (ushort) 200 ? 1 : (*(ushort*) ((IntPtr) voidPtr + 24) != (ushort) 64 ? 1 : 0)) != 0)
        throw new NotImplementedException("The captcha is expected to be 200 x 64 pixels.");
      byte[] byte_0 = Class73.smethod_211(class1_0, (int) *(ushort*) ((IntPtr) voidPtr + 18));
      *(sbyte*) ((IntPtr) voidPtr + 27) = (sbyte) ((uint) Class73.smethod_179(class1_0) > 0U);
      if (*(sbyte*) ((IntPtr) voidPtr + 27) != (sbyte) 0)
        throw new Exception("Unknown captcha packet.");
      *(int*) voidPtr = (int) *(ushort*) ((IntPtr) voidPtr + 20);
      byte[] byte_1 = new byte[(int) *(ushort*) ((IntPtr) voidPtr + 20)];
      Class73.smethod_146(byte_0, out byte_1);
      byte[] numArray1 = new byte[*(int*) voidPtr];
      Buffer.BlockCopy((Array) byte_1, 0, (Array) numArray1, 0, byte_1.Length);
      uint[] numArray2 = new uint[(int) *(ushort*) ((IntPtr) voidPtr + 22) * (int) *(ushort*) ((IntPtr) voidPtr + 24)];
      int num = 0;
      *(int*) ((IntPtr) voidPtr + 4) = 0;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 30) = (sbyte) (*(int*) ((IntPtr) voidPtr + 4) < (int) *(ushort*) ((IntPtr) voidPtr + 24));
        if (*(sbyte*) ((IntPtr) voidPtr + 30) != (sbyte) 0)
        {
          *(int*) ((IntPtr) voidPtr + 8) = 0;
          while (true)
          {
            *(sbyte*) ((IntPtr) voidPtr + 29) = (sbyte) (*(int*) ((IntPtr) voidPtr + 8) < (int) *(ushort*) ((IntPtr) voidPtr + 22));
            if (*(sbyte*) ((IntPtr) voidPtr + 29) != (sbyte) 0)
            {
              *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 4) * (int) *(ushort*) ((IntPtr) voidPtr + 22) + *(int*) ((IntPtr) voidPtr + 8);
              numArray2[(int) *(uint*) ((IntPtr) voidPtr + 12)] = (uint) (byte) Math.Pow(2.0, (double) (num++ % 8)) & (uint) numArray1[(int) (IntPtr) (long) (*(uint*) ((IntPtr) voidPtr + 12) / 8U)];
              *(sbyte*) ((IntPtr) voidPtr + 28) = (sbyte) (numArray2[(int) *(uint*) ((IntPtr) voidPtr + 12)] == 0U);
              if (*(sbyte*) ((IntPtr) voidPtr + 28) != (sbyte) 0)
                numArray2[(int) *(uint*) ((IntPtr) voidPtr + 12)] = 4278190080U;
              else
                numArray2[(int) *(uint*) ((IntPtr) voidPtr + 12)] = uint.MaxValue;
              *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) + 1;
            }
            else
              break;
          }
          *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + 1;
        }
        else
          break;
      }
      return numArray2;
    }

    static unsafe void smethod_32(Class17 class17_0, Class9 class9_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(18);
      short[] short0 = class17_0.short_0;
      short[] short2 = class17_0.class15_0.short_2;
      *(int*) voidPtr = class17_0.class15_0.int_3;
      int int_0 = -1;
      class9_0.int_32 = 0;
      class9_0.int_33 = Class17.int_1;
      *(int*) ((IntPtr) voidPtr + 4) = 0;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 13) = (sbyte) (*(int*) ((IntPtr) voidPtr + 4) < *(int*) voidPtr);
        if (*(sbyte*) ((IntPtr) voidPtr + 13) != (sbyte) 0)
        {
          *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) ((uint) short0[*(int*) ((IntPtr) voidPtr + 4) * 2] > 0U);
          if (*(sbyte*) ((IntPtr) voidPtr + 12) != (sbyte) 0)
          {
            class9_0.int_31[++class9_0.int_32] = int_0 = *(int*) ((IntPtr) voidPtr + 4);
            class9_0.byte_3[*(int*) ((IntPtr) voidPtr + 4)] = (byte) 0;
          }
          else
            short0[*(int*) ((IntPtr) voidPtr + 4) * 2 + 1] = (short) 0;
          *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + 1;
        }
        else
          break;
      }
      while (true)
      {
        int index1;
        do
        {
          *(sbyte*) ((IntPtr) voidPtr + 15) = (sbyte) (class9_0.int_32 < 2);
          if (*(sbyte*) ((IntPtr) voidPtr + 15) != (sbyte) 0)
          {
            int[] int31 = class9_0.int_31;
            int index2 = ++class9_0.int_32;
            int num1;
            if (int_0 >= 2)
              num1 = 0;
            else
              int_0 = num1 = int_0 + 1;
            int num2 = num1;
            int31[index2] = num1;
            index1 = num2;
            short0[index1 * 2] = (short) 1;
            class9_0.byte_3[index1] = (byte) 0;
            --class9_0.int_38;
            *(sbyte*) ((IntPtr) voidPtr + 14) = (sbyte) (short2 != null);
          }
          else
            goto label_12;
        }
        while (*(sbyte*) ((IntPtr) voidPtr + 14) == (sbyte) 0);
        class9_0.int_39 -= (int) short2[index1 * 2 + 1];
      }
label_12:
      class17_0.int_7 = int_0;
      *(int*) ((IntPtr) voidPtr + 4) = class9_0.int_32 / 2;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 16) = (sbyte) (*(int*) ((IntPtr) voidPtr + 4) >= 1);
        if (*(sbyte*) ((IntPtr) voidPtr + 16) != (sbyte) 0)
        {
          Class73.smethod_73(class9_0, short0, *(int*) ((IntPtr) voidPtr + 4));
          *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) - 1;
        }
        else
          break;
      }
      int index = *(int*) voidPtr;
      do
      {
        *(int*) ((IntPtr) voidPtr + 4) = class9_0.int_31[1];
        class9_0.int_31[1] = class9_0.int_31[class9_0.int_32--];
        Class73.smethod_73(class9_0, short0, 1);
        *(int*) ((IntPtr) voidPtr + 8) = class9_0.int_31[1];
        class9_0.int_31[--class9_0.int_33] = *(int*) ((IntPtr) voidPtr + 4);
        class9_0.int_31[--class9_0.int_33] = *(int*) ((IntPtr) voidPtr + 8);
        short0[index * 2] = (short) ((int) short0[*(int*) ((IntPtr) voidPtr + 4) * 2] + (int) short0[*(int*) ((IntPtr) voidPtr + 8) * 2]);
        class9_0.byte_3[index] = (byte) ((uint) Math.Max(class9_0.byte_3[*(int*) ((IntPtr) voidPtr + 4)], class9_0.byte_3[*(int*) ((IntPtr) voidPtr + 8)]) + 1U);
        short0[*(int*) ((IntPtr) voidPtr + 4) * 2 + 1] = short0[*(int*) ((IntPtr) voidPtr + 8) * 2 + 1] = (short) index;
        class9_0.int_31[1] = index++;
        Class73.smethod_73(class9_0, short0, 1);
        *(sbyte*) ((IntPtr) voidPtr + 17) = (sbyte) (class9_0.int_32 >= 2);
      }
      while (*(sbyte*) ((IntPtr) voidPtr + 17) != (sbyte) 0);
      class9_0.int_31[--class9_0.int_33] = class9_0.int_31[1];
      Class73.smethod_3(class17_0, class9_0);
      Class73.smethod_2(int_0, short0, class9_0.short_5);
    }

    static unsafe ulong smethod_33(Class1 class1_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(10);
      object object0 = class1_0.object_0;
      *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) 0;
      try
      {
        // ISSUE: cast to a reference type
        Monitor.Enter(object0, (bool&) ((IntPtr) voidPtr + 8));
        *(sbyte*) ((IntPtr) voidPtr + 9) = (sbyte) !class1_0.bool_2;
        if (*(sbyte*) ((IntPtr) voidPtr + 9) != (sbyte) 0)
          throw new Exception("Cannot Read from an unlocked Packet.");
        *(long*) voidPtr = (long) class1_0.class2_0.ReadUInt64();
      }
      finally
      {
        if (*(sbyte*) ((IntPtr) voidPtr + 8) != (sbyte) 0)
          Monitor.Exit(object0);
      }
      return (ulong) *(long*) voidPtr;
    }

    static unsafe int smethod_34(Class80.Class82 class82_0, byte[] byte_0, int int_0, int int_1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(12);
      *(int*) voidPtr = 0;
      while (class82_0.int_2 > 0 && int_1 > 0)
      {
        byte_0[int_0++] = (byte) class82_0.uint_0;
        class82_0.uint_0 >>= 8;
        class82_0.int_2 -= 8;
        --int_1;
        *(int*) voidPtr = *(int*) voidPtr + 1;
      }
      if (int_1 == 0)
        return *(int*) voidPtr;
      *(int*) ((IntPtr) voidPtr + 4) = class82_0.int_1 - class82_0.int_0;
      if (int_1 > *(int*) ((IntPtr) voidPtr + 4))
        int_1 = *(int*) ((IntPtr) voidPtr + 4);
      Array.Copy((Array) class82_0.byte_0, class82_0.int_0, (Array) byte_0, int_0, int_1);
      class82_0.int_0 += int_1;
      if ((class82_0.int_0 - class82_0.int_1 & 1) != 0)
      {
        Class80.Class82 class82_1 = class82_0;
        byte[] byte0 = class82_0.byte_0;
        Class80.Class82 class82_2 = class82_0;
        *(int*) ((IntPtr) voidPtr + 8) = class82_0.int_0;
        int num1 = *(int*) ((IntPtr) voidPtr + 8) + 1;
        class82_2.int_0 = num1;
        int index = *(int*) ((IntPtr) voidPtr + 8);
        int num2 = (int) byte0[index] & (int) byte.MaxValue;
        class82_1.uint_0 = (uint) num2;
        class82_0.int_2 = 8;
      }
      return *(int*) voidPtr + int_1;
    }

    static Bitmap smethod_35()
    {
      return (Bitmap) Class73.smethod_175().GetObject("mp_logo2", Class31.cultureInfo_0);
    }

    static unsafe void smethod_36(byte[] byte_0, Class0 class0_0, int int_0, int int_1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(27);
      *(int*) voidPtr = 0;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 20) = (sbyte) (*(uint*) voidPtr < 18U);
        if (*(sbyte*) ((IntPtr) voidPtr + 20) != (sbyte) 0)
        {
          class0_0.uint_2[(int) *(uint*) voidPtr] = Class0.uint_0[(int) *(uint*) voidPtr];
          *(int*) voidPtr = (int) *(uint*) voidPtr + 1;
        }
        else
          break;
      }
      *(int*) voidPtr = 0;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 22) = (sbyte) (*(uint*) voidPtr < 4U);
        if (*(sbyte*) ((IntPtr) voidPtr + 22) != (sbyte) 0)
        {
          *(int*) ((IntPtr) voidPtr + 4) = 0;
          while (true)
          {
            *(sbyte*) ((IntPtr) voidPtr + 21) = (sbyte) (*(uint*) ((IntPtr) voidPtr + 4) < 256U);
            if (*(sbyte*) ((IntPtr) voidPtr + 21) != (sbyte) 0)
            {
              class0_0.uint_3[(int) *(uint*) voidPtr, (int) *(uint*) ((IntPtr) voidPtr + 4)] = Class0.uint_1[(int) *(uint*) voidPtr, (int) *(uint*) ((IntPtr) voidPtr + 4)];
              *(int*) ((IntPtr) voidPtr + 4) = (int) *(uint*) ((IntPtr) voidPtr + 4) + 1;
            }
            else
              break;
          }
          *(int*) voidPtr = (int) *(uint*) voidPtr + 1;
        }
        else
          break;
      }
      byte[] numArray = new byte[4];
      *(int*) ((IntPtr) voidPtr + 4) = 0;
      *(int*) voidPtr = 0;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 23) = (sbyte) (*(uint*) voidPtr < 18U);
        if (*(sbyte*) ((IntPtr) voidPtr + 23) != (sbyte) 0)
        {
          numArray[3] = byte_0[(int) *(uint*) ((IntPtr) voidPtr + 4)];
          numArray[2] = byte_0[(long) (*(uint*) ((IntPtr) voidPtr + 4) + 1U) % (long) int_0];
          numArray[1] = byte_0[(long) (*(uint*) ((IntPtr) voidPtr + 4) + 2U) % (long) int_0];
          numArray[0] = byte_0[(long) (*(uint*) ((IntPtr) voidPtr + 4) + 3U) % (long) int_0];
          *(int*) ((IntPtr) voidPtr + 8) = (int) BitConverter.ToUInt32(numArray, 0);
          class0_0.uint_2[(int) *(uint*) voidPtr] ^= *(uint*) ((IntPtr) voidPtr + 8);
          *(int*) ((IntPtr) voidPtr + 4) = (int) ((*(uint*) ((IntPtr) voidPtr + 4) + 4U) % (uint) int_0);
          *(int*) voidPtr = (int) *(uint*) voidPtr + 1;
        }
        else
          break;
      }
      *(int*) ((IntPtr) voidPtr + 12) = 0;
      *(int*) ((IntPtr) voidPtr + 16) = 0;
      *(int*) voidPtr = 0;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 24) = (sbyte) (*(uint*) voidPtr < 18U);
        if (*(sbyte*) ((IntPtr) voidPtr + 24) != (sbyte) 0)
        {
          // ISSUE: cast to a reference type
          // ISSUE: cast to a reference type
          Class73.smethod_57((uint&) ((IntPtr) voidPtr + 12), class0_0, (uint&) ((IntPtr) voidPtr + 16));
          class0_0.uint_2[(int) *(uint*) voidPtr] = *(uint*) ((IntPtr) voidPtr + 12);
          class0_0.uint_2[(int) *(uint*) voidPtr + 1] = *(uint*) ((IntPtr) voidPtr + 16);
          *(int*) voidPtr = (int) *(uint*) voidPtr + 2;
        }
        else
          break;
      }
      *(int*) voidPtr = 0;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 26) = (sbyte) (*(uint*) voidPtr < 4U);
        if (*(sbyte*) ((IntPtr) voidPtr + 26) != (sbyte) 0)
        {
          *(int*) ((IntPtr) voidPtr + 4) = 0;
          while (true)
          {
            *(sbyte*) ((IntPtr) voidPtr + 25) = (sbyte) (*(uint*) ((IntPtr) voidPtr + 4) < 256U);
            if (*(sbyte*) ((IntPtr) voidPtr + 25) != (sbyte) 0)
            {
              // ISSUE: cast to a reference type
              // ISSUE: cast to a reference type
              Class73.smethod_57((uint&) ((IntPtr) voidPtr + 12), class0_0, (uint&) ((IntPtr) voidPtr + 16));
              class0_0.uint_3[(int) *(uint*) voidPtr, (int) *(uint*) ((IntPtr) voidPtr + 4)] = *(uint*) ((IntPtr) voidPtr + 12);
              class0_0.uint_3[(int) *(uint*) voidPtr, (int) *(uint*) ((IntPtr) voidPtr + 4) + 1] = *(uint*) ((IntPtr) voidPtr + 16);
              *(int*) ((IntPtr) voidPtr + 4) = (int) *(uint*) ((IntPtr) voidPtr + 4) + 2;
            }
            else
              break;
          }
          *(int*) voidPtr = (int) *(uint*) voidPtr + 1;
        }
        else
          break;
      }
    }

    static unsafe void smethod_37(uint uint_0, Class4 class4_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(21);
      *(sbyte*) ((IntPtr) voidPtr + 18) = (sbyte) (uint_0 == 0U);
      if (*(sbyte*) ((IntPtr) voidPtr + 18) != (sbyte) 0)
        uint_0 = 2596254646U;
      *(int*) voidPtr = (int) uint_0;
      *(int*) ((IntPtr) voidPtr + 4) = (int) Class73.smethod_14(ref *(uint*) voidPtr, class4_0);
      *(int*) ((IntPtr) voidPtr + 8) = (int) Class73.smethod_14(ref *(uint*) voidPtr, class4_0);
      *(int*) ((IntPtr) voidPtr + 12) = (int) Class73.smethod_14(ref *(uint*) voidPtr, class4_0);
      int num = (int) Class73.smethod_14(ref *(uint*) voidPtr, class4_0);
      *(sbyte*) ((IntPtr) voidPtr + 16) = (sbyte) (byte) ((int) *(uint*) voidPtr & (int) byte.MaxValue ^ (int) *(uint*) ((IntPtr) voidPtr + 12) & (int) byte.MaxValue);
      *(sbyte*) ((IntPtr) voidPtr + 17) = (sbyte) (byte) ((int) *(uint*) ((IntPtr) voidPtr + 4) & (int) byte.MaxValue ^ (int) *(uint*) ((IntPtr) voidPtr + 8) & (int) byte.MaxValue);
      *(sbyte*) ((IntPtr) voidPtr + 19) = (sbyte) (*(byte*) ((IntPtr) voidPtr + 16) == (byte) 0);
      if (*(sbyte*) ((IntPtr) voidPtr + 19) != (sbyte) 0)
        *(sbyte*) ((IntPtr) voidPtr + 16) = (sbyte) 1;
      *(sbyte*) ((IntPtr) voidPtr + 20) = (sbyte) (*(byte*) ((IntPtr) voidPtr + 17) == (byte) 0);
      if (*(sbyte*) ((IntPtr) voidPtr + 20) != (sbyte) 0)
        *(sbyte*) ((IntPtr) voidPtr + 17) = (sbyte) 1;
      class4_0.byte_0[0] = (byte) ((uint) *(byte*) ((IntPtr) voidPtr + 16) ^ (uint) *(byte*) ((IntPtr) voidPtr + 17));
      class4_0.byte_0[1] = *(byte*) ((IntPtr) voidPtr + 17);
      class4_0.byte_0[2] = *(byte*) ((IntPtr) voidPtr + 16);
    }

    static unsafe byte[] smethod_38(Class4 class4_0, ushort ushort_0, byte[] byte_0, bool bool_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(31);
      *(sbyte*) ((IntPtr) voidPtr + 28) = (sbyte) (byte_0.Length >= 32768);
      if (*(sbyte*) ((IntPtr) voidPtr + 28) != (sbyte) 0)
        throw new Exception("[SecurityAPI::FormatPacket] Payload is too large!");
      *(short*) ((IntPtr) voidPtr + 24) = (short) (ushort) byte_0.Length;
      Class3 class3_0 = new Class3();
      class3_0.Write(*(ushort*) ((IntPtr) voidPtr + 24));
      class3_0.Write(ushort_0);
      class3_0.Write((ushort) 0);
      class3_0.Write(byte_0);
      class3_0.Flush();
      if ((!bool_0 ? 0 : (class4_0.class5_0.byte_1 == (byte) 1 ? 1 : (class4_0.class5_0.byte_2 != (byte) 1 ? 0 : (class4_0.class5_0.byte_1 == (byte) 0 ? 1 : 0)))) != 0)
      {
        *(long*) voidPtr = class3_0.BaseStream.Seek(0L, SeekOrigin.Current);
        *(short*) ((IntPtr) voidPtr + 26) = (short) (ushort) ((uint) *(ushort*) ((IntPtr) voidPtr + 24) | 32768U);
        class3_0.BaseStream.Seek(0L, SeekOrigin.Begin);
        class3_0.Write(*(ushort*) ((IntPtr) voidPtr + 26));
        class3_0.Flush();
        class3_0.BaseStream.Seek(*(long*) voidPtr, SeekOrigin.Begin);
      }
      if ((class4_0.bool_0 ? 0 : (class4_0.class5_0.byte_2 == (byte) 1 ? 1 : 0)) != 0)
      {
        *(long*) ((IntPtr) voidPtr + 8) = class3_0.BaseStream.Seek(0L, SeekOrigin.Current);
        *(sbyte*) ((IntPtr) voidPtr + 29) = (sbyte) Class73.smethod_80(true, class4_0);
        class3_0.BaseStream.Seek(4L, SeekOrigin.Begin);
        class3_0.Write(*(byte*) ((IntPtr) voidPtr + 29));
        class3_0.Flush();
        *(sbyte*) ((IntPtr) voidPtr + 30) = (sbyte) Class73.smethod_139(class4_0, Class73.smethod_230(class3_0));
        class3_0.BaseStream.Seek(5L, SeekOrigin.Begin);
        class3_0.Write(*(byte*) ((IntPtr) voidPtr + 30));
        class3_0.Flush();
        class3_0.BaseStream.Seek(*(long*) ((IntPtr) voidPtr + 8), SeekOrigin.Begin);
      }
      if ((!bool_0 ? 0 : (class4_0.class5_0.byte_1 == (byte) 1 ? 1 : 0)) != 0)
      {
        byte[] byte_0_1 = Class73.smethod_230(class3_0);
        byte[] buffer = Class73.smethod_22(byte_0_1.Length - 2, 2, class4_0.class0_0, byte_0_1);
        class3_0.BaseStream.Seek(2L, SeekOrigin.Begin);
        class3_0.Write(buffer);
        class3_0.Flush();
      }
      else if ((!bool_0 ? 0 : (class4_0.class5_0.byte_2 != (byte) 1 ? 0 : (class4_0.class5_0.byte_1 == (byte) 0 ? 1 : 0))) != 0)
      {
        *(long*) ((IntPtr) voidPtr + 16) = class3_0.BaseStream.Seek(0L, SeekOrigin.Current);
        class3_0.BaseStream.Seek(0L, SeekOrigin.Begin);
        class3_0.Write(*(ushort*) ((IntPtr) voidPtr + 24));
        class3_0.Flush();
        class3_0.BaseStream.Seek(*(long*) ((IntPtr) voidPtr + 16), SeekOrigin.Begin);
      }
      return Class73.smethod_230(class3_0);
    }

    static unsafe int smethod_39(int int_0, Class80.Class83 class83_0, int int_1, byte[] byte_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(12);
      *(int*) voidPtr = class83_0.int_0;
      if (int_1 > class83_0.int_1)
        int_1 = class83_0.int_1;
      else
        *(int*) voidPtr = class83_0.int_0 - class83_0.int_1 + int_1 & (int) short.MaxValue;
      *(int*) ((IntPtr) voidPtr + 4) = int_1;
      *(int*) ((IntPtr) voidPtr + 8) = int_1 - *(int*) voidPtr;
      if (*(int*) ((IntPtr) voidPtr + 8) > 0)
      {
        Array.Copy((Array) class83_0.byte_0, 32768 - *(int*) ((IntPtr) voidPtr + 8), (Array) byte_0, int_0, *(int*) ((IntPtr) voidPtr + 8));
        int_0 += *(int*) ((IntPtr) voidPtr + 8);
        int_1 = *(int*) voidPtr;
      }
      Array.Copy((Array) class83_0.byte_0, *(int*) voidPtr - int_1, (Array) byte_0, int_0, int_1);
      class83_0.int_1 -= *(int*) ((IntPtr) voidPtr + 4);
      if (class83_0.int_1 < 0)
        throw new InvalidOperationException();
      return *(int*) ((IntPtr) voidPtr + 4);
    }

    static void smethod_40(Form1 form1_0)
    {
      form1_0.icontainer_0 = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      form1_0.richTextBox_0 = new RichTextBox();
      form1_0.label_0 = new Label();
      form1_0.label_1 = new Label();
      form1_0.groupControl_0 = new GroupControl();
      form1_0.panelControl_0 = new PanelControl();
      form1_0.groupControl_9 = new GroupControl();
      form1_0.textBox_101 = new TextBox();
      form1_0.panelControl_8 = new PanelControl();
      form1_0.listView_0 = new ListView();
      form1_0.columnHeader_0 = new ColumnHeader();
      form1_0.columnHeader_1 = new ColumnHeader();
      form1_0.columnHeader_2 = new ColumnHeader();
      form1_0.listBox_20 = new ListBox();
      form1_0.groupBox_10 = new GroupBox();
      form1_0.label_134 = new Label();
      form1_0.label_135 = new Label();
      form1_0.listBox_13 = new ListBox();
      form1_0.listBox_14 = new ListBox();
      form1_0.groupBox_11 = new GroupBox();
      form1_0.textBox_83 = new TextBox();
      form1_0.label_138 = new Label();
      form1_0.textBox_17 = new TextBox();
      form1_0.label_42 = new Label();
      form1_0.label_129 = new Label();
      form1_0.textBox_78 = new TextBox();
      form1_0.groupBox_12 = new GroupBox();
      form1_0.groupBox_13 = new GroupBox();
      form1_0.textBox_98 = new TextBox();
      form1_0.label_155 = new Label();
      form1_0.label_43 = new Label();
      form1_0.label_44 = new Label();
      form1_0.label_45 = new Label();
      form1_0.textBox_18 = new TextBox();
      form1_0.textBox_19 = new TextBox();
      form1_0.textBox_20 = new TextBox();
      form1_0.checkBox_6 = new CheckBox();
      form1_0.groupBox_14 = new GroupBox();
      form1_0.label_46 = new Label();
      form1_0.label_47 = new Label();
      form1_0.label_48 = new Label();
      form1_0.textBox_21 = new TextBox();
      form1_0.textBox_22 = new TextBox();
      form1_0.textBox_23 = new TextBox();
      form1_0.checkBox_7 = new CheckBox();
      form1_0.timer_0 = new System.Windows.Forms.Timer(form1_0.icontainer_0);
      form1_0.panelControl_1 = new PanelControl();
      form1_0.groupControl_1 = new GroupControl();
      form1_0.textEdit_0 = new TextEdit();
      form1_0.simpleButton_0 = new SimpleButton();
      form1_0.label_2 = new Label();
      form1_0.textEdit_1 = new TextEdit();
      form1_0.textEdit_2 = new TextEdit();
      form1_0.labelControl_0 = new LabelControl();
      form1_0.labelControl_1 = new LabelControl();
      form1_0.labelControl_2 = new LabelControl();
      form1_0.labelControl_3 = new LabelControl();
      form1_0.textEdit_3 = new TextEdit();
      form1_0.textEdit_4 = new TextEdit();
      form1_0.labelControl_4 = new LabelControl();
      form1_0.textEdit_5 = new TextEdit();
      form1_0.labelControl_5 = new LabelControl();
      form1_0.groupControl_2 = new GroupControl();
      form1_0.labelControl_6 = new LabelControl();
      form1_0.labelControl_7 = new LabelControl();
      form1_0.label_3 = new Label();
      form1_0.label_4 = new Label();
      form1_0.label_5 = new Label();
      form1_0.button_0 = new Button();
      form1_0.button_1 = new Button();
      form1_0.simpleButton_1 = new SimpleButton();
      form1_0.textEdit_6 = new TextEdit();
      form1_0.textEdit_7 = new TextEdit();
      form1_0.textEdit_8 = new TextEdit();
      form1_0.labelControl_8 = new LabelControl();
      form1_0.labelControl_9 = new LabelControl();
      form1_0.labelControl_10 = new LabelControl();
      form1_0.groupControl_3 = new GroupControl();
      form1_0.groupControl_4 = new GroupControl();
      form1_0.panelControl_2 = new PanelControl();
      form1_0.textEdit_15 = new TextEdit();
      form1_0.textEdit_16 = new TextEdit();
      form1_0.label_159 = new Label();
      form1_0.label_6 = new Label();
      form1_0.label_7 = new Label();
      form1_0.textEdit_18 = new TextEdit();
      form1_0.panel_1 = new Panel();
      form1_0.panelControl_3 = new PanelControl();
      form1_0.panelControl_7 = new PanelControl();
      form1_0.textEdit_13 = new TextEdit();
      form1_0.textEdit_14 = new TextEdit();
      form1_0.label_19 = new Label();
      form1_0.label_9 = new Label();
      form1_0.textEdit_12 = new TextEdit();
      form1_0.label_18 = new Label();
      form1_0.label_10 = new Label();
      form1_0.label_17 = new Label();
      form1_0.textEdit_9 = new TextEdit();
      form1_0.textEdit_11 = new TextEdit();
      form1_0.label_11 = new Label();
      form1_0.textEdit_10 = new TextEdit();
      form1_0.textBox_86 = new TextBox();
      form1_0.button_23 = new Button();
      form1_0.groupControl_5 = new GroupControl();
      form1_0.panelControl_4 = new PanelControl();
      form1_0.label_161 = new Label();
      form1_0.label_162 = new Label();
      form1_0.label_163 = new Label();
      form1_0.label_164 = new Label();
      form1_0.label_160 = new Label();
      form1_0.label_158 = new Label();
      form1_0.checkEdit_9 = new CheckEdit();
      form1_0.groupControl_6 = new GroupControl();
      form1_0.panelControl_5 = new PanelControl();
      form1_0.label_171 = new Label();
      form1_0.checkBox_25 = new CheckBox();
      form1_0.label_12 = new Label();
      form1_0.pictureBox_0 = new PictureBox();
      form1_0.label_8 = new Label();
      form1_0.label_13 = new Label();
      form1_0.label_14 = new Label();
      form1_0.label_15 = new Label();
      form1_0.label_16 = new Label();
      form1_0.button_19 = new Button();
      form1_0.button_2 = new Button();
      form1_0.groupControl_7 = new GroupControl();
      form1_0.panelControl_6 = new PanelControl();
      form1_0.textEdit_17 = new TextEdit();
      form1_0.textBox_90 = new TextBox();
      form1_0.textBox_89 = new TextBox();
      form1_0.label_20 = new Label();
      form1_0.label_21 = new Label();
      form1_0.label_22 = new Label();
      form1_0.checkEdit_10 = new CheckEdit();
      form1_0.xtraTabControl_0 = new XtraTabControl();
      form1_0.xtraTabPage_0 = new XtraTabPage();
      form1_0.comboBoxEdit_3 = new ComboBoxEdit();
      form1_0.button_3 = new Button();
      form1_0.groupBox_0 = new GroupBox();
      form1_0.button_37 = new Button();
      form1_0.checkBox_26 = new CheckBox();
      form1_0.panel_2 = new Panel();
      form1_0.textBox_7 = new TextBox();
      form1_0.textBox_8 = new TextBox();
      form1_0.label_29 = new Label();
      form1_0.label_120 = new Label();
      form1_0.label_156 = new Label();
      form1_0.label_157 = new Label();
      form1_0.button_26 = new Button();
      form1_0.button_27 = new Button();
      form1_0.button_28 = new Button();
      form1_0.button_29 = new Button();
      form1_0.listBoxControl_0 = new ListBoxControl();
      form1_0.contextMenuStrip_0 = new ContextMenuStrip(form1_0.icontainer_0);
      form1_0.toolStripMenuItem_0 = new ToolStripMenuItem();
      form1_0.button_30 = new Button();
      form1_0.listBoxControl_1 = new ListBoxControl();
      form1_0.groupBox_1 = new GroupBox();
      form1_0.groupBox_2 = new GroupBox();
      form1_0.label_149 = new Label();
      form1_0.textBox_91 = new TextBox();
      form1_0.label_23 = new Label();
      form1_0.label_24 = new Label();
      form1_0.label_25 = new Label();
      form1_0.textBox_0 = new TextBox();
      form1_0.textBox_1 = new TextBox();
      form1_0.textBox_2 = new TextBox();
      form1_0.checkBox_0 = new CheckBox();
      form1_0.groupBox_3 = new GroupBox();
      form1_0.label_26 = new Label();
      form1_0.label_27 = new Label();
      form1_0.label_28 = new Label();
      form1_0.textBox_3 = new TextBox();
      form1_0.textBox_4 = new TextBox();
      form1_0.textBox_5 = new TextBox();
      form1_0.checkBox_1 = new CheckBox();
      form1_0.textBox_6 = new TextBox();
      form1_0.button_4 = new Button();
      form1_0.textBox_9 = new TextBox();
      form1_0.listBox_10 = new ListBox();
      form1_0.dateTimePicker_8 = new DateTimePicker();
      form1_0.label_30 = new Label();
      form1_0.label_31 = new Label();
      form1_0.groupBox_4 = new GroupBox();
      form1_0.comboBoxEdit_2 = new ComboBoxEdit();
      form1_0.label_106 = new Label();
      form1_0.label_107 = new Label();
      form1_0.checkBox_2 = new CheckBox();
      form1_0.label_32 = new Label();
      form1_0.xtraTabPage_1 = new XtraTabPage();
      form1_0.comboBoxEdit_4 = new ComboBoxEdit();
      form1_0.button_5 = new Button();
      form1_0.button_6 = new Button();
      form1_0.textBox_10 = new TextBox();
      form1_0.groupBox_5 = new GroupBox();
      form1_0.listBox_19 = new ListBox();
      form1_0.textBox_99 = new TextBox();
      form1_0.listBox_18 = new ListBox();
      form1_0.listBox_0 = new ListBox();
      form1_0.listBox_1 = new ListBox();
      form1_0.groupBox_6 = new GroupBox();
      form1_0.groupBox_7 = new GroupBox();
      form1_0.textBox_92 = new TextBox();
      form1_0.label_148 = new Label();
      form1_0.label_33 = new Label();
      form1_0.label_34 = new Label();
      form1_0.label_35 = new Label();
      form1_0.textBox_11 = new TextBox();
      form1_0.textBox_12 = new TextBox();
      form1_0.textBox_13 = new TextBox();
      form1_0.checkBox_3 = new CheckBox();
      form1_0.groupBox_8 = new GroupBox();
      form1_0.label_36 = new Label();
      form1_0.label_37 = new Label();
      form1_0.label_38 = new Label();
      form1_0.textBox_14 = new TextBox();
      form1_0.textBox_15 = new TextBox();
      form1_0.textBox_16 = new TextBox();
      form1_0.checkBox_4 = new CheckBox();
      form1_0.listBox_11 = new ListBox();
      form1_0.dateTimePicker_0 = new DateTimePicker();
      form1_0.label_39 = new Label();
      form1_0.label_40 = new Label();
      form1_0.groupBox_9 = new GroupBox();
      form1_0.comboBoxEdit_0 = new ComboBoxEdit();
      form1_0.label_108 = new Label();
      form1_0.label_109 = new Label();
      form1_0.checkBox_5 = new CheckBox();
      form1_0.label_41 = new Label();
      form1_0.xtraTabPage_2 = new XtraTabPage();
      form1_0.comboBoxEdit_5 = new ComboBoxEdit();
      form1_0.button_7 = new Button();
      form1_0.button_8 = new Button();
      form1_0.textBox_24 = new TextBox();
      form1_0.groupBox_15 = new GroupBox();
      form1_0.label_139 = new Label();
      form1_0.groupBox_33 = new GroupBox();
      form1_0.groupBox_34 = new GroupBox();
      form1_0.textBox_93 = new TextBox();
      form1_0.label_150 = new Label();
      form1_0.label_94 = new Label();
      form1_0.label_95 = new Label();
      form1_0.label_96 = new Label();
      form1_0.textBox_53 = new TextBox();
      form1_0.textBox_54 = new TextBox();
      form1_0.textBox_55 = new TextBox();
      form1_0.checkBox_15 = new CheckBox();
      form1_0.groupBox_35 = new GroupBox();
      form1_0.label_97 = new Label();
      form1_0.label_98 = new Label();
      form1_0.label_99 = new Label();
      form1_0.textBox_56 = new TextBox();
      form1_0.textBox_57 = new TextBox();
      form1_0.textBox_58 = new TextBox();
      form1_0.checkBox_16 = new CheckBox();
      form1_0.listBox_2 = new ListBox();
      form1_0.groupBox_16 = new GroupBox();
      form1_0.comboBoxEdit_1 = new ComboBoxEdit();
      form1_0.label_110 = new Label();
      form1_0.label_111 = new Label();
      form1_0.textBox_52 = new TextBox();
      form1_0.checkBox_8 = new CheckBox();
      form1_0.label_49 = new Label();
      form1_0.listBox_3 = new ListBox();
      form1_0.dateTimePicker_1 = new DateTimePicker();
      form1_0.label_50 = new Label();
      form1_0.label_51 = new Label();
      form1_0.xtraTabPage_3 = new XtraTabPage();
      form1_0.comboBoxEdit_6 = new ComboBoxEdit();
      form1_0.groupBox_17 = new GroupBox();
      form1_0.groupBox_36 = new GroupBox();
      form1_0.groupBox_37 = new GroupBox();
      form1_0.textBox_94 = new TextBox();
      form1_0.label_151 = new Label();
      form1_0.label_100 = new Label();
      form1_0.label_101 = new Label();
      form1_0.label_102 = new Label();
      form1_0.textBox_59 = new TextBox();
      form1_0.textBox_60 = new TextBox();
      form1_0.textBox_61 = new TextBox();
      form1_0.checkBox_17 = new CheckBox();
      form1_0.groupBox_38 = new GroupBox();
      form1_0.label_103 = new Label();
      form1_0.label_104 = new Label();
      form1_0.label_105 = new Label();
      form1_0.textBox_62 = new TextBox();
      form1_0.textBox_63 = new TextBox();
      form1_0.textBox_64 = new TextBox();
      form1_0.checkBox_18 = new CheckBox();
      form1_0.groupBox_18 = new GroupBox();
      form1_0.label_165 = new Label();
      form1_0.comboBox_0 = new System.Windows.Forms.ComboBox();
      form1_0.comboBox_2 = new System.Windows.Forms.ComboBox();
      form1_0.label_52 = new Label();
      form1_0.label_53 = new Label();
      form1_0.label_54 = new Label();
      form1_0.textBox_25 = new TextBox();
      form1_0.label_55 = new Label();
      form1_0.button_9 = new Button();
      form1_0.button_10 = new Button();
      form1_0.textBox_26 = new TextBox();
      form1_0.listBox_4 = new ListBox();
      form1_0.dateTimePicker_2 = new DateTimePicker();
      form1_0.label_56 = new Label();
      form1_0.label_57 = new Label();
      form1_0.groupBox_19 = new GroupBox();
      form1_0.label_112 = new Label();
      form1_0.label_113 = new Label();
      form1_0.checkBox_9 = new CheckBox();
      form1_0.xtraTabPage_4 = new XtraTabPage();
      form1_0.comboBoxEdit_7 = new ComboBoxEdit();
      form1_0.button_11 = new Button();
      form1_0.groupBox_20 = new GroupBox();
      form1_0.textBox_79 = new TextBox();
      form1_0.groupBox_21 = new GroupBox();
      form1_0.textBox_27 = new TextBox();
      form1_0.label_58 = new Label();
      form1_0.label_59 = new Label();
      form1_0.textBox_28 = new TextBox();
      form1_0.label_60 = new Label();
      form1_0.label_61 = new Label();
      form1_0.label_62 = new Label();
      form1_0.label_63 = new Label();
      form1_0.textBox_29 = new TextBox();
      form1_0.groupBox_22 = new GroupBox();
      form1_0.groupBox_23 = new GroupBox();
      form1_0.textBox_95 = new TextBox();
      form1_0.label_152 = new Label();
      form1_0.label_64 = new Label();
      form1_0.label_65 = new Label();
      form1_0.label_66 = new Label();
      form1_0.textBox_30 = new TextBox();
      form1_0.textBox_31 = new TextBox();
      form1_0.textBox_32 = new TextBox();
      form1_0.checkBox_10 = new CheckBox();
      form1_0.groupBox_24 = new GroupBox();
      form1_0.label_67 = new Label();
      form1_0.label_68 = new Label();
      form1_0.label_69 = new Label();
      form1_0.textBox_33 = new TextBox();
      form1_0.textBox_34 = new TextBox();
      form1_0.textBox_35 = new TextBox();
      form1_0.checkBox_11 = new CheckBox();
      form1_0.button_12 = new Button();
      form1_0.textBox_36 = new TextBox();
      form1_0.listBox_5 = new ListBox();
      form1_0.dateTimePicker_3 = new DateTimePicker();
      form1_0.label_70 = new Label();
      form1_0.label_71 = new Label();
      form1_0.groupBox_25 = new GroupBox();
      form1_0.textBox_80 = new TextBox();
      form1_0.label_114 = new Label();
      form1_0.label_115 = new Label();
      form1_0.textBox_65 = new TextBox();
      form1_0.textBox_66 = new TextBox();
      form1_0.checkBox_12 = new CheckBox();
      form1_0.xtraTabPage_6 = new XtraTabPage();
      form1_0.comboBoxEdit_8 = new ComboBoxEdit();
      form1_0.groupBox_45 = new GroupBox();
      form1_0.label_166 = new Label();
      form1_0.label_167 = new Label();
      form1_0.groupBox_29 = new GroupBox();
      form1_0.label_170 = new Label();
      form1_0.button_32 = new Button();
      form1_0.button_31 = new Button();
      form1_0.label_168 = new Label();
      form1_0.label_169 = new Label();
      form1_0.label_144 = new Label();
      form1_0.textBox_87 = new TextBox();
      form1_0.label_79 = new Label();
      form1_0.textBox_40 = new TextBox();
      form1_0.label_80 = new Label();
      form1_0.textBox_41 = new TextBox();
      form1_0.textBox_77 = new TextBox();
      form1_0.textBox_76 = new TextBox();
      form1_0.groupBox_28 = new GroupBox();
      form1_0.checkBox_13 = new CheckBox();
      form1_0.groupBox_30 = new GroupBox();
      form1_0.label_81 = new Label();
      form1_0.label_82 = new Label();
      form1_0.label_83 = new Label();
      form1_0.textBox_43 = new TextBox();
      form1_0.textBox_42 = new TextBox();
      form1_0.textBox_44 = new TextBox();
      form1_0.groupBox_31 = new GroupBox();
      form1_0.textBox_96 = new TextBox();
      form1_0.label_153 = new Label();
      form1_0.label_84 = new Label();
      form1_0.label_85 = new Label();
      form1_0.label_86 = new Label();
      form1_0.textBox_45 = new TextBox();
      form1_0.textBox_46 = new TextBox();
      form1_0.textBox_47 = new TextBox();
      form1_0.checkBox_14 = new CheckBox();
      form1_0.button_15 = new Button();
      form1_0.button_16 = new Button();
      form1_0.listBox_7 = new ListBox();
      form1_0.dateTimePicker_5 = new DateTimePicker();
      form1_0.label_87 = new Label();
      form1_0.label_88 = new Label();
      form1_0.xtraTabPage_7 = new XtraTabPage();
      form1_0.comboBoxEdit_9 = new ComboBoxEdit();
      form1_0.checkBox_22 = new CheckBox();
      form1_0.listBox_16 = new ListBox();
      form1_0.groupBox_39 = new GroupBox();
      form1_0.checkBox_19 = new CheckBox();
      form1_0.groupBox_40 = new GroupBox();
      form1_0.label_119 = new Label();
      form1_0.label_118 = new Label();
      form1_0.checkBox_20 = new CheckBox();
      form1_0.groupBox_41 = new GroupBox();
      form1_0.textBox_70 = new TextBox();
      form1_0.label_125 = new Label();
      form1_0.label_123 = new Label();
      form1_0.label_124 = new Label();
      form1_0.textBox_71 = new TextBox();
      form1_0.textBox_72 = new TextBox();
      form1_0.groupBox_42 = new GroupBox();
      form1_0.textBox_97 = new TextBox();
      form1_0.label_154 = new Label();
      form1_0.label_126 = new Label();
      form1_0.label_127 = new Label();
      form1_0.label_128 = new Label();
      form1_0.textBox_73 = new TextBox();
      form1_0.textBox_74 = new TextBox();
      form1_0.textBox_75 = new TextBox();
      form1_0.listBox_8 = new ListBox();
      form1_0.button_17 = new Button();
      form1_0.button_18 = new Button();
      form1_0.textBox_48 = new TextBox();
      form1_0.listBox_9 = new ListBox();
      form1_0.dateTimePicker_6 = new DateTimePicker();
      form1_0.label_89 = new Label();
      form1_0.label_90 = new Label();
      form1_0.groupBox_32 = new GroupBox();
      form1_0.checkEdit_0 = new CheckEdit();
      form1_0.textBox_69 = new TextBox();
      form1_0.label_121 = new Label();
      form1_0.textBox_68 = new TextBox();
      form1_0.label_122 = new Label();
      form1_0.textBox_67 = new TextBox();
      form1_0.textBox_49 = new TextBox();
      form1_0.label_91 = new Label();
      form1_0.textBox_50 = new TextBox();
      form1_0.label_92 = new Label();
      form1_0.textBox_51 = new TextBox();
      form1_0.label_93 = new Label();
      form1_0.xtraTabPage_8 = new XtraTabPage();
      form1_0.comboBoxEdit_10 = new ComboBoxEdit();
      form1_0.textBox_84 = new TextBox();
      form1_0.button_20 = new Button();
      form1_0.button_21 = new Button();
      form1_0.listBox_12 = new ListBox();
      form1_0.dateTimePicker_7 = new DateTimePicker();
      form1_0.label_130 = new Label();
      form1_0.label_131 = new Label();
      form1_0.groupBox_43 = new GroupBox();
      form1_0.button_22 = new Button();
      form1_0.label_136 = new Label();
      form1_0.textBox_81 = new TextBox();
      form1_0.label_137 = new Label();
      form1_0.textBox_82 = new TextBox();
      form1_0.label_132 = new Label();
      form1_0.label_133 = new Label();
      form1_0.checkBox_21 = new CheckBox();
      form1_0.xtraTabPage_9 = new XtraTabPage();
      form1_0.label_175 = new Label();
      form1_0.listBox_23 = new ListBox();
      form1_0.checkBox_28 = new CheckBox();
      form1_0.button_36 = new Button();
      form1_0.groupBox_46 = new GroupBox();
      form1_0.label_176 = new Label();
      form1_0.label_174 = new Label();
      form1_0.textBox_103 = new TextBox();
      form1_0.comboBoxEdit_13 = new ComboBoxEdit();
      form1_0.comboBoxEdit_12 = new ComboBoxEdit();
      form1_0.checkBox_27 = new CheckBox();
      form1_0.button_34 = new Button();
      form1_0.button_35 = new Button();
      form1_0.textBox_102 = new TextBox();
      form1_0.listBox_22 = new ListBox();
      form1_0.dateTimePicker_9 = new DateTimePicker();
      form1_0.label_172 = new Label();
      form1_0.label_173 = new Label();
      form1_0.xtraTabPage_5 = new XtraTabPage();
      form1_0.listBox_21 = new ListBox();
      form1_0.button_33 = new Button();
      form1_0.comboBoxEdit_11 = new ComboBoxEdit();
      form1_0.groupBox_44 = new GroupBox();
      form1_0.panel_0 = new Panel();
      form1_0.textBox_100 = new TextBox();
      form1_0.label_147 = new Label();
      form1_0.label_146 = new Label();
      form1_0.label_145 = new Label();
      form1_0.textBox_88 = new TextBox();
      form1_0.listBox_17 = new ListBox();
      form1_0.label_141 = new Label();
      form1_0.label_140 = new Label();
      form1_0.textBox_85 = new TextBox();
      form1_0.button_24 = new Button();
      form1_0.label_142 = new Label();
      form1_0.button_25 = new Button();
      form1_0.label_143 = new Label();
      form1_0.checkBox_23 = new CheckBox();
      form1_0.checkBox_24 = new CheckBox();
      form1_0.listBox_15 = new ListBox();
      form1_0.button_13 = new Button();
      form1_0.button_14 = new Button();
      form1_0.textBox_37 = new TextBox();
      form1_0.listBox_6 = new ListBox();
      form1_0.dateTimePicker_4 = new DateTimePicker();
      form1_0.label_72 = new Label();
      form1_0.label_73 = new Label();
      form1_0.groupBox_26 = new GroupBox();
      form1_0.label_116 = new Label();
      form1_0.comboBox_1 = new System.Windows.Forms.ComboBox();
      form1_0.label_117 = new Label();
      form1_0.label_74 = new Label();
      form1_0.label_75 = new Label();
      form1_0.label_76 = new Label();
      form1_0.groupBox_27 = new GroupBox();
      form1_0.checkEdit_11 = new CheckEdit();
      form1_0.checkEdit_1 = new CheckEdit();
      form1_0.checkEdit_2 = new CheckEdit();
      form1_0.checkEdit_3 = new CheckEdit();
      form1_0.checkEdit_4 = new CheckEdit();
      form1_0.checkEdit_5 = new CheckEdit();
      form1_0.checkEdit_6 = new CheckEdit();
      form1_0.checkEdit_7 = new CheckEdit();
      form1_0.checkEdit_8 = new CheckEdit();
      form1_0.textBox_38 = new TextBox();
      form1_0.label_77 = new Label();
      form1_0.label_78 = new Label();
      form1_0.textBox_39 = new TextBox();
      form1_0.groupControl_8 = new GroupControl();
      form1_0.timer_1 = new System.Windows.Forms.Timer(form1_0.icontainer_0);
      form1_0.timer_2 = new System.Windows.Forms.Timer(form1_0.icontainer_0);
      form1_0.timer_4 = new System.Windows.Forms.Timer(form1_0.icontainer_0);
      form1_0.timer_3 = new System.Windows.Forms.Timer(form1_0.icontainer_0);
      form1_0.timer_5 = new System.Windows.Forms.Timer(form1_0.icontainer_0);
      form1_0.behaviorManager_0 = new BehaviorManager(form1_0.icontainer_0);
      form1_0.timer_6 = new System.Windows.Forms.Timer(form1_0.icontainer_0);
      form1_0.timer_7 = new System.Windows.Forms.Timer(form1_0.icontainer_0);
      form1_0.defaultLookAndFeel_0 = new DefaultLookAndFeel(form1_0.icontainer_0);
      form1_0.formAssistant_0 = new FormAssistant();
      form1_0.ribbonPage_0 = new RibbonPage();
      form1_0.timer_8 = new System.Windows.Forms.Timer(form1_0.icontainer_0);
      form1_0.timer_9 = new System.Windows.Forms.Timer(form1_0.icontainer_0);
      form1_0.timer_10 = new System.Windows.Forms.Timer(form1_0.icontainer_0);
      form1_0.timer_11 = new System.Windows.Forms.Timer(form1_0.icontainer_0);
      form1_0.timer_12 = new System.Windows.Forms.Timer(form1_0.icontainer_0);
      form1_0.groupControl_0.BeginInit();
      form1_0.groupControl_0.SuspendLayout();
      form1_0.panelControl_0.BeginInit();
      form1_0.panelControl_0.SuspendLayout();
      form1_0.groupControl_9.BeginInit();
      form1_0.groupControl_9.SuspendLayout();
      form1_0.panelControl_8.BeginInit();
      form1_0.panelControl_8.SuspendLayout();
      form1_0.groupBox_10.SuspendLayout();
      form1_0.groupBox_11.SuspendLayout();
      form1_0.groupBox_12.SuspendLayout();
      form1_0.groupBox_13.SuspendLayout();
      form1_0.groupBox_14.SuspendLayout();
      form1_0.panelControl_1.BeginInit();
      form1_0.panelControl_1.SuspendLayout();
      form1_0.groupControl_1.BeginInit();
      form1_0.groupControl_1.SuspendLayout();
      form1_0.textEdit_0.Properties.BeginInit();
      form1_0.textEdit_1.Properties.BeginInit();
      form1_0.textEdit_2.Properties.BeginInit();
      form1_0.textEdit_3.Properties.BeginInit();
      form1_0.textEdit_4.Properties.BeginInit();
      form1_0.textEdit_5.Properties.BeginInit();
      form1_0.groupControl_2.BeginInit();
      form1_0.groupControl_2.SuspendLayout();
      form1_0.textEdit_6.Properties.BeginInit();
      form1_0.textEdit_7.Properties.BeginInit();
      form1_0.textEdit_8.Properties.BeginInit();
      form1_0.groupControl_3.BeginInit();
      form1_0.groupControl_3.SuspendLayout();
      form1_0.groupControl_4.BeginInit();
      form1_0.groupControl_4.SuspendLayout();
      form1_0.panelControl_2.BeginInit();
      form1_0.panelControl_2.SuspendLayout();
      form1_0.textEdit_15.Properties.BeginInit();
      form1_0.textEdit_16.Properties.BeginInit();
      form1_0.textEdit_18.Properties.BeginInit();
      form1_0.panelControl_3.BeginInit();
      form1_0.panelControl_3.SuspendLayout();
      form1_0.panelControl_7.BeginInit();
      form1_0.panelControl_7.SuspendLayout();
      form1_0.textEdit_13.Properties.BeginInit();
      form1_0.textEdit_14.Properties.BeginInit();
      form1_0.textEdit_12.Properties.BeginInit();
      form1_0.textEdit_9.Properties.BeginInit();
      form1_0.textEdit_11.Properties.BeginInit();
      form1_0.textEdit_10.Properties.BeginInit();
      form1_0.groupControl_5.BeginInit();
      form1_0.groupControl_5.SuspendLayout();
      form1_0.panelControl_4.BeginInit();
      form1_0.panelControl_4.SuspendLayout();
      form1_0.checkEdit_9.Properties.BeginInit();
      form1_0.groupControl_6.BeginInit();
      form1_0.groupControl_6.SuspendLayout();
      form1_0.panelControl_5.BeginInit();
      form1_0.panelControl_5.SuspendLayout();
      ((ISupportInitialize) form1_0.pictureBox_0).BeginInit();
      form1_0.groupControl_7.BeginInit();
      form1_0.groupControl_7.SuspendLayout();
      form1_0.panelControl_6.BeginInit();
      form1_0.panelControl_6.SuspendLayout();
      form1_0.textEdit_17.Properties.BeginInit();
      form1_0.checkEdit_10.Properties.BeginInit();
      form1_0.xtraTabControl_0.BeginInit();
      form1_0.xtraTabControl_0.SuspendLayout();
      form1_0.xtraTabPage_0.SuspendLayout();
      form1_0.comboBoxEdit_3.Properties.BeginInit();
      form1_0.groupBox_0.SuspendLayout();
      form1_0.panel_2.SuspendLayout();
      ((ISupportInitialize) form1_0.listBoxControl_0).BeginInit();
      form1_0.contextMenuStrip_0.SuspendLayout();
      ((ISupportInitialize) form1_0.listBoxControl_1).BeginInit();
      form1_0.groupBox_1.SuspendLayout();
      form1_0.groupBox_2.SuspendLayout();
      form1_0.groupBox_3.SuspendLayout();
      form1_0.groupBox_4.SuspendLayout();
      form1_0.comboBoxEdit_2.Properties.BeginInit();
      form1_0.xtraTabPage_1.SuspendLayout();
      form1_0.comboBoxEdit_4.Properties.BeginInit();
      form1_0.groupBox_5.SuspendLayout();
      form1_0.groupBox_6.SuspendLayout();
      form1_0.groupBox_7.SuspendLayout();
      form1_0.groupBox_8.SuspendLayout();
      form1_0.groupBox_9.SuspendLayout();
      form1_0.comboBoxEdit_0.Properties.BeginInit();
      form1_0.xtraTabPage_2.SuspendLayout();
      form1_0.comboBoxEdit_5.Properties.BeginInit();
      form1_0.groupBox_15.SuspendLayout();
      form1_0.groupBox_33.SuspendLayout();
      form1_0.groupBox_34.SuspendLayout();
      form1_0.groupBox_35.SuspendLayout();
      form1_0.groupBox_16.SuspendLayout();
      form1_0.comboBoxEdit_1.Properties.BeginInit();
      form1_0.xtraTabPage_3.SuspendLayout();
      form1_0.comboBoxEdit_6.Properties.BeginInit();
      form1_0.groupBox_17.SuspendLayout();
      form1_0.groupBox_36.SuspendLayout();
      form1_0.groupBox_37.SuspendLayout();
      form1_0.groupBox_38.SuspendLayout();
      form1_0.groupBox_18.SuspendLayout();
      form1_0.groupBox_19.SuspendLayout();
      form1_0.xtraTabPage_4.SuspendLayout();
      form1_0.comboBoxEdit_7.Properties.BeginInit();
      form1_0.groupBox_20.SuspendLayout();
      form1_0.groupBox_21.SuspendLayout();
      form1_0.groupBox_22.SuspendLayout();
      form1_0.groupBox_23.SuspendLayout();
      form1_0.groupBox_24.SuspendLayout();
      form1_0.groupBox_25.SuspendLayout();
      form1_0.xtraTabPage_6.SuspendLayout();
      form1_0.comboBoxEdit_8.Properties.BeginInit();
      form1_0.groupBox_45.SuspendLayout();
      form1_0.groupBox_29.SuspendLayout();
      form1_0.groupBox_28.SuspendLayout();
      form1_0.groupBox_30.SuspendLayout();
      form1_0.groupBox_31.SuspendLayout();
      form1_0.xtraTabPage_7.SuspendLayout();
      form1_0.comboBoxEdit_9.Properties.BeginInit();
      form1_0.groupBox_39.SuspendLayout();
      form1_0.groupBox_40.SuspendLayout();
      form1_0.groupBox_41.SuspendLayout();
      form1_0.groupBox_42.SuspendLayout();
      form1_0.groupBox_32.SuspendLayout();
      form1_0.checkEdit_0.Properties.BeginInit();
      form1_0.xtraTabPage_8.SuspendLayout();
      form1_0.comboBoxEdit_10.Properties.BeginInit();
      form1_0.groupBox_43.SuspendLayout();
      form1_0.xtraTabPage_9.SuspendLayout();
      form1_0.groupBox_46.SuspendLayout();
      form1_0.comboBoxEdit_13.Properties.BeginInit();
      form1_0.comboBoxEdit_12.Properties.BeginInit();
      form1_0.xtraTabPage_5.SuspendLayout();
      form1_0.comboBoxEdit_11.Properties.BeginInit();
      form1_0.groupBox_44.SuspendLayout();
      form1_0.panel_0.SuspendLayout();
      form1_0.groupBox_26.SuspendLayout();
      form1_0.groupBox_27.SuspendLayout();
      form1_0.checkEdit_11.Properties.BeginInit();
      form1_0.checkEdit_1.Properties.BeginInit();
      form1_0.checkEdit_2.Properties.BeginInit();
      form1_0.checkEdit_3.Properties.BeginInit();
      form1_0.checkEdit_4.Properties.BeginInit();
      form1_0.checkEdit_5.Properties.BeginInit();
      form1_0.checkEdit_6.Properties.BeginInit();
      form1_0.checkEdit_7.Properties.BeginInit();
      form1_0.checkEdit_8.Properties.BeginInit();
      form1_0.groupControl_8.BeginInit();
      form1_0.groupControl_8.SuspendLayout();
      ((ISupportInitialize) form1_0.behaviorManager_0).BeginInit();
      form1_0.SuspendLayout();
      form1_0.richTextBox_0.BackColor = Color.FromArgb(38, 38, 38);
      form1_0.richTextBox_0.ForeColor = SystemColors.Info;
      form1_0.richTextBox_0.Location = new Point(2, -3);
      form1_0.richTextBox_0.Name = "richTextBox1";
      form1_0.richTextBox_0.Size = new Size(816, 173);
      form1_0.richTextBox_0.TabIndex = 15;
      form1_0.richTextBox_0.Text = "";
      form1_0.label_0.AutoSize = true;
      form1_0.label_0.Location = new Point(189, 2);
      form1_0.label_0.Name = "label_saat";
      form1_0.label_0.Size = new Size(47, 13);
      form1_0.label_0.TabIndex = 67;
      form1_0.label_0.Text = "label181";
      form1_0.label_0.Visible = false;
      form1_0.label_1.AutoSize = true;
      form1_0.label_1.Location = new Point(138, 2);
      form1_0.label_1.Name = "label_güns";
      form1_0.label_1.Size = new Size(47, 13);
      form1_0.label_1.TabIndex = 68;
      form1_0.label_1.Text = "label181";
      form1_0.label_1.Visible = false;
      form1_0.groupControl_0.Controls.Add((Control) form1_0.label_0);
      form1_0.groupControl_0.Controls.Add((Control) form1_0.label_1);
      form1_0.groupControl_0.Controls.Add((Control) form1_0.panelControl_0);
      form1_0.groupControl_0.Controls.Add((Control) form1_0.groupControl_9);
      form1_0.groupControl_0.Location = new Point(195, 505);
      form1_0.groupControl_0.Name = "groupControl8";
      form1_0.groupControl_0.Size = new Size(815, 193);
      form1_0.groupControl_0.TabIndex = 27;
      form1_0.groupControl_0.Text = "                                                                                                KONSOL";
      form1_0.panelControl_0.Controls.Add((Control) form1_0.richTextBox_0);
      form1_0.panelControl_0.Location = new Point(0, 26);
      form1_0.panelControl_0.Name = "panelControl6";
      form1_0.panelControl_0.Size = new Size(825, 219);
      form1_0.panelControl_0.TabIndex = 7;
      form1_0.groupControl_9.Controls.Add((Control) form1_0.textBox_101);
      form1_0.groupControl_9.Controls.Add((Control) form1_0.panelControl_8);
      form1_0.groupControl_9.Location = new Point(590, -4);
      form1_0.groupControl_9.Name = "groupControl9";
      form1_0.groupControl_9.Size = new Size(120, 18);
      form1_0.groupControl_9.TabIndex = 26;
      form1_0.groupControl_9.Text = "PT NO   |   CHARNAME   |                                     ACIKLAMA";
      form1_0.groupControl_9.Visible = false;
      form1_0.textBox_101.BackColor = Color.RosyBrown;
      form1_0.textBox_101.Enabled = false;
      form1_0.textBox_101.Location = new Point(543, 2);
      form1_0.textBox_101.Name = "textBox62";
      form1_0.textBox_101.Size = new Size(42, 21);
      form1_0.textBox_101.TabIndex = 63;
      form1_0.textBox_101.Text = "0";
      form1_0.textBox_101.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_101.Visible = false;
      form1_0.panelControl_8.Controls.Add((Control) form1_0.listView_0);
      form1_0.panelControl_8.Location = new Point(0, 25);
      form1_0.panelControl_8.Name = "panelControl7";
      form1_0.panelControl_8.Size = new Size(590, 247);
      form1_0.panelControl_8.TabIndex = 7;
      form1_0.listView_0.BackColor = Color.Gray;
      form1_0.listView_0.Columns.AddRange(new ColumnHeader[3]
      {
        form1_0.columnHeader_0,
        form1_0.columnHeader_1,
        form1_0.columnHeader_2
      });
      form1_0.listView_0.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      form1_0.listView_0.ForeColor = Color.Snow;
      form1_0.listView_0.FullRowSelect = true;
      form1_0.listView_0.Location = new Point(0, -25);
      form1_0.listView_0.MultiSelect = false;
      form1_0.listView_0.Name = "listView2";
      form1_0.listView_0.Size = new Size(590, 266);
      form1_0.listView_0.TabIndex = 246;
      form1_0.listView_0.UseCompatibleStateImageBehavior = false;
      form1_0.listView_0.View = View.Details;
      form1_0.columnHeader_0.Text = "PT NO";
      form1_0.columnHeader_0.Width = 61;
      form1_0.columnHeader_1.Text = "CHARNAME";
      form1_0.columnHeader_1.TextAlign = HorizontalAlignment.Center;
      form1_0.columnHeader_1.Width = 104;
      form1_0.columnHeader_2.Text = "PARTY AÇIKLAMA";
      form1_0.columnHeader_2.TextAlign = HorizontalAlignment.Center;
      form1_0.columnHeader_2.Width = 360;
      form1_0.listBox_20.BackColor = Color.Salmon;
      form1_0.listBox_20.FormattingEnabled = true;
      form1_0.listBox_20.Location = new Point(802, 12);
      form1_0.listBox_20.Name = "listBox_pt_listnumara";
      form1_0.listBox_20.Size = new Size(12, 433);
      form1_0.listBox_20.TabIndex = 252;
      form1_0.listBox_20.Visible = false;
      form1_0.groupBox_10.BackColor = Color.Gray;
      form1_0.groupBox_10.Controls.Add((Control) form1_0.label_134);
      form1_0.groupBox_10.Controls.Add((Control) form1_0.label_135);
      form1_0.groupBox_10.Controls.Add((Control) form1_0.listBox_13);
      form1_0.groupBox_10.Controls.Add((Control) form1_0.listBox_14);
      form1_0.groupBox_10.Controls.Add((Control) form1_0.groupBox_11);
      form1_0.groupBox_10.Controls.Add((Control) form1_0.groupBox_12);
      form1_0.groupBox_10.ForeColor = SystemColors.Window;
      form1_0.groupBox_10.Location = new Point(231, 6);
      form1_0.groupBox_10.Name = "groupBox1";
      form1_0.groupBox_10.Size = new Size(584, 441);
      form1_0.groupBox_10.TabIndex = 83;
      form1_0.groupBox_10.TabStop = false;
      form1_0.groupBox_10.Text = "AYARLAR";
      form1_0.label_134.AutoSize = true;
      form1_0.label_134.Location = new Point(208, 128);
      form1_0.label_134.Name = "labelllll13";
      form1_0.label_134.Size = new Size(69, 13);
      form1_0.label_134.TabIndex = 195;
      form1_0.label_134.Text = "İçeride Kalan";
      form1_0.label_135.AutoSize = true;
      form1_0.label_135.Location = new Point(39, 128);
      form1_0.label_135.Name = "label111";
      form1_0.label_135.Size = new Size(86, 13);
      form1_0.label_135.TabIndex = 194;
      form1_0.label_135.Text = "Kayıt Yaptıranlar";
      form1_0.listBox_13.BackColor = Color.Salmon;
      form1_0.listBox_13.FormattingEnabled = true;
      form1_0.listBox_13.Location = new Point(182, 146);
      form1_0.listBox_13.Name = "HayattaKal_listbox_icerde_kalan";
      form1_0.listBox_13.Size = new Size(136, 277);
      form1_0.listBox_13.TabIndex = 193;
      form1_0.listBox_14.BackColor = Color.Salmon;
      form1_0.listBox_14.FormattingEnabled = true;
      form1_0.listBox_14.Location = new Point(15, 148);
      form1_0.listBox_14.Name = "HayattaKal_listbox_kayıtyapanlar";
      form1_0.listBox_14.Size = new Size(146, 277);
      form1_0.listBox_14.TabIndex = 192;
      form1_0.groupBox_11.BackColor = Color.Gray;
      form1_0.groupBox_11.Controls.Add((Control) form1_0.textBox_83);
      form1_0.groupBox_11.Controls.Add((Control) form1_0.label_138);
      form1_0.groupBox_11.Controls.Add((Control) form1_0.textBox_17);
      form1_0.groupBox_11.Controls.Add((Control) form1_0.label_42);
      form1_0.groupBox_11.Controls.Add((Control) form1_0.label_129);
      form1_0.groupBox_11.Controls.Add((Control) form1_0.textBox_78);
      form1_0.groupBox_11.ForeColor = SystemColors.Window;
      form1_0.groupBox_11.Location = new Point(15, 16);
      form1_0.groupBox_11.Name = "groupBox42";
      form1_0.groupBox_11.Size = new Size(303, 104);
      form1_0.groupBox_11.TabIndex = 191;
      form1_0.groupBox_11.TabStop = false;
      form1_0.textBox_83.BackColor = Color.Salmon;
      form1_0.textBox_83.ForeColor = SystemColors.Window;
      form1_0.textBox_83.Location = new Point(133, 73);
      form1_0.textBox_83.Multiline = true;
      form1_0.textBox_83.Name = "HayattaKal_Lvl_Limit";
      form1_0.textBox_83.Size = new Size(54, 20);
      form1_0.textBox_83.TabIndex = 218;
      form1_0.textBox_83.Text = "20";
      form1_0.textBox_83.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_83.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.label_138.AutoSize = true;
      form1_0.label_138.ForeColor = SystemColors.Window;
      form1_0.label_138.Location = new Point(7, 76);
      form1_0.label_138.Name = "label198";
      form1_0.label_138.Size = new Size(120, 13);
      form1_0.label_138.TabIndex = 217;
      form1_0.label_138.Text = "Level sınırı ( alt limit ) = ";
      form1_0.textBox_17.BackColor = Color.Salmon;
      form1_0.textBox_17.ForeColor = SystemColors.Window;
      form1_0.textBox_17.Location = new Point(182, 41);
      form1_0.textBox_17.Multiline = true;
      form1_0.textBox_17.Name = "HayattaKal_MaxKatılımcı";
      form1_0.textBox_17.Size = new Size(54, 20);
      form1_0.textBox_17.TabIndex = 213;
      form1_0.textBox_17.Text = "16";
      form1_0.textBox_17.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_17.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.label_42.AutoSize = true;
      form1_0.label_42.ForeColor = SystemColors.Window;
      form1_0.label_42.Location = new Point(7, 44);
      form1_0.label_42.Name = "label184";
      form1_0.label_42.Size = new Size(168, 13);
      form1_0.label_42.TabIndex = 211;
      form1_0.label_42.Text = "İçeri Alınacak Maximum Katılımcı =";
      form1_0.label_129.AutoSize = true;
      form1_0.label_129.ForeColor = SystemColors.Window;
      form1_0.label_129.Location = new Point(3, 13);
      form1_0.label_129.Name = "label187";
      form1_0.label_129.Size = new Size(233, 13);
      form1_0.label_129.TabIndex = 216;
      form1_0.label_129.Text = "Etkinlik başlaması için gerekli minimum katılımcı =";
      form1_0.textBox_78.BackColor = Color.Salmon;
      form1_0.textBox_78.ForeColor = SystemColors.Window;
      form1_0.textBox_78.Location = new Point(246, 10);
      form1_0.textBox_78.Multiline = true;
      form1_0.textBox_78.Name = "textBox15";
      form1_0.textBox_78.Size = new Size(50, 20);
      form1_0.textBox_78.TabIndex = 214;
      form1_0.textBox_78.Text = "60";
      form1_0.textBox_78.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_78.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.groupBox_12.BackColor = Color.Gray;
      form1_0.groupBox_12.Controls.Add((Control) form1_0.groupBox_13);
      form1_0.groupBox_12.Controls.Add((Control) form1_0.checkBox_6);
      form1_0.groupBox_12.Controls.Add((Control) form1_0.groupBox_14);
      form1_0.groupBox_12.Controls.Add((Control) form1_0.checkBox_7);
      form1_0.groupBox_12.ForeColor = SystemColors.Window;
      form1_0.groupBox_12.Location = new Point(343, 22);
      form1_0.groupBox_12.Name = "groupBox3";
      form1_0.groupBox_12.Size = new Size(230, 401);
      form1_0.groupBox_12.TabIndex = 56;
      form1_0.groupBox_12.TabStop = false;
      form1_0.groupBox_12.Text = "ÖDÜL AYARLARI";
      form1_0.groupBox_13.BackColor = Color.Gray;
      form1_0.groupBox_13.Controls.Add((Control) form1_0.textBox_98);
      form1_0.groupBox_13.Controls.Add((Control) form1_0.label_155);
      form1_0.groupBox_13.Controls.Add((Control) form1_0.label_43);
      form1_0.groupBox_13.Controls.Add((Control) form1_0.label_44);
      form1_0.groupBox_13.Controls.Add((Control) form1_0.label_45);
      form1_0.groupBox_13.Controls.Add((Control) form1_0.textBox_18);
      form1_0.groupBox_13.Controls.Add((Control) form1_0.textBox_19);
      form1_0.groupBox_13.Controls.Add((Control) form1_0.textBox_20);
      form1_0.groupBox_13.Enabled = false;
      form1_0.groupBox_13.ForeColor = SystemColors.Window;
      form1_0.groupBox_13.Location = new Point(4, 33);
      form1_0.groupBox_13.Name = "groupBox4";
      form1_0.groupBox_13.Size = new Size(220, 167);
      form1_0.groupBox_13.TabIndex = 9;
      form1_0.groupBox_13.TabStop = false;
      form1_0.groupBox_13.Text = "ITEM";
      form1_0.textBox_98.BackColor = Color.Salmon;
      form1_0.textBox_98.Location = new Point(26, 129);
      form1_0.textBox_98.Name = "textBox58";
      form1_0.textBox_98.Size = new Size(174, 21);
      form1_0.textBox_98.TabIndex = 56;
      form1_0.textBox_98.Text = "Sun Sword ( 1 Dg )";
      form1_0.textBox_98.TextAlign = HorizontalAlignment.Center;
      form1_0.label_155.AutoSize = true;
      form1_0.label_155.Location = new Point(84, 115);
      form1_0.label_155.Name = "label89";
      form1_0.label_155.Size = new Size(56, 13);
      form1_0.label_155.TabIndex = 55;
      form1_0.label_155.Text = "ITEM İSMİ";
      form1_0.label_43.AutoSize = true;
      form1_0.label_43.Location = new Point(155, 72);
      form1_0.label_43.Name = "label76";
      form1_0.label_43.Size = new Size(31, 13);
      form1_0.label_43.TabIndex = 41;
      form1_0.label_43.Text = "PLUS";
      form1_0.label_44.AutoSize = true;
      form1_0.label_44.Location = new Point(52, 71);
      form1_0.label_44.Name = "label77";
      form1_0.label_44.Size = new Size(33, 13);
      form1_0.label_44.TabIndex = 40;
      form1_0.label_44.Text = "ADET";
      form1_0.label_45.AutoSize = true;
      form1_0.label_45.Location = new Point(79, 14);
      form1_0.label_45.Name = "label88";
      form1_0.label_45.Size = new Size(62, 13);
      form1_0.label_45.TabIndex = 39;
      form1_0.label_45.Text = "ITEM KODU";
      form1_0.textBox_18.BackColor = Color.Salmon;
      form1_0.textBox_18.Location = new Point(135, 88);
      form1_0.textBox_18.Name = "textBox55";
      form1_0.textBox_18.Size = new Size(65, 21);
      form1_0.textBox_18.TabIndex = 8;
      form1_0.textBox_18.Text = "1";
      form1_0.textBox_18.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_18.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_19.BackColor = Color.Salmon;
      form1_0.textBox_19.Location = new Point(26, 88);
      form1_0.textBox_19.Name = "textBox56";
      form1_0.textBox_19.Size = new Size(74, 21);
      form1_0.textBox_19.TabIndex = 7;
      form1_0.textBox_19.Text = "1";
      form1_0.textBox_19.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_19.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_20.BackColor = Color.Salmon;
      form1_0.textBox_20.Location = new Point(26, 30);
      form1_0.textBox_20.Name = "textBox57";
      form1_0.textBox_20.Size = new Size(174, 21);
      form1_0.textBox_20.TabIndex = 4;
      form1_0.textBox_20.Text = "ITEM_CH_SWORD_01_C_RARE";
      form1_0.textBox_20.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_20.TextChanged += new EventHandler(form1_0.method_28);
      form1_0.checkBox_6.AutoSize = true;
      form1_0.checkBox_6.Location = new Point(7, 206);
      form1_0.checkBox_6.Name = "HayattaKal_ÖdülTİpi_SGSR";
      form1_0.checkBox_6.Size = new Size(15, 14);
      form1_0.checkBox_6.TabIndex = 10;
      form1_0.checkBox_6.UseVisualStyleBackColor = true;
      form1_0.checkBox_6.CheckedChanged += new EventHandler(form1_0.method_30);
      form1_0.groupBox_14.BackColor = Color.Gray;
      form1_0.groupBox_14.Controls.Add((Control) form1_0.label_46);
      form1_0.groupBox_14.Controls.Add((Control) form1_0.label_47);
      form1_0.groupBox_14.Controls.Add((Control) form1_0.label_48);
      form1_0.groupBox_14.Controls.Add((Control) form1_0.textBox_21);
      form1_0.groupBox_14.Controls.Add((Control) form1_0.textBox_22);
      form1_0.groupBox_14.Controls.Add((Control) form1_0.textBox_23);
      form1_0.groupBox_14.Enabled = false;
      form1_0.groupBox_14.ForeColor = SystemColors.Window;
      form1_0.groupBox_14.Location = new Point(7, 226);
      form1_0.groupBox_14.Name = "groupBox22";
      form1_0.groupBox_14.Size = new Size(217, 164);
      form1_0.groupBox_14.TabIndex = 10;
      form1_0.groupBox_14.TabStop = false;
      form1_0.groupBox_14.Text = "SİLK- GOLD - SP";
      form1_0.label_46.AutoSize = true;
      form1_0.label_46.Location = new Point(98, 116);
      form1_0.label_46.Name = "label90";
      form1_0.label_46.Size = new Size(53, 13);
      form1_0.label_46.TabIndex = 38;
      form1_0.label_46.Text = "SP Miktarı";
      form1_0.label_47.AutoSize = true;
      form1_0.label_47.Location = new Point(82, 66);
      form1_0.label_47.Name = "label91";
      form1_0.label_47.Size = new Size(62, 13);
      form1_0.label_47.TabIndex = 37;
      form1_0.label_47.Text = "Gold Miktari";
      form1_0.label_48.AutoSize = true;
      form1_0.label_48.Location = new Point(88, 17);
      form1_0.label_48.Name = "label95";
      form1_0.label_48.Size = new Size(56, 13);
      form1_0.label_48.TabIndex = 36;
      form1_0.label_48.Text = "Silk Miktarı";
      form1_0.textBox_21.BackColor = Color.Salmon;
      form1_0.textBox_21.Location = new Point(52, 80);
      form1_0.textBox_21.MaxLength = 19;
      form1_0.textBox_21.Name = "textBox59";
      form1_0.textBox_21.Size = new Size(131, 21);
      form1_0.textBox_21.TabIndex = 6;
      form1_0.textBox_21.Text = "0";
      form1_0.textBox_21.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_21.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_22.BackColor = Color.Salmon;
      form1_0.textBox_22.Location = new Point(70, 132);
      form1_0.textBox_22.MaxLength = 19;
      form1_0.textBox_22.Name = "textBox60";
      form1_0.textBox_22.Size = new Size(97, 21);
      form1_0.textBox_22.TabIndex = 5;
      form1_0.textBox_22.Text = "0";
      form1_0.textBox_22.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_22.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_23.BackColor = Color.Salmon;
      form1_0.textBox_23.Location = new Point(82, 32);
      form1_0.textBox_23.MaxLength = 19;
      form1_0.textBox_23.Name = "textBox61";
      form1_0.textBox_23.Size = new Size(71, 21);
      form1_0.textBox_23.TabIndex = 4;
      form1_0.textBox_23.Text = "0";
      form1_0.textBox_23.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_23.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.checkBox_7.AutoSize = true;
      form1_0.checkBox_7.Location = new Point(7, 16);
      form1_0.checkBox_7.Name = "HayattaKal_ÖdülTİpi_ITEM";
      form1_0.checkBox_7.Size = new Size(15, 14);
      form1_0.checkBox_7.TabIndex = 9;
      form1_0.checkBox_7.UseVisualStyleBackColor = true;
      form1_0.checkBox_7.CheckedChanged += new EventHandler(form1_0.method_29);
      form1_0.timer_0.Interval = 1000;
      form1_0.timer_0.Tick += new EventHandler(form1_0.method_23);
      form1_0.panelControl_1.Controls.Add((Control) form1_0.groupControl_1);
      form1_0.panelControl_1.Controls.Add((Control) form1_0.labelControl_3);
      form1_0.panelControl_1.Controls.Add((Control) form1_0.textEdit_3);
      form1_0.panelControl_1.Controls.Add((Control) form1_0.textEdit_4);
      form1_0.panelControl_1.Controls.Add((Control) form1_0.labelControl_4);
      form1_0.panelControl_1.Controls.Add((Control) form1_0.textEdit_5);
      form1_0.panelControl_1.Controls.Add((Control) form1_0.labelControl_5);
      form1_0.panelControl_1.Dock = DockStyle.Top;
      form1_0.panelControl_1.Location = new Point(2, 22);
      form1_0.panelControl_1.Name = "panelControl5";
      form1_0.panelControl_1.Size = new Size(197, 275);
      form1_0.panelControl_1.TabIndex = 7;
      form1_0.groupControl_1.Controls.Add((Control) form1_0.textEdit_0);
      form1_0.groupControl_1.Controls.Add((Control) form1_0.simpleButton_0);
      form1_0.groupControl_1.Controls.Add((Control) form1_0.label_2);
      form1_0.groupControl_1.Controls.Add((Control) form1_0.textEdit_1);
      form1_0.groupControl_1.Controls.Add((Control) form1_0.textEdit_2);
      form1_0.groupControl_1.Controls.Add((Control) form1_0.labelControl_0);
      form1_0.groupControl_1.Controls.Add((Control) form1_0.labelControl_1);
      form1_0.groupControl_1.Controls.Add((Control) form1_0.labelControl_2);
      form1_0.groupControl_1.Location = new Point(25, 112);
      form1_0.groupControl_1.Name = "groupControl7";
      form1_0.groupControl_1.Size = new Size(212, 176);
      form1_0.groupControl_1.TabIndex = 118;
      form1_0.groupControl_1.Text = "           SQL BAĞLANTI";
      form1_0.textEdit_0.EditValue = (object) ".\\SQLEXPRESS";
      form1_0.textEdit_0.Location = new Point(43, 36);
      form1_0.textEdit_0.Name = "text_host";
      form1_0.textEdit_0.Properties.Mask.EditMask = componentResourceManager.GetString("text_host.Properties.Mask.EditMask");
      form1_0.textEdit_0.Size = new Size(156, 20);
      form1_0.textEdit_0.TabIndex = 119;
      form1_0.simpleButton_0.Location = new Point(63, (int) sbyte.MaxValue);
      form1_0.simpleButton_0.Name = "simpleButton1";
      form1_0.simpleButton_0.Size = new Size(84, 23);
      form1_0.simpleButton_0.TabIndex = 118;
      form1_0.simpleButton_0.Text = "Bağlan";
      form1_0.label_2.AutoSize = true;
      form1_0.label_2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      form1_0.label_2.Location = new Point(7, 549);
      form1_0.label_2.Name = "label62";
      form1_0.label_2.Size = new Size(36, 15);
      form1_0.label_2.TabIndex = 46;
      form1_0.label_2.Text = "tarih";
      form1_0.textEdit_1.EditValue = (object) "12345";
      form1_0.textEdit_1.Location = new Point(40, 91);
      form1_0.textEdit_1.Name = "text_passw";
      form1_0.textEdit_1.Properties.Mask.EditMask = componentResourceManager.GetString("text_passw.Properties.Mask.EditMask");
      form1_0.textEdit_1.Size = new Size(159, 20);
      form1_0.textEdit_1.TabIndex = 112;
      form1_0.textEdit_2.EditValue = (object) "sa";
      form1_0.textEdit_2.Location = new Point(43, 65);
      form1_0.textEdit_2.Name = "text_user";
      form1_0.textEdit_2.Properties.Mask.EditMask = componentResourceManager.GetString("text_user.Properties.Mask.EditMask");
      form1_0.textEdit_2.Size = new Size(156, 20);
      form1_0.textEdit_2.TabIndex = 111;
      form1_0.labelControl_0.Location = new Point(5, 94);
      form1_0.labelControl_0.Name = "labelControl10";
      form1_0.labelControl_0.Size = new Size(29, 13);
      form1_0.labelControl_0.TabIndex = 3;
      form1_0.labelControl_0.Text = "PASS:";
      form1_0.labelControl_1.Location = new Point(6, 66);
      form1_0.labelControl_1.Name = "labelControl11";
      form1_0.labelControl_1.Size = new Size(30, 13);
      form1_0.labelControl_1.TabIndex = 2;
      form1_0.labelControl_1.Text = "USER:";
      form1_0.labelControl_2.Location = new Point(6, 41);
      form1_0.labelControl_2.Name = "labelControl12";
      form1_0.labelControl_2.Size = new Size(31, 13);
      form1_0.labelControl_2.TabIndex = 1;
      form1_0.labelControl_2.Text = "HOST:";
      form1_0.labelControl_3.Location = new Point(104, 46);
      form1_0.labelControl_3.Name = "labelControl3";
      form1_0.labelControl_3.Size = new Size(44, 13);
      form1_0.labelControl_3.TabIndex = 8;
      form1_0.labelControl_3.Text = "Captcha:";
      form1_0.textEdit_3.Location = new Point(153, 43);
      form1_0.textEdit_3.Name = "textEdit13";
      form1_0.textEdit_3.Properties.Mask.EditMask = "(102[4-9]|10[3-9]\\d|1[1-9]\\d{2}|[2-9]\\d{3}|[1-5]\\d{4}|6[0-4]\\d{3}|65[0-4]\\d{2}|655[0-2]\\d|6553[0-5])";
      form1_0.textEdit_3.Size = new Size(38, 20);
      form1_0.textEdit_3.TabIndex = 103;
      form1_0.textEdit_4.Location = new Point(43, 8);
      form1_0.textEdit_4.Name = "textEdit14";
      form1_0.textEdit_4.Properties.Mask.EditMask = componentResourceManager.GetString("textEdit14.Properties.Mask.EditMask");
      form1_0.textEdit_4.Properties.Mask.MaskType = MaskType.RegEx;
      form1_0.textEdit_4.Size = new Size(148, 20);
      form1_0.textEdit_4.TabIndex = 101;
      form1_0.labelControl_4.Location = new Point(21, 11);
      form1_0.labelControl_4.Name = "labelControl1";
      form1_0.labelControl_4.Size = new Size(17, 13);
      form1_0.labelControl_4.TabIndex = 0;
      form1_0.labelControl_4.Text = "IP :";
      form1_0.textEdit_5.Location = new Point(43, 43);
      form1_0.textEdit_5.Name = "textEdit15";
      form1_0.textEdit_5.Properties.Mask.EditMask = "(102[4-9]|10[3-9]\\d|1[1-9]\\d{2}|[2-9]\\d{3}|[1-5]\\d{4}|6[0-4]\\d{3}|65[0-4]\\d{2}|655[0-2]\\d|6553[0-5])";
      form1_0.textEdit_5.Properties.Mask.MaskType = MaskType.RegEx;
      form1_0.textEdit_5.Size = new Size(54, 20);
      form1_0.textEdit_5.TabIndex = 102;
      form1_0.labelControl_5.Location = new Point(11, 46);
      form1_0.labelControl_5.Name = "labelControl2";
      form1_0.labelControl_5.Size = new Size(27, 13);
      form1_0.labelControl_5.TabIndex = 1;
      form1_0.labelControl_5.Text = "Port :";
      form1_0.groupControl_2.Controls.Add((Control) form1_0.labelControl_6);
      form1_0.groupControl_2.Controls.Add((Control) form1_0.labelControl_7);
      form1_0.groupControl_2.Controls.Add((Control) form1_0.label_3);
      form1_0.groupControl_2.Controls.Add((Control) form1_0.label_4);
      form1_0.groupControl_2.Controls.Add((Control) form1_0.label_5);
      form1_0.groupControl_2.Controls.Add((Control) form1_0.button_0);
      form1_0.groupControl_2.Controls.Add((Control) form1_0.button_1);
      form1_0.groupControl_2.Controls.Add((Control) form1_0.simpleButton_1);
      form1_0.groupControl_2.Controls.Add((Control) form1_0.textEdit_6);
      form1_0.groupControl_2.Controls.Add((Control) form1_0.textEdit_7);
      form1_0.groupControl_2.Controls.Add((Control) form1_0.textEdit_8);
      form1_0.groupControl_2.Controls.Add((Control) form1_0.labelControl_8);
      form1_0.groupControl_2.Controls.Add((Control) form1_0.labelControl_9);
      form1_0.groupControl_2.Controls.Add((Control) form1_0.labelControl_10);
      form1_0.groupControl_2.Dock = DockStyle.Top;
      form1_0.groupControl_2.Location = new Point(2, 297);
      form1_0.groupControl_2.Name = "groupControl6";
      form1_0.groupControl_2.Size = new Size(197, 576);
      form1_0.groupControl_2.TabIndex = 0;
      form1_0.groupControl_2.Text = "           Bot Karakter Giriş";
      form1_0.labelControl_6.Location = new Point(79, 256);
      form1_0.labelControl_6.Name = "labelThread";
      form1_0.labelControl_6.Size = new Size(6, 13);
      form1_0.labelControl_6.TabIndex = 117;
      form1_0.labelControl_6.Text = "0";
      form1_0.labelControl_7.Location = new Point(29, 256);
      form1_0.labelControl_7.Name = "labelControl7";
      form1_0.labelControl_7.Size = new Size(44, 13);
      form1_0.labelControl_7.TabIndex = 115;
      form1_0.labelControl_7.Text = "Thread : ";
      form1_0.label_3.AutoSize = true;
      form1_0.label_3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      form1_0.label_3.Location = new Point(9, 549);
      form1_0.label_3.Name = "label_tarih_sonuc";
      form1_0.label_3.Size = new Size(36, 15);
      form1_0.label_3.TabIndex = 46;
      form1_0.label_3.Text = "tarih";
      form1_0.label_4.AutoSize = true;
      form1_0.label_4.Location = new Point(152, 17);
      form1_0.label_4.Name = "label_gün";
      form1_0.label_4.Size = new Size(25, 13);
      form1_0.label_4.TabIndex = 45;
      form1_0.label_4.Text = "gün";
      form1_0.label_4.Visible = false;
      form1_0.label_5.AutoSize = true;
      form1_0.label_5.Location = new Point(119, 17);
      form1_0.label_5.Name = "label_saa";
      form1_0.label_5.Size = new Size(29, 13);
      form1_0.label_5.TabIndex = 44;
      form1_0.label_5.Text = "tarih";
      form1_0.label_5.Visible = false;
      form1_0.button_0.Location = new Point(61, 159);
      form1_0.button_0.Name = "button8";
      form1_0.button_0.Size = new Size(86, 34);
      form1_0.button_0.TabIndex = 114;
      form1_0.button_0.Text = "button8";
      form1_0.button_0.UseVisualStyleBackColor = true;
      form1_0.button_1.BackColor = Color.Red;
      form1_0.button_1.Location = new Point(119, 130);
      form1_0.button_1.Name = "button9";
      form1_0.button_1.Size = new Size(88, 23);
      form1_0.button_1.TabIndex = 1;
      form1_0.button_1.Text = "button9";
      form1_0.button_1.UseVisualStyleBackColor = false;
      form1_0.simpleButton_1.Location = new Point(10, 130);
      form1_0.simpleButton_1.Name = "simpleButton2";
      form1_0.simpleButton_1.Size = new Size(84, 23);
      form1_0.simpleButton_1.TabIndex = 113;
      form1_0.simpleButton_1.Text = "Kullan";
      form1_0.textEdit_6.EditValue = (object) "EVENTBOT";
      form1_0.textEdit_6.Location = new Point(76, 89);
      form1_0.textEdit_6.Name = "textEdit10";
      form1_0.textEdit_6.Properties.Mask.EditMask = componentResourceManager.GetString("textEdit10.Properties.Mask.EditMask");
      form1_0.textEdit_6.Size = new Size(110, 20);
      form1_0.textEdit_6.TabIndex = 112;
      form1_0.textEdit_7.EditValue = (object) "1";
      form1_0.textEdit_7.Location = new Point(51, 63);
      form1_0.textEdit_7.Name = "textEdit11";
      form1_0.textEdit_7.Properties.Mask.EditMask = componentResourceManager.GetString("textEdit11.Properties.Mask.EditMask");
      form1_0.textEdit_7.Size = new Size(135, 20);
      form1_0.textEdit_7.TabIndex = 111;
      form1_0.textEdit_8.EditValue = (object) "1";
      form1_0.textEdit_8.Location = new Point(51, 37);
      form1_0.textEdit_8.Name = "textEdit12";
      form1_0.textEdit_8.Properties.CharacterCasing = CharacterCasing.Lower;
      form1_0.textEdit_8.Size = new Size(135, 20);
      form1_0.textEdit_8.TabIndex = 110;
      form1_0.labelControl_8.Location = new Point(14, 92);
      form1_0.labelControl_8.Name = "labelControl6";
      form1_0.labelControl_8.Size = new Size(57, 13);
      form1_0.labelControl_8.TabIndex = 3;
      form1_0.labelControl_8.Text = "CharName :";
      form1_0.labelControl_9.Location = new Point(19, 66);
      form1_0.labelControl_9.Name = "labelControl5";
      form1_0.labelControl_9.Size = new Size(23, 13);
      form1_0.labelControl_9.TabIndex = 2;
      form1_0.labelControl_9.Text = "PW :";
      form1_0.labelControl_10.Location = new Point(28, 40);
      form1_0.labelControl_10.Name = "labelControl4";
      form1_0.labelControl_10.Size = new Size(18, 13);
      form1_0.labelControl_10.TabIndex = 1;
      form1_0.labelControl_10.Text = "ID :";
      form1_0.groupControl_3.Appearance.BackColor = Color.Salmon;
      form1_0.groupControl_3.Appearance.BackColor2 = Color.DarkGoldenrod;
      form1_0.groupControl_3.Appearance.BorderColor = Color.Cyan;
      form1_0.groupControl_3.Appearance.Options.UseBackColor = true;
      form1_0.groupControl_3.Appearance.Options.UseBorderColor = true;
      form1_0.groupControl_3.AppearanceCaption.BackColor = Color.Cyan;
      form1_0.groupControl_3.AppearanceCaption.Options.UseBackColor = true;
      form1_0.groupControl_3.Controls.Add((Control) form1_0.groupControl_4);
      form1_0.groupControl_3.Controls.Add((Control) form1_0.panel_1);
      form1_0.groupControl_3.Controls.Add((Control) form1_0.panelControl_3);
      form1_0.groupControl_3.Location = new Point(0, 0);
      form1_0.groupControl_3.Name = "groupControl2";
      form1_0.groupControl_3.Size = new Size(194, 736);
      form1_0.groupControl_3.TabIndex = 22;
      form1_0.groupControl_3.Text = "                 MENÜ";
      form1_0.groupControl_4.Controls.Add((Control) form1_0.panelControl_2);
      form1_0.groupControl_4.Location = new Point(2, 296);
      form1_0.groupControl_4.Name = "groupControl4";
      form1_0.groupControl_4.Size = new Size(244, 110);
      form1_0.groupControl_4.TabIndex = 25;
      form1_0.groupControl_4.Text = "        KARAKTER GİRİŞ";
      form1_0.panelControl_2.Controls.Add((Control) form1_0.textEdit_15);
      form1_0.panelControl_2.Controls.Add((Control) form1_0.textEdit_16);
      form1_0.panelControl_2.Controls.Add((Control) form1_0.label_159);
      form1_0.panelControl_2.Controls.Add((Control) form1_0.label_6);
      form1_0.panelControl_2.Controls.Add((Control) form1_0.label_7);
      form1_0.panelControl_2.Controls.Add((Control) form1_0.textEdit_18);
      form1_0.panelControl_2.Location = new Point(0, 24);
      form1_0.panelControl_2.Name = "panelControl3";
      form1_0.panelControl_2.Size = new Size(194, 110);
      form1_0.panelControl_2.TabIndex = 7;
      form1_0.textEdit_15.EditValue = (object) "1";
      form1_0.textEdit_15.Location = new Point(45, 33);
      form1_0.textEdit_15.Name = "text_CHARPW";
      form1_0.textEdit_15.Properties.PasswordChar = '•';
      form1_0.textEdit_15.Size = new Size(142, 20);
      form1_0.textEdit_15.TabIndex = 241;
      form1_0.textEdit_16.EditValue = (object) "1";
      form1_0.textEdit_16.Location = new Point(45, 7);
      form1_0.textEdit_16.Name = "text_CHARID";
      form1_0.textEdit_16.Size = new Size(142, 20);
      form1_0.textEdit_16.TabIndex = 240;
      form1_0.label_159.AutoSize = true;
      form1_0.label_159.BackColor = Color.Transparent;
      form1_0.label_159.ForeColor = Color.Salmon;
      form1_0.label_159.Location = new Point(1, 62);
      form1_0.label_159.Name = "label13";
      form1_0.label_159.Size = new Size(67, 13);
      form1_0.label_159.TabIndex = 34;
      form1_0.label_159.Text = "CHARNAME:";
      form1_0.label_6.AutoSize = true;
      form1_0.label_6.BackColor = Color.Transparent;
      form1_0.label_6.ForeColor = Color.Salmon;
      form1_0.label_6.Location = new Point(11, 10);
      form1_0.label_6.Name = "label14";
      form1_0.label_6.Size = new Size(25, 13);
      form1_0.label_6.TabIndex = 29;
      form1_0.label_6.Text = "ID :";
      form1_0.label_7.AutoSize = true;
      form1_0.label_7.BackColor = Color.Transparent;
      form1_0.label_7.ForeColor = Color.Salmon;
      form1_0.label_7.Location = new Point(7, 36);
      form1_0.label_7.Name = "label15";
      form1_0.label_7.Size = new Size(30, 13);
      form1_0.label_7.TabIndex = 33;
      form1_0.label_7.Text = "PW :";
      form1_0.textEdit_18.EditValue = (object) "My_EventBot";
      form1_0.textEdit_18.Location = new Point(74, 59);
      form1_0.textEdit_18.Name = "text_CHARNAME";
      form1_0.textEdit_18.Size = new Size(112, 20);
      form1_0.textEdit_18.TabIndex = 242;
      form1_0.panel_1.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.panel_1.BackgroundImage = (Image) componentResourceManager.GetObject("panel2.BackgroundImage");
      form1_0.panel_1.BackgroundImageLayout = ImageLayout.Stretch;
      form1_0.panel_1.Location = new Point(1, 23);
      form1_0.panel_1.Name = "panel2";
      form1_0.panel_1.Size = new Size(192, 174);
      form1_0.panel_1.TabIndex = 238;
      form1_0.panel_1.MouseMove += new MouseEventHandler(form1_0.method_81);
      form1_0.panelControl_3.Controls.Add((Control) form1_0.panelControl_7);
      form1_0.panelControl_3.Controls.Add((Control) form1_0.textBox_86);
      form1_0.panelControl_3.Controls.Add((Control) form1_0.button_23);
      form1_0.panelControl_3.Controls.Add((Control) form1_0.groupControl_5);
      form1_0.panelControl_3.Controls.Add((Control) form1_0.groupControl_6);
      form1_0.panelControl_3.Controls.Add((Control) form1_0.button_19);
      form1_0.panelControl_3.Controls.Add((Control) form1_0.button_2);
      form1_0.panelControl_3.Controls.Add((Control) form1_0.groupControl_7);
      form1_0.panelControl_3.Location = new Point(2, 22);
      form1_0.panelControl_3.Name = "panelControl1";
      form1_0.panelControl_3.Size = new Size(194, 714);
      form1_0.panelControl_3.TabIndex = 7;
      form1_0.panelControl_7.Controls.Add((Control) form1_0.textEdit_13);
      form1_0.panelControl_7.Controls.Add((Control) form1_0.textEdit_14);
      form1_0.panelControl_7.Controls.Add((Control) form1_0.label_19);
      form1_0.panelControl_7.Controls.Add((Control) form1_0.label_9);
      form1_0.panelControl_7.Controls.Add((Control) form1_0.textEdit_12);
      form1_0.panelControl_7.Controls.Add((Control) form1_0.label_18);
      form1_0.panelControl_7.Controls.Add((Control) form1_0.label_10);
      form1_0.panelControl_7.Controls.Add((Control) form1_0.label_17);
      form1_0.panelControl_7.Controls.Add((Control) form1_0.textEdit_9);
      form1_0.panelControl_7.Controls.Add((Control) form1_0.textEdit_11);
      form1_0.panelControl_7.Controls.Add((Control) form1_0.label_11);
      form1_0.panelControl_7.Controls.Add((Control) form1_0.textEdit_10);
      form1_0.panelControl_7.Location = new Point(-3, 0);
      form1_0.panelControl_7.Name = "panelControl9";
      form1_0.panelControl_7.Size = new Size(197, 174);
      form1_0.panelControl_7.TabIndex = 67;
      form1_0.panelControl_7.MouseLeave += new EventHandler(form1_0.method_80);
      form1_0.panelControl_7.MouseMove += new MouseEventHandler(form1_0.method_79);
      form1_0.textEdit_13.EditValue = (object) "CRU3L\\SQLEXPRESS";
      form1_0.textEdit_13.Location = new Point(46, 7);
      form1_0.textEdit_13.Name = "textEdit1";
      form1_0.textEdit_13.Size = new Size(124, 20);
      form1_0.textEdit_13.TabIndex = 23;
      form1_0.textEdit_14.EditValue = (object) "sa";
      form1_0.textEdit_14.Location = new Point(46, 33);
      form1_0.textEdit_14.Name = "textEdit2";
      form1_0.textEdit_14.Size = new Size(124, 20);
      form1_0.textEdit_14.TabIndex = 25;
      form1_0.label_19.AutoSize = true;
      form1_0.label_19.BackColor = Color.Transparent;
      form1_0.label_19.ForeColor = Color.Salmon;
      form1_0.label_19.Location = new Point(4, 36);
      form1_0.label_19.Name = "label8";
      form1_0.label_19.Size = new Size(37, 13);
      form1_0.label_19.TabIndex = 27;
      form1_0.label_19.Text = "USER:";
      form1_0.label_9.AutoSize = true;
      form1_0.label_9.BackColor = Color.Transparent;
      form1_0.label_9.ForeColor = Color.Salmon;
      form1_0.label_9.Location = new Point(8, 141);
      form1_0.label_9.Name = "label156";
      form1_0.label_9.Size = new Size(31, 13);
      form1_0.label_9.TabIndex = 68;
      form1_0.label_9.Text = "LOG:";
      form1_0.textEdit_12.EditValue = (object) "12345";
      form1_0.textEdit_12.Location = new Point(46, 59);
      form1_0.textEdit_12.Name = "textEdit3";
      form1_0.textEdit_12.Size = new Size(124, 20);
      form1_0.textEdit_12.TabIndex = 26;
      form1_0.label_18.AutoSize = true;
      form1_0.label_18.BackColor = Color.Transparent;
      form1_0.label_18.ForeColor = Color.Salmon;
      form1_0.label_18.Location = new Point(4, 10);
      form1_0.label_18.Name = "label7";
      form1_0.label_18.Size = new Size(38, 13);
      form1_0.label_18.TabIndex = 23;
      form1_0.label_18.Text = "HOST:";
      form1_0.label_10.AutoSize = true;
      form1_0.label_10.BackColor = Color.Transparent;
      form1_0.label_10.ForeColor = Color.Salmon;
      form1_0.label_10.Location = new Point(7, 115);
      form1_0.label_10.Name = "label155";
      form1_0.label_10.Size = new Size(32, 13);
      form1_0.label_10.TabIndex = 68;
      form1_0.label_10.Text = "ACC:";
      form1_0.label_17.AutoSize = true;
      form1_0.label_17.BackColor = Color.Transparent;
      form1_0.label_17.ForeColor = Color.Salmon;
      form1_0.label_17.Location = new Point(4, 62);
      form1_0.label_17.Name = "label9";
      form1_0.label_17.Size = new Size(36, 13);
      form1_0.label_17.TabIndex = 28;
      form1_0.label_17.Text = "PASS:";
      form1_0.textEdit_9.EditValue = (object) "SRO_VT_LOG";
      form1_0.textEdit_9.Location = new Point(46, 134);
      form1_0.textEdit_9.Name = "textEdit18";
      form1_0.textEdit_9.Size = new Size(124, 20);
      form1_0.textEdit_9.TabIndex = 67;
      form1_0.textEdit_11.EditValue = (object) "SRO_VT_SHARD";
      form1_0.textEdit_11.Location = new Point(46, 85);
      form1_0.textEdit_11.Name = "textEdit16";
      form1_0.textEdit_11.Size = new Size(124, 20);
      form1_0.textEdit_11.TabIndex = 67;
      form1_0.label_11.AutoSize = true;
      form1_0.label_11.BackColor = Color.Transparent;
      form1_0.label_11.ForeColor = Color.Salmon;
      form1_0.label_11.Location = new Point(-1, 88);
      form1_0.label_11.Name = "label154";
      form1_0.label_11.Size = new Size(45, 13);
      form1_0.label_11.TabIndex = 68;
      form1_0.label_11.Text = "SHARD:";
      form1_0.textEdit_10.EditValue = (object) "SRO_VT_ACCOUNT";
      form1_0.textEdit_10.Location = new Point(45, 108);
      form1_0.textEdit_10.Name = "textEdit17";
      form1_0.textEdit_10.Size = new Size(124, 20);
      form1_0.textEdit_10.TabIndex = 67;
      form1_0.textBox_86.BackColor = Color.DimGray;
      form1_0.textBox_86.BorderStyle = BorderStyle.FixedSingle;
      form1_0.textBox_86.ForeColor = Color.Snow;
      form1_0.textBox_86.Location = new Point(0, 653);
      form1_0.textBox_86.Multiline = true;
      form1_0.textBox_86.Name = "textBox73";
      form1_0.textBox_86.Size = new Size(191, 20);
      form1_0.textBox_86.TabIndex = 210;
      form1_0.textBox_86.Text = "T A R I H";
      form1_0.textBox_86.TextAlign = HorizontalAlignment.Center;
      form1_0.button_23.BackColor = Color.Transparent;
      form1_0.button_23.FlatStyle = FlatStyle.Flat;
      form1_0.button_23.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 162);
      form1_0.button_23.ForeColor = Color.Salmon;
      form1_0.button_23.Location = new Point(-3, 621);
      form1_0.button_23.Name = "button5";
      form1_0.button_23.Size = new Size(198, 26);
      form1_0.button_23.TabIndex = 67;
      form1_0.button_23.Text = "R E H B E R";
      form1_0.button_23.UseVisualStyleBackColor = false;
      form1_0.button_23.Click += new EventHandler(form1_0.method_74);
      form1_0.button_23.MouseEnter += new EventHandler(form1_0.method_77);
      form1_0.button_23.MouseLeave += new EventHandler(form1_0.method_78);
      form1_0.groupControl_5.Controls.Add((Control) form1_0.panelControl_4);
      form1_0.groupControl_5.Controls.Add((Control) form1_0.checkEdit_9);
      form1_0.groupControl_5.Location = new Point(0, 382);
      form1_0.groupControl_5.Name = "groupControl10";
      form1_0.groupControl_5.Size = new Size(197, 91);
      form1_0.groupControl_5.TabIndex = 26;
      form1_0.groupControl_5.Text = "                GENEL";
      form1_0.panelControl_4.Controls.Add((Control) form1_0.label_161);
      form1_0.panelControl_4.Controls.Add((Control) form1_0.label_162);
      form1_0.panelControl_4.Controls.Add((Control) form1_0.label_163);
      form1_0.panelControl_4.Controls.Add((Control) form1_0.label_164);
      form1_0.panelControl_4.Controls.Add((Control) form1_0.label_160);
      form1_0.panelControl_4.Controls.Add((Control) form1_0.label_158);
      form1_0.panelControl_4.Location = new Point(0, 26);
      form1_0.panelControl_4.Name = "panelControl8";
      form1_0.panelControl_4.Size = new Size(194, 96);
      form1_0.panelControl_4.TabIndex = 7;
      form1_0.label_161.AutoSize = true;
      form1_0.label_161.BackColor = Color.Transparent;
      form1_0.label_161.ForeColor = Color.Salmon;
      form1_0.label_161.Location = new Point(94, 52);
      form1_0.label_161.Name = "label_agent";
      form1_0.label_161.Size = new Size(49, 13);
      form1_0.label_161.TabIndex = 253;
      form1_0.label_161.Text = "OFFLİNE";
      form1_0.label_162.AutoSize = true;
      form1_0.label_162.BackColor = Color.Transparent;
      form1_0.label_162.ForeColor = Color.Snow;
      form1_0.label_162.Location = new Point(36, 52);
      form1_0.label_162.Name = "label39";
      form1_0.label_162.Size = new Size(47, 13);
      form1_0.label_162.TabIndex = 252;
      form1_0.label_162.Text = "AGENT :";
      form1_0.label_163.AutoSize = true;
      form1_0.label_163.BackColor = Color.Transparent;
      form1_0.label_163.ForeColor = Color.Salmon;
      form1_0.label_163.Location = new Point(94, 32);
      form1_0.label_163.Name = "label_gatwy";
      form1_0.label_163.Size = new Size(49, 13);
      form1_0.label_163.TabIndex = 251;
      form1_0.label_163.Text = "OFFLİNE";
      form1_0.label_164.AutoSize = true;
      form1_0.label_164.BackColor = Color.Transparent;
      form1_0.label_164.ForeColor = Color.Snow;
      form1_0.label_164.Location = new Point(20, 32);
      form1_0.label_164.Name = "label35";
      form1_0.label_164.Size = new Size(63, 13);
      form1_0.label_164.TabIndex = 250;
      form1_0.label_164.Text = "GATEWAY :";
      form1_0.label_160.AutoSize = true;
      form1_0.label_160.BackColor = Color.Transparent;
      form1_0.label_160.ForeColor = Color.Salmon;
      form1_0.label_160.Location = new Point(94, 4);
      form1_0.label_160.Name = "label33";
      form1_0.label_160.Size = new Size(49, 13);
      form1_0.label_160.TabIndex = 244;
      form1_0.label_160.Text = "OFFLİNE";
      form1_0.label_158.AutoSize = true;
      form1_0.label_158.BackColor = Color.Transparent;
      form1_0.label_158.ForeColor = Color.Snow;
      form1_0.label_158.Location = new Point(18, 4);
      form1_0.label_158.Name = "label32";
      form1_0.label_158.Size = new Size(66, 13);
      form1_0.label_158.TabIndex = 243;
      form1_0.label_158.Text = "KARAKTER :";
      form1_0.checkEdit_9.Location = new Point(5, 2);
      form1_0.checkEdit_9.Name = "AnlıkUniqLog";
      form1_0.checkEdit_9.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.checkEdit_9.Properties.Appearance.Options.UseFont = true;
      form1_0.checkEdit_9.Properties.Caption = "Anlık Unique Log Tut";
      form1_0.checkEdit_9.Properties.CheckStyle = CheckStyles.Radio;
      form1_0.checkEdit_9.Properties.GlyphAlignment = HorzAlignment.Default;
      form1_0.checkEdit_9.Size = new Size(57, 20);
      form1_0.checkEdit_9.TabIndex = 249;
      form1_0.checkEdit_9.Visible = false;
      form1_0.groupControl_6.CaptionImageOptions.Image = (Image) componentResourceManager.GetObject("groupControl5.CaptionImageOptions.Image");
      form1_0.groupControl_6.CaptionImageOptions.Padding = new Padding(10, -8, -8, -8);
      form1_0.groupControl_6.Controls.Add((Control) form1_0.panelControl_5);
      form1_0.groupControl_6.Location = new Point(0, 483);
      form1_0.groupControl_6.Name = "groupControl5";
      form1_0.groupControl_6.Size = new Size(196, 100);
      form1_0.groupControl_6.TabIndex = 26;
      form1_0.groupControl_6.Text = "   L İ S A N S";
      form1_0.panelControl_5.Controls.Add((Control) form1_0.label_171);
      form1_0.panelControl_5.Controls.Add((Control) form1_0.checkBox_25);
      form1_0.panelControl_5.Controls.Add((Control) form1_0.label_12);
      form1_0.panelControl_5.Controls.Add((Control) form1_0.pictureBox_0);
      form1_0.panelControl_5.Controls.Add((Control) form1_0.label_8);
      form1_0.panelControl_5.Controls.Add((Control) form1_0.label_13);
      form1_0.panelControl_5.Controls.Add((Control) form1_0.label_14);
      form1_0.panelControl_5.Controls.Add((Control) form1_0.label_15);
      form1_0.panelControl_5.Controls.Add((Control) form1_0.label_16);
      form1_0.panelControl_5.Dock = DockStyle.Top;
      form1_0.panelControl_5.Location = new Point(2, 23);
      form1_0.panelControl_5.Name = "panelControl4";
      form1_0.panelControl_5.Size = new Size(192, 76);
      form1_0.panelControl_5.TabIndex = 7;
      form1_0.label_171.AutoSize = true;
      form1_0.label_171.BackColor = Color.Transparent;
      form1_0.label_171.ForeColor = Color.Salmon;
      form1_0.label_171.Location = new Point(51, 33);
      form1_0.label_171.Name = "label_Mail";
      form1_0.label_171.Size = new Size(13, 13);
      form1_0.label_171.TabIndex = 239;
      form1_0.label_171.Text = "asd@asd@asd";
      form1_0.checkBox_25.AutoSize = true;
      form1_0.checkBox_25.Location = new Point(95, 21);
      form1_0.checkBox_25.Name = "lisans_durumu";
      form1_0.checkBox_25.Size = new Size(84, 17);
      form1_0.checkBox_25.TabIndex = 238;
      form1_0.checkBox_25.Text = "lisans_varmı";
      form1_0.checkBox_25.UseVisualStyleBackColor = true;
      form1_0.checkBox_25.Visible = false;
      form1_0.label_12.AutoSize = true;
      form1_0.label_12.BackColor = Color.Transparent;
      form1_0.label_12.ForeColor = Color.Salmon;
      form1_0.label_12.Location = new Point(64, 55);
      form1_0.label_12.Name = "label180";
      form1_0.label_12.Size = new Size(13, 13);
      form1_0.label_12.TabIndex = 41;
      form1_0.label_12.Text = "0";
      form1_0.pictureBox_0.BackColor = SystemColors.ActiveCaptionText;
      form1_0.pictureBox_0.Location = new Point(117, 39);
      form1_0.pictureBox_0.Name = "pictureBox1";
      form1_0.pictureBox_0.Size = new Size(26, 15);
      form1_0.pictureBox_0.SizeMode = PictureBoxSizeMode.CenterImage;
      form1_0.pictureBox_0.TabIndex = 14;
      form1_0.pictureBox_0.TabStop = false;
      form1_0.pictureBox_0.Visible = false;
      form1_0.label_8.AutoSize = true;
      form1_0.label_8.Location = new Point(155, 41);
      form1_0.label_8.Name = "saat_sonuc";
      form1_0.label_8.Size = new Size(15, 13);
      form1_0.label_8.TabIndex = 69;
      form1_0.label_8.Text = "l1";
      form1_0.label_8.Visible = false;
      form1_0.label_13.AutoSize = true;
      form1_0.label_13.BackColor = Color.Transparent;
      form1_0.label_13.ForeColor = Color.Salmon;
      form1_0.label_13.Location = new Point(30, 9);
      form1_0.label_13.Name = "LocalIP";
      form1_0.label_13.Size = new Size(79, 13);
      form1_0.label_13.TabIndex = 39;
      form1_0.label_13.Text = "192.168.2.227";
      form1_0.label_14.AutoSize = true;
      form1_0.label_14.BackColor = Color.Transparent;
      form1_0.label_14.ForeColor = Color.Salmon;
      form1_0.label_14.Location = new Point(5, 55);
      form1_0.label_14.Name = "label177";
      form1_0.label_14.Size = new Size(65, 13);
      form1_0.label_14.TabIndex = 38;
      form1_0.label_14.Text = "Kalan Gün : ";
      form1_0.label_15.AutoSize = true;
      form1_0.label_15.BackColor = Color.Transparent;
      form1_0.label_15.ForeColor = Color.Salmon;
      form1_0.label_15.Location = new Point(5, 33);
      form1_0.label_15.Name = "label176";
      form1_0.label_15.Size = new Size(42, 13);
      form1_0.label_15.TabIndex = 37;
      form1_0.label_15.Text = "e-mail :";
      form1_0.label_16.AutoSize = true;
      form1_0.label_16.BackColor = Color.Transparent;
      form1_0.label_16.ForeColor = Color.Salmon;
      form1_0.label_16.Location = new Point(5, 9);
      form1_0.label_16.Name = "label174";
      form1_0.label_16.Size = new Size(24, 13);
      form1_0.label_16.TabIndex = 36;
      form1_0.label_16.Text = "IP :";
      form1_0.button_19.BackColor = Color.DimGray;
      form1_0.button_19.BackgroundImageLayout = ImageLayout.Stretch;
      form1_0.button_19.FlatStyle = FlatStyle.Flat;
      form1_0.button_19.ForeColor = Color.Black;
      form1_0.button_19.Location = new Point(94, 589);
      form1_0.button_19.Name = "button1";
      form1_0.button_19.Size = new Size(93, 26);
      form1_0.button_19.TabIndex = 13;
      form1_0.button_19.Text = "Bağlan";
      form1_0.button_19.UseVisualStyleBackColor = false;
      form1_0.button_19.Click += new EventHandler(form1_0.method_2);
      form1_0.button_2.BackColor = Color.DimGray;
      form1_0.button_2.BackgroundImageLayout = ImageLayout.Center;
      form1_0.button_2.Enabled = false;
      form1_0.button_2.FlatStyle = FlatStyle.Flat;
      form1_0.button_2.Font = new Font("Microsoft Sans Serif", 8.25f);
      form1_0.button_2.ForeColor = Color.Black;
      form1_0.button_2.Location = new Point(4, 589);
      form1_0.button_2.Name = "SaveConfig";
      form1_0.button_2.Size = new Size(88, 26);
      form1_0.button_2.TabIndex = 66;
      form1_0.button_2.Text = "Ayarları Kaydet";
      form1_0.button_2.UseVisualStyleBackColor = false;
      form1_0.button_2.Click += new EventHandler(form1_0.method_62);
      form1_0.groupControl_7.Controls.Add((Control) form1_0.panelControl_6);
      form1_0.groupControl_7.Location = new Point(-2, 172);
      form1_0.groupControl_7.Name = "groupControl3";
      form1_0.groupControl_7.Size = new Size(256, 103);
      form1_0.groupControl_7.TabIndex = 24;
      form1_0.groupControl_7.Text = "       SERVER BAĞLANTISI";
      form1_0.panelControl_6.Controls.Add((Control) form1_0.textEdit_17);
      form1_0.panelControl_6.Controls.Add((Control) form1_0.textBox_90);
      form1_0.panelControl_6.Controls.Add((Control) form1_0.textBox_89);
      form1_0.panelControl_6.Controls.Add((Control) form1_0.label_20);
      form1_0.panelControl_6.Controls.Add((Control) form1_0.label_21);
      form1_0.panelControl_6.Controls.Add((Control) form1_0.label_22);
      form1_0.panelControl_6.Location = new Point(2, 25);
      form1_0.panelControl_6.Name = "panelControl2";
      form1_0.panelControl_6.Size = new Size(199, 78);
      form1_0.panelControl_6.TabIndex = 7;
      form1_0.panelControl_6.Paint += new PaintEventHandler(form1_0.method_89);
      form1_0.textEdit_17.EditValue = (object) "192.168.2.227";
      form1_0.textEdit_17.Location = new Point(58, 4);
      form1_0.textEdit_17.Name = "AnaIPAdress";
      form1_0.textEdit_17.Size = new Size(119, 20);
      form1_0.textEdit_17.TabIndex = 239;
      form1_0.textBox_90.BackColor = Color.FromArgb(65, 65, 65);
      form1_0.textBox_90.BorderStyle = BorderStyle.FixedSingle;
      form1_0.textBox_90.ForeColor = Color.FromArgb(180, 180, 180);
      form1_0.textBox_90.Location = new Point(88, 52);
      form1_0.textBox_90.Multiline = true;
      form1_0.textBox_90.Name = "text_CAPTCHA";
      form1_0.textBox_90.Size = new Size(69, 17);
      form1_0.textBox_90.TabIndex = 55;
      form1_0.textBox_90.Text = "0";
      form1_0.textBox_90.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_89.BackColor = Color.FromArgb(65, 65, 65);
      form1_0.textBox_89.BorderStyle = BorderStyle.FixedSingle;
      form1_0.textBox_89.ForeColor = Color.FromArgb(180, 180, 180);
      form1_0.textBox_89.Location = new Point(88, 30);
      form1_0.textBox_89.Multiline = true;
      form1_0.textBox_89.Name = "text_PORT";
      form1_0.textBox_89.Size = new Size(69, 17);
      form1_0.textBox_89.TabIndex = 54;
      form1_0.textBox_89.Text = "15779";
      form1_0.textBox_89.TextAlign = HorizontalAlignment.Center;
      form1_0.label_20.AutoSize = true;
      form1_0.label_20.BackColor = Color.Transparent;
      form1_0.label_20.ForeColor = Color.Salmon;
      form1_0.label_20.Location = new Point(28, 52);
      form1_0.label_20.Name = "label10";
      form1_0.label_20.Size = new Size(61, 13);
      form1_0.label_20.TabIndex = 34;
      form1_0.label_20.Text = "CAPTCHA :";
      form1_0.label_21.AutoSize = true;
      form1_0.label_21.BackColor = Color.Transparent;
      form1_0.label_21.ForeColor = Color.Salmon;
      form1_0.label_21.Location = new Point(28, 7);
      form1_0.label_21.Name = "label11";
      form1_0.label_21.Size = new Size(24, 13);
      form1_0.label_21.TabIndex = 29;
      form1_0.label_21.Text = "IP :";
      form1_0.label_22.AutoSize = true;
      form1_0.label_22.BackColor = Color.Transparent;
      form1_0.label_22.ForeColor = Color.Salmon;
      form1_0.label_22.Location = new Point(46, 32);
      form1_0.label_22.Name = "label12";
      form1_0.label_22.Size = new Size(41, 13);
      form1_0.label_22.TabIndex = 33;
      form1_0.label_22.Text = "PORT :";
      form1_0.checkEdit_10.Location = new Point(40, 302);
      form1_0.checkEdit_10.Name = "AnlıkCharLog";
      form1_0.checkEdit_10.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.checkEdit_10.Properties.Appearance.Options.UseFont = true;
      form1_0.checkEdit_10.Properties.Caption = "Anlık GLobal Log Tut";
      form1_0.checkEdit_10.Properties.CheckStyle = CheckStyles.Radio;
      form1_0.checkEdit_10.Properties.GlyphAlignment = HorzAlignment.Default;
      form1_0.checkEdit_10.Size = new Size(151, 20);
      form1_0.checkEdit_10.TabIndex = 248;
      form1_0.checkEdit_10.Visible = false;
      form1_0.xtraTabControl_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      form1_0.xtraTabControl_0.Appearance.BackColor = Color.DimGray;
      form1_0.xtraTabControl_0.Appearance.BackColor2 = Color.Transparent;
      form1_0.xtraTabControl_0.Appearance.Options.UseBackColor = true;
      form1_0.xtraTabControl_0.AppearancePage.Header.BackColor = Color.Salmon;
      form1_0.xtraTabControl_0.AppearancePage.Header.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.xtraTabControl_0.AppearancePage.Header.Options.UseBackColor = true;
      form1_0.xtraTabControl_0.AppearancePage.Header.Options.UseFont = true;
      form1_0.xtraTabControl_0.BackgroundImage = (Image) componentResourceManager.GetObject("HAYATTA_KAL.BackgroundImage");
      form1_0.xtraTabControl_0.BackgroundImageLayout = ImageLayout.Stretch;
      form1_0.xtraTabControl_0.ImeMode = ImeMode.Hiragana;
      form1_0.xtraTabControl_0.Location = new Point(194, 0);
      form1_0.xtraTabControl_0.LookAndFeel.SkinName = "Darkroom";
      form1_0.xtraTabControl_0.Name = "HAYATTA_KAL";
      form1_0.xtraTabControl_0.SelectedTabPage = form1_0.xtraTabPage_0;
      form1_0.xtraTabControl_0.Size = new Size(819, 797);
      form1_0.xtraTabControl_0.TabIndex = 138;
      form1_0.xtraTabControl_0.TabPages.AddRange(new XtraTabPage[10]
      {
        form1_0.xtraTabPage_0,
        form1_0.xtraTabPage_1,
        form1_0.xtraTabPage_2,
        form1_0.xtraTabPage_3,
        form1_0.xtraTabPage_4,
        form1_0.xtraTabPage_6,
        form1_0.xtraTabPage_7,
        form1_0.xtraTabPage_8,
        form1_0.xtraTabPage_9,
        form1_0.xtraTabPage_5
      });
      form1_0.xtraTabControl_0.Click += new EventHandler(form1_0.method_113);
      form1_0.xtraTabControl_0.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.xtraTabPage_0.Controls.Add((Control) form1_0.comboBoxEdit_3);
      form1_0.xtraTabPage_0.Controls.Add((Control) form1_0.button_3);
      form1_0.xtraTabPage_0.Controls.Add((Control) form1_0.groupBox_0);
      form1_0.xtraTabPage_0.Controls.Add((Control) form1_0.button_4);
      form1_0.xtraTabPage_0.Controls.Add((Control) form1_0.textBox_9);
      form1_0.xtraTabPage_0.Controls.Add((Control) form1_0.listBox_10);
      form1_0.xtraTabPage_0.Controls.Add((Control) form1_0.dateTimePicker_8);
      form1_0.xtraTabPage_0.Controls.Add((Control) form1_0.label_30);
      form1_0.xtraTabPage_0.Controls.Add((Control) form1_0.label_31);
      form1_0.xtraTabPage_0.Controls.Add((Control) form1_0.groupBox_4);
      form1_0.xtraTabPage_0.Image = (Image) componentResourceManager.GetObject("UKILL_EVENT.Image");
      form1_0.xtraTabPage_0.ImeMode = ImeMode.HangulFull;
      form1_0.xtraTabPage_0.InvertTouchScroll = true;
      form1_0.xtraTabPage_0.Name = "UKILL_EVENT";
      form1_0.xtraTabPage_0.Size = new Size(817, 753);
      form1_0.xtraTabPage_0.Text = "Unique Kes";
      form1_0.xtraTabPage_0.Paint += new PaintEventHandler(form1_0.method_35);
      form1_0.comboBoxEdit_3.EditValue = (object) "Gün Seçin";
      form1_0.comboBoxEdit_3.Location = new Point(3, 181);
      form1_0.comboBoxEdit_3.Name = "UKILL_zamanı";
      form1_0.comboBoxEdit_3.Properties.Appearance.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.comboBoxEdit_3.Properties.Appearance.ForeColor = Color.Salmon;
      form1_0.comboBoxEdit_3.Properties.Appearance.Options.UseBackColor = true;
      form1_0.comboBoxEdit_3.Properties.Appearance.Options.UseForeColor = true;
      form1_0.comboBoxEdit_3.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      form1_0.comboBoxEdit_3.Properties.Items.AddRange(new object[7]
      {
        (object) "Pazartesi",
        (object) "Salı",
        (object) "Çarşamba",
        (object) "Perşembe",
        (object) "Cuma",
        (object) "Cumartesi",
        (object) "Pazar"
      });
      form1_0.comboBoxEdit_3.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
      form1_0.comboBoxEdit_3.Size = new Size(89, 20);
      form1_0.comboBoxEdit_3.TabIndex = 60;
      form1_0.button_3.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.button_3.BackgroundImageLayout = ImageLayout.Stretch;
      form1_0.button_3.FlatStyle = FlatStyle.Flat;
      form1_0.button_3.ForeColor = SystemColors.Window;
      form1_0.button_3.Location = new Point(109, 427);
      form1_0.button_3.Name = "button10";
      form1_0.button_3.Size = new Size(93, 24);
      form1_0.button_3.TabIndex = 66;
      form1_0.button_3.Text = "Sil";
      form1_0.button_3.UseVisualStyleBackColor = false;
      form1_0.button_3.Click += new EventHandler(form1_0.method_50);
      form1_0.groupBox_0.BackColor = Color.Gray;
      form1_0.groupBox_0.Controls.Add((Control) form1_0.button_37);
      form1_0.groupBox_0.Controls.Add((Control) form1_0.checkBox_26);
      form1_0.groupBox_0.Controls.Add((Control) form1_0.panel_2);
      form1_0.groupBox_0.Controls.Add((Control) form1_0.checkEdit_10);
      form1_0.groupBox_0.Controls.Add((Control) form1_0.label_156);
      form1_0.groupBox_0.Controls.Add((Control) form1_0.label_157);
      form1_0.groupBox_0.Controls.Add((Control) form1_0.button_26);
      form1_0.groupBox_0.Controls.Add((Control) form1_0.button_27);
      form1_0.groupBox_0.Controls.Add((Control) form1_0.button_28);
      form1_0.groupBox_0.Controls.Add((Control) form1_0.button_29);
      form1_0.groupBox_0.Controls.Add((Control) form1_0.listBoxControl_0);
      form1_0.groupBox_0.Controls.Add((Control) form1_0.button_30);
      form1_0.groupBox_0.Controls.Add((Control) form1_0.listBoxControl_1);
      form1_0.groupBox_0.Controls.Add((Control) form1_0.groupBox_1);
      form1_0.groupBox_0.Controls.Add((Control) form1_0.textBox_6);
      form1_0.groupBox_0.ForeColor = SystemColors.Window;
      form1_0.groupBox_0.Location = new Point(208, 11);
      form1_0.groupBox_0.Name = "groupBox16";
      form1_0.groupBox_0.Size = new Size(610, 441);
      form1_0.groupBox_0.TabIndex = 55;
      form1_0.groupBox_0.TabStop = false;
      form1_0.groupBox_0.Text = "   UNİQUE AYARLARI";
      form1_0.groupBox_0.Enter += new EventHandler(form1_0.method_65);
      form1_0.button_37.BackColor = Color.FromArgb(65, 65, 65);
      form1_0.button_37.FlatStyle = FlatStyle.Flat;
      form1_0.button_37.ForeColor = Color.Salmon;
      form1_0.button_37.Location = new Point(308, 375);
      form1_0.button_37.Name = "button38";
      form1_0.button_37.Size = new Size(87, 57);
      form1_0.button_37.TabIndex = 313;
      form1_0.button_37.Text = "CodeName128";
      form1_0.button_37.UseVisualStyleBackColor = false;
      form1_0.button_37.Click += new EventHandler(form1_0.method_114);
      form1_0.checkBox_26.AutoSize = true;
      form1_0.checkBox_26.BackColor = Color.Transparent;
      form1_0.checkBox_26.ForeColor = Color.Black;
      form1_0.checkBox_26.Location = new Point(253, 10);
      form1_0.checkBox_26.Name = "checkBox1";
      form1_0.checkBox_26.Size = new Size(104, 17);
      form1_0.checkBox_26.TabIndex = 311;
      form1_0.checkBox_26.Text = "Zerklik atılsın mı?";
      form1_0.checkBox_26.UseVisualStyleBackColor = false;
      form1_0.checkBox_26.CheckedChanged += new EventHandler(form1_0.method_106);
      form1_0.panel_2.BackColor = Color.DimGray;
      form1_0.panel_2.Controls.Add((Control) form1_0.textBox_7);
      form1_0.panel_2.Controls.Add((Control) form1_0.textBox_8);
      form1_0.panel_2.Controls.Add((Control) form1_0.label_29);
      form1_0.panel_2.Controls.Add((Control) form1_0.label_120);
      form1_0.panel_2.Enabled = false;
      form1_0.panel_2.Location = new Point(213, 30);
      form1_0.panel_2.Name = "panel3";
      form1_0.panel_2.Size = new Size(185, 53);
      form1_0.panel_2.TabIndex = 310;
      form1_0.textBox_7.BackColor = Color.LightCoral;
      form1_0.textBox_7.ForeColor = SystemColors.Window;
      form1_0.textBox_7.Location = new Point(108, 19);
      form1_0.textBox_7.MaxLength = 2;
      form1_0.textBox_7.Multiline = true;
      form1_0.textBox_7.Name = "uniq_zerk_adet";
      form1_0.textBox_7.Size = new Size(74, 19);
      form1_0.textBox_7.TabIndex = 164;
      form1_0.textBox_7.Text = "1";
      form1_0.textBox_7.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_7.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_8.BackColor = Color.LightCoral;
      form1_0.textBox_8.ForeColor = SystemColors.Window;
      form1_0.textBox_8.Location = new Point(8, 19);
      form1_0.textBox_8.Multiline = true;
      form1_0.textBox_8.Name = "UKILL_zerk_uniq_ID";
      form1_0.textBox_8.Size = new Size(94, 18);
      form1_0.textBox_8.TabIndex = 35;
      form1_0.textBox_8.Text = "22519";
      form1_0.textBox_8.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_8.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.label_29.AutoSize = true;
      form1_0.label_29.Font = new Font("Tahoma", 6.25f);
      form1_0.label_29.ForeColor = Color.WhiteSmoke;
      form1_0.label_29.Location = new Point(19, 5);
      form1_0.label_29.Name = "label36";
      form1_0.label_29.Size = new Size(70, 11);
      form1_0.label_29.TabIndex = 3;
      form1_0.label_29.Text = "ZERK UNİQUE";
      form1_0.label_120.AutoSize = true;
      form1_0.label_120.Font = new Font("Tahoma", 6.25f);
      form1_0.label_120.ForeColor = Color.WhiteSmoke;
      form1_0.label_120.Location = new Point(132, 5);
      form1_0.label_120.Name = "label194";
      form1_0.label_120.Size = new Size(31, 11);
      form1_0.label_120.TabIndex = 209;
      form1_0.label_120.Text = "ADET";
      form1_0.label_156.AutoSize = true;
      form1_0.label_156.Font = new Font("Tahoma", 6.25f);
      form1_0.label_156.ForeColor = Color.WhiteSmoke;
      form1_0.label_156.Location = new Point(227, 86);
      form1_0.label_156.Name = "label31";
      form1_0.label_156.Size = new Size(144, 11);
      form1_0.label_156.TabIndex = 309;
      form1_0.label_156.Text = "    ETKİNLİK İÇİN SEÇİLENLER";
      form1_0.label_157.AutoSize = true;
      form1_0.label_157.Font = new Font("Tahoma", 6.25f);
      form1_0.label_157.ForeColor = Color.WhiteSmoke;
      form1_0.label_157.Location = new Point(6, 55);
      form1_0.label_157.Name = "label30";
      form1_0.label_157.Size = new Size(163, 11);
      form1_0.label_157.TabIndex = 308;
      form1_0.label_157.Text = "   VERİTABANINDAKİ UNİQUELER";
      form1_0.button_26.BackColor = Color.FromArgb(65, 65, 65);
      form1_0.button_26.FlatStyle = FlatStyle.Flat;
      form1_0.button_26.ForeColor = Color.Salmon;
      form1_0.button_26.Location = new Point(5, 406);
      form1_0.button_26.Name = "button27";
      form1_0.button_26.Size = new Size(186, 25);
      form1_0.button_26.TabIndex = 306;
      form1_0.button_26.Text = "====>";
      form1_0.button_26.UseVisualStyleBackColor = false;
      form1_0.button_26.Click += new EventHandler(form1_0.method_91);
      form1_0.button_27.BackColor = Color.FromArgb(65, 65, 65);
      form1_0.button_27.FlatStyle = FlatStyle.Flat;
      form1_0.button_27.ForeColor = Color.Salmon;
      form1_0.button_27.Location = new Point(213, 375);
      form1_0.button_27.Name = "button20";
      form1_0.button_27.Size = new Size(89, 25);
      form1_0.button_27.TabIndex = 307;
      form1_0.button_27.Text = "<====";
      form1_0.button_27.UseVisualStyleBackColor = false;
      form1_0.button_27.Click += new EventHandler(form1_0.method_93);
      form1_0.button_28.BackColor = Color.FromArgb(65, 65, 65);
      form1_0.button_28.FlatStyle = FlatStyle.Flat;
      form1_0.button_28.ForeColor = Color.Salmon;
      form1_0.button_28.Location = new Point(264, 402);
      form1_0.button_28.Name = "button15";
      form1_0.button_28.Size = new Size(38, 30);
      form1_0.button_28.TabIndex = 305;
      form1_0.button_28.Text = "/\\";
      form1_0.button_28.UseVisualStyleBackColor = false;
      form1_0.button_28.Click += new EventHandler(form1_0.method_94);
      form1_0.button_29.BackColor = Color.FromArgb(65, 65, 65);
      form1_0.button_29.FlatStyle = FlatStyle.Flat;
      form1_0.button_29.ForeColor = Color.Salmon;
      form1_0.button_29.Location = new Point(213, 402);
      form1_0.button_29.Name = "button6";
      form1_0.button_29.Size = new Size(45, 29);
      form1_0.button_29.TabIndex = 304;
      form1_0.button_29.Text = "\\/";
      form1_0.button_29.UseVisualStyleBackColor = false;
      form1_0.button_29.Click += new EventHandler(form1_0.method_92);
      form1_0.listBoxControl_0.ContextMenuStrip = form1_0.contextMenuStrip_0;
      form1_0.listBoxControl_0.Cursor = Cursors.Default;
      form1_0.listBoxControl_0.Location = new Point(213, 99);
      form1_0.listBoxControl_0.Name = "list_Ukill_secilenler";
      form1_0.listBoxControl_0.Size = new Size(185, 273);
      form1_0.listBoxControl_0.TabIndex = 301;
      form1_0.contextMenuStrip_0.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) form1_0.toolStripMenuItem_0
      });
      form1_0.contextMenuStrip_0.Name = "contextMenuStrip1";
      form1_0.contextMenuStrip_0.Size = new Size(153, 26);
      form1_0.contextMenuStrip_0.Opening += new CancelEventHandler(form1_0.method_115);
      form1_0.toolStripMenuItem_0.Name = "ıDBulToolStripMenuItem";
      form1_0.toolStripMenuItem_0.Size = new Size(152, 22);
      form1_0.toolStripMenuItem_0.Text = "CodeName128";
      form1_0.toolStripMenuItem_0.Click += new EventHandler(form1_0.method_116);
      form1_0.button_30.BackColor = Color.FromArgb(65, 65, 65);
      form1_0.button_30.FlatStyle = FlatStyle.Flat;
      form1_0.button_30.ForeColor = Color.Salmon;
      form1_0.button_30.Location = new Point(6, 22);
      form1_0.button_30.Name = "button26";
      form1_0.button_30.Size = new Size(185, 28);
      form1_0.button_30.TabIndex = 284;
      form1_0.button_30.Text = "UNİQUE BİLGİLERİNİ GETİR";
      form1_0.button_30.UseVisualStyleBackColor = false;
      form1_0.button_30.Click += new EventHandler(form1_0.method_90);
      form1_0.listBoxControl_1.Cursor = Cursors.Default;
      form1_0.listBoxControl_1.Location = new Point(6, 70);
      form1_0.listBoxControl_1.Name = "List_UKıll_Uniq_List";
      form1_0.listBoxControl_1.Size = new Size(185, 330);
      form1_0.listBoxControl_1.TabIndex = 283;
      form1_0.groupBox_1.BackColor = Color.Gray;
      form1_0.groupBox_1.Controls.Add((Control) form1_0.groupBox_2);
      form1_0.groupBox_1.Controls.Add((Control) form1_0.checkBox_0);
      form1_0.groupBox_1.Controls.Add((Control) form1_0.groupBox_3);
      form1_0.groupBox_1.Controls.Add((Control) form1_0.checkBox_1);
      form1_0.groupBox_1.ForeColor = SystemColors.Window;
      form1_0.groupBox_1.Location = new Point(404, 55);
      form1_0.groupBox_1.Name = "groupBox9";
      form1_0.groupBox_1.Size = new Size(197, 380);
      form1_0.groupBox_1.TabIndex = 56;
      form1_0.groupBox_1.TabStop = false;
      form1_0.groupBox_1.Text = "ÖDÜL AYARLARI";
      form1_0.groupBox_2.BackColor = Color.Gray;
      form1_0.groupBox_2.Controls.Add((Control) form1_0.label_149);
      form1_0.groupBox_2.Controls.Add((Control) form1_0.textBox_91);
      form1_0.groupBox_2.Controls.Add((Control) form1_0.label_23);
      form1_0.groupBox_2.Controls.Add((Control) form1_0.label_24);
      form1_0.groupBox_2.Controls.Add((Control) form1_0.label_25);
      form1_0.groupBox_2.Controls.Add((Control) form1_0.textBox_0);
      form1_0.groupBox_2.Controls.Add((Control) form1_0.textBox_1);
      form1_0.groupBox_2.Controls.Add((Control) form1_0.textBox_2);
      form1_0.groupBox_2.Enabled = false;
      form1_0.groupBox_2.ForeColor = SystemColors.Window;
      form1_0.groupBox_2.Location = new Point(6, 34);
      form1_0.groupBox_2.Name = "groupBox14";
      form1_0.groupBox_2.Size = new Size(183, 160);
      form1_0.groupBox_2.TabIndex = 9;
      form1_0.groupBox_2.TabStop = false;
      form1_0.groupBox_2.Text = "ITEM";
      form1_0.label_149.AutoSize = true;
      form1_0.label_149.Location = new Point(66, 108);
      form1_0.label_149.Name = "label64";
      form1_0.label_149.Size = new Size(56, 13);
      form1_0.label_149.TabIndex = 44;
      form1_0.label_149.Text = "ITEM İSMİ";
      form1_0.textBox_91.BackColor = Color.Salmon;
      form1_0.textBox_91.Location = new Point(6, 124);
      form1_0.textBox_91.MaxLength = 300;
      form1_0.textBox_91.Name = "textBox14";
      form1_0.textBox_91.Size = new Size(163, 21);
      form1_0.textBox_91.TabIndex = 42;
      form1_0.textBox_91.Text = "Sun Sword (1 Dg )";
      form1_0.textBox_91.TextAlign = HorizontalAlignment.Center;
      form1_0.label_23.AutoSize = true;
      form1_0.label_23.Location = new Point(124, 56);
      form1_0.label_23.Name = "label1";
      form1_0.label_23.Size = new Size(31, 13);
      form1_0.label_23.TabIndex = 41;
      form1_0.label_23.Text = "PLUS";
      form1_0.label_24.AutoSize = true;
      form1_0.label_24.Location = new Point(31, 56);
      form1_0.label_24.Name = "label2";
      form1_0.label_24.Size = new Size(33, 13);
      form1_0.label_24.TabIndex = 40;
      form1_0.label_24.Text = "ADET";
      form1_0.label_25.AutoSize = true;
      form1_0.label_25.Location = new Point(49, 10);
      form1_0.label_25.Name = "label3";
      form1_0.label_25.Size = new Size(62, 13);
      form1_0.label_25.TabIndex = 39;
      form1_0.label_25.Text = "ITEM KODU";
      form1_0.textBox_0.BackColor = Color.Salmon;
      form1_0.textBox_0.Location = new Point(104, 72);
      form1_0.textBox_0.Name = "textBox20";
      form1_0.textBox_0.Size = new Size(65, 21);
      form1_0.textBox_0.TabIndex = 8;
      form1_0.textBox_0.Text = "1";
      form1_0.textBox_0.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_0.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_1.BackColor = Color.Salmon;
      form1_0.textBox_1.Location = new Point(6, 72);
      form1_0.textBox_1.Name = "textBox21";
      form1_0.textBox_1.Size = new Size(74, 21);
      form1_0.textBox_1.TabIndex = 7;
      form1_0.textBox_1.Text = "1";
      form1_0.textBox_1.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_1.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_2.BackColor = Color.Salmon;
      form1_0.textBox_2.Location = new Point(6, 26);
      form1_0.textBox_2.MaxLength = 300;
      form1_0.textBox_2.Name = "textBox22";
      form1_0.textBox_2.Size = new Size(163, 21);
      form1_0.textBox_2.TabIndex = 4;
      form1_0.textBox_2.Text = "ITEM_CH_SWORD_01_C_RARE";
      form1_0.textBox_2.TextAlign = HorizontalAlignment.Center;
      form1_0.checkBox_0.AutoSize = true;
      form1_0.checkBox_0.Location = new Point(6, 200);
      form1_0.checkBox_0.Name = "ödültipi_slk_gld_sp_rtb";
      form1_0.checkBox_0.Size = new Size(15, 14);
      form1_0.checkBox_0.TabIndex = 10;
      form1_0.checkBox_0.UseVisualStyleBackColor = true;
      form1_0.checkBox_0.CheckedChanged += new EventHandler(form1_0.method_21);
      form1_0.groupBox_3.BackColor = Color.Gray;
      form1_0.groupBox_3.Controls.Add((Control) form1_0.label_26);
      form1_0.groupBox_3.Controls.Add((Control) form1_0.label_27);
      form1_0.groupBox_3.Controls.Add((Control) form1_0.label_28);
      form1_0.groupBox_3.Controls.Add((Control) form1_0.textBox_3);
      form1_0.groupBox_3.Controls.Add((Control) form1_0.textBox_4);
      form1_0.groupBox_3.Controls.Add((Control) form1_0.textBox_5);
      form1_0.groupBox_3.Enabled = false;
      form1_0.groupBox_3.ForeColor = SystemColors.Window;
      form1_0.groupBox_3.Location = new Point(6, 220);
      form1_0.groupBox_3.Name = "groupBox13";
      form1_0.groupBox_3.Size = new Size(183, 158);
      form1_0.groupBox_3.TabIndex = 10;
      form1_0.groupBox_3.TabStop = false;
      form1_0.groupBox_3.Text = "SİLK- GOLD - SP";
      form1_0.label_26.AutoSize = true;
      form1_0.label_26.Location = new Point(73, 103);
      form1_0.label_26.Name = "label5";
      form1_0.label_26.Size = new Size(53, 13);
      form1_0.label_26.TabIndex = 38;
      form1_0.label_26.Text = "SP Miktarı";
      form1_0.label_27.AutoSize = true;
      form1_0.label_27.Location = new Point(64, 61);
      form1_0.label_27.Name = "label6";
      form1_0.label_27.Size = new Size(62, 13);
      form1_0.label_27.TabIndex = 37;
      form1_0.label_27.Text = "Gold Miktari";
      form1_0.label_28.AutoSize = true;
      form1_0.label_28.Location = new Point(68, 20);
      form1_0.label_28.Name = "label29";
      form1_0.label_28.Size = new Size(56, 13);
      form1_0.label_28.TabIndex = 36;
      form1_0.label_28.Text = "Silk Miktarı";
      form1_0.textBox_3.BackColor = Color.Salmon;
      form1_0.textBox_3.Location = new Point(6, 75);
      form1_0.textBox_3.MaxLength = 19;
      form1_0.textBox_3.Name = "UKes_GoldMiktari";
      form1_0.textBox_3.Size = new Size(171, 21);
      form1_0.textBox_3.TabIndex = 6;
      form1_0.textBox_3.Text = "0";
      form1_0.textBox_3.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_3.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_4.BackColor = Color.Salmon;
      form1_0.textBox_4.Location = new Point(52, 119);
      form1_0.textBox_4.MaxLength = 19;
      form1_0.textBox_4.Name = "UKes_SPMiktari";
      form1_0.textBox_4.Size = new Size(97, 21);
      form1_0.textBox_4.TabIndex = 5;
      form1_0.textBox_4.Text = "0";
      form1_0.textBox_4.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_4.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_5.BackColor = Color.Salmon;
      form1_0.textBox_5.Location = new Point(62, 35);
      form1_0.textBox_5.MaxLength = 19;
      form1_0.textBox_5.Name = "UKes_SilkMiktari";
      form1_0.textBox_5.Size = new Size(71, 21);
      form1_0.textBox_5.TabIndex = 4;
      form1_0.textBox_5.Text = "0";
      form1_0.textBox_5.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_5.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.checkBox_1.AutoSize = true;
      form1_0.checkBox_1.Location = new Point(6, 14);
      form1_0.checkBox_1.Name = "ödültipi_İTEM";
      form1_0.checkBox_1.Size = new Size(15, 14);
      form1_0.checkBox_1.TabIndex = 9;
      form1_0.checkBox_1.UseVisualStyleBackColor = true;
      form1_0.checkBox_1.CheckedChanged += new EventHandler(form1_0.method_20);
      form1_0.textBox_6.BackColor = Color.Silver;
      form1_0.textBox_6.ForeColor = SystemColors.Window;
      form1_0.textBox_6.Location = new Point(526, 14);
      form1_0.textBox_6.Multiline = true;
      form1_0.textBox_6.Name = "UKILL_son_atılan_uniq";
      form1_0.textBox_6.Size = new Size(75, 20);
      form1_0.textBox_6.TabIndex = 199;
      form1_0.textBox_6.Text = "0";
      form1_0.textBox_6.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_6.Visible = false;
      form1_0.button_4.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.button_4.BackgroundImageLayout = ImageLayout.Stretch;
      form1_0.button_4.FlatStyle = FlatStyle.Flat;
      form1_0.button_4.ForeColor = SystemColors.Window;
      form1_0.button_4.Location = new Point(3, 427);
      form1_0.button_4.Name = "button11";
      form1_0.button_4.Size = new Size(93, 24);
      form1_0.button_4.TabIndex = 65;
      form1_0.button_4.Text = "Ekle";
      form1_0.button_4.UseVisualStyleBackColor = false;
      form1_0.button_4.Click += new EventHandler(form1_0.method_22);
      form1_0.textBox_9.Location = new Point(157, 208);
      form1_0.textBox_9.Name = "textBox2";
      form1_0.textBox_9.Size = new Size(45, 21);
      form1_0.textBox_9.TabIndex = 52;
      form1_0.textBox_9.Visible = false;
      form1_0.listBox_10.BackColor = Color.Gray;
      form1_0.listBox_10.ForeColor = SystemColors.Window;
      form1_0.listBox_10.FormattingEnabled = true;
      form1_0.listBox_10.Location = new Point(3, 208);
      form1_0.listBox_10.Name = "UniqKes_ListBox";
      form1_0.listBox_10.Size = new Size(199, 212);
      form1_0.listBox_10.TabIndex = 51;
      form1_0.listBox_10.SelectedValueChanged += new EventHandler(form1_0.method_64);
      form1_0.dateTimePicker_8.CalendarMonthBackground = SystemColors.InactiveCaptionText;
      form1_0.dateTimePicker_8.Format = DateTimePickerFormat.Time;
      form1_0.dateTimePicker_8.ImeMode = ImeMode.NoControl;
      form1_0.dateTimePicker_8.Location = new Point(98, 181);
      form1_0.dateTimePicker_8.Name = "UniqKes_Saat";
      form1_0.dateTimePicker_8.RightToLeft = RightToLeft.Yes;
      form1_0.dateTimePicker_8.ShowUpDown = true;
      form1_0.dateTimePicker_8.Size = new Size(104, 21);
      form1_0.dateTimePicker_8.TabIndex = 50;
      form1_0.label_30.AutoSize = true;
      form1_0.label_30.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.label_30.Location = new Point((int) sbyte.MaxValue, 159);
      form1_0.label_30.Name = "label37";
      form1_0.label_30.Size = new Size(43, 20);
      form1_0.label_30.TabIndex = 48;
      form1_0.label_30.Text = "Saat";
      form1_0.label_31.AutoSize = true;
      form1_0.label_31.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.label_31.Location = new Point(37, 157);
      form1_0.label_31.Name = "label40";
      form1_0.label_31.Size = new Size(40, 20);
      form1_0.label_31.TabIndex = 47;
      form1_0.label_31.Text = "Gün";
      form1_0.groupBox_4.BackColor = Color.Gray;
      form1_0.groupBox_4.Controls.Add((Control) form1_0.comboBoxEdit_2);
      form1_0.groupBox_4.Controls.Add((Control) form1_0.label_106);
      form1_0.groupBox_4.Controls.Add((Control) form1_0.label_107);
      form1_0.groupBox_4.Controls.Add((Control) form1_0.checkBox_2);
      form1_0.groupBox_4.Controls.Add((Control) form1_0.label_32);
      form1_0.groupBox_4.ForeColor = SystemColors.Menu;
      form1_0.groupBox_4.Location = new Point(3, 11);
      form1_0.groupBox_4.Name = "groupBox15";
      form1_0.groupBox_4.Size = new Size(199, 143);
      form1_0.groupBox_4.TabIndex = 46;
      form1_0.groupBox_4.TabStop = false;
      form1_0.groupBox_4.Text = "GENEL AYARLAR";
      form1_0.comboBoxEdit_2.EditValue = (object) "Etkinlik Bölgesi Seçin";
      form1_0.comboBoxEdit_2.Location = new Point(25, 63);
      form1_0.comboBoxEdit_2.Name = "UKILL_Bölge";
      form1_0.comboBoxEdit_2.Properties.Appearance.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.comboBoxEdit_2.Properties.Appearance.ForeColor = Color.Salmon;
      form1_0.comboBoxEdit_2.Properties.Appearance.Options.UseBackColor = true;
      form1_0.comboBoxEdit_2.Properties.Appearance.Options.UseForeColor = true;
      form1_0.comboBoxEdit_2.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      form1_0.comboBoxEdit_2.Properties.Items.AddRange(new object[6]
      {
        (object) "Jangan",
        (object) "Donwhang",
        (object) "Hotan",
        (object) "Samarkand",
        (object) "Constantine",
        (object) "Alexandria"
      });
      form1_0.comboBoxEdit_2.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
      form1_0.comboBoxEdit_2.Size = new Size(144, 20);
      form1_0.comboBoxEdit_2.TabIndex = 59;
      form1_0.label_106.AutoSize = true;
      form1_0.label_106.Location = new Point(125, 114);
      form1_0.label_106.Name = "label118";
      form1_0.label_106.Size = new Size(13, 13);
      form1_0.label_106.TabIndex = 58;
      form1_0.label_106.Text = "0";
      form1_0.label_107.AutoSize = true;
      form1_0.label_107.Location = new Point(2, 114);
      form1_0.label_107.Name = "label117";
      form1_0.label_107.Size = new Size(125, 13);
      form1_0.label_107.TabIndex = 57;
      form1_0.label_107.Text = "Ortalama Etkinlik Süresi :";
      form1_0.checkBox_2.AutoSize = true;
      form1_0.checkBox_2.BackColor = Color.Transparent;
      form1_0.checkBox_2.ForeColor = Color.Black;
      form1_0.checkBox_2.Location = new Point(38, 26);
      form1_0.checkBox_2.Name = "Unq_kesme_basladımı";
      form1_0.checkBox_2.Size = new Size(105, 17);
      form1_0.checkBox_2.TabIndex = 56;
      form1_0.checkBox_2.Text = "Event Başladımı?";
      form1_0.checkBox_2.UseVisualStyleBackColor = false;
      form1_0.checkBox_2.Visible = false;
      form1_0.label_32.AutoSize = true;
      form1_0.label_32.Location = new Point(61, 47);
      form1_0.label_32.Name = "label46";
      form1_0.label_32.Size = new Size(71, 13);
      form1_0.label_32.TabIndex = 1;
      form1_0.label_32.Text = "Event Bölgesi";
      form1_0.xtraTabPage_1.Appearance.PageClient.BackColor = Color.Gray;
      form1_0.xtraTabPage_1.Appearance.PageClient.Options.UseBackColor = true;
      form1_0.xtraTabPage_1.Controls.Add((Control) form1_0.comboBoxEdit_4);
      form1_0.xtraTabPage_1.Controls.Add((Control) form1_0.button_5);
      form1_0.xtraTabPage_1.Controls.Add((Control) form1_0.button_6);
      form1_0.xtraTabPage_1.Controls.Add((Control) form1_0.textBox_10);
      form1_0.xtraTabPage_1.Controls.Add((Control) form1_0.groupBox_5);
      form1_0.xtraTabPage_1.Controls.Add((Control) form1_0.listBox_11);
      form1_0.xtraTabPage_1.Controls.Add((Control) form1_0.dateTimePicker_0);
      form1_0.xtraTabPage_1.Controls.Add((Control) form1_0.label_39);
      form1_0.xtraTabPage_1.Controls.Add((Control) form1_0.label_40);
      form1_0.xtraTabPage_1.Controls.Add((Control) form1_0.groupBox_9);
      form1_0.xtraTabPage_1.Image = (Image) componentResourceManager.GetObject("UniqBUL.Image");
      form1_0.xtraTabPage_1.Name = "UniqBUL";
      form1_0.xtraTabPage_1.Size = new Size(817, 753);
      form1_0.xtraTabPage_1.Text = "Kayıp Unique";
      form1_0.xtraTabPage_1.Paint += new PaintEventHandler(form1_0.method_36);
      form1_0.comboBoxEdit_4.EditValue = (object) "Gün Seçin";
      form1_0.comboBoxEdit_4.Location = new Point(5, 176);
      form1_0.comboBoxEdit_4.Name = "UniqBul_EventZamanı";
      form1_0.comboBoxEdit_4.Properties.Appearance.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.comboBoxEdit_4.Properties.Appearance.ForeColor = Color.Salmon;
      form1_0.comboBoxEdit_4.Properties.Appearance.Options.UseBackColor = true;
      form1_0.comboBoxEdit_4.Properties.Appearance.Options.UseForeColor = true;
      form1_0.comboBoxEdit_4.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      form1_0.comboBoxEdit_4.Properties.Items.AddRange(new object[7]
      {
        (object) "Pazartesi",
        (object) "Salı",
        (object) "Çarşamba",
        (object) "Perşembe",
        (object) "Cuma",
        (object) "Cumartesi",
        (object) "Pazar"
      });
      form1_0.comboBoxEdit_4.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
      form1_0.comboBoxEdit_4.Size = new Size(106, 20);
      form1_0.comboBoxEdit_4.TabIndex = 62;
      form1_0.button_5.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.button_5.BackgroundImageLayout = ImageLayout.Stretch;
      form1_0.button_5.FlatStyle = FlatStyle.Flat;
      form1_0.button_5.ForeColor = SystemColors.Window;
      form1_0.button_5.Location = new Point(121, 423);
      form1_0.button_5.Name = "button3";
      form1_0.button_5.Size = new Size(104, 24);
      form1_0.button_5.TabIndex = 67;
      form1_0.button_5.Text = "Sil";
      form1_0.button_5.UseVisualStyleBackColor = false;
      form1_0.button_5.Click += new EventHandler(form1_0.method_51);
      form1_0.button_6.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.button_6.BackgroundImageLayout = ImageLayout.Stretch;
      form1_0.button_6.FlatStyle = FlatStyle.Flat;
      form1_0.button_6.ForeColor = SystemColors.Window;
      form1_0.button_6.Location = new Point(5, 423);
      form1_0.button_6.Name = "button4";
      form1_0.button_6.Size = new Size(104, 24);
      form1_0.button_6.TabIndex = 66;
      form1_0.button_6.Text = "Ekle";
      form1_0.button_6.UseVisualStyleBackColor = false;
      form1_0.button_6.Click += new EventHandler(form1_0.method_24);
      form1_0.textBox_10.Location = new Point(180, 203);
      form1_0.textBox_10.Name = "textBox19";
      form1_0.textBox_10.Size = new Size(45, 21);
      form1_0.textBox_10.TabIndex = 65;
      form1_0.textBox_10.Visible = false;
      form1_0.groupBox_5.BackColor = Color.Gray;
      form1_0.groupBox_5.Controls.Add((Control) form1_0.listBox_19);
      form1_0.groupBox_5.Controls.Add((Control) form1_0.textBox_99);
      form1_0.groupBox_5.Controls.Add((Control) form1_0.listBox_18);
      form1_0.groupBox_5.Controls.Add((Control) form1_0.listBox_0);
      form1_0.groupBox_5.Controls.Add((Control) form1_0.listBox_1);
      form1_0.groupBox_5.Controls.Add((Control) form1_0.groupBox_6);
      form1_0.groupBox_5.ForeColor = SystemColors.Window;
      form1_0.groupBox_5.Location = new Point(231, 6);
      form1_0.groupBox_5.Name = "groupBox5";
      form1_0.groupBox_5.Size = new Size(588, 440);
      form1_0.groupBox_5.TabIndex = 62;
      form1_0.groupBox_5.TabStop = false;
      form1_0.groupBox_5.Text = "   UNİQUE AYARLARI";
      form1_0.listBox_19.FormattingEnabled = true;
      form1_0.listBox_19.Location = new Point(67, 251);
      form1_0.listBox_19.Name = "gidilecek_koord";
      form1_0.listBox_19.Size = new Size(33, 173);
      form1_0.listBox_19.TabIndex = 218;
      form1_0.listBox_19.Visible = false;
      form1_0.textBox_99.BackColor = Color.Salmon;
      form1_0.textBox_99.Location = new Point(271, 11);
      form1_0.textBox_99.Name = "textBox25";
      form1_0.textBox_99.Size = new Size(311, 21);
      form1_0.textBox_99.TabIndex = 217;
      form1_0.textBox_99.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_99.Visible = false;
      form1_0.listBox_18.BackColor = Color.Salmon;
      form1_0.listBox_18.ForeColor = SystemColors.Info;
      form1_0.listBox_18.FormattingEnabled = true;
      form1_0.listBox_18.Location = new Point(11, 85);
      form1_0.listBox_18.Name = "UBul_Map_Listesi";
      form1_0.listBox_18.Size = new Size(50, 160);
      form1_0.listBox_18.TabIndex = 216;
      form1_0.listBox_18.Visible = false;
      form1_0.listBox_0.FormattingEnabled = true;
      form1_0.listBox_0.Location = new Point(11, 251);
      form1_0.listBox_0.Name = "secilen_liste";
      form1_0.listBox_0.Size = new Size(50, 173);
      form1_0.listBox_0.TabIndex = 214;
      form1_0.listBox_0.Visible = false;
      form1_0.listBox_1.BackColor = Color.Salmon;
      form1_0.listBox_1.ForeColor = SystemColors.Info;
      form1_0.listBox_1.FormattingEnabled = true;
      form1_0.listBox_1.Location = new Point(67, 85);
      form1_0.listBox_1.Name = "asıl_liste";
      form1_0.listBox_1.Size = new Size(33, 160);
      form1_0.listBox_1.TabIndex = 213;
      form1_0.listBox_1.Visible = false;
      form1_0.groupBox_6.BackColor = Color.Gray;
      form1_0.groupBox_6.Controls.Add((Control) form1_0.groupBox_7);
      form1_0.groupBox_6.Controls.Add((Control) form1_0.checkBox_3);
      form1_0.groupBox_6.Controls.Add((Control) form1_0.groupBox_8);
      form1_0.groupBox_6.Controls.Add((Control) form1_0.checkBox_4);
      form1_0.groupBox_6.ForeColor = SystemColors.Window;
      form1_0.groupBox_6.Location = new Point(137, 31);
      form1_0.groupBox_6.Name = "groupBox6";
      form1_0.groupBox_6.Size = new Size(325, 384);
      form1_0.groupBox_6.TabIndex = 56;
      form1_0.groupBox_6.TabStop = false;
      form1_0.groupBox_6.Text = "ÖDÜL AYARLARI";
      form1_0.groupBox_7.BackColor = Color.Gray;
      form1_0.groupBox_7.Controls.Add((Control) form1_0.textBox_92);
      form1_0.groupBox_7.Controls.Add((Control) form1_0.label_148);
      form1_0.groupBox_7.Controls.Add((Control) form1_0.label_33);
      form1_0.groupBox_7.Controls.Add((Control) form1_0.label_34);
      form1_0.groupBox_7.Controls.Add((Control) form1_0.label_35);
      form1_0.groupBox_7.Controls.Add((Control) form1_0.textBox_11);
      form1_0.groupBox_7.Controls.Add((Control) form1_0.textBox_12);
      form1_0.groupBox_7.Controls.Add((Control) form1_0.textBox_13);
      form1_0.groupBox_7.Enabled = false;
      form1_0.groupBox_7.ForeColor = SystemColors.Window;
      form1_0.groupBox_7.Location = new Point(25, 33);
      form1_0.groupBox_7.Name = "groupBox7";
      form1_0.groupBox_7.Size = new Size(268, 154);
      form1_0.groupBox_7.TabIndex = 9;
      form1_0.groupBox_7.TabStop = false;
      form1_0.groupBox_7.Text = "ITEM";
      form1_0.textBox_92.BackColor = Color.Salmon;
      form1_0.textBox_92.Location = new Point(26, 124);
      form1_0.textBox_92.Name = "textBox6";
      form1_0.textBox_92.Size = new Size(225, 21);
      form1_0.textBox_92.TabIndex = 44;
      form1_0.textBox_92.Text = "Sun Sword ( 1 Dg )";
      form1_0.textBox_92.TextAlign = HorizontalAlignment.Center;
      form1_0.label_148.AutoSize = true;
      form1_0.label_148.Location = new Point(110, 108);
      form1_0.label_148.Name = "label4";
      form1_0.label_148.Size = new Size(56, 13);
      form1_0.label_148.TabIndex = 43;
      form1_0.label_148.Text = "ITEM İSMİ";
      form1_0.label_33.AutoSize = true;
      form1_0.label_33.Location = new Point(206, 60);
      form1_0.label_33.Name = "label53";
      form1_0.label_33.Size = new Size(31, 13);
      form1_0.label_33.TabIndex = 41;
      form1_0.label_33.Text = "PLUS";
      form1_0.label_34.AutoSize = true;
      form1_0.label_34.Location = new Point(42, 57);
      form1_0.label_34.Name = "label61";
      form1_0.label_34.Size = new Size(33, 13);
      form1_0.label_34.TabIndex = 40;
      form1_0.label_34.Text = "ADET";
      form1_0.label_35.AutoSize = true;
      form1_0.label_35.Location = new Point(105, 14);
      form1_0.label_35.Name = "label63";
      form1_0.label_35.Size = new Size(62, 13);
      form1_0.label_35.TabIndex = 39;
      form1_0.label_35.Text = "ITEM KODU";
      form1_0.textBox_11.BackColor = Color.Salmon;
      form1_0.textBox_11.Location = new Point(186, 76);
      form1_0.textBox_11.Name = "textBox3";
      form1_0.textBox_11.Size = new Size(65, 21);
      form1_0.textBox_11.TabIndex = 8;
      form1_0.textBox_11.Text = "1";
      form1_0.textBox_11.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_11.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_12.BackColor = Color.Salmon;
      form1_0.textBox_12.Location = new Point(26, 73);
      form1_0.textBox_12.Name = "textBox4";
      form1_0.textBox_12.Size = new Size(74, 21);
      form1_0.textBox_12.TabIndex = 7;
      form1_0.textBox_12.Text = "1";
      form1_0.textBox_12.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_12.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_13.BackColor = Color.Salmon;
      form1_0.textBox_13.Location = new Point(26, 30);
      form1_0.textBox_13.Name = "textBox5";
      form1_0.textBox_13.Size = new Size(225, 21);
      form1_0.textBox_13.TabIndex = 4;
      form1_0.textBox_13.Text = "ITEM_CH_SWORD_01_C_RARE";
      form1_0.textBox_13.TextAlign = HorizontalAlignment.Center;
      form1_0.checkBox_3.AutoSize = true;
      form1_0.checkBox_3.Location = new Point(25, 193);
      form1_0.checkBox_3.Name = "checkBox7";
      form1_0.checkBox_3.Size = new Size(15, 14);
      form1_0.checkBox_3.TabIndex = 10;
      form1_0.checkBox_3.UseVisualStyleBackColor = true;
      form1_0.checkBox_3.CheckedChanged += new EventHandler(form1_0.method_26);
      form1_0.groupBox_8.BackColor = Color.Gray;
      form1_0.groupBox_8.Controls.Add((Control) form1_0.label_36);
      form1_0.groupBox_8.Controls.Add((Control) form1_0.label_37);
      form1_0.groupBox_8.Controls.Add((Control) form1_0.label_38);
      form1_0.groupBox_8.Controls.Add((Control) form1_0.textBox_14);
      form1_0.groupBox_8.Controls.Add((Control) form1_0.textBox_15);
      form1_0.groupBox_8.Controls.Add((Control) form1_0.textBox_16);
      form1_0.groupBox_8.Enabled = false;
      form1_0.groupBox_8.ForeColor = SystemColors.Window;
      form1_0.groupBox_8.Location = new Point(25, 212);
      form1_0.groupBox_8.Name = "groupBox8";
      form1_0.groupBox_8.Size = new Size(268, 166);
      form1_0.groupBox_8.TabIndex = 10;
      form1_0.groupBox_8.TabStop = false;
      form1_0.groupBox_8.Text = "SİLK- GOLD - SP";
      form1_0.label_36.AutoSize = true;
      form1_0.label_36.Location = new Point(112, 124);
      form1_0.label_36.Name = "label65";
      form1_0.label_36.Size = new Size(53, 13);
      form1_0.label_36.TabIndex = 38;
      form1_0.label_36.Text = "SP Miktarı";
      form1_0.label_37.AutoSize = true;
      form1_0.label_37.Location = new Point(96, 72);
      form1_0.label_37.Name = "label66";
      form1_0.label_37.Size = new Size(62, 13);
      form1_0.label_37.TabIndex = 37;
      form1_0.label_37.Text = "Gold Miktari";
      form1_0.label_38.AutoSize = true;
      form1_0.label_38.Location = new Point(102, 17);
      form1_0.label_38.Name = "label67";
      form1_0.label_38.Size = new Size(56, 13);
      form1_0.label_38.TabIndex = 36;
      form1_0.label_38.Text = "Silk Miktarı";
      form1_0.textBox_14.BackColor = Color.Salmon;
      form1_0.textBox_14.Location = new Point(45, 86);
      form1_0.textBox_14.MaxLength = 19;
      form1_0.textBox_14.Name = "textBox7";
      form1_0.textBox_14.Size = new Size(175, 21);
      form1_0.textBox_14.TabIndex = 6;
      form1_0.textBox_14.Text = "0";
      form1_0.textBox_14.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_14.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_15.BackColor = Color.Salmon;
      form1_0.textBox_15.Location = new Point(84, 140);
      form1_0.textBox_15.MaxLength = 19;
      form1_0.textBox_15.Name = "textBox8";
      form1_0.textBox_15.Size = new Size(97, 21);
      form1_0.textBox_15.TabIndex = 5;
      form1_0.textBox_15.Text = "0";
      form1_0.textBox_15.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_15.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_16.BackColor = Color.Salmon;
      form1_0.textBox_16.Location = new Point(96, 32);
      form1_0.textBox_16.MaxLength = 19;
      form1_0.textBox_16.Name = "textBox9";
      form1_0.textBox_16.Size = new Size(71, 21);
      form1_0.textBox_16.TabIndex = 4;
      form1_0.textBox_16.Text = "0";
      form1_0.textBox_16.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_16.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.checkBox_4.AutoSize = true;
      form1_0.checkBox_4.Location = new Point(25, 13);
      form1_0.checkBox_4.Name = "checkBox6";
      form1_0.checkBox_4.Size = new Size(15, 14);
      form1_0.checkBox_4.TabIndex = 9;
      form1_0.checkBox_4.UseVisualStyleBackColor = true;
      form1_0.checkBox_4.CheckedChanged += new EventHandler(form1_0.method_25);
      form1_0.listBox_11.BackColor = Color.Gray;
      form1_0.listBox_11.ForeColor = SystemColors.Window;
      form1_0.listBox_11.FormattingEnabled = true;
      form1_0.listBox_11.Location = new Point(5, 203);
      form1_0.listBox_11.Name = "uniq_bul_listBox";
      form1_0.listBox_11.Size = new Size(220, 212);
      form1_0.listBox_11.TabIndex = 61;
      form1_0.dateTimePicker_0.Format = DateTimePickerFormat.Time;
      form1_0.dateTimePicker_0.ImeMode = ImeMode.NoControl;
      form1_0.dateTimePicker_0.Location = new Point(121, 176);
      form1_0.dateTimePicker_0.Name = "UniqBul_Saat";
      form1_0.dateTimePicker_0.RightToLeft = RightToLeft.Yes;
      form1_0.dateTimePicker_0.ShowUpDown = true;
      form1_0.dateTimePicker_0.Size = new Size(104, 21);
      form1_0.dateTimePicker_0.TabIndex = 60;
      form1_0.label_39.AutoSize = true;
      form1_0.label_39.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.label_39.Location = new Point(150, 155);
      form1_0.label_39.Name = "label103";
      form1_0.label_39.Size = new Size(43, 20);
      form1_0.label_39.TabIndex = 58;
      form1_0.label_39.Text = "Saat";
      form1_0.label_40.AutoSize = true;
      form1_0.label_40.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.label_40.Location = new Point(40, 153);
      form1_0.label_40.Name = "label104";
      form1_0.label_40.Size = new Size(40, 20);
      form1_0.label_40.TabIndex = 57;
      form1_0.label_40.Text = "Gün";
      form1_0.groupBox_9.BackColor = Color.Gray;
      form1_0.groupBox_9.Controls.Add((Control) form1_0.comboBoxEdit_0);
      form1_0.groupBox_9.Controls.Add((Control) form1_0.label_108);
      form1_0.groupBox_9.Controls.Add((Control) form1_0.label_109);
      form1_0.groupBox_9.Controls.Add((Control) form1_0.checkBox_5);
      form1_0.groupBox_9.Controls.Add((Control) form1_0.label_41);
      form1_0.groupBox_9.ForeColor = SystemColors.Menu;
      form1_0.groupBox_9.Location = new Point(5, 6);
      form1_0.groupBox_9.Name = "groupBox10";
      form1_0.groupBox_9.Size = new Size(220, 141);
      form1_0.groupBox_9.TabIndex = 56;
      form1_0.groupBox_9.TabStop = false;
      form1_0.groupBox_9.Text = "GENEL AYARLAR";
      form1_0.groupBox_9.Enter += new EventHandler(form1_0.method_67);
      form1_0.comboBoxEdit_0.EditValue = (object) "Etkinlik Bölgesi Seçin";
      form1_0.comboBoxEdit_0.Location = new Point(26, 68);
      form1_0.comboBoxEdit_0.Name = "UniqBul_eventbölgesi";
      form1_0.comboBoxEdit_0.Properties.Appearance.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.comboBoxEdit_0.Properties.Appearance.ForeColor = Color.Salmon;
      form1_0.comboBoxEdit_0.Properties.Appearance.Options.UseBackColor = true;
      form1_0.comboBoxEdit_0.Properties.Appearance.Options.UseForeColor = true;
      form1_0.comboBoxEdit_0.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      form1_0.comboBoxEdit_0.Properties.Items.AddRange(new object[6]
      {
        (object) "Jangan",
        (object) "Donwhang",
        (object) "Hotan",
        (object) "Samarkand",
        (object) "Constantine",
        (object) "Alexandria"
      });
      form1_0.comboBoxEdit_0.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
      form1_0.comboBoxEdit_0.Size = new Size(162, 20);
      form1_0.comboBoxEdit_0.TabIndex = 61;
      form1_0.label_108.AutoSize = true;
      form1_0.label_108.Location = new Point(133, 122);
      form1_0.label_108.Name = "label119";
      form1_0.label_108.Size = new Size(13, 13);
      form1_0.label_108.TabIndex = 60;
      form1_0.label_108.Text = "0";
      form1_0.label_109.AutoSize = true;
      form1_0.label_109.Location = new Point(7, 122);
      form1_0.label_109.Name = "label120";
      form1_0.label_109.Size = new Size(125, 13);
      form1_0.label_109.TabIndex = 59;
      form1_0.label_109.Text = "Ortalama Etkinlik Süresi :";
      form1_0.checkBox_5.AutoSize = true;
      form1_0.checkBox_5.BackColor = Color.Transparent;
      form1_0.checkBox_5.Enabled = false;
      form1_0.checkBox_5.ForeColor = Color.Black;
      form1_0.checkBox_5.Location = new Point(115, 0);
      form1_0.checkBox_5.Name = "Unq_Bulma_basladımı";
      form1_0.checkBox_5.Size = new Size(105, 17);
      form1_0.checkBox_5.TabIndex = 57;
      form1_0.checkBox_5.Text = "Event Başladımı?";
      form1_0.checkBox_5.UseVisualStyleBackColor = false;
      form1_0.checkBox_5.Visible = false;
      form1_0.label_41.AutoSize = true;
      form1_0.label_41.Location = new Point(72, 50);
      form1_0.label_41.Name = "label105";
      form1_0.label_41.Size = new Size(71, 13);
      form1_0.label_41.TabIndex = 1;
      form1_0.label_41.Text = "Event Bölgesi";
      form1_0.xtraTabPage_2.Controls.Add((Control) form1_0.comboBoxEdit_5);
      form1_0.xtraTabPage_2.Controls.Add((Control) form1_0.button_7);
      form1_0.xtraTabPage_2.Controls.Add((Control) form1_0.button_8);
      form1_0.xtraTabPage_2.Controls.Add((Control) form1_0.textBox_24);
      form1_0.xtraTabPage_2.Controls.Add((Control) form1_0.groupBox_15);
      form1_0.xtraTabPage_2.Controls.Add((Control) form1_0.groupBox_16);
      form1_0.xtraTabPage_2.Controls.Add((Control) form1_0.listBox_3);
      form1_0.xtraTabPage_2.Controls.Add((Control) form1_0.dateTimePicker_1);
      form1_0.xtraTabPage_2.Controls.Add((Control) form1_0.label_50);
      form1_0.xtraTabPage_2.Controls.Add((Control) form1_0.label_51);
      form1_0.xtraTabPage_2.Image = (Image) componentResourceManager.GetObject("GM_BUL.Image");
      form1_0.xtraTabPage_2.Name = "GM_BUL";
      form1_0.xtraTabPage_2.Size = new Size(817, 753);
      form1_0.xtraTabPage_2.Text = "Kayıp GM";
      form1_0.xtraTabPage_2.Paint += new PaintEventHandler(form1_0.method_38);
      form1_0.comboBoxEdit_5.EditValue = (object) "Gün Seçin";
      form1_0.comboBoxEdit_5.Location = new Point(7, 176);
      form1_0.comboBoxEdit_5.Name = "GMBul_EventZamanı";
      form1_0.comboBoxEdit_5.Properties.Appearance.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.comboBoxEdit_5.Properties.Appearance.ForeColor = Color.Salmon;
      form1_0.comboBoxEdit_5.Properties.Appearance.Options.UseBackColor = true;
      form1_0.comboBoxEdit_5.Properties.Appearance.Options.UseForeColor = true;
      form1_0.comboBoxEdit_5.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      form1_0.comboBoxEdit_5.Properties.Items.AddRange(new object[7]
      {
        (object) "Pazartesi",
        (object) "Salı",
        (object) "Çarşamba",
        (object) "Perşembe",
        (object) "Cuma",
        (object) "Cumartesi",
        (object) "Pazar"
      });
      form1_0.comboBoxEdit_5.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
      form1_0.comboBoxEdit_5.Size = new Size(106, 20);
      form1_0.comboBoxEdit_5.TabIndex = 81;
      form1_0.button_7.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.button_7.BackgroundImageLayout = ImageLayout.Stretch;
      form1_0.button_7.FlatStyle = FlatStyle.Flat;
      form1_0.button_7.ForeColor = SystemColors.Window;
      form1_0.button_7.Location = new Point(121, 423);
      form1_0.button_7.Name = "button18";
      form1_0.button_7.Size = new Size(104, 24);
      form1_0.button_7.TabIndex = 78;
      form1_0.button_7.Text = "Sil";
      form1_0.button_7.UseVisualStyleBackColor = false;
      form1_0.button_7.Click += new EventHandler(form1_0.method_49);
      form1_0.button_8.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.button_8.BackgroundImageLayout = ImageLayout.Stretch;
      form1_0.button_8.FlatStyle = FlatStyle.Flat;
      form1_0.button_8.ForeColor = SystemColors.Window;
      form1_0.button_8.Location = new Point(5, 423);
      form1_0.button_8.Name = "button19";
      form1_0.button_8.Size = new Size(104, 24);
      form1_0.button_8.TabIndex = 77;
      form1_0.button_8.Text = "Ekle";
      form1_0.button_8.UseVisualStyleBackColor = false;
      form1_0.button_8.Click += new EventHandler(form1_0.method_48);
      form1_0.textBox_24.Location = new Point(180, 203);
      form1_0.textBox_24.Name = "textBox40";
      form1_0.textBox_24.Size = new Size(45, 21);
      form1_0.textBox_24.TabIndex = 76;
      form1_0.textBox_24.Visible = false;
      form1_0.groupBox_15.BackColor = Color.Gray;
      form1_0.groupBox_15.Controls.Add((Control) form1_0.label_139);
      form1_0.groupBox_15.Controls.Add((Control) form1_0.groupBox_33);
      form1_0.groupBox_15.Controls.Add((Control) form1_0.listBox_2);
      form1_0.groupBox_15.ForeColor = SystemColors.Window;
      form1_0.groupBox_15.Location = new Point(231, 6);
      form1_0.groupBox_15.Name = "groupBox12";
      form1_0.groupBox_15.Size = new Size(588, 440);
      form1_0.groupBox_15.TabIndex = 75;
      form1_0.groupBox_15.TabStop = false;
      form1_0.groupBox_15.Text = "ETKİNLİK AYARLARI";
      form1_0.label_139.AutoSize = true;
      form1_0.label_139.BackColor = Color.Transparent;
      form1_0.label_139.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      form1_0.label_139.ForeColor = Color.Salmon;
      form1_0.label_139.Location = new Point(18, 393);
      form1_0.label_139.Name = "label195";
      form1_0.label_139.Size = new Size(51, 16);
      form1_0.label_139.TabIndex = 218;
      form1_0.label_139.Text = "SAYIM";
      form1_0.label_139.Visible = false;
      form1_0.groupBox_33.BackColor = Color.Gray;
      form1_0.groupBox_33.Controls.Add((Control) form1_0.groupBox_34);
      form1_0.groupBox_33.Controls.Add((Control) form1_0.checkBox_15);
      form1_0.groupBox_33.Controls.Add((Control) form1_0.groupBox_35);
      form1_0.groupBox_33.Controls.Add((Control) form1_0.checkBox_16);
      form1_0.groupBox_33.ForeColor = SystemColors.Window;
      form1_0.groupBox_33.Location = new Point(137, 31);
      form1_0.groupBox_33.Name = "groupBox18";
      form1_0.groupBox_33.Size = new Size(325, 384);
      form1_0.groupBox_33.TabIndex = 217;
      form1_0.groupBox_33.TabStop = false;
      form1_0.groupBox_33.Text = "ÖDÜL AYARLARI";
      form1_0.groupBox_34.BackColor = Color.Gray;
      form1_0.groupBox_34.Controls.Add((Control) form1_0.textBox_93);
      form1_0.groupBox_34.Controls.Add((Control) form1_0.label_150);
      form1_0.groupBox_34.Controls.Add((Control) form1_0.label_94);
      form1_0.groupBox_34.Controls.Add((Control) form1_0.label_95);
      form1_0.groupBox_34.Controls.Add((Control) form1_0.label_96);
      form1_0.groupBox_34.Controls.Add((Control) form1_0.textBox_53);
      form1_0.groupBox_34.Controls.Add((Control) form1_0.textBox_54);
      form1_0.groupBox_34.Controls.Add((Control) form1_0.textBox_55);
      form1_0.groupBox_34.Enabled = false;
      form1_0.groupBox_34.ForeColor = SystemColors.Window;
      form1_0.groupBox_34.Location = new Point(29, 30);
      form1_0.groupBox_34.Name = "groupBox19";
      form1_0.groupBox_34.Size = new Size(268, 154);
      form1_0.groupBox_34.TabIndex = 9;
      form1_0.groupBox_34.TabStop = false;
      form1_0.groupBox_34.Text = "ITEM";
      form1_0.textBox_93.BackColor = Color.Salmon;
      form1_0.textBox_93.Location = new Point(26, 122);
      form1_0.textBox_93.Name = "textBox26";
      form1_0.textBox_93.Size = new Size(222, 21);
      form1_0.textBox_93.TabIndex = 46;
      form1_0.textBox_93.Text = "Sun Sword ( 1 Dg )";
      form1_0.textBox_93.TextAlign = HorizontalAlignment.Center;
      form1_0.label_150.AutoSize = true;
      form1_0.label_150.Location = new Point(111, 106);
      form1_0.label_150.Name = "label110";
      form1_0.label_150.Size = new Size(56, 13);
      form1_0.label_150.TabIndex = 45;
      form1_0.label_150.Text = "ITEM İSMİ";
      form1_0.label_94.AutoSize = true;
      form1_0.label_94.Location = new Point(203, 60);
      form1_0.label_94.Name = "label81";
      form1_0.label_94.Size = new Size(31, 13);
      form1_0.label_94.TabIndex = 41;
      form1_0.label_94.Text = "PLUS";
      form1_0.label_95.AutoSize = true;
      form1_0.label_95.Location = new Point(42, 60);
      form1_0.label_95.Name = "label84";
      form1_0.label_95.Size = new Size(33, 13);
      form1_0.label_95.TabIndex = 40;
      form1_0.label_95.Text = "ADET";
      form1_0.label_96.AutoSize = true;
      form1_0.label_96.Location = new Point(101, 14);
      form1_0.label_96.Name = "label109";
      form1_0.label_96.Size = new Size(62, 13);
      form1_0.label_96.TabIndex = 39;
      form1_0.label_96.Text = "ITEM KODU";
      form1_0.textBox_53.BackColor = Color.Salmon;
      form1_0.textBox_53.Location = new Point(183, 76);
      form1_0.textBox_53.Name = "textBox13";
      form1_0.textBox_53.Size = new Size(65, 21);
      form1_0.textBox_53.TabIndex = 8;
      form1_0.textBox_53.Text = "1";
      form1_0.textBox_53.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_53.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_54.BackColor = Color.Salmon;
      form1_0.textBox_54.Location = new Point(26, 76);
      form1_0.textBox_54.Name = "textBox16";
      form1_0.textBox_54.Size = new Size(74, 21);
      form1_0.textBox_54.TabIndex = 7;
      form1_0.textBox_54.Text = "1";
      form1_0.textBox_54.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_54.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_55.BackColor = Color.Salmon;
      form1_0.textBox_55.Location = new Point(26, 30);
      form1_0.textBox_55.Name = "textBox17";
      form1_0.textBox_55.Size = new Size(222, 21);
      form1_0.textBox_55.TabIndex = 4;
      form1_0.textBox_55.Text = "ITEM_CH_SWORD_01_C_RARE";
      form1_0.textBox_55.TextAlign = HorizontalAlignment.Center;
      form1_0.checkBox_15.AutoSize = true;
      form1_0.checkBox_15.Location = new Point(29, 193);
      form1_0.checkBox_15.Name = "GMbul_ÖdülTİpi_SGSR";
      form1_0.checkBox_15.Size = new Size(15, 14);
      form1_0.checkBox_15.TabIndex = 10;
      form1_0.checkBox_15.UseVisualStyleBackColor = true;
      form1_0.checkBox_15.CheckedChanged += new EventHandler(form1_0.method_32);
      form1_0.groupBox_35.BackColor = Color.Gray;
      form1_0.groupBox_35.Controls.Add((Control) form1_0.label_97);
      form1_0.groupBox_35.Controls.Add((Control) form1_0.label_98);
      form1_0.groupBox_35.Controls.Add((Control) form1_0.label_99);
      form1_0.groupBox_35.Controls.Add((Control) form1_0.textBox_56);
      form1_0.groupBox_35.Controls.Add((Control) form1_0.textBox_57);
      form1_0.groupBox_35.Controls.Add((Control) form1_0.textBox_58);
      form1_0.groupBox_35.Enabled = false;
      form1_0.groupBox_35.ForeColor = SystemColors.Window;
      form1_0.groupBox_35.Location = new Point(29, 213);
      form1_0.groupBox_35.Name = "groupBox20";
      form1_0.groupBox_35.Size = new Size(268, 165);
      form1_0.groupBox_35.TabIndex = 10;
      form1_0.groupBox_35.TabStop = false;
      form1_0.groupBox_35.Text = "SİLK- GOLD - SP";
      form1_0.label_97.AutoSize = true;
      form1_0.label_97.Location = new Point(120, 112);
      form1_0.label_97.Name = "label114";
      form1_0.label_97.Size = new Size(53, 13);
      form1_0.label_97.TabIndex = 38;
      form1_0.label_97.Text = "SP Miktarı";
      form1_0.label_98.AutoSize = true;
      form1_0.label_98.Location = new Point(104, 62);
      form1_0.label_98.Name = "label115";
      form1_0.label_98.Size = new Size(62, 13);
      form1_0.label_98.TabIndex = 37;
      form1_0.label_98.Text = "Gold Miktari";
      form1_0.label_99.AutoSize = true;
      form1_0.label_99.Location = new Point(110, 13);
      form1_0.label_99.Name = "label116";
      form1_0.label_99.Size = new Size(56, 13);
      form1_0.label_99.TabIndex = 36;
      form1_0.label_99.Text = "Silk Miktarı";
      form1_0.textBox_56.BackColor = Color.Salmon;
      form1_0.textBox_56.Location = new Point(65, 76);
      form1_0.textBox_56.MaxLength = 19;
      form1_0.textBox_56.Name = "textBox27";
      form1_0.textBox_56.Size = new Size(151, 21);
      form1_0.textBox_56.TabIndex = 6;
      form1_0.textBox_56.Text = "0";
      form1_0.textBox_56.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_56.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_57.BackColor = Color.Salmon;
      form1_0.textBox_57.Location = new Point(92, 128);
      form1_0.textBox_57.MaxLength = 19;
      form1_0.textBox_57.Name = "textBox28";
      form1_0.textBox_57.Size = new Size(97, 21);
      form1_0.textBox_57.TabIndex = 5;
      form1_0.textBox_57.Text = "0";
      form1_0.textBox_57.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_57.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_58.BackColor = Color.Salmon;
      form1_0.textBox_58.Location = new Point(104, 28);
      form1_0.textBox_58.MaxLength = 19;
      form1_0.textBox_58.Name = "textBox30";
      form1_0.textBox_58.Size = new Size(71, 21);
      form1_0.textBox_58.TabIndex = 4;
      form1_0.textBox_58.Text = "0";
      form1_0.textBox_58.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_58.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.checkBox_16.AutoSize = true;
      form1_0.checkBox_16.Location = new Point(30, 16);
      form1_0.checkBox_16.Name = "GMbul_ÖdülTİpi_ITEM";
      form1_0.checkBox_16.Size = new Size(15, 14);
      form1_0.checkBox_16.TabIndex = 9;
      form1_0.checkBox_16.UseVisualStyleBackColor = true;
      form1_0.checkBox_16.CheckedChanged += new EventHandler(form1_0.method_31);
      form1_0.listBox_2.FormattingEnabled = true;
      form1_0.listBox_2.Location = new Point(86, 379);
      form1_0.listBox_2.Name = "GMbul_secilen_liste";
      form1_0.listBox_2.Size = new Size(251, 43);
      form1_0.listBox_2.TabIndex = 214;
      form1_0.listBox_2.Visible = false;
      form1_0.groupBox_16.BackColor = Color.Gray;
      form1_0.groupBox_16.Controls.Add((Control) form1_0.comboBoxEdit_1);
      form1_0.groupBox_16.Controls.Add((Control) form1_0.label_110);
      form1_0.groupBox_16.Controls.Add((Control) form1_0.label_111);
      form1_0.groupBox_16.Controls.Add((Control) form1_0.textBox_52);
      form1_0.groupBox_16.Controls.Add((Control) form1_0.checkBox_8);
      form1_0.groupBox_16.Controls.Add((Control) form1_0.label_49);
      form1_0.groupBox_16.ForeColor = SystemColors.Menu;
      form1_0.groupBox_16.Location = new Point(5, 6);
      form1_0.groupBox_16.Name = "groupBox21";
      form1_0.groupBox_16.Size = new Size(220, 141);
      form1_0.groupBox_16.TabIndex = 74;
      form1_0.groupBox_16.TabStop = false;
      form1_0.groupBox_16.Text = "GENEL AYARLAR";
      form1_0.comboBoxEdit_1.EditValue = (object) "Etkinlik Bölgesi Seçin";
      form1_0.comboBoxEdit_1.Location = new Point(26, 64);
      form1_0.comboBoxEdit_1.Name = "GMbul_Bölge";
      form1_0.comboBoxEdit_1.Properties.Appearance.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.comboBoxEdit_1.Properties.Appearance.ForeColor = Color.Salmon;
      form1_0.comboBoxEdit_1.Properties.Appearance.Options.UseBackColor = true;
      form1_0.comboBoxEdit_1.Properties.Appearance.Options.UseForeColor = true;
      form1_0.comboBoxEdit_1.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      form1_0.comboBoxEdit_1.Properties.Items.AddRange(new object[6]
      {
        (object) "Jangan",
        (object) "Donwhang",
        (object) "Hotan",
        (object) "Samarkand",
        (object) "Constantine",
        (object) "Alexandria"
      });
      form1_0.comboBoxEdit_1.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
      form1_0.comboBoxEdit_1.Size = new Size(162, 20);
      form1_0.comboBoxEdit_1.TabIndex = 80;
      form1_0.label_110.AutoSize = true;
      form1_0.label_110.Location = new Point(146, 121);
      form1_0.label_110.Name = "label144";
      form1_0.label_110.Size = new Size(13, 13);
      form1_0.label_110.TabIndex = 79;
      form1_0.label_110.Text = "0";
      form1_0.label_111.AutoSize = true;
      form1_0.label_111.Location = new Point(20, 120);
      form1_0.label_111.Name = "label161";
      form1_0.label_111.Size = new Size(125, 13);
      form1_0.label_111.TabIndex = 78;
      form1_0.label_111.Text = "Ortalama Etkinlik Süresi :";
      form1_0.textBox_52.Location = new Point(5, 31);
      form1_0.textBox_52.Name = "kacıncı_tur";
      form1_0.textBox_52.Size = new Size(45, 21);
      form1_0.textBox_52.TabIndex = 77;
      form1_0.textBox_52.Text = "1";
      form1_0.textBox_52.Visible = false;
      form1_0.checkBox_8.AutoSize = true;
      form1_0.checkBox_8.BackColor = Color.Transparent;
      form1_0.checkBox_8.ForeColor = Color.Black;
      form1_0.checkBox_8.Location = new Point(103, 0);
      form1_0.checkBox_8.Name = "GM_Bulma_basladımı";
      form1_0.checkBox_8.Size = new Size(105, 17);
      form1_0.checkBox_8.TabIndex = 57;
      form1_0.checkBox_8.Text = "Event Başladımı?";
      form1_0.checkBox_8.UseVisualStyleBackColor = false;
      form1_0.checkBox_8.Visible = false;
      form1_0.label_49.AutoSize = true;
      form1_0.label_49.Location = new Point(72, 46);
      form1_0.label_49.Name = "label123";
      form1_0.label_49.Size = new Size(71, 13);
      form1_0.label_49.TabIndex = 1;
      form1_0.label_49.Text = "Event Bölgesi";
      form1_0.listBox_3.BackColor = Color.Gray;
      form1_0.listBox_3.ForeColor = SystemColors.Window;
      form1_0.listBox_3.FormattingEnabled = true;
      form1_0.listBox_3.Location = new Point(5, 203);
      form1_0.listBox_3.Name = "GMBul_listBox";
      form1_0.listBox_3.Size = new Size(220, 212);
      form1_0.listBox_3.TabIndex = 70;
      form1_0.dateTimePicker_1.Format = DateTimePickerFormat.Time;
      form1_0.dateTimePicker_1.ImeMode = ImeMode.NoControl;
      form1_0.dateTimePicker_1.Location = new Point(121, 176);
      form1_0.dateTimePicker_1.Name = "GMBul__Saat";
      form1_0.dateTimePicker_1.RightToLeft = RightToLeft.Yes;
      form1_0.dateTimePicker_1.ShowUpDown = true;
      form1_0.dateTimePicker_1.Size = new Size(104, 21);
      form1_0.dateTimePicker_1.TabIndex = 69;
      form1_0.dateTimePicker_1.ValueChanged += new EventHandler(form1_0.method_88);
      form1_0.label_50.AutoSize = true;
      form1_0.label_50.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.label_50.Location = new Point(150, 155);
      form1_0.label_50.Name = "label127";
      form1_0.label_50.Size = new Size(43, 20);
      form1_0.label_50.TabIndex = 67;
      form1_0.label_50.Text = "Saat";
      form1_0.label_51.AutoSize = true;
      form1_0.label_51.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.label_51.Location = new Point(40, 153);
      form1_0.label_51.Name = "label128";
      form1_0.label_51.Size = new Size(40, 20);
      form1_0.label_51.TabIndex = 66;
      form1_0.label_51.Text = "Gün";
      form1_0.xtraTabPage_3.Controls.Add((Control) form1_0.comboBoxEdit_6);
      form1_0.xtraTabPage_3.Controls.Add((Control) form1_0.groupBox_17);
      form1_0.xtraTabPage_3.Controls.Add((Control) form1_0.button_9);
      form1_0.xtraTabPage_3.Controls.Add((Control) form1_0.button_10);
      form1_0.xtraTabPage_3.Controls.Add((Control) form1_0.textBox_26);
      form1_0.xtraTabPage_3.Controls.Add((Control) form1_0.listBox_4);
      form1_0.xtraTabPage_3.Controls.Add((Control) form1_0.dateTimePicker_2);
      form1_0.xtraTabPage_3.Controls.Add((Control) form1_0.label_56);
      form1_0.xtraTabPage_3.Controls.Add((Control) form1_0.label_57);
      form1_0.xtraTabPage_3.Controls.Add((Control) form1_0.groupBox_19);
      form1_0.xtraTabPage_3.Image = (Image) componentResourceManager.GetObject("ACLHEMY.Image");
      form1_0.xtraTabPage_3.Name = "ACLHEMY";
      form1_0.xtraTabPage_3.Size = new Size(817, 753);
      form1_0.xtraTabPage_3.Text = "Alchemy (+ Basma)";
      form1_0.xtraTabPage_3.Paint += new PaintEventHandler(form1_0.method_39);
      form1_0.comboBoxEdit_6.EditValue = (object) "Gün Seçin";
      form1_0.comboBoxEdit_6.Location = new Point(3, 174);
      form1_0.comboBoxEdit_6.Name = "Alchemy_EventZamanı";
      form1_0.comboBoxEdit_6.Properties.Appearance.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.comboBoxEdit_6.Properties.Appearance.ForeColor = Color.Salmon;
      form1_0.comboBoxEdit_6.Properties.Appearance.Options.UseBackColor = true;
      form1_0.comboBoxEdit_6.Properties.Appearance.Options.UseForeColor = true;
      form1_0.comboBoxEdit_6.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      form1_0.comboBoxEdit_6.Properties.Items.AddRange(new object[7]
      {
        (object) "Pazartesi",
        (object) "Salı",
        (object) "Çarşamba",
        (object) "Perşembe",
        (object) "Cuma",
        (object) "Cumartesi",
        (object) "Pazar"
      });
      form1_0.comboBoxEdit_6.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
      form1_0.comboBoxEdit_6.Size = new Size(106, 20);
      form1_0.comboBoxEdit_6.TabIndex = 82;
      form1_0.groupBox_17.BackColor = Color.Gray;
      form1_0.groupBox_17.Controls.Add((Control) form1_0.groupBox_36);
      form1_0.groupBox_17.Controls.Add((Control) form1_0.groupBox_18);
      form1_0.groupBox_17.ForeColor = SystemColors.Window;
      form1_0.groupBox_17.Location = new Point(230, 7);
      form1_0.groupBox_17.Name = "groupBox2";
      form1_0.groupBox_17.Size = new Size(590, 439);
      form1_0.groupBox_17.TabIndex = 65;
      form1_0.groupBox_17.TabStop = false;
      form1_0.groupBox_17.Text = "ETKİNLİK AYARLARI";
      form1_0.groupBox_36.BackColor = Color.Gray;
      form1_0.groupBox_36.Controls.Add((Control) form1_0.groupBox_37);
      form1_0.groupBox_36.Controls.Add((Control) form1_0.checkBox_17);
      form1_0.groupBox_36.Controls.Add((Control) form1_0.groupBox_38);
      form1_0.groupBox_36.Controls.Add((Control) form1_0.checkBox_18);
      form1_0.groupBox_36.ForeColor = SystemColors.Window;
      form1_0.groupBox_36.Location = new Point(353, 34);
      form1_0.groupBox_36.Name = "groupBox24";
      form1_0.groupBox_36.Size = new Size(230, 378);
      form1_0.groupBox_36.TabIndex = 218;
      form1_0.groupBox_36.TabStop = false;
      form1_0.groupBox_36.Text = "ÖDÜL AYARLARI";
      form1_0.groupBox_37.BackColor = Color.Gray;
      form1_0.groupBox_37.Controls.Add((Control) form1_0.textBox_94);
      form1_0.groupBox_37.Controls.Add((Control) form1_0.label_151);
      form1_0.groupBox_37.Controls.Add((Control) form1_0.label_100);
      form1_0.groupBox_37.Controls.Add((Control) form1_0.label_101);
      form1_0.groupBox_37.Controls.Add((Control) form1_0.label_102);
      form1_0.groupBox_37.Controls.Add((Control) form1_0.textBox_59);
      form1_0.groupBox_37.Controls.Add((Control) form1_0.textBox_60);
      form1_0.groupBox_37.Controls.Add((Control) form1_0.textBox_61);
      form1_0.groupBox_37.Enabled = false;
      form1_0.groupBox_37.ForeColor = SystemColors.Window;
      form1_0.groupBox_37.Location = new Point(4, 33);
      form1_0.groupBox_37.Name = "groupBox25";
      form1_0.groupBox_37.Size = new Size(220, 148);
      form1_0.groupBox_37.TabIndex = 9;
      form1_0.groupBox_37.TabStop = false;
      form1_0.groupBox_37.Text = "ITEM";
      form1_0.textBox_94.BackColor = Color.Salmon;
      form1_0.textBox_94.Location = new Point(26, 118);
      form1_0.textBox_94.Name = "textBox36";
      form1_0.textBox_94.Size = new Size(174, 21);
      form1_0.textBox_94.TabIndex = 48;
      form1_0.textBox_94.Text = "Sun Sword ( 1 Dg )";
      form1_0.textBox_94.TextAlign = HorizontalAlignment.Center;
      form1_0.label_151.AutoSize = true;
      form1_0.label_151.Location = new Point(84, 104);
      form1_0.label_151.Name = "label19";
      form1_0.label_151.Size = new Size(56, 13);
      form1_0.label_151.TabIndex = 47;
      form1_0.label_151.Text = "ITEM İSMİ";
      form1_0.label_100.AutoSize = true;
      form1_0.label_100.Location = new Point(155, 57);
      form1_0.label_100.Name = "label16";
      form1_0.label_100.Size = new Size(31, 13);
      form1_0.label_100.TabIndex = 41;
      form1_0.label_100.Text = "PLUS";
      form1_0.label_101.AutoSize = true;
      form1_0.label_101.Location = new Point(43, 57);
      form1_0.label_101.Name = "label17";
      form1_0.label_101.Size = new Size(33, 13);
      form1_0.label_101.TabIndex = 40;
      form1_0.label_101.Text = "ADET";
      form1_0.label_102.AutoSize = true;
      form1_0.label_102.Location = new Point(79, 14);
      form1_0.label_102.Name = "label18";
      form1_0.label_102.Size = new Size(62, 13);
      form1_0.label_102.TabIndex = 39;
      form1_0.label_102.Text = "ITEM KODU";
      form1_0.textBox_59.BackColor = Color.Salmon;
      form1_0.textBox_59.Location = new Point(135, 73);
      form1_0.textBox_59.Name = "textBox31";
      form1_0.textBox_59.Size = new Size(65, 21);
      form1_0.textBox_59.TabIndex = 8;
      form1_0.textBox_59.Text = "1";
      form1_0.textBox_59.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_59.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_60.BackColor = Color.Salmon;
      form1_0.textBox_60.Location = new Point(26, 73);
      form1_0.textBox_60.Name = "textBox32";
      form1_0.textBox_60.Size = new Size(74, 21);
      form1_0.textBox_60.TabIndex = 7;
      form1_0.textBox_60.Text = "1";
      form1_0.textBox_60.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_60.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_61.BackColor = Color.Salmon;
      form1_0.textBox_61.Location = new Point(26, 30);
      form1_0.textBox_61.Name = "textBox34";
      form1_0.textBox_61.Size = new Size(174, 21);
      form1_0.textBox_61.TabIndex = 4;
      form1_0.textBox_61.Text = "ITEM_CH_SWORD_01_C_RARE";
      form1_0.textBox_61.TextAlign = HorizontalAlignment.Center;
      form1_0.checkBox_17.AutoSize = true;
      form1_0.checkBox_17.Location = new Point(6, 186);
      form1_0.checkBox_17.Name = "Alchemy_Ödül_Tipi_SGSR";
      form1_0.checkBox_17.Size = new Size(15, 14);
      form1_0.checkBox_17.TabIndex = 10;
      form1_0.checkBox_17.UseVisualStyleBackColor = true;
      form1_0.checkBox_17.CheckedChanged += new EventHandler(form1_0.method_34);
      form1_0.groupBox_38.BackColor = Color.Gray;
      form1_0.groupBox_38.Controls.Add((Control) form1_0.label_103);
      form1_0.groupBox_38.Controls.Add((Control) form1_0.label_104);
      form1_0.groupBox_38.Controls.Add((Control) form1_0.label_105);
      form1_0.groupBox_38.Controls.Add((Control) form1_0.textBox_62);
      form1_0.groupBox_38.Controls.Add((Control) form1_0.textBox_63);
      form1_0.groupBox_38.Controls.Add((Control) form1_0.textBox_64);
      form1_0.groupBox_38.Enabled = false;
      form1_0.groupBox_38.ForeColor = SystemColors.Window;
      form1_0.groupBox_38.Location = new Point(7, 203);
      form1_0.groupBox_38.Name = "groupBox26";
      form1_0.groupBox_38.Size = new Size(217, 166);
      form1_0.groupBox_38.TabIndex = 10;
      form1_0.groupBox_38.TabStop = false;
      form1_0.groupBox_38.Text = "SİLK- GOLD - SP";
      form1_0.label_103.AutoSize = true;
      form1_0.label_103.Location = new Point(98, 116);
      form1_0.label_103.Name = "label20";
      form1_0.label_103.Size = new Size(53, 13);
      form1_0.label_103.TabIndex = 38;
      form1_0.label_103.Text = "SP Miktarı";
      form1_0.label_104.AutoSize = true;
      form1_0.label_104.Location = new Point(82, 66);
      form1_0.label_104.Name = "label21";
      form1_0.label_104.Size = new Size(62, 13);
      form1_0.label_104.TabIndex = 37;
      form1_0.label_104.Text = "Gold Miktari";
      form1_0.label_105.AutoSize = true;
      form1_0.label_105.Location = new Point(88, 17);
      form1_0.label_105.Name = "label22";
      form1_0.label_105.Size = new Size(56, 13);
      form1_0.label_105.TabIndex = 36;
      form1_0.label_105.Text = "Silk Miktarı";
      form1_0.textBox_62.BackColor = Color.Salmon;
      form1_0.textBox_62.Location = new Point(43, 80);
      form1_0.textBox_62.MaxLength = 19;
      form1_0.textBox_62.Name = "textBox38";
      form1_0.textBox_62.Size = new Size(154, 21);
      form1_0.textBox_62.TabIndex = 6;
      form1_0.textBox_62.Text = "0";
      form1_0.textBox_62.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_62.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_63.BackColor = Color.Salmon;
      form1_0.textBox_63.Location = new Point(70, 132);
      form1_0.textBox_63.MaxLength = 19;
      form1_0.textBox_63.Name = "textBox45";
      form1_0.textBox_63.Size = new Size(97, 21);
      form1_0.textBox_63.TabIndex = 5;
      form1_0.textBox_63.Text = "0";
      form1_0.textBox_63.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_63.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_64.BackColor = Color.Salmon;
      form1_0.textBox_64.Location = new Point(82, 32);
      form1_0.textBox_64.MaxLength = 19;
      form1_0.textBox_64.Name = "textBox46";
      form1_0.textBox_64.Size = new Size(71, 21);
      form1_0.textBox_64.TabIndex = 4;
      form1_0.textBox_64.Text = "0";
      form1_0.textBox_64.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_64.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.checkBox_18.AutoSize = true;
      form1_0.checkBox_18.Location = new Point(7, 16);
      form1_0.checkBox_18.Name = "Alchemy_Ödül_Tipi_İTEM";
      form1_0.checkBox_18.Size = new Size(15, 14);
      form1_0.checkBox_18.TabIndex = 9;
      form1_0.checkBox_18.UseVisualStyleBackColor = true;
      form1_0.checkBox_18.CheckedChanged += new EventHandler(form1_0.method_33);
      form1_0.groupBox_18.BackColor = Color.Gray;
      form1_0.groupBox_18.Controls.Add((Control) form1_0.label_165);
      form1_0.groupBox_18.Controls.Add((Control) form1_0.comboBox_0);
      form1_0.groupBox_18.Controls.Add((Control) form1_0.comboBox_2);
      form1_0.groupBox_18.Controls.Add((Control) form1_0.label_52);
      form1_0.groupBox_18.Controls.Add((Control) form1_0.label_53);
      form1_0.groupBox_18.Controls.Add((Control) form1_0.label_54);
      form1_0.groupBox_18.Controls.Add((Control) form1_0.textBox_25);
      form1_0.groupBox_18.Controls.Add((Control) form1_0.label_55);
      form1_0.groupBox_18.ForeColor = SystemColors.Window;
      form1_0.groupBox_18.Location = new Point(16, 34);
      form1_0.groupBox_18.Name = "groupBox34";
      form1_0.groupBox_18.Size = new Size(331, 378);
      form1_0.groupBox_18.TabIndex = 212;
      form1_0.groupBox_18.TabStop = false;
      form1_0.groupBox_18.Text = "GENEL AYARLAR";
      form1_0.label_165.AutoSize = true;
      form1_0.label_165.Location = new Point(72, 283);
      form1_0.label_165.Name = "label25";
      form1_0.label_165.Size = new Size(173, 13);
      form1_0.label_165.TabIndex = 212;
      form1_0.label_165.Text = "( Ara droplarda da bu sayı geçerli )";
      form1_0.comboBox_0.BackColor = Color.Salmon;
      form1_0.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
      form1_0.comboBox_0.FlatStyle = FlatStyle.Popup;
      form1_0.comboBox_0.ForeColor = SystemColors.ActiveCaptionText;
      form1_0.comboBox_0.FormattingEnabled = true;
      form1_0.comboBox_0.Items.AddRange(new object[30]
      {
        (object) "1",
        (object) "2",
        (object) "3",
        (object) "4",
        (object) "5",
        (object) "6",
        (object) "7",
        (object) "8",
        (object) "9",
        (object) "10",
        (object) "11",
        (object) "12",
        (object) "13",
        (object) "14",
        (object) "15",
        (object) "16",
        (object) "17",
        (object) "18",
        (object) "19",
        (object) "20",
        (object) "21",
        (object) "22",
        (object) "23",
        (object) "24",
        (object) "25",
        (object) "26",
        (object) "27",
        (object) "28",
        (object) "29",
        (object) "30"
      });
      form1_0.comboBox_0.Location = new Point(208, 177);
      form1_0.comboBox_0.Name = "Alchemy_ÖdülKazanacakPLUS";
      form1_0.comboBox_0.Size = new Size(53, 21);
      form1_0.comboBox_0.TabIndex = 211;
      form1_0.comboBox_2.BackColor = Color.Salmon;
      form1_0.comboBox_2.DropDownStyle = ComboBoxStyle.DropDownList;
      form1_0.comboBox_2.FlatStyle = FlatStyle.Popup;
      form1_0.comboBox_2.ForeColor = SystemColors.ActiveCaptionText;
      form1_0.comboBox_2.FormattingEnabled = true;
      form1_0.comboBox_2.Items.AddRange(new object[9]
      {
        (object) "0",
        (object) "1",
        (object) "2",
        (object) "3",
        (object) "4",
        (object) "5",
        (object) "6",
        (object) "7",
        (object) "8"
      });
      form1_0.comboBox_2.Location = new Point(206, 103);
      form1_0.comboBox_2.Name = "Alchemy_DropEdilecekPLUS";
      form1_0.comboBox_2.Size = new Size(53, 21);
      form1_0.comboBox_2.TabIndex = 57;
      form1_0.label_52.AutoSize = true;
      form1_0.label_52.ForeColor = SystemColors.Window;
      form1_0.label_52.Location = new Point(20, 106);
      form1_0.label_52.Name = "label141";
      form1_0.label_52.Size = new Size(182, 13);
      form1_0.label_52.TabIndex = 3;
      form1_0.label_52.Text = "Drop Edilecek İtem Plus Değeri  ==>";
      form1_0.label_53.AutoSize = true;
      form1_0.label_53.ForeColor = SystemColors.Window;
      form1_0.label_53.Location = new Point(19, 180);
      form1_0.label_53.Name = "label28";
      form1_0.label_53.Size = new Size(183, 13);
      form1_0.label_53.TabIndex = 210;
      form1_0.label_53.Text = "Sıralamaya girecek minimum Plus => ";
      form1_0.label_54.AutoSize = true;
      form1_0.label_54.Location = new Point(185, 254);
      form1_0.label_54.Name = "label27";
      form1_0.label_54.Size = new Size(97, 13);
      form1_0.label_54.TabIndex = 208;
      form1_0.label_54.Text = " Adet İtem Drop Et";
      form1_0.textBox_25.BackColor = Color.Salmon;
      form1_0.textBox_25.ForeColor = SystemColors.Window;
      form1_0.textBox_25.Location = new Point(132, 251);
      form1_0.textBox_25.Multiline = true;
      form1_0.textBox_25.Name = "Alchemy_ToplamDrop";
      form1_0.textBox_25.Size = new Size(50, 20);
      form1_0.textBox_25.TabIndex = 165;
      form1_0.textBox_25.Text = "30";
      form1_0.textBox_25.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_25.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.label_55.AutoSize = true;
      form1_0.label_55.ForeColor = SystemColors.Window;
      form1_0.label_55.Location = new Point(31, 254);
      form1_0.label_55.Name = "label24";
      form1_0.label_55.Size = new Size(95, 13);
      form1_0.label_55.TabIndex = 204;
      form1_0.label_55.Text = "Her Turda Toplam \r\n";
      form1_0.button_9.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.button_9.BackgroundImageLayout = ImageLayout.Stretch;
      form1_0.button_9.FlatStyle = FlatStyle.Flat;
      form1_0.button_9.ForeColor = SystemColors.Window;
      form1_0.button_9.Location = new Point(120, 422);
      form1_0.button_9.Name = "button16";
      form1_0.button_9.Size = new Size(104, 24);
      form1_0.button_9.TabIndex = 64;
      form1_0.button_9.Text = "Sil";
      form1_0.button_9.UseVisualStyleBackColor = false;
      form1_0.button_9.Click += new EventHandler(form1_0.method_52);
      form1_0.button_10.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.button_10.BackgroundImageLayout = ImageLayout.Stretch;
      form1_0.button_10.FlatStyle = FlatStyle.Flat;
      form1_0.button_10.ForeColor = SystemColors.Window;
      form1_0.button_10.Location = new Point(5, 422);
      form1_0.button_10.Name = "button17";
      form1_0.button_10.Size = new Size(103, 24);
      form1_0.button_10.TabIndex = 63;
      form1_0.button_10.Text = "Ekle";
      form1_0.button_10.UseVisualStyleBackColor = false;
      form1_0.button_10.Click += new EventHandler(form1_0.method_57);
      form1_0.textBox_26.Location = new Point(179, 201);
      form1_0.textBox_26.Name = "textBox88";
      form1_0.textBox_26.Size = new Size(45, 21);
      form1_0.textBox_26.TabIndex = 62;
      form1_0.textBox_26.Visible = false;
      form1_0.listBox_4.BackColor = Color.Gray;
      form1_0.listBox_4.BorderStyle = BorderStyle.FixedSingle;
      form1_0.listBox_4.ForeColor = SystemColors.Window;
      form1_0.listBox_4.FormattingEnabled = true;
      form1_0.listBox_4.Location = new Point(4, 201);
      form1_0.listBox_4.Name = "Alchemy_listBox";
      form1_0.listBox_4.Size = new Size(220, 210);
      form1_0.listBox_4.TabIndex = 61;
      form1_0.dateTimePicker_2.Format = DateTimePickerFormat.Time;
      form1_0.dateTimePicker_2.ImeMode = ImeMode.NoControl;
      form1_0.dateTimePicker_2.Location = new Point(120, 174);
      form1_0.dateTimePicker_2.Name = "Alchemy_Saat";
      form1_0.dateTimePicker_2.RightToLeft = RightToLeft.Yes;
      form1_0.dateTimePicker_2.ShowUpDown = true;
      form1_0.dateTimePicker_2.Size = new Size(104, 21);
      form1_0.dateTimePicker_2.TabIndex = 60;
      form1_0.label_56.AutoSize = true;
      form1_0.label_56.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.label_56.Location = new Point(149, 153);
      form1_0.label_56.Name = "label142";
      form1_0.label_56.Size = new Size(43, 20);
      form1_0.label_56.TabIndex = 58;
      form1_0.label_56.Text = "Saat";
      form1_0.label_57.AutoSize = true;
      form1_0.label_57.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.label_57.Location = new Point(39, 151);
      form1_0.label_57.Name = "label143";
      form1_0.label_57.Size = new Size(40, 20);
      form1_0.label_57.TabIndex = 57;
      form1_0.label_57.Text = "Gün";
      form1_0.groupBox_19.BackColor = Color.Gray;
      form1_0.groupBox_19.Controls.Add((Control) form1_0.label_112);
      form1_0.groupBox_19.Controls.Add((Control) form1_0.label_113);
      form1_0.groupBox_19.Controls.Add((Control) form1_0.checkBox_9);
      form1_0.groupBox_19.Enabled = false;
      form1_0.groupBox_19.ForeColor = SystemColors.Menu;
      form1_0.groupBox_19.Location = new Point(4, 7);
      form1_0.groupBox_19.Name = "groupBox27";
      form1_0.groupBox_19.Size = new Size(220, 140);
      form1_0.groupBox_19.TabIndex = 56;
      form1_0.groupBox_19.TabStop = false;
      form1_0.groupBox_19.Text = "GENEL AYARLAR";
      form1_0.label_112.AutoSize = true;
      form1_0.label_112.Location = new Point(150, 71);
      form1_0.label_112.Name = "label181";
      form1_0.label_112.Size = new Size(13, 13);
      form1_0.label_112.TabIndex = 60;
      form1_0.label_112.Text = "0";
      form1_0.label_113.AutoSize = true;
      form1_0.label_113.Location = new Point(23, 71);
      form1_0.label_113.Name = "label183";
      form1_0.label_113.Size = new Size(125, 13);
      form1_0.label_113.TabIndex = 59;
      form1_0.label_113.Text = "Ortalama Etkinlik Süresi :";
      form1_0.checkBox_9.AutoSize = true;
      form1_0.checkBox_9.BackColor = Color.Transparent;
      form1_0.checkBox_9.ForeColor = Color.Black;
      form1_0.checkBox_9.Location = new Point(52, 55);
      form1_0.checkBox_9.Name = "Alchemy_basladımı";
      form1_0.checkBox_9.Size = new Size(105, 17);
      form1_0.checkBox_9.TabIndex = 56;
      form1_0.checkBox_9.Text = "Event Başladımı?";
      form1_0.checkBox_9.UseVisualStyleBackColor = false;
      form1_0.checkBox_9.Visible = false;
      form1_0.xtraTabPage_4.Controls.Add((Control) form1_0.comboBoxEdit_7);
      form1_0.xtraTabPage_4.Controls.Add((Control) form1_0.button_11);
      form1_0.xtraTabPage_4.Controls.Add((Control) form1_0.groupBox_20);
      form1_0.xtraTabPage_4.Controls.Add((Control) form1_0.button_12);
      form1_0.xtraTabPage_4.Controls.Add((Control) form1_0.textBox_36);
      form1_0.xtraTabPage_4.Controls.Add((Control) form1_0.listBox_5);
      form1_0.xtraTabPage_4.Controls.Add((Control) form1_0.dateTimePicker_3);
      form1_0.xtraTabPage_4.Controls.Add((Control) form1_0.label_70);
      form1_0.xtraTabPage_4.Controls.Add((Control) form1_0.label_71);
      form1_0.xtraTabPage_4.Controls.Add((Control) form1_0.groupBox_25);
      form1_0.xtraTabPage_4.Image = (Image) componentResourceManager.GetObject("SORU_CEVAP.Image");
      form1_0.xtraTabPage_4.Name = "SORU_CEVAP";
      form1_0.xtraTabPage_4.Size = new Size(817, 753);
      form1_0.xtraTabPage_4.Text = "Soru-Cevap";
      form1_0.xtraTabPage_4.Paint += new PaintEventHandler(form1_0.method_83);
      form1_0.comboBoxEdit_7.EditValue = (object) "Gün Seçin";
      form1_0.comboBoxEdit_7.Location = new Point(4, 173);
      form1_0.comboBoxEdit_7.Name = "SoruCevap_EventZamanı";
      form1_0.comboBoxEdit_7.Properties.Appearance.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.comboBoxEdit_7.Properties.Appearance.ForeColor = Color.Salmon;
      form1_0.comboBoxEdit_7.Properties.Appearance.Options.UseBackColor = true;
      form1_0.comboBoxEdit_7.Properties.Appearance.Options.UseForeColor = true;
      form1_0.comboBoxEdit_7.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      form1_0.comboBoxEdit_7.Properties.Items.AddRange(new object[7]
      {
        (object) "Pazartesi",
        (object) "Salı",
        (object) "Çarşamba",
        (object) "Perşembe",
        (object) "Cuma",
        (object) "Cumartesi",
        (object) "Pazar"
      });
      form1_0.comboBoxEdit_7.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
      form1_0.comboBoxEdit_7.Size = new Size(106, 20);
      form1_0.comboBoxEdit_7.TabIndex = 83;
      form1_0.button_11.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.button_11.BackgroundImageLayout = ImageLayout.Stretch;
      form1_0.button_11.DialogResult = DialogResult.Cancel;
      form1_0.button_11.FlatStyle = FlatStyle.Flat;
      form1_0.button_11.ForeColor = SystemColors.Window;
      form1_0.button_11.Location = new Point(120, 423);
      form1_0.button_11.Name = "button12";
      form1_0.button_11.Size = new Size(104, 24);
      form1_0.button_11.TabIndex = 76;
      form1_0.button_11.Text = "Sil";
      form1_0.button_11.UseVisualStyleBackColor = false;
      form1_0.button_11.Click += new EventHandler(form1_0.method_53);
      form1_0.groupBox_20.BackColor = Color.Gray;
      form1_0.groupBox_20.Controls.Add((Control) form1_0.textBox_79);
      form1_0.groupBox_20.Controls.Add((Control) form1_0.groupBox_21);
      form1_0.groupBox_20.Controls.Add((Control) form1_0.groupBox_22);
      form1_0.groupBox_20.ForeColor = SystemColors.Window;
      form1_0.groupBox_20.Location = new Point(230, 7);
      form1_0.groupBox_20.Name = "groupBox28";
      form1_0.groupBox_20.Size = new Size(590, 440);
      form1_0.groupBox_20.TabIndex = 74;
      form1_0.groupBox_20.TabStop = false;
      form1_0.groupBox_20.Text = "ETKİNLİK AYARLARI";
      form1_0.textBox_79.BackColor = Color.Salmon;
      form1_0.textBox_79.Location = new Point(440, 21);
      form1_0.textBox_79.Name = "SoruCevap_arananCEVAP";
      form1_0.textBox_79.Size = new Size(74, 21);
      form1_0.textBox_79.TabIndex = 192;
      form1_0.textBox_79.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_79.Visible = false;
      form1_0.groupBox_21.BackColor = Color.Gray;
      form1_0.groupBox_21.Controls.Add((Control) form1_0.textBox_27);
      form1_0.groupBox_21.Controls.Add((Control) form1_0.label_58);
      form1_0.groupBox_21.Controls.Add((Control) form1_0.label_59);
      form1_0.groupBox_21.Controls.Add((Control) form1_0.textBox_28);
      form1_0.groupBox_21.Controls.Add((Control) form1_0.label_60);
      form1_0.groupBox_21.Controls.Add((Control) form1_0.label_61);
      form1_0.groupBox_21.Controls.Add((Control) form1_0.label_62);
      form1_0.groupBox_21.Controls.Add((Control) form1_0.label_63);
      form1_0.groupBox_21.Controls.Add((Control) form1_0.textBox_29);
      form1_0.groupBox_21.ForeColor = SystemColors.Window;
      form1_0.groupBox_21.Location = new Point(6, 54);
      form1_0.groupBox_21.Name = "groupBox33";
      form1_0.groupBox_21.Size = new Size(331, 378);
      form1_0.groupBox_21.TabIndex = 42;
      form1_0.groupBox_21.TabStop = false;
      form1_0.groupBox_21.Text = "GENEL AYARLAR";
      form1_0.textBox_27.BackColor = Color.Salmon;
      form1_0.textBox_27.ForeColor = SystemColors.Window;
      form1_0.textBox_27.Location = new Point(135, 268);
      form1_0.textBox_27.Multiline = true;
      form1_0.textBox_27.Name = "SORUCEVAP_SonrakiSoruyaGeçmeSüresi";
      form1_0.textBox_27.Size = new Size(54, 20);
      form1_0.textBox_27.TabIndex = 226;
      form1_0.textBox_27.Text = "30";
      form1_0.textBox_27.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_27.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.label_58.AutoSize = true;
      form1_0.label_58.ForeColor = SystemColors.Window;
      form1_0.label_58.Location = new Point(27, 271);
      form1_0.label_58.Name = "label130";
      form1_0.label_58.Size = new Size(109, 13);
      form1_0.label_58.TabIndex = 225;
      form1_0.label_58.Text = "Sonraki Soruyu  ==>";
      form1_0.label_59.AutoSize = true;
      form1_0.label_59.Location = new Point(192, 271);
      form1_0.label_59.Name = "label132";
      form1_0.label_59.Size = new Size(92, 13);
      form1_0.label_59.TabIndex = 227;
      form1_0.label_59.Text = " Saniye Sonra Sor";
      form1_0.textBox_28.BackColor = Color.Salmon;
      form1_0.textBox_28.ForeColor = SystemColors.Window;
      form1_0.textBox_28.Location = new Point(144, 107);
      form1_0.textBox_28.Multiline = true;
      form1_0.textBox_28.Name = "SORUCEVAP_ToplamSoru";
      form1_0.textBox_28.Size = new Size(54, 20);
      form1_0.textBox_28.TabIndex = 213;
      form1_0.textBox_28.Text = "3";
      form1_0.textBox_28.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_28.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.label_60.AutoSize = true;
      form1_0.label_60.ForeColor = SystemColors.Window;
      form1_0.label_60.Location = new Point(25, 110);
      form1_0.label_60.Name = "label136";
      form1_0.label_60.Size = new Size(113, 13);
      form1_0.label_60.TabIndex = 211;
      form1_0.label_60.Text = "Etkinlikte Toplam ==>";
      form1_0.label_61.AutoSize = true;
      form1_0.label_61.Location = new Point(223, 188);
      form1_0.label_61.Name = "label131";
      form1_0.label_61.Size = new Size(70, 13);
      form1_0.label_61.TabIndex = 220;
      form1_0.label_61.Text = " Saniye Bekle";
      form1_0.label_62.AutoSize = true;
      form1_0.label_62.Location = new Point(204, 110);
      form1_0.label_62.Name = "label135";
      form1_0.label_62.Size = new Size(51, 13);
      form1_0.label_62.TabIndex = 223;
      form1_0.label_62.Text = " Soru Sor";
      form1_0.label_63.AutoSize = true;
      form1_0.label_63.ForeColor = SystemColors.Window;
      form1_0.label_63.Location = new Point(15, 188);
      form1_0.label_63.Name = "label134";
      form1_0.label_63.Size = new Size(150, 13);
      form1_0.label_63.TabIndex = 216;
      form1_0.label_63.Text = "Her Sorunun Cevabı İçin ==>\r\n";
      form1_0.textBox_29.BackColor = Color.Salmon;
      form1_0.textBox_29.ForeColor = SystemColors.Window;
      form1_0.textBox_29.Location = new Point(167, 185);
      form1_0.textBox_29.Multiline = true;
      form1_0.textBox_29.Name = "textBox71";
      form1_0.textBox_29.Size = new Size(50, 20);
      form1_0.textBox_29.TabIndex = 214;
      form1_0.textBox_29.Text = "60";
      form1_0.textBox_29.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_29.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.groupBox_22.BackColor = Color.Gray;
      form1_0.groupBox_22.Controls.Add((Control) form1_0.groupBox_23);
      form1_0.groupBox_22.Controls.Add((Control) form1_0.checkBox_10);
      form1_0.groupBox_22.Controls.Add((Control) form1_0.groupBox_24);
      form1_0.groupBox_22.Controls.Add((Control) form1_0.checkBox_11);
      form1_0.groupBox_22.ForeColor = SystemColors.Window;
      form1_0.groupBox_22.Location = new Point(343, 55);
      form1_0.groupBox_22.Name = "groupBox29";
      form1_0.groupBox_22.Size = new Size(230, 379);
      form1_0.groupBox_22.TabIndex = 56;
      form1_0.groupBox_22.TabStop = false;
      form1_0.groupBox_22.Text = "ÖDÜL AYARLARI";
      form1_0.groupBox_23.BackColor = Color.Gray;
      form1_0.groupBox_23.Controls.Add((Control) form1_0.textBox_95);
      form1_0.groupBox_23.Controls.Add((Control) form1_0.label_152);
      form1_0.groupBox_23.Controls.Add((Control) form1_0.label_64);
      form1_0.groupBox_23.Controls.Add((Control) form1_0.label_65);
      form1_0.groupBox_23.Controls.Add((Control) form1_0.label_66);
      form1_0.groupBox_23.Controls.Add((Control) form1_0.textBox_30);
      form1_0.groupBox_23.Controls.Add((Control) form1_0.textBox_31);
      form1_0.groupBox_23.Controls.Add((Control) form1_0.textBox_32);
      form1_0.groupBox_23.Enabled = false;
      form1_0.groupBox_23.ForeColor = SystemColors.Window;
      form1_0.groupBox_23.Location = new Point(7, 33);
      form1_0.groupBox_23.Name = "groupBox30";
      form1_0.groupBox_23.Size = new Size(217, 162);
      form1_0.groupBox_23.TabIndex = 9;
      form1_0.groupBox_23.TabStop = false;
      form1_0.groupBox_23.Text = "ITEM";
      form1_0.textBox_95.BackColor = Color.Salmon;
      form1_0.textBox_95.Location = new Point(24, 128);
      form1_0.textBox_95.Name = "textBox49";
      form1_0.textBox_95.Size = new Size(174, 21);
      form1_0.textBox_95.TabIndex = 50;
      form1_0.textBox_95.Text = "Sun Sword ( 1 Dg )";
      form1_0.textBox_95.TextAlign = HorizontalAlignment.Center;
      form1_0.label_152.AutoSize = true;
      form1_0.label_152.Location = new Point(82, 114);
      form1_0.label_152.Name = "label73";
      form1_0.label_152.Size = new Size(56, 13);
      form1_0.label_152.TabIndex = 49;
      form1_0.label_152.Text = "ITEM İSMİ";
      form1_0.label_64.AutoSize = true;
      form1_0.label_64.Location = new Point(153, 64);
      form1_0.label_64.Name = "label58";
      form1_0.label_64.Size = new Size(31, 13);
      form1_0.label_64.TabIndex = 41;
      form1_0.label_64.Text = "PLUS";
      form1_0.label_65.AutoSize = true;
      form1_0.label_65.Location = new Point(49, 65);
      form1_0.label_65.Name = "label59";
      form1_0.label_65.Size = new Size(33, 13);
      form1_0.label_65.TabIndex = 40;
      form1_0.label_65.Text = "ADET";
      form1_0.label_66.AutoSize = true;
      form1_0.label_66.Location = new Point(77, 19);
      form1_0.label_66.Name = "label72";
      form1_0.label_66.Size = new Size(62, 13);
      form1_0.label_66.TabIndex = 39;
      form1_0.label_66.Text = "ITEM KODU";
      form1_0.textBox_30.BackColor = Color.Salmon;
      form1_0.textBox_30.Location = new Point(133, 80);
      form1_0.textBox_30.Name = "textBox63";
      form1_0.textBox_30.Size = new Size(65, 21);
      form1_0.textBox_30.TabIndex = 8;
      form1_0.textBox_30.Text = "1";
      form1_0.textBox_30.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_30.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_31.BackColor = Color.Salmon;
      form1_0.textBox_31.Location = new Point(24, 81);
      form1_0.textBox_31.Name = "textBox64";
      form1_0.textBox_31.Size = new Size(74, 21);
      form1_0.textBox_31.TabIndex = 7;
      form1_0.textBox_31.Text = "1";
      form1_0.textBox_31.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_31.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_32.BackColor = Color.Salmon;
      form1_0.textBox_32.Location = new Point(24, 35);
      form1_0.textBox_32.Name = "textBox65";
      form1_0.textBox_32.Size = new Size(174, 21);
      form1_0.textBox_32.TabIndex = 4;
      form1_0.textBox_32.Text = "ITEM_CH_SWORD_01_C_RARE";
      form1_0.textBox_32.TextAlign = HorizontalAlignment.Center;
      form1_0.checkBox_10.AutoSize = true;
      form1_0.checkBox_10.Location = new Point(6, 201);
      form1_0.checkBox_10.Name = "SoruCevap_ÖdülTipi_SGSR";
      form1_0.checkBox_10.Size = new Size(15, 14);
      form1_0.checkBox_10.TabIndex = 10;
      form1_0.checkBox_10.UseVisualStyleBackColor = true;
      form1_0.checkBox_10.CheckedChanged += new EventHandler(form1_0.method_41);
      form1_0.groupBox_24.BackColor = Color.Gray;
      form1_0.groupBox_24.Controls.Add((Control) form1_0.label_67);
      form1_0.groupBox_24.Controls.Add((Control) form1_0.label_68);
      form1_0.groupBox_24.Controls.Add((Control) form1_0.label_69);
      form1_0.groupBox_24.Controls.Add((Control) form1_0.textBox_33);
      form1_0.groupBox_24.Controls.Add((Control) form1_0.textBox_34);
      form1_0.groupBox_24.Controls.Add((Control) form1_0.textBox_35);
      form1_0.groupBox_24.Enabled = false;
      form1_0.groupBox_24.ForeColor = SystemColors.Window;
      form1_0.groupBox_24.Location = new Point(7, 221);
      form1_0.groupBox_24.Name = "groupBox31";
      form1_0.groupBox_24.Size = new Size(217, 158);
      form1_0.groupBox_24.TabIndex = 10;
      form1_0.groupBox_24.TabStop = false;
      form1_0.groupBox_24.Text = "SİLK- GOLD - SP";
      form1_0.label_67.AutoSize = true;
      form1_0.label_67.Location = new Point(86, 106);
      form1_0.label_67.Name = "label125";
      form1_0.label_67.Size = new Size(53, 13);
      form1_0.label_67.TabIndex = 38;
      form1_0.label_67.Text = "SP Miktarı";
      form1_0.label_68.AutoSize = true;
      form1_0.label_68.Location = new Point(70, 64);
      form1_0.label_68.Name = "label126";
      form1_0.label_68.Size = new Size(62, 13);
      form1_0.label_68.TabIndex = 37;
      form1_0.label_68.Text = "Gold Miktari";
      form1_0.label_69.AutoSize = true;
      form1_0.label_69.Location = new Point(74, 23);
      form1_0.label_69.Name = "label129";
      form1_0.label_69.Size = new Size(56, 13);
      form1_0.label_69.TabIndex = 36;
      form1_0.label_69.Text = "Silk Miktarı";
      form1_0.textBox_33.BackColor = Color.Salmon;
      form1_0.textBox_33.Location = new Point(40, 78);
      form1_0.textBox_33.MaxLength = 19;
      form1_0.textBox_33.Name = "s2";
      form1_0.textBox_33.Size = new Size(144, 21);
      form1_0.textBox_33.TabIndex = 6;
      form1_0.textBox_33.Text = "0";
      form1_0.textBox_33.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_33.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_34.BackColor = Color.Salmon;
      form1_0.textBox_34.Location = new Point(58, 122);
      form1_0.textBox_34.MaxLength = 19;
      form1_0.textBox_34.Name = "s3";
      form1_0.textBox_34.Size = new Size(97, 21);
      form1_0.textBox_34.TabIndex = 5;
      form1_0.textBox_34.Text = "0";
      form1_0.textBox_34.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_34.TextChanged += new EventHandler(form1_0.method_42);
      form1_0.textBox_34.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_35.BackColor = Color.Salmon;
      form1_0.textBox_35.Location = new Point(68, 38);
      form1_0.textBox_35.MaxLength = 19;
      form1_0.textBox_35.Name = "s1";
      form1_0.textBox_35.Size = new Size(71, 21);
      form1_0.textBox_35.TabIndex = 4;
      form1_0.textBox_35.Text = "0";
      form1_0.textBox_35.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_35.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.checkBox_11.AutoSize = true;
      form1_0.checkBox_11.Location = new Point(7, 13);
      form1_0.checkBox_11.Name = "SoruCevap_ÖdülTipi_ITEM";
      form1_0.checkBox_11.Size = new Size(15, 14);
      form1_0.checkBox_11.TabIndex = 9;
      form1_0.checkBox_11.UseVisualStyleBackColor = true;
      form1_0.checkBox_11.CheckedChanged += new EventHandler(form1_0.method_40);
      form1_0.button_12.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.button_12.BackgroundImageLayout = ImageLayout.Stretch;
      form1_0.button_12.FlatStyle = FlatStyle.Flat;
      form1_0.button_12.ForeColor = SystemColors.Window;
      form1_0.button_12.Location = new Point(5, 423);
      form1_0.button_12.Name = "button21";
      form1_0.button_12.Size = new Size(104, 24);
      form1_0.button_12.TabIndex = 75;
      form1_0.button_12.Text = "Ekle";
      form1_0.button_12.UseVisualStyleBackColor = false;
      form1_0.button_12.Click += new EventHandler(form1_0.method_58);
      form1_0.textBox_36.Location = new Point(179, 200);
      form1_0.textBox_36.Name = "textBox102";
      form1_0.textBox_36.Size = new Size(45, 21);
      form1_0.textBox_36.TabIndex = 73;
      form1_0.textBox_36.Visible = false;
      form1_0.listBox_5.BackColor = Color.Gray;
      form1_0.listBox_5.ForeColor = SystemColors.Window;
      form1_0.listBox_5.FormattingEnabled = true;
      form1_0.listBox_5.Location = new Point(4, 201);
      form1_0.listBox_5.Name = "SoruCevap_ListBox";
      form1_0.listBox_5.Size = new Size(220, 212);
      form1_0.listBox_5.TabIndex = 72;
      form1_0.dateTimePicker_3.Format = DateTimePickerFormat.Time;
      form1_0.dateTimePicker_3.ImeMode = ImeMode.NoControl;
      form1_0.dateTimePicker_3.Location = new Point(120, 174);
      form1_0.dateTimePicker_3.Name = "SoruCevap_Saat";
      form1_0.dateTimePicker_3.RightToLeft = RightToLeft.Yes;
      form1_0.dateTimePicker_3.ShowUpDown = true;
      form1_0.dateTimePicker_3.Size = new Size(104, 21);
      form1_0.dateTimePicker_3.TabIndex = 71;
      form1_0.label_70.AutoSize = true;
      form1_0.label_70.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.label_70.Location = new Point(149, 151);
      form1_0.label_70.Name = "label159";
      form1_0.label_70.Size = new Size(43, 20);
      form1_0.label_70.TabIndex = 69;
      form1_0.label_70.Text = "Saat";
      form1_0.label_71.AutoSize = true;
      form1_0.label_71.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.label_71.Location = new Point(39, 151);
      form1_0.label_71.Name = "label160";
      form1_0.label_71.Size = new Size(40, 20);
      form1_0.label_71.TabIndex = 68;
      form1_0.label_71.Text = "Gün";
      form1_0.groupBox_25.BackColor = Color.Gray;
      form1_0.groupBox_25.Controls.Add((Control) form1_0.textBox_80);
      form1_0.groupBox_25.Controls.Add((Control) form1_0.label_114);
      form1_0.groupBox_25.Controls.Add((Control) form1_0.label_115);
      form1_0.groupBox_25.Controls.Add((Control) form1_0.textBox_65);
      form1_0.groupBox_25.Controls.Add((Control) form1_0.textBox_66);
      form1_0.groupBox_25.Controls.Add((Control) form1_0.checkBox_12);
      form1_0.groupBox_25.Enabled = false;
      form1_0.groupBox_25.ForeColor = SystemColors.Menu;
      form1_0.groupBox_25.Location = new Point(4, 7);
      form1_0.groupBox_25.Name = "groupBox32";
      form1_0.groupBox_25.Size = new Size(220, 140);
      form1_0.groupBox_25.TabIndex = 67;
      form1_0.groupBox_25.TabStop = false;
      form1_0.groupBox_25.Text = "GENEL AYARLAR";
      form1_0.textBox_80.Location = new Point(168, 14);
      form1_0.textBox_80.Name = "soru_cevap_tur";
      form1_0.textBox_80.Size = new Size(45, 21);
      form1_0.textBox_80.TabIndex = 77;
      form1_0.textBox_80.Text = "1";
      form1_0.textBox_80.Visible = false;
      form1_0.label_114.AutoSize = true;
      form1_0.label_114.Location = new Point(147, 68);
      form1_0.label_114.Name = "label185";
      form1_0.label_114.Size = new Size(13, 13);
      form1_0.label_114.TabIndex = 77;
      form1_0.label_114.Text = "0";
      form1_0.label_115.AutoSize = true;
      form1_0.label_115.Location = new Point(9, 68);
      form1_0.label_115.Name = "label186";
      form1_0.label_115.Size = new Size(125, 13);
      form1_0.label_115.TabIndex = 76;
      form1_0.label_115.Text = "Ortalama Etkinlik Süresi :";
      form1_0.textBox_65.Location = new Point(30, 80);
      form1_0.textBox_65.Name = "SORUCEVAP_sonCevap";
      form1_0.textBox_65.Size = new Size(158, 21);
      form1_0.textBox_65.TabIndex = 75;
      form1_0.textBox_65.Visible = false;
      form1_0.textBox_66.Location = new Point(9, 41);
      form1_0.textBox_66.Name = "SORUCEVAP_sonSoru";
      form1_0.textBox_66.Size = new Size(202, 21);
      form1_0.textBox_66.TabIndex = 74;
      form1_0.textBox_66.Visible = false;
      form1_0.checkBox_12.AutoSize = true;
      form1_0.checkBox_12.BackColor = Color.Transparent;
      form1_0.checkBox_12.ForeColor = Color.Black;
      form1_0.checkBox_12.Location = new Point(64, 24);
      form1_0.checkBox_12.Name = "SORUCEVAP_basladımı";
      form1_0.checkBox_12.Size = new Size(105, 17);
      form1_0.checkBox_12.TabIndex = 56;
      form1_0.checkBox_12.Text = "Event Başladımı?";
      form1_0.checkBox_12.UseVisualStyleBackColor = false;
      form1_0.checkBox_12.Visible = false;
      form1_0.xtraTabPage_6.Controls.Add((Control) form1_0.comboBoxEdit_8);
      form1_0.xtraTabPage_6.Controls.Add((Control) form1_0.groupBox_45);
      form1_0.xtraTabPage_6.Controls.Add((Control) form1_0.listBox_20);
      form1_0.xtraTabPage_6.Controls.Add((Control) form1_0.groupBox_29);
      form1_0.xtraTabPage_6.Controls.Add((Control) form1_0.textBox_77);
      form1_0.xtraTabPage_6.Controls.Add((Control) form1_0.textBox_76);
      form1_0.xtraTabPage_6.Controls.Add((Control) form1_0.groupBox_28);
      form1_0.xtraTabPage_6.Controls.Add((Control) form1_0.button_15);
      form1_0.xtraTabPage_6.Controls.Add((Control) form1_0.button_16);
      form1_0.xtraTabPage_6.Controls.Add((Control) form1_0.listBox_7);
      form1_0.xtraTabPage_6.Controls.Add((Control) form1_0.dateTimePicker_5);
      form1_0.xtraTabPage_6.Controls.Add((Control) form1_0.label_87);
      form1_0.xtraTabPage_6.Controls.Add((Control) form1_0.label_88);
      form1_0.xtraTabPage_6.Image = (Image) componentResourceManager.GetObject("PT_FORM.Image");
      form1_0.xtraTabPage_6.Name = "PT_FORM";
      form1_0.xtraTabPage_6.Size = new Size(817, 753);
      form1_0.xtraTabPage_6.Text = "Party Form";
      form1_0.xtraTabPage_6.Paint += new PaintEventHandler(form1_0.method_84);
      form1_0.comboBoxEdit_8.EditValue = (object) "Gün Seçin";
      form1_0.comboBoxEdit_8.Location = new Point(16, 176);
      form1_0.comboBoxEdit_8.Name = "PTForm_EventZamanı";
      form1_0.comboBoxEdit_8.Properties.Appearance.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.comboBoxEdit_8.Properties.Appearance.ForeColor = Color.Salmon;
      form1_0.comboBoxEdit_8.Properties.Appearance.Options.UseBackColor = true;
      form1_0.comboBoxEdit_8.Properties.Appearance.Options.UseForeColor = true;
      form1_0.comboBoxEdit_8.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      form1_0.comboBoxEdit_8.Properties.Items.AddRange(new object[7]
      {
        (object) "Pazartesi",
        (object) "Salı",
        (object) "Çarşamba",
        (object) "Perşembe",
        (object) "Cuma",
        (object) "Cumartesi",
        (object) "Pazar"
      });
      form1_0.comboBoxEdit_8.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
      form1_0.comboBoxEdit_8.Size = new Size(106, 20);
      form1_0.comboBoxEdit_8.TabIndex = 248;
      form1_0.groupBox_45.BackColor = Color.Gray;
      form1_0.groupBox_45.Controls.Add((Control) form1_0.label_166);
      form1_0.groupBox_45.Controls.Add((Control) form1_0.label_167);
      form1_0.groupBox_45.Enabled = false;
      form1_0.groupBox_45.ForeColor = SystemColors.Menu;
      form1_0.groupBox_45.Location = new Point(16, 13);
      form1_0.groupBox_45.Name = "groupBox11";
      form1_0.groupBox_45.Size = new Size(220, 140);
      form1_0.groupBox_45.TabIndex = 253;
      form1_0.groupBox_45.TabStop = false;
      form1_0.groupBox_45.Text = "GENEL AYARLAR";
      form1_0.label_166.AutoSize = true;
      form1_0.label_166.Location = new Point(156, 77);
      form1_0.label_166.Name = "label199";
      form1_0.label_166.Size = new Size(13, 13);
      form1_0.label_166.TabIndex = 247;
      form1_0.label_166.Text = "0";
      form1_0.label_167.AutoSize = true;
      form1_0.label_167.Location = new Point(18, 77);
      form1_0.label_167.Name = "label191";
      form1_0.label_167.Size = new Size(125, 13);
      form1_0.label_167.TabIndex = 59;
      form1_0.label_167.Text = "Ortalama Etkinlik Süresi :";
      form1_0.groupBox_29.BackColor = Color.Gray;
      form1_0.groupBox_29.Controls.Add((Control) form1_0.label_170);
      form1_0.groupBox_29.Controls.Add((Control) form1_0.button_32);
      form1_0.groupBox_29.Controls.Add((Control) form1_0.button_31);
      form1_0.groupBox_29.Controls.Add((Control) form1_0.label_168);
      form1_0.groupBox_29.Controls.Add((Control) form1_0.label_169);
      form1_0.groupBox_29.Controls.Add((Control) form1_0.label_144);
      form1_0.groupBox_29.Controls.Add((Control) form1_0.textBox_87);
      form1_0.groupBox_29.Controls.Add((Control) form1_0.label_79);
      form1_0.groupBox_29.Controls.Add((Control) form1_0.textBox_40);
      form1_0.groupBox_29.Controls.Add((Control) form1_0.label_80);
      form1_0.groupBox_29.Controls.Add((Control) form1_0.textBox_41);
      form1_0.groupBox_29.ForeColor = SystemColors.Window;
      form1_0.groupBox_29.Location = new Point((int) byte.MaxValue, 13);
      form1_0.groupBox_29.Name = "groupBox38";
      form1_0.groupBox_29.Size = new Size(261, 434);
      form1_0.groupBox_29.TabIndex = 42;
      form1_0.groupBox_29.TabStop = false;
      form1_0.groupBox_29.Text = "ETKİNLİK AYARLARI";
      form1_0.label_170.AutoSize = true;
      form1_0.label_170.BackColor = Color.Transparent;
      form1_0.label_170.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      form1_0.label_170.ForeColor = Color.Snow;
      form1_0.label_170.Location = new Point(131, 385);
      form1_0.label_170.Name = "label38";
      form1_0.label_170.Size = new Size(16, 16);
      form1_0.label_170.TabIndex = 253;
      form1_0.label_170.Text = "0";
      form1_0.button_32.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.button_32.BackgroundImageLayout = ImageLayout.Stretch;
      form1_0.button_32.FlatStyle = FlatStyle.Flat;
      form1_0.button_32.ForeColor = SystemColors.Window;
      form1_0.button_32.Location = new Point(6, 20);
      form1_0.button_32.Name = "button23";
      form1_0.button_32.Size = new Size(104, 24);
      form1_0.button_32.TabIndex = 83;
      form1_0.button_32.Text = "PARTY OLUSTUR";
      form1_0.button_32.UseVisualStyleBackColor = false;
      form1_0.button_32.Visible = false;
      form1_0.button_32.Click += new EventHandler(form1_0.method_102);
      form1_0.button_31.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.button_31.BackgroundImageLayout = ImageLayout.Stretch;
      form1_0.button_31.FlatStyle = FlatStyle.Flat;
      form1_0.button_31.ForeColor = SystemColors.Window;
      form1_0.button_31.Location = new Point(157, 17);
      form1_0.button_31.Name = "button22";
      form1_0.button_31.Size = new Size(104, 24);
      form1_0.button_31.TabIndex = 82;
      form1_0.button_31.Text = "GETPARTYDATA";
      form1_0.button_31.UseVisualStyleBackColor = false;
      form1_0.button_31.Visible = false;
      form1_0.button_31.Click += new EventHandler(form1_0.method_101);
      form1_0.label_168.AutoSize = true;
      form1_0.label_168.Location = new Point(132, 225);
      form1_0.label_168.Name = "label34";
      form1_0.label_168.Size = new Size(15, 13);
      form1_0.label_168.TabIndex = 64;
      form1_0.label_168.Text = "+";
      form1_0.label_169.AutoSize = true;
      form1_0.label_169.Location = new Point(62, 211);
      form1_0.label_169.Name = "label26";
      form1_0.label_169.Size = new Size(164, 13);
      form1_0.label_169.TabIndex = 63;
      form1_0.label_169.Text = "Şuanki en yüksek party numarası";
      form1_0.label_144.AutoSize = true;
      form1_0.label_144.Location = new Point(23, 355);
      form1_0.label_144.Name = "label201";
      form1_0.label_144.Size = new Size(219, 13);
      form1_0.label_144.TabIndex = 62;
      form1_0.label_144.Text = "Saniye içinde kazanan olmazsa yeni tura geç";
      form1_0.textBox_87.BackColor = Color.Salmon;
      form1_0.textBox_87.Location = new Point(116, 329);
      form1_0.textBox_87.Name = "Party_Form_Raund_bekleme";
      form1_0.textBox_87.Size = new Size(42, 21);
      form1_0.textBox_87.TabIndex = 61;
      form1_0.textBox_87.Text = "10";
      form1_0.textBox_87.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_87.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.label_79.AutoSize = true;
      form1_0.label_79.Location = new Point(94, 97);
      form1_0.label_79.Name = "label150";
      form1_0.label_79.Size = new Size(85, 13);
      form1_0.label_79.TabIndex = 41;
      form1_0.label_79.Text = "Etkinlik tur sayısı";
      form1_0.textBox_40.BackColor = Color.Salmon;
      form1_0.textBox_40.Location = new Point(116, 124);
      form1_0.textBox_40.Name = "textBox79";
      form1_0.textBox_40.Size = new Size(42, 21);
      form1_0.textBox_40.TabIndex = 40;
      form1_0.textBox_40.Text = "3";
      form1_0.textBox_40.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_40.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.label_80.AutoSize = true;
      form1_0.label_80.Location = new Point(77, 193);
      form1_0.label_80.Name = "label152";
      form1_0.label_80.Size = new Size(117, 13);
      form1_0.label_80.TabIndex = 39;
      form1_0.label_80.Text = "Aranan party numarası";
      form1_0.textBox_41.BackColor = Color.Salmon;
      form1_0.textBox_41.Location = new Point(116, 241);
      form1_0.textBox_41.Name = "textBox81";
      form1_0.textBox_41.Size = new Size(42, 21);
      form1_0.textBox_41.TabIndex = 4;
      form1_0.textBox_41.Text = "100";
      form1_0.textBox_41.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_41.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_77.Location = new Point(191, 205);
      form1_0.textBox_77.Name = "textBox69";
      form1_0.textBox_77.Size = new Size(45, 21);
      form1_0.textBox_77.TabIndex = 245;
      form1_0.textBox_77.Visible = false;
      form1_0.textBox_76.BackColor = Color.Salmon;
      form1_0.textBox_76.Location = new Point(167, 241);
      form1_0.textBox_76.Name = "textBox48";
      form1_0.textBox_76.Size = new Size(69, 21);
      form1_0.textBox_76.TabIndex = 194;
      form1_0.textBox_76.Text = "NO:";
      form1_0.textBox_76.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_76.Visible = false;
      form1_0.groupBox_28.BackColor = Color.Gray;
      form1_0.groupBox_28.Controls.Add((Control) form1_0.checkBox_13);
      form1_0.groupBox_28.Controls.Add((Control) form1_0.groupBox_30);
      form1_0.groupBox_28.Controls.Add((Control) form1_0.groupBox_31);
      form1_0.groupBox_28.Controls.Add((Control) form1_0.checkBox_14);
      form1_0.groupBox_28.ForeColor = SystemColors.Window;
      form1_0.groupBox_28.Location = new Point(534, 15);
      form1_0.groupBox_28.Name = "groupBox35";
      form1_0.groupBox_28.Size = new Size(262, 432);
      form1_0.groupBox_28.TabIndex = 82;
      form1_0.groupBox_28.TabStop = false;
      form1_0.groupBox_28.Text = "ÖDÜL AYARLARI";
      form1_0.checkBox_13.AutoSize = true;
      form1_0.checkBox_13.Location = new Point(33, 229);
      form1_0.checkBox_13.Name = "PTform_ÖdülTipi_SGSR";
      form1_0.checkBox_13.Size = new Size(15, 14);
      form1_0.checkBox_13.TabIndex = 43;
      form1_0.checkBox_13.UseVisualStyleBackColor = true;
      form1_0.checkBox_13.CheckedChanged += new EventHandler(form1_0.method_46);
      form1_0.groupBox_30.BackColor = Color.Gray;
      form1_0.groupBox_30.Controls.Add((Control) form1_0.label_81);
      form1_0.groupBox_30.Controls.Add((Control) form1_0.label_82);
      form1_0.groupBox_30.Controls.Add((Control) form1_0.label_83);
      form1_0.groupBox_30.Controls.Add((Control) form1_0.textBox_43);
      form1_0.groupBox_30.Controls.Add((Control) form1_0.textBox_42);
      form1_0.groupBox_30.Controls.Add((Control) form1_0.textBox_44);
      form1_0.groupBox_30.Enabled = false;
      form1_0.groupBox_30.ForeColor = SystemColors.Window;
      form1_0.groupBox_30.Location = new Point(33, 249);
      form1_0.groupBox_30.Name = "groupBox37";
      form1_0.groupBox_30.Size = new Size(191, 150);
      form1_0.groupBox_30.TabIndex = 11;
      form1_0.groupBox_30.TabStop = false;
      form1_0.groupBox_30.Text = "SİLK- GOLD - SP";
      form1_0.label_81.AutoSize = true;
      form1_0.label_81.Location = new Point(69, 18);
      form1_0.label_81.Name = "label149";
      form1_0.label_81.Size = new Size(56, 13);
      form1_0.label_81.TabIndex = 36;
      form1_0.label_81.Text = "Silk Miktarı";
      form1_0.label_82.AutoSize = true;
      form1_0.label_82.Location = new Point(72, 95);
      form1_0.label_82.Name = "label147";
      form1_0.label_82.Size = new Size(53, 13);
      form1_0.label_82.TabIndex = 38;
      form1_0.label_82.Text = "SP Miktarı";
      form1_0.label_83.AutoSize = true;
      form1_0.label_83.Location = new Point(66, 56);
      form1_0.label_83.Name = "label148";
      form1_0.label_83.Size = new Size(62, 13);
      form1_0.label_83.TabIndex = 37;
      form1_0.label_83.Text = "Gold Miktari";
      form1_0.textBox_43.BackColor = Color.Salmon;
      form1_0.textBox_43.Location = new Point(44, 34);
      form1_0.textBox_43.MaxLength = 19;
      form1_0.textBox_43.Name = "textBox78";
      form1_0.textBox_43.Size = new Size(108, 21);
      form1_0.textBox_43.TabIndex = 4;
      form1_0.textBox_43.Text = "0";
      form1_0.textBox_43.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_43.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_42.BackColor = Color.Salmon;
      form1_0.textBox_42.Location = new Point(44, 71);
      form1_0.textBox_42.MaxLength = 19;
      form1_0.textBox_42.Name = "textBox76";
      form1_0.textBox_42.Size = new Size(108, 21);
      form1_0.textBox_42.TabIndex = 6;
      form1_0.textBox_42.Text = "0";
      form1_0.textBox_42.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_42.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_44.BackColor = Color.Salmon;
      form1_0.textBox_44.Location = new Point(44, 111);
      form1_0.textBox_44.MaxLength = 19;
      form1_0.textBox_44.Name = "textBox77";
      form1_0.textBox_44.Size = new Size(108, 21);
      form1_0.textBox_44.TabIndex = 5;
      form1_0.textBox_44.Text = "0";
      form1_0.textBox_44.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_44.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.groupBox_31.BackColor = Color.Gray;
      form1_0.groupBox_31.Controls.Add((Control) form1_0.textBox_96);
      form1_0.groupBox_31.Controls.Add((Control) form1_0.label_153);
      form1_0.groupBox_31.Controls.Add((Control) form1_0.label_84);
      form1_0.groupBox_31.Controls.Add((Control) form1_0.label_85);
      form1_0.groupBox_31.Controls.Add((Control) form1_0.label_86);
      form1_0.groupBox_31.Controls.Add((Control) form1_0.textBox_45);
      form1_0.groupBox_31.Controls.Add((Control) form1_0.textBox_46);
      form1_0.groupBox_31.Controls.Add((Control) form1_0.textBox_47);
      form1_0.groupBox_31.Enabled = false;
      form1_0.groupBox_31.ForeColor = SystemColors.Window;
      form1_0.groupBox_31.Location = new Point(33, 50);
      form1_0.groupBox_31.Name = "groupBox36";
      form1_0.groupBox_31.Size = new Size(191, 173);
      form1_0.groupBox_31.TabIndex = 10;
      form1_0.groupBox_31.TabStop = false;
      form1_0.groupBox_31.Text = "ITEM";
      form1_0.textBox_96.BackColor = Color.Salmon;
      form1_0.textBox_96.Location = new Point(12, 131);
      form1_0.textBox_96.Name = "textBox72";
      form1_0.textBox_96.Size = new Size(174, 21);
      form1_0.textBox_96.TabIndex = 52;
      form1_0.textBox_96.Text = "Sun Sword ( 1 Dg )";
      form1_0.textBox_96.TextAlign = HorizontalAlignment.Center;
      form1_0.label_153.AutoSize = true;
      form1_0.label_153.Location = new Point(70, 117);
      form1_0.label_153.Name = "label146";
      form1_0.label_153.Size = new Size(56, 13);
      form1_0.label_153.TabIndex = 51;
      form1_0.label_153.Text = "ITEM İSMİ";
      form1_0.label_84.AutoSize = true;
      form1_0.label_84.Location = new Point(32, 71);
      form1_0.label_84.Name = "label139";
      form1_0.label_84.Size = new Size(31, 13);
      form1_0.label_84.TabIndex = 41;
      form1_0.label_84.Text = "PLUS";
      form1_0.label_85.AutoSize = true;
      form1_0.label_85.Location = new Point(129, 72);
      form1_0.label_85.Name = "label140";
      form1_0.label_85.Size = new Size(33, 13);
      form1_0.label_85.TabIndex = 40;
      form1_0.label_85.Text = "ADET";
      form1_0.label_86.AutoSize = true;
      form1_0.label_86.Location = new Point(65, 19);
      form1_0.label_86.Name = "label145";
      form1_0.label_86.Size = new Size(62, 13);
      form1_0.label_86.TabIndex = 39;
      form1_0.label_86.Text = "ITEM KODU";
      form1_0.textBox_45.BackColor = Color.Salmon;
      form1_0.textBox_45.Location = new Point(12, 87);
      form1_0.textBox_45.Name = "textBox54";
      form1_0.textBox_45.Size = new Size(65, 21);
      form1_0.textBox_45.TabIndex = 8;
      form1_0.textBox_45.Text = "1";
      form1_0.textBox_45.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_45.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_46.BackColor = Color.Salmon;
      form1_0.textBox_46.Location = new Point(112, 88);
      form1_0.textBox_46.Name = "textBox70";
      form1_0.textBox_46.Size = new Size(74, 21);
      form1_0.textBox_46.TabIndex = 7;
      form1_0.textBox_46.Text = "1";
      form1_0.textBox_46.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_46.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_47.BackColor = Color.Salmon;
      form1_0.textBox_47.Location = new Point(12, 35);
      form1_0.textBox_47.Name = "textBox74";
      form1_0.textBox_47.Size = new Size(174, 21);
      form1_0.textBox_47.TabIndex = 4;
      form1_0.textBox_47.Text = "ITEM_CH_SWORD_01_C_RARE";
      form1_0.textBox_47.TextAlign = HorizontalAlignment.Center;
      form1_0.checkBox_14.AutoSize = true;
      form1_0.checkBox_14.Location = new Point(33, 30);
      form1_0.checkBox_14.Name = "PTform_ÖdülTipi_ITEM";
      form1_0.checkBox_14.Size = new Size(15, 14);
      form1_0.checkBox_14.TabIndex = 9;
      form1_0.checkBox_14.UseVisualStyleBackColor = true;
      form1_0.checkBox_14.CheckedChanged += new EventHandler(form1_0.method_45);
      form1_0.button_15.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.button_15.BackgroundImageLayout = ImageLayout.Stretch;
      form1_0.button_15.FlatStyle = FlatStyle.Flat;
      form1_0.button_15.ForeColor = SystemColors.Window;
      form1_0.button_15.Location = new Point(132, 423);
      form1_0.button_15.Name = "button24";
      form1_0.button_15.Size = new Size(104, 24);
      form1_0.button_15.TabIndex = 81;
      form1_0.button_15.Text = "Sil";
      form1_0.button_15.UseVisualStyleBackColor = false;
      form1_0.button_15.Click += new EventHandler(form1_0.method_54);
      form1_0.button_16.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.button_16.BackgroundImageLayout = ImageLayout.Stretch;
      form1_0.button_16.FlatStyle = FlatStyle.Flat;
      form1_0.button_16.ForeColor = SystemColors.Window;
      form1_0.button_16.Location = new Point(16, 423);
      form1_0.button_16.Name = "button25";
      form1_0.button_16.Size = new Size(104, 24);
      form1_0.button_16.TabIndex = 80;
      form1_0.button_16.Text = "Ekle";
      form1_0.button_16.UseVisualStyleBackColor = false;
      form1_0.button_16.Click += new EventHandler(form1_0.method_59);
      form1_0.listBox_7.BackColor = Color.Gray;
      form1_0.listBox_7.ForeColor = SystemColors.Window;
      form1_0.listBox_7.FormattingEnabled = true;
      form1_0.listBox_7.Location = new Point(16, 205);
      form1_0.listBox_7.Name = "PTForm_listBox";
      form1_0.listBox_7.Size = new Size(220, 212);
      form1_0.listBox_7.TabIndex = 79;
      form1_0.dateTimePicker_5.Format = DateTimePickerFormat.Time;
      form1_0.dateTimePicker_5.ImeMode = ImeMode.NoControl;
      form1_0.dateTimePicker_5.Location = new Point(132, 178);
      form1_0.dateTimePicker_5.Name = "PTForm_Saat";
      form1_0.dateTimePicker_5.RightToLeft = RightToLeft.Yes;
      form1_0.dateTimePicker_5.ShowUpDown = true;
      form1_0.dateTimePicker_5.Size = new Size(104, 21);
      form1_0.dateTimePicker_5.TabIndex = 75;
      form1_0.label_87.AutoSize = true;
      form1_0.label_87.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.label_87.Location = new Point(161, 155);
      form1_0.label_87.Name = "label133";
      form1_0.label_87.Size = new Size(43, 20);
      form1_0.label_87.TabIndex = 73;
      form1_0.label_87.Text = "Saat";
      form1_0.label_88.AutoSize = true;
      form1_0.label_88.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.label_88.Location = new Point(51, 155);
      form1_0.label_88.Name = "label138";
      form1_0.label_88.Size = new Size(40, 20);
      form1_0.label_88.TabIndex = 72;
      form1_0.label_88.Text = "Gün";
      form1_0.xtraTabPage_7.Controls.Add((Control) form1_0.comboBoxEdit_9);
      form1_0.xtraTabPage_7.Controls.Add((Control) form1_0.checkBox_22);
      form1_0.xtraTabPage_7.Controls.Add((Control) form1_0.listBox_16);
      form1_0.xtraTabPage_7.Controls.Add((Control) form1_0.groupBox_39);
      form1_0.xtraTabPage_7.Controls.Add((Control) form1_0.listBox_8);
      form1_0.xtraTabPage_7.Controls.Add((Control) form1_0.button_17);
      form1_0.xtraTabPage_7.Controls.Add((Control) form1_0.button_18);
      form1_0.xtraTabPage_7.Controls.Add((Control) form1_0.textBox_48);
      form1_0.xtraTabPage_7.Controls.Add((Control) form1_0.listBox_9);
      form1_0.xtraTabPage_7.Controls.Add((Control) form1_0.dateTimePicker_6);
      form1_0.xtraTabPage_7.Controls.Add((Control) form1_0.label_89);
      form1_0.xtraTabPage_7.Controls.Add((Control) form1_0.label_90);
      form1_0.xtraTabPage_7.Controls.Add((Control) form1_0.groupBox_32);
      form1_0.xtraTabPage_7.Image = (Image) componentResourceManager.GetObject("AKLIMDAKİ_SAYI.Image");
      form1_0.xtraTabPage_7.Name = "AKLIMDAKİ_SAYI";
      form1_0.xtraTabPage_7.Size = new Size(817, 753);
      form1_0.xtraTabPage_7.Text = "Sayı Tahmin";
      form1_0.xtraTabPage_7.Paint += new PaintEventHandler(form1_0.method_85);
      form1_0.comboBoxEdit_9.EditValue = (object) "Gün Seçin";
      form1_0.comboBoxEdit_9.Location = new Point(67, 27);
      form1_0.comboBoxEdit_9.Name = "SayıBul_EventZamanı";
      form1_0.comboBoxEdit_9.Properties.Appearance.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.comboBoxEdit_9.Properties.Appearance.ForeColor = Color.Salmon;
      form1_0.comboBoxEdit_9.Properties.Appearance.Options.UseBackColor = true;
      form1_0.comboBoxEdit_9.Properties.Appearance.Options.UseForeColor = true;
      form1_0.comboBoxEdit_9.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      form1_0.comboBoxEdit_9.Properties.Items.AddRange(new object[7]
      {
        (object) "Pazartesi",
        (object) "Salı",
        (object) "Çarşamba",
        (object) "Perşembe",
        (object) "Cuma",
        (object) "Cumartesi",
        (object) "Pazar"
      });
      form1_0.comboBoxEdit_9.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
      form1_0.comboBoxEdit_9.Size = new Size(106, 20);
      form1_0.comboBoxEdit_9.TabIndex = 252;
      form1_0.checkBox_22.AutoSize = true;
      form1_0.checkBox_22.BackColor = Color.Transparent;
      form1_0.checkBox_22.ForeColor = Color.Black;
      form1_0.checkBox_22.Location = new Point(10, 4);
      form1_0.checkBox_22.Name = "SayıBul_oylamaSüresiBasladımı";
      form1_0.checkBox_22.Size = new Size(105, 17);
      form1_0.checkBox_22.TabIndex = 251;
      form1_0.checkBox_22.Text = "Event Başladımı?";
      form1_0.checkBox_22.UseVisualStyleBackColor = false;
      form1_0.checkBox_22.Visible = false;
      form1_0.listBox_16.FormattingEnabled = true;
      form1_0.listBox_16.Location = new Point(717, 13);
      form1_0.listBox_16.Name = "SayıBul_tahminde_bulunanlar_listBox";
      form1_0.listBox_16.Size = new Size(82, 147);
      form1_0.listBox_16.TabIndex = 250;
      form1_0.listBox_16.Visible = false;
      form1_0.groupBox_39.BackColor = Color.Gray;
      form1_0.groupBox_39.Controls.Add((Control) form1_0.checkBox_19);
      form1_0.groupBox_39.Controls.Add((Control) form1_0.groupBox_40);
      form1_0.groupBox_39.Controls.Add((Control) form1_0.checkBox_20);
      form1_0.groupBox_39.Controls.Add((Control) form1_0.groupBox_41);
      form1_0.groupBox_39.Controls.Add((Control) form1_0.groupBox_42);
      form1_0.groupBox_39.ForeColor = SystemColors.Window;
      form1_0.groupBox_39.Location = new Point(3, 317);
      form1_0.groupBox_39.Name = "groupBox43";
      form1_0.groupBox_39.Size = new Size(810, 146);
      form1_0.groupBox_39.TabIndex = 248;
      form1_0.groupBox_39.TabStop = false;
      form1_0.groupBox_39.Text = "AYARLAR";
      form1_0.checkBox_19.AutoSize = true;
      form1_0.checkBox_19.Location = new Point(667, 76);
      form1_0.checkBox_19.Name = "SayıBıl_ÖdülTİpi_SGSR";
      form1_0.checkBox_19.Size = new Size(15, 14);
      form1_0.checkBox_19.TabIndex = 43;
      form1_0.checkBox_19.UseVisualStyleBackColor = true;
      form1_0.checkBox_19.CheckedChanged += new EventHandler(form1_0.method_44);
      form1_0.groupBox_40.BackColor = Color.Gray;
      form1_0.groupBox_40.Controls.Add((Control) form1_0.label_119);
      form1_0.groupBox_40.Controls.Add((Control) form1_0.label_118);
      form1_0.groupBox_40.ForeColor = SystemColors.Window;
      form1_0.groupBox_40.Location = new Point(6, 20);
      form1_0.groupBox_40.Name = "groupBox44";
      form1_0.groupBox_40.Size = new Size(334, 107);
      form1_0.groupBox_40.TabIndex = 42;
      form1_0.groupBox_40.TabStop = false;
      form1_0.groupBox_40.Text = "GENEL AYARLAR";
      form1_0.label_119.AutoSize = true;
      form1_0.label_119.Location = new Point(66, 52);
      form1_0.label_119.Name = "label193";
      form1_0.label_119.Size = new Size(125, 13);
      form1_0.label_119.TabIndex = 239;
      form1_0.label_119.Text = "Ortalama Etkinlik Süresi :";
      form1_0.label_118.AutoSize = true;
      form1_0.label_118.Location = new Point(204, 52);
      form1_0.label_118.Name = "label192";
      form1_0.label_118.Size = new Size(13, 13);
      form1_0.label_118.TabIndex = 240;
      form1_0.label_118.Text = "0";
      form1_0.checkBox_20.AutoSize = true;
      form1_0.checkBox_20.Location = new Point(346, 68);
      form1_0.checkBox_20.Name = "SayıBıl_ÖdülTİpi_ITEM";
      form1_0.checkBox_20.Size = new Size(15, 14);
      form1_0.checkBox_20.TabIndex = 9;
      form1_0.checkBox_20.UseVisualStyleBackColor = true;
      form1_0.checkBox_20.CheckedChanged += new EventHandler(form1_0.method_43);
      form1_0.groupBox_41.BackColor = Color.Gray;
      form1_0.groupBox_41.Controls.Add((Control) form1_0.textBox_70);
      form1_0.groupBox_41.Controls.Add((Control) form1_0.label_125);
      form1_0.groupBox_41.Controls.Add((Control) form1_0.label_123);
      form1_0.groupBox_41.Controls.Add((Control) form1_0.label_124);
      form1_0.groupBox_41.Controls.Add((Control) form1_0.textBox_71);
      form1_0.groupBox_41.Controls.Add((Control) form1_0.textBox_72);
      form1_0.groupBox_41.Enabled = false;
      form1_0.groupBox_41.ForeColor = SystemColors.Window;
      form1_0.groupBox_41.Location = new Point(688, 12);
      form1_0.groupBox_41.Name = "groupBox45";
      form1_0.groupBox_41.Size = new Size(111, 131);
      form1_0.groupBox_41.TabIndex = 11;
      form1_0.groupBox_41.TabStop = false;
      form1_0.groupBox_41.Text = "SİLK- GOLD - SP";
      form1_0.textBox_70.BackColor = Color.Salmon;
      form1_0.textBox_70.Location = new Point(6, 67);
      form1_0.textBox_70.MaxLength = 19;
      form1_0.textBox_70.Name = "textBox51";
      form1_0.textBox_70.Size = new Size(102, 21);
      form1_0.textBox_70.TabIndex = 6;
      form1_0.textBox_70.Text = "0";
      form1_0.textBox_70.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_70.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.label_125.AutoSize = true;
      form1_0.label_125.Location = new Point(23, 53);
      form1_0.label_125.Name = "label205";
      form1_0.label_125.Size = new Size(62, 13);
      form1_0.label_125.TabIndex = 37;
      form1_0.label_125.Text = "Gold Miktari";
      form1_0.label_123.AutoSize = true;
      form1_0.label_123.Location = new Point(23, 14);
      form1_0.label_123.Name = "label203";
      form1_0.label_123.Size = new Size(56, 13);
      form1_0.label_123.TabIndex = 36;
      form1_0.label_123.Text = "Silk Miktarı";
      form1_0.label_124.AutoSize = true;
      form1_0.label_124.Location = new Point(34, 90);
      form1_0.label_124.Name = "label204";
      form1_0.label_124.Size = new Size(53, 13);
      form1_0.label_124.TabIndex = 38;
      form1_0.label_124.Text = "SP Miktarı";
      form1_0.textBox_71.BackColor = Color.Salmon;
      form1_0.textBox_71.Location = new Point(17, 29);
      form1_0.textBox_71.MaxLength = 19;
      form1_0.textBox_71.Name = "textBox52";
      form1_0.textBox_71.Size = new Size(71, 21);
      form1_0.textBox_71.TabIndex = 4;
      form1_0.textBox_71.Text = "0";
      form1_0.textBox_71.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_71.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_72.BackColor = Color.Salmon;
      form1_0.textBox_72.Location = new Point(17, 106);
      form1_0.textBox_72.MaxLength = 19;
      form1_0.textBox_72.Name = "textBox53";
      form1_0.textBox_72.Size = new Size(71, 21);
      form1_0.textBox_72.TabIndex = 5;
      form1_0.textBox_72.Text = "0";
      form1_0.textBox_72.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_72.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.groupBox_42.BackColor = Color.Gray;
      form1_0.groupBox_42.Controls.Add((Control) form1_0.textBox_97);
      form1_0.groupBox_42.Controls.Add((Control) form1_0.label_154);
      form1_0.groupBox_42.Controls.Add((Control) form1_0.label_126);
      form1_0.groupBox_42.Controls.Add((Control) form1_0.label_127);
      form1_0.groupBox_42.Controls.Add((Control) form1_0.label_128);
      form1_0.groupBox_42.Controls.Add((Control) form1_0.textBox_73);
      form1_0.groupBox_42.Controls.Add((Control) form1_0.textBox_74);
      form1_0.groupBox_42.Controls.Add((Control) form1_0.textBox_75);
      form1_0.groupBox_42.Enabled = false;
      form1_0.groupBox_42.ForeColor = SystemColors.Window;
      form1_0.groupBox_42.Location = new Point(375, 12);
      form1_0.groupBox_42.Name = "groupBox46";
      form1_0.groupBox_42.Size = new Size(286, 131);
      form1_0.groupBox_42.TabIndex = 10;
      form1_0.groupBox_42.TabStop = false;
      form1_0.groupBox_42.Text = "ITEM";
      form1_0.textBox_97.BackColor = Color.Salmon;
      form1_0.textBox_97.Location = new Point(102, 96);
      form1_0.textBox_97.Name = "textBox50";
      form1_0.textBox_97.Size = new Size(174, 21);
      form1_0.textBox_97.TabIndex = 54;
      form1_0.textBox_97.Text = "Sun Sword ( 1 Dg )";
      form1_0.textBox_97.TextAlign = HorizontalAlignment.Center;
      form1_0.label_154.AutoSize = true;
      form1_0.label_154.Location = new Point(160, 82);
      form1_0.label_154.Name = "label190";
      form1_0.label_154.Size = new Size(56, 13);
      form1_0.label_154.TabIndex = 53;
      form1_0.label_154.Text = "ITEM İSMİ";
      form1_0.label_126.AutoSize = true;
      form1_0.label_126.Location = new Point(32, 80);
      form1_0.label_126.Name = "label206";
      form1_0.label_126.Size = new Size(31, 13);
      form1_0.label_126.TabIndex = 41;
      form1_0.label_126.Text = "PLUS";
      form1_0.label_127.AutoSize = true;
      form1_0.label_127.Location = new Point(218, 17);
      form1_0.label_127.Name = "label207";
      form1_0.label_127.Size = new Size(33, 13);
      form1_0.label_127.TabIndex = 40;
      form1_0.label_127.Text = "ADET";
      form1_0.label_128.AutoSize = true;
      form1_0.label_128.Location = new Point(65, 17);
      form1_0.label_128.Name = "label208";
      form1_0.label_128.Size = new Size(62, 13);
      form1_0.label_128.TabIndex = 39;
      form1_0.label_128.Text = "ITEM KODU";
      form1_0.textBox_73.BackColor = Color.Salmon;
      form1_0.textBox_73.Location = new Point(12, 96);
      form1_0.textBox_73.Name = "textBox66";
      form1_0.textBox_73.Size = new Size(65, 21);
      form1_0.textBox_73.TabIndex = 8;
      form1_0.textBox_73.Text = "1";
      form1_0.textBox_73.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_73.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_74.BackColor = Color.Salmon;
      form1_0.textBox_74.Location = new Point(202, 33);
      form1_0.textBox_74.Name = "textBox67";
      form1_0.textBox_74.Size = new Size(74, 21);
      form1_0.textBox_74.TabIndex = 7;
      form1_0.textBox_74.Text = "1";
      form1_0.textBox_74.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_74.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_75.BackColor = Color.Salmon;
      form1_0.textBox_75.Location = new Point(12, 33);
      form1_0.textBox_75.Name = "textBox68";
      form1_0.textBox_75.Size = new Size(174, 21);
      form1_0.textBox_75.TabIndex = 4;
      form1_0.textBox_75.Text = "ITEM_CH_SWORD_01_C_RARE";
      form1_0.textBox_75.TextAlign = HorizontalAlignment.Center;
      form1_0.listBox_8.FormattingEnabled = true;
      form1_0.listBox_8.Location = new Point(719, 164);
      form1_0.listBox_8.Name = "listBox10";
      form1_0.listBox_8.Size = new Size(83, 147);
      form1_0.listBox_8.TabIndex = 247;
      form1_0.listBox_8.Visible = false;
      form1_0.button_17.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.button_17.BackgroundImageLayout = ImageLayout.Stretch;
      form1_0.button_17.DialogResult = DialogResult.Cancel;
      form1_0.button_17.FlatStyle = FlatStyle.Flat;
      form1_0.button_17.ForeColor = SystemColors.Window;
      form1_0.button_17.Location = new Point(184, 287);
      form1_0.button_17.Name = "button32";
      form1_0.button_17.Size = new Size(104, 24);
      form1_0.button_17.TabIndex = 246;
      form1_0.button_17.Text = "Sil";
      form1_0.button_17.UseVisualStyleBackColor = false;
      form1_0.button_17.Click += new EventHandler(form1_0.method_55);
      form1_0.button_18.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.button_18.BackgroundImageLayout = ImageLayout.Stretch;
      form1_0.button_18.FlatStyle = FlatStyle.Flat;
      form1_0.button_18.ForeColor = SystemColors.Window;
      form1_0.button_18.Location = new Point(68, 287);
      form1_0.button_18.Name = "button33";
      form1_0.button_18.Size = new Size(104, 24);
      form1_0.button_18.TabIndex = 245;
      form1_0.button_18.Text = "Ekle";
      form1_0.button_18.UseVisualStyleBackColor = false;
      form1_0.button_18.Click += new EventHandler(form1_0.method_60);
      form1_0.textBox_48.Location = new Point(242, 53);
      form1_0.textBox_48.Name = "textBox84";
      form1_0.textBox_48.Size = new Size(45, 21);
      form1_0.textBox_48.TabIndex = 244;
      form1_0.textBox_48.Visible = false;
      form1_0.listBox_9.BackColor = Color.Gray;
      form1_0.listBox_9.ForeColor = SystemColors.Window;
      form1_0.listBox_9.FormattingEnabled = true;
      form1_0.listBox_9.Location = new Point(67, 54);
      form1_0.listBox_9.Name = "SayıBul_listBox";
      form1_0.listBox_9.Size = new Size(220, 225);
      form1_0.listBox_9.TabIndex = 243;
      form1_0.dateTimePicker_6.Format = DateTimePickerFormat.Time;
      form1_0.dateTimePicker_6.ImeMode = ImeMode.NoControl;
      form1_0.dateTimePicker_6.Location = new Point(183, 27);
      form1_0.dateTimePicker_6.Name = "SayıBul_Saat";
      form1_0.dateTimePicker_6.RightToLeft = RightToLeft.Yes;
      form1_0.dateTimePicker_6.ShowUpDown = true;
      form1_0.dateTimePicker_6.Size = new Size(104, 21);
      form1_0.dateTimePicker_6.TabIndex = 242;
      form1_0.label_89.AutoSize = true;
      form1_0.label_89.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.label_89.Location = new Point(212, 4);
      form1_0.label_89.Name = "label163";
      form1_0.label_89.Size = new Size(43, 20);
      form1_0.label_89.TabIndex = 240;
      form1_0.label_89.Text = "Saat";
      form1_0.label_90.AutoSize = true;
      form1_0.label_90.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.label_90.Location = new Point(102, 4);
      form1_0.label_90.Name = "label164";
      form1_0.label_90.Size = new Size(40, 20);
      form1_0.label_90.TabIndex = 239;
      form1_0.label_90.Text = "Gün";
      form1_0.groupBox_32.BackColor = Color.Transparent;
      form1_0.groupBox_32.Controls.Add((Control) form1_0.checkEdit_0);
      form1_0.groupBox_32.Controls.Add((Control) form1_0.textBox_69);
      form1_0.groupBox_32.Controls.Add((Control) form1_0.label_121);
      form1_0.groupBox_32.Controls.Add((Control) form1_0.textBox_68);
      form1_0.groupBox_32.Controls.Add((Control) form1_0.label_122);
      form1_0.groupBox_32.Controls.Add((Control) form1_0.textBox_67);
      form1_0.groupBox_32.Controls.Add((Control) form1_0.textBox_49);
      form1_0.groupBox_32.Controls.Add((Control) form1_0.label_91);
      form1_0.groupBox_32.Controls.Add((Control) form1_0.textBox_50);
      form1_0.groupBox_32.Controls.Add((Control) form1_0.label_92);
      form1_0.groupBox_32.Controls.Add((Control) form1_0.textBox_51);
      form1_0.groupBox_32.Controls.Add((Control) form1_0.label_93);
      form1_0.groupBox_32.ForeColor = SystemColors.Window;
      form1_0.groupBox_32.Location = new Point(338, 3);
      form1_0.groupBox_32.Name = "groupBox41";
      form1_0.groupBox_32.Size = new Size(373, 308);
      form1_0.groupBox_32.TabIndex = 238;
      form1_0.groupBox_32.TabStop = false;
      form1_0.groupBox_32.Text = "ETKİNLİK AYARLARI";
      form1_0.groupBox_32.Enter += new EventHandler(form1_0.method_47);
      form1_0.checkEdit_0.Location = new Point(59, 51);
      form1_0.checkEdit_0.Name = "SayıBulma_Basladımı";
      form1_0.checkEdit_0.Properties.Caption = "Oylama basladımı";
      form1_0.checkEdit_0.Size = new Size(111, 19);
      form1_0.checkEdit_0.TabIndex = 248;
      form1_0.checkEdit_0.Visible = false;
      form1_0.textBox_69.Location = new Point(176, 12);
      form1_0.textBox_69.Name = "Text_Sonuc_ChnrName";
      form1_0.textBox_69.Size = new Size(104, 21);
      form1_0.textBox_69.TabIndex = 246;
      form1_0.textBox_69.Visible = false;
      form1_0.label_121.AutoSize = true;
      form1_0.label_121.ForeColor = Color.PaleGoldenrod;
      form1_0.label_121.Location = new Point(199, 207);
      form1_0.label_121.Name = "label197";
      form1_0.label_121.Size = new Size(81, 13);
      form1_0.label_121.TabIndex = 243;
      form1_0.label_121.Text = "(Sistem belirler)";
      form1_0.textBox_68.Location = new Point(303, 12);
      form1_0.textBox_68.Name = "Text_aranacak_Sayı";
      form1_0.textBox_68.Size = new Size(64, 21);
      form1_0.textBox_68.TabIndex = 245;
      form1_0.textBox_68.Visible = false;
      form1_0.label_122.AutoSize = true;
      form1_0.label_122.ForeColor = SystemColors.Window;
      form1_0.label_122.Location = new Point(24, 207);
      form1_0.label_122.Name = "label196";
      form1_0.label_122.Size = new Size(92, 13);
      form1_0.label_122.TabIndex = 242;
      form1_0.label_122.Text = "Aranan Sayı ==>";
      form1_0.textBox_67.BackColor = Color.Salmon;
      form1_0.textBox_67.Enabled = false;
      form1_0.textBox_67.Location = new Point(122, 203);
      form1_0.textBox_67.Name = "textBox47";
      form1_0.textBox_67.Size = new Size(72, 21);
      form1_0.textBox_67.TabIndex = 241;
      form1_0.textBox_67.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_67.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.textBox_49.BackColor = Color.Salmon;
      form1_0.textBox_49.ForeColor = SystemColors.Window;
      form1_0.textBox_49.Location = new Point(303, 144);
      form1_0.textBox_49.MaxLength = 4;
      form1_0.textBox_49.Multiline = true;
      form1_0.textBox_49.Name = "textBox89";
      form1_0.textBox_49.Size = new Size(54, 21);
      form1_0.textBox_49.TabIndex = 237;
      form1_0.textBox_49.Text = "250";
      form1_0.textBox_49.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_49.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.label_91.AutoSize = true;
      form1_0.label_91.Location = new Point(24, 92);
      form1_0.label_91.Name = "label175";
      form1_0.label_91.Size = new Size(96, 13);
      form1_0.label_91.TabIndex = 41;
      form1_0.label_91.Text = "Etkinlik tur sayısı =";
      form1_0.textBox_50.BackColor = Color.Salmon;
      form1_0.textBox_50.Location = new Point(128, 87);
      form1_0.textBox_50.MaxLength = 1;
      form1_0.textBox_50.Name = "textBox90";
      form1_0.textBox_50.Size = new Size(42, 21);
      form1_0.textBox_50.TabIndex = 40;
      form1_0.textBox_50.Text = "3";
      form1_0.textBox_50.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_50.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.label_92.AutoSize = true;
      form1_0.label_92.ForeColor = SystemColors.Window;
      form1_0.label_92.Location = new Point(266, 147);
      form1_0.label_92.Name = "label167";
      form1_0.label_92.Size = new Size(31, 13);
      form1_0.label_92.TabIndex = 236;
      form1_0.label_92.Text = "<-->";
      form1_0.textBox_51.BackColor = Color.Salmon;
      form1_0.textBox_51.ForeColor = SystemColors.Window;
      form1_0.textBox_51.Location = new Point(206, 144);
      form1_0.textBox_51.MaxLength = 4;
      form1_0.textBox_51.Multiline = true;
      form1_0.textBox_51.Name = "textBox85";
      form1_0.textBox_51.Size = new Size(54, 21);
      form1_0.textBox_51.TabIndex = 213;
      form1_0.textBox_51.Text = "1";
      form1_0.textBox_51.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_51.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.label_93.AutoSize = true;
      form1_0.label_93.ForeColor = SystemColors.Window;
      form1_0.label_93.Location = new Point(22, 150);
      form1_0.label_93.Name = "label172";
      form1_0.label_93.Size = new Size(178, 13);
      form1_0.label_93.TabIndex = 211;
      form1_0.label_93.Text = "Rastgele üretilecek sayı aralığı ==>";
      form1_0.xtraTabPage_8.Controls.Add((Control) form1_0.comboBoxEdit_10);
      form1_0.xtraTabPage_8.Controls.Add((Control) form1_0.textBox_84);
      form1_0.xtraTabPage_8.Controls.Add((Control) form1_0.button_20);
      form1_0.xtraTabPage_8.Controls.Add((Control) form1_0.button_21);
      form1_0.xtraTabPage_8.Controls.Add((Control) form1_0.listBox_12);
      form1_0.xtraTabPage_8.Controls.Add((Control) form1_0.dateTimePicker_7);
      form1_0.xtraTabPage_8.Controls.Add((Control) form1_0.label_130);
      form1_0.xtraTabPage_8.Controls.Add((Control) form1_0.label_131);
      form1_0.xtraTabPage_8.Controls.Add((Control) form1_0.groupBox_43);
      form1_0.xtraTabPage_8.Controls.Add((Control) form1_0.groupBox_10);
      form1_0.xtraTabPage_8.Image = (Image) componentResourceManager.GetObject("HayattaKal.Image");
      form1_0.xtraTabPage_8.Name = "HayattaKal";
      form1_0.xtraTabPage_8.Size = new Size(817, 753);
      form1_0.xtraTabPage_8.Text = "Hayatta Kal";
      form1_0.xtraTabPage_8.Paint += new PaintEventHandler(form1_0.method_86);
      form1_0.comboBoxEdit_10.EditValue = (object) "Gün Seçin";
      form1_0.comboBoxEdit_10.Location = new Point(3, 174);
      form1_0.comboBoxEdit_10.Name = "HayattaKal_EventGünü";
      form1_0.comboBoxEdit_10.Properties.Appearance.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.comboBoxEdit_10.Properties.Appearance.ForeColor = Color.Salmon;
      form1_0.comboBoxEdit_10.Properties.Appearance.Options.UseBackColor = true;
      form1_0.comboBoxEdit_10.Properties.Appearance.Options.UseForeColor = true;
      form1_0.comboBoxEdit_10.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      form1_0.comboBoxEdit_10.Properties.Items.AddRange(new object[7]
      {
        (object) "Pazartesi",
        (object) "Salı",
        (object) "Çarşamba",
        (object) "Perşembe",
        (object) "Cuma",
        (object) "Cumartesi",
        (object) "Pazar"
      });
      form1_0.comboBoxEdit_10.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
      form1_0.comboBoxEdit_10.Size = new Size(106, 20);
      form1_0.comboBoxEdit_10.TabIndex = 83;
      form1_0.textBox_84.Location = new Point(178, 200);
      form1_0.textBox_84.Name = "textBox1";
      form1_0.textBox_84.Size = new Size(45, 21);
      form1_0.textBox_84.TabIndex = 245;
      form1_0.textBox_84.Visible = false;
      form1_0.button_20.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.button_20.BackgroundImageLayout = ImageLayout.Stretch;
      form1_0.button_20.FlatStyle = FlatStyle.Flat;
      form1_0.button_20.ForeColor = SystemColors.Window;
      form1_0.button_20.Location = new Point(121, 421);
      form1_0.button_20.Name = "button2";
      form1_0.button_20.Size = new Size(104, 24);
      form1_0.button_20.TabIndex = 91;
      form1_0.button_20.Text = "Sil";
      form1_0.button_20.UseVisualStyleBackColor = false;
      form1_0.button_20.Click += new EventHandler(form1_0.method_70);
      form1_0.button_21.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.button_21.BackgroundImageLayout = ImageLayout.Stretch;
      form1_0.button_21.FlatStyle = FlatStyle.Flat;
      form1_0.button_21.ForeColor = SystemColors.Window;
      form1_0.button_21.Location = new Point(3, 421);
      form1_0.button_21.Name = "button31";
      form1_0.button_21.Size = new Size(104, 24);
      form1_0.button_21.TabIndex = 90;
      form1_0.button_21.Text = "Ekle";
      form1_0.button_21.UseVisualStyleBackColor = false;
      form1_0.button_21.Click += new EventHandler(form1_0.method_69);
      form1_0.listBox_12.BackColor = Color.Gray;
      form1_0.listBox_12.ForeColor = SystemColors.Window;
      form1_0.listBox_12.FormattingEnabled = true;
      form1_0.listBox_12.Location = new Point(3, 200);
      form1_0.listBox_12.Name = "HayaTTaKal_listBox_etknlik_Takvimi";
      form1_0.listBox_12.Size = new Size(220, 212);
      form1_0.listBox_12.TabIndex = 89;
      form1_0.dateTimePicker_7.Format = DateTimePickerFormat.Time;
      form1_0.dateTimePicker_7.ImeMode = ImeMode.NoControl;
      form1_0.dateTimePicker_7.Location = new Point(119, 173);
      form1_0.dateTimePicker_7.Name = "HayattaKal_EventSaati";
      form1_0.dateTimePicker_7.RightToLeft = RightToLeft.Yes;
      form1_0.dateTimePicker_7.ShowUpDown = true;
      form1_0.dateTimePicker_7.Size = new Size(104, 21);
      form1_0.dateTimePicker_7.TabIndex = 88;
      form1_0.label_130.AutoSize = true;
      form1_0.label_130.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.label_130.Location = new Point(148, 152);
      form1_0.label_130.Name = "label100";
      form1_0.label_130.Size = new Size(43, 20);
      form1_0.label_130.TabIndex = 86;
      form1_0.label_130.Text = "Saat";
      form1_0.label_131.AutoSize = true;
      form1_0.label_131.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.label_131.Location = new Point(38, 150);
      form1_0.label_131.Name = "label121";
      form1_0.label_131.Size = new Size(40, 20);
      form1_0.label_131.TabIndex = 85;
      form1_0.label_131.Text = "Gün";
      form1_0.groupBox_43.BackColor = Color.Gray;
      form1_0.groupBox_43.Controls.Add((Control) form1_0.button_22);
      form1_0.groupBox_43.Controls.Add((Control) form1_0.label_136);
      form1_0.groupBox_43.Controls.Add((Control) form1_0.textBox_81);
      form1_0.groupBox_43.Controls.Add((Control) form1_0.label_137);
      form1_0.groupBox_43.Controls.Add((Control) form1_0.textBox_82);
      form1_0.groupBox_43.Controls.Add((Control) form1_0.label_132);
      form1_0.groupBox_43.Controls.Add((Control) form1_0.label_133);
      form1_0.groupBox_43.Controls.Add((Control) form1_0.checkBox_21);
      form1_0.groupBox_43.ForeColor = SystemColors.Menu;
      form1_0.groupBox_43.Location = new Point(3, 6);
      form1_0.groupBox_43.Name = "groupBox23";
      form1_0.groupBox_43.Size = new Size(220, 140);
      form1_0.groupBox_43.TabIndex = 84;
      form1_0.groupBox_43.TabStop = false;
      form1_0.groupBox_43.Text = "BÖLGE";
      form1_0.button_22.BackColor = Color.Salmon;
      form1_0.button_22.FlatStyle = FlatStyle.Flat;
      form1_0.button_22.Font = new Font("Microsoft Sans Serif", 8.25f);
      form1_0.button_22.ForeColor = Color.Black;
      form1_0.button_22.Location = new Point(138, 51);
      form1_0.button_22.Name = "button13";
      form1_0.button_22.Size = new Size(70, 30);
      form1_0.button_22.TabIndex = 70;
      form1_0.button_22.Text = "Bilgi Al";
      form1_0.button_22.UseVisualStyleBackColor = false;
      form1_0.button_22.Click += new EventHandler(form1_0.method_68);
      form1_0.label_136.AutoSize = true;
      form1_0.label_136.Location = new Point(36, 60);
      form1_0.label_136.Name = "label182";
      form1_0.label_136.Size = new Size(62, 13);
      form1_0.label_136.TabIndex = 62;
      form1_0.label_136.Text = "Koordinat Y";
      form1_0.textBox_81.BackColor = Color.Salmon;
      form1_0.textBox_81.Location = new Point(21, 77);
      form1_0.textBox_81.Name = "HayattaKal_Krdnt_Y";
      form1_0.textBox_81.Size = new Size(101, 21);
      form1_0.textBox_81.TabIndex = 61;
      form1_0.textBox_81.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_81.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.label_137.AutoSize = true;
      form1_0.label_137.Location = new Point(36, 20);
      form1_0.label_137.Name = "label124";
      form1_0.label_137.Size = new Size(65, 13);
      form1_0.label_137.TabIndex = 60;
      form1_0.label_137.Text = "Koordinat X ";
      form1_0.textBox_82.BackColor = Color.Salmon;
      form1_0.textBox_82.Location = new Point(21, 36);
      form1_0.textBox_82.Name = "HayattaKal_Krdnt_X";
      form1_0.textBox_82.Size = new Size(101, 21);
      form1_0.textBox_82.TabIndex = 59;
      form1_0.textBox_82.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_82.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.label_132.AutoSize = true;
      form1_0.label_132.Location = new Point(143, 110);
      form1_0.label_132.Name = "label122";
      form1_0.label_132.Size = new Size(13, 13);
      form1_0.label_132.TabIndex = 58;
      form1_0.label_132.Text = "0";
      form1_0.label_133.AutoSize = true;
      form1_0.label_133.Location = new Point(18, 110);
      form1_0.label_133.Name = "label151";
      form1_0.label_133.Size = new Size(125, 13);
      form1_0.label_133.TabIndex = 57;
      form1_0.label_133.Text = "Ortalama Etkinlik Süresi :";
      form1_0.checkBox_21.AutoSize = true;
      form1_0.checkBox_21.BackColor = Color.Transparent;
      form1_0.checkBox_21.ForeColor = Color.Black;
      form1_0.checkBox_21.Location = new Point(69, 0);
      form1_0.checkBox_21.Name = "HayattaKal_basladımı";
      form1_0.checkBox_21.Size = new Size(105, 17);
      form1_0.checkBox_21.TabIndex = 56;
      form1_0.checkBox_21.Text = "Event Başladımı?";
      form1_0.checkBox_21.UseVisualStyleBackColor = false;
      form1_0.checkBox_21.Visible = false;
      form1_0.xtraTabPage_9.Controls.Add((Control) form1_0.label_175);
      form1_0.xtraTabPage_9.Controls.Add((Control) form1_0.listBox_23);
      form1_0.xtraTabPage_9.Controls.Add((Control) form1_0.checkBox_28);
      form1_0.xtraTabPage_9.Controls.Add((Control) form1_0.button_36);
      form1_0.xtraTabPage_9.Controls.Add((Control) form1_0.groupBox_46);
      form1_0.xtraTabPage_9.Controls.Add((Control) form1_0.comboBoxEdit_12);
      form1_0.xtraTabPage_9.Controls.Add((Control) form1_0.checkBox_27);
      form1_0.xtraTabPage_9.Controls.Add((Control) form1_0.button_34);
      form1_0.xtraTabPage_9.Controls.Add((Control) form1_0.button_35);
      form1_0.xtraTabPage_9.Controls.Add((Control) form1_0.textBox_102);
      form1_0.xtraTabPage_9.Controls.Add((Control) form1_0.listBox_22);
      form1_0.xtraTabPage_9.Controls.Add((Control) form1_0.dateTimePicker_9);
      form1_0.xtraTabPage_9.Controls.Add((Control) form1_0.label_172);
      form1_0.xtraTabPage_9.Controls.Add((Control) form1_0.label_173);
      form1_0.xtraTabPage_9.Image = (Image) Class73.smethod_35();
      form1_0.xtraTabPage_9.Name = "xtraTabPage1";
      form1_0.xtraTabPage_9.Size = new Size(817, 753);
      form1_0.xtraTabPage_9.Text = "Piyango";
      form1_0.label_175.AutoSize = true;
      form1_0.label_175.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.label_175.Location = new Point(642, 62);
      form1_0.label_175.Name = "label47";
      form1_0.label_175.Size = new Size(119, 20);
      form1_0.label_175.TabIndex = 266;
      form1_0.label_175.Text = "KATILIMCILAR";
      form1_0.listBox_23.BackColor = Color.Salmon;
      form1_0.listBox_23.FormattingEnabled = true;
      form1_0.listBox_23.Location = new Point(610, 94);
      form1_0.listBox_23.Name = "MP_Katılımcılar";
      form1_0.listBox_23.Size = new Size(187, 303);
      form1_0.listBox_23.TabIndex = 265;
      form1_0.checkBox_28.AutoSize = true;
      form1_0.checkBox_28.BackColor = Color.Transparent;
      form1_0.checkBox_28.ForeColor = Color.Black;
      form1_0.checkBox_28.Location = new Point(399, 98);
      form1_0.checkBox_28.Name = "MP_Katılım_Durumu";
      form1_0.checkBox_28.Size = new Size(87, 17);
      form1_0.checkBox_28.TabIndex = 264;
      form1_0.checkBox_28.Text = "Katılım açıkmı";
      form1_0.checkBox_28.UseVisualStyleBackColor = false;
      form1_0.checkBox_28.Visible = false;
      form1_0.button_36.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.button_36.BackgroundImageLayout = ImageLayout.Stretch;
      form1_0.button_36.FlatStyle = FlatStyle.Flat;
      form1_0.button_36.ForeColor = SystemColors.Window;
      form1_0.button_36.Location = new Point(398, 43);
      form1_0.button_36.Name = "button36";
      form1_0.button_36.Size = new Size(104, 24);
      form1_0.button_36.TabIndex = 263;
      form1_0.button_36.Text = "BAŞLAT";
      form1_0.button_36.UseVisualStyleBackColor = false;
      form1_0.button_36.Visible = false;
      form1_0.button_36.Click += new EventHandler(form1_0.method_108);
      form1_0.groupBox_46.BackColor = Color.Gray;
      form1_0.groupBox_46.Controls.Add((Control) form1_0.label_176);
      form1_0.groupBox_46.Controls.Add((Control) form1_0.label_174);
      form1_0.groupBox_46.Controls.Add((Control) form1_0.textBox_103);
      form1_0.groupBox_46.Controls.Add((Control) form1_0.comboBoxEdit_13);
      form1_0.groupBox_46.ForeColor = SystemColors.Window;
      form1_0.groupBox_46.Location = new Point(322, 176);
      form1_0.groupBox_46.Name = "groupBox17";
      form1_0.groupBox_46.Size = new Size(261, 135);
      form1_0.groupBox_46.TabIndex = 262;
      form1_0.groupBox_46.TabStop = false;
      form1_0.groupBox_46.Text = "ETKİNLİK AYARLARI";
      form1_0.label_176.AutoSize = true;
      form1_0.label_176.Location = new Point(103, 30);
      form1_0.label_176.Name = "label43";
      form1_0.label_176.Size = new Size(61, 13);
      form1_0.label_176.TabIndex = 267;
      form1_0.label_176.Text = "Çekiliş Türü";
      form1_0.label_174.AutoSize = true;
      form1_0.label_174.Location = new Point(112, 78);
      form1_0.label_174.Name = "label44";
      form1_0.label_174.Size = new Size(36, 13);
      form1_0.label_174.TabIndex = 266;
      form1_0.label_174.Text = "Miktar";
      form1_0.textBox_103.BackColor = Color.Salmon;
      form1_0.textBox_103.Location = new Point(77, 95);
      form1_0.textBox_103.Name = "textBox18";
      form1_0.textBox_103.Size = new Size(117, 21);
      form1_0.textBox_103.TabIndex = 265;
      form1_0.textBox_103.Text = "1000000";
      form1_0.textBox_103.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_103.TextChanged += new EventHandler(form1_0.method_110);
      form1_0.textBox_103.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.comboBoxEdit_13.EditValue = (object) "Gold";
      form1_0.comboBoxEdit_13.Location = new Point(76, 50);
      form1_0.comboBoxEdit_13.Name = "comboBoxEdit2";
      form1_0.comboBoxEdit_13.Properties.Appearance.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.comboBoxEdit_13.Properties.Appearance.ForeColor = Color.Salmon;
      form1_0.comboBoxEdit_13.Properties.Appearance.Options.UseBackColor = true;
      form1_0.comboBoxEdit_13.Properties.Appearance.Options.UseForeColor = true;
      form1_0.comboBoxEdit_13.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      form1_0.comboBoxEdit_13.Properties.Items.AddRange(new object[3]
      {
        (object) "Gold",
        (object) "Silk",
        (object) "Sp"
      });
      form1_0.comboBoxEdit_13.Size = new Size(118, 20);
      form1_0.comboBoxEdit_13.TabIndex = 262;
      form1_0.comboBoxEdit_13.SelectedIndexChanged += new EventHandler(form1_0.method_107);
      form1_0.comboBoxEdit_12.EditValue = (object) "Gün Seçin";
      form1_0.comboBoxEdit_12.Location = new Point(73, 67);
      form1_0.comboBoxEdit_12.Name = "MP_gün";
      form1_0.comboBoxEdit_12.Properties.Appearance.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.comboBoxEdit_12.Properties.Appearance.ForeColor = Color.Salmon;
      form1_0.comboBoxEdit_12.Properties.Appearance.Options.UseBackColor = true;
      form1_0.comboBoxEdit_12.Properties.Appearance.Options.UseForeColor = true;
      form1_0.comboBoxEdit_12.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      form1_0.comboBoxEdit_12.Properties.Items.AddRange(new object[7]
      {
        (object) "Pazartesi",
        (object) "Salı",
        (object) "Çarşamba",
        (object) "Perşembe",
        (object) "Cuma",
        (object) "Cumartesi",
        (object) "Pazar"
      });
      form1_0.comboBoxEdit_12.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
      form1_0.comboBoxEdit_12.Size = new Size(106, 20);
      form1_0.comboBoxEdit_12.TabIndex = 261;
      form1_0.checkBox_27.AutoSize = true;
      form1_0.checkBox_27.BackColor = Color.Transparent;
      form1_0.checkBox_27.ForeColor = Color.Black;
      form1_0.checkBox_27.Location = new Point(388, 75);
      form1_0.checkBox_27.Name = "MP_Event_Basladımı";
      form1_0.checkBox_27.Size = new Size(105, 17);
      form1_0.checkBox_27.TabIndex = 260;
      form1_0.checkBox_27.Text = "Event Başladımı?";
      form1_0.checkBox_27.UseVisualStyleBackColor = false;
      form1_0.checkBox_27.Visible = false;
      form1_0.button_34.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.button_34.BackgroundImageLayout = ImageLayout.Stretch;
      form1_0.button_34.DialogResult = DialogResult.Cancel;
      form1_0.button_34.FlatStyle = FlatStyle.Flat;
      form1_0.button_34.ForeColor = SystemColors.Window;
      form1_0.button_34.Location = new Point(189, 413);
      form1_0.button_34.Name = "button34";
      form1_0.button_34.Size = new Size(104, 24);
      form1_0.button_34.TabIndex = 259;
      form1_0.button_34.Text = "Sil";
      form1_0.button_34.UseVisualStyleBackColor = false;
      form1_0.button_34.Click += new EventHandler(form1_0.method_112);
      form1_0.button_35.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.button_35.BackgroundImageLayout = ImageLayout.Stretch;
      form1_0.button_35.FlatStyle = FlatStyle.Flat;
      form1_0.button_35.ForeColor = SystemColors.Window;
      form1_0.button_35.Location = new Point(73, 413);
      form1_0.button_35.Name = "button35";
      form1_0.button_35.Size = new Size(104, 24);
      form1_0.button_35.TabIndex = 258;
      form1_0.button_35.Text = "Ekle";
      form1_0.button_35.UseVisualStyleBackColor = false;
      form1_0.button_35.Click += new EventHandler(form1_0.method_111);
      form1_0.textBox_102.Location = new Point(248, 94);
      form1_0.textBox_102.Name = "textBox10";
      form1_0.textBox_102.Size = new Size(45, 21);
      form1_0.textBox_102.TabIndex = 257;
      form1_0.textBox_102.Visible = false;
      form1_0.listBox_22.BackColor = Color.Gray;
      form1_0.listBox_22.ForeColor = SystemColors.Window;
      form1_0.listBox_22.FormattingEnabled = true;
      form1_0.listBox_22.Location = new Point(73, 94);
      form1_0.listBox_22.Name = "MP_listbox";
      form1_0.listBox_22.Size = new Size(220, 303);
      form1_0.listBox_22.TabIndex = 256;
      form1_0.dateTimePicker_9.Format = DateTimePickerFormat.Time;
      form1_0.dateTimePicker_9.ImeMode = ImeMode.NoControl;
      form1_0.dateTimePicker_9.Location = new Point(189, 67);
      form1_0.dateTimePicker_9.Name = "MP_saat";
      form1_0.dateTimePicker_9.RightToLeft = RightToLeft.Yes;
      form1_0.dateTimePicker_9.ShowUpDown = true;
      form1_0.dateTimePicker_9.Size = new Size(104, 21);
      form1_0.dateTimePicker_9.TabIndex = (int) byte.MaxValue;
      form1_0.label_172.AutoSize = true;
      form1_0.label_172.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.label_172.Location = new Point(218, 44);
      form1_0.label_172.Name = "label41";
      form1_0.label_172.Size = new Size(43, 20);
      form1_0.label_172.TabIndex = 254;
      form1_0.label_172.Text = "Saat";
      form1_0.label_173.AutoSize = true;
      form1_0.label_173.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.label_173.Location = new Point(108, 44);
      form1_0.label_173.Name = "label42";
      form1_0.label_173.Size = new Size(40, 20);
      form1_0.label_173.TabIndex = 253;
      form1_0.label_173.Text = "Gün";
      form1_0.xtraTabPage_5.Appearance.PageClient.BackColor = Color.Tomato;
      form1_0.xtraTabPage_5.Appearance.PageClient.Options.UseBackColor = true;
      form1_0.xtraTabPage_5.Controls.Add((Control) form1_0.listBox_21);
      form1_0.xtraTabPage_5.Controls.Add((Control) form1_0.button_33);
      form1_0.xtraTabPage_5.Controls.Add((Control) form1_0.comboBoxEdit_11);
      form1_0.xtraTabPage_5.Controls.Add((Control) form1_0.groupBox_44);
      form1_0.xtraTabPage_5.Controls.Add((Control) form1_0.checkBox_23);
      form1_0.xtraTabPage_5.Controls.Add((Control) form1_0.checkBox_24);
      form1_0.xtraTabPage_5.Controls.Add((Control) form1_0.listBox_15);
      form1_0.xtraTabPage_5.Controls.Add((Control) form1_0.button_13);
      form1_0.xtraTabPage_5.Controls.Add((Control) form1_0.button_14);
      form1_0.xtraTabPage_5.Controls.Add((Control) form1_0.textBox_37);
      form1_0.xtraTabPage_5.Controls.Add((Control) form1_0.listBox_6);
      form1_0.xtraTabPage_5.Controls.Add((Control) form1_0.dateTimePicker_4);
      form1_0.xtraTabPage_5.Controls.Add((Control) form1_0.label_72);
      form1_0.xtraTabPage_5.Controls.Add((Control) form1_0.label_73);
      form1_0.xtraTabPage_5.Controls.Add((Control) form1_0.groupBox_26);
      form1_0.xtraTabPage_5.Image = (Image) componentResourceManager.GetObject("OYLAMA.Image");
      form1_0.xtraTabPage_5.Name = "OYLAMA";
      form1_0.xtraTabPage_5.Size = new Size(817, 753);
      form1_0.xtraTabPage_5.Text = "Oylama";
      form1_0.xtraTabPage_5.Paint += new PaintEventHandler(form1_0.method_87);
      form1_0.listBox_21.FormattingEnabled = true;
      form1_0.listBox_21.Items.AddRange(new object[9]
      {
        (object) "uniqkes",
        (object) "uniqbul",
        (object) "gmbul",
        (object) "alchemy",
        (object) "soru-cevap",
        (object) "party",
        (object) "sayı",
        (object) "hayatta",
        (object) "oylama"
      });
      form1_0.listBox_21.Location = new Point(134, 19);
      form1_0.listBox_21.Name = "listBox1";
      form1_0.listBox_21.Size = new Size(135, 17);
      form1_0.listBox_21.TabIndex = 248;
      form1_0.listBox_21.Visible = false;
      form1_0.button_33.Location = new Point(170, 42);
      form1_0.button_33.Name = "button30";
      form1_0.button_33.Size = new Size(61, 22);
      form1_0.button_33.TabIndex = 247;
      form1_0.button_33.Text = "button30";
      form1_0.button_33.UseVisualStyleBackColor = true;
      form1_0.button_33.Visible = false;
      form1_0.button_33.Click += new EventHandler(form1_0.method_105);
      form1_0.comboBoxEdit_11.EditValue = (object) "Gün Seçin";
      form1_0.comboBoxEdit_11.Location = new Point(104, 100);
      form1_0.comboBoxEdit_11.Name = "Oylama_EventZamanı";
      form1_0.comboBoxEdit_11.Properties.Appearance.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.comboBoxEdit_11.Properties.Appearance.ForeColor = Color.Salmon;
      form1_0.comboBoxEdit_11.Properties.Appearance.Options.UseBackColor = true;
      form1_0.comboBoxEdit_11.Properties.Appearance.Options.UseForeColor = true;
      form1_0.comboBoxEdit_11.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      form1_0.comboBoxEdit_11.Properties.Items.AddRange(new object[7]
      {
        (object) "Pazartesi",
        (object) "Salı",
        (object) "Çarşamba",
        (object) "Perşembe",
        (object) "Cuma",
        (object) "Cumartesi",
        (object) "Pazar"
      });
      form1_0.comboBoxEdit_11.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
      form1_0.comboBoxEdit_11.Size = new Size(106, 20);
      form1_0.comboBoxEdit_11.TabIndex = 241;
      form1_0.groupBox_44.BackColor = Color.Transparent;
      form1_0.groupBox_44.Controls.Add((Control) form1_0.panel_0);
      form1_0.groupBox_44.ForeColor = SystemColors.Window;
      form1_0.groupBox_44.Location = new Point(12, 91);
      form1_0.groupBox_44.Name = "groupBox47";
      form1_0.groupBox_44.Size = new Size(83, 246);
      form1_0.groupBox_44.TabIndex = 78;
      form1_0.groupBox_44.TabStop = false;
      form1_0.groupBox_44.Text = "-------PH BOT KERVAN ENGELLEME";
      form1_0.groupBox_44.Visible = false;
      form1_0.panel_0.BackColor = Color.Transparent;
      form1_0.panel_0.Controls.Add((Control) form1_0.textBox_100);
      form1_0.panel_0.Controls.Add((Control) form1_0.label_147);
      form1_0.panel_0.Controls.Add((Control) form1_0.label_146);
      form1_0.panel_0.Controls.Add((Control) form1_0.label_145);
      form1_0.panel_0.Controls.Add((Control) form1_0.textBox_88);
      form1_0.panel_0.Controls.Add((Control) form1_0.listBox_17);
      form1_0.panel_0.Controls.Add((Control) form1_0.label_141);
      form1_0.panel_0.Controls.Add((Control) form1_0.label_140);
      form1_0.panel_0.Controls.Add((Control) form1_0.textBox_85);
      form1_0.panel_0.Controls.Add((Control) form1_0.button_24);
      form1_0.panel_0.Controls.Add((Control) form1_0.label_142);
      form1_0.panel_0.Controls.Add((Control) form1_0.button_25);
      form1_0.panel_0.Controls.Add((Control) form1_0.label_143);
      form1_0.panel_0.Location = new Point(7, 20);
      form1_0.panel_0.Name = "panel1";
      form1_0.panel_0.Size = new Size(212, 425);
      form1_0.panel_0.TabIndex = 79;
      form1_0.panel_0.MouseEnter += new EventHandler(form1_0.method_75);
      form1_0.textBox_100.Location = new Point(17, 142);
      form1_0.textBox_100.Name = "mhmt_yldz";
      form1_0.textBox_100.Size = new Size(179, 21);
      form1_0.textBox_100.TabIndex = 264;
      form1_0.textBox_100.Text = "127.0.0.1";
      form1_0.textBox_100.Visible = false;
      form1_0.label_147.AutoSize = true;
      form1_0.label_147.ForeColor = Color.Tan;
      form1_0.label_147.Location = new Point(-1, 166);
      form1_0.label_147.Name = "label173";
      form1_0.label_147.Size = new Size(215, 39);
      form1_0.label_147.TabIndex = 271;
      form1_0.label_147.Text = " ( Sorulacak soru sistem tarafından rastgele\r\nüretilmiş 4 haneli bir rakamdır ve 60 dk da\r\n bir otomatik degişir.)";
      form1_0.label_146.AutoSize = true;
      form1_0.label_146.ForeColor = SystemColors.Window;
      form1_0.label_146.Location = new Point(30, 117);
      form1_0.label_146.Name = "label171";
      form1_0.label_146.Size = new Size(132, 13);
      form1_0.label_146.TabIndex = 270;
      form1_0.label_146.Text = "BAĞLANTI BEKLENİYOR...";
      form1_0.label_145.AutoSize = true;
      form1_0.label_145.ForeColor = SystemColors.Window;
      form1_0.label_145.Location = new Point(150, 54);
      form1_0.label_145.Name = "label137";
      form1_0.label_145.Size = new Size(56, 13);
      form1_0.label_145.TabIndex = 269;
      form1_0.label_145.Text = " ( Saniye )";
      form1_0.textBox_88.BackColor = Color.Salmon;
      form1_0.textBox_88.ForeColor = SystemColors.Window;
      form1_0.textBox_88.Location = new Point(41, -3);
      form1_0.textBox_88.Multiline = true;
      form1_0.textBox_88.Name = "Extra_AntiphbotSoru";
      form1_0.textBox_88.Size = new Size(92, 21);
      form1_0.textBox_88.TabIndex = 268;
      form1_0.textBox_88.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_88.Visible = false;
      form1_0.listBox_17.FormattingEnabled = true;
      form1_0.listBox_17.Location = new Point(144, -5);
      form1_0.listBox_17.Name = "listBox_antiph";
      form1_0.listBox_17.Size = new Size(62, 30);
      form1_0.listBox_17.TabIndex = 80;
      form1_0.listBox_17.Visible = false;
      form1_0.label_141.AutoSize = true;
      form1_0.label_141.ForeColor = Color.Salmon;
      form1_0.label_141.Location = new Point(117, 374);
      form1_0.label_141.Name = "antiphbot_drm";
      form1_0.label_141.Size = new Size(36, 13);
      form1_0.label_141.TabIndex = 252;
      form1_0.label_141.Text = "PASİF";
      form1_0.label_140.AutoSize = true;
      form1_0.label_140.ForeColor = SystemColors.Window;
      form1_0.label_140.Location = new Point(1, 35);
      form1_0.label_140.Name = "label200";
      form1_0.label_140.Size = new Size(146, 13);
      form1_0.label_140.TabIndex = 211;
      form1_0.label_140.Text = "cevap için bekleme süresi =>";
      form1_0.textBox_85.BackColor = Color.Salmon;
      form1_0.textBox_85.ForeColor = SystemColors.Window;
      form1_0.textBox_85.Location = new Point(153, 31);
      form1_0.textBox_85.Multiline = true;
      form1_0.textBox_85.Name = "Extra_textBox_beklemesüresi";
      form1_0.textBox_85.Size = new Size(54, 21);
      form1_0.textBox_85.TabIndex = 213;
      form1_0.textBox_85.Text = "15";
      form1_0.textBox_85.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_85.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.button_24.BackColor = Color.Honeydew;
      form1_0.button_24.Enabled = false;
      form1_0.button_24.FlatStyle = FlatStyle.Flat;
      form1_0.button_24.ForeColor = Color.Black;
      form1_0.button_24.Location = new Point(41, 87);
      form1_0.button_24.Name = "button7";
      form1_0.button_24.Size = new Size(106, 26);
      form1_0.button_24.TabIndex = 242;
      form1_0.button_24.Text = "BAŞLAT";
      form1_0.button_24.UseVisualStyleBackColor = false;
      form1_0.button_24.Click += new EventHandler(form1_0.method_73);
      form1_0.label_142.AutoSize = true;
      form1_0.label_142.ForeColor = SystemColors.Window;
      form1_0.label_142.Location = new Point(44, 374);
      form1_0.label_142.Name = "label166";
      form1_0.label_142.Size = new Size(60, 13);
      form1_0.label_142.TabIndex = 251;
      form1_0.label_142.Text = "DURUM  = ";
      form1_0.button_25.BackColor = Color.Honeydew;
      form1_0.button_25.Enabled = false;
      form1_0.button_25.FlatStyle = FlatStyle.Flat;
      form1_0.button_25.ForeColor = Color.Black;
      form1_0.button_25.Location = new Point(41, 87);
      form1_0.button_25.Name = "button14";
      form1_0.button_25.Size = new Size(106, 26);
      form1_0.button_25.TabIndex = 250;
      form1_0.button_25.Text = "DURDUR";
      form1_0.button_25.UseVisualStyleBackColor = false;
      form1_0.button_25.Click += new EventHandler(form1_0.method_76);
      form1_0.label_143.AutoSize = true;
      form1_0.label_143.ForeColor = SystemColors.Window;
      form1_0.label_143.Location = new Point(1, 231);
      form1_0.label_143.Name = "label153";
      form1_0.label_143.Size = new Size(216, 130);
      form1_0.label_143.TabIndex = 249;
      form1_0.label_143.Text = componentResourceManager.GetString("label153.Text");
      form1_0.checkBox_23.AutoSize = true;
      form1_0.checkBox_23.Location = new Point(12, 44);
      form1_0.checkBox_23.Name = "oylama_basladımı";
      form1_0.checkBox_23.Size = new Size(108, 17);
      form1_0.checkBox_23.TabIndex = 246;
      form1_0.checkBox_23.Text = "Oylama basladımı";
      form1_0.checkBox_23.UseVisualStyleBackColor = true;
      form1_0.checkBox_23.Visible = false;
      form1_0.checkBox_24.AutoSize = true;
      form1_0.checkBox_24.Location = new Point(13, 15);
      form1_0.checkBox_24.Name = "oylama_etkinlik_basladımı";
      form1_0.checkBox_24.Size = new Size(107, 17);
      form1_0.checkBox_24.TabIndex = 246;
      form1_0.checkBox_24.Text = "etkinlik_Basladımı";
      form1_0.checkBox_24.UseVisualStyleBackColor = true;
      form1_0.checkBox_24.Visible = false;
      form1_0.listBox_15.FormattingEnabled = true;
      form1_0.listBox_15.Location = new Point(723, 44);
      form1_0.listBox_15.Name = "listBox9";
      form1_0.listBox_15.Size = new Size(78, 381);
      form1_0.listBox_15.TabIndex = 86;
      form1_0.listBox_15.Visible = false;
      form1_0.button_13.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.button_13.BackgroundImageLayout = ImageLayout.Stretch;
      form1_0.button_13.DialogResult = DialogResult.Cancel;
      form1_0.button_13.FlatStyle = FlatStyle.Flat;
      form1_0.button_13.ForeColor = SystemColors.Window;
      form1_0.button_13.Location = new Point(220, 360);
      form1_0.button_13.Name = "button28";
      form1_0.button_13.Size = new Size(104, 24);
      form1_0.button_13.TabIndex = 85;
      form1_0.button_13.Text = "Sil";
      form1_0.button_13.UseVisualStyleBackColor = false;
      form1_0.button_13.Click += new EventHandler(form1_0.method_56);
      form1_0.button_14.BackColor = Color.FromArgb(80, 80, 80);
      form1_0.button_14.BackgroundImageLayout = ImageLayout.Stretch;
      form1_0.button_14.FlatStyle = FlatStyle.Flat;
      form1_0.button_14.ForeColor = SystemColors.Window;
      form1_0.button_14.Location = new Point(104, 360);
      form1_0.button_14.Name = "button29";
      form1_0.button_14.Size = new Size(104, 24);
      form1_0.button_14.TabIndex = 84;
      form1_0.button_14.Text = "Ekle";
      form1_0.button_14.UseVisualStyleBackColor = false;
      form1_0.button_14.Click += new EventHandler(form1_0.method_61);
      form1_0.textBox_37.Location = new Point(278, 126);
      form1_0.textBox_37.Name = "textBox82";
      form1_0.textBox_37.Size = new Size(45, 21);
      form1_0.textBox_37.TabIndex = 83;
      form1_0.textBox_37.Visible = false;
      form1_0.listBox_6.BackColor = Color.Gray;
      form1_0.listBox_6.ForeColor = SystemColors.Window;
      form1_0.listBox_6.FormattingEnabled = true;
      form1_0.listBox_6.Location = new Point(103, (int) sbyte.MaxValue);
      form1_0.listBox_6.Name = "Oylama_listBox";
      form1_0.listBox_6.Size = new Size(220, 225);
      form1_0.listBox_6.TabIndex = 82;
      form1_0.dateTimePicker_4.Format = DateTimePickerFormat.Time;
      form1_0.dateTimePicker_4.ImeMode = ImeMode.NoControl;
      form1_0.dateTimePicker_4.Location = new Point(219, 100);
      form1_0.dateTimePicker_4.Name = "Oylama_Saat";
      form1_0.dateTimePicker_4.RightToLeft = RightToLeft.Yes;
      form1_0.dateTimePicker_4.ShowUpDown = true;
      form1_0.dateTimePicker_4.Size = new Size(104, 21);
      form1_0.dateTimePicker_4.TabIndex = 81;
      form1_0.label_72.AutoSize = true;
      form1_0.label_72.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.label_72.Location = new Point(248, 77);
      form1_0.label_72.Name = "label157";
      form1_0.label_72.Size = new Size(43, 20);
      form1_0.label_72.TabIndex = 79;
      form1_0.label_72.Text = "Saat";
      form1_0.label_73.AutoSize = true;
      form1_0.label_73.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.label_73.Location = new Point(138, 77);
      form1_0.label_73.Name = "label158";
      form1_0.label_73.Size = new Size(40, 20);
      form1_0.label_73.TabIndex = 78;
      form1_0.label_73.Text = "Gün";
      form1_0.groupBox_26.BackColor = Color.Transparent;
      form1_0.groupBox_26.Controls.Add((Control) form1_0.label_116);
      form1_0.groupBox_26.Controls.Add((Control) form1_0.comboBox_1);
      form1_0.groupBox_26.Controls.Add((Control) form1_0.label_117);
      form1_0.groupBox_26.Controls.Add((Control) form1_0.label_74);
      form1_0.groupBox_26.Controls.Add((Control) form1_0.label_75);
      form1_0.groupBox_26.Controls.Add((Control) form1_0.label_76);
      form1_0.groupBox_26.Controls.Add((Control) form1_0.groupBox_27);
      form1_0.groupBox_26.Controls.Add((Control) form1_0.textBox_38);
      form1_0.groupBox_26.Controls.Add((Control) form1_0.label_77);
      form1_0.groupBox_26.Controls.Add((Control) form1_0.label_78);
      form1_0.groupBox_26.Controls.Add((Control) form1_0.textBox_39);
      form1_0.groupBox_26.ForeColor = SystemColors.Window;
      form1_0.groupBox_26.Location = new Point(344, 37);
      form1_0.groupBox_26.Name = "groupBox39";
      form1_0.groupBox_26.Size = new Size(373, 390);
      form1_0.groupBox_26.TabIndex = 77;
      form1_0.groupBox_26.TabStop = false;
      form1_0.groupBox_26.Text = "ETKİNLİK AYARLARI";
      form1_0.label_116.AutoSize = true;
      form1_0.label_116.Location = new Point(156, 364);
      form1_0.label_116.Name = "label188";
      form1_0.label_116.Size = new Size(13, 13);
      form1_0.label_116.TabIndex = 240;
      form1_0.label_116.Text = "0";
      form1_0.label_116.Visible = false;
      form1_0.comboBox_1.BackColor = Color.Salmon;
      form1_0.comboBox_1.DisplayMember = "1";
      form1_0.comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
      form1_0.comboBox_1.FlatStyle = FlatStyle.Popup;
      form1_0.comboBox_1.ForeColor = SystemColors.ActiveCaptionText;
      form1_0.comboBox_1.FormattingEnabled = true;
      form1_0.comboBox_1.Items.AddRange(new object[10]
      {
        (object) "Etkinlik yapma",
        (object) "Unique Kes",
        (object) "Kayıp Unique",
        (object) "Kayıp GM",
        (object) "Alchemy",
        (object) "Soru-Cevap",
        (object) "Party Form",
        (object) "Sayı Tahmin",
        (object) "Hayatta Kal",
        (object) "Piyango"
      });
      form1_0.comboBox_1.Location = new Point(254, 343);
      form1_0.comboBox_1.Name = "comboBox13";
      form1_0.comboBox_1.Size = new Size(105, 21);
      form1_0.comboBox_1.TabIndex = 235;
      form1_0.label_117.AutoSize = true;
      form1_0.label_117.Location = new Point(18, 364);
      form1_0.label_117.Name = "label189";
      form1_0.label_117.Size = new Size(125, 13);
      form1_0.label_117.TabIndex = 239;
      form1_0.label_117.Text = "Ortalama Etkinlik Süresi :";
      form1_0.label_117.Visible = false;
      form1_0.label_74.AutoSize = true;
      form1_0.label_74.ForeColor = SystemColors.Window;
      form1_0.label_74.Location = new Point(10, 346);
      form1_0.label_74.Name = "label162";
      form1_0.label_74.Size = new Size(245, 13);
      form1_0.label_74.TabIndex = 234;
      form1_0.label_74.Text = "Yeterli katılım sağlanmadığında bu işlemi yap ==> ";
      form1_0.label_75.AutoSize = true;
      form1_0.label_75.ForeColor = Color.PaleGoldenrod;
      form1_0.label_75.Location = new Point(261, 233);
      form1_0.label_75.Name = "label169";
      form1_0.label_75.Size = new Size(47, 13);
      form1_0.label_75.TabIndex = 233;
      form1_0.label_75.Text = "(Saniye)";
      form1_0.label_76.AutoSize = true;
      form1_0.label_76.ForeColor = Color.Salmon;
      form1_0.label_76.Location = new Point(68, 28);
      form1_0.label_76.Name = "label170";
      form1_0.label_76.Size = new Size(226, 13);
      form1_0.label_76.TabIndex = 231;
      form1_0.label_76.Text = "OYLAMAYA DAHİL OLACAK EVENTLERİ SEÇİN";
      form1_0.groupBox_27.BackColor = Color.Transparent;
      form1_0.groupBox_27.Controls.Add((Control) form1_0.checkEdit_11);
      form1_0.groupBox_27.Controls.Add((Control) form1_0.checkEdit_1);
      form1_0.groupBox_27.Controls.Add((Control) form1_0.checkEdit_2);
      form1_0.groupBox_27.Controls.Add((Control) form1_0.checkEdit_3);
      form1_0.groupBox_27.Controls.Add((Control) form1_0.checkEdit_4);
      form1_0.groupBox_27.Controls.Add((Control) form1_0.checkEdit_5);
      form1_0.groupBox_27.Controls.Add((Control) form1_0.checkEdit_6);
      form1_0.groupBox_27.Controls.Add((Control) form1_0.checkEdit_7);
      form1_0.groupBox_27.Controls.Add((Control) form1_0.checkEdit_8);
      form1_0.groupBox_27.ForeColor = SystemColors.Menu;
      form1_0.groupBox_27.Location = new Point(60, 40);
      form1_0.groupBox_27.Name = "groupBox40";
      form1_0.groupBox_27.Size = new Size(272, 177);
      form1_0.groupBox_27.TabIndex = 230;
      form1_0.groupBox_27.TabStop = false;
      form1_0.checkEdit_11.Location = new Point(154, 115);
      form1_0.checkEdit_11.Name = "Oylama_check_9_Piyango";
      form1_0.checkEdit_11.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.checkEdit_11.Properties.Appearance.Options.UseFont = true;
      form1_0.checkEdit_11.Properties.Caption = "Piyango = 9";
      form1_0.checkEdit_11.Properties.CheckStyle = CheckStyles.Radio;
      form1_0.checkEdit_11.Properties.GlyphAlignment = HorzAlignment.Default;
      form1_0.checkEdit_11.Size = new Size(112, 20);
      form1_0.checkEdit_11.TabIndex = 254;
      form1_0.checkEdit_1.Location = new Point(154, 81);
      form1_0.checkEdit_1.Name = "Oylama_check_8_HayattaKal";
      form1_0.checkEdit_1.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.checkEdit_1.Properties.Appearance.Options.UseFont = true;
      form1_0.checkEdit_1.Properties.Caption = "Hayatta Kal = 8";
      form1_0.checkEdit_1.Properties.CheckStyle = CheckStyles.Radio;
      form1_0.checkEdit_1.Properties.GlyphAlignment = HorzAlignment.Default;
      form1_0.checkEdit_1.Size = new Size(112, 20);
      form1_0.checkEdit_1.TabIndex = 252;
      form1_0.checkEdit_2.Location = new Point(11, 144);
      form1_0.checkEdit_2.Name = "Oylama_check_5_sorucevap";
      form1_0.checkEdit_2.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.checkEdit_2.Properties.Appearance.Options.UseFont = true;
      form1_0.checkEdit_2.Properties.Caption = "Soru-Cevap = 5";
      form1_0.checkEdit_2.Properties.CheckStyle = CheckStyles.Radio;
      form1_0.checkEdit_2.Properties.GlyphAlignment = HorzAlignment.Default;
      form1_0.checkEdit_2.Size = new Size(124, 20);
      form1_0.checkEdit_2.TabIndex = 250;
      form1_0.checkEdit_3.Location = new Point(154, 54);
      form1_0.checkEdit_3.Name = "Oylama_check_7_SayıBul";
      form1_0.checkEdit_3.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.checkEdit_3.Properties.Appearance.Options.UseFont = true;
      form1_0.checkEdit_3.Properties.Caption = "Sayı Bul = 7";
      form1_0.checkEdit_3.Properties.CheckStyle = CheckStyles.Radio;
      form1_0.checkEdit_3.Properties.GlyphAlignment = HorzAlignment.Default;
      form1_0.checkEdit_3.Size = new Size(112, 20);
      form1_0.checkEdit_3.TabIndex = 253;
      form1_0.checkEdit_4.Location = new Point(154, 25);
      form1_0.checkEdit_4.Name = "Oylama_check_6_PartyForm";
      form1_0.checkEdit_4.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.checkEdit_4.Properties.Appearance.Options.UseFont = true;
      form1_0.checkEdit_4.Properties.Caption = "Party Form = 6";
      form1_0.checkEdit_4.Properties.CheckStyle = CheckStyles.Radio;
      form1_0.checkEdit_4.Properties.GlyphAlignment = HorzAlignment.Default;
      form1_0.checkEdit_4.Size = new Size(112, 20);
      form1_0.checkEdit_4.TabIndex = 251;
      form1_0.checkEdit_5.Location = new Point(11, 110);
      form1_0.checkEdit_5.Name = "Oylama_check_4_alchemy";
      form1_0.checkEdit_5.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.checkEdit_5.Properties.Appearance.Options.UseFont = true;
      form1_0.checkEdit_5.Properties.Caption = "Alchemy = 4";
      form1_0.checkEdit_5.Properties.CheckStyle = CheckStyles.Radio;
      form1_0.checkEdit_5.Properties.GlyphAlignment = HorzAlignment.Default;
      form1_0.checkEdit_5.Size = new Size(112, 20);
      form1_0.checkEdit_5.TabIndex = 249;
      form1_0.checkEdit_6.Location = new Point(11, 25);
      form1_0.checkEdit_6.Name = "Oylama_check_1_Unq_Kes";
      form1_0.checkEdit_6.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.checkEdit_6.Properties.Appearance.Options.UseFont = true;
      form1_0.checkEdit_6.Properties.Caption = "Unique Kes = 1";
      form1_0.checkEdit_6.Properties.CheckStyle = CheckStyles.Radio;
      form1_0.checkEdit_6.Properties.GlyphAlignment = HorzAlignment.Default;
      form1_0.checkEdit_6.Size = new Size(112, 20);
      form1_0.checkEdit_6.TabIndex = 247;
      form1_0.checkEdit_7.Location = new Point(11, 82);
      form1_0.checkEdit_7.Name = "Oylama_check_3_GMBul";
      form1_0.checkEdit_7.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.checkEdit_7.Properties.Appearance.Options.UseFont = true;
      form1_0.checkEdit_7.Properties.Caption = "Kayıp GM = 3";
      form1_0.checkEdit_7.Properties.CheckStyle = CheckStyles.Radio;
      form1_0.checkEdit_7.Properties.GlyphAlignment = HorzAlignment.Default;
      form1_0.checkEdit_7.Size = new Size(112, 20);
      form1_0.checkEdit_7.TabIndex = 249;
      form1_0.checkEdit_8.Location = new Point(11, 53);
      form1_0.checkEdit_8.Name = "Oylama_check_2_Unq_Bul";
      form1_0.checkEdit_8.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      form1_0.checkEdit_8.Properties.Appearance.Options.UseFont = true;
      form1_0.checkEdit_8.Properties.Caption = "Kayıp Uniq = 2";
      form1_0.checkEdit_8.Properties.CheckStyle = CheckStyles.Radio;
      form1_0.checkEdit_8.Properties.GlyphAlignment = HorzAlignment.Default;
      form1_0.checkEdit_8.Size = new Size(112, 20);
      form1_0.checkEdit_8.TabIndex = 248;
      form1_0.textBox_38.BackColor = Color.Salmon;
      form1_0.textBox_38.ForeColor = SystemColors.Window;
      form1_0.textBox_38.Location = new Point(201, 230);
      form1_0.textBox_38.Multiline = true;
      form1_0.textBox_38.Name = "oylamasüresi";
      form1_0.textBox_38.Size = new Size(54, 21);
      form1_0.textBox_38.TabIndex = 213;
      form1_0.textBox_38.Text = "60";
      form1_0.textBox_38.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_38.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.label_77.AutoSize = true;
      form1_0.label_77.ForeColor = SystemColors.Window;
      form1_0.label_77.Location = new Point(27, 234);
      form1_0.label_77.Name = "label165";
      form1_0.label_77.Size = new Size(168, 13);
      form1_0.label_77.TabIndex = 211;
      form1_0.label_77.Text = "Oylama için beklenecek süre ==>";
      form1_0.label_78.AutoSize = true;
      form1_0.label_78.ForeColor = SystemColors.Window;
      form1_0.label_78.Location = new Point(27, 284);
      form1_0.label_78.Name = "label168";
      form1_0.label_78.Size = new Size(247, 13);
      form1_0.label_78.TabIndex = 216;
      form1_0.label_78.Text = "Etkinliğin başlaması için gerekli katılımcı sayısı ==> ";
      form1_0.textBox_39.BackColor = Color.Salmon;
      form1_0.textBox_39.ForeColor = SystemColors.Window;
      form1_0.textBox_39.Location = new Point(280, 281);
      form1_0.textBox_39.Multiline = true;
      form1_0.textBox_39.Name = "textBox86";
      form1_0.textBox_39.Size = new Size(54, 20);
      form1_0.textBox_39.TabIndex = 214;
      form1_0.textBox_39.Text = "5";
      form1_0.textBox_39.TextAlign = HorizontalAlignment.Center;
      form1_0.textBox_39.KeyPress += new KeyPressEventHandler(form1_0.method_63);
      form1_0.groupControl_8.AutoSize = true;
      form1_0.groupControl_8.Controls.Add((Control) form1_0.groupControl_3);
      form1_0.groupControl_8.Controls.Add((Control) form1_0.groupControl_2);
      form1_0.groupControl_8.Controls.Add((Control) form1_0.panelControl_1);
      form1_0.groupControl_8.Dock = DockStyle.Left;
      form1_0.groupControl_8.Location = new Point(0, 0);
      form1_0.groupControl_8.Name = "groupControl1";
      form1_0.groupControl_8.Size = new Size(201, 701);
      form1_0.groupControl_8.TabIndex = 135;
      form1_0.groupControl_8.Text = "    Sunucu Bağlantı ve Giriş";
      form1_0.timer_1.Interval = 1000;
      form1_0.timer_1.Tick += new EventHandler(form1_0.method_37);
      form1_0.timer_2.Interval = 1000;
      form1_0.timer_2.Tick += new EventHandler(form1_0.method_66);
      form1_0.timer_4.Interval = 1000;
      form1_0.timer_4.Tick += new EventHandler(form1_0.method_71);
      form1_0.timer_3.Interval = 1000;
      form1_0.timer_3.Tick += new EventHandler(form1_0.method_72);
      form1_0.timer_5.Interval = 3600000;
      form1_0.timer_5.Tick += new EventHandler(form1_0.method_82);
      form1_0.timer_6.Interval = 5000;
      form1_0.timer_6.Tick += new EventHandler(form1_0.method_96);
      form1_0.timer_7.Interval = 2000;
      form1_0.timer_7.Tick += new EventHandler(form1_0.method_97);
      form1_0.defaultLookAndFeel_0.LookAndFeel.SkinName = "Darkroom";
      form1_0.ribbonPage_0.Name = "ribbonPage2";
      form1_0.ribbonPage_0.Text = "ribbonPage2";
      form1_0.timer_8.Interval = 1000;
      form1_0.timer_8.Tick += new EventHandler(form1_0.method_98);
      form1_0.timer_9.Interval = 1800000;
      form1_0.timer_9.Tick += new EventHandler(form1_0.method_99);
      form1_0.timer_10.Interval = 1800000;
      form1_0.timer_10.Tick += new EventHandler(form1_0.method_100);
      form1_0.timer_11.Interval = 60000;
      form1_0.timer_11.Tick += new EventHandler(form1_0.method_103);
      form1_0.timer_12.Interval = 1000;
      form1_0.timer_12.Tick += new EventHandler(form1_0.method_104);
      form1_0.AutoScaleDimensions = new SizeF(6f, 13f);
      form1_0.AutoScaleMode = AutoScaleMode.Font;
      form1_0.AutoScroll = true;
      form1_0.AutoValidate = AutoValidate.EnablePreventFocusChange;
      form1_0.ClientSize = new Size(1016, 701);
      form1_0.Controls.Add((Control) form1_0.groupControl_0);
      form1_0.Controls.Add((Control) form1_0.xtraTabControl_0);
      form1_0.Controls.Add((Control) form1_0.groupControl_8);
      form1_0.FormBorderStyle = FormBorderStyle.FixedSingle;
      form1_0.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      form1_0.MaximumSize = new Size(1057, 740);
      form1_0.Name = "MainForm";
      form1_0.StartPosition = FormStartPosition.CenterScreen;
      form1_0.Text = "My_EventBot_gncl";
      form1_0.Load += new EventHandler(form1_0.method_0);
      form1_0.groupControl_0.EndInit();
      form1_0.groupControl_0.ResumeLayout(false);
      form1_0.groupControl_0.PerformLayout();
      form1_0.panelControl_0.EndInit();
      form1_0.panelControl_0.ResumeLayout(false);
      form1_0.groupControl_9.EndInit();
      form1_0.groupControl_9.ResumeLayout(false);
      form1_0.groupControl_9.PerformLayout();
      form1_0.panelControl_8.EndInit();
      form1_0.panelControl_8.ResumeLayout(false);
      form1_0.groupBox_10.ResumeLayout(false);
      form1_0.groupBox_10.PerformLayout();
      form1_0.groupBox_11.ResumeLayout(false);
      form1_0.groupBox_11.PerformLayout();
      form1_0.groupBox_12.ResumeLayout(false);
      form1_0.groupBox_12.PerformLayout();
      form1_0.groupBox_13.ResumeLayout(false);
      form1_0.groupBox_13.PerformLayout();
      form1_0.groupBox_14.ResumeLayout(false);
      form1_0.groupBox_14.PerformLayout();
      form1_0.panelControl_1.EndInit();
      form1_0.panelControl_1.ResumeLayout(false);
      form1_0.panelControl_1.PerformLayout();
      form1_0.groupControl_1.EndInit();
      form1_0.groupControl_1.ResumeLayout(false);
      form1_0.groupControl_1.PerformLayout();
      form1_0.textEdit_0.Properties.EndInit();
      form1_0.textEdit_1.Properties.EndInit();
      form1_0.textEdit_2.Properties.EndInit();
      form1_0.textEdit_3.Properties.EndInit();
      form1_0.textEdit_4.Properties.EndInit();
      form1_0.textEdit_5.Properties.EndInit();
      form1_0.groupControl_2.EndInit();
      form1_0.groupControl_2.ResumeLayout(false);
      form1_0.groupControl_2.PerformLayout();
      form1_0.textEdit_6.Properties.EndInit();
      form1_0.textEdit_7.Properties.EndInit();
      form1_0.textEdit_8.Properties.EndInit();
      form1_0.groupControl_3.EndInit();
      form1_0.groupControl_3.ResumeLayout(false);
      form1_0.groupControl_4.EndInit();
      form1_0.groupControl_4.ResumeLayout(false);
      form1_0.panelControl_2.EndInit();
      form1_0.panelControl_2.ResumeLayout(false);
      form1_0.panelControl_2.PerformLayout();
      form1_0.textEdit_15.Properties.EndInit();
      form1_0.textEdit_16.Properties.EndInit();
      form1_0.textEdit_18.Properties.EndInit();
      form1_0.panelControl_3.EndInit();
      form1_0.panelControl_3.ResumeLayout(false);
      form1_0.panelControl_3.PerformLayout();
      form1_0.panelControl_7.EndInit();
      form1_0.panelControl_7.ResumeLayout(false);
      form1_0.panelControl_7.PerformLayout();
      form1_0.textEdit_13.Properties.EndInit();
      form1_0.textEdit_14.Properties.EndInit();
      form1_0.textEdit_12.Properties.EndInit();
      form1_0.textEdit_9.Properties.EndInit();
      form1_0.textEdit_11.Properties.EndInit();
      form1_0.textEdit_10.Properties.EndInit();
      form1_0.groupControl_5.EndInit();
      form1_0.groupControl_5.ResumeLayout(false);
      form1_0.panelControl_4.EndInit();
      form1_0.panelControl_4.ResumeLayout(false);
      form1_0.panelControl_4.PerformLayout();
      form1_0.checkEdit_9.Properties.EndInit();
      form1_0.groupControl_6.EndInit();
      form1_0.groupControl_6.ResumeLayout(false);
      form1_0.panelControl_5.EndInit();
      form1_0.panelControl_5.ResumeLayout(false);
      form1_0.panelControl_5.PerformLayout();
      ((ISupportInitialize) form1_0.pictureBox_0).EndInit();
      form1_0.groupControl_7.EndInit();
      form1_0.groupControl_7.ResumeLayout(false);
      form1_0.panelControl_6.EndInit();
      form1_0.panelControl_6.ResumeLayout(false);
      form1_0.panelControl_6.PerformLayout();
      form1_0.textEdit_17.Properties.EndInit();
      form1_0.checkEdit_10.Properties.EndInit();
      form1_0.xtraTabControl_0.EndInit();
      form1_0.xtraTabControl_0.ResumeLayout(false);
      form1_0.xtraTabPage_0.ResumeLayout(false);
      form1_0.xtraTabPage_0.PerformLayout();
      form1_0.comboBoxEdit_3.Properties.EndInit();
      form1_0.groupBox_0.ResumeLayout(false);
      form1_0.groupBox_0.PerformLayout();
      form1_0.panel_2.ResumeLayout(false);
      form1_0.panel_2.PerformLayout();
      ((ISupportInitialize) form1_0.listBoxControl_0).EndInit();
      form1_0.contextMenuStrip_0.ResumeLayout(false);
      ((ISupportInitialize) form1_0.listBoxControl_1).EndInit();
      form1_0.groupBox_1.ResumeLayout(false);
      form1_0.groupBox_1.PerformLayout();
      form1_0.groupBox_2.ResumeLayout(false);
      form1_0.groupBox_2.PerformLayout();
      form1_0.groupBox_3.ResumeLayout(false);
      form1_0.groupBox_3.PerformLayout();
      form1_0.groupBox_4.ResumeLayout(false);
      form1_0.groupBox_4.PerformLayout();
      form1_0.comboBoxEdit_2.Properties.EndInit();
      form1_0.xtraTabPage_1.ResumeLayout(false);
      form1_0.xtraTabPage_1.PerformLayout();
      form1_0.comboBoxEdit_4.Properties.EndInit();
      form1_0.groupBox_5.ResumeLayout(false);
      form1_0.groupBox_5.PerformLayout();
      form1_0.groupBox_6.ResumeLayout(false);
      form1_0.groupBox_6.PerformLayout();
      form1_0.groupBox_7.ResumeLayout(false);
      form1_0.groupBox_7.PerformLayout();
      form1_0.groupBox_8.ResumeLayout(false);
      form1_0.groupBox_8.PerformLayout();
      form1_0.groupBox_9.ResumeLayout(false);
      form1_0.groupBox_9.PerformLayout();
      form1_0.comboBoxEdit_0.Properties.EndInit();
      form1_0.xtraTabPage_2.ResumeLayout(false);
      form1_0.xtraTabPage_2.PerformLayout();
      form1_0.comboBoxEdit_5.Properties.EndInit();
      form1_0.groupBox_15.ResumeLayout(false);
      form1_0.groupBox_15.PerformLayout();
      form1_0.groupBox_33.ResumeLayout(false);
      form1_0.groupBox_33.PerformLayout();
      form1_0.groupBox_34.ResumeLayout(false);
      form1_0.groupBox_34.PerformLayout();
      form1_0.groupBox_35.ResumeLayout(false);
      form1_0.groupBox_35.PerformLayout();
      form1_0.groupBox_16.ResumeLayout(false);
      form1_0.groupBox_16.PerformLayout();
      form1_0.comboBoxEdit_1.Properties.EndInit();
      form1_0.xtraTabPage_3.ResumeLayout(false);
      form1_0.xtraTabPage_3.PerformLayout();
      form1_0.comboBoxEdit_6.Properties.EndInit();
      form1_0.groupBox_17.ResumeLayout(false);
      form1_0.groupBox_36.ResumeLayout(false);
      form1_0.groupBox_36.PerformLayout();
      form1_0.groupBox_37.ResumeLayout(false);
      form1_0.groupBox_37.PerformLayout();
      form1_0.groupBox_38.ResumeLayout(false);
      form1_0.groupBox_38.PerformLayout();
      form1_0.groupBox_18.ResumeLayout(false);
      form1_0.groupBox_18.PerformLayout();
      form1_0.groupBox_19.ResumeLayout(false);
      form1_0.groupBox_19.PerformLayout();
      form1_0.xtraTabPage_4.ResumeLayout(false);
      form1_0.xtraTabPage_4.PerformLayout();
      form1_0.comboBoxEdit_7.Properties.EndInit();
      form1_0.groupBox_20.ResumeLayout(false);
      form1_0.groupBox_20.PerformLayout();
      form1_0.groupBox_21.ResumeLayout(false);
      form1_0.groupBox_21.PerformLayout();
      form1_0.groupBox_22.ResumeLayout(false);
      form1_0.groupBox_22.PerformLayout();
      form1_0.groupBox_23.ResumeLayout(false);
      form1_0.groupBox_23.PerformLayout();
      form1_0.groupBox_24.ResumeLayout(false);
      form1_0.groupBox_24.PerformLayout();
      form1_0.groupBox_25.ResumeLayout(false);
      form1_0.groupBox_25.PerformLayout();
      form1_0.xtraTabPage_6.ResumeLayout(false);
      form1_0.xtraTabPage_6.PerformLayout();
      form1_0.comboBoxEdit_8.Properties.EndInit();
      form1_0.groupBox_45.ResumeLayout(false);
      form1_0.groupBox_45.PerformLayout();
      form1_0.groupBox_29.ResumeLayout(false);
      form1_0.groupBox_29.PerformLayout();
      form1_0.groupBox_28.ResumeLayout(false);
      form1_0.groupBox_28.PerformLayout();
      form1_0.groupBox_30.ResumeLayout(false);
      form1_0.groupBox_30.PerformLayout();
      form1_0.groupBox_31.ResumeLayout(false);
      form1_0.groupBox_31.PerformLayout();
      form1_0.xtraTabPage_7.ResumeLayout(false);
      form1_0.xtraTabPage_7.PerformLayout();
      form1_0.comboBoxEdit_9.Properties.EndInit();
      form1_0.groupBox_39.ResumeLayout(false);
      form1_0.groupBox_39.PerformLayout();
      form1_0.groupBox_40.ResumeLayout(false);
      form1_0.groupBox_40.PerformLayout();
      form1_0.groupBox_41.ResumeLayout(false);
      form1_0.groupBox_41.PerformLayout();
      form1_0.groupBox_42.ResumeLayout(false);
      form1_0.groupBox_42.PerformLayout();
      form1_0.groupBox_32.ResumeLayout(false);
      form1_0.groupBox_32.PerformLayout();
      form1_0.checkEdit_0.Properties.EndInit();
      form1_0.xtraTabPage_8.ResumeLayout(false);
      form1_0.xtraTabPage_8.PerformLayout();
      form1_0.comboBoxEdit_10.Properties.EndInit();
      form1_0.groupBox_43.ResumeLayout(false);
      form1_0.groupBox_43.PerformLayout();
      form1_0.xtraTabPage_9.ResumeLayout(false);
      form1_0.xtraTabPage_9.PerformLayout();
      form1_0.groupBox_46.ResumeLayout(false);
      form1_0.groupBox_46.PerformLayout();
      form1_0.comboBoxEdit_13.Properties.EndInit();
      form1_0.comboBoxEdit_12.Properties.EndInit();
      form1_0.xtraTabPage_5.ResumeLayout(false);
      form1_0.xtraTabPage_5.PerformLayout();
      form1_0.comboBoxEdit_11.Properties.EndInit();
      form1_0.groupBox_44.ResumeLayout(false);
      form1_0.panel_0.ResumeLayout(false);
      form1_0.panel_0.PerformLayout();
      form1_0.groupBox_26.ResumeLayout(false);
      form1_0.groupBox_26.PerformLayout();
      form1_0.groupBox_27.ResumeLayout(false);
      form1_0.checkEdit_11.Properties.EndInit();
      form1_0.checkEdit_1.Properties.EndInit();
      form1_0.checkEdit_2.Properties.EndInit();
      form1_0.checkEdit_3.Properties.EndInit();
      form1_0.checkEdit_4.Properties.EndInit();
      form1_0.checkEdit_5.Properties.EndInit();
      form1_0.checkEdit_6.Properties.EndInit();
      form1_0.checkEdit_7.Properties.EndInit();
      form1_0.checkEdit_8.Properties.EndInit();
      form1_0.groupControl_8.EndInit();
      form1_0.groupControl_8.ResumeLayout(false);
      ((ISupportInitialize) form1_0.behaviorManager_0).EndInit();
      form1_0.ResumeLayout(false);
      form1_0.PerformLayout();
    }

    static void smethod_41(byte[] byte_0, Class0 class0_0)
    {
      Class73.smethod_36(byte_0, class0_0, byte_0.Length, 0);
    }

    static void smethod_42(Class1 class1_0, byte[] byte_0)
    {
      if (class1_0.bool_2)
        throw new Exception("Cannot Write to a locked Packet.");
      class1_0.class3_0.Write(byte_0);
    }

    static unsafe void smethod_43(Class9 class9_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      *(sbyte*) voidPtr = (sbyte) (class9_0.int_42 > 8);
      if (*(sbyte*) voidPtr != (sbyte) 0)
      {
        Class73.smethod_195((int) class9_0.short_6, class9_0);
      }
      else
      {
        *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (class9_0.int_42 > 0);
        if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
          Class73.smethod_102(class9_0, (byte) class9_0.short_6);
      }
      class9_0.short_6 = (short) 0;
      class9_0.int_42 = 0;
    }

    static unsafe void smethod_44(Class1 class1_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      object object0 = class1_0.object_0;
      *(sbyte*) voidPtr = (sbyte) 0;
      try
      {
        Monitor.Enter(object0, ref *(bool*) voidPtr);
        *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) !class1_0.bool_2;
        if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
          return;
        class1_0.byte_0 = Class73.smethod_230(class1_0.class3_0);
        class1_0.class2_0 = new Class2(class1_0.byte_0);
        class1_0.class3_0.Close();
        class1_0.class3_0 = (Class3) null;
        class1_0.bool_2 = true;
      }
      finally
      {
        if (*(sbyte*) voidPtr != (sbyte) 0)
          Monitor.Exit(object0);
      }
    }

    static void smethod_45(int int_0, ref uint uint_0, Class0 class0_0, uint uint_1)
    {
      uint_0 ^= Class73.smethod_95(uint_1, class0_0) ^ class0_0.uint_2[int_0];
    }

    static void smethod_46(Form1 form1_0)
    {
      Form1.int_0 = new Random().Next(100, 999);
      form1_0.textBox_88.Text = string.Concat((object) Form1.int_0);
    }

    static unsafe byte[] smethod_47(byte[] byte_0, int int_0, int int_1, Class0 class0_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(13);
      byte[] numArray1;
      if ((int_0 % 8 != 0 ? 1 : (int_0 == 0 ? 1 : 0)) != 0)
      {
        numArray1 = (byte[]) null;
      }
      else
      {
        byte[] numArray2 = new byte[int_0];
        Buffer.BlockCopy((Array) byte_0, int_1, (Array) numArray2, 0, int_0);
        *(int*) voidPtr = 0;
        while (true)
        {
          *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) (*(int*) voidPtr < numArray2.Length);
          if (*(sbyte*) ((IntPtr) voidPtr + 12) != (sbyte) 0)
          {
            *(int*) ((IntPtr) voidPtr + 4) = (int) BitConverter.ToUInt32(numArray2, *(int*) voidPtr);
            *(int*) ((IntPtr) voidPtr + 8) = (int) BitConverter.ToUInt32(numArray2, *(int*) voidPtr + 4);
            // ISSUE: cast to a reference type
            // ISSUE: cast to a reference type
            Class73.smethod_86((uint&) ((IntPtr) voidPtr + 4), (uint&) ((IntPtr) voidPtr + 8), class0_0);
            Buffer.BlockCopy((Array) BitConverter.GetBytes(*(uint*) ((IntPtr) voidPtr + 4)), 0, (Array) numArray2, *(int*) voidPtr, 4);
            Buffer.BlockCopy((Array) BitConverter.GetBytes(*(uint*) ((IntPtr) voidPtr + 8)), 0, (Array) numArray2, *(int*) voidPtr + 4, 4);
            *(int*) voidPtr = *(int*) voidPtr + 8;
          }
          else
            break;
        }
        numArray1 = numArray2;
      }
      return numArray1;
    }

    static string smethod_48(string string_0)
    {
      return Class73.smethod_79(BitConverter.ToString(new SHA512Managed().ComputeHash(Class73.smethod_50(string_0))));
    }

    static void smethod_49(Form1 form1_0)
    {
      form1_0.xtraTabPage_0.Text = "Unique Kill";
      form1_0.xtraTabPage_1.Text = "Lost Unique";
      form1_0.xtraTabPage_2.Text = "Hide and Seek";
      form1_0.xtraTabPage_3.Text = "Alchemy";
      form1_0.xtraTabPage_4.Text = "Question-Answer";
      form1_0.xtraTabPage_6.Text = "Party Form";
      form1_0.xtraTabPage_7.Text = "Number Guess";
      form1_0.xtraTabPage_8.Text = "LMS";
      form1_0.xtraTabPage_9.Text = "Lottery";
      form1_0.xtraTabPage_5.Text = "Voting";
      form1_0.groupControl_7.Text = "     CONNECT SERVER";
      form1_0.groupControl_4.Text = "   CHARACTER LOGİN";
      form1_0.label_158.Text = "CHARACTER";
      form1_0.groupControl_6.Text = "   L I C E N C E";
      form1_0.label_14.Text = "Days : ";
      form1_0.button_2.Text = "Save Config";
      form1_0.button_19.Text = "Login";
      form1_0.button_23.Text = "G U I D E";
      form1_0.textBox_86.Text = "T İ M E";
      form1_0.groupBox_4.Text = "GENERAL SETTINGS";
      form1_0.label_32.Text = "Event Area";
      form1_0.comboBoxEdit_2.Text = "Select Event Area";
      form1_0.label_31.Text = "Day";
      form1_0.label_30.Text = "Time";
      form1_0.comboBoxEdit_3.Text = "Select Day";
      form1_0.button_4.Text = "Add";
      form1_0.button_3.Text = "Delete";
      form1_0.groupBox_0.Text = "UNİQUE SETTİNGS";
      form1_0.button_30.Text = "GET UNİQUES DATA";
      form1_0.label_157.Text = " UNİQUES IN THE DATABASE";
      form1_0.checkBox_26.Text = "Spawn Zerk Mob ?";
      form1_0.label_29.Text = "UNIQUE ID";
      form1_0.label_120.Text = "COUNT";
      form1_0.label_156.Text = "SELECTED UNİQUES FOR EVENT";
      form1_0.groupBox_1.Text = "REWARD SETTINGS";
      form1_0.label_25.Text = "ITEM CODE";
      form1_0.label_24.Text = "COUNT";
      form1_0.label_149.Text = "ITEM NAME";
      form1_0.label_28.Text = "Silk Count";
      form1_0.label_27.Text = "Gold Count";
      form1_0.label_26.Text = "Sp Count";
      form1_0.groupControl_0.Text = "                                                                                                CONSOL";
    }

    static byte[] smethod_50(string string_0)
    {
      return new UnicodeEncoding().GetBytes(string_0);
    }

    static byte smethod_51(ushort ushort_0)
    {
      return (byte) ((uint) ushort_0 & (uint) byte.MaxValue);
    }

    static bool smethod_52(Assembly assembly_0, Assembly assembly_1)
    {
      return true;
    }

    static int smethod_53(Class6 class6_0)
    {
      return class6_0.int_1;
    }

    static string smethod_54(string string_0)
    {
      return Class73.smethod_48(BitConverter.ToString(new SHA384Managed().ComputeHash(Class73.smethod_50(string_0))));
    }

    static byte smethod_55(Class4.Class5 class5_0)
    {
      return (byte) ((int) class5_0.byte_0 | (int) class5_0.byte_1 << 1 | (int) class5_0.byte_2 << 2 | (int) class5_0.byte_3 << 3 | (int) class5_0.byte_4 << 4 | (int) class5_0.byte_5 << 5 | (int) class5_0.byte_6 << 6 | (int) class5_0.byte_7 << 7);
    }

    static void smethod_56(Class18 class18_0, Class11 class11_0)
    {
      Class73.smethod_227(class18_0, (long[]) null, class11_0);
      class11_0.byte_0 = (byte[]) null;
      class11_0.int_12 = (int[]) null;
    }

    static unsafe void smethod_57(ref uint uint_0, Class0 class0_0, ref uint uint_1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(8);
      *(int*) voidPtr = (int) uint_0;
      *(int*) ((IntPtr) voidPtr + 4) = (int) uint_1;
      *(int*) voidPtr = (int) *(uint*) voidPtr ^ (int) class0_0.uint_2[0];
      // ISSUE: cast to a reference type
      Class73.smethod_45(1, (uint&) ((IntPtr) voidPtr + 4), class0_0, *(uint*) voidPtr);
      Class73.smethod_45(2, ref *(uint*) voidPtr, class0_0, *(uint*) ((IntPtr) voidPtr + 4));
      // ISSUE: cast to a reference type
      Class73.smethod_45(3, (uint&) ((IntPtr) voidPtr + 4), class0_0, *(uint*) voidPtr);
      Class73.smethod_45(4, ref *(uint*) voidPtr, class0_0, *(uint*) ((IntPtr) voidPtr + 4));
      // ISSUE: cast to a reference type
      Class73.smethod_45(5, (uint&) ((IntPtr) voidPtr + 4), class0_0, *(uint*) voidPtr);
      Class73.smethod_45(6, ref *(uint*) voidPtr, class0_0, *(uint*) ((IntPtr) voidPtr + 4));
      // ISSUE: cast to a reference type
      Class73.smethod_45(7, (uint&) ((IntPtr) voidPtr + 4), class0_0, *(uint*) voidPtr);
      Class73.smethod_45(8, ref *(uint*) voidPtr, class0_0, *(uint*) ((IntPtr) voidPtr + 4));
      // ISSUE: cast to a reference type
      Class73.smethod_45(9, (uint&) ((IntPtr) voidPtr + 4), class0_0, *(uint*) voidPtr);
      Class73.smethod_45(10, ref *(uint*) voidPtr, class0_0, *(uint*) ((IntPtr) voidPtr + 4));
      // ISSUE: cast to a reference type
      Class73.smethod_45(11, (uint&) ((IntPtr) voidPtr + 4), class0_0, *(uint*) voidPtr);
      Class73.smethod_45(12, ref *(uint*) voidPtr, class0_0, *(uint*) ((IntPtr) voidPtr + 4));
      // ISSUE: cast to a reference type
      Class73.smethod_45(13, (uint&) ((IntPtr) voidPtr + 4), class0_0, *(uint*) voidPtr);
      Class73.smethod_45(14, ref *(uint*) voidPtr, class0_0, *(uint*) ((IntPtr) voidPtr + 4));
      // ISSUE: cast to a reference type
      Class73.smethod_45(15, (uint&) ((IntPtr) voidPtr + 4), class0_0, *(uint*) voidPtr);
      Class73.smethod_45(16, ref *(uint*) voidPtr, class0_0, *(uint*) ((IntPtr) voidPtr + 4));
      *(int*) ((IntPtr) voidPtr + 4) = (int) *(uint*) ((IntPtr) voidPtr + 4) ^ (int) class0_0.uint_2[17];
      uint_1 = *(uint*) voidPtr;
      uint_0 = *(uint*) ((IntPtr) voidPtr + 4);
    }

    static void smethod_58(Class19 class19_0, string string_0)
    {
      Class1 class1_0 = new Class1((ushort) 28858);
      Class73.smethod_136(class1_0, (sbyte) 6);
      Class73.smethod_120(class1_0, string_0);
      class19_0.method_1(class1_0);
    }

    static void smethod_59()
    {
      try
      {
        AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(Class73.smethod_150);
      }
      catch
      {
      }
    }

    static unsafe int smethod_60(Class18 class18_0, int int_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(5);
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (class18_0.class13_0 == null);
      if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
        *(int*) voidPtr = -2;
      else
        *(int*) voidPtr = Class73.smethod_17(class18_0.class13_0, class18_0, int_0);
      return *(int*) voidPtr;
    }

    static unsafe void smethod_61(Class9 class9_0, int int_0, int int_1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(9);
      *(int*) voidPtr = int_1;
      *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) (class9_0.int_42 > 16 - *(int*) voidPtr);
      if (*(sbyte*) ((IntPtr) voidPtr + 8) != (sbyte) 0)
      {
        *(int*) ((IntPtr) voidPtr + 4) = int_0;
        class9_0.short_6 = (short) ((int) (ushort) class9_0.short_6 | (int) (ushort) (*(int*) ((IntPtr) voidPtr + 4) << class9_0.int_42 & (int) ushort.MaxValue));
        Class73.smethod_195((int) class9_0.short_6, class9_0);
        class9_0.short_6 = (short) Class73.smethod_108(16 - class9_0.int_42, *(int*) ((IntPtr) voidPtr + 4));
        class9_0.int_42 += *(int*) voidPtr - 16;
      }
      else
      {
        class9_0.short_6 = (short) ((int) (ushort) class9_0.short_6 | (int) (ushort) (int_0 << class9_0.int_42 & (int) ushort.MaxValue));
        class9_0.int_42 += *(int*) voidPtr;
      }
    }

    static unsafe string smethod_62(string string_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      string str = "";
      *(sbyte*) voidPtr = (sbyte) (string_0 == "myeventbot");
      if (*(sbyte*) voidPtr != (sbyte) 0)
        str = Form1.string_13 + Form1.string_25 + Form1.string_26 + Form1.string_27 + Form1.string_29 + Form1.string_30 + Form1.string_31 ?? "";
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (string_0 == "my-eventbot");
      if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
        str = Form1.string_32 + Form1.string_33 ?? "";
      return str;
    }

    static void smethod_63(Class29 class29_0)
    {
      try
      {
        class29_0.socket_0.BeginReceive(class29_0.byte_0, 0, class29_0.byte_0.Length, SocketFlags.None, new AsyncCallback(class29_0.method_0), (object) null);
      }
      catch (Exception ex)
      {
        Class73.smethod_245(class29_0, ex.ToString());
      }
    }

    static unsafe bool smethod_64(int int_0, Class9 class9_0, int int_1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(15);
      class9_0.byte_0[class9_0.int_37 + class9_0.int_36 * 2] = (byte) Class73.smethod_108(8, int_1);
      class9_0.byte_0[class9_0.int_37 + class9_0.int_36 * 2 + 1] = (byte) int_1;
      class9_0.byte_0[class9_0.int_34 + class9_0.int_36] = (byte) int_0;
      ++class9_0.int_36;
      *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) (int_1 == 0);
      if (*(sbyte*) ((IntPtr) voidPtr + 12) != (sbyte) 0)
      {
        ++class9_0.short_2[int_0 * 2];
      }
      else
      {
        ++class9_0.int_40;
        --int_1;
        ++class9_0.short_2[((int) Class17.byte_2[int_0] + 256 + 1) * 2];
        ++class9_0.short_3[Class73.smethod_233(int_1) * 2];
      }
      if (((class9_0.int_36 & 8191) != 0 ? 0 : (class9_0.int_27 > 2 ? 1 : 0)) != 0)
      {
        *(int*) voidPtr = class9_0.int_36 * 8;
        *(int*) ((IntPtr) voidPtr + 4) = class9_0.int_21 - class9_0.int_17;
        *(int*) ((IntPtr) voidPtr + 8) = 0;
        while (true)
        {
          *(sbyte*) ((IntPtr) voidPtr + 13) = (sbyte) (*(int*) ((IntPtr) voidPtr + 8) < 30);
          if (*(sbyte*) ((IntPtr) voidPtr + 13) != (sbyte) 0)
          {
            *(int*) voidPtr = (int) ((long) *(int*) voidPtr + (long) class9_0.short_3[*(int*) ((IntPtr) voidPtr + 8) * 2] * (5L + (long) Class17.int_3[*(int*) ((IntPtr) voidPtr + 8)]));
            *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) + 1;
          }
          else
            break;
        }
        *(int*) voidPtr = Class73.smethod_108(3, *(int*) voidPtr);
        if ((class9_0.int_40 >= class9_0.int_36 / 2 ? 0 : (*(int*) voidPtr < *(int*) ((IntPtr) voidPtr + 4) / 2 ? 1 : 0)) != 0)
        {
          *(sbyte*) ((IntPtr) voidPtr + 14) = (sbyte) 1;
          goto label_10;
        }
      }
      *(sbyte*) ((IntPtr) voidPtr + 14) = (sbyte) (class9_0.int_36 == class9_0.int_35 - 1);
label_10:
      return (bool) *(sbyte*) ((IntPtr) voidPtr + 14);
    }

    static unsafe void smethod_65(ushort ushort_0, Class1 class1_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      object object0 = class1_0.object_0;
      *(sbyte*) voidPtr = (sbyte) 0;
      try
      {
        Monitor.Enter(object0, ref *(bool*) voidPtr);
        *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) class1_0.bool_2;
        if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
          throw new Exception("Cannot Write to a locked Packet.");
        class1_0.class3_0.Write(ushort_0);
      }
      finally
      {
        if (*(sbyte*) voidPtr != (sbyte) 0)
          Monitor.Exit(object0);
      }
    }

    static void smethod_66(Class19 class19_0)
    {
      class19_0.method_1(new Class1((ushort) 28850));
    }

    static unsafe bool smethod_67(string string_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      using (SqlDataReader sqlDataReader = new SqlCommand("IF OBJECT_ID('" + string_0 + "') IS NOT NULL select 1 else select 0", Class65.sqlConnection_0).ExecuteReader())
      {
        sqlDataReader.Read();
        *(sbyte*) voidPtr = (sbyte) ((int) sqlDataReader[0] == 1);
        if (*(sbyte*) voidPtr != (sbyte) 0)
          *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) 1;
        else
          *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) 0;
      }
      return (bool) *(sbyte*) ((IntPtr) voidPtr + 1);
    }

    static string smethod_68(string string_0)
    {
      return Class73.smethod_90(BitConverter.ToString(new SHA512Managed().ComputeHash(Class73.smethod_50(string_0))));
    }

    static unsafe void smethod_69(Form1 form1_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      StreamReader streamReader = new StreamReader(Application.StartupPath + "/Ayarlar.ini");
      while (true)
      {
        switch (streamReader.ReadLine())
        {
          case "[GENEL]":
            Form1.string_23 = streamReader.ReadLine().Split('=')[1];
            continue;
          case null:
            goto label_3;
          default:
            continue;
        }
      }
label_3:
      *(sbyte*) voidPtr = (sbyte) (Form1.string_23 == "TR");
      if (*(sbyte*) voidPtr != (sbyte) 0)
      {
        Form1.smethod_0("Türkçe ayarlanıyor..");
      }
      else
      {
        *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (Form1.string_23 == "ENG");
        if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
          return;
        Form1.smethod_0("Set ENG language");
        Class73.smethod_49(form1_0);
      }
    }

    static void smethod_70(int int_0, Class4 class4_0, int int_1, byte[] byte_0)
    {
      class4_0.method_0(new Class6(byte_0, int_0, int_1, true));
    }

    static unsafe int smethod_71(byte[] byte_0, Class80.Class81 class81_0, int int_0, int int_1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(8);
      *(int*) voidPtr = 0;
      do
      {
        if (class81_0.int_4 != 11)
          goto label_2;
label_1:
        continue;
label_2:
        *(int*) ((IntPtr) voidPtr + 4) = Class73.smethod_39(int_0, class81_0.class83_0, int_1, byte_0);
        int_0 += *(int*) ((IntPtr) voidPtr + 4);
        *(int*) voidPtr = *(int*) voidPtr + *(int*) ((IntPtr) voidPtr + 4);
        int_1 -= *(int*) ((IntPtr) voidPtr + 4);
        if (int_1 != 0)
          goto label_1;
        else
          goto label_4;
      }
      while (Class73.smethod_125(class81_0) || class81_0.class83_0.int_1 > 0 && class81_0.int_4 != 11);
      goto label_5;
label_4:
      return *(int*) voidPtr;
label_5:
      return *(int*) voidPtr;
    }

    static void smethod_72(int int_0, Class19 class19_0)
    {
      Class1 class1_0 = new Class1((ushort) 28779);
      Class73.smethod_198(class1_0, (object) int_0);
      class19_0.method_1(class1_0);
    }

    static unsafe void smethod_73(Class9 class9_0, short[] short_0, int int_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(10);
      *(int*) voidPtr = class9_0.int_31[int_0];
      *(int*) ((IntPtr) voidPtr + 4) = int_0 << 1;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 9) = (sbyte) (*(int*) ((IntPtr) voidPtr + 4) <= class9_0.int_32);
        if (*(sbyte*) ((IntPtr) voidPtr + 9) != (sbyte) 0)
        {
          if ((*(int*) ((IntPtr) voidPtr + 4) >= class9_0.int_32 ? 0 : (Class73.smethod_141(short_0, class9_0.int_31[*(int*) ((IntPtr) voidPtr + 4) + 1], class9_0.int_31[*(int*) ((IntPtr) voidPtr + 4)], class9_0.byte_3) ? 1 : 0)) != 0)
            *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + 1;
          *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) Class73.smethod_141(short_0, *(int*) voidPtr, class9_0.int_31[*(int*) ((IntPtr) voidPtr + 4)], class9_0.byte_3);
          if (*(sbyte*) ((IntPtr) voidPtr + 8) == (sbyte) 0)
          {
            class9_0.int_31[int_0] = class9_0.int_31[*(int*) ((IntPtr) voidPtr + 4)];
            int_0 = *(int*) ((IntPtr) voidPtr + 4);
            *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) << 1;
          }
          else
            break;
        }
        else
          break;
      }
      class9_0.int_31[int_0] = *(int*) voidPtr;
    }

    static void smethod_74()
    {
      Class73.smethod_83(Class25.class19_0, 3530.0, 1862.0);
    }

    static unsafe uint smethod_75(uint uint_0, uint uint_1, Class4 class4_0, uint uint_2)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(23);
      *(long*) voidPtr = 1L;
      *(long*) ((IntPtr) voidPtr + 8) = (long) uint_0;
      *(sbyte*) ((IntPtr) voidPtr + 20) = (sbyte) (uint_2 == 0U);
      if (*(sbyte*) ((IntPtr) voidPtr + 20) != (sbyte) 0)
      {
        *(int*) ((IntPtr) voidPtr + 16) = 1;
      }
      else
      {
        while (true)
        {
          *(sbyte*) ((IntPtr) voidPtr + 22) = (sbyte) (uint_2 > 0U);
          if (*(sbyte*) ((IntPtr) voidPtr + 22) != (sbyte) 0)
          {
            *(sbyte*) ((IntPtr) voidPtr + 21) = (sbyte) ((uint_2 & 1U) > 0U);
            if (*(sbyte*) ((IntPtr) voidPtr + 21) != (sbyte) 0)
              *(long*) voidPtr = *(long*) ((IntPtr) voidPtr + 8) * *(long*) voidPtr % (long) uint_1;
            uint_2 >>= 1;
            *(long*) ((IntPtr) voidPtr + 8) = *(long*) ((IntPtr) voidPtr + 8) * *(long*) ((IntPtr) voidPtr + 8) % (long) uint_1;
          }
          else
            break;
        }
        *(int*) ((IntPtr) voidPtr + 16) = (int) (uint) *(long*) voidPtr;
      }
      return *(uint*) ((IntPtr) voidPtr + 16);
    }

    static string smethod_76(byte[] byte_0)
    {
      return Class73.smethod_231(byte_0.Length, 0, byte_0);
    }

    static string smethod_77(string string_0)
    {
      return Class73.smethod_68(BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(Class73.smethod_50(string_0))));
    }

    static string smethod_78(string string_0)
    {
      return Class73.smethod_116(BitConverter.ToString(new SHA1CryptoServiceProvider().ComputeHash(Class73.smethod_50(string_0))));
    }

    static string smethod_79(string string_0)
    {
      return Class73.smethod_203(BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(Class73.smethod_50(string_0))));
    }

    static unsafe byte smethod_80(bool bool_0, Class4 class4_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(3);
      *(sbyte*) voidPtr = (sbyte) (byte) ((uint) class4_0.byte_0[2] * ((uint) ~class4_0.byte_0[0] + (uint) class4_0.byte_0[1]));
      *(sbyte*) voidPtr = (sbyte) (byte) ((uint) *(byte*) voidPtr ^ (uint) *(byte*) voidPtr >> 4);
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) bool_0;
      if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
        class4_0.byte_0[0] = *(byte*) voidPtr;
      *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) *(byte*) voidPtr;
      return *(byte*) ((IntPtr) voidPtr + 2);
    }

    static string smethod_81(string string_0)
    {
      return Class73.smethod_77(BitConverter.ToString(new SHA512Managed().ComputeHash(Class73.smethod_50(string_0))));
    }

    static unsafe void smethod_82(byte[] byte_0, Class80.Class84 class84_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(64);
      int[] numArray1 = new int[16];
      int[] numArray2 = new int[16];
      *(int*) ((IntPtr) voidPtr + 12) = 0;
      while (*(int*) ((IntPtr) voidPtr + 12) < byte_0.Length)
      {
        *(int*) ((IntPtr) voidPtr + 16) = (int) byte_0[*(int*) ((IntPtr) voidPtr + 12)];
        if (*(int*) ((IntPtr) voidPtr + 16) > 0)
          ++numArray1[*(int*) ((IntPtr) voidPtr + 16)];
        *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + 1;
      }
      *(int*) voidPtr = 0;
      *(int*) ((IntPtr) voidPtr + 4) = 512;
      *(int*) ((IntPtr) voidPtr + 20) = 1;
      while (*(int*) ((IntPtr) voidPtr + 20) <= 15)
      {
        numArray2[*(int*) ((IntPtr) voidPtr + 20)] = *(int*) voidPtr;
        *(int*) voidPtr = *(int*) voidPtr + (numArray1[*(int*) ((IntPtr) voidPtr + 20)] << 16 - *(int*) ((IntPtr) voidPtr + 20));
        if (*(int*) ((IntPtr) voidPtr + 20) >= 10)
        {
          *(int*) ((IntPtr) voidPtr + 24) = numArray2[*(int*) ((IntPtr) voidPtr + 20)] & 130944;
          *(int*) ((IntPtr) voidPtr + 28) = *(int*) voidPtr & 130944;
          *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + (*(int*) ((IntPtr) voidPtr + 28) - *(int*) ((IntPtr) voidPtr + 24) >> 16 - *(int*) ((IntPtr) voidPtr + 20));
        }
        *(int*) ((IntPtr) voidPtr + 20) = *(int*) ((IntPtr) voidPtr + 20) + 1;
      }
      class84_0.short_0 = new short[*(int*) ((IntPtr) voidPtr + 4)];
      *(int*) ((IntPtr) voidPtr + 8) = 512;
      *(int*) ((IntPtr) voidPtr + 32) = 15;
      while (*(int*) ((IntPtr) voidPtr + 32) >= 10)
      {
        *(int*) ((IntPtr) voidPtr + 36) = *(int*) voidPtr & 130944;
        *(int*) voidPtr = *(int*) voidPtr - (numArray1[*(int*) ((IntPtr) voidPtr + 32)] << 16 - *(int*) ((IntPtr) voidPtr + 32));
        *(int*) ((IntPtr) voidPtr + 40) = *(int*) voidPtr & 130944;
        while (*(int*) ((IntPtr) voidPtr + 40) < *(int*) ((IntPtr) voidPtr + 36))
        {
          class84_0.short_0[(int) Class73.smethod_7(*(int*) ((IntPtr) voidPtr + 40))] = (short) (-*(int*) ((IntPtr) voidPtr + 8) << 4 | *(int*) ((IntPtr) voidPtr + 32));
          *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) + (1 << *(int*) ((IntPtr) voidPtr + 32) - 9);
          *(int*) ((IntPtr) voidPtr + 40) = *(int*) ((IntPtr) voidPtr + 40) + 128;
        }
        *(int*) ((IntPtr) voidPtr + 32) = *(int*) ((IntPtr) voidPtr + 32) - 1;
      }
      *(int*) ((IntPtr) voidPtr + 44) = 0;
      while (*(int*) ((IntPtr) voidPtr + 44) < byte_0.Length)
      {
        *(int*) ((IntPtr) voidPtr + 48) = (int) byte_0[*(int*) ((IntPtr) voidPtr + 44)];
        if (*(int*) ((IntPtr) voidPtr + 48) != 0)
        {
          *(int*) voidPtr = numArray2[*(int*) ((IntPtr) voidPtr + 48)];
          *(int*) ((IntPtr) voidPtr + 52) = (int) Class73.smethod_7(*(int*) voidPtr);
          if (*(int*) ((IntPtr) voidPtr + 48) <= 9)
          {
            do
            {
              class84_0.short_0[*(int*) ((IntPtr) voidPtr + 52)] = (short) (*(int*) ((IntPtr) voidPtr + 44) << 4 | *(int*) ((IntPtr) voidPtr + 48));
              *(int*) ((IntPtr) voidPtr + 52) = *(int*) ((IntPtr) voidPtr + 52) + (1 << *(int*) ((IntPtr) voidPtr + 48));
            }
            while (*(int*) ((IntPtr) voidPtr + 52) < 512);
          }
          else
          {
            *(int*) ((IntPtr) voidPtr + 56) = (int) class84_0.short_0[*(int*) ((IntPtr) voidPtr + 52) & 511];
            *(int*) ((IntPtr) voidPtr + 60) = 1 << (*(int*) ((IntPtr) voidPtr + 56) & 15);
            *(int*) ((IntPtr) voidPtr + 56) = -(*(int*) ((IntPtr) voidPtr + 56) >> 4);
            do
            {
              class84_0.short_0[*(int*) ((IntPtr) voidPtr + 56) | *(int*) ((IntPtr) voidPtr + 52) >> 9] = (short) (*(int*) ((IntPtr) voidPtr + 44) << 4 | *(int*) ((IntPtr) voidPtr + 48));
              *(int*) ((IntPtr) voidPtr + 52) = *(int*) ((IntPtr) voidPtr + 52) + (1 << *(int*) ((IntPtr) voidPtr + 48));
            }
            while (*(int*) ((IntPtr) voidPtr + 52) < *(int*) ((IntPtr) voidPtr + 60));
          }
          numArray2[*(int*) ((IntPtr) voidPtr + 48)] = *(int*) voidPtr + (1 << 16 - *(int*) ((IntPtr) voidPtr + 48));
        }
        *(int*) ((IntPtr) voidPtr + 44) = *(int*) ((IntPtr) voidPtr + 44) + 1;
      }
    }

    static unsafe void smethod_83(Class19 class19_0, double double_0, double double_1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(36);
      *(double*) voidPtr = double_0 % 192.0 * 10.0;
      *(double*) ((IntPtr) voidPtr + 8) = double_1 % 192.0 * 10.0;
      *(double*) ((IntPtr) voidPtr + 16) = (double_0 - *(double*) voidPtr / 10.0) / 192.0 + 135.0;
      *(double*) ((IntPtr) voidPtr + 24) = (double_1 - *(double*) ((IntPtr) voidPtr + 8) / 10.0) / 192.0 + 92.0;
      *(int*) ((IntPtr) voidPtr + 32) = Convert.ToInt32(*(double*) ((IntPtr) voidPtr + 24) * Math.Pow(2.0, 8.0) + *(double*) ((IntPtr) voidPtr + 16));
      Class1 class1_0 = new Class1((ushort) 28688);
      Class73.smethod_162((byte) 16, class1_0);
      Class73.smethod_162((byte) 0, class1_0);
      Class73.smethod_226(class1_0, (object) *(int*) ((IntPtr) voidPtr + 32));
      Class73.smethod_134((float) *(double*) voidPtr, class1_0);
      Class73.smethod_134(1000f, class1_0);
      Class73.smethod_134((float) *(double*) ((IntPtr) voidPtr + 8), class1_0);
      Class73.smethod_136(class1_0, (sbyte) 1);
      Class73.smethod_162((byte) 0, class1_0);
      class19_0.method_1(class1_0);
    }

    static int smethod_84(Class6 class6_0)
    {
      return class6_0.int_0;
    }

    static string smethod_85()
    {
      return Class73.smethod_124("32767");
    }

    static unsafe void smethod_86(ref uint uint_0, ref uint uint_1, Class0 class0_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(8);
      *(int*) voidPtr = (int) uint_0;
      *(int*) ((IntPtr) voidPtr + 4) = (int) uint_1;
      *(int*) voidPtr = (int) *(uint*) voidPtr ^ (int) class0_0.uint_2[17];
      // ISSUE: cast to a reference type
      Class73.smethod_45(16, (uint&) ((IntPtr) voidPtr + 4), class0_0, *(uint*) voidPtr);
      Class73.smethod_45(15, ref *(uint*) voidPtr, class0_0, *(uint*) ((IntPtr) voidPtr + 4));
      // ISSUE: cast to a reference type
      Class73.smethod_45(14, (uint&) ((IntPtr) voidPtr + 4), class0_0, *(uint*) voidPtr);
      Class73.smethod_45(13, ref *(uint*) voidPtr, class0_0, *(uint*) ((IntPtr) voidPtr + 4));
      // ISSUE: cast to a reference type
      Class73.smethod_45(12, (uint&) ((IntPtr) voidPtr + 4), class0_0, *(uint*) voidPtr);
      Class73.smethod_45(11, ref *(uint*) voidPtr, class0_0, *(uint*) ((IntPtr) voidPtr + 4));
      // ISSUE: cast to a reference type
      Class73.smethod_45(10, (uint&) ((IntPtr) voidPtr + 4), class0_0, *(uint*) voidPtr);
      Class73.smethod_45(9, ref *(uint*) voidPtr, class0_0, *(uint*) ((IntPtr) voidPtr + 4));
      // ISSUE: cast to a reference type
      Class73.smethod_45(8, (uint&) ((IntPtr) voidPtr + 4), class0_0, *(uint*) voidPtr);
      Class73.smethod_45(7, ref *(uint*) voidPtr, class0_0, *(uint*) ((IntPtr) voidPtr + 4));
      // ISSUE: cast to a reference type
      Class73.smethod_45(6, (uint&) ((IntPtr) voidPtr + 4), class0_0, *(uint*) voidPtr);
      Class73.smethod_45(5, ref *(uint*) voidPtr, class0_0, *(uint*) ((IntPtr) voidPtr + 4));
      // ISSUE: cast to a reference type
      Class73.smethod_45(4, (uint&) ((IntPtr) voidPtr + 4), class0_0, *(uint*) voidPtr);
      Class73.smethod_45(3, ref *(uint*) voidPtr, class0_0, *(uint*) ((IntPtr) voidPtr + 4));
      // ISSUE: cast to a reference type
      Class73.smethod_45(2, (uint&) ((IntPtr) voidPtr + 4), class0_0, *(uint*) voidPtr);
      Class73.smethod_45(1, ref *(uint*) voidPtr, class0_0, *(uint*) ((IntPtr) voidPtr + 4));
      *(int*) ((IntPtr) voidPtr + 4) = (int) *(uint*) ((IntPtr) voidPtr + 4) ^ (int) class0_0.uint_2[0];
      uint_0 = *(uint*) ((IntPtr) voidPtr + 4);
      uint_1 = *(uint*) voidPtr;
    }

    static string smethod_87(Class1 class1_0)
    {
      return Class73.smethod_140(class1_0, 1254).Replace("'", "''");
    }

    static void smethod_88(Class80.Class82 class82_0)
    {
      class82_0.uint_0 >>= class82_0.int_2 & 7;
      class82_0.int_2 &= -8;
    }

    static ushort smethod_89(Class1 class1_0)
    {
      return class1_0.ushort_0;
    }

    static string smethod_90(string string_0)
    {
      return Class73.smethod_184(BitConverter.ToString(new SHA384Managed().ComputeHash(Class73.smethod_50(string_0))));
    }

    static unsafe void smethod_91(Class9 class9_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(8);
      do
      {
        *(int*) voidPtr = class9_0.int_12 - class9_0.int_23 - class9_0.int_21;
        if ((*(int*) voidPtr != 0 || class9_0.int_21 != 0 ? 0 : (class9_0.int_23 == 0 ? 1 : 0)) != 0)
        {
          *(int*) voidPtr = class9_0.int_9;
        }
        else
        {
          *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (*(int*) voidPtr == -1);
          if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
          {
            *(int*) voidPtr = *(int*) voidPtr - 1;
          }
          else
          {
            *(sbyte*) ((IntPtr) voidPtr + 5) = (sbyte) (class9_0.int_21 >= class9_0.int_9 + class9_0.int_9 - Class9.int_0);
            if (*(sbyte*) ((IntPtr) voidPtr + 5) != (sbyte) 0)
            {
              Array.Copy((Array) class9_0.byte_2, class9_0.int_9, (Array) class9_0.byte_2, 0, class9_0.int_9);
              class9_0.int_22 -= class9_0.int_9;
              class9_0.int_21 -= class9_0.int_9;
              class9_0.int_17 -= class9_0.int_9;
              int int14 = class9_0.int_14;
              int index1 = int14;
              do
              {
                int num = (int) class9_0.short_1[--index1] & (int) ushort.MaxValue;
                class9_0.short_1[index1] = num < class9_0.int_9 ? (short) 0 : (short) (num - class9_0.int_9);
              }
              while ((uint) --int14 > 0U);
              int int9 = class9_0.int_9;
              int index2 = int9;
              do
              {
                int num = (int) class9_0.short_0[--index2] & (int) ushort.MaxValue;
                class9_0.short_0[index2] = num < class9_0.int_9 ? (short) 0 : (short) (num - class9_0.int_9);
              }
              while ((uint) --int9 > 0U);
              *(int*) voidPtr = *(int*) voidPtr + class9_0.int_9;
            }
          }
        }
        *(sbyte*) ((IntPtr) voidPtr + 6) = (sbyte) (class9_0.class18_0.int_2 == 0);
        if (*(sbyte*) ((IntPtr) voidPtr + 6) == (sbyte) 0)
        {
          int num = Class73.smethod_156(class9_0.class18_0, class9_0.byte_2, class9_0.int_21 + class9_0.int_23, *(int*) voidPtr);
          class9_0.int_23 += num;
          *(sbyte*) ((IntPtr) voidPtr + 7) = (sbyte) (class9_0.int_23 >= 3);
          if (*(sbyte*) ((IntPtr) voidPtr + 7) != (sbyte) 0)
          {
            class9_0.int_13 = (int) class9_0.byte_2[class9_0.int_21] & (int) byte.MaxValue;
            class9_0.int_13 = (class9_0.int_13 << class9_0.int_16 ^ (int) class9_0.byte_2[class9_0.int_21 + 1] & (int) byte.MaxValue) & class9_0.int_15;
          }
        }
        else
          goto label_16;
      }
      while ((class9_0.int_23 >= Class9.int_0 ? 0 : ((uint) class9_0.class18_0.int_2 > 0U ? 1 : 0)) != 0);
      goto label_14;
label_16:
      return;
label_14:;
    }

    static unsafe void smethod_92(string string_0, Class1 class1_0, int int_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      object object0 = class1_0.object_0;
      *(sbyte*) voidPtr = (sbyte) 0;
      try
      {
        Monitor.Enter(object0, ref *(bool*) voidPtr);
        *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) class1_0.bool_2;
        if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
          throw new Exception("Cannot Write to a locked Packet.");
        Encoding.UTF8.GetString(Encoding.GetEncoding(int_0).GetBytes(string_0));
        byte[] bytes = Encoding.Default.GetBytes(string_0);
        class1_0.class3_0.Write((ushort) bytes.Length);
        class1_0.class3_0.Write(bytes);
      }
      finally
      {
        if (*(sbyte*) voidPtr != (sbyte) 0)
          Monitor.Exit(object0);
      }
    }

    static unsafe int smethod_93(Class18 class18_0, Class13 class13_0, int int_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(5);
      class18_0.string_0 = (string) null;
      class13_0.class11_0 = (Class11) null;
      class13_0.int_3 = 0;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (int_0 < 0);
      if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
      {
        int_0 = -int_0;
        class13_0.int_3 = 1;
      }
      if ((int_0 < 8 ? 1 : (int_0 > 15 ? 1 : 0)) != 0)
      {
        Class73.smethod_154(class13_0, class18_0);
        *(int*) voidPtr = -2;
      }
      else
      {
        class13_0.int_4 = int_0;
        class18_0.class13_0.class11_0 = new Class11(class18_0, class18_0.class13_0.int_3 != 0 ? (object) (Class13) null : (object) class13_0, 1 << int_0);
        Class73.smethod_189(class18_0, class13_0);
        *(int*) voidPtr = 0;
      }
      return *(int*) voidPtr;
    }

    static void smethod_94()
    {
      try
      {
        if (Environment.OSVersion.Platform != PlatformID.Win32NT)
          return;
        MemoryManager.memoryManager_0 = new MemoryManager();
      }
      catch
      {
      }
    }

    static uint smethod_95(uint uint_0, Class0 class0_0)
    {
      return (Class73.smethod_240(uint_0, 0, class0_0) + Class73.smethod_240(uint_0, 1, class0_0) ^ Class73.smethod_240(uint_0, 2, class0_0)) + Class73.smethod_240(uint_0, 3, class0_0);
    }

    static void smethod_96(Form1 form1_0, int int_0)
    {
      try
      {
        new SqlCommand("update top(1) My_EventBot.._UniqKesList set Durum = 1 where refcommon_ID = " + (object) int_0 + " and Durum =0", Class65.sqlConnection_0).ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        Form1.smethod_0("[Unique Kesme] eventinde " + (object) int_0 + " ID li uniquein Durum kolonu 1 olarak güncellenemedi!!");
        Form1.smethod_0("Hata Açıklaması ==> " + ex.Message);
      }
    }

    static Class80.Class84 smethod_97(Class80.Class85 class85_0)
    {
      byte[] byte_0 = new byte[class85_0.int_3];
      Array.Copy((Array) class85_0.byte_1, 0, (Array) byte_0, 0, class85_0.int_3);
      return new Class80.Class84(byte_0);
    }

    private static string smethod_98()
    {
      string str;
      try
      {
        str = "asd@asd.asd";
        Form1.form1_0.label_171.Text = str;
      }
      catch (Exception ex)
      {
        Form1.smethod_0("Mail adresiniz alınamadı.Lütfen internet bağlantınızı kontrol edip programı yeniden başlatın.!!  ");
        str = "";
      }
      return str;
    }

    static unsafe int smethod_99(Class80.Class84 class84_0, Class80.Class82 class82_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(16);
      int index1;
      if ((index1 = Class73.smethod_254(class82_0, 9)) >= 0)
      {
        int num1;
        if ((num1 = (int) class84_0.short_0[index1]) >= 0)
        {
          Class73.smethod_147(class82_0, num1 & 15);
          return num1 >> 4;
        }
        *(int*) voidPtr = -(num1 >> 4);
        *(int*) ((IntPtr) voidPtr + 4) = num1 & 15;
        int num2;
        if ((num2 = Class73.smethod_254(class82_0, *(int*) ((IntPtr) voidPtr + 4))) >= 0)
        {
          int num3 = (int) class84_0.short_0[*(int*) voidPtr | num2 >> 9];
          Class73.smethod_147(class82_0, num3 & 15);
          return num3 >> 4;
        }
        *(int*) ((IntPtr) voidPtr + 8) = class82_0.int_2;
        int num4 = Class73.smethod_254(class82_0, *(int*) ((IntPtr) voidPtr + 8));
        int num5 = (int) class84_0.short_0[*(int*) voidPtr | num4 >> 9];
        if ((num5 & 15) > *(int*) ((IntPtr) voidPtr + 8))
          return -1;
        Class73.smethod_147(class82_0, num5 & 15);
        return num5 >> 4;
      }
      *(int*) ((IntPtr) voidPtr + 12) = class82_0.int_2;
      int index2 = Class73.smethod_254(class82_0, *(int*) ((IntPtr) voidPtr + 12));
      int num = (int) class84_0.short_0[index2];
      if (num < 0 || (num & 15) > *(int*) ((IntPtr) voidPtr + 12))
        return -1;
      Class73.smethod_147(class82_0, num & 15);
      return num >> 4;
    }

    static unsafe int smethod_100(
      int[] int_0,
      int[] int_1,
      int[] int_2,
      int[] int_3,
      Class18 class18_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(9);
      int[] int_9 = new int[1];
      int[] int_10 = new int[19];
      *(int*) voidPtr = Class73.smethod_194(int_1, 0, 19, 19, (int[]) null, (int[]) null, int_0, int_3, int_2, int_9, int_10);
      *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) (*(int*) voidPtr == -3);
      if (*(sbyte*) ((IntPtr) voidPtr + 8) != (sbyte) 0)
        class18_0.string_0 = "oversubscribed dynamic bit lengths tree";
      else if ((*(int*) voidPtr == -5 ? 1 : (int_3[0] == 0 ? 1 : 0)) != 0)
      {
        class18_0.string_0 = "incomplete dynamic bit lengths tree";
        *(int*) voidPtr = -3;
      }
      *(int*) ((IntPtr) voidPtr + 4) = *(int*) voidPtr;
      return *(int*) ((IntPtr) voidPtr + 4);
    }

    static void smethod_101()
    {
      Class73.smethod_83(Class25.class19_0, 3680.0, 2111.0);
    }

    static void smethod_102(Class9 class9_0, byte byte_0)
    {
      byte[] byte0 = class9_0.byte_0;
      Class9 class9 = class9_0;
      int int6 = class9_0.int_6;
      int num1 = int6 + 1;
      class9.int_6 = num1;
      int index = int6;
      int num2 = (int) byte_0;
      byte0[index] = (byte) num2;
    }

    static int smethod_103(Class0 class0_0, int int_0)
    {
      return int_0 % 8 == 0 ? int_0 : int_0 + (8 - int_0 % 8);
    }

    static unsafe void smethod_104(Class9 class9_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(15);
      *(int*) voidPtr = 0;
      *(int*) ((IntPtr) voidPtr + 4) = 0;
      *(int*) ((IntPtr) voidPtr + 8) = 0;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) (*(int*) voidPtr < 7);
        if (*(sbyte*) ((IntPtr) voidPtr + 12) != (sbyte) 0)
        {
          *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) + (int) class9_0.short_2[*(int*) voidPtr * 2];
          *(int*) voidPtr = *(int*) voidPtr + 1;
        }
        else
          break;
      }
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 13) = (sbyte) (*(int*) voidPtr < 128);
        if (*(sbyte*) ((IntPtr) voidPtr + 13) != (sbyte) 0)
        {
          *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + (int) class9_0.short_2[*(int*) voidPtr * 2];
          *(int*) voidPtr = *(int*) voidPtr + 1;
        }
        else
          break;
      }
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 14) = (sbyte) (*(int*) voidPtr < 256);
        if (*(sbyte*) ((IntPtr) voidPtr + 14) != (sbyte) 0)
        {
          *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) + (int) class9_0.short_2[*(int*) voidPtr * 2];
          *(int*) voidPtr = *(int*) voidPtr + 1;
        }
        else
          break;
      }
      class9_0.byte_1 = *(int*) ((IntPtr) voidPtr + 8) > Class73.smethod_108(2, *(int*) ((IntPtr) voidPtr + 4)) ? (byte) 0 : (byte) 1;
    }

    [DllImport("kernel32")]
    static extern bool MoveFileEx(string string_0, string string_1, int int_0);

    static unsafe void smethod_105(short[] short_0, Class9 class9_0, short[] short_1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(25);
      *(int*) ((IntPtr) voidPtr + 8) = 0;
      *(sbyte*) ((IntPtr) voidPtr + 20) = (sbyte) ((uint) class9_0.int_36 > 0U);
      if (*(sbyte*) ((IntPtr) voidPtr + 20) != (sbyte) 0)
      {
        do
        {
          *(int*) voidPtr = (int) class9_0.byte_0[class9_0.int_37 + *(int*) ((IntPtr) voidPtr + 8) * 2] << 8 & 65280 | (int) class9_0.byte_0[class9_0.int_37 + *(int*) ((IntPtr) voidPtr + 8) * 2 + 1] & (int) byte.MaxValue;
          *(int*) ((IntPtr) voidPtr + 4) = (int) class9_0.byte_0[class9_0.int_34 + *(int*) ((IntPtr) voidPtr + 8)] & (int) byte.MaxValue;
          *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) + 1;
          *(sbyte*) ((IntPtr) voidPtr + 21) = (sbyte) (*(int*) voidPtr == 0);
          if (*(sbyte*) ((IntPtr) voidPtr + 21) == (sbyte) 0)
          {
            *(int*) ((IntPtr) voidPtr + 12) = (int) Class17.byte_2[*(int*) ((IntPtr) voidPtr + 4)];
            Class73.smethod_137(class9_0, *(int*) ((IntPtr) voidPtr + 12) + 256 + 1, short_0);
            *(int*) ((IntPtr) voidPtr + 16) = Class17.int_2[*(int*) ((IntPtr) voidPtr + 12)];
            *(sbyte*) ((IntPtr) voidPtr + 22) = (sbyte) ((uint) *(int*) ((IntPtr) voidPtr + 16) > 0U);
            if (*(sbyte*) ((IntPtr) voidPtr + 22) != (sbyte) 0)
            {
              *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) - Class17.int_5[*(int*) ((IntPtr) voidPtr + 12)];
              Class73.smethod_61(class9_0, *(int*) ((IntPtr) voidPtr + 4), *(int*) ((IntPtr) voidPtr + 16));
            }
            *(int*) voidPtr = *(int*) voidPtr - 1;
            *(int*) ((IntPtr) voidPtr + 12) = Class73.smethod_233(*(int*) voidPtr);
            Class73.smethod_137(class9_0, *(int*) ((IntPtr) voidPtr + 12), short_1);
            *(int*) ((IntPtr) voidPtr + 16) = Class17.int_3[*(int*) ((IntPtr) voidPtr + 12)];
            *(sbyte*) ((IntPtr) voidPtr + 23) = (sbyte) ((uint) *(int*) ((IntPtr) voidPtr + 16) > 0U);
            if (*(sbyte*) ((IntPtr) voidPtr + 23) != (sbyte) 0)
            {
              *(int*) voidPtr = *(int*) voidPtr - Class17.int_6[*(int*) ((IntPtr) voidPtr + 12)];
              Class73.smethod_61(class9_0, *(int*) voidPtr, *(int*) ((IntPtr) voidPtr + 16));
            }
          }
          else
            goto label_6;
label_5:
          *(sbyte*) ((IntPtr) voidPtr + 24) = (sbyte) (*(int*) ((IntPtr) voidPtr + 8) < class9_0.int_36);
          continue;
label_6:
          Class73.smethod_137(class9_0, *(int*) ((IntPtr) voidPtr + 4), short_0);
          goto label_5;
        }
        while (*(sbyte*) ((IntPtr) voidPtr + 24) != (sbyte) 0);
      }
      Class73.smethod_137(class9_0, 256, short_0);
      class9_0.int_41 = (int) short_0[513];
    }

    static unsafe int smethod_106(Class9 class9_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(14);
      short[] short2 = class9_0.short_2;
      *(int*) ((IntPtr) voidPtr + 8) = class9_0.class17_0.int_7;
      Class73.smethod_122(*(int*) ((IntPtr) voidPtr + 8), short2, class9_0);
      short[] short3 = class9_0.short_3;
      *(int*) ((IntPtr) voidPtr + 8) = class9_0.class17_1.int_7;
      Class73.smethod_122(*(int*) ((IntPtr) voidPtr + 8), short3, class9_0);
      Class73.smethod_32(class9_0.class17_2, class9_0);
      *(int*) voidPtr = 18;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 13) = (sbyte) (*(int*) voidPtr >= 3);
        if (*(sbyte*) ((IntPtr) voidPtr + 13) != (sbyte) 0)
        {
          *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) ((uint) class9_0.short_4[(int) Class17.byte_0[*(int*) voidPtr] * 2 + 1] > 0U);
          if (*(sbyte*) ((IntPtr) voidPtr + 12) == (sbyte) 0)
            *(int*) voidPtr = *(int*) voidPtr - 1;
          else
            break;
        }
        else
          break;
      }
      class9_0.int_38 += 3 * (*(int*) voidPtr + 1) + 5 + 5 + 4;
      *(int*) ((IntPtr) voidPtr + 4) = *(int*) voidPtr;
      return *(int*) ((IntPtr) voidPtr + 4);
    }

    static unsafe void smethod_107(Class18 class18_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(7);
      *(int*) voidPtr = class18_0.class9_0.int_6;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (*(int*) voidPtr > class18_0.int_4);
      if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
        *(int*) voidPtr = class18_0.int_4;
      *(sbyte*) ((IntPtr) voidPtr + 5) = (sbyte) (*(int*) voidPtr == 0);
      if (*(sbyte*) ((IntPtr) voidPtr + 5) != (sbyte) 0)
        return;
      if ((class18_0.class9_0.byte_0.Length <= class18_0.class9_0.int_5 || class18_0.byte_1.Length <= class18_0.int_3 || class18_0.class9_0.byte_0.Length < class18_0.class9_0.int_5 + *(int*) voidPtr ? 1 : (class18_0.byte_1.Length < class18_0.int_3 + *(int*) voidPtr ? 1 : 0)) != 0)
        ;
      Array.Copy((Array) class18_0.class9_0.byte_0, class18_0.class9_0.int_5, (Array) class18_0.byte_1, class18_0.int_3, *(int*) voidPtr);
      class18_0.int_3 += *(int*) voidPtr;
      class18_0.class9_0.int_5 += *(int*) voidPtr;
      class18_0.long_1 += (long) *(int*) voidPtr;
      class18_0.int_4 -= *(int*) voidPtr;
      class18_0.class9_0.int_6 -= *(int*) voidPtr;
      *(sbyte*) ((IntPtr) voidPtr + 6) = (sbyte) (class18_0.class9_0.int_6 == 0);
      if (*(sbyte*) ((IntPtr) voidPtr + 6) == (sbyte) 0)
        return;
      class18_0.class9_0.int_5 = 0;
    }

    static unsafe int smethod_108(int int_0, int int_1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(5);
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (int_1 >= 0);
      if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
        *(int*) voidPtr = int_1 >> int_0;
      else
        *(int*) voidPtr = (int_1 >> int_0) + (2 << ~int_0);
      return *(int*) voidPtr;
    }

    static string smethod_109(string string_0)
    {
      return Class73.smethod_1(BitConverter.ToString(new SHA256Managed().ComputeHash(Class73.smethod_50(string_0))));
    }

    static byte smethod_110(ushort ushort_0)
    {
      return (byte) ((int) ushort_0 >> 8 & (int) byte.MaxValue);
    }

    static unsafe byte[] smethod_111(byte[] byte_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(46);
      Assembly callingAssembly = Assembly.GetCallingAssembly();
      Assembly executingAssembly = Assembly.GetExecutingAssembly();
      if ((object) callingAssembly != (object) executingAssembly && !Class73.smethod_52(executingAssembly, callingAssembly))
        return (byte[]) null;
      Class80.Stream1 stream1_0 = new Class80.Stream1(byte_0);
      byte[] byte_0_1 = new byte[0];
      *(int*) voidPtr = Class73.smethod_200(stream1_0);
      if (*(int*) voidPtr == 67324752)
      {
        *(short*) ((IntPtr) voidPtr + 44) = (short) Class73.smethod_239(stream1_0);
        *(int*) ((IntPtr) voidPtr + 4) = Class73.smethod_239(stream1_0);
        *(int*) ((IntPtr) voidPtr + 8) = Class73.smethod_239(stream1_0);
        if (*(int*) voidPtr != 67324752 || *(short*) ((IntPtr) voidPtr + 44) != (short) 20 || (*(int*) ((IntPtr) voidPtr + 4) != 0 || *(int*) ((IntPtr) voidPtr + 8) != 8))
          throw new FormatException("Wrong Header Signature");
        Class73.smethod_200(stream1_0);
        Class73.smethod_200(stream1_0);
        Class73.smethod_200(stream1_0);
        *(int*) ((IntPtr) voidPtr + 12) = Class73.smethod_200(stream1_0);
        *(int*) ((IntPtr) voidPtr + 16) = Class73.smethod_239(stream1_0);
        *(int*) ((IntPtr) voidPtr + 20) = Class73.smethod_239(stream1_0);
        if (*(int*) ((IntPtr) voidPtr + 16) > 0)
        {
          byte[] buffer = new byte[*(int*) ((IntPtr) voidPtr + 16)];
          stream1_0.Read(buffer, 0, *(int*) ((IntPtr) voidPtr + 16));
        }
        if (*(int*) ((IntPtr) voidPtr + 20) > 0)
        {
          byte[] buffer = new byte[*(int*) ((IntPtr) voidPtr + 20)];
          stream1_0.Read(buffer, 0, *(int*) ((IntPtr) voidPtr + 20));
        }
        byte[] numArray = new byte[stream1_0.Length - stream1_0.Position];
        stream1_0.Read(numArray, 0, numArray.Length);
        Class80.Class81 class81 = new Class80.Class81(numArray);
        byte_0_1 = new byte[*(int*) ((IntPtr) voidPtr + 12)];
        Class80.Class81 class81_0 = class81;
        byte[] byte_0_2 = byte_0_1;
        *(int*) ((IntPtr) voidPtr + 40) = byte_0_1.Length;
        Class73.smethod_71(byte_0_2, class81_0, 0, *(int*) ((IntPtr) voidPtr + 40));
      }
      else
      {
        *(int*) ((IntPtr) voidPtr + 24) = *(int*) voidPtr >> 24;
        *(int*) voidPtr = *(int*) voidPtr - (*(int*) ((IntPtr) voidPtr + 24) << 24);
        if (*(int*) voidPtr != 8223355)
          throw new FormatException("Unknown Header");
        if (*(int*) ((IntPtr) voidPtr + 24) == 1)
        {
          *(int*) ((IntPtr) voidPtr + 28) = Class73.smethod_200(stream1_0);
          byte_0_1 = new byte[*(int*) ((IntPtr) voidPtr + 28)];
          *(int*) ((IntPtr) voidPtr + 32) = 0;
          while (*(int*) ((IntPtr) voidPtr + 32) < *(int*) ((IntPtr) voidPtr + 28))
          {
            int length = Class73.smethod_200(stream1_0);
            *(int*) ((IntPtr) voidPtr + 36) = Class73.smethod_200(stream1_0);
            byte[] numArray = new byte[length];
            stream1_0.Read(numArray, 0, numArray.Length);
            Class73.smethod_71(byte_0_1, new Class80.Class81(numArray), *(int*) ((IntPtr) voidPtr + 32), *(int*) ((IntPtr) voidPtr + 36));
            *(int*) ((IntPtr) voidPtr + 32) = *(int*) ((IntPtr) voidPtr + 32) + *(int*) ((IntPtr) voidPtr + 36);
          }
        }
        if (*(int*) ((IntPtr) voidPtr + 24) == 2)
        {
          using (ICryptoTransform cryptoTransform = Class73.smethod_13(new byte[8]
          {
            (byte) 157,
            (byte) 46,
            (byte) 154,
            (byte) 250,
            (byte) 237,
            (byte) 194,
            (byte) 169,
            (byte) 169
          }, true, new byte[8]
          {
            (byte) 209,
            (byte) 86,
            (byte) 222,
            (byte) 56,
            (byte) 101,
            (byte) 161,
            (byte) 74,
            (byte) 178
          }))
            byte_0_1 = Class73.smethod_111(cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4));
        }
        if (*(int*) ((IntPtr) voidPtr + 24) == 3)
        {
          using (ICryptoTransform cryptoTransform = Class73.smethod_126(true, new byte[16]
          {
            (byte) 2,
            (byte) 2,
            (byte) 2,
            (byte) 2,
            (byte) 2,
            (byte) 2,
            (byte) 2,
            (byte) 2,
            (byte) 2,
            (byte) 2,
            (byte) 2,
            (byte) 2,
            (byte) 2,
            (byte) 2,
            (byte) 2,
            (byte) 2
          }, new byte[16]
          {
            (byte) 1,
            (byte) 1,
            (byte) 1,
            (byte) 1,
            (byte) 1,
            (byte) 1,
            (byte) 1,
            (byte) 1,
            (byte) 1,
            (byte) 1,
            (byte) 1,
            (byte) 1,
            (byte) 1,
            (byte) 1,
            (byte) 1,
            (byte) 1
          }))
            byte_0_1 = Class73.smethod_111(cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4));
        }
      }
      stream1_0.Close();
      return byte_0_1;
    }

    static unsafe int smethod_112(Class9 class9_0, int int_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(28);
      *(int*) voidPtr = 0;
      do
      {
        do
        {
          *(sbyte*) ((IntPtr) voidPtr + 25) = (sbyte) 1;
          *(sbyte*) ((IntPtr) voidPtr + 17) = (sbyte) (class9_0.int_23 < Class9.int_0);
          if (*(sbyte*) ((IntPtr) voidPtr + 17) != (sbyte) 0)
            goto label_15;
label_1:
          *(sbyte*) ((IntPtr) voidPtr + 19) = (sbyte) (class9_0.int_23 >= 3);
          if (*(sbyte*) ((IntPtr) voidPtr + 19) != (sbyte) 0)
          {
            class9_0.int_13 = (class9_0.int_13 << class9_0.int_16 ^ (int) class9_0.byte_2[class9_0.int_21 + 2] & (int) byte.MaxValue) & class9_0.int_15;
            *(int*) voidPtr = (int) class9_0.short_1[class9_0.int_13] & (int) ushort.MaxValue;
            class9_0.short_0[class9_0.int_21 & class9_0.int_11] = class9_0.short_1[class9_0.int_13];
            class9_0.short_1[class9_0.int_13] = (short) class9_0.int_21;
          }
          if ((*(int*) voidPtr == 0 ? 0 : ((class9_0.int_21 - *(int*) voidPtr & (int) ushort.MaxValue) <= class9_0.int_9 - Class9.int_0 ? 1 : 0)) != 0)
          {
            *(sbyte*) ((IntPtr) voidPtr + 20) = (sbyte) (class9_0.int_28 != 2);
            if (*(sbyte*) ((IntPtr) voidPtr + 20) != (sbyte) 0)
              class9_0.int_18 = Class73.smethod_149(*(int*) voidPtr, class9_0);
          }
          *(sbyte*) ((IntPtr) voidPtr + 21) = (sbyte) (class9_0.int_18 >= 3);
          if (*(sbyte*) ((IntPtr) voidPtr + 21) != (sbyte) 0)
          {
            *(int*) ((IntPtr) voidPtr + 8) = class9_0.int_21 - class9_0.int_22;
            *(int*) ((IntPtr) voidPtr + 12) = class9_0.int_18 - 3;
            *(sbyte*) ((IntPtr) voidPtr + 16) = (sbyte) Class73.smethod_64(*(int*) ((IntPtr) voidPtr + 12), class9_0, *(int*) ((IntPtr) voidPtr + 8));
            class9_0.int_23 -= class9_0.int_18;
            if ((class9_0.int_18 > class9_0.int_26 ? 0 : (class9_0.int_23 >= 3 ? 1 : 0)) != 0)
            {
              --class9_0.int_18;
              do
              {
                ++class9_0.int_21;
                class9_0.int_13 = (class9_0.int_13 << class9_0.int_16 ^ (int) class9_0.byte_2[class9_0.int_21 + 2] & (int) byte.MaxValue) & class9_0.int_15;
                *(int*) voidPtr = (int) class9_0.short_1[class9_0.int_13] & (int) ushort.MaxValue;
                class9_0.short_0[class9_0.int_21 & class9_0.int_11] = class9_0.short_1[class9_0.int_13];
                class9_0.short_1[class9_0.int_13] = (short) class9_0.int_21;
                Class9 class9 = class9_0;
                *(int*) ((IntPtr) voidPtr + 4) = class9_0.int_18 - 1;
                int num = *(int*) ((IntPtr) voidPtr + 4);
                class9.int_18 = num;
                *(sbyte*) ((IntPtr) voidPtr + 22) = (sbyte) ((uint) *(int*) ((IntPtr) voidPtr + 4) > 0U);
              }
              while (*(sbyte*) ((IntPtr) voidPtr + 22) != (sbyte) 0);
              ++class9_0.int_21;
            }
            else
            {
              class9_0.int_21 += class9_0.int_18;
              class9_0.int_18 = 0;
              class9_0.int_13 = (int) class9_0.byte_2[class9_0.int_21] & (int) byte.MaxValue;
              class9_0.int_13 = (class9_0.int_13 << class9_0.int_16 ^ (int) class9_0.byte_2[class9_0.int_21 + 1] & (int) byte.MaxValue) & class9_0.int_15;
            }
          }
          else
          {
            *(sbyte*) ((IntPtr) voidPtr + 16) = (sbyte) Class73.smethod_64((int) class9_0.byte_2[class9_0.int_21] & (int) byte.MaxValue, class9_0, 0);
            --class9_0.int_23;
            ++class9_0.int_21;
          }
          *(sbyte*) ((IntPtr) voidPtr + 23) = *(sbyte*) ((IntPtr) voidPtr + 16);
          continue;
label_15:
          Class73.smethod_91(class9_0);
          if ((class9_0.int_23 >= Class9.int_0 ? 0 : (int_0 == 0 ? 1 : 0)) == 0)
          {
            *(sbyte*) ((IntPtr) voidPtr + 18) = (sbyte) (class9_0.int_23 == 0);
            if (*(sbyte*) ((IntPtr) voidPtr + 18) == (sbyte) 0)
              goto label_1;
            else
              goto label_19;
          }
          else
            goto label_18;
        }
        while (*(sbyte*) ((IntPtr) voidPtr + 23) == (sbyte) 0);
        Class73.smethod_224(class9_0, false);
        *(sbyte*) ((IntPtr) voidPtr + 24) = (sbyte) (class9_0.class18_0.int_4 == 0);
      }
      while (*(sbyte*) ((IntPtr) voidPtr + 24) == (sbyte) 0);
      goto label_22;
label_18:
      int num1 = 0;
      goto label_23;
label_19:
      Class73.smethod_224(class9_0, int_0 == 4);
      *(sbyte*) ((IntPtr) voidPtr + 26) = (sbyte) (class9_0.class18_0.int_4 == 0);
      if (*(sbyte*) ((IntPtr) voidPtr + 26) != (sbyte) 0)
      {
        *(sbyte*) ((IntPtr) voidPtr + 27) = (sbyte) (int_0 == 4);
        num1 = *(sbyte*) ((IntPtr) voidPtr + 27) == (sbyte) 0 ? 0 : 2;
        goto label_23;
      }
      else
      {
        num1 = int_0 == 4 ? 3 : 1;
        goto label_23;
      }
label_22:
      num1 = 0;
label_23:
      return num1;
    }

    private static string smethod_113()
    {
      try
      {
        string str = "127.0.0.1";
        Class32.string_0 = str.ToString();
        Class69.string_0 = str.ToString();
        Class19.string_0 = str.ToString();
        Class71.string_0 = str.ToString();
        Class0.string_0 = str.ToString();
        Form1.form1_0.textBox_100.Text = str.ToString();
        return str;
      }
      catch (Exception ex)
      {
        Form1.smethod_0("Mail adresiniz alınamadı.Lütfen internet bağlantınızı kontrol edip programı yeniden başlatın.!!  ");
        return "";
      }
    }

    static void smethod_114(Form0 form0_0)
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form0));
      form0_0.panel_0 = new Panel();
      form0_0.tabControl_0 = new TabControl();
      form0_0.tabPage_0 = new TabPage();
      form0_0.label_112 = new Label();
      form0_0.label_101 = new Label();
      form0_0.label_102 = new Label();
      form0_0.label_4 = new Label();
      form0_0.label_5 = new Label();
      form0_0.label_6 = new Label();
      form0_0.richTextBox_0 = new RichTextBox();
      form0_0.richTextBox_1 = new RichTextBox();
      form0_0.label_2 = new Label();
      form0_0.label_3 = new Label();
      form0_0.label_0 = new Label();
      form0_0.label_1 = new Label();
      form0_0.tabPage_10 = new TabPage();
      form0_0.label_76 = new Label();
      form0_0.label_77 = new Label();
      form0_0.label_78 = new Label();
      form0_0.label_79 = new Label();
      form0_0.label_80 = new Label();
      form0_0.label_81 = new Label();
      form0_0.label_82 = new Label();
      form0_0.label_83 = new Label();
      form0_0.label_84 = new Label();
      form0_0.label_85 = new Label();
      form0_0.label_86 = new Label();
      form0_0.label_87 = new Label();
      form0_0.label_88 = new Label();
      form0_0.label_89 = new Label();
      form0_0.label_90 = new Label();
      form0_0.label_91 = new Label();
      form0_0.label_92 = new Label();
      form0_0.label_93 = new Label();
      form0_0.label_94 = new Label();
      form0_0.label_95 = new Label();
      form0_0.label_96 = new Label();
      form0_0.label_97 = new Label();
      form0_0.label_98 = new Label();
      form0_0.label_99 = new Label();
      form0_0.label_100 = new Label();
      form0_0.panel_10 = new Panel();
      form0_0.panel_11 = new Panel();
      form0_0.tabPage_1 = new TabPage();
      form0_0.label_103 = new Label();
      form0_0.label_104 = new Label();
      form0_0.label_16 = new Label();
      form0_0.label_17 = new Label();
      form0_0.label_18 = new Label();
      form0_0.label_19 = new Label();
      form0_0.label_20 = new Label();
      form0_0.label_21 = new Label();
      form0_0.label_22 = new Label();
      form0_0.label_7 = new Label();
      form0_0.label_8 = new Label();
      form0_0.label_9 = new Label();
      form0_0.label_10 = new Label();
      form0_0.label_11 = new Label();
      form0_0.label_12 = new Label();
      form0_0.label_13 = new Label();
      form0_0.label_14 = new Label();
      form0_0.label_15 = new Label();
      form0_0.panel_1 = new Panel();
      form0_0.tabPage_2 = new TabPage();
      form0_0.label_105 = new Label();
      form0_0.label_106 = new Label();
      form0_0.label_23 = new Label();
      form0_0.label_24 = new Label();
      form0_0.panel_2 = new Panel();
      form0_0.tabPage_3 = new TabPage();
      form0_0.label_107 = new Label();
      form0_0.label_108 = new Label();
      form0_0.label_109 = new Label();
      form0_0.label_110 = new Label();
      form0_0.panel_3 = new Panel();
      form0_0.tabPage_4 = new TabPage();
      form0_0.label_111 = new Label();
      form0_0.label_25 = new Label();
      form0_0.label_26 = new Label();
      form0_0.label_27 = new Label();
      form0_0.label_28 = new Label();
      form0_0.label_29 = new Label();
      form0_0.label_30 = new Label();
      form0_0.label_31 = new Label();
      form0_0.label_32 = new Label();
      form0_0.label_33 = new Label();
      form0_0.label_34 = new Label();
      form0_0.label_35 = new Label();
      form0_0.panel_4 = new Panel();
      form0_0.tabPage_5 = new TabPage();
      form0_0.label_36 = new Label();
      form0_0.label_37 = new Label();
      form0_0.label_38 = new Label();
      form0_0.label_39 = new Label();
      form0_0.label_40 = new Label();
      form0_0.label_41 = new Label();
      form0_0.panel_5 = new Panel();
      form0_0.tabPage_6 = new TabPage();
      form0_0.label_42 = new Label();
      form0_0.label_43 = new Label();
      form0_0.label_44 = new Label();
      form0_0.label_45 = new Label();
      form0_0.label_46 = new Label();
      form0_0.label_47 = new Label();
      form0_0.panel_6 = new Panel();
      form0_0.tabPage_7 = new TabPage();
      form0_0.label_48 = new Label();
      form0_0.label_49 = new Label();
      form0_0.label_50 = new Label();
      form0_0.label_51 = new Label();
      form0_0.label_52 = new Label();
      form0_0.label_53 = new Label();
      form0_0.panel_7 = new Panel();
      form0_0.tabPage_8 = new TabPage();
      form0_0.label_54 = new Label();
      form0_0.label_55 = new Label();
      form0_0.label_56 = new Label();
      form0_0.label_57 = new Label();
      form0_0.label_58 = new Label();
      form0_0.label_59 = new Label();
      form0_0.label_60 = new Label();
      form0_0.label_61 = new Label();
      form0_0.label_62 = new Label();
      form0_0.label_63 = new Label();
      form0_0.label_64 = new Label();
      form0_0.label_65 = new Label();
      form0_0.label_66 = new Label();
      form0_0.label_67 = new Label();
      form0_0.panel_8 = new Panel();
      form0_0.tabPage_9 = new TabPage();
      form0_0.label_68 = new Label();
      form0_0.label_69 = new Label();
      form0_0.label_70 = new Label();
      form0_0.label_71 = new Label();
      form0_0.label_72 = new Label();
      form0_0.label_73 = new Label();
      form0_0.label_74 = new Label();
      form0_0.label_75 = new Label();
      form0_0.panel_9 = new Panel();
      form0_0.tabControl_0.SuspendLayout();
      form0_0.tabPage_0.SuspendLayout();
      form0_0.tabPage_10.SuspendLayout();
      form0_0.tabPage_1.SuspendLayout();
      form0_0.tabPage_2.SuspendLayout();
      form0_0.tabPage_3.SuspendLayout();
      form0_0.tabPage_4.SuspendLayout();
      form0_0.tabPage_5.SuspendLayout();
      form0_0.tabPage_6.SuspendLayout();
      form0_0.tabPage_7.SuspendLayout();
      form0_0.tabPage_8.SuspendLayout();
      form0_0.tabPage_9.SuspendLayout();
      form0_0.SuspendLayout();
      form0_0.panel_0.Location = new Point(1, 2);
      form0_0.panel_0.Name = "panel1";
      form0_0.panel_0.Size = new Size(678, 403);
      form0_0.panel_0.TabIndex = 2;
      form0_0.tabControl_0.Controls.Add((Control) form0_0.tabPage_0);
      form0_0.tabControl_0.Controls.Add((Control) form0_0.tabPage_10);
      form0_0.tabControl_0.Controls.Add((Control) form0_0.tabPage_1);
      form0_0.tabControl_0.Controls.Add((Control) form0_0.tabPage_2);
      form0_0.tabControl_0.Controls.Add((Control) form0_0.tabPage_3);
      form0_0.tabControl_0.Controls.Add((Control) form0_0.tabPage_4);
      form0_0.tabControl_0.Controls.Add((Control) form0_0.tabPage_5);
      form0_0.tabControl_0.Controls.Add((Control) form0_0.tabPage_6);
      form0_0.tabControl_0.Controls.Add((Control) form0_0.tabPage_7);
      form0_0.tabControl_0.Controls.Add((Control) form0_0.tabPage_8);
      form0_0.tabControl_0.Controls.Add((Control) form0_0.tabPage_9);
      form0_0.tabControl_0.Location = new Point(1, 2);
      form0_0.tabControl_0.Name = "tabControl1";
      form0_0.tabControl_0.SelectedIndex = 0;
      form0_0.tabControl_0.Size = new Size(819, 780);
      form0_0.tabControl_0.TabIndex = 0;
      form0_0.tabControl_0.SelectedIndexChanged += new EventHandler(form0_0.method_1);
      form0_0.tabPage_0.BackColor = Color.Black;
      form0_0.tabPage_0.Controls.Add((Control) form0_0.label_112);
      form0_0.tabPage_0.Controls.Add((Control) form0_0.label_101);
      form0_0.tabPage_0.Controls.Add((Control) form0_0.label_102);
      form0_0.tabPage_0.Controls.Add((Control) form0_0.label_4);
      form0_0.tabPage_0.Controls.Add((Control) form0_0.label_5);
      form0_0.tabPage_0.Controls.Add((Control) form0_0.label_6);
      form0_0.tabPage_0.Controls.Add((Control) form0_0.richTextBox_0);
      form0_0.tabPage_0.Controls.Add((Control) form0_0.richTextBox_1);
      form0_0.tabPage_0.Controls.Add((Control) form0_0.label_2);
      form0_0.tabPage_0.Controls.Add((Control) form0_0.label_3);
      form0_0.tabPage_0.Controls.Add((Control) form0_0.label_0);
      form0_0.tabPage_0.Controls.Add((Control) form0_0.label_1);
      form0_0.tabPage_0.Location = new Point(4, 22);
      form0_0.tabPage_0.Name = "tabPage1";
      form0_0.tabPage_0.Padding = new Padding(3);
      form0_0.tabPage_0.Size = new Size(811, 754);
      form0_0.tabPage_0.TabIndex = 0;
      form0_0.tabPage_0.Text = "KURULUM";
      form0_0.label_112.AutoSize = true;
      form0_0.label_112.ForeColor = SystemColors.ButtonFace;
      form0_0.label_112.Location = new Point(44, -15);
      form0_0.label_112.Name = "label32";
      form0_0.label_112.Size = new Size(733, 104);
      form0_0.label_112.TabIndex = 28;
      form0_0.label_112.Text = componentResourceManager.GetString("label32.Text");
      form0_0.label_112.Visible = false;
      form0_0.label_101.AutoSize = true;
      form0_0.label_101.ForeColor = Color.White;
      form0_0.label_101.Location = new Point(44, 644);
      form0_0.label_101.Name = "label122";
      form0_0.label_101.Size = new Size(723, 39);
      form0_0.label_101.TabIndex = 27;
      form0_0.label_101.Text = componentResourceManager.GetString("label122.Text");
      form0_0.label_102.AutoSize = true;
      form0_0.label_102.ForeColor = Color.Red;
      form0_0.label_102.Location = new Point(353, 620);
      form0_0.label_102.Name = "label128";
      form0_0.label_102.Size = new Size(76, 13);
      form0_0.label_102.TabIndex = 26;
      form0_0.label_102.Text = "D İ K K A T !!!!";
      form0_0.label_4.AutoSize = true;
      form0_0.label_4.BackColor = Color.Black;
      form0_0.label_4.ForeColor = Color.Yellow;
      form0_0.label_4.Location = new Point(353, 111);
      form0_0.label_4.Name = "label7";
      form0_0.label_4.Size = new Size(43, 26);
      form0_0.label_4.TabIndex = 10;
      form0_0.label_4.Text = "ADIM 2\r\n    \\/";
      form0_0.label_5.AutoSize = true;
      form0_0.label_5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      form0_0.label_5.ForeColor = Color.White;
      form0_0.label_5.Location = new Point(143, 60);
      form0_0.label_5.Name = "label6";
      form0_0.label_5.Size = new Size(502, 39);
      form0_0.label_5.TabIndex = 9;
      form0_0.label_5.Text = componentResourceManager.GetString("label6.Text");
      form0_0.label_6.AutoSize = true;
      form0_0.label_6.BackColor = Color.Black;
      form0_0.label_6.ForeColor = Color.Yellow;
      form0_0.label_6.Location = new Point(76, 71);
      form0_0.label_6.Name = "label5";
      form0_0.label_6.Size = new Size(61, 13);
      form0_0.label_6.TabIndex = 8;
      form0_0.label_6.Text = "ADIM 1 => ";
      form0_0.richTextBox_0.Location = new Point(69, 452);
      form0_0.richTextBox_0.Name = "richTextBox2";
      form0_0.richTextBox_0.Size = new Size(662, 154);
      form0_0.richTextBox_0.TabIndex = 7;
      form0_0.richTextBox_0.Text = componentResourceManager.GetString("richTextBox2.Text");
      form0_0.richTextBox_1.Location = new Point(69, 224);
      form0_0.richTextBox_1.Name = "richTextBox1";
      form0_0.richTextBox_1.Size = new Size(661, 209);
      form0_0.richTextBox_1.TabIndex = 6;
      form0_0.richTextBox_1.Text = componentResourceManager.GetString("richTextBox1.Text");
      form0_0.label_2.AutoSize = true;
      form0_0.label_2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      form0_0.label_2.ForeColor = Color.White;
      form0_0.label_2.Location = new Point(65, 137);
      form0_0.label_2.Name = "label4";
      form0_0.label_2.Size = new Size(678, 39);
      form0_0.label_2.TabIndex = 5;
      form0_0.label_2.Text = componentResourceManager.GetString("label4.Text");
      form0_0.label_3.AutoSize = true;
      form0_0.label_3.ForeColor = Color.Yellow;
      form0_0.label_3.Location = new Point(319, 185);
      form0_0.label_3.Name = "label3";
      form0_0.label_3.Size = new Size(124, 13);
      form0_0.label_3.TabIndex = 4;
      form0_0.label_3.Text = "Prsedürlere eklenecekler";
      form0_0.label_0.AutoSize = true;
      form0_0.label_0.ForeColor = Color.White;
      form0_0.label_0.Location = new Point(345, 436);
      form0_0.label_0.Name = "label2";
      form0_0.label_0.Size = new Size(70, 13);
      form0_0.label_0.TabIndex = 3;
      form0_0.label_0.Text = "_AddLogItem";
      form0_0.label_1.AutoSize = true;
      form0_0.label_1.ForeColor = Color.White;
      form0_0.label_1.Location = new Point(343, 208);
      form0_0.label_1.Name = "label1";
      form0_0.label_1.Size = new Size(72, 13);
      form0_0.label_1.TabIndex = 1;
      form0_0.label_1.Text = "_AddLogChar";
      form0_0.tabPage_10.BackColor = Color.Black;
      form0_0.tabPage_10.Controls.Add((Control) form0_0.label_76);
      form0_0.tabPage_10.Controls.Add((Control) form0_0.label_77);
      form0_0.tabPage_10.Controls.Add((Control) form0_0.label_78);
      form0_0.tabPage_10.Controls.Add((Control) form0_0.label_79);
      form0_0.tabPage_10.Controls.Add((Control) form0_0.label_80);
      form0_0.tabPage_10.Controls.Add((Control) form0_0.label_81);
      form0_0.tabPage_10.Controls.Add((Control) form0_0.label_82);
      form0_0.tabPage_10.Controls.Add((Control) form0_0.label_83);
      form0_0.tabPage_10.Controls.Add((Control) form0_0.label_84);
      form0_0.tabPage_10.Controls.Add((Control) form0_0.label_85);
      form0_0.tabPage_10.Controls.Add((Control) form0_0.label_86);
      form0_0.tabPage_10.Controls.Add((Control) form0_0.label_87);
      form0_0.tabPage_10.Controls.Add((Control) form0_0.label_88);
      form0_0.tabPage_10.Controls.Add((Control) form0_0.label_89);
      form0_0.tabPage_10.Controls.Add((Control) form0_0.label_90);
      form0_0.tabPage_10.Controls.Add((Control) form0_0.label_91);
      form0_0.tabPage_10.Controls.Add((Control) form0_0.label_92);
      form0_0.tabPage_10.Controls.Add((Control) form0_0.label_93);
      form0_0.tabPage_10.Controls.Add((Control) form0_0.label_94);
      form0_0.tabPage_10.Controls.Add((Control) form0_0.label_95);
      form0_0.tabPage_10.Controls.Add((Control) form0_0.label_96);
      form0_0.tabPage_10.Controls.Add((Control) form0_0.label_97);
      form0_0.tabPage_10.Controls.Add((Control) form0_0.label_98);
      form0_0.tabPage_10.Controls.Add((Control) form0_0.label_99);
      form0_0.tabPage_10.Controls.Add((Control) form0_0.label_100);
      form0_0.tabPage_10.Controls.Add((Control) form0_0.panel_10);
      form0_0.tabPage_10.Controls.Add((Control) form0_0.panel_11);
      form0_0.tabPage_10.Location = new Point(4, 22);
      form0_0.tabPage_10.Name = "tabPage11";
      form0_0.tabPage_10.Padding = new Padding(3);
      form0_0.tabPage_10.Size = new Size(811, 754);
      form0_0.tabPage_10.TabIndex = 10;
      form0_0.tabPage_10.Text = "SqlServer Ayarları";
      form0_0.label_76.AutoSize = true;
      form0_0.label_76.ForeColor = Color.White;
      form0_0.label_76.Location = new Point(106, 677);
      form0_0.label_76.Name = "label102";
      form0_0.label_76.Size = new Size(631, 13);
      form0_0.label_76.TabIndex = 84;
      form0_0.label_76.Text = "KURULUM sekmesinde _AddLogChar ve _AddLogItem prosedürlerine eklemeniz için verilen kodlarda da aynı değişiklikleri uygulayın.";
      form0_0.label_77.AutoSize = true;
      form0_0.label_77.ForeColor = Color.White;
      form0_0.label_77.Location = new Point(56, 643);
      form0_0.label_77.Name = "label126";
      form0_0.label_77.Size = new Size(619, 13);
      form0_0.label_77.TabIndex = 83;
      form0_0.label_77.Text = "Bu prosedürlerde sizin database isimlerinden farklı olanları kendinize göre ayarların ve F5 tuşu ile execute ederek kaydedip kapatın.";
      form0_0.label_78.AutoSize = true;
      form0_0.label_78.ForeColor = Color.Red;
      form0_0.label_78.Location = new Point(18, 677);
      form0_0.label_78.Name = "label127";
      form0_0.label_78.Size = new Size(82, 13);
      form0_0.label_78.TabIndex = 82;
      form0_0.label_78.Text = "D İ K K A T ! ! ! ";
      form0_0.label_79.AutoSize = true;
      form0_0.label_79.ForeColor = Color.Orange;
      form0_0.label_79.Location = new Point(610, 412);
      form0_0.label_79.Name = "label125";
      form0_0.label_79.Size = new Size(110, 13);
      form0_0.label_79.TabIndex = 81;
      form0_0.label_79.Text = "YENİDEN BAŞLATIN";
      form0_0.label_80.AutoSize = true;
      form0_0.label_80.ForeColor = Color.White;
      form0_0.label_80.Location = new Point(55, 611);
      form0_0.label_80.Name = "label124";
      form0_0.label_80.Size = new Size(743, 13);
      form0_0.label_80.TabIndex = 80;
      form0_0.label_80.Text = "Sql programını açın ve My_EventBot => Programmability => Stored Procedures  bölümünden sırasıyla prosedürlere sağ tık Modify 'ye diyerek prosedürleri açın.";
      form0_0.label_81.AutoSize = true;
      form0_0.label_81.ForeColor = Color.Red;
      form0_0.label_81.Location = new Point(18, 643);
      form0_0.label_81.Name = "label123";
      form0_0.label_81.Size = new Size(31, 13);
      form0_0.label_81.TabIndex = 79;
      form0_0.label_81.Text = "2 => ";
      form0_0.label_82.AutoSize = true;
      form0_0.label_82.ForeColor = Color.White;
      form0_0.label_82.Location = new Point(288, 493);
      form0_0.label_82.Name = "label121";
      form0_0.label_82.Size = new Size(237, 91);
      form0_0.label_82.TabIndex = 77;
      form0_0.label_82.Text = "Eğer Database isimleriniz \r\n\r\nSRO_VT_SHARD\r\nSRO_VT_ACCOUNT\r\nSRO_VT_LOG\r\n\r\nBunlardan farklı ise aşşağıdaki adımları uygulayın.";
      form0_0.label_83.AutoSize = true;
      form0_0.label_83.ForeColor = Color.Red;
      form0_0.label_83.Location = new Point(297, 468);
      form0_0.label_83.Name = "label120";
      form0_0.label_83.Size = new Size(103, 13);
      form0_0.label_83.TabIndex = 76;
      form0_0.label_83.Text = "D  İ  K  K  A  T  !  !  !";
      form0_0.label_84.AutoSize = true;
      form0_0.label_84.ForeColor = Color.Orange;
      form0_0.label_84.Location = new Point(310, 412);
      form0_0.label_84.Name = "label119";
      form0_0.label_84.Size = new Size(90, 13);
      form0_0.label_84.TabIndex = 75;
      form0_0.label_84.Text = "\"Ayarları Kaydet \"";
      form0_0.label_85.AutoSize = true;
      form0_0.label_85.ForeColor = Color.Red;
      form0_0.label_85.Location = new Point(394, 6);
      form0_0.label_85.Name = "label117";
      form0_0.label_85.Size = new Size(34, 13);
      form0_0.label_85.TabIndex = 73;
      form0_0.label_85.Text = "===> ";
      form0_0.label_86.AutoSize = true;
      form0_0.label_86.ForeColor = Color.Red;
      form0_0.label_86.Location = new Point(393, 34);
      form0_0.label_86.Name = "label118";
      form0_0.label_86.Size = new Size(34, 13);
      form0_0.label_86.TabIndex = 74;
      form0_0.label_86.Text = "===> ";
      form0_0.label_87.AutoSize = true;
      form0_0.label_87.ForeColor = Color.Red;
      form0_0.label_87.Location = new Point(394, 274);
      form0_0.label_87.Name = "label114";
      form0_0.label_87.Size = new Size(34, 13);
      form0_0.label_87.TabIndex = 72;
      form0_0.label_87.Text = "===> ";
      form0_0.label_88.AutoSize = true;
      form0_0.label_88.ForeColor = Color.Red;
      form0_0.label_88.Location = new Point(394, 304);
      form0_0.label_88.Name = "label115";
      form0_0.label_88.Size = new Size(34, 13);
      form0_0.label_88.TabIndex = 71;
      form0_0.label_88.Text = "===> ";
      form0_0.label_89.AutoSize = true;
      form0_0.label_89.ForeColor = Color.Red;
      form0_0.label_89.Location = new Point(394, 242);
      form0_0.label_89.Name = "label116";
      form0_0.label_89.Size = new Size(34, 13);
      form0_0.label_89.TabIndex = 70;
      form0_0.label_89.Text = "===> ";
      form0_0.label_90.AutoSize = true;
      form0_0.label_90.ForeColor = Color.Red;
      form0_0.label_90.Location = new Point(393, 186);
      form0_0.label_90.Name = "label111";
      form0_0.label_90.Size = new Size(34, 13);
      form0_0.label_90.TabIndex = 69;
      form0_0.label_90.Text = "===> ";
      form0_0.label_91.AutoSize = true;
      form0_0.label_91.ForeColor = Color.Red;
      form0_0.label_91.Location = new Point(393, 216);
      form0_0.label_91.Name = "label112";
      form0_0.label_91.Size = new Size(34, 13);
      form0_0.label_91.TabIndex = 68;
      form0_0.label_91.Text = "===> ";
      form0_0.label_92.AutoSize = true;
      form0_0.label_92.ForeColor = Color.Red;
      form0_0.label_92.Location = new Point(393, 154);
      form0_0.label_92.Name = "label113";
      form0_0.label_92.Size = new Size(34, 13);
      form0_0.label_92.TabIndex = 67;
      form0_0.label_92.Text = "===> ";
      form0_0.label_93.AutoSize = true;
      form0_0.label_93.ForeColor = Color.Red;
      form0_0.label_93.Location = new Point(393, 97);
      form0_0.label_93.Name = "label110";
      form0_0.label_93.Size = new Size(34, 13);
      form0_0.label_93.TabIndex = 66;
      form0_0.label_93.Text = "===> ";
      form0_0.label_94.AutoSize = true;
      form0_0.label_94.ForeColor = Color.Red;
      form0_0.label_94.Location = new Point(393, (int) sbyte.MaxValue);
      form0_0.label_94.Name = "label109";
      form0_0.label_94.Size = new Size(34, 13);
      form0_0.label_94.TabIndex = 65;
      form0_0.label_94.Text = "===> ";
      form0_0.label_95.AutoSize = true;
      form0_0.label_95.ForeColor = Color.Red;
      form0_0.label_95.Location = new Point(393, 65);
      form0_0.label_95.Name = "label108";
      form0_0.label_95.Size = new Size(34, 13);
      form0_0.label_95.TabIndex = 64;
      form0_0.label_95.Text = "===> ";
      form0_0.label_96.AutoSize = true;
      form0_0.label_96.ForeColor = Color.White;
      form0_0.label_96.Location = new Point(56, 412);
      form0_0.label_96.Name = "label103";
      form0_0.label_96.Size = new Size(560, 13);
      form0_0.label_96.TabIndex = 62;
      form0_0.label_96.Text = "Bu alanı kendinize göre eksiksiz doldurduktan sonra                                   butonu ile ayarlarınızı kaydedin ve programı ";
      form0_0.label_97.AutoSize = true;
      form0_0.label_97.ForeColor = Color.White;
      form0_0.label_97.Location = new Point(56, 368);
      form0_0.label_97.Name = "label104";
      form0_0.label_97.Size = new Size(497, 13);
      form0_0.label_97.TabIndex = 61;
      form0_0.label_97.Text = "Kırmızı alan içindeki bölgeye Mause ile geldiğinizde SQL SERVER  bağlantı ayarları penceresi açılacaktır.";
      form0_0.label_98.AutoSize = true;
      form0_0.label_98.ForeColor = Color.Red;
      form0_0.label_98.Location = new Point(18, 611);
      form0_0.label_98.Name = "label105";
      form0_0.label_98.Size = new Size(31, 13);
      form0_0.label_98.TabIndex = 60;
      form0_0.label_98.Text = "1 => ";
      form0_0.label_99.AutoSize = true;
      form0_0.label_99.ForeColor = Color.Red;
      form0_0.label_99.Location = new Point(19, 412);
      form0_0.label_99.Name = "label106";
      form0_0.label_99.Size = new Size(31, 13);
      form0_0.label_99.TabIndex = 59;
      form0_0.label_99.Text = "2 => ";
      form0_0.label_100.AutoSize = true;
      form0_0.label_100.ForeColor = Color.Red;
      form0_0.label_100.Location = new Point(19, 368);
      form0_0.label_100.Name = "label107";
      form0_0.label_100.Size = new Size(31, 13);
      form0_0.label_100.TabIndex = 58;
      form0_0.label_100.Text = "1 => ";
      form0_0.panel_10.BackgroundImage = (Image) componentResourceManager.GetObject("panel14.BackgroundImage");
      form0_0.panel_10.Location = new Point(434, 3);
      form0_0.panel_10.Name = "panel14";
      form0_0.panel_10.Size = new Size(371, 319);
      form0_0.panel_10.TabIndex = 10;
      form0_0.panel_11.BackgroundImage = (Image) componentResourceManager.GetObject("panel13.BackgroundImage");
      form0_0.panel_11.Location = new Point(8, 6);
      form0_0.panel_11.Name = "panel13";
      form0_0.panel_11.Size = new Size(379, 319);
      form0_0.panel_11.TabIndex = 9;
      form0_0.tabPage_1.BackColor = Color.Black;
      form0_0.tabPage_1.Controls.Add((Control) form0_0.label_103);
      form0_0.tabPage_1.Controls.Add((Control) form0_0.label_104);
      form0_0.tabPage_1.Controls.Add((Control) form0_0.label_16);
      form0_0.tabPage_1.Controls.Add((Control) form0_0.label_17);
      form0_0.tabPage_1.Controls.Add((Control) form0_0.label_18);
      form0_0.tabPage_1.Controls.Add((Control) form0_0.label_19);
      form0_0.tabPage_1.Controls.Add((Control) form0_0.label_20);
      form0_0.tabPage_1.Controls.Add((Control) form0_0.label_21);
      form0_0.tabPage_1.Controls.Add((Control) form0_0.label_22);
      form0_0.tabPage_1.Controls.Add((Control) form0_0.label_7);
      form0_0.tabPage_1.Controls.Add((Control) form0_0.label_8);
      form0_0.tabPage_1.Controls.Add((Control) form0_0.label_9);
      form0_0.tabPage_1.Controls.Add((Control) form0_0.label_10);
      form0_0.tabPage_1.Controls.Add((Control) form0_0.label_11);
      form0_0.tabPage_1.Controls.Add((Control) form0_0.label_12);
      form0_0.tabPage_1.Controls.Add((Control) form0_0.label_13);
      form0_0.tabPage_1.Controls.Add((Control) form0_0.label_14);
      form0_0.tabPage_1.Controls.Add((Control) form0_0.label_15);
      form0_0.tabPage_1.Controls.Add((Control) form0_0.panel_1);
      form0_0.tabPage_1.Location = new Point(4, 22);
      form0_0.tabPage_1.Name = "tabPage2";
      form0_0.tabPage_1.Padding = new Padding(3);
      form0_0.tabPage_1.Size = new Size(811, 754);
      form0_0.tabPage_1.TabIndex = 1;
      form0_0.tabPage_1.Text = "Uniq Kes";
      form0_0.label_103.AutoSize = true;
      form0_0.label_103.ForeColor = Color.White;
      form0_0.label_103.Location = new Point(54, 515);
      form0_0.label_103.Name = "label130";
      form0_0.label_103.Size = new Size(285, 13);
      form0_0.label_103.TabIndex = 28;
      form0_0.label_103.Text = "Etkinlikte kazananlara verilecek ödül / ler burada belirlenir. ";
      form0_0.label_104.AutoSize = true;
      form0_0.label_104.ForeColor = Color.White;
      form0_0.label_104.Location = new Point(54, 539);
      form0_0.label_104.Name = "label19";
      form0_0.label_104.Size = new Size(194, 13);
      form0_0.label_104.TabIndex = 26;
      form0_0.label_104.Text = "veritabanınızdaki tüm unique'leri  listeler.";
      form0_0.label_16.AutoSize = true;
      form0_0.label_16.ForeColor = Color.White;
      form0_0.label_16.Location = new Point(571, 560);
      form0_0.label_16.Name = "label31";
      form0_0.label_16.Size = new Size(206, 13);
      form0_0.label_16.TabIndex = 25;
      form0_0.label_16.Text = "1.  2.  ve 3. adımlar her etkinlik için aynıdır.";
      form0_0.label_17.AutoSize = true;
      form0_0.label_17.ForeColor = Color.Red;
      form0_0.label_17.Location = new Point(663, 538);
      form0_0.label_17.Name = "label30";
      form0_0.label_17.Size = new Size(36, 13);
      form0_0.label_17.TabIndex = 24;
      form0_0.label_17.Text = "N O T";
      form0_0.label_18.AutoSize = true;
      form0_0.label_18.ForeColor = Color.White;
      form0_0.label_18.Location = new Point(54, 467);
      form0_0.label_18.Name = "label24";
      form0_0.label_18.Size = new Size(489, 13);
      form0_0.label_18.TabIndex = 21;
      form0_0.label_18.Text = "Etkinliğin yapılacagı harita buradan belirlenir. (Belirlediğiniz haritada bölgeleri bot kendisi rastgele seçer.)";
      form0_0.label_19.AutoSize = true;
      form0_0.label_19.ForeColor = Color.White;
      form0_0.label_19.Location = new Point(54, 491);
      form0_0.label_19.Name = "label26";
      form0_0.label_19.Size = new Size(157, 13);
      form0_0.label_19.TabIndex = 19;
      form0_0.label_19.Text = "Burada etkinlik zamanı belirlenir.";
      form0_0.label_20.AutoSize = true;
      form0_0.label_20.ForeColor = Color.White;
      form0_0.label_20.Location = new Point(54, 635);
      form0_0.label_20.Name = "label22";
      form0_0.label_20.Size = new Size(377, 13);
      form0_0.label_20.TabIndex = 17;
      form0_0.label_20.Text = "Etkinlikte her unique'den önce spawn edilecek zerk uniq ayarları burada yapılır.";
      form0_0.label_21.AutoSize = true;
      form0_0.label_21.ForeColor = Color.Red;
      form0_0.label_21.Location = new Point(17, 635);
      form0_0.label_21.Name = "label23";
      form0_0.label_21.Size = new Size(31, 13);
      form0_0.label_21.TabIndex = 16;
      form0_0.label_21.Text = "8 => ";
      form0_0.label_22.AutoSize = true;
      form0_0.label_22.ForeColor = Color.Red;
      form0_0.label_22.Location = new Point(17, 467);
      form0_0.label_22.Name = "label21";
      form0_0.label_22.Size = new Size(31, 13);
      form0_0.label_22.TabIndex = 14;
      form0_0.label_22.Text = "1 => ";
      form0_0.label_7.AutoSize = true;
      form0_0.label_7.ForeColor = Color.White;
      form0_0.label_7.Location = new Point(54, 611);
      form0_0.label_7.Name = "label18";
      form0_0.label_7.Size = new Size(434, 13);
      form0_0.label_7.TabIndex = 13;
      form0_0.label_7.Text = "Etkinlikte kullanılacak unique işlemlerini yapmaya yarar ( ekleme, silme, sıralama değiştirme )";
      form0_0.label_8.AutoSize = true;
      form0_0.label_8.ForeColor = Color.White;
      form0_0.label_8.Location = new Point(54, 584);
      form0_0.label_8.Name = "label16";
      form0_0.label_8.Size = new Size(236, 13);
      form0_0.label_8.TabIndex = 11;
      form0_0.label_8.Text = "Etkinlikte kullanılacak unique'ler burada listelenir.";
      form0_0.label_9.AutoSize = true;
      form0_0.label_9.ForeColor = Color.White;
      form0_0.label_9.Location = new Point(54, 560);
      form0_0.label_9.Name = "label15";
      form0_0.label_9.Size = new Size(230, 13);
      form0_0.label_9.TabIndex = 9;
      form0_0.label_9.Text = "Veritanından çekilen unique'ler burada listelenir.";
      form0_0.label_10.AutoSize = true;
      form0_0.label_10.ForeColor = Color.Red;
      form0_0.label_10.Location = new Point(17, 584);
      form0_0.label_10.Name = "label12";
      form0_0.label_10.Size = new Size(31, 13);
      form0_0.label_10.TabIndex = 7;
      form0_0.label_10.Text = "6 => ";
      form0_0.label_11.AutoSize = true;
      form0_0.label_11.ForeColor = Color.Red;
      form0_0.label_11.Location = new Point(17, 560);
      form0_0.label_11.Name = "label13";
      form0_0.label_11.Size = new Size(31, 13);
      form0_0.label_11.TabIndex = 6;
      form0_0.label_11.Text = "5 => ";
      form0_0.label_12.AutoSize = true;
      form0_0.label_12.ForeColor = Color.Red;
      form0_0.label_12.Location = new Point(17, 539);
      form0_0.label_12.Name = "label10";
      form0_0.label_12.Size = new Size(31, 13);
      form0_0.label_12.TabIndex = 5;
      form0_0.label_12.Text = "4 => ";
      form0_0.label_13.AutoSize = true;
      form0_0.label_13.ForeColor = Color.Red;
      form0_0.label_13.Location = new Point(17, 515);
      form0_0.label_13.Name = "label11";
      form0_0.label_13.Size = new Size(31, 13);
      form0_0.label_13.TabIndex = 4;
      form0_0.label_13.Text = "3 => ";
      form0_0.label_14.AutoSize = true;
      form0_0.label_14.ForeColor = Color.Red;
      form0_0.label_14.Location = new Point(17, 491);
      form0_0.label_14.Name = "label9";
      form0_0.label_14.Size = new Size(31, 13);
      form0_0.label_14.TabIndex = 3;
      form0_0.label_14.Text = "2 => ";
      form0_0.label_15.AutoSize = true;
      form0_0.label_15.ForeColor = Color.Red;
      form0_0.label_15.Location = new Point(17, 611);
      form0_0.label_15.Name = "label8";
      form0_0.label_15.Size = new Size(31, 13);
      form0_0.label_15.TabIndex = 2;
      form0_0.label_15.Text = "7 => ";
      form0_0.panel_1.BackgroundImage = (Image) componentResourceManager.GetObject("panel2.BackgroundImage");
      form0_0.panel_1.BackgroundImageLayout = ImageLayout.Stretch;
      form0_0.panel_1.Location = new Point(0, 6);
      form0_0.panel_1.Name = "panel2";
      form0_0.panel_1.Size = new Size(809, 447);
      form0_0.panel_1.TabIndex = 0;
      form0_0.tabPage_2.BackColor = Color.Black;
      form0_0.tabPage_2.Controls.Add((Control) form0_0.label_105);
      form0_0.tabPage_2.Controls.Add((Control) form0_0.label_106);
      form0_0.tabPage_2.Controls.Add((Control) form0_0.label_23);
      form0_0.tabPage_2.Controls.Add((Control) form0_0.label_24);
      form0_0.tabPage_2.Controls.Add((Control) form0_0.panel_2);
      form0_0.tabPage_2.Location = new Point(4, 22);
      form0_0.tabPage_2.Name = "tabPage3";
      form0_0.tabPage_2.Padding = new Padding(3);
      form0_0.tabPage_2.Size = new Size(811, 754);
      form0_0.tabPage_2.TabIndex = 2;
      form0_0.tabPage_2.Text = "Kayıp Uniq";
      form0_0.label_105.AutoSize = true;
      form0_0.label_105.ForeColor = Color.White;
      form0_0.label_105.Location = new Point(118, 607);
      form0_0.label_105.Name = "label17";
      form0_0.label_105.Size = new Size(615, 13);
      form0_0.label_105.TabIndex = 16;
      form0_0.label_105.Text = "Bu spawn edilen unique'ler ilk 10 dk içinde kesildiğinde ödül verilir. 10 dakika sonra event biter ve bot notice ile oyunculara bildirir.";
      form0_0.label_106.AutoSize = true;
      form0_0.label_106.ForeColor = Color.White;
      form0_0.label_106.Location = new Point(131, 574);
      form0_0.label_106.Name = "label14";
      form0_0.label_106.Size = new Size(580, 13);
      form0_0.label_106.TabIndex = 15;
      form0_0.label_106.Text = "Bot seçtiğiniz haritadan rastgele bi bölge seçer ve bu bölgeye atanmış 11 adet koordinatdan 5 tanesine uniqu spawn eder.";
      form0_0.label_23.AutoSize = true;
      form0_0.label_23.ForeColor = Color.White;
      form0_0.label_23.Location = new Point(192, 541);
      form0_0.label_23.Name = "label34";
      form0_0.label_23.Size = new Size(400, 13);
      form0_0.label_23.TabIndex = 14;
      form0_0.label_23.Text = "Bu etkinlik için etkinlik zamanı ve etkinlik haritası seçip ödülleri ayarlamanız yeterlidir.";
      form0_0.label_24.AutoSize = true;
      form0_0.label_24.ForeColor = Color.Red;
      form0_0.label_24.Location = new Point(359, 516);
      form0_0.label_24.Name = "label37";
      form0_0.label_24.Size = new Size(82, 13);
      form0_0.label_24.TabIndex = 11;
      form0_0.label_24.Text = "D  İ  K  K  A  T  ";
      form0_0.panel_2.BackgroundImage = (Image) componentResourceManager.GetObject("panel3.BackgroundImage");
      form0_0.panel_2.Location = new Point(3, 3);
      form0_0.panel_2.Name = "panel3";
      form0_0.panel_2.Size = new Size(805, 452);
      form0_0.panel_2.TabIndex = 1;
      form0_0.panel_2.Paint += new PaintEventHandler(form0_0.method_2);
      form0_0.tabPage_3.BackColor = Color.Black;
      form0_0.tabPage_3.Controls.Add((Control) form0_0.label_107);
      form0_0.tabPage_3.Controls.Add((Control) form0_0.label_108);
      form0_0.tabPage_3.Controls.Add((Control) form0_0.label_109);
      form0_0.tabPage_3.Controls.Add((Control) form0_0.label_110);
      form0_0.tabPage_3.Controls.Add((Control) form0_0.panel_3);
      form0_0.tabPage_3.Location = new Point(4, 22);
      form0_0.tabPage_3.Name = "tabPage4";
      form0_0.tabPage_3.Padding = new Padding(3);
      form0_0.tabPage_3.Size = new Size(811, 754);
      form0_0.tabPage_3.TabIndex = 3;
      form0_0.tabPage_3.Text = "Kayıp GM";
      form0_0.label_107.AutoSize = true;
      form0_0.label_107.ForeColor = Color.White;
      form0_0.label_107.Location = new Point(120, 594);
      form0_0.label_107.Name = "label20";
      form0_0.label_107.Size = new Size(538, 13);
      form0_0.label_107.TabIndex = 33;
      form0_0.label_107.Text = "Etkinlik toplam 3 tur yapılır. Her turda 5 dakika içinde kimsenin kazanamaması durumunda sonraki etkinliğe geçilir.";
      form0_0.label_108.AutoSize = true;
      form0_0.label_108.ForeColor = Color.White;
      form0_0.label_108.Location = new Point(9, 564);
      form0_0.label_108.Name = "label25";
      form0_0.label_108.Size = new Size(789, 13);
      form0_0.label_108.TabIndex = 32;
      form0_0.label_108.Text = "Bot seçtiğiniz haritadan rastgele bi bölge seçer ve bu bölgeye atanmış 11 adet koordinatdan her turda 1 tanesine giderek stal açar.Bu stala ilk mesaj yazan kişi kazanır.";
      form0_0.label_109.AutoSize = true;
      form0_0.label_109.ForeColor = Color.White;
      form0_0.label_109.Location = new Point(170, 538);
      form0_0.label_109.Name = "label27";
      form0_0.label_109.Size = new Size(400, 13);
      form0_0.label_109.TabIndex = 31;
      form0_0.label_109.Text = "Bu etkinlik için etkinlik zamanı ve etkinlik haritası seçip ödülleri ayarlamanız yeterlidir.";
      form0_0.label_110.AutoSize = true;
      form0_0.label_110.ForeColor = Color.Red;
      form0_0.label_110.Location = new Point(337, 513);
      form0_0.label_110.Name = "label28";
      form0_0.label_110.Size = new Size(82, 13);
      form0_0.label_110.TabIndex = 30;
      form0_0.label_110.Text = "D  İ  K  K  A  T  ";
      form0_0.panel_3.BackgroundImage = (Image) componentResourceManager.GetObject("panel5.BackgroundImage");
      form0_0.panel_3.Location = new Point(4, 3);
      form0_0.panel_3.Name = "panel5";
      form0_0.panel_3.Size = new Size(801, 450);
      form0_0.panel_3.TabIndex = 2;
      form0_0.tabPage_4.BackColor = Color.Black;
      form0_0.tabPage_4.Controls.Add((Control) form0_0.label_111);
      form0_0.tabPage_4.Controls.Add((Control) form0_0.label_25);
      form0_0.tabPage_4.Controls.Add((Control) form0_0.label_26);
      form0_0.tabPage_4.Controls.Add((Control) form0_0.label_27);
      form0_0.tabPage_4.Controls.Add((Control) form0_0.label_28);
      form0_0.tabPage_4.Controls.Add((Control) form0_0.label_29);
      form0_0.tabPage_4.Controls.Add((Control) form0_0.label_30);
      form0_0.tabPage_4.Controls.Add((Control) form0_0.label_31);
      form0_0.tabPage_4.Controls.Add((Control) form0_0.label_32);
      form0_0.tabPage_4.Controls.Add((Control) form0_0.label_33);
      form0_0.tabPage_4.Controls.Add((Control) form0_0.label_34);
      form0_0.tabPage_4.Controls.Add((Control) form0_0.label_35);
      form0_0.tabPage_4.Controls.Add((Control) form0_0.panel_4);
      form0_0.tabPage_4.Location = new Point(4, 22);
      form0_0.tabPage_4.Name = "tabPage5";
      form0_0.tabPage_4.Padding = new Padding(3);
      form0_0.tabPage_4.Size = new Size(811, 754);
      form0_0.tabPage_4.TabIndex = 4;
      form0_0.tabPage_4.Text = "Alchemy";
      form0_0.label_111.AutoSize = true;
      form0_0.label_111.ForeColor = Color.Orange;
      form0_0.label_111.Location = new Point(60, 596);
      form0_0.label_111.Name = "label29";
      form0_0.label_111.Size = new Size(401, 13);
      form0_0.label_111.TabIndex = 38;
      form0_0.label_111.Text = "( Her turda 3 ara drop uygulanır.Bu işlemde de burada belirlediğiniz rakam kullanılır. ) ";
      form0_0.label_25.AutoSize = true;
      form0_0.label_25.ForeColor = Color.White;
      form0_0.label_25.Location = new Point(574, 658);
      form0_0.label_25.Name = "label61";
      form0_0.label_25.Size = new Size(36, 13);
      form0_0.label_25.TabIndex = 37;
      form0_0.label_25.Text = "yapılır.";
      form0_0.label_26.AutoSize = true;
      form0_0.label_26.ForeColor = Color.Orange;
      form0_0.label_26.Location = new Point(60, 547);
      form0_0.label_26.Name = "label59";
      form0_0.label_26.Size = new Size(513, 13);
      form0_0.label_26.TabIndex = 35;
      form0_0.label_26.Text = "( en yüksek plus değerine birden fazla oyuncu ulaştığında bu değere en önce ulaşan oyuncu ödül kazanır. ) ";
      form0_0.label_27.AutoSize = true;
      form0_0.label_27.ForeColor = Color.Orange;
      form0_0.label_27.Location = new Point(445, 658);
      form0_0.label_27.Name = "label48";
      form0_0.label_27.Size = new Size(123, 13);
      form0_0.label_27.TabIndex = 34;
      form0_0.label_27.Text = "Downhan East Gate ' de";
      form0_0.label_28.AutoSize = true;
      form0_0.label_28.ForeColor = Color.White;
      form0_0.label_28.Location = new Point(147, 658);
      form0_0.label_28.Name = "label49";
      form0_0.label_28.Size = new Size(300, 13);
      form0_0.label_28.TabIndex = 33;
      form0_0.label_28.Text = "Bu etkinlik için bölge belirleyemezsiniz. Etkinlik standart olarak ";
      form0_0.label_29.AutoSize = true;
      form0_0.label_29.ForeColor = Color.White;
      form0_0.label_29.Location = new Point(60, 574);
      form0_0.label_29.Name = "label51";
      form0_0.label_29.Size = new Size(740, 13);
      form0_0.label_29.TabIndex = 31;
      form0_0.label_29.Text = "Etkinliğin her turunda oyuncuların + basması için drop edilecek item sayısını belirler.Önceki etkinliklerden edindiğiniz izlenime göre buraya en uygun sayıyı girin";
      form0_0.label_30.AutoSize = true;
      form0_0.label_30.ForeColor = Color.White;
      form0_0.label_30.Location = new Point(60, 529);
      form0_0.label_30.Name = "label52";
      form0_0.label_30.Size = new Size(532, 13);
      form0_0.label_30.TabIndex = 30;
      form0_0.label_30.Text = "Burada belirttiginiz +sınırının altındaki Loglar işleme alınmaz.Bu sınıra ulaşan ve üzerine çıkan loglar değerlendirilir.";
      form0_0.label_31.AutoSize = true;
      form0_0.label_31.ForeColor = Color.White;
      form0_0.label_31.Location = new Point(60, 505);
      form0_0.label_31.Name = "label53";
      form0_0.label_31.Size = new Size(424, 13);
      form0_0.label_31.TabIndex = 29;
      form0_0.label_31.Text = "Etkinlik başladığında oyuncuların + basması için drop edilecek itemin plus değerini belirler.";
      form0_0.label_32.AutoSize = true;
      form0_0.label_32.ForeColor = Color.Red;
      form0_0.label_32.Location = new Point(363, 634);
      form0_0.label_32.Name = "label54";
      form0_0.label_32.Size = new Size(36, 13);
      form0_0.label_32.TabIndex = 28;
      form0_0.label_32.Text = "N O T";
      form0_0.label_33.AutoSize = true;
      form0_0.label_33.ForeColor = Color.Red;
      form0_0.label_33.Location = new Point(23, 574);
      form0_0.label_33.Name = "label56";
      form0_0.label_33.Size = new Size(31, 13);
      form0_0.label_33.TabIndex = 26;
      form0_0.label_33.Text = "3 => ";
      form0_0.label_34.AutoSize = true;
      form0_0.label_34.ForeColor = Color.Red;
      form0_0.label_34.Location = new Point(23, 529);
      form0_0.label_34.Name = "label57";
      form0_0.label_34.Size = new Size(31, 13);
      form0_0.label_34.TabIndex = 25;
      form0_0.label_34.Text = "2 => ";
      form0_0.label_35.AutoSize = true;
      form0_0.label_35.ForeColor = Color.Red;
      form0_0.label_35.Location = new Point(23, 505);
      form0_0.label_35.Name = "label58";
      form0_0.label_35.Size = new Size(31, 13);
      form0_0.label_35.TabIndex = 24;
      form0_0.label_35.Text = "1 => ";
      form0_0.panel_4.BackgroundImage = (Image) componentResourceManager.GetObject("panel7.BackgroundImage");
      form0_0.panel_4.Location = new Point(3, 3);
      form0_0.panel_4.Name = "panel7";
      form0_0.panel_4.Size = new Size(805, 441);
      form0_0.panel_4.TabIndex = 3;
      form0_0.tabPage_5.BackColor = Color.Black;
      form0_0.tabPage_5.Controls.Add((Control) form0_0.label_36);
      form0_0.tabPage_5.Controls.Add((Control) form0_0.label_37);
      form0_0.tabPage_5.Controls.Add((Control) form0_0.label_38);
      form0_0.tabPage_5.Controls.Add((Control) form0_0.label_39);
      form0_0.tabPage_5.Controls.Add((Control) form0_0.label_40);
      form0_0.tabPage_5.Controls.Add((Control) form0_0.label_41);
      form0_0.tabPage_5.Controls.Add((Control) form0_0.panel_5);
      form0_0.tabPage_5.Location = new Point(4, 22);
      form0_0.tabPage_5.Name = "tabPage6";
      form0_0.tabPage_5.Padding = new Padding(3);
      form0_0.tabPage_5.Size = new Size(811, 754);
      form0_0.tabPage_5.TabIndex = 5;
      form0_0.tabPage_5.Text = "Soru Cevap";
      form0_0.label_36.AutoSize = true;
      form0_0.label_36.ForeColor = Color.White;
      form0_0.label_36.Location = new Point(267, 607);
      form0_0.label_36.Name = "label68";
      form0_0.label_36.Size = new Size(182, 13);
      form0_0.label_36.TabIndex = 45;
      form0_0.label_36.Text = "Sorular arası bekleme süresini belirler.";
      form0_0.label_37.AutoSize = true;
      form0_0.label_37.ForeColor = Color.White;
      form0_0.label_37.Location = new Point(267, 567);
      form0_0.label_37.Name = "label69";
      form0_0.label_37.Size = new Size(337, 13);
      form0_0.label_37.TabIndex = 44;
      form0_0.label_37.Text = "Soru sorulduktan sonra cevapları almak için beklenecek süreyi belirler.";
      form0_0.label_38.AutoSize = true;
      form0_0.label_38.ForeColor = Color.White;
      form0_0.label_38.Location = new Point(267, 534);
      form0_0.label_38.Name = "label70";
      form0_0.label_38.Size = new Size(285, 13);
      form0_0.label_38.TabIndex = 43;
      form0_0.label_38.Text = "Etkinlikte toplam sorularacak soru sayısını belirler. 3 idealdir.";
      form0_0.label_39.AutoSize = true;
      form0_0.label_39.ForeColor = Color.Red;
      form0_0.label_39.Location = new Point(230, 607);
      form0_0.label_39.Name = "label73";
      form0_0.label_39.Size = new Size(31, 13);
      form0_0.label_39.TabIndex = 40;
      form0_0.label_39.Text = "3 => ";
      form0_0.label_40.AutoSize = true;
      form0_0.label_40.ForeColor = Color.Red;
      form0_0.label_40.Location = new Point(230, 567);
      form0_0.label_40.Name = "label74";
      form0_0.label_40.Size = new Size(31, 13);
      form0_0.label_40.TabIndex = 39;
      form0_0.label_40.Text = "2 => ";
      form0_0.label_41.AutoSize = true;
      form0_0.label_41.ForeColor = Color.Red;
      form0_0.label_41.Location = new Point(230, 534);
      form0_0.label_41.Name = "label75";
      form0_0.label_41.Size = new Size(31, 13);
      form0_0.label_41.TabIndex = 38;
      form0_0.label_41.Text = "1 => ";
      form0_0.panel_5.BackgroundImage = (Image) componentResourceManager.GetObject("panel8.BackgroundImage");
      form0_0.panel_5.Location = new Point(7, 3);
      form0_0.panel_5.Name = "panel8";
      form0_0.panel_5.Size = new Size(795, 441);
      form0_0.panel_5.TabIndex = 4;
      form0_0.tabPage_6.BackColor = Color.Black;
      form0_0.tabPage_6.Controls.Add((Control) form0_0.label_42);
      form0_0.tabPage_6.Controls.Add((Control) form0_0.label_43);
      form0_0.tabPage_6.Controls.Add((Control) form0_0.label_44);
      form0_0.tabPage_6.Controls.Add((Control) form0_0.label_45);
      form0_0.tabPage_6.Controls.Add((Control) form0_0.label_46);
      form0_0.tabPage_6.Controls.Add((Control) form0_0.label_47);
      form0_0.tabPage_6.Controls.Add((Control) form0_0.panel_6);
      form0_0.tabPage_6.Location = new Point(4, 22);
      form0_0.tabPage_6.Name = "tabPage7";
      form0_0.tabPage_6.Padding = new Padding(3);
      form0_0.tabPage_6.Size = new Size(811, 754);
      form0_0.tabPage_6.TabIndex = 6;
      form0_0.tabPage_6.Text = "Pt Form";
      form0_0.label_42.AutoSize = true;
      form0_0.label_42.ForeColor = Color.White;
      form0_0.label_42.Location = new Point(264, 613);
      form0_0.label_42.Name = "label62";
      form0_0.label_42.Size = new Size(246, 13);
      form0_0.label_42.TabIndex = 51;
      form0_0.label_42.Text = "Etkinlik turları için zaman sınırlaması buradan yapılır.";
      form0_0.label_43.AutoSize = true;
      form0_0.label_43.ForeColor = Color.White;
      form0_0.label_43.Location = new Point(264, 554);
      form0_0.label_43.Name = "label63";
      form0_0.label_43.Size = new Size(395, 26);
      form0_0.label_43.TabIndex = 50;
      form0_0.label_43.Text = "Bot şanslı party numarasını belirlemek için yeni bir party açar ve bu party numarasını\r\n burada belirlediginiz sayı ile toplar. Bu aranan şanslı party numarasıdır.";
      form0_0.label_44.AutoSize = true;
      form0_0.label_44.ForeColor = Color.White;
      form0_0.label_44.Location = new Point(264, 499);
      form0_0.label_44.Name = "label64";
      form0_0.label_44.Size = new Size(213, 13);
      form0_0.label_44.TabIndex = 49;
      form0_0.label_44.Text = "Etkinliğin toplam kaç tur yapılacagını belirler.";
      form0_0.label_45.AutoSize = true;
      form0_0.label_45.ForeColor = Color.Red;
      form0_0.label_45.Location = new Point(227, 613);
      form0_0.label_45.Name = "label65";
      form0_0.label_45.Size = new Size(31, 13);
      form0_0.label_45.TabIndex = 48;
      form0_0.label_45.Text = "3 => ";
      form0_0.label_46.AutoSize = true;
      form0_0.label_46.ForeColor = Color.Red;
      form0_0.label_46.Location = new Point(227, 554);
      form0_0.label_46.Name = "label66";
      form0_0.label_46.Size = new Size(31, 13);
      form0_0.label_46.TabIndex = 47;
      form0_0.label_46.Text = "2 => ";
      form0_0.label_47.AutoSize = true;
      form0_0.label_47.ForeColor = Color.Red;
      form0_0.label_47.Location = new Point(227, 499);
      form0_0.label_47.Name = "label67";
      form0_0.label_47.Size = new Size(31, 13);
      form0_0.label_47.TabIndex = 46;
      form0_0.label_47.Text = "1 => ";
      form0_0.panel_6.BackgroundImage = (Image) componentResourceManager.GetObject("panel9.BackgroundImage");
      form0_0.panel_6.Location = new Point(6, 6);
      form0_0.panel_6.Name = "panel9";
      form0_0.panel_6.Size = new Size(795, 441);
      form0_0.panel_6.TabIndex = 5;
      form0_0.tabPage_7.BackColor = Color.Black;
      form0_0.tabPage_7.Controls.Add((Control) form0_0.label_48);
      form0_0.tabPage_7.Controls.Add((Control) form0_0.label_49);
      form0_0.tabPage_7.Controls.Add((Control) form0_0.label_50);
      form0_0.tabPage_7.Controls.Add((Control) form0_0.label_51);
      form0_0.tabPage_7.Controls.Add((Control) form0_0.label_52);
      form0_0.tabPage_7.Controls.Add((Control) form0_0.label_53);
      form0_0.tabPage_7.Controls.Add((Control) form0_0.panel_7);
      form0_0.tabPage_7.Location = new Point(4, 22);
      form0_0.tabPage_7.Name = "tabPage8";
      form0_0.tabPage_7.Padding = new Padding(3);
      form0_0.tabPage_7.Size = new Size(811, 754);
      form0_0.tabPage_7.TabIndex = 7;
      form0_0.tabPage_7.Text = "Sayı Bulma";
      form0_0.label_48.AutoSize = true;
      form0_0.label_48.ForeColor = Color.White;
      form0_0.label_48.Location = new Point(248, 627);
      form0_0.label_48.Name = "label71";
      form0_0.label_48.Size = new Size(260, 13);
      form0_0.label_48.TabIndex = 57;
      form0_0.label_48.Text = "Sistem aranan sayıyı belirledikten sonra buraya aktarır.";
      form0_0.label_49.AutoSize = true;
      form0_0.label_49.ForeColor = Color.White;
      form0_0.label_49.Location = new Point(248, 568);
      form0_0.label_49.Name = "label72";
      form0_0.label_49.Size = new Size(242, 13);
      form0_0.label_49.TabIndex = 56;
      form0_0.label_49.Text = "Sistemin rastgele belirleyeceği sayı aralıgını belirler.";
      form0_0.label_50.AutoSize = true;
      form0_0.label_50.ForeColor = Color.White;
      form0_0.label_50.Location = new Point(248, 513);
      form0_0.label_50.Name = "label76";
      form0_0.label_50.Size = new Size(213, 13);
      form0_0.label_50.TabIndex = 55;
      form0_0.label_50.Text = "Etkinliğin toplam kaç tur yapılacagını belirler.";
      form0_0.label_51.AutoSize = true;
      form0_0.label_51.ForeColor = Color.Red;
      form0_0.label_51.Location = new Point(211, 627);
      form0_0.label_51.Name = "label77";
      form0_0.label_51.Size = new Size(31, 13);
      form0_0.label_51.TabIndex = 54;
      form0_0.label_51.Text = "3 => ";
      form0_0.label_52.AutoSize = true;
      form0_0.label_52.ForeColor = Color.Red;
      form0_0.label_52.Location = new Point(211, 568);
      form0_0.label_52.Name = "label78";
      form0_0.label_52.Size = new Size(31, 13);
      form0_0.label_52.TabIndex = 53;
      form0_0.label_52.Text = "2 => ";
      form0_0.label_53.AutoSize = true;
      form0_0.label_53.ForeColor = Color.Red;
      form0_0.label_53.Location = new Point(211, 513);
      form0_0.label_53.Name = "label79";
      form0_0.label_53.Size = new Size(31, 13);
      form0_0.label_53.TabIndex = 52;
      form0_0.label_53.Text = "1 => ";
      form0_0.panel_7.BackgroundImage = (Image) componentResourceManager.GetObject("panel10.BackgroundImage");
      form0_0.panel_7.Location = new Point(7, 6);
      form0_0.panel_7.Name = "panel10";
      form0_0.panel_7.Size = new Size(795, 441);
      form0_0.panel_7.TabIndex = 6;
      form0_0.tabPage_8.BackColor = Color.Black;
      form0_0.tabPage_8.Controls.Add((Control) form0_0.label_54);
      form0_0.tabPage_8.Controls.Add((Control) form0_0.label_55);
      form0_0.tabPage_8.Controls.Add((Control) form0_0.label_56);
      form0_0.tabPage_8.Controls.Add((Control) form0_0.label_57);
      form0_0.tabPage_8.Controls.Add((Control) form0_0.label_58);
      form0_0.tabPage_8.Controls.Add((Control) form0_0.label_59);
      form0_0.tabPage_8.Controls.Add((Control) form0_0.label_60);
      form0_0.tabPage_8.Controls.Add((Control) form0_0.label_61);
      form0_0.tabPage_8.Controls.Add((Control) form0_0.label_62);
      form0_0.tabPage_8.Controls.Add((Control) form0_0.label_63);
      form0_0.tabPage_8.Controls.Add((Control) form0_0.label_64);
      form0_0.tabPage_8.Controls.Add((Control) form0_0.label_65);
      form0_0.tabPage_8.Controls.Add((Control) form0_0.label_66);
      form0_0.tabPage_8.Controls.Add((Control) form0_0.label_67);
      form0_0.tabPage_8.Controls.Add((Control) form0_0.panel_8);
      form0_0.tabPage_8.Location = new Point(4, 22);
      form0_0.tabPage_8.Name = "tabPage9";
      form0_0.tabPage_8.Padding = new Padding(3);
      form0_0.tabPage_8.Size = new Size(811, 754);
      form0_0.tabPage_8.TabIndex = 8;
      form0_0.tabPage_8.Text = "Hayatta Kal";
      form0_0.label_54.AutoSize = true;
      form0_0.label_54.ForeColor = Color.White;
      form0_0.label_54.Location = new Point(94, 640);
      form0_0.label_54.Name = "label88";
      form0_0.label_54.Size = new Size(694, 26);
      form0_0.label_54.TabIndex = 37;
      form0_0.label_54.Text = componentResourceManager.GetString("label88.Text");
      form0_0.label_55.AutoSize = true;
      form0_0.label_55.ForeColor = Color.Red;
      form0_0.label_55.Location = new Point(57, 640);
      form0_0.label_55.Name = "label89";
      form0_0.label_55.Size = new Size(31, 13);
      form0_0.label_55.TabIndex = 36;
      form0_0.label_55.Text = "7 => ";
      form0_0.label_56.AutoSize = true;
      form0_0.label_56.ForeColor = Color.White;
      form0_0.label_56.Location = new Point(94, 612);
      form0_0.label_56.Name = "label90";
      form0_0.label_56.Size = new Size(152, 13);
      form0_0.label_56.TabIndex = 35;
      form0_0.label_56.Text = "Kayıt yapan katılımcıların listesi.";
      form0_0.label_57.AutoSize = true;
      form0_0.label_57.ForeColor = Color.White;
      form0_0.label_57.Location = new Point(94, 588);
      form0_0.label_57.Name = "label91";
      form0_0.label_57.Size = new Size(242, 13);
      form0_0.label_57.TabIndex = 34;
      form0_0.label_57.Text = "Buradan etkinliğe level sınırlaması ayarlayabilrsiniz.";
      form0_0.label_58.AutoSize = true;
      form0_0.label_58.ForeColor = Color.White;
      form0_0.label_58.Location = new Point(94, 567);
      form0_0.label_58.Name = "label92";
      form0_0.label_58.Size = new Size(357, 13);
      form0_0.label_58.TabIndex = 33;
      form0_0.label_58.Text = "Etkinliğe katılım üst limitini belirler. Bu limite ulaşıldığı zaman kayıtlar kapanır.";
      form0_0.label_59.AutoSize = true;
      form0_0.label_59.ForeColor = Color.White;
      form0_0.label_59.Location = new Point(94, 543);
      form0_0.label_59.Name = "label93";
      form0_0.label_59.Size = new Size(480, 13);
      form0_0.label_59.TabIndex = 32;
      form0_0.label_59.Text = "Etkinliğin katılım alt limitini belirler. Belirlediginiz sayının altında katılımcı oldugu zaman etkinlik iptal olur.";
      form0_0.label_60.AutoSize = true;
      form0_0.label_60.ForeColor = Color.White;
      form0_0.label_60.Location = new Point(94, 519);
      form0_0.label_60.Name = "label94";
      form0_0.label_60.Size = new Size(264, 13);
      form0_0.label_60.TabIndex = 31;
      form0_0.label_60.Text = "Etkinlik x,y koordinat ayarları için detaylı bilgi notu açar.";
      form0_0.label_61.AutoSize = true;
      form0_0.label_61.ForeColor = Color.White;
      form0_0.label_61.Location = new Point(94, 495);
      form0_0.label_61.Name = "label95";
      form0_0.label_61.Size = new Size(570, 13);
      form0_0.label_61.TabIndex = 30;
      form0_0.label_61.Text = "Etkinliğin yapılacağı bölgenin x , y koordinatlarını belirler. 2. adımdaki 'Bilgi Al' butonunu kullanarak detaylı bilgi alabilrsiniz.";
      form0_0.label_62.AutoSize = true;
      form0_0.label_62.ForeColor = Color.Red;
      form0_0.label_62.Location = new Point(57, 612);
      form0_0.label_62.Name = "label96";
      form0_0.label_62.Size = new Size(31, 13);
      form0_0.label_62.TabIndex = 29;
      form0_0.label_62.Text = "6 => ";
      form0_0.label_63.AutoSize = true;
      form0_0.label_63.ForeColor = Color.Red;
      form0_0.label_63.Location = new Point(57, 588);
      form0_0.label_63.Name = "label97";
      form0_0.label_63.Size = new Size(31, 13);
      form0_0.label_63.TabIndex = 28;
      form0_0.label_63.Text = "5 => ";
      form0_0.label_64.AutoSize = true;
      form0_0.label_64.ForeColor = Color.Red;
      form0_0.label_64.Location = new Point(57, 567);
      form0_0.label_64.Name = "label98";
      form0_0.label_64.Size = new Size(31, 13);
      form0_0.label_64.TabIndex = 27;
      form0_0.label_64.Text = "4 => ";
      form0_0.label_65.AutoSize = true;
      form0_0.label_65.ForeColor = Color.Red;
      form0_0.label_65.Location = new Point(57, 543);
      form0_0.label_65.Name = "label99";
      form0_0.label_65.Size = new Size(31, 13);
      form0_0.label_65.TabIndex = 26;
      form0_0.label_65.Text = "3 => ";
      form0_0.label_66.AutoSize = true;
      form0_0.label_66.ForeColor = Color.Red;
      form0_0.label_66.Location = new Point(57, 519);
      form0_0.label_66.Name = "label100";
      form0_0.label_66.Size = new Size(31, 13);
      form0_0.label_66.TabIndex = 25;
      form0_0.label_66.Text = "2 => ";
      form0_0.label_67.AutoSize = true;
      form0_0.label_67.ForeColor = Color.Red;
      form0_0.label_67.Location = new Point(57, 495);
      form0_0.label_67.Name = "label101";
      form0_0.label_67.Size = new Size(31, 13);
      form0_0.label_67.TabIndex = 24;
      form0_0.label_67.Text = "1 => ";
      form0_0.panel_8.BackgroundImage = (Image) componentResourceManager.GetObject("panel11.BackgroundImage");
      form0_0.panel_8.Location = new Point(7, 6);
      form0_0.panel_8.Name = "panel11";
      form0_0.panel_8.Size = new Size(795, 441);
      form0_0.panel_8.TabIndex = 7;
      form0_0.tabPage_9.BackColor = Color.Black;
      form0_0.tabPage_9.Controls.Add((Control) form0_0.label_68);
      form0_0.tabPage_9.Controls.Add((Control) form0_0.label_69);
      form0_0.tabPage_9.Controls.Add((Control) form0_0.label_70);
      form0_0.tabPage_9.Controls.Add((Control) form0_0.label_71);
      form0_0.tabPage_9.Controls.Add((Control) form0_0.label_72);
      form0_0.tabPage_9.Controls.Add((Control) form0_0.label_73);
      form0_0.tabPage_9.Controls.Add((Control) form0_0.label_74);
      form0_0.tabPage_9.Controls.Add((Control) form0_0.label_75);
      form0_0.tabPage_9.Controls.Add((Control) form0_0.panel_9);
      form0_0.tabPage_9.Location = new Point(4, 22);
      form0_0.tabPage_9.Name = "tabPage10";
      form0_0.tabPage_9.Padding = new Padding(3);
      form0_0.tabPage_9.Size = new Size(811, 754);
      form0_0.tabPage_9.TabIndex = 9;
      form0_0.tabPage_9.Text = "Oylama";
      form0_0.label_68.AutoSize = true;
      form0_0.label_68.ForeColor = Color.White;
      form0_0.label_68.Location = new Point(157, 634);
      form0_0.label_68.Name = "label80";
      form0_0.label_68.Size = new Size(581, 13);
      form0_0.label_68.TabIndex = 41;
      form0_0.label_68.Text = "Oylamaya yeterli katılım olmadı zaman oylama sonunda dilediginiz etkinliği başlatabilir veya hiçbir etkinlik yaptırmayabilirsiniz.";
      form0_0.label_69.AutoSize = true;
      form0_0.label_69.ForeColor = Color.White;
      form0_0.label_69.Location = new Point(157, 591);
      form0_0.label_69.Name = "label81";
      form0_0.label_69.Size = new Size(560, 13);
      form0_0.label_69.TabIndex = 40;
      form0_0.label_69.Text = "Oylamada seçilen etkinliğin başlaması için en az belirlenen sayı kadar katılımcının bu etkinliğie oy vermiş olması gerekir.";
      form0_0.label_70.AutoSize = true;
      form0_0.label_70.ForeColor = Color.White;
      form0_0.label_70.Location = new Point(157, 549);
      form0_0.label_70.Name = "label82";
      form0_0.label_70.Size = new Size(116, 13);
      form0_0.label_70.TabIndex = 39;
      form0_0.label_70.Text = "Oylama süresini belirler.";
      form0_0.label_71.AutoSize = true;
      form0_0.label_71.ForeColor = Color.White;
      form0_0.label_71.Location = new Point(157, 513);
      form0_0.label_71.Name = "label83";
      form0_0.label_71.Size = new Size(370, 13);
      form0_0.label_71.TabIndex = 38;
      form0_0.label_71.Text = "Burada işaretledigniz etkinlikler oylamada oyunculara seçenek olarak sunulur.";
      form0_0.label_72.AutoSize = true;
      form0_0.label_72.ForeColor = Color.Red;
      form0_0.label_72.Location = new Point(120, 634);
      form0_0.label_72.Name = "label84";
      form0_0.label_72.Size = new Size(31, 13);
      form0_0.label_72.TabIndex = 37;
      form0_0.label_72.Text = "4 => ";
      form0_0.label_73.AutoSize = true;
      form0_0.label_73.ForeColor = Color.Red;
      form0_0.label_73.Location = new Point(120, 591);
      form0_0.label_73.Name = "label85";
      form0_0.label_73.Size = new Size(31, 13);
      form0_0.label_73.TabIndex = 36;
      form0_0.label_73.Text = "3 => ";
      form0_0.label_74.AutoSize = true;
      form0_0.label_74.ForeColor = Color.Red;
      form0_0.label_74.Location = new Point(120, 549);
      form0_0.label_74.Name = "label86";
      form0_0.label_74.Size = new Size(31, 13);
      form0_0.label_74.TabIndex = 35;
      form0_0.label_74.Text = "2 => ";
      form0_0.label_75.AutoSize = true;
      form0_0.label_75.ForeColor = Color.Red;
      form0_0.label_75.Location = new Point(120, 513);
      form0_0.label_75.Name = "label87";
      form0_0.label_75.Size = new Size(31, 13);
      form0_0.label_75.TabIndex = 34;
      form0_0.label_75.Text = "1 => ";
      form0_0.panel_9.BackgroundImage = (Image) componentResourceManager.GetObject("panel12.BackgroundImage");
      form0_0.panel_9.BackgroundImageLayout = ImageLayout.Stretch;
      form0_0.panel_9.Location = new Point(6, 6);
      form0_0.panel_9.Name = "panel12";
      form0_0.panel_9.Size = new Size(795, 441);
      form0_0.panel_9.TabIndex = 8;
      form0_0.panel_9.Paint += new PaintEventHandler(form0_0.method_3);
      form0_0.AutoScaleDimensions = new SizeF(6f, 13f);
      form0_0.AutoScaleMode = AutoScaleMode.Font;
      form0_0.BackColor = SystemColors.ActiveCaptionText;
      form0_0.ClientSize = new Size(815, 733);
      form0_0.Controls.Add((Control) form0_0.tabControl_0);
      form0_0.Controls.Add((Control) form0_0.panel_0);
      form0_0.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      form0_0.MaximizeBox = false;
      form0_0.MinimizeBox = false;
      form0_0.Name = "Bilgilendirme";
      form0_0.Text = "Bilgilendirme";
      form0_0.Load += new EventHandler(form0_0.method_0);
      form0_0.tabControl_0.ResumeLayout(false);
      form0_0.tabPage_0.ResumeLayout(false);
      form0_0.tabPage_0.PerformLayout();
      form0_0.tabPage_10.ResumeLayout(false);
      form0_0.tabPage_10.PerformLayout();
      form0_0.tabPage_1.ResumeLayout(false);
      form0_0.tabPage_1.PerformLayout();
      form0_0.tabPage_2.ResumeLayout(false);
      form0_0.tabPage_2.PerformLayout();
      form0_0.tabPage_3.ResumeLayout(false);
      form0_0.tabPage_3.PerformLayout();
      form0_0.tabPage_4.ResumeLayout(false);
      form0_0.tabPage_4.PerformLayout();
      form0_0.tabPage_5.ResumeLayout(false);
      form0_0.tabPage_5.PerformLayout();
      form0_0.tabPage_6.ResumeLayout(false);
      form0_0.tabPage_6.PerformLayout();
      form0_0.tabPage_7.ResumeLayout(false);
      form0_0.tabPage_7.PerformLayout();
      form0_0.tabPage_8.ResumeLayout(false);
      form0_0.tabPage_8.PerformLayout();
      form0_0.tabPage_9.ResumeLayout(false);
      form0_0.tabPage_9.PerformLayout();
      form0_0.ResumeLayout(false);
    }

    static int smethod_115(Class80.Class82 class82_0)
    {
      return class82_0.int_1 - class82_0.int_0 + (class82_0.int_2 >> 3);
    }

    static string smethod_116(string string_0)
    {
      return BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(Class73.smethod_50(string_0)));
    }

    static unsafe uint smethod_117(string string_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(8);
      if (string_0 != null)
      {
        *(int*) voidPtr = -2128831035;
        *(int*) ((IntPtr) voidPtr + 4) = 0;
        while (*(int*) ((IntPtr) voidPtr + 4) < string_0.Length)
        {
          *(int*) voidPtr = ((int) string_0[*(int*) ((IntPtr) voidPtr + 4)] ^ (int) *(uint*) voidPtr) * 16777619;
          *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + 1;
        }
      }
      return *(uint*) voidPtr;
    }

    static void smethod_118(string string_0, Form1 form1_0)
    {
      Form1.smethod_1(string_0 + " etkinliği başlatılamadı.Bot karakter oyunda değil. Otomatik giriş başlatıldı.Bot hala oyuna giriş yapmadıysa lütfen giriş bilgilerini kontrol edin.", Color.DarkSalmon);
    }

    static bool smethod_119(Class1 class1_0)
    {
      return class1_0.bool_1;
    }

    static void smethod_120(Class1 class1_0, string string_0)
    {
      Class73.smethod_92(string_0, class1_0, 1254);
    }

    static unsafe int smethod_121(
      int[] int_0,
      int[] int_1,
      int[] int_2,
      Class18 class18_0,
      int int_3,
      int[] int_4,
      int int_5,
      int[] int_6,
      int[] int_7)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(13);
      int[] int_9 = new int[1];
      int[] int_10 = new int[288];
      *(int*) voidPtr = Class73.smethod_194(int_2, 0, int_3, 257, Class14.int_2, Class14.int_3, int_4, int_6, int_1, int_9, int_10);
      if ((*(int*) voidPtr != 0 ? 1 : (int_6[0] == 0 ? 1 : 0)) != 0)
      {
        *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) (*(int*) voidPtr == -3);
        if (*(sbyte*) ((IntPtr) voidPtr + 8) != (sbyte) 0)
        {
          class18_0.string_0 = "oversubscribed literal/length tree";
        }
        else
        {
          *(sbyte*) ((IntPtr) voidPtr + 9) = (sbyte) (*(int*) voidPtr != -4);
          if (*(sbyte*) ((IntPtr) voidPtr + 9) != (sbyte) 0)
          {
            class18_0.string_0 = "incomplete literal/length tree";
            *(int*) voidPtr = -3;
          }
        }
        *(int*) ((IntPtr) voidPtr + 4) = *(int*) voidPtr;
      }
      else
      {
        *(int*) voidPtr = Class73.smethod_194(int_2, int_3, int_5, 0, Class14.int_4, Class14.int_5, int_0, int_7, int_1, int_9, int_10);
        if ((*(int*) voidPtr != 0 ? 1 : (int_7[0] != 0 ? 0 : (int_3 > 257 ? 1 : 0))) != 0)
        {
          *(sbyte*) ((IntPtr) voidPtr + 10) = (sbyte) (*(int*) voidPtr == -3);
          if (*(sbyte*) ((IntPtr) voidPtr + 10) != (sbyte) 0)
          {
            class18_0.string_0 = "oversubscribed distance tree";
          }
          else
          {
            *(sbyte*) ((IntPtr) voidPtr + 11) = (sbyte) (*(int*) voidPtr == -5);
            if (*(sbyte*) ((IntPtr) voidPtr + 11) != (sbyte) 0)
            {
              class18_0.string_0 = "incomplete distance tree";
              *(int*) voidPtr = -3;
            }
            else
            {
              *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) (*(int*) voidPtr != -4);
              if (*(sbyte*) ((IntPtr) voidPtr + 12) != (sbyte) 0)
              {
                class18_0.string_0 = "empty distance tree with lengths";
                *(int*) voidPtr = -3;
              }
            }
          }
          *(int*) ((IntPtr) voidPtr + 4) = *(int*) voidPtr;
        }
        else
          *(int*) ((IntPtr) voidPtr + 4) = 0;
      }
      return *(int*) ((IntPtr) voidPtr + 4);
    }

    static unsafe void smethod_122(int int_0, short[] short_0, Class9 class9_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(32);
      *(int*) ((IntPtr) voidPtr + 4) = -1;
      *(int*) ((IntPtr) voidPtr + 12) = (int) short_0[1];
      int num = 0;
      *(int*) ((IntPtr) voidPtr + 16) = 7;
      *(int*) ((IntPtr) voidPtr + 20) = 4;
      *(sbyte*) ((IntPtr) voidPtr + 24) = (sbyte) (*(int*) ((IntPtr) voidPtr + 12) == 0);
      if (*(sbyte*) ((IntPtr) voidPtr + 24) != (sbyte) 0)
      {
        *(int*) ((IntPtr) voidPtr + 16) = 138;
        *(int*) ((IntPtr) voidPtr + 20) = 3;
      }
      short_0[(int_0 + 1) * 2 + 1] = (short) Class73.smethod_247((long) ushort.MaxValue);
      *(int*) voidPtr = 0;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 31) = (sbyte) (*(int*) voidPtr <= int_0);
        if (*(sbyte*) ((IntPtr) voidPtr + 31) != (sbyte) 0)
        {
          *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 12);
          *(int*) ((IntPtr) voidPtr + 12) = (int) short_0[(*(int*) voidPtr + 1) * 2 + 1];
          if ((++num >= *(int*) ((IntPtr) voidPtr + 16) ? 0 : (*(int*) ((IntPtr) voidPtr + 8) == *(int*) ((IntPtr) voidPtr + 12) ? 1 : 0)) == 0)
          {
            *(sbyte*) ((IntPtr) voidPtr + 25) = (sbyte) (num < *(int*) ((IntPtr) voidPtr + 20));
            if (*(sbyte*) ((IntPtr) voidPtr + 25) != (sbyte) 0)
            {
              class9_0.short_4[*(int*) ((IntPtr) voidPtr + 8) * 2] = (short) ((int) class9_0.short_4[*(int*) ((IntPtr) voidPtr + 8) * 2] + num);
            }
            else
            {
              *(sbyte*) ((IntPtr) voidPtr + 26) = (sbyte) ((uint) *(int*) ((IntPtr) voidPtr + 8) > 0U);
              if (*(sbyte*) ((IntPtr) voidPtr + 26) != (sbyte) 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 27) = (sbyte) (*(int*) ((IntPtr) voidPtr + 8) != *(int*) ((IntPtr) voidPtr + 4));
                if (*(sbyte*) ((IntPtr) voidPtr + 27) != (sbyte) 0)
                  ++class9_0.short_4[*(int*) ((IntPtr) voidPtr + 8) * 2];
                ++class9_0.short_4[32];
              }
              else
              {
                *(sbyte*) ((IntPtr) voidPtr + 28) = (sbyte) (num <= 10);
                if (*(sbyte*) ((IntPtr) voidPtr + 28) != (sbyte) 0)
                  ++class9_0.short_4[34];
                else
                  ++class9_0.short_4[36];
              }
            }
            num = 0;
            *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 8);
            *(sbyte*) ((IntPtr) voidPtr + 29) = (sbyte) (*(int*) ((IntPtr) voidPtr + 12) == 0);
            if (*(sbyte*) ((IntPtr) voidPtr + 29) != (sbyte) 0)
            {
              *(int*) ((IntPtr) voidPtr + 16) = 138;
              *(int*) ((IntPtr) voidPtr + 20) = 3;
            }
            else
            {
              *(sbyte*) ((IntPtr) voidPtr + 30) = (sbyte) (*(int*) ((IntPtr) voidPtr + 8) == *(int*) ((IntPtr) voidPtr + 12));
              if (*(sbyte*) ((IntPtr) voidPtr + 30) != (sbyte) 0)
              {
                *(int*) ((IntPtr) voidPtr + 16) = 6;
                *(int*) ((IntPtr) voidPtr + 20) = 3;
              }
              else
              {
                *(int*) ((IntPtr) voidPtr + 16) = 7;
                *(int*) ((IntPtr) voidPtr + 20) = 4;
              }
            }
          }
          *(int*) voidPtr = *(int*) voidPtr + 1;
        }
        else
          break;
      }
    }

    static void smethod_123(Class19 class19_0, string string_0, string string_1)
    {
      Class1 class1_0 = new Class1((ushort) 28709);
      Class73.smethod_65((ushort) 2, class1_0);
      Class73.smethod_120(class1_0, string_0);
      Class73.smethod_120(class1_0, string_1);
      class19_0.method_1(class1_0);
    }

    static string smethod_124(string string_0)
    {
      string_0 = Encoding.UTF8.GetString(Encoding.GetEncoding(1254).GetBytes(string_0));
      Class69.smethod_1(string_0);
      return string_0;
    }

    static unsafe bool smethod_125(Class80.Class81 class81_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(8);
      switch (class81_0.int_4)
      {
        case 2:
          if (class81_0.bool_0)
          {
            class81_0.int_4 = 12;
            return false;
          }
          *(int*) voidPtr = Class73.smethod_254(class81_0.class82_0, 3);
          if (*(int*) voidPtr < 0)
            return false;
          Class73.smethod_147(class81_0.class82_0, 3);
          if ((*(int*) voidPtr & 1) != 0)
            class81_0.bool_0 = true;
          switch (*(int*) voidPtr >> 1)
          {
            case 0:
              Class73.smethod_88(class81_0.class82_0);
              class81_0.int_4 = 3;
              break;
            case 1:
              class81_0.class84_0 = Class80.Class84.class84_0;
              class81_0.class84_1 = Class80.Class84.class84_1;
              class81_0.int_4 = 7;
              break;
            case 2:
              class81_0.class85_0 = new Class80.Class85();
              class81_0.int_4 = 6;
              break;
          }
          return true;
        case 3:
          if ((class81_0.int_8 = Class73.smethod_254(class81_0.class82_0, 16)) < 0)
            return false;
          Class73.smethod_147(class81_0.class82_0, 16);
          class81_0.int_4 = 4;
          goto case 4;
        case 4:
          if (Class73.smethod_254(class81_0.class82_0, 16) < 0)
            return false;
          Class73.smethod_147(class81_0.class82_0, 16);
          class81_0.int_4 = 5;
          goto case 5;
        case 5:
          *(int*) ((IntPtr) voidPtr + 4) = Class73.smethod_159(class81_0.class83_0, class81_0.class82_0, class81_0.int_8);
          class81_0.int_8 -= *(int*) ((IntPtr) voidPtr + 4);
          if (class81_0.int_8 != 0)
            return !Class73.smethod_133(class81_0.class82_0);
          class81_0.int_4 = 2;
          return true;
        case 6:
          if (!Class73.smethod_250(class81_0.class85_0, class81_0.class82_0))
            return false;
          class81_0.class84_0 = Class73.smethod_97(class81_0.class85_0);
          class81_0.class84_1 = Class73.smethod_138(class81_0.class85_0);
          class81_0.int_4 = 7;
          goto case 7;
        case 7:
        case 8:
        case 9:
        case 10:
          return Class73.smethod_222(class81_0);
        case 12:
          return false;
        default:
          return false;
      }
    }

    static ICryptoTransform smethod_126(bool bool_0, byte[] byte_0, byte[] byte_1)
    {
      using (SymmetricAlgorithm symmetricAlgorithm = (SymmetricAlgorithm) new RijndaelManaged())
        return bool_0 ? symmetricAlgorithm.CreateDecryptor(byte_1, byte_0) : symmetricAlgorithm.CreateEncryptor(byte_1, byte_0);
    }

    static string smethod_127(string string_0)
    {
      return Class73.smethod_54(BitConverter.ToString(new SHA256Managed().ComputeHash(Class73.smethod_50(string_0))));
    }

    static void smethod_128(bool bool_0, Class1 class1_0, Class19 class19_0)
    {
      if (class19_0.socket_0 == null)
        return;
      Class73.smethod_219(false, bool_0, class1_0);
    }

    static string smethod_129(string string_0)
    {
      return "127.0.0.1";
    }

    static unsafe void smethod_130(int int_0, int int_1, Form1 form1_0, int int_2)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(9);
      *(int*) voidPtr = int_0;
      *(int*) ((IntPtr) voidPtr + 4) = 0;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) (*(int*) ((IntPtr) voidPtr + 4) < *(int*) voidPtr);
        if (*(sbyte*) ((IntPtr) voidPtr + 8) != (sbyte) 0)
        {
          Class73.smethod_183(int_1, Class25.class19_0, int_2);
          *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + 1;
        }
        else
          break;
      }
    }

    static void smethod_131(bool bool_0, Class1 class1_0, Class29 class29_0)
    {
      if (class29_0.socket_0 == null)
        return;
      Class73.smethod_219(true, bool_0, class1_0);
    }

    static unsafe KeyValuePair<Class6, Class1> smethod_132(Class4 class4_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(8);
      *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) (class4_0.list_1.Count == 0);
      if (*(sbyte*) ((IntPtr) voidPtr + 2) != (sbyte) 0)
        throw new Exception("[SecurityAPI::GetPacketToSend] No packets are avaliable to send.");
      Class1 class1_0 = class4_0.list_1[0];
      class4_0.list_1.RemoveAt(0);
      *(sbyte*) ((IntPtr) voidPtr + 3) = (sbyte) Class73.smethod_119(class1_0);
      KeyValuePair<Class6, Class1> keyValuePair;
      if (*(sbyte*) ((IntPtr) voidPtr + 3) != (sbyte) 0)
      {
        *(short*) voidPtr = (short) 0;
        Class3 class3_0_1 = new Class3();
        Class3 class3_0_2 = new Class3();
        byte[] numArray = Class73.smethod_223(class1_0);
        Class2 class2 = new Class2(numArray);
        Class6 class6_0_1 = new Class6(4089, 0, numArray.Length);
        while (true)
        {
          *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (Class73.smethod_53(class6_0_1) > 0);
          if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
          {
            Class3 class3_0_3 = new Class3();
            int count = Class73.smethod_53(class6_0_1) > 4089 ? 4089 : Class73.smethod_53(class6_0_1);
            class3_0_3.Write((byte) 0);
            class3_0_3.Write(numArray, Class73.smethod_84(class6_0_1), count);
            Class6 class6_0_2 = class6_0_1;
            Class73.smethod_6(class6_0_2, Class73.smethod_84(class6_0_2) + count);
            Class6 class6_0_3 = class6_0_1;
            Class73.smethod_158(class6_0_3, Class73.smethod_53(class6_0_3) - count);
            class3_0_2.Write(Class73.smethod_38(class4_0, (ushort) 24589, Class73.smethod_230(class3_0_3), false));
            *(short*) voidPtr = (short) (ushort) ((uint) *(ushort*) voidPtr + 1U);
          }
          else
            break;
        }
        Class3 class3_0_4 = new Class3();
        class3_0_4.Write((byte) 1);
        class3_0_4.Write((short) *(ushort*) voidPtr);
        class3_0_4.Write(Class73.smethod_89(class1_0));
        class3_0_1.Write(Class73.smethod_38(class4_0, (ushort) 24589, Class73.smethod_230(class3_0_4), false));
        class3_0_1.Write(Class73.smethod_230(class3_0_2));
        byte[] byte_1 = Class73.smethod_230(class3_0_1);
        Class73.smethod_44(class1_0);
        keyValuePair = new KeyValuePair<Class6, Class1>(new Class6(byte_1, 0, byte_1.Length, true), class1_0);
      }
      else
      {
        *(sbyte*) ((IntPtr) voidPtr + 5) = (sbyte) Class73.smethod_186(class1_0);
        *(sbyte*) ((IntPtr) voidPtr + 6) = (sbyte) !class4_0.bool_0;
        if (*(sbyte*) ((IntPtr) voidPtr + 6) != (sbyte) 0)
        {
          *(sbyte*) ((IntPtr) voidPtr + 7) = (sbyte) class4_0.list_2.Contains(Class73.smethod_89(class1_0));
          if (*(sbyte*) ((IntPtr) voidPtr + 7) != (sbyte) 0)
            *(sbyte*) ((IntPtr) voidPtr + 5) = (sbyte) 1;
        }
        byte[] byte_1 = Class73.smethod_38(class4_0, Class73.smethod_89(class1_0), Class73.smethod_223(class1_0), (bool) *(sbyte*) ((IntPtr) voidPtr + 5));
        Class73.smethod_44(class1_0);
        keyValuePair = new KeyValuePair<Class6, Class1>(new Class6(byte_1, 0, byte_1.Length, true), class1_0);
      }
      return keyValuePair;
    }

    static bool smethod_133(Class80.Class82 class82_0)
    {
      return class82_0.int_0 == class82_0.int_1;
    }

    static unsafe void smethod_134(float float_0, Class1 class1_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      object object0 = class1_0.object_0;
      *(sbyte*) voidPtr = (sbyte) 0;
      try
      {
        Monitor.Enter(object0, ref *(bool*) voidPtr);
        *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) class1_0.bool_2;
        if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
          throw new Exception("Cannot Write to a locked Packet.");
        class1_0.class3_0.Write(float_0);
      }
      finally
      {
        if (*(sbyte*) voidPtr != (sbyte) 0)
          Monitor.Exit(object0);
      }
    }

    static byte[] smethod_135(Class0 class0_0, byte[] byte_0)
    {
      return Class73.smethod_47(byte_0, byte_0.Length, 0, class0_0);
    }

    static unsafe void smethod_136(Class1 class1_0, sbyte sbyte_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      object object0 = class1_0.object_0;
      *(sbyte*) voidPtr = (sbyte) 0;
      try
      {
        Monitor.Enter(object0, ref *(bool*) voidPtr);
        *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) class1_0.bool_2;
        if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
          throw new Exception("Cannot Write to a locked Packet.");
        class1_0.class3_0.Write(sbyte_0);
      }
      finally
      {
        if (*(sbyte*) voidPtr != (sbyte) 0)
          Monitor.Exit(object0);
      }
    }

    static void smethod_137(Class9 class9_0, int int_0, short[] short_0)
    {
      Class73.smethod_61(class9_0, (int) short_0[int_0 * 2] & (int) ushort.MaxValue, (int) short_0[int_0 * 2 + 1] & (int) ushort.MaxValue);
    }

    static Class80.Class84 smethod_138(Class80.Class85 class85_0)
    {
      byte[] byte_0 = new byte[class85_0.int_4];
      Array.Copy((Array) class85_0.byte_1, class85_0.int_3, (Array) byte_0, 0, class85_0.int_4);
      return new Class80.Class84(byte_0);
    }

    static byte smethod_139(Class4 class4_0, byte[] byte_0)
    {
      return Class73.smethod_190(byte_0, class4_0, 0, byte_0.Length);
    }

    static unsafe string smethod_140(Class1 class1_0, int int_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(4);
      object object0 = class1_0.object_0;
      *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) 0;
      try
      {
        // ISSUE: cast to a reference type
        Monitor.Enter(object0, (bool&) ((IntPtr) voidPtr + 2));
        *(sbyte*) ((IntPtr) voidPtr + 3) = (sbyte) !class1_0.bool_2;
        if (*(sbyte*) ((IntPtr) voidPtr + 3) != (sbyte) 0)
          throw new Exception("Cannot Read from an unlocked Packet.");
        *(short*) voidPtr = (short) class1_0.class2_0.ReadUInt16();
        byte[] bytes = class1_0.class2_0.ReadBytes((int) *(ushort*) voidPtr);
        return Encoding.GetEncoding(int_0).GetString(bytes);
      }
      finally
      {
        if (*(sbyte*) ((IntPtr) voidPtr + 2) != (sbyte) 0)
          Monitor.Exit(object0);
      }
    }

    static bool smethod_141(short[] short_0, int int_0, int int_1, byte[] byte_0)
    {
      if ((int) short_0[int_0 * 2] < (int) short_0[int_1 * 2])
        return true;
      return (int) short_0[int_0 * 2] == (int) short_0[int_1 * 2] && (int) byte_0[int_0] <= (int) byte_0[int_1];
    }

    static int smethod_142(Class80.Class82 class82_0)
    {
      return class82_0.int_2;
    }

    static void smethod_143(Class12 class12_0, Class18 class18_0)
    {
    }

    static unsafe int smethod_144(int int_0, Class11 class11_0, Class18 class18_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(26);
      *(int*) ((IntPtr) voidPtr + 8) = class18_0.int_3;
      *(int*) ((IntPtr) voidPtr + 12) = class11_0.int_14;
      int num1 = (*(int*) ((IntPtr) voidPtr + 12) <= class11_0.int_15 ? class11_0.int_15 : class11_0.int_13) - *(int*) ((IntPtr) voidPtr + 12);
      *(sbyte*) ((IntPtr) voidPtr + 20) = (sbyte) (num1 > class18_0.int_4);
      if (*(sbyte*) ((IntPtr) voidPtr + 20) != (sbyte) 0)
        num1 = class18_0.int_4;
      if ((num1 == 0 ? 0 : (int_0 == -5 ? 1 : 0)) != 0)
        int_0 = 0;
      class18_0.int_4 -= num1;
      class18_0.long_1 += (long) num1;
      *(sbyte*) ((IntPtr) voidPtr + 21) = (sbyte) (class11_0.object_0 != null);
      if (*(sbyte*) ((IntPtr) voidPtr + 21) != (sbyte) 0)
      {
        Class18 class18 = class18_0;
        Class11 class11 = class11_0;
        Class8 class80 = class18_0.class8_0;
        *(long*) voidPtr = class11_0.long_0;
        long num2;
        long num3 = num2 = Class73.smethod_151(class11_0.byte_0, class80, num1, *(long*) voidPtr, *(int*) ((IntPtr) voidPtr + 12));
        class11.long_0 = num2;
        long num4 = num3;
        class18.long_2 = num4;
      }
      Array.Copy((Array) class11_0.byte_0, *(int*) ((IntPtr) voidPtr + 12), (Array) class18_0.byte_1, *(int*) ((IntPtr) voidPtr + 8), num1);
      *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) + num1;
      *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + num1;
      *(sbyte*) ((IntPtr) voidPtr + 22) = (sbyte) (*(int*) ((IntPtr) voidPtr + 12) == class11_0.int_13);
      if (*(sbyte*) ((IntPtr) voidPtr + 22) != (sbyte) 0)
      {
        *(int*) ((IntPtr) voidPtr + 12) = 0;
        *(sbyte*) ((IntPtr) voidPtr + 23) = (sbyte) (class11_0.int_15 == class11_0.int_13);
        if (*(sbyte*) ((IntPtr) voidPtr + 23) != (sbyte) 0)
          class11_0.int_15 = 0;
        int num2 = class11_0.int_15 - *(int*) ((IntPtr) voidPtr + 12);
        *(sbyte*) ((IntPtr) voidPtr + 24) = (sbyte) (num2 > class18_0.int_4);
        if (*(sbyte*) ((IntPtr) voidPtr + 24) != (sbyte) 0)
          num2 = class18_0.int_4;
        if ((num2 == 0 ? 0 : (int_0 == -5 ? 1 : 0)) != 0)
          int_0 = 0;
        class18_0.int_4 -= num2;
        class18_0.long_1 += (long) num2;
        *(sbyte*) ((IntPtr) voidPtr + 25) = (sbyte) (class11_0.object_0 != null);
        if (*(sbyte*) ((IntPtr) voidPtr + 25) != (sbyte) 0)
        {
          Class18 class18 = class18_0;
          Class11 class11 = class11_0;
          Class8 class80 = class18_0.class8_0;
          *(long*) voidPtr = class11_0.long_0;
          long num3;
          long num4 = num3 = Class73.smethod_151(class11_0.byte_0, class80, num2, *(long*) voidPtr, *(int*) ((IntPtr) voidPtr + 12));
          class11.long_0 = num3;
          long num5 = num4;
          class18.long_2 = num5;
        }
        Array.Copy((Array) class11_0.byte_0, *(int*) ((IntPtr) voidPtr + 12), (Array) class18_0.byte_1, *(int*) ((IntPtr) voidPtr + 8), num2);
        *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) + num2;
        *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + num2;
      }
      class18_0.int_3 = *(int*) ((IntPtr) voidPtr + 8);
      class11_0.int_14 = *(int*) ((IntPtr) voidPtr + 12);
      *(int*) ((IntPtr) voidPtr + 16) = int_0;
      return *(int*) ((IntPtr) voidPtr + 16);
    }

    static unsafe void smethod_145()
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(5);
      try
      {
        using (SqlDataReader sqlDataReader = new SqlCommand("select Etkinlik,Etkinlik_Tarihi from My_EventBot.._Etkinlik_Takvimi", Class65.sqlConnection_0).ExecuteReader())
        {
          Form1.form1_0.listBox_10.Items.Clear();
          Form1.form1_0.listBox_11.Items.Clear();
          Form1.form1_0.listBox_3.Items.Clear();
          Form1.form1_0.listBox_4.Items.Clear();
          Form1.form1_0.listBox_5.Items.Clear();
          Form1.form1_0.listBox_7.Items.Clear();
          Form1.form1_0.listBox_9.Items.Clear();
          Form1.form1_0.listBox_6.Items.Clear();
          Form1.form1_0.listBox_12.Items.Clear();
          while (true)
          {
            string string_0;
            do
            {
              do
              {
                do
                {
                  do
                  {
                    do
                    {
                      do
                      {
                        do
                        {
                          do
                          {
                            do
                            {
                              do
                              {
                                *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) sqlDataReader.Read();
                                if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
                                {
                                  string_0 = sqlDataReader[0].ToString();
                                  *(int*) voidPtr = (int) Class73.smethod_117(string_0);
                                  if (*(uint*) voidPtr > 935352090U)
                                  {
                                    if (*(uint*) voidPtr > 1952778366U)
                                    {
                                      if (*(uint*) voidPtr != 2690449916U)
                                        goto label_25;
                                    }
                                    else
                                      goto label_19;
                                  }
                                  else
                                    goto label_4;
                                }
                                else
                                  goto label_33;
                              }
                              while (!(string_0 == "Alchemy"));
                              goto label_31;
label_25:
                              if (*(uint*) voidPtr != 3014609657U)
                                goto label_26;
                            }
                            while (!(string_0 == "Sayı_Bulma"));
                            goto label_29;
label_26:;
                          }
                          while (*(uint*) voidPtr != 3806578296U || !(string_0 == "Oylama"));
                          goto label_27;
label_19:
                          if (*(uint*) voidPtr != 1250606020U)
                            goto label_20;
                        }
                        while (!(string_0 == "Unique_Bulma"));
                        goto label_23;
label_20:;
                      }
                      while (*(uint*) voidPtr != 1952778366U || !(string_0 == "Party_Form"));
                      goto label_21;
label_4:
                      if (*(uint*) voidPtr > 107575738U)
                      {
                        if (*(uint*) voidPtr != 354086688U)
                          goto label_11;
                      }
                      else
                        goto label_5;
                    }
                    while (!(string_0 == "Hayatta_Kal"));
                    goto label_17;
label_11:
                    if (*(uint*) voidPtr != 728378495U)
                      goto label_12;
                  }
                  while (!(string_0 == "GM_Bulma"));
                  goto label_15;
label_12:;
                }
                while (*(uint*) voidPtr != 935352090U || !(string_0 == "Unique_Kesme"));
                goto label_13;
label_5:
                if (*(uint*) voidPtr != 106058584U)
                  goto label_6;
              }
              while (!(string_0 == "Piyango"));
              goto label_9;
label_6:;
            }
            while (*(uint*) voidPtr != 107575738U || !(string_0 == "Soru_Cevap"));
            Form1.form1_0.listBox_5.Items.Add((object) sqlDataReader[1].ToString());
            continue;
label_9:
            Form1.form1_0.listBox_22.Items.Add((object) sqlDataReader[1].ToString());
            continue;
label_13:
            Form1.form1_0.listBox_10.Items.Add((object) sqlDataReader[1].ToString());
            continue;
label_15:
            Form1.form1_0.listBox_3.Items.Add((object) sqlDataReader[1].ToString());
            continue;
label_17:
            Form1.form1_0.listBox_12.Items.Add((object) sqlDataReader[1].ToString());
            continue;
label_21:
            Form1.form1_0.listBox_7.Items.Add((object) sqlDataReader[1].ToString());
            continue;
label_23:
            Form1.form1_0.listBox_11.Items.Add((object) sqlDataReader[1].ToString());
            continue;
label_27:
            Form1.form1_0.listBox_6.Items.Add((object) sqlDataReader[1].ToString());
            continue;
label_29:
            Form1.form1_0.listBox_9.Items.Add((object) sqlDataReader[1].ToString());
            continue;
label_31:
            Form1.form1_0.listBox_4.Items.Add((object) sqlDataReader[1].ToString());
          }
label_33:
          sqlDataReader.Close();
          Form1.smethod_0("[Etkinlik Takvimi] yüklendi.Bot kullanıma hazır..");
        }
      }
      catch (Exception ex)
      {
        Form1.smethod_0("[Etkinlik Takvimi] yüklenemedi.Programı tekrar başlatın.!! Açıklama ==> " + ex.Message);
      }
    }

    static void smethod_146(byte[] byte_0, out byte[] byte_1)
    {
      using (MemoryStream memoryStream = new MemoryStream())
      {
        using (Stream0 stream0 = new Stream0((Stream) memoryStream))
        {
          using (Stream stream_0 = (Stream) new MemoryStream(byte_0))
          {
            Class73.smethod_213(stream_0, (Stream) stream0);
            stream0.vmethod_0();
            byte_1 = memoryStream.ToArray();
          }
        }
      }
    }

    static void smethod_147(Class80.Class82 class82_0, int int_0)
    {
      class82_0.uint_0 >>= int_0;
      class82_0.int_2 -= int_0;
    }

    static unsafe int smethod_148(Class9 class9_0, int int_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(36);
      *(int*) voidPtr = 0;
      while (true)
      {
        do
        {
          do
          {
            do
            {
              *(sbyte*) ((IntPtr) voidPtr + 32) = (sbyte) 1;
              *(sbyte*) ((IntPtr) voidPtr + 21) = (sbyte) (class9_0.int_23 < Class9.int_0);
              if (*(sbyte*) ((IntPtr) voidPtr + 21) != (sbyte) 0)
                goto label_20;
label_1:
              *(sbyte*) ((IntPtr) voidPtr + 23) = (sbyte) (class9_0.int_23 >= 3);
              if (*(sbyte*) ((IntPtr) voidPtr + 23) != (sbyte) 0)
              {
                class9_0.int_13 = (class9_0.int_13 << class9_0.int_16 ^ (int) class9_0.byte_2[class9_0.int_21 + 2] & (int) byte.MaxValue) & class9_0.int_15;
                *(int*) voidPtr = (int) class9_0.short_1[class9_0.int_13] & (int) ushort.MaxValue;
                class9_0.short_0[class9_0.int_21 & class9_0.int_11] = class9_0.short_1[class9_0.int_13];
                class9_0.short_1[class9_0.int_13] = (short) class9_0.int_21;
              }
              class9_0.int_24 = class9_0.int_18;
              class9_0.int_19 = class9_0.int_22;
              class9_0.int_18 = 2;
              if ((*(int*) voidPtr == 0 || class9_0.int_24 >= class9_0.int_26 ? 0 : ((class9_0.int_21 - *(int*) voidPtr & (int) ushort.MaxValue) <= class9_0.int_9 - Class9.int_0 ? 1 : 0)) != 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 24) = (sbyte) (class9_0.int_28 != 2);
                if (*(sbyte*) ((IntPtr) voidPtr + 24) != (sbyte) 0)
                  class9_0.int_18 = Class73.smethod_149(*(int*) voidPtr, class9_0);
                if ((class9_0.int_18 > 5 ? 0 : (class9_0.int_28 == 1 ? 1 : (class9_0.int_18 != 3 ? 0 : (class9_0.int_21 - class9_0.int_22 > 4096 ? 1 : 0)))) != 0)
                  class9_0.int_18 = 2;
              }
              if ((class9_0.int_24 < 3 ? 0 : (class9_0.int_18 <= class9_0.int_24 ? 1 : 0)) == 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 29) = (sbyte) ((uint) class9_0.int_20 > 0U);
                if (*(sbyte*) ((IntPtr) voidPtr + 29) != (sbyte) 0)
                {
                  *(sbyte*) ((IntPtr) voidPtr + 20) = (sbyte) Class73.smethod_64((int) class9_0.byte_2[class9_0.int_21 - 1] & (int) byte.MaxValue, class9_0, 0);
                  *(sbyte*) ((IntPtr) voidPtr + 30) = *(sbyte*) ((IntPtr) voidPtr + 20);
                  if (*(sbyte*) ((IntPtr) voidPtr + 30) != (sbyte) 0)
                    Class73.smethod_224(class9_0, false);
                  ++class9_0.int_21;
                  --class9_0.int_23;
                  *(sbyte*) ((IntPtr) voidPtr + 31) = (sbyte) (class9_0.class18_0.int_4 == 0);
                  continue;
                }
                goto label_19;
              }
              else
                goto label_9;
label_20:
              Class73.smethod_91(class9_0);
              if ((class9_0.int_23 >= Class9.int_0 ? 0 : (int_0 == 0 ? 1 : 0)) == 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 22) = (sbyte) (class9_0.int_23 == 0);
                if (*(sbyte*) ((IntPtr) voidPtr + 22) == (sbyte) 0)
                  goto label_1;
                else
                  goto label_24;
              }
              else
                goto label_23;
            }
            while (*(sbyte*) ((IntPtr) voidPtr + 31) == (sbyte) 0);
            goto label_30;
label_9:
            *(int*) ((IntPtr) voidPtr + 4) = class9_0.int_21 + class9_0.int_23 - 3;
            *(int*) ((IntPtr) voidPtr + 12) = class9_0.int_21 - 1 - class9_0.int_19;
            *(int*) ((IntPtr) voidPtr + 16) = class9_0.int_24 - 3;
            *(sbyte*) ((IntPtr) voidPtr + 20) = (sbyte) Class73.smethod_64(*(int*) ((IntPtr) voidPtr + 16), class9_0, *(int*) ((IntPtr) voidPtr + 12));
            class9_0.int_23 -= class9_0.int_24 - 1;
            class9_0.int_24 -= 2;
            do
            {
              Class9 class9_1 = class9_0;
              *(int*) ((IntPtr) voidPtr + 8) = class9_0.int_21 + 1;
              int num1 = *(int*) ((IntPtr) voidPtr + 8);
              class9_1.int_21 = num1;
              *(sbyte*) ((IntPtr) voidPtr + 25) = (sbyte) (*(int*) ((IntPtr) voidPtr + 8) <= *(int*) ((IntPtr) voidPtr + 4));
              if (*(sbyte*) ((IntPtr) voidPtr + 25) != (sbyte) 0)
                goto label_11;
label_10:
              Class9 class9_2 = class9_0;
              *(int*) ((IntPtr) voidPtr + 8) = class9_0.int_24 - 1;
              int num2 = *(int*) ((IntPtr) voidPtr + 8);
              class9_2.int_24 = num2;
              *(sbyte*) ((IntPtr) voidPtr + 26) = (sbyte) ((uint) *(int*) ((IntPtr) voidPtr + 8) > 0U);
              continue;
label_11:
              class9_0.int_13 = (class9_0.int_13 << class9_0.int_16 ^ (int) class9_0.byte_2[class9_0.int_21 + 2] & (int) byte.MaxValue) & class9_0.int_15;
              *(int*) voidPtr = (int) class9_0.short_1[class9_0.int_13] & (int) ushort.MaxValue;
              class9_0.short_0[class9_0.int_21 & class9_0.int_11] = class9_0.short_1[class9_0.int_13];
              class9_0.short_1[class9_0.int_13] = (short) class9_0.int_21;
              goto label_10;
            }
            while (*(sbyte*) ((IntPtr) voidPtr + 26) != (sbyte) 0);
            class9_0.int_20 = 0;
            class9_0.int_18 = 2;
            ++class9_0.int_21;
            *(sbyte*) ((IntPtr) voidPtr + 27) = *(sbyte*) ((IntPtr) voidPtr + 20);
          }
          while (*(sbyte*) ((IntPtr) voidPtr + 27) == (sbyte) 0);
          Class73.smethod_224(class9_0, false);
          *(sbyte*) ((IntPtr) voidPtr + 28) = (sbyte) (class9_0.class18_0.int_4 == 0);
        }
        while (*(sbyte*) ((IntPtr) voidPtr + 28) == (sbyte) 0);
        goto label_29;
label_19:
        class9_0.int_20 = 1;
        ++class9_0.int_21;
        --class9_0.int_23;
      }
label_23:
      int num = 0;
      goto label_31;
label_24:
      *(sbyte*) ((IntPtr) voidPtr + 33) = (sbyte) ((uint) class9_0.int_20 > 0U);
      if (*(sbyte*) ((IntPtr) voidPtr + 33) != (sbyte) 0)
      {
        *(sbyte*) ((IntPtr) voidPtr + 20) = (sbyte) Class73.smethod_64((int) class9_0.byte_2[class9_0.int_21 - 1] & (int) byte.MaxValue, class9_0, 0);
        class9_0.int_20 = 0;
      }
      Class73.smethod_224(class9_0, int_0 == 4);
      *(sbyte*) ((IntPtr) voidPtr + 34) = (sbyte) (class9_0.class18_0.int_4 == 0);
      if (*(sbyte*) ((IntPtr) voidPtr + 34) != (sbyte) 0)
      {
        *(sbyte*) ((IntPtr) voidPtr + 35) = (sbyte) (int_0 == 4);
        num = *(sbyte*) ((IntPtr) voidPtr + 35) == (sbyte) 0 ? 0 : 2;
        goto label_31;
      }
      else
      {
        num = int_0 == 4 ? 3 : 1;
        goto label_31;
      }
label_29:
      num = 0;
      goto label_31;
label_30:
      num = 0;
label_31:
      return num;
    }

    static unsafe int smethod_149(int int_0, Class9 class9_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(31);
      int int25 = class9_0.int_25;
      int index1 = class9_0.int_21;
      *(int*) ((IntPtr) voidPtr + 4) = class9_0.int_24;
      int num1 = class9_0.int_21 > class9_0.int_9 - Class9.int_0 ? class9_0.int_21 - (class9_0.int_9 - Class9.int_0) : 0;
      *(int*) ((IntPtr) voidPtr + 8) = class9_0.int_30;
      *(int*) ((IntPtr) voidPtr + 12) = class9_0.int_11;
      *(int*) ((IntPtr) voidPtr + 16) = class9_0.int_21 + 258;
      *(sbyte*) ((IntPtr) voidPtr + 24) = (sbyte) class9_0.byte_2[index1 + *(int*) ((IntPtr) voidPtr + 4) - 1];
      *(sbyte*) ((IntPtr) voidPtr + 25) = (sbyte) class9_0.byte_2[index1 + *(int*) ((IntPtr) voidPtr + 4)];
      *(sbyte*) ((IntPtr) voidPtr + 26) = (sbyte) (class9_0.int_24 >= class9_0.int_29);
      if (*(sbyte*) ((IntPtr) voidPtr + 26) != (sbyte) 0)
        int25 >>= 2;
      *(sbyte*) ((IntPtr) voidPtr + 27) = (sbyte) (*(int*) ((IntPtr) voidPtr + 8) > class9_0.int_23);
      if (*(sbyte*) ((IntPtr) voidPtr + 27) != (sbyte) 0)
        *(int*) ((IntPtr) voidPtr + 8) = class9_0.int_23;
      do
      {
        int index2 = int_0;
        if (((int) class9_0.byte_2[index2 + *(int*) ((IntPtr) voidPtr + 4)] != (int) *(byte*) ((IntPtr) voidPtr + 25) || ((int) class9_0.byte_2[index2 + *(int*) ((IntPtr) voidPtr + 4) - 1] != (int) *(byte*) ((IntPtr) voidPtr + 24) || (int) class9_0.byte_2[index2] != (int) class9_0.byte_2[index1]) ? 1 : ((int) class9_0.byte_2[++index2] != (int) class9_0.byte_2[index1 + 1] ? 1 : 0)) == 0)
        {
          int num2 = index1 + 2;
          int num3 = index2 + 1;
          do
            ;
          while (((int) class9_0.byte_2[++num2] != (int) class9_0.byte_2[++num3] || ((int) class9_0.byte_2[++num2] != (int) class9_0.byte_2[++num3] || (int) class9_0.byte_2[++num2] != (int) class9_0.byte_2[++num3]) || ((int) class9_0.byte_2[++num2] != (int) class9_0.byte_2[++num3] || (int) class9_0.byte_2[++num2] != (int) class9_0.byte_2[++num3] || ((int) class9_0.byte_2[++num2] != (int) class9_0.byte_2[++num3] || (int) class9_0.byte_2[++num2] != (int) class9_0.byte_2[++num3])) || (int) class9_0.byte_2[++num2] != (int) class9_0.byte_2[++num3] ? 0 : (num2 < *(int*) ((IntPtr) voidPtr + 16) ? 1 : 0)) != 0);
          *(int*) voidPtr = 258 - (*(int*) ((IntPtr) voidPtr + 16) - num2);
          index1 = *(int*) ((IntPtr) voidPtr + 16) - 258;
          *(sbyte*) ((IntPtr) voidPtr + 28) = (sbyte) (*(int*) voidPtr > *(int*) ((IntPtr) voidPtr + 4));
          if (*(sbyte*) ((IntPtr) voidPtr + 28) != (sbyte) 0)
          {
            class9_0.int_22 = int_0;
            *(int*) ((IntPtr) voidPtr + 4) = *(int*) voidPtr;
            *(sbyte*) ((IntPtr) voidPtr + 29) = (sbyte) (*(int*) voidPtr >= *(int*) ((IntPtr) voidPtr + 8));
            if (*(sbyte*) ((IntPtr) voidPtr + 29) == (sbyte) 0)
            {
              *(sbyte*) ((IntPtr) voidPtr + 24) = (sbyte) class9_0.byte_2[index1 + *(int*) ((IntPtr) voidPtr + 4) - 1];
              *(sbyte*) ((IntPtr) voidPtr + 25) = (sbyte) class9_0.byte_2[index1 + *(int*) ((IntPtr) voidPtr + 4)];
            }
            else
              break;
          }
        }
      }
      while (((int_0 = (int) class9_0.short_0[int_0 & *(int*) ((IntPtr) voidPtr + 12)] & (int) ushort.MaxValue) <= num1 ? 0 : ((uint) --int25 > 0U ? 1 : 0)) != 0);
      *(sbyte*) ((IntPtr) voidPtr + 30) = (sbyte) (*(int*) ((IntPtr) voidPtr + 4) <= class9_0.int_23);
      if (*(sbyte*) ((IntPtr) voidPtr + 30) != (sbyte) 0)
        *(int*) ((IntPtr) voidPtr + 20) = *(int*) ((IntPtr) voidPtr + 4);
      else
        *(int*) ((IntPtr) voidPtr + 20) = class9_0.int_23;
      return *(int*) ((IntPtr) voidPtr + 20);
    }

    static unsafe Assembly smethod_150(object object_0, ResolveEventArgs resolveEventArgs_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(16);
      Class75.Struct15 struct15 = new Class75.Struct15(resolveEventArgs_0.Name);
      string base64String1 = Convert.ToBase64String(Encoding.UTF8.GetBytes(struct15.method_0(false)));
      string[] strArray = "e2M1NmI5NjBhLTYxZTMtNDkxZi05NTE3LWQ2ZmE2NjIxZTFkMX0sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{6f4c9ddf-9e8f-4883-b54f-b40044f36d96},e2M1NmI5NjBhLTYxZTMtNDkxZi05NTE3LWQ2ZmE2NjIxZTFkMX0=,[z]{6f4c9ddf-9e8f-4883-b54f-b40044f36d96}".Split(',');
      string index = string.Empty;
      bool flag1 = false;
      bool flag2 = false;
      *(int*) voidPtr = 0;
      while (*(int*) voidPtr < strArray.Length - 1)
      {
        if (!(strArray[*(int*) voidPtr] == base64String1))
        {
          *(int*) voidPtr = *(int*) voidPtr + 2;
        }
        else
        {
          index = strArray[*(int*) voidPtr + 1];
          break;
        }
      }
      if (index.Length == 0 && struct15.string_2.Length == 0)
      {
        string base64String2 = Convert.ToBase64String(Encoding.UTF8.GetBytes(struct15.string_0));
        *(int*) ((IntPtr) voidPtr + 4) = 0;
        while (*(int*) ((IntPtr) voidPtr + 4) < strArray.Length - 1)
        {
          if (!(strArray[*(int*) ((IntPtr) voidPtr + 4)] == base64String2))
          {
            *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + 2;
          }
          else
          {
            index = strArray[*(int*) ((IntPtr) voidPtr + 4) + 1];
            break;
          }
        }
      }
      if (index.Length > 0)
      {
        if (index[0] == '[')
        {
          *(int*) ((IntPtr) voidPtr + 8) = index.IndexOf(']');
          string str = index.Substring(1, *(int*) ((IntPtr) voidPtr + 8) - 1);
          flag1 = str.IndexOf('z') >= 0;
          flag2 = str.IndexOf('t') >= 0;
          index = index.Substring(*(int*) ((IntPtr) voidPtr + 8) + 1);
        }
        lock (Class75.dictionary_0)
        {
          if (Class75.dictionary_0.ContainsKey(index))
            return Class75.dictionary_0[index];
          Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(index);
          if (manifestResourceStream != null)
          {
            *(int*) ((IntPtr) voidPtr + 12) = (int) manifestResourceStream.Length;
            byte[] numArray = new byte[*(int*) ((IntPtr) voidPtr + 12)];
            manifestResourceStream.Read(numArray, 0, *(int*) ((IntPtr) voidPtr + 12));
            if (flag1)
              numArray = Class73.smethod_111(numArray);
            Assembly assembly = (Assembly) null;
            if (!flag2)
            {
              try
              {
                assembly = Assembly.Load(numArray);
              }
              catch (FileLoadException ex)
              {
                flag2 = true;
              }
              catch (BadImageFormatException ex)
              {
                flag2 = true;
              }
            }
            if (flag2)
            {
              try
              {
                string str1 = string.Format("{0}{1}\\", (object) Path.GetTempPath(), (object) index);
                Directory.CreateDirectory(str1);
                string str2 = str1 + struct15.string_0 + ".dll";
                if (!File.Exists(str2))
                {
                  FileStream fileStream = File.OpenWrite(str2);
                  fileStream.Write(numArray, 0, numArray.Length);
                  fileStream.Close();
                  Class73.MoveFileEx(str2, (string) null, 4);
                  Class73.MoveFileEx(str1, (string) null, 4);
                }
                assembly = Assembly.LoadFile(str2);
              }
              catch
              {
              }
            }
            Class75.dictionary_0[index] = assembly;
            return assembly;
          }
        }
      }
      return (Assembly) null;
    }

    static unsafe long smethod_151(
      byte[] byte_0,
      Class8 class8_0,
      int int_0,
      long long_0,
      int int_1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(20);
      *(sbyte*) ((IntPtr) voidPtr + 16) = (sbyte) (byte_0 == null);
      if (*(sbyte*) ((IntPtr) voidPtr + 16) != (sbyte) 0)
      {
        *(long*) ((IntPtr) voidPtr + 8) = 1L;
      }
      else
      {
        long num1 = long_0 & (long) ushort.MaxValue;
        *(long*) voidPtr = long_0 >> 16 & (long) ushort.MaxValue;
        while (true)
        {
          *(sbyte*) ((IntPtr) voidPtr + 19) = (sbyte) (int_0 > 0);
          if (*(sbyte*) ((IntPtr) voidPtr + 19) != (sbyte) 0)
          {
            int num2 = int_0 < 5552 ? int_0 : 5552;
            int_0 -= num2;
            while (true)
            {
              *(sbyte*) ((IntPtr) voidPtr + 17) = (sbyte) (num2 >= 16);
              if (*(sbyte*) ((IntPtr) voidPtr + 17) != (sbyte) 0)
              {
                long num3 = num1 + (long) ((int) byte_0[int_1++] & (int) byte.MaxValue);
                *(long*) voidPtr = *(long*) voidPtr + num3;
                long num4 = num3 + (long) ((int) byte_0[int_1++] & (int) byte.MaxValue);
                *(long*) voidPtr = *(long*) voidPtr + num4;
                long num5 = num4 + (long) ((int) byte_0[int_1++] & (int) byte.MaxValue);
                *(long*) voidPtr = *(long*) voidPtr + num5;
                long num6 = num5 + (long) ((int) byte_0[int_1++] & (int) byte.MaxValue);
                *(long*) voidPtr = *(long*) voidPtr + num6;
                long num7 = num6 + (long) ((int) byte_0[int_1++] & (int) byte.MaxValue);
                *(long*) voidPtr = *(long*) voidPtr + num7;
                long num8 = num7 + (long) ((int) byte_0[int_1++] & (int) byte.MaxValue);
                *(long*) voidPtr = *(long*) voidPtr + num8;
                long num9 = num8 + (long) ((int) byte_0[int_1++] & (int) byte.MaxValue);
                *(long*) voidPtr = *(long*) voidPtr + num9;
                long num10 = num9 + (long) ((int) byte_0[int_1++] & (int) byte.MaxValue);
                *(long*) voidPtr = *(long*) voidPtr + num10;
                long num11 = num10 + (long) ((int) byte_0[int_1++] & (int) byte.MaxValue);
                *(long*) voidPtr = *(long*) voidPtr + num11;
                long num12 = num11 + (long) ((int) byte_0[int_1++] & (int) byte.MaxValue);
                *(long*) voidPtr = *(long*) voidPtr + num12;
                long num13 = num12 + (long) ((int) byte_0[int_1++] & (int) byte.MaxValue);
                *(long*) voidPtr = *(long*) voidPtr + num13;
                long num14 = num13 + (long) ((int) byte_0[int_1++] & (int) byte.MaxValue);
                *(long*) voidPtr = *(long*) voidPtr + num14;
                long num15 = num14 + (long) ((int) byte_0[int_1++] & (int) byte.MaxValue);
                *(long*) voidPtr = *(long*) voidPtr + num15;
                long num16 = num15 + (long) ((int) byte_0[int_1++] & (int) byte.MaxValue);
                *(long*) voidPtr = *(long*) voidPtr + num16;
                long num17 = num16 + (long) ((int) byte_0[int_1++] & (int) byte.MaxValue);
                *(long*) voidPtr = *(long*) voidPtr + num17;
                num1 = num17 + (long) ((int) byte_0[int_1++] & (int) byte.MaxValue);
                *(long*) voidPtr = *(long*) voidPtr + num1;
                num2 -= 16;
              }
              else
                break;
            }
            *(sbyte*) ((IntPtr) voidPtr + 18) = (sbyte) ((uint) num2 > 0U);
            if (*(sbyte*) ((IntPtr) voidPtr + 18) != (sbyte) 0)
            {
              do
              {
                num1 += (long) ((int) byte_0[int_1++] & (int) byte.MaxValue);
                *(long*) voidPtr = *(long*) voidPtr + num1;
              }
              while ((uint) --num2 > 0U);
            }
            num1 %= 65521L;
            *(long*) voidPtr = *(long*) voidPtr % 65521L;
          }
          else
            break;
        }
        *(long*) ((IntPtr) voidPtr + 8) = *(long*) voidPtr << 16 | num1;
      }
      return *(long*) ((IntPtr) voidPtr + 8);
    }

    static void smethod_152()
    {
      try
      {
        Class73.smethod_59();
      }
      catch (Exception ex)
      {
      }
    }

    static int smethod_153(Class80.Class83 class83_0)
    {
      return 32768 - class83_0.int_1;
    }

    static unsafe int smethod_154(Class13 class13_0, Class18 class18_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(5);
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (class13_0.class11_0 != null);
      if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
        Class73.smethod_56(class18_0, class13_0.class11_0);
      class13_0.class11_0 = (Class11) null;
      *(int*) voidPtr = 0;
      return *(int*) voidPtr;
    }

    static byte[] smethod_155(Class6 class6_0)
    {
      return class6_0.byte_0;
    }

    static unsafe int smethod_156(Class18 class18_0, byte[] byte_0, int int_0, int int_1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(23);
      *(int*) ((IntPtr) voidPtr + 8) = class18_0.int_2;
      *(sbyte*) ((IntPtr) voidPtr + 20) = (sbyte) (*(int*) ((IntPtr) voidPtr + 8) > int_1);
      if (*(sbyte*) ((IntPtr) voidPtr + 20) != (sbyte) 0)
        *(int*) ((IntPtr) voidPtr + 8) = int_1;
      *(sbyte*) ((IntPtr) voidPtr + 21) = (sbyte) (*(int*) ((IntPtr) voidPtr + 8) == 0);
      if (*(sbyte*) ((IntPtr) voidPtr + 21) != (sbyte) 0)
      {
        *(int*) ((IntPtr) voidPtr + 12) = 0;
      }
      else
      {
        class18_0.int_2 -= *(int*) ((IntPtr) voidPtr + 8);
        *(sbyte*) ((IntPtr) voidPtr + 22) = (sbyte) (class18_0.class9_0.int_7 == 0);
        if (*(sbyte*) ((IntPtr) voidPtr + 22) != (sbyte) 0)
        {
          Class18 class18 = class18_0;
          Class8 class80 = class18_0.class8_0;
          *(long*) voidPtr = class18_0.long_2;
          byte[] byte0 = class18_0.byte_0;
          *(int*) ((IntPtr) voidPtr + 16) = class18_0.int_1;
          long num = Class73.smethod_151(byte0, class80, *(int*) ((IntPtr) voidPtr + 8), *(long*) voidPtr, *(int*) ((IntPtr) voidPtr + 16));
          class18.long_2 = num;
        }
        Array.Copy((Array) class18_0.byte_0, class18_0.int_1, (Array) byte_0, int_0, *(int*) ((IntPtr) voidPtr + 8));
        class18_0.int_1 += *(int*) ((IntPtr) voidPtr + 8);
        class18_0.long_0 += (long) *(int*) ((IntPtr) voidPtr + 8);
        *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 8);
      }
      return *(int*) ((IntPtr) voidPtr + 12);
    }

    static unsafe ulong smethod_157(uint uint_0, uint uint_1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(24);
      *(long*) voidPtr = (long) uint_0;
      *(long*) ((IntPtr) voidPtr + 8) = (long) uint_1;
      *(long*) ((IntPtr) voidPtr + 16) = *(long*) ((IntPtr) voidPtr + 8) << 32 | *(long*) voidPtr;
      return (ulong) *(long*) ((IntPtr) voidPtr + 16);
    }

    static void smethod_158(Class6 class6_0, int int_0)
    {
      lock (class6_0.object_0)
        class6_0.int_1 = int_0;
    }

    static unsafe int smethod_159(Class80.Class83 class83_0, Class80.Class82 class82_0, int int_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(8);
      int_0 = Math.Min(Math.Min(int_0, 32768 - class83_0.int_1), Class73.smethod_115(class82_0));
      *(int*) ((IntPtr) voidPtr + 4) = 32768 - class83_0.int_0;
      if (int_0 > *(int*) ((IntPtr) voidPtr + 4))
      {
        *(int*) voidPtr = Class73.smethod_34(class82_0, class83_0.byte_0, class83_0.int_0, *(int*) ((IntPtr) voidPtr + 4));
        if (*(int*) voidPtr == *(int*) ((IntPtr) voidPtr + 4))
          *(int*) voidPtr = *(int*) voidPtr + Class73.smethod_34(class82_0, class83_0.byte_0, 0, int_0 - *(int*) ((IntPtr) voidPtr + 4));
      }
      else
        *(int*) voidPtr = Class73.smethod_34(class82_0, class83_0.byte_0, class83_0.int_0, int_0);
      class83_0.int_0 = class83_0.int_0 + *(int*) voidPtr & (int) short.MaxValue;
      class83_0.int_1 += *(int*) voidPtr;
      return *(int*) voidPtr;
    }

    static unsafe void smethod_160(ulong ulong_0, Class1 class1_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      object object0 = class1_0.object_0;
      *(sbyte*) voidPtr = (sbyte) 0;
      try
      {
        Monitor.Enter(object0, ref *(bool*) voidPtr);
        *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) class1_0.bool_2;
        if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
          throw new Exception("Cannot Write to a locked Packet.");
        class1_0.class3_0.Write(ulong_0);
      }
      finally
      {
        if (*(sbyte*) voidPtr != (sbyte) 0)
          Monitor.Exit(object0);
      }
    }

    static void smethod_161(Class19 class19_0, string string_0)
    {
      Class1 class1_0 = new Class1((ushort) 28709);
      Class73.smethod_65((ushort) 7, class1_0);
      Class73.smethod_120(class1_0, string_0);
      class19_0.method_1(class1_0);
    }

    static unsafe void smethod_162(byte byte_0, Class1 class1_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      object object0 = class1_0.object_0;
      *(sbyte*) voidPtr = (sbyte) 0;
      try
      {
        Monitor.Enter(object0, ref *(bool*) voidPtr);
        *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) class1_0.bool_2;
        if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
          throw new Exception("Cannot Write to a locked Packet.");
        class1_0.class3_0.Write(byte_0);
      }
      finally
      {
        if (*(sbyte*) voidPtr != (sbyte) 0)
          Monitor.Exit(object0);
      }
    }

    static void smethod_163(Bitmap bitmap_0)
    {
      Class73.smethod_225(bitmap_0);
    }

    static unsafe int smethod_164(Class9 class9_0, int int_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(16);
      *(int*) voidPtr = (int) ushort.MaxValue;
      *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) (*(int*) voidPtr > class9_0.int_4 - 5);
      if (*(sbyte*) ((IntPtr) voidPtr + 8) != (sbyte) 0)
        *(int*) voidPtr = class9_0.int_4 - 5;
      do
      {
        do
        {
          *(sbyte*) ((IntPtr) voidPtr + 14) = (sbyte) 1;
          *(sbyte*) ((IntPtr) voidPtr + 9) = (sbyte) (class9_0.int_23 <= 1);
          if (*(sbyte*) ((IntPtr) voidPtr + 9) != (sbyte) 0)
            goto label_6;
label_2:
          class9_0.int_21 += class9_0.int_23;
          class9_0.int_23 = 0;
          *(int*) ((IntPtr) voidPtr + 4) = class9_0.int_17 + *(int*) voidPtr;
          if ((class9_0.int_21 == 0 ? 1 : (class9_0.int_21 >= *(int*) ((IntPtr) voidPtr + 4) ? 1 : 0)) != 0)
          {
            class9_0.int_23 = class9_0.int_21 - *(int*) ((IntPtr) voidPtr + 4);
            class9_0.int_21 = *(int*) ((IntPtr) voidPtr + 4);
            Class73.smethod_224(class9_0, false);
            *(sbyte*) ((IntPtr) voidPtr + 11) = (sbyte) (class9_0.class18_0.int_4 == 0);
            if (*(sbyte*) ((IntPtr) voidPtr + 11) != (sbyte) 0)
              goto label_11;
          }
          *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) (class9_0.int_21 - class9_0.int_17 >= class9_0.int_9 - Class9.int_0);
          continue;
label_6:
          Class73.smethod_91(class9_0);
          if ((class9_0.int_23 != 0 ? 0 : (int_0 == 0 ? 1 : 0)) == 0)
          {
            *(sbyte*) ((IntPtr) voidPtr + 10) = (sbyte) (class9_0.int_23 == 0);
            if (*(sbyte*) ((IntPtr) voidPtr + 10) == (sbyte) 0)
              goto label_2;
            else
              goto label_10;
          }
          else
            goto label_9;
        }
        while (*(sbyte*) ((IntPtr) voidPtr + 12) == (sbyte) 0);
        Class73.smethod_224(class9_0, false);
        *(sbyte*) ((IntPtr) voidPtr + 13) = (sbyte) (class9_0.class18_0.int_4 == 0);
      }
      while (*(sbyte*) ((IntPtr) voidPtr + 13) == (sbyte) 0);
      goto label_12;
label_9:
      int num = 0;
      goto label_13;
label_10:
      Class73.smethod_224(class9_0, int_0 == 4);
      *(sbyte*) ((IntPtr) voidPtr + 15) = (sbyte) (class9_0.class18_0.int_4 == 0);
      num = *(sbyte*) ((IntPtr) voidPtr + 15) == (sbyte) 0 ? (int_0 == 4 ? 3 : 1) : (int_0 == 4 ? 2 : 0);
      goto label_13;
label_11:
      num = 0;
      goto label_13;
label_12:
      num = 0;
label_13:
      return num;
    }

    static unsafe uint smethod_165(Class1 class1_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(6);
      object object0 = class1_0.object_0;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) 0;
      try
      {
        // ISSUE: cast to a reference type
        Monitor.Enter(object0, (bool&) ((IntPtr) voidPtr + 4));
        *(sbyte*) ((IntPtr) voidPtr + 5) = (sbyte) !class1_0.bool_2;
        if (*(sbyte*) ((IntPtr) voidPtr + 5) != (sbyte) 0)
          throw new Exception("Cannot Read from an unlocked Packet.");
        *(int*) voidPtr = (int) class1_0.class2_0.ReadUInt32();
      }
      finally
      {
        if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
          Monitor.Exit(object0);
      }
      return *(uint*) voidPtr;
    }

    static unsafe int smethod_166(Class18 class18_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(9);
      *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) (class18_0.class9_0 == null);
      if (*(sbyte*) ((IntPtr) voidPtr + 8) != (sbyte) 0)
      {
        *(int*) ((IntPtr) voidPtr + 4) = -2;
      }
      else
      {
        *(int*) voidPtr = Class73.smethod_20(class18_0.class9_0);
        class18_0.class9_0 = (Class9) null;
        *(int*) ((IntPtr) voidPtr + 4) = *(int*) voidPtr;
      }
      return *(int*) ((IntPtr) voidPtr + 4);
    }

    static int smethod_167(Class18 class18_0)
    {
      return Class73.smethod_221(class18_0, Class18.int_0);
    }

    static void smethod_168()
    {
      Class73.smethod_83(Class25.class19_0, -15809.0, 94.0);
    }

    static void smethod_169()
    {
      Class73.smethod_83(Class25.class19_0, -252.0, 47.0);
    }

    static void smethod_170(Class6 class6_0, byte[] byte_0)
    {
      lock (class6_0.object_0)
        class6_0.byte_0 = byte_0;
    }

    static void smethod_171(int int_0, Stream0 stream0_0)
    {
      stream0_0.byte_1[0] = (byte) int_0;
      ((Stream) stream0_0).Write(stream0_0.byte_1, 0, 1);
    }

    static unsafe int smethod_172(int int_0, int int_1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(8);
      *(int*) voidPtr = 0;
      do
      {
        *(int*) voidPtr = *(int*) voidPtr | int_1 & 1;
        int_1 = Class73.smethod_108(1, int_1);
        *(int*) voidPtr = *(int*) voidPtr << 1;
      }
      while (--int_0 > 0);
      *(int*) ((IntPtr) voidPtr + 4) = Class73.smethod_108(1, *(int*) voidPtr);
      return *(int*) ((IntPtr) voidPtr + 4);
    }

    static unsafe void smethod_173(object object_0, Class1 class1_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      object object0 = class1_0.object_0;
      *(sbyte*) voidPtr = (sbyte) 0;
      try
      {
        Monitor.Enter(object0, ref *(bool*) voidPtr);
        *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) class1_0.bool_2;
        if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
          throw new Exception("Cannot Write to a locked Packet.");
        class1_0.class3_0.Write((byte) (Convert.ToUInt64(object_0) & (ulong) byte.MaxValue));
      }
      finally
      {
        if (*(sbyte*) voidPtr != (sbyte) 0)
          Monitor.Exit(object0);
      }
    }

    static ushort smethod_174(uint uint_0)
    {
      return (ushort) (uint_0 >> 16 & (uint) ushort.MaxValue);
    }

    static ResourceManager smethod_175()
    {
      if (Class31.resourceManager_0 == null)
        Class31.resourceManager_0 = new ResourceManager("ns2.Class31", typeof (Class31).Assembly);
      return Class31.resourceManager_0;
    }

    static void smethod_176(Class1 class1_0, Class4 class4_0)
    {
      if ((Class73.smethod_89(class1_0) == (ushort) 20480 ? 1 : (Class73.smethod_89(class1_0) == (ushort) 36864 ? 1 : 0)) != 0)
        return;
      lock (class4_0.object_0)
        class4_0.list_1.Add(class1_0);
    }

    static void smethod_177(Class9 class9_0, byte[] byte_0, int int_0, int int_1)
    {
      Array.Copy((Array) byte_0, int_0, (Array) class9_0.byte_0, class9_0.int_6, int_1);
      class9_0.int_6 += int_1;
    }

    static void smethod_178(Stream0 stream0_0)
    {
      stream0_0.int_1 = 0;
      stream0_0.byte_0 = new byte[stream0_0.int_0];
    }

    static unsafe int smethod_179(Class1 class1_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(6);
      object object0 = class1_0.object_0;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) 0;
      try
      {
        // ISSUE: cast to a reference type
        Monitor.Enter(object0, (bool&) ((IntPtr) voidPtr + 4));
        *(sbyte*) ((IntPtr) voidPtr + 5) = (sbyte) !class1_0.bool_2;
        if (*(sbyte*) ((IntPtr) voidPtr + 5) != (sbyte) 0)
          throw new Exception("Cannot SeekRead on an unlocked Packet.");
        *(int*) voidPtr = (int) (class1_0.class2_0.BaseStream.Length - class1_0.class2_0.BaseStream.Position);
      }
      finally
      {
        if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
          Monitor.Exit(object0);
      }
      return *(int*) voidPtr;
    }

    static void smethod_180(string string_0)
    {
      Class65.string_0 = string_0;
      using (SqlDataReader sqlDataReader = new SqlCommand("DECLARE @dbname nvarchar(128) = N'" + string_0 + "' IF (EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE ('[' + name + ']' = @dbname OR name = @dbname))) select 1 else select 0", Class65.sqlConnection_0).ExecuteReader())
      {
        try
        {
          sqlDataReader.Read();
          if ((int) sqlDataReader[0] != 1)
            Class73.smethod_234("create database " + string_0, true);
          Class73.smethod_234("use " + string_0, true);
          Form1.smethod_0("Database Oluşturuldu ==> [" + string_0 + "]");
        }
        catch (Exception ex)
        {
          Form1.smethod_0(string_0 + "  Database oluşturulurken bir hata oluştu.Lütfen programı kapatıp tekrar açın.");
          Form1.smethod_0("Hata Açıklaması ==> " + ex.Message);
        }
      }
    }

    static void smethod_181(string string_0)
    {
      string str = string_0;
      if (!(str == "Jangan"))
      {
        if (!(str == "Donwhang"))
        {
          if (!(str == "Hotan"))
          {
            if (!(str == "Samarkand"))
            {
              if (!(str == "Constantine"))
              {
                if (!(str == "Alexandria"))
                  return;
                Class73.smethod_168();
              }
              else
                Class73.smethod_207();
            }
            else
              Class73.smethod_212();
          }
          else
            Class73.smethod_169();
        }
        else
          Class73.smethod_74();
      }
      else
        Class73.smethod_236();
    }

    static unsafe int smethod_182(Class11 class11_0, Class18 class18_0, int int_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(53);
      int int1_1 = class18_0.int_1;
      *(int*) voidPtr = class18_0.int_2;
      int int_1_1 = class11_0.int_11;
      int num1 = class11_0.int_10;
      *(int*) ((IntPtr) voidPtr + 4) = class11_0.int_15;
      int num2 = *(int*) ((IntPtr) voidPtr + 4) < class11_0.int_14 ? class11_0.int_14 - *(int*) ((IntPtr) voidPtr + 4) - 1 : class11_0.int_13 - *(int*) ((IntPtr) voidPtr + 4);
      int num3;
      int num4;
      while (true)
      {
        do
        {
          *(sbyte*) ((IntPtr) voidPtr + 52) = (sbyte) 1;
          *(int*) ((IntPtr) voidPtr + 8) = class11_0.int_2;
          switch (*(int*) ((IntPtr) voidPtr + 8))
          {
            case 0:
              goto label_57;
            case 1:
              goto label_52;
            case 2:
              *(sbyte*) ((IntPtr) voidPtr + 25) = (sbyte) (*(int*) voidPtr == 0);
              if (*(sbyte*) ((IntPtr) voidPtr + 25) == (sbyte) 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 26) = (sbyte) (num2 == 0);
                if (*(sbyte*) ((IntPtr) voidPtr + 26) != (sbyte) 0)
                {
                  if ((*(int*) ((IntPtr) voidPtr + 4) != class11_0.int_13 ? 0 : ((uint) class11_0.int_14 > 0U ? 1 : 0)) != 0)
                  {
                    *(int*) ((IntPtr) voidPtr + 4) = 0;
                    num2 = *(int*) ((IntPtr) voidPtr + 4) < class11_0.int_14 ? class11_0.int_14 - *(int*) ((IntPtr) voidPtr + 4) - 1 : class11_0.int_13 - *(int*) ((IntPtr) voidPtr + 4);
                  }
                  *(sbyte*) ((IntPtr) voidPtr + 27) = (sbyte) (num2 == 0);
                  if (*(sbyte*) ((IntPtr) voidPtr + 27) != (sbyte) 0)
                  {
                    class11_0.int_15 = *(int*) ((IntPtr) voidPtr + 4);
                    int_0 = Class73.smethod_144(int_0, class11_0, class18_0);
                    *(int*) ((IntPtr) voidPtr + 4) = class11_0.int_15;
                    num2 = *(int*) ((IntPtr) voidPtr + 4) < class11_0.int_14 ? class11_0.int_14 - *(int*) ((IntPtr) voidPtr + 4) - 1 : class11_0.int_13 - *(int*) ((IntPtr) voidPtr + 4);
                    if ((*(int*) ((IntPtr) voidPtr + 4) != class11_0.int_13 ? 0 : ((uint) class11_0.int_14 > 0U ? 1 : 0)) != 0)
                    {
                      *(int*) ((IntPtr) voidPtr + 4) = 0;
                      num2 = *(int*) ((IntPtr) voidPtr + 4) < class11_0.int_14 ? class11_0.int_14 - *(int*) ((IntPtr) voidPtr + 4) - 1 : class11_0.int_13 - *(int*) ((IntPtr) voidPtr + 4);
                    }
                    *(sbyte*) ((IntPtr) voidPtr + 28) = (sbyte) (num2 == 0);
                    if (*(sbyte*) ((IntPtr) voidPtr + 28) != (sbyte) 0)
                      goto label_69;
                  }
                }
                int_0 = 0;
                int length = class11_0.int_3;
                *(sbyte*) ((IntPtr) voidPtr + 29) = (sbyte) (length > *(int*) voidPtr);
                if (*(sbyte*) ((IntPtr) voidPtr + 29) != (sbyte) 0)
                  length = *(int*) voidPtr;
                *(sbyte*) ((IntPtr) voidPtr + 30) = (sbyte) (length > num2);
                if (*(sbyte*) ((IntPtr) voidPtr + 30) != (sbyte) 0)
                  length = num2;
                Array.Copy((Array) class18_0.byte_0, int1_1, (Array) class11_0.byte_0, *(int*) ((IntPtr) voidPtr + 4), length);
                int1_1 += length;
                *(int*) voidPtr = *(int*) voidPtr - length;
                *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + length;
                num2 -= length;
                int num5;
                class11_0.int_3 = num5 = class11_0.int_3 - length;
                *(sbyte*) ((IntPtr) voidPtr + 31) = (sbyte) ((uint) num5 > 0U);
                continue;
              }
              goto label_68;
            case 3:
              goto label_33;
            case 4:
              goto label_26;
            case 5:
              goto label_19;
            case 6:
              goto label_1;
            case 7:
              goto label_84;
            case 8:
              goto label_87;
            case 9:
              goto label_88;
            default:
              goto label_63;
          }
        }
        while (*(sbyte*) ((IntPtr) voidPtr + 31) != (sbyte) 0);
        goto label_49;
label_1:
        class11_0.int_11 = int_1_1;
        class11_0.int_10 = num1;
        class18_0.int_2 = *(int*) voidPtr;
        class18_0.long_0 += (long) (int1_1 - class18_0.int_1);
        class18_0.int_1 = int1_1;
        class11_0.int_15 = *(int*) ((IntPtr) voidPtr + 4);
        if ((int_0 = Class73.smethod_12(int_0, class11_0.class12_0, class11_0, class18_0)) == 1)
        {
          int_0 = 0;
          Class73.smethod_143(class11_0.class12_0, class18_0);
          int1_1 = class18_0.int_1;
          *(int*) voidPtr = class18_0.int_2;
          int_1_1 = class11_0.int_11;
          num1 = class11_0.int_10;
          *(int*) ((IntPtr) voidPtr + 4) = class11_0.int_15;
          num2 = *(int*) ((IntPtr) voidPtr + 4) < class11_0.int_14 ? class11_0.int_14 - *(int*) ((IntPtr) voidPtr + 4) - 1 : class11_0.int_13 - *(int*) ((IntPtr) voidPtr + 4);
          *(sbyte*) ((IntPtr) voidPtr + 50) = (sbyte) (class11_0.int_9 == 0);
          if (*(sbyte*) ((IntPtr) voidPtr + 50) != (sbyte) 0)
          {
            class11_0.int_2 = 0;
            continue;
          }
          goto label_83;
        }
        else
          goto label_82;
label_19:
        while (true)
        {
          *(sbyte*) ((IntPtr) voidPtr + 47) = (sbyte) 1;
          int int4_1 = class11_0.int_4;
          *(sbyte*) ((IntPtr) voidPtr + 40) = (sbyte) (class11_0.int_5 >= 258 + (int4_1 & 31) + (int4_1 >> 5 & 31));
          if (*(sbyte*) ((IntPtr) voidPtr + 40) == (sbyte) 0)
          {
            int index1 = class11_0.int_7[0];
            while (true)
            {
              *(sbyte*) ((IntPtr) voidPtr + 42) = (sbyte) (num1 < index1);
              if (*(sbyte*) ((IntPtr) voidPtr + 42) != (sbyte) 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 41) = (sbyte) ((uint) *(int*) voidPtr > 0U);
                if (*(sbyte*) ((IntPtr) voidPtr + 41) != (sbyte) 0)
                {
                  int_0 = 0;
                  *(int*) voidPtr = *(int*) voidPtr - 1;
                  int_1_1 |= ((int) class18_0.byte_0[int1_1++] & (int) byte.MaxValue) << num1;
                  num1 += 8;
                }
                else
                  goto label_81;
              }
              else
                break;
            }
            *(sbyte*) ((IntPtr) voidPtr + 43) = (sbyte) (class11_0.int_8[0] == -1);
            if (*(sbyte*) ((IntPtr) voidPtr + 43) != (sbyte) 0)
              ;
            int int_0_1 = class11_0.int_12[(class11_0.int_8[0] + (int_1_1 & Class11.int_0[index1])) * 3 + 1];
            int num5 = class11_0.int_12[(class11_0.int_8[0] + (int_1_1 & Class11.int_0[int_0_1])) * 3 + 2];
            *(sbyte*) ((IntPtr) voidPtr + 44) = (sbyte) (num5 < 16);
            if (*(sbyte*) ((IntPtr) voidPtr + 44) != (sbyte) 0)
            {
              int_1_1 = Class73.smethod_108(int_0_1, int_1_1);
              num1 -= int_0_1;
              int[] int6 = class11_0.int_6;
              Class11 class11 = class11_0;
              int int5 = class11_0.int_5;
              int num6 = int5 + 1;
              class11.int_5 = num6;
              int index2 = int5;
              int num7 = num5;
              int6[index2] = num7;
            }
            else
            {
              int int_0_2 = num5 == 18 ? 7 : num5 - 14;
              int num6 = num5 == 18 ? 11 : 3;
              while (true)
              {
                *(sbyte*) ((IntPtr) voidPtr + 46) = (sbyte) (num1 < int_0_1 + int_0_2);
                if (*(sbyte*) ((IntPtr) voidPtr + 46) != (sbyte) 0)
                {
                  *(sbyte*) ((IntPtr) voidPtr + 45) = (sbyte) ((uint) *(int*) voidPtr > 0U);
                  if (*(sbyte*) ((IntPtr) voidPtr + 45) != (sbyte) 0)
                  {
                    int_0 = 0;
                    *(int*) voidPtr = *(int*) voidPtr - 1;
                    int_1_1 |= ((int) class18_0.byte_0[int1_1++] & (int) byte.MaxValue) << num1;
                    num1 += 8;
                  }
                  else
                    goto label_80;
                }
                else
                  break;
              }
              int int_1_2 = Class73.smethod_108(int_0_1, int_1_1);
              int num7 = num1 - int_0_1;
              int num8 = num6 + (int_1_2 & Class11.int_0[int_0_2]);
              int_1_1 = Class73.smethod_108(int_0_2, int_1_2);
              num1 = num7 - int_0_2;
              int int5 = class11_0.int_5;
              int int4_2 = class11_0.int_4;
              if ((int5 + num8 > 258 + (int4_2 & 31) + (int4_2 >> 5 & 31) ? 1 : (num5 != 16 ? 0 : (int5 < 1 ? 1 : 0))) == 0)
              {
                int num9 = num5 == 16 ? class11_0.int_6[int5 - 1] : 0;
                do
                {
                  class11_0.int_6[int5++] = num9;
                }
                while ((uint) --num8 > 0U);
                class11_0.int_5 = int5;
              }
              else
                goto label_79;
            }
          }
          else
            break;
        }
        class11_0.int_8[0] = -1;
        int[] int_6 = new int[1];
        int[] int_7 = new int[1];
        int[] int_4 = new int[1];
        int[] int_0_3 = new int[1];
        int_6[0] = 9;
        int_7[0] = 6;
        int int4 = class11_0.int_4;
        int[] int6_1 = class11_0.int_6;
        int[] int12_1 = class11_0.int_12;
        num3 = Class73.smethod_121(int_0_3, int12_1, int6_1, class18_0, 257 + (int4 & 31), int_4, 1 + (int4 >> 5 & 31), int_6, int_7);
        *(sbyte*) ((IntPtr) voidPtr + 48) = (sbyte) ((uint) num3 > 0U);
        if (*(sbyte*) ((IntPtr) voidPtr + 48) == (sbyte) 0)
        {
          class11_0.class12_0 = new Class12(int_6[0], int_7[0], class11_0.int_12, int_4[0], class11_0.int_12, int_0_3[0], class18_0);
          class11_0.int_6 = (int[]) null;
          class11_0.int_2 = 6;
          goto label_1;
        }
        else
          goto label_76;
label_26:
        while (true)
        {
          *(sbyte*) ((IntPtr) voidPtr + 36) = (sbyte) (class11_0.int_5 < 4 + Class73.smethod_108(10, class11_0.int_4));
          if (*(sbyte*) ((IntPtr) voidPtr + 36) != (sbyte) 0)
          {
            while (true)
            {
              *(sbyte*) ((IntPtr) voidPtr + 35) = (sbyte) (num1 < 3);
              if (*(sbyte*) ((IntPtr) voidPtr + 35) != (sbyte) 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 34) = (sbyte) ((uint) *(int*) voidPtr > 0U);
                if (*(sbyte*) ((IntPtr) voidPtr + 34) != (sbyte) 0)
                {
                  int_0 = 0;
                  *(int*) voidPtr = *(int*) voidPtr - 1;
                  int_1_1 |= ((int) class18_0.byte_0[int1_1++] & (int) byte.MaxValue) << num1;
                  num1 += 8;
                }
                else
                  goto label_75;
              }
              else
                break;
            }
            int[] int6_2 = class11_0.int_6;
            int[] int1_2 = Class11.int_1;
            Class11 class11 = class11_0;
            int int5 = class11_0.int_5;
            int num5 = int5 + 1;
            class11.int_5 = num5;
            int index1 = int5;
            int index2 = int1_2[index1];
            int num6 = int_1_1 & 7;
            int6_2[index2] = num6;
            int_1_1 = Class73.smethod_108(3, int_1_1);
            num1 -= 3;
          }
          else
            break;
        }
        while (true)
        {
          *(sbyte*) ((IntPtr) voidPtr + 37) = (sbyte) (class11_0.int_5 < 19);
          if (*(sbyte*) ((IntPtr) voidPtr + 37) != (sbyte) 0)
          {
            int[] int6_2 = class11_0.int_6;
            int[] int1_2 = Class11.int_1;
            Class11 class11 = class11_0;
            int int5 = class11_0.int_5;
            int num5 = int5 + 1;
            class11.int_5 = num5;
            int index1 = int5;
            int index2 = int1_2[index1];
            int6_2[index2] = 0;
          }
          else
            break;
        }
        class11_0.int_7[0] = 7;
        int[] int6_3 = class11_0.int_6;
        int[] int7 = class11_0.int_7;
        int[] int8 = class11_0.int_8;
        int[] int12_2 = class11_0.int_12;
        num4 = Class73.smethod_100(int8, int6_3, int12_2, int7, class18_0);
        *(sbyte*) ((IntPtr) voidPtr + 38) = (sbyte) ((uint) num4 > 0U);
        if (*(sbyte*) ((IntPtr) voidPtr + 38) == (sbyte) 0)
        {
          class11_0.int_5 = 0;
          class11_0.int_2 = 5;
          goto label_19;
        }
        else
          goto label_72;
label_33:
        while (true)
        {
          *(sbyte*) ((IntPtr) voidPtr + 33) = (sbyte) (num1 < 14);
          if (*(sbyte*) ((IntPtr) voidPtr + 33) != (sbyte) 0)
          {
            *(sbyte*) ((IntPtr) voidPtr + 32) = (sbyte) ((uint) *(int*) voidPtr > 0U);
            if (*(sbyte*) ((IntPtr) voidPtr + 32) != (sbyte) 0)
            {
              int_0 = 0;
              *(int*) voidPtr = *(int*) voidPtr - 1;
              int_1_1 |= ((int) class18_0.byte_0[int1_1++] & (int) byte.MaxValue) << num1;
              num1 += 8;
            }
            else
              goto label_71;
          }
          else
            break;
        }
        int num10;
        class11_0.int_4 = num10 = int_1_1 & 16383;
        if (((num10 & 31) > 29 ? 1 : ((num10 >> 5 & 31) > 29 ? 1 : 0)) == 0)
        {
          int length = 258 + (num10 & 31) + (num10 >> 5 & 31);
          class11_0.int_6 = new int[length];
          int_1_1 = Class73.smethod_108(14, int_1_1);
          num1 -= 14;
          class11_0.int_5 = 0;
          class11_0.int_2 = 4;
          goto label_26;
        }
        else
          goto label_70;
label_49:
        class11_0.int_2 = class11_0.int_9 != 0 ? 7 : 0;
        continue;
label_52:
        while (true)
        {
          *(sbyte*) ((IntPtr) voidPtr + 23) = (sbyte) (num1 < 32);
          if (*(sbyte*) ((IntPtr) voidPtr + 23) != (sbyte) 0)
          {
            *(sbyte*) ((IntPtr) voidPtr + 22) = (sbyte) ((uint) *(int*) voidPtr > 0U);
            if (*(sbyte*) ((IntPtr) voidPtr + 22) != (sbyte) 0)
            {
              int_0 = 0;
              *(int*) voidPtr = *(int*) voidPtr - 1;
              int_1_1 |= ((int) class18_0.byte_0[int1_1++] & (int) byte.MaxValue) << num1;
              num1 += 8;
            }
            else
              goto label_67;
          }
          else
            break;
        }
        *(sbyte*) ((IntPtr) voidPtr + 24) = (sbyte) ((Class73.smethod_108(16, ~int_1_1) & (int) ushort.MaxValue) != (int_1_1 & (int) ushort.MaxValue));
        if (*(sbyte*) ((IntPtr) voidPtr + 24) == (sbyte) 0)
        {
          class11_0.int_3 = int_1_1 & (int) ushort.MaxValue;
          num1 = 0;
          int_1_1 = 0;
          class11_0.int_2 = class11_0.int_3 != 0 ? 2 : (class11_0.int_9 != 0 ? 7 : 0);
          continue;
        }
        goto label_66;
label_57:
        while (true)
        {
          *(sbyte*) ((IntPtr) voidPtr + 21) = (sbyte) (num1 < 3);
          if (*(sbyte*) ((IntPtr) voidPtr + 21) != (sbyte) 0)
          {
            *(sbyte*) ((IntPtr) voidPtr + 20) = (sbyte) ((uint) *(int*) voidPtr > 0U);
            if (*(sbyte*) ((IntPtr) voidPtr + 20) != (sbyte) 0)
            {
              int_0 = 0;
              *(int*) voidPtr = *(int*) voidPtr - 1;
              int_1_1 |= ((int) class18_0.byte_0[int1_1++] & (int) byte.MaxValue) << num1;
              num1 += 8;
            }
            else
              goto label_65;
          }
          else
            break;
        }
        int int_1_3 = int_1_1 & 7;
        class11_0.int_9 = int_1_3 & 1;
        *(int*) ((IntPtr) voidPtr + 16) = Class73.smethod_108(1, int_1_3);
        switch (*(int*) ((IntPtr) voidPtr + 16))
        {
          case 0:
            int int_1_4 = Class73.smethod_108(3, int_1_1);
            int num11 = num1 - 3;
            int int_0_4 = num11 & 7;
            int_1_1 = Class73.smethod_108(int_0_4, int_1_4);
            num1 = num11 - int_0_4;
            class11_0.int_2 = 1;
            continue;
          case 1:
            int[] int_1_5 = new int[1];
            int[] int_0_5 = new int[1];
            int[][] int_2 = new int[1][];
            int[][] int_3 = new int[1][];
            Class73.smethod_4(class18_0, int_0_5, int_1_5, int_2, int_3);
            class11_0.class12_0 = new Class12(int_1_5[0], int_0_5[0], int_2[0], int_3[0], class18_0);
            int_1_1 = Class73.smethod_108(3, int_1_1);
            num1 -= 3;
            class11_0.int_2 = 6;
            continue;
          case 2:
            int_1_1 = Class73.smethod_108(3, int_1_1);
            num1 -= 3;
            class11_0.int_2 = 3;
            continue;
          case 3:
            goto label_64;
          default:
            continue;
        }
      }
label_63:
      int_0 = -2;
      class11_0.int_11 = int_1_1;
      class11_0.int_10 = num1;
      class18_0.int_2 = *(int*) voidPtr;
      class18_0.long_0 += (long) (int1_1 - class18_0.int_1);
      class18_0.int_1 = int1_1;
      class11_0.int_15 = *(int*) ((IntPtr) voidPtr + 4);
      *(int*) ((IntPtr) voidPtr + 12) = Class73.smethod_144(-2, class11_0, class18_0);
      goto label_89;
label_64:
      int num12 = Class73.smethod_108(3, int_1_1);
      int num13 = num1 - 3;
      class11_0.int_2 = 9;
      class18_0.string_0 = "invalid block type";
      int_0 = -3;
      class11_0.int_11 = num12;
      class11_0.int_10 = num13;
      class18_0.int_2 = *(int*) voidPtr;
      class18_0.long_0 += (long) (int1_1 - class18_0.int_1);
      class18_0.int_1 = int1_1;
      class11_0.int_15 = *(int*) ((IntPtr) voidPtr + 4);
      *(int*) ((IntPtr) voidPtr + 12) = Class73.smethod_144(-3, class11_0, class18_0);
      goto label_89;
label_65:
      class11_0.int_11 = int_1_1;
      class11_0.int_10 = num1;
      class18_0.int_2 = *(int*) voidPtr;
      class18_0.long_0 += (long) (int1_1 - class18_0.int_1);
      class18_0.int_1 = int1_1;
      class11_0.int_15 = *(int*) ((IntPtr) voidPtr + 4);
      *(int*) ((IntPtr) voidPtr + 12) = Class73.smethod_144(int_0, class11_0, class18_0);
      goto label_89;
label_66:
      class11_0.int_2 = 9;
      class18_0.string_0 = "invalid stored block lengths";
      int_0 = -3;
      class11_0.int_11 = int_1_1;
      class11_0.int_10 = num1;
      class18_0.int_2 = *(int*) voidPtr;
      class18_0.long_0 += (long) (int1_1 - class18_0.int_1);
      class18_0.int_1 = int1_1;
      class11_0.int_15 = *(int*) ((IntPtr) voidPtr + 4);
      *(int*) ((IntPtr) voidPtr + 12) = Class73.smethod_144(-3, class11_0, class18_0);
      goto label_89;
label_67:
      class11_0.int_11 = int_1_1;
      class11_0.int_10 = num1;
      class18_0.int_2 = *(int*) voidPtr;
      class18_0.long_0 += (long) (int1_1 - class18_0.int_1);
      class18_0.int_1 = int1_1;
      class11_0.int_15 = *(int*) ((IntPtr) voidPtr + 4);
      *(int*) ((IntPtr) voidPtr + 12) = Class73.smethod_144(int_0, class11_0, class18_0);
      goto label_89;
label_68:
      class11_0.int_11 = int_1_1;
      class11_0.int_10 = num1;
      class18_0.int_2 = *(int*) voidPtr;
      class18_0.long_0 += (long) (int1_1 - class18_0.int_1);
      class18_0.int_1 = int1_1;
      class11_0.int_15 = *(int*) ((IntPtr) voidPtr + 4);
      *(int*) ((IntPtr) voidPtr + 12) = Class73.smethod_144(int_0, class11_0, class18_0);
      goto label_89;
label_69:
      class11_0.int_11 = int_1_1;
      class11_0.int_10 = num1;
      class18_0.int_2 = *(int*) voidPtr;
      class18_0.long_0 += (long) (int1_1 - class18_0.int_1);
      class18_0.int_1 = int1_1;
      class11_0.int_15 = *(int*) ((IntPtr) voidPtr + 4);
      *(int*) ((IntPtr) voidPtr + 12) = Class73.smethod_144(int_0, class11_0, class18_0);
      goto label_89;
label_70:
      class11_0.int_2 = 9;
      class18_0.string_0 = "too many length or distance symbols";
      int_0 = -3;
      class11_0.int_11 = int_1_1;
      class11_0.int_10 = num1;
      class18_0.int_2 = *(int*) voidPtr;
      class18_0.long_0 += (long) (int1_1 - class18_0.int_1);
      class18_0.int_1 = int1_1;
      class11_0.int_15 = *(int*) ((IntPtr) voidPtr + 4);
      *(int*) ((IntPtr) voidPtr + 12) = Class73.smethod_144(-3, class11_0, class18_0);
      goto label_89;
label_71:
      class11_0.int_11 = int_1_1;
      class11_0.int_10 = num1;
      class18_0.int_2 = *(int*) voidPtr;
      class18_0.long_0 += (long) (int1_1 - class18_0.int_1);
      class18_0.int_1 = int1_1;
      class11_0.int_15 = *(int*) ((IntPtr) voidPtr + 4);
      *(int*) ((IntPtr) voidPtr + 12) = Class73.smethod_144(int_0, class11_0, class18_0);
      goto label_89;
label_72:
      int_0 = num4;
      *(sbyte*) ((IntPtr) voidPtr + 39) = (sbyte) (int_0 == -3);
      if (*(sbyte*) ((IntPtr) voidPtr + 39) != (sbyte) 0)
      {
        class11_0.int_6 = (int[]) null;
        class11_0.int_2 = 9;
      }
      class11_0.int_11 = int_1_1;
      class11_0.int_10 = num1;
      class18_0.int_2 = *(int*) voidPtr;
      class18_0.long_0 += (long) (int1_1 - class18_0.int_1);
      class18_0.int_1 = int1_1;
      class11_0.int_15 = *(int*) ((IntPtr) voidPtr + 4);
      *(int*) ((IntPtr) voidPtr + 12) = Class73.smethod_144(int_0, class11_0, class18_0);
      goto label_89;
label_75:
      class11_0.int_11 = int_1_1;
      class11_0.int_10 = num1;
      class18_0.int_2 = *(int*) voidPtr;
      class18_0.long_0 += (long) (int1_1 - class18_0.int_1);
      class18_0.int_1 = int1_1;
      class11_0.int_15 = *(int*) ((IntPtr) voidPtr + 4);
      *(int*) ((IntPtr) voidPtr + 12) = Class73.smethod_144(int_0, class11_0, class18_0);
      goto label_89;
label_76:
      *(sbyte*) ((IntPtr) voidPtr + 49) = (sbyte) (num3 == -3);
      if (*(sbyte*) ((IntPtr) voidPtr + 49) != (sbyte) 0)
      {
        class11_0.int_6 = (int[]) null;
        class11_0.int_2 = 9;
      }
      int_0 = num3;
      class11_0.int_11 = int_1_1;
      class11_0.int_10 = num1;
      class18_0.int_2 = *(int*) voidPtr;
      class18_0.long_0 += (long) (int1_1 - class18_0.int_1);
      class18_0.int_1 = int1_1;
      class11_0.int_15 = *(int*) ((IntPtr) voidPtr + 4);
      *(int*) ((IntPtr) voidPtr + 12) = Class73.smethod_144(int_0, class11_0, class18_0);
      goto label_89;
label_79:
      class11_0.int_6 = (int[]) null;
      class11_0.int_2 = 9;
      class18_0.string_0 = "invalid bit length repeat";
      int_0 = -3;
      class11_0.int_11 = int_1_1;
      class11_0.int_10 = num1;
      class18_0.int_2 = *(int*) voidPtr;
      class18_0.long_0 += (long) (int1_1 - class18_0.int_1);
      class18_0.int_1 = int1_1;
      class11_0.int_15 = *(int*) ((IntPtr) voidPtr + 4);
      *(int*) ((IntPtr) voidPtr + 12) = Class73.smethod_144(-3, class11_0, class18_0);
      goto label_89;
label_80:
      class11_0.int_11 = int_1_1;
      class11_0.int_10 = num1;
      class18_0.int_2 = *(int*) voidPtr;
      class18_0.long_0 += (long) (int1_1 - class18_0.int_1);
      class18_0.int_1 = int1_1;
      class11_0.int_15 = *(int*) ((IntPtr) voidPtr + 4);
      *(int*) ((IntPtr) voidPtr + 12) = Class73.smethod_144(int_0, class11_0, class18_0);
      goto label_89;
label_81:
      class11_0.int_11 = int_1_1;
      class11_0.int_10 = num1;
      class18_0.int_2 = *(int*) voidPtr;
      class18_0.long_0 += (long) (int1_1 - class18_0.int_1);
      class18_0.int_1 = int1_1;
      class11_0.int_15 = *(int*) ((IntPtr) voidPtr + 4);
      *(int*) ((IntPtr) voidPtr + 12) = Class73.smethod_144(int_0, class11_0, class18_0);
      goto label_89;
label_82:
      *(int*) ((IntPtr) voidPtr + 12) = Class73.smethod_144(int_0, class11_0, class18_0);
      goto label_89;
label_83:
      class11_0.int_2 = 7;
label_84:
      class11_0.int_15 = *(int*) ((IntPtr) voidPtr + 4);
      int_0 = Class73.smethod_144(int_0, class11_0, class18_0);
      *(int*) ((IntPtr) voidPtr + 4) = class11_0.int_15;
      int num14 = *(int*) ((IntPtr) voidPtr + 4) < class11_0.int_14 ? class11_0.int_14 - *(int*) ((IntPtr) voidPtr + 4) - 1 : class11_0.int_13 - *(int*) ((IntPtr) voidPtr + 4);
      *(sbyte*) ((IntPtr) voidPtr + 51) = (sbyte) (class11_0.int_14 != class11_0.int_15);
      if (*(sbyte*) ((IntPtr) voidPtr + 51) != (sbyte) 0)
      {
        class11_0.int_11 = int_1_1;
        class11_0.int_10 = num1;
        class18_0.int_2 = *(int*) voidPtr;
        class18_0.long_0 += (long) (int1_1 - class18_0.int_1);
        class18_0.int_1 = int1_1;
        class11_0.int_15 = *(int*) ((IntPtr) voidPtr + 4);
        *(int*) ((IntPtr) voidPtr + 12) = Class73.smethod_144(int_0, class11_0, class18_0);
        goto label_89;
      }
      else
        class11_0.int_2 = 8;
label_87:
      int_0 = 1;
      class11_0.int_11 = int_1_1;
      class11_0.int_10 = num1;
      class18_0.int_2 = *(int*) voidPtr;
      class18_0.long_0 += (long) (int1_1 - class18_0.int_1);
      class18_0.int_1 = int1_1;
      class11_0.int_15 = *(int*) ((IntPtr) voidPtr + 4);
      *(int*) ((IntPtr) voidPtr + 12) = Class73.smethod_144(1, class11_0, class18_0);
      goto label_89;
label_88:
      int_0 = -3;
      class11_0.int_11 = int_1_1;
      class11_0.int_10 = num1;
      class18_0.int_2 = *(int*) voidPtr;
      class18_0.long_0 += (long) (int1_1 - class18_0.int_1);
      class18_0.int_1 = int1_1;
      class11_0.int_15 = *(int*) ((IntPtr) voidPtr + 4);
      *(int*) ((IntPtr) voidPtr + 12) = Class73.smethod_144(-3, class11_0, class18_0);
label_89:
      return *(int*) ((IntPtr) voidPtr + 12);
    }

    static void smethod_183(int int_0, Class19 class19_0, int int_1)
    {
      Class1 class1_0 = new Class1((ushort) 28688);
      Class73.smethod_65((ushort) 7, class1_0);
      Class73.smethod_198(class1_0, (object) int_1);
      Class73.smethod_173((object) int_0, class1_0);
      class19_0.method_1(class1_0);
    }

    static string smethod_184(string string_0)
    {
      return Class73.smethod_78(BitConverter.ToString(new SHA256Managed().ComputeHash(Class73.smethod_50(string_0))));
    }

    static void smethod_185(Class4 class4_0, ref ulong ulong_0, uint uint_0, byte byte_0)
    {
      byte[] bytes = BitConverter.GetBytes(ulong_0);
      bytes[0] ^= (byte) ((uint) bytes[0] + (uint) Class73.smethod_51(Class73.smethod_209(uint_0)) + (uint) byte_0);
      bytes[1] ^= (byte) ((uint) bytes[1] + (uint) Class73.smethod_110(Class73.smethod_209(uint_0)) + (uint) byte_0);
      bytes[2] ^= (byte) ((uint) bytes[2] + (uint) Class73.smethod_51(Class73.smethod_174(uint_0)) + (uint) byte_0);
      bytes[3] ^= (byte) ((uint) bytes[3] + (uint) Class73.smethod_110(Class73.smethod_174(uint_0)) + (uint) byte_0);
      bytes[4] ^= (byte) ((uint) bytes[4] + (uint) Class73.smethod_51(Class73.smethod_209(uint_0)) + (uint) byte_0);
      bytes[5] ^= (byte) ((uint) bytes[5] + (uint) Class73.smethod_110(Class73.smethod_209(uint_0)) + (uint) byte_0);
      bytes[6] ^= (byte) ((uint) bytes[6] + (uint) Class73.smethod_51(Class73.smethod_174(uint_0)) + (uint) byte_0);
      bytes[7] ^= (byte) ((uint) bytes[7] + (uint) Class73.smethod_110(Class73.smethod_174(uint_0)) + (uint) byte_0);
      ulong_0 = BitConverter.ToUInt64(bytes, 0);
    }

    static bool smethod_186(Class1 class1_0)
    {
      return class1_0.bool_0;
    }

    static unsafe uint[] smethod_187()
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(25);
      uint[] numArray = new uint[65536];
      using (MemoryStream memoryStream = new MemoryStream(new byte[1024]
      {
        (byte) 177,
        (byte) 214,
        (byte) 139,
        (byte) 150,
        (byte) 150,
        (byte) 48,
        (byte) 7,
        (byte) 119,
        (byte) 44,
        (byte) 97,
        (byte) 14,
        (byte) 238,
        (byte) 186,
        (byte) 81,
        (byte) 9,
        (byte) 153,
        (byte) 25,
        (byte) 196,
        (byte) 109,
        (byte) 7,
        (byte) 143,
        (byte) 244,
        (byte) 106,
        (byte) 112,
        (byte) 53,
        (byte) 165,
        (byte) 99,
        (byte) 233,
        (byte) 163,
        (byte) 149,
        (byte) 100,
        (byte) 158,
        (byte) 50,
        (byte) 136,
        (byte) 219,
        (byte) 14,
        (byte) 164,
        (byte) 184,
        (byte) 220,
        (byte) 121,
        (byte) 30,
        (byte) 233,
        (byte) 213,
        (byte) 224,
        (byte) 136,
        (byte) 217,
        (byte) 210,
        (byte) 151,
        (byte) 43,
        (byte) 76,
        (byte) 182,
        (byte) 9,
        (byte) 189,
        (byte) 124,
        (byte) 177,
        (byte) 126,
        (byte) 7,
        (byte) 45,
        (byte) 184,
        (byte) 231,
        (byte) 145,
        (byte) 29,
        (byte) 191,
        (byte) 144,
        (byte) 100,
        (byte) 16,
        (byte) 183,
        (byte) 29,
        (byte) 242,
        (byte) 32,
        (byte) 176,
        (byte) 106,
        (byte) 72,
        (byte) 113,
        (byte) 177,
        (byte) 243,
        (byte) 222,
        (byte) 65,
        (byte) 190,
        (byte) 140,
        (byte) 125,
        (byte) 212,
        (byte) 218,
        (byte) 26,
        (byte) 235,
        (byte) 228,
        (byte) 221,
        (byte) 109,
        (byte) 81,
        (byte) 181,
        (byte) 212,
        (byte) 244,
        (byte) 199,
        (byte) 133,
        (byte) 211,
        (byte) 131,
        (byte) 86,
        (byte) 152,
        (byte) 108,
        (byte) 19,
        (byte) 192,
        (byte) 168,
        (byte) 107,
        (byte) 100,
        (byte) 122,
        (byte) 249,
        (byte) 98,
        (byte) 253,
        (byte) 236,
        (byte) 201,
        (byte) 101,
        (byte) 138,
        (byte) 79,
        (byte) 92,
        (byte) 1,
        (byte) 20,
        (byte) 217,
        (byte) 108,
        (byte) 6,
        (byte) 99,
        (byte) 99,
        (byte) 61,
        (byte) 15,
        (byte) 250,
        (byte) 245,
        (byte) 13,
        (byte) 8,
        (byte) 141,
        (byte) 200,
        (byte) 32,
        (byte) 110,
        (byte) 59,
        (byte) 94,
        (byte) 16,
        (byte) 105,
        (byte) 76,
        (byte) 228,
        (byte) 65,
        (byte) 96,
        (byte) 213,
        (byte) 114,
        (byte) 113,
        (byte) 103,
        (byte) 162,
        (byte) 209,
        (byte) 228,
        (byte) 3,
        (byte) 60,
        (byte) 71,
        (byte) 212,
        (byte) 4,
        (byte) 75,
        (byte) 253,
        (byte) 133,
        (byte) 13,
        (byte) 210,
        (byte) 107,
        (byte) 181,
        (byte) 10,
        (byte) 165,
        (byte) 250,
        (byte) 168,
        (byte) 181,
        (byte) 53,
        (byte) 108,
        (byte) 152,
        (byte) 178,
        (byte) 66,
        (byte) 214,
        (byte) 201,
        (byte) 187,
        (byte) 219,
        (byte) 64,
        (byte) 249,
        (byte) 188,
        (byte) 172,
        (byte) 227,
        (byte) 108,
        (byte) 216,
        (byte) 50,
        (byte) 117,
        (byte) 92,
        (byte) 223,
        (byte) 69,
        (byte) 207,
        (byte) 13,
        (byte) 214,
        (byte) 220,
        (byte) 89,
        (byte) 61,
        (byte) 209,
        (byte) 171,
        (byte) 172,
        (byte) 48,
        (byte) 217,
        (byte) 38,
        (byte) 58,
        (byte) 0,
        (byte) 222,
        (byte) 81,
        (byte) 128,
        (byte) 81,
        (byte) 215,
        (byte) 200,
        (byte) 22,
        (byte) 97,
        (byte) 208,
        (byte) 191,
        (byte) 181,
        (byte) 244,
        (byte) 180,
        (byte) 33,
        (byte) 35,
        (byte) 196,
        (byte) 179,
        (byte) 86,
        (byte) 153,
        (byte) 149,
        (byte) 186,
        (byte) 207,
        (byte) 15,
        (byte) 165,
        (byte) 183,
        (byte) 184,
        (byte) 158,
        (byte) 184,
        (byte) 2,
        (byte) 40,
        (byte) 8,
        (byte) 136,
        (byte) 5,
        (byte) 95,
        (byte) 178,
        (byte) 217,
        (byte) 236,
        (byte) 198,
        (byte) 36,
        (byte) 233,
        (byte) 11,
        (byte) 177,
        (byte) 135,
        (byte) 124,
        (byte) 111,
        (byte) 47,
        (byte) 17,
        (byte) 76,
        (byte) 104,
        (byte) 88,
        (byte) 171,
        (byte) 29,
        (byte) 97,
        (byte) 193,
        (byte) 61,
        (byte) 45,
        (byte) 102,
        (byte) 182,
        (byte) 144,
        (byte) 65,
        (byte) 220,
        (byte) 118,
        (byte) 6,
        (byte) 113,
        (byte) 219,
        (byte) 1,
        (byte) 188,
        (byte) 32,
        (byte) 210,
        (byte) 152,
        (byte) 42,
        (byte) 16,
        (byte) 213,
        (byte) 239,
        (byte) 137,
        (byte) 133,
        (byte) 177,
        (byte) 113,
        (byte) 31,
        (byte) 181,
        (byte) 182,
        (byte) 6,
        (byte) 165,
        (byte) 228,
        (byte) 191,
        (byte) 159,
        (byte) 51,
        (byte) 212,
        (byte) 184,
        (byte) 232,
        (byte) 162,
        (byte) 201,
        (byte) 7,
        (byte) 120,
        (byte) 52,
        (byte) 249,
        (byte) 160,
        (byte) 15,
        (byte) 142,
        (byte) 168,
        (byte) 9,
        (byte) 150,
        (byte) 24,
        (byte) 152,
        (byte) 14,
        (byte) 225,
        (byte) 187,
        (byte) 13,
        (byte) 106,
        (byte) 127,
        (byte) 45,
        (byte) 61,
        (byte) 109,
        (byte) 8,
        (byte) 151,
        (byte) 108,
        (byte) 100,
        (byte) 145,
        (byte) 1,
        (byte) 92,
        (byte) 99,
        (byte) 230,
        (byte) 244,
        (byte) 81,
        (byte) 107,
        (byte) 107,
        (byte) 98,
        (byte) 97,
        (byte) 108,
        (byte) 28,
        (byte) 216,
        (byte) 48,
        (byte) 101,
        (byte) 133,
        (byte) 78,
        (byte) 0,
        (byte) 98,
        (byte) 242,
        (byte) 237,
        (byte) 149,
        (byte) 6,
        (byte) 108,
        (byte) 123,
        (byte) 165,
        (byte) 1,
        (byte) 27,
        (byte) 193,
        (byte) 244,
        (byte) 8,
        (byte) 130,
        (byte) 87,
        (byte) 196,
        (byte) 15,
        (byte) 245,
        (byte) 198,
        (byte) 217,
        (byte) 176,
        (byte) 99,
        (byte) 80,
        (byte) 233,
        (byte) 183,
        (byte) 18,
        (byte) 234,
        (byte) 184,
        (byte) 190,
        (byte) 139,
        (byte) 124,
        (byte) 136,
        (byte) 185,
        (byte) 252,
        (byte) 223,
        (byte) 29,
        (byte) 221,
        (byte) 98,
        (byte) 73,
        (byte) 45,
        (byte) 218,
        (byte) 21,
        (byte) 243,
        (byte) 124,
        (byte) 211,
        (byte) 140,
        (byte) 101,
        (byte) 76,
        (byte) 212,
        (byte) 251,
        (byte) 88,
        (byte) 97,
        (byte) 178,
        (byte) 77,
        (byte) 206,
        (byte) 81,
        (byte) 181,
        (byte) 58,
        (byte) 116,
        (byte) 0,
        (byte) 188,
        (byte) 163,
        (byte) 226,
        (byte) 48,
        (byte) 187,
        (byte) 212,
        (byte) 65,
        (byte) 165,
        (byte) 223,
        (byte) 74,
        (byte) 215,
        (byte) 149,
        (byte) 216,
        (byte) 61,
        (byte) 109,
        (byte) 196,
        (byte) 209,
        (byte) 164,
        (byte) 251,
        (byte) 244,
        (byte) 214,
        (byte) 211,
        (byte) 106,
        (byte) 233,
        (byte) 105,
        (byte) 67,
        (byte) 252,
        (byte) 217,
        (byte) 110,
        (byte) 52,
        (byte) 70,
        (byte) 136,
        (byte) 103,
        (byte) 173,
        (byte) 208,
        (byte) 184,
        (byte) 96,
        (byte) 218,
        (byte) 115,
        (byte) 45,
        (byte) 4,
        (byte) 68,
        (byte) 229,
        (byte) 29,
        (byte) 3,
        (byte) 51,
        (byte) 95,
        (byte) 76,
        (byte) 10,
        (byte) 170,
        (byte) 201,
        (byte) 124,
        (byte) 13,
        (byte) 221,
        (byte) 60,
        (byte) 113,
        (byte) 5,
        (byte) 80,
        (byte) 170,
        (byte) 65,
        (byte) 2,
        (byte) 39,
        (byte) 16,
        (byte) 16,
        (byte) 11,
        (byte) 190,
        (byte) 134,
        (byte) 32,
        (byte) 12,
        (byte) 201,
        (byte) 37,
        (byte) 181,
        (byte) 104,
        (byte) 87,
        (byte) 179,
        (byte) 133,
        (byte) 111,
        (byte) 32,
        (byte) 9,
        (byte) 212,
        (byte) 102,
        (byte) 185,
        (byte) 159,
        (byte) 228,
        (byte) 97,
        (byte) 206,
        (byte) 14,
        (byte) 249,
        (byte) 222,
        (byte) 94,
        (byte) 8,
        (byte) 201,
        (byte) 217,
        (byte) 41,
        (byte) 34,
        (byte) 152,
        (byte) 208,
        (byte) 176,
        (byte) 180,
        (byte) 168,
        (byte) 87,
        (byte) 199,
        (byte) 23,
        (byte) 61,
        (byte) 179,
        (byte) 89,
        (byte) 129,
        (byte) 13,
        (byte) 180,
        (byte) 62,
        (byte) 59,
        (byte) 92,
        (byte) 189,
        (byte) 183,
        (byte) 173,
        (byte) 108,
        (byte) 186,
        (byte) 192,
        (byte) 32,
        (byte) 131,
        (byte) 184,
        (byte) 237,
        (byte) 182,
        (byte) 179,
        (byte) 191,
        (byte) 154,
        (byte) 12,
        (byte) 226,
        (byte) 182,
        (byte) 3,
        (byte) 154,
        (byte) 210,
        (byte) 177,
        (byte) 116,
        (byte) 57,
        (byte) 71,
        (byte) 213,
        (byte) 234,
        (byte) 175,
        (byte) 119,
        (byte) 210,
        (byte) 157,
        (byte) 21,
        (byte) 38,
        (byte) 219,
        (byte) 4,
        (byte) 131,
        (byte) 22,
        (byte) 220,
        (byte) 115,
        (byte) 18,
        (byte) 11,
        (byte) 99,
        (byte) 227,
        (byte) 132,
        (byte) 59,
        (byte) 100,
        (byte) 148,
        (byte) 62,
        (byte) 106,
        (byte) 109,
        (byte) 13,
        (byte) 168,
        (byte) 90,
        (byte) 106,
        (byte) 122,
        (byte) 11,
        (byte) 207,
        (byte) 14,
        (byte) 228,
        (byte) 157,
        byte.MaxValue,
        (byte) 9,
        (byte) 147,
        (byte) 39,
        (byte) 174,
        (byte) 0,
        (byte) 10,
        (byte) 177,
        (byte) 158,
        (byte) 7,
        (byte) 125,
        (byte) 68,
        (byte) 147,
        (byte) 15,
        (byte) 240,
        (byte) 210,
        (byte) 162,
        (byte) 8,
        (byte) 135,
        (byte) 104,
        (byte) 242,
        (byte) 1,
        (byte) 30,
        (byte) 254,
        (byte) 194,
        (byte) 6,
        (byte) 105,
        (byte) 93,
        (byte) 87,
        (byte) 98,
        (byte) 247,
        (byte) 203,
        (byte) 103,
        (byte) 101,
        (byte) 128,
        (byte) 113,
        (byte) 54,
        (byte) 108,
        (byte) 25,
        (byte) 231,
        (byte) 6,
        (byte) 107,
        (byte) 110,
        (byte) 118,
        (byte) 27,
        (byte) 212,
        (byte) 254,
        (byte) 224,
        (byte) 43,
        (byte) 211,
        (byte) 137,
        (byte) 90,
        (byte) 122,
        (byte) 218,
        (byte) 16,
        (byte) 204,
        (byte) 74,
        (byte) 221,
        (byte) 103,
        (byte) 111,
        (byte) 223,
        (byte) 185,
        (byte) 249,
        (byte) 249,
        (byte) 239,
        (byte) 190,
        (byte) 142,
        (byte) 67,
        (byte) 190,
        (byte) 183,
        (byte) 23,
        (byte) 213,
        (byte) 142,
        (byte) 176,
        (byte) 96,
        (byte) 232,
        (byte) 163,
        (byte) 214,
        (byte) 214,
        (byte) 126,
        (byte) 147,
        (byte) 209,
        (byte) 161,
        (byte) 196,
        (byte) 194,
        (byte) 216,
        (byte) 56,
        (byte) 82,
        (byte) 242,
        (byte) 223,
        (byte) 79,
        (byte) 241,
        (byte) 103,
        (byte) 187,
        (byte) 209,
        (byte) 103,
        (byte) 87,
        (byte) 188,
        (byte) 166,
        (byte) 221,
        (byte) 6,
        (byte) 181,
        (byte) 63,
        (byte) 75,
        (byte) 54,
        (byte) 178,
        (byte) 72,
        (byte) 218,
        (byte) 43,
        (byte) 13,
        (byte) 216,
        (byte) 76,
        (byte) 27,
        (byte) 10,
        (byte) 175,
        (byte) 246,
        (byte) 74,
        (byte) 3,
        (byte) 54,
        (byte) 96,
        (byte) 122,
        (byte) 4,
        (byte) 65,
        (byte) 195,
        (byte) 239,
        (byte) 96,
        (byte) 223,
        (byte) 85,
        (byte) 223,
        (byte) 103,
        (byte) 168,
        (byte) 239,
        (byte) 142,
        (byte) 110,
        (byte) 49,
        (byte) 121,
        (byte) 14,
        (byte) 105,
        (byte) 70,
        (byte) 140,
        (byte) 179,
        (byte) 81,
        (byte) 203,
        (byte) 26,
        (byte) 131,
        (byte) 99,
        (byte) 188,
        (byte) 160,
        (byte) 210,
        (byte) 111,
        (byte) 37,
        (byte) 54,
        (byte) 226,
        (byte) 104,
        (byte) 82,
        (byte) 149,
        (byte) 119,
        (byte) 12,
        (byte) 204,
        (byte) 3,
        (byte) 71,
        (byte) 11,
        (byte) 187,
        (byte) 185,
        (byte) 20,
        (byte) 2,
        (byte) 34,
        (byte) 47,
        (byte) 38,
        (byte) 5,
        (byte) 85,
        (byte) 190,
        (byte) 59,
        (byte) 182,
        (byte) 197,
        (byte) 40,
        (byte) 11,
        (byte) 189,
        (byte) 178,
        (byte) 146,
        (byte) 90,
        (byte) 180,
        (byte) 43,
        (byte) 4,
        (byte) 106,
        (byte) 179,
        (byte) 92,
        (byte) 167,
        byte.MaxValue,
        (byte) 215,
        (byte) 194,
        (byte) 49,
        (byte) 207,
        (byte) 208,
        (byte) 181,
        (byte) 139,
        (byte) 158,
        (byte) 217,
        (byte) 44,
        (byte) 29,
        (byte) 174,
        (byte) 222,
        (byte) 91,
        (byte) 176,
        (byte) 114,
        (byte) 100,
        (byte) 155,
        (byte) 38,
        (byte) 242,
        (byte) 227,
        (byte) 236,
        (byte) 156,
        (byte) 163,
        (byte) 106,
        (byte) 117,
        (byte) 10,
        (byte) 147,
        (byte) 109,
        (byte) 2,
        (byte) 169,
        (byte) 6,
        (byte) 9,
        (byte) 156,
        (byte) 63,
        (byte) 54,
        (byte) 14,
        (byte) 235,
        (byte) 133,
        (byte) 104,
        (byte) 7,
        (byte) 114,
        (byte) 19,
        (byte) 7,
        (byte) 0,
        (byte) 5,
        (byte) 130,
        (byte) 72,
        (byte) 191,
        (byte) 149,
        (byte) 20,
        (byte) 122,
        (byte) 184,
        (byte) 226,
        (byte) 174,
        (byte) 43,
        (byte) 177,
        (byte) 123,
        (byte) 56,
        (byte) 27,
        (byte) 182,
        (byte) 12,
        (byte) 155,
        (byte) 142,
        (byte) 210,
        (byte) 146,
        (byte) 13,
        (byte) 190,
        (byte) 213,
        (byte) 229,
        (byte) 183,
        (byte) 239,
        (byte) 220,
        (byte) 124,
        (byte) 33,
        (byte) 223,
        (byte) 219,
        (byte) 11,
        (byte) 148,
        (byte) 210,
        (byte) 211,
        (byte) 134,
        (byte) 66,
        (byte) 226,
        (byte) 212,
        (byte) 241,
        (byte) 248,
        (byte) 179,
        (byte) 221,
        (byte) 104,
        (byte) 110,
        (byte) 131,
        (byte) 218,
        (byte) 31,
        (byte) 205,
        (byte) 22,
        (byte) 190,
        (byte) 129,
        (byte) 91,
        (byte) 38,
        (byte) 185,
        (byte) 246,
        (byte) 225,
        (byte) 119,
        (byte) 176,
        (byte) 111,
        (byte) 119,
        (byte) 71,
        (byte) 183,
        (byte) 24,
        (byte) 224,
        (byte) 90,
        (byte) 8,
        (byte) 136,
        (byte) 112,
        (byte) 106,
        (byte) 15,
        (byte) 241,
        (byte) 202,
        (byte) 59,
        (byte) 6,
        (byte) 102,
        (byte) 92,
        (byte) 11,
        (byte) 1,
        (byte) 17,
        byte.MaxValue,
        (byte) 158,
        (byte) 101,
        (byte) 143,
        (byte) 105,
        (byte) 174,
        (byte) 98,
        (byte) 248,
        (byte) 211,
        byte.MaxValue,
        (byte) 107,
        (byte) 97,
        (byte) 69,
        (byte) 207,
        (byte) 108,
        (byte) 22,
        (byte) 120,
        (byte) 226,
        (byte) 10,
        (byte) 160,
        (byte) 238,
        (byte) 210,
        (byte) 13,
        (byte) 215,
        (byte) 84,
        (byte) 131,
        (byte) 4,
        (byte) 78,
        (byte) 194,
        (byte) 179,
        (byte) 3,
        (byte) 57,
        (byte) 97,
        (byte) 38,
        (byte) 103,
        (byte) 167,
        (byte) 247,
        (byte) 22,
        (byte) 96,
        (byte) 208,
        (byte) 77,
        (byte) 71,
        (byte) 105,
        (byte) 73,
        (byte) 219,
        (byte) 119,
        (byte) 110,
        (byte) 62,
        (byte) 74,
        (byte) 106,
        (byte) 209,
        (byte) 174,
        (byte) 220,
        (byte) 90,
        (byte) 214,
        (byte) 217,
        (byte) 102,
        (byte) 11,
        (byte) 223,
        (byte) 64,
        (byte) 240,
        (byte) 59,
        (byte) 216,
        (byte) 55,
        (byte) 83,
        (byte) 174,
        (byte) 188,
        (byte) 169,
        (byte) 197,
        (byte) 158,
        (byte) 187,
        (byte) 222,
        (byte) 127,
        (byte) 207,
        (byte) 178,
        (byte) 71,
        (byte) 233,
        byte.MaxValue,
        (byte) 181,
        (byte) 48,
        (byte) 28,
        (byte) 249,
        (byte) 189,
        (byte) 189,
        (byte) 138,
        (byte) 205,
        (byte) 186,
        (byte) 202,
        (byte) 48,
        (byte) 158,
        (byte) 179,
        (byte) 83,
        (byte) 166,
        (byte) 163,
        (byte) 188,
        (byte) 36,
        (byte) 5,
        (byte) 59,
        (byte) 208,
        (byte) 186,
        (byte) 163,
        (byte) 6,
        (byte) 215,
        (byte) 205,
        (byte) 233,
        (byte) 87,
        (byte) 222,
        (byte) 84,
        (byte) 191,
        (byte) 103,
        (byte) 217,
        (byte) 35,
        (byte) 46,
        (byte) 114,
        (byte) 102,
        (byte) 179,
        (byte) 184,
        (byte) 74,
        (byte) 97,
        (byte) 196,
        (byte) 2,
        (byte) 27,
        (byte) 56,
        (byte) 93,
        (byte) 148,
        (byte) 43,
        (byte) 111,
        (byte) 43,
        (byte) 55,
        (byte) 190,
        (byte) 203,
        (byte) 180,
        (byte) 161,
        (byte) 142,
        (byte) 204,
        (byte) 195,
        (byte) 27,
        (byte) 223,
        (byte) 13,
        (byte) 90,
        (byte) 141,
        (byte) 237,
        (byte) 2,
        (byte) 45
      }, false))
      {
        using (BinaryReader binaryReader = new BinaryReader((Stream) memoryStream))
        {
          int num = 0;
          *(int*) voidPtr = 0;
          while (true)
          {
            *(sbyte*) ((IntPtr) voidPtr + 24) = (sbyte) (*(int*) voidPtr < 1024);
            if (*(sbyte*) ((IntPtr) voidPtr + 24) != (sbyte) 0)
            {
              *(int*) ((IntPtr) voidPtr + 4) = (int) binaryReader.ReadUInt32();
              *(int*) ((IntPtr) voidPtr + 8) = 0;
              while (true)
              {
                *(sbyte*) ((IntPtr) voidPtr + 23) = (sbyte) (*(uint*) ((IntPtr) voidPtr + 8) < 256U);
                if (*(sbyte*) ((IntPtr) voidPtr + 23) != (sbyte) 0)
                {
                  *(int*) ((IntPtr) voidPtr + 12) = (int) (*(uint*) ((IntPtr) voidPtr + 8) >> 1);
                  *(sbyte*) ((IntPtr) voidPtr + 20) = (sbyte) ((*(uint*) ((IntPtr) voidPtr + 8) & 1U) > 0U);
                  if (*(sbyte*) ((IntPtr) voidPtr + 20) != (sbyte) 0)
                    *(int*) ((IntPtr) voidPtr + 12) = (int) *(uint*) ((IntPtr) voidPtr + 12) ^ (int) *(uint*) ((IntPtr) voidPtr + 4);
                  *(int*) ((IntPtr) voidPtr + 16) = 0;
                  while (true)
                  {
                    *(sbyte*) ((IntPtr) voidPtr + 22) = (sbyte) (*(int*) ((IntPtr) voidPtr + 16) < 7);
                    if (*(sbyte*) ((IntPtr) voidPtr + 22) != (sbyte) 0)
                    {
                      *(sbyte*) ((IntPtr) voidPtr + 21) = (sbyte) ((*(uint*) ((IntPtr) voidPtr + 12) & 1U) > 0U);
                      if (*(sbyte*) ((IntPtr) voidPtr + 21) != (sbyte) 0)
                      {
                        *(int*) ((IntPtr) voidPtr + 12) = (int) (*(uint*) ((IntPtr) voidPtr + 12) >> 1);
                        *(int*) ((IntPtr) voidPtr + 12) = (int) *(uint*) ((IntPtr) voidPtr + 12) ^ (int) *(uint*) ((IntPtr) voidPtr + 4);
                      }
                      else
                        *(int*) ((IntPtr) voidPtr + 12) = (int) (*(uint*) ((IntPtr) voidPtr + 12) >> 1);
                      *(int*) ((IntPtr) voidPtr + 16) = *(int*) ((IntPtr) voidPtr + 16) + 1;
                    }
                    else
                      break;
                  }
                  numArray[num++] = *(uint*) ((IntPtr) voidPtr + 12);
                  *(int*) ((IntPtr) voidPtr + 8) = (int) *(uint*) ((IntPtr) voidPtr + 8) + 1;
                }
                else
                  break;
              }
              *(int*) voidPtr = *(int*) voidPtr + 4;
            }
            else
              break;
          }
        }
      }
      return numArray;
    }

    static unsafe void smethod_188(Class9 class9_0, int int_0, int int_1, bool bool_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(17);
      *(int*) voidPtr = 0;
      *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) (class9_0.int_27 > 0);
      int num1;
      int num2;
      if (*(sbyte*) ((IntPtr) voidPtr + 12) != (sbyte) 0)
      {
        *(sbyte*) ((IntPtr) voidPtr + 13) = (sbyte) (class9_0.byte_1 == (byte) 2);
        if (*(sbyte*) ((IntPtr) voidPtr + 13) != (sbyte) 0)
          Class73.smethod_104(class9_0);
        Class73.smethod_32(class9_0.class17_0, class9_0);
        Class73.smethod_32(class9_0.class17_1, class9_0);
        *(int*) voidPtr = Class73.smethod_106(class9_0);
        num1 = Class73.smethod_108(3, class9_0.int_38 + 3 + 7);
        num2 = Class73.smethod_108(3, class9_0.int_39 + 3 + 7);
        *(sbyte*) ((IntPtr) voidPtr + 14) = (sbyte) (num2 <= num1);
        if (*(sbyte*) ((IntPtr) voidPtr + 14) != (sbyte) 0)
          num1 = num2;
      }
      else
        num1 = num2 = int_1 + 5;
      if ((int_1 + 4 > num1 ? 0 : (int_0 != -1 ? 1 : 0)) != 0)
      {
        Class73.smethod_196(int_0, bool_0, int_1, class9_0);
      }
      else
      {
        *(sbyte*) ((IntPtr) voidPtr + 15) = (sbyte) (num2 == num1);
        if (*(sbyte*) ((IntPtr) voidPtr + 15) != (sbyte) 0)
        {
          Class73.smethod_61(class9_0, 2 + (bool_0 ? 1 : 0), 3);
          short[] short0 = Class15.short_0;
          short[] short1 = Class15.short_1;
          Class73.smethod_105(short0, class9_0, short1);
        }
        else
        {
          Class73.smethod_61(class9_0, 4 + (bool_0 ? 1 : 0), 3);
          *(int*) ((IntPtr) voidPtr + 4) = class9_0.class17_0.int_7 + 1;
          *(int*) ((IntPtr) voidPtr + 8) = class9_0.class17_1.int_7 + 1;
          Class73.smethod_28(*(int*) voidPtr + 1, class9_0, *(int*) ((IntPtr) voidPtr + 8), *(int*) ((IntPtr) voidPtr + 4));
          short[] short2 = class9_0.short_2;
          short[] short3 = class9_0.short_3;
          Class73.smethod_105(short2, class9_0, short3);
        }
      }
      Class73.smethod_208(class9_0);
      *(sbyte*) ((IntPtr) voidPtr + 16) = (sbyte) bool_0;
      if (*(sbyte*) ((IntPtr) voidPtr + 16) == (sbyte) 0)
        return;
      Class73.smethod_43(class9_0);
    }

    static int smethod_189(Class18 class18_0, Class13 class13_0)
    {
      int num;
      if ((class18_0 == null ? 1 : (class18_0.class13_0 == null ? 1 : 0)) != 0)
      {
        num = -2;
      }
      else
      {
        Class18 class18 = class18_0;
        class18_0.long_1 = 0L;
        class18.long_0 = 0L;
        class18_0.string_0 = (string) null;
        class18_0.class13_0.int_0 = class18_0.class13_0.int_3 != 0 ? 7 : 0;
        Class73.smethod_227(class18_0, (long[]) null, class18_0.class13_0.class11_0);
        num = 0;
      }
      return num;
    }

    static unsafe byte smethod_190(byte[] byte_0, Class4 class4_0, int int_0, int int_1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(14);
      *(int*) voidPtr = -1;
      *(int*) ((IntPtr) voidPtr + 4) = (int) class4_0.uint_8 << 8;
      *(int*) ((IntPtr) voidPtr + 8) = int_0;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) (*(int*) ((IntPtr) voidPtr + 8) < int_0 + int_1);
        if (*(sbyte*) ((IntPtr) voidPtr + 12) != (sbyte) 0)
        {
          *(int*) voidPtr = (int) (*(uint*) voidPtr >> 8) ^ (int) Class4.uint_0[(int) *(uint*) ((IntPtr) voidPtr + 4) + (((int) byte_0[*(int*) ((IntPtr) voidPtr + 8)] ^ (int) *(uint*) voidPtr) & (int) byte.MaxValue)];
          *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) + 1;
        }
        else
          break;
      }
      *(sbyte*) ((IntPtr) voidPtr + 13) = (sbyte) (byte) (((int) (*(uint*) voidPtr >> 24) & (int) byte.MaxValue) + ((int) (*(uint*) voidPtr >> 8) & (int) byte.MaxValue) + ((int) (*(uint*) voidPtr >> 16) & (int) byte.MaxValue) + ((int) *(uint*) voidPtr & (int) byte.MaxValue));
      return *(byte*) ((IntPtr) voidPtr + 13);
    }

    static unsafe int smethod_191(
      int int_0,
      int int_1,
      int int_2,
      int[] int_3,
      int int_4,
      int[] int_5,
      Class18 class18_0,
      Class11 class11_0,
      Class12 class12_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(45);
      int int1 = class18_0.int_1;
      *(int*) ((IntPtr) voidPtr + 12) = class18_0.int_2;
      int num1 = class11_0.int_11;
      *(int*) ((IntPtr) voidPtr + 8) = class11_0.int_10;
      int destinationIndex = class11_0.int_15;
      int num2 = destinationIndex < class11_0.int_14 ? class11_0.int_14 - destinationIndex - 1 : class11_0.int_13 - destinationIndex;
      *(int*) ((IntPtr) voidPtr + 16) = Class12.int_0[int_1];
      *(int*) ((IntPtr) voidPtr + 20) = Class12.int_0[int_4];
      int index1;
      int num3;
      while (true)
      {
        do
        {
          *(sbyte*) ((IntPtr) voidPtr + 32) = (sbyte) (*(int*) ((IntPtr) voidPtr + 8) < 20);
          if (*(sbyte*) ((IntPtr) voidPtr + 32) == (sbyte) 0)
          {
            *(int*) voidPtr = num1 & *(int*) ((IntPtr) voidPtr + 16);
            int[] numArray1 = int_3;
            *(int*) ((IntPtr) voidPtr + 4) = int_2;
            if ((index1 = numArray1[(*(int*) ((IntPtr) voidPtr + 4) + *(int*) voidPtr) * 3]) == 0)
            {
              num1 >>= numArray1[(*(int*) ((IntPtr) voidPtr + 4) + *(int*) voidPtr) * 3 + 1];
              *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) - numArray1[(*(int*) ((IntPtr) voidPtr + 4) + *(int*) voidPtr) * 3 + 1];
              class11_0.byte_0[destinationIndex++] = (byte) numArray1[(*(int*) ((IntPtr) voidPtr + 4) + *(int*) voidPtr) * 3 + 2];
              --num2;
            }
            else
            {
              while (true)
              {
                num1 >>= numArray1[(*(int*) ((IntPtr) voidPtr + 4) + *(int*) voidPtr) * 3 + 1];
                *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) - numArray1[(*(int*) ((IntPtr) voidPtr + 4) + *(int*) voidPtr) * 3 + 1];
                *(sbyte*) ((IntPtr) voidPtr + 33) = (sbyte) ((uint) (index1 & 16) > 0U);
                if (*(sbyte*) ((IntPtr) voidPtr + 33) == (sbyte) 0)
                {
                  *(sbyte*) ((IntPtr) voidPtr + 42) = (sbyte) ((index1 & 64) == 0);
                  if (*(sbyte*) ((IntPtr) voidPtr + 42) != (sbyte) 0)
                  {
                    *(int*) voidPtr = *(int*) voidPtr + numArray1[(*(int*) ((IntPtr) voidPtr + 4) + *(int*) voidPtr) * 3 + 2];
                    *(int*) voidPtr = *(int*) voidPtr + (num1 & Class12.int_0[index1]);
                    if ((index1 = numArray1[(*(int*) ((IntPtr) voidPtr + 4) + *(int*) voidPtr) * 3]) != 0)
                      *(sbyte*) ((IntPtr) voidPtr + 44) = (sbyte) 1;
                    else
                      goto label_32;
                  }
                  else
                    goto label_37;
                }
                else
                  break;
              }
              int index2 = index1 & 15;
              int length1 = numArray1[(*(int*) ((IntPtr) voidPtr + 4) + *(int*) voidPtr) * 3 + 2] + (num1 & Class12.int_0[index2]);
              num3 = num1 >> index2;
              *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) - index2;
              while (true)
              {
                *(sbyte*) ((IntPtr) voidPtr + 34) = (sbyte) (*(int*) ((IntPtr) voidPtr + 8) < 15);
                if (*(sbyte*) ((IntPtr) voidPtr + 34) != (sbyte) 0)
                {
                  *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) - 1;
                  num3 |= ((int) class18_0.byte_0[int1++] & (int) byte.MaxValue) << *(int*) ((IntPtr) voidPtr + 8);
                  *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) + 8;
                }
                else
                  break;
              }
              *(int*) voidPtr = num3 & *(int*) ((IntPtr) voidPtr + 20);
              int[] numArray2 = int_5;
              *(int*) ((IntPtr) voidPtr + 4) = int_0;
              int index3 = numArray2[(*(int*) ((IntPtr) voidPtr + 4) + *(int*) voidPtr) * 3];
              while (true)
              {
                num3 >>= numArray2[(*(int*) ((IntPtr) voidPtr + 4) + *(int*) voidPtr) * 3 + 1];
                *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) - numArray2[(*(int*) ((IntPtr) voidPtr + 4) + *(int*) voidPtr) * 3 + 1];
                *(sbyte*) ((IntPtr) voidPtr + 35) = (sbyte) ((uint) (index3 & 16) > 0U);
                if (*(sbyte*) ((IntPtr) voidPtr + 35) == (sbyte) 0)
                {
                  *(sbyte*) ((IntPtr) voidPtr + 40) = (sbyte) ((index3 & 64) == 0);
                  if (*(sbyte*) ((IntPtr) voidPtr + 40) != (sbyte) 0)
                  {
                    *(int*) voidPtr = *(int*) voidPtr + numArray2[(*(int*) ((IntPtr) voidPtr + 4) + *(int*) voidPtr) * 3 + 2];
                    *(int*) voidPtr = *(int*) voidPtr + (num3 & Class12.int_0[index3]);
                    index3 = numArray2[(*(int*) ((IntPtr) voidPtr + 4) + *(int*) voidPtr) * 3];
                    *(sbyte*) ((IntPtr) voidPtr + 41) = (sbyte) 1;
                  }
                  else
                    goto label_35;
                }
                else
                  break;
              }
              int index4 = index3 & 15;
              while (true)
              {
                *(sbyte*) ((IntPtr) voidPtr + 36) = (sbyte) (*(int*) ((IntPtr) voidPtr + 8) < index4);
                if (*(sbyte*) ((IntPtr) voidPtr + 36) != (sbyte) 0)
                {
                  *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) - 1;
                  num3 |= ((int) class18_0.byte_0[int1++] & (int) byte.MaxValue) << *(int*) ((IntPtr) voidPtr + 8);
                  *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) + 8;
                }
                else
                  break;
              }
              *(int*) ((IntPtr) voidPtr + 24) = numArray2[(*(int*) ((IntPtr) voidPtr + 4) + *(int*) voidPtr) * 3 + 2] + (num3 & Class12.int_0[index4]);
              num1 = num3 >> index4;
              *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) - index4;
              num2 -= length1;
              *(sbyte*) ((IntPtr) voidPtr + 37) = (sbyte) (destinationIndex >= *(int*) ((IntPtr) voidPtr + 24));
              int sourceIndex1;
              int num4;
              if (*(sbyte*) ((IntPtr) voidPtr + 37) != (sbyte) 0)
              {
                int sourceIndex2 = destinationIndex - *(int*) ((IntPtr) voidPtr + 24);
                if ((destinationIndex - sourceIndex2 <= 0 ? 0 : (2 > destinationIndex - sourceIndex2 ? 1 : 0)) != 0)
                {
                  byte[] byte0_1 = class11_0.byte_0;
                  int index5 = destinationIndex;
                  int num5 = index5 + 1;
                  byte[] byte0_2 = class11_0.byte_0;
                  int index6 = sourceIndex2;
                  int num6 = index6 + 1;
                  int num7 = (int) byte0_2[index6];
                  byte0_1[index5] = (byte) num7;
                  int num8 = length1 - 1;
                  byte[] byte0_3 = class11_0.byte_0;
                  int index7 = num5;
                  destinationIndex = index7 + 1;
                  byte[] byte0_4 = class11_0.byte_0;
                  int index8 = num6;
                  sourceIndex1 = index8 + 1;
                  int num9 = (int) byte0_4[index8];
                  byte0_3[index7] = (byte) num9;
                  length1 = num8 - 1;
                }
                else
                {
                  Array.Copy((Array) class11_0.byte_0, sourceIndex2, (Array) class11_0.byte_0, destinationIndex, 2);
                  destinationIndex += 2;
                  sourceIndex1 = sourceIndex2 + 2;
                  length1 -= 2;
                }
              }
              else
              {
                sourceIndex1 = destinationIndex - *(int*) ((IntPtr) voidPtr + 24);
                do
                {
                  sourceIndex1 += class11_0.int_13;
                  *(sbyte*) ((IntPtr) voidPtr + 38) = (sbyte) (sourceIndex1 < 0);
                }
                while (*(sbyte*) ((IntPtr) voidPtr + 38) != (sbyte) 0);
                int length2 = class11_0.int_13 - sourceIndex1;
                *(sbyte*) ((IntPtr) voidPtr + 39) = (sbyte) (length1 > length2);
                if (*(sbyte*) ((IntPtr) voidPtr + 39) != (sbyte) 0)
                {
                  length1 -= length2;
                  if ((destinationIndex - sourceIndex1 <= 0 ? 0 : (length2 > destinationIndex - sourceIndex1 ? 1 : 0)) != 0)
                  {
                    do
                    {
                      class11_0.byte_0[destinationIndex++] = class11_0.byte_0[sourceIndex1++];
                    }
                    while ((uint) --length2 > 0U);
                  }
                  else
                  {
                    Array.Copy((Array) class11_0.byte_0, sourceIndex1, (Array) class11_0.byte_0, destinationIndex, length2);
                    destinationIndex += length2;
                    num4 = sourceIndex1 + length2;
                  }
                  sourceIndex1 = 0;
                }
              }
              if ((destinationIndex - sourceIndex1 <= 0 ? 0 : (length1 > destinationIndex - sourceIndex1 ? 1 : 0)) != 0)
              {
                do
                {
                  class11_0.byte_0[destinationIndex++] = class11_0.byte_0[sourceIndex1++];
                }
                while ((uint) --length1 > 0U);
                goto label_33;
              }
              else
              {
                Array.Copy((Array) class11_0.byte_0, sourceIndex1, (Array) class11_0.byte_0, destinationIndex, length1);
                destinationIndex += length1;
                num4 = sourceIndex1 + length1;
                goto label_33;
              }
label_32:
              num1 >>= numArray1[(*(int*) ((IntPtr) voidPtr + 4) + *(int*) voidPtr) * 3 + 1];
              *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) - numArray1[(*(int*) ((IntPtr) voidPtr + 4) + *(int*) voidPtr) * 3 + 1];
              class11_0.byte_0[destinationIndex++] = (byte) numArray1[(*(int*) ((IntPtr) voidPtr + 4) + *(int*) voidPtr) * 3 + 2];
              --num2;
            }
label_33:;
          }
          else
            goto label_1;
        }
        while ((num2 < 258 ? 0 : (*(int*) ((IntPtr) voidPtr + 12) >= 10 ? 1 : 0)) != 0);
        goto label_36;
label_1:
        *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) - 1;
        num1 |= ((int) class18_0.byte_0[int1++] & (int) byte.MaxValue) << *(int*) ((IntPtr) voidPtr + 8);
        *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) + 8;
      }
label_35:
      class18_0.string_0 = "invalid distance code";
      int num10 = class18_0.int_2 - *(int*) ((IntPtr) voidPtr + 12);
      int num11 = *(int*) ((IntPtr) voidPtr + 8) >> 3 < num10 ? *(int*) ((IntPtr) voidPtr + 8) >> 3 : num10;
      *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + num11;
      int num12 = int1 - num11;
      *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) - (num11 << 3);
      class11_0.int_11 = num3;
      class11_0.int_10 = *(int*) ((IntPtr) voidPtr + 8);
      class18_0.int_2 = *(int*) ((IntPtr) voidPtr + 12);
      class18_0.long_0 += (long) (num12 - class18_0.int_1);
      class18_0.int_1 = num12;
      class11_0.int_15 = destinationIndex;
      *(int*) ((IntPtr) voidPtr + 28) = -3;
      goto label_40;
label_36:
      int num13 = class18_0.int_2 - *(int*) ((IntPtr) voidPtr + 12);
      int num14 = *(int*) ((IntPtr) voidPtr + 8) >> 3 < num13 ? *(int*) ((IntPtr) voidPtr + 8) >> 3 : num13;
      *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + num14;
      int num15 = int1 - num14;
      *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) - (num14 << 3);
      class11_0.int_11 = num1;
      class11_0.int_10 = *(int*) ((IntPtr) voidPtr + 8);
      class18_0.int_2 = *(int*) ((IntPtr) voidPtr + 12);
      class18_0.long_0 += (long) (num15 - class18_0.int_1);
      class18_0.int_1 = num15;
      class11_0.int_15 = destinationIndex;
      *(int*) ((IntPtr) voidPtr + 28) = 0;
      goto label_40;
label_37:
      *(sbyte*) ((IntPtr) voidPtr + 43) = (sbyte) ((uint) (index1 & 32) > 0U);
      if (*(sbyte*) ((IntPtr) voidPtr + 43) != (sbyte) 0)
      {
        int num4 = class18_0.int_2 - *(int*) ((IntPtr) voidPtr + 12);
        int num5 = *(int*) ((IntPtr) voidPtr + 8) >> 3 < num4 ? *(int*) ((IntPtr) voidPtr + 8) >> 3 : num4;
        *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + num5;
        int num6 = int1 - num5;
        *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) - (num5 << 3);
        class11_0.int_11 = num1;
        class11_0.int_10 = *(int*) ((IntPtr) voidPtr + 8);
        class18_0.int_2 = *(int*) ((IntPtr) voidPtr + 12);
        class18_0.long_0 += (long) (num6 - class18_0.int_1);
        class18_0.int_1 = num6;
        class11_0.int_15 = destinationIndex;
        *(int*) ((IntPtr) voidPtr + 28) = 1;
      }
      else
      {
        class18_0.string_0 = "invalid literal/length code";
        int num4 = class18_0.int_2 - *(int*) ((IntPtr) voidPtr + 12);
        int num5 = *(int*) ((IntPtr) voidPtr + 8) >> 3 < num4 ? *(int*) ((IntPtr) voidPtr + 8) >> 3 : num4;
        *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + num5;
        int num6 = int1 - num5;
        *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) - (num5 << 3);
        class11_0.int_11 = num1;
        class11_0.int_10 = *(int*) ((IntPtr) voidPtr + 8);
        class18_0.int_2 = *(int*) ((IntPtr) voidPtr + 12);
        class18_0.long_0 += (long) (num6 - class18_0.int_1);
        class18_0.int_1 = num6;
        class11_0.int_15 = destinationIndex;
        *(int*) ((IntPtr) voidPtr + 28) = -3;
      }
label_40:
      return *(int*) ((IntPtr) voidPtr + 28);
    }

    static unsafe List<Class1> smethod_192(Class4 class4_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      List<Class1> class1List = (List<Class1>) null;
      object object0 = class4_0.object_0;
      *(sbyte*) voidPtr = (sbyte) 0;
      try
      {
        Monitor.Enter(object0, ref *(bool*) voidPtr);
        *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (class4_0.list_0.Count > 0);
        if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
        {
          class1List = class4_0.list_0;
          class4_0.list_0 = new List<Class1>();
        }
      }
      finally
      {
        if (*(sbyte*) voidPtr != (sbyte) 0)
          Monitor.Exit(object0);
      }
      return class1List;
    }

    static void smethod_193(Class19 class19_0, string string_0)
    {
      Class1 class1_0 = new Class1((ushort) 28688);
      Class73.smethod_65((ushort) 17, class1_0);
      Class73.smethod_120(class1_0, string_0);
      class19_0.method_1(class1_0);
    }

    static unsafe int smethod_194(
      int[] int_0,
      int int_1,
      int int_2,
      int int_3,
      int[] int_4,
      int[] int_5,
      int[] int_6,
      int[] int_7,
      int[] int_8,
      int[] int_9,
      int[] int_10)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(43);
      int[] numArray1 = new int[16];
      int[] numArray2 = new int[3];
      int[] numArray3 = new int[15];
      int[] numArray4 = new int[16];
      int num1 = 0;
      int num2 = int_2;
      do
      {
        ++numArray1[int_0[int_1 + num1]];
        ++num1;
        --num2;
        *(sbyte*) ((IntPtr) voidPtr + 24) = (sbyte) ((uint) num2 > 0U);
      }
      while (*(sbyte*) ((IntPtr) voidPtr + 24) != (sbyte) 0);
      *(sbyte*) ((IntPtr) voidPtr + 25) = (sbyte) (numArray1[0] == int_2);
      int num3;
      if (*(sbyte*) ((IntPtr) voidPtr + 25) != (sbyte) 0)
      {
        int_6[0] = -1;
        int_7[0] = 0;
        num3 = 0;
      }
      else
      {
        *(int*) ((IntPtr) voidPtr + 12) = int_7[0];
        int index1 = 1;
        while (true)
        {
          *(sbyte*) ((IntPtr) voidPtr + 27) = (sbyte) (index1 <= 15);
          if (*(sbyte*) ((IntPtr) voidPtr + 27) != (sbyte) 0)
          {
            *(sbyte*) ((IntPtr) voidPtr + 26) = (sbyte) ((uint) numArray1[index1] > 0U);
            if (*(sbyte*) ((IntPtr) voidPtr + 26) == (sbyte) 0)
              ++index1;
            else
              break;
          }
          else
            break;
        }
        *(int*) ((IntPtr) voidPtr + 8) = index1;
        *(sbyte*) ((IntPtr) voidPtr + 28) = (sbyte) (*(int*) ((IntPtr) voidPtr + 12) < index1);
        if (*(sbyte*) ((IntPtr) voidPtr + 28) != (sbyte) 0)
          *(int*) ((IntPtr) voidPtr + 12) = index1;
        int index2 = 15;
        while (true)
        {
          *(sbyte*) ((IntPtr) voidPtr + 30) = (sbyte) ((uint) index2 > 0U);
          if (*(sbyte*) ((IntPtr) voidPtr + 30) != (sbyte) 0)
          {
            *(sbyte*) ((IntPtr) voidPtr + 29) = (sbyte) ((uint) numArray1[index2] > 0U);
            if (*(sbyte*) ((IntPtr) voidPtr + 29) == (sbyte) 0)
              --index2;
            else
              break;
          }
          else
            break;
        }
        *(int*) voidPtr = index2;
        *(sbyte*) ((IntPtr) voidPtr + 31) = (sbyte) (*(int*) ((IntPtr) voidPtr + 12) > index2);
        if (*(sbyte*) ((IntPtr) voidPtr + 31) != (sbyte) 0)
          *(int*) ((IntPtr) voidPtr + 12) = index2;
        int_7[0] = *(int*) ((IntPtr) voidPtr + 12);
        int num4 = 1 << index1;
        while (true)
        {
          *(sbyte*) ((IntPtr) voidPtr + 32) = (sbyte) (index1 < index2);
          if (*(sbyte*) ((IntPtr) voidPtr + 32) != (sbyte) 0)
          {
            int num5;
            if ((num5 = num4 - numArray1[index1]) >= 0)
            {
              ++index1;
              num4 = num5 << 1;
            }
            else
              goto label_59;
          }
          else
            break;
        }
        int num6;
        if ((num6 = num4 - numArray1[index2]) < 0)
        {
          num3 = -3;
          goto label_60;
        }
        else
        {
          numArray1[index2] += num6;
          int[] numArray5 = numArray4;
          int num5 = 0;
          numArray5[1] = 0;
          int index3 = 1;
          int index4 = 2;
          while ((uint) --index2 > 0U)
          {
            numArray4[index4] = (num5 += numArray1[index3]);
            ++index4;
            ++index3;
          }
          int num7 = 0;
          int num8 = 0;
          do
          {
            int index5;
            if ((uint) (index5 = int_0[int_1 + num8]) > 0U)
              goto label_27;
label_26:
            ++num8;
            continue;
label_27:
            int_10[numArray4[index5]++] = num7;
            goto label_26;
          }
          while (++num7 < int_2);
          int_2 = numArray4[*(int*) voidPtr];
          int[] numArray6 = numArray4;
          int int_1_1 = 0;
          numArray6[0] = 0;
          int index6 = 0;
          *(int*) ((IntPtr) voidPtr + 4) = -1;
          *(int*) ((IntPtr) voidPtr + 20) = -*(int*) ((IntPtr) voidPtr + 12);
          numArray3[0] = 0;
          int num9 = 0;
          int num10 = 0;
          while (true)
          {
            *(sbyte*) ((IntPtr) voidPtr + 42) = (sbyte) (*(int*) ((IntPtr) voidPtr + 8) <= *(int*) voidPtr);
            if (*(sbyte*) ((IntPtr) voidPtr + 42) != (sbyte) 0)
            {
              int num11 = numArray1[*(int*) ((IntPtr) voidPtr + 8)];
label_54:
              while ((uint) num11-- > 0U)
              {
                while (true)
                {
                  *(sbyte*) ((IntPtr) voidPtr + 36) = (sbyte) (*(int*) ((IntPtr) voidPtr + 8) > *(int*) ((IntPtr) voidPtr + 20) + *(int*) ((IntPtr) voidPtr + 12));
                  if (*(sbyte*) ((IntPtr) voidPtr + 36) != (sbyte) 0)
                  {
                    *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + 1;
                    *(int*) ((IntPtr) voidPtr + 20) = *(int*) ((IntPtr) voidPtr + 20) + *(int*) ((IntPtr) voidPtr + 12);
                    int num12 = *(int*) voidPtr - *(int*) ((IntPtr) voidPtr + 20);
                    int num13 = num12 > *(int*) ((IntPtr) voidPtr + 12) ? *(int*) ((IntPtr) voidPtr + 12) : num12;
                    int num14;
                    int num15;
                    if ((num15 = 1 << (num14 = *(int*) ((IntPtr) voidPtr + 8) - *(int*) ((IntPtr) voidPtr + 20))) > num11 + 1)
                    {
                      int num16 = num15 - (num11 + 1);
                      int index5 = *(int*) ((IntPtr) voidPtr + 8);
                      *(sbyte*) ((IntPtr) voidPtr + 33) = (sbyte) (num14 < num13);
                      if (*(sbyte*) ((IntPtr) voidPtr + 33) != (sbyte) 0)
                      {
                        int num17;
                        while (++num14 < num13 && (num17 = num16 << 1) > numArray1[++index5])
                          num16 = num17 - numArray1[index5];
                      }
                    }
                    num10 = 1 << num14;
                    *(sbyte*) ((IntPtr) voidPtr + 34) = (sbyte) (int_9[0] + num10 > 1440);
                    if (*(sbyte*) ((IntPtr) voidPtr + 34) == (sbyte) 0)
                    {
                      numArray3[*(int*) ((IntPtr) voidPtr + 4)] = num9 = int_9[0];
                      int_9[0] += num10;
                      *(sbyte*) ((IntPtr) voidPtr + 35) = (sbyte) ((uint) *(int*) ((IntPtr) voidPtr + 4) > 0U);
                      if (*(sbyte*) ((IntPtr) voidPtr + 35) != (sbyte) 0)
                      {
                        numArray4[*(int*) ((IntPtr) voidPtr + 4)] = int_1_1;
                        numArray2[0] = (int) (byte) num14;
                        numArray2[1] = (int) (byte) *(int*) ((IntPtr) voidPtr + 12);
                        int num16 = Class73.smethod_108(*(int*) ((IntPtr) voidPtr + 20) - *(int*) ((IntPtr) voidPtr + 12), int_1_1);
                        numArray2[2] = num9 - numArray3[*(int*) ((IntPtr) voidPtr + 4) - 1] - num16;
                        Array.Copy((Array) numArray2, 0, (Array) int_8, (numArray3[*(int*) ((IntPtr) voidPtr + 4) - 1] + num16) * 3, 3);
                      }
                      else
                        int_6[0] = num9;
                    }
                    else
                      goto label_58;
                  }
                  else
                    break;
                }
                numArray2[1] = (int) (byte) (*(int*) ((IntPtr) voidPtr + 8) - *(int*) ((IntPtr) voidPtr + 20));
                *(sbyte*) ((IntPtr) voidPtr + 37) = (sbyte) (index6 >= int_2);
                if (*(sbyte*) ((IntPtr) voidPtr + 37) != (sbyte) 0)
                {
                  numArray2[0] = 192;
                }
                else
                {
                  *(sbyte*) ((IntPtr) voidPtr + 38) = (sbyte) (int_10[index6] < int_3);
                  if (*(sbyte*) ((IntPtr) voidPtr + 38) != (sbyte) 0)
                  {
                    numArray2[0] = int_10[index6] < 256 ? 0 : 96;
                    numArray2[2] = int_10[index6++];
                  }
                  else
                  {
                    numArray2[0] = (int) (byte) (int_5[int_10[index6] - int_3] + 16 + 64);
                    numArray2[2] = int_4[int_10[index6++] - int_3];
                  }
                }
                int num18 = 1 << *(int*) ((IntPtr) voidPtr + 8) - *(int*) ((IntPtr) voidPtr + 20);
                int num19 = Class73.smethod_108(*(int*) ((IntPtr) voidPtr + 20), int_1_1);
                while (true)
                {
                  *(sbyte*) ((IntPtr) voidPtr + 39) = (sbyte) (num19 < num10);
                  if (*(sbyte*) ((IntPtr) voidPtr + 39) != (sbyte) 0)
                  {
                    Array.Copy((Array) numArray2, 0, (Array) int_8, (num9 + num19) * 3, 3);
                    num19 += num18;
                  }
                  else
                    break;
                }
                int int_1_2 = 1 << *(int*) ((IntPtr) voidPtr + 8) - 1;
                while (true)
                {
                  *(sbyte*) ((IntPtr) voidPtr + 40) = (sbyte) ((uint) (int_1_1 & int_1_2) > 0U);
                  if (*(sbyte*) ((IntPtr) voidPtr + 40) != (sbyte) 0)
                  {
                    int_1_1 ^= int_1_2;
                    int_1_2 = Class73.smethod_108(1, int_1_2);
                  }
                  else
                    break;
                }
                int_1_1 ^= int_1_2;
                *(int*) ((IntPtr) voidPtr + 16) = (1 << *(int*) ((IntPtr) voidPtr + 20)) - 1;
                while (true)
                {
                  *(sbyte*) ((IntPtr) voidPtr + 41) = (sbyte) ((int_1_1 & *(int*) ((IntPtr) voidPtr + 16)) != numArray4[*(int*) ((IntPtr) voidPtr + 4)]);
                  if (*(sbyte*) ((IntPtr) voidPtr + 41) != (sbyte) 0)
                  {
                    *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) - 1;
                    *(int*) ((IntPtr) voidPtr + 20) = *(int*) ((IntPtr) voidPtr + 20) - *(int*) ((IntPtr) voidPtr + 12);
                    *(int*) ((IntPtr) voidPtr + 16) = (1 << *(int*) ((IntPtr) voidPtr + 20)) - 1;
                  }
                  else
                    goto label_54;
                }
label_58:
                num3 = -3;
                goto label_60;
              }
              *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) + 1;
            }
            else
              break;
          }
          num3 = num6 == 0 || *(int*) voidPtr == 1 ? 0 : -5;
          goto label_60;
        }
label_59:
        num3 = -3;
      }
label_60:
      return num3;
    }

    static void smethod_195(int int_0, Class9 class9_0)
    {
      Class73.smethod_102(class9_0, (byte) int_0);
      Class73.smethod_102(class9_0, (byte) Class73.smethod_108(8, int_0));
    }

    static void smethod_196(int int_0, bool bool_0, int int_1, Class9 class9_0)
    {
      Class73.smethod_61(class9_0, bool_0 ? 1 : 0, 3);
      Class73.smethod_246(true, class9_0, int_0, int_1);
    }

    static unsafe int smethod_197(Class18 class18_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(9);
      *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) (class18_0.class13_0 == null);
      if (*(sbyte*) ((IntPtr) voidPtr + 8) != (sbyte) 0)
      {
        *(int*) ((IntPtr) voidPtr + 4) = -2;
      }
      else
      {
        *(int*) voidPtr = Class73.smethod_154(class18_0.class13_0, class18_0);
        class18_0.class13_0 = (Class13) null;
        *(int*) ((IntPtr) voidPtr + 4) = *(int*) voidPtr;
      }
      return *(int*) ((IntPtr) voidPtr + 4);
    }

    static unsafe void smethod_198(Class1 class1_0, object object_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      object object0 = class1_0.object_0;
      *(sbyte*) voidPtr = (sbyte) 0;
      try
      {
        Monitor.Enter(object0, ref *(bool*) voidPtr);
        *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) class1_0.bool_2;
        if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
          throw new Exception("Cannot Write to a locked Packet.");
        class1_0.class3_0.Write((uint) (Convert.ToUInt64(object_0) & (ulong) uint.MaxValue));
      }
      finally
      {
        if (*(sbyte*) voidPtr != (sbyte) 0)
          Monitor.Exit(object0);
      }
    }

    static void smethod_199(Class9 class9_0, int int_0)
    {
      Class73.smethod_102(class9_0, (byte) (int_0 >> 8));
      Class73.smethod_102(class9_0, (byte) int_0);
    }

    static int smethod_200(Class80.Stream1 stream1_0)
    {
      return Class73.smethod_239(stream1_0) | Class73.smethod_239(stream1_0) << 16;
    }

    static void smethod_201(Class9 class9_0)
    {
      Class73.smethod_61(class9_0, 2, 3);
      Class73.smethod_137(class9_0, 256, Class15.short_0);
      Class73.smethod_205(class9_0);
      if (1 + class9_0.int_41 + 10 - class9_0.int_42 < 9)
      {
        Class73.smethod_61(class9_0, 2, 3);
        Class73.smethod_137(class9_0, 256, Class15.short_0);
        Class73.smethod_205(class9_0);
      }
      class9_0.int_41 = 7;
    }

    static void smethod_202(Class19 class19_0)
    {
      Class1 class1_0 = new Class1((ushort) 28777);
      Class73.smethod_160(0UL, class1_0);
      Class73.smethod_162((byte) 5, class1_0);
      Class73.smethod_162((byte) 0, class1_0);
      Class73.smethod_162((byte) 1, class1_0);
      Class73.smethod_162((byte) 1, class1_0);
      Class73.smethod_120(class1_0, "      [Party Form] Etkinliği     ");
      class19_0.method_1(class1_0);
    }

    static string smethod_203(string string_0)
    {
      return Class73.smethod_109(BitConverter.ToString(new SHA1CryptoServiceProvider().ComputeHash(Class73.smethod_50(string_0))));
    }

    static int smethod_204(Class80.Class83 class83_0)
    {
      return class83_0.int_1;
    }

    static unsafe void smethod_205(Class9 class9_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      *(sbyte*) voidPtr = (sbyte) (class9_0.int_42 == 16);
      if (*(sbyte*) voidPtr != (sbyte) 0)
      {
        Class73.smethod_195((int) class9_0.short_6, class9_0);
        class9_0.short_6 = (short) 0;
        class9_0.int_42 = 0;
      }
      else
      {
        *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (class9_0.int_42 >= 8);
        if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
          return;
        Class73.smethod_102(class9_0, (byte) class9_0.short_6);
        class9_0.short_6 = (short) Class73.smethod_108(8, (int) class9_0.short_6);
        class9_0.int_42 -= 8;
      }
    }

    static void smethod_206(Class19 class19_0)
    {
      Class1 class1_0 = new Class1((ushort) 28688, true);
      Class73.smethod_162((byte) 2, class1_0);
      Class73.smethod_162((byte) 0, class1_0);
      class19_0.method_1(class1_0);
    }

    static void smethod_207()
    {
      Class73.smethod_83(Class25.class19_0, -11201.0, 2641.0);
    }

    static unsafe void smethod_208(Class9 class9_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(15);
      *(int*) voidPtr = 0;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) (*(int*) voidPtr < Class9.int_1);
        if (*(sbyte*) ((IntPtr) voidPtr + 12) != (sbyte) 0)
        {
          class9_0.short_2[*(int*) voidPtr * 2] = (short) 0;
          *(int*) voidPtr = *(int*) voidPtr + 1;
        }
        else
          break;
      }
      *(int*) ((IntPtr) voidPtr + 4) = 0;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 13) = (sbyte) (*(int*) ((IntPtr) voidPtr + 4) < 30);
        if (*(sbyte*) ((IntPtr) voidPtr + 13) != (sbyte) 0)
        {
          class9_0.short_3[*(int*) ((IntPtr) voidPtr + 4) * 2] = (short) 0;
          *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + 1;
        }
        else
          break;
      }
      *(int*) ((IntPtr) voidPtr + 8) = 0;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 14) = (sbyte) (*(int*) ((IntPtr) voidPtr + 8) < 19);
        if (*(sbyte*) ((IntPtr) voidPtr + 14) != (sbyte) 0)
        {
          class9_0.short_4[*(int*) ((IntPtr) voidPtr + 8) * 2] = (short) 0;
          *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) + 1;
        }
        else
          break;
      }
      class9_0.short_2[512] = (short) 1;
      Class9 class9_1 = class9_0;
      class9_0.int_39 = 0;
      class9_1.int_38 = 0;
      Class9 class9_2 = class9_0;
      class9_0.int_40 = 0;
      class9_2.int_36 = 0;
    }

    static ushort smethod_209(uint uint_0)
    {
      return (ushort) (uint_0 & (uint) ushort.MaxValue);
    }

    static string smethod_210(string string_0)
    {
      return Class73.smethod_127(BitConverter.ToString(new SHA1CryptoServiceProvider().ComputeHash(Class73.smethod_50(string_0))));
    }

    static unsafe byte[] smethod_211(Class1 class1_0, int int_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(7);
      object object0 = class1_0.object_0;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) 0;
      try
      {
        // ISSUE: cast to a reference type
        Monitor.Enter(object0, (bool&) ((IntPtr) voidPtr + 4));
        *(sbyte*) ((IntPtr) voidPtr + 5) = (sbyte) !class1_0.bool_2;
        if (*(sbyte*) ((IntPtr) voidPtr + 5) != (sbyte) 0)
          throw new Exception("Cannot Read from an unlocked Packet.");
        byte[] numArray = new byte[int_0];
        *(int*) voidPtr = 0;
        while (true)
        {
          *(sbyte*) ((IntPtr) voidPtr + 6) = (sbyte) (*(int*) voidPtr < int_0);
          if (*(sbyte*) ((IntPtr) voidPtr + 6) != (sbyte) 0)
          {
            numArray[*(int*) voidPtr] = class1_0.class2_0.ReadByte();
            *(int*) voidPtr = *(int*) voidPtr + 1;
          }
          else
            break;
        }
        return numArray;
      }
      finally
      {
        if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
          Monitor.Exit(object0);
      }
    }

    static void smethod_212()
    {
      Class73.smethod_83(Class25.class19_0, -5187.0, 2643.0);
    }

    static void smethod_213(Stream stream_0, Stream stream_1)
    {
      byte[] buffer = new byte[2000];
      int count;
      while ((count = stream_0.Read(buffer, 0, 2000)) > 0)
        stream_1.Write(buffer, 0, count);
      stream_1.Flush();
    }

    static void smethod_214(Class19 class19_0)
    {
      Class1 class1_0 = new Class1((ushort) 28780);
      Class73.smethod_162((byte) 0, class1_0);
      class19_0.method_1(class1_0);
    }

    static void smethod_215(Class80.Class83 class83_0, int int_0, int int_1)
    {
      if ((class83_0.int_1 += int_0) > 32768)
        throw new InvalidOperationException();
      int num1 = class83_0.int_0 - int_1 & (int) short.MaxValue;
      int num2 = 32768 - int_0;
      if (num1 <= num2 && class83_0.int_0 < num2)
      {
        if (int_0 <= int_1)
        {
          Array.Copy((Array) class83_0.byte_0, num1, (Array) class83_0.byte_0, class83_0.int_0, int_0);
          class83_0.int_0 += int_0;
        }
        else
        {
          while (int_0-- > 0)
          {
            byte[] byte0 = class83_0.byte_0;
            Class80.Class83 class83 = class83_0;
            int int0 = class83_0.int_0;
            int num3 = int0 + 1;
            class83.int_0 = num3;
            int index = int0;
            int num4 = (int) class83_0.byte_0[num1++];
            byte0[index] = (byte) num4;
          }
        }
      }
      else
        Class73.smethod_30(class83_0, num1, int_0, int_1);
    }

    static unsafe List<KeyValuePair<Class6, Class1>> smethod_216(
      Class4 class4_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(3);
      List<KeyValuePair<Class6, Class1>> keyValuePairList = (List<KeyValuePair<Class6, Class1>>) null;
      object object0 = class4_0.object_0;
      *(sbyte*) voidPtr = (sbyte) 0;
      try
      {
        Monitor.Enter(object0, ref *(bool*) voidPtr);
        *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) Class73.smethod_29(class4_0);
        if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
        {
          keyValuePairList = new List<KeyValuePair<Class6, Class1>>();
          while (true)
          {
            *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) Class73.smethod_29(class4_0);
            if (*(sbyte*) ((IntPtr) voidPtr + 2) != (sbyte) 0)
              keyValuePairList.Add(Class73.smethod_132(class4_0));
            else
              break;
          }
        }
      }
      finally
      {
        if (*(sbyte*) voidPtr != (sbyte) 0)
          Monitor.Exit(object0);
      }
      return keyValuePairList;
    }

    static void smethod_217(Class19 class19_0, string string_0)
    {
      if (class19_0.socket_0 != null)
      {
        class19_0.socket_0.Close();
        class19_0.socket_0 = (Socket) null;
        Class73.smethod_18("Agent bağlantısı kesildi. => " + string_0);
        Class25.class19_0 = (Class19) null;
        Class73.smethod_251(true, "FromAgent");
        Form1.form1_0.label_160.Text = "OFFLİNE";
        Form1.form1_0.label_160.ForeColor = Color.Salmon;
        Form1.form1_0.label_161.Text = "OFFLİNE";
        Form1.form1_0.label_161.ForeColor = Color.Salmon;
      }
      GC.SuppressFinalize((object) class19_0);
    }

    static void smethod_218(Class19 class19_0, string string_0)
    {
      Class1 class1_0 = new Class1((ushort) 28709);
      Class73.smethod_65((ushort) 3, class1_0);
      Class73.smethod_120(class1_0, string_0);
      class19_0.method_1(class1_0);
    }

    static void smethod_219(bool bool_0, bool bool_1, Class1 class1_0)
    {
      string str = bool_1 ? "Client => Server" : "Server => Client";
      byte[] byte_0 = Class73.smethod_223(class1_0);
      int num = bool_1 ? 2 : 1;
      string.Format("[" + str + "][{0:X4}][{1} bytes]{2}{3}{4}{5}{6}", (object) Class73.smethod_89(class1_0), (object) byte_0.Length, Class73.smethod_186(class1_0) ? (object) "[Encrypted]" : (object) "", Class73.smethod_119(class1_0) ? (object) "[Massive]" : (object) "", (object) Environment.NewLine, (object) Class73.smethod_76(byte_0), (object) Environment.NewLine);
    }

    static unsafe long smethod_220(int int_0, long long_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(9);
      *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) (long_0 >= 0L);
      if (*(sbyte*) ((IntPtr) voidPtr + 8) != (sbyte) 0)
        *(long*) voidPtr = long_0 >> int_0;
      else
        *(long*) voidPtr = (long_0 >> int_0) + (2L << ~int_0);
      return *(long*) voidPtr;
    }

    static int smethod_221(Class18 class18_0, int int_0)
    {
      class18_0.class13_0 = new Class13();
      return Class73.smethod_93(class18_0, class18_0.class13_0, int_0);
    }

    static unsafe bool smethod_222(Class80.Class81 class81_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(12);
      int num = Class73.smethod_153(class81_0.class83_0);
      while (num >= 258)
      {
        *(int*) voidPtr = class81_0.int_4;
        switch (*(int*) voidPtr)
        {
          case 7:
            int int_0;
            while (((int_0 = Class73.smethod_99(class81_0.class84_0, class81_0.class82_0)) & -256) == 0)
            {
              Class73.smethod_23(class81_0.class83_0, int_0);
              if (--num < 258)
                return true;
            }
            if (int_0 >= 257)
            {
              class81_0.int_6 = Class80.Class81.int_0[int_0 - 257];
              class81_0.int_5 = Class80.Class81.int_1[int_0 - 257];
              goto case 8;
            }
            else
            {
              if (int_0 < 0)
                return false;
              class81_0.class84_1 = (Class80.Class84) null;
              class81_0.class84_0 = (Class80.Class84) null;
              class81_0.int_4 = 2;
              return true;
            }
          case 8:
            if (class81_0.int_5 > 0)
            {
              class81_0.int_4 = 8;
              *(int*) ((IntPtr) voidPtr + 4) = Class73.smethod_254(class81_0.class82_0, class81_0.int_5);
              if (*(int*) ((IntPtr) voidPtr + 4) < 0)
                return false;
              Class73.smethod_147(class81_0.class82_0, class81_0.int_5);
              class81_0.int_6 += *(int*) ((IntPtr) voidPtr + 4);
            }
            class81_0.int_4 = 9;
            goto case 9;
          case 9:
            int index = Class73.smethod_99(class81_0.class84_1, class81_0.class82_0);
            if (index < 0)
              return false;
            class81_0.int_7 = Class80.Class81.int_2[index];
            class81_0.int_5 = Class80.Class81.int_3[index];
            goto case 10;
          case 10:
            if (class81_0.int_5 > 0)
            {
              class81_0.int_4 = 10;
              *(int*) ((IntPtr) voidPtr + 8) = Class73.smethod_254(class81_0.class82_0, class81_0.int_5);
              if (*(int*) ((IntPtr) voidPtr + 8) < 0)
                return false;
              Class73.smethod_147(class81_0.class82_0, class81_0.int_5);
              class81_0.int_7 += *(int*) ((IntPtr) voidPtr + 8);
            }
            Class73.smethod_215(class81_0.class83_0, class81_0.int_6, class81_0.int_7);
            num -= class81_0.int_6;
            class81_0.int_4 = 7;
            continue;
          default:
            continue;
        }
      }
      return true;
    }

    static unsafe byte[] smethod_223(Class1 class1_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      object object0 = class1_0.object_0;
      *(sbyte*) voidPtr = (sbyte) 0;
      try
      {
        Monitor.Enter(object0, ref *(bool*) voidPtr);
        *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) class1_0.bool_2;
        return *(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0 ? class1_0.byte_0 : Class73.smethod_230(class1_0.class3_0);
      }
      finally
      {
        if (*(sbyte*) voidPtr != (sbyte) 0)
          Monitor.Exit(object0);
      }
    }

    static void smethod_224(Class9 class9_0, bool bool_0)
    {
      Class73.smethod_188(class9_0, class9_0.int_17 >= 0 ? class9_0.int_17 : -1, class9_0.int_21 - class9_0.int_17, bool_0);
      class9_0.int_17 = class9_0.int_21;
      Class73.smethod_107(class9_0.class18_0);
    }

    static void smethod_225(Bitmap bitmap_0)
    {
      Form1.form1_0.Invoke((Delegate) new MethodInvoker(new Form1.Class37()
      {
        bitmap_0 = bitmap_0
      }.method_0));
    }

    static unsafe void smethod_226(Class1 class1_0, object object_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      object object0 = class1_0.object_0;
      *(sbyte*) voidPtr = (sbyte) 0;
      try
      {
        Monitor.Enter(object0, ref *(bool*) voidPtr);
        *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) class1_0.bool_2;
        if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
          throw new Exception("Cannot Write to a locked Packet.");
        class1_0.class3_0.Write((ushort) (Convert.ToInt64(object_0) & (long) ushort.MaxValue));
      }
      finally
      {
        if (*(sbyte*) voidPtr != (sbyte) 0)
          Monitor.Exit(object0);
      }
    }

    static unsafe void smethod_227(Class18 class18_0, long[] long_0, Class11 class11_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(3);
      *(sbyte*) voidPtr = (sbyte) (long_0 != null);
      if (*(sbyte*) voidPtr != (sbyte) 0)
        long_0[0] = class11_0.long_0;
      if ((class11_0.int_2 == 4 ? 1 : (class11_0.int_2 == 5 ? 1 : 0)) != 0)
        class11_0.int_6 = (int[]) null;
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (class11_0.int_2 == 6);
      if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
        Class73.smethod_143(class11_0.class12_0, class18_0);
      class11_0.int_2 = 0;
      class11_0.int_10 = 0;
      class11_0.int_11 = 0;
      Class11 class11 = class11_0;
      class11_0.int_15 = 0;
      class11.int_14 = 0;
      *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) (class11_0.object_0 != null);
      if (*(sbyte*) ((IntPtr) voidPtr + 2) == (sbyte) 0)
        return;
      class18_0.long_2 = class11_0.long_0 = Class73.smethod_151((byte[]) null, class18_0.class8_0, 0, 0L, 0);
    }

    static byte[] smethod_228(Class0 class0_0, byte[] byte_0)
    {
      return Class73.smethod_22(byte_0.Length, 0, class0_0, byte_0);
    }

    static void smethod_229(Class19 class19_0)
    {
      Task.Factory.StartNew<Task>(new Func<Task>(class19_0.method_3));
    }

    static byte[] smethod_230(Class3 class3_0)
    {
      return class3_0.memoryStream_0.ToArray();
    }

    static unsafe string smethod_231(int int_0, int int_1, byte[] byte_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(15);
      StringBuilder stringBuilder1 = new StringBuilder();
      StringBuilder stringBuilder2 = new StringBuilder();
      *(int*) voidPtr = int_0;
      *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) ((uint) (*(int*) voidPtr % 16) > 0U);
      if (*(sbyte*) ((IntPtr) voidPtr + 8) != (sbyte) 0)
        *(int*) voidPtr = *(int*) voidPtr + (16 - *(int*) voidPtr % 16);
      *(int*) ((IntPtr) voidPtr + 4) = 0;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 14) = (sbyte) (*(int*) ((IntPtr) voidPtr + 4) <= *(int*) voidPtr);
        if (*(sbyte*) ((IntPtr) voidPtr + 14) != (sbyte) 0)
        {
          *(sbyte*) ((IntPtr) voidPtr + 9) = (sbyte) (*(int*) ((IntPtr) voidPtr + 4) % 16 == 0);
          if (*(sbyte*) ((IntPtr) voidPtr + 9) != (sbyte) 0)
          {
            *(sbyte*) ((IntPtr) voidPtr + 10) = (sbyte) (*(int*) ((IntPtr) voidPtr + 4) > 0);
            if (*(sbyte*) ((IntPtr) voidPtr + 10) != (sbyte) 0)
            {
              stringBuilder1.AppendFormat("  {0}{1}", (object) stringBuilder2.ToString(), (object) Environment.NewLine);
              stringBuilder2.Clear();
            }
            *(sbyte*) ((IntPtr) voidPtr + 11) = (sbyte) (*(int*) ((IntPtr) voidPtr + 4) != *(int*) voidPtr);
            if (*(sbyte*) ((IntPtr) voidPtr + 11) != (sbyte) 0)
              stringBuilder1.AppendFormat("{0:d10}   ", (object) *(int*) ((IntPtr) voidPtr + 4));
          }
          *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) (*(int*) ((IntPtr) voidPtr + 4) < int_0);
          if (*(sbyte*) ((IntPtr) voidPtr + 12) != (sbyte) 0)
          {
            stringBuilder1.AppendFormat("{0:X2} ", (object) byte_0[int_1 + *(int*) ((IntPtr) voidPtr + 4)]);
            char c = (char) byte_0[int_1 + *(int*) ((IntPtr) voidPtr + 4)];
            *(sbyte*) ((IntPtr) voidPtr + 13) = (sbyte) !char.IsControl(c);
            if (*(sbyte*) ((IntPtr) voidPtr + 13) != (sbyte) 0)
              stringBuilder2.AppendFormat("{0}", (object) c);
            else
              stringBuilder2.Append(".");
          }
          else
          {
            stringBuilder1.Append("   ");
            stringBuilder2.Append(".");
          }
          *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + 1;
        }
        else
          break;
      }
      return stringBuilder1.ToString();
    }

    static unsafe int smethod_232(int int_0, Class18 class18_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(5);
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (class18_0.class9_0 == null);
      if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
        *(int*) voidPtr = -2;
      else
        *(int*) voidPtr = Class73.smethod_238(class18_0.class9_0, class18_0, int_0);
      return *(int*) voidPtr;
    }

    static int smethod_233(int int_0)
    {
      return int_0 < 256 ? (int) Class17.byte_1[int_0] : (int) Class17.byte_1[256 + Class73.smethod_108(7, int_0)];
    }

    static unsafe bool smethod_234(string string_0, bool bool_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(8);
      try
      {
        string str1 = string.Empty;
        SqlCommand sqlCommand = new SqlCommand(string.Empty, Class65.sqlConnection_0);
        *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) string_0.Contains("GO");
        if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
        {
          string[] strArray = string_0.Split(new string[2]
          {
            "\n",
            "\r"
          }, StringSplitOptions.RemoveEmptyEntries);
          *(int*) voidPtr = 0;
          while (*(int*) voidPtr < strArray.Length)
          {
            string str2 = strArray[*(int*) voidPtr];
            *(sbyte*) ((IntPtr) voidPtr + 5) = (sbyte) (str2.ToUpperInvariant().Trim() == "GO");
            if (*(sbyte*) ((IntPtr) voidPtr + 5) != (sbyte) 0)
            {
              sqlCommand.CommandText = str1;
              sqlCommand.ExecuteNonQuery();
              str1 = string.Empty;
            }
            else
              str1 = str1 + str2 + "\n";
            *(int*) voidPtr = *(int*) voidPtr + 1;
          }
        }
        else
          new SqlCommand(string_0, Class65.sqlConnection_0).ExecuteNonQuery();
        *(sbyte*) ((IntPtr) voidPtr + 6) = (sbyte) 1;
      }
      catch (Exception ex)
      {
        *(sbyte*) ((IntPtr) voidPtr + 7) = (sbyte) bool_0;
        if (*(sbyte*) ((IntPtr) voidPtr + 7) != (sbyte) 0)
        {
          int num = (int) XtraMessageBox.Show(string_0 + "\n" + ex.Message.ToString());
        }
        *(sbyte*) ((IntPtr) voidPtr + 6) = (sbyte) 0;
      }
      return (bool) *(sbyte*) ((IntPtr) voidPtr + 6);
    }

    static uint smethod_235()
    {
      byte[] buffer = new byte[4];
      Class4.random_0.NextBytes(buffer);
      return BitConverter.ToUInt32(buffer, 0);
    }

    static void smethod_236()
    {
      Class73.smethod_83(Class25.class19_0, 6443.0, 874.0);
    }

    static string smethod_237()
    {
      string str = "127.0.0.1";
      Form1.form1_0.label_13.Text = str;
      return str;
    }

    static unsafe int smethod_238(Class9 class9_0, Class18 class18_0, int int_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(39);
      int num;
      if ((int_0 > 4 ? 1 : (int_0 < 0 ? 1 : 0)) != 0)
        num = -2;
      else if ((class18_0.byte_1 == null || class18_0.byte_0 == null && class18_0.int_2 != 0 ? 1 : (class9_0.int_3 != 666 ? 0 : (int_0 != 4 ? 1 : 0))) != 0)
      {
        class18_0.string_0 = Class9.string_0[4];
        num = -2;
      }
      else
      {
        *(sbyte*) ((IntPtr) voidPtr + 24) = (sbyte) (class18_0.int_4 == 0);
        if (*(sbyte*) ((IntPtr) voidPtr + 24) != (sbyte) 0)
        {
          class18_0.string_0 = Class9.string_0[7];
          num = -5;
        }
        else
        {
          class9_0.class18_0 = class18_0;
          *(int*) voidPtr = class9_0.int_8;
          class9_0.int_8 = int_0;
          *(sbyte*) ((IntPtr) voidPtr + 25) = (sbyte) (class9_0.int_3 == 42);
          if (*(sbyte*) ((IntPtr) voidPtr + 25) != (sbyte) 0)
          {
            *(int*) ((IntPtr) voidPtr + 4) = 8 + (class9_0.int_10 - 8 << 4) << 8;
            *(int*) ((IntPtr) voidPtr + 8) = (class9_0.int_27 - 1 & (int) byte.MaxValue) >> 1;
            *(sbyte*) ((IntPtr) voidPtr + 26) = (sbyte) (*(int*) ((IntPtr) voidPtr + 8) > 3);
            if (*(sbyte*) ((IntPtr) voidPtr + 26) != (sbyte) 0)
              *(int*) ((IntPtr) voidPtr + 8) = 3;
            *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) | *(int*) ((IntPtr) voidPtr + 8) << 6;
            *(sbyte*) ((IntPtr) voidPtr + 27) = (sbyte) ((uint) class9_0.int_21 > 0U);
            if (*(sbyte*) ((IntPtr) voidPtr + 27) != (sbyte) 0)
              *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) | 32;
            *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + (31 - *(int*) ((IntPtr) voidPtr + 4) % 31);
            class9_0.int_3 = 113;
            Class73.smethod_199(class9_0, *(int*) ((IntPtr) voidPtr + 4));
            *(sbyte*) ((IntPtr) voidPtr + 28) = (sbyte) ((uint) class9_0.int_21 > 0U);
            if (*(sbyte*) ((IntPtr) voidPtr + 28) != (sbyte) 0)
            {
              Class73.smethod_199(class9_0, (int) Class73.smethod_220(16, class18_0.long_2));
              Class73.smethod_199(class9_0, (int) (class18_0.long_2 & (long) ushort.MaxValue));
            }
            class18_0.long_2 = Class73.smethod_151((byte[]) null, class18_0.class8_0, 0, 0L, 0);
          }
          *(sbyte*) ((IntPtr) voidPtr + 29) = (sbyte) ((uint) class9_0.int_6 > 0U);
          if (*(sbyte*) ((IntPtr) voidPtr + 29) != (sbyte) 0)
          {
            Class73.smethod_107(class18_0);
            *(sbyte*) ((IntPtr) voidPtr + 30) = (sbyte) (class18_0.int_4 == 0);
            if (*(sbyte*) ((IntPtr) voidPtr + 30) != (sbyte) 0)
            {
              class9_0.int_8 = -1;
              num = 0;
              goto label_46;
            }
          }
          else if ((class18_0.int_2 != 0 || int_0 > *(int*) voidPtr ? 0 : (int_0 != 4 ? 1 : 0)) != 0)
          {
            class18_0.string_0 = Class9.string_0[7];
            num = -5;
            goto label_46;
          }
          if ((class9_0.int_3 != 666 ? 0 : ((uint) class18_0.int_2 > 0U ? 1 : 0)) != 0)
          {
            class18_0.string_0 = Class9.string_0[7];
            num = -5;
          }
          else
          {
            if ((class18_0.int_2 != 0 || class9_0.int_23 != 0 ? 1 : (int_0 == 0 ? 0 : (class9_0.int_3 != 666 ? 1 : 0))) != 0)
            {
              *(int*) ((IntPtr) voidPtr + 12) = -1;
              *(int*) ((IntPtr) voidPtr + 16) = Class9.class10_0[class9_0.int_27].int_4;
              switch (*(int*) ((IntPtr) voidPtr + 16))
              {
                case 0:
                  *(int*) ((IntPtr) voidPtr + 12) = Class73.smethod_164(class9_0, int_0);
                  break;
                case 1:
                  *(int*) ((IntPtr) voidPtr + 12) = Class73.smethod_112(class9_0, int_0);
                  break;
                case 2:
                  *(int*) ((IntPtr) voidPtr + 12) = Class73.smethod_148(class9_0, int_0);
                  break;
              }
              if ((*(int*) ((IntPtr) voidPtr + 12) == 2 ? 1 : (*(int*) ((IntPtr) voidPtr + 12) == 3 ? 1 : 0)) != 0)
                class9_0.int_3 = 666;
              if ((*(int*) ((IntPtr) voidPtr + 12) == 0 ? 1 : (*(int*) ((IntPtr) voidPtr + 12) == 2 ? 1 : 0)) != 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 31) = (sbyte) (class18_0.int_4 == 0);
                if (*(sbyte*) ((IntPtr) voidPtr + 31) != (sbyte) 0)
                  class9_0.int_8 = -1;
                num = 0;
                goto label_46;
              }
              else
              {
                *(sbyte*) ((IntPtr) voidPtr + 32) = (sbyte) (*(int*) ((IntPtr) voidPtr + 12) == 1);
                if (*(sbyte*) ((IntPtr) voidPtr + 32) != (sbyte) 0)
                {
                  *(sbyte*) ((IntPtr) voidPtr + 33) = (sbyte) (int_0 == 1);
                  if (*(sbyte*) ((IntPtr) voidPtr + 33) != (sbyte) 0)
                  {
                    Class73.smethod_201(class9_0);
                  }
                  else
                  {
                    Class73.smethod_196(0, false, 0, class9_0);
                    *(sbyte*) ((IntPtr) voidPtr + 34) = (sbyte) (int_0 == 3);
                    if (*(sbyte*) ((IntPtr) voidPtr + 34) != (sbyte) 0)
                    {
                      *(int*) ((IntPtr) voidPtr + 20) = 0;
                      while (true)
                      {
                        *(sbyte*) ((IntPtr) voidPtr + 35) = (sbyte) (*(int*) ((IntPtr) voidPtr + 20) < class9_0.int_14);
                        if (*(sbyte*) ((IntPtr) voidPtr + 35) != (sbyte) 0)
                        {
                          class9_0.short_1[*(int*) ((IntPtr) voidPtr + 20)] = (short) 0;
                          *(int*) ((IntPtr) voidPtr + 20) = *(int*) ((IntPtr) voidPtr + 20) + 1;
                        }
                        else
                          break;
                      }
                    }
                  }
                  Class73.smethod_107(class18_0);
                  *(sbyte*) ((IntPtr) voidPtr + 36) = (sbyte) (class18_0.int_4 == 0);
                  if (*(sbyte*) ((IntPtr) voidPtr + 36) != (sbyte) 0)
                  {
                    class9_0.int_8 = -1;
                    num = 0;
                    goto label_46;
                  }
                }
              }
            }
            *(sbyte*) ((IntPtr) voidPtr + 37) = (sbyte) (int_0 != 4);
            if (*(sbyte*) ((IntPtr) voidPtr + 37) != (sbyte) 0)
            {
              num = 0;
            }
            else
            {
              *(sbyte*) ((IntPtr) voidPtr + 38) = (sbyte) ((uint) class9_0.int_7 > 0U);
              if (*(sbyte*) ((IntPtr) voidPtr + 38) != (sbyte) 0)
              {
                num = 1;
              }
              else
              {
                Class73.smethod_199(class9_0, (int) Class73.smethod_220(16, class18_0.long_2));
                Class73.smethod_199(class9_0, (int) (class18_0.long_2 & (long) ushort.MaxValue));
                Class73.smethod_107(class18_0);
                class9_0.int_7 = -1;
                num = class9_0.int_6 != 0 ? 0 : 1;
              }
            }
          }
        }
      }
label_46:
      return num;
    }

    static int smethod_239(Class80.Stream1 stream1_0)
    {
      return stream1_0.ReadByte() | stream1_0.ReadByte() << 8;
    }

    static uint smethod_240(uint uint_0, int int_0, Class0 class0_0)
    {
      if ((int_0 < 0 ? 1 : (int_0 > 3 ? 1 : 0)) != 0)
        throw new Exception(string.Format("[Blowfish::S] Invalid i index of [{0}].", (object) int_0));
      uint_0 >>= 24 - 8 * int_0;
      uint_0 &= (uint) byte.MaxValue;
      return class0_0.uint_3[int_0, (int) uint_0];
    }

    static void smethod_241(Class19 class19_0)
    {
      Class1 class1_0 = new Class1((ushort) 28688);
      Class73.smethod_65((ushort) 15, class1_0);
      class19_0.method_1(class1_0);
    }

    static void smethod_242(Form1 form1_0)
    {
      try
      {
        SqlDataReader sqlDataReader = new SqlCommand("select Top(1) refcommon_ID from My_EventBot.._UniqKesList where Durum = 0 order by Sıra", Class65.sqlConnection_0).ExecuteReader();
        sqlDataReader.Read();
        if ((sqlDataReader[0].ToString() != "0" ? 1 : (sqlDataReader[0].ToString() != "" ? 1 : 0)) != 0)
        {
          Form1.int_10 = Convert.ToInt32(sqlDataReader[0]);
        }
        else
        {
          if ((sqlDataReader[0].ToString() == "0" ? 1 : (sqlDataReader[0].ToString() == "" ? 1 : 0)) == 0)
            return;
          Form1.smethod_0("Arannan UniqueID veritabanında bulunamadı !! ID = " + sqlDataReader[0].ToString());
        }
      }
      catch (Exception ex)
      {
        Form1.smethod_1("#2 [Unique Kesme] etkinliginde unique bilgileri alınamadı !!! HATA => " + ex.Message, Color.Salmon);
      }
    }

    static void smethod_243(string string_0, Color color_0)
    {
      Form1.smethod_1(string_0, color_0);
    }

    static void smethod_244(int int_0, Class19 class19_0)
    {
      Class1 class1_0 = new Class1((ushort) 28780);
      Class73.smethod_173((object) int_0, class1_0);
      class19_0.method_1(class1_0);
    }

    static unsafe void smethod_245(Class29 class29_0, string string_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(3);
      Class29 class29 = class29_0;
      *(sbyte*) voidPtr = (sbyte) 0;
      try
      {
        Monitor.Enter((object) class29, ref *(bool*) voidPtr);
        *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (class29_0.socket_0 != null);
        if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
        {
          class29_0.socket_0.Close();
          class29_0.socket_0 = (Socket) null;
          *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) (string_0 != "FromAgent");
          if (*(sbyte*) ((IntPtr) voidPtr + 2) != (sbyte) 0)
          {
            Class73.smethod_243("Gateway bağlantısı kesildi. => " + string_0, Color.OrangeRed);
            Form1.form1_0.label_163.Text = "OFFLİNE";
            Form1.form1_0.label_163.ForeColor = Color.Salmon;
          }
          Class25.class29_0 = (Class29) null;
          Class25.autoResetEvent_0.Set();
        }
      }
      finally
      {
        if (*(sbyte*) voidPtr != (sbyte) 0)
          Monitor.Exit((object) class29);
      }
      GC.SuppressFinalize((object) class29_0);
    }

    static void smethod_246(bool bool_0, Class9 class9_0, int int_0, int int_1)
    {
      Class73.smethod_43(class9_0);
      class9_0.int_41 = 8;
      if (bool_0)
      {
        Class73.smethod_195((int) (short) int_1, class9_0);
        Class73.smethod_195((int) (short) ~int_1, class9_0);
      }
      Class73.smethod_177(class9_0, class9_0.byte_2, int_0, int_1);
    }

    static long smethod_247(long long_0)
    {
      return long_0;
    }

    static Class4.Class5 smethod_248(byte byte_0)
    {
      Class4.Class5 class5 = new Class4.Class5();
      class5.byte_0 = (byte) ((uint) byte_0 & 1U);
      byte_0 >>= 1;
      class5.byte_1 = (byte) ((uint) byte_0 & 1U);
      byte_0 >>= 1;
      class5.byte_2 = (byte) ((uint) byte_0 & 1U);
      byte_0 >>= 1;
      class5.byte_3 = (byte) ((uint) byte_0 & 1U);
      byte_0 >>= 1;
      class5.byte_4 = (byte) ((uint) byte_0 & 1U);
      byte_0 >>= 1;
      class5.byte_5 = (byte) ((uint) byte_0 & 1U);
      byte_0 >>= 1;
      class5.byte_6 = (byte) ((uint) byte_0 & 1U);
      byte_0 >>= 1;
      class5.byte_7 = (byte) ((uint) byte_0 & 1U);
      byte_0 = (byte) 0;
      return class5;
    }

    static void smethod_249(string string_0, Class19 class19_0)
    {
      Class1 class1_0 = new Class1((ushort) 28849);
      Class73.smethod_120(class1_0, string_0);
      class19_0.method_1(class1_0);
    }

    static unsafe bool smethod_250(Class80.Class85 class85_0, Class80.Class82 class82_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(12);
      while (true)
      {
        *(int*) voidPtr = class85_0.int_2;
        switch (*(int*) voidPtr)
        {
          case 0:
            class85_0.int_3 = Class73.smethod_254(class82_0, 5);
            if (class85_0.int_3 >= 0)
            {
              class85_0.int_3 += 257;
              Class73.smethod_147(class82_0, 5);
              class85_0.int_2 = 1;
              goto case 1;
            }
            else
              goto label_24;
          case 1:
            class85_0.int_4 = Class73.smethod_254(class82_0, 5);
            if (class85_0.int_4 >= 0)
            {
              ++class85_0.int_4;
              Class73.smethod_147(class82_0, 5);
              class85_0.int_6 = class85_0.int_3 + class85_0.int_4;
              class85_0.byte_1 = new byte[class85_0.int_6];
              class85_0.int_2 = 2;
              goto case 2;
            }
            else
              goto label_25;
          case 2:
            class85_0.int_5 = Class73.smethod_254(class82_0, 4);
            if (class85_0.int_5 >= 0)
            {
              class85_0.int_5 += 4;
              Class73.smethod_147(class82_0, 4);
              class85_0.byte_0 = new byte[19];
              class85_0.int_8 = 0;
              class85_0.int_2 = 3;
              goto case 3;
            }
            else
              goto label_26;
          case 3:
            for (; class85_0.int_8 < class85_0.int_5; ++class85_0.int_8)
            {
              *(int*) ((IntPtr) voidPtr + 4) = Class73.smethod_254(class82_0, 3);
              if (*(int*) ((IntPtr) voidPtr + 4) < 0)
                return false;
              Class73.smethod_147(class82_0, 3);
              class85_0.byte_0[Class80.Class85.int_9[class85_0.int_8]] = (byte) *(int*) ((IntPtr) voidPtr + 4);
            }
            class85_0.class84_0 = new Class80.Class84(class85_0.byte_0);
            class85_0.byte_0 = (byte[]) null;
            class85_0.int_8 = 0;
            class85_0.int_2 = 4;
            goto case 4;
          case 4:
            int num1;
            while (((num1 = Class73.smethod_99(class85_0.class84_0, class82_0)) & -16) == 0)
            {
              byte[] byte1 = class85_0.byte_1;
              Class80.Class85 class85 = class85_0;
              *(int*) voidPtr = class85_0.int_8;
              int num2 = *(int*) voidPtr + 1;
              class85.int_8 = num2;
              int index = *(int*) voidPtr;
              int num3 = (int) (class85_0.byte_2 = (byte) num1);
              byte1[index] = (byte) num3;
              if (class85_0.int_8 == class85_0.int_6)
                return true;
            }
            if (num1 >= 0)
            {
              if (num1 >= 17)
                class85_0.byte_2 = (byte) 0;
              class85_0.int_7 = num1 - 16;
              class85_0.int_2 = 5;
              goto case 5;
            }
            else
              goto label_28;
          case 5:
            *(int*) ((IntPtr) voidPtr + 8) = Class80.Class85.int_1[class85_0.int_7];
            int num4 = Class73.smethod_254(class82_0, *(int*) ((IntPtr) voidPtr + 8));
            if (num4 >= 0)
            {
              Class73.smethod_147(class82_0, *(int*) ((IntPtr) voidPtr + 8));
              int num2 = num4 + Class80.Class85.int_0[class85_0.int_7];
              while (num2-- > 0)
              {
                byte[] byte1 = class85_0.byte_1;
                Class80.Class85 class85 = class85_0;
                *(int*) voidPtr = class85_0.int_8;
                int num3 = *(int*) voidPtr + 1;
                class85.int_8 = num3;
                int index = *(int*) voidPtr;
                int byte2 = (int) class85_0.byte_2;
                byte1[index] = (byte) byte2;
              }
              if (class85_0.int_8 != class85_0.int_6)
              {
                class85_0.int_2 = 4;
                continue;
              }
              goto label_31;
            }
            else
              goto label_30;
          default:
            continue;
        }
      }
label_24:
      return false;
label_25:
      return false;
label_26:
      return false;
label_28:
      return false;
label_30:
      return false;
label_31:
      return true;
    }

    static unsafe void smethod_251(bool bool_0, string string_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(3);
      *(sbyte*) voidPtr = (sbyte) !bool_0;
      if (*(sbyte*) voidPtr != (sbyte) 0)
        ++Class25.int_0;
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (Class25.class19_0 != null);
      if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
        Class73.smethod_217(Class25.class19_0, string_0);
      *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) (Class25.class29_0 != null);
      if (*(sbyte*) ((IntPtr) voidPtr + 2) != (sbyte) 0)
        Class73.smethod_245(Class25.class29_0, string_0);
      Class25.autoResetEvent_0.Set();
    }

    static void smethod_252(int int_0, byte[] byte_0, int int_1, Class80.Class82 class82_0)
    {
      if (class82_0.int_0 < class82_0.int_1)
        throw new InvalidOperationException();
      int num = int_1 + int_0;
      if (0 > int_1 || int_1 > num || num > byte_0.Length)
        throw new ArgumentOutOfRangeException();
      if ((int_0 & 1) != 0)
      {
        class82_0.uint_0 |= (uint) (((int) byte_0[int_1++] & (int) byte.MaxValue) << class82_0.int_2);
        class82_0.int_2 += 8;
      }
      class82_0.byte_0 = byte_0;
      class82_0.int_0 = int_1;
      class82_0.int_1 = num;
    }

    static unsafe void smethod_253(Form1 form1_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(6);
      try
      {
        *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (form1_0.listBox_0.Items.Count > 0);
        if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
        {
          string str = form1_0.listBox_0.Items[0].ToString();
          *(int*) voidPtr = 0;
          while (true)
          {
            if (*(int*) voidPtr < str.Split('/').Length)
            {
              form1_0.listBox_19.Items.Add((object) str.Split('/')[*(int*) voidPtr]);
              *(int*) voidPtr = *(int*) voidPtr + 1;
            }
            else
              break;
          }
        }
        else
        {
          *(sbyte*) ((IntPtr) voidPtr + 5) = (sbyte) (form1_0.listBox_0.Items.Count <= 0);
          if (*(sbyte*) ((IntPtr) voidPtr + 5) == (sbyte) 0)
            return;
          Form1.smethod_0("Gidilecek Koordinat Kalmadı.! ");
          Class73.smethod_206(Class25.class19_0);
        }
      }
      catch (Exception ex)
      {
        Form1.smethod_1("HATA => " + ex.Message, Color.Salmon);
      }
    }

    static int smethod_254(Class80.Class82 class82_0, int int_0)
    {
      if (class82_0.int_2 < int_0)
      {
        if (class82_0.int_0 == class82_0.int_1)
          return -1;
        Class80.Class82 class82_1 = class82_0;
        int uint0 = (int) class82_0.uint_0;
        byte[] byte0_1 = class82_0.byte_0;
        Class80.Class82 class82_2 = class82_0;
        int int0_1 = class82_0.int_0;
        int num1 = int0_1 + 1;
        class82_2.int_0 = num1;
        int index1 = int0_1;
        int num2 = (int) byte0_1[index1] & (int) byte.MaxValue;
        byte[] byte0_2 = class82_0.byte_0;
        Class80.Class82 class82_3 = class82_0;
        int int0_2 = class82_0.int_0;
        int num3 = int0_2 + 1;
        class82_3.int_0 = num3;
        int index2 = int0_2;
        int num4 = ((int) byte0_2[index2] & (int) byte.MaxValue) << 8;
        int num5 = (num2 | num4) << class82_0.int_2;
        int num6 = uint0 | num5;
        class82_1.uint_0 = (uint) num6;
        class82_0.int_2 += 16;
      }
      return (int) ((long) class82_0.uint_0 & (long) ((1 << int_0) - 1));
    }

    static Bitmap smethod_255(Class1 class1_0)
    {
      uint[] numArray1 = Class73.smethod_31(class1_0);
      byte[] numArray2 = new byte[122]
      {
        (byte) 66,
        (byte) 77,
        (byte) 122,
        (byte) 200,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 122,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 108,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 200,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 64,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 0,
        (byte) 32,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 200,
        (byte) 0,
        (byte) 0,
        (byte) 18,
        (byte) 11,
        (byte) 0,
        (byte) 0,
        (byte) 18,
        (byte) 11,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        byte.MaxValue,
        (byte) 0,
        (byte) 0,
        byte.MaxValue,
        (byte) 0,
        (byte) 0,
        byte.MaxValue,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        byte.MaxValue,
        (byte) 1,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0
      };
      byte[] array = ((IEnumerable<uint>) numArray1).SelectMany<uint, byte>(new Func<uint, IEnumerable<byte>>(BitConverter.GetBytes)).ToArray<byte>();
      byte[] numArray3 = new byte[numArray2.Length + array.Length];
      Buffer.BlockCopy((Array) numArray2, 0, (Array) numArray3, 0, numArray2.Length);
      Buffer.BlockCopy((Array) array, 0, (Array) numArray3, numArray2.Length, array.Length);
      return new Bitmap((Image) new ImageConverter().ConvertFrom((object) numArray3));
    }
  }
}
