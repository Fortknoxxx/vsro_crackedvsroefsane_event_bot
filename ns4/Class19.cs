// Decompiled with Syinea's Decompiler
// Type: ns4.Class19
// Assembly: My_EventBot_ßy_Mehmet_Yıldız_ML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B7172642-DC7D-4477-97BD-E927F8349F37
// Assembly location: C:\Users\Syinea\Downloads\CrackedMyEventBot\CrackedVsroEfsane.exe

using ns0;
using ns10;
using ns2;
using ns3;
using ns5;
using ns9;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ns4
{
  internal sealed class Class19
  {
    public static string string_0 = "127.0.0.1";
    public static string string_4 = "";
    public static string string_5 = "Bu Dünyada Herşey Para Demek Değildir Program Bedavadır.";
    public static bool bool_1 = false;
    public static bool bool_2 = false;
    private Class4 class4_0 = new Class4();
    internal byte[] byte_0 = new byte[8192];
    private bool bool_0 = false;
    internal Socket socket_0;
    private uint uint_0;
    private uint uint_1;
    private uint uint_2;
    private string string_1;
    private string string_2;
    private string string_3;

    public Class19(
      string string_6,
      ushort ushort_0,
      uint uint_3,
      uint uint_4,
      string string_7,
      string string_8,
      string string_9,
      uint uint_5)
    {
      try
      {
        if (Class25.class19_0 != null)
          return;
        Class25.class19_0 = this;
        this.uint_1 = uint_4;
        this.uint_2 = uint_3;
        this.string_1 = string_7;
        this.string_2 = string_8;
        this.string_3 = string_9;
        this.uint_0 = uint_5;
        if (this.socket_0 != null)
          this.socket_0.Close();
        this.socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Form1.form1_0.label_161.Text = "BAĞLANIYOR";
        if (!this.socket_0.BeginConnect(IPAddress.Parse(string_6), (int) ushort_0, (AsyncCallback) null, (object) null).AsyncWaitHandle.WaitOne(100))
          Form1.form1_0.label_161.Text = "BAŞARISIZ";
        Form1.form1_0.label_161.Text = "ONLİNE";
        Form1.form1_0.label_161.ForeColor = Color.GreenYellow;
        Class73.smethod_24(this);
        this.method_1((Class1) null);
        this.method_2();
      }
      catch (Exception ex)
      {
        Class73.smethod_217(this, ex.ToString());
      }
    }

    internal void method_0(IAsyncResult iasyncResult_0)
    {
      Class19.Class20 stateMachine = new Class19.Class20();
      stateMachine.class19_0 = this;
      stateMachine.iasyncResult_0 = iasyncResult_0;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Class19.Class20>(ref stateMachine);
    }

    public void method_1(Class1 class1_0)
    {
      try
      {
        if (class1_0 != null)
          Class73.smethod_176(class1_0, this.class4_0);
        foreach (KeyValuePair<Class6, Class1> keyValuePair in Class73.smethod_216(this.class4_0))
        {
          Class73.smethod_128(true, keyValuePair.Value, this);
          this.socket_0.Send(Class73.smethod_155(keyValuePair.Key));
        }
      }
      catch
      {
      }
    }

    private void method_2()
    {
      Class19.Class21 stateMachine = new Class19.Class21();
      stateMachine.class19_0 = this;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Class19.Class21>(ref stateMachine);
    }

    public static void smethod_0(string string_6)
    {
      Class19.Class22 stateMachine = new Class19.Class22();
      stateMachine.string_0 = string_6;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Class19.Class22>(ref stateMachine);
    }

    internal Task method_3()
    {
      Class19.Class23 stateMachine = new Class19.Class23();
      stateMachine.class19_0 = this;
      stateMachine.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncTaskMethodBuilder_0.Start<Class19.Class23>(ref stateMachine);
      return stateMachine.asyncTaskMethodBuilder_0.Task;
    }

    private sealed class Class20 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public IAsyncResult iasyncResult_0;
      public Class19 class19_0;
      private int int_1;
      private List<Class1> list_0;
      private List<Class1>.Enumerator enumerator_0;
      private Class1 class1_0;
      private uint uint_0;
      private byte byte_0;
      private byte byte_1;
      private byte byte_2;
      private byte byte_3;
      private int int_2;
      private ushort ushort_0;
      private Class1 class1_1;
      private Class1 class1_2;
      private Class1 class1_3;
      private uint uint_1;
      private List<string> list_1;
      private string string_0;
      private int int_3;
      private int int_4;
      private int int_5;
      private int int_6;
      private int int_7;
      private List<string>.Enumerator enumerator_1;
      private string string_1;
      private string string_2;
      private string string_3;
      private string string_4;
      private string string_5;
      private string string_6;
      private string string_7;
      private string string_8;
      private int int_8;
      private int int_9;
      private int int_10;
      private int int_11;
      private int int_12;
      private int int_13;
      private string string_9;
      private Exception exception_0;
      private int int_14;
      private char[] char_0;
      private int int_15;
      private Exception exception_1;
      private SqlDataReader sqlDataReader_0;
      private int int_16;
      private int int_17;
      private int int_18;
      private Exception exception_2;
      private SqlDataReader sqlDataReader_1;
      private Exception exception_3;
      private Exception exception_4;
      private Exception exception_5;
      private Exception exception_6;
      private Exception exception_7;
      private int int_19;
      private int int_20;
      private string string_10;
      private int int_21;
      private int int_22;
      private string string_11;
      private Exception exception_8;
      private uint uint_2;
      private Exception exception_9;
      private uint uint_3;
      private string string_12;
      private Exception exception_10;
      private Exception exception_11;
      private Exception exception_12;
      private Exception exception_13;
      private Class1 class1_4;
      private Class1 class1_5;
      private byte[] byte_4;
      private string string_13;
      private bool bool_0;
      private byte[] byte_5;
      private string string_14;
      private bool bool_1;
      private Exception exception_14;
      private TaskAwaiter<SqlDataReader> taskAwaiter_0;
      private TaskAwaiter taskAwaiter_1;
      private TaskAwaiter<int> taskAwaiter_2;

      unsafe void IAsyncStateMachine.MoveNext()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(79);
        int num1 = this.int_0;
        try
        {
          switch (num1)
          {
            default:
              try
              {
                switch (num1)
                {
                  case 0:
                  case 1:
                  case 2:
                  case 3:
                  case 4:
                  case 5:
                  case 6:
                  case 7:
                  case 8:
                  case 9:
                  case 10:
                    try
                    {
                      TaskAwaiter awaiter1;
                      TaskAwaiter awaiter2;
                      TaskAwaiter awaiter3;
                      TaskAwaiter awaiter4;
                      TaskAwaiter awaiter5;
                      TaskAwaiter awaiter6;
                      TaskAwaiter awaiter7;
                      TaskAwaiter awaiter8;
                      switch (num1)
                      {
                        case 0:
                        case 1:
                          try
                          {
                            TaskAwaiter<SqlDataReader> awaiter9;
                            TaskAwaiter<SqlDataReader> awaiter10;
                            switch (num1)
                            {
                              case 0:
                                awaiter9 = this.taskAwaiter_0;
                                this.taskAwaiter_0 = new TaskAwaiter<SqlDataReader>();
                                num1 = -1;
                                this.int_0 = -1;
                                break;
                              case 1:
                                awaiter10 = this.taskAwaiter_0;
                                this.taskAwaiter_0 = new TaskAwaiter<SqlDataReader>();
                                num1 = -1;
                                this.int_0 = -1;
                                goto label_111;
                              default:
                                *(sbyte*) ((IntPtr) voidPtr + 35) = (sbyte) Form1.form1_0.checkBox_23.Checked;
                                if (*(sbyte*) ((IntPtr) voidPtr + 35) != (sbyte) 0)
                                {
                                  if ((this.string_3.ToString() == "1" || this.string_3.ToString() == "2" || (this.string_3.ToString() == "3" || this.string_3.ToString() == "4") || (this.string_3.ToString() == "5" || this.string_3.ToString() == "6" || (this.string_3.ToString() == "7" || this.string_3.ToString() == "8")) ? 1 : (this.string_3.ToString() == "9" ? 1 : 0)) != 0)
                                  {
                                    *(sbyte*) ((IntPtr) voidPtr + 36) = (sbyte) Class32.list_1.Contains(this.string_2);
                                    if (*(sbyte*) ((IntPtr) voidPtr + 36) != (sbyte) 0)
                                    {
                                      Class73.smethod_123(this.class19_0, this.string_2, "Seçimin değiştirildi. !!");
                                      awaiter9 = new SqlCommand("exec My_EventBot..__Oylama '" + this.string_2 + "','" + this.string_3 + "'", Class65.sqlConnection_0).ExecuteReaderAsync().GetAwaiter();
                                      if (!awaiter9.IsCompleted)
                                      {
                                        num1 = 0;
                                        this.int_0 = 0;
                                        this.taskAwaiter_0 = awaiter9;
                                        Class19.Class20 stateMachine = this;
                                        this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<SqlDataReader>, Class19.Class20>(ref awaiter9, ref stateMachine);
                                        return;
                                      }
                                      break;
                                    }
                                    goto label_108;
                                  }
                                  else if ((this.string_3.ToString() != "1" || this.string_3.ToString() != "2" || (this.string_3.ToString() != "3" || this.string_3.ToString() != "4") || (this.string_3.ToString() != "5" || this.string_3.ToString() != "6" || (this.string_3.ToString() != "7" || this.string_3.ToString() != "8")) ? 1 : (this.string_3.ToString() != "9" ? 1 : 0)) != 0)
                                  {
                                    Class73.smethod_123(this.class19_0, this.string_2, "Geçersiz Oy !! Sadece 1-9 arası seçim yapabilirsin.");
                                    goto label_112;
                                  }
                                  else
                                    goto label_112;
                                }
                                else
                                  goto label_112;
                            }
                            awaiter9.GetResult();
                            awaiter9 = new TaskAwaiter<SqlDataReader>();
label_108:
                            *(sbyte*) ((IntPtr) voidPtr + 37) = (sbyte) !Class32.list_1.Contains(this.string_2);
                            if (*(sbyte*) ((IntPtr) voidPtr + 37) != (sbyte) 0)
                            {
                              Class32.list_1.Add(this.string_2);
                              Class73.smethod_123(this.class19_0, this.string_2, "Oy kullanma başarılı.Dilersen seçimini değiştirebilirsin.");
                              awaiter10 = new SqlCommand("exec My_EventBot..__Oylama '" + this.string_2 + "','" + this.string_3 + "'", Class65.sqlConnection_0).ExecuteReaderAsync().GetAwaiter();
                              if (!awaiter10.IsCompleted)
                              {
                                num1 = 1;
                                this.int_0 = 1;
                                this.taskAwaiter_0 = awaiter10;
                                Class19.Class20 stateMachine = this;
                                this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<SqlDataReader>, Class19.Class20>(ref awaiter10, ref stateMachine);
                                return;
                              }
                            }
                            else
                              goto label_112;
label_111:
                            awaiter10.GetResult();
                            awaiter10 = new TaskAwaiter<SqlDataReader>();
label_112:
                            *(sbyte*) ((IntPtr) voidPtr + 38) = (sbyte) Form1.form1_0.checkBox_12.Checked;
                            if (*(sbyte*) ((IntPtr) voidPtr + 38) != (sbyte) 0)
                            {
                              this.int_10 = (int) Convert.ToInt16(Form1.form1_0.textBox_29.Text);
                              this.int_11 = (int) Convert.ToInt16(Form1.form1_0.textBox_27.Text);
                              this.int_12 = (int) Convert.ToInt16(Form1.form1_0.textBox_80.Text);
                              this.int_13 = (int) Convert.ToInt16(Form1.form1_0.textBox_28.Text);
                              this.string_9 = Form1.form1_0.textBox_79.Text;
                              this.string_3 = this.string_3.Replace("'", "''");
                              try
                              {
                                new SqlCommand("Exec My_EventBot.._AnlıkChat_Log 1,'" + this.string_2 + "','" + this.string_3 + "'", Class65.sqlConnection_0).ExecuteNonQuery();
                                Class73.smethod_123(this.class19_0, this.string_2, "Cevabın alındı. Daha önce zaten bir cevap yazdıysan artık geçersiz.Herzaman son cevabın dikkate alınır.");
                              }
                              catch (Exception ex)
                              {
                                this.exception_0 = ex;
                                Form1.smethod_1("[SoruCevap] etkinliği için gelen PM tabloya yazdırılamadı. Hata => " + this.exception_0.Message, Color.Salmon);
                              }
                              this.string_9 = (string) null;
                            }
                            *(sbyte*) ((IntPtr) voidPtr + 39) = (sbyte) Form1.form1_0.checkEdit_0.Checked;
                            if (*(sbyte*) ((IntPtr) voidPtr + 39) != (sbyte) 0)
                            {
                              *(sbyte*) ((IntPtr) voidPtr + 40) = (sbyte) Form1.form1_0.checkBox_22.Checked;
                              if (*(sbyte*) ((IntPtr) voidPtr + 40) != (sbyte) 0)
                              {
                                this.string_3 = this.string_3.Replace("'", "''");
                                *(sbyte*) ((IntPtr) voidPtr + 41) = (sbyte) int.TryParse(this.string_3, out this.int_14);
                                if (*(sbyte*) ((IntPtr) voidPtr + 41) != (sbyte) 0)
                                {
                                  this.char_0 = this.string_3.ToCharArray();
                                  this.int_15 = this.char_0.Length;
                                  *(sbyte*) ((IntPtr) voidPtr + 42) = (sbyte) (this.int_15 <= 4);
                                  if (*(sbyte*) ((IntPtr) voidPtr + 42) != (sbyte) 0)
                                  {
                                    try
                                    {
                                      *(sbyte*) ((IntPtr) voidPtr + 43) = (sbyte) Form1.form1_0.listBox_16.Items.Contains((object) this.string_2);
                                      if (*(sbyte*) ((IntPtr) voidPtr + 43) != (sbyte) 0)
                                        Class73.smethod_123(this.class19_0, this.string_2, "Bu tur için zaten bir tahminde bulundun. Birdaha ki tura tekrar katılabilirsin.");
                                      *(sbyte*) ((IntPtr) voidPtr + 44) = (sbyte) !Form1.form1_0.listBox_16.Items.Contains((object) this.string_2);
                                      if (*(sbyte*) ((IntPtr) voidPtr + 44) != (sbyte) 0)
                                      {
                                        new SqlCommand("Exec My_EventBot..__Sayı_Bul '" + this.string_2 + "','" + (object) this.int_14 + "'", Class65.sqlConnection_0).ExecuteNonQuery();
                                        Class73.smethod_123(this.class19_0, this.string_2, "Tahmin Alındı.Bu tahmin değiştirilemez ve bu tur için başka tahmin hakkın yok.");
                                        Form1.form1_0.listBox_16.Items.Add((object) this.string_2);
                                      }
                                    }
                                    catch (Exception ex)
                                    {
                                      this.exception_1 = ex;
                                      Form1.smethod_1("[Sayı Tahmin] etkinliği için gelen Tahmin tabloya yazdırılamadı. Hata => " + this.exception_1.Message, Color.Salmon);
                                    }
                                  }
                                  else
                                  {
                                    *(sbyte*) ((IntPtr) voidPtr + 45) = (sbyte) (this.int_15 > 4);
                                    if (*(sbyte*) ((IntPtr) voidPtr + 45) != (sbyte) 0)
                                      Class73.smethod_123(this.class19_0, this.string_2, "Tahmininiz en fazla 4 basamaklı bir rakam(9999) olabilir.");
                                  }
                                  this.char_0 = (char[]) null;
                                }
                                else
                                  Class73.smethod_123(this.class19_0, this.string_2, "Geçersiz tahmin. Lütfen verilen sayılar aralığında bir tahminde bulunun...");
                              }
                              else
                              {
                                *(sbyte*) ((IntPtr) voidPtr + 46) = (sbyte) !Form1.form1_0.checkBox_22.Checked;
                                if (*(sbyte*) ((IntPtr) voidPtr + 46) != (sbyte) 0)
                                  Class73.smethod_123(this.class19_0, this.string_2, "Tahmin alma sistemi şuan kapalı.Notice ile bildirim yapıldığında tahminde bulunabilirsin.");
                              }
                            }
                            this.int_9 = (int) Convert.ToInt16(Form1.form1_0.textBox_17.Text);
                            if ((!Form1.form1_0.checkBox_21.Checked ? 0 : (!Form1.form1_0.bool_0 ? 1 : 0)) != 0)
                              Class73.smethod_123(this.class19_0, this.string_2, "Kayıt şuan aktif değil.");
                            *(sbyte*) ((IntPtr) voidPtr + 47) = (sbyte) Form1.form1_0.bool_0;
                            if (*(sbyte*) ((IntPtr) voidPtr + 47) != (sbyte) 0)
                            {
                              if ((!(this.string_3 == "IPTAL") ? 0 : (Form1.list_0.Contains(this.string_2) ? 1 : 0)) != 0)
                              {
                                Form1.list_0.Remove(this.string_2);
                                Form1.form1_0.listBox_14.Items.Remove((object) this.string_2);
                                Class73.smethod_123(this.class19_0, this.string_2, "Kaydınız silindi.");
                              }
                              else if ((!(this.string_3 == "IPTAL") ? 0 : (!Form1.list_0.Contains(this.string_2) ? 1 : 0)) != 0)
                                Class73.smethod_123(this.class19_0, this.string_2, "Zaten kayıtlı değilsin.. ");
                              if ((!(this.string_3 != "KAYIT") ? 0 : (this.string_3 != "IPTAL" ? 1 : 0)) != 0)
                                Class73.smethod_123(this.class19_0, this.string_2, "Yazım hatası !! Etkinliğe kaydolmak için KAYIT yazınız.");
                              if ((!(this.string_3 == "KAYIT") || Form1.list_0.Count >= this.int_9 ? 0 : (!Form1.list_0.Contains(this.string_2) ? 1 : 0)) != 0)
                              {
                                try
                                {
                                  this.sqlDataReader_0 = new SqlCommand("Exec My_EventBot..__Hayatta_Kal '" + this.string_2 + "', 'LVL_KONTROL'", Class65.sqlConnection_0).ExecuteReader();
                                  try
                                  {
                                    this.sqlDataReader_0.Read();
                                    this.int_16 = (int) Convert.ToInt16(this.sqlDataReader_0[0]);
                                    this.int_17 = (int) Convert.ToInt16(this.sqlDataReader_0[1]);
                                    this.int_18 = (int) Convert.ToInt16(Form1.form1_0.textBox_83.Text);
                                    *(sbyte*) ((IntPtr) voidPtr + 48) = (sbyte) (this.int_16 >= this.int_18);
                                    if (*(sbyte*) ((IntPtr) voidPtr + 48) != (sbyte) 0)
                                    {
                                      *(sbyte*) ((IntPtr) voidPtr + 49) = (sbyte) (this.int_17 == 0);
                                      if (*(sbyte*) ((IntPtr) voidPtr + 49) != (sbyte) 0)
                                      {
                                        try
                                        {
                                          new SqlCommand("Exec My_EventBot..__Hayatta_Kal '" + this.string_2 + "', 'TABEKLE'", Class65.sqlConnection_0).ExecuteReader();
                                        }
                                        catch
                                        {
                                          Form1.smethod_0("[Hayatta Kal] etkinliğinde [" + this.string_2 + "] isimli karakter _HayattaKal_List tablosuna eklenirken hata oluştu.");
                                        }
                                        Form1.list_0.Add(this.string_2);
                                        Form1.form1_0.listBox_14.Items.Add((object) this.string_2);
                                        Class73.smethod_123(this.class19_0, this.string_2, "Kaydınız başarıyla tamamlanmıştır.Kaydı iptal etmek isterseniz IPTAL yazınız.Bol şanslar.");
                                      }
                                      else
                                      {
                                        *(sbyte*) ((IntPtr) voidPtr + 50) = (sbyte) (this.int_17 > 0);
                                        if (*(sbyte*) ((IntPtr) voidPtr + 50) != (sbyte) 0)
                                          Class73.smethod_123(this.class19_0, this.string_2, "Job modundayken bu etkinliğe katılamazsın !!");
                                      }
                                    }
                                    else
                                    {
                                      *(sbyte*) ((IntPtr) voidPtr + 51) = (sbyte) (this.int_16 < this.int_18);
                                      if (*(sbyte*) ((IntPtr) voidPtr + 51) != (sbyte) 0)
                                        Class73.smethod_123(this.class19_0, this.string_2, "Şuanki etkinlik için level sınırlaması mevcut.Gereken Lvl =  " + (object) this.int_18 + "+");
                                    }
                                  }
                                  finally
                                  {
                                    if (num1 < 0 && this.sqlDataReader_0 != null)
                                      this.sqlDataReader_0.Dispose();
                                  }
                                  this.sqlDataReader_0 = (SqlDataReader) null;
                                }
                                catch (Exception ex)
                                {
                                  this.exception_2 = ex;
                                  Form1.smethod_0("[Hayatta Kal] etkinliği katılımcı listeye eklenemedi.CharName => " + this.string_2 + " --- HATA => " + this.exception_2.Message);
                                  Class73.smethod_123(this.class19_0, this.string_2, "Kayıt işlemi başarısız.Birkaç saniye sonra tekrar dene.");
                                }
                              }
                              else if ((!(this.string_3 == "KAYIT") || Form1.list_0.Count < this.int_9 ? 0 : (!Form1.list_0.Contains(this.string_2) ? 1 : 0)) != 0)
                                Class73.smethod_123(this.class19_0, this.string_2, "Maximum kayıt sayısına ulaşıldığından kayıtlar kapandı.");
                              else if ((!(this.string_3 == "KAYIT") || Form1.list_0.Count >= this.int_9 ? 0 : (Form1.list_0.Contains(this.string_2) ? 1 : 0)) != 0)
                                Class73.smethod_123(this.class19_0, this.string_2, "Zaten kayıtlısın..");
                              else if ((!(this.string_3 == "KAYIT") || Form1.list_0.Count < this.int_9 ? 0 : (Form1.list_0.Contains(this.string_2) ? 1 : 0)) != 0)
                                Class73.smethod_123(this.class19_0, this.string_2, "Maximum kayıt sayısına ulaşıldığından kayıtlar kapandı. NOT ==> Zaten Kayıtlısın...");
                            }
                            if ((!Form1.form1_0.checkBox_27.Checked ? 0 : (!Form1.form1_0.checkBox_28.Checked ? 1 : 0)) != 0)
                              Class73.smethod_123(this.class19_0, this.string_2, "Çekilişe katılım henüz başlamadı.Lütfen notice ile bildirildiğinde katılmayı dene !!");
                            if ((!Form1.form1_0.checkBox_27.Checked ? 0 : (Form1.form1_0.checkBox_28.Checked ? 1 : 0)) != 0)
                            {
                              *(sbyte*) ((IntPtr) voidPtr + 52) = (sbyte) (this.string_3 != "MP");
                              if (*(sbyte*) ((IntPtr) voidPtr + 52) != (sbyte) 0)
                                Class73.smethod_123(this.class19_0, this.string_2, "Yazım hatası ! çekilişe katılmak için MP yazınız.");
                              if ((!(this.string_3 == "MP") ? 0 : (!Form1.list_1.Contains(this.string_2) ? 1 : 0)) != 0)
                              {
                                try
                                {
                                  this.sqlDataReader_1 = new SqlCommand("exec My_EventBot..__Pıyango 'Kontrol','" + this.string_2 + "','" + Form1.form1_0.string_21 + "'," + (object) Convert.ToInt32(Form1.form1_0.textBox_103.Text), Class65.sqlConnection_0).ExecuteReader();
                                  this.sqlDataReader_1.Read();
                                  *(sbyte*) ((IntPtr) voidPtr + 53) = (sbyte) (this.sqlDataReader_1[0].ToString() == "1");
                                  if (*(sbyte*) ((IntPtr) voidPtr + 53) != (sbyte) 0)
                                  {
                                    Class73.smethod_123(this.class19_0, this.string_2, "[PIYANGO] etkinliğine katılımınız başarılı.Hesabınızdan [ " + Form1.form1_0.textBox_103.Text + " " + Form1.form1_0.string_21 + " ] alındı.");
                                    Class73.smethod_26(this.class19_0, this.string_2);
                                    Form1.list_1.Add(this.string_2);
                                    Form1.form1_0.listBox_23.Items.Add((object) this.string_2);
                                  }
                                  else
                                  {
                                    *(sbyte*) ((IntPtr) voidPtr + 54) = (sbyte) (this.sqlDataReader_1[0].ToString() == "0");
                                    if (*(sbyte*) ((IntPtr) voidPtr + 54) != (sbyte) 0)
                                      Class73.smethod_123(this.class19_0, this.string_2, Form1.form1_0.string_21 + " miktarınız yetersiz olduğu için katılımınız başırısız.");
                                  }
                                  this.sqlDataReader_1 = (SqlDataReader) null;
                                }
                                catch (Exception ex)
                                {
                                  this.exception_3 = ex;
                                  Class73.smethod_123(this.class19_0, this.string_2, "[PIYANGO] etkinliğine katılımınız başarısız !! Lütfen birkaç saniye sonra tekrar deneyin.");
                                  Form1.smethod_0(this.string_2 + " isimli karakter [PIYANGO] eventine katılmaya çalışırken hata oluştu.. HATA => " + this.exception_3.Message);
                                }
                              }
                              if ((!(this.string_3 == "MP") ? 0 : (Form1.list_1.Contains(this.string_2) ? 1 : 0)) != 0)
                              {
                                Class73.smethod_123(this.class19_0, this.string_2, "[PIYANGO] etkinliğine her karakter 1 defa katılabilir.Siz zaten katıldınız.");
                                goto label_262;
                              }
                              else
                                goto label_262;
                            }
                            else
                              goto label_262;
                          }
                          catch (Exception ex)
                          {
                            this.exception_4 = ex;
                            Form1.smethod_0("Pm tabloya yazdırılırken bir hata olustu. Acıklama => " + this.exception_4.Message);
                            goto label_262;
                          }
                        case 2:
                          awaiter1 = this.taskAwaiter_1;
                          this.taskAwaiter_1 = new TaskAwaiter();
                          num1 = -1;
                          this.int_0 = -1;
                          goto label_66;
                        case 3:
                          awaiter2 = this.taskAwaiter_1;
                          this.taskAwaiter_1 = new TaskAwaiter();
                          num1 = -1;
                          this.int_0 = -1;
                          goto label_67;
                        case 4:
                          awaiter3 = this.taskAwaiter_1;
                          this.taskAwaiter_1 = new TaskAwaiter();
                          num1 = -1;
                          this.int_0 = -1;
                          goto label_74;
                        case 5:
                          awaiter4 = this.taskAwaiter_1;
                          this.taskAwaiter_1 = new TaskAwaiter();
                          num1 = -1;
                          this.int_0 = -1;
                          goto label_78;
                        case 6:
                          awaiter5 = this.taskAwaiter_1;
                          this.taskAwaiter_1 = new TaskAwaiter();
                          num1 = -1;
                          this.int_0 = -1;
                          goto label_84;
                        case 7:
label_228:
                          try
                          {
                            TaskAwaiter<int> awaiter9;
                            if (num1 != 7)
                            {
                              awaiter9 = new SqlCommand("EXEC My_EventBot..__PartyListesi " + (object) this.int_19 + ",'" + this.string_10 + "'", Class65.sqlConnection_0).ExecuteNonQueryAsync().GetAwaiter();
                              if (!awaiter9.IsCompleted)
                              {
                                num1 = 7;
                                this.int_0 = 7;
                                this.taskAwaiter_2 = awaiter9;
                                Class19.Class20 stateMachine = this;
                                this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<int>, Class19.Class20>(ref awaiter9, ref stateMachine);
                                return;
                              }
                            }
                            else
                            {
                              awaiter9 = this.taskAwaiter_2;
                              this.taskAwaiter_2 = new TaskAwaiter<int>();
                              num1 = -1;
                              this.int_0 = -1;
                            }
                            awaiter9.GetResult();
                            awaiter9 = new TaskAwaiter<int>();
                            Class32.list_0.Add(this.int_19);
                          }
                          catch (Exception ex)
                          {
                            this.exception_8 = ex;
                            Class73.smethod_18("Party listesi tabloya yazılırken hata oluştu ! SQL baglantısı kapalı olabilir. \n Hata Açıklaması => " + this.exception_8.ToString());
                          }
                          this.string_10 = (string) null;
                          this.string_11 = (string) null;
                          goto label_226;
                        case 8:
                          awaiter6 = this.taskAwaiter_1;
                          this.taskAwaiter_1 = new TaskAwaiter();
                          num1 = -1;
                          this.int_0 = -1;
                          goto label_250;
                        case 9:
                          awaiter7 = this.taskAwaiter_1;
                          this.taskAwaiter_1 = new TaskAwaiter();
                          num1 = -1;
                          this.int_0 = -1;
                          goto label_258;
                        case 10:
                          awaiter8 = this.taskAwaiter_1;
                          this.taskAwaiter_1 = new TaskAwaiter();
                          num1 = -1;
                          this.int_0 = -1;
                          break;
                        default:
label_25:
                          if (this.enumerator_0.MoveNext())
                          {
                            this.class1_0 = this.enumerator_0.Current;
                            Class73.smethod_128(false, this.class1_0, this.class19_0);
                            *(short*) ((IntPtr) voidPtr + 16) = (short) Class73.smethod_89(this.class1_0);
                            if (*(ushort*) ((IntPtr) voidPtr + 16) <= (ushort) 12498)
                            {
                              if (*(ushort*) ((IntPtr) voidPtr + 16) <= (ushort) 12309)
                              {
                                if (*(ushort*) ((IntPtr) voidPtr + 16) <= (ushort) 12300)
                                {
                                  if (*(ushort*) ((IntPtr) voidPtr + 16) != (ushort) 8193)
                                  {
                                    if (*(ushort*) ((IntPtr) voidPtr + 16) == (ushort) 12300)
                                    {
                                      this.ushort_0 = Class73.smethod_11(this.class1_0);
                                      *(sbyte*) ((IntPtr) voidPtr + 61) = (sbyte) (this.ushort_0 == (ushort) 3077);
                                      if (*(sbyte*) ((IntPtr) voidPtr + 61) != (sbyte) 0)
                                      {
                                        this.uint_2 = Class73.smethod_165(this.class1_0);
                                        *(sbyte*) ((IntPtr) voidPtr + 62) = (sbyte) Form1.form1_0.checkEdit_9.Checked;
                                        if (*(sbyte*) ((IntPtr) voidPtr + 62) != (sbyte) 0)
                                          Class73.smethod_243(this.uint_2.ToString() + " belirdi.", Color.DeepSkyBlue);
                                        *(sbyte*) ((IntPtr) voidPtr + 63) = (sbyte) Form1.form1_0.checkEdit_9.Checked;
                                        if (*(sbyte*) ((IntPtr) voidPtr + 63) != (sbyte) 0)
                                        {
                                          try
                                          {
                                            new SqlCommand("Exec My_EventBot.._Anlık_UniqueLog 1," + (object) this.uint_2 + ",NULL", Class65.sqlConnection_0).ExecuteNonQuery();
                                            goto label_24;
                                          }
                                          catch (Exception ex)
                                          {
                                            this.exception_9 = ex;
                                            Form1.smethod_1("HATA ! Uniq Spawn Logu yazılamadı !!!." + this.exception_9.Message, Color.Salmon);
                                            goto label_24;
                                          }
                                        }
                                        else
                                          goto label_24;
                                      }
                                      else
                                      {
                                        *(sbyte*) ((IntPtr) voidPtr + 64) = (sbyte) (this.ushort_0 == (ushort) 3078);
                                        if (*(sbyte*) ((IntPtr) voidPtr + 64) != (sbyte) 0)
                                        {
                                          this.uint_3 = Class73.smethod_165(this.class1_0);
                                          this.string_12 = Class73.smethod_87(this.class1_0);
                                          *(sbyte*) ((IntPtr) voidPtr + 65) = (sbyte) Form1.form1_0.checkEdit_9.Checked;
                                          if (*(sbyte*) ((IntPtr) voidPtr + 65) != (sbyte) 0)
                                            Class73.smethod_243(this.uint_3.ToString() + ", " + this.string_12 + " tarafından kesildi.", Color.DeepSkyBlue);
                                          *(sbyte*) ((IntPtr) voidPtr + 66) = (sbyte) Form1.form1_0.checkEdit_9.Checked;
                                          if (*(sbyte*) ((IntPtr) voidPtr + 66) != (sbyte) 0)
                                          {
                                            try
                                            {
                                              new SqlCommand("Exec My_EventBot.._Anlık_UniqueLog 2," + (object) this.uint_3 + "," + this.string_12 ?? "", Class65.sqlConnection_0).ExecuteNonQuery();
                                            }
                                            catch (Exception ex)
                                            {
                                              this.exception_10 = ex;
                                              Form1.smethod_1("HATA ! Uniq Kill Logu yazılamadı !!!." + this.exception_10.Message, Color.Salmon);
                                            }
                                          }
                                          if ((!Form1.form1_0.checkBox_2.Checked ? 0 : ((long) this.uint_3 == (long) Form1.int_10 ? 1 : 0)) != 0)
                                          {
                                            Class19.bool_2 = false;
                                            Class19.string_5 = this.string_12;
                                            Class73.smethod_181(Form1.form1_0.comboBoxEdit_2.Text);
                                          }
                                          *(sbyte*) ((IntPtr) voidPtr + 67) = (sbyte) (Form1.form1_0.checkBox_5.Checked & this.uint_3 == 22519U);
                                          if (*(sbyte*) ((IntPtr) voidPtr + 67) != (sbyte) 0)
                                          {
                                            --Form1.int_1;
                                            *(sbyte*) ((IntPtr) voidPtr + 68) = (sbyte) (Form1.int_1 > 0);
                                            if (*(sbyte*) ((IntPtr) voidPtr + 68) != (sbyte) 0)
                                              Class73.smethod_161(this.class19_0, "Tebrikler [" + this.string_12 + "] . Kalan unique sayısı = " + (object) Form1.int_1);
                                            *(sbyte*) ((IntPtr) voidPtr + 69) = (sbyte) (Form1.int_1 == 0);
                                            if (*(sbyte*) ((IntPtr) voidPtr + 69) != (sbyte) 0)
                                            {
                                              Class73.smethod_161(this.class19_0, "Tebrikler [" + this.string_12 + "]. Uniqler bitmiştir.");
                                              awaiter6 = Task.Delay(5000).GetAwaiter();
                                              if (!awaiter6.IsCompleted)
                                              {
                                                num1 = 8;
                                                this.int_0 = 8;
                                                this.taskAwaiter_1 = awaiter6;
                                                Class19.Class20 stateMachine = this;
                                                this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class19.Class20>(ref awaiter6, ref stateMachine);
                                                return;
                                              }
                                              goto label_250;
                                            }
                                            else
                                              goto label_251;
                                          }
                                          else
                                            goto label_23;
                                        }
                                        else
                                          goto label_24;
                                      }
                                    }
                                    else
                                      goto label_24;
                                  }
                                  else
                                  {
                                    *(sbyte*) ((IntPtr) voidPtr + 73) = (sbyte) (Class73.smethod_87(this.class1_0) == "AgentServer");
                                    if (*(sbyte*) ((IntPtr) voidPtr + 73) != (sbyte) 0)
                                    {
                                      this.class1_5 = new Class1((ushort) 24835);
                                      Class73.smethod_9(this.class1_5, this.class19_0.uint_0);
                                      Class73.smethod_120(this.class1_5, this.class19_0.string_1);
                                      Class73.smethod_120(this.class1_5, this.class19_0.string_2);
                                      Class73.smethod_162((byte) 22, this.class1_5);
                                      Class73.smethod_9(this.class1_5, 0U);
                                      Class73.smethod_65((ushort) 0, this.class1_5);
                                      this.class19_0.method_1(this.class1_5);
                                      this.class1_5 = (Class1) null;
                                      goto label_24;
                                    }
                                    else
                                      goto label_24;
                                  }
                                }
                                else if (*(ushort*) ((IntPtr) voidPtr + 16) != (ushort) 12307)
                                {
                                  if (*(ushort*) ((IntPtr) voidPtr + 16) == (ushort) 12309)
                                  {
                                    this.byte_4 = Class73.smethod_223(this.class1_0);
                                    this.string_13 = Encoding.Default.GetString(this.byte_4);
                                    this.bool_0 = this.string_13.Contains(Class19.string_5 ?? "");
                                    *(sbyte*) ((IntPtr) voidPtr + 74) = (sbyte) this.bool_0;
                                    if (*(sbyte*) ((IntPtr) voidPtr + 74) != (sbyte) 0)
                                      ;
                                    this.byte_4 = (byte[]) null;
                                    this.string_13 = (string) null;
                                    goto label_24;
                                  }
                                  else
                                    goto label_24;
                                }
                                else
                                {
                                  Class73.smethod_243("Karakter Spawn Başarılı.", Color.LightSeaGreen);
                                  Class19.bool_1 = true;
                                  Class73.smethod_229(this.class19_0);
                                  goto label_24;
                                }
                              }
                              else if (*(ushort*) ((IntPtr) voidPtr + 16) <= (ushort) 12320)
                              {
                                if (*(ushort*) ((IntPtr) voidPtr + 16) != (ushort) 12313)
                                {
                                  if (*(ushort*) ((IntPtr) voidPtr + 16) == (ushort) 12320)
                                  {
                                    this.class1_1 = new Class1((ushort) 12306);
                                    this.class19_0.method_1(this.class1_1);
                                    goto label_24;
                                  }
                                  else
                                    goto label_24;
                                }
                                else
                                {
                                  Class19.bool_1 = true;
                                  this.byte_5 = Class73.smethod_223(this.class1_0);
                                  this.string_14 = Encoding.Default.GetString(this.byte_5);
                                  this.bool_1 = this.string_14.Contains(Class19.string_5 ?? "");
                                  *(sbyte*) ((IntPtr) voidPtr + 75) = (sbyte) this.bool_1;
                                  if (*(sbyte*) ((IntPtr) voidPtr + 75) != (sbyte) 0)
                                  {
                                    *(sbyte*) ((IntPtr) voidPtr + 76) = (sbyte) Form1.form1_0.checkBox_2.Checked;
                                    if (*(sbyte*) ((IntPtr) voidPtr + 76) != (sbyte) 0)
                                    {
                                      *(sbyte*) ((IntPtr) voidPtr + 77) = (sbyte) !Class19.bool_2;
                                      if (*(sbyte*) ((IntPtr) voidPtr + 77) != (sbyte) 0)
                                        Class19.smethod_0(Class19.string_5);
                                    }
                                  }
                                  else
                                  {
                                    *(sbyte*) ((IntPtr) voidPtr + 78) = (sbyte) Form1.form1_0.checkBox_2.Checked;
                                    if (*(sbyte*) ((IntPtr) voidPtr + 78) != (sbyte) 0)
                                      ;
                                  }
                                  this.byte_5 = (byte[]) null;
                                  this.string_14 = (string) null;
                                  goto label_24;
                                }
                              }
                              else if (*(ushort*) ((IntPtr) voidPtr + 16) != (ushort) 12326)
                              {
                                if (*(ushort*) ((IntPtr) voidPtr + 16) == (ushort) 12498)
                                  goto label_24;
                                else
                                  goto label_24;
                              }
                              else
                              {
                                this.uint_0 = (uint) Class73.smethod_16(this.class1_0);
                                *(int*) ((IntPtr) voidPtr + 4) = (int) this.uint_0;
                                if (*(uint*) ((IntPtr) voidPtr + 4) != 2U)
                                {
                                  switch (*(uint*) ((IntPtr) voidPtr + 4))
                                  {
                                    case 6:
                                      this.string_4 = Class73.smethod_87(this.class1_0);
                                      this.string_5 = Class73.smethod_87(this.class1_0);
                                      Class73.smethod_243("[GLOBAL] " + this.string_4 + ":" + this.string_5, Color.Gold);
                                      *(sbyte*) ((IntPtr) voidPtr + 55) = (sbyte) Form1.form1_0.checkEdit_10.Checked;
                                      if (*(sbyte*) ((IntPtr) voidPtr + 55) != (sbyte) 0)
                                      {
                                        this.string_5 = this.string_5.Replace("'", "''");
                                        try
                                        {
                                          new SqlCommand("Exec My_EventBot.._AnlıkChat_Log 2,'" + this.string_4 + "','" + this.string_5 + "'", Class65.sqlConnection_0).ExecuteNonQuery();
                                          goto label_262;
                                        }
                                        catch
                                        {
                                          Form1.smethod_1("Bir hata oluştu.Lütfen geliştiriciye bildirin. Hata kodu = #02.", Color.Salmon);
                                          goto label_262;
                                        }
                                      }
                                      else
                                        goto label_262;
                                    case 7:
                                      this.string_6 = Class73.smethod_87(this.class1_0);
                                      Class73.smethod_243("[NOTICE] " + this.string_6, Color.Salmon);
                                      goto label_262;
                                    case 9:
                                      this.string_7 = Class73.smethod_87(this.class1_0);
                                      this.string_8 = Class73.smethod_87(this.class1_0);
                                      *(sbyte*) ((IntPtr) voidPtr + 56) = (sbyte) Form1.form1_0.checkBox_8.Checked;
                                      if (*(sbyte*) ((IntPtr) voidPtr + 56) != (sbyte) 0)
                                      {
                                        Class73.smethod_161(this.class19_0, "Tebrikler [" + this.string_7 + "] .Beni buldun. ");
                                        awaiter1 = Task.Delay(1000).GetAwaiter();
                                        if (!awaiter1.IsCompleted)
                                        {
                                          num1 = 2;
                                          this.int_0 = 2;
                                          this.taskAwaiter_1 = awaiter1;
                                          Class19.Class20 stateMachine = this;
                                          this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class19.Class20>(ref awaiter1, ref stateMachine);
                                          return;
                                        }
                                        goto label_66;
                                      }
                                      else
                                        goto label_262;
                                    default:
                                      goto label_262;
                                  }
                                }
                                else
                                {
                                  this.string_2 = Class73.smethod_87(this.class1_0);
                                  this.string_3 = Class73.smethod_87(this.class1_0);
                                  *(sbyte*) ((IntPtr) voidPtr + 32) = (sbyte) Form1.form1_0.listBox_17.Items.Contains((object) this.string_2);
                                  if (*(sbyte*) ((IntPtr) voidPtr + 32) != (sbyte) 0)
                                  {
                                    this.string_3 = this.string_3.Replace("'", "''");
                                    this.int_8 = Form1.int_0;
                                    *(sbyte*) ((IntPtr) voidPtr + 33) = (sbyte) (this.string_3 == string.Concat((object) this.int_8));
                                    if (*(sbyte*) ((IntPtr) voidPtr + 33) != (sbyte) 0)
                                    {
                                      new SqlCommand("delete top (1) My_EventBot.._AntiPhBot where CharName='" + this.string_2 + "' and CevapDurumu ='bekleniyor'", Class65.sqlConnection_0).ExecuteNonQuery();
                                      Class73.smethod_123(this.class19_0, this.string_2, "Cevap doğru. İşlemine devam edebilirsin.");
                                    }
                                    *(sbyte*) ((IntPtr) voidPtr + 34) = (sbyte) (this.string_3 != string.Concat((object) this.int_8));
                                    if (*(sbyte*) ((IntPtr) voidPtr + 34) != (sbyte) 0)
                                    {
                                      new SqlCommand("update top(1) My_EventBot.._AntiPhBot set CevapDurumu = 'yanliscevap' where CharName = '" + this.string_2 + "' and CevapDurumu ='bekleniyor'", Class65.sqlConnection_0).ExecuteNonQuery();
                                      goto case 0;
                                    }
                                    else
                                      goto case 0;
                                  }
                                  else
                                    goto case 0;
                                }
                              }
                            }
                            else if (*(ushort*) ((IntPtr) voidPtr + 16) <= (ushort) 41219)
                            {
                              if (*(ushort*) ((IntPtr) voidPtr + 16) <= (ushort) 20480)
                              {
                                if (*(ushort*) ((IntPtr) voidPtr + 16) != (ushort) 13493)
                                {
                                  if (*(ushort*) ((IntPtr) voidPtr + 16) != (ushort) 20480)
                                    goto label_24;
                                }
                                else
                                {
                                  this.class1_2 = new Class1((ushort) 13494);
                                  this.class19_0.method_1(this.class1_2);
                                  goto label_24;
                                }
                              }
                              else if (*(ushort*) ((IntPtr) voidPtr + 16) != (ushort) 36864)
                              {
                                if (*(ushort*) ((IntPtr) voidPtr + 16) == (ushort) 41219)
                                {
                                  *(sbyte*) ((IntPtr) voidPtr + 72) = (sbyte) (Class73.smethod_16(this.class1_0) == (byte) 1);
                                  if (*(sbyte*) ((IntPtr) voidPtr + 72) != (sbyte) 0)
                                  {
                                    this.class1_4 = new Class1((ushort) 28679);
                                    Class73.smethod_162((byte) 2, this.class1_4);
                                    this.class19_0.method_1(this.class1_4);
                                    this.class1_4 = (Class1) null;
                                    goto label_24;
                                  }
                                  else
                                    goto label_24;
                                }
                                else
                                  goto label_24;
                              }
                              this.class19_0.method_1((Class1) null);
                              goto label_24;
                            }
                            else if (*(ushort*) ((IntPtr) voidPtr + 16) <= (ushort) 45063)
                            {
                              if (*(ushort*) ((IntPtr) voidPtr + 16) != (ushort) 45057)
                              {
                                if (*(ushort*) ((IntPtr) voidPtr + 16) == (ushort) 45063)
                                {
                                  *(sbyte*) ((IntPtr) voidPtr + 20) = (sbyte) (Class73.smethod_16(this.class1_0) == (byte) 2);
                                  if (*(sbyte*) ((IntPtr) voidPtr + 20) != (sbyte) 0)
                                  {
                                    *(sbyte*) ((IntPtr) voidPtr + 21) = (sbyte) (Class73.smethod_16(this.class1_0) == (byte) 1);
                                    if (*(sbyte*) ((IntPtr) voidPtr + 21) != (sbyte) 0)
                                    {
                                      try
                                      {
                                        this.uint_1 = (uint) Class73.smethod_16(this.class1_0);
                                        this.list_1 = new List<string>();
                                        this.int_3 = 0;
                                        while (true)
                                        {
                                          *(sbyte*) ((IntPtr) voidPtr + 29) = (sbyte) ((long) this.int_3 <= (long) (this.uint_1 - 1U));
                                          if (*(sbyte*) ((IntPtr) voidPtr + 29) != (sbyte) 0)
                                          {
                                            int num2 = (int) Class73.smethod_165(this.class1_0);
                                            this.list_1.Add(Class73.smethod_87(this.class1_0));
                                            int num3 = (int) Class73.smethod_16(this.class1_0);
                                            List<string> list1 = this.list_1;
                                            *(int*) voidPtr = this.int_3;
                                            List<string> stringList = list1;
                                            int index = *(int*) voidPtr;
                                            string str1 = list1[*(int*) voidPtr];
                                            *(sbyte*) ((IntPtr) voidPtr + 22) = (sbyte) Class73.smethod_16(this.class1_0);
                                            string str2 = ((byte*) ((IntPtr) voidPtr + 22))->ToString();
                                            string str3 = str1 + " " + str2 + " lvl";
                                            stringList[index] = str3;
                                            long num4 = (long) Class73.smethod_33(this.class1_0);
                                            int num5 = (int) Class73.smethod_11(this.class1_0);
                                            int num6 = (int) Class73.smethod_11(this.class1_0);
                                            int num7 = (int) Class73.smethod_11(this.class1_0);
                                            int num8 = (int) Class73.smethod_165(this.class1_0);
                                            int num9 = (int) Class73.smethod_165(this.class1_0);
                                            *(sbyte*) ((IntPtr) voidPtr + 23) = (sbyte) (Class73.smethod_16(this.class1_0) == (byte) 1);
                                            if (*(sbyte*) ((IntPtr) voidPtr + 23) != (sbyte) 0)
                                            {
                                              int num10 = (int) Class73.smethod_165(this.class1_0);
                                            }
                                            int num11 = (int) Class73.smethod_16(this.class1_0);
                                            *(sbyte*) ((IntPtr) voidPtr + 24) = (sbyte) (Class73.smethod_16(this.class1_0) == (byte) 1);
                                            if (*(sbyte*) ((IntPtr) voidPtr + 24) != (sbyte) 0)
                                              Class73.smethod_87(this.class1_0);
                                            int num12 = (int) Class73.smethod_16(this.class1_0);
                                            this.int_4 = (int) Class73.smethod_16(this.class1_0);
                                            *(sbyte*) ((IntPtr) voidPtr + 25) = (sbyte) (this.int_4 > 0);
                                            if (*(sbyte*) ((IntPtr) voidPtr + 25) != (sbyte) 0)
                                            {
                                              this.int_6 = 1;
                                              while (true)
                                              {
                                                *(sbyte*) ((IntPtr) voidPtr + 26) = (sbyte) (this.int_6 <= this.int_4);
                                                if (*(sbyte*) ((IntPtr) voidPtr + 26) != (sbyte) 0)
                                                {
                                                  int num13 = (int) Class73.smethod_165(this.class1_0);
                                                  int num14 = (int) Class73.smethod_16(this.class1_0);
                                                  *(int*) voidPtr = this.int_6;
                                                  this.int_6 = *(int*) voidPtr + 1;
                                                }
                                                else
                                                  break;
                                              }
                                            }
                                            this.int_5 = (int) Class73.smethod_16(this.class1_0);
                                            *(sbyte*) ((IntPtr) voidPtr + 27) = (sbyte) (this.int_5 > 0);
                                            if (*(sbyte*) ((IntPtr) voidPtr + 27) != (sbyte) 0)
                                            {
                                              this.int_7 = 1;
                                              while (true)
                                              {
                                                *(sbyte*) ((IntPtr) voidPtr + 28) = (sbyte) (this.int_7 <= this.int_5);
                                                if (*(sbyte*) ((IntPtr) voidPtr + 28) != (sbyte) 0)
                                                {
                                                  int num13 = (int) Class73.smethod_165(this.class1_0);
                                                  int num14 = (int) Class73.smethod_16(this.class1_0);
                                                  *(int*) voidPtr = this.int_7;
                                                  this.int_7 = *(int*) voidPtr + 1;
                                                }
                                                else
                                                  break;
                                              }
                                            }
                                            *(int*) voidPtr = this.int_3;
                                            this.int_3 = *(int*) voidPtr + 1;
                                          }
                                          else
                                            break;
                                        }
                                        this.string_0 = "Bu üyelikte " + this.uint_1.ToString() + " adet karakter bulundu.";
                                        *(sbyte*) ((IntPtr) voidPtr + 30) = (sbyte) (this.uint_1 > 0U);
                                        if (*(sbyte*) ((IntPtr) voidPtr + 30) != (sbyte) 0)
                                        {
                                          this.enumerator_1 = this.list_1.GetEnumerator();
                                          try
                                          {
                                            while (this.enumerator_1.MoveNext())
                                            {
                                              this.string_1 = this.enumerator_1.Current;
                                              this.string_0 = this.string_0 + "\n  " + this.string_1;
                                              this.string_1 = (string) null;
                                            }
                                          }
                                          finally
                                          {
                                            if (num1 < 0)
                                              this.enumerator_1.Dispose();
                                          }
                                          this.enumerator_1 = new List<string>.Enumerator();
                                        }
                                        Class73.smethod_243(this.string_0, Color.LightBlue);
                                        this.list_1 = (List<string>) null;
                                        this.string_0 = (string) null;
                                      }
                                      catch
                                      {
                                        Class73.smethod_243("Karakter listesi oluşturulamadı.", Color.Red);
                                      }
                                      this.class1_3 = new Class1((ushort) 28673);
                                      Class73.smethod_120(this.class1_3, this.class19_0.string_3);
                                      this.class19_0.method_1(this.class1_3);
                                      this.class1_3 = (Class1) null;
                                      goto label_24;
                                    }
                                    else
                                    {
                                      Class73.smethod_217(this.class19_0, "Farklı bir üyelik ile deneyin.Sorun devam ederse bize bildirin ==> https://www.vsro.org/members/efsanesro.3096/");
                                      goto label_24;
                                    }
                                  }
                                  else
                                  {
                                    Class73.smethod_217(this.class19_0, "Farklı bir üyelik ile deneyin.Sorun devam ederse bize bildirin ==> https://www.vsro.org/members/efsanesro.3096/");
                                    goto label_24;
                                  }
                                }
                                else
                                  goto label_24;
                              }
                              else
                              {
                                *(sbyte*) ((IntPtr) voidPtr + 31) = (sbyte) (Class73.smethod_16(this.class1_0) != (byte) 1);
                                if (*(sbyte*) ((IntPtr) voidPtr + 31) != (sbyte) 0)
                                {
                                  ++Class25.int_0;
                                  Class73.smethod_217(this.class19_0, "Karakter adını kontrol edin.");
                                  goto label_24;
                                }
                                else
                                  goto label_24;
                              }
                            }
                            else if (*(ushort*) ((IntPtr) voidPtr + 16) != (ushort) 45125 && *(ushort*) ((IntPtr) voidPtr + 16) != (ushort) 45161 && *(ushort*) ((IntPtr) voidPtr + 16) == (ushort) 45164)
                            {
                              this.byte_0 = Class73.smethod_16(this.class1_0);
                              this.byte_1 = Class73.smethod_16(this.class1_0);
                              this.byte_2 = Class73.smethod_16(this.class1_0);
                              this.byte_3 = Class73.smethod_16(this.class1_0);
                              this.int_2 = (int) this.byte_1 - 1;
                              goto label_226;
                            }
                            else
                              goto label_24;
                          }
                          else
                            goto label_274;
                      }
label_18:
                      awaiter8.GetResult();
                      awaiter8 = new TaskAwaiter();
                      try
                      {
                        new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_12 + "',4,böylekalsin," + Form1.form1_0.textBox_15.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
                        Form1.smethod_1("SP ödülü teslim Edildi .", Color.DarkGreen);
                      }
                      catch (Exception ex)
                      {
                        this.exception_13 = ex;
                        Form1.smethod_1("HATA !Sp ödülü teslim edilemedi !! ==> " + this.exception_13.Message, Color.OrangeRed);
                      }
                      Class73.smethod_193(this.class19_0, this.string_12);
label_22:
                      Class73.smethod_193(this.class19_0, this.string_12);
label_23:
                      this.string_12 = (string) null;
label_24:
                      this.class1_1 = (Class1) null;
                      this.class1_2 = (Class1) null;
                      this.class1_0 = (Class1) null;
                      goto label_25;
label_66:
                      awaiter1.GetResult();
                      awaiter1 = new TaskAwaiter();
                      Class73.smethod_66(this.class19_0);
                      awaiter2 = Task.Delay(2000).GetAwaiter();
                      if (!awaiter2.IsCompleted)
                      {
                        num1 = 3;
                        this.int_0 = 3;
                        this.taskAwaiter_1 = awaiter2;
                        Class19.Class20 stateMachine = this;
                        this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class19.Class20>(ref awaiter2, ref stateMachine);
                        return;
                      }
label_67:
                      awaiter2.GetResult();
                      awaiter2 = new TaskAwaiter();
                      *(sbyte*) ((IntPtr) voidPtr + 57) = (sbyte) Form1.form1_0.checkBox_16.Checked;
                      if (*(sbyte*) ((IntPtr) voidPtr + 57) != (sbyte) 0)
                      {
                        try
                        {
                          new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_7 + "',1," + Form1.form1_0.textBox_55.Text + "," + Form1.form1_0.textBox_54.Text + "," + Form1.form1_0.textBox_53.Text ?? "", Class65.sqlConnection_0).ExecuteNonQuery();
                          Form1.smethod_1("ITEM ödülü teslim Edildi .", Color.DarkGreen);
                        }
                        catch (Exception ex)
                        {
                          this.exception_5 = ex;
                          Form1.smethod_1("HATA ! İtem Ödülü teslim edilemedi!!" + this.exception_5.Message, Color.OrangeRed);
                        }
                      }
                      *(sbyte*) ((IntPtr) voidPtr + 58) = (sbyte) Form1.form1_0.checkBox_15.Checked;
                      if (*(sbyte*) ((IntPtr) voidPtr + 58) != (sbyte) 0)
                      {
                        try
                        {
                          new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_7 + "',2,böylekalsin," + Form1.form1_0.textBox_58.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
                          Form1.smethod_1("Silk ödülü teslim Edildi .", Color.DarkGreen);
                        }
                        catch (Exception ex)
                        {
                        }
                        awaiter3 = Task.Delay(500).GetAwaiter();
                        if (!awaiter3.IsCompleted)
                        {
                          num1 = 4;
                          this.int_0 = 4;
                          this.taskAwaiter_1 = awaiter3;
                          Class19.Class20 stateMachine = this;
                          this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class19.Class20>(ref awaiter3, ref stateMachine);
                          return;
                        }
                      }
                      else
                        goto label_81;
label_74:
                      awaiter3.GetResult();
                      awaiter3 = new TaskAwaiter();
                      try
                      {
                        new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_7 + "',3,böylekalsin," + Form1.form1_0.textBox_56.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
                        Form1.smethod_1("GOLD ödülü teslim Edildi. ", Color.DarkGreen);
                      }
                      catch (Exception ex)
                      {
                        this.exception_6 = ex;
                        Form1.smethod_1("HATA ! Gold ödülü teslim edilemedi !! ==> " + this.exception_6.Message, Color.OrangeRed);
                      }
                      awaiter4 = Task.Delay(500).GetAwaiter();
                      if (!awaiter4.IsCompleted)
                      {
                        num1 = 5;
                        this.int_0 = 5;
                        this.taskAwaiter_1 = awaiter4;
                        Class19.Class20 stateMachine = this;
                        this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class19.Class20>(ref awaiter4, ref stateMachine);
                        return;
                      }
label_78:
                      awaiter4.GetResult();
                      awaiter4 = new TaskAwaiter();
                      try
                      {
                        new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_7 + "',4,böylekalsin," + Form1.form1_0.textBox_57.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
                        Form1.smethod_1("SP ödülü teslim Edildi .", Color.DarkGreen);
                      }
                      catch (Exception ex)
                      {
                        this.exception_7 = ex;
                        Form1.smethod_1("HATA !Sp ödülü teslim edilemedi !! ==> " + this.exception_7.Message, Color.OrangeRed);
                      }
label_81:
                      if ((Form1.form1_0.checkBox_16.Checked ? 1 : (Form1.form1_0.checkBox_15.Checked ? 1 : 0)) != 0)
                        Class73.smethod_193(this.class19_0, this.string_7);
                      awaiter5 = Task.Delay(3000).GetAwaiter();
                      if (!awaiter5.IsCompleted)
                      {
                        num1 = 6;
                        this.int_0 = 6;
                        this.taskAwaiter_1 = awaiter5;
                        Class19.Class20 stateMachine = this;
                        this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class19.Class20>(ref awaiter5, ref stateMachine);
                        return;
                      }
label_84:
                      awaiter5.GetResult();
                      awaiter5 = new TaskAwaiter();
                      string text = Form1.form1_0.textBox_52.Text;
                      if (!(text == "1"))
                      {
                        if (!(text == "2"))
                        {
                          if (text == "3")
                          {
                            Form1.form1_0.textBox_52.Text = "0";
                            Form1.form1_0.method_19();
                          }
                        }
                        else
                        {
                          Form1.form1_0.textBox_52.Text = "3";
                          Form1.form1_0.method_18();
                        }
                      }
                      else
                      {
                        Form1.form1_0.textBox_52.Text = "2";
                        Form1.form1_0.method_17();
                      }
                      Form1.form1_0.int_6 = 0;
                      Form1.form1_0.label_139.Text = "0";
                      goto label_262;
label_226:
                      *(sbyte*) ((IntPtr) voidPtr + 59) = (sbyte) (Class73.smethod_179(this.class1_0) >= 1);
                      if (*(sbyte*) ((IntPtr) voidPtr + 59) != (sbyte) 0)
                      {
                        this.int_19 = (int) Class73.smethod_165(this.class1_0);
                        this.int_20 = (int) Class73.smethod_165(this.class1_0);
                        this.string_10 = Class73.smethod_87(this.class1_0);
                        this.int_21 = (int) Class73.smethod_165(this.class1_0);
                        this.int_22 = (int) Class73.smethod_11(this.class1_0);
                        this.string_11 = Class73.smethod_87(this.class1_0);
                        goto label_228;
                      }
                      else
                      {
                        *(sbyte*) ((IntPtr) voidPtr + 60) = (sbyte) ((int) this.byte_2 != (int) this.byte_1 - 1);
                        if (*(sbyte*) ((IntPtr) voidPtr + 60) != (sbyte) 0)
                        {
                          Class19 class190 = this.class19_0;
                          *(int*) ((IntPtr) voidPtr + 8) = (int) this.byte_2 + 1;
                          Class73.smethod_244(*(int*) ((IntPtr) voidPtr + 8), class190);
                          goto label_24;
                        }
                        else
                          goto label_24;
                      }
label_250:
                      awaiter6.GetResult();
                      awaiter6 = new TaskAwaiter();
                      Class73.smethod_161(this.class19_0, "[Kayıp Unique] etkinliği sona ermiştir. Katılan herkese teşekkürler.Başka etkinliklerde görüşmek üzere.");
                      Form1.form1_0.checkBox_5.Checked = false;
                      Class73.smethod_206(this.class19_0);
label_251:
                      *(sbyte*) ((IntPtr) voidPtr + 70) = (sbyte) Form1.form1_0.checkBox_4.Checked;
                      if (*(sbyte*) ((IntPtr) voidPtr + 70) != (sbyte) 0)
                      {
                        try
                        {
                          new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_12 + "',1," + Form1.form1_0.textBox_13.Text + "," + Form1.form1_0.textBox_12.Text + "," + Form1.form1_0.textBox_11.Text ?? "", Class65.sqlConnection_0).ExecuteNonQuery();
                          Form1.smethod_1("ITEM ödülü teslim Edildi .", Color.DarkGreen);
                        }
                        catch (Exception ex)
                        {
                          this.exception_11 = ex;
                          Form1.smethod_1("HATA ! İtem Ödülü teslim edilemedi!!" + this.exception_11.Message, Color.OrangeRed);
                        }
                      }
                      *(sbyte*) ((IntPtr) voidPtr + 71) = (sbyte) Form1.form1_0.checkBox_3.Checked;
                      if (*(sbyte*) ((IntPtr) voidPtr + 71) != (sbyte) 0)
                      {
                        try
                        {
                          new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_12 + "',2,böylekalsin," + Form1.form1_0.textBox_16.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
                          Form1.smethod_1("Silk ödülü teslim Edildi .", Color.DarkGreen);
                        }
                        catch
                        {
                          Form1.smethod_1("Silk ödülü teslim Edildi .", Color.DarkGreen);
                        }
                        awaiter7 = Task.Delay(500).GetAwaiter();
                        if (!awaiter7.IsCompleted)
                        {
                          num1 = 9;
                          this.int_0 = 9;
                          this.taskAwaiter_1 = awaiter7;
                          Class19.Class20 stateMachine = this;
                          this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class19.Class20>(ref awaiter7, ref stateMachine);
                          return;
                        }
                      }
                      else
                        goto label_22;
label_258:
                      awaiter7.GetResult();
                      awaiter7 = new TaskAwaiter();
                      try
                      {
                        new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_12 + "',3,böylekalsin," + Form1.form1_0.textBox_14.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
                        Form1.smethod_1("GOLD ödülü teslim Edildi. ", Color.DarkGreen);
                      }
                      catch (Exception ex)
                      {
                        this.exception_12 = ex;
                        Form1.smethod_1("HATA ! Gold ödülü teslim edilemedi !! ==> " + this.exception_12.Message, Color.OrangeRed);
                      }
                      awaiter8 = Task.Delay(500).GetAwaiter();
                      if (!awaiter8.IsCompleted)
                      {
                        num1 = 10;
                        this.int_0 = 10;
                        this.taskAwaiter_1 = awaiter8;
                        Class19.Class20 stateMachine = this;
                        this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class19.Class20>(ref awaiter8, ref stateMachine);
                        return;
                      }
                      goto label_18;
label_262:
                      this.string_2 = (string) null;
                      this.string_3 = (string) null;
                      this.string_4 = (string) null;
                      this.string_5 = (string) null;
                      this.string_6 = (string) null;
                      this.string_7 = (string) null;
                      this.string_8 = (string) null;
                      goto label_24;
                    }
                    finally
                    {
                      if (num1 < 0)
                        this.enumerator_0.Dispose();
                    }
label_274:
                    this.enumerator_0 = new List<Class1>.Enumerator();
                    break;
                  default:
                    this.int_1 = this.class19_0.socket_0.EndReceive(this.iasyncResult_0);
                    *(sbyte*) ((IntPtr) voidPtr + 18) = (sbyte) (this.int_1 > 0);
                    if (*(sbyte*) ((IntPtr) voidPtr + 18) != (sbyte) 0)
                    {
                      Class4 class40 = this.class19_0.class4_0;
                      byte[] byte0 = this.class19_0.byte_0;
                      *(int*) ((IntPtr) voidPtr + 12) = this.int_1;
                      Class73.smethod_70(0, class40, *(int*) ((IntPtr) voidPtr + 12), byte0);
                      this.list_0 = Class73.smethod_192(this.class19_0.class4_0);
                      *(sbyte*) ((IntPtr) voidPtr + 19) = (sbyte) (this.list_0 != null);
                      if (*(sbyte*) ((IntPtr) voidPtr + 19) != (sbyte) 0)
                      {
                        this.enumerator_0 = this.list_0.GetEnumerator();
                        goto case 0;
                      }
                      else
                        break;
                    }
                    else
                    {
                      Class73.smethod_217(this.class19_0, "nReceived < 1");
                      goto label_278;
                    }
                }
                Class73.smethod_24(this.class19_0);
                this.list_0 = (List<Class1>) null;
                break;
              }
              catch (Exception ex)
              {
                this.exception_14 = ex;
                Class73.smethod_217(this.class19_0, this.exception_14.ToString());
                break;
              }
          }
        }
        catch (Exception ex)
        {
          this.int_0 = -2;
          this.asyncVoidMethodBuilder_0.SetException(ex);
          return;
        }
