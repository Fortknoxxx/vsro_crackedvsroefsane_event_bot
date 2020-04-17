// Decompiled with Syinea's Decompiler
// Type: ns0.Class78
// Assembly: My_EventBot_ßy_Mehmet_Yıldız_ML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B7172642-DC7D-4477-97BD-E927F8349F37
// Assembly location: C:\Users\Syinea\Downloads\CrackedMyEventBot\CrackedVsroEfsane.exe

using System;
using System.Diagnostics;
using System.Reflection;

namespace ns0
{
  internal sealed class Class78
  {
    private static Assembly assembly_0 = (Assembly) null;
    private static string[] string_0 = new string[0];

    internal static void smethod_0()
    {
      try
      {
        AppDomain.CurrentDomain.ResourceResolve += new ResolveEventHandler(Class78.smethod_1);
      }
      catch (Exception ex)
      {
      }
    }

    private static Assembly smethod_1(object object_0, ResolveEventArgs resolveEventArgs_0)
    {
      if ((object) Class78.assembly_0 == null)
      {
        lock (Class78.string_0)
        {
          Class78.assembly_0 = Assembly.Load("{c56b960a-61e3-491f-9517-d6fa6621e1d1}, PublicKeyToken=3e56350693f7355e");
          if ((object) Class78.assembly_0 != null)
            Class78.string_0 = Class78.assembly_0.GetManifestResourceNames();
        }
      }
      string name = resolveEventArgs_0.Name;
      for (int index = 0; index < Class78.string_0.Length; ++index)
      {
        if (Class78.string_0[index] == name)
          return !Class78.smethod_2() ? (Assembly) null : Class78.assembly_0;
      }
      return (Assembly) null;
    }

    private static unsafe bool smethod_2()
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(5);
      try
      {
        StackFrame[] frames = new StackTrace().GetFrames();
        *(int*) voidPtr = 2;
        while (*(int*) voidPtr < frames.Length)
        {
          if ((object) frames[*(int*) voidPtr].GetMethod().Module.Assembly != (object) Assembly.GetExecutingAssembly())
          {
            *(int*) voidPtr = *(int*) voidPtr + 1;
          }
          else
          {
            *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) 1;
            goto label_8;
          }
        }
        *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) 0;
      }
      catch
      {
        *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) 1;
      }
label_8:
      return (bool) *(sbyte*) ((IntPtr) voidPtr + 4);
    }
  }
}
