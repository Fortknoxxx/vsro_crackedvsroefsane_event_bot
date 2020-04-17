// Decompiled with Syinea's Decompiler
// Type: ns2.Class65
// Assembly: My_EventBot_ßy_Mehmet_Yıldız_ML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B7172642-DC7D-4477-97BD-E927F8349F37
// Assembly location: C:\Users\Syinea\Downloads\CrackedMyEventBot\CrackedVsroEfsane.exe

using ns10;
using ns5;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ns2
{
  internal static class Class65
  {
    public static string string_0 = "My_EventBot";
    public static SqlConnection sqlConnection_0;

    [STAThread]
    private static void Main()
    {
      Class73.smethod_94();
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }

    public static void smethod_0(this RichTextBox richTextBox_0, string string_1, Color color_0)
    {
      string_1 += Environment.NewLine;
      richTextBox_0.SelectionStart = richTextBox_0.TextLength;
      richTextBox_0.SelectionLength = 0;
      richTextBox_0.SelectionColor = color_0;
      richTextBox_0.AppendText(string_1);
      richTextBox_0.SelectionColor = richTextBox_0.ForeColor;
    }

    public static void smethod_1()
    {
      Class65.Class66 stateMachine = new Class65.Class66();
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Class65.Class66>(ref stateMachine);
    }

    public static void smethod_2()
    {
      Class65.Class67 stateMachine = new Class65.Class67();
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Class65.Class67>(ref stateMachine);
    }

    public static unsafe void smethod_3()
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      List<string> stringList = new List<string>();
      using (SqlDataReader sqlDataReader = new SqlCommand("select name from My_EventBot..sysobjects where xtype = 'U'", Class65.sqlConnection_0).ExecuteReader())
      {
        while (true)
        {
          *(sbyte*) voidPtr = (sbyte) sqlDataReader.Read();
          if (*(sbyte*) voidPtr != (sbyte) 0)
            stringList.Add(sqlDataReader[0].ToString());
          else
            break;
        }
        sqlDataReader.Close();
      }
      foreach (string string_1 in new List<string>()
      {
        "_PartyListesi",
        "_Oylama",
        "_Sayı_Bul",
        "_AnlıkPM_Log",
        "_AnlıkGlobal_Log",
        "_UniquesLog",
        "_PlusLog",
        "_SoruCevap",
        "_Etkinlik_Takvimi",
        "_Hayatta_Kal",
        "_HayattaKal_List",
        "_AntiPhBot",
        "_UniqKesList",
        "_Piyango"
      })
      {
        *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) stringList.Contains(string_1);
        if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
          Class71.smethod_0(string_1);
      }
    }

    public static unsafe void smethod_4()
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      List<string> stringList = new List<string>();
      using (SqlDataReader sqlDataReader = new SqlCommand("select name from My_EventBot..sysobjects where xtype = 'P'", Class65.sqlConnection_0).ExecuteReader())
      {
        while (true)
        {
          *(sbyte*) voidPtr = (sbyte) sqlDataReader.Read();
          if (*(sbyte*) voidPtr != (sbyte) 0)
            stringList.Add(sqlDataReader[0].ToString());
          else
            break;
        }
        sqlDataReader.Close();
      }
      foreach (string string_1 in new List<string>()
      {
        "__PartyListesi",
        "__Oylama",
        "__Sayı_Bul",
        "_AnlıkChat_Log",
        "_Anlık_UniqueLog",
        "_Ödül_ver",
        "__SoruCevap",
        "__Etkinlik_Takvimi",
        "__Hayatta_Kal",
        "__AntiPhBot",
        "__PlusLog",
        "__Pıyango"
      })
      {
        *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) stringList.Contains(string_1);
        if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
          Class71.smethod_1(string_1);
      }
    }

    public static void smethod_5()
    {
      Class65.Class68 stateMachine = new Class65.Class68();
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Class65.Class68>(ref stateMachine);
    }

    private sealed class Class66 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      private TaskAwaiter taskAwaiter_0;

      unsafe void IAsyncStateMachine.MoveNext()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(4);
        int int0 = this.int_0;
        try
        {
          TaskAwaiter awaiter;
          int num1;
          if (int0 != 0)
          {
            *(sbyte*) voidPtr = (sbyte) (Class65.sqlConnection_0 == null);
            if (*(sbyte*) voidPtr != (sbyte) 0)
            {
              Class65.sqlConnection_0 = new SqlConnection("Data Source=" + Form1.form1_0.textEdit_13.Text + ";Initial Catalog=master;Integrated Security=false; User ID = " + Form1.form1_0.textEdit_14.Text + "; Password = " + Form1.form1_0.textEdit_12.Text + ";MultipleActiveResultSets=true;Connect Timeout=1");
              try
              {
                Class65.sqlConnection_0.Open();
                Form1.smethod_0("SQL SERVER bağlantısı başarılı...");
              }
              catch
              {
                Class65.sqlConnection_0 = (SqlConnection) null;
              }
            }
            *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (Class65.sqlConnection_0 == null);
            if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
            {
              Class65.sqlConnection_0 = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True;Connect Timeout=1");
              try
              {
                Class65.sqlConnection_0.Open();
                Form1.smethod_0("SQL SERVER bağlantısı başarılı...");
              }
              catch
              {
                Class65.sqlConnection_0 = (SqlConnection) null;
              }
            }
            *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) (Class65.sqlConnection_0 == null);
            if (*(sbyte*) ((IntPtr) voidPtr + 2) != (sbyte) 0)
            {
              Class65.sqlConnection_0 = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True;Connect Timeout=1");
              try
              {
                Class65.sqlConnection_0.Open();
                Form1.smethod_0("SQL SERVER bağlantısı başarılı...");
              }
              catch
              {
                Class65.sqlConnection_0 = (SqlConnection) null;
              }
            }
            *(sbyte*) ((IntPtr) voidPtr + 3) = (sbyte) (Class65.sqlConnection_0 == null);
            if (*(sbyte*) ((IntPtr) voidPtr + 3) != (sbyte) 0)
            {
              Form1.smethod_1("SQL Server ile bağlantı kurulamıyor.Lütfen Ayarlar.ini dosyasından SQL ayarlarınızı kontrol edip programı tekrar başlatın.", Color.DarkRed);
              int num2 = (int) MessageBox.Show("SQL Server ile bağlantı kurulamıyor.Lütfen Ayarlar.ini dosyasından SQL ayarlarınızı kontrol edip programı tekrar başlatın.");
              Environment.Exit(0);
            }
            awaiter = Task.Delay(1000).GetAwaiter();
            if (!awaiter.IsCompleted)
            {
              num1 = 0;
              this.int_0 = 0;
              this.taskAwaiter_0 = awaiter;
              Class65.Class66 stateMachine = this;
              this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class65.Class66>(ref awaiter, ref stateMachine);
              return;
            }
          }
          else
          {
            awaiter = this.taskAwaiter_0;
            this.taskAwaiter_0 = new TaskAwaiter();
            num1 = -1;
            this.int_0 = -1;
          }
          awaiter.GetResult();
          awaiter = new TaskAwaiter();
        }
        catch (Exception ex)
        {
          this.int_0 = -2;
          this.asyncVoidMethodBuilder_0.SetException(ex);
          return;
        }
        this.int_0 = -2;
        this.asyncVoidMethodBuilder_0.SetResult();
      }

      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }

    private sealed class Class67 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      private object object_0;
      private int int_1;
      private bool bool_0;
      private SqlDataReader sqlDataReader_0;
      private Exception exception_0;
      private Exception exception_1;
      private Exception exception_2;
      private TaskAwaiter taskAwaiter_0;

      unsafe void IAsyncStateMachine.MoveNext()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(5);
        int num = this.int_0;
        try
        {
          TaskAwaiter awaiter1;
          switch (num)
          {
            case 0:
            case 1:
            case 2:
            case 3:
              try
              {
                TaskAwaiter awaiter2;
                TaskAwaiter awaiter3;
                TaskAwaiter awaiter4;
                TaskAwaiter awaiter5;
                switch (num)
                {
                  case 0:
                    awaiter2 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num = -1;
                    this.int_0 = -1;
                    break;
                  case 1:
                    awaiter3 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num = -1;
                    this.int_0 = -1;
                    goto label_12;
                  case 2:
                    awaiter4 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num = -1;
                    this.int_0 = -1;
                    goto label_23;
                  case 3:
                    awaiter5 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num = -1;
                    this.int_0 = -1;
                    goto label_26;
                  default:
                    awaiter2 = Task.Delay(2500).GetAwaiter();
                    if (!awaiter2.IsCompleted)
                    {
                      num = 0;
                      this.int_0 = 0;
                      this.taskAwaiter_0 = awaiter2;
                      Class65.Class67 stateMachine = this;
                      this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class65.Class67>(ref awaiter2, ref stateMachine);
                      return;
                    }
                    break;
                }
                awaiter2.GetResult();
                awaiter2 = new TaskAwaiter();
                Class65.smethod_1();
                awaiter3 = Task.Delay(1000).GetAwaiter();
                if (!awaiter3.IsCompleted)
                {
                  num = 1;
                  this.int_0 = 1;
                  this.taskAwaiter_0 = awaiter3;
                  Class65.Class67 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class65.Class67>(ref awaiter3, ref stateMachine);
                  return;
                }
label_12:
                awaiter3.GetResult();
                awaiter3 = new TaskAwaiter();
                this.sqlDataReader_0 = new SqlCommand("SELECT COUNT(name) FROM master..sysdatabases where name = 'My_EventBot'", Class65.sqlConnection_0).ExecuteReader();
                try
                {
                  this.sqlDataReader_0.Read();
                  this.bool_0 = Convert.ToBoolean(this.sqlDataReader_0[0]);
                  this.sqlDataReader_0.Close();
                }
                finally
                {
                  if (num < 0 && this.sqlDataReader_0 != null)
                    this.sqlDataReader_0.Dispose();
                }
                this.sqlDataReader_0 = (SqlDataReader) null;
                *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) !this.bool_0;
                if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
                  Class73.smethod_180("My_EventBot");
                else
                  new SqlCommand("USE [My_EventBot]", Class65.sqlConnection_0).ExecuteNonQuery();
                Class65.smethod_3();
                Class65.smethod_4();
                awaiter4 = Task.Delay(2500).GetAwaiter();
                if (!awaiter4.IsCompleted)
                {
                  num = 2;
                  this.int_0 = 2;
                  this.taskAwaiter_0 = awaiter4;
                  Class65.Class67 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class65.Class67>(ref awaiter4, ref stateMachine);
                  return;
                }
label_23:
                awaiter4.GetResult();
                awaiter4 = new TaskAwaiter();
                Form1.smethod_0("Kontroller tamamlandı.");
                new Task(new Action(Form1.form1_0.method_1)).Start();
                Form1.form1_0.button_2.Enabled = true;
                awaiter5 = Task.Delay(1000).GetAwaiter();
                if (!awaiter5.IsCompleted)
                {
                  num = 3;
                  this.int_0 = 3;
                  this.taskAwaiter_0 = awaiter5;
                  Class65.Class67 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class65.Class67>(ref awaiter5, ref stateMachine);
                  return;
                }
label_26:
                awaiter5.GetResult();
                awaiter5 = new TaskAwaiter();
                Form1.form1_0.timer_9.Start();
                Form1.form1_0.timer_10.Start();
                try
                {
                  Class73.smethod_145();
                  Form1.form1_0.method_95();
                }
                catch (Exception ex)
                {
                  this.exception_0 = ex;
                  Form1.smethod_0("Etkinlik takvimi yüklenemedi.. Hata Açıklaması => " + this.exception_0.Message);
                }
              }
              catch (Exception ex)
              {
                this.object_0 = (object) ex;
                this.int_1 = 1;
              }
              *(int*) voidPtr = this.int_1;
              if (*(int*) voidPtr == 1)
              {
                this.exception_1 = (Exception) this.object_0;
                Form1.smethod_1("Kontroller sırasında bir hata oluştu ! Bir kaç saniye içinde kontrol yeniden başlayacak...", Color.Red);
                Form1.smethod_1("Hata almaya devam ederseniz My_EventBot veritabanını sildikten sonra programı yeniden başlatın...", Color.Red);
                Form1.smethod_0(this.exception_1.Message ?? "");
                awaiter1 = Task.Delay(4000).GetAwaiter();
                if (!awaiter1.IsCompleted)
                {
                  this.int_0 = 4;
                  this.taskAwaiter_0 = awaiter1;
                  Class65.Class67 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class65.Class67>(ref awaiter1, ref stateMachine);
                  return;
                }
                break;
              }
              this.object_0 = (object) null;
              try
              {
                Form1.string_0 = Form1.form1_0.textEdit_11.Text;
                Form1.string_1 = Form1.form1_0.textEdit_10.Text;
                Form1.string_2 = Form1.form1_0.textEdit_9.Text;
                goto label_37;
              }
              catch (Exception ex)
              {
                this.exception_2 = ex;
                Form1.smethod_0("DATABASE isimleri ayarlanamadı.Lütfen SQL SERVER bölümünden gerekli alanları hatasız doldurup ayarları kaydettikten sonra programı yeniden başlatın.");
                Form1.smethod_0("Hata Kodu ==> " + this.exception_2.Message);
                goto label_37;
              }
            case 4:
              awaiter1 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              break;
            default:
label_4:
              Form1.smethod_0("Veritabanı kontrolleri yapılıyor...");
              this.int_1 = 0;
              goto case 0;
          }
          awaiter1.GetResult();
          awaiter1 = new TaskAwaiter();
          goto label_4;
        }
        catch (Exception ex)
        {
          this.int_0 = -2;
          this.asyncVoidMethodBuilder_0.SetException(ex);
          return;
        }