label_278:
        this.int_0 = -2;
        this.asyncVoidMethodBuilder_0.SetResult();
      }

      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }

    private sealed class Class21 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public Class19 class19_0;
      private Class1 class1_0;
      private TaskAwaiter taskAwaiter_0;

      void IAsyncStateMachine.MoveNext()
      {
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
          if (this.class19_0.socket_0 != null)
          {
            awaiter = Task.Delay(10000).GetAwaiter();
            if (!awaiter.IsCompleted)
            {
              num = 0;
              this.int_0 = 0;
              this.taskAwaiter_0 = awaiter;
              Class19.Class21 stateMachine = this;
              this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class19.Class21>(ref awaiter, ref stateMachine);
              return;
            }
          }
          else
            goto label_8;
label_5:
          awaiter.GetResult();
          awaiter = new TaskAwaiter();
          this.class1_0 = new Class1((ushort) 8194);
          this.class19_0.method_1(this.class1_0);
          this.class1_0 = (Class1) null;
          goto label_3;
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

    private sealed class Class22 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public string string_0;
      private Exception exception_0;
      private Exception exception_1;
      private Exception exception_2;
      private TaskAwaiter taskAwaiter_0;

      unsafe void IAsyncStateMachine.MoveNext()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(6);
        int int0 = this.int_0;
        try
        {
          TaskAwaiter awaiter1;
          int num;
          TaskAwaiter awaiter2;
          TaskAwaiter awaiter3;
          TaskAwaiter awaiter4;
          TaskAwaiter awaiter5;
          TaskAwaiter awaiter6;
          TaskAwaiter awaiter7;
          TaskAwaiter awaiter8;
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
              goto label_16;
            case 2:
              awaiter3 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_22;
            case 3:
              awaiter4 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_29;
            case 4:
              awaiter5 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_37;
            case 5:
              awaiter7 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_41;
            case 6:
              awaiter8 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_44;
            case 7:
              awaiter6 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_47;
            default:
              while ((!Class19.bool_1 ? 0 : (!Class19.bool_2 ? 1 : 0)) == 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 5) = (sbyte) !Class19.bool_1;
                if (*(sbyte*) ((IntPtr) voidPtr + 5) == (sbyte) 0)
                  goto label_50;
              }
              awaiter1 = Task.Delay(1000).GetAwaiter();
              if (!awaiter1.IsCompleted)
              {
                num = 0;
                this.int_0 = 0;
                this.taskAwaiter_0 = awaiter1;
                Class19.Class22 stateMachine = this;
                this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class19.Class22>(ref awaiter1, ref stateMachine);
                return;
              }
              break;
          }
          awaiter1.GetResult();
          awaiter1 = new TaskAwaiter();
          Class73.smethod_218(Class25.class19_0, "Tebrikler " + this.string_0);
          Form1.form1_0.textBox_6.Text = "0";
          *(sbyte*) voidPtr = (sbyte) Form1.form1_0.checkBox_1.Checked;
          if (*(sbyte*) voidPtr != (sbyte) 0)
          {
            try
            {
              new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_0 + "',1," + Form1.form1_0.textBox_2.Text + "," + Form1.form1_0.textBox_1.Text + "," + Form1.form1_0.textBox_0.Text ?? "", Class65.sqlConnection_0).ExecuteNonQuery();
              Form1.smethod_1("ITEM ödülü teslim Edildi .", Color.DarkGreen);
            }
            catch (Exception ex)
            {
              this.exception_0 = ex;
              Form1.smethod_1("HATA ! İtem Ödülü teslim edilemedi!!" + this.exception_0.Message, Color.Salmon);
            }
          }
          *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) Form1.form1_0.checkBox_0.Checked;
          if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
          {
            try
            {
              new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_0 + "',2,böylekalsin," + Form1.form1_0.textBox_5.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
              Form1.smethod_1("Silk ödülü teslim Edildi.", Color.DarkGreen);
            }
            catch
            {
            }
            awaiter2 = Task.Delay(500).GetAwaiter();
            if (!awaiter2.IsCompleted)
            {
              num = 1;
              this.int_0 = 1;
              this.taskAwaiter_0 = awaiter2;
              Class19.Class22 stateMachine = this;
              this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class19.Class22>(ref awaiter2, ref stateMachine);
              return;
            }
          }
          else
            goto label_25;
