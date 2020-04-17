// Decompiled with Syinea's Decompiler
// Type: SmartAssembly.HouseOfCards.MemberRefsProxy
// Assembly: My_EventBot_ßy_Mehmet_Yıldız_ML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B7172642-DC7D-4477-97BD-E927F8349F37
// Assembly location: C:\Users\Syinea\Downloads\CrackedMyEventBot\CrackedVsroEfsane.exe

using ns10;
using System;
using System.Reflection;
using System.Reflection.Emit;

namespace SmartAssembly.HouseOfCards
{
  public static class MemberRefsProxy
  {
    private static char[] char_0 = new char[58]
    {
      '\x0001',
      '\x0002',
      '\x0003',
      '\x0004',
      '\x0005',
      '\x0006',
      '\a',
      '\b',
      '\x000E',
      '\x000F',
      '\x0010',
      '\x0011',
      '\x0012',
      '\x0013',
      '\x0014',
      '\x0015',
      '\x0016',
      '\x0017',
      '\x0018',
      '\x0019',
      '\x001A',
      '\x001B',
      '\x001C',
      '\x001D',
      '\x001E',
      '\x001F',
      '\x007F',
      '\x0080',
      '\x0081',
      '\x0082',
      '\x0083',
      '\x0084',
      '\x0086',
      '\x0087',
      '\x0088',
      '\x0089',
      '\x008A',
      '\x008B',
      '\x008C',
      '\x008D',
      '\x008E',
      '\x008F',
      '\x0090',
      '\x0091',
      '\x0092',
      '\x0093',
      '\x0094',
      '\x0095',
      '\x0096',
      '\x0097',
      '\x0098',
      '\x0099',
      '\x009A',
      '\x009B',
      '\x009C',
      '\x009D',
      '\x009E',
      '\x009F'
    };
    private static ModuleHandle moduleHandle_0;

    [Attribute1]
    public static unsafe void CreateMemberRefsDelegates(int typeID)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(29);
      Type typeFromHandle;
      try
      {
        typeFromHandle = Type.GetTypeFromHandle(MemberRefsProxy.moduleHandle_0.ResolveTypeHandle(33554433 + typeID));
      }
      catch
      {
        return;
      }
      FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
      *(int*) voidPtr = 0;
      while (*(int*) voidPtr < fields.Length)
      {
        FieldInfo fieldInfo = fields[*(int*) voidPtr];
        string name = fieldInfo.Name;
        *(sbyte*) ((IntPtr) voidPtr + 28) = (sbyte) 0;
        *(int*) ((IntPtr) voidPtr + 4) = 0;
        *(int*) ((IntPtr) voidPtr + 8) = name.Length - 1;
        while (*(int*) ((IntPtr) voidPtr + 8) >= 0)
        {
          char ch = name[*(int*) ((IntPtr) voidPtr + 8)];
          if (ch != '~')
          {
            *(int*) ((IntPtr) voidPtr + 12) = 0;
            while (*(int*) ((IntPtr) voidPtr + 12) < 58)
            {
              if ((int) MemberRefsProxy.char_0[*(int*) ((IntPtr) voidPtr + 12)] != (int) ch)
              {
                *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + 1;
              }
              else
              {
                *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) * 58 + *(int*) ((IntPtr) voidPtr + 12);
                break;
              }
            }
            *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) - 1;
          }
          else
          {
            *(sbyte*) ((IntPtr) voidPtr + 28) = (sbyte) 1;
            break;
          }
        }
        MethodInfo methodFromHandle;
        try
        {
          methodFromHandle = (MethodInfo) MethodBase.GetMethodFromHandle(MemberRefsProxy.moduleHandle_0.ResolveMethodHandle(*(int*) ((IntPtr) voidPtr + 4) + 167772161));
        }
        catch
        {
          goto label_41;
        }
        Delegate @delegate;
        if (methodFromHandle.IsStatic)
        {
          try
          {
            @delegate = Delegate.CreateDelegate(fieldInfo.FieldType, methodFromHandle);
          }
          catch (Exception ex)
          {
            goto label_41;
          }
        }
        else
        {
          ParameterInfo[] parameters = methodFromHandle.GetParameters();
          *(int*) ((IntPtr) voidPtr + 16) = parameters.Length + 1;
          Type[] parameterTypes = new Type[*(int*) ((IntPtr) voidPtr + 16)];
          parameterTypes[0] = typeof (object);
          *(int*) ((IntPtr) voidPtr + 20) = 1;
          while (*(int*) ((IntPtr) voidPtr + 20) < *(int*) ((IntPtr) voidPtr + 16))
          {
            parameterTypes[*(int*) ((IntPtr) voidPtr + 20)] = parameters[*(int*) ((IntPtr) voidPtr + 20) - 1].ParameterType;
            *(int*) ((IntPtr) voidPtr + 20) = *(int*) ((IntPtr) voidPtr + 20) + 1;
          }
          DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodFromHandle.ReturnType, parameterTypes, typeFromHandle, true);
          ILGenerator ilGenerator = dynamicMethod.GetILGenerator();
          ilGenerator.Emit(OpCodes.Ldarg_0);
          if (*(int*) ((IntPtr) voidPtr + 16) > 1)
            ilGenerator.Emit(OpCodes.Ldarg_1);
          if (*(int*) ((IntPtr) voidPtr + 16) > 2)
            ilGenerator.Emit(OpCodes.Ldarg_2);
          if (*(int*) ((IntPtr) voidPtr + 16) > 3)
            ilGenerator.Emit(OpCodes.Ldarg_3);
          if (*(int*) ((IntPtr) voidPtr + 16) > 4)
          {
            *(int*) ((IntPtr) voidPtr + 24) = 4;
            while (*(int*) ((IntPtr) voidPtr + 24) < *(int*) ((IntPtr) voidPtr + 16))
            {
              ilGenerator.Emit(OpCodes.Ldarg_S, *(int*) ((IntPtr) voidPtr + 24));
              *(int*) ((IntPtr) voidPtr + 24) = *(int*) ((IntPtr) voidPtr + 24) + 1;
            }
          }
          ilGenerator.Emit(OpCodes.Tailcall);
          ilGenerator.Emit(*(sbyte*) ((IntPtr) voidPtr + 28) != (sbyte) 0 ? OpCodes.Callvirt : OpCodes.Call, methodFromHandle);
          ilGenerator.Emit(OpCodes.Ret);
          try
          {
            @delegate = dynamicMethod.CreateDelegate(typeFromHandle);
          }
          catch
          {
            goto label_41;
          }
        }
        try
        {
          fieldInfo.SetValue((object) null, (object) @delegate);
        }
        catch
        {
        }
label_41:
        *(int*) voidPtr = *(int*) voidPtr + 1;
      }
    }

    static MemberRefsProxy()
    {
      if ((object) typeof (MulticastDelegate) == null)
        return;
      MemberRefsProxy.moduleHandle_0 = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
    }
  }
}