label_37:
        this.int_0 = -2;
        this.asyncVoidMethodBuilder_0.SetResult();
      }

      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }

    private sealed class Class68 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      private object object_0;
      private int int_1;
      private TaskAwaiter taskAwaiter_0;

      unsafe void IAsyncStateMachine.MoveNext()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(5);
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
          }
          else
            goto label_5;
label_3:
          awaiter.GetResult();
          awaiter = new TaskAwaiter();
label_4:
          this.object_0 = (object) null;
label_5:
          *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (Class65.sqlConnection_0.State != ConnectionState.Open);
          if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
          {
            this.int_1 = 0;
            try
            {
              Class65.sqlConnection_0.Open();
            }
            catch (object ex)
            {
              this.object_0 = ex;
              this.int_1 = 1;
            }
            *(int*) voidPtr = this.int_1;
            if (*(int*) voidPtr == 1)
            {
              Form1.smethod_0("SQL bağlantı koptu. Yeniden bağlantı deneneniyor.");
              awaiter = Task.Delay(2).GetAwaiter();
              if (!awaiter.IsCompleted)
              {
                num = 0;
                this.int_0 = 0;
                this.taskAwaiter_0 = awaiter;
                Class65.Class68 stateMachine = this;
                this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class65.Class68>(ref awaiter, ref stateMachine);
                return;
              }
              goto label_3;
            }
            else
              goto label_4;
          }
        }
        catch (Exception ex)
        {
          this.int_0 = -2;
          this.asyncVoidMethodBuilder_0.SetException(ex);
          return;
        }
        this.int_0 = -2;
        this.asyncVoidMethodBuilder_0.SetResult();
      }

      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }
  }
}