label_16:
          awaiter2.GetResult();
          awaiter2 = new TaskAwaiter();
          try
          {
            new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_0 + "',3,böylekalsin," + Form1.form1_0.textBox_3.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
            Form1.smethod_1("GOLD ödülü teslim Edildi.", Color.DarkGreen);
          }
          catch (Exception ex)
          {
            this.exception_1 = ex;
            Form1.smethod_1("HATA ! Gold ödülü teslim edilemedi.Ödül miktarı boş bırakılmış olabilir. !! ==> " + this.exception_1.Message, Color.OrangeRed);
          }
          awaiter3 = Task.Delay(500).GetAwaiter();
          if (!awaiter3.IsCompleted)
          {
            num = 2;
            this.int_0 = 2;
            this.taskAwaiter_0 = awaiter3;
            Class19.Class22 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class19.Class22>(ref awaiter3, ref stateMachine);
            return;
          }
label_22:
          awaiter3.GetResult();
          awaiter3 = new TaskAwaiter();
          try
          {
            new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_0 + "',4,böylekalsin," + Form1.form1_0.textBox_4.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
            Form1.smethod_1("SP ödülü teslim Edildi.", Color.DarkGreen);
          }
          catch (Exception ex)
          {
            this.exception_2 = ex;
            Form1.smethod_1("HATA ! Sp ödülü teslim edilemedi.Ödül miktarı boş bırakılmış olabilir. !! ==> " + this.exception_2.Message, Color.OrangeRed);
          }
