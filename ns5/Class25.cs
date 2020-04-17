// Decompiled with Syinea's Decompiler
// Type: ns5.Class25
// Assembly: My_EventBot_ßy_Mehmet_Yıldız_ML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B7172642-DC7D-4477-97BD-E927F8349F37
// Assembly location: C:\Users\Syinea\Downloads\CrackedMyEventBot\CrackedVsroEfsane.exe

using ns10;
using ns4;
using ns6;
using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace ns5
{
  internal static class Class25
  {
    public static int int_0 = 0;
    public static Class29 class29_0 = (Class29) null;
    public static Class19 class19_0 = (Class19) null;
    public static Form1 form1_0 = (Form1) null;
    public static AutoResetEvent autoResetEvent_0 = new AutoResetEvent(true);

    public static void smethod_0(
      string string_0,
      ushort ushort_0,
      uint uint_0,
      uint uint_1,
      string string_1,
      string string_2,
      string string_3,
      string string_4)
    {
      Class25.Class28 stateMachine = new Class25.Class28();
      stateMachine.string_0 = string_0;
      stateMachine.ushort_0 = ushort_0;
      stateMachine.uint_0 = uint_0;
      stateMachine.uint_1 = uint_1;
      stateMachine.string_1 = string_1;
      stateMachine.string_2 = string_2;
      stateMachine.string_3 = string_3;
      stateMachine.string_4 = string_4;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Class25.Class28>(ref stateMachine);
    }

    private sealed class Class26
    {
      public int int_0;
      public string string_0;
      public ushort ushort_0;
      public uint uint_0;
      public uint uint_1;
      public string string_1;
      public string string_2;
      public string string_3;
      public string string_4;

      internal Task method_0()
      {
        Class25.Class26.Class27 stateMachine = new Class25.Class26.Class27();
        stateMachine.class26_0 = this;
        stateMachine.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
        stateMachine.int_0 = -1;
        stateMachine.asyncTaskMethodBuilder_0.Start<Class25.Class26.Class27>(ref stateMachine);
        return stateMachine.asyncTaskMethodBuilder_0.Task;
      }

      private sealed class Class27 : IAsyncStateMachine
      {
        public int int_0;
        public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;
        public Class25.Class26 class26_0;
        private TaskAwaiter taskAwaiter_0;

        unsafe void IAsyncStateMachine.MoveNext()
        {
          // ISSUE: untyped stack allocation
          void* voidPtr = (void*) __untypedstackalloc(2);
          int int0 = this.int_0;
          try
          {
            TaskAwaiter awaiter;
            int num;
            if (int0 == 0)
            {
              awaiter = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_5;
            }
label_3:
            *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) 1;
            Class25.autoResetEvent_0.WaitOne();
            *(sbyte*) voidPtr = (sbyte) (this.class26_0.int_0 == Class25.int_0);
            if (*(sbyte*) voidPtr != (sbyte) 0)
            {
              Class29 class29 = new Class29(this.class26_0.string_0, this.class26_0.ushort_0, this.class26_0.uint_0, this.class26_0.uint_1, this.class26_0.string_1, this.class26_0.string_2, this.class26_0.string_3, this.class26_0.string_4);
              awaiter = Task.Delay(1000).GetAwaiter();
              if (!awaiter.IsCompleted)
              {
                num = 0;
                this.int_0 = 0;
                this.taskAwaiter_0 = awaiter;
                Class25.Class26.Class27 stateMachine = this;
                this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class25.Class26.Class27>(ref awaiter, ref stateMachine);
                return;
              }
            }
            else
              goto label_8;
label_5:
            awaiter.GetResult();
            awaiter = new TaskAwaiter();
            goto label_3;
          }
          catch (Exception ex)
          {
            this.int_0 = -2;
            this.asyncTaskMethodBuilder_0.SetException(ex);
            return;
          }
label_8:
          this.int_0 = -2;
          this.asyncTaskMethodBuilder_0.SetResult();
        }

        void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
        {
        }
      }
    }

    private sealed class Class28 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public string string_0;
      public ushort ushort_0;
      public uint uint_0;
      public uint uint_1;
      public string string_1;
      public string string_2;
      public string string_3;
      public string string_4;
      private Class25.Class26 class26_0;
      private TaskAwaiter<Task> taskAwaiter_0;

      void IAsyncStateMachine.MoveNext()
      {
        int int0 = this.int_0;
        try
        {
          TaskAwaiter<Task> awaiter;
          int num;
          if (int0 != 0)
          {
            this.class26_0 = new Class25.Class26();
            this.class26_0.string_0 = this.string_0;
            this.class26_0.ushort_0 = this.ushort_0;
            this.class26_0.uint_0 = this.uint_0;
            this.class26_0.uint_1 = this.uint_1;
            this.class26_0.string_1 = this.string_1;
            this.class26_0.string_2 = this.string_2;
            this.class26_0.string_3 = this.string_4;
            this.class26_0.string_4 = this.string_3;
            if ((Class25.class29_0 != null ? 1 : (Class25.class19_0 != null ? 1 : 0)) == 0)
            {
              ++Class25.int_0;
              this.class26_0.int_0 = Class25.int_0;
              Class25.autoResetEvent_0.Set();
              awaiter = Task.Factory.StartNew<Task>(new Func<Task>(this.class26_0.method_0)).GetAwaiter();
              if (!awaiter.IsCompleted)
              {
                num = 0;
                this.int_0 = 0;
                this.taskAwaiter_0 = awaiter;
                Class25.Class28 stateMachine = this;
                this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Task>, Class25.Class28>(ref awaiter, ref stateMachine);
                return;
              }
            }
            else
              goto label_8;
          }
          else
          {
            awaiter = this.taskAwaiter_0;
            this.taskAwaiter_0 = new TaskAwaiter<Task>();
            num = -1;
            this.int_0 = -1;
          }
          awaiter.GetResult();
          awaiter = new TaskAwaiter<Task>();
        }
        catch (Exception ex)
        {
          this.int_0 = -2;
          this.asyncVoidMethodBuilder_0.SetException(ex);
          return;
        }
label_8:
        this.int_0 = -2;
        this.asyncVoidMethodBuilder_0.SetResult();
      }

      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }
  }
}
