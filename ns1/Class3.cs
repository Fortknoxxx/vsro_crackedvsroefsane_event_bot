// Decompiled with Syinea's Decompiler
// Type: ns1.Class3
// Assembly: My_EventBot_ßy_Mehmet_Yıldız_ML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B7172642-DC7D-4477-97BD-E927F8349F37
// Assembly location: C:\Users\Syinea\Downloads\CrackedMyEventBot\CrackedVsroEfsane.exe

using System.IO;

namespace ns1
{
  internal sealed class Class3 : BinaryWriter
  {
    internal MemoryStream memoryStream_0;

    public Class3()
    {
      this.memoryStream_0 = new MemoryStream();
      this.OutStream = (Stream) this.memoryStream_0;
    }
  }
}