label_25:
          if ((Form1.form1_0.checkBox_1.Checked ? 1 : (Form1.form1_0.checkBox_0.Checked ? 1 : 0)) != 0)
          {
            Class73.smethod_193(Class25.class19_0, this.string_0);
            awaiter4 = Task.Delay(3000).GetAwaiter();
            if (!awaiter4.IsCompleted)
            {
              num = 3;
              this.int_0 = 3;
              this.taskAwaiter_0 = awaiter4;
              Class19.Class22 stateMachine = this;
              this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class19.Class22>(ref awaiter4, ref stateMachine);
              return;
            }
          }
          else
            goto label_30;
label_29:
          awaiter4.GetResult();
          awaiter4 = new TaskAwaiter();
          Class73.smethod_123(Class25.class19_0, this.string_0, "Tebrikler.Ödülün teslim edildi.");
          Class19.bool_2 = true;
label_30:
          *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) (Form1.form1_0.listBoxControl_0.Items.Count > 0);
          if (*(sbyte*) ((IntPtr) voidPtr + 2) != (sbyte) 0)
          {
            awaiter5 = Task.Delay(3000).GetAwaiter();
            if (!awaiter5.IsCompleted)
            {
              num = 4;
              this.int_0 = 4;
              this.taskAwaiter_0 = awaiter5;
              Class19.Class22 stateMachine = this;
              this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class19.Class22>(ref awaiter5, ref stateMachine);
              return;
            }
          }
          else
          {
            *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (Form1.form1_0.listBoxControl_0.Items.Count <= 0);
            if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
            {
              awaiter6 = Task.Delay(5000).GetAwaiter();
              if (!awaiter6.IsCompleted)
              {
                num = 7;
                this.int_0 = 7;
                this.taskAwaiter_0 = awaiter6;
                Class19.Class22 stateMachine = this;
                this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class19.Class22>(ref awaiter6, ref stateMachine);
                return;
              }
              goto label_47;
            }
            else
              goto label_48;
          }
