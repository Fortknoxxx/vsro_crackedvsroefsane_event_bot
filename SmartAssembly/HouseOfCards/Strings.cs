// Decompiled with Syinea's Decompiler
// Type: SmartAssembly.HouseOfCards.Strings
// Assembly: My_EventBot_ßy_Mehmet_Yıldız_ML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B7172642-DC7D-4477-97BD-E927F8349F37
// Assembly location: C:\Users\Syinea\Downloads\CrackedMyEventBot\CrackedVsroEfsane.exe

using ns10;
using ns2;
using SmartAssembly.Delegates;
using System;
using System.Reflection;
using System.Reflection.Emit;

namespace SmartAssembly.HouseOfCards
{
  public static class Strings
  {
    [Attribute1]
    public static unsafe void CreateGetStringDelegate(Type ownerType)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(8);
      FieldInfo[] fields = ownerType.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
      *(int*) voidPtr = 0;
      while (*(int*) voidPtr < fields.Length)
      {
        FieldInfo fieldInfo = fields[*(int*) voidPtr];
        try
        {
          if ((object) fieldInfo.FieldType == (object) typeof (GetString))
          {
            DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof (string), new Type[1]
            {
              typeof (int)
            }, ownerType.Module, true);
            ILGenerator ilGenerator = dynamicMethod.GetILGenerator();
            ilGenerator.Emit(OpCodes.Ldarg_0);
            MethodInfo[] methods = typeof (Class79).GetMethods(BindingFlags.Static | BindingFlags.Public);
            *(int*) ((IntPtr) voidPtr + 4) = 0;
            while (*(int*) ((IntPtr) voidPtr + 4) < methods.Length)
            {
              MethodInfo meth = methods[*(int*) ((IntPtr) voidPtr + 4)];
              if ((object) meth.ReturnType != (object) typeof (string))
              {
                *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + 1;
              }
              else
              {
                ilGenerator.Emit(OpCodes.Ldc_I4, fieldInfo.MetadataToken & 16777215);
                ilGenerator.Emit(OpCodes.Sub);
                ilGenerator.Emit(OpCodes.Call, meth);
                break;
              }
            }
            ilGenerator.Emit(OpCodes.Ret);
            fieldInfo.SetValue((object) null, (object) dynamicMethod.CreateDelegate(typeof (GetString)));
            break;
          }
        }
        catch
        {
        }
        *(int*) voidPtr = *(int*) voidPtr + 1;
      }
    }
  }
}
