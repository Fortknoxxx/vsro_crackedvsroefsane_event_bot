// Decompiled with Syinea's Decompiler
// Type: ns2.Class79
// Assembly: My_EventBot_ßy_Mehmet_Yıldız_ML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B7172642-DC7D-4477-97BD-E927F8349F37
// Assembly location: C:\Users\Syinea\Downloads\CrackedMyEventBot\CrackedVsroEfsane.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace ns2
{
  internal sealed class Class79
  {
    private static readonly string string_0 = "1";
    private static readonly string string_1 = "33";
    private static readonly byte[] byte_0 = (byte[]) null;
    private static readonly object object_0 = new object();
    private static readonly bool bool_0 = false;
    private static readonly int int_0 = 0;
    private static readonly Dictionary<int, string> dictionary_0;

    public static string smethod_0(int int_1)
    {
      int_1 -= Class79.int_0;
      if (Class79.bool_0)
      {
        lock (Class79.object_0)
        {
          string str;
          Class79.dictionary_0.TryGetValue(int_1, out str);
          if (str != null)
            return str;
        }
      }
      int num1 = int_1;
      byte[] byte0_1 = Class79.byte_0;
      int index1 = num1;
      int index2 = index1 + 1;
      int num2 = (int) byte0_1[index1];
      int count;
      if ((num2 & 128) == 0)
      {
        count = num2;
        if (count == 0)
          return string.Empty;
      }
      else if ((num2 & 64) == 0)
      {
        count = ((num2 & 63) << 8) + (int) Class79.byte_0[index2++];
      }
      else
      {
        int num3 = (num2 & 31) << 24;
        byte[] byte0_2 = Class79.byte_0;
        int index3 = index2;
        int num4 = index3 + 1;
        int num5 = (int) byte0_2[index3] << 16;
        int num6 = num3 + num5;
        byte[] byte0_3 = Class79.byte_0;
        int index4 = num4;
        int num7 = index4 + 1;
        int num8 = (int) byte0_3[index4] << 8;
        int num9 = num6 + num8;
        byte[] byte0_4 = Class79.byte_0;
        int index5 = num7;
        index2 = index5 + 1;
        int num10 = (int) byte0_4[index5];
        count = num9 + num10;
      }
      try
      {
        byte[] bytes = Convert.FromBase64String(Encoding.UTF8.GetString(Class79.byte_0, index2, count));
        string str = string.Intern(Encoding.UTF8.GetString(bytes, 0, bytes.Length));
        if (Class79.bool_0)
        {
          try
          {
            lock (Class79.object_0)
              Class79.dictionary_0.Add(int_1, str);
          }
          catch
          {
          }
        }
        return str;
      }
      catch
      {
        return (string) null;
      }
    }

    static Class79()
    {
      if (Class79.string_0 == "1")
      {
        Class79.bool_0 = true;
        Class79.dictionary_0 = new Dictionary<int, string>();
      }
      Class79.int_0 = Convert.ToInt32(Class79.string_1);
      using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("{953e6385-ca31-4953-af77-f117acc05df2}"))
      {
        int int32 = Convert.ToInt32(manifestResourceStream.Length);
        byte[] numArray = new byte[int32];
        manifestResourceStream.Read(numArray, 0, int32);
        Class79.byte_0 = Class73.smethod_111(numArray);
        manifestResourceStream.Close();
      }
    }
  }
}