label_37:
          awaiter5.GetResult();
          awaiter5 = new TaskAwaiter();
          *(sbyte*) ((IntPtr) voidPtr + 3) = (sbyte) Form1.form1_0.checkBox_26.Checked;
          if (*(sbyte*) ((IntPtr) voidPtr + 3) != (sbyte) 0)
          {
            Class73.smethod_218(Class25.class19_0, "Önce biraz zerk...");
            awaiter7 = Task.Delay(10000).GetAwaiter();
            if (!awaiter7.IsCompleted)
            {
              num = 5;
              this.int_0 = 5;
              this.taskAwaiter_0 = awaiter7;
              Class19.Class22 stateMachine = this;
              this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class19.Class22>(ref awaiter7, ref stateMachine);
              return;
            }
          }
          else
            goto label_45;
label_41:
          awaiter7.GetResult();
          awaiter7 = new TaskAwaiter();
          Form1.bool_1 = true;
          awaiter8 = Task.Delay(15000).GetAwaiter();
          if (!awaiter8.IsCompleted)
          {
            num = 6;
            this.int_0 = 6;
            this.taskAwaiter_0 = awaiter8;
            Class19.Class22 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class19.Class22>(ref awaiter8, ref stateMachine);
            return;
          }
label_44:
          awaiter8.GetResult();
          awaiter8 = new TaskAwaiter();
