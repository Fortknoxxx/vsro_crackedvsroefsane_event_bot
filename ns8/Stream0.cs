// Decompiled with Syinea's Decompiler
// Type: ns8.Stream0
// Assembly: My_EventBot_ßy_Mehmet_Yıldız_ML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B7172642-DC7D-4477-97BD-E927F8349F37
// Assembly location: C:\Users\Syinea\Downloads\CrackedMyEventBot\CrackedVsroEfsane.exe

using ns0;
using ns2;
using ns6;
using System;
using System.IO;

namespace ns8
{
  internal sealed class Stream0 : Stream
  {
    protected internal Class18 class18_0 = new Class18();
    protected internal int int_0 = 4096;
    protected internal byte[] byte_1 = new byte[1];
    protected internal int int_1;
    protected internal byte[] byte_0;
    protected internal bool bool_0;
    private Stream stream_0;

    public Stream0(Stream stream_1)
    {
      Class73.smethod_178(this);
      this.stream_0 = stream_1;
      Class73.smethod_167(this.class18_0);
      this.bool_0 = false;
    }

    public virtual void System\u002EIO\u002EStream\u002EWriteByte(byte value)
    {
      Class73.smethod_171((int) value, this);
    }

    public virtual unsafe void System\u002EIO\u002EStream\u002EWrite(
      byte[] buffer,
      int offset,
      int count)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(10);
      *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) (count == 0);
      if (*(sbyte*) ((IntPtr) voidPtr + 8) == (sbyte) 0)
      {
        byte[] numArray = new byte[buffer.Length];
        Array.Copy((Array) buffer, 0, (Array) numArray, 0, buffer.Length);
        this.class18_0.byte_0 = numArray;
        this.class18_0.int_1 = offset;
        this.class18_0.int_2 = count;
        do
        {
          this.class18_0.byte_1 = this.byte_0;
          this.class18_0.int_3 = 0;
          this.class18_0.int_4 = this.int_0;
          *(sbyte*) ((IntPtr) voidPtr + 9) = (sbyte) this.bool_0;
          if (*(sbyte*) ((IntPtr) voidPtr + 9) == (sbyte) 0)
            *(int*) voidPtr = Class73.smethod_60(this.class18_0, this.int_1);
          else
            goto label_6;
label_3:
          if ((*(int*) voidPtr == 0 ? 0 : (*(int*) voidPtr != 1 ? 1 : 0)) == 0)
          {
            this.stream_0.Write(this.byte_0, 0, this.int_0 - this.class18_0.int_4);
            continue;
          }
          goto label_9;
label_6:
          Class18 class180 = this.class18_0;
          *(int*) ((IntPtr) voidPtr + 4) = this.int_1;
          *(int*) voidPtr = Class73.smethod_232(*(int*) ((IntPtr) voidPtr + 4), class180);
          goto label_3;
        }
        while ((this.class18_0.int_2 > 0 ? 1 : (this.class18_0.int_4 == 0 ? 1 : 0)) != 0);
        return;
label_9:
        throw new Exception0((this.bool_0 ? "de" : "in") + "flating: " + this.class18_0.string_0);
      }
    }

    public virtual unsafe void vmethod_0()
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(6);
      do
      {
        this.class18_0.byte_1 = this.byte_0;
        this.class18_0.int_3 = 0;
        this.class18_0.int_4 = this.int_0;
        *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) this.bool_0;
        if (*(sbyte*) ((IntPtr) voidPtr + 4) == (sbyte) 0)
          *(int*) voidPtr = Class73.smethod_60(this.class18_0, 4);
        else
          goto label_6;
label_2:
        if ((*(int*) voidPtr == 1 ? 0 : ((uint) *(int*) voidPtr > 0U ? 1 : 0)) == 0)
        {
          *(sbyte*) ((IntPtr) voidPtr + 5) = (sbyte) (this.int_0 - this.class18_0.int_4 > 0);
          if (*(sbyte*) ((IntPtr) voidPtr + 5) != (sbyte) 0)
            this.stream_0.Write(this.byte_0, 0, this.int_0 - this.class18_0.int_4);
          continue;
        }
        goto label_8;
label_6:
        *(int*) voidPtr = Class73.smethod_232(4, this.class18_0);
        goto label_2;
      }
      while ((this.class18_0.int_2 > 0 ? 1 : (this.class18_0.int_4 == 0 ? 1 : 0)) != 0);
      goto label_9;
label_8:
      throw new Exception0((this.bool_0 ? "de" : "in") + "flating: " + this.class18_0.string_0);
label_9:
      try
      {
        ((Stream) this).Flush();
      }
      catch
      {
      }
    }

    public virtual void vmethod_1()
    {
      if (this.bool_0)
        Class73.smethod_166(this.class18_0);
      else
        Class73.smethod_197(this.class18_0);
      Class73.smethod_19(this.class18_0);
      this.class18_0 = (Class18) null;
    }

    public virtual void System\u002EIO\u002EStream\u002EClose()
    {
      try
      {
        this.vmethod_0();
      }
      catch
      {
      }
      finally
      {
        this.vmethod_1();
        this.stream_0.Close();
        this.stream_0 = (Stream) null;
      }
    }

    public virtual void System\u002EIO\u002EStream\u002EFlush()
    {
      this.stream_0.Flush();
    }

    public virtual int System\u002EIO\u002EStream\u002ERead(byte[] buffer, int offset, int count)
    {
      return 0;
    }

    public virtual void System\u002EIO\u002EStream\u002ESetLength(long value)
    {
    }

    public virtual long System\u002EIO\u002EStream\u002ESeek(long offset, SeekOrigin origin)
    {
      return 0;
    }

    public virtual bool System\u002EIO\u002EStream\u002ECanRead
    {
      get
      {
        return false;
      }
    }

    public virtual bool System\u002EIO\u002EStream\u002ECanSeek
    {
      get
      {
        return false;
      }
    }

    public virtual bool System\u002EIO\u002EStream\u002ECanWrite
    {
      get
      {
        return false;
      }
    }

    public virtual long System\u002EIO\u002EStream\u002ELength
    {
      get
      {
        return 0;
      }
    }

    public virtual long System\u002EIO\u002EStream\u002EPosition
    {
      get
      {
        return 0;
      }
      set
      {
      }
    }
  }
}
