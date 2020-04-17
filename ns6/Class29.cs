// Decompiled with Syinea's Decompiler
// Type: ns6.Class29
// Assembly: My_EventBot_ßy_Mehmet_Yıldız_ML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B7172642-DC7D-4477-97BD-E927F8349F37
// Assembly location: C:\Users\Syinea\Downloads\CrackedMyEventBot\CrackedVsroEfsane.exe

using ns0;
using ns10;
using ns2;
using ns3;
using ns4;
using ns5;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ns6
{
  internal sealed class Class29
  {
    private Class4 class4_0 = new Class4();
    internal byte[] byte_0 = new byte[8192];
    internal int int_0 = 0;
    internal Socket socket_0;
    private uint uint_0;
    private uint uint_1;
    private string string_0;
    private string string_1;
    private string string_2;
    private string string_3;

    public Class29(
      string string_4,
      ushort ushort_0,
      uint uint_2,
      uint uint_3,
      string string_5,
      string string_6,
      string string_7,
      string string_8)
    {
      try
      {
        if (Class25.class29_0 != null)
          return;
        Class25.class29_0 = this;
        this.uint_0 = uint_3;
        this.uint_1 = uint_2;
        this.string_0 = string_5;
        this.string_1 = string_6;
        this.string_2 = string_7;
        this.string_3 = string_8;
        if (this.socket_0 != null)
          this.socket_0.Close();
        this.socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Form1.form1_0.label_163.Text = "BAĞLANIYOR";
        if (!this.socket_0.BeginConnect(IPAddress.Parse(string_4), (int) ushort_0, (AsyncCallback) null, (object) null).AsyncWaitHandle.WaitOne(1000, true))
          Form1.form1_0.label_163.Text = "BAŞARISIZ";
        Form1.form1_0.label_163.Text = "ONLİNE";
        Form1.form1_0.label_163.ForeColor = Color.GreenYellow;
        Class73.smethod_63(this);
        this.method_1((Class1) null);
        this.method_2();
      }
      catch (Exception ex)
      {
        Class73.smethod_245(this, ex.ToString());
      }
    }

    internal unsafe void method_0(IAsyncResult iasyncResult_0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(52);
      try
      {
        *(int*) voidPtr = this.socket_0.EndReceive(iasyncResult_0);
        *(sbyte*) ((IntPtr) voidPtr + 42) = (sbyte) (*(int*) voidPtr > 0);
        if (*(sbyte*) ((IntPtr) voidPtr + 42) != (sbyte) 0)
        {
          Class4 class40 = this.class4_0;
          byte[] byte0 = this.byte_0;
          Class73.smethod_70(0, class40, *(int*) voidPtr, byte0);
          List<Class1> class1List = Class73.smethod_192(this.class4_0);
          *(sbyte*) ((IntPtr) voidPtr + 43) = (sbyte) (class1List != null);
          if (*(sbyte*) ((IntPtr) voidPtr + 43) != (sbyte) 0)
          {
            foreach (Class1 class1_0_1 in class1List)
            {
              Class73.smethod_131(false, class1_0_1, this);
              *(short*) ((IntPtr) voidPtr + 36) = (short) Class73.smethod_89(class1_0_1);
              if (*(ushort*) ((IntPtr) voidPtr + 36) <= (ushort) 20480)
              {
                if (*(ushort*) ((IntPtr) voidPtr + 36) != (ushort) 8193)
                {
                  if (*(ushort*) ((IntPtr) voidPtr + 36) != (ushort) 8994)
                  {
                    if (*(ushort*) ((IntPtr) voidPtr + 36) != (ushort) 20480)
                      continue;
                  }
                  else
                  {
                    Class73.smethod_163(Class73.smethod_255(class1_0_1));
                    Class1 class1_0_2 = new Class1((ushort) 25379);
                    Class73.smethod_120(class1_0_2, this.string_3);
                    this.method_1(class1_0_2);
                    continue;
                  }
                }
                else
                {
                  *(sbyte*) ((IntPtr) voidPtr + 51) = (sbyte) (Class73.smethod_87(class1_0_1) == "GatewayServer");
                  if (*(sbyte*) ((IntPtr) voidPtr + 51) != (sbyte) 0)
                  {
                    Class1 class1_0_2 = new Class1((ushort) 24832, true, false);
                    Class73.smethod_173((object) this.uint_0, class1_0_2);
                    Class73.smethod_120(class1_0_2, "SR_Client");
                    Class73.smethod_9(class1_0_2, this.uint_1);
                    this.method_1(class1_0_2);
                    continue;
                  }
                  continue;
                }
              }
              else if (*(ushort*) ((IntPtr) voidPtr + 36) != (ushort) 36864)
              {
                switch (*(ushort*) ((IntPtr) voidPtr + 36))
                {
                  case 41216:
                    *(sbyte*) ((IntPtr) voidPtr + 49) = (sbyte) (Class73.smethod_16(class1_0_1) == (byte) 1);
                    if (*(sbyte*) ((IntPtr) voidPtr + 49) != (sbyte) 0)
                      this.method_1(new Class1((ushort) 24833, true));
                    *(sbyte*) ((IntPtr) voidPtr + 50) = (sbyte) (Class25.class19_0 == null);
                    if (*(sbyte*) ((IntPtr) voidPtr + 50) != (sbyte) 0)
                    {
                      Class1 class1_0_2 = new Class1((ushort) 24834);
                      Class73.smethod_162((byte) 22, class1_0_2);
                      Class73.smethod_120(class1_0_2, this.string_0);
                      Class73.smethod_120(class1_0_2, this.string_1);
                      Class73.smethod_65((ushort) 64, class1_0_2);
                      this.method_1(class1_0_2);
                      continue;
                    }
                    continue;
                  case 41217:
                    *(sbyte*) ((IntPtr) voidPtr + 48) = (sbyte) (Class73.smethod_16(class1_0_1) == (byte) 1);
                    if (*(sbyte*) ((IntPtr) voidPtr + 48) != (sbyte) 0)
                    {
                      *(int*) ((IntPtr) voidPtr + 16) = (int) Class73.smethod_16(class1_0_1);
                      Class73.smethod_87(class1_0_1);
                      *(int*) ((IntPtr) voidPtr + 20) = (int) Class73.smethod_165(class1_0_1);
                      Class73.smethod_87(class1_0_1);
                      *(int*) ((IntPtr) voidPtr + 24) = (int) Class73.smethod_11(class1_0_1);
                      *(int*) ((IntPtr) voidPtr + 28) = (int) Class73.smethod_11(class1_0_1);
                      *(int*) ((IntPtr) voidPtr + 32) = (int) Class73.smethod_16(class1_0_1);
                      *(short*) ((IntPtr) voidPtr + 40) = (short) Class73.smethod_11(class1_0_1);
                      Class73.smethod_0(*(uint*) ((IntPtr) voidPtr + 32), *(int*) ((IntPtr) voidPtr + 28), *(int*) ((IntPtr) voidPtr + 24), this);
                      continue;
                    }
                    continue;
                  case 41218:
                    *(int*) ((IntPtr) voidPtr + 4) = (int) Class73.smethod_16(class1_0_1);
                    *(sbyte*) ((IntPtr) voidPtr + 45) = (sbyte) (*(uint*) ((IntPtr) voidPtr + 4) == 1U);
                    if (*(sbyte*) ((IntPtr) voidPtr + 45) != (sbyte) 0)
                    {
                      *(int*) ((IntPtr) voidPtr + 8) = (int) Class73.smethod_165(class1_0_1);
                      string string_6 = Class73.smethod_87(class1_0_1);
                      *(short*) ((IntPtr) voidPtr + 38) = (short) Class73.smethod_11(class1_0_1);
                      Class19 class19 = new Class19(string_6, *(ushort*) ((IntPtr) voidPtr + 38), this.uint_1, this.uint_0, this.string_0, this.string_1, this.string_2, *(uint*) ((IntPtr) voidPtr + 8));
                      continue;
                    }
                    *(sbyte*) ((IntPtr) voidPtr + 46) = (sbyte) (*(uint*) ((IntPtr) voidPtr + 4) == 2U);
                    if (*(sbyte*) ((IntPtr) voidPtr + 46) != (sbyte) 0)
                    {
                      *(int*) ((IntPtr) voidPtr + 12) = (int) Class73.smethod_16(class1_0_1);
                      string[] strArray = new string[12]
                      {
                        "Bilinmeyen Hata",
                        "ID veya şifre hatalı",
                        "Üyelik girişi server tarafından reddedildi",
                        "Karakter zaten oyunda.",
                        "Server full. Tekrar deneyin. / veya server Check.",
                        "(C7) Bağlantı hatası",
                        "(C8) Bağlantı hatası",
                        "Karakter IP limit sınırına takıldı.",
                        "Bilinmiyor",
                        "18 yaş hatası( [GM] girişi için yetkili ip ayarlanmamış olabilir ! )",
                        "12 yaş hatası( [GM] girişi için yetkili ip ayarlanmamış olabilir ! )",
                        "18 yaş hatası( [GM] girişi için yetkili ip ayarlanmamış olabilir ! )"
                      };
                      *(sbyte*) ((IntPtr) voidPtr + 47) = (sbyte) (*(uint*) ((IntPtr) voidPtr + 12) == 1U);
                      if (*(sbyte*) ((IntPtr) voidPtr + 47) != (sbyte) 0)
                        ++Class25.int_0;
                      if ((*(uint*) ((IntPtr) voidPtr + 12) < 1U ? 0 : (*(uint*) ((IntPtr) voidPtr + 12) <= 11U ? 1 : 0)) != 0)
                      {
                        Class73.smethod_245(this, strArray[(int) *(uint*) ((IntPtr) voidPtr + 12)]);
                        continue;
                      }
                      Class73.smethod_245(this, strArray[0]);
                      continue;
                    }
                    Class73.smethod_245(this, "Bilinmeyen hata kodu => 0xa102 uint8 != 1");
                    continue;
                  default:
                    if (*(ushort*) ((IntPtr) voidPtr + 36) == (ushort) 41763)
                    {
                      *(sbyte*) ((IntPtr) voidPtr + 44) = (sbyte) (Class73.smethod_16(class1_0_1) == (byte) 2);
                      if (*(sbyte*) ((IntPtr) voidPtr + 44) != (sbyte) 0)
                      {
                        ++Class25.int_0;
                        Class73.smethod_245(this, "Captcha kodu hatalı");
                        continue;
                      }
                      continue;
                    }
                    continue;
                }
              }
              this.method_1((Class1) null);
            }
          }
          Class73.smethod_63(this);
        }
        else
          Class73.smethod_245(this, "nReceived < 1");
      }
      catch (Exception ex)
      {
        Class73.smethod_245(this, ex.ToString());
      }
    }

    private void method_1(Class1 class1_0)
    {
      try
      {
        if (class1_0 != null)
          Class73.smethod_176(class1_0, this.class4_0);
        foreach (KeyValuePair<Class6, Class1> keyValuePair in Class73.smethod_216(this.class4_0))
        {
          Class73.smethod_131(true, keyValuePair.Value, this);
          this.socket_0.Send(Class73.smethod_155(keyValuePair.Key));
        }
      }
      catch
      {
      }
    }

    private void method_2()
    {
      Class29.Class30 stateMachine = new Class29.Class30();
      stateMachine.class29_0 = this;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Class29.Class30>(ref stateMachine);
    }

    private sealed class Class30 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public Class29 class29_0;
      private Class1 class1_0;
      private Class1 class1_1;
      private TaskAwaiter taskAwaiter_0;

      void IAsyncStateMachine.MoveNext()
      {
        int int0 = this.int_0;
        try
        {
          TaskAwaiter awaiter1;
          int num;
          TaskAwaiter awaiter2;
          switch (int0)
          {
            case 0:
              awaiter2 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_7;
            case 1:
              awaiter1 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              break;
            default:
label_5:
              if (this.class29_0.socket_0 != null)
              {
                awaiter2 = Task.Delay(2500).GetAwaiter();
                if (!awaiter2.IsCompleted)
                {
                  num = 0;
                  this.int_0 = 0;
                  this.taskAwaiter_0 = awaiter2;
                  Class29.Class30 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class29.Class30>(ref awaiter2, ref stateMachine);
                  return;
                }
                goto label_7;
              }
              else
                goto label_11;
          }
label_4:
          awaiter1.GetResult();
          awaiter1 = new TaskAwaiter();
          this.class1_1 = new Class1((ushort) 24833, true);
          this.class29_0.method_1(this.class1_1);
          this.class1_0 = (Class1) null;
          this.class1_1 = (Class1) null;
          goto label_5;
label_7:
          awaiter2.GetResult();
          awaiter2 = new TaskAwaiter();
          this.class1_0 = new Class1((ushort) 8194);
          this.class29_0.method_1(this.class1_0);
          awaiter1 = Task.Delay(2500).GetAwaiter();
          if (!awaiter1.IsCompleted)
          {
            num = 1;
            this.int_0 = 1;
            this.taskAwaiter_0 = awaiter1;
            Class29.Class30 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class29.Class30>(ref awaiter1, ref stateMachine);
            return;
          }
          goto label_4;
        }
        catch (Exception ex)
        {
          this.int_0 = -2;
          this.asyncVoidMethodBuilder_0.SetException(ex);
          return;
        }
label_11:
        this.int_0 = -2;
        this.asyncVoidMethodBuilder_0.SetResult();
      }

      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }
  }
}