label_45:
          Form1.bool_2 = true;
          goto label_48;
label_47:
          awaiter6.GetResult();
          awaiter6 = new TaskAwaiter();
          Class73.smethod_161(Class25.class19_0, "[Unique Kesme] Etkinliği sona erdi. Katılan herkese teşekkürler.Başka etkinlklerde görüşmek üzere.!");
          Form1.form1_0.checkBox_2.Checked = false;
          Form1.form1_0.textBox_6.Text = "0";
          Class19.string_5 = "Cracked by EfsaneSro";
          Form1.form1_0.timer_6.Stop();
          Form1.form1_0.timer_7.Stop();
          Form1.bool_1 = false;
          Form1.bool_2 = false;
          Class19.bool_2 = false;
          Form1.form1_0.method_95();
          Form1.form1_0.listBoxControl_0.Enabled = true;
          Class73.smethod_206(Class25.class19_0);
label_48:
          Class19.string_5 = "Cracked by EfsaneSro";
        }
        catch (Exception ex)
        {
          this.int_0 = -2;
          this.asyncVoidMethodBuilder_0.SetException(ex);
          return;
        }
label_50:
        this.int_0 = -2;
        this.asyncVoidMethodBuilder_0.SetResult();
      }

      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }

    private sealed class Class23 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;
      public Class19 class19_0;
      private TaskAwaiter taskAwaiter_0;

      unsafe void IAsyncStateMachine.MoveNext()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(3);
        int num = this.int_0;
        try
        {
          if (num != 0)
          {
            *(sbyte*) voidPtr = (sbyte) this.class19_0.bool_0;
            if (*(sbyte*) voidPtr == (sbyte) 0)
            {
              this.class19_0.bool_0 = true;
              Class73.smethod_18("Sistem Başladı...");
              Form1.form1_0.label_160.Text = "ONLİNE";
              Form1.form1_0.label_160.ForeColor = Color.GreenYellow;
              goto label_13;
            }
            else
              goto label_15;
          }
label_4:
          try
          {
            TaskAwaiter awaiter;
            if (num != 0)
            {
              *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (Class65.sqlConnection_0.State != ConnectionState.Open);
              if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
                Class65.smethod_5();
              awaiter = Task.Delay(1).GetAwaiter();
              if (!awaiter.IsCompleted)
              {
                num = 0;
                this.int_0 = 0;
                this.taskAwaiter_0 = awaiter;
                Class19.Class23 stateMachine = this;
                this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class19.Class23>(ref awaiter, ref stateMachine);
                return;
              }
            }
            else
            {
              awaiter = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
            }
            awaiter.GetResult();
            awaiter = new TaskAwaiter();
          }
          catch
          {
          }
label_13:
          *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) (this.class19_0.socket_0 != null);
          if (*(sbyte*) ((IntPtr) voidPtr + 2) != (sbyte) 0)
            goto label_4;
        }
        catch (Exception ex)
        {
          this.int_0 = -2;
          this.asyncTaskMethodBuilder_0.SetException(ex);
          return;
        }
label_15:
        this.int_0 = -2;
        this.asyncTaskMethodBuilder_0.SetResult();
      }

      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }
  }
}
