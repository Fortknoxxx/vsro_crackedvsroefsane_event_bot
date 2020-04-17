// Decompiled with Syinea's Decompiler
// Type: ns5.Class71
// Assembly: My_EventBot_ßy_Mehmet_Yıldız_ML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B7172642-DC7D-4477-97BD-E927F8349F37
// Assembly location: C:\Users\Syinea\Downloads\CrackedMyEventBot\CrackedVsroEfsane.exe

using ns10;
using ns2;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ns5
{
  internal sealed class Class71
  {
    public static string string_0 = "127.0.0.1";

    public static unsafe void smethod_0(string string_1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(26);
      *(sbyte*) voidPtr = (sbyte) (string_1.ToString() == "_PartyListesi");
      if (*(sbyte*) voidPtr != (sbyte) 0)
      {
        foreach (string[] strArray in new List<string[]>()
        {
          new string[2]
          {
            "_PartyListesi",
            "USE [My_EventBot]\nGO\n\n/****** Object:  Table [dbo].[_PartyListesi]    Script Date: 9.03.2017 03:00:50 ******/\nSET ANSI_NULLS ON\nGO\n\nSET QUOTED_IDENTIFIER ON\nGO\n\nSET ANSI_PADDING ON\nGO\n\nCREATE TABLE [dbo].[_PartyListesi](\n\n\t[Party_No] [int] NOT NULL,\n\t[CharName16] [varchar](50) NOT NULL,\n\t)\n\nGO\n\nSET ANSI_PADDING OFF\nGO\n"
          }
        })
        {
          *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) !Class73.smethod_67(strArray[0]);
          if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
            Class73.smethod_234(strArray[1], true);
        }
        Form1.smethod_1("Tablo Oluşturuldu ==> _PartyListesi", Color.DarkGreen);
      }
      *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) (string_1.ToString() == "_Oylama");
      if (*(sbyte*) ((IntPtr) voidPtr + 2) != (sbyte) 0)
      {
        foreach (string[] strArray in new List<string[]>()
        {
          new string[2]
          {
            "_Oylama",
            "USE [My_EventBot]\nGO\n\n/****** Object:  Table [dbo].[_Oylama]    Script Date: 9.03.2017 03:00:50 ******/\nSET ANSI_NULLS ON\nGO\n\nSET QUOTED_IDENTIFIER ON\nGO\n\nSET ANSI_PADDING ON\nGO\n\nCREATE TABLE [dbo].[_Oylama]\n(\n\t[CharName16] [varchar](50) NOT NULL,\n\t[Kullandıgı_Oy] int NOT NULL\n)\n\nGO\n\nSET ANSI_PADDING OFF\nGO\n\n\n"
          }
        })
        {
          *(sbyte*) ((IntPtr) voidPtr + 3) = (sbyte) !Class73.smethod_67(strArray[0]);
          if (*(sbyte*) ((IntPtr) voidPtr + 3) != (sbyte) 0)
            Class73.smethod_234(strArray[1], true);
        }
        Form1.smethod_1("Tablo Oluşturuldu ==> _Oylama", Color.DarkGreen);
      }
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (string_1.ToString() == "_Sayı_Bul");
      if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
      {
        foreach (string[] strArray in new List<string[]>()
        {
          new string[2]
          {
            "_Sayı_Bul",
            "USE [My_EventBot]\nGO\n\n/****** Object:  Table [dbo].[_Sayı_Bul]    Script Date: 9.03.2017 03:00:50 ******/\nSET ANSI_NULLS ON\nGO\n\nSET QUOTED_IDENTIFIER ON\nGO\n\nSET ANSI_PADDING ON\nGO\n\nCREATE TABLE [dbo].[_Sayı_Bul]\n(\n\t[CharName16] [varchar](50) NOT NULL,\n\t[Tahmin] int NOT NULL,\n    [Tarih] datetime NOT NULL\n)\n\nGO\n\nSET ANSI_PADDING OFF\nGO\n\n\n"
          }
        })
        {
          *(sbyte*) ((IntPtr) voidPtr + 5) = (sbyte) !Class73.smethod_67(strArray[0]);
          if (*(sbyte*) ((IntPtr) voidPtr + 5) != (sbyte) 0)
            Class73.smethod_234(strArray[1], true);
        }
        Form1.smethod_1("Tablo Oluşturuldu ==> _Sayı_Bul", Color.DarkGreen);
      }
      *(sbyte*) ((IntPtr) voidPtr + 6) = (sbyte) (string_1.ToString() == "_AnlıkGlobal_Log");
      if (*(sbyte*) ((IntPtr) voidPtr + 6) != (sbyte) 0)
      {
        foreach (string[] strArray in new List<string[]>()
        {
          new string[2]
          {
            "_AnlıkGlobal_Log",
            "USE [My_EventBot]\nGO\n\n/****** Object:  Table [dbo].[_AnlıkGlobal_Log]    Script Date: 9.03.2017 03:00:50 ******/\nSET ANSI_NULLS ON\nGO\n\nSET QUOTED_IDENTIFIER ON\nGO\n\nSET ANSI_PADDING ON\nGO\n\nCreate Table [dbo].[_AnlıkGlobal_Log]  \n([ID][Int] NOT NULL Primary Key Identity ,\n[CharName][Varchar](60)\tNOT NULL ,\n[GlobalChat][Varchar](Max) NOT NULL ,\n[Date][DATETIME] NOT NULL);\n\nGO\nSET ANSI_PADDING OFF\nGO\n\n\n"
          }
        })
        {
          *(sbyte*) ((IntPtr) voidPtr + 7) = (sbyte) !Class73.smethod_67(strArray[0]);
          if (*(sbyte*) ((IntPtr) voidPtr + 7) != (sbyte) 0)
            Class73.smethod_234(strArray[1], true);
        }
        Form1.smethod_1("Tablo Oluşturuldu ==> _AnlıkGlobal_Log", Color.DarkGreen);
      }
      *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) (string_1.ToString() == "_AnlıkPM_Log");
      if (*(sbyte*) ((IntPtr) voidPtr + 8) != (sbyte) 0)
      {
        foreach (string[] strArray in new List<string[]>()
        {
          new string[2]
          {
            "_AnlıkPM_Log",
            "USE [My_EventBot]\nGO\n\n/****** Object:  Table [dbo].[_AnlıkPM_Log]    Script Date: 9.03.2017 03:00:50 ******/\nSET ANSI_NULLS ON\nGO\n\nSET QUOTED_IDENTIFIER ON\nGO\n\nSET ANSI_PADDING ON\nGO\n\nCreate Table [dbo].[_AnlıkPM_Log]\n([ID][Int] NOT NULL Primary Key Identity ,\n[CharName][Varchar](60)\tNOT NULL ,\n[Chat][Varchar](Max) NOT NULL ,\n[Date][DATETIME] NOT NULL);\n\nGO\nSET ANSI_PADDING OFF\nGO\n\n\n"
          }
        })
        {
          *(sbyte*) ((IntPtr) voidPtr + 9) = (sbyte) !Class73.smethod_67(strArray[0]);
          if (*(sbyte*) ((IntPtr) voidPtr + 9) != (sbyte) 0)
            Class73.smethod_234(strArray[1], true);
        }
        Form1.smethod_1("Tablo Oluşturuldu ==> _AnlıkPM_Log", Color.DarkGreen);
      }
      *(sbyte*) ((IntPtr) voidPtr + 10) = (sbyte) (string_1.ToString() == "_UniquesLog");
      if (*(sbyte*) ((IntPtr) voidPtr + 10) != (sbyte) 0)
      {
        foreach (string[] strArray in new List<string[]>()
        {
          new string[2]
          {
            "_UniquesLog",
            "USE [My_EventBot]\nGO\n\n/****** Object:  Table [dbo].[_UniquesLog]    Script Date: 9.03.2017 03:00:50 ******/\nSET ANSI_NULLS ON\nGO\n\nSET QUOTED_IDENTIFIER ON\nGO\n\nSET ANSI_PADDING ON\nGO\n\nCREATE TABLE [dbo].[_UniquesLog]\n(\n[ID][Int] NOT NULL Primary Key Identity ,\n[Type][Int]\tNOT NULL ,\n[CodeName128][Varchar](128) NOT NULL ,\n[Killer][Varchar](60) ,\n[Date][DATETIME] NOT NULL\n)\n\nGO\n\nSET ANSI_PADDING OFF\nGO\n"
          }
        })
        {
          *(sbyte*) ((IntPtr) voidPtr + 11) = (sbyte) !Class73.smethod_67(strArray[0]);
          if (*(sbyte*) ((IntPtr) voidPtr + 11) != (sbyte) 0)
            Class73.smethod_234(strArray[1], true);
        }
        Form1.smethod_1("Tablo Oluşturuldu ==> _UniquesLog", Color.DarkGreen);
      }
      *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) (string_1.ToString() == "_PlusLog");
      if (*(sbyte*) ((IntPtr) voidPtr + 12) != (sbyte) 0)
      {
        foreach (string[] strArray in new List<string[]>()
        {
          new string[2]
          {
            "_PlusLog",
            "USE [My_EventBot]\nGO\n\n/****** Object:  Table [dbo].[_PlusLog]    Script Date: 9.03.2017 03:00:50 ******/\nSET ANSI_NULLS ON\nGO\n\nSET QUOTED_IDENTIFIER ON\nGO\n\nSET ANSI_PADDING ON\nGO\n\nCREATE TABLE [dbo].[_PlusLog](\n\t[ID] [int] IDENTITY(1,1) NOT NULL,\n\t[CharID] [varchar](10) NOT NULL,\n\t[CharName16] [varchar](50) NOT NULL,\n    [ItemID] [varchar](50) NOT NULL,\n\t[ItemSerial64] [varchar](64) NOT NULL,\n\t[Plus] [int] NOT NULL,\n\t[Tarih] [datetime] NOT NULL,\n\t[Durum] [int]NOT NULL,\n CONSTRAINT [PK_PlusLog1_1] PRIMARY KEY CLUSTERED \n(\n\t[ID] ASC\n)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]\n) ON [PRIMARY]\n\nGO\n\nSET ANSI_PADDING OFF\nGO\n"
          }
        })
        {
          *(sbyte*) ((IntPtr) voidPtr + 13) = (sbyte) !Class73.smethod_67(strArray[0]);
          if (*(sbyte*) ((IntPtr) voidPtr + 13) != (sbyte) 0)
            Class73.smethod_234(strArray[1], true);
        }
        Form1.smethod_1("Tablo Oluşturuldu ==> _PlusLog", Color.DarkGreen);
      }
      *(sbyte*) ((IntPtr) voidPtr + 14) = (sbyte) (string_1.ToString() == "_SoruCevap");
      if (*(sbyte*) ((IntPtr) voidPtr + 14) != (sbyte) 0)
      {
        foreach (string[] strArray in new List<string[]>()
        {
          new string[2]
          {
            "_SoruCevap",
            "USE [My_EventBot]\nGO\n\n/****** Object:  Table [dbo].[_SoruCevap]    Script Date: 9.03.2017 03:00:50 ******/\nSET ANSI_NULLS ON\nGO\n\nSET QUOTED_IDENTIFIER ON\nGO\n\nSET ANSI_PADDING ON\nGO\n\nCREATE TABLE [dbo].[_SoruCevap](\n\t[ID] [int] IDENTITY(1,1) NOT NULL,\n\t[Soru] [varchar](256) NOT NULL,\n\t[Cevap] [varchar](128) NOT NULL,\n\t[Soruldumu] [int] NOT NULL,\n\t[SorulduguTarih] [datetime] NULL CONSTRAINT [DF__SoruCevap_SorulduguTarih]  DEFAULT (getdate()),\n CONSTRAINT [_SoruCevap1] PRIMARY KEY CLUSTERED \n(\n\t[ID] ASC\n)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]\n) ON [PRIMARY]\nif not exists (select soru from _SoruCevap where Soru ='Tarihçilerin Kutbu olarak bilinen dünyaca ünlü tarihçimizin ismi nedir? (sadece isim)') \ninsert into _SoruCevap (Soru,Cevap,Soruldumu,SorulduguTarih) values ('Tarihçilerin Kutbu olarak bilinen dünyaca ünlü tarihçimizin ismi nedir? (sadece isim)','Halil',0,GETDATE())\nif not exists (select soru from _SoruCevap where Soru ='Osmanlı İmparatorluğu yaklaşık kac asır hüküm sürmüştür? (rakam)')\ninsert into _SoruCevap (Soru,Cevap,Soruldumu,SorulduguTarih) values ('Osmanlı İmparatorluğu yaklaşık kac asır hüküm sürmüştür? (rakam)','6',0,GETDATE())\nif not exists (select soru from _SoruCevap where Soru ='Fas ın başkenti hangi şehirdir?')\ninsert into _SoruCevap (Soru,Cevap,Soruldumu,SorulduguTarih) values ('Fas ın başkenti hangi şehirdir?','Rabat',0,GETDATE())\nif not exists(select soru from _SoruCevap where Soru = '1 metre kaç milimetredir? (rakam)')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('1 metre kaç milimetredir? (rakam)', '1000', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = 'Dört halife devrinden sonra kurulan saltanatın adı nedir?')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('Dört halife devrinden sonra kurulan saltanatın adı nedir?', 'Emeviler', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = 'Vezir-i Azam ın bugünkü karşılığı nedir?')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('Vezir-i Azam ın bugünkü karşılığı nedir?', 'Başbakan', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = 'Güneş yılına göre düenlenmiş olan takvimin adı nedir?')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('Güneş yılına göre düenlenmiş olan takvimin adı nedir?', 'Rumi', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = ' 8850 metre yüksekliğinde dünyanın en yüksek dağı olarak bilinen dağın adı nedir?')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('8850 metre yüksekliğinde dünyanın en yüksek dağı olarak bilinen dağın adı nedir?', 'Everest', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = 'Avrupa Birliği nin dönem başkanının süresi ne kadardır?')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('Avrupa Birliği nin dönem başkanının süresi kaç aydır?', '6', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = 'Hilal-i Ahmer in bugünkü adı nedir?')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('Hilal-i Ahmer in bugünkü adı nedir?', 'Kızılay', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = 'Orta Çağ Avrupası nda kahraman kabul edilen kişilere ne isim verilir?')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('Orta Çağ Avrupası nda kahraman kabul edilen kişilere ne isim verilir?', 'Şövalye', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = 'Tek kişinin mutlak yönetimine ne denir?')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('Tek kişinin mutlak yönetimine ne denir?', 'Monarşi', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = 'Günümüzde nüfusu en fazla olan İslam ülkesi hangisidir? ')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('Günümüzde nüfusu en fazla olan İslam ülkesi hangisidir? ', 'Endonezya', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = 'Bakü hangi devletin başkentidir? ')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('Bakü hangi devletin başkentidir? ', 'Azerbaycan', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = 'Hollanda’nın başkenti nedir? ')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('Hollanda’nın başkenti nedir?', 'Amsterdam', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = 'Kaç yılda bir Şubat ayı 29 çeker? ')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('Kaç yılda bir Şubat ayı 29 çeker?', '4', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = 'Bir Gün Kaç Saniyedir? ')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('Bir Gün Kaç Saniyedir? ', '86400', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = 'Aspirinin Hammaddesi Nedir? ')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('Aspirinin Hammaddesi Nedir? ', 'Söğüt', 0, GETDATE())\nGO\n\nSET ANSI_PADDING OFF\nGO\n"
          }
        })
        {
          *(sbyte*) ((IntPtr) voidPtr + 15) = (sbyte) !Class73.smethod_67(strArray[0]);
          if (*(sbyte*) ((IntPtr) voidPtr + 15) != (sbyte) 0)
            Class73.smethod_234(strArray[1], true);
        }
        Form1.smethod_1("Tablo Oluşturuldu ==> _SoruCevap", Color.DarkGreen);
      }
      *(sbyte*) ((IntPtr) voidPtr + 16) = (sbyte) (string_1.ToString() == "_Etkinlik_Takvimi");
      if (*(sbyte*) ((IntPtr) voidPtr + 16) != (sbyte) 0)
      {
        foreach (string[] strArray in new List<string[]>()
        {
          new string[2]
          {
            "_Etkinlik_Takvimi",
            "USE [My_EventBot]\nGO\n\n/****** Object:  Table [dbo].[_Etkinlik_Takvimi]    Script Date: 9.03.2017 03:00:50 ******/\nSET ANSI_NULLS ON\nGO\n\nSET QUOTED_IDENTIFIER ON\nGO\n\nSET ANSI_PADDING ON\nGO\n\nCREATE TABLE [dbo].[_Etkinlik_Takvimi]\n(\n    [ID] [int] IDENTITY(1,1) NOT NULL,\n    [Etkinlik] [varchar](128) NOT NULL,\n\t[Etkinlik_Tarihi] [varchar](128) NOT NULL,\n CONSTRAINT [PK__Etkinlik_Takvimi_1] PRIMARY KEY CLUSTERED \n(\n    [ID] ASC\n)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]\n) ON [PRIMARY] \n\nGO\n\nSET ANSI_PADDING OFF\nGO\n"
          }
        })
        {
          *(sbyte*) ((IntPtr) voidPtr + 17) = (sbyte) !Class73.smethod_67(strArray[0]);
          if (*(sbyte*) ((IntPtr) voidPtr + 17) != (sbyte) 0)
            Class73.smethod_234(strArray[1], true);
        }
        Form1.smethod_1("Tablo Oluşturuldu ==> _Etkinlik_Takvimi", Color.DarkGreen);
      }
      *(sbyte*) ((IntPtr) voidPtr + 18) = (sbyte) (string_1.ToString() == "_Hayatta_Kal");
      if (*(sbyte*) ((IntPtr) voidPtr + 18) != (sbyte) 0)
      {
        foreach (string[] strArray in new List<string[]>()
        {
          new string[2]
          {
            "_Hayatta_Kal",
            "USE [My_EventBot]\nGO\n\n/****** Object:  Table [dbo].[_Hayatta_Kal]    Script Date: 9.03.2017 03:00:50 ******/\nSET ANSI_NULLS ON\nGO\n\nSET ANSI_PADDING ON\nGO\n\nCREATE TABLE [dbo].[_Hayatta_Kal](\n\t[CharName] [varchar](128) NOT NULL,\n\t[Durum] [varchar](128) NOT NULL,\n    [Toplam_Öldürme] [int] NOT NULL\n)\nGO\nSET ANSI_PADDING OFF\nGO\n"
          }
        })
        {
          *(sbyte*) ((IntPtr) voidPtr + 19) = (sbyte) !Class73.smethod_67(strArray[0]);
          if (*(sbyte*) ((IntPtr) voidPtr + 19) != (sbyte) 0)
            Class73.smethod_234(strArray[1], true);
        }
        Form1.smethod_1("Tablo Oluşturuldu ==> _Hayatta_Kal", Color.DarkGreen);
      }
      *(sbyte*) ((IntPtr) voidPtr + 20) = (sbyte) (string_1.ToString() == "_UniqKesList");
      if (*(sbyte*) ((IntPtr) voidPtr + 20) != (sbyte) 0)
      {
        foreach (string[] strArray in new List<string[]>()
        {
          new string[2]
          {
            "_UniqKesList",
            "USE [My_EventBot]\nGO\n\n/****** Object:  Table [dbo].[_UniqKesList]    Script Date: 9.03.2017 03:00:50 ******/\nSET ANSI_NULLS ON\nGO\n\nSET QUOTED_IDENTIFIER ON\nGO\n\nSET ANSI_PADDING ON\nGO\n\nCREATE TABLE [dbo].[_UniqKesList](\n\n\t[Sıra] [int] IDENTITY(1,1) NOT NULL,\r\n\t[refcommon_ID] [int] NOT NULL,\r\n    [Durum] [int] NOT NULL,\r\nPRIMARY KEY CLUSTERED \r\n(\r\n\t[Sıra] ASC\r\n)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]\r\n) ON [PRIMARY]\r\n\r\nGO\r\n\r\nSET ANSI_PADDING OFF\r\nGO\n"
          }
        })
        {
          *(sbyte*) ((IntPtr) voidPtr + 21) = (sbyte) !Class73.smethod_67(strArray[0]);
          if (*(sbyte*) ((IntPtr) voidPtr + 21) != (sbyte) 0)
            Class73.smethod_234(strArray[1], true);
        }
        Form1.smethod_1("Tablo Oluşturuldu ==> _UniqKesList", Color.DarkGreen);
      }
      *(sbyte*) ((IntPtr) voidPtr + 22) = (sbyte) (string_1.ToString() == "_HayattaKal_List");
      if (*(sbyte*) ((IntPtr) voidPtr + 22) != (sbyte) 0)
      {
        foreach (string[] strArray in new List<string[]>()
        {
          new string[2]
          {
            "_HayattaKal_List",
            "USE [My_EventBot]\nGO\n\n/****** Object:  Table [dbo].[_HayattaKal_List]    Script Date: 9.03.2017 03:00:50 ******/\nSET ANSI_NULLS ON\nGO\n\nSET QUOTED_IDENTIFIER ON\nGO\n\nSET ANSI_PADDING ON\nGO\n\nCREATE TABLE [dbo].[_HayattaKal_List](\n\n\t[CharName16][varchar](100) NOT NULL,\n    [Asama][varchar](50) NOT NULL,\n\t[Durum] [varchar](100) NOT NULL,\n\t)\n\nGO\n\nSET ANSI_PADDING OFF\nGO\n"
          }
        })
        {
          *(sbyte*) ((IntPtr) voidPtr + 23) = (sbyte) !Class73.smethod_67(strArray[0]);
          if (*(sbyte*) ((IntPtr) voidPtr + 23) != (sbyte) 0)
            Class73.smethod_234(strArray[1], true);
        }
        Form1.smethod_1("Tablo Oluşturuldu ==> _HayattaKal_List", Color.DarkGreen);
      }
      *(sbyte*) ((IntPtr) voidPtr + 24) = (sbyte) (string_1.ToString() == "_Piyango");
      if (*(sbyte*) ((IntPtr) voidPtr + 24) == (sbyte) 0)
        return;
      foreach (string[] strArray in new List<string[]>()
      {
        new string[2]
        {
          "_Piyango",
          "USE [My_EventBot]\nGO\n\n/****** Object:  Table [dbo].[_Piyango]    Script Date: 9.03.2017 03:00:50 ******/\nSET ANSI_NULLS ON\nGO\n\nSET QUOTED_IDENTIFIER ON\nGO\n\nSET ANSI_PADDING ON\nGO\n\nCREATE TABLE [dbo].[_Piyango](\n\t[CharName] [varchar](100) NULL,\n\t[KatılımUcreti] [bigint] NULL\n) ON [PRIMARY]\n\nGO\n\nSET ANSI_PADDING OFF\nGO\n"
        }
      })
      {
        *(sbyte*) ((IntPtr) voidPtr + 25) = (sbyte) !Class73.smethod_67(strArray[0]);
        if (*(sbyte*) ((IntPtr) voidPtr + 25) != (sbyte) 0)
          Class73.smethod_234(strArray[1], true);
      }
      Form1.smethod_1("Tablo Oluşturuldu ==> _Piyango", Color.DarkGreen);
    }

    public static unsafe void smethod_1(string string_1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(24);
      *(sbyte*) voidPtr = (sbyte) (string_1.ToString() == "__PartyListesi");
      if (*(sbyte*) voidPtr != (sbyte) 0)
      {
        foreach (string[] strArray in new List<string[]>()
        {
          new string[2]
          {
            "__PartyListesi",
            "\nUSE [My_EventBot]\nGO\n/****** Object:  StoredProcedure [dbo].[__PartyListesi]    Script Date: 04.01.2017 20:11:13 ******/\nSET ANSI_NULLS ON\nGO\nSET QUOTED_IDENTIFIER ON\nGO\n-- =============================================\n-- Author:\t\t<Bu prosedür MEHMET YILDIZ (facebook.com/mhmt3606) tarafından My_EventBot programı için hazırlanmıştır.>\n-- Create date: <11.06.2017>\n-- Description:\t<My_EventBot>\n-- =============================================\nCREATE PROCEDURE [dbo].[__PartyListesi]\n@Party_No\t\tint,\n@CharName16 varchar(50)\n WITH ENCRYPTION\nas\ndeclare @gercekcname varchar(100)\n-----------------------------------\nif exists (Select CharName16 from SRO_VT_SHARD.._Char where CharName16=@CharName16) -- Kazanan CharName16 ise\nset @gercekcname=@CharName16\nif not exists (Select CharName16 from SRO_VT_SHARD.._Char where CharName16=@CharName16) --Kazanan NickName16 ise\nset @gercekcname=( SELECT CharName16 from SRO_VT_SHARD.._Char where NickName16=@CharName16)\n-----------------------------------\nif not exists(select CharName16 from _PartyListesi where CharName16=@gercekcname)\nbegin\ninsert into _PartyListesi (Party_No,CharName16) values (@Party_No,@gercekcname)\nend\nelse if exists(select CharName16 from _PartyListesi where CharName16=@gercekcname)\nbegin\nupdate My_EventBot.._PartyListesi set Party_No = @Party_No where CharName16=@gercekcname\nend\n\n\t\nGO\n\nSET ANSI_PADDING OFF\nGO\n\n"
          }
        })
        {
          *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) !Class73.smethod_67(strArray[0]);
          if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
          {
            try
            {
              Class73.smethod_234(strArray[1], true);
              Form1.smethod_1("Prosedür Oluşturuldu ==> __PartyListesi", Color.LightCyan);
            }
            catch (Exception ex)
            {
              Form1.smethod_0(ex.Message ?? "");
            }
          }
        }
      }
      *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) (string_1.ToString() == "__Oylama");
      if (*(sbyte*) ((IntPtr) voidPtr + 2) != (sbyte) 0)
      {
        foreach (string[] strArray in new List<string[]>()
        {
          new string[2]
          {
            "__Oylama",
            "\nUSE [My_EventBot]\nGO\n/****** Object:  StoredProcedure [dbo].[__Oylama]    Script Date: 04.01.2017 20:11:13 ******/\nSET ANSI_NULLS ON\nGO\nSET QUOTED_IDENTIFIER ON\nGO\n-- =============================================\n-- Author:\t\t<Bu prosedür MEHMET YILDIZ (facebook.com/mhmt3606) tarafından My_EventBot programı için hazırlanmıştır.>\n-- Create date: <11.06.2017>\n-- Description:\t<My_EventBot>\n-- =============================================\n\nCREATE PROCEDURE [dbo].[__Oylama]\n@CharName16 varchar(50),\n@Kullandıgı_Oy int\n WITH ENCRYPTION\nas\nif not exists(select CharName16 from _Oylama where CharName16 = @CharName16)\ninsert into _Oylama(CharName16,Kullandıgı_Oy) values (@CharName16,@Kullandıgı_Oy)\nelse if(exists (select CharName16 from _Oylama where CharName16 = @CharName16))\nupdate _Oylama set Kullandıgı_Oy = @Kullandıgı_Oy where CharName16 = @CharName16\n\nGO\n\nSET ANSI_PADDING OFF\nGO\n\n\n"
          }
        })
        {
          *(sbyte*) ((IntPtr) voidPtr + 3) = (sbyte) !Class73.smethod_67(strArray[0]);
          if (*(sbyte*) ((IntPtr) voidPtr + 3) != (sbyte) 0)
            Class73.smethod_234(strArray[1], true);
        }
        Form1.smethod_1("Prosedür Oluşturuldu ==> __Oylama", Color.LightCyan);
      }
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (string_1.ToString() == "__Sayı_Bul");
      if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
      {
        foreach (string[] strArray in new List<string[]>()
        {
          new string[2]
          {
            "__Sayı_Bul",
            "\nUSE [My_EventBot]\nGO\n/****** Object:  StoredProcedure [dbo].[__Sayı_Bul]    Script Date: 04.01.2017 20:11:13 ******/\nSET ANSI_NULLS ON\nGO\nSET QUOTED_IDENTIFIER ON\nGO\n-- =============================================\n-- Author:\t\t<Bu prosedür MEHMET YILDIZ (facebook.com/mhmt3606) tarafından My_EventBot programı için hazırlanmıştır.>\n-- Create date: <11.06.2017>\n-- Description:\t<My_EventBot>\n-- =============================================\n\nCREATE PROCEDURE [dbo].[__Sayı_Bul]\n@CharName16 varchar(50),\n@Tahmin int\n WITH ENCRYPTION\nas\ndeclare @gercekcname varchar(100)\n-----------------------------------\nif exists (Select CharName16 from SRO_VT_SHARD.._Char where CharName16=@CharName16) -- Kazanan CharName16 ise\nset @gercekcname=@CharName16\nif not exists (Select CharName16 from SRO_VT_SHARD.._Char where CharName16=@CharName16) --Kazanan NickName16 ise\nset @gercekcname=( SELECT CharName16 from SRO_VT_SHARD.._Char where NickName16=@CharName16)\n-----------------------------------\nif not exists(select CharName16 from _Sayı_Bul where CharName16 = @gercekcname)\nbegin \ninsert into _Sayı_Bul(CharName16,Tahmin,Tarih) values (@gercekcname,@Tahmin,GETDATE())\nend\nelse if exists(select CharName16 from _Sayı_Bul where CharName16=@gercekcname)\nbegin\nupdate My_EventBot.._Sayı_Bul set Tahmin = @Tahmin,Tarih=GETDATE() where CharName16=@gercekcname\nend\n\nGO\n\nSET ANSI_PADDING OFF\nGO\n\n\n"
          }
        })
        {
          *(sbyte*) ((IntPtr) voidPtr + 5) = (sbyte) !Class73.smethod_67(strArray[0]);
          if (*(sbyte*) ((IntPtr) voidPtr + 5) != (sbyte) 0)
            Class73.smethod_234(strArray[1], true);
        }
        Form1.smethod_1("Prosedür Oluşturuldu ==> __Sayı_Bul", Color.LightCyan);
      }
      *(sbyte*) ((IntPtr) voidPtr + 6) = (sbyte) (string_1.ToString() == "_AnlıkChat_Log");
      if (*(sbyte*) ((IntPtr) voidPtr + 6) != (sbyte) 0)
      {
        foreach (string[] strArray in new List<string[]>()
        {
          new string[2]
          {
            "_AnlıkChat_Log",
            "\nUSE [My_EventBot]\nGO\n/****** Object:  StoredProcedure [dbo].[_AnlıkChat_Log]    Script Date: 04.01.2017 20:11:13 ******/\nSET ANSI_NULLS ON\nGO\nSET QUOTED_IDENTIFIER ON\nGO\n-- =============================================\n-- Author:\t\t<Bu prosedür MEHMET YILDIZ (facebook.com/mhmt3606) tarafından My_EventBot programı için hazırlanmıştır.>\n-- Create date: <11.06.2017>\n-- Description:\t<My_EventBot>\n-- =============================================\n\nCreate Procedure [dbo].[_AnlıkChat_Log]\n @Type\t\t[Varchar](60) ,\n @CharName\t[Varchar](60) ,\n @Message\t[Varchar](Max)\n WITH ENCRYPTION\n  As\n\n--------------------------------------------------------------------------------------------------------------------------\n-- @Type = 1 private chat\n-- @Type = 2 global chat\n\n\tIF @Type = 1\n\tBegin\n\t\tInsert Into [dbo].[_AnlıkPM_Log] (CharName,Chat,Date) Values (@CharName,@Message,GETDATE())\n\tEnd\n\n\tIF @Type = 2\n\tBegin\n\t\tInsert Into [dbo].[_AnlıkGlobal_Log] (CharName,GlobalChat,Date) Values (@CharName,@Message,GETDATE())\n\tEnd\n\nGO\n\nSET ANSI_PADDING OFF\nGO\n\n\n"
          }
        })
        {
          *(sbyte*) ((IntPtr) voidPtr + 7) = (sbyte) !Class73.smethod_67(strArray[0]);
          if (*(sbyte*) ((IntPtr) voidPtr + 7) != (sbyte) 0)
            Class73.smethod_234(strArray[1], true);
        }
        Form1.smethod_1("Prosedür Oluşturuldu ==> _AnlıkChat_Log", Color.LightCyan);
      }
      *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) (string_1.ToString() == "_Anlık_UniqueLog");
      if (*(sbyte*) ((IntPtr) voidPtr + 8) != (sbyte) 0)
      {
        foreach (string[] strArray in new List<string[]>()
        {
          new string[2]
          {
            "_Anlık_UniqueLog",
            "USE [My_EventBot]\nGO\n/****** Object:  StoredProcedure [dbo].[_Anlık_UniqueLog]    Script Date: 04.01.2017 20:11:13 ******/\nSET ANSI_NULLS ON\nGO\nSET QUOTED_IDENTIFIER ON\nGO\n-- =============================================\n-- Author:\t\t<Bu prosedür MEHMET YILDIZ (facebook.com/mhmt3606) tarafından My_EventBot programı için hazırlanmıştır.>\n-- Create date: <11.06.2017>\n-- Description:\t<My_EventBot>\n-- =============================================\n\nCreate Procedure [dbo].[_Anlık_UniqueLog]\n @Type\t\t\t[Varchar](1) ,\n @RefMonsterID\t[Int] ,\n @Killer\t\t[Varchar](60)\n WITH ENCRYPTION\n  As\n Declare @CodeName Varchar(128) = (Select CodeName128 From SRO_VT_SHARD.._RefObjCommon Where ID = @RefMonsterID)\n\n --------------------------------------------------------------------------------------------------------------------------\n-- @Type = 1  Spawned \n-- @Type = 2  Killed\n\n  Insert Into [dbo].[_UniquesLog] (Type,CodeName128,Killer,Date) Values (@Type,@CodeName,@Killer,GETDATE())\n\nGO\n\nSET ANSI_PADDING OFF\nGO\n\n"
          }
        })
        {
          *(sbyte*) ((IntPtr) voidPtr + 9) = (sbyte) !Class73.smethod_67(strArray[0]);
          if (*(sbyte*) ((IntPtr) voidPtr + 9) != (sbyte) 0)
            Class73.smethod_234(strArray[1], true);
        }
        Form1.smethod_1("Prosedür Oluşturuldu ==> _Anlık_UniqueLog", Color.LightCyan);
      }
      *(sbyte*) ((IntPtr) voidPtr + 10) = (sbyte) (string_1.ToString() == "_Ödül_ver");
      if (*(sbyte*) ((IntPtr) voidPtr + 10) != (sbyte) 0)
      {
        foreach (string[] strArray in new List<string[]>()
        {
          new string[2]
          {
            "_Ödül_ver",
            "\nUSE [My_EventBot]\nGO\n/****** Object:  StoredProcedure [dbo].[_Ödül_ver]    Script Date: 04.01.2017 20:11:13 ******/\nSET ANSI_NULLS ON\nGO\nSET QUOTED_IDENTIFIER ON\nGO\n-- =============================================\n-- Author:\t\t<Bu prosedür MEHMET YILDIZ (facebook.com/mhmt3606) tarafından My_EventBot programı için hazırlanmıştır.>\n-- Create date: <11.06.2017>\n-- Description:\t<My_EventBot>\n-- =============================================\n\nCreate Procedure [dbo].[_Ödül_ver]\n\n--@ÖdülTipi 1 = ITEM\n--@ÖdülTipi 2 = SILK\n--@ÖdülTipi 3 = GOLD\n--@ÖdülTipi 4 = SP\n--@ÖdülTipi 5 = RUTBE\n\n@CharName varchar(100),\n@ÖdülTipi varchar(50),\n@ÖdülKodu varchar(100),\n@ÖdülMiktari bigint,\n@ödülPLUS int\n WITH ENCRYPTION\nAS\nBEGIN\nDECLARE @ChrID INT; \nDECLARE @AccJID INT;\nSET @ChrID=(SELECT CharID FROM SRO_VT_SHARD.._Char WHERE CharName16=@CharName)\nSET @AccJID=(SELECT UserJID FROM SRO_VT_SHARD.._User WHERE CharID=@ChrID)\nif(@ÖdülTipi = '1') --İTEM\nbegin\nEXEC SRO_VT_SHARD.._ADD_ITEM_EXTERN @CharName,@ÖdülKodu,@ÖdülMiktari,@ödülPLUS\nend\nif(@ÖdülTipi = '2') -- SİLK\nbegin\nif not exists (select JID from SRO_VT_ACCOUNT..SK_Silk where JID=@AccJID)\nbegin\ninsert into SRO_VT_ACCOUNT..SK_Silk (JID,silk_own,silk_gift,silk_point) values (@AccJID,0,0,0)\nend\nUPDATE SRO_VT_ACCOUNT..SK_Silk set silk_own = silk_own+@ÖdülMiktari where JID=@AccJID\nend\nif(@ÖdülTipi = '3') -- GOLD\nbegin\nUPDATE SRO_VT_SHARD.._Char SET RemainGold = RemainGold+@ÖdülMiktari where CharID = @ChrID\nend\nif(@ÖdülTipi = '4') -- SP\nbegin\nUPDATE SRO_VT_SHARD.._Char SET RemainSkillPoint = RemainSkillPoint+@ÖdülMiktari where CharID = @ChrID\nend\nEND\n\nSET ANSI_PADDING OFF\nGO\n\n\n"
          }
        })
        {
          *(sbyte*) ((IntPtr) voidPtr + 11) = (sbyte) !Class73.smethod_67(strArray[0]);
          if (*(sbyte*) ((IntPtr) voidPtr + 11) != (sbyte) 0)
            Class73.smethod_234(strArray[1], true);
        }
        Form1.smethod_1("Prosedür Oluşturuldu ==> _Ödül_ver", Color.LightCyan);
      }
      *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) (string_1.ToString() == "__SoruCevap");
      if (*(sbyte*) ((IntPtr) voidPtr + 12) != (sbyte) 0)
      {
        foreach (string[] strArray in new List<string[]>()
        {
          new string[2]
          {
            "__SoruCevap",
            "\nUSE [My_EventBot]\nGO\n/****** Object:  StoredProcedure [dbo].[__SoruCevap]    Script Date: 04.01.2017 20:11:13 ******/\nSET ANSI_NULLS ON\nGO\nSET QUOTED_IDENTIFIER ON\nGO\n-- =============================================\n-- Author:\t\t<Bu prosedür MEHMET YILDIZ (facebook.com/mhmt3606) tarafından My_EventBot programı için hazırlanmıştır.>\n-- Create date: <11.06.2017>\n-- Description:\t<My_EventBot>\n-- =============================================\n\nCreate Procedure [dbo].[__SoruCevap]\n@İslemTipi varchar(25),\n@aranancevap varchar(250)\n WITH ENCRYPTION\nAS\nif(@İslemTipi = 'SoruBul')\nbegin\ndeclare @soru varchar(max)\ndeclare @cevap varchar(max)\nset @soru = (select Top 1 Soru from My_EventBot.._SoruCevap order by SorulduguTarih)\nset @cevap = (select Cevap from My_EventBot.._SoruCevap where Soru = @soru)\nupdate _SoruCevap set SorulduguTarih = GETDATE() where Soru = @soru\ndelete _AnlıkPM_Log\nselect @soru,@cevap\nend\nif(@İslemTipi = 'KazananıBul')\nbegin \ndeclare @kazananChr varchar(50) set @kazananChr = (select top 1 CharName from _AnlıkPM_Log where Chat like '%'+@aranancevap+'%' order by Date asc)\nselect @kazananChr\nend\nif(@İslemTipi = 'SoruEkle')\nbegin\nif not exists (select soru from _SoruCevap where Soru ='Tarihçilerin Kutbu olarak bilinen dünyaca ünlü tarihçimizin ismi nedir? (sadece isim)') \ninsert into _SoruCevap (Soru,Cevap,Soruldumu,SorulduguTarih) values ('Tarihçilerin Kutbu olarak bilinen dünyaca ünlü tarihçimizin ismi nedir? (sadece isim)','Halil',0,GETDATE())\nif not exists (select soru from _SoruCevap where Soru ='Osmanlı İmparatorluğu yaklaşık kac asır hüküm sürmüştür? (rakam)')\ninsert into _SoruCevap (Soru,Cevap,Soruldumu,SorulduguTarih) values ('Osmanlı İmparatorluğu yaklaşık kac asır hüküm sürmüştür? (rakam)','6',0,GETDATE())\nif not exists (select soru from _SoruCevap where Soru ='Fas ın başkenti hangi şehirdir?')\ninsert into _SoruCevap (Soru,Cevap,Soruldumu,SorulduguTarih) values ('Fas ın başkenti hangi şehirdir?','Rabat',0,GETDATE())\nif not exists(select soru from _SoruCevap where Soru = '1 metre kaç milimetredir? (rakam)')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('1 metre kaç milimetredir? (rakam)', '1000', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = 'Dört halife devrinden sonra kurulan saltanatın adı nedir?')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('Dört halife devrinden sonra kurulan saltanatın adı nedir?', 'Emeviler', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = 'Vezir-i Azam ın bugünkü karşılığı nedir?')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('Vezir-i Azam ın bugünkü karşılığı nedir?', 'Başbakan', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = 'Güneş yılına göre düenlenmiş olan takvimin adı nedir?')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('Güneş yılına göre düenlenmiş olan takvimin adı nedir?', 'Rumi', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = ' 8850 metre yüksekliğinde dünyanın en yüksek dağı olarak bilinen dağın adı nedir?')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('8850 metre yüksekliğinde dünyanın en yüksek dağı olarak bilinen dağın adı nedir?', 'Everest', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = 'Avrupa Birliği nin dönem başkanının süresi ne kadardır?')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('Avrupa Birliği nin dönem başkanının süresi kaç aydır?', '6', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = 'Hilal-i Ahmer in bugünkü adı nedir?')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('Hilal-i Ahmer in bugünkü adı nedir?', 'Kızılay', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = 'Orta Çağ Avrupası nda kahraman kabul edilen kişilere ne isim verilir?')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('Orta Çağ Avrupası nda kahraman kabul edilen kişilere ne isim verilir?', 'Şövalye', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = 'Tek kişinin mutlak yönetimine ne denir?')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('Tek kişinin mutlak yönetimine ne denir?', 'Monarşi', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = 'Günümüzde nüfusu en fazla olan İslam ülkesi hangisidir? ')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('Günümüzde nüfusu en fazla olan İslam ülkesi hangisidir? ', 'Endonezya', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = 'Bakü hangi devletin başkentidir? ')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('Bakü hangi devletin başkentidir? ', 'Azerbaycan', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = 'Hollanda’nın başkenti nedir? ')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('Hollanda’nın başkenti nedir?', 'Amsterdam', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = 'Kaç yılda bir Şubat ayı 29 çeker? ')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('Kaç yılda bir Şubat ayı 29 çeker?', '4', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = 'Bir Gün Kaç Saniyedir? ')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('Bir Gün Kaç Saniyedir? ', '86400', 0, GETDATE())\nif not exists(select soru from _SoruCevap where Soru = 'Aspirinin Hammaddesi Nedir? ')\ninsert into _SoruCevap(Soru, Cevap, Soruldumu, SorulduguTarih) values('Aspirinin Hammaddesi Nedir? ', 'Söğüt', 0, GETDATE())\nend\n\nGO\n\nSET ANSI_PADDING OFF\nGO\n\n\n"
          }
        })
        {
          *(sbyte*) ((IntPtr) voidPtr + 13) = (sbyte) !Class73.smethod_67(strArray[0]);
          if (*(sbyte*) ((IntPtr) voidPtr + 13) != (sbyte) 0)
            Class73.smethod_234(strArray[1], true);
        }
        Form1.smethod_1("Prosedür Oluşturuldu ==> __SoruCevap", Color.LightCyan);
      }
      *(sbyte*) ((IntPtr) voidPtr + 14) = (sbyte) (string_1.ToString() == "__Etkinlik_Takvimi");
      if (*(sbyte*) ((IntPtr) voidPtr + 14) != (sbyte) 0)
      {
        foreach (string[] strArray in new List<string[]>()
        {
          new string[2]
          {
            "__Etkinlik_Takvimi",
            "\nUSE [My_EventBot]\nGO\n/****** Object:  StoredProcedure [dbo].[__Etkinlik_Takvimi]    Script Date: 04.01.2017 20:11:13 ******/\nSET ANSI_NULLS ON\nGO\nSET QUOTED_IDENTIFIER ON\nGO\n-- =============================================\n-- Author:\t\t<Bu prosedür MEHMET YILDIZ (facebook.com/mhmt3606) tarafından My_EventBot programı için hazırlanmıştır.>\n-- Create date: <11.06.2017>\n-- Description:\t<My_EventBot>\n-- =============================================\n\nCreate Procedure [dbo].[__Etkinlik_Takvimi]\n@Etkinlik_Ismi varchar(50),\n@Yapılacak_Islem varchar(50),\n@Tarih varchar(100)\n WITH ENCRYPTION\nAS\nif(@Yapılacak_Islem = 'ekle')\ninsert into _Etkinlik_Takvimi(Etkinlik,Etkinlik_Tarihi) values (@Etkinlik_Ismi,@Tarih)\nif(@Yapılacak_Islem = 'sil')\ndelete _Etkinlik_Takvimi where Etkinlik_Tarihi = @Tarih and Etkinlik=@Etkinlik_Ismi\nGO\n\nSET ANSI_PADDING OFF\nGO\n\n\n"
          }
        })
        {
          *(sbyte*) ((IntPtr) voidPtr + 15) = (sbyte) !Class73.smethod_67(strArray[0]);
          if (*(sbyte*) ((IntPtr) voidPtr + 15) != (sbyte) 0)
            Class73.smethod_234(strArray[1], true);
        }
        Form1.smethod_1("Prosedür Oluşturuldu ==> __Etkinlik_Takvimi", Color.LightCyan);
      }
      *(sbyte*) ((IntPtr) voidPtr + 16) = (sbyte) (string_1.ToString() == "__Hayatta_Kal");
      if (*(sbyte*) ((IntPtr) voidPtr + 16) != (sbyte) 0)
      {
        foreach (string[] strArray in new List<string[]>()
        {
          new string[2]
          {
            "__Hayatta_Kal",
            "\nUSE [My_EventBot]\nGO\n/****** Object:  StoredProcedure [dbo].[__Hayatta_Kal]    Script Date: 04.01.2017 20:11:13 ******/\nSET ANSI_NULLS ON\nGO\nSET QUOTED_IDENTIFIER ON\nGO\n-- =============================================\n-- Author:\t\t<Bu prosedür MEHMET YILDIZ (facebook.com/mhmt3606) tarafından My_EventBot programı için hazırlanmıştır.>\n-- Create date: <11.06.2017>\n-- Description:\t<My_EventBot>\n-- =============================================\n\nCreate Procedure [dbo].[__Hayatta_Kal]\n @CharName varchar(100),\n @Islem varchar(50)\n --WITH ENCRYPTION\nas\ndeclare @CurLevel int = (select CurLevel from SRO_VT_SHARD.._Char where CharName16 = @CharName)\r\ndeclare @SuitSLotID int= (select ItemID from SRO_VT_SHARD.._Inventory where Slot =8 and CharID = (select CharID from SRO_VT_SHARD.._Char where CharName16=@CharName))\r\ndeclare @CharID int = (select CharID from SRO_VT_SHARD.._Char where CharName16 = @CharName)\r\n\nif(@Islem = 'PKEKLE')\nbegin\n update SRO_VT_SHARD.._Char set PKPenaltyPoint =199 where CharName16 = @CharName\n if not exists (select CharName from My_EventBot.._Hayatta_Kal where CharName = @CharName )\n begin\n insert into My_EventBot.._Hayatta_Kal(CharName,Durum,Toplam_Öldürme) values (@CharName+'','İcerde',0)\n end\n update My_EventBot.._HayattaKal_List set Asama='ICERDE', Durum = 'ICERDE' WHERE CharName16=@CharName\n\tend\n if(@Islem = 'PKSİL')\n begin\n update SRO_VT_SHARD.._Char set PKPenaltyPoint =0,DailyPK = 0,TotalPK =0,TelRegion=24233,TelPosX=1281,TelPosY=36.74564,TelPosZ=423,DiedRegion=24233,DiedPosX=1281,DiedPosY=36.74564,DiedPosZ=423,WorldID=1,TelWorldID=1,DiedWorldID=1 where CharName16 = @CharName\ndelete My_EventBot.._Hayatta_Kal where CharName = @CharName\ndelete My_EventBot.._HayattaKal_List where CharName16 = @CharName\nend\nif(@Islem = 'TABEKLE')\nbegin\nif not exists (select CharName16 from My_EventBot.._HayattaKal_List where CharName16 = @CharName)\ninsert into My_EventBot.._HayattaKal_List(CharName16,Asama,Durum) values (@CharName,'KAYIT','KAYIT')\nelse\nupdate My_EventBot.._HayattaKal_List set Asama='KAYIT',Durum='KAYIT' WHERE CharName16 = @CharName\nend\nif(@Islem = 'LVL_KONTROL')\r\nbegin\r\ndeclare @charLevel int select @charLevel = CurLevel from SRO_VT_SHARD.._Char where CharName16 = @CharName\r\nselect @charLevel,@SuitSLotID\t\r\nend\n\nGO\n\nSET ANSI_PADDING OFF\nGO\n\n\n"
          }
        })
        {
          *(sbyte*) ((IntPtr) voidPtr + 17) = (sbyte) !Class73.smethod_67(strArray[0]);
          if (*(sbyte*) ((IntPtr) voidPtr + 17) != (sbyte) 0)
            Class73.smethod_234(strArray[1], true);
        }
        Form1.smethod_1("Prosedür Oluşturuldu ==> __Hayatta_Kal", Color.LightCyan);
      }
      *(sbyte*) ((IntPtr) voidPtr + 18) = (sbyte) (string_1.ToString() == "_UKesIDGetır");
      if (*(sbyte*) ((IntPtr) voidPtr + 18) != (sbyte) 0)
      {
        foreach (string[] strArray in new List<string[]>()
        {
          new string[2]
          {
            "_UKesIDGetır",
            "\nUSE [My_EventBot]\nGO\n/****** Object:  StoredProcedure [dbo].[_UKesIDGetır]    Script Date: 04.01.2017 20:11:13 ******/\nSET ANSI_NULLS ON\nGO\nSET QUOTED_IDENTIFIER ON\nGO\n-- =============================================\n-- Author:\t\t<Bu prosedür MEHMET YILDIZ (facebook.com/mhmt3606) tarafından My_EventBot programı için hazırlanmıştır.>\n-- Create date: <11.06.2017>\n-- Description:\t<My_EventBot>\n-- =============================================\n\nCreate Procedure [dbo].[_UKesIDGetır]\n@görev varchar(50),\n@CodeName128 varchar(250),\n@Bölgeİsmi varchar(50)\n WITH ENCRYPTION\nas\nif(@görev = 'MobID')\nbegin\ndeclare @ID int\nif exists (select ID from SRO_VT_SHARD.._RefObjCommon where CodeName128 =@CodeName128)\nbegin \nset @ID =(select ID from SRO_VT_SHARD.._RefObjCommon where CodeName128 =@CodeName128)\nselect @ID\nend\nelse if not exists(select ID from SRO_VT_SHARD.._RefObjCommon where CodeName128 =@CodeName128)\nbegin\nselect 'Gönderilen Codename128 e ait ID bulunamadı. CodeName128 ='+@CodeName128\nend\nend\nif(@görev = 'RegID')\nbegin\nDECLARE @ChID int select @ChID=CharID from SRO_VT_SHARD.._Char where CharName16 ='My_EventBot'\ndeclare @strPOS varchar(50) = (select TOP(1) EventPos from SRO_VT_LOG.._LogEventChar where EventID=9 and CharID =@ChID order by EventTime DESC)\nif(@strPOS like '%'+@Bölgeİsmi+'%')\nselect 'var'\nelse\nselect 'yok'\nend\nif(@görev = 'Sil')\ndelete SRO_VT_LOG.._LogEventChar where CharID = @ChID and EventID = 9\n\n\n\nGO\n\nSET ANSI_PADDING OFF\nGO\n\n\n"
          }
        })
        {
          *(sbyte*) ((IntPtr) voidPtr + 19) = (sbyte) !Class73.smethod_67(strArray[0]);
          if (*(sbyte*) ((IntPtr) voidPtr + 19) != (sbyte) 0)
            Class73.smethod_234(strArray[1], true);
        }
        Form1.smethod_1("Prosedür Oluşturuldu ==> _UKesIDGetır", Color.LightCyan);
      }
      *(sbyte*) ((IntPtr) voidPtr + 20) = (sbyte) (string_1.ToString() == "__PlusLog");
      if (*(sbyte*) ((IntPtr) voidPtr + 20) != (sbyte) 0)
      {
        foreach (string[] strArray in new List<string[]>()
        {
          new string[2]
          {
            "[__PlusLog]",
            "\nUSE [My_EventBot]\nGO\n/****** Object:  StoredProcedure [dbo].[[__PlusLog]]    Script Date: 04.01.2017 20:11:13 ******/\nSET ANSI_NULLS ON\nGO\nSET QUOTED_IDENTIFIER ON\nGO\n-- =============================================\n-- Author:\t\t<Bu prosedür MEHMET YILDIZ (facebook.com/mhmt3606) tarafından My_EventBot programı için hazırlanmıştır.>\n-- Create date: <11.06.2017>\n-- Description:\t<My_EventBot>\n-- =============================================\n\nCreate Procedure [dbo].[__PlusLog]\n@ItemID int\n WITH ENCRYPTION\nas\ndeclare @ID varchar(25) = (Select top(1) ID from My_EventBot.._PlusLog where Durum=0 and ItemID = @ItemID order by Plus DESC) \ndeclare @CharName varchar(250) = (Select top(1) CharName16 from My_EventBot.._PlusLog where ID=@ID)\ndeclare @Plus int  = (Select top(1) Plus from My_EventBot.._PlusLog where ID=@ID)\nupdate My_EventBot.._PlusLog set Durum = 1 where CharName16 = @CharName and ID=@ID\nif(@CharName != 'NULL')\nselect @CharName,@Plus\nelse\nselect 'SonucYok','SonucYok'\n\nGO\n\nSET ANSI_PADDING OFF\nGO\n\n\n"
          }
        })
        {
          *(sbyte*) ((IntPtr) voidPtr + 21) = (sbyte) !Class73.smethod_67(strArray[0]);
          if (*(sbyte*) ((IntPtr) voidPtr + 21) != (sbyte) 0)
            Class73.smethod_234(strArray[1], true);
        }
        Form1.smethod_1("Prosedür Oluşturuldu ==> [__PlusLog]", Color.LightCyan);
      }
      *(sbyte*) ((IntPtr) voidPtr + 22) = (sbyte) (string_1.ToString() == "__Pıyango");
      if (*(sbyte*) ((IntPtr) voidPtr + 22) == (sbyte) 0)
        return;
      foreach (string[] strArray in new List<string[]>()
      {
        new string[2]
        {
          "[__Pıyango]",
          "\nUSE [My_EventBot]\nGO\n/****** Object:  StoredProcedure [dbo].[__Pıyango]]    Script Date: 04.01.2017 20:11:13 ******/\nSET ANSI_NULLS ON\nGO\nSET QUOTED_IDENTIFIER ON\nGO\n-- =============================================\n-- Author:\t\t<Bu prosedür MEHMET YILDIZ (facebook.com/mhmt3606) tarafından My_EventBot programı için hazırlanmıştır.>\n-- Create date: <11.06.2017>\n-- Description:\t<My_EventBot>\n-- =============================================\n\nCREATE PROCEDURE [dbo].[__Pıyango]\n@Islem varchar(50),\n@Charname varchar(100),\n@OyunTuru varchar(25),\n@KatılımMıktarı bigint\nAS\nif(@Islem = 'Kontrol')\nbegin\ndeclare @MevcutMıktar bigint\ndeclare @CharID int \ndeclare @AccJID int\nset @CharID = (Select CharID from SRO_VT_SHARD.._Char where CharName16 = @Charname)\nset @AccJID = (Select UserJID from SRO_VT_SHARD.._User where CharID =@CharID)\nif(@OyunTuru = 'Silk')\nbegin\nif(not exists (Select JID from SRO_VT_ACCOUNT..SK_Silk where JID =@AccJID)) -- \nbegin\ninsert into SRO_VT_ACCOUNT..SK_Silk (JID,silk_own,silk_gift,silk_point) values (@AccJID,0,0,0)\nend\nset @MevcutMıktar = (select Silk_own from SRO_VT_ACCOUNT..SK_Silk where JID = @AccJID)\nif(@MevcutMıktar >= @KatılımMıktarı)\nbegin\nupdate SRO_VT_ACCOUNT..SK_Silk set silk_own = silk_own - @KatılımMıktarı where JID = @AccJID\nif not exists (select CharName from _Piyango where CharName = @Charname)\ninsert into _Piyango (CharName,KatılımUcreti) values (@Charname , @KatılımMıktarı)\nelse if exists (select CharName from _Piyango where CharName = @Charname)\nupdate _Piyango set KatılımUcreti = @KatılımMıktarı where CharName = @Charname\nselect 1\nend\nelse\nselect 0\nend\nif(@OyunTuru = 'Gold')\nbegin\nset @MevcutMıktar = (Select RemainGold from SRO_VT_SHARD.._Char where CharName16 = @Charname)\nif(@MevcutMıktar >= @KatılımMıktarı)\nbegin\nupdate SRO_VT_SHARD.._Char SET RemainGold = RemainGold - @KatılımMıktarı where CharName16 = @Charname\nif not exists (select CharName from _Piyango where CharName = @Charname)\ninsert into _Piyango (CharName,KatılımUcreti) values (@Charname , @KatılımMıktarı)\nelse if exists (select CharName from _Piyango where CharName = @Charname)\nupdate _Piyango set KatılımUcreti = @KatılımMıktarı where CharName = @Charname\nselect 1\nend\nelse\nselect 0\nend\nif(@OyunTuru = 'Sp')\nbegin\nset @MevcutMıktar = (Select RemainSkillPoint from SRO_VT_SHARD.._Char where CharName16 = @Charname)\nif(@MevcutMıktar >= @KatılımMıktarı)\nbegin\nupdate SRO_VT_SHARD.._Char SET RemainSkillPoint = RemainSkillPoint - @KatılımMıktarı where CharName16 = @Charname\nif not exists (select CharName from _Piyango where CharName = @Charname)\ninsert into _Piyango (CharName,KatılımUcreti) values (@Charname , @KatılımMıktarı)\nelse if exists (select CharName from _Piyango where CharName = @Charname)\nupdate _Piyango set KatılımUcreti = @KatılımMıktarı where CharName = @Charname\nselect 1\nend\nelse\nselect 0\nend\nend\nif(@Islem ='Toplam')\nbegin\nDECLARE @snc bigint =(select SUM(KatılımUCreti) from _Piyango)\nif (@snc > 0)\nselect Count(*),SUM(KatılımUCreti) from _Piyango\nelse\nselect (select Count(*) from _Piyango),0 \nend\nif(@Islem = 'Ödül')\nbegin\ndeclare @JID int = (Select UserJID from SRO_VT_SHARD.._User where CharID =(Select CharID from SRO_VT_SHARD.._Char where CharName16 = @Charname))\nDECLARE @tplm bigint = (select SUM(KatılımUCreti) from _Piyango)\nif(@tplm >0) set @tplm=@tplm else set @tplm=0\nif(@OyunTuru ='Silk')\nbegin\nupdate SRO_VT_ACCOUNT.dbo.SK_Silk set silk_own = silk_own + @tplm where JID=@JID\nend\nif(@OyunTuru = 'Gold')\nbegin\nupdate SRO_VT_SHARD.._Char set RemainGold = RemainGold + @tplm where CharName16=@Charname\nend\nif(@OyunTuru = 'Sp')\nbegin\nupdate SRO_VT_SHARD.._Char set RemainSkillPoint = RemainSkillPoint + @tplm where CharName16=@Charname\nend\ndelete _Piyango\nend\n\n\nGO\n\nSET ANSI_PADDING OFF\nGO\n\n\n"
        }
      })
      {
        *(sbyte*) ((IntPtr) voidPtr + 23) = (sbyte) !Class73.smethod_67(strArray[0]);
        if (*(sbyte*) ((IntPtr) voidPtr + 23) != (sbyte) 0)
          Class73.smethod_234(strArray[1], true);
      }
      Form1.smethod_1("Prosedür Oluşturuldu ==> [__Pıyango]", Color.LightCyan);
    }
  }
}
