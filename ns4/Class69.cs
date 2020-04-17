// Decompiled with Syinea's Decompiler
// Type: ns4.Class69
// Assembly: My_EventBot_ßy_Mehmet_Yıldız_ML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B7172642-DC7D-4477-97BD-E927F8349F37
// Assembly location: C:\Users\Syinea\Downloads\CrackedMyEventBot\CrackedVsroEfsane.exe

using ns10;
using ns2;
using ns9;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ns4
{
  internal sealed class Class69
  {
    public static string string_0 = "127.0.0.1";
    public static WebClient webClient_0 = new WebClient();
    public static int int_0 = 0;
    public static string string_1 = Class69.smethod_0(Class73.smethod_62("myeventbot")) + "t" + Class69.smethod_2(Class73.smethod_62("my-eventbot")) + ".si";

    public static unsafe string smethod_0(string string_2)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(5);
      string str = string_2;
      string empty = string.Empty;
      List<char> list = ((IEnumerable<char>) str.ToCharArray()).ToList<char>();
      *(int*) voidPtr = 0;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (*(int*) voidPtr < list.Count);
        if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
        {
          empty += ((char) ((uint) list[*(int*) voidPtr] + 3U)).ToString();
          *(int*) voidPtr = *(int*) voidPtr + 1;
        }
        else
          break;
      }
      return empty;
    }

    public static void smethod_1(string string_2)
    {
      Class69.Class70 stateMachine = new Class69.Class70();
      stateMachine.string_0 = string_2;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Class69.Class70>(ref stateMachine);
    }

    public static unsafe string smethod_2(string string_2)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(5);
      string str = string_2;
      string empty = string.Empty;
      List<char> list = ((IEnumerable<char>) str.ToCharArray()).ToList<char>();
      *(int*) voidPtr = 0;
      while (true)
      {
        *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (*(int*) voidPtr < list.Count);
        if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
        {
          empty += ((char) ((uint) list[*(int*) voidPtr] + 3U)).ToString();
          *(int*) voidPtr = *(int*) voidPtr + 1;
        }
        else
          break;
      }
      return empty;
    }

    private sealed class Class70 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public string string_0;
      private int int_1;
      private TaskAwaiter taskAwaiter_0;

      unsafe void IAsyncStateMachine.MoveNext()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(2);
        int int0 = this.int_0;
        try
        {
          TaskAwaiter awaiter1;
          int num;
          TaskAwaiter awaiter2;
          switch (int0)
          {
            case 0:
              awaiter1 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              break;
            case 1:
              awaiter2 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_11;
            default:
              this.int_1 = (int) Convert.ToInt16(this.string_0);
              *(sbyte*) voidPtr = (sbyte) (this.int_1 < 0);
              if (*(sbyte*) voidPtr != (sbyte) 0)
              {
                Form1.form1_0.checkBox_25.Checked = false;
                Form1.smethod_1("Lisansınız bulunmamakta.Lütfen geliştirici ile iletişime geçiniz..", Color.DarkGoldenrod);
                Form1.smethod_1("Profilim = https://www.vsro.org/members/efsanesro.3096/", Color.DarkGoldenrod);
                Form1.smethod_1("Facebook adresi = www.facebook.com/efsanesroreborn", Color.DarkGoldenrod);
                Form1.form1_0.label_13.Text = "Lisans Yok";
                Form1.form1_0.label_171.Text = "Lisans Yok";
                Form1.form1_0.label_12.Text = "Lisans Yok";
                Form1.form1_0.timer_11.Start();
                Form1.form1_0.button_2.Visible = false;
                Form1.form1_0.button_19.Visible = false;
                goto label_13;
              }
              else
              {
                *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (this.int_1 >= 0);
                if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
                {
                  Class69.int_0 = this.int_1;
                  Class32.bool_0 = true;
                  Form1.form1_0.checkBox_25.Checked = true;
                  Class73.smethod_237();
                  Form1.form1_0.label_12.Text = this.string_0 ?? "";
                  Form1.form1_0.button_19.Enabled = true;
                  Form1.smethod_3();
                  Class73.smethod_69(Form1.form1_0);
                  awaiter1 = Task.Delay(3000).GetAwaiter();
                  if (!awaiter1.IsCompleted)
                  {
                    num = 0;
                    this.int_0 = 0;
                    this.taskAwaiter_0 = awaiter1;
                    Class69.Class70 stateMachine = this;
                    this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class69.Class70>(ref awaiter1, ref stateMachine);
                    return;
                  }
                  break;
                }
                goto label_13;
              }
          }
          awaiter1.GetResult();
          awaiter1 = new TaskAwaiter();
          Form1.smethod_2();
          Form1.form1_0.timer_0.Start();
          awaiter2 = Task.Delay(10000).GetAwaiter();
          if (!awaiter2.IsCompleted)
          {
            num = 1;
            this.int_0 = 1;
            this.taskAwaiter_0 = awaiter2;
            Class69.Class70 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class69.Class70>(ref awaiter2, ref stateMachine);
            return;
          }
label_11:
          awaiter2.GetResult();
          awaiter2 = new TaskAwaiter();
          new Task(new Action(Class65.smethod_2)).Start();
          Form1.form1_0.button_24.Enabled = true;
          Form1.form1_0.button_25.Enabled = true;
          Form1.form1_0.label_146.Visible = false;
        }
        catch (Exception ex)
        {
          this.int_0 = -2;
          this.asyncVoidMethodBuilder_0.SetException(ex);
          return;
        }
label_13:
        this.int_0 = -2;
        this.asyncVoidMethodBuilder_0.SetResult();
      }

      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }
  }
}
