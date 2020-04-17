// Decompiled with Syinea's Decompiler
// Type: SmartAssembly.MemoryManagement.MemoryManager
// Assembly: My_EventBot_ßy_Mehmet_Yıldız_ML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B7172642-DC7D-4477-97BD-E927F8349F37
// Assembly location: C:\Users\Syinea\Downloads\CrackedVsroEfsane.exe

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SmartAssembly.MemoryManagement
{
  public sealed class MemoryManager
  {
    private long long_0 = DateTime.Now.Ticks;
    internal static MemoryManager memoryManager_0;

    [DllImport("kernel32")]
    private static extern int SetProcessWorkingSetSize(
      IntPtr intptr_0,
      IntPtr intptr_1,
      IntPtr intptr_2);

    private void method_0()
    {
      try
      {
        using (Process currentProcess = Process.GetCurrentProcess())
          MemoryManager.SetProcessWorkingSetSize(currentProcess.Handle, new IntPtr(-1), new IntPtr(-1));
      }
      catch
      {
      }
    }

    private void method_1(object sender, EventArgs e)
    {
      try
      {
        long ticks = DateTime.Now.Ticks;
        if (ticks - this.long_0 <= 10000000L)
          return;
        this.long_0 = ticks;
        this.method_0();
      }
      catch
      {
      }
    }

    internal MemoryManager()
    {
      Application.Idle += new EventHandler(this.method_1);
      this.method_0();
    }
  }
}
