// Decompiled with Syinea's Decompiler
// Type: ns10.Form1
// Assembly: My_EventBot_ßy_Mehmet_Yıldız_ML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B7172642-DC7D-4477-97BD-E927F8349F37
// Assembly location: C:\Users\Syinea\Downloads\CrackedMyEventBot\CrackedVsroEfsane.exe

using DevExpress.LookAndFeel;
using DevExpress.Utils.Behaviors;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using ns0;
using ns2;
using ns4;
using ns5;
using ns9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ns10
{
  internal sealed class Form1 : XtraForm
  {
    public static Random random_0 = new Random();
    public static List<string> list_0 = new List<string>();
    public static List<string> list_1 = new List<string>();
    public static string string_13 = "s";
    public static string string_14 = "d";
    public static string string_15 = "b";
    public static string string_16 = "+";
    public static string string_17 = "m";
    public static string string_18 = "u";
    public static string string_19 = "f";
    public static int int_1 = 0;
    public static int int_2 = 0;
    public static int int_3 = 0;
    public static int int_4 = 0;
    public static int int_5 = 0;
    public static bool bool_1 = false;
    public static bool bool_2 = false;
    public static string string_20 = "";
    public static int int_10 = 0;
    public static string string_23 = "TR";
    public static Form1 form1_0 = (Form1) null;
    public static string string_25 = "p";
    public static string string_26 = "o";
    public static string string_27 = "l";
    public static string string_28 = "*";
    public static string string_29 = "a";
    public static string string_30 = "b";
    public static string string_31 = "p";
    public static string string_32 = "b";
    public static string string_33 = "h";
    public static string string_34 = "";
    public static string string_35 = "";
    public int int_6 = 0;
    public int int_7 = 0;
    public int int_8 = 0;
    public int int_9 = 0;
    public int int_11 = 0;
    public int int_12 = 0;
    public int int_13 = 0;
    public string string_24 = "";
    private Random random_1 = new Random();
    private int int_14 = 0;
    private int int_15 = 0;
    private int int_16 = 0;
    internal IContainer icontainer_0 = (IContainer) null;
    public static string string_0;
    public static string string_1;
    public static string string_2;
    public static string string_3;
    public static string string_4;
    public static string string_5;
    public static string string_6;
    public static string string_7;
    public static string string_8;
    public static string string_9;
    public static string string_10;
    public static string string_11;
    public static string string_12;
    public bool bool_0;
    public static int int_0;
    public string string_21;
    public string string_22;
    public static long long_0;
    internal RichTextBox richTextBox_0;
    internal GroupControl groupControl_0;
    internal PanelControl panelControl_0;
    public Label label_0;
    public Label label_1;
    public Timer timer_0;
    internal PanelControl panelControl_1;
    internal GroupControl groupControl_1;
    internal TextEdit textEdit_0;
    internal SimpleButton simpleButton_0;
    internal Label label_2;
    internal TextEdit textEdit_1;
    internal TextEdit textEdit_2;
    internal LabelControl labelControl_0;
    internal LabelControl labelControl_1;
    internal LabelControl labelControl_2;
    internal LabelControl labelControl_3;
    internal TextEdit textEdit_3;
    internal TextEdit textEdit_4;
    internal LabelControl labelControl_4;
    internal TextEdit textEdit_5;
    internal LabelControl labelControl_5;
    internal GroupControl groupControl_2;
    internal LabelControl labelControl_6;
    internal LabelControl labelControl_7;
    internal Label label_3;
    internal Label label_4;
    internal Label label_5;
    internal Button button_0;
    internal Button button_1;
    internal SimpleButton simpleButton_1;
    internal TextEdit textEdit_6;
    internal TextEdit textEdit_7;
    internal TextEdit textEdit_8;
    internal LabelControl labelControl_8;
    internal LabelControl labelControl_9;
    internal LabelControl labelControl_10;
    internal GroupControl groupControl_3;
    internal GroupControl groupControl_4;
    internal PanelControl panelControl_2;
    internal Label label_6;
    internal Label label_7;
    internal PanelControl panelControl_3;
    internal GroupControl groupControl_5;
    internal PanelControl panelControl_4;
    public Label label_8;
    public PictureBox pictureBox_0;
    internal Label label_9;
    internal Label label_10;
    public TextEdit textEdit_9;
    internal Label label_11;
    public TextEdit textEdit_10;
    public TextEdit textEdit_11;
    internal GroupControl groupControl_6;
    internal PanelControl panelControl_5;
    public Label label_12;
    public Label label_13;
    internal Label label_14;
    internal Label label_15;
    internal Label label_16;
    internal Label label_17;
    public Button button_2;
    internal Label label_18;
    public TextEdit textEdit_12;
    internal Label label_19;
    internal GroupControl groupControl_7;
    internal PanelControl panelControl_6;
    internal Label label_20;
    internal Label label_21;
    internal Label label_22;
    internal Button button_3;
    internal GroupBox groupBox_0;
    internal GroupBox groupBox_1;
    internal GroupBox groupBox_2;
    internal Label label_23;
    internal Label label_24;
    internal Label label_25;
    public TextBox textBox_0;
    public TextBox textBox_1;
    public TextBox textBox_2;
    public CheckBox checkBox_0;
    internal GroupBox groupBox_3;
    internal Label label_26;
    internal Label label_27;
    internal Label label_28;
    public TextBox textBox_3;
    public TextBox textBox_4;
    public TextBox textBox_5;
    public CheckBox checkBox_1;
    public TextBox textBox_6;
    public TextBox textBox_7;
    internal Label label_29;
    public TextBox textBox_8;
    internal Button button_4;
    internal TextBox textBox_9;
    internal Label label_30;
    internal Label label_31;
    internal GroupBox groupBox_4;
    public CheckBox checkBox_2;
    internal Label label_32;
    internal Button button_5;
    internal Button button_6;
    internal TextBox textBox_10;
    internal GroupBox groupBox_5;
    internal ListBox listBox_0;
    internal ListBox listBox_1;
    internal GroupBox groupBox_6;
    internal GroupBox groupBox_7;
    internal Label label_33;
    internal Label label_34;
    internal Label label_35;
    public TextBox textBox_11;
    public TextBox textBox_12;
    public TextBox textBox_13;
    public CheckBox checkBox_3;
    internal GroupBox groupBox_8;
    internal Label label_36;
    internal Label label_37;
    internal Label label_38;
    public TextBox textBox_14;
    public TextBox textBox_15;
    public TextBox textBox_16;
    public CheckBox checkBox_4;
    internal DateTimePicker dateTimePicker_0;
    internal Label label_39;
    internal Label label_40;
    internal GroupBox groupBox_9;
    public CheckBox checkBox_5;
    internal Label label_41;
    internal GroupBox groupBox_10;
    internal GroupBox groupBox_11;
    public TextBox textBox_17;
    internal Label label_42;
    internal GroupBox groupBox_12;
    internal GroupBox groupBox_13;
    internal Label label_43;
    internal Label label_44;
    internal Label label_45;
    public TextBox textBox_18;
    public TextBox textBox_19;
    public TextBox textBox_20;
    public CheckBox checkBox_6;
    internal GroupBox groupBox_14;
    internal Label label_46;
    internal Label label_47;
    internal Label label_48;
    public TextBox textBox_21;
    public TextBox textBox_22;
    public TextBox textBox_23;
    public CheckBox checkBox_7;
    internal Button button_7;
    internal Button button_8;
    internal TextBox textBox_24;
    internal GroupBox groupBox_15;
    internal ListBox listBox_2;
    internal GroupBox groupBox_16;
    public CheckBox checkBox_8;
    internal Label label_49;
    internal ListBox listBox_3;
    internal DateTimePicker dateTimePicker_1;
    internal Label label_50;
    internal Label label_51;
    internal GroupBox groupBox_17;
    internal GroupBox groupBox_18;
    public System.Windows.Forms.ComboBox comboBox_0;
    internal Label label_52;
    internal Label label_53;
    internal Label label_54;
    public TextBox textBox_25;
    internal Label label_55;
    internal Button button_9;
    internal Button button_10;
    internal TextBox textBox_26;
    internal ListBox listBox_4;
    internal DateTimePicker dateTimePicker_2;
    internal Label label_56;
    internal Label label_57;
    internal GroupBox groupBox_19;
    public CheckBox checkBox_9;
    internal Button button_11;
    internal GroupBox groupBox_20;
    internal GroupBox groupBox_21;
    public TextBox textBox_27;
    internal Label label_58;
    internal Label label_59;
    public TextBox textBox_28;
    internal Label label_60;
    internal Label label_61;
    internal Label label_62;
    internal Label label_63;
    public TextBox textBox_29;
    internal GroupBox groupBox_22;
    internal GroupBox groupBox_23;
    internal Label label_64;
    internal Label label_65;
    internal Label label_66;
    public TextBox textBox_30;
    public TextBox textBox_31;
    public TextBox textBox_32;
    public CheckBox checkBox_10;
    internal GroupBox groupBox_24;
    internal Label label_67;
    internal Label label_68;
    internal Label label_69;
    public TextBox textBox_33;
    public TextBox textBox_34;
    public TextBox textBox_35;
    public CheckBox checkBox_11;
    internal Button button_12;
    internal TextBox textBox_36;
    internal ListBox listBox_5;
    internal DateTimePicker dateTimePicker_3;
    internal Label label_70;
    internal Label label_71;
    internal GroupBox groupBox_25;
    public CheckBox checkBox_12;
    internal Button button_13;
    internal Button button_14;
    internal TextBox textBox_37;
    internal ListBox listBox_6;
    internal DateTimePicker dateTimePicker_4;
    internal Label label_72;
    internal Label label_73;
    internal GroupBox groupBox_26;
    public System.Windows.Forms.ComboBox comboBox_1;
    internal Label label_74;
    internal Label label_75;
    internal Label label_76;
    internal GroupBox groupBox_27;
    public TextBox textBox_38;
    internal Label label_77;
    internal Label label_78;
    public TextBox textBox_39;
    internal GroupBox groupBox_28;
    public CheckBox checkBox_13;
    internal GroupBox groupBox_29;
    internal Label label_79;
    public TextBox textBox_40;
    internal Label label_80;
    public TextBox textBox_41;
    internal GroupBox groupBox_30;
    internal Label label_81;
    internal Label label_82;
    internal Label label_83;
    public TextBox textBox_42;
    public TextBox textBox_43;
    public TextBox textBox_44;
    internal GroupBox groupBox_31;
    internal Label label_84;
    internal Label label_85;
    internal Label label_86;
    public TextBox textBox_45;
    public TextBox textBox_46;
    public TextBox textBox_47;
    public CheckBox checkBox_14;
    internal Button button_15;
    internal Button button_16;
    internal ListBox listBox_7;
    internal DateTimePicker dateTimePicker_5;
    internal Label label_87;
    internal Label label_88;
    public CheckEdit checkEdit_0;
    internal ListBox listBox_8;
    internal Button button_17;
    internal Button button_18;
    internal TextBox textBox_48;
    internal ListBox listBox_9;
    internal DateTimePicker dateTimePicker_6;
    internal Label label_89;
    internal Label label_90;
    internal GroupBox groupBox_32;
    public TextBox textBox_49;
    internal Label label_91;
    public TextBox textBox_50;
    internal Label label_92;
    public TextBox textBox_51;
    internal Label label_93;
    internal GroupControl groupControl_8;
    public TextBox textBox_52;
    internal GroupBox groupBox_33;
    internal GroupBox groupBox_34;
    internal Label label_94;
    internal Label label_95;
    internal Label label_96;
    public TextBox textBox_53;
    public TextBox textBox_54;
    public TextBox textBox_55;
    public CheckBox checkBox_15;
    internal GroupBox groupBox_35;
    internal Label label_97;
    internal Label label_98;
    internal Label label_99;
    public TextBox textBox_56;
    public TextBox textBox_57;
    public TextBox textBox_58;
    public CheckBox checkBox_16;
    public System.Windows.Forms.ComboBox comboBox_2;
    internal GroupBox groupBox_36;
    internal GroupBox groupBox_37;
    internal Label label_100;
    internal Label label_101;
    internal Label label_102;
    public TextBox textBox_59;
    public TextBox textBox_60;
    public TextBox textBox_61;
    public CheckBox checkBox_17;
    internal GroupBox groupBox_38;
    internal Label label_103;
    internal Label label_104;
    internal Label label_105;
    public TextBox textBox_62;
    public TextBox textBox_63;
    public TextBox textBox_64;
    public CheckBox checkBox_18;
    internal TextBox textBox_65;
    internal TextBox textBox_66;
    internal Label label_106;
    internal Label label_107;
    internal Label label_108;
    internal Label label_109;
    internal Label label_110;
    internal Label label_111;
    internal Label label_112;
    internal Label label_113;
    internal Label label_114;
    internal Label label_115;
    internal Label label_116;
    internal Label label_117;
    internal Label label_118;
    internal Label label_119;
    internal Label label_120;
    public Timer timer_1;
    public TextBox textBox_67;
    public TextBox textBox_68;
    public TextBox textBox_69;
    internal Label label_121;
    internal Label label_122;
    internal GroupBox groupBox_39;
    public CheckBox checkBox_19;
    internal GroupBox groupBox_40;
    internal GroupBox groupBox_41;
    internal Label label_123;
    internal Label label_124;
    internal Label label_125;
    public TextBox textBox_70;
    public TextBox textBox_71;
    public TextBox textBox_72;
    internal GroupBox groupBox_42;
    internal Label label_126;
    internal Label label_127;
    internal Label label_128;
    public TextBox textBox_73;
    public TextBox textBox_74;
    public TextBox textBox_75;
    public CheckBox checkBox_20;
    public TextBox textBox_76;
    public Button button_19;
    public ListBox listBox_10;
    public ListBox listBox_11;
    internal TextBox textBox_77;
    internal Label label_129;
    public TextBox textBox_78;
    internal Button button_20;
    internal Button button_21;
    public ListBox listBox_12;
    internal DateTimePicker dateTimePicker_7;
    internal Label label_130;
    internal Label label_131;
    internal GroupBox groupBox_43;
    internal Label label_132;
    internal Label label_133;
    public CheckBox checkBox_21;
    internal Label label_134;
    internal Label label_135;
    public ListBox listBox_13;
    public ListBox listBox_14;
    public Timer timer_2;
    public TextBox textBox_79;
    public TextBox textBox_80;
    public ListBox listBox_15;
    public Button button_22;
    internal Label label_136;
    public TextBox textBox_81;
    internal Label label_137;
    public TextBox textBox_82;
    public TextBox textBox_83;
    internal Label label_138;
    public Label label_139;
    public Button button_23;
    public ListBox listBox_16;
    public CheckBox checkBox_22;
    internal TextBox textBox_84;
    internal GroupBox groupBox_44;
    public TextBox textBox_85;
    internal Label label_140;
    public Button button_24;
    public Timer timer_3;
    public Timer timer_4;
    public TextBox textBox_86;
    internal Panel panel_0;
    internal Label label_141;
    internal Label label_142;
    public Button button_25;
    internal Label label_143;
    public ListBox listBox_17;
    internal PanelControl panelControl_7;
    public Panel panel_1;
    internal Label label_144;
    public TextBox textBox_87;
    public TextBox textBox_88;
    public Timer timer_5;
    public XtraTabControl xtraTabControl_0;
    public XtraTabPage xtraTabPage_0;
    public XtraTabPage xtraTabPage_1;
    public XtraTabPage xtraTabPage_2;
    public XtraTabPage xtraTabPage_3;
    public XtraTabPage xtraTabPage_4;
    public XtraTabPage xtraTabPage_5;
    public XtraTabPage xtraTabPage_6;
    public XtraTabPage xtraTabPage_7;
    public XtraTabPage xtraTabPage_8;
    internal Label label_145;
    public Label label_146;
    internal Label label_147;
    internal TextBox textBox_89;
    internal TextBox textBox_90;
    public CheckBox checkBox_23;
    public CheckBox checkBox_24;
    public CheckBox checkBox_25;
    public TextEdit textEdit_13;
    public TextEdit textEdit_14;
    public TextEdit textEdit_15;
    public TextEdit textEdit_16;
    public TextEdit textEdit_17;
    internal ComboBoxEdit comboBoxEdit_0;
    internal ComboBoxEdit comboBoxEdit_1;
    internal CheckEdit checkEdit_1;
    internal CheckEdit checkEdit_2;
    internal CheckEdit checkEdit_3;
    internal CheckEdit checkEdit_4;
    internal CheckEdit checkEdit_5;
    internal CheckEdit checkEdit_6;
    internal CheckEdit checkEdit_7;
    internal CheckEdit checkEdit_8;
    public CheckEdit checkEdit_9;
    public CheckEdit checkEdit_10;
    internal BehaviorManager behaviorManager_0;
    public TextBox textBox_91;
    internal Label label_148;
    public TextBox textBox_92;
    internal Label label_149;
    public TextBox textBox_93;
    internal Label label_150;
    public TextBox textBox_94;
    internal Label label_151;
    public TextBox textBox_95;
    internal Label label_152;
    public TextBox textBox_96;
    internal Label label_153;
    public TextBox textBox_97;
    internal Label label_154;
    public TextBox textBox_98;
    internal Label label_155;
    internal Button button_26;
    internal Button button_27;
    internal Button button_28;
    internal Button button_29;
    internal Button button_30;
    public Timer timer_6;
    public ListBoxControl listBoxControl_0;
    public ListBoxControl listBoxControl_1;
    internal Label label_156;
    internal Label label_157;
    public Timer timer_7;
    public ComboBoxEdit comboBoxEdit_2;
    internal ListBox listBox_18;
    public TextBox textBox_99;
    internal ListBox listBox_19;
    internal DefaultLookAndFeel defaultLookAndFeel_0;
    internal FormAssistant formAssistant_0;
    internal RibbonPage ribbonPage_0;
    internal Label label_158;
    internal Label label_159;
    public Label label_160;
    public Label label_161;
    internal Label label_162;
    public Label label_163;
    internal Label label_164;
    public Timer timer_8;
    public TextBox textBox_100;
    public Timer timer_9;
    internal Label label_165;
    public Timer timer_10;
    public ListBox listBox_20;
    internal GroupControl groupControl_9;
    public TextBox textBox_101;
    internal PanelControl panelControl_8;
    internal ListView listView_0;
    internal ColumnHeader columnHeader_0;
    internal ColumnHeader columnHeader_1;
    internal ColumnHeader columnHeader_2;
    internal GroupBox groupBox_45;
    internal Label label_166;
    internal Label label_167;
    internal Label label_168;
    internal Label label_169;
    internal Button button_31;
    internal Button button_32;
    public Label label_170;
    public Timer timer_11;
    public ComboBoxEdit comboBoxEdit_3;
    internal DateTimePicker dateTimePicker_8;
    internal ComboBoxEdit comboBoxEdit_4;
    internal ComboBoxEdit comboBoxEdit_5;
    internal ComboBoxEdit comboBoxEdit_6;
    internal ComboBoxEdit comboBoxEdit_7;
    internal ComboBoxEdit comboBoxEdit_8;
    internal ComboBoxEdit comboBoxEdit_9;
    internal ComboBoxEdit comboBoxEdit_10;
    internal ComboBoxEdit comboBoxEdit_11;
    public Timer timer_12;
    public Label label_171;
    internal ListBox listBox_21;
    internal Button button_33;
    public CheckBox checkBox_26;
    internal Panel panel_2;
    internal XtraTabPage xtraTabPage_9;
    internal ComboBoxEdit comboBoxEdit_12;
    public CheckBox checkBox_27;
    internal Button button_34;
    internal Button button_35;
    internal TextBox textBox_102;
    internal ListBox listBox_22;
    internal DateTimePicker dateTimePicker_9;
    internal Label label_172;
    internal Label label_173;
    internal GroupBox groupBox_46;
    internal Label label_174;
    public TextBox textBox_103;
    internal ComboBoxEdit comboBoxEdit_13;
    internal Button button_36;
    public CheckBox checkBox_28;
    internal Label label_175;
    public ListBox listBox_23;
    internal CheckEdit checkEdit_11;
    internal Label label_176;
    internal Button button_37;
    internal ContextMenuStrip contextMenuStrip_0;
    internal ToolStripMenuItem toolStripMenuItem_0;
    internal TextEdit textEdit_18;

    public Form1()
    {
      Class73.smethod_40(this);
      Form1.form1_0 = this;
    }

    public void method_0(object sender, EventArgs e)
    {
      Form1.Class33 stateMachine = new Form1.Class33();
      stateMachine.form1_0 = this;
      stateMachine.object_0 = sender;
      stateMachine.eventArgs_0 = e;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class33>(ref stateMachine);
    }

    public void method_1()
    {
      Form1.Class34 stateMachine = new Form1.Class34();
      stateMachine.form1_0 = this;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class34>(ref stateMachine);
    }

    public static void smethod_0(string string_36)
    {
      Form1.Class35 class35 = new Form1.Class35();
      class35.string_0 = string_36;
      Form1.form1_0.Invoke((Delegate) new MethodInvoker(class35.method_0));
      try
      {
        StreamWriter streamWriter = new StreamWriter((Stream) new FileStream("Log.ini", FileMode.OpenOrCreate, FileAccess.Write));
        streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
        streamWriter.WriteLine("[" + DateTime.Now.ToString() + "]");
        streamWriter.WriteLine(class35.string_0);
        streamWriter.Close();
      }
      catch
      {
      }
    }

    public static void smethod_1(string string_36, Color color_0)
    {
      Form1.Class36 class36 = new Form1.Class36();
      class36.string_0 = string_36;
      class36.color_0 = color_0;
      Form1.form1_0.Invoke((Delegate) new MethodInvoker(class36.method_0));
      try
      {
        StreamWriter streamWriter = new StreamWriter((Stream) new FileStream("Log.ini", FileMode.OpenOrCreate, FileAccess.Write));
        streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
        streamWriter.WriteLine("[" + DateTime.Now.ToString() + "]");
        streamWriter.WriteLine(class36.string_0);
        streamWriter.Close();
      }
      catch
      {
      }
    }

    internal unsafe void method_2(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      *(sbyte*) voidPtr = (sbyte) (this.label_160.Text != "ONLİNE");
      if (*(sbyte*) voidPtr != (sbyte) 0)
      {
        try
        {
          Class25.smethod_0(Form1.form1_0.textEdit_17.Text, Convert.ToUInt16(Form1.form1_0.textBox_89.Text), 9999U, 22U, Form1.form1_0.textEdit_16.Text, Form1.form1_0.textEdit_15.Text, Form1.form1_0.textBox_90.Text, Form1.form1_0.textEdit_18.Text);
        }
        catch
        {
          Form1.smethod_0("Bot oyuna baglanırken bir hata olustu. Lütfen Port adresinizi dogru yazdıgınıza emin olun.!!");
        }
      }
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (this.label_160.Text == "ONLİNE");
      if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
        Form1.smethod_0("Karakter zaten oyunda");
      if ((!(this.label_163.Text == "ONLİNE") || !(this.label_161.Text == "ONLİNE") ? 0 : (this.label_160.Text == "OFFLİNE" ? 1 : 0)) == 0)
        return;
      Class73.smethod_251(false, "Manuel");
    }

    public static void smethod_2()
    {
      Form1.Class38 stateMachine = new Form1.Class38();
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class38>(ref stateMachine);
    }

    public static void smethod_3()
    {
      Form1.Class39 stateMachine = new Form1.Class39();
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class39>(ref stateMachine);
    }

    public void method_3()
    {
      Form1.Class40 stateMachine = new Form1.Class40();
      stateMachine.form1_0 = this;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class40>(ref stateMachine);
    }

    public void method_4()
    {
      Form1.Class41 stateMachine = new Form1.Class41();
      stateMachine.form1_0 = this;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class41>(ref stateMachine);
    }

    public void method_5()
    {
      Form1.Class42 stateMachine = new Form1.Class42();
      stateMachine.form1_0 = this;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class42>(ref stateMachine);
    }

    public void method_6(int int_17)
    {
      Form1.Class43 stateMachine = new Form1.Class43();
      stateMachine.form1_0 = this;
      stateMachine.int_1 = int_17;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class43>(ref stateMachine);
    }

    public void method_7()
    {
      Form1.Class44 stateMachine = new Form1.Class44();
      stateMachine.form1_0 = this;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class44>(ref stateMachine);
    }

    public void method_8()
    {
      Form1.Class45 stateMachine = new Form1.Class45();
      stateMachine.form1_0 = this;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class45>(ref stateMachine);
    }

    public void method_9(int int_17)
    {
      Form1.Class46 stateMachine = new Form1.Class46();
      stateMachine.form1_0 = this;
      stateMachine.int_1 = int_17;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class46>(ref stateMachine);
    }

    public void method_10(int int_17)
    {
      Form1.Class47 stateMachine = new Form1.Class47();
      stateMachine.form1_0 = this;
      stateMachine.int_1 = int_17;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class47>(ref stateMachine);
    }

    public void method_11()
    {
      Form1.Class48 stateMachine = new Form1.Class48();
      stateMachine.form1_0 = this;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class48>(ref stateMachine);
    }

    public void method_12()
    {
      Form1.Class49 stateMachine = new Form1.Class49();
      stateMachine.form1_0 = this;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class49>(ref stateMachine);
    }

    public static void smethod_4(string string_36)
    {
      Form1.Class50 stateMachine = new Form1.Class50();
      stateMachine.string_0 = string_36;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class50>(ref stateMachine);
    }

    public static unsafe void smethod_5()
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(46);
      *(int*) voidPtr = (int) Convert.ToInt16(Form1.form1_0.textBox_67.Text);
      List<int> intList = new List<int>();
      List<int> source = new List<int>();
      *(int*) ((IntPtr) voidPtr + 4) = 0;
      *(int*) ((IntPtr) voidPtr + 8) = 0;
      Form1.form1_0.listBox_8.Items.Clear();
      try
      {
        SqlDataReader sqlDataReader = new SqlCommand("select * from My_EventBot.._Sayı_Bul", Class65.sqlConnection_0).ExecuteReader();
        string str;
        do
        {
          *(sbyte*) ((IntPtr) voidPtr + 37) = (sbyte) sqlDataReader.Read();
          if (*(sbyte*) ((IntPtr) voidPtr + 37) != (sbyte) 0)
          {
            *(int*) ((IntPtr) voidPtr + 16) = Convert.ToInt32(sqlDataReader["Tahmin"].ToString());
            str = Convert.ToString(sqlDataReader["CharName16"].ToString());
            intList.Add(*(int*) ((IntPtr) voidPtr + 16));
            Form1.form1_0.listBox_8.Items.Add((object) *(int*) ((IntPtr) voidPtr + 16));
            *(sbyte*) ((IntPtr) voidPtr + 36) = (sbyte) (*(int*) ((IntPtr) voidPtr + 16) == *(int*) voidPtr);
          }
          else
            goto label_6;
        }
        while (*(sbyte*) ((IntPtr) voidPtr + 36) == (sbyte) 0);
        Form1.form1_0.textBox_68.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 16));
        Form1.form1_0.textBox_69.Text = str ?? "";
        Form1.smethod_0("En yakin sayi = " + (object) *(int*) ((IntPtr) voidPtr + 16));
        return;
      }
      catch (Exception ex)
      {
        Form1.smethod_0("Tahminler veritabanından çekilemedi!!! Hata => " + ex.Message);
      }
label_6:
      foreach (int num in intList)
      {
        *(int*) ((IntPtr) voidPtr + 20) = num;
        *(sbyte*) ((IntPtr) voidPtr + 38) = (sbyte) (*(int*) ((IntPtr) voidPtr + 20) > *(int*) voidPtr);
        if (*(sbyte*) ((IntPtr) voidPtr + 38) != (sbyte) 0)
          *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 20) - *(int*) voidPtr;
        *(sbyte*) ((IntPtr) voidPtr + 39) = (sbyte) (*(int*) ((IntPtr) voidPtr + 20) < *(int*) voidPtr);
        if (*(sbyte*) ((IntPtr) voidPtr + 39) != (sbyte) 0)
          *(int*) ((IntPtr) voidPtr + 4) = *(int*) voidPtr - *(int*) ((IntPtr) voidPtr + 20);
        source.Add(*(int*) ((IntPtr) voidPtr + 4));
        *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) + 1;
      }
      *(int*) ((IntPtr) voidPtr + 12) = 0;
      *(sbyte*) ((IntPtr) voidPtr + 40) = (sbyte) (source.Count > 0);
      if (*(sbyte*) ((IntPtr) voidPtr + 40) != (sbyte) 0)
      {
        *(int*) ((IntPtr) voidPtr + 12) = source.Min();
      }
      else
      {
        *(sbyte*) ((IntPtr) voidPtr + 41) = (sbyte) (source.Count <= 0);
        if (*(sbyte*) ((IntPtr) voidPtr + 41) != (sbyte) 0)
          ;
      }
      *(sbyte*) ((IntPtr) voidPtr + 42) = (sbyte) (intList.Count > 0);
      if (*(sbyte*) ((IntPtr) voidPtr + 42) != (sbyte) 0)
      {
        foreach (int num in intList)
        {
          *(int*) ((IntPtr) voidPtr + 24) = num;
          *(sbyte*) ((IntPtr) voidPtr + 43) = (sbyte) (*(int*) voidPtr + *(int*) ((IntPtr) voidPtr + 12) == *(int*) ((IntPtr) voidPtr + 24));
          if (*(sbyte*) ((IntPtr) voidPtr + 43) != (sbyte) 0)
          {
            Class32.list_2.Add(*(int*) ((IntPtr) voidPtr + 24));
            try
            {
              SqlDataReader sqlDataReader = new SqlCommand("select*from My_EventBot.._Sayı_Bul where Tahmin =" + (object) *(int*) ((IntPtr) voidPtr + 24) + " order by Tarih", Class65.sqlConnection_0).ExecuteReader();
              sqlDataReader.Read();
              *(int*) ((IntPtr) voidPtr + 28) = (int) Convert.ToUInt16(sqlDataReader["Tahmin"]);
              string str = Convert.ToString(sqlDataReader["CharName16"]);
              Form1.form1_0.textBox_68.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 28));
              Form1.form1_0.textBox_69.Text = str ?? "";
              Form1.smethod_0("En yakin sayi = " + (object) *(int*) ((IntPtr) voidPtr + 28));
            }
            catch (Exception ex)
            {
              Form1.smethod_0("En Yakın tahmin alınamadı!! Hata => " + ex.Message);
            }
          }
          *(sbyte*) ((IntPtr) voidPtr + 44) = (sbyte) (*(int*) voidPtr - *(int*) ((IntPtr) voidPtr + 12) == *(int*) ((IntPtr) voidPtr + 24));
          if (*(sbyte*) ((IntPtr) voidPtr + 44) != (sbyte) 0)
          {
            Class32.list_2.Add(*(int*) ((IntPtr) voidPtr + 24));
            try
            {
              SqlDataReader sqlDataReader = new SqlCommand("select*from My_EventBot.._Sayı_Bul where Tahmin =" + (object) *(int*) ((IntPtr) voidPtr + 24) + " order by Tarih", Class65.sqlConnection_0).ExecuteReader();
              sqlDataReader.Read();
              *(int*) ((IntPtr) voidPtr + 32) = (int) Convert.ToUInt16(sqlDataReader["Tahmin"]);
              string str = Convert.ToString(sqlDataReader["CharName16"]);
              Form1.form1_0.textBox_68.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 32));
              Form1.form1_0.textBox_69.Text = str ?? "";
              Form1.smethod_0("En yakin syi = " + (object) *(int*) ((IntPtr) voidPtr + 32));
            }
            catch (Exception ex)
            {
              Form1.smethod_0("En Yakın tahmin alınamadı!! Hata => " + ex.Message);
            }
          }
        }
      }
      else
      {
        *(sbyte*) ((IntPtr) voidPtr + 45) = (sbyte) (intList.Count <= 0);
        if (*(sbyte*) ((IntPtr) voidPtr + 45) == (sbyte) 0)
          return;
        Form1.smethod_0("Hiç Tahmin Bulunamadı...!");
      }
    }

    public void method_13(string string_36)
    {
      Form1.Class51 stateMachine = new Form1.Class51();
      stateMachine.form1_0 = this;
      stateMachine.string_0 = string_36;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class51>(ref stateMachine);
    }

    public void method_14()
    {
      Form1.Class52 stateMachine = new Form1.Class52();
      stateMachine.form1_0 = this;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class52>(ref stateMachine);
    }

    public void method_15()
    {
      Form1.Class53 stateMachine = new Form1.Class53();
      stateMachine.form1_0 = this;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class53>(ref stateMachine);
    }

    public void method_16()
    {
      Form1.Class54 stateMachine = new Form1.Class54();
      stateMachine.form1_0 = this;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class54>(ref stateMachine);
    }

    public void method_17()
    {
      Form1.Class55 stateMachine = new Form1.Class55();
      stateMachine.form1_0 = this;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class55>(ref stateMachine);
    }

    public void method_18()
    {
      Form1.Class56 stateMachine = new Form1.Class56();
      stateMachine.form1_0 = this;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class56>(ref stateMachine);
    }

    public void method_19()
    {
      Form1.Class57 stateMachine = new Form1.Class57();
      stateMachine.form1_0 = this;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class57>(ref stateMachine);
    }

    internal unsafe void method_20(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      *(sbyte*) voidPtr = (sbyte) this.checkBox_1.Checked;
      if (*(sbyte*) voidPtr != (sbyte) 0)
        this.groupBox_2.Enabled = true;
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) !this.checkBox_1.Checked;
      if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
        return;
      this.groupBox_2.Enabled = false;
    }

    internal unsafe void method_21(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      *(sbyte*) voidPtr = (sbyte) this.checkBox_0.Checked;
      if (*(sbyte*) voidPtr != (sbyte) 0)
        this.groupBox_3.Enabled = true;
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) !this.checkBox_0.Checked;
      if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
        return;
      this.groupBox_3.Enabled = false;
    }

    internal unsafe void method_22(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      if ((Class65.sqlConnection_0 == null || !(this.comboBoxEdit_3.Text != "") || (!(this.comboBoxEdit_3.Text != "Gün Seçin") || !(this.comboBoxEdit_2.Text != "")) || !(this.comboBoxEdit_2.Text != "Etkinlik Bölgesi Seçin") ? 0 : (this.listBoxControl_0.Items.Count > 0 ? 1 : 0)) != 0)
      {
        try
        {
          string str = this.comboBoxEdit_3.Text + " Saat :" + this.dateTimePicker_8.Text;
          this.listBox_10.Items.Add((object) str);
          new SqlCommand("exec My_EventBot..__Etkinlik_Takvimi 'Unique_Kesme','ekle','" + str + "'", Class65.sqlConnection_0).ExecuteNonQuery();
          Form1.smethod_0("Liste ve veritabanına eklendi :   " + str);
        }
        catch (Exception ex)
        {
          *(sbyte*) voidPtr = (sbyte) (Class65.sqlConnection_0 == null);
          if (*(sbyte*) voidPtr != (sbyte) 0)
            Form1.smethod_0("SQL bağlantısı kapalı olduğundan işlem gerçekleştirilemedi.!!");
          else
            Form1.smethod_0("Etkinlik tarihini veritabanına eklerken bir hata oluştu. Açıklama ==> " + (object) ex);
        }
      }
      else if ((Class65.sqlConnection_0 != null || !(this.comboBoxEdit_3.Text != "") || (!(this.comboBoxEdit_3.Text != "Gün Seçin") || !(this.comboBoxEdit_2.Text != "")) || !(this.comboBoxEdit_2.Text != "Etkinlik Bölgesi Seçin") ? 0 : (this.listBoxControl_0.Items.Count > 0 ? 1 : 0)) != 0)
        Form1.smethod_0("SQL bağlantısı kapalı olduğundan işlem gerçekleştirilemedi.!!");
      if ((this.comboBoxEdit_2.Text == "" ? 1 : (this.comboBoxEdit_2.Text == "Etkinlik Bölgesi Seçin" ? 1 : 0)) != 0)
        Form1.smethod_1("Event Bölgesi Seçilmedi  !!!!!", Color.Salmon);
      if ((this.comboBoxEdit_3.Text == "" ? 1 : (this.comboBoxEdit_3.Text == "Gün Seçin" ? 1 : 0)) != 0)
        Form1.smethod_1("Event Günü Seçilmedi  !!!!!", Color.Salmon);
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (this.listBoxControl_0.Items.Count <= 0);
      if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
        return;
      Form1.smethod_1("Etkinlik için hiç unique seçilmedi. !!!", Color.Salmon);
      int num = (int) MessageBox.Show("Etkinlik için hiç unique seçilmedi. !!!");
    }

    internal unsafe void method_23(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(27);
      Process.GetCurrentProcess();
      LabelControl labelControl6 = this.labelControl_6;
      *(int*) voidPtr = Process.GetCurrentProcess().Threads.Count;
      string str1 = ((int*) voidPtr)->ToString();
      labelControl6.Text = str1;
      string longTimeString = DateTime.Now.ToLongTimeString();
      this.label_0.Text = longTimeString;
      string dayName = new CultureInfo("tr-TR").DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
      this.label_1.Text = dayName;
      this.textBox_86.Text = dayName + " Saat :" + longTimeString;
      TextBox textBox9 = this.textBox_9;
      *(sbyte*) ((IntPtr) voidPtr + 16) = (sbyte) this.listBox_10.Items.Contains((object) this.textBox_86.Text);
      string str2 = ((bool*) ((IntPtr) voidPtr + 16))->ToString();
      textBox9.Text = str2;
      *(sbyte*) ((IntPtr) voidPtr + 17) = (sbyte) (this.listBox_10.FindString(this.textBox_86.Text) != -1);
      if (*(sbyte*) ((IntPtr) voidPtr + 17) != (sbyte) 0)
        this.method_3();
      TextBox textBox10 = this.textBox_10;
      *(sbyte*) ((IntPtr) voidPtr + 16) = (sbyte) this.listBox_11.Items.Contains((object) this.textBox_86.Text);
      string str3 = ((bool*) ((IntPtr) voidPtr + 16))->ToString();
      textBox10.Text = str3;
      *(sbyte*) ((IntPtr) voidPtr + 18) = (sbyte) (this.listBox_11.FindString(this.textBox_86.Text) != -1);
      if (*(sbyte*) ((IntPtr) voidPtr + 18) != (sbyte) 0)
        this.method_4();
      TextBox textBox24 = this.textBox_24;
      *(sbyte*) ((IntPtr) voidPtr + 16) = (sbyte) this.listBox_3.Items.Contains((object) this.textBox_86.Text);
      string str4 = ((bool*) ((IntPtr) voidPtr + 16))->ToString();
      textBox24.Text = str4;
      *(sbyte*) ((IntPtr) voidPtr + 19) = (sbyte) (this.listBox_3.FindString(this.textBox_86.Text) != -1);
      if (*(sbyte*) ((IntPtr) voidPtr + 19) != (sbyte) 0)
        this.method_7();
      TextBox textBox26 = this.textBox_26;
      *(sbyte*) ((IntPtr) voidPtr + 16) = (sbyte) this.listBox_4.Items.Contains((object) this.textBox_86.Text);
      string str5 = ((bool*) ((IntPtr) voidPtr + 16))->ToString();
      textBox26.Text = str5;
      *(sbyte*) ((IntPtr) voidPtr + 20) = (sbyte) (this.listBox_4.FindString(this.textBox_86.Text) != -1);
      if (*(sbyte*) ((IntPtr) voidPtr + 20) != (sbyte) 0)
        this.method_8();
      TextBox textBox36 = this.textBox_36;
      *(sbyte*) ((IntPtr) voidPtr + 16) = (sbyte) this.listBox_5.Items.Contains((object) this.textBox_86.Text);
      string str6 = ((bool*) ((IntPtr) voidPtr + 16))->ToString();
      textBox36.Text = str6;
      *(sbyte*) ((IntPtr) voidPtr + 21) = (sbyte) (this.listBox_5.FindString(this.textBox_86.Text) != -1);
      if (*(sbyte*) ((IntPtr) voidPtr + 21) != (sbyte) 0)
      {
        *(int*) ((IntPtr) voidPtr + 4) = (int) Convert.ToInt16(this.textBox_28.Text);
        this.method_9(*(int*) ((IntPtr) voidPtr + 4));
      }
      TextBox textBox77 = this.textBox_77;
      *(sbyte*) ((IntPtr) voidPtr + 16) = (sbyte) this.listBox_7.Items.Contains((object) this.textBox_86.Text);
      string str7 = ((bool*) ((IntPtr) voidPtr + 16))->ToString();
      textBox77.Text = str7;
      *(sbyte*) ((IntPtr) voidPtr + 22) = (sbyte) (this.listBox_7.FindString(this.textBox_86.Text) != -1);
      if (*(sbyte*) ((IntPtr) voidPtr + 22) != (sbyte) 0)
      {
        *(int*) ((IntPtr) voidPtr + 8) = (int) Convert.ToInt16(this.textBox_40.Text);
        this.method_10(*(int*) ((IntPtr) voidPtr + 8));
      }
      TextBox textBox48 = this.textBox_48;
      *(sbyte*) ((IntPtr) voidPtr + 16) = (sbyte) this.listBox_9.Items.Contains((object) this.textBox_86.Text);
      string str8 = ((bool*) ((IntPtr) voidPtr + 16))->ToString();
      textBox48.Text = str8;
      *(sbyte*) ((IntPtr) voidPtr + 23) = (sbyte) (this.listBox_9.FindString(this.textBox_86.Text) != -1);
      if (*(sbyte*) ((IntPtr) voidPtr + 23) != (sbyte) 0)
      {
        *(int*) ((IntPtr) voidPtr + 12) = (int) Convert.ToInt16(this.textBox_50.Text);
        this.method_6(*(int*) ((IntPtr) voidPtr + 12));
      }
      XtraTabControl xtraTabControl0 = this.xtraTabControl_0;
      *(sbyte*) ((IntPtr) voidPtr + 16) = (sbyte) this.listBox_6.Items.Contains((object) this.textBox_86.Text);
      string str9 = ((bool*) ((IntPtr) voidPtr + 16))->ToString();
      xtraTabControl0.Text = str9;
      *(sbyte*) ((IntPtr) voidPtr + 24) = (sbyte) (this.listBox_6.FindString(this.textBox_86.Text) != -1);
      if (*(sbyte*) ((IntPtr) voidPtr + 24) != (sbyte) 0)
        this.method_5();
      TextBox textBox37 = this.textBox_37;
      *(sbyte*) ((IntPtr) voidPtr + 16) = (sbyte) this.listBox_12.Items.Contains((object) this.textBox_86.Text);
      string str10 = ((bool*) ((IntPtr) voidPtr + 16))->ToString();
      textBox37.Text = str10;
      *(sbyte*) ((IntPtr) voidPtr + 25) = (sbyte) (this.listBox_12.FindString(this.textBox_86.Text) != -1);
      if (*(sbyte*) ((IntPtr) voidPtr + 25) != (sbyte) 0)
        this.method_12();
      TextBox textBox102 = this.textBox_102;
      *(sbyte*) ((IntPtr) voidPtr + 16) = (sbyte) this.listBox_22.Items.Contains((object) this.textBox_86.Text);
      string str11 = ((bool*) ((IntPtr) voidPtr + 16))->ToString();
      textBox102.Text = str11;
      *(sbyte*) ((IntPtr) voidPtr + 26) = (sbyte) (this.listBox_22.FindString(this.textBox_86.Text) != -1);
      if (*(sbyte*) ((IntPtr) voidPtr + 26) == (sbyte) 0)
        return;
      this.method_109();
    }

    internal void method_24(object sender, EventArgs e)
    {
      if ((!(this.comboBoxEdit_4.Text != "") || !(this.comboBoxEdit_4.Text != "Gün Seçin") || (!(this.comboBoxEdit_0.Text != "") || !(this.comboBoxEdit_0.Text != "Etkinlik Bölgesi Seçin")) ? 0 : (Class65.sqlConnection_0 != null ? 1 : 0)) != 0)
      {
        try
        {
          string str = this.comboBoxEdit_4.Text + " Saat :" + this.dateTimePicker_0.Text;
          this.listBox_11.Items.Add((object) str);
          new SqlCommand("exec My_EventBot..__Etkinlik_Takvimi 'Unique_Bulma','ekle','" + str + "'", Class65.sqlConnection_0).ExecuteNonQuery();
          Form1.smethod_0("Liste ve veritabanına eklendi :   " + str);
        }
        catch (Exception ex)
        {
          if (Class65.sqlConnection_0 == null)
            Form1.smethod_0("SQL bağlantısı kapalı olduğundan işlem gerçekleştirilemedi.!!");
          else
            Form1.smethod_0("Etkinlik tarihini veritabanına eklerken bir hata oluştu. Açıklama ==> " + (object) ex);
        }
      }
      else if ((Class65.sqlConnection_0 != null || !(this.comboBoxEdit_4.Text != "") || (!(this.comboBoxEdit_4.Text != "Gün Seçin") || !(this.comboBoxEdit_0.Text != "")) ? 0 : (this.comboBoxEdit_0.Text != "Etkinlik Bölgesi Seçin" ? 1 : 0)) != 0)
        Form1.smethod_0("SQL bağlantısı kapalı olduğundan işlem gerçekleştirilemedi.!!");
      if ((this.comboBoxEdit_0.Text == "" ? 1 : (this.comboBoxEdit_0.Text == "Etkinlik Bölgesi Seçin" ? 1 : 0)) != 0)
        Form1.smethod_1("Event Bölgesi Seçilmedi  !!!!!", Color.Salmon);
      if ((this.comboBoxEdit_4.Text == "" ? 1 : (this.comboBoxEdit_4.Text == "Gün Seçin" ? 1 : 0)) == 0)
        return;
      Form1.smethod_1("Event Günü Seçilmedi  !!!!!", Color.Salmon);
    }

    internal unsafe void method_25(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      *(sbyte*) voidPtr = (sbyte) this.checkBox_4.Checked;
      if (*(sbyte*) voidPtr != (sbyte) 0)
        this.groupBox_7.Enabled = true;
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) !this.checkBox_4.Checked;
      if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
        return;
      this.groupBox_7.Enabled = false;
    }

    internal unsafe void method_26(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      *(sbyte*) voidPtr = (sbyte) this.checkBox_3.Checked;
      if (*(sbyte*) voidPtr != (sbyte) 0)
        this.groupBox_8.Enabled = true;
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) !this.checkBox_3.Checked;
      if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
        return;
      this.groupBox_8.Enabled = false;
    }

    public void method_27(string string_36)
    {
      Form1.Class58 stateMachine = new Form1.Class58();
      stateMachine.form1_0 = this;
      stateMachine.string_0 = string_36;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class58>(ref stateMachine);
    }

    internal void method_28(object sender, EventArgs e)
    {
    }

    internal unsafe void method_29(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      *(sbyte*) voidPtr = (sbyte) this.checkBox_7.Checked;
      if (*(sbyte*) voidPtr != (sbyte) 0)
        this.groupBox_13.Enabled = true;
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) !this.checkBox_7.Checked;
      if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
        return;
      this.groupBox_13.Enabled = false;
    }

    internal unsafe void method_30(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      *(sbyte*) voidPtr = (sbyte) this.checkBox_6.Checked;
      if (*(sbyte*) voidPtr != (sbyte) 0)
        this.groupBox_14.Enabled = true;
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) !this.checkBox_6.Checked;
      if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
        return;
      this.groupBox_14.Enabled = false;
    }

    internal unsafe void method_31(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      *(sbyte*) voidPtr = (sbyte) this.checkBox_16.Checked;
      if (*(sbyte*) voidPtr != (sbyte) 0)
        this.groupBox_34.Enabled = true;
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) !this.checkBox_16.Checked;
      if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
        return;
      this.groupBox_34.Enabled = false;
    }

    internal unsafe void method_32(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      *(sbyte*) voidPtr = (sbyte) this.checkBox_15.Checked;
      if (*(sbyte*) voidPtr != (sbyte) 0)
        this.groupBox_35.Enabled = true;
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) !this.checkBox_15.Checked;
      if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
        return;
      this.groupBox_35.Enabled = false;
    }

    internal unsafe void method_33(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      *(sbyte*) voidPtr = (sbyte) this.checkBox_18.Checked;
      if (*(sbyte*) voidPtr != (sbyte) 0)
        this.groupBox_37.Enabled = true;
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) !this.checkBox_18.Checked;
      if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
        return;
      this.groupBox_37.Enabled = false;
    }

    internal unsafe void method_34(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      *(sbyte*) voidPtr = (sbyte) this.checkBox_17.Checked;
      if (*(sbyte*) voidPtr != (sbyte) 0)
        this.groupBox_38.Enabled = true;
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) !this.checkBox_17.Checked;
      if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
        return;
      this.groupBox_38.Enabled = false;
    }

    internal unsafe void method_35(object sender, PaintEventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(16);
      *(int*) voidPtr = 493;
      *(int*) ((IntPtr) voidPtr + 4) = *(int*) voidPtr / 60;
      *(int*) ((IntPtr) voidPtr + 8) = *(int*) voidPtr % 60;
      *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 4) / 60;
      *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) % 60;
      this.label_106.Text = ((int*) ((IntPtr) voidPtr + 12))->ToString("00") + ":" + ((int*) ((IntPtr) voidPtr + 4))->ToString("00") + ":" + ((int*) ((IntPtr) voidPtr + 8))->ToString("00");
    }

    internal unsafe void method_36(object sender, PaintEventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(16);
      *(int*) voidPtr = 1600;
      *(int*) ((IntPtr) voidPtr + 4) = *(int*) voidPtr / 60;
      *(int*) ((IntPtr) voidPtr + 8) = *(int*) voidPtr % 60;
      *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 4) / 60;
      *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) % 60;
      this.label_108.Text = ((int*) ((IntPtr) voidPtr + 12))->ToString("00") + ":" + ((int*) ((IntPtr) voidPtr + 4))->ToString("00") + ":" + ((int*) ((IntPtr) voidPtr + 8))->ToString("00");
    }

    public void method_37(object sender, EventArgs e)
    {
      Form1.Class59 stateMachine = new Form1.Class59();
      stateMachine.form1_0 = this;
      stateMachine.object_0 = sender;
      stateMachine.eventArgs_0 = e;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class59>(ref stateMachine);
    }

    internal unsafe void method_38(object sender, PaintEventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(16);
      *(int*) voidPtr = 1204;
      *(int*) ((IntPtr) voidPtr + 4) = *(int*) voidPtr / 60;
      *(int*) ((IntPtr) voidPtr + 8) = *(int*) voidPtr % 60;
      *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 4) / 60;
      *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) % 60;
      this.label_110.Text = ((int*) ((IntPtr) voidPtr + 12))->ToString("00") + ":" + ((int*) ((IntPtr) voidPtr + 4))->ToString("00") + ":" + ((int*) ((IntPtr) voidPtr + 8))->ToString("00");
    }

    internal unsafe void method_39(object sender, PaintEventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(20);
      *(int*) voidPtr = 300;
      *(int*) ((IntPtr) voidPtr + 4) = 320 + *(int*) voidPtr * 3;
      *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 4) / 60;
      *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 4) % 60;
      *(int*) ((IntPtr) voidPtr + 16) = *(int*) ((IntPtr) voidPtr + 8) / 60;
      *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) % 60;
      this.label_112.Text = ((int*) ((IntPtr) voidPtr + 16))->ToString("00") + ":" + ((int*) ((IntPtr) voidPtr + 8))->ToString("00") + ":" + ((int*) ((IntPtr) voidPtr + 12))->ToString("00");
    }

    internal unsafe void method_40(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      *(sbyte*) voidPtr = (sbyte) this.checkBox_11.Checked;
      if (*(sbyte*) voidPtr != (sbyte) 0)
        this.groupBox_23.Enabled = true;
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) !this.checkBox_11.Checked;
      if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
        return;
      this.groupBox_23.Enabled = false;
    }

    internal unsafe void method_41(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      *(sbyte*) voidPtr = (sbyte) this.checkBox_10.Checked;
      if (*(sbyte*) voidPtr != (sbyte) 0)
        this.groupBox_24.Enabled = true;
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) !this.checkBox_10.Checked;
      if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
        return;
      this.groupBox_24.Enabled = false;
    }

    internal void method_42(object sender, EventArgs e)
    {
    }

    internal unsafe void method_43(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      *(sbyte*) voidPtr = (sbyte) this.checkBox_20.Checked;
      if (*(sbyte*) voidPtr != (sbyte) 0)
        this.groupBox_42.Enabled = true;
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) !this.checkBox_20.Checked;
      if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
        return;
      this.groupBox_42.Enabled = false;
    }

    internal unsafe void method_44(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      *(sbyte*) voidPtr = (sbyte) this.checkBox_19.Checked;
      if (*(sbyte*) voidPtr != (sbyte) 0)
        this.groupBox_41.Enabled = true;
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) !this.checkBox_19.Checked;
      if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
        return;
      this.groupBox_41.Enabled = false;
    }

    internal unsafe void method_45(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      *(sbyte*) voidPtr = (sbyte) this.checkBox_14.Checked;
      if (*(sbyte*) voidPtr != (sbyte) 0)
        this.groupBox_31.Enabled = true;
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) !this.checkBox_14.Checked;
      if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
        return;
      this.groupBox_31.Enabled = false;
    }

    internal unsafe void method_46(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      *(sbyte*) voidPtr = (sbyte) this.checkBox_13.Checked;
      if (*(sbyte*) voidPtr != (sbyte) 0)
        this.groupBox_30.Enabled = true;
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) !this.checkBox_13.Checked;
      if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
        return;
      this.groupBox_30.Enabled = false;
    }

    internal void method_47(object sender, EventArgs e)
    {
    }

    internal void method_48(object sender, EventArgs e)
    {
      if ((Class65.sqlConnection_0 == null || !(this.comboBoxEdit_5.Text != "") || (!(this.comboBoxEdit_5.Text != "Gün Seçin") || !(this.comboBoxEdit_1.Text != "Etkinlik Bölgesi Seçin")) ? 0 : (this.comboBoxEdit_1.Text != "Etkinlik Bölgesi Seçin" ? 1 : 0)) != 0)
      {
        try
        {
          string str = this.comboBoxEdit_5.Text + " Saat :" + this.dateTimePicker_1.Text;
          this.listBox_3.Items.Add((object) str);
          new SqlCommand("exec My_EventBot..__Etkinlik_Takvimi 'GM_Bulma','ekle','" + str + "'", Class65.sqlConnection_0).ExecuteNonQuery();
          Form1.smethod_0("Liste ve veritabanına eklendi :   " + str);
        }
        catch (Exception ex)
        {
          if (Class65.sqlConnection_0 == null)
            Form1.smethod_0("SQL bağlantısı kapalı olduğundan işlem gerçekleştirilemedi.!!");
          else
            Form1.smethod_0("Etkinlik tarihini veritabanına eklerken bir hata oluştu. Açıklama ==> " + (object) ex);
        }
      }
      else if ((Class65.sqlConnection_0 != null || !(this.comboBoxEdit_5.Text != "") || (!(this.comboBoxEdit_5.Text != "Gün Seçin") || !(this.comboBoxEdit_1.Text != "")) ? 0 : (this.comboBoxEdit_1.Text != "Etkinlik Bölgesi Seçin" ? 1 : 0)) != 0)
        Form1.smethod_0("SQL bağlantısı kapalı olduğundan işlem gerçekleştirilemedi.!!");
      if ((this.comboBoxEdit_1.Text == "" ? 1 : (this.comboBoxEdit_1.Text == "Etkinlik Bölgesi Seçin" ? 1 : 0)) != 0)
        Form1.smethod_1("Event Bölgesi Seçilmedi  !!!!!", Color.Salmon);
      if ((this.comboBoxEdit_5.Text == "" ? 1 : (this.comboBoxEdit_5.Text == "Gün Seçin" ? 1 : 0)) == 0)
        return;
      Form1.smethod_1("Event Günü Seçilmedi  !!!!!", Color.Salmon);
    }

    internal unsafe void method_49(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(3);
      try
      {
        Form1.string_5 = this.listBox_3.SelectedItem.ToString();
        new SqlCommand("exec My_EventBot..__Etkinlik_Takvimi 'GM_Bulma','sil','" + Form1.string_5 + "'", Class65.sqlConnection_0).ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        *(sbyte*) voidPtr = (sbyte) (this.listBox_3.SelectedItem != null);
        if (*(sbyte*) voidPtr != (sbyte) 0)
          Form1.smethod_0("Liste ve veritabanından silinirken bir hata oluştu. Açıklama ==> " + (object) ex);
      }
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (this.listBox_3.SelectedItem != null);
      if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
      {
        this.listBox_3.Items.Remove(this.listBox_3.SelectedItem);
        Form1.smethod_0("Liste ve veritabanından silindi :  " + Form1.string_5);
      }
      else
      {
        *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) (this.listBox_3.SelectedItem == null);
        if (*(sbyte*) ((IntPtr) voidPtr + 2) == (sbyte) 0)
          return;
        Form1.smethod_0("Lütfen silinecek etkinlik tarihi seçin..");
      }
    }

    internal unsafe void method_50(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(3);
      try
      {
        Form1.string_3 = this.listBox_10.SelectedItem.ToString();
        new SqlCommand("exec My_EventBot..__Etkinlik_Takvimi 'Unique_Kesme','sil','" + Form1.string_3 + "'", Class65.sqlConnection_0).ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        *(sbyte*) voidPtr = (sbyte) (this.listBox_10.SelectedItem != null);
        if (*(sbyte*) voidPtr != (sbyte) 0)
          Form1.smethod_0("Liste ve veritabanından silinirken bir hata oluştu. Açıklama ==> " + (object) ex);
      }
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (this.listBox_10.SelectedItem != null);
      if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
      {
        this.listBox_10.Items.Remove(this.listBox_10.SelectedItem);
        Form1.smethod_0("Liste ve veritabanından silindi :  " + Form1.string_3);
      }
      else
      {
        *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) (this.listBox_10.SelectedItem == null);
        if (*(sbyte*) ((IntPtr) voidPtr + 2) == (sbyte) 0)
          return;
        Form1.smethod_0("Lütfen silinecek etkinlik tarihi seçin..");
      }
    }

    internal unsafe void method_51(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(3);
      try
      {
        Form1.string_4 = this.listBox_11.SelectedItem.ToString();
        new SqlCommand("exec My_EventBot..__Etkinlik_Takvimi 'Unique_Bulma','sil','" + Form1.string_4 + "'", Class65.sqlConnection_0).ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        *(sbyte*) voidPtr = (sbyte) (this.listBox_11.SelectedItem != null);
        if (*(sbyte*) voidPtr != (sbyte) 0)
          Form1.smethod_0("Liste ve veritabanından silinirken bir hata oluştu. Açıklama ==> " + (object) ex);
      }
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (this.listBox_11.SelectedItem != null);
      if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
      {
        this.listBox_11.Items.Remove(this.listBox_11.SelectedItem);
        Form1.smethod_0("Liste ve veritabanından silindi :  " + Form1.string_4);
      }
      else
      {
        *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) (this.listBox_11.SelectedItem == null);
        if (*(sbyte*) ((IntPtr) voidPtr + 2) == (sbyte) 0)
          return;
        Form1.smethod_0("Lütfen silinecek etkinlik tarihi seçin..");
      }
    }

    internal unsafe void method_52(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(3);
      try
      {
        Form1.string_6 = this.listBox_4.SelectedItem.ToString();
        new SqlCommand("exec My_EventBot..__Etkinlik_Takvimi 'Alchemy','sil','" + Form1.string_6 + "'", Class65.sqlConnection_0).ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        *(sbyte*) voidPtr = (sbyte) (this.listBox_4.SelectedItem != null);
        if (*(sbyte*) voidPtr != (sbyte) 0)
          Form1.smethod_0("Liste ve veritabanından silinirken bir hata oluştu. Açıklama ==> " + (object) ex);
      }
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (this.listBox_4.SelectedItem != null);
      if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
      {
        this.listBox_4.Items.Remove(this.listBox_4.SelectedItem);
        Form1.smethod_0("Liste ve veritabanından silindi :  " + Form1.string_6);
      }
      else
      {
        *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) (this.listBox_4.SelectedItem == null);
        if (*(sbyte*) ((IntPtr) voidPtr + 2) == (sbyte) 0)
          return;
        Form1.smethod_0("Lütfen silinecek etkinlik tarihi seçin..");
      }
    }

    internal unsafe void method_53(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(3);
      try
      {
        Form1.string_7 = this.listBox_5.SelectedItem.ToString();
        new SqlCommand("exec My_EventBot..__Etkinlik_Takvimi 'Soru_Cevap','sil','" + Form1.string_7 + "'", Class65.sqlConnection_0).ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        *(sbyte*) voidPtr = (sbyte) (this.listBox_5.SelectedItem != null);
        if (*(sbyte*) voidPtr != (sbyte) 0)
          Form1.smethod_0("Liste ve veritabanından silinirken bir hata oluştu. Açıklama ==> " + (object) ex);
      }
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (this.listBox_5.SelectedItem != null);
      if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
      {
        this.listBox_5.Items.Remove(this.listBox_5.SelectedItem);
        Form1.smethod_0("Liste ve veritabanından silindi :  " + Form1.string_7);
      }
      else
      {
        *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) (this.listBox_5.SelectedItem == null);
        if (*(sbyte*) ((IntPtr) voidPtr + 2) == (sbyte) 0)
          return;
        Form1.smethod_0("Lütfen silinecek etkinlik tarihi seçin..");
      }
    }

    internal unsafe void method_54(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(3);
      try
      {
        Form1.string_8 = this.listBox_7.SelectedItem.ToString();
        new SqlCommand("exec My_EventBot..__Etkinlik_Takvimi 'Party_Form','sil','" + Form1.string_8 + "'", Class65.sqlConnection_0).ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        *(sbyte*) voidPtr = (sbyte) (this.listBox_7.SelectedItem != null);
        if (*(sbyte*) voidPtr != (sbyte) 0)
          Form1.smethod_0("Liste ve veritabanından silinirken bir hata oluştu. Açıklama ==> " + (object) ex);
      }
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (this.listBox_7.SelectedItem != null);
      if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
      {
        this.listBox_7.Items.Remove(this.listBox_7.SelectedItem);
        Form1.smethod_0("Liste ve veritabanından silindi :  " + Form1.string_8);
      }
      else
      {
        *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) (this.listBox_7.SelectedItem == null);
        if (*(sbyte*) ((IntPtr) voidPtr + 2) == (sbyte) 0)
          return;
        Form1.smethod_0("Lütfen silinecek etkinlik tarihi seçin..");
      }
    }

    internal unsafe void method_55(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(3);
      try
      {
        Form1.string_9 = this.listBox_9.SelectedItem.ToString();
        new SqlCommand("exec My_EventBot..__Etkinlik_Takvimi 'Sayı_Bulma','sil','" + Form1.string_9 + "'", Class65.sqlConnection_0).ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        *(sbyte*) voidPtr = (sbyte) (this.listBox_9.SelectedItem != null);
        if (*(sbyte*) voidPtr != (sbyte) 0)
          Form1.smethod_0("Liste ve veritabanından silinirken bir hata oluştu. Açıklama ==> " + (object) ex);
      }
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (this.listBox_9.SelectedItem != null);
      if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
      {
        this.listBox_9.Items.Remove(this.listBox_9.SelectedItem);
        Form1.smethod_0("Liste ve veritabanından silindi :  " + Form1.string_9);
      }
      else
      {
        *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) (this.listBox_9.SelectedItem == null);
        if (*(sbyte*) ((IntPtr) voidPtr + 2) == (sbyte) 0)
          return;
        Form1.smethod_0("Lütfen silinecek etkinlik tarihi seçin..");
      }
    }

    internal unsafe void method_56(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(3);
      try
      {
        Form1.string_10 = this.listBox_6.SelectedItem.ToString();
        new SqlCommand("exec My_EventBot..__Etkinlik_Takvimi 'Oylama','sil','" + Form1.string_10 + "'", Class65.sqlConnection_0).ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        *(sbyte*) voidPtr = (sbyte) (this.listBox_6.SelectedItem != null);
        if (*(sbyte*) voidPtr != (sbyte) 0)
          Form1.smethod_0("Liste ve veritabanından silinirken bir hata oluştu. Açıklama ==> " + (object) ex);
      }
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (this.listBox_6.SelectedItem != null);
      if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
      {
        this.listBox_6.Items.Remove(this.listBox_6.SelectedItem);
        Form1.smethod_0("Liste ve veritabanından silindi :  " + Form1.string_10);
      }
      else
      {
        *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) (this.listBox_6.SelectedItem == null);
        if (*(sbyte*) ((IntPtr) voidPtr + 2) == (sbyte) 0)
          return;
        Form1.smethod_0("Lütfen silinecek etkinlik tarihi seçin..");
      }
    }

    internal void method_57(object sender, EventArgs e)
    {
      if ((Class65.sqlConnection_0 == null || !(this.comboBoxEdit_6.Text != "") ? 0 : (this.comboBoxEdit_6.Text != "Gün Seçin" ? 1 : 0)) != 0)
      {
        try
        {
          string str = this.comboBoxEdit_6.Text + " Saat :" + this.dateTimePicker_2.Text;
          this.listBox_4.Items.Add((object) str);
          new SqlCommand("exec My_EventBot..__Etkinlik_Takvimi 'Alchemy','ekle','" + str + "'", Class65.sqlConnection_0).ExecuteNonQuery();
          Form1.smethod_0("Liste ve veritabanına eklendi :   " + str);
        }
        catch (Exception ex)
        {
          if (Class65.sqlConnection_0 == null)
            Form1.smethod_0("SQL bağlantısı kapalı olduğundan işlem gerçekleştirilemedi.!!");
          else
            Form1.smethod_0("Etkinlik tarihini veritabanına eklerken bir hata oluştu. Açıklama ==> " + (object) ex);
        }
      }
      else if ((Class65.sqlConnection_0 != null || !(this.comboBoxEdit_6.Text != "") ? 0 : (this.comboBoxEdit_6.Text != "Gün Seçin" ? 1 : 0)) != 0)
        Form1.smethod_0("SQL bağlantısı kapalı olduğundan işlem gerçekleştirilemedi.!!");
      if ((this.comboBoxEdit_6.Text == "" ? 1 : (this.comboBoxEdit_6.Text == "Gün Seçin" ? 1 : 0)) == 0)
        return;
      Form1.smethod_1("Event Günü Seçilmedi  !!!!!", Color.Salmon);
    }

    internal void method_58(object sender, EventArgs e)
    {
      if ((Class65.sqlConnection_0 == null || !(this.comboBoxEdit_7.Text != "") ? 0 : (this.comboBoxEdit_7.Text != "Gün Seçin" ? 1 : 0)) != 0)
      {
        try
        {
          string str = this.comboBoxEdit_7.Text + " Saat :" + this.dateTimePicker_3.Text;
          this.listBox_5.Items.Add((object) str);
          new SqlCommand("exec My_EventBot..__Etkinlik_Takvimi 'Soru_Cevap','ekle','" + str + "'", Class65.sqlConnection_0).ExecuteNonQuery();
          Form1.smethod_0("Liste ve veritabanına eklendi :   " + str);
        }
        catch (Exception ex)
        {
          if (Class65.sqlConnection_0 == null)
            Form1.smethod_0("SQL bağlantısı kapalı olduğundan işlem gerçekleştirilemedi.!!");
          else
            Form1.smethod_0("Etkinlik tarihini veritabanına eklerken bir hata oluştu. Açıklama ==> " + (object) ex);
        }
      }
      else if ((Class65.sqlConnection_0 != null || !(this.comboBoxEdit_7.Text != "") ? 0 : (this.comboBoxEdit_7.Text != "Gün Seçin" ? 1 : 0)) != 0)
        Form1.smethod_0("SQL bağlantısı kapalı olduğundan işlem gerçekleştirilemedi.!!");
      if ((this.comboBoxEdit_7.Text == "" ? 1 : (this.comboBoxEdit_7.Text == "Gün Seçin" ? 1 : 0)) == 0)
        return;
      Form1.smethod_1("Event Günü Seçilmedi  !!!!!", Color.Salmon);
    }

    internal void method_59(object sender, EventArgs e)
    {
      if ((Class65.sqlConnection_0 == null || !(this.comboBoxEdit_8.Text != "") ? 0 : (this.comboBoxEdit_8.Text != "Gün Seçin" ? 1 : 0)) != 0)
      {
        try
        {
          string str = this.comboBoxEdit_8.Text + " Saat :" + this.dateTimePicker_5.Text;
          this.listBox_7.Items.Add((object) str);
          new SqlCommand("exec My_EventBot..__Etkinlik_Takvimi 'Party_Form','ekle','" + str + "'", Class65.sqlConnection_0).ExecuteNonQuery();
          Form1.smethod_0("Liste ve veritabanına eklendi :   " + str);
        }
        catch (Exception ex)
        {
          if (Class65.sqlConnection_0 == null)
            Form1.smethod_0("SQL bağlantısı kapalı olduğundan işlem gerçekleştirilemedi.!!");
          else
            Form1.smethod_0("Etkinlik tarihini veritabanına eklerken bir hata oluştu. Açıklama ==> " + (object) ex);
        }
      }
      else if ((Class65.sqlConnection_0 != null || !(this.comboBoxEdit_8.Text != "") ? 0 : (this.comboBoxEdit_8.Text != "Gün Seçin" ? 1 : 0)) != 0)
        Form1.smethod_0("SQL bağlantısı kapalı olduğundan işlem gerçekleştirilemedi.!!");
      if ((this.comboBoxEdit_8.Text == "" ? 1 : (this.comboBoxEdit_8.Text == "Gün Seçin" ? 1 : 0)) == 0)
        return;
      Form1.smethod_1("Event Günü Seçilmedi  !!!!!", Color.Salmon);
    }

    internal void method_60(object sender, EventArgs e)
    {
      if ((Class65.sqlConnection_0 == null || !(this.comboBoxEdit_9.Text != "") ? 0 : (this.comboBoxEdit_9.Text != "Gün Seçin" ? 1 : 0)) != 0)
      {
        try
        {
          string str = this.comboBoxEdit_9.Text + " Saat :" + this.dateTimePicker_6.Text;
          this.listBox_9.Items.Add((object) str);
          new SqlCommand("exec My_EventBot..__Etkinlik_Takvimi 'Sayı_Bulma','ekle','" + str + "'", Class65.sqlConnection_0).ExecuteNonQuery();
          Form1.smethod_0("Liste ve veritabanına eklendi :   " + str);
        }
        catch (Exception ex)
        {
          if (Class65.sqlConnection_0 == null)
            Form1.smethod_0("SQL bağlantısı kapalı olduğundan işlem gerçekleştirilemedi.!!");
          else
            Form1.smethod_0("Etkinlik tarihini veritabanına eklerken bir hata oluştu. Açıklama ==> " + (object) ex);
        }
      }
      else if ((Class65.sqlConnection_0 != null || !(this.comboBoxEdit_9.Text != "") ? 0 : (this.comboBoxEdit_9.Text != "Gün Seçin" ? 1 : 0)) != 0)
        Form1.smethod_0("SQL bağlantısı kapalı olduğundan işlem gerçekleştirilemedi.!!");
      if ((this.comboBoxEdit_9.Text == "" ? 1 : (this.comboBoxEdit_9.Text == "Gün Seçin" ? 1 : 0)) == 0)
        return;
      Form1.smethod_1("Event Günü Seçilmedi  !!!!!", Color.Salmon);
    }

    internal void method_61(object sender, EventArgs e)
    {
      if ((Class65.sqlConnection_0 == null || !(this.comboBoxEdit_11.Text != "") ? 0 : (this.comboBoxEdit_11.Text != "Gün Seçin" ? 1 : 0)) != 0)
      {
        try
        {
          string str = this.comboBoxEdit_11.Text + " Saat :" + this.dateTimePicker_4.Text;
          this.listBox_6.Items.Add((object) str);
          new SqlCommand("exec My_EventBot..__Etkinlik_Takvimi 'Oylama','ekle','" + str + "'", Class65.sqlConnection_0).ExecuteNonQuery();
          Form1.smethod_0("Liste ve veritabanına eklendi :   " + str);
        }
        catch (Exception ex)
        {
          if (Class65.sqlConnection_0 == null)
            Form1.smethod_0("SQL bağlantısı kapalı olduğundan işlem gerçekleştirilemedi.!!");
          else
            Form1.smethod_0("Etkinlik tarihini veritabanına eklerken bir hata oluştu. Açıklama ==> " + (object) ex);
        }
      }
      else if ((Class65.sqlConnection_0 != null || !(this.comboBoxEdit_11.Text != "") ? 0 : (this.comboBoxEdit_11.Text != "Gün Seçin" ? 1 : 0)) != 0)
        Form1.smethod_0("SQL bağlantısı kapalı olduğundan işlem gerçekleştirilemedi.!!");
      if ((this.comboBoxEdit_11.Text == "" ? 1 : (this.comboBoxEdit_11.Text == "Gün Seçin" ? 1 : 0)) == 0)
        return;
      Form1.smethod_1("Event Günü Seçilmedi  !!!!!", Color.Salmon);
    }

    internal unsafe void method_62(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(9);
      TextWriter textWriter1 = (TextWriter) new StreamWriter(Application.StartupPath + "/Ayarlar.ini");
      textWriter1.WriteLine("**********************************// My_EventBot VSRo 1.88 //*****************************");
      textWriter1.WriteLine("");
      textWriter1.WriteLine("              **************GENEL AYARLAR******************");
      textWriter1.WriteLine("[GENEL]");
      textWriter1.WriteLine("LANG=" + Form1.string_23.ToString());
      textWriter1.WriteLine("HOST=" + Form1.form1_0.textEdit_13.Text);
      textWriter1.WriteLine("USER=" + Form1.form1_0.textEdit_14.Text);
      textWriter1.WriteLine("PASS=" + Form1.form1_0.textEdit_12.Text);
      textWriter1.WriteLine("SHARD=" + Form1.form1_0.textEdit_11.Text);
      textWriter1.WriteLine("ACC=" + Form1.form1_0.textEdit_10.Text);
      textWriter1.WriteLine("LOG=" + Form1.form1_0.textEdit_9.Text);
      textWriter1.WriteLine("IP=" + Form1.form1_0.textEdit_17.Text);
      textWriter1.WriteLine("PORT=" + Form1.form1_0.textBox_89.Text);
      textWriter1.WriteLine("CAPTCHA=" + Form1.form1_0.textBox_90.Text);
      textWriter1.WriteLine("ID=" + Form1.form1_0.textEdit_16.Text);
      textWriter1.WriteLine("PW=" + Form1.form1_0.textEdit_15.Text);
      textWriter1.WriteLine("CHARNAME=" + Form1.form1_0.textEdit_18.Text);
      textWriter1.WriteLine("           ************** UNİQUE KESME ETKİNLİĞİ ******************");
      textWriter1.WriteLine("[UNİQUE_KESME]");
      textWriter1.WriteLine("EVENT_BOLGE=" + Form1.form1_0.comboBoxEdit_2.SelectedItem);
      textWriter1.WriteLine("ZERK_UNQ_ID=" + Form1.form1_0.textBox_8.Text);
      textWriter1.WriteLine("ZERK_UNQ_ADET=" + Form1.form1_0.textBox_7.Text);
      TextWriter textWriter2 = textWriter1;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) Form1.form1_0.checkBox_1.Checked;
      string str1 = "ODUL_TIPI_ITEM=" + ((bool*) ((IntPtr) voidPtr + 4))->ToString();
      textWriter2.WriteLine(str1);
      TextWriter textWriter3 = textWriter1;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) Form1.form1_0.checkBox_0.Checked;
      string str2 = "ODUL_TIPI_SGSR=" + ((bool*) ((IntPtr) voidPtr + 4))->ToString();
      textWriter3.WriteLine(str2);
      textWriter1.WriteLine("ODUL_ITEM_KODU=" + Form1.form1_0.textBox_2.Text);
      textWriter1.WriteLine("ODUL_ITEM_ADET=" + Form1.form1_0.textBox_1.Text);
      textWriter1.WriteLine("ODUL_ITEM_PLUS=" + Form1.form1_0.textBox_0.Text);
      textWriter1.WriteLine("ODUL_SGSR_SILK=" + Form1.form1_0.textBox_5.Text);
      textWriter1.WriteLine("ODUL_SGSR_GOLD=" + Form1.form1_0.textBox_3.Text);
      textWriter1.WriteLine("ODUL_SGSR_SP=" + Form1.form1_0.textBox_4.Text);
      textWriter1.WriteLine("ODUL_ITEM_ACIKLAMA=" + Form1.form1_0.textBox_91.Text);
      try
      {
        *(sbyte*) ((IntPtr) voidPtr + 5) = (sbyte) ((uint) this.listBoxControl_0.Items.Count > 0U);
        if (*(sbyte*) ((IntPtr) voidPtr + 5) != (sbyte) 0)
        {
          new SqlCommand("delete My_EventBot.._UniqKesList", Class65.sqlConnection_0).ExecuteNonQuery();
          *(int*) voidPtr = 0;
          while (true)
          {
            *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) (*(int*) voidPtr < this.listBoxControl_0.Items.Count);
            if (*(sbyte*) ((IntPtr) voidPtr + 8) != (sbyte) 0)
            {
              *(sbyte*) ((IntPtr) voidPtr + 6) = (sbyte) (this.listBoxControl_0.Items[*(int*) voidPtr].ToString() != null);
              if (*(sbyte*) ((IntPtr) voidPtr + 6) != (sbyte) 0)
              {
                new SqlCommand("insert into My_EventBot.._UniqKesList (refcommon_ID,Durum) values ('" + this.listBoxControl_0.Items[*(int*) voidPtr].ToString() + "',0)", Class65.sqlConnection_0).ExecuteNonQuery();
              }
              else
              {
                *(sbyte*) ((IntPtr) voidPtr + 7) = (sbyte) (this.listBoxControl_0.Items[*(int*) voidPtr].ToString() == null);
                if (*(sbyte*) ((IntPtr) voidPtr + 7) != (sbyte) 0)
                  Form1.smethod_0("Boş değer tabloya yazılamadı !!");
              }
              *(int*) voidPtr = *(int*) voidPtr + 1;
            }
            else
              break;
          }
        }
        else
        {
          int num = (int) MessageBox.Show("DİKKAT . . . [Unique Kesme] etkinliği için Unique listesinde hiç veri yok !!");
        }
      }
      catch
      {
      }
      textWriter1.WriteLine("           ************** UNİQUE BULMA ETKİNLİĞİ ******************");
      textWriter1.WriteLine("[UNİQUE_BULMA]");
      textWriter1.WriteLine("EVENT_BOLGE=" + Form1.form1_0.comboBoxEdit_0.SelectedItem.ToString());
      TextWriter textWriter4 = textWriter1;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) Form1.form1_0.checkBox_4.Checked;
      string str3 = "ODUL_TIPI_ITEM=" + ((bool*) ((IntPtr) voidPtr + 4))->ToString();
      textWriter4.WriteLine(str3);
      TextWriter textWriter5 = textWriter1;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) Form1.form1_0.checkBox_3.Checked;
      string str4 = "ODUL_TIPI_SGSR=" + ((bool*) ((IntPtr) voidPtr + 4))->ToString();
      textWriter5.WriteLine(str4);
      textWriter1.WriteLine("ODUL_ITEM_KODU=" + Form1.form1_0.textBox_13.Text);
      textWriter1.WriteLine("ODUL_ITEM_ADET=" + Form1.form1_0.textBox_12.Text);
      textWriter1.WriteLine("ODUL_ITEM_PLUS=" + Form1.form1_0.textBox_11.Text);
      textWriter1.WriteLine("ODUL_SGSR_SILK=" + Form1.form1_0.textBox_16.Text);
      textWriter1.WriteLine("ODUL_SGSR_GOLD=" + Form1.form1_0.textBox_14.Text);
      textWriter1.WriteLine("ODUL_SGSR_SP=" + Form1.form1_0.textBox_15.Text);
      textWriter1.WriteLine("ODUL_ITEM_ACIKLAMA=" + Form1.form1_0.textBox_92.Text);
      textWriter1.WriteLine("           ************** GM BULMA ETKİNLİĞİ ******************");
      textWriter1.WriteLine("[GM_BULMA]");
      textWriter1.WriteLine("EVENT_BOLGE=" + Form1.form1_0.comboBoxEdit_1.SelectedItem.ToString());
      TextWriter textWriter6 = textWriter1;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) Form1.form1_0.checkBox_16.Checked;
      string str5 = "ODUL_TIPI_ITEM=" + ((bool*) ((IntPtr) voidPtr + 4))->ToString();
      textWriter6.WriteLine(str5);
      TextWriter textWriter7 = textWriter1;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) Form1.form1_0.checkBox_15.Checked;
      string str6 = "ODUL_TIPI_SGSR=" + ((bool*) ((IntPtr) voidPtr + 4))->ToString();
      textWriter7.WriteLine(str6);
      textWriter1.WriteLine("ODUL_ITEM_KODU=" + Form1.form1_0.textBox_55.Text);
      textWriter1.WriteLine("ODUL_ITEM_ADET=" + Form1.form1_0.textBox_54.Text);
      textWriter1.WriteLine("ODUL_ITEM_PLUS=" + Form1.form1_0.textBox_53.Text);
      textWriter1.WriteLine("ODUL_SGSR_SILK=" + Form1.form1_0.textBox_58.Text);
      textWriter1.WriteLine("ODUL_SGSR_GOLD=" + Form1.form1_0.textBox_56.Text);
      textWriter1.WriteLine("ODUL_SGSR_SP=" + Form1.form1_0.textBox_57.Text);
      textWriter1.WriteLine("ODUL_ITEM_ACIKLAMA=" + Form1.form1_0.textBox_93.Text);
      textWriter1.WriteLine("           ************** ALCHEMY ETKİNLİĞİ ******************");
      textWriter1.WriteLine("[ALCHEMY]");
      textWriter1.WriteLine("DROP_PLUS=" + Form1.form1_0.comboBox_2.Text);
      textWriter1.WriteLine("ARANAN_PLUS=" + Form1.form1_0.comboBox_0.Text);
      textWriter1.WriteLine("DROP_ADET=" + Form1.form1_0.textBox_25.Text);
      TextWriter textWriter8 = textWriter1;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) Form1.form1_0.checkBox_18.Checked;
      string str7 = "ODUL_TIPI_ITEM=" + ((bool*) ((IntPtr) voidPtr + 4))->ToString();
      textWriter8.WriteLine(str7);
      TextWriter textWriter9 = textWriter1;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) Form1.form1_0.checkBox_17.Checked;
      string str8 = "ODUL_TIPI_SGSR=" + ((bool*) ((IntPtr) voidPtr + 4))->ToString();
      textWriter9.WriteLine(str8);
      textWriter1.WriteLine("ODUL_ITEM_KODU=" + Form1.form1_0.textBox_61.Text);
      textWriter1.WriteLine("ODUL_ITEM_ADET=" + Form1.form1_0.textBox_60.Text);
      textWriter1.WriteLine("ODUL_ITEM_PLUS=" + Form1.form1_0.textBox_59.Text);
      textWriter1.WriteLine("ODUL_SGSR_SILK=" + Form1.form1_0.textBox_64.Text);
      textWriter1.WriteLine("ODUL_SGSR_GOLD=" + Form1.form1_0.textBox_62.Text);
      textWriter1.WriteLine("ODUL_SGSR_SP=" + Form1.form1_0.textBox_63.Text);
      textWriter1.WriteLine("ODUL_ITEM_ACIKLAMA=" + Form1.form1_0.textBox_94.Text);
      textWriter1.WriteLine("           ************** SORU-CEVAP ETKİNLİĞİ ******************");
      textWriter1.WriteLine("[SORU-CEVAP]");
      textWriter1.WriteLine("TOPLAM_SORU=" + Form1.form1_0.textBox_28.Text);
      textWriter1.WriteLine("CEVAP_BEKLEME_SURESI=" + Form1.form1_0.textBox_29.Text);
      textWriter1.WriteLine("SORULAR_ARASI_SURE=" + Form1.form1_0.textBox_27.Text);
      TextWriter textWriter10 = textWriter1;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) Form1.form1_0.checkBox_11.Checked;
      string str9 = "ODUL_TIPI_ITEM=" + ((bool*) ((IntPtr) voidPtr + 4))->ToString();
      textWriter10.WriteLine(str9);
      TextWriter textWriter11 = textWriter1;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) Form1.form1_0.checkBox_10.Checked;
      string str10 = "ODUL_TIPI_SGSR=" + ((bool*) ((IntPtr) voidPtr + 4))->ToString();
      textWriter11.WriteLine(str10);
      textWriter1.WriteLine("ODUL_ITEM_KODU=" + Form1.form1_0.textBox_32.Text);
      textWriter1.WriteLine("ODUL_ITEM_ADET=" + Form1.form1_0.textBox_31.Text);
      textWriter1.WriteLine("ODUL_ITEM_PLUS=" + Form1.form1_0.textBox_30.Text);
      textWriter1.WriteLine("ODUL_SGSR_SILK=" + Form1.form1_0.textBox_35.Text);
      textWriter1.WriteLine("ODUL_SGSR_GOLD=" + Form1.form1_0.textBox_33.Text);
      textWriter1.WriteLine("ODUL_SGSR_SP=" + Form1.form1_0.textBox_34.Text);
      textWriter1.WriteLine("ODUL_ITEM_ACIKLAMA=" + Form1.form1_0.textBox_95.Text);
      textWriter1.WriteLine("           ************** PARTY FORM ETKİNLİĞİ ******************");
      textWriter1.WriteLine("[PARTY FORM]");
      textWriter1.WriteLine("ETKNLK_RAUND=" + Form1.form1_0.textBox_40.Text);
      textWriter1.WriteLine("ARANAN_PT_ARTI=" + Form1.form1_0.textBox_41.Text);
      textWriter1.WriteLine("RAUND_BEKLEME_SANIYE=" + Form1.form1_0.textBox_87.Text);
      TextWriter textWriter12 = textWriter1;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) Form1.form1_0.checkBox_14.Checked;
      string str11 = "ODUL_TIPI_ITEM=" + ((bool*) ((IntPtr) voidPtr + 4))->ToString();
      textWriter12.WriteLine(str11);
      TextWriter textWriter13 = textWriter1;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) Form1.form1_0.checkBox_13.Checked;
      string str12 = "ODUL_TIPI_SGSR=" + ((bool*) ((IntPtr) voidPtr + 4))->ToString();
      textWriter13.WriteLine(str12);
      textWriter1.WriteLine("ODUL_ITEM_KODU=" + Form1.form1_0.textBox_47.Text);
      textWriter1.WriteLine("ODUL_ITEM_ADET=" + Form1.form1_0.textBox_46.Text);
      textWriter1.WriteLine("ODUL_ITEM_PLUS=" + Form1.form1_0.textBox_45.Text);
      textWriter1.WriteLine("ODUL_SGSR_SILK=" + Form1.form1_0.textBox_43.Text);
      textWriter1.WriteLine("ODUL_SGSR_GOLD=" + Form1.form1_0.textBox_42.Text);
      textWriter1.WriteLine("ODUL_SGSR_SP=" + Form1.form1_0.textBox_44.Text);
      textWriter1.WriteLine("ODUL_ITEM_ACIKLAMA=" + Form1.form1_0.textBox_96.Text);
      textWriter1.WriteLine("           ************** SAYI BULMA ETKİNLİĞİ ******************");
      textWriter1.WriteLine("[SAYI BULMA]");
      textWriter1.WriteLine("ETKNLK_RAUND=" + Form1.form1_0.textBox_50.Text);
      textWriter1.WriteLine("RSTGL_SAYI_1=" + Form1.form1_0.textBox_51.Text);
      textWriter1.WriteLine("RSTGL_SAYI_2=" + Form1.form1_0.textBox_49.Text);
      TextWriter textWriter14 = textWriter1;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) Form1.form1_0.checkBox_20.Checked;
      string str13 = "ODUL_TIPI_ITEM=" + ((bool*) ((IntPtr) voidPtr + 4))->ToString();
      textWriter14.WriteLine(str13);
      TextWriter textWriter15 = textWriter1;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) Form1.form1_0.checkBox_19.Checked;
      string str14 = "ODUL_TIPI_SGSR=" + ((bool*) ((IntPtr) voidPtr + 4))->ToString();
      textWriter15.WriteLine(str14);
      textWriter1.WriteLine("ODUL_ITEM_KODU=" + Form1.form1_0.textBox_75.Text);
      textWriter1.WriteLine("ODUL_ITEM_ADET=" + Form1.form1_0.textBox_74.Text);
      textWriter1.WriteLine("ODUL_ITEM_PLUS=" + Form1.form1_0.textBox_73.Text);
      textWriter1.WriteLine("ODUL_SGSR_SILK=" + Form1.form1_0.textBox_71.Text);
      textWriter1.WriteLine("ODUL_SGSR_GOLD=" + Form1.form1_0.textBox_70.Text);
      textWriter1.WriteLine("ODUL_SGSR_SP=" + Form1.form1_0.textBox_72.Text);
      textWriter1.WriteLine("ODUL_ITEM_ACIKLAMA=" + Form1.form1_0.textBox_97.Text);
      textWriter1.WriteLine("           ************** OYLAMA ETKİNLİĞİ ******************");
      textWriter1.WriteLine("[OYLAMA]");
      textWriter1.WriteLine("GEREKLI_KATILIMCI=" + Form1.form1_0.textBox_39.Text);
      textWriter1.WriteLine("BEKLENECEK_SURE=" + Form1.form1_0.textBox_38.Text);
      textWriter1.WriteLine("YTRSZ_KTLM_ETKNLK=" + Form1.form1_0.comboBox_1.Text);
      TextWriter textWriter16 = textWriter1;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) Form1.form1_0.checkEdit_6.Checked;
      string str15 = "OYL_DHL_ETKNLK_1=" + ((bool*) ((IntPtr) voidPtr + 4))->ToString();
      textWriter16.WriteLine(str15);
      TextWriter textWriter17 = textWriter1;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) Form1.form1_0.checkEdit_8.Checked;
      string str16 = "OYL_DHL_ETKNLK_2=" + ((bool*) ((IntPtr) voidPtr + 4))->ToString();
      textWriter17.WriteLine(str16);
      TextWriter textWriter18 = textWriter1;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) Form1.form1_0.checkEdit_7.Checked;
      string str17 = "OYL_DHL_ETKNLK_3=" + ((bool*) ((IntPtr) voidPtr + 4))->ToString();
      textWriter18.WriteLine(str17);
      TextWriter textWriter19 = textWriter1;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) Form1.form1_0.checkEdit_5.Checked;
      string str18 = "OYL_DHL_ETKNLK_4=" + ((bool*) ((IntPtr) voidPtr + 4))->ToString();
      textWriter19.WriteLine(str18);
      TextWriter textWriter20 = textWriter1;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) Form1.form1_0.checkEdit_2.Checked;
      string str19 = "OYL_DHL_ETKNLK_5=" + ((bool*) ((IntPtr) voidPtr + 4))->ToString();
      textWriter20.WriteLine(str19);
      TextWriter textWriter21 = textWriter1;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) Form1.form1_0.checkEdit_4.Checked;
      string str20 = "OYL_DHL_ETKNLK_6=" + ((bool*) ((IntPtr) voidPtr + 4))->ToString();
      textWriter21.WriteLine(str20);
      TextWriter textWriter22 = textWriter1;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) Form1.form1_0.checkEdit_3.Checked;
      string str21 = "OYL_DHL_ETKNLK_7=" + ((bool*) ((IntPtr) voidPtr + 4))->ToString();
      textWriter22.WriteLine(str21);
      TextWriter textWriter23 = textWriter1;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) Form1.form1_0.checkEdit_1.Checked;
      string str22 = "OYL_DHL_ETKNLK_8=" + ((bool*) ((IntPtr) voidPtr + 4))->ToString();
      textWriter23.WriteLine(str22);
      TextWriter textWriter24 = textWriter1;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) Form1.form1_0.checkEdit_11.Checked;
      string str23 = "OYL_DHL_ETKNLK_9=" + ((bool*) ((IntPtr) voidPtr + 4))->ToString();
      textWriter24.WriteLine(str23);
      textWriter1.WriteLine("           ************** HAYATTA KAL ETKİNLİĞİ ******************");
      textWriter1.WriteLine("[HAYATTA KAL]");
      textWriter1.WriteLine("KOORDINAT_X=" + Form1.form1_0.textBox_82.Text);
      textWriter1.WriteLine("KOORDINAT_Y=" + Form1.form1_0.textBox_81.Text);
      textWriter1.WriteLine("BASLAMA_MINUMUM_KATILIMCI=" + Form1.form1_0.textBox_78.Text);
      textWriter1.WriteLine("ICERI_ALINACAK_MAX_KATILIMCI=" + Form1.form1_0.textBox_17.Text);
      textWriter1.WriteLine("ALT_LVL_SINIRI=" + Form1.form1_0.textBox_83.Text);
      TextWriter textWriter25 = textWriter1;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) Form1.form1_0.checkBox_7.Checked;
      string str24 = "ODUL_TIPI_ITEM=" + ((bool*) ((IntPtr) voidPtr + 4))->ToString();
      textWriter25.WriteLine(str24);
      TextWriter textWriter26 = textWriter1;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) Form1.form1_0.checkBox_6.Checked;
      string str25 = "ODUL_TIPI_SGSR=" + ((bool*) ((IntPtr) voidPtr + 4))->ToString();
      textWriter26.WriteLine(str25);
      textWriter1.WriteLine("ODUL_ITEM_KODU=" + Form1.form1_0.textBox_20.Text);
      textWriter1.WriteLine("ODUL_ITEM_ADET=" + Form1.form1_0.textBox_19.Text);
      textWriter1.WriteLine("ODUL_ITEM_PLUS=" + Form1.form1_0.textBox_18.Text);
      textWriter1.WriteLine("ODUL_SGSR_SILK=" + Form1.form1_0.textBox_23.Text);
      textWriter1.WriteLine("ODUL_SGSR_GOLD=" + Form1.form1_0.textBox_21.Text);
      textWriter1.WriteLine("ODUL_SGSR_SP=" + Form1.form1_0.textBox_22.Text);
      textWriter1.WriteLine("ODUL_ITEM_ACIKLAMA=" + Form1.form1_0.textBox_98.Text);
      textWriter1.WriteLine("           ************** PIYANGO ******************");
      textWriter1.WriteLine("[PIYANGO]");
      textWriter1.WriteLine("CEKILIS_TURU=" + this.comboBoxEdit_13.Text);
      textWriter1.WriteLine("CEKILIS_MIKTARI=" + this.textBox_103.Text);
      textWriter1.WriteLine("");
      textWriter1.WriteLine("**********************************// My_EventBot //*****************************");
      textWriter1.Flush();
      textWriter1.Close();
      Form1.smethod_1("Ayarlar Kaydedildi.", Color.Salmon);
    }

    internal void method_63(object sender, KeyPressEventArgs e)
    {
      e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
    }

    internal void method_64(object sender, EventArgs e)
    {
    }

    internal void method_65(object sender, EventArgs e)
    {
    }

    internal void method_66(object sender, EventArgs e)
    {
      Form1.Class60 stateMachine = new Form1.Class60();
      stateMachine.form1_0 = this;
      stateMachine.object_0 = sender;
      stateMachine.eventArgs_0 = e;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class60>(ref stateMachine);
    }

    internal void method_67(object sender, EventArgs e)
    {
    }

    internal void method_68(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("Bu X,Y koordinatı etkinliğin yapılacağı koordinatlardır.Etkinlik başladığında sistem kayıtlı olan oyuncuları bu koordinatlara çeker.O yüzden oyun içerisinde kullanılmayan, etkinlik sırasında diğer oyuncuların giremiyeceği bir bölge belirlemelisiniz. örneğin Event Arena / Pwp Arena / Prison olabilir. Seçtiniz bölgeye herhangi bir karakter ile gidin. Etkinlik başladığında karakterlerin tam olarak doğmasını istediniz noktada sağ üst ufak haritanın altındaki X ve Y koordinatlarını buradaki kutucuklara yazın.");
    }

    internal void method_69(object sender, EventArgs e)
    {
      if ((Class65.sqlConnection_0 == null || !(this.comboBoxEdit_10.Text != "") ? 0 : (this.comboBoxEdit_10.Text != "Gün Seçin" ? 1 : 0)) != 0)
      {
        try
        {
          string str = this.comboBoxEdit_10.Text + " Saat :" + this.dateTimePicker_7.Text;
          this.listBox_12.Items.Add((object) str);
          new SqlCommand("exec My_EventBot..__Etkinlik_Takvimi 'Hayatta_Kal','ekle','" + str + "'", Class65.sqlConnection_0).ExecuteNonQuery();
          Form1.smethod_0("Liste ve veritabanına eklendi :   " + str);
        }
        catch (Exception ex)
        {
          if (Class65.sqlConnection_0 == null)
            Form1.smethod_0("SQL bağlantısı kapalı olduğundan işlem gerçekleştirilemedi.!!");
          else
            Form1.smethod_0("Etkinlik tarihini veritabanına eklerken bir hata oluştu. Açıklama ==> " + (object) ex);
        }
      }
      else if ((Class65.sqlConnection_0 != null || !(this.comboBoxEdit_10.Text != "") ? 0 : (this.comboBoxEdit_10.Text != "Gün Seçin" ? 1 : 0)) != 0)
        Form1.smethod_0("SQL bağlantısı kapalı olduğundan işlem gerçekleştirilemedi.!!");
      if ((this.comboBoxEdit_10.Text == "" ? 1 : (this.comboBoxEdit_10.Text == "Gün Seçin" ? 1 : 0)) == 0)
        return;
      Form1.smethod_1("Event Günü Seçilmedi  !!!!!", Color.Salmon);
    }

    internal unsafe void method_70(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(3);
      try
      {
        Form1.string_11 = this.listBox_12.SelectedItem.ToString();
        new SqlCommand("exec My_EventBot..__Etkinlik_Takvimi 'Hayatta_Kal','sil','" + Form1.string_11 + "'", Class65.sqlConnection_0).ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        *(sbyte*) voidPtr = (sbyte) (this.listBox_12.SelectedItem != null);
        if (*(sbyte*) voidPtr != (sbyte) 0)
          Form1.smethod_0("Liste ve veritabanından silinirken bir hata oluştu. Açıklama ==> " + (object) ex);
      }
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (this.listBox_12.SelectedItem != null);
      if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
      {
        this.listBox_12.Items.Remove(this.listBox_12.SelectedItem);
        Form1.smethod_0("Listeden silindi :  " + Form1.string_11);
      }
      else
      {
        *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) (this.listBox_12.SelectedItem == null);
        if (*(sbyte*) ((IntPtr) voidPtr + 2) == (sbyte) 0)
          return;
        Form1.smethod_0("Lütfen silinecek etkinlik tarihi seçin..");
      }
    }

    public void method_71(object sender, EventArgs e)
    {
      Form1.Class61 stateMachine = new Form1.Class61();
      stateMachine.form1_0 = this;
      stateMachine.object_0 = sender;
      stateMachine.eventArgs_0 = e;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class61>(ref stateMachine);
    }

    internal void method_72(object sender, EventArgs e)
    {
      Form1.Class62 stateMachine = new Form1.Class62();
      stateMachine.form1_0 = this;
      stateMachine.object_0 = sender;
      stateMachine.eventArgs_0 = e;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class62>(ref stateMachine);
    }

    internal unsafe void method_73(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(3);
      *(sbyte*) voidPtr = (sbyte) (this.label_160.Text == "ONLİNE");
      if (*(sbyte*) voidPtr != (sbyte) 0)
      {
        Class73.smethod_46(this);
        try
        {
          new SqlCommand("delete My_EventBot.._AntiPhBot", Class65.sqlConnection_0).ExecuteNonQuery();
        }
        catch
        {
        }
        Form1.smethod_0("Kervan botu engelleme sistemi başlatıldı.");
        this.timer_4.Start();
        this.timer_3.Start();
        this.timer_5.Start();
      }
      else
      {
        *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (this.label_160.Text == "OFFLİNE");
        if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
          Form1.smethod_0("KARAKTER OYUNDA DEGİL.AntiPhbot engelleme sistemi başlatılamadı.");
      }
      ConnectionState state = Class65.sqlConnection_0.State;
      *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) (state.ToString() != "Open");
      if (*(sbyte*) ((IntPtr) voidPtr + 2) == (sbyte) 0)
        return;
      Form1.smethod_0("SQL SERVER baglantısı kapalı !!!!");
    }

    internal void method_74(object sender, EventArgs e)
    {
      new Form0().Show();
    }

    internal unsafe void method_75(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      *(sbyte*) voidPtr = (sbyte) this.timer_4.Enabled;
      if (*(sbyte*) voidPtr != (sbyte) 0)
      {
        this.label_141.Text = "AKTİF";
        this.label_141.ForeColor = Color.YellowGreen;
        this.button_24.Visible = false;
        this.button_25.Visible = true;
      }
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) !this.timer_4.Enabled;
      if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
        return;
      this.label_141.Text = "PASİF";
      this.label_141.ForeColor = Color.Salmon;
      this.button_24.Visible = true;
      this.button_25.Visible = false;
    }

    internal void method_76(object sender, EventArgs e)
    {
      Form1.smethod_0("Kervan botu engelleme sistemi durduruldu.!!");
      this.timer_4.Stop();
      this.timer_3.Stop();
      this.timer_5.Stop();
    }

    internal void method_77(object sender, EventArgs e)
    {
    }

    internal void method_78(object sender, EventArgs e)
    {
    }

    internal void method_79(object sender, MouseEventArgs e)
    {
    }

    internal void method_80(object sender, EventArgs e)
    {
      this.panel_1.Location = new Point(0, 22);
      this.panel_1.Height = 174;
      this.panel_1.Width = 192;
    }

    internal void method_81(object sender, MouseEventArgs e)
    {
      Panel panel1 = this.panel_1;
      Point position = Cursor.Position;
      int x = position.X;
      position = Cursor.Position;
      int y = position.Y;
      Point point = new Point(x, y);
      panel1.Location = point;
      this.panel_1.Height = 174;
      this.panel_1.Width = 192;
    }

    internal void method_82(object sender, EventArgs e)
    {
      Class73.smethod_46(this);
    }

    internal unsafe void method_83(object sender, PaintEventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(40);
      *(int*) voidPtr = 300;
      *(int*) ((IntPtr) voidPtr + 4) = Convert.ToInt32(this.textBox_29.Text);
      *(int*) ((IntPtr) voidPtr + 8) = Convert.ToInt32(this.textBox_27.Text);
      *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 4) + *(int*) ((IntPtr) voidPtr + 8) + 3 + 3 + 5;
      *(int*) ((IntPtr) voidPtr + 16) = Convert.ToInt32(this.textBox_28.Text);
      *(int*) ((IntPtr) voidPtr + 20) = *(int*) ((IntPtr) voidPtr + 12) * *(int*) ((IntPtr) voidPtr + 16);
      *(int*) ((IntPtr) voidPtr + 24) = *(int*) voidPtr + *(int*) ((IntPtr) voidPtr + 20);
      *(int*) ((IntPtr) voidPtr + 28) = *(int*) ((IntPtr) voidPtr + 24) / 60;
      *(int*) ((IntPtr) voidPtr + 32) = *(int*) ((IntPtr) voidPtr + 24) % 60;
      *(int*) ((IntPtr) voidPtr + 36) = *(int*) ((IntPtr) voidPtr + 28) / 60;
      *(int*) ((IntPtr) voidPtr + 28) = *(int*) ((IntPtr) voidPtr + 28) % 60;
      this.label_114.Text = ((int*) ((IntPtr) voidPtr + 36))->ToString("00") + ":" + ((int*) ((IntPtr) voidPtr + 28))->ToString("00") + ":" + ((int*) ((IntPtr) voidPtr + 32))->ToString("00");
    }

    internal unsafe void method_84(object sender, PaintEventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(32);
      *(int*) voidPtr = Convert.ToInt32(this.textBox_40.Text);
      *(int*) ((IntPtr) voidPtr + 4) = 300;
      *(int*) ((IntPtr) voidPtr + 8) = Convert.ToInt32(Form1.form1_0.textBox_87.Text) + 7;
      *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 8) * *(int*) voidPtr;
      *(int*) ((IntPtr) voidPtr + 16) = *(int*) ((IntPtr) voidPtr + 12) + *(int*) ((IntPtr) voidPtr + 4);
      *(int*) ((IntPtr) voidPtr + 20) = *(int*) ((IntPtr) voidPtr + 16) / 60;
      *(int*) ((IntPtr) voidPtr + 24) = *(int*) ((IntPtr) voidPtr + 16) % 60;
      *(int*) ((IntPtr) voidPtr + 28) = *(int*) ((IntPtr) voidPtr + 20) / 60;
      *(int*) ((IntPtr) voidPtr + 20) = *(int*) ((IntPtr) voidPtr + 20) % 60;
      this.label_166.Text = ((int*) ((IntPtr) voidPtr + 28))->ToString("00") + ":" + ((int*) ((IntPtr) voidPtr + 20))->ToString("00") + ":" + ((int*) ((IntPtr) voidPtr + 24))->ToString("00");
    }

    internal unsafe void method_85(object sender, PaintEventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(20);
      *(int*) voidPtr = 132 * Convert.ToInt32(this.textBox_50.Text);
      *(int*) ((IntPtr) voidPtr + 4) = *(int*) voidPtr + 300;
      *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 4) / 60;
      *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 4) % 60;
      *(int*) ((IntPtr) voidPtr + 16) = *(int*) ((IntPtr) voidPtr + 8) / 60;
      *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) % 60;
      this.label_118.Text = ((int*) ((IntPtr) voidPtr + 16))->ToString("00") + ":" + ((int*) ((IntPtr) voidPtr + 8))->ToString("00") + ":" + ((int*) ((IntPtr) voidPtr + 12))->ToString("00");
    }

    internal unsafe void method_86(object sender, PaintEventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(16);
      *(int*) voidPtr = 610;
      *(int*) ((IntPtr) voidPtr + 4) = *(int*) voidPtr / 60;
      *(int*) ((IntPtr) voidPtr + 8) = *(int*) voidPtr % 60;
      *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 4) / 60;
      *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) % 60;
      this.label_132.Text = ((int*) ((IntPtr) voidPtr + 12))->ToString("00") + ":" + ((int*) ((IntPtr) voidPtr + 4))->ToString("00") + ":" + ((int*) ((IntPtr) voidPtr + 8))->ToString("00");
    }

    internal unsafe void method_87(object sender, PaintEventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(20);
      *(int*) voidPtr = Convert.ToInt32(this.textBox_38.Text);
      *(int*) ((IntPtr) voidPtr + 4) = 78 + *(int*) voidPtr;
      *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 4) / 60;
      *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 4) % 60;
      *(int*) ((IntPtr) voidPtr + 16) = *(int*) ((IntPtr) voidPtr + 8) / 60;
      *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) % 60;
      this.label_116.Text = ((int*) ((IntPtr) voidPtr + 16))->ToString("00") + ":" + ((int*) ((IntPtr) voidPtr + 8))->ToString("00") + ":" + ((int*) ((IntPtr) voidPtr + 12))->ToString("00");
    }

    internal void method_88(object sender, EventArgs e)
    {
      this.BackColor = Color.Gray;
    }

    internal void method_89(object sender, PaintEventArgs e)
    {
    }

    internal void method_90(object sender, EventArgs e)
    {
      this.listBoxControl_1.Items.Clear();
      try
      {
        SqlDataReader sqlDataReader = new SqlCommand("select CodeName128 from " + Form1.string_0 + ".._RefObjCommon where CodeName128 like '%MOB_%' and Rarity =3", Class65.sqlConnection_0).ExecuteReader();
        while (sqlDataReader.Read())
          this.listBoxControl_1.Items.Add(sqlDataReader[0]);
      }
      catch (Exception ex)
      {
        Form1.smethod_0("Veritabanındaki uniqueler listeye aktarılamadı. HATA => " + ex.Message);
      }
    }

    internal void method_91(object sender, EventArgs e)
    {
      if (this.listBoxControl_1.SelectedItem == null)
        return;
      try
      {
        using (SqlDataReader sqlDataReader = new SqlCommand("select ID from SRO_VT_SHARD.._RefObjCommon where CodeName128='" + this.listBoxControl_1.SelectedItem.ToString() + "'", Class65.sqlConnection_0).ExecuteReader())
        {
          sqlDataReader.Read();
          this.listBoxControl_0.Items.Add((object) sqlDataReader[0].ToString());
        }
      }
      catch (Exception ex)
      {
        Form1.smethod_0(this.listBoxControl_1.SelectedItem.ToString() + " CoddeName128'e ait ID alınamadı !! HATA => " + ex.Message);
      }
    }

    internal unsafe void method_92(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(5);
      *(int*) voidPtr = this.listBoxControl_0.SelectedIndex;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (*(int*) voidPtr < this.listBoxControl_0.Items.Count - 1 & *(int*) voidPtr != -1);
      if (*(sbyte*) ((IntPtr) voidPtr + 4) == (sbyte) 0)
        return;
      this.listBoxControl_0.Items.Insert(*(int*) voidPtr + 2, this.listBoxControl_0.Items[*(int*) voidPtr]);
      this.listBoxControl_0.Items.RemoveAt(*(int*) voidPtr);
      this.listBoxControl_0.SelectedIndex = *(int*) voidPtr + 1;
    }

    internal void method_93(object sender, EventArgs e)
    {
      this.listBoxControl_0.Items.Remove(this.listBoxControl_0.SelectedItem);
    }

    internal unsafe void method_94(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(5);
      *(int*) voidPtr = this.listBoxControl_0.SelectedIndex;
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (*(int*) voidPtr > 0);
      if (*(sbyte*) ((IntPtr) voidPtr + 4) == (sbyte) 0)
        return;
      this.listBoxControl_0.Items.Insert(*(int*) voidPtr - 1, this.listBoxControl_0.Items[*(int*) voidPtr]);
      this.listBoxControl_0.Items.RemoveAt(*(int*) voidPtr + 1);
      this.listBoxControl_0.SelectedIndex = *(int*) voidPtr - 1;
    }

    public void method_95()
    {
      Form1.Class63 stateMachine = new Form1.Class63();
      stateMachine.form1_0 = this;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class63>(ref stateMachine);
    }

    internal unsafe void method_96(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(9);
      *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) Form1.bool_1;
      if (*(sbyte*) ((IntPtr) voidPtr + 8) == (sbyte) 0)
        return;
      Class19 class190 = Class25.class19_0;
      *(int*) voidPtr = Form1.int_3;
      *(int*) ((IntPtr) voidPtr + 4) = Form1.int_4;
      Class73.smethod_21(*(int*) ((IntPtr) voidPtr + 4), class190, *(int*) voidPtr);
      Form1.bool_1 = false;
    }

    internal unsafe void method_97(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(5);
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) Form1.bool_2;
      if (*(sbyte*) ((IntPtr) voidPtr + 4) == (sbyte) 0)
        return;
      try
      {
        Class73.smethod_242(this);
        Class19 class190 = Class25.class19_0;
        *(int*) voidPtr = Form1.int_10;
        Class73.smethod_21(1, class190, *(int*) voidPtr);
        Class73.smethod_218(Class25.class19_0, "Başarılar..");
        this.textBox_6.Text = string.Concat((object) Form1.int_10);
        Form1.bool_2 = false;
        this.listBoxControl_0.Items.Remove(this.listBoxControl_0.Items[0]);
        Class73.smethod_96(this, Form1.int_10);
      }
      catch (Exception ex)
      {
        Form1.smethod_0("Unique spawn edilemedi !! HATA ==> " + ex.Message);
      }
    }

    internal void method_98(object sender, EventArgs e)
    {
      try
      {
        SqlDataReader sqlDataReader = new SqlCommand("exec My_EventBot..__PlusLog " + (object) this.int_7, Class65.sqlConnection_0).ExecuteReader();
        sqlDataReader.Read();
        string str1 = Convert.ToString(sqlDataReader[0]);
        string str2 = Convert.ToString(sqlDataReader[1]);
        if ((!(str1 != "SonucYok") || !(str2 != "SonucYok") ? 0 : ((int) Convert.ToInt16(str2) >= (int) Convert.ToInt16(this.comboBox_0.Text) ? 1 : 0)) == 0)
          return;
        Class73.smethod_161(Class25.class19_0, "[" + str1 + "] isimli karakter [Alchemy] etkinliğinde bir iteme +" + str2 + " bastı.");
      }
      catch (Exception ex)
      {
        Form1.smethod_1("[Alchemy] etkinliğinde Plus notice geçmek için plus ve charname alınamadı ! HATA => " + ex.Message, Color.Salmon);
      }
    }

    internal void method_99(object sender, EventArgs e)
    {
      try
      {
        string str = "127.0.0.1";
        Class32.string_0 = str.ToString();
        Class69.string_0 = str.ToString();
        Class19.string_0 = str.ToString();
        Class71.string_0 = str.ToString();
        Class0.string_0 = str.ToString();
        Form1.form1_0.textBox_100.Text = str.ToString();
      }
      catch (Exception ex)
      {
      }
    }

    internal void method_100(object sender, EventArgs e)
    {
      Form1.form1_0.label_13.Text = "127.0.0.1";
    }

    internal void method_101(object sender, EventArgs e)
    {
      Class73.smethod_214(Class25.class19_0);
    }

    internal void method_102(object sender, EventArgs e)
    {
      Class73.smethod_202(Class25.class19_0);
    }

    internal unsafe void method_103(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(48);
      Random random = new Random();
      *(int*) voidPtr = random.Next(111, 999);
      *(int*) ((IntPtr) voidPtr + 4) = random.Next(111, 999);
      *(int*) ((IntPtr) voidPtr + 8) = random.Next(111, 999);
      *(int*) ((IntPtr) voidPtr + 12) = random.Next(111, 999);
      *(int*) ((IntPtr) voidPtr + 16) = random.Next(111, 999);
      *(int*) ((IntPtr) voidPtr + 20) = random.Next(111, 999);
      *(int*) ((IntPtr) voidPtr + 24) = random.Next(111, 999);
      *(int*) ((IntPtr) voidPtr + 28) = random.Next(111, 999);
      *(int*) ((IntPtr) voidPtr + 32) = random.Next(111, 999);
      *(int*) ((IntPtr) voidPtr + 36) = random.Next(111, 999);
      *(int*) ((IntPtr) voidPtr + 40) = random.Next(111, 999);
      *(int*) ((IntPtr) voidPtr + 44) = random.Next(111, 999);
      this.textBox_12.Text = string.Concat((object) *(int*) voidPtr);
      this.textBox_11.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 4));
      this.textBox_16.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 8));
      this.textBox_14.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 12));
      this.textBox_15.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 16));
      this.textBox_54.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 20));
      this.textBox_53.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 24));
      this.textBox_58.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 28));
      this.textBox_57.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 32));
      this.textBox_56.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 36));
      this.comboBox_2.SelectedIndex = 5;
      this.comboBox_0.SelectedIndex = 3;
      this.textBox_25.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 40));
      this.textBox_1.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 28));
      this.textBox_0.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 12));
      this.textBox_5.Text = string.Concat((object) *(int*) voidPtr);
      this.textBox_3.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 44));
      this.textBox_4.Text = string.Concat((object) 8);
      this.textBox_60.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 44));
      this.textBox_59.Text = string.Concat((object) *(int*) voidPtr);
      this.textBox_64.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 4));
      this.textBox_63.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 8));
      this.textBox_62.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 12));
      this.textBox_28.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 16));
      this.textBox_29.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 20));
      this.textBox_27.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 24));
      this.textBox_31.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 28));
      this.textBox_30.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 32));
      Form1.form1_0.textBox_35.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 36));
      Form1.form1_0.textBox_33.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 40));
      Form1.form1_0.textBox_34.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 44));
      this.textBox_40.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 44));
      this.textBox_87.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 40));
      this.textBox_45.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 36));
      this.textBox_46.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 32));
      this.textBox_42.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 28));
      this.textBox_44.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 24));
      this.textBox_50.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 20));
      this.textBox_51.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 16));
      this.textBox_49.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 12));
      this.textBox_78.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 8));
      this.textBox_83.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 4));
      this.textBox_23.Text = string.Concat((object) *(int*) voidPtr);
      this.textBox_21.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 44));
      this.textBox_22.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 40));
      this.textBox_38.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 36));
      this.button_24.Visible = false;
      this.textBox_85.Text = string.Concat((object) *(int*) ((IntPtr) voidPtr + 28));
      this.listBox_10.Items.Clear();
      this.listBox_11.Items.Clear();
      this.listBox_3.Items.Clear();
      this.listBox_4.Items.Clear();
      this.listBox_5.Items.Clear();
      this.listBox_7.Items.Clear();
      this.listBox_9.Items.Clear();
      this.listBox_12.Items.Clear();
      this.listBox_6.Items.Clear();
    }

    internal unsafe void method_104(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      *(sbyte*) voidPtr = (sbyte) (Class65.sqlConnection_0.State != ConnectionState.Open);
      if (*(sbyte*) voidPtr != (sbyte) 0)
        Class65.smethod_5();
      try
      {
        using (SqlDataReader sqlDataReader = new SqlCommand("Select*From My_EventBot.._HayattaKal_List", Class65.sqlConnection_0).ExecuteReader())
        {
          while (true)
          {
            string string_0;
            string str1;
            string str2;
            do
            {
              *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) sqlDataReader.Read();
              if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
              {
                string_0 = Convert.ToString(sqlDataReader[0]);
                str1 = Convert.ToString(sqlDataReader[1]);
                str2 = Convert.ToString(sqlDataReader[2]);
                if ((!(str1 == "KAYIT") ? 0 : (str2 == "DC" ? 1 : 0)) != 0)
                {
                  Form1.smethod_0("[" + string_0 + "] isimli karakter KAYIT sürecinde oyundan çıktığı için event kaydı silindi.");
                  Form1.list_0.Remove(string_0);
                  this.listBox_13.Items.Remove((object) string_0);
                  this.listBox_14.Items.Remove((object) string_0);
                  try
                  {
                    new SqlCommand("Exec My_EventBot..__Hayatta_Kal '" + string_0 + "', 'PKSİL'", Class65.sqlConnection_0).ExecuteNonQuery();
                  }
                  catch (Exception ex)
                  {
                    Form1.smethod_0("[Hayatta Kal] eventi kayıt sırasında DC olan [" + string_0 + "] _Hayatta_Kal tablosuna işlenemedi..");
                    Form1.smethod_0("Hata Açıklaması ==> " + ex.Message);
                  }
                }
                if ((!(str1 == "ICERDE") ? 0 : (str2 == "DC" ? 1 : 0)) != 0)
                {
                  Form1.smethod_0("[" + string_0 + "] isimli karakter event sırasında oyundan çıktığı için diskalifiye oldu");
                  Form1.list_0.Remove(string_0);
                  this.listBox_13.Items.Remove((object) string_0);
                  this.listBox_14.Items.Remove((object) string_0);
                  try
                  {
                    new SqlCommand("Exec My_EventBot..__Hayatta_Kal '" + string_0 + "', 'PKSİL'", Class65.sqlConnection_0).ExecuteNonQuery();
                  }
                  catch (Exception ex)
                  {
                    Form1.smethod_0("[Hayatta Kal] eventi sırasında içerdeyken DC olan [" + string_0 + "] _Hayatta_Kal tablosuna işlenemedi..");
                    Form1.smethod_0("Hata Açıklaması ==> " + ex.Message);
                  }
                }
              }
              else
                goto label_18;
            }
            while ((!(str1 == "KAYIT") ? 0 : (str2 == "INJOB" ? 1 : 0)) == 0);
            Form1.smethod_0("[" + string_0 + "] isimli karakter KAYIT sürecinde JOB moduna geçtiği için event kaydı silindi..");
            Form1.list_0.Remove(string_0);
            this.listBox_13.Items.Remove((object) string_0);
            this.listBox_14.Items.Remove((object) string_0);
            Class73.smethod_123(Class25.class19_0, string_0, "Job moduna geçtiğiniz için LMS kaydınız silindi !!");
            try
            {
              new SqlCommand("Exec My_EventBot..__Hayatta_Kal '" + string_0 + "', 'PKSİL'", Class65.sqlConnection_0).ExecuteNonQuery();
            }
            catch (Exception ex)
            {
              Form1.smethod_0("[LMS] eventi kayıt sürecinde JOB moda geçen [" + string_0 + "]  _Hayatta_Kal tablosuna işlenemedi..");
              Form1.smethod_0("Hata Açıklaması ==> " + ex.Message);
            }
          }
label_18:;
        }
      }
      catch (Exception ex)
      {
        Form1.smethod_0("[Hayatta Kal] etkinliği DC / JOB kontrolü sırasında bir hata oluştu !!");
        Form1.smethod_0("HATA AÇIKLAMASI ==> " + (object) ex);
      }
    }

    internal void method_105(object sender, EventArgs e)
    {
      string text = this.listBox_21.Text;
      switch (Class73.smethod_117(text))
      {
        case 1581100439:
          if (!(text == "party"))
            break;
          this.method_10(3);
          break;
        case 2015182117:
          if (!(text == "uniqkes"))
            break;
          this.method_3();
          break;
        case 2234842375:
          if (!(text == "uniqbul"))
            break;
          this.method_4();
          break;
        case 2256958044:
          if (!(text == "alchemy"))
            break;
          this.method_8();
          break;
        case 3055354200:
          if (!(text == "oylama"))
            break;
          this.method_5();
          break;
        case 3878650203:
          if (!(text == "hayatta"))
            break;
          this.method_12();
          break;
        case 3878869096:
          if (!(text == "gmbul"))
            break;
          this.method_7();
          break;
        case 3906759811:
          if (!(text == "sayı"))
            break;
          this.method_6(3);
          break;
        case 4073677828:
          if (!(text == "soru-cevap"))
            break;
          this.method_9(3);
          break;
      }
    }

    internal unsafe void method_106(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      *(sbyte*) voidPtr = (sbyte) this.checkBox_26.Checked;
      if (*(sbyte*) voidPtr != (sbyte) 0)
      {
        this.panel_2.Enabled = true;
      }
      else
      {
        *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) !this.checkBox_26.Checked;
        if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
          return;
        this.panel_2.Enabled = false;
      }
    }

    internal void method_107(object sender, EventArgs e)
    {
      string selectedText = this.comboBoxEdit_13.SelectedText;
      if (!(selectedText == "TL"))
      {
        if (!(selectedText == "Silk"))
        {
          if (!(selectedText == "Gold"))
          {
            if (!(selectedText == "Sp"))
              return;
            this.string_21 = "Sp";
          }
          else
            this.string_21 = "Gold";
        }
        else
          this.string_21 = "Silk";
      }
      else
        this.string_21 = "TL";
    }

    internal void method_108(object sender, EventArgs e)
    {
      this.method_109();
    }

    public void method_109()
    {
      Form1.Class64 stateMachine = new Form1.Class64();
      stateMachine.form1_0 = this;
      stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
      stateMachine.int_0 = -1;
      stateMachine.asyncVoidMethodBuilder_0.Start<Form1.Class64>(ref stateMachine);
    }

    internal void method_110(object sender, EventArgs e)
    {
    }

    internal void method_111(object sender, EventArgs e)
    {
      if ((Class65.sqlConnection_0 == null || !(this.comboBoxEdit_12.Text != "") ? 0 : (this.comboBoxEdit_12.Text != "Gün Seçin" ? 1 : 0)) != 0)
      {
        try
        {
          string str = this.comboBoxEdit_12.Text + " Saat :" + this.dateTimePicker_9.Text;
          this.listBox_22.Items.Add((object) str);
          new SqlCommand("exec My_EventBot..__Etkinlik_Takvimi 'Piyango','ekle','" + str + "'", Class65.sqlConnection_0).ExecuteNonQuery();
          Form1.smethod_0("Liste ve veritabanına eklendi :   " + str);
        }
        catch (Exception ex)
        {
          if (Class65.sqlConnection_0 == null)
            Form1.smethod_0("SQL bağlantısı kapalı olduğundan işlem gerçekleştirilemedi.!!");
          else
            Form1.smethod_0("Etkinlik tarihini veritabanına eklerken bir hata oluştu. Açıklama ==> " + (object) ex);
        }
      }
      else if ((Class65.sqlConnection_0 != null || !(this.comboBoxEdit_12.Text != "") ? 0 : (this.comboBoxEdit_12.Text != "Gün Seçin" ? 1 : 0)) != 0)
        Form1.smethod_0("SQL bağlantısı kapalı olduğundan işlem gerçekleştirilemedi.!!");
      if ((this.comboBoxEdit_12.Text == "" ? 1 : (this.comboBoxEdit_12.Text == "Gün Seçin" ? 1 : 0)) == 0)
        return;
      Form1.smethod_1("Event Günü Seçilmedi  !!!!!", Color.Salmon);
    }

    internal unsafe void method_112(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(3);
      try
      {
        Form1.string_12 = this.listBox_22.SelectedItem.ToString();
        new SqlCommand("exec My_EventBot..__Etkinlik_Takvimi 'Piyango','sil','" + Form1.string_12 + "'", Class65.sqlConnection_0).ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        *(sbyte*) voidPtr = (sbyte) (this.listBox_22.SelectedItem != null);
        if (*(sbyte*) voidPtr != (sbyte) 0)
          Form1.smethod_0("Liste ve veritabanından silinirken bir hata oluştu. Açıklama ==> " + (object) ex);
      }
      *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (this.listBox_22.SelectedItem != null);
      if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
      {
        this.listBox_22.Items.Remove(this.listBox_22.SelectedItem);
        Form1.smethod_0("Liste ve veritabanından silindi :  " + Form1.string_12);
      }
      else
      {
        *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) (this.listBox_22.SelectedItem == null);
        if (*(sbyte*) ((IntPtr) voidPtr + 2) == (sbyte) 0)
          return;
        Form1.smethod_0("Lütfen silinecek etkinlik tarihi seçin..");
      }
    }

    internal void method_113(object sender, EventArgs e)
    {
    }

    internal unsafe void method_114(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      *(sbyte*) voidPtr = (sbyte) (this.listBoxControl_0.SelectedItem != null);
      if (*(sbyte*) voidPtr != (sbyte) 0)
      {
        try
        {
          using (SqlDataReader sqlDataReader = new SqlCommand("select CodeName128 from SRO_VT_SHARD.._RefObjCommon where ID='" + this.listBoxControl_0.SelectedItem.ToString() + "'", Class65.sqlConnection_0).ExecuteReader())
          {
            sqlDataReader.Read();
            Form1.smethod_0(this.listBoxControl_0.SelectedItem.ToString() + " ID ye ait CodeName128 = " + sqlDataReader[0].ToString());
          }
        }
        catch (Exception ex)
        {
          Form1.smethod_0(this.listBoxControl_0.SelectedItem.ToString() + "numaralı UniqueID' ye ait CodeName128 alınamadı !! HATA => " + ex.Message);
        }
      }
      else
      {
        *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (this.listBoxControl_0.SelectedItem == null);
        if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
          return;
        Form1.smethod_0("CodeName128 Aranacak UniqueID seçiniz..");
      }
    }

    internal void method_115(object sender, CancelEventArgs e)
    {
    }

    internal unsafe void method_116(object sender, EventArgs e)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      *(sbyte*) voidPtr = (sbyte) (this.listBoxControl_0.SelectedItem != null);
      if (*(sbyte*) voidPtr != (sbyte) 0)
      {
        try
        {
          using (SqlDataReader sqlDataReader = new SqlCommand("select CodeName128 from SRO_VT_SHARD.._RefObjCommon where ID='" + this.listBoxControl_0.SelectedItem.ToString() + "'", Class65.sqlConnection_0).ExecuteReader())
          {
            sqlDataReader.Read();
            Form1.smethod_0(this.listBoxControl_0.SelectedItem.ToString() + " ID ye ait CodeName128 = " + sqlDataReader[0].ToString());
          }
        }
        catch (Exception ex)
        {
          Form1.smethod_0(this.listBoxControl_0.SelectedItem.ToString() + "numaralı UniqueID' ye ait CodeName128 alınamadı !! HATA => " + ex.Message);
        }
      }
      else
      {
        *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (this.listBoxControl_0.SelectedItem == null);
        if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
          return;
        Form1.smethod_0("CodeName128 Aranacak UniqueID seçiniz..");
      }
    }

    void XtraForm.Dispose(bool disposing)
    {
      if ((!disposing ? 0 : (this.icontainer_0 != null ? 1 : 0)) != 0)
        this.icontainer_0.Dispose();
      // ISSUE: explicit non-virtual call
      __nonvirtual (((XtraForm) this).Dispose(disposing));
    }

    protected new void Dispose(bool disposing)
    {
    }

    private sealed class Class33 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public object object_0;
      public EventArgs eventArgs_0;
      public Form1 form1_0;
      private TaskAwaiter taskAwaiter_0;

      void IAsyncStateMachine.MoveNext()
      {
        int int0 = this.int_0;
        try
        {
          TaskAwaiter awaiter;
          int num;
          if (int0 != 0)
          {
            this.form1_0.Text = "My_EventBot for Vsro Files  < Cracked by EfsaneSro >";
            Control.CheckForIllegalCrossThreadCalls = false;
            Class73.smethod_85();
            Class73.smethod_237();
            awaiter = Task.Delay(5000).GetAwaiter();
            if (!awaiter.IsCompleted)
            {
              num = 0;
              this.int_0 = 0;
              this.taskAwaiter_0 = awaiter;
              Form1.Class33 stateMachine = this;
              this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class33>(ref awaiter, ref stateMachine);
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

    private sealed class Class34 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public Form1 form1_0;
      private Exception exception_0;
      private TaskAwaiter taskAwaiter_0;

      unsafe void IAsyncStateMachine.MoveNext()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(2);
        int int0 = this.int_0;
        try
        {
          TaskAwaiter awaiter;
          int num1;
          if (int0 == 0)
          {
            awaiter = this.taskAwaiter_0;
            this.taskAwaiter_0 = new TaskAwaiter();
            num1 = -1;
            this.int_0 = -1;
          }
          else
            goto label_7;
label_3:
          awaiter.GetResult();
          awaiter = new TaskAwaiter();
          try
          {
            *(sbyte*) voidPtr = (sbyte) (Class65.sqlConnection_0 == null);
            if (*(sbyte*) voidPtr != (sbyte) 0)
            {
              Form1.smethod_1("SQL BAĞLANTISI KOPTU. PROGRAMI YENİDEN BAŞLATMANIZ GEREKİYOR...", Color.DarkOrange);
              int num2 = (int) MessageBox.Show("SQL BAĞLANTISI KOPTU. PROGRAMI YENİDEN BAŞLATMANIZ GEREKİYOR...");
              goto label_10;
            }
          }
          catch (Exception ex)
          {
            this.exception_0 = ex;
            Form1.smethod_0("SqlKontrol() sistemi başlatılamadı. Hata => " + this.exception_0.Message);
          }
label_7:
          *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) 1;
          awaiter = Task.Delay(1000).GetAwaiter();
          if (!awaiter.IsCompleted)
          {
            num1 = 0;
            this.int_0 = 0;
            this.taskAwaiter_0 = awaiter;
            Form1.Class34 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class34>(ref awaiter, ref stateMachine);
            return;
          }
          goto label_3;
        }
        catch (Exception ex)
        {
          this.int_0 = -2;
          this.asyncVoidMethodBuilder_0.SetException(ex);
          return;
        }
label_10:
        this.int_0 = -2;
        this.asyncVoidMethodBuilder_0.SetResult();
      }

      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }

    private sealed class Class35
    {
      public string string_0;

      internal void method_0()
      {
        Form1.form1_0.richTextBox_0.AppendText(this.string_0);
        Form1.form1_0.richTextBox_0.AppendText(Environment.NewLine);
        Form1.form1_0.richTextBox_0.ScrollToCaret();
      }
    }

    private sealed class Class36
    {
      public string string_0;
      public Color color_0;

      internal void method_0()
      {
        Form1.form1_0.richTextBox_0.smethod_0(this.string_0, this.color_0);
        Form1.form1_0.richTextBox_0.ScrollToCaret();
      }
    }

    internal sealed class Class37
    {
      public Bitmap bitmap_0;

      internal void method_0()
      {
        Form1.form1_0.pictureBox_0.Image = (Image) this.bitmap_0;
      }
    }

    private sealed class Class38 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      private StreamReader streamReader_0;
      private string string_0;
      private string string_1;
      private TaskAwaiter taskAwaiter_0;

      unsafe void IAsyncStateMachine.MoveNext()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(5);
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
          TaskAwaiter awaiter9;
          TaskAwaiter awaiter10;
          TaskAwaiter awaiter11;
          switch (int0)
          {
            case 0:
              awaiter1 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_43;
            case 1:
              awaiter2 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_18;
            case 2:
              awaiter3 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_21;
            case 3:
              awaiter4 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_26;
            case 4:
              awaiter5 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_38;
            case 5:
              awaiter6 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_32;
            case 6:
              awaiter7 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_51;
            case 7:
              awaiter8 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_29;
            case 8:
              awaiter9 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_54;
            case 9:
              awaiter10 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_67;
            case 10:
              awaiter11 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_70;
            default:
              this.streamReader_0 = new StreamReader(Application.StartupPath + "/Ayarlar.ini");
              break;
          }
label_12:
          string str;
          this.string_0 = str = this.streamReader_0.ReadLine();
          *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (str != null);
          if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
          {
            this.string_1 = this.string_0;
            string string1 = this.string_1;
            *(int*) voidPtr = (int) Class73.smethod_117(string1);
            if (*(uint*) voidPtr <= 894050548U)
            {
              if (*(uint*) voidPtr <= 276761501U)
              {
                if (*(uint*) voidPtr != 149484163U)
                {
                  if (*(uint*) voidPtr == 276761501U && string1 == "[UNİQUE_BULMA]")
                  {
                    Form1.form1_0.comboBoxEdit_0.SelectedItem = (object) this.streamReader_0.ReadLine().Split('=')[1];
                    Form1.form1_0.checkBox_4.Checked = (Convert.ToBoolean(this.streamReader_0.ReadLine().Split('=')[1]) ? 1 : 0) != 0;
                    Form1.form1_0.checkBox_3.Checked = (Convert.ToBoolean(this.streamReader_0.ReadLine().Split('=')[1]) ? 1 : 0) != 0;
                    Form1.form1_0.textBox_13.Text = this.streamReader_0.ReadLine().Split('=')[1];
                    Form1.form1_0.textBox_12.Text = this.streamReader_0.ReadLine().Split('=')[1];
                    Form1.form1_0.textBox_11.Text = this.streamReader_0.ReadLine().Split('=')[1];
                    Form1.form1_0.textBox_16.Text = this.streamReader_0.ReadLine().Split('=')[1];
                    Form1.form1_0.textBox_14.Text = this.streamReader_0.ReadLine().Split('=')[1];
                    Form1.form1_0.textBox_15.Text = this.streamReader_0.ReadLine().Split('=')[1];
                    Form1.form1_0.textBox_92.Text = this.streamReader_0.ReadLine().Split('=')[1];
                    awaiter2 = Task.Delay(300).GetAwaiter();
                    if (!awaiter2.IsCompleted)
                    {
                      num = 1;
                      this.int_0 = 1;
                      this.taskAwaiter_0 = awaiter2;
                      Form1.Class38 stateMachine = this;
                      this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class38>(ref awaiter2, ref stateMachine);
                      return;
                    }
                  }
                  else
                    goto label_52;
                }
                else if (string1 == "[GM_BULMA]")
                {
                  Form1.form1_0.comboBoxEdit_1.SelectedItem = (object) this.streamReader_0.ReadLine().Split('=')[1];
                  Form1.form1_0.checkBox_16.Checked = (Convert.ToBoolean(this.streamReader_0.ReadLine().Split('=')[1]) ? 1 : 0) != 0;
                  Form1.form1_0.checkBox_15.Checked = (Convert.ToBoolean(this.streamReader_0.ReadLine().Split('=')[1]) ? 1 : 0) != 0;
                  Form1.form1_0.textBox_55.Text = this.streamReader_0.ReadLine().Split('=')[1];
                  Form1.form1_0.textBox_54.Text = this.streamReader_0.ReadLine().Split('=')[1];
                  Form1.form1_0.textBox_53.Text = this.streamReader_0.ReadLine().Split('=')[1];
                  Form1.form1_0.textBox_58.Text = this.streamReader_0.ReadLine().Split('=')[1];
                  Form1.form1_0.textBox_56.Text = this.streamReader_0.ReadLine().Split('=')[1];
                  Form1.form1_0.textBox_57.Text = this.streamReader_0.ReadLine().Split('=')[1];
                  Form1.form1_0.textBox_93.Text = this.streamReader_0.ReadLine().Split('=')[1];
                  awaiter3 = Task.Delay(300).GetAwaiter();
                  if (!awaiter3.IsCompleted)
                  {
                    num = 2;
                    this.int_0 = 2;
                    this.taskAwaiter_0 = awaiter3;
                    Form1.Class38 stateMachine = this;
                    this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class38>(ref awaiter3, ref stateMachine);
                    return;
                  }
                  goto label_21;
                }
                else
                  goto label_52;
              }
              else if (*(uint*) voidPtr != 540882651U)
              {
                if (*(uint*) voidPtr != 546772813U)
                {
                  if (*(uint*) voidPtr == 894050548U && string1 == "[ALCHEMY]")
                  {
                    Form1.form1_0.comboBox_2.Text = this.streamReader_0.ReadLine().Split('=')[1];
                    Form1.form1_0.comboBox_0.Text = this.streamReader_0.ReadLine().Split('=')[1];
                    Form1.form1_0.textBox_25.Text = this.streamReader_0.ReadLine().Split('=')[1];
                    Form1.form1_0.checkBox_18.Checked = (Convert.ToBoolean(this.streamReader_0.ReadLine().Split('=')[1]) ? 1 : 0) != 0;
                    Form1.form1_0.checkBox_17.Checked = (Convert.ToBoolean(this.streamReader_0.ReadLine().Split('=')[1]) ? 1 : 0) != 0;
                    Form1.form1_0.textBox_61.Text = this.streamReader_0.ReadLine().Split('=')[1];
                    Form1.form1_0.textBox_60.Text = this.streamReader_0.ReadLine().Split('=')[1];
                    Form1.form1_0.textBox_59.Text = this.streamReader_0.ReadLine().Split('=')[1];
                    Form1.form1_0.textBox_64.Text = this.streamReader_0.ReadLine().Split('=')[1];
                    Form1.form1_0.textBox_62.Text = this.streamReader_0.ReadLine().Split('=')[1];
                    Form1.form1_0.textBox_63.Text = this.streamReader_0.ReadLine().Split('=')[1];
                    Form1.form1_0.textBox_94.Text = this.streamReader_0.ReadLine().Split('=')[1];
                    awaiter4 = Task.Delay(300).GetAwaiter();
                    if (!awaiter4.IsCompleted)
                    {
                      num = 3;
                      this.int_0 = 3;
                      this.taskAwaiter_0 = awaiter4;
                      Form1.Class38 stateMachine = this;
                      this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class38>(ref awaiter4, ref stateMachine);
                      return;
                    }
                    goto label_26;
                  }
                  else
                    goto label_52;
                }
                else if (string1 == "[HAYATTA KAL]")
                {
                  Form1.form1_0.textBox_82.Text = this.streamReader_0.ReadLine().Split('=')[1];
                  Form1.form1_0.textBox_81.Text = this.streamReader_0.ReadLine().Split('=')[1];
                  Form1.form1_0.textBox_78.Text = this.streamReader_0.ReadLine().Split('=')[1];
                  Form1.form1_0.textBox_17.Text = this.streamReader_0.ReadLine().Split('=')[1];
                  Form1.form1_0.textBox_83.Text = this.streamReader_0.ReadLine().Split('=')[1];
                  Form1.form1_0.checkBox_7.Checked = (Convert.ToBoolean(this.streamReader_0.ReadLine().Split('=')[1]) ? 1 : 0) != 0;
                  Form1.form1_0.checkBox_6.Checked = (Convert.ToBoolean(this.streamReader_0.ReadLine().Split('=')[1]) ? 1 : 0) != 0;
                  Form1.form1_0.textBox_20.Text = this.streamReader_0.ReadLine().Split('=')[1];
                  Form1.form1_0.textBox_19.Text = this.streamReader_0.ReadLine().Split('=')[1];
                  Form1.form1_0.textBox_18.Text = this.streamReader_0.ReadLine().Split('=')[1];
                  Form1.form1_0.textBox_23.Text = this.streamReader_0.ReadLine().Split('=')[1];
                  Form1.form1_0.textBox_21.Text = this.streamReader_0.ReadLine().Split('=')[1];
                  Form1.form1_0.textBox_22.Text = this.streamReader_0.ReadLine().Split('=')[1];
                  Form1.form1_0.textBox_98.Text = this.streamReader_0.ReadLine().Split('=')[1];
                  awaiter8 = Task.Delay(300).GetAwaiter();
                  if (!awaiter8.IsCompleted)
                  {
                    num = 7;
                    this.int_0 = 7;
                    this.taskAwaiter_0 = awaiter8;
                    Form1.Class38 stateMachine = this;
                    this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class38>(ref awaiter8, ref stateMachine);
                    return;
                  }
                  goto label_29;
                }
                else
                  goto label_52;
              }
              else if (string1 == "[PARTY FORM]")
              {
                Form1.form1_0.textBox_40.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textBox_41.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textBox_87.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.checkBox_14.Checked = (Convert.ToBoolean(this.streamReader_0.ReadLine().Split('=')[1]) ? 1 : 0) != 0;
                Form1.form1_0.checkBox_13.Checked = (Convert.ToBoolean(this.streamReader_0.ReadLine().Split('=')[1]) ? 1 : 0) != 0;
                Form1.form1_0.textBox_47.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textBox_46.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textBox_45.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textBox_43.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textBox_42.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textBox_44.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textBox_96.Text = this.streamReader_0.ReadLine().Split('=')[1];
                awaiter6 = Task.Delay(300).GetAwaiter();
                if (!awaiter6.IsCompleted)
                {
                  num = 5;
                  this.int_0 = 5;
                  this.taskAwaiter_0 = awaiter6;
                  Form1.Class38 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class38>(ref awaiter6, ref stateMachine);
                  return;
                }
                goto label_32;
              }
              else
                goto label_52;
            }
            else if (*(uint*) voidPtr <= 1513517158U)
            {
              if (*(uint*) voidPtr != 1212728843U)
              {
                if (*(uint*) voidPtr != 1393968812U)
                {
                  if (*(uint*) voidPtr == 1513517158U && string1 == "[SORU-CEVAP]")
                  {
                    Form1.form1_0.textBox_28.Text = this.streamReader_0.ReadLine().Split('=')[1];
                    Form1.form1_0.textBox_29.Text = this.streamReader_0.ReadLine().Split('=')[1];
                    Form1.form1_0.textBox_27.Text = this.streamReader_0.ReadLine().Split('=')[1];
                    Form1.form1_0.checkBox_11.Checked = (Convert.ToBoolean(this.streamReader_0.ReadLine().Split('=')[1]) ? 1 : 0) != 0;
                    Form1.form1_0.checkBox_10.Checked = (Convert.ToBoolean(this.streamReader_0.ReadLine().Split('=')[1]) ? 1 : 0) != 0;
                    Form1.form1_0.textBox_32.Text = this.streamReader_0.ReadLine().Split('=')[1];
                    Form1.form1_0.textBox_31.Text = this.streamReader_0.ReadLine().Split('=')[1];
                    Form1.form1_0.textBox_30.Text = this.streamReader_0.ReadLine().Split('=')[1];
                    Form1.form1_0.textBox_35.Text = this.streamReader_0.ReadLine().Split('=')[1];
                    Form1.form1_0.textBox_33.Text = this.streamReader_0.ReadLine().Split('=')[1];
                    Form1.form1_0.textBox_34.Text = this.streamReader_0.ReadLine().Split('=')[1];
                    Form1.form1_0.textBox_95.Text = this.streamReader_0.ReadLine().Split('=')[1];
                    awaiter5 = Task.Delay(300).GetAwaiter();
                    if (!awaiter5.IsCompleted)
                    {
                      num = 4;
                      this.int_0 = 4;
                      this.taskAwaiter_0 = awaiter5;
                      Form1.Class38 stateMachine = this;
                      this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class38>(ref awaiter5, ref stateMachine);
                      return;
                    }
                    goto label_38;
                  }
                  else
                    goto label_52;
                }
                else if (string1 == "[PIYANGO]")
                {
                  Form1.form1_0.comboBoxEdit_13.Text = this.streamReader_0.ReadLine().Split('=')[1];
                  Form1.form1_0.textBox_103.Text = this.streamReader_0.ReadLine().Split('=')[1];
                  Form1.smethod_1("Ayarlar Yüklendi ==> [PIYANGO]", Color.Salmon);
                  goto label_52;
                }
                else
                  goto label_52;
              }
              else if (string1 == "[UNİQUE_KESME]")
              {
                Form1.form1_0.comboBoxEdit_2.SelectedItem = (object) this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textBox_8.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textBox_7.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.checkBox_1.Checked = (Convert.ToBoolean(this.streamReader_0.ReadLine().Split('=')[1]) ? 1 : 0) != 0;
                Form1.form1_0.checkBox_0.Checked = (Convert.ToBoolean(this.streamReader_0.ReadLine().Split('=')[1]) ? 1 : 0) != 0;
                Form1.form1_0.textBox_2.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textBox_1.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textBox_0.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textBox_5.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textBox_3.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textBox_4.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textBox_91.Text = this.streamReader_0.ReadLine().Split('=')[1];
                awaiter1 = Task.Delay(300).GetAwaiter();
                if (!awaiter1.IsCompleted)
                {
                  num = 0;
                  this.int_0 = 0;
                  this.taskAwaiter_0 = awaiter1;
                  Form1.Class38 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class38>(ref awaiter1, ref stateMachine);
                  return;
                }
                goto label_43;
              }
              else
                goto label_52;
            }
            else if (*(uint*) voidPtr != 2141189652U)
            {
              if (*(uint*) voidPtr != 3197393124U)
              {
                if (*(uint*) voidPtr == 3301730198U && string1 == "[OYLAMA]")
                {
                  Form1.form1_0.textBox_39.Text = this.streamReader_0.ReadLine().Split('=')[1];
                  Form1.form1_0.textBox_38.Text = this.streamReader_0.ReadLine().Split('=')[1];
                  Form1.form1_0.comboBox_1.Text = this.streamReader_0.ReadLine().Split('=')[1];
                  Form1.form1_0.checkEdit_6.Checked = (Convert.ToBoolean(this.streamReader_0.ReadLine().Split('=')[1]) ? 1 : 0) != 0;
                  Form1.form1_0.checkEdit_8.Checked = (Convert.ToBoolean(this.streamReader_0.ReadLine().Split('=')[1]) ? 1 : 0) != 0;
                  Form1.form1_0.checkEdit_7.Checked = (Convert.ToBoolean(this.streamReader_0.ReadLine().Split('=')[1]) ? 1 : 0) != 0;
                  Form1.form1_0.checkEdit_5.Checked = (Convert.ToBoolean(this.streamReader_0.ReadLine().Split('=')[1]) ? 1 : 0) != 0;
                  Form1.form1_0.checkEdit_2.Checked = (Convert.ToBoolean(this.streamReader_0.ReadLine().Split('=')[1]) ? 1 : 0) != 0;
                  Form1.form1_0.checkEdit_4.Checked = (Convert.ToBoolean(this.streamReader_0.ReadLine().Split('=')[1]) ? 1 : 0) != 0;
                  Form1.form1_0.checkEdit_3.Checked = (Convert.ToBoolean(this.streamReader_0.ReadLine().Split('=')[1]) ? 1 : 0) != 0;
                  Form1.form1_0.checkEdit_1.Checked = (Convert.ToBoolean(this.streamReader_0.ReadLine().Split('=')[1]) ? 1 : 0) != 0;
                  Form1.form1_0.checkEdit_11.Checked = (Convert.ToBoolean(this.streamReader_0.ReadLine().Split('=')[1]) ? 1 : 0) != 0;
                  awaiter9 = Task.Delay(300).GetAwaiter();
                  if (!awaiter9.IsCompleted)
                  {
                    num = 8;
                    this.int_0 = 8;
                    this.taskAwaiter_0 = awaiter9;
                    Form1.Class38 stateMachine = this;
                    this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class38>(ref awaiter9, ref stateMachine);
                    return;
                  }
                  goto label_54;
                }
                else
                  goto label_52;
              }
              else if (string1 == "[GENEL]")
              {
                Form1.string_23 = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textEdit_13.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textEdit_14.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textEdit_12.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textEdit_11.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textEdit_10.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textEdit_9.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textEdit_17.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textBox_89.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textBox_90.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textEdit_16.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textEdit_15.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.form1_0.textEdit_18.Text = this.streamReader_0.ReadLine().Split('=')[1];
                Form1.smethod_1("Ayarlar Yüklendi ==> [GENEL]", Color.Salmon);
                goto label_52;
              }
              else
                goto label_52;
            }
            else if (string1 == "[SAYI BULMA]")
            {
              Form1.form1_0.textBox_50.Text = this.streamReader_0.ReadLine().Split('=')[1];
              Form1.form1_0.textBox_51.Text = this.streamReader_0.ReadLine().Split('=')[1];
              Form1.form1_0.textBox_49.Text = this.streamReader_0.ReadLine().Split('=')[1];
              Form1.form1_0.checkBox_20.Checked = (Convert.ToBoolean(this.streamReader_0.ReadLine().Split('=')[1]) ? 1 : 0) != 0;
              Form1.form1_0.checkBox_19.Checked = (Convert.ToBoolean(this.streamReader_0.ReadLine().Split('=')[1]) ? 1 : 0) != 0;
              Form1.form1_0.textBox_75.Text = this.streamReader_0.ReadLine().Split('=')[1];
              Form1.form1_0.textBox_74.Text = this.streamReader_0.ReadLine().Split('=')[1];
              Form1.form1_0.textBox_73.Text = this.streamReader_0.ReadLine().Split('=')[1];
              Form1.form1_0.textBox_71.Text = this.streamReader_0.ReadLine().Split('=')[1];
              Form1.form1_0.textBox_70.Text = this.streamReader_0.ReadLine().Split('=')[1];
              Form1.form1_0.textBox_72.Text = this.streamReader_0.ReadLine().Split('=')[1];
              Form1.form1_0.textBox_97.Text = this.streamReader_0.ReadLine().Split('=')[1];
              awaiter7 = Task.Delay(300).GetAwaiter();
              if (!awaiter7.IsCompleted)
              {
                num = 6;
                this.int_0 = 6;
                this.taskAwaiter_0 = awaiter7;
                Form1.Class38 stateMachine = this;
                this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class38>(ref awaiter7, ref stateMachine);
                return;
              }
              goto label_51;
            }
            else
              goto label_52;
          }
          else
          {
            awaiter10 = Task.Delay(1000).GetAwaiter();
            if (!awaiter10.IsCompleted)
            {
              num = 9;
              this.int_0 = 9;
              this.taskAwaiter_0 = awaiter10;
              Form1.Class38 stateMachine = this;
              this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class38>(ref awaiter10, ref stateMachine);
              return;
            }
            goto label_67;
          }
label_18:
          awaiter2.GetResult();
          awaiter2 = new TaskAwaiter();
          Form1.smethod_1("Ayarlar Yüklendi ==> [UNİQUE_BULMA]", Color.Salmon);
          goto label_52;
label_21:
          awaiter3.GetResult();
          awaiter3 = new TaskAwaiter();
          Form1.smethod_1("Ayarlar Yüklendi ==> [KAYIP GM]", Color.Salmon);
          goto label_52;
label_26:
          awaiter4.GetResult();
          awaiter4 = new TaskAwaiter();
          Form1.smethod_1("Ayarlar Yüklendi ==> [ALCHEMY]", Color.Salmon);
          goto label_52;
label_29:
          awaiter8.GetResult();
          awaiter8 = new TaskAwaiter();
          Form1.smethod_1("Ayarlar Yüklendi ==> [HAYATTA KAL]", Color.Salmon);
          goto label_52;
label_32:
          awaiter6.GetResult();
          awaiter6 = new TaskAwaiter();
          Form1.smethod_1("Ayarlar Yüklendi ==> [PARTY FORM]", Color.Salmon);
          goto label_52;
label_38:
          awaiter5.GetResult();
          awaiter5 = new TaskAwaiter();
          Form1.smethod_1("Ayarlar Yüklendi ==> [SORU-CEVAP]", Color.Salmon);
          goto label_52;
label_43:
          awaiter1.GetResult();
          awaiter1 = new TaskAwaiter();
          Form1.smethod_1("Ayarlar Yüklendi ==> [UNİQUE_KESME]", Color.Salmon);
          goto label_52;
label_51:
          awaiter7.GetResult();
          awaiter7 = new TaskAwaiter();
          Form1.smethod_1("Ayarlar Yüklendi ==> [SAYI BULMA]", Color.Salmon);
label_52:
          this.string_1 = (string) null;
          goto label_12;
label_54:
          awaiter9.GetResult();
          awaiter9 = new TaskAwaiter();
          Form1.smethod_1("Ayarlar Yüklendi ==> [OYLAMA]", Color.Salmon);
          goto label_52;
label_67:
          awaiter10.GetResult();
          awaiter10 = new TaskAwaiter();
          Form1.smethod_0("Ayarlar Başarıyla Yüklendi...");
          this.streamReader_0.Close();
          awaiter11 = Task.Delay(3000).GetAwaiter();
          if (!awaiter11.IsCompleted)
          {
            num = 10;
            this.int_0 = 10;
            this.taskAwaiter_0 = awaiter11;
            Form1.Class38 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class38>(ref awaiter11, ref stateMachine);
            return;
          }
label_70:
          awaiter11.GetResult();
          awaiter11 = new TaskAwaiter();
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

    private sealed class Class39 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      private string string_0;
      private TextWriter textWriter_0;
      private TaskAwaiter taskAwaiter_0;

      void IAsyncStateMachine.MoveNext()
      {
        int int0 = this.int_0;
        try
        {
          TaskAwaiter awaiter;
          int num;
          if (int0 != 0)
          {
            Form1.form1_0.Text = "My_EventBot VSRo 1.88  ---  Cracked by EfsaneSro";
            this.string_0 = Application.StartupPath;
            if (!File.Exists(this.string_0 + "/Ayarlar.ini"))
            {
              File.Create(this.string_0 + "/Ayarlar.ini").Close();
              this.textWriter_0 = (TextWriter) new StreamWriter(this.string_0 + "/Ayarlar.ini");
              this.textWriter_0.WriteLine("**********************************// My_EventBot VSRo 1.88 //*****************************");
              this.textWriter_0.WriteLine("");
              this.textWriter_0.WriteLine("              **************GENEL AYARLAR******************");
              this.textWriter_0.WriteLine("[GENEL]");
              this.textWriter_0.WriteLine("LANG=TR");
              this.textWriter_0.WriteLine("HOST=.\\SQLEXPRESS");
              this.textWriter_0.WriteLine("USER=sa");
              this.textWriter_0.WriteLine("PASS=12345");
              this.textWriter_0.WriteLine("SHARD=SRO_VT_SHARD");
              this.textWriter_0.WriteLine("ACC=SRO_VT_ACCOUNT");
              this.textWriter_0.WriteLine("LOG=SRO_VT_LOG");
              this.textWriter_0.WriteLine("IP=127.0.0.1");
              this.textWriter_0.WriteLine("PORT=15779");
              this.textWriter_0.WriteLine("CAPTCHA=MY");
              this.textWriter_0.WriteLine("ID=CharID");
              this.textWriter_0.WriteLine("PW=CharPW");
              this.textWriter_0.WriteLine("CHARNAME=My_EventBot");
              this.textWriter_0.WriteLine("           ************** UNİQUE KESME ETKİNLİĞİ ******************");
              this.textWriter_0.WriteLine("[UNİQUE_KESME]");
              this.textWriter_0.WriteLine("EVENT_BOLGE=Jangan");
              this.textWriter_0.WriteLine("ZERK_UNQ_ID=22519");
              this.textWriter_0.WriteLine("ZERK_UNQ_ADET=5");
              this.textWriter_0.WriteLine("ODUL_TIPI_ITEM=False");
              this.textWriter_0.WriteLine("ODUL_TIPI_SGSR=False");
              this.textWriter_0.WriteLine("ODUL_ITEM_KODU=ITEM_CH_SWORD_01_C_RARE");
              this.textWriter_0.WriteLine("ODUL_ITEM_ADET=1");
              this.textWriter_0.WriteLine("ODUL_ITEM_PLUS=1");
              this.textWriter_0.WriteLine("ODUL_SGSR_SILK=0");
              this.textWriter_0.WriteLine("ODUL_SGSR_GOLD=0");
              this.textWriter_0.WriteLine("ODUL_SGSR_SP=0");
              this.textWriter_0.WriteLine("ODUL_ITEM_ACIKLAMA=Sun Sword(1 Dg)");
              this.textWriter_0.WriteLine("           ************** UNİQUE BULMA ETKİNLİĞİ ******************");
              this.textWriter_0.WriteLine("[UNİQUE_BULMA]");
              this.textWriter_0.WriteLine("EVENT_BOLGE=Jangan");
              this.textWriter_0.WriteLine("ODUL_TIPI_ITEM=False");
              this.textWriter_0.WriteLine("ODUL_TIPI_SGSR=False");
              this.textWriter_0.WriteLine("ODUL_ITEM_KODU=ITEM_CH_SWORD_01_C_RARE");
              this.textWriter_0.WriteLine("ODUL_ITEM_ADET=1");
              this.textWriter_0.WriteLine("ODUL_ITEM_PLUS=1");
              this.textWriter_0.WriteLine("ODUL_SGSR_SILK=0");
              this.textWriter_0.WriteLine("ODUL_SGSR_GOLD=0");
              this.textWriter_0.WriteLine("ODUL_SGSR_SP=0");
              this.textWriter_0.WriteLine("ODUL_ITEM_ACIKLAMA=Sun Sword(1 Dg)");
              this.textWriter_0.WriteLine("           ************** GM BULMA ETKİNLİĞİ ******************");
              this.textWriter_0.WriteLine("[GM_BULMA]");
              this.textWriter_0.WriteLine("EVENT_BOLGE=Jangan");
              this.textWriter_0.WriteLine("ODUL_TIPI_ITEM=False");
              this.textWriter_0.WriteLine("ODUL_TIPI_SGSR=False");
              this.textWriter_0.WriteLine("ODUL_ITEM_KODU=ITEM_CH_SWORD_01_C_RARE");
              this.textWriter_0.WriteLine("ODUL_ITEM_ADET=1");
              this.textWriter_0.WriteLine("ODUL_ITEM_PLUS=1");
              this.textWriter_0.WriteLine("ODUL_SGSR_SILK=0");
              this.textWriter_0.WriteLine("ODUL_SGSR_GOLD=0");
              this.textWriter_0.WriteLine("ODUL_SGSR_SP=0");
              this.textWriter_0.WriteLine("ODUL_ITEM_ACIKLAMA=Sun Sword(1 Dg)");
              this.textWriter_0.WriteLine("           ************** ALCHEMY ETKİNLİĞİ ******************");
              this.textWriter_0.WriteLine("[ALCHEMY]");
              this.textWriter_0.WriteLine("DROP_PLUS=0");
              this.textWriter_0.WriteLine("ARANAN_PLUS=5");
              this.textWriter_0.WriteLine("DROP_ADET=30");
              this.textWriter_0.WriteLine("ODUL_TIPI_ITEM=False");
              this.textWriter_0.WriteLine("ODUL_TIPI_SGSR=False");
              this.textWriter_0.WriteLine("ODUL_ITEM_KODU=ITEM_CH_SWORD_01_C_RARE");
              this.textWriter_0.WriteLine("ODUL_ITEM_ADET=1");
              this.textWriter_0.WriteLine("ODUL_ITEM_PLUS=1");
              this.textWriter_0.WriteLine("ODUL_SGSR_SILK=0");
              this.textWriter_0.WriteLine("ODUL_SGSR_GOLD=0");
              this.textWriter_0.WriteLine("ODUL_SGSR_SP=0");
              this.textWriter_0.WriteLine("ODUL_ITEM_ACIKLAMA=Sun Sword(1 Dg)");
              this.textWriter_0.WriteLine("           ************** SORU-CEVAP ETKİNLİĞİ ******************");
              this.textWriter_0.WriteLine("[SORU-CEVAP]");
              this.textWriter_0.WriteLine("TOPLAM_SORU=3");
              this.textWriter_0.WriteLine("CEVAP_BEKLEME_SURESI=60");
              this.textWriter_0.WriteLine("SORULAR_ARASI_SURE=30");
              this.textWriter_0.WriteLine("ODUL_TIPI_ITEM=False");
              this.textWriter_0.WriteLine("ODUL_TIPI_SGSR=False");
              this.textWriter_0.WriteLine("ODUL_ITEM_KODU=ITEM_CH_SWORD_01_C_RARE");
              this.textWriter_0.WriteLine("ODUL_ITEM_ADET=1");
              this.textWriter_0.WriteLine("ODUL_ITEM_PLUS=1");
              this.textWriter_0.WriteLine("ODUL_SGSR_SILK=0");
              this.textWriter_0.WriteLine("ODUL_SGSR_GOLD=0");
              this.textWriter_0.WriteLine("ODUL_SGSR_SP=0");
              this.textWriter_0.WriteLine("ODUL_ITEM_ACIKLAMA=Sun Sword(1 Dg)");
              this.textWriter_0.WriteLine("           ************** PARTY FORM ETKİNLİĞİ ******************");
              this.textWriter_0.WriteLine("[PARTY FORM]");
              this.textWriter_0.WriteLine("ETKNLK_RAUND=3");
              this.textWriter_0.WriteLine("ARANAN_PT_ARTI=100");
              this.textWriter_0.WriteLine("RAUND_BEKLEME_SANIYE=200");
              this.textWriter_0.WriteLine("ODUL_TIPI_ITEM=False");
              this.textWriter_0.WriteLine("ODUL_TIPI_SGSR=False");
              this.textWriter_0.WriteLine("ODUL_ITEM_KODU=ITEM_CH_SWORD_01_C_RARE");
              this.textWriter_0.WriteLine("ODUL_ITEM_ADET=1");
              this.textWriter_0.WriteLine("ODUL_ITEM_PLUS=1");
              this.textWriter_0.WriteLine("ODUL_SGSR_SILK=0");
              this.textWriter_0.WriteLine("ODUL_SGSR_GOLD=0");
              this.textWriter_0.WriteLine("ODUL_SGSR_SP=0");
              this.textWriter_0.WriteLine("ODUL_ITEM_ACIKLAMA=Sun Sword(1 Dg)");
              this.textWriter_0.WriteLine("           ************** SAYI BULMA ETKİNLİĞİ ******************");
              this.textWriter_0.WriteLine("[SAYI BULMA]");
              this.textWriter_0.WriteLine("ETKNLK_RAUND=3");
              this.textWriter_0.WriteLine("RSTGL_SAYI_1=100");
              this.textWriter_0.WriteLine("RSTGL_SAYI_2=250");
              this.textWriter_0.WriteLine("ODUL_TIPI_ITEM=False");
              this.textWriter_0.WriteLine("ODUL_TIPI_SGSR=False");
              this.textWriter_0.WriteLine("ODUL_ITEM_KODU=ITEM_CH_SWORD_01_C_RARE");
              this.textWriter_0.WriteLine("ODUL_ITEM_ADET=1");
              this.textWriter_0.WriteLine("ODUL_ITEM_PLUS=1");
              this.textWriter_0.WriteLine("ODUL_SGSR_SILK=0");
              this.textWriter_0.WriteLine("ODUL_SGSR_GOLD=0");
              this.textWriter_0.WriteLine("ODUL_SGSR_SP=0");
              this.textWriter_0.WriteLine("ODUL_ITEM_ACIKLAMA=Sun Sword(1 Dg)");
              this.textWriter_0.WriteLine("           ************** HAYATTA KAL ETKİNLİĞİ ******************");
              this.textWriter_0.WriteLine("[HAYATTA KAL]");
              this.textWriter_0.WriteLine("KOORDINAT_X=4878");
              this.textWriter_0.WriteLine("KOORDINAT_Y=0");
              this.textWriter_0.WriteLine("BASLAMA_MINUMUM_KATILIMCI=16");
              this.textWriter_0.WriteLine("ICERI_ALINACAK_MAX_KATILIMCI=32");
              this.textWriter_0.WriteLine("ALT_LVL_SINIRI=20");
              this.textWriter_0.WriteLine("ODUL_TIPI_ITEM=False");
              this.textWriter_0.WriteLine("ODUL_TIPI_SGSR=False");
              this.textWriter_0.WriteLine("ODUL_ITEM_KODU=ITEM_CH_SWORD_01_C_RARE");
              this.textWriter_0.WriteLine("ODUL_ITEM_ADET=1");
              this.textWriter_0.WriteLine("ODUL_ITEM_PLUS=1");
              this.textWriter_0.WriteLine("ODUL_SGSR_SILK=0");
              this.textWriter_0.WriteLine("ODUL_SGSR_GOLD=0");
              this.textWriter_0.WriteLine("ODUL_SGSR_SP=0");
              this.textWriter_0.WriteLine("ODUL_ITEM_ACIKLAMA=Sun Sword(1 Dg)");
              this.textWriter_0.WriteLine("           ************** OYLAMA ETKİNLİĞİ ******************");
              this.textWriter_0.WriteLine("[OYLAMA]");
              this.textWriter_0.WriteLine("GEREKLI_KATILIMCI=5");
              this.textWriter_0.WriteLine("BEKLENECEK_SURE=60");
              this.textWriter_0.WriteLine("YTRSZ_KTLM_ETKNLK=False");
              this.textWriter_0.WriteLine("OYL_DHL_ETKNLK_1=False");
              this.textWriter_0.WriteLine("OYL_DHL_ETKNLK_2=False");
              this.textWriter_0.WriteLine("OYL_DHL_ETKNLK_3=False");
              this.textWriter_0.WriteLine("OYL_DHL_ETKNLK_4=False");
              this.textWriter_0.WriteLine("OYL_DHL_ETKNLK_5=False");
              this.textWriter_0.WriteLine("OYL_DHL_ETKNLK_6=False");
              this.textWriter_0.WriteLine("OYL_DHL_ETKNLK_7=False");
              this.textWriter_0.WriteLine("OYL_DHL_ETKNLK_8=True");
              this.textWriter_0.WriteLine("OYL_DHL_ETKNLK_9=True");
              this.textWriter_0.WriteLine("           ************** PIYANGO ETKİNLİĞİ ******************");
              this.textWriter_0.WriteLine("[PIYANGO]");
              this.textWriter_0.WriteLine("CEKILIS_TURU=Gold");
              this.textWriter_0.WriteLine("CEKILIS_MIKTARI=1000000");
              this.textWriter_0.WriteLine("");
              this.textWriter_0.WriteLine("");
              this.textWriter_0.WriteLine("**********************************// My_EventBot //*****************************");
              this.textWriter_0.Flush();
              this.textWriter_0.Close();
              Form1.smethod_1("Dosya oluşturma başarılı ==> Ayarlar.ini", Color.Salmon);
              awaiter = Task.Delay(3000).GetAwaiter();
              if (!awaiter.IsCompleted)
              {
                num = 0;
                this.int_0 = 0;
                this.taskAwaiter_0 = awaiter;
                Form1.Class39 stateMachine = this;
                this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class39>(ref awaiter, ref stateMachine);
                return;
              }
            }
            else
              goto label_8;
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
          this.textWriter_0 = (TextWriter) null;
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

    private sealed class Class40 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public Form1 form1_0;
      private string string_0;
      private string string_1;
      private TaskAwaiter taskAwaiter_0;

      unsafe void IAsyncStateMachine.MoveNext()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(11);
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
              goto label_39;
            case 2:
              awaiter3 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_42;
            case 3:
              awaiter4 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_45;
            case 4:
              awaiter5 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_49;
            case 5:
              awaiter6 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_52;
            default:
              *(sbyte*) voidPtr = (sbyte) (Class73.smethod_129(this.form1_0.label_13.Text) == Class32.string_0);
              if (*(sbyte*) voidPtr != (sbyte) 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (this.form1_0.label_160.Text == "ONLİNE");
                if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
                {
                  *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) (this.form1_0.label_160.Text == "OFFLİNE");
                  if (*(sbyte*) ((IntPtr) voidPtr + 2) != (sbyte) 0)
                  {
                    this.form1_0.method_2((object) this.form1_0.button_19, new EventArgs());
                    Class73.smethod_118("[Unique Kesme]", this.form1_0);
                    goto label_55;
                  }
                }
                this.string_0 = "";
                this.string_1 = "";
                if ((this.form1_0.textBox_91.Text != "" ? 1 : (this.form1_0.textBox_91.Text != "Sun Sword ( 1 Dg )" ? 1 : 0)) != 0)
                  this.string_1 = this.form1_0.textBox_91.Text ?? "";
                if ((this.form1_0.textBox_91.Text == "" ? 1 : (this.form1_0.textBox_91.Text == "Sun Sword ( 1 Dg )" ? 1 : 0)) != 0)
                {
                  this.string_1 = this.form1_0.textBox_2.Text ?? "";
                  Form1.smethod_0("[Unique Kesme] etkinliğinin İTEM ödülü için isim girilmemiş.Lütfen kontrol edin.İsim için bu seferlik itemin kodu kullanıldı!!");
                }
                if ((!this.form1_0.checkBox_1.Checked ? 0 : (!this.form1_0.checkBox_0.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Etkinlik Ödülü ==>  " + this.form1_0.textBox_1.Text + " adet [" + this.string_1 + "] +" + this.form1_0.textBox_0.Text + " ";
                if ((!this.form1_0.checkBox_0.Checked ? 0 : (!this.form1_0.checkBox_1.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Etkinlik Ödülü ==> Silk = " + this.form1_0.textBox_5.Text + " , Gold = " + this.form1_0.textBox_3.Text + " , Sp = " + this.form1_0.textBox_4.Text;
                if ((!this.form1_0.checkBox_0.Checked ? 0 : (this.form1_0.checkBox_1.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Etkinlik Ödülü ==>  " + this.form1_0.textBox_1.Text + " adet [" + this.string_1 + "] +" + this.form1_0.textBox_0.Text + "  , Silk = " + this.form1_0.textBox_5.Text + " , Gold = " + this.form1_0.textBox_3.Text + " , Sp = " + this.form1_0.textBox_4.Text ?? "";
                if ((this.form1_0.checkBox_0.Checked ? 0 : (!this.form1_0.checkBox_1.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Bu ödülsüz bir etkinliktir.";
                this.form1_0.checkBox_2.Checked = true;
                *(sbyte*) ((IntPtr) voidPtr + 3) = (sbyte) (this.form1_0.comboBoxEdit_2.Text == "Jangan");
                if (*(sbyte*) ((IntPtr) voidPtr + 3) != (sbyte) 0)
                  Class73.smethod_236();
                *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (this.form1_0.comboBoxEdit_2.Text == "Donwhang");
                if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
                  Class73.smethod_74();
                *(sbyte*) ((IntPtr) voidPtr + 5) = (sbyte) (this.form1_0.comboBoxEdit_2.Text == "Hotan");
                if (*(sbyte*) ((IntPtr) voidPtr + 5) != (sbyte) 0)
                  Class73.smethod_169();
                *(sbyte*) ((IntPtr) voidPtr + 6) = (sbyte) (this.form1_0.comboBoxEdit_2.Text == "Samarkand");
                if (*(sbyte*) ((IntPtr) voidPtr + 6) != (sbyte) 0)
                  Class73.smethod_212();
                *(sbyte*) ((IntPtr) voidPtr + 7) = (sbyte) (this.form1_0.comboBoxEdit_2.Text == "Constantine");
                if (*(sbyte*) ((IntPtr) voidPtr + 7) != (sbyte) 0)
                  Class73.smethod_207();
                *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) (this.form1_0.comboBoxEdit_2.Text == "Alexandria");
                if (*(sbyte*) ((IntPtr) voidPtr + 8) != (sbyte) 0)
                  Class73.smethod_168();
                Form1.int_3 = Convert.ToInt32(Form1.form1_0.textBox_8.Text);
                Form1.int_4 = Convert.ToInt32(Form1.form1_0.textBox_7.Text);
                Form1.int_5 = Form1.int_4 * 1500;
                awaiter1 = Task.Delay(3000).GetAwaiter();
                if (!awaiter1.IsCompleted)
                {
                  num = 0;
                  this.int_0 = 0;
                  this.taskAwaiter_0 = awaiter1;
                  Form1.Class40 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class40>(ref awaiter1, ref stateMachine);
                  return;
                }
                break;
              }
              Class73.smethod_27(this.form1_0);
              goto label_55;
          }
          awaiter1.GetResult();
          awaiter1 = new TaskAwaiter();
          this.form1_0.checkBox_2.Checked = true;
          *(sbyte*) ((IntPtr) voidPtr + 9) = (sbyte) (this.form1_0.comboBoxEdit_2.Text == "");
          if (*(sbyte*) ((IntPtr) voidPtr + 9) != (sbyte) 0)
            this.form1_0.comboBoxEdit_2.Text = "Jangan";
          Class73.smethod_161(Class25.class19_0, "Merhaba. 5 dakika sonra [" + this.form1_0.comboBoxEdit_2.Text + "] kapıda [Unique Kesme] Etkinliği yapılacaktır.");
          awaiter2 = Task.Delay(7000).GetAwaiter();
          if (!awaiter2.IsCompleted)
          {
            num = 1;
            this.int_0 = 1;
            this.taskAwaiter_0 = awaiter2;
            Form1.Class40 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class40>(ref awaiter2, ref stateMachine);
            return;
          }
label_39:
          awaiter2.GetResult();
          awaiter2 = new TaskAwaiter();
          Class73.smethod_161(Class25.class19_0, this.string_0 ?? "");
          awaiter3 = Task.Delay(300000).GetAwaiter();
          if (!awaiter3.IsCompleted)
          {
            num = 2;
            this.int_0 = 2;
            this.taskAwaiter_0 = awaiter3;
            Form1.Class40 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class40>(ref awaiter3, ref stateMachine);
            return;
          }
label_42:
          awaiter3.GetResult();
          awaiter3 = new TaskAwaiter();
          Class73.smethod_161(Class25.class19_0, this.form1_0.comboBoxEdit_2.Text + " kapıda [Unique Kesme] Etkinliği başlamıştır.Bol şanslar.");
          awaiter4 = Task.Delay(3000).GetAwaiter();
          if (!awaiter4.IsCompleted)
          {
            num = 3;
            this.int_0 = 3;
            this.taskAwaiter_0 = awaiter4;
            Form1.Class40 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class40>(ref awaiter4, ref stateMachine);
            return;
          }
label_45:
          awaiter4.GetResult();
          awaiter4 = new TaskAwaiter();
          this.form1_0.timer_6.Start();
          this.form1_0.timer_7.Start();
          this.form1_0.listBoxControl_0.Enabled = false;
          *(sbyte*) ((IntPtr) voidPtr + 10) = (sbyte) this.form1_0.checkBox_26.Checked;
          if (*(sbyte*) ((IntPtr) voidPtr + 10) != (sbyte) 0)
          {
            Class73.smethod_218(Class25.class19_0, "Önce biraz zerk...");
            awaiter5 = Task.Delay(10000).GetAwaiter();
            if (!awaiter5.IsCompleted)
            {
              num = 4;
              this.int_0 = 4;
              this.taskAwaiter_0 = awaiter5;
              Form1.Class40 stateMachine = this;
              this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class40>(ref awaiter5, ref stateMachine);
              return;
            }
          }
          else
            goto label_53;
label_49:
          awaiter5.GetResult();
          awaiter5 = new TaskAwaiter();
          Form1.bool_1 = true;
          awaiter6 = Task.Delay(14000).GetAwaiter();
          if (!awaiter6.IsCompleted)
          {
            num = 5;
            this.int_0 = 5;
            this.taskAwaiter_0 = awaiter6;
            Form1.Class40 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class40>(ref awaiter6, ref stateMachine);
            return;
          }
label_52:
          awaiter6.GetResult();
          awaiter6 = new TaskAwaiter();
label_53:
          Form1.bool_2 = true;
        }
        catch (Exception ex)
        {
          this.int_0 = -2;
          this.asyncVoidMethodBuilder_0.SetException(ex);
          return;
        }
label_55:
        this.int_0 = -2;
        this.asyncVoidMethodBuilder_0.SetResult();
      }

      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }

    private sealed class Class41 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public Form1 form1_0;
      private string string_0;
      private string string_1;
      private TaskAwaiter taskAwaiter_0;

      unsafe void IAsyncStateMachine.MoveNext()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(4);
        int int0 = this.int_0;
        try
        {
          TaskAwaiter awaiter1;
          int num;
          TaskAwaiter awaiter2;
          TaskAwaiter awaiter3;
          TaskAwaiter awaiter4;
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
              goto label_25;
            case 2:
              awaiter3 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_28;
            case 3:
              awaiter4 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_31;
            default:
              *(sbyte*) voidPtr = (sbyte) (Class73.smethod_129(this.form1_0.label_13.Text) == Class69.string_0);
              if (*(sbyte*) voidPtr != (sbyte) 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (this.form1_0.label_160.Text == "ONLİNE");
                if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
                {
                  *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) (this.form1_0.label_160.Text == "OFFLİNE");
                  if (*(sbyte*) ((IntPtr) voidPtr + 2) != (sbyte) 0)
                  {
                    this.form1_0.method_2((object) this.form1_0.button_19, new EventArgs());
                    Class73.smethod_118("[Kayıp Unique]", this.form1_0);
                    goto label_35;
                  }
                }
                this.string_0 = "";
                this.string_1 = "";
                if ((this.form1_0.textBox_92.Text != "" ? 1 : (this.form1_0.textBox_92.Text != "Sun Sword ( 1 Dg )" ? 1 : 0)) != 0)
                  this.string_1 = this.form1_0.textBox_92.Text ?? "";
                if ((this.form1_0.textBox_92.Text == "" ? 1 : (this.form1_0.textBox_92.Text == "Sun Sword ( 1 Dg )" ? 1 : 0)) != 0)
                {
                  this.string_1 = this.form1_0.textBox_13.Text ?? "";
                  Form1.smethod_0("[Kayıp Unique] etkinliğinin İTEM ödülü için isim girilmemiş.Lütfen kontrol edin.İsim için bu seferlik itemin kodu kullanıldı!!");
                }
                if ((!this.form1_0.checkBox_4.Checked ? 0 : (!this.form1_0.checkBox_3.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Etkinlik Ödülü ==>  " + this.form1_0.textBox_12.Text + " adet [" + this.string_1 + "] +" + this.form1_0.textBox_11.Text + " ";
                if ((!this.form1_0.checkBox_3.Checked ? 0 : (!this.form1_0.checkBox_4.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Etkinlik Ödülü ==> Silk = " + this.form1_0.textBox_16.Text + " , Gold = " + this.form1_0.textBox_14.Text + " , Sp = " + this.form1_0.textBox_15.Text;
                if ((!this.form1_0.checkBox_3.Checked ? 0 : (this.form1_0.checkBox_4.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Etkinlik Ödülü ==>  " + this.form1_0.textBox_12.Text + " adet [" + this.string_1 + "] +" + this.form1_0.textBox_11.Text + " , Silk = " + this.form1_0.textBox_16.Text + " , Gold = " + this.form1_0.textBox_14.Text + " , Sp = " + this.form1_0.textBox_15.Text ?? "";
                if ((this.form1_0.checkBox_3.Checked ? 0 : (!this.form1_0.checkBox_4.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Bu ödülsüz bir etkinliktir.";
                this.form1_0.checkBox_5.Checked = true;
                this.form1_0.method_13(this.form1_0.comboBoxEdit_0.Text ?? "");
                Class73.smethod_161(Class25.class19_0, "Merhaba.5 dakika sonra " + this.form1_0.comboBoxEdit_0.Text + " haritasında  [Kayıp Unique] Etkinliği yapılacaktır.");
                awaiter1 = Task.Delay(7000).GetAwaiter();
                if (!awaiter1.IsCompleted)
                {
                  num = 0;
                  this.int_0 = 0;
                  this.taskAwaiter_0 = awaiter1;
                  Form1.Class41 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class41>(ref awaiter1, ref stateMachine);
                  return;
                }
                break;
              }
              Class73.smethod_27(this.form1_0);
              goto label_35;
          }
          awaiter1.GetResult();
          awaiter1 = new TaskAwaiter();
          Class73.smethod_161(Class25.class19_0, this.string_0 ?? "");
          awaiter2 = Task.Delay(300000).GetAwaiter();
          if (!awaiter2.IsCompleted)
          {
            num = 1;
            this.int_0 = 1;
            this.taskAwaiter_0 = awaiter2;
            Form1.Class41 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class41>(ref awaiter2, ref stateMachine);
            return;
          }
label_25:
          awaiter2.GetResult();
          awaiter2 = new TaskAwaiter();
          Class73.smethod_161(Class25.class19_0, "[Kayıp Unique] etkinliği başladı. Etkinlik bölgesi " + Form1.string_20 ?? "");
          awaiter3 = Task.Delay(10000).GetAwaiter();
          if (!awaiter3.IsCompleted)
          {
            num = 2;
            this.int_0 = 2;
            this.taskAwaiter_0 = awaiter3;
            Form1.Class41 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class41>(ref awaiter3, ref stateMachine);
            return;
          }
label_28:
          awaiter3.GetResult();
          awaiter3 = new TaskAwaiter();
          Class73.smethod_161(Class25.class19_0, "Bu uniqlerden ödül kazanmak için 10 dakika içinde kesmeniz gerekmektedir.");
          this.form1_0.method_14();
          awaiter4 = Task.Delay(600000).GetAwaiter();
          if (!awaiter4.IsCompleted)
          {
            num = 3;
            this.int_0 = 3;
            this.taskAwaiter_0 = awaiter4;
            Form1.Class41 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class41>(ref awaiter4, ref stateMachine);
            return;
          }
label_31:
          awaiter4.GetResult();
          awaiter4 = new TaskAwaiter();
          *(sbyte*) ((IntPtr) voidPtr + 3) = (sbyte) (Form1.int_1 > 0);
          if (*(sbyte*) ((IntPtr) voidPtr + 3) != (sbyte) 0)
            Class73.smethod_161(Class25.class19_0, "[Kayıp Unique] etkinliğinde henüz kesilmemiş uniqueler için ödül sistemi kapanmıştır.");
          this.form1_0.checkBox_5.Checked = false;
          Form1.int_1 = 0;
        }
        catch (Exception ex)
        {
          this.int_0 = -2;
          this.asyncVoidMethodBuilder_0.SetException(ex);
          return;
        }
label_35:
        this.int_0 = -2;
        this.asyncVoidMethodBuilder_0.SetResult();
      }

      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }

    private sealed class Class42 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public Form1 form1_0;
      private SqlDataReader sqlDataReader_0;
      private int int_1;
      private int int_2;
      private int int_3;
      private SqlDataReader sqlDataReader_1;
      private Exception exception_0;
      private SqlDataReader sqlDataReader_2;
      private Exception exception_1;
      private SqlDataReader sqlDataReader_3;
      private Exception exception_2;
      private int int_4;
      private int int_5;
      private Exception exception_3;
      private TaskAwaiter taskAwaiter_0;

      unsafe void IAsyncStateMachine.MoveNext()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(31);
        int num1 = this.int_0;
        try
        {
          TaskAwaiter awaiter1;
          int num2;
          TaskAwaiter awaiter2;
          TaskAwaiter awaiter3;
          TaskAwaiter awaiter4;
          switch (num1)
          {
            case 0:
              awaiter1 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              break;
            case 1:
              awaiter2 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_33;
            case 2:
              awaiter3 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_36;
            case 3:
              awaiter4 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_50;
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
label_51:
              try
              {
                TaskAwaiter awaiter5;
                TaskAwaiter awaiter6;
                TaskAwaiter awaiter7;
                TaskAwaiter awaiter8;
                TaskAwaiter awaiter9;
                TaskAwaiter awaiter10;
                TaskAwaiter awaiter11;
                TaskAwaiter awaiter12;
                TaskAwaiter awaiter13;
                TaskAwaiter awaiter14;
                TaskAwaiter awaiter15;
                switch (num1)
                {
                  case 4:
                    awaiter5 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num2 = -1;
                    this.int_0 = -1;
                    break;
                  case 5:
                    awaiter6 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num2 = -1;
                    this.int_0 = -1;
                    goto label_85;
                  case 6:
                    awaiter7 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num2 = -1;
                    this.int_0 = -1;
                    goto label_87;
                  case 7:
                    awaiter8 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num2 = -1;
                    this.int_0 = -1;
                    goto label_89;
                  case 8:
                    awaiter9 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num2 = -1;
                    this.int_0 = -1;
                    goto label_91;
                  case 9:
                    awaiter10 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num2 = -1;
                    this.int_0 = -1;
                    goto label_93;
                  case 10:
                    awaiter11 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num2 = -1;
                    this.int_0 = -1;
                    goto label_95;
                  case 11:
                    awaiter12 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num2 = -1;
                    this.int_0 = -1;
                    goto label_97;
                  case 12:
                    awaiter13 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num2 = -1;
                    this.int_0 = -1;
                    goto label_99;
                  case 13:
                    awaiter14 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num2 = -1;
                    this.int_0 = -1;
                    goto label_101;
                  case 14:
                    awaiter15 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num2 = -1;
                    this.int_0 = -1;
                    goto label_120;
                  default:
                    this.sqlDataReader_0 = new SqlCommand("SELECT COUNT(Kullandıgı_Oy) FROM My_EventBot.._Oylama", Class65.sqlConnection_0).ExecuteReader();
                    this.sqlDataReader_0.Read();
                    this.form1_0.int_11 = (int) Convert.ToInt16(this.sqlDataReader_0[0]);
                    this.int_1 = (int) Convert.ToInt16(this.form1_0.textBox_39.Text);
                    *(sbyte*) ((IntPtr) voidPtr + 28) = (sbyte) (this.form1_0.comboBox_1.SelectedIndex < 0);
                    if (*(sbyte*) ((IntPtr) voidPtr + 28) != (sbyte) 0)
                      this.form1_0.comboBox_1.SelectedIndex = 0;
                    *(sbyte*) ((IntPtr) voidPtr + 29) = (sbyte) (this.form1_0.int_11 < this.int_1);
                    if (*(sbyte*) ((IntPtr) voidPtr + 29) != (sbyte) 0)
                    {
                      this.form1_0.checkBox_23.Checked = true;
                      *(int*) ((IntPtr) voidPtr + 4) = this.form1_0.comboBox_1.SelectedIndex;
                      switch (*(int*) ((IntPtr) voidPtr + 4))
                      {
                        case 0:
                          Class73.smethod_161(Class25.class19_0, "Oylama sona erdi.Yeterli katılım sağlanmadığı için oylamadan sonuç alınamadı ve etkinlik yapılmayacak.İyi oyunlar.");
                          goto label_130;
                        case 1:
                          Class73.smethod_161(Class25.class19_0, "Oylama sona erdi.Yeterli katılım sağlanmadığı için 60 saniye sonra sistem tarafından seçilen [Unique Kesme] etkinliği yapılacak.");
                          awaiter5 = Task.Delay(60000).GetAwaiter();
                          if (!awaiter5.IsCompleted)
                          {
                            num2 = 4;
                            this.int_0 = 4;
                            this.taskAwaiter_0 = awaiter5;
                            Form1.Class42 stateMachine = this;
                            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class42>(ref awaiter5, ref stateMachine);
                            return;
                          }
                          break;
                        case 2:
                          Class73.smethod_161(Class25.class19_0, "Oylama sona erdi.Yeterli katılım sağlanmadığı için 60 saniye sonra sistem tarafından seçilen [Kayıp Unique] etkinliği yapılacak.");
                          awaiter6 = Task.Delay(60000).GetAwaiter();
                          if (!awaiter6.IsCompleted)
                          {
                            num2 = 5;
                            this.int_0 = 5;
                            this.taskAwaiter_0 = awaiter6;
                            Form1.Class42 stateMachine = this;
                            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class42>(ref awaiter6, ref stateMachine);
                            return;
                          }
                          goto label_85;
                        case 3:
                          Class73.smethod_161(Class25.class19_0, "Oylama sona erdi.Yeterli katılım sağlanmadığı için 60 saniye sonra sistem tarafından seçilen [Kayıp GM] etkinliği yapılacak.");
                          awaiter7 = Task.Delay(60000).GetAwaiter();
                          if (!awaiter7.IsCompleted)
                          {
                            num2 = 6;
                            this.int_0 = 6;
                            this.taskAwaiter_0 = awaiter7;
                            Form1.Class42 stateMachine = this;
                            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class42>(ref awaiter7, ref stateMachine);
                            return;
                          }
                          goto label_87;
                        case 4:
                          Class73.smethod_161(Class25.class19_0, "Oylama sona erdi.Yeterli katılım sağlanmadığı için 60 saniye sonra sistem tarafından seçilen [Alchemy] etkinliği yapılacak.");
                          awaiter8 = Task.Delay(60000).GetAwaiter();
                          if (!awaiter8.IsCompleted)
                          {
                            num2 = 7;
                            this.int_0 = 7;
                            this.taskAwaiter_0 = awaiter8;
                            Form1.Class42 stateMachine = this;
                            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class42>(ref awaiter8, ref stateMachine);
                            return;
                          }
                          goto label_89;
                        case 5:
                          Class73.smethod_161(Class25.class19_0, "Oylama sona erdi.Yeterli katılım sağlanmadığı için 60 saniye sonra sistem tarafından seçilen [Soru-Cevap] etkinliği yapılacak.");
                          awaiter9 = Task.Delay(60000).GetAwaiter();
                          if (!awaiter9.IsCompleted)
                          {
                            num2 = 8;
                            this.int_0 = 8;
                            this.taskAwaiter_0 = awaiter9;
                            Form1.Class42 stateMachine = this;
                            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class42>(ref awaiter9, ref stateMachine);
                            return;
                          }
                          goto label_91;
                        case 6:
                          Class73.smethod_161(Class25.class19_0, "Oylama sona erdi.Yeterli katılım sağlanmadığı için 60 saniye sonra sistem tarafından seçilen [Party Form] etkinliği yapılacak.");
                          awaiter10 = Task.Delay(60000).GetAwaiter();
                          if (!awaiter10.IsCompleted)
                          {
                            num2 = 9;
                            this.int_0 = 9;
                            this.taskAwaiter_0 = awaiter10;
                            Form1.Class42 stateMachine = this;
                            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class42>(ref awaiter10, ref stateMachine);
                            return;
                          }
                          goto label_93;
                        case 7:
                          Class73.smethod_161(Class25.class19_0, "Oylama sona erdi.Yeterli katılım sağlanmadığı için 60 saniye sonra sistem tarafından seçilen [Sayı Tahmin] etkinliği yapılacak.");
                          awaiter11 = Task.Delay(60000).GetAwaiter();
                          if (!awaiter11.IsCompleted)
                          {
                            num2 = 10;
                            this.int_0 = 10;
                            this.taskAwaiter_0 = awaiter11;
                            Form1.Class42 stateMachine = this;
                            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class42>(ref awaiter11, ref stateMachine);
                            return;
                          }
                          goto label_95;
                        case 8:
                          Class73.smethod_161(Class25.class19_0, "Oylama sona erdi.Yeterli katılım sağlanmadığı için 60 saniye sonra sistem tarafından seçilen [Hayatta Kal] etkinliği yapılacak.");
                          awaiter12 = Task.Delay(60000).GetAwaiter();
                          if (!awaiter12.IsCompleted)
                          {
                            num2 = 11;
                            this.int_0 = 11;
                            this.taskAwaiter_0 = awaiter12;
                            Form1.Class42 stateMachine = this;
                            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class42>(ref awaiter12, ref stateMachine);
                            return;
                          }
                          goto label_97;
                        case 9:
                          Class73.smethod_161(Class25.class19_0, "Oylama sona erdi.Yeterli katılım sağlanmadığı için 60 saniye sonra sistem tarafından seçilen [PIYANGO] etkinliği yapılacak.");
                          awaiter13 = Task.Delay(60000).GetAwaiter();
                          if (!awaiter13.IsCompleted)
                          {
                            num2 = 12;
                            this.int_0 = 12;
                            this.taskAwaiter_0 = awaiter13;
                            Form1.Class42 stateMachine = this;
                            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class42>(ref awaiter13, ref stateMachine);
                            return;
                          }
                          goto label_99;
                        default:
                          goto label_130;
                      }
                    }
                    else
                    {
                      *(sbyte*) ((IntPtr) voidPtr + 30) = (sbyte) (this.form1_0.int_11 >= this.int_1);
                      if (*(sbyte*) ((IntPtr) voidPtr + 30) != (sbyte) 0)
                      {
                        this.form1_0.checkBox_23.Checked = true;
                        try
                        {
                          this.sqlDataReader_1 = new SqlCommand("select top 1 Kullandıgı_Oy from My_EventBot.._Oylama group by Kullandıgı_Oy order by count(Kullandıgı_Oy) DESC", Class65.sqlConnection_0).ExecuteReader();
                          this.sqlDataReader_1.Read();
                          this.form1_0.int_13 = (int) Convert.ToInt16(this.sqlDataReader_1["Kullandıgı_Oy"]);
                          this.sqlDataReader_1 = (SqlDataReader) null;
                        }
                        catch (Exception ex)
                        {
                          this.exception_0 = ex;
                          Form1.smethod_0("Kazanan etkinlik numarası alınamadı. Açıklama ==> " + this.exception_0.Message);
                        }
                        awaiter14 = Task.Delay(1000).GetAwaiter();
                        if (!awaiter14.IsCompleted)
                        {
                          num2 = 13;
                          this.int_0 = 13;
                          this.taskAwaiter_0 = awaiter14;
                          Form1.Class42 stateMachine = this;
                          this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class42>(ref awaiter14, ref stateMachine);
                          return;
                        }
                        goto label_101;
                      }
                      else
                        goto label_130;
                    }
                    break;
                }
                awaiter5.GetResult();
                awaiter5 = new TaskAwaiter();
                this.form1_0.method_3();
                goto label_130;
label_85:
                awaiter6.GetResult();
                awaiter6 = new TaskAwaiter();
                this.form1_0.method_4();
                goto label_130;
label_87:
                awaiter7.GetResult();
                awaiter7 = new TaskAwaiter();
                this.form1_0.method_7();
                goto label_130;
label_89:
                awaiter8.GetResult();
                awaiter8 = new TaskAwaiter();
                this.form1_0.method_8();
                goto label_130;
label_91:
                awaiter9.GetResult();
                awaiter9 = new TaskAwaiter();
                this.form1_0.method_9(3);
                goto label_130;
label_93:
                awaiter10.GetResult();
                awaiter10 = new TaskAwaiter();
                this.int_2 = (int) Convert.ToInt16(this.form1_0.textBox_40.Text);
                this.form1_0.method_10(this.int_2);
                goto label_130;
label_95:
                awaiter11.GetResult();
                awaiter11 = new TaskAwaiter();
                this.int_3 = (int) Convert.ToInt16(this.form1_0.textBox_50.Text);
                this.form1_0.method_6(this.int_3);
                goto label_130;
label_97:
                awaiter12.GetResult();
                awaiter12 = new TaskAwaiter();
                this.form1_0.method_12();
                goto label_130;
label_99:
                awaiter13.GetResult();
                awaiter13 = new TaskAwaiter();
                this.form1_0.method_109();
                goto label_130;
label_101:
                awaiter14.GetResult();
                awaiter14 = new TaskAwaiter();
                try
                {
                  this.sqlDataReader_2 = new SqlCommand("SELECT COUNT(Kullandıgı_Oy) FROM My_EventBot.._Oylama where Kullandıgı_Oy=" + (object) this.form1_0.int_13 ?? "", Class65.sqlConnection_0).ExecuteReader();
                  this.sqlDataReader_2.Read();
                  this.form1_0.int_12 = (int) Convert.ToInt16(this.sqlDataReader_2[0]);
                  this.sqlDataReader_2 = (SqlDataReader) null;
                }
                catch (Exception ex)
                {
                  this.exception_1 = ex;
                  Form1.smethod_0("Etkinlik kazanan oy bilgisi alınamadı. Açıklama ==> " + this.exception_1.Message);
                }
                *(int*) ((IntPtr) voidPtr + 8) = this.form1_0.int_13;
                switch (*(int*) ((IntPtr) voidPtr + 8))
                {
                  case 1:
                    this.form1_0.string_24 = "Unique Kesme";
                    break;
                  case 2:
                    this.form1_0.string_24 = "Kayıp Unique";
                    break;
                  case 3:
                    this.form1_0.string_24 = "Kayıp GM";
                    break;
                  case 4:
                    this.form1_0.string_24 = "Alchemy";
                    break;
                  case 5:
                    this.form1_0.string_24 = "Soru-Cevap";
                    break;
                  case 6:
                    this.form1_0.string_24 = "Party Form";
                    break;
                  case 7:
                    this.form1_0.string_24 = "Sayı Tahmin";
                    break;
                  case 8:
                    this.form1_0.string_24 = "Hayatta Kal";
                    break;
                  case 9:
                    this.form1_0.string_24 = "Piyango";
                    break;
                }
                Class73.smethod_161(Class25.class19_0, "Oylama sona erdi. [" + (object) this.form1_0.int_11 + "]  Kişilik katılımda  [" + (object) this.form1_0.int_12 + "]  oy ile [" + this.form1_0.string_24 + "] etkinliği seçilmiştir.Etkinlik 60 saniye sonra başlayacaktır.");
                Class32.list_1.Clear();
                try
                {
                  this.sqlDataReader_3 = new SqlCommand("DELETE My_EventBot.._Oylama where Kullandıgı_Oy > 0", Class65.sqlConnection_0).ExecuteReader();
                  this.sqlDataReader_3.Read();
                  Form1.smethod_0("_Oylama Tablosundaki veriler silindi.");
                  this.sqlDataReader_3 = (SqlDataReader) null;
                }
                catch (Exception ex)
                {
                  this.exception_2 = ex;
                  Form1.smethod_0("_Oylama tablosundaki veriler silinemedi.Birdahaki oylamada sorun yaratır.Lütfen _Oylama tablosunu manuel silin. Açıklama ==> " + this.exception_2.Message);
                }
                awaiter15 = Task.Delay(60000).GetAwaiter();
                if (!awaiter15.IsCompleted)
                {
                  num2 = 14;
                  this.int_0 = 14;
                  this.taskAwaiter_0 = awaiter15;
                  Form1.Class42 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class42>(ref awaiter15, ref stateMachine);
                  return;
                }
label_120:
                awaiter15.GetResult();
                awaiter15 = new TaskAwaiter();
                *(int*) ((IntPtr) voidPtr + 12) = this.form1_0.int_13;
                switch (*(int*) ((IntPtr) voidPtr + 12))
                {
                  case 1:
                    this.form1_0.method_3();
                    break;
                  case 2:
                    this.form1_0.method_4();
                    break;
                  case 3:
                    this.form1_0.method_7();
                    break;
                  case 4:
                    this.form1_0.method_8();
                    break;
                  case 5:
                    this.int_4 = (int) Convert.ToInt16(this.form1_0.textBox_28.Text);
                    this.form1_0.method_9(this.int_4);
                    break;
                  case 6:
                    this.int_5 = (int) Convert.ToInt16(this.form1_0.textBox_40.Text);
                    this.form1_0.method_10(this.int_5);
                    break;
                  case 7:
                    this.form1_0.method_6(3);
                    break;
                  case 8:
                    this.form1_0.method_12();
                    break;
                  case 9:
                    this.form1_0.method_109();
                    break;
                }
label_130:
                this.sqlDataReader_0 = (SqlDataReader) null;
                goto label_133;
              }
              catch (Exception ex)
              {
                this.exception_3 = ex;
                Form1.smethod_0("Toplam katılımcı bilgisi alınamadı. Açıklama ==> " + this.exception_3.Message);
                goto label_133;
              }
            default:
              *(sbyte*) ((IntPtr) voidPtr + 16) = (sbyte) (Class73.smethod_129(this.form1_0.label_13.Text) == Class0.string_0);
              if (*(sbyte*) ((IntPtr) voidPtr + 16) != (sbyte) 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 17) = (sbyte) (this.form1_0.label_160.Text == "ONLİNE");
                if (*(sbyte*) ((IntPtr) voidPtr + 17) == (sbyte) 0)
                {
                  *(sbyte*) ((IntPtr) voidPtr + 18) = (sbyte) (this.form1_0.label_160.Text == "OFFLİNE");
                  if (*(sbyte*) ((IntPtr) voidPtr + 18) != (sbyte) 0)
                  {
                    this.form1_0.method_2((object) this.form1_0.button_19, new EventArgs());
                    Class73.smethod_118("[Oylama]", this.form1_0);
                    goto label_133;
                  }
                }
                this.form1_0.listBox_15.Items.Clear();
                *(sbyte*) ((IntPtr) voidPtr + 19) = (sbyte) this.form1_0.checkEdit_6.Checked;
                if (*(sbyte*) ((IntPtr) voidPtr + 19) != (sbyte) 0)
                  this.form1_0.listBox_15.Items.Add((object) 1);
                *(sbyte*) ((IntPtr) voidPtr + 20) = (sbyte) this.form1_0.checkEdit_8.Checked;
                if (*(sbyte*) ((IntPtr) voidPtr + 20) != (sbyte) 0)
                  this.form1_0.listBox_15.Items.Add((object) 2);
                *(sbyte*) ((IntPtr) voidPtr + 21) = (sbyte) this.form1_0.checkEdit_7.Checked;
                if (*(sbyte*) ((IntPtr) voidPtr + 21) != (sbyte) 0)
                  this.form1_0.listBox_15.Items.Add((object) 3);
                *(sbyte*) ((IntPtr) voidPtr + 22) = (sbyte) this.form1_0.checkEdit_5.Checked;
                if (*(sbyte*) ((IntPtr) voidPtr + 22) != (sbyte) 0)
                  this.form1_0.listBox_15.Items.Add((object) 4);
                *(sbyte*) ((IntPtr) voidPtr + 23) = (sbyte) this.form1_0.checkEdit_2.Checked;
                if (*(sbyte*) ((IntPtr) voidPtr + 23) != (sbyte) 0)
                  this.form1_0.listBox_15.Items.Add((object) 5);
                *(sbyte*) ((IntPtr) voidPtr + 24) = (sbyte) this.form1_0.checkEdit_4.Checked;
                if (*(sbyte*) ((IntPtr) voidPtr + 24) != (sbyte) 0)
                  this.form1_0.listBox_15.Items.Add((object) 6);
                *(sbyte*) ((IntPtr) voidPtr + 25) = (sbyte) this.form1_0.checkEdit_3.Checked;
                if (*(sbyte*) ((IntPtr) voidPtr + 25) != (sbyte) 0)
                  this.form1_0.listBox_15.Items.Add((object) 7);
                *(sbyte*) ((IntPtr) voidPtr + 26) = (sbyte) this.form1_0.checkEdit_1.Checked;
                if (*(sbyte*) ((IntPtr) voidPtr + 26) != (sbyte) 0)
                  this.form1_0.listBox_15.Items.Add((object) 8);
                *(sbyte*) ((IntPtr) voidPtr + 27) = (sbyte) this.form1_0.checkEdit_11.Checked;
                if (*(sbyte*) ((IntPtr) voidPtr + 27) != (sbyte) 0)
                  this.form1_0.listBox_15.Items.Add((object) 9);
                if ((this.form1_0.checkEdit_6.Checked || this.form1_0.checkEdit_8.Checked || (this.form1_0.checkEdit_7.Checked || this.form1_0.checkEdit_5.Checked) || (this.form1_0.checkEdit_2.Checked || this.form1_0.checkEdit_4.Checked || (this.form1_0.checkEdit_3.Checked || this.form1_0.checkEdit_1.Checked)) ? 0 : (!this.form1_0.checkEdit_11.Checked ? 1 : 0)) != 0)
                {
                  Form1.smethod_0("Oylamaya hiçbir etkinliği dahil etmediğiniz için sistem otomatik 1 ve 6 numaralı (Uniq Kesme,Party Form) etkinliklerini oylamaya dahil etti.");
                  this.form1_0.listBox_15.Items.Add((object) 1);
                  this.form1_0.listBox_15.Items.Add((object) 6);
                }
                Class73.smethod_161(Class25.class19_0, "Sıradaki etkinliği belirlemek sizin elinizde!.Yapmanız gereken tek şey oylamaya katılmak.Detaylar globalden verilecektir.");
                awaiter1 = Task.Delay(5000).GetAwaiter();
                if (!awaiter1.IsCompleted)
                {
                  num2 = 0;
                  this.int_0 = 0;
                  this.taskAwaiter_0 = awaiter1;
                  Form1.Class42 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class42>(ref awaiter1, ref stateMachine);
                  return;
                }
                break;
              }
              Class73.smethod_27(this.form1_0);
              goto label_133;
          }
          awaiter1.GetResult();
          awaiter1 = new TaskAwaiter();
          Class73.smethod_161(Class25.class19_0, "Yapılmasını istediğiniz etkinlik numarasını [" + this.form1_0.textEdit_18.Text + "] isimli karaktere pm atın.Sadece 1 etkinliğe oy verebilirsiniz..");
          awaiter2 = Task.Delay(6000).GetAwaiter();
          if (!awaiter2.IsCompleted)
          {
            num2 = 1;
            this.int_0 = 1;
            this.taskAwaiter_0 = awaiter2;
            Form1.Class42 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class42>(ref awaiter2, ref stateMachine);
            return;
          }
label_33:
          awaiter2.GetResult();
          awaiter2 = new TaskAwaiter();
          Class73.smethod_161(Class25.class19_0, "Unique Kes=1, Kayıp Unique=2, Kayıp GM=3, Alchemy=4, Soru-Cevap=5, Party Form=6, Sayı Bul=7,Hayatta Kal=8, Piyango=9");
          awaiter3 = Task.Delay(7000).GetAwaiter();
          if (!awaiter3.IsCompleted)
          {
            num2 = 2;
            this.int_0 = 2;
            this.taskAwaiter_0 = awaiter3;
            Form1.Class42 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class42>(ref awaiter3, ref stateMachine);
            return;
          }
label_36:
          awaiter3.GetResult();
          awaiter3 = new TaskAwaiter();
          this.form1_0.checkBox_23.Checked = true;
          *(int*) voidPtr = this.form1_0.listBox_15.Items.Count;
          switch (*(int*) voidPtr)
          {
            case 1:
              Class73.smethod_161(Class25.class19_0, "Oylama başladı.Oylama süresi [" + this.form1_0.textBox_38.Text + "] saniyedir.Bu oylamaya dahil etkinlikler (" + this.form1_0.listBox_15.Items[0] + ").Seçimini yap.");
              break;
            case 2:
              Class73.smethod_161(Class25.class19_0, "Oylama başladı.Oylama süresi [" + this.form1_0.textBox_38.Text + "] saniyedir.Bu oylamaya dahil etkinlikler (" + this.form1_0.listBox_15.Items[0].ToString() + "," + this.form1_0.listBox_15.Items[1].ToString() + ").Seçimini yap.");
              break;
            case 3:
              Class73.smethod_161(Class25.class19_0, "Oylama başladı.Oylama süresi [" + this.form1_0.textBox_38.Text + "] saniyedir.Bu oylamaya dahil etkinlikler (" + this.form1_0.listBox_15.Items[0].ToString() + "," + this.form1_0.listBox_15.Items[1].ToString() + "," + this.form1_0.listBox_15.Items[2].ToString() + ").Seçimini yap.");
              break;
            case 4:
              Class73.smethod_161(Class25.class19_0, "Oylama başladı.Oylama süresi [" + this.form1_0.textBox_38.Text + "] saniyedir.Bu oylamaya dahil etkinlikler (" + this.form1_0.listBox_15.Items[0].ToString() + "," + this.form1_0.listBox_15.Items[1].ToString() + "," + this.form1_0.listBox_15.Items[2].ToString() + "," + this.form1_0.listBox_15.Items[3].ToString() + ").Seçimini yap.");
              break;
            case 5:
              Class73.smethod_161(Class25.class19_0, "Oylama başladı.Oylama süresi [" + this.form1_0.textBox_38.Text + "] saniyedir.Bu oylamaya dahil etkinlikler (" + this.form1_0.listBox_15.Items[0].ToString() + "," + this.form1_0.listBox_15.Items[1].ToString() + "," + this.form1_0.listBox_15.Items[2].ToString() + "," + this.form1_0.listBox_15.Items[3].ToString() + "," + this.form1_0.listBox_15.Items[4].ToString() + ").Seçimini yap.");
              break;
            case 6:
              Class73.smethod_161(Class25.class19_0, "Oylama başladı.Oylama süresi [" + this.form1_0.textBox_38.Text + "] saniyedir.Bu oylamaya dahil etkinlikler (" + this.form1_0.listBox_15.Items[0].ToString() + "," + this.form1_0.listBox_15.Items[1].ToString() + "," + this.form1_0.listBox_15.Items[2].ToString() + "," + this.form1_0.listBox_15.Items[3].ToString() + "," + this.form1_0.listBox_15.Items[4].ToString() + "," + this.form1_0.listBox_15.Items[5].ToString() + ")Seçimini yap.");
              break;
            case 7:
              Class73.smethod_161(Class25.class19_0, "Oylama başladı.Oylama süresi [" + this.form1_0.textBox_38.Text + "] saniyedir.Bu oylamaya dahil etkinlikler (" + this.form1_0.listBox_15.Items[0].ToString() + "," + this.form1_0.listBox_15.Items[1].ToString() + "," + this.form1_0.listBox_15.Items[2].ToString() + "," + this.form1_0.listBox_15.Items[3].ToString() + "," + this.form1_0.listBox_15.Items[4].ToString() + "," + this.form1_0.listBox_15.Items[5].ToString() + "," + this.form1_0.listBox_15.Items[6].ToString() + ")Seçimini yap.");
              break;
            case 8:
              Class73.smethod_161(Class25.class19_0, "Oylama başladı.Oylama süresi [" + this.form1_0.textBox_38.Text + "] saniyedir.Bu oylamaya dahil etkinlikler (" + this.form1_0.listBox_15.Items[0].ToString() + "," + this.form1_0.listBox_15.Items[1].ToString() + "," + this.form1_0.listBox_15.Items[2].ToString() + "," + this.form1_0.listBox_15.Items[3].ToString() + "," + this.form1_0.listBox_15.Items[4].ToString() + "," + this.form1_0.listBox_15.Items[5].ToString() + "," + this.form1_0.listBox_15.Items[6].ToString() + "," + this.form1_0.listBox_15.Items[7].ToString() + ")Seçimini yap.");
              break;
            case 9:
              Class73.smethod_161(Class25.class19_0, "Oylama başladı.Oylama süresi [" + this.form1_0.textBox_38.Text + "] saniyedir.Bu oylamaya dahil etkinlikler (" + this.form1_0.listBox_15.Items[0].ToString() + "," + this.form1_0.listBox_15.Items[1].ToString() + "," + this.form1_0.listBox_15.Items[2].ToString() + "," + this.form1_0.listBox_15.Items[3].ToString() + "," + this.form1_0.listBox_15.Items[4].ToString() + "," + this.form1_0.listBox_15.Items[5].ToString() + "," + this.form1_0.listBox_15.Items[6].ToString() + "," + this.form1_0.listBox_15.Items[7].ToString() + "," + this.form1_0.listBox_15.Items[8].ToString() + ")Seçimini yap.");
              break;
            case 10:
              Class73.smethod_161(Class25.class19_0, "Oylama başladı.Oylama süresi [" + this.form1_0.textBox_38.Text + "] saniyedir.Bu oylamaya dahil etkinlikler (" + this.form1_0.listBox_15.Items[0].ToString() + "," + this.form1_0.listBox_15.Items[1].ToString() + "," + this.form1_0.listBox_15.Items[2].ToString() + "," + this.form1_0.listBox_15.Items[3].ToString() + "," + this.form1_0.listBox_15.Items[4].ToString() + "," + this.form1_0.listBox_15.Items[5].ToString() + "," + this.form1_0.listBox_15.Items[6].ToString() + "," + this.form1_0.listBox_15.Items[7].ToString() + "," + this.form1_0.listBox_15.Items[8].ToString() + "," + this.form1_0.listBox_15.Items[9].ToString() + ")Seçimini yap.");
              break;
          }
          awaiter4 = Task.Delay(Convert.ToInt32(this.form1_0.textBox_38.Text) * 1000).GetAwaiter();
          if (!awaiter4.IsCompleted)
          {
            num2 = 3;
            this.int_0 = 3;
            this.taskAwaiter_0 = awaiter4;
            Form1.Class42 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class42>(ref awaiter4, ref stateMachine);
            return;
          }
label_50:
          awaiter4.GetResult();
          awaiter4 = new TaskAwaiter();
          goto label_51;
        }
        catch (Exception ex)
        {
          this.int_0 = -2;
          this.asyncVoidMethodBuilder_0.SetException(ex);
          return;
        }
label_133:
        this.int_0 = -2;
        this.asyncVoidMethodBuilder_0.SetResult();
      }

      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }

    private sealed class Class43 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public int int_1;
      public Form1 form1_0;
      private string string_0;
      private string string_1;
      private int int_2;
      private int int_3;
      private int int_4;
      private int int_5;
      private Exception exception_0;
      private string string_2;
      private Exception exception_1;
      private TaskAwaiter taskAwaiter_0;

      unsafe void IAsyncStateMachine.MoveNext()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(11);
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
              goto label_25;
            case 2:
              awaiter3 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_36;
            case 3:
              awaiter4 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_37;
            case 4:
              awaiter5 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_38;
            case 5:
              awaiter6 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_40;
            case 6:
              awaiter7 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_31;
            default:
              *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (Class73.smethod_129(this.form1_0.label_13.Text) == Class71.string_0);
              if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 5) = (sbyte) (this.form1_0.label_160.Text == "ONLİNE");
                if (*(sbyte*) ((IntPtr) voidPtr + 5) == (sbyte) 0)
                {
                  *(sbyte*) ((IntPtr) voidPtr + 6) = (sbyte) (this.form1_0.label_160.Text == "OFFLİNE");
                  if (*(sbyte*) ((IntPtr) voidPtr + 6) != (sbyte) 0)
                  {
                    this.form1_0.method_2((object) this.form1_0.button_19, new EventArgs());
                    Class73.smethod_118("[Sayı Bul]", this.form1_0);
                    goto label_55;
                  }
                }
                this.string_0 = "";
                this.string_1 = "";
                if ((this.form1_0.textBox_97.Text != "" ? 1 : (this.form1_0.textBox_97.Text != "Sun Sword ( 1 Dg )" ? 1 : 0)) != 0)
                  this.string_1 = this.form1_0.textBox_97.Text ?? "";
                if ((this.form1_0.textBox_97.Text == "" ? 1 : (this.form1_0.textBox_97.Text == "Sun Sword ( 1 Dg )" ? 1 : 0)) != 0)
                {
                  this.string_1 = this.form1_0.textBox_75.Text ?? "";
                  Form1.smethod_0("[Sayı Tahmin] etkinliğinin İTEM ödülü için isim girilmemiş.Lütfen kontrol edin.İsim için bu seferlik itemin kodu kullanıldı!!");
                }
                if ((!this.form1_0.checkBox_20.Checked ? 0 : (!this.form1_0.checkBox_19.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Etkinlik Ödülü ==>  " + this.form1_0.textBox_74.Text + " adet [" + this.string_1 + "] + " + this.form1_0.textBox_73.Text ?? "";
                if ((!this.form1_0.checkBox_19.Checked ? 0 : (!this.form1_0.checkBox_20.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Etkinlik Ödülü ==> Silk = " + this.form1_0.textBox_71.Text + " , Gold = " + this.form1_0.textBox_70.Text + " , Sp = " + this.form1_0.textBox_72.Text;
                if ((!this.form1_0.checkBox_19.Checked ? 0 : (this.form1_0.checkBox_20.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Etkinlik Ödülü ==> " + this.form1_0.textBox_74.Text + " adet [" + this.string_1 + "] + " + this.form1_0.textBox_73.Text + " , Silk = " + this.form1_0.textBox_71.Text + " , Gold = " + this.form1_0.textBox_70.Text + " , Sp = " + this.form1_0.textBox_72.Text ?? "";
                if ((this.form1_0.checkBox_19.Checked ? 0 : (!this.form1_0.checkBox_20.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Bu ödülsüz bir etkinliktir.";
                this.int_2 = this.int_1;
                Form1.form1_0.checkEdit_0.Checked = true;
                Class73.smethod_161(Class25.class19_0, "Merhaba. 5 dakika sonra [Sayı Tahmin] etkinliği yapılacaktır.Etkinkik toplam " + (object) this.int_1 + " tur yapılacak.");
                awaiter1 = Task.Delay(7000).GetAwaiter();
                if (!awaiter1.IsCompleted)
                {
                  num = 0;
                  this.int_0 = 0;
                  this.taskAwaiter_0 = awaiter1;
                  Form1.Class43 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class43>(ref awaiter1, ref stateMachine);
                  return;
                }
                break;
              }
              Class73.smethod_27(this.form1_0);
              goto label_55;
          }
          awaiter1.GetResult();
          awaiter1 = new TaskAwaiter();
          Class73.smethod_161(Class25.class19_0, this.string_0 ?? "");
          awaiter2 = Task.Delay(300000).GetAwaiter();
          if (!awaiter2.IsCompleted)
          {
            num = 1;
            this.int_0 = 1;
            this.taskAwaiter_0 = awaiter2;
            Form1.Class43 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class43>(ref awaiter2, ref stateMachine);
            return;
          }
label_25:
          awaiter2.GetResult();
          awaiter2 = new TaskAwaiter();
          goto label_33;
label_31:
          awaiter7.GetResult();
          awaiter7 = new TaskAwaiter();
label_32:
          *(sbyte*) ((IntPtr) voidPtr + 9) = (sbyte) (this.int_2 > 0);
          if (*(sbyte*) ((IntPtr) voidPtr + 9) == (sbyte) 0)
          {
            *(sbyte*) ((IntPtr) voidPtr + 10) = (sbyte) (this.int_2 <= 0);
            if (*(sbyte*) ((IntPtr) voidPtr + 10) != (sbyte) 0)
            {
              Class73.smethod_161(Class25.class19_0, "[Sayı Tahmin] etkinliğimiz sona ermiştir.Başka etkinliklerde görüşmek üzere..");
              Class73.smethod_206(Class25.class19_0);
              Form1.form1_0.textBox_67.Text = "";
              Form1.form1_0.textBox_68.Text = "";
              Form1.form1_0.textBox_69.Text = "";
              Form1.form1_0.listBox_8.Items.Clear();
              Form1.form1_0.listBox_16.Items.Clear();
              try
              {
                new SqlCommand("delete My_EventBot.._Sayı_Bul", Class65.sqlConnection_0).ExecuteNonQuery();
              }
              catch (Exception ex)
              {
                this.exception_1 = ex;
                Form1.smethod_0("[Sayı Tahmin] etkinlik bitimi _Sayı_Bul tablosu temizlenemedi.HATA => " + this.exception_1.Message);
              }
              Form1.form1_0.checkBox_22.Checked = false;
              Form1.form1_0.checkEdit_0.Checked = false;
              goto label_55;
            }
            else
              goto label_55;
          }
label_33:
          this.form1_0.listBox_16.Items.Clear();
          try
          {
            new SqlCommand("delete My_EventBot.._Sayı_Bul", Class65.sqlConnection_0).ExecuteNonQuery();
          }
          catch (Exception ex)
          {
            this.exception_0 = ex;
            Form1.smethod_0("[Sayı Tahmin] etkinliği için _Sayı_Bul tablosu silinemedi. Hata Acıklaması => " + this.exception_0.Message);
          }
          this.int_3 = Convert.ToInt32(Form1.form1_0.textBox_51.Text);
          this.int_4 = Convert.ToInt32(Form1.form1_0.textBox_49.Text);
          this.int_5 = Form1.random_0.Next(this.int_3, this.int_4);
          Form1.form1_0.textBox_68.Text = "";
          Form1.form1_0.textBox_69.Text = "";
          Form1.form1_0.textBox_67.Text = string.Concat((object) this.int_5);
          awaiter3 = Task.Delay(2000).GetAwaiter();
          if (!awaiter3.IsCompleted)
          {
            num = 2;
            this.int_0 = 2;
            this.taskAwaiter_0 = awaiter3;
            Form1.Class43 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class43>(ref awaiter3, ref stateMachine);
            return;
          }
label_36:
          awaiter3.GetResult();
          awaiter3 = new TaskAwaiter();
          Class73.smethod_161(Class25.class19_0, "[Sayı Tahmin] etkinliği başladı." + (object) this.int_3 + " - " + (object) this.int_4 + " aralığındaki tahmininizi [" + this.form1_0.textEdit_18.Text + "] isimli karaktere pm atınız.Süre 2 dakika.Başarılar.");
          Form1.form1_0.checkBox_22.Checked = true;
          awaiter4 = Task.Delay(120000).GetAwaiter();
          if (!awaiter4.IsCompleted)
          {
            num = 3;
            this.int_0 = 3;
            this.taskAwaiter_0 = awaiter4;
            Form1.Class43 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class43>(ref awaiter4, ref stateMachine);
            return;
          }
label_37:
          awaiter4.GetResult();
          awaiter4 = new TaskAwaiter();
          Form1.form1_0.checkBox_22.Checked = false;
          Form1.smethod_5();
          awaiter5 = Task.Delay(1000).GetAwaiter();
          if (!awaiter5.IsCompleted)
          {
            num = 4;
            this.int_0 = 4;
            this.taskAwaiter_0 = awaiter5;
            Form1.Class43 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class43>(ref awaiter5, ref stateMachine);
            return;
          }
label_38:
          awaiter5.GetResult();
          awaiter5 = new TaskAwaiter();
          *(sbyte*) ((IntPtr) voidPtr + 7) = (sbyte) (Form1.form1_0.textBox_69.Text != "");
          if (*(sbyte*) ((IntPtr) voidPtr + 7) != (sbyte) 0)
          {
            Class73.smethod_161(Class25.class19_0, "2 dakikalık süre doldu.Aranan sayı [" + Form1.form1_0.textBox_67.Text + "] , gelen en yakın tahmin  [" + Form1.form1_0.textBox_68.Text + "], Tahminde bulunan kişi [" + Form1.form1_0.textBox_69.Text + "]..Tebrikler.");
            this.string_2 = Convert.ToString(Form1.form1_0.textBox_69.Text);
            Form1.smethod_4(this.string_2);
            awaiter6 = Task.Delay(5000).GetAwaiter();
            if (!awaiter6.IsCompleted)
            {
              num = 5;
              this.int_0 = 5;
              this.taskAwaiter_0 = awaiter6;
              Form1.Class43 stateMachine = this;
              this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class43>(ref awaiter6, ref stateMachine);
              return;
            }
          }
          else
          {
            *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) (Form1.form1_0.textBox_69.Text == "");
            if (*(sbyte*) ((IntPtr) voidPtr + 8) != (sbyte) 0)
            {
              Form1.smethod_0("Bu raundda kazanan olmadı.");
              Class73.smethod_161(Class25.class19_0, "Bu raundda kazanan olmadı.");
              *(int*) voidPtr = this.int_2;
              this.int_2 = *(int*) voidPtr - 1;
              Form1.form1_0.listBox_8.Items.Clear();
              Form1.form1_0.listBox_16.Items.Clear();
              awaiter7 = Task.Delay(5000).GetAwaiter();
              if (!awaiter7.IsCompleted)
              {
                num = 6;
                this.int_0 = 6;
                this.taskAwaiter_0 = awaiter7;
                Form1.Class43 stateMachine = this;
                this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class43>(ref awaiter7, ref stateMachine);
                return;
              }
              goto label_31;
            }
            else
              goto label_32;
          }
label_40:
          awaiter6.GetResult();
          awaiter6 = new TaskAwaiter();
          *(int*) voidPtr = this.int_2;
          this.int_2 = *(int*) voidPtr - 1;
          this.string_2 = (string) null;
          goto label_32;
        }
        catch (Exception ex)
        {
          this.int_0 = -2;
          this.asyncVoidMethodBuilder_0.SetException(ex);
          return;
        }
label_55:
        this.int_0 = -2;
        this.asyncVoidMethodBuilder_0.SetResult();
      }

      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }

    private sealed class Class44 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public Form1 form1_0;
      private string string_0;
      private string string_1;
      private TaskAwaiter taskAwaiter_0;

      unsafe void IAsyncStateMachine.MoveNext()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(3);
        int int0 = this.int_0;
        try
        {
          TaskAwaiter awaiter1;
          int num;
          TaskAwaiter awaiter2;
          TaskAwaiter awaiter3;
          TaskAwaiter awaiter4;
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
              goto label_25;
            case 2:
              awaiter3 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_28;
            case 3:
              awaiter4 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_31;
            default:
              *(sbyte*) voidPtr = (sbyte) (Class73.smethod_129(this.form1_0.label_13.Text) == this.form1_0.textBox_100.Text);
              if (*(sbyte*) voidPtr != (sbyte) 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (this.form1_0.label_160.Text == "ONLİNE");
                if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
                {
                  *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) (this.form1_0.label_160.Text == "OFFLİNE");
                  if (*(sbyte*) ((IntPtr) voidPtr + 2) != (sbyte) 0)
                  {
                    this.form1_0.method_2((object) this.form1_0.button_19, new EventArgs());
                    Class73.smethod_118("[Kayıp GM]", this.form1_0);
                    goto label_33;
                  }
                }
                this.string_0 = "";
                this.string_1 = "";
                if ((this.form1_0.textBox_93.Text != "" ? 1 : (this.form1_0.textBox_93.Text != "Sun Sword ( 1 Dg )" ? 1 : 0)) != 0)
                  this.string_1 = this.form1_0.textBox_93.Text ?? "";
                if ((this.form1_0.textBox_93.Text == "" ? 1 : (this.form1_0.textBox_93.Text == "Sun Sword ( 1 Dg )" ? 1 : 0)) != 0)
                {
                  this.string_1 = this.form1_0.textBox_55.Text ?? "";
                  Form1.smethod_0("[Kayıp GM] etkinliğinin İTEM ödülü için isim girilmemiş.Lütfen kontrol edin.İsim için bu seferlik itemin kodu kullanıldı!!");
                }
                if ((!this.form1_0.checkBox_16.Checked ? 0 : (!this.form1_0.checkBox_15.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Etkinlik Ödülü ==>  " + this.form1_0.textBox_54.Text + " adet [" + this.string_1 + "] + " + this.form1_0.textBox_53.Text + " ";
                if ((!this.form1_0.checkBox_15.Checked ? 0 : (!this.form1_0.checkBox_16.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Etkinlik Ödülü ==> Silk = " + this.form1_0.textBox_58.Text + " , Gold = " + this.form1_0.textBox_56.Text + " , Sp = " + this.form1_0.textBox_57.Text;
                if ((!this.form1_0.checkBox_15.Checked ? 0 : (this.form1_0.checkBox_16.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Etkinlik Ödülü ==> " + this.form1_0.textBox_54.Text + " adet [" + this.string_1 + "] + " + this.form1_0.textBox_53.Text + " , Silk = " + this.form1_0.textBox_58.Text + " , Gold = " + this.form1_0.textBox_56.Text + " , Sp = " + this.form1_0.textBox_57.Text ?? "";
                if ((this.form1_0.checkBox_15.Checked ? 0 : (!this.form1_0.checkBox_16.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Bu ödülsüz bir etkinliktir.";
                this.form1_0.checkBox_8.Checked = true;
                this.form1_0.method_13(this.form1_0.comboBoxEdit_1.Text ?? "");
                awaiter1 = Task.Delay(3000).GetAwaiter();
                if (!awaiter1.IsCompleted)
                {
                  num = 0;
                  this.int_0 = 0;
                  this.taskAwaiter_0 = awaiter1;
                  Form1.Class44 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class44>(ref awaiter1, ref stateMachine);
                  return;
                }
                break;
              }
              Class73.smethod_27(this.form1_0);
              goto label_33;
          }
          awaiter1.GetResult();
          awaiter1 = new TaskAwaiter();
          Class73.smethod_161(Class25.class19_0, "Merhaba.. 5 Dakika sonra " + this.form1_0.comboBoxEdit_1.Text + " haritasında [Kayıp GM] etkinliği yapılacaktır.Etkinlik toplam 3 tur olacaktır.");
          awaiter2 = Task.Delay(7000).GetAwaiter();
          if (!awaiter2.IsCompleted)
          {
            num = 1;
            this.int_0 = 1;
            this.taskAwaiter_0 = awaiter2;
            Form1.Class44 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class44>(ref awaiter2, ref stateMachine);
            return;
          }
label_25:
          awaiter2.GetResult();
          awaiter2 = new TaskAwaiter();
          Class73.smethod_161(Class25.class19_0, this.string_0 ?? "");
          awaiter3 = Task.Delay(300000).GetAwaiter();
          if (!awaiter3.IsCompleted)
          {
            num = 2;
            this.int_0 = 2;
            this.taskAwaiter_0 = awaiter3;
            Form1.Class44 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class44>(ref awaiter3, ref stateMachine);
            return;
          }
label_28:
          awaiter3.GetResult();
          awaiter3 = new TaskAwaiter();
          this.form1_0.textBox_52.Text = "1";
          Class73.smethod_161(Class25.class19_0, "[Kayıp GM] etkinliği başladı. Etkinlik bölgesi " + Form1.string_20);
          awaiter4 = Task.Delay(1000).GetAwaiter();
          if (!awaiter4.IsCompleted)
          {
            num = 3;
            this.int_0 = 3;
            this.taskAwaiter_0 = awaiter4;
            Form1.Class44 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class44>(ref awaiter4, ref stateMachine);
            return;
          }
label_31:
          awaiter4.GetResult();
          awaiter4 = new TaskAwaiter();
          this.form1_0.timer_1.Start();
          this.form1_0.method_16();
        }
        catch (Exception ex)
        {
          this.int_0 = -2;
          this.asyncVoidMethodBuilder_0.SetException(ex);
          return;
        }
label_33:
        this.int_0 = -2;
        this.asyncVoidMethodBuilder_0.SetResult();
      }

      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }

    private sealed class Class45 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public Form1 form1_0;
      private string string_0;
      private string string_1;
      private int int_1;
      private int int_2;
      private int int_3;
      private int int_4;
      private int int_5;
      private int int_6;
      private int int_7;
      private int int_8;
      private Exception exception_0;
      private string string_2;
      private SqlDataReader sqlDataReader_0;
      private int int_9;
      private Exception exception_1;
      private Exception exception_2;
      private Exception exception_3;
      private Exception exception_4;
      private Exception exception_5;
      private string string_3;
      private SqlDataReader sqlDataReader_1;
      private int int_10;
      private Exception exception_6;
      private Exception exception_7;
      private Exception exception_8;
      private Exception exception_9;
      private Exception exception_10;
      private string string_4;
      private SqlDataReader sqlDataReader_2;
      private int int_11;
      private Exception exception_11;
      private Exception exception_12;
      private Exception exception_13;
      private Exception exception_14;
      private Exception exception_15;
      private TaskAwaiter taskAwaiter_0;

      unsafe void IAsyncStateMachine.MoveNext()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(42);
        int num1 = this.int_0;
        try
        {
          TaskAwaiter awaiter1;
          int num2;
          TaskAwaiter awaiter2;
          TaskAwaiter awaiter3;
          TaskAwaiter awaiter4;
          TaskAwaiter awaiter5;
          TaskAwaiter awaiter6;
          TaskAwaiter awaiter7;
          TaskAwaiter awaiter8;
          TaskAwaiter awaiter9;
          TaskAwaiter awaiter10;
          TaskAwaiter awaiter11;
          TaskAwaiter awaiter12;
          TaskAwaiter awaiter13;
          TaskAwaiter awaiter14;
          TaskAwaiter awaiter15;
          TaskAwaiter awaiter16;
          TaskAwaiter awaiter17;
          TaskAwaiter awaiter18;
          switch (num1)
          {
            case 0:
              awaiter1 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              break;
            case 1:
              awaiter2 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_25;
            case 2:
              awaiter3 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_28;
            case 3:
              awaiter4 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_31;
            case 4:
              awaiter5 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_34;
            case 5:
              awaiter6 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_37;
            case 6:
              awaiter7 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_40;
            case 7:
              awaiter8 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_52;
            case 8:
            case 9:
            case 10:
            case 11:
label_55:
              try
              {
                TaskAwaiter awaiter19;
                TaskAwaiter awaiter20;
                TaskAwaiter awaiter21;
                TaskAwaiter awaiter22;
                switch (num1)
                {
                  case 8:
                    awaiter19 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num1 = -1;
                    this.int_0 = -1;
                    break;
                  case 9:
                    awaiter20 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num1 = -1;
                    this.int_0 = -1;
                    goto label_70;
                  case 10:
                    awaiter21 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num1 = -1;
                    this.int_0 = -1;
                    goto label_76;
                  case 11:
                    awaiter22 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num1 = -1;
                    this.int_0 = -1;
                    goto label_83;
                  default:
                    this.string_2 = "";
                    this.sqlDataReader_0 = new SqlCommand("select TOP 1 Plus,CharName16 from My_EventBot.._PlusLog where ItemID = " + (object) this.form1_0.int_7 + " and Plus >= " + this.form1_0.comboBox_0.Text + " order by  Plus desc", Class65.sqlConnection_0).ExecuteReader();
                    this.sqlDataReader_0.Read();
                    this.int_9 = (int) Convert.ToInt16(this.sqlDataReader_0["Plus"]);
                    this.string_2 = Convert.ToString(this.sqlDataReader_0["CharName16"]);
                    *(sbyte*) ((IntPtr) voidPtr + 23) = (sbyte) (this.string_2 != "");
                    if (*(sbyte*) ((IntPtr) voidPtr + 23) != (sbyte) 0)
                    {
                      Class73.smethod_161(Class25.class19_0, "[+" + (object) this.int_9 + "] Plus ile bu turun galibi [" + this.string_2 + "] olmuştur.Tebrikler.1 dakika sonra 2. tur başlayacaktır.");
                      awaiter19 = Task.Delay(1000).GetAwaiter();
                      if (!awaiter19.IsCompleted)
                      {
                        num1 = 8;
                        this.int_0 = 8;
                        this.taskAwaiter_0 = awaiter19;
                        Form1.Class45 stateMachine = this;
                        this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter19, ref stateMachine);
                        return;
                      }
                      break;
                    }
                    goto label_84;
                }
                awaiter19.GetResult();
                awaiter19 = new TaskAwaiter();
                *(sbyte*) ((IntPtr) voidPtr + 24) = (sbyte) this.form1_0.checkBox_18.Checked;
                if (*(sbyte*) ((IntPtr) voidPtr + 24) != (sbyte) 0)
                {
                  try
                  {
                    new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_2 + "',1," + this.form1_0.textBox_61.Text + "," + this.form1_0.textBox_60.Text + "," + this.form1_0.textBox_59.Text ?? "", Class65.sqlConnection_0).ExecuteNonQuery();
                    Form1.smethod_1("ITEM ödülü teslim Edildi.", Color.DarkGreen);
                  }
                  catch (Exception ex)
                  {
                    this.exception_1 = ex;
                    Form1.smethod_1("HATA ! İtem Ödülü teslim edilemedi!!" + this.exception_1.Message, Color.Salmon);
                  }
                }
                *(sbyte*) ((IntPtr) voidPtr + 25) = (sbyte) this.form1_0.checkBox_17.Checked;
                if (*(sbyte*) ((IntPtr) voidPtr + 25) != (sbyte) 0)
                {
                  try
                  {
                    new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_2 + "',2,böylekalsin," + this.form1_0.textBox_64.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
                    Form1.smethod_1("Silk ödülü teslim Edildi.", Color.DarkGreen);
                  }
                  catch
                  {
                  }
                  awaiter20 = Task.Delay(500).GetAwaiter();
                  if (!awaiter20.IsCompleted)
                  {
                    num1 = 9;
                    this.int_0 = 9;
                    this.taskAwaiter_0 = awaiter20;
                    Form1.Class45 stateMachine = this;
                    this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter20, ref stateMachine);
                    return;
                  }
                }
                else
                  goto label_79;
label_70:
                awaiter20.GetResult();
                awaiter20 = new TaskAwaiter();
                try
                {
                  new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_2 + "',3,böylekalsin," + this.form1_0.textBox_62.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
                  Form1.smethod_1("GOLD ödülü teslim Edildi.", Color.DarkGreen);
                }
                catch (Exception ex)
                {
                  this.exception_2 = ex;
                  Form1.smethod_1("HATA ! Gold ödülü teslim edilemedi.Ödül miktarı boş bırakılmış olabilir. !! ==> " + this.exception_2.Message, Color.OrangeRed);
                }
                awaiter21 = Task.Delay(500).GetAwaiter();
                if (!awaiter21.IsCompleted)
                {
                  num1 = 10;
                  this.int_0 = 10;
                  this.taskAwaiter_0 = awaiter21;
                  Form1.Class45 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter21, ref stateMachine);
                  return;
                }
label_76:
                awaiter21.GetResult();
                awaiter21 = new TaskAwaiter();
                try
                {
                  new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_2 + "',4,böylekalsin," + this.form1_0.textBox_63.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
                  Form1.smethod_1("SP ödülü teslim Edildi.", Color.DarkGreen);
                }
                catch (Exception ex)
                {
                  this.exception_3 = ex;
                  Form1.smethod_1("HATA ! Sp ödülü teslim edilemedi.Ödül miktarı boş bırakılmış olabilir. !! ==> " + this.exception_3.Message, Color.OrangeRed);
                }
label_79:
                if ((this.form1_0.checkBox_18.Checked ? 1 : (this.form1_0.checkBox_17.Checked ? 1 : 0)) != 0)
                {
                  Class73.smethod_123(Class25.class19_0, this.string_2, "Tebrikler.Ödülünü teslim ettik..");
                  awaiter22 = Task.Delay(1000).GetAwaiter();
                  if (!awaiter22.IsCompleted)
                  {
                    num1 = 11;
                    this.int_0 = 11;
                    this.taskAwaiter_0 = awaiter22;
                    Form1.Class45 stateMachine = this;
                    this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter22, ref stateMachine);
                    return;
                  }
                }
                else
                  goto label_84;
label_83:
                awaiter22.GetResult();
                awaiter22 = new TaskAwaiter();
                Class73.smethod_193(Class25.class19_0, this.string_2);
label_84:
                this.string_2 = (string) null;
                this.sqlDataReader_0 = (SqlDataReader) null;
              }
              catch (Exception ex)
              {
                this.exception_4 = ex;
                if ((this.exception_4.Message == "Hiç veri yokken okuma girişimi geçersiz." ? 1 : (this.exception_4.Message == "Invalid attempt to read when no data is present." ? 1 : 0)) != 0)
                  Class73.smethod_161(Class25.class19_0, "Belirlenen sınıra ulaşan olmadığı için bu turda kazanan olmadı.");
                Form1.smethod_0("1. Tur Alchemy kazanan plus değeri alınamadı. Açıklama ==> " + this.exception_4.Message);
              }
              try
              {
                new SqlCommand("Exec " + Form1.string_0 + ".._SEEK_N_DESTROY_ITEM 'ITEM_CH_BOW_03_BASIC'", Class65.sqlConnection_0).ExecuteNonQuery();
              }
              catch
              {
                Form1.smethod_0("1. tur Etkinlik itemleri karakterlerden silinemedi!!");
              }
              awaiter9 = Task.Delay(60000).GetAwaiter();
              if (!awaiter9.IsCompleted)
              {
                num2 = 12;
                this.int_0 = 12;
                this.taskAwaiter_0 = awaiter9;
                Form1.Class45 stateMachine = this;
                this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter9, ref stateMachine);
                return;
              }
              goto label_94;
            case 12:
              awaiter9 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_94;
            case 13:
              awaiter10 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_97;
            case 14:
              awaiter11 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_109;
            case 15:
            case 16:
            case 17:
            case 18:
label_112:
              try
              {
                TaskAwaiter awaiter19;
                TaskAwaiter awaiter20;
                TaskAwaiter awaiter21;
                TaskAwaiter awaiter22;
                switch (num1)
                {
                  case 15:
                    awaiter19 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num1 = -1;
                    this.int_0 = -1;
                    break;
                  case 16:
                    awaiter20 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num1 = -1;
                    this.int_0 = -1;
                    goto label_129;
                  case 17:
                    awaiter21 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num1 = -1;
                    this.int_0 = -1;
                    goto label_135;
                  case 18:
                    awaiter22 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num1 = -1;
                    this.int_0 = -1;
                    goto label_142;
                  default:
                    this.string_3 = "";
                    this.sqlDataReader_1 = new SqlCommand("select TOP 1 Plus,CharName16 from My_EventBot.._PlusLog where ItemID = " + (object) this.form1_0.int_7 + " and Plus >= " + this.form1_0.comboBox_0.Text + " order by  Plus desc", Class65.sqlConnection_0).ExecuteReader();
                    this.sqlDataReader_1.Read();
                    this.int_10 = (int) Convert.ToInt16(this.sqlDataReader_1["Plus"]);
                    this.string_3 = Convert.ToString(this.sqlDataReader_1["CharName16"]);
                    *(sbyte*) ((IntPtr) voidPtr + 30) = (sbyte) (this.string_3 != "");
                    if (*(sbyte*) ((IntPtr) voidPtr + 30) != (sbyte) 0)
                    {
                      Class73.smethod_161(Class25.class19_0, "[+" + (object) this.int_10 + "] Plus ile bu turun galibi [" + this.string_3 + "] olmuştur.Tebrikler.1 dakika sonra 3. tur başlayacaktır.");
                      awaiter19 = Task.Delay(500).GetAwaiter();
                      if (!awaiter19.IsCompleted)
                      {
                        num1 = 15;
                        this.int_0 = 15;
                        this.taskAwaiter_0 = awaiter19;
                        Form1.Class45 stateMachine = this;
                        this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter19, ref stateMachine);
                        return;
                      }
                      break;
                    }
                    *(sbyte*) ((IntPtr) voidPtr + 33) = (sbyte) (this.string_3 == "");
                    if (*(sbyte*) ((IntPtr) voidPtr + 33) != (sbyte) 0)
                    {
                      Class73.smethod_161(Class25.class19_0, "Belirlenen sınıra ulaşan olmadığı için bu turda kazanan olmadı.");
                      goto label_143;
                    }
                    else
                      goto label_143;
                }
                awaiter19.GetResult();
                awaiter19 = new TaskAwaiter();
                *(sbyte*) ((IntPtr) voidPtr + 31) = (sbyte) this.form1_0.checkBox_18.Checked;
                if (*(sbyte*) ((IntPtr) voidPtr + 31) != (sbyte) 0)
                {
                  try
                  {
                    new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_3 + "',1," + this.form1_0.textBox_61.Text + "," + this.form1_0.textBox_60.Text + "," + this.form1_0.textBox_59.Text ?? "", Class65.sqlConnection_0).ExecuteNonQuery();
                    Form1.smethod_1("ITEM ödülü teslim Edildi .", Color.DarkGreen);
                  }
                  catch (Exception ex)
                  {
                    this.exception_6 = ex;
                    Form1.smethod_1("HATA ! İtem Ödülü teslim edilemedi!!" + this.exception_6.Message, Color.Salmon);
                  }
                }
                *(sbyte*) ((IntPtr) voidPtr + 32) = (sbyte) this.form1_0.checkBox_17.Checked;
                if (*(sbyte*) ((IntPtr) voidPtr + 32) != (sbyte) 0)
                {
                  try
                  {
                    new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_3 + "',2,böylekalsin," + this.form1_0.textBox_64.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
                    Form1.smethod_1("Silk ödülü teslim Edildi.", Color.DarkGreen);
                  }
                  catch
                  {
                  }
                  awaiter20 = Task.Delay(500).GetAwaiter();
                  if (!awaiter20.IsCompleted)
                  {
                    num1 = 16;
                    this.int_0 = 16;
                    this.taskAwaiter_0 = awaiter20;
                    Form1.Class45 stateMachine = this;
                    this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter20, ref stateMachine);
                    return;
                  }
                }
                else
                  goto label_138;
label_129:
                awaiter20.GetResult();
                awaiter20 = new TaskAwaiter();
                try
                {
                  new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_3 + "',3,böylekalsin," + this.form1_0.textBox_62.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
                  Form1.smethod_1("GOLD ödülü teslim Edildi.", Color.DarkGreen);
                }
                catch (Exception ex)
                {
                  this.exception_7 = ex;
                  Form1.smethod_1("HATA ! Gold ödülü teslim edilemedi.Ödül miktarı boş bırakılmış olabilir. !! ==> " + this.exception_7.Message, Color.OrangeRed);
                }
                awaiter21 = Task.Delay(500).GetAwaiter();
                if (!awaiter21.IsCompleted)
                {
                  num1 = 17;
                  this.int_0 = 17;
                  this.taskAwaiter_0 = awaiter21;
                  Form1.Class45 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter21, ref stateMachine);
                  return;
                }
label_135:
                awaiter21.GetResult();
                awaiter21 = new TaskAwaiter();
                try
                {
                  new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_3 + "',4,böylekalsin," + this.form1_0.textBox_63.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
                  Form1.smethod_1("SP ödülü teslim Edildi.", Color.DarkGreen);
                }
                catch (Exception ex)
                {
                  this.exception_8 = ex;
                  Form1.smethod_1("HATA ! Sp ödülü teslim edilemedi.Ödül miktarı boş bırakılmış olabilir. !! ==> " + this.exception_8.Message, Color.OrangeRed);
                }
label_138:
                if ((this.form1_0.checkBox_18.Checked ? 1 : (this.form1_0.checkBox_17.Checked ? 1 : 0)) != 0)
                {
                  Class73.smethod_123(Class25.class19_0, this.string_3, "Tebrikler.Ödülünü teslim ettik..");
                  awaiter22 = Task.Delay(1000).GetAwaiter();
                  if (!awaiter22.IsCompleted)
                  {
                    num1 = 18;
                    this.int_0 = 18;
                    this.taskAwaiter_0 = awaiter22;
                    Form1.Class45 stateMachine = this;
                    this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter22, ref stateMachine);
                    return;
                  }
                }
                else
                  goto label_143;
label_142:
                awaiter22.GetResult();
                awaiter22 = new TaskAwaiter();
                Class73.smethod_193(Class25.class19_0, this.string_3);
label_143:
                this.string_3 = (string) null;
                this.sqlDataReader_1 = (SqlDataReader) null;
              }
              catch (Exception ex)
              {
                this.exception_9 = ex;
                if ((this.exception_9.Message == "Hiç veri yokken okuma girişimi geçersiz." ? 1 : (this.exception_9.Message == "Invalid attempt to read when no data is present." ? 1 : 0)) != 0)
                  Class73.smethod_161(Class25.class19_0, "Belirlenen sınıra ulaşan olmadığı için bu turda kazanan olmadı.");
                Form1.smethod_0("2. Tur Alchemy kazanan plus değeri alınamadı. Açıklama ==> " + this.exception_9.Message);
              }
              try
              {
                new SqlCommand("Exec  " + Form1.string_0 + ".._SEEK_N_DESTROY_ITEM 'ITEM_CH_SWORD_03_BASIC'", Class65.sqlConnection_0).ExecuteNonQuery();
                new SqlCommand("Exec  " + Form1.string_0 + ".._SEEK_N_DESTROY_ITEM 'ITEM_CH_BOW_03_BASIC'", Class65.sqlConnection_0).ExecuteNonQuery();
              }
              catch
              {
                Form1.smethod_0("2. tur Etkinlik itemleri karakterlerden silinemedi!!");
              }
              awaiter12 = Task.Delay(60000).GetAwaiter();
              if (!awaiter12.IsCompleted)
              {
                num2 = 19;
                this.int_0 = 19;
                this.taskAwaiter_0 = awaiter12;
                Form1.Class45 stateMachine = this;
                this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter12, ref stateMachine);
                return;
              }
              goto label_153;
            case 19:
              awaiter12 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_153;
            case 20:
              awaiter13 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_156;
            case 21:
              awaiter14 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_168;
            case 22:
            case 23:
            case 24:
            case 25:
label_171:
              try
              {
                TaskAwaiter awaiter19;
                TaskAwaiter awaiter20;
                TaskAwaiter awaiter21;
                TaskAwaiter awaiter22;
                switch (num1)
                {
                  case 22:
                    awaiter19 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num2 = -1;
                    this.int_0 = -1;
                    break;
                  case 23:
                    awaiter20 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num2 = -1;
                    this.int_0 = -1;
                    goto label_188;
                  case 24:
                    awaiter21 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num2 = -1;
                    this.int_0 = -1;
                    goto label_194;
                  case 25:
                    awaiter22 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num2 = -1;
                    this.int_0 = -1;
                    goto label_201;
                  default:
                    this.string_4 = "";
                    this.sqlDataReader_2 = new SqlCommand("select TOP 1 Plus,CharName16 from My_EventBot.._PlusLog where ItemID = " + (object) this.form1_0.int_7 + " and Plus >= " + this.form1_0.comboBox_0.Text + " order by  Plus desc", Class65.sqlConnection_0).ExecuteReader();
                    this.sqlDataReader_2.Read();
                    this.int_11 = (int) Convert.ToInt16(this.sqlDataReader_2["Plus"]);
                    this.string_4 = Convert.ToString(this.sqlDataReader_2["CharName16"]);
                    *(sbyte*) ((IntPtr) voidPtr + 38) = (sbyte) (this.string_4 != "");
                    if (*(sbyte*) ((IntPtr) voidPtr + 38) != (sbyte) 0)
                    {
                      Class73.smethod_161(Class25.class19_0, "[+" + (object) this.int_11 + "] Plus ile bu turun galibi [" + this.string_4 + "] olmuştur.Tebrikler.");
                      awaiter19 = Task.Delay(500).GetAwaiter();
                      if (!awaiter19.IsCompleted)
                      {
                        num2 = 22;
                        this.int_0 = 22;
                        this.taskAwaiter_0 = awaiter19;
                        Form1.Class45 stateMachine = this;
                        this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter19, ref stateMachine);
                        return;
                      }
                      break;
                    }
                    *(sbyte*) ((IntPtr) voidPtr + 41) = (sbyte) (this.string_4 == "");
                    if (*(sbyte*) ((IntPtr) voidPtr + 41) != (sbyte) 0)
                    {
                      Class73.smethod_161(Class25.class19_0, "Belirlenen sınıra ulaşan olmadığı için bu turda kazanan olmadı.");
                      goto label_202;
                    }
                    else
                      goto label_202;
                }
                awaiter19.GetResult();
                awaiter19 = new TaskAwaiter();
                *(sbyte*) ((IntPtr) voidPtr + 39) = (sbyte) this.form1_0.checkBox_18.Checked;
                if (*(sbyte*) ((IntPtr) voidPtr + 39) != (sbyte) 0)
                {
                  try
                  {
                    new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_4 + "',1," + this.form1_0.textBox_61.Text + "," + this.form1_0.textBox_60.Text + "," + this.form1_0.textBox_59.Text ?? "", Class65.sqlConnection_0).ExecuteNonQuery();
                    Form1.smethod_1("ITEM ödülü teslim edildi .", Color.DarkGreen);
                  }
                  catch (Exception ex)
                  {
                    this.exception_11 = ex;
                    Form1.smethod_1("HATA ! İtem Ödülü teslim edilemedi!!" + this.exception_11.Message, Color.Salmon);
                  }
                }
                *(sbyte*) ((IntPtr) voidPtr + 40) = (sbyte) this.form1_0.checkBox_17.Checked;
                if (*(sbyte*) ((IntPtr) voidPtr + 40) != (sbyte) 0)
                {
                  try
                  {
                    new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_4 + "',2,böylekalsin," + this.form1_0.textBox_64.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
                    Form1.smethod_1("Silk ödülü teslim Edildi.", Color.DarkGreen);
                  }
                  catch
                  {
                  }
                  awaiter20 = Task.Delay(500).GetAwaiter();
                  if (!awaiter20.IsCompleted)
                  {
                    num2 = 23;
                    this.int_0 = 23;
                    this.taskAwaiter_0 = awaiter20;
                    Form1.Class45 stateMachine = this;
                    this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter20, ref stateMachine);
                    return;
                  }
                }
                else
                  goto label_197;
label_188:
                awaiter20.GetResult();
                awaiter20 = new TaskAwaiter();
                try
                {
                  new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_4 + "',3,böylekalsin," + this.form1_0.textBox_62.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
                  Form1.smethod_1("GOLD ödülü teslim edildi.", Color.DarkGreen);
                }
                catch (Exception ex)
                {
                  this.exception_12 = ex;
                  Form1.smethod_1("HATA ! Gold ödülü teslim edilemedi.Ödül miktarı boş bırakılmış olabilir. !! ==> " + this.exception_12.Message, Color.OrangeRed);
                }
                awaiter21 = Task.Delay(500).GetAwaiter();
                if (!awaiter21.IsCompleted)
                {
                  num2 = 24;
                  this.int_0 = 24;
                  this.taskAwaiter_0 = awaiter21;
                  Form1.Class45 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter21, ref stateMachine);
                  return;
                }
label_194:
                awaiter21.GetResult();
                awaiter21 = new TaskAwaiter();
                try
                {
                  new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_4 + "',4,böylekalsin," + this.form1_0.textBox_63.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
                  Form1.smethod_1("SP ödülü teslim Edildi.", Color.DarkGreen);
                }
                catch (Exception ex)
                {
                  this.exception_13 = ex;
                  Form1.smethod_1("HATA ! SP ödülü teslim edilemedi.Ödül miktarı boş bırakılmış olabilir. !! ==> " + this.exception_13.Message, Color.OrangeRed);
                }
label_197:
                if ((this.form1_0.checkBox_18.Checked ? 1 : (this.form1_0.checkBox_17.Checked ? 1 : 0)) != 0)
                {
                  Class73.smethod_123(Class25.class19_0, this.string_4, "Tebrikler.Ödülünü teslim ettik..");
                  awaiter22 = Task.Delay(1000).GetAwaiter();
                  if (!awaiter22.IsCompleted)
                  {
                    num2 = 25;
                    this.int_0 = 25;
                    this.taskAwaiter_0 = awaiter22;
                    Form1.Class45 stateMachine = this;
                    this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter22, ref stateMachine);
                    return;
                  }
                }
                else
                  goto label_202;
label_201:
                awaiter22.GetResult();
                awaiter22 = new TaskAwaiter();
                Class73.smethod_193(Class25.class19_0, this.string_4);
label_202:
                this.string_4 = (string) null;
                this.sqlDataReader_2 = (SqlDataReader) null;
              }
              catch (Exception ex)
              {
                this.exception_14 = ex;
                if ((this.exception_14.Message == "Hiç veri yokken okuma girişimi geçersiz." ? 1 : (this.exception_14.Message == "Invalid attempt to read when no data is present." ? 1 : 0)) != 0)
                  Class73.smethod_161(Class25.class19_0, "Belirlenen sınıra ulaşan olmadığı için bu turda kazanan olmadı.");
                Form1.smethod_0("3. Tur Alchemy kazanan plus değeri alınamadı. Açıklama ==> " + this.exception_14.Message);
              }
              awaiter15 = Task.Delay(500).GetAwaiter();
              if (!awaiter15.IsCompleted)
              {
                num2 = 26;
                this.int_0 = 26;
                this.taskAwaiter_0 = awaiter15;
                Form1.Class45 stateMachine = this;
                this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter15, ref stateMachine);
                return;
              }
              goto label_209;
            case 26:
              awaiter15 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num2 = -1;
              this.int_0 = -1;
              goto label_209;
            case 27:
              awaiter16 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num2 = -1;
              this.int_0 = -1;
              goto label_215;
            case 28:
              awaiter17 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num2 = -1;
              this.int_0 = -1;
              goto label_218;
            case 29:
              awaiter18 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num2 = -1;
              this.int_0 = -1;
              goto label_224;
            default:
              *(sbyte*) ((IntPtr) voidPtr + 16) = (sbyte) (Class73.smethod_129(this.form1_0.label_13.Text) == Class32.string_0);
              if (*(sbyte*) ((IntPtr) voidPtr + 16) != (sbyte) 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 17) = (sbyte) (this.form1_0.label_160.Text == "ONLİNE");
                if (*(sbyte*) ((IntPtr) voidPtr + 17) == (sbyte) 0)
                {
                  *(sbyte*) ((IntPtr) voidPtr + 18) = (sbyte) (this.form1_0.label_160.Text == "OFFLİNE");
                  if (*(sbyte*) ((IntPtr) voidPtr + 18) != (sbyte) 0)
                  {
                    this.form1_0.method_2((object) this.form1_0.button_19, new EventArgs());
                    Class73.smethod_118("[Alchemy]", this.form1_0);
                    goto label_228;
                  }
                }
                this.string_0 = "";
                this.string_1 = "";
                if ((this.form1_0.textBox_94.Text != "" ? 1 : (this.form1_0.textBox_94.Text != "Sun Sword ( 1 Dg )" ? 1 : 0)) != 0)
                  this.string_1 = this.form1_0.textBox_94.Text ?? "";
                if ((this.form1_0.textBox_94.Text == "" ? 1 : (this.form1_0.textBox_94.Text == "Sun Sword ( 1 Dg )" ? 1 : 0)) != 0)
                {
                  this.string_1 = this.form1_0.textBox_61.Text ?? "";
                  Form1.smethod_0("[Alchemy] etkinliğinin İTEM ödülü için isim girilmemiş.Lütfen kontrol edin.İsim için bu seferlik itemin kodu kullanıldı!!");
                }
                if ((!this.form1_0.checkBox_18.Checked ? 0 : (!this.form1_0.checkBox_17.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Etkinlik Ödülü ==>  " + this.form1_0.textBox_60.Text + " adet [" + this.string_1 + "] +" + this.form1_0.textBox_59.Text ?? "";
                if ((!this.form1_0.checkBox_17.Checked ? 0 : (!this.form1_0.checkBox_18.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Etkinlik Ödülü ==> Silk = " + this.form1_0.textBox_64.Text + " , Gold = " + this.form1_0.textBox_62.Text + " , Sp = " + this.form1_0.textBox_63.Text;
                if ((!this.form1_0.checkBox_17.Checked ? 0 : (this.form1_0.checkBox_18.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Etkinlik Ödülü ==>  " + this.form1_0.textBox_60.Text + " adet [" + this.string_1 + "] +" + this.form1_0.textBox_59.Text + ", Silk = " + this.form1_0.textBox_64.Text + " , Gold = " + this.form1_0.textBox_62.Text + " , Sp = " + this.form1_0.textBox_63.Text ?? "";
                if ((this.form1_0.checkBox_17.Checked ? 0 : (!this.form1_0.checkBox_18.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Bu ödülsüz bir etkinliktir.";
                this.int_1 = (int) Convert.ToInt16(this.form1_0.textBox_25.Text);
                this.int_2 = 24202;
                this.int_3 = 24178;
                this.int_4 = 24196;
                this.int_5 = (int) Convert.ToInt16(this.form1_0.comboBox_2.Text);
                this.form1_0.checkBox_9.Checked = true;
                Class73.smethod_161(Class25.class19_0, "Merhaba. 5 dakika sonra Downhang East Gate'de [Alchemy] etkinliği yapılacaktır.");
                awaiter1 = Task.Delay(7000).GetAwaiter();
                if (!awaiter1.IsCompleted)
                {
                  num2 = 0;
                  this.int_0 = 0;
                  this.taskAwaiter_0 = awaiter1;
                  Form1.Class45 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter1, ref stateMachine);
                  return;
                }
                break;
              }
              Class73.smethod_27(this.form1_0);
              goto label_228;
          }
          awaiter1.GetResult();
          awaiter1 = new TaskAwaiter();
          Class73.smethod_161(Class25.class19_0, this.string_0 ?? "");
          awaiter2 = Task.Delay(300000).GetAwaiter();
          if (!awaiter2.IsCompleted)
          {
            num2 = 1;
            this.int_0 = 1;
            this.taskAwaiter_0 = awaiter2;
            Form1.Class45 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter2, ref stateMachine);
            return;
          }
label_25:
          awaiter2.GetResult();
          awaiter2 = new TaskAwaiter();
          Class73.smethod_101();
          awaiter3 = Task.Delay(1000).GetAwaiter();
          if (!awaiter3.IsCompleted)
          {
            num2 = 2;
            this.int_0 = 2;
            this.taskAwaiter_0 = awaiter3;
            Form1.Class45 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter3, ref stateMachine);
            return;
          }
label_28:
          awaiter3.GetResult();
          awaiter3 = new TaskAwaiter();
          Class73.smethod_241(Class25.class19_0);
          awaiter4 = Task.Delay(250).GetAwaiter();
          if (!awaiter4.IsCompleted)
          {
            num2 = 3;
            this.int_0 = 3;
            this.taskAwaiter_0 = awaiter4;
            Form1.Class45 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter4, ref stateMachine);
            return;
          }
label_31:
          awaiter4.GetResult();
          awaiter4 = new TaskAwaiter();
          Class73.smethod_161(Class25.class19_0, "Downhang East Gate'de [Alchemy] etkinliği başlamıştır.Başarılar..");
          this.form1_0.timer_8.Start();
          awaiter5 = Task.Delay(5000).GetAwaiter();
          if (!awaiter5.IsCompleted)
          {
            num2 = 4;
            this.int_0 = 4;
            this.taskAwaiter_0 = awaiter5;
            Form1.Class45 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter5, ref stateMachine);
            return;
          }
label_34:
          awaiter5.GetResult();
          awaiter5 = new TaskAwaiter();
          Class73.smethod_218(Class25.class19_0, "1. tur başladı. [ 5 DAKİKA ] sonra basılan [+" + this.form1_0.comboBox_0.Text + "] ve üzeri pluslar değerlendirilecektir.Başarılar.");
          awaiter6 = Task.Delay(50).GetAwaiter();
          if (!awaiter6.IsCompleted)
          {
            num2 = 5;
            this.int_0 = 5;
            this.taskAwaiter_0 = awaiter6;
            Form1.Class45 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter6, ref stateMachine);
            return;
          }
label_37:
          awaiter6.GetResult();
          awaiter6 = new TaskAwaiter();
          Form1 form10_1 = this.form1_0;
          *(int*) ((IntPtr) voidPtr + 4) = this.int_2;
          *(int*) ((IntPtr) voidPtr + 8) = this.int_5;
          *(int*) ((IntPtr) voidPtr + 12) = this.int_1;
          Class73.smethod_130(*(int*) ((IntPtr) voidPtr + 12), *(int*) ((IntPtr) voidPtr + 8), form10_1, *(int*) ((IntPtr) voidPtr + 4));
          awaiter7 = Task.Delay(5000).GetAwaiter();
          if (!awaiter7.IsCompleted)
          {
            num2 = 6;
            this.int_0 = 6;
            this.taskAwaiter_0 = awaiter7;
            Form1.Class45 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter7, ref stateMachine);
            return;
          }
label_40:
          awaiter7.GetResult();
          awaiter7 = new TaskAwaiter();
          this.form1_0.int_7 = 24202;
          this.form1_0.int_8 = 1;
          Class73.smethod_218(Class25.class19_0, "1. tur itemi (3 Degree Bow). Başka itemlere basılan artılar geçersizdir.");
          try
          {
            new SqlCommand("delete My_EventBot.._PlusLog", Class65.sqlConnection_0).ExecuteNonQuery();
          }
          catch (Exception ex)
          {
            this.exception_0 = ex;
            Form1.smethod_0("[Alchemy] etkinliği 1. tur başlangıcında  _PlusLog tablosu temizlenemedi. HATA =>" + this.exception_0.Message);
          }
          this.int_6 = 0;
label_49:
          *(sbyte*) ((IntPtr) voidPtr + 22) = (sbyte) (this.int_6 < 300);
          if (*(sbyte*) ((IntPtr) voidPtr + 22) != (sbyte) 0)
          {
            awaiter8 = Task.Delay(1000).GetAwaiter();
            if (!awaiter8.IsCompleted)
            {
              num2 = 7;
              this.int_0 = 7;
              this.taskAwaiter_0 = awaiter8;
              Form1.Class45 stateMachine = this;
              this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter8, ref stateMachine);
              return;
            }
          }
          else
          {
            this.int_6 = 0;
            goto label_55;
          }
label_52:
          awaiter8.GetResult();
          awaiter8 = new TaskAwaiter();
          *(int*) voidPtr = this.int_6;
          this.int_6 = *(int*) voidPtr + 1;
          *(sbyte*) ((IntPtr) voidPtr + 19) = (sbyte) (this.int_6 == 60);
          if (*(sbyte*) ((IntPtr) voidPtr + 19) != (sbyte) 0)
            goto label_51;
label_45:
          *(sbyte*) ((IntPtr) voidPtr + 20) = (sbyte) (this.int_6 == 120);
          if (*(sbyte*) ((IntPtr) voidPtr + 20) != (sbyte) 0)
          {
            Form1 form10_2 = this.form1_0;
            *(int*) ((IntPtr) voidPtr + 4) = this.int_2;
            *(int*) ((IntPtr) voidPtr + 8) = this.int_5;
            *(int*) ((IntPtr) voidPtr + 12) = this.int_1;
            Class73.smethod_130(*(int*) ((IntPtr) voidPtr + 12), *(int*) ((IntPtr) voidPtr + 8), form10_2, *(int*) ((IntPtr) voidPtr + 4));
            Class73.smethod_218(Class25.class19_0, "1. tur itemi (3 Degree Bow). Başka itemlere basılan artılar geçersizdir.Sadece kullanacağınız kadar item alın..");
          }
          *(sbyte*) ((IntPtr) voidPtr + 21) = (sbyte) (this.int_6 == 180);
          if (*(sbyte*) ((IntPtr) voidPtr + 21) != (sbyte) 0)
          {
            Form1 form10_2 = this.form1_0;
            *(int*) ((IntPtr) voidPtr + 4) = this.int_2;
            *(int*) ((IntPtr) voidPtr + 8) = this.int_5;
            *(int*) ((IntPtr) voidPtr + 12) = this.int_1;
            Class73.smethod_130(*(int*) ((IntPtr) voidPtr + 12), *(int*) ((IntPtr) voidPtr + 8), form10_2, *(int*) ((IntPtr) voidPtr + 4));
            Class73.smethod_218(Class25.class19_0, "1. tur itemi (3 Degree Bow). Başka itemlere basılan artılar geçersizdir.Sadece kullanacağınız kadar item alın..");
            goto label_49;
          }
          else
            goto label_49;
label_51:
          Form1 form10_3 = this.form1_0;
          *(int*) ((IntPtr) voidPtr + 4) = this.int_2;
          *(int*) ((IntPtr) voidPtr + 8) = this.int_5;
          *(int*) ((IntPtr) voidPtr + 12) = this.int_1;
          Class73.smethod_130(*(int*) ((IntPtr) voidPtr + 12), *(int*) ((IntPtr) voidPtr + 8), form10_3, *(int*) ((IntPtr) voidPtr + 4));
          Class73.smethod_218(Class25.class19_0, "1. tur itemi (3 Degree Bow). Başka itemlere basılan artılar geçersizdir.Sadece kullanacağınız kadar item alın..");
          goto label_45;
label_94:
          awaiter9.GetResult();
          awaiter9 = new TaskAwaiter();
          Class73.smethod_218(Class25.class19_0, "2. tur başladı. [ 5 DAKİKA ] sonra basılan [+" + this.form1_0.comboBox_0.Text + "] ve üzeri pluslar değerlendirilecektir.Başarılar.");
          Form1 form10_4 = this.form1_0;
          *(int*) ((IntPtr) voidPtr + 4) = this.int_3;
          *(int*) ((IntPtr) voidPtr + 8) = this.int_5;
          *(int*) ((IntPtr) voidPtr + 12) = this.int_1;
          Class73.smethod_130(*(int*) ((IntPtr) voidPtr + 12), *(int*) ((IntPtr) voidPtr + 8), form10_4, *(int*) ((IntPtr) voidPtr + 4));
          awaiter10 = Task.Delay(5000).GetAwaiter();
          if (!awaiter10.IsCompleted)
          {
            num2 = 13;
            this.int_0 = 13;
            this.taskAwaiter_0 = awaiter10;
            Form1.Class45 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter10, ref stateMachine);
            return;
          }
label_97:
          awaiter10.GetResult();
          awaiter10 = new TaskAwaiter();
          this.form1_0.int_7 = 24178;
          this.form1_0.int_8 = 2;
          Class73.smethod_218(Class25.class19_0, "2. tur itemi (3 Degree Sword). Başka itemlere basılan artılar geçersizdir.");
          try
          {
            new SqlCommand("delete My_EventBot.._PlusLog", Class65.sqlConnection_0).ExecuteNonQuery();
          }
          catch (Exception ex)
          {
            this.exception_5 = ex;
            Form1.smethod_0("[Alchemy] etkinliği 2. tur başlangıcında  _PlusLog tablosu temizlenemedi. HATA =>" + this.exception_5.Message);
          }
          this.int_7 = 0;
label_106:
          *(sbyte*) ((IntPtr) voidPtr + 29) = (sbyte) (this.int_7 < 300);
          if (*(sbyte*) ((IntPtr) voidPtr + 29) != (sbyte) 0)
          {
            awaiter11 = Task.Delay(1000).GetAwaiter();
            if (!awaiter11.IsCompleted)
            {
              num2 = 14;
              this.int_0 = 14;
              this.taskAwaiter_0 = awaiter11;
              Form1.Class45 stateMachine = this;
              this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter11, ref stateMachine);
              return;
            }
          }
          else
          {
            this.int_7 = 0;
            goto label_112;
          }
label_109:
          awaiter11.GetResult();
          awaiter11 = new TaskAwaiter();
          *(int*) voidPtr = this.int_7;
          this.int_7 = *(int*) voidPtr + 1;
          *(sbyte*) ((IntPtr) voidPtr + 26) = (sbyte) (this.int_7 == 60);
          if (*(sbyte*) ((IntPtr) voidPtr + 26) != (sbyte) 0)
            goto label_108;
label_102:
          *(sbyte*) ((IntPtr) voidPtr + 27) = (sbyte) (this.int_7 == 120);
          if (*(sbyte*) ((IntPtr) voidPtr + 27) != (sbyte) 0)
          {
            Form1 form10_2 = this.form1_0;
            *(int*) ((IntPtr) voidPtr + 4) = this.int_3;
            *(int*) ((IntPtr) voidPtr + 8) = this.int_5;
            *(int*) ((IntPtr) voidPtr + 12) = this.int_1;
            Class73.smethod_130(*(int*) ((IntPtr) voidPtr + 12), *(int*) ((IntPtr) voidPtr + 8), form10_2, *(int*) ((IntPtr) voidPtr + 4));
            Class73.smethod_218(Class25.class19_0, "2. tur itemi (3 Degree Sword). Başka itemlere basılan artılar geçersizdir.Sadece kullanacağınız kadar item alın..");
          }
          *(sbyte*) ((IntPtr) voidPtr + 28) = (sbyte) (this.int_7 == 180);
          if (*(sbyte*) ((IntPtr) voidPtr + 28) != (sbyte) 0)
          {
            Form1 form10_2 = this.form1_0;
            *(int*) ((IntPtr) voidPtr + 4) = this.int_3;
            *(int*) ((IntPtr) voidPtr + 8) = this.int_5;
            *(int*) ((IntPtr) voidPtr + 12) = this.int_1;
            Class73.smethod_130(*(int*) ((IntPtr) voidPtr + 12), *(int*) ((IntPtr) voidPtr + 8), form10_2, *(int*) ((IntPtr) voidPtr + 4));
            Class73.smethod_218(Class25.class19_0, "2. tur itemi (3 Degree Sword). Başka itemlere basılan artılar geçersizdir.Sadece kullanacağınız kadar item alın..");
            goto label_106;
          }
          else
            goto label_106;
label_108:
          Form1 form10_5 = this.form1_0;
          *(int*) ((IntPtr) voidPtr + 4) = this.int_3;
          *(int*) ((IntPtr) voidPtr + 8) = this.int_5;
          *(int*) ((IntPtr) voidPtr + 12) = this.int_1;
          Class73.smethod_130(*(int*) ((IntPtr) voidPtr + 12), *(int*) ((IntPtr) voidPtr + 8), form10_5, *(int*) ((IntPtr) voidPtr + 4));
          Class73.smethod_218(Class25.class19_0, "2. tur itemi (3 Degree Sword). Başka itemlere basılan artılar geçersizdir.Sadece kullanacağınız kadar item alın..");
          goto label_102;
label_153:
          awaiter12.GetResult();
          awaiter12 = new TaskAwaiter();
          Class73.smethod_218(Class25.class19_0, "3. tur başladı. [ 5 DAKİKA ] sonra basılan [+" + this.form1_0.comboBox_0.Text + "] ve üzeri pluslar değerlendirilecektir.Başarılar.");
          Form1 form10_6 = this.form1_0;
          *(int*) ((IntPtr) voidPtr + 4) = this.int_4;
          *(int*) ((IntPtr) voidPtr + 8) = this.int_5;
          *(int*) ((IntPtr) voidPtr + 12) = this.int_1;
          Class73.smethod_130(*(int*) ((IntPtr) voidPtr + 12), *(int*) ((IntPtr) voidPtr + 8), form10_6, *(int*) ((IntPtr) voidPtr + 4));
          awaiter13 = Task.Delay(5000).GetAwaiter();
          if (!awaiter13.IsCompleted)
          {
            num2 = 20;
            this.int_0 = 20;
            this.taskAwaiter_0 = awaiter13;
            Form1.Class45 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter13, ref stateMachine);
            return;
          }
label_156:
          awaiter13.GetResult();
          awaiter13 = new TaskAwaiter();
          this.form1_0.int_7 = 24196;
          this.form1_0.int_8 = 3;
          Class73.smethod_218(Class25.class19_0, "3. tur itemi (3 Degree Glavie). Başka itemlere basılan artılar geçersizdir.");
          try
          {
            new SqlCommand("delete My_EventBot.._PlusLog", Class65.sqlConnection_0).ExecuteNonQuery();
          }
          catch (Exception ex)
          {
            this.exception_10 = ex;
            Form1.smethod_0("[Alchemy] etkinliği 3. tur başlangıcında  _PlusLog tablosu temizlenemedi. HATA =>" + this.exception_10.Message);
          }
          this.int_8 = 0;
label_165:
          *(sbyte*) ((IntPtr) voidPtr + 37) = (sbyte) (this.int_8 < 300);
          if (*(sbyte*) ((IntPtr) voidPtr + 37) != (sbyte) 0)
          {
            awaiter14 = Task.Delay(1000).GetAwaiter();
            if (!awaiter14.IsCompleted)
            {
              num2 = 21;
              this.int_0 = 21;
              this.taskAwaiter_0 = awaiter14;
              Form1.Class45 stateMachine = this;
              this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter14, ref stateMachine);
              return;
            }
          }
          else
          {
            this.int_8 = 0;
            goto label_171;
          }
label_168:
          awaiter14.GetResult();
          awaiter14 = new TaskAwaiter();
          *(int*) voidPtr = this.int_8;
          this.int_8 = *(int*) voidPtr + 1;
          *(sbyte*) ((IntPtr) voidPtr + 34) = (sbyte) (this.int_8 == 60);
          if (*(sbyte*) ((IntPtr) voidPtr + 34) != (sbyte) 0)
            goto label_167;
label_161:
          *(sbyte*) ((IntPtr) voidPtr + 35) = (sbyte) (this.int_8 == 120);
          if (*(sbyte*) ((IntPtr) voidPtr + 35) != (sbyte) 0)
          {
            Form1 form10_2 = this.form1_0;
            *(int*) ((IntPtr) voidPtr + 4) = this.int_4;
            *(int*) ((IntPtr) voidPtr + 8) = this.int_5;
            *(int*) ((IntPtr) voidPtr + 12) = this.int_1;
            Class73.smethod_130(*(int*) ((IntPtr) voidPtr + 12), *(int*) ((IntPtr) voidPtr + 8), form10_2, *(int*) ((IntPtr) voidPtr + 4));
            Class73.smethod_218(Class25.class19_0, "3. tur itemi (3 Degree Glavie).Başka itemlere basılan artılar geçersizdir.Sadece kullanacağınız kadar item alın..");
          }
          *(sbyte*) ((IntPtr) voidPtr + 36) = (sbyte) (this.int_8 == 180);
          if (*(sbyte*) ((IntPtr) voidPtr + 36) != (sbyte) 0)
          {
            Form1 form10_2 = this.form1_0;
            *(int*) ((IntPtr) voidPtr + 4) = this.int_4;
            *(int*) ((IntPtr) voidPtr + 8) = this.int_5;
            *(int*) ((IntPtr) voidPtr + 12) = this.int_1;
            Class73.smethod_130(*(int*) ((IntPtr) voidPtr + 12), *(int*) ((IntPtr) voidPtr + 8), form10_2, *(int*) ((IntPtr) voidPtr + 4));
            Class73.smethod_218(Class25.class19_0, "3. tur itemi (3 Degree Glavie).Başka itemlere basılan artılar geçersizdir.Sadece kullanacağınız kadar item alın..");
            goto label_165;
          }
          else
            goto label_165;
label_167:
          Form1 form10_7 = this.form1_0;
          *(int*) ((IntPtr) voidPtr + 4) = this.int_4;
          *(int*) ((IntPtr) voidPtr + 8) = this.int_5;
          *(int*) ((IntPtr) voidPtr + 12) = this.int_1;
          Class73.smethod_130(*(int*) ((IntPtr) voidPtr + 12), *(int*) ((IntPtr) voidPtr + 8), form10_7, *(int*) ((IntPtr) voidPtr + 4));
          Class73.smethod_218(Class25.class19_0, "3. tur itemi (3 Degree Glavie).Başka itemlere basılan artılar geçersizdir.Sadece kullanacağınız kadar item alın..");
          goto label_161;
label_209:
          awaiter15.GetResult();
          awaiter15 = new TaskAwaiter();
          try
          {
            new SqlCommand("Exec  " + Form1.string_0 + ".._SEEK_N_DESTROY_ITEM 'ITEM_CH_BOW_03_BASIC'", Class65.sqlConnection_0).ExecuteNonQuery();
            new SqlCommand("Exec  " + Form1.string_0 + ".._SEEK_N_DESTROY_ITEM 'ITEM_CH_SWORD_03_BASIC'", Class65.sqlConnection_0).ExecuteNonQuery();
            new SqlCommand("Exec  " + Form1.string_0 + ".._SEEK_N_DESTROY_ITEM 'ITEM_CH_TBLADE_03_BASIC'", Class65.sqlConnection_0).ExecuteNonQuery();
          }
          catch
          {
            Form1.smethod_0("3. tur Etkinlik itemleri karakterlerden silinemedi!!");
          }
          awaiter16 = Task.Delay(3000).GetAwaiter();
          if (!awaiter16.IsCompleted)
          {
            num2 = 27;
            this.int_0 = 27;
            this.taskAwaiter_0 = awaiter16;
            Form1.Class45 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter16, ref stateMachine);
            return;
          }
label_215:
          awaiter16.GetResult();
          awaiter16 = new TaskAwaiter();
          Class73.smethod_161(Class25.class19_0, "[Alchemy] Etkinliği sona erdi. Başka etkinliklerde görüşmek üzere.");
          this.form1_0.int_7 = 0;
          this.form1_0.int_8 = 0;
          awaiter17 = Task.Delay(1000).GetAwaiter();
          if (!awaiter17.IsCompleted)
          {
            num2 = 28;
            this.int_0 = 28;
            this.taskAwaiter_0 = awaiter17;
            Form1.Class45 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter17, ref stateMachine);
            return;
          }
label_218:
          awaiter17.GetResult();
          awaiter17 = new TaskAwaiter();
          Class73.smethod_206(Class25.class19_0);
          this.form1_0.checkBox_9.Checked = false;
          this.form1_0.timer_8.Stop();
          try
          {
            new SqlCommand("delete My_EventBot.._PlusLog", Class65.sqlConnection_0).ExecuteNonQuery();
          }
          catch (Exception ex)
          {
            this.exception_15 = ex;
            Form1.smethod_0("[Alchemy] etkinliği bitimi _PlusLog tablosu temizlenemedi. HATA =>" + this.exception_15.Message);
          }
          awaiter18 = Task.Delay(180000).GetAwaiter();
          if (!awaiter18.IsCompleted)
          {
            num2 = 29;
            this.int_0 = 29;
            this.taskAwaiter_0 = awaiter18;
            Form1.Class45 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class45>(ref awaiter18, ref stateMachine);
            return;
          }
label_224:
          awaiter18.GetResult();
          awaiter18 = new TaskAwaiter();
          try
          {
            new SqlCommand("Exec  " + Form1.string_0 + ".._SEEK_N_DESTROY_ITEM 'ITEM_CH_BOW_03_BASIC'", Class65.sqlConnection_0).ExecuteNonQuery();
            new SqlCommand("Exec  " + Form1.string_0 + ".._SEEK_N_DESTROY_ITEM 'ITEM_CH_SWORD_03_BASIC'", Class65.sqlConnection_0).ExecuteNonQuery();
            new SqlCommand("Exec  " + Form1.string_0 + ".._SEEK_N_DESTROY_ITEM 'ITEM_CH_TBLADE_03_BASIC'", Class65.sqlConnection_0).ExecuteNonQuery();
          }
          catch
          {
            Form1.smethod_0("3. tur Etkinlik itemleri karakterlerden silinemedi!!");
          }
        }
        catch (Exception ex)
        {
          this.int_0 = -2;
          this.asyncVoidMethodBuilder_0.SetException(ex);
          return;
        }
label_228:
        this.int_0 = -2;
        this.asyncVoidMethodBuilder_0.SetResult();
      }

      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }

    private sealed class Class46 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public int int_1;
      public Form1 form1_0;
      private string string_0;
      private string string_1;
      private int int_2;
      private int int_3;
      private int int_4;
      private SqlDataReader sqlDataReader_0;
      private string string_2;
      private string string_3;
      private SqlDataReader sqlDataReader_1;
      private string string_4;
      private SqlDataReader sqlDataReader_2;
      private int int_5;
      private int int_6;
      private Exception exception_0;
      private TaskAwaiter taskAwaiter_0;

      unsafe void IAsyncStateMachine.MoveNext()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(17);
        int num1 = this.int_0;
        try
        {
          TaskAwaiter awaiter1;
          int num2;
          TaskAwaiter awaiter2;
          TaskAwaiter awaiter3;
          TaskAwaiter awaiter4;
          TaskAwaiter awaiter5;
          switch (num1)
          {
            case 0:
              awaiter1 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              break;
            case 1:
              awaiter2 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_25;
            case 2:
              awaiter3 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_28;
            case 3:
              awaiter4 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_58;
            case 4:
            case 5:
label_30:
              try
              {
                TaskAwaiter awaiter6;
                while (true)
                {
                  if (num1 != 4)
                  {
                    if (num1 != 5)
                    {
                      this.sqlDataReader_0 = new SqlCommand("exec My_EventBot..__SoruCevap 'SoruBul','cevapyok'", Class65.sqlConnection_0).ExecuteReader();
                      this.sqlDataReader_0.Read();
                      this.string_2 = Convert.ToString(this.sqlDataReader_0[0]);
                      this.string_3 = Convert.ToString(this.sqlDataReader_0[1]);
                      this.form1_0.textBox_79.Text = this.string_3;
                      this.form1_0.textBox_66.Text = this.string_2;
                      this.form1_0.textBox_65.Text = this.string_3;
                      *(sbyte*) ((IntPtr) voidPtr + 7) = (sbyte) (this.string_2.ToString() == "");
                      if (*(sbyte*) ((IntPtr) voidPtr + 7) != (sbyte) 0)
                      {
                        Form1.smethod_0("Veritabanından soru alınamadı.!!! _SoruCevap Tablosunda hiç soru olmayabilir.Lütfen kontrol ediniz.Sistem geçici soru ekledi.");
                        awaiter6 = Task.Delay(3000).GetAwaiter();
                        if (!awaiter6.IsCompleted)
                          break;
                      }
                      else
                        goto label_35;
                    }
                    else
                      goto label_39;
                  }
                  else
                  {
                    awaiter6 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num1 = -1;
                    this.int_0 = -1;
                  }
                  awaiter6.GetResult();
                  awaiter6 = new TaskAwaiter();
                  this.sqlDataReader_2 = new SqlCommand("exec My_EventBot..__SoruCevap 'SoruEkle','gerekyok'", Class65.sqlConnection_0).ExecuteReader();
                }
                num2 = 4;
                this.int_0 = 4;
                this.taskAwaiter_0 = awaiter6;
                Form1.Class46 stateMachine1 = this;
                this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class46>(ref awaiter6, ref stateMachine1);
                return;
label_35:
                *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) (this.string_2.ToString() != "");
                if (*(sbyte*) ((IntPtr) voidPtr + 8) != (sbyte) 0)
                  Class73.smethod_161(Class25.class19_0, "(Cevaplama süresi " + (object) this.int_3 + " saniye) " + this.form1_0.textBox_80.Text + ". Soru = " + this.string_2);
                TaskAwaiter awaiter7 = Task.Delay(this.int_3 * 1000).GetAwaiter();
                if (!awaiter7.IsCompleted)
                {
                  num2 = 5;
                  this.int_0 = 5;
                  this.taskAwaiter_0 = awaiter7;
                  Form1.Class46 stateMachine2 = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class46>(ref awaiter7, ref stateMachine2);
                  return;
                }
                goto label_40;
label_39:
                awaiter7 = this.taskAwaiter_0;
                this.taskAwaiter_0 = new TaskAwaiter();
                num1 = -1;
                this.int_0 = -1;
label_40:
                awaiter7.GetResult();
                awaiter7 = new TaskAwaiter();
                this.sqlDataReader_1 = new SqlCommand("exec My_EventBot..__SoruCevap 'KazananıBul','" + this.string_3 + "'", Class65.sqlConnection_0).ExecuteReader();
                this.sqlDataReader_1.Read();
                this.string_4 = Convert.ToString(this.sqlDataReader_1[0]);
                *(sbyte*) ((IntPtr) voidPtr + 9) = (sbyte) (this.string_4.ToString() == "");
                if (*(sbyte*) ((IntPtr) voidPtr + 9) != (sbyte) 0)
                {
                  this.int_5 = (int) Convert.ToInt16(this.form1_0.textBox_80.Text);
                  *(int*) voidPtr = this.int_5;
                  this.int_5 = *(int*) voidPtr + 1;
                  *(int*) voidPtr = this.int_2;
                  this.int_2 = *(int*) voidPtr - 1;
                  this.form1_0.textBox_80.Text = string.Concat((object) this.int_5);
                  *(sbyte*) ((IntPtr) voidPtr + 10) = (sbyte) (this.int_2 == 0);
                  if (*(sbyte*) ((IntPtr) voidPtr + 10) != (sbyte) 0)
                  {
                    Class73.smethod_161(Class25.class19_0, "Bu soruya doğru cevap veren olmadı.");
                  }
                  else
                  {
                    *(sbyte*) ((IntPtr) voidPtr + 11) = (sbyte) ((uint) this.int_2 > 0U);
                    if (*(sbyte*) ((IntPtr) voidPtr + 11) != (sbyte) 0)
                      Class73.smethod_161(Class25.class19_0, "Bu soruya doğru cevap veren olmadı." + (object) this.int_4 + " saniye sonra yeni soru sorulacak.");
                  }
                }
                *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) (this.string_4.ToString() != "");
                if (*(sbyte*) ((IntPtr) voidPtr + 12) != (sbyte) 0)
                {
                  this.int_6 = (int) Convert.ToInt16(this.form1_0.textBox_80.Text);
                  *(int*) voidPtr = this.int_6;
                  this.int_6 = *(int*) voidPtr + 1;
                  this.form1_0.textBox_80.Text = string.Concat((object) this.int_6);
                  *(int*) voidPtr = this.int_2;
                  this.int_2 = *(int*) voidPtr - 1;
                  *(sbyte*) ((IntPtr) voidPtr + 13) = (sbyte) (this.int_2 == 0);
                  if (*(sbyte*) ((IntPtr) voidPtr + 13) != (sbyte) 0)
                  {
                    Form1.smethod_0("Kazanan ==> [" + this.string_4 + "]");
                    Class73.smethod_161(Class25.class19_0, "Doğru cevap olan [" + this.string_3 + "], en erken [" + this.string_4 + "] isimli karakter tarafından cevaplandı.");
                    this.form1_0.method_27(this.string_4);
                  }
                  else
                  {
                    *(sbyte*) ((IntPtr) voidPtr + 14) = (sbyte) ((uint) this.int_2 > 0U);
                    if (*(sbyte*) ((IntPtr) voidPtr + 14) != (sbyte) 0)
                    {
                      Form1.smethod_0("Kazanan ==> [" + this.string_4 + "]");
                      Class73.smethod_161(Class25.class19_0, "Doğru cevap olan [" + this.string_3 + "], en erken  [" + this.string_4 + "] isimli karakter tarafından cevaplandı." + (object) this.int_4 + " saniye sonra yeni soru sorulacak.");
                      this.form1_0.method_27(this.string_4.ToString());
                    }
                  }
                }
                *(sbyte*) ((IntPtr) voidPtr + 15) = (sbyte) (this.int_2 > 0);
                if (*(sbyte*) ((IntPtr) voidPtr + 15) == (sbyte) 0)
                {
                  *(sbyte*) ((IntPtr) voidPtr + 16) = (sbyte) (this.int_2 <= 0);
                  if (*(sbyte*) ((IntPtr) voidPtr + 16) != (sbyte) 0)
                  {
                    Form1.form1_0.checkBox_12.Checked = false;
                    goto label_60;
                  }
                  else
                  {
                    this.sqlDataReader_0 = (SqlDataReader) null;
                    this.string_2 = (string) null;
                    this.string_3 = (string) null;
                    this.sqlDataReader_1 = (SqlDataReader) null;
                    this.string_4 = (string) null;
                    goto label_59;
                  }
                }
              }
              catch (Exception ex)
              {
                this.exception_0 = ex;
                Form1.smethod_0("[Soru Cevap] etkinliği için soru/cevap alınamadı !!. HATA => " + this.exception_0.Message);
                goto label_59;
              }
              awaiter4 = Task.Delay(this.int_4 * 1000).GetAwaiter();
              if (!awaiter4.IsCompleted)
              {
                num2 = 3;
                this.int_0 = 3;
                this.taskAwaiter_0 = awaiter4;
                Form1.Class46 stateMachine = this;
                this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class46>(ref awaiter4, ref stateMachine);
                return;
              }
              goto label_58;
label_59:
              this.form1_0.checkBox_12.Checked = false;
label_60:
              awaiter5 = Task.Delay(5000).GetAwaiter();
              if (!awaiter5.IsCompleted)
              {
                num2 = 6;
                this.int_0 = 6;
                this.taskAwaiter_0 = awaiter5;
                Form1.Class46 stateMachine = this;
                this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class46>(ref awaiter5, ref stateMachine);
                return;
              }
              goto label_64;
            case 6:
              awaiter5 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num2 = -1;
              this.int_0 = -1;
              goto label_64;
            default:
              *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (Class73.smethod_129(this.form1_0.label_13.Text) == Class19.string_0);
              if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 5) = (sbyte) (this.form1_0.label_160.Text == "ONLİNE");
                if (*(sbyte*) ((IntPtr) voidPtr + 5) == (sbyte) 0)
                {
                  *(sbyte*) ((IntPtr) voidPtr + 6) = (sbyte) (this.form1_0.label_160.Text == "OFFLİNE");
                  if (*(sbyte*) ((IntPtr) voidPtr + 6) != (sbyte) 0)
                  {
                    this.form1_0.method_2((object) this.form1_0.button_19, new EventArgs());
                    Class73.smethod_118("[Soru Cevap]", this.form1_0);
                    goto label_66;
                  }
                }
                this.string_0 = "";
                this.string_1 = "";
                if ((this.form1_0.textBox_95.Text != "" ? 1 : (this.form1_0.textBox_95.Text != "Sun Sword ( 1 Dg )" ? 1 : 0)) != 0)
                  this.string_1 = this.form1_0.textBox_95.Text ?? "";
                if ((this.form1_0.textBox_95.Text == "" ? 1 : (this.form1_0.textBox_95.Text == "Sun Sword ( 1 Dg )" ? 1 : 0)) != 0)
                {
                  this.string_1 = this.form1_0.textBox_32.Text ?? "";
                  Form1.smethod_0("[Soru Cevap] etkinliğinin İTEM ödülü için isim girilmemiş.Lütfen kontrol edin.İsim için bu seferlik itemin kodu kullanıldı!!");
                }
                if ((!this.form1_0.checkBox_11.Checked ? 0 : (!this.form1_0.checkBox_10.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Etkinlik Ödülü ==>  " + this.form1_0.textBox_31.Text + " adet [" + this.string_1 + "] +" + this.form1_0.textBox_30.Text ?? "";
                if ((!this.form1_0.checkBox_10.Checked ? 0 : (!this.form1_0.checkBox_11.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Etkinlik Ödülü ==> Silk = " + this.form1_0.textBox_35.Text + " , Gold = " + this.form1_0.textBox_33.Text + " , Sp = " + this.form1_0.textBox_34.Text;
                if ((!this.form1_0.checkBox_10.Checked ? 0 : (this.form1_0.checkBox_11.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Etkinlik Ödülü ==> " + this.form1_0.textBox_31.Text + " adet [" + this.string_1 + "] +" + this.form1_0.textBox_30.Text + ", Silk = " + this.form1_0.textBox_35.Text + " , Gold = " + this.form1_0.textBox_33.Text + " , Sp = " + this.form1_0.textBox_34.Text ?? "";
                if ((this.form1_0.checkBox_10.Checked ? 0 : (!this.form1_0.checkBox_11.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Bu ödülsüz bir etkinliktir.";
                this.int_2 = this.int_1;
                this.int_3 = (int) Convert.ToInt16(this.form1_0.textBox_29.Text);
                this.int_4 = (int) Convert.ToInt16(this.form1_0.textBox_27.Text);
                this.form1_0.checkBox_12.Checked = true;
                Class73.smethod_161(Class25.class19_0, "Merhaba.. 5 dakika sonra [Soru-Cevap] etkinliği yapılacaktır.Toplam " + (object) this.int_2 + " soru sorulacaktır.");
                awaiter1 = Task.Delay(7000).GetAwaiter();
                if (!awaiter1.IsCompleted)
                {
                  num2 = 0;
                  this.int_0 = 0;
                  this.taskAwaiter_0 = awaiter1;
                  Form1.Class46 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class46>(ref awaiter1, ref stateMachine);
                  return;
                }
                break;
              }
              Class73.smethod_27(this.form1_0);
              goto label_66;
          }
          awaiter1.GetResult();
          awaiter1 = new TaskAwaiter();
          Class73.smethod_161(Class25.class19_0, this.string_0 ?? "");
          awaiter2 = Task.Delay(300000).GetAwaiter();
          if (!awaiter2.IsCompleted)
          {
            num2 = 1;
            this.int_0 = 1;
            this.taskAwaiter_0 = awaiter2;
            Form1.Class46 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class46>(ref awaiter2, ref stateMachine);
            return;
          }
label_25:
          awaiter2.GetResult();
          awaiter2 = new TaskAwaiter();
          Class73.smethod_161(Class25.class19_0, "[Soru-Cevap] etkinliği başlamıştır.Toplam " + (object) this.int_2 + " soru sorulacaktır.Cevaplarınızı [" + this.form1_0.textEdit_18.Text + "] isimli karaktere PM atınız.Başarılar..");
          awaiter3 = Task.Delay(3000).GetAwaiter();
          if (!awaiter3.IsCompleted)
          {
            num2 = 2;
            this.int_0 = 2;
            this.taskAwaiter_0 = awaiter3;
            Form1.Class46 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class46>(ref awaiter3, ref stateMachine);
            return;
          }
label_28:
          awaiter3.GetResult();
          awaiter3 = new TaskAwaiter();
          goto label_30;
label_58:
          awaiter4.GetResult();
          awaiter4 = new TaskAwaiter();
          goto label_30;
label_64:
          awaiter5.GetResult();
          awaiter5 = new TaskAwaiter();
          this.form1_0.textBox_80.Text = "1";
          Class73.smethod_161(Class25.class19_0, "[Soru-Cevap] Etkinliği sona ermiştir.Başka etkinliklerde görüşmek üzere..");
        }
        catch (Exception ex)
        {
          this.int_0 = -2;
          this.asyncVoidMethodBuilder_0.SetException(ex);
          return;
        }
label_66:
        this.int_0 = -2;
        this.asyncVoidMethodBuilder_0.SetResult();
      }

      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }

    private sealed class Class47 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public int int_1;
      public Form1 form1_0;
      private string string_0;
      private string string_1;
      private int int_2;
      private int int_3;
      private int int_4;
      private Exception exception_0;
      private SqlDataReader sqlDataReader_0;
      private string string_2;
      private Exception exception_1;
      private Exception exception_2;
      private Exception exception_3;
      private Exception exception_4;
      private Exception exception_5;
      private TaskAwaiter taskAwaiter_0;

      unsafe void IAsyncStateMachine.MoveNext()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(15);
        int num1 = this.int_0;
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
            case 11:
            case 12:
              try
              {
                TaskAwaiter awaiter1;
                int num2;
                TaskAwaiter awaiter2;
                TaskAwaiter awaiter3;
                TaskAwaiter awaiter4;
                TaskAwaiter awaiter5;
                TaskAwaiter awaiter6;
                TaskAwaiter awaiter7;
                TaskAwaiter awaiter8;
                TaskAwaiter awaiter9;
                switch (num1)
                {
                  case 0:
                    awaiter1 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num1 = -1;
                    this.int_0 = -1;
                    break;
                  case 1:
                    awaiter2 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num1 = -1;
                    this.int_0 = -1;
                    goto label_31;
                  case 2:
                    awaiter3 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num1 = -1;
                    this.int_0 = -1;
                    goto label_73;
                  case 3:
                    awaiter4 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num1 = -1;
                    this.int_0 = -1;
                    goto label_74;
                  case 4:
                    awaiter5 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num1 = -1;
                    this.int_0 = -1;
                    goto label_75;
                  case 5:
                    awaiter6 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num1 = -1;
                    this.int_0 = -1;
                    goto label_76;
                  case 6:
                    awaiter7 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num1 = -1;
                    this.int_0 = -1;
                    goto label_78;
                  case 7:
                    awaiter8 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num1 = -1;
                    this.int_0 = -1;
                    goto label_80;
                  case 8:
                    awaiter9 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num1 = -1;
                    this.int_0 = -1;
                    goto label_85;
                  case 9:
                  case 10:
                  case 11:
                  case 12:
label_39:
                    try
                    {
                      TaskAwaiter awaiter10;
                      TaskAwaiter awaiter11;
                      TaskAwaiter awaiter12;
                      TaskAwaiter awaiter13;
                      switch (num1 - 9)
                      {
                        case 0:
                          awaiter10 = this.taskAwaiter_0;
                          this.taskAwaiter_0 = new TaskAwaiter();
                          num1 = -1;
                          this.int_0 = -1;
                          break;
                        case 1:
                          awaiter11 = this.taskAwaiter_0;
                          this.taskAwaiter_0 = new TaskAwaiter();
                          num1 = -1;
                          this.int_0 = -1;
                          goto label_46;
                        case 2:
                          awaiter12 = this.taskAwaiter_0;
                          this.taskAwaiter_0 = new TaskAwaiter();
                          num1 = -1;
                          this.int_0 = -1;
                          goto label_55;
                        case 3:
                          awaiter13 = this.taskAwaiter_0;
                          this.taskAwaiter_0 = new TaskAwaiter();
                          num1 = -1;
                          this.int_0 = -1;
                          goto label_61;
                        default:
                          this.sqlDataReader_0 = new SqlCommand("Select CharName16 from My_EventBot.._PartyListesi where Party_No=" + (object) this.form1_0.int_9 ?? "", Class65.sqlConnection_0).ExecuteReader();
                          this.sqlDataReader_0.Read();
                          this.string_2 = Convert.ToString(this.sqlDataReader_0["CharName16"]);
                          Form1.smethod_1("[Party Form] Kazanan ===> " + this.string_2 ?? "", Color.GreenYellow);
                          awaiter10 = Task.Delay(500).GetAwaiter();
                          if (!awaiter10.IsCompleted)
                          {
                            num2 = 9;
                            this.int_0 = 9;
                            this.taskAwaiter_0 = awaiter10;
                            Form1.Class47 stateMachine = this;
                            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class47>(ref awaiter10, ref stateMachine);
                            return;
                          }
                          break;
                      }
                      awaiter10.GetResult();
                      awaiter10 = new TaskAwaiter();
                      Class73.smethod_161(Class25.class19_0, "[Party Form] etkinliği kazananı [" + this.string_2 + "]. Tebrikler.!!");
                      Class73.smethod_5();
                      Class32.list_0.Clear();
                      awaiter11 = Task.Delay(3000).GetAwaiter();
                      if (!awaiter11.IsCompleted)
                      {
                        num2 = 10;
                        this.int_0 = 10;
                        this.taskAwaiter_0 = awaiter11;
                        Form1.Class47 stateMachine = this;
                        this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class47>(ref awaiter11, ref stateMachine);
                        return;
                      }
label_46:
                      awaiter11.GetResult();
                      awaiter11 = new TaskAwaiter();
                      *(int*) voidPtr = this.int_2;
                      this.int_2 = *(int*) voidPtr - 1;
                      *(sbyte*) ((IntPtr) voidPtr + 11) = (sbyte) Form1.form1_0.checkBox_14.Checked;
                      if (*(sbyte*) ((IntPtr) voidPtr + 11) != (sbyte) 0)
                      {
                        try
                        {
                          new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_2 + "',1," + Form1.form1_0.textBox_47.Text + "," + Form1.form1_0.textBox_46.Text + "," + Form1.form1_0.textBox_45.Text ?? "", Class65.sqlConnection_0).ExecuteNonQuery();
                          Form1.smethod_1("ITEM ödülü teslim edildi .", Color.DarkGreen);
                        }
                        catch (Exception ex)
                        {
                          this.exception_1 = ex;
                          Form1.smethod_1("HATA ! İtem Ödülü teslim edilemedi!!" + this.exception_1.Message, Color.OrangeRed);
                        }
                      }
                      *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) Form1.form1_0.checkBox_13.Checked;
                      if (*(sbyte*) ((IntPtr) voidPtr + 12) != (sbyte) 0)
                      {
                        try
                        {
                          new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_2 + "',2,böylekalsin," + Form1.form1_0.textBox_43.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
                          Form1.smethod_1("Silk ödülü teslim edildi .", Color.DarkGreen);
                        }
                        catch
                        {
                        }
                        awaiter12 = Task.Delay(500).GetAwaiter();
                        if (!awaiter12.IsCompleted)
                        {
                          num2 = 11;
                          this.int_0 = 11;
                          this.taskAwaiter_0 = awaiter12;
                          Form1.Class47 stateMachine = this;
                          this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class47>(ref awaiter12, ref stateMachine);
                          return;
                        }
                      }
                      else
                        goto label_64;
label_55:
                      awaiter12.GetResult();
                      awaiter12 = new TaskAwaiter();
                      try
                      {
                        new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_2 + "',3,böylekalsin," + Form1.form1_0.textBox_42.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
                        Form1.smethod_1("GOLD ödülü teslim edildi. ", Color.DarkGreen);
                      }
                      catch (Exception ex)
                      {
                        this.exception_2 = ex;
                        Form1.smethod_1("HATA ! Gold ödülü teslim edilemedi !! ==> " + this.exception_2.Message, Color.OrangeRed);
                      }
                      awaiter13 = Task.Delay(500).GetAwaiter();
                      if (!awaiter13.IsCompleted)
                      {
                        num2 = 12;
                        this.int_0 = 12;
                        this.taskAwaiter_0 = awaiter13;
                        Form1.Class47 stateMachine = this;
                        this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class47>(ref awaiter13, ref stateMachine);
                        return;
                      }
label_61:
                      awaiter13.GetResult();
                      awaiter13 = new TaskAwaiter();
                      try
                      {
                        new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_2 + "',4,böylekalsin," + Form1.form1_0.textBox_44.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
                        Form1.smethod_1("SP ödülü teslim edildi .", Color.DarkGreen);
                      }
                      catch (Exception ex)
                      {
                        this.exception_3 = ex;
                        Form1.smethod_1("HATA !Sp ödülü teslim edilemedi !! ==> " + this.exception_3.Message, Color.OrangeRed);
                      }
label_64:
                      if ((Form1.form1_0.checkBox_14.Checked ? 1 : (Form1.form1_0.checkBox_13.Checked ? 1 : 0)) != 0)
                        Class73.smethod_193(Class25.class19_0, this.string_2);
                      *(sbyte*) ((IntPtr) voidPtr + 13) = (sbyte) (this.int_2 > 0);
                      if (*(sbyte*) ((IntPtr) voidPtr + 13) == (sbyte) 0)
                      {
                        *(sbyte*) ((IntPtr) voidPtr + 14) = (sbyte) (this.int_2 <= 0);
                        if (*(sbyte*) ((IntPtr) voidPtr + 14) != (sbyte) 0)
                          this.form1_0.method_11();
                        this.sqlDataReader_0 = (SqlDataReader) null;
                        this.string_2 = (string) null;
                        goto label_97;
                      }
                      else
                        goto label_86;
                    }
                    catch (Exception ex)
                    {
                      this.exception_4 = ex;
                      if ((this.exception_4.ToString() == "Hiç veri yokken okuma girişimi geçersiz." ? 1 : (this.exception_4.ToString() == "The attempt to read is invalid when there is no data." ? 1 : 0)) != 0)
                      {
                        Form1.smethod_0("Bu turda kazanan olmadı.");
                        goto label_97;
                      }
                      else
                      {
                        Form1.smethod_0("[Party Form] etkinliği kazananı veritabanından alınırken hata oluştu. HATA ==> " + this.exception_4.Message);
                        goto label_97;
                      }
                    }
                  default:
                    this.int_3 = (int) Convert.ToInt16(this.form1_0.textBox_87.Text);
                    try
                    {
                      new SqlCommand("Delete My_EventBot.._PartyListesi", Class65.sqlConnection_0).ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                      this.exception_0 = ex;
                      Form1.smethod_0("[Party Form] etkinliği öncesi tablo temizlenemedi. HATA => " + this.exception_0.Message);
                    }
                    Class73.smethod_161(Class25.class19_0, "Merhaba..5 dakika sonra [Party Form] etkinliği yapılacaktır. Etkinlik [" + (object) this.int_2 + "] tur olacak.");
                    awaiter1 = Task.Delay(7000).GetAwaiter();
                    if (!awaiter1.IsCompleted)
                    {
                      num2 = 0;
                      this.int_0 = 0;
                      this.taskAwaiter_0 = awaiter1;
                      Form1.Class47 stateMachine = this;
                      this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class47>(ref awaiter1, ref stateMachine);
                      return;
                    }
                    break;
                }
                awaiter1.GetResult();
                awaiter1 = new TaskAwaiter();
                Class73.smethod_161(Class25.class19_0, this.string_0 ?? "");
                awaiter2 = Task.Delay(300000).GetAwaiter();
                if (!awaiter2.IsCompleted)
                {
                  num2 = 1;
                  this.int_0 = 1;
                  this.taskAwaiter_0 = awaiter2;
                  Form1.Class47 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class47>(ref awaiter2, ref stateMachine);
                  return;
                }
label_31:
                awaiter2.GetResult();
                awaiter2 = new TaskAwaiter();
                goto label_86;
label_73:
                awaiter3.GetResult();
                awaiter3 = new TaskAwaiter();
                Class32.list_0.Clear();
                awaiter4 = Task.Delay(50).GetAwaiter();
                if (!awaiter4.IsCompleted)
                {
                  num2 = 3;
                  this.int_0 = 3;
                  this.taskAwaiter_0 = awaiter4;
                  Form1.Class47 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class47>(ref awaiter4, ref stateMachine);
                  return;
                }
label_74:
                awaiter4.GetResult();
                awaiter4 = new TaskAwaiter();
                Class73.smethod_214(Class25.class19_0);
                awaiter5 = Task.Delay(1000).GetAwaiter();
                if (!awaiter5.IsCompleted)
                {
                  num2 = 4;
                  this.int_0 = 4;
                  this.taskAwaiter_0 = awaiter5;
                  Form1.Class47 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class47>(ref awaiter5, ref stateMachine);
                  return;
                }
label_75:
                awaiter5.GetResult();
                awaiter5 = new TaskAwaiter();
                this.form1_0.int_9 = Class32.list_0.Max() + (int) Convert.ToInt16(Form1.form1_0.textBox_41.Text);
                Form1.smethod_1("Aranan Party No ==> " + (object) this.form1_0.int_9 ?? "", Color.GreenYellow);
                awaiter6 = Task.Delay(3000).GetAwaiter();
                if (!awaiter6.IsCompleted)
                {
                  num2 = 5;
                  this.int_0 = 5;
                  this.taskAwaiter_0 = awaiter6;
                  Form1.Class47 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class47>(ref awaiter6, ref stateMachine);
                  return;
                }
label_76:
                awaiter6.GetResult();
                awaiter6 = new TaskAwaiter();
                Class73.smethod_161(Class25.class19_0, "[Party Form] etkinliği başlamıştır. [" + (object) this.form1_0.int_9 + "] numaralı partiyi açan ödülü kazanır. Başarılar !");
                goto label_83;
label_78:
                awaiter7.GetResult();
                awaiter7 = new TaskAwaiter();
                Class73.smethod_214(Class25.class19_0);
                *(int*) voidPtr = this.int_4;
                this.int_4 = *(int*) voidPtr + 1;
                this.form1_0.label_170.Text = string.Concat((object) this.int_4);
                *(sbyte*) ((IntPtr) voidPtr + 7) = (sbyte) (this.int_4 == this.int_3);
                if (*(sbyte*) ((IntPtr) voidPtr + 7) != (sbyte) 0)
                {
                  awaiter8 = Task.Delay(1000).GetAwaiter();
                  if (!awaiter8.IsCompleted)
                  {
                    num2 = 7;
                    this.int_0 = 7;
                    this.taskAwaiter_0 = awaiter8;
                    Form1.Class47 stateMachine = this;
                    this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class47>(ref awaiter8, ref stateMachine);
                    return;
                  }
                }
                else
                  goto label_83;
label_80:
                awaiter8.GetResult();
                awaiter8 = new TaskAwaiter();
                Class73.smethod_161(Class25.class19_0, "Belirlenen süre içinde kazanan olmadı.");
                Class32.list_0.Clear();
                Class73.smethod_5();
                *(int*) voidPtr = this.int_2;
                this.int_2 = *(int*) voidPtr - 1;
                *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) (this.int_2 > 0);
                if (*(sbyte*) ((IntPtr) voidPtr + 8) == (sbyte) 0)
                {
                  *(sbyte*) ((IntPtr) voidPtr + 9) = (sbyte) (this.int_2 <= 0);
                  if (*(sbyte*) ((IntPtr) voidPtr + 9) != (sbyte) 0)
                    this.form1_0.method_11();
                }
                else
                {
                  awaiter9 = Task.Delay(5000).GetAwaiter();
                  if (!awaiter9.IsCompleted)
                  {
                    num2 = 8;
                    this.int_0 = 8;
                    this.taskAwaiter_0 = awaiter9;
                    Form1.Class47 stateMachine = this;
                    this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class47>(ref awaiter9, ref stateMachine);
                    return;
                  }
                  goto label_85;
                }
label_83:
                if ((Class32.list_0.Contains(this.form1_0.int_9) ? 0 : (this.int_4 != this.int_3 ? 1 : 0)) != 0)
                {
                  awaiter7 = Task.Delay(1000).GetAwaiter();
                  if (!awaiter7.IsCompleted)
                  {
                    num2 = 6;
                    this.int_0 = 6;
                    this.taskAwaiter_0 = awaiter7;
                    Form1.Class47 stateMachine = this;
                    this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class47>(ref awaiter7, ref stateMachine);
                    return;
                  }
                  goto label_78;
                }
                else
                {
                  *(sbyte*) ((IntPtr) voidPtr + 10) = (sbyte) Class32.list_0.Contains(this.form1_0.int_9);
                  if (*(sbyte*) ((IntPtr) voidPtr + 10) == (sbyte) 0)
                    break;
                  goto label_39;
                }
label_85:
                awaiter9.GetResult();
                awaiter9 = new TaskAwaiter();
label_86:
                this.int_4 = 0;
                Class73.smethod_202(Class25.class19_0);
                awaiter3 = Task.Delay(1000).GetAwaiter();
                if (!awaiter3.IsCompleted)
                {
                  num2 = 2;
                  this.int_0 = 2;
                  this.taskAwaiter_0 = awaiter3;
                  Form1.Class47 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class47>(ref awaiter3, ref stateMachine);
                  return;
                }
                goto label_73;
              }
              catch (Exception ex)
              {
                this.exception_5 = ex;
                Form1.smethod_0("HATA OLUSTU ==> " + this.exception_5.Message);
                break;
              }
            default:
              *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (Class73.smethod_129(this.form1_0.label_13.Text) == this.form1_0.textBox_100.Text);
              if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 5) = (sbyte) (this.form1_0.label_160.Text == "ONLİNE");
                if (*(sbyte*) ((IntPtr) voidPtr + 5) == (sbyte) 0)
                {
                  *(sbyte*) ((IntPtr) voidPtr + 6) = (sbyte) (this.form1_0.label_160.Text == "OFFLİNE");
                  if (*(sbyte*) ((IntPtr) voidPtr + 6) != (sbyte) 0)
                  {
                    this.form1_0.method_2((object) this.form1_0.button_19, new EventArgs());
                    Class73.smethod_118("[Party Form]", this.form1_0);
                    break;
                  }
                }
                this.string_0 = "";
                this.string_1 = "";
                if ((this.form1_0.textBox_96.Text != "" ? 1 : (this.form1_0.textBox_96.Text != "Sun Sword ( 1 Dg )" ? 1 : 0)) != 0)
                  this.string_1 = this.form1_0.textBox_96.Text ?? "";
                if ((this.form1_0.textBox_96.Text == "" ? 1 : (this.form1_0.textBox_96.Text == "Sun Sword ( 1 Dg )" ? 1 : 0)) != 0)
                {
                  this.string_1 = this.form1_0.textBox_47.Text ?? "";
                  Form1.smethod_0("[Party Form] etkinliğinin İTEM ödülü için isim girilmemiş.Lütfen kontrol edin.İsim için bu seferlik itemin kodu kullanıldı!!");
                }
                if ((!this.form1_0.checkBox_14.Checked ? 0 : (!this.form1_0.checkBox_13.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Etkinlik Ödülü ==>  " + this.form1_0.textBox_46.Text + " adet [" + this.string_1 + "] +" + this.form1_0.textBox_45.Text ?? "";
                if ((!this.form1_0.checkBox_13.Checked ? 0 : (!this.form1_0.checkBox_14.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Etkinlik Ödülü ==> Silk = " + this.form1_0.textBox_43.Text + " , Gold = " + this.form1_0.textBox_42.Text + " , Sp = " + this.form1_0.textBox_44.Text;
                if ((!this.form1_0.checkBox_13.Checked ? 0 : (this.form1_0.checkBox_14.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Etkinlik Ödülü ==>  " + this.form1_0.textBox_46.Text + " adet [" + this.string_1 + "] +" + this.form1_0.textBox_45.Text + " , Silk = " + this.form1_0.textBox_43.Text + " , Gold = " + this.form1_0.textBox_42.Text + " , Sp = " + this.form1_0.textBox_44.Text ?? "";
                if ((this.form1_0.checkBox_13.Checked ? 0 : (!this.form1_0.checkBox_14.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Bu ödülsüz bir etkinliktir.";
                this.int_2 = this.int_1;
                goto case 0;
              }
              else
              {
                Class73.smethod_27(this.form1_0);
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
label_97:
        this.int_0 = -2;
        this.asyncVoidMethodBuilder_0.SetResult();
      }

      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }

    private sealed class Class48 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public Form1 form1_0;
      private Exception exception_0;
      private TaskAwaiter taskAwaiter_0;

      void IAsyncStateMachine.MoveNext()
      {
        int int0 = this.int_0;
        try
        {
          TaskAwaiter awaiter;
          int num;
          if (int0 != 0)
          {
            Class73.smethod_161(Class25.class19_0, "[Party Form] etkinliği sona ermiştir.Bir dahaki etkinlikte görüşmek üzere.");
            awaiter = Task.Delay(1000).GetAwaiter();
            if (!awaiter.IsCompleted)
            {
              num = 0;
              this.int_0 = 0;
              this.taskAwaiter_0 = awaiter;
              Form1.Class48 stateMachine = this;
              this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class48>(ref awaiter, ref stateMachine);
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
          this.form1_0.label_170.Text = "";
          try
          {
            Class32.list_0.Clear();
            new SqlCommand("Delete My_EventBot.._PartyListesi", Class65.sqlConnection_0).ExecuteNonQuery();
            Form1.smethod_0("[Party Form] etkinliği sonrası temizlik başarıyla yapıldı.");
          }
          catch (Exception ex)
          {
            this.exception_0 = ex;
            Form1.smethod_0("[Party Form] etkinliği sonrası temizlik yapılırken bir hata oluştu ==> " + this.exception_0.Message);
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

    private sealed class Class49 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public Form1 form1_0;
      private string string_0;
      private string string_1;
      private int int_1;
      private double double_0;
      private double double_1;
      private List<string>.Enumerator enumerator_0;
      private string string_2;
      private TaskAwaiter taskAwaiter_0;

      unsafe void IAsyncStateMachine.MoveNext()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(6);
        int num1 = this.int_0;
        try
        {
          TaskAwaiter awaiter1;
          int num2;
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
              awaiter1 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              break;
            case 1:
              awaiter2 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_25;
            case 2:
              awaiter3 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_28;
            case 3:
              awaiter4 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_31;
            case 4:
              awaiter5 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_37;
            case 5:
              awaiter6 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_40;
            case 6:
            case 7:
label_41:
              try
              {
                TaskAwaiter awaiter9;
                TaskAwaiter awaiter10;
                switch (num1)
                {
                  case 6:
                    awaiter10 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num1 = -1;
                    this.int_0 = -1;
                    break;
                  case 7:
                    awaiter9 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num1 = -1;
                    this.int_0 = -1;
                    goto label_46;
                  default:
label_47:
                    if (this.enumerator_0.MoveNext())
                    {
                      this.string_2 = this.enumerator_0.Current;
                      try
                      {
                        new SqlCommand("Exec My_EventBot..__Hayatta_Kal " + this.string_2 + ",'PKEKLE'", Class65.sqlConnection_0).ExecuteReader();
                      }
                      catch
                      {
                        Form1.smethod_0("[Hayatta Kal] etkinliğinde [" + this.string_2 + "] isimli karaktere PK eklenirken hata oluştu.");
                      }
                      awaiter10 = Task.Delay(50).GetAwaiter();
                      if (!awaiter10.IsCompleted)
                      {
                        num1 = 6;
                        this.int_0 = 6;
                        this.taskAwaiter_0 = awaiter10;
                        Form1.Class49 stateMachine = this;
                        this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class49>(ref awaiter10, ref stateMachine);
                        return;
                      }
                      break;
                    }
                    goto label_57;
                }
                awaiter10.GetResult();
                awaiter10 = new TaskAwaiter();
                Class73.smethod_193(Class25.class19_0, this.string_2);
                awaiter9 = Task.Delay(50).GetAwaiter();
                if (!awaiter9.IsCompleted)
                {
                  num1 = 7;
                  this.int_0 = 7;
                  this.taskAwaiter_0 = awaiter9;
                  Form1.Class49 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class49>(ref awaiter9, ref stateMachine);
                  return;
                }
label_46:
                awaiter9.GetResult();
                awaiter9 = new TaskAwaiter();
                Form1.list_0.Remove(this.string_2);
                this.form1_0.listBox_13.Items.Add((object) this.string_2);
                this.string_2 = (string) null;
                goto label_47;
              }
              finally
              {
                if (num1 < 0)
                  this.enumerator_0.Dispose();
              }
label_57:
              this.enumerator_0 = new List<string>.Enumerator();
              *(sbyte*) ((IntPtr) voidPtr + 5) = (sbyte) (Form1.list_0.Count == 0);
              if (*(sbyte*) ((IntPtr) voidPtr + 5) != (sbyte) 0)
              {
                Class73.smethod_206(Class25.class19_0);
                awaiter7 = Task.Delay(500).GetAwaiter();
                if (!awaiter7.IsCompleted)
                {
                  num2 = 8;
                  this.int_0 = 8;
                  this.taskAwaiter_0 = awaiter7;
                  Form1.Class49 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class49>(ref awaiter7, ref stateMachine);
                  return;
                }
                goto label_61;
              }
              else
                goto label_69;
            case 8:
              awaiter7 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num2 = -1;
              this.int_0 = -1;
              goto label_61;
            case 9:
              awaiter8 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num2 = -1;
              this.int_0 = -1;
              goto label_64;
            default:
              *(sbyte*) voidPtr = (sbyte) (Class73.smethod_129(this.form1_0.label_13.Text) == this.form1_0.textBox_100.Text);
              if (*(sbyte*) voidPtr != (sbyte) 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (this.form1_0.label_160.Text == "ONLİNE");
                if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
                {
                  *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) (this.form1_0.label_160.Text == "OFFLİNE");
                  if (*(sbyte*) ((IntPtr) voidPtr + 2) != (sbyte) 0)
                  {
                    this.form1_0.method_2((object) this.form1_0.button_19, new EventArgs());
                    Class73.smethod_118("[Hayatta Kal]", this.form1_0);
                    goto label_69;
                  }
                }
                this.string_0 = "";
                this.string_1 = "";
                if ((this.form1_0.textBox_98.Text != "" ? 1 : (this.form1_0.textBox_98.Text != "Sun Sword ( 1 Dg )" ? 1 : 0)) != 0)
                  this.string_1 = this.form1_0.textBox_98.Text ?? "";
                if ((this.form1_0.textBox_98.Text == "" ? 1 : (this.form1_0.textBox_98.Text == "Sun Sword ( 1 Dg )" ? 1 : 0)) != 0)
                {
                  this.string_1 = this.form1_0.textBox_20.Text ?? "";
                  Form1.smethod_0("[Hayatta Kal] etkinliğinin İTEM ödülü için isim girilmemiş.Lütfen kontrol edin.İsim için bu seferlik itemin kodu kullanıldı!!");
                }
                if ((!this.form1_0.checkBox_7.Checked ? 0 : (!this.form1_0.checkBox_6.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Etkinlik Ödülü ==>  " + this.form1_0.textBox_19.Text + " adet [" + this.string_1 + "] +" + this.form1_0.textBox_18.Text ?? "";
                if ((!this.form1_0.checkBox_6.Checked ? 0 : (!this.form1_0.checkBox_7.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Etkinlik Ödülü ==> Silk = " + this.form1_0.textBox_23.Text + " , Gold = " + this.form1_0.textBox_21.Text + " , Sp = " + this.form1_0.textBox_22.Text;
                if ((!this.form1_0.checkBox_6.Checked ? 0 : (this.form1_0.checkBox_7.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Etkinlik Ödülü ==> " + this.form1_0.textBox_19.Text + " adet [" + this.string_1 + "] +" + this.form1_0.textBox_18.Text + ", Silk = " + this.form1_0.textBox_23.Text + " , Gold = " + this.form1_0.textBox_21.Text + " , Sp = " + this.form1_0.textBox_22.Text ?? "";
                if ((this.form1_0.checkBox_6.Checked ? 0 : (!this.form1_0.checkBox_7.Checked ? 1 : 0)) != 0)
                  this.string_0 = "Bu ödülsüz bir etkinliktir.";
                this.int_1 = (int) Convert.ToInt16(this.form1_0.textBox_78.Text);
                this.form1_0.checkBox_21.Checked = true;
                Class73.smethod_161(Class25.class19_0, "Merhaba.. 5 dakika sonra [Hayatta Kal] etkinliği yapılacaktır.Etkinliğe " + Form1.form1_0.textBox_83.Text + " Lvl ve üzeri herkes katılabilir.");
                awaiter1 = Task.Delay(7000).GetAwaiter();
                if (!awaiter1.IsCompleted)
                {
                  num2 = 0;
                  this.int_0 = 0;
                  this.taskAwaiter_0 = awaiter1;
                  Form1.Class49 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class49>(ref awaiter1, ref stateMachine);
                  return;
                }
                break;
              }
              Class73.smethod_27(this.form1_0);
              goto label_69;
          }
          awaiter1.GetResult();
          awaiter1 = new TaskAwaiter();
          Class73.smethod_161(Class25.class19_0, this.string_0 ?? "");
          awaiter2 = Task.Delay(7000).GetAwaiter();
          if (!awaiter2.IsCompleted)
          {
            num2 = 1;
            this.int_0 = 1;
            this.taskAwaiter_0 = awaiter2;
            Form1.Class49 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class49>(ref awaiter2, ref stateMachine);
            return;
          }
label_25:
          awaiter2.GetResult();
          awaiter2 = new TaskAwaiter();
          this.form1_0.timer_12.Start();
          Class73.smethod_161(Class25.class19_0, "[Hayatta Kal] etkinliğine kayıt başladı.Kayıt 4 dakika sürecektir.Kayıt olmak için [" + this.form1_0.textEdit_18.Text + "] isimli karaktere 'KAYIT' yazınız.");
          this.form1_0.bool_0 = true;
          awaiter3 = Task.Delay(120000).GetAwaiter();
          if (!awaiter3.IsCompleted)
          {
            num2 = 2;
            this.int_0 = 2;
            this.taskAwaiter_0 = awaiter3;
            Form1.Class49 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class49>(ref awaiter3, ref stateMachine);
            return;
          }
label_28:
          awaiter3.GetResult();
          awaiter3 = new TaskAwaiter();
          Class73.smethod_161(Class25.class19_0, "[Hayatta Kal] etkinliği kayıtları devam etmektedir.Son 2 dakika.Kayıt olmak için [" + this.form1_0.textEdit_18.Text + "] isimli karaktere 'KAYIT' yazınız.");
          awaiter4 = Task.Delay(120000).GetAwaiter();
          if (!awaiter4.IsCompleted)
          {
            num2 = 3;
            this.int_0 = 3;
            this.taskAwaiter_0 = awaiter4;
            Form1.Class49 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class49>(ref awaiter4, ref stateMachine);
            return;
          }
label_31:
          awaiter4.GetResult();
          awaiter4 = new TaskAwaiter();
          this.form1_0.bool_0 = false;
          *(sbyte*) ((IntPtr) voidPtr + 3) = (sbyte) (this.form1_0.listBox_14.Items.Count < this.int_1);
          if (*(sbyte*) ((IntPtr) voidPtr + 3) != (sbyte) 0)
          {
            Class73.smethod_161(Class25.class19_0, "[Hayatta Kal] etkinliği kayıt işlemi sonra erdi.Yeterli katılım sağlanmadığından etkinlik iptal edilmiştir..");
            Form1.list_0.Clear();
            this.form1_0.listBox_13.Items.Clear();
            this.form1_0.listBox_14.Items.Clear();
            this.form1_0.checkBox_21.Checked = false;
            this.form1_0.bool_0 = false;
            Class73.smethod_206(Class25.class19_0);
          }
          *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (this.form1_0.listBox_14.Items.Count >= this.int_1);
          if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
          {
            Class73.smethod_161(Class25.class19_0, "[Hayatta Kal] etkinliği kayıt işlemi sona erdi.Etkinlik 1 dakika sonra başlayacak.");
            awaiter5 = Task.Delay(60000).GetAwaiter();
            if (!awaiter5.IsCompleted)
            {
              num2 = 4;
              this.int_0 = 4;
              this.taskAwaiter_0 = awaiter5;
              Form1.Class49 stateMachine = this;
              this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class49>(ref awaiter5, ref stateMachine);
              return;
            }
          }
          else
            goto label_69;
label_37:
          awaiter5.GetResult();
          awaiter5 = new TaskAwaiter();
          Class73.smethod_161(Class25.class19_0, "[Hayatta Kal] etkinliği başladı.Başarılar...");
          this.double_0 = Convert.ToDouble(Form1.form1_0.textBox_82.Text);
          this.double_1 = Convert.ToDouble(Form1.form1_0.textBox_81.Text);
          Class73.smethod_83(Class25.class19_0, this.double_0, this.double_1);
          awaiter6 = Task.Delay(1000).GetAwaiter();
          if (!awaiter6.IsCompleted)
          {
            num2 = 5;
            this.int_0 = 5;
            this.taskAwaiter_0 = awaiter6;
            Form1.Class49 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class49>(ref awaiter6, ref stateMachine);
            return;
          }
label_40:
          awaiter6.GetResult();
          awaiter6 = new TaskAwaiter();
          this.enumerator_0 = Form1.list_0.ToList<string>().GetEnumerator();
          goto label_41;
label_61:
          awaiter7.GetResult();
          awaiter7 = new TaskAwaiter();
          Form1.smethod_0("Tüm katılımcılar etkinlik alanına alındı.");
          awaiter8 = Task.Delay(1000).GetAwaiter();
          if (!awaiter8.IsCompleted)
          {
            num2 = 9;
            this.int_0 = 9;
            this.taskAwaiter_0 = awaiter8;
            Form1.Class49 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class49>(ref awaiter8, ref stateMachine);
            return;
          }
label_64:
          awaiter8.GetResult();
          awaiter8 = new TaskAwaiter();
          try
          {
            new SqlCommand("update My_EventBot.._HayattaKal_List set Durum='ICERDE'", Class65.sqlConnection_0).ExecuteReader();
          }
          catch
          {
            Form1.smethod_0("[Hayatta Kal] etkinliği akışında bir hata oluştu. Hata Kodu #HK0052.");
          }
          Form1.form1_0.bool_0 = false;
          Form1.form1_0.checkBox_21.Checked = false;
          this.form1_0.timer_2.Start();
        }
        catch (Exception ex)
        {
          this.int_0 = -2;
          this.asyncVoidMethodBuilder_0.SetException(ex);
          return;
        }
label_69:
        this.int_0 = -2;
        this.asyncVoidMethodBuilder_0.SetResult();
      }

      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }

    private sealed class Class50 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public string string_0;
      private Exception exception_0;
      private Exception exception_1;
      private Exception exception_2;
      private Exception exception_3;
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
              goto label_17;
            default:
              *(sbyte*) voidPtr = (sbyte) Form1.form1_0.checkBox_20.Checked;
              if (*(sbyte*) voidPtr != (sbyte) 0)
              {
                try
                {
                  new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_0 + "',1," + Form1.form1_0.textBox_75.Text + "," + Form1.form1_0.textBox_74.Text + "," + Form1.form1_0.textBox_73.Text ?? "", Class65.sqlConnection_0).ExecuteNonQuery();
                  Form1.smethod_1("ITEM ödülü teslim Edildi .", Color.DarkGreen);
                }
                catch (Exception ex)
                {
                  this.exception_0 = ex;
                  Form1.smethod_1("HATA ! İtem Ödülü teslim edilemedi!!" + this.exception_0.Message, Color.OrangeRed);
                }
              }
              *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) Form1.form1_0.checkBox_19.Checked;
              if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
              {
                try
                {
                  new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_0 + "',2,böylekalsin," + Form1.form1_0.textBox_71.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
                  Form1.smethod_1("Silk ödülü teslim edildi .", Color.DarkGreen);
                }
                catch (Exception ex)
                {
                  this.exception_1 = ex;
                  Form1.smethod_1("Silk ödülü teslim edilemedi!! ==> " + this.exception_1.Message, Color.DarkGreen);
                }
                awaiter1 = Task.Delay(500).GetAwaiter();
                if (!awaiter1.IsCompleted)
                {
                  num = 0;
                  this.int_0 = 0;
                  this.taskAwaiter_0 = awaiter1;
                  Form1.Class50 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class50>(ref awaiter1, ref stateMachine);
                  return;
                }
                break;
              }
              goto label_20;
          }
          awaiter1.GetResult();
          awaiter1 = new TaskAwaiter();
          try
          {
            new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_0 + "',3,böylekalsin," + Form1.form1_0.textBox_70.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
            Form1.smethod_1("GOLD ödülü teslim Edildi. ", Color.DarkGreen);
          }
          catch (Exception ex)
          {
            this.exception_2 = ex;
            Form1.smethod_1("HATA ! GOLD ödülü teslim edilemedi !! ==> " + this.exception_2.Message, Color.OrangeRed);
          }
          awaiter2 = Task.Delay(500).GetAwaiter();
          if (!awaiter2.IsCompleted)
          {
            num = 1;
            this.int_0 = 1;
            this.taskAwaiter_0 = awaiter2;
            Form1.Class50 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class50>(ref awaiter2, ref stateMachine);
            return;
          }
label_17:
          awaiter2.GetResult();
          awaiter2 = new TaskAwaiter();
          try
          {
            new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_0 + "',4,böylekalsin," + Form1.form1_0.textBox_72.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
            Form1.smethod_1("SP ödülü teslim Edildi .", Color.DarkGreen);
          }
          catch (Exception ex)
          {
            this.exception_3 = ex;
            Form1.smethod_1("HATA !Sp ödülü teslim edilemedi !! ==> " + this.exception_3.Message, Color.OrangeRed);
          }
label_20:
          if ((Form1.form1_0.checkBox_20.Checked ? 1 : (Form1.form1_0.checkBox_19.Checked ? 1 : 0)) != 0)
            Class73.smethod_193(Class25.class19_0, this.string_0);
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

    private sealed class Class51 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public string string_0;
      public Form1 form1_0;
      private int int_1;
      private Random random_0;
      private string string_1;
      private int int_2;
      private int int_3;
      private Random random_1;
      private TaskAwaiter taskAwaiter_0;

      unsafe void IAsyncStateMachine.MoveNext()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(10);
        int int0 = this.int_0;
        try
        {
          TaskAwaiter awaiter;
          int num;
          if (int0 != 0)
          {
            this.form1_0.listBox_18.Items.Clear();
            this.form1_0.listBox_1.Items.Clear();
            this.form1_0.listBox_0.Items.Clear();
            string string0 = this.string_0;
            if (!(string0 == "Jangan"))
            {
              if (!(string0 == "Donwhang"))
              {
                if (!(string0 == "Hotan"))
                {
                  if (!(string0 == "Samarkand"))
                  {
                    if (!(string0 == "Constantine"))
                    {
                      if (string0 == "Alexandria")
                      {
                        this.form1_0.listBox_18.Items.Add((object) "Alexandria [Red Hamada/Red Leg/Red Eggre] çevresi");
                        this.form1_0.listBox_18.Items.Add((object) "Alexandria [Mushroom r.a / Salt Post/Salt Desert] çevresi");
                        this.form1_0.listBox_18.Items.Add((object) "Alexandria [Black Hamada/Black Leg/Black Eggre] çevresi");
                        this.form1_0.listBox_18.Items.Add((object) "Alexandria [Chaos Maze]");
                        this.form1_0.listBox_18.Items.Add((object) "Alexandria [Şehir Çevresi]");
                      }
                    }
                    else
                    {
                      this.form1_0.listBox_18.Items.Add((object) "Constantine [Traveler's Hills/Bloody Hill/Golden Plain] çevresi");
                      this.form1_0.listBox_18.Items.Add((object) "Constantine [Forest of Sorrow] çevresi");
                      this.form1_0.listBox_18.Items.Add((object) "Constantine [Desperado Hill/Forest of Dusk/Garden of Gods] çevresi");
                    }
                  }
                  else
                  {
                    this.form1_0.listBox_18.Items.Add((object) "Samarkand [Huns Garrison/Ong Habitat] çevresi");
                    this.form1_0.listBox_18.Items.Add((object) "Samarkand [Ampitheater/Asia Minor/Anatolian Plateau] çevresi");
                    this.form1_0.listBox_18.Items.Add((object) "Samarkand [Cleopatras's Gate/Haran's Tower/Ewil Order Fortress] çevresi");
                  }
                }
                else
                {
                  this.form1_0.listBox_18.Items.Add((object) "Hotan [Grassland Road] çevresi");
                  this.form1_0.listBox_18.Items.Add((object) "Hotan [Niya Remains] çevresi");
                  this.form1_0.listBox_18.Items.Add((object) "Hotan [Taklamakan] çevresi");
                  this.form1_0.listBox_18.Items.Add((object) "Hotan [Mysterious Death Desert] çevresi");
                  this.form1_0.listBox_18.Items.Add((object) "Hotan [Karakoram] İçeri");
                  this.form1_0.listBox_18.Items.Add((object) "Hotan [Karakoram] Dışarı");
                }
              }
              else
              {
                this.form1_0.listBox_18.Items.Add((object) "Downhang [Eart Ghost Canyon] çevresi");
                this.form1_0.listBox_18.Items.Add((object) "Downhang [Grassland Road/Hyungno Homeland] çevresi");
                this.form1_0.listBox_18.Items.Add((object) "Downhang [Tarim Basin] çevresi");
              }
            }
            else
            {
              this.form1_0.listBox_18.Items.Add((object) "Jangan [Grassland/Tomb/Cave] çevresi");
              this.form1_0.listBox_18.Items.Add((object) "Jangan [Tiger-Bandit Montain/West-East Ferry] çevresi");
            }
            this.random_0 = new Random();
            this.int_1 = this.random_0.Next(this.form1_0.listBox_18.Items.Count);
            Form1.string_20 = this.form1_0.listBox_18.Items[this.int_1].ToString();
            this.form1_0.textBox_99.Text = Form1.string_20;
            awaiter = Task.Delay(1000).GetAwaiter();
            if (!awaiter.IsCompleted)
            {
              num = 0;
              this.int_0 = 0;
              this.taskAwaiter_0 = awaiter;
              Form1.Class51 stateMachine = this;
              this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class51>(ref awaiter, ref stateMachine);
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
          string string20 = Form1.string_20;
          *(int*) voidPtr = (int) Class73.smethod_117(string20);
          if (*(uint*) voidPtr <= 1853796092U)
          {
            if (*(uint*) voidPtr <= 509909794U)
            {
              if (*(uint*) voidPtr <= 221043237U)
              {
                if (*(uint*) voidPtr != 148527851U)
                {
                  if (*(uint*) voidPtr == 221043237U && string20 == "Jangan [Tiger-Bandit Montain/West-East Ferry] çevresi")
                  {
                    this.form1_0.listBox_1.Items.Add((object) "4457/911");
                    this.form1_0.listBox_1.Items.Add((object) "4417/599");
                    this.form1_0.listBox_1.Items.Add((object) "4220/209");
                    this.form1_0.listBox_1.Items.Add((object) "4342/13");
                    this.form1_0.listBox_1.Items.Add((object) "4893/-286");
                    this.form1_0.listBox_1.Items.Add((object) "5355/-221");
                    this.form1_0.listBox_1.Items.Add((object) "5025/-27");
                    this.form1_0.listBox_1.Items.Add((object) "5117/425");
                    this.form1_0.listBox_1.Items.Add((object) "4768/446");
                    this.form1_0.listBox_1.Items.Add((object) "5034/1115");
                    this.form1_0.listBox_1.Items.Add((object) "5082/613");
                  }
                }
                else if (string20 == "Samarkand [Cleopatras's Gate/Haran's Tower/Ewil Order Fortress] çevresi")
                {
                  this.form1_0.listBox_1.Items.Add((object) "-7100/1536");
                  this.form1_0.listBox_1.Items.Add((object) "-6787/1130");
                  this.form1_0.listBox_1.Items.Add((object) "-6935/1838");
                  this.form1_0.listBox_1.Items.Add((object) "-6415/1252");
                  this.form1_0.listBox_1.Items.Add((object) "-6650/1500");
                  this.form1_0.listBox_1.Items.Add((object) "-7472/1332");
                  this.form1_0.listBox_1.Items.Add((object) "-7657/1198");
                  this.form1_0.listBox_1.Items.Add((object) "-7773/1517");
                }
              }
              else if (*(uint*) voidPtr != 234214020U)
              {
                if (*(uint*) voidPtr != 346500889U)
                {
                  if (*(uint*) voidPtr == 509909794U && string20 == "Constantine [Forest of Sorrow] çevresi")
                  {
                    this.form1_0.listBox_1.Items.Add((object) "-11842/2646");
                    this.form1_0.listBox_1.Items.Add((object) "-11866/2506");
                    this.form1_0.listBox_1.Items.Add((object) "-12107/2486");
                    this.form1_0.listBox_1.Items.Add((object) "-12232/2695");
                    this.form1_0.listBox_1.Items.Add((object) "-12575/2254");
                    this.form1_0.listBox_1.Items.Add((object) "-12572/2697");
                    this.form1_0.listBox_1.Items.Add((object) "-12496/3231");
                    this.form1_0.listBox_1.Items.Add((object) "-12375/3063");
                  }
                }
                else if (string20 == "Alexandria [Şehir Çevresi]")
                {
                  this.form1_0.listBox_1.Items.Add((object) "-16027/-882");
                  this.form1_0.listBox_1.Items.Add((object) "-15981/-654");
                  this.form1_0.listBox_1.Items.Add((object) "-15583/-575");
                  this.form1_0.listBox_1.Items.Add((object) "-15795/-442");
                  this.form1_0.listBox_1.Items.Add((object) "-15725/-105");
                  this.form1_0.listBox_1.Items.Add((object) "-15925/-73");
                  this.form1_0.listBox_1.Items.Add((object) "-16170/-266");
                  this.form1_0.listBox_1.Items.Add((object) "-16217/-402");
                }
              }
              else if (string20 == "Hotan [Niya Remains] çevresi")
              {
                this.form1_0.listBox_1.Items.Add((object) "-1056/2355");
                this.form1_0.listBox_1.Items.Add((object) "-1214/2540");
                this.form1_0.listBox_1.Items.Add((object) "-1560/2548");
                this.form1_0.listBox_1.Items.Add((object) "-1069/1983");
                this.form1_0.listBox_1.Items.Add((object) "-1688/1971");
                this.form1_0.listBox_1.Items.Add((object) "-1665/2133");
                this.form1_0.listBox_1.Items.Add((object) "-1088/2003");
                this.form1_0.listBox_1.Items.Add((object) "-953/2142");
              }
            }
            else if (*(uint*) voidPtr <= 752190473U)
            {
              if (*(uint*) voidPtr != 513610739U)
              {
                if (*(uint*) voidPtr != 569688608U)
                {
                  if (*(uint*) voidPtr == 752190473U && string20 == "Alexandria [Mushroom r.a / Salt Post/Salt Desert] çevresi")
                  {
                    this.form1_0.listBox_1.Items.Add((object) "-13364/-1526");
                    this.form1_0.listBox_1.Items.Add((object) "-13053/-1359");
                    this.form1_0.listBox_1.Items.Add((object) "-12970/-1534");
                    this.form1_0.listBox_1.Items.Add((object) "-12679/-1421");
                    this.form1_0.listBox_1.Items.Add((object) "-12699/-1195");
                    this.form1_0.listBox_1.Items.Add((object) "-12360/-1257");
                    this.form1_0.listBox_1.Items.Add((object) "-11993/-1524");
                    this.form1_0.listBox_1.Items.Add((object) "-12054/-1219");
                    this.form1_0.listBox_1.Items.Add((object) "-11516/-1201");
                    this.form1_0.listBox_1.Items.Add((object) "-11658/-1525");
                  }
                }
                else if (string20 == "Downhang [Tarim Basin] çevresi")
                {
                  this.form1_0.listBox_1.Items.Add((object) "2504/-27");
                  this.form1_0.listBox_1.Items.Add((object) "2395/156");
                  this.form1_0.listBox_1.Items.Add((object) "2787/55");
                  this.form1_0.listBox_1.Items.Add((object) "2593/-195");
                  this.form1_0.listBox_1.Items.Add((object) "2851/1");
                  this.form1_0.listBox_1.Items.Add((object) "2590/196");
                  this.form1_0.listBox_1.Items.Add((object) "2374/1");
                  this.form1_0.listBox_1.Items.Add((object) "2117/431");
                  this.form1_0.listBox_1.Items.Add((object) "2615/826");
                  this.form1_0.listBox_1.Items.Add((object) "2376/679");
                }
              }
              else if (string20 == "Jangan [Grassland/Tomb/Cave] çevresi")
              {
                this.form1_0.listBox_1.Items.Add((object) "6702/837");
                this.form1_0.listBox_1.Items.Add((object) "6101/804");
                this.form1_0.listBox_1.Items.Add((object) "5930/576");
                this.form1_0.listBox_1.Items.Add((object) "6235/429");
                this.form1_0.listBox_1.Items.Add((object) "7203/295");
                this.form1_0.listBox_1.Items.Add((object) "7399/98");
                this.form1_0.listBox_1.Items.Add((object) "7195/1150");
                this.form1_0.listBox_1.Items.Add((object) "7105/1714");
                this.form1_0.listBox_1.Items.Add((object) "7288/1759");
                this.form1_0.listBox_1.Items.Add((object) "7243/1979");
                this.form1_0.listBox_1.Items.Add((object) "7153/1979");
              }
            }
            else if (*(uint*) voidPtr != 1086532783U)
            {
              if (*(uint*) voidPtr != 1387105384U)
              {
                if (*(uint*) voidPtr == 1853796092U && string20 == "Constantine [Traveler's Hills/Bloody Hill/Golden Plain] çevresi")
                {
                  this.form1_0.listBox_1.Items.Add((object) "-11642/3422");
                  this.form1_0.listBox_1.Items.Add((object) "-11269/3391");
                  this.form1_0.listBox_1.Items.Add((object) "-10790/3342");
                  this.form1_0.listBox_1.Items.Add((object) "-10383/3286");
                  this.form1_0.listBox_1.Items.Add((object) "-11166/3094");
                  this.form1_0.listBox_1.Items.Add((object) "-11385/2834");
                  this.form1_0.listBox_1.Items.Add((object) "-11181/2330");
                  this.form1_0.listBox_1.Items.Add((object) "-11453/2385");
                  this.form1_0.listBox_1.Items.Add((object) "-11526/2737");
                }
              }
              else if (string20 == "Constantine [Desperado Hill/Forest of Dusk/Garden of Gods] çevresi")
              {
                this.form1_0.listBox_1.Items.Add((object) "-11422/2086");
                this.form1_0.listBox_1.Items.Add((object) "-11209/1844");
                this.form1_0.listBox_1.Items.Add((object) "-11710/1654");
                this.form1_0.listBox_1.Items.Add((object) "-12000/1247");
                this.form1_0.listBox_1.Items.Add((object) "-12379/1267");
                this.form1_0.listBox_1.Items.Add((object) "-12444/1561");
                this.form1_0.listBox_1.Items.Add((object) "-12572/1990");
                this.form1_0.listBox_1.Items.Add((object) "-12095/2044");
                this.form1_0.listBox_1.Items.Add((object) "-12094/2384");
              }
            }
            else if (string20 == "Hotan [Karakoram] İçeri")
            {
              this.form1_0.listBox_1.Items.Add((object) "-1884/-446");
              this.form1_0.listBox_1.Items.Add((object) "-1797/4");
              this.form1_0.listBox_1.Items.Add((object) "-1337/118");
              this.form1_0.listBox_1.Items.Add((object) "-982/-522");
              this.form1_0.listBox_1.Items.Add((object) "-1185/-728");
              this.form1_0.listBox_1.Items.Add((object) "-1620/-716");
              this.form1_0.listBox_1.Items.Add((object) "-1644/-470");
              this.form1_0.listBox_1.Items.Add((object) "-1347/-330");
              this.form1_0.listBox_1.Items.Add((object) "-1362/-211");
              this.form1_0.listBox_1.Items.Add((object) "-1390/30");
            }
          }
          else if (*(uint*) voidPtr <= 2806391371U)
          {
            if (*(uint*) voidPtr <= 2464011180U)
            {
              if (*(uint*) voidPtr != 2358778907U)
              {
                if (*(uint*) voidPtr == 2464011180U && string20 == "Hotan [Karakoram] Dışarı")
                {
                  this.form1_0.listBox_1.Items.Add((object) "-1933/-780");
                  this.form1_0.listBox_1.Items.Add((object) "-2551/-1074");
                  this.form1_0.listBox_1.Items.Add((object) "-2585/327");
                  this.form1_0.listBox_1.Items.Add((object) "-1489/793");
                  this.form1_0.listBox_1.Items.Add((object) "-1457/286");
                  this.form1_0.listBox_1.Items.Add((object) "-806/510");
                  this.form1_0.listBox_1.Items.Add((object) "-898/-379");
                  this.form1_0.listBox_1.Items.Add((object) "-642/-571");
                  this.form1_0.listBox_1.Items.Add((object) "-890/-1206");
                  this.form1_0.listBox_1.Items.Add((object) "-1302/-1053");
                }
              }
              else if (string20 == "Alexandria [Chaos Maze]")
              {
                this.form1_0.listBox_1.Items.Add((object) "-12777/-3256");
                this.form1_0.listBox_1.Items.Add((object) "-12512/-3112");
                this.form1_0.listBox_1.Items.Add((object) "-12241/-2994");
                this.form1_0.listBox_1.Items.Add((object) "-12526/-3364");
                this.form1_0.listBox_1.Items.Add((object) "-12535/-3493");
                this.form1_0.listBox_1.Items.Add((object) "-12455/-3617");
                this.form1_0.listBox_1.Items.Add((object) "-12876/-3608");
                this.form1_0.listBox_1.Items.Add((object) "-12146/-3636");
              }
            }
            else if (*(uint*) voidPtr != 2543520512U)
            {
              if (*(uint*) voidPtr != 2694699419U)
              {
                if (*(uint*) voidPtr == 2806391371U && string20 == "Hotan [Grassland Road] çevresi")
                {
                  this.form1_0.listBox_1.Items.Add((object) "470/788");
                  this.form1_0.listBox_1.Items.Add((object) "569/516");
                  this.form1_0.listBox_1.Items.Add((object) "657/274");
                  this.form1_0.listBox_1.Items.Add((object) "928/267");
                  this.form1_0.listBox_1.Items.Add((object) "974/557");
                  this.form1_0.listBox_1.Items.Add((object) "728/840");
                  this.form1_0.listBox_1.Items.Add((object) "327/707");
                  this.form1_0.listBox_1.Items.Add((object) "438/188");
                }
              }
              else if (string20 == "Downhang [Eart Ghost Canyon] çevresi")
              {
                this.form1_0.listBox_1.Items.Add((object) "3521/1518");
                this.form1_0.listBox_1.Items.Add((object) "3291/1557");
                this.form1_0.listBox_1.Items.Add((object) "3605/1368");
                this.form1_0.listBox_1.Items.Add((object) "3838/1505");
                this.form1_0.listBox_1.Items.Add((object) "3639/1080");
                this.form1_0.listBox_1.Items.Add((object) "3806/1176");
                this.form1_0.listBox_1.Items.Add((object) "3397/853");
                this.form1_0.listBox_1.Items.Add((object) "3316/1200");
                this.form1_0.listBox_1.Items.Add((object) "3304/1418");
                this.form1_0.listBox_1.Items.Add((object) "4059/1660");
              }
            }
            else if (string20 == "Alexandria [Red Hamada/Red Leg/Red Eggre] çevresi")
            {
              this.form1_0.listBox_1.Items.Add((object) "-13394/-981");
              this.form1_0.listBox_1.Items.Add((object) "-1304/-858");
              this.form1_0.listBox_1.Items.Add((object) "-12480/-811");
              this.form1_0.listBox_1.Items.Add((object) "-11569/-907");
              this.form1_0.listBox_1.Items.Add((object) "-11605/-1086");
              this.form1_0.listBox_1.Items.Add((object) "-13102/-1080");
            }
          }
          else if (*(uint*) voidPtr <= 3314701985U)
          {
            if (*(uint*) voidPtr != 3126691316U)
            {
              if (*(uint*) voidPtr != 3198960433U)
              {
                if (*(uint*) voidPtr == 3314701985U && string20 == "Hotan [Mysterious Death Desert] çevresi")
                {
                  this.form1_0.listBox_1.Items.Add((object) "142/1667");
                  this.form1_0.listBox_1.Items.Add((object) "-305/1580");
                  this.form1_0.listBox_1.Items.Add((object) "-675/1588");
                  this.form1_0.listBox_1.Items.Add((object) "-879/1404");
                  this.form1_0.listBox_1.Items.Add((object) "-854/1380");
                  this.form1_0.listBox_1.Items.Add((object) "-1100/1603");
                  this.form1_0.listBox_1.Items.Add((object) "-918/1825");
                }
              }
              else if (string20 == "Hotan [Taklamakan] çevresi")
              {
                this.form1_0.listBox_1.Items.Add((object) "-891/2551");
                this.form1_0.listBox_1.Items.Add((object) "-581/2634");
                this.form1_0.listBox_1.Items.Add((object) "-22/2465");
                this.form1_0.listBox_1.Items.Add((object) "227/2512");
                this.form1_0.listBox_1.Items.Add((object) "524/2625");
                this.form1_0.listBox_1.Items.Add((object) "-290/2278");
                this.form1_0.listBox_1.Items.Add((object) "-404/2145");
                this.form1_0.listBox_1.Items.Add((object) "-617/2135");
                this.form1_0.listBox_1.Items.Add((object) "-636/2546");
                this.form1_0.listBox_1.Items.Add((object) "7/2025");
              }
            }
            else if (string20 == "Downhang [Grassland Road/Hyungno Homeland] çevresi")
            {
              this.form1_0.listBox_1.Items.Add((object) "3807/2373");
              this.form1_0.listBox_1.Items.Add((object) "3635/2600");
              this.form1_0.listBox_1.Items.Add((object) "4218/2645");
              this.form1_0.listBox_1.Items.Add((object) "4422/2272");
              this.form1_0.listBox_1.Items.Add((object) "4781/2037");
              this.form1_0.listBox_1.Items.Add((object) "4949/2130");
              this.form1_0.listBox_1.Items.Add((object) "5118/2370");
              this.form1_0.listBox_1.Items.Add((object) "4972/2569");
              this.form1_0.listBox_1.Items.Add((object) "4753/2644");
              this.form1_0.listBox_1.Items.Add((object) "4749/2418");
            }
          }
          else if (*(uint*) voidPtr != 3646794897U)
          {
            if (*(uint*) voidPtr != 3822126096U)
            {
              if (*(uint*) voidPtr == 4282160766U && string20 == "Samarkand [Ampitheater/Asia Minor/Anatolian Plateau] çevresi")
              {
                this.form1_0.listBox_1.Items.Add((object) "-6432/2759");
                this.form1_0.listBox_1.Items.Add((object) "-6892/2260");
                this.form1_0.listBox_1.Items.Add((object) "-6957/2325");
                this.form1_0.listBox_1.Items.Add((object) "-6787/2620");
                this.form1_0.listBox_1.Items.Add((object) "-6444/2299");
                this.form1_0.listBox_1.Items.Add((object) "-6031/2279");
                this.form1_0.listBox_1.Items.Add((object) "-6600/2172");
                this.form1_0.listBox_1.Items.Add((object) "-6621/1948");
                this.form1_0.listBox_1.Items.Add((object) "-6903/2137");
              }
            }
            else if (string20 == "Alexandria [Black Hamada/Black Leg/Black Eggre] çevresi")
            {
              this.form1_0.listBox_1.Items.Add((object) "-11678/-1616");
              this.form1_0.listBox_1.Items.Add((object) "-11492/-1823");
              this.form1_0.listBox_1.Items.Add((object) "-11930/-1757");
              this.form1_0.listBox_1.Items.Add((object) "-12189/-1688");
              this.form1_0.listBox_1.Items.Add((object) "-12567/-1864");
              this.form1_0.listBox_1.Items.Add((object) "-12851/-1801");
              this.form1_0.listBox_1.Items.Add((object) "-13153/-1707");
              this.form1_0.listBox_1.Items.Add((object) "-13355/-1607");
            }
          }
          else if (string20 == "Samarkand [Huns Garrison/Ong Habitat] çevresi")
          {
            this.form1_0.listBox_1.Items.Add((object) "-4216/2665");
            this.form1_0.listBox_1.Items.Add((object) "-4683/2313");
            this.form1_0.listBox_1.Items.Add((object) "-4797/2618");
            this.form1_0.listBox_1.Items.Add((object) "-4877/2299");
            this.form1_0.listBox_1.Items.Add((object) "-5182/1953");
            this.form1_0.listBox_1.Items.Add((object) "-5645/2984");
            this.form1_0.listBox_1.Items.Add((object) "-5354/2249");
            this.form1_0.listBox_1.Items.Add((object) "-5056/2211");
            this.form1_0.listBox_1.Items.Add((object) "-4801/2410");
          }
          this.int_3 = 0;
          this.random_1 = new Random(Guid.NewGuid().GetHashCode());
          while (true)
          {
            *(sbyte*) ((IntPtr) voidPtr + 9) = (sbyte) (this.int_3 < 5);
            if (*(sbyte*) ((IntPtr) voidPtr + 9) != (sbyte) 0)
            {
              *(int*) ((IntPtr) voidPtr + 4) = this.int_3;
              this.int_3 = *(int*) ((IntPtr) voidPtr + 4) + 1;
              this.int_2 = this.random_1.Next(this.form1_0.listBox_1.Items.Count);
              this.string_1 = this.form1_0.listBox_1.Items[this.int_2].ToString();
              *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) (this.form1_0.listBox_0.FindString(this.string_1) == -1);
              if (*(sbyte*) ((IntPtr) voidPtr + 8) != (sbyte) 0)
              {
                this.form1_0.listBox_0.Items.Add((object) this.string_1);
              }
              else
              {
                *(int*) ((IntPtr) voidPtr + 4) = this.int_3;
                this.int_3 = *(int*) ((IntPtr) voidPtr + 4) - 1;
              }
            }
            else
              break;
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

    private sealed class Class52 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public Form1 form1_0;
      private Exception exception_0;
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
              awaiter2 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              break;
            case 1:
              awaiter1 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_7;
            default:
label_9:
              *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (this.form1_0.listBox_0.Items.Count > 0);
              if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
              {
                this.form1_0.method_15();
                awaiter2 = Task.Delay(1500).GetAwaiter();
                if (!awaiter2.IsCompleted)
                {
                  num = 0;
                  this.int_0 = 0;
                  this.taskAwaiter_0 = awaiter2;
                  Form1.Class52 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class52>(ref awaiter2, ref stateMachine);
                  return;
                }
                break;
              }
              goto label_15;
          }
          awaiter2.GetResult();
          awaiter2 = new TaskAwaiter();
          try
          {
            Class73.smethod_21(1, Class25.class19_0, 22519);
            ++Form1.int_1;
          }
          catch (Exception ex)
          {
            this.exception_0 = ex;
            Form1.smethod_0("Uniq Spawn başarısız!!!  ==> " + this.exception_0.Message);
          }
          awaiter1 = Task.Delay(500).GetAwaiter();
          if (!awaiter1.IsCompleted)
          {
            num = 1;
            this.int_0 = 1;
            this.taskAwaiter_0 = awaiter1;
            Form1.Class52 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class52>(ref awaiter1, ref stateMachine);
            return;
          }
label_7:
          awaiter1.GetResult();
          awaiter1 = new TaskAwaiter();
          *(sbyte*) voidPtr = (sbyte) (this.form1_0.listBox_0.Items.Count == 0);
          if (*(sbyte*) voidPtr != (sbyte) 0)
          {
            Form1.smethod_0("Tüm uniqler spawn edildi.");
            Class73.smethod_206(Class25.class19_0);
            goto label_9;
          }
          else
            goto label_9;
        }
        catch (Exception ex)
        {
          this.int_0 = -2;
          this.asyncVoidMethodBuilder_0.SetException(ex);
          return;
        }
label_15:
        this.int_0 = -2;
        this.asyncVoidMethodBuilder_0.SetResult();
      }

      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }

    private sealed class Class53 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public Form1 form1_0;
      private string string_0;
      private string string_1;
      private double double_0;
      private double double_1;
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
          if (int0 != 0)
          {
            this.form1_0.listBox_0.SetSelected(0, true);
            Class73.smethod_253(this.form1_0);
            awaiter = Task.Delay(250).GetAwaiter();
            if (!awaiter.IsCompleted)
            {
              num = 0;
              this.int_0 = 0;
              this.taskAwaiter_0 = awaiter;
              Form1.Class53 stateMachine = this;
              this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class53>(ref awaiter, ref stateMachine);
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
          this.string_0 = string.Concat(this.form1_0.listBox_19.Items[0]);
          this.string_1 = string.Concat(this.form1_0.listBox_19.Items[1]);
          this.double_0 = Convert.ToDouble(this.string_0);
          this.double_1 = Convert.ToDouble(this.string_1);
          *(sbyte*) voidPtr = (sbyte) (this.form1_0.listBox_0.Items.Count > 0);
          if (*(sbyte*) voidPtr != (sbyte) 0)
          {
            Class73.smethod_83(Class25.class19_0, this.double_0, this.double_1);
          }
          else
          {
            Class73.smethod_206(Class25.class19_0);
            Form1.smethod_1("Gidilecek Koordinat Kalmadı !!!", Color.Salmon);
          }
          this.form1_0.listBox_0.Items.Remove(this.form1_0.listBox_0.SelectedItem);
          this.form1_0.listBox_19.Items.Clear();
          *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (this.form1_0.listBox_0.Items.Count > 0);
          if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
            this.form1_0.listBox_0.SetSelected(0, true);
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

    private sealed class Class54 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public Form1 form1_0;
      private string string_0;
      private string string_1;
      private double double_0;
      private double double_1;
      private TaskAwaiter taskAwaiter_0;

      unsafe void IAsyncStateMachine.MoveNext()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(3);
        int int0 = this.int_0;
        try
        {
          TaskAwaiter awaiter1;
          int num;
          TaskAwaiter awaiter2;
          TaskAwaiter awaiter3;
          TaskAwaiter awaiter4;
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
              goto label_9;
            case 2:
              awaiter3 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_12;
            case 3:
              awaiter4 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_15;
            default:
              Class73.smethod_25(this.form1_0);
              this.form1_0.checkBox_8.Checked = true;
              this.string_0 = string.Concat(this.form1_0.listBox_19.Items[0]);
              this.string_1 = string.Concat(this.form1_0.listBox_19.Items[1]);
              this.double_0 = Convert.ToDouble(this.string_0);
              this.double_1 = Convert.ToDouble(this.string_1);
              *(sbyte*) voidPtr = (sbyte) (this.form1_0.listBox_0.Items.Count > 0);
              if (*(sbyte*) voidPtr != (sbyte) 0)
              {
                Class73.smethod_83(Class25.class19_0, this.double_0, this.double_1);
                awaiter1 = Task.Delay(2000).GetAwaiter();
                if (!awaiter1.IsCompleted)
                {
                  num = 0;
                  this.int_0 = 0;
                  this.taskAwaiter_0 = awaiter1;
                  Form1.Class54 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class54>(ref awaiter1, ref stateMachine);
                  return;
                }
                break;
              }
              goto label_16;
          }
          awaiter1.GetResult();
          awaiter1 = new TaskAwaiter();
          Class73.smethod_249("GM BULMA ETKİNLİĞİ", Class25.class19_0);
          awaiter2 = Task.Delay(500).GetAwaiter();
          if (!awaiter2.IsCompleted)
          {
            num = 1;
            this.int_0 = 1;
            this.taskAwaiter_0 = awaiter2;
            Form1.Class54 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class54>(ref awaiter2, ref stateMachine);
            return;
          }
label_9:
          awaiter2.GetResult();
          awaiter2 = new TaskAwaiter();
          Class73.smethod_58(Class25.class19_0, "KAZANMAK İÇİN STALA BİR MESAJ BIRAK.");
          awaiter3 = Task.Delay(500).GetAwaiter();
          if (!awaiter3.IsCompleted)
          {
            num = 2;
            this.int_0 = 2;
            this.taskAwaiter_0 = awaiter3;
            Form1.Class54 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class54>(ref awaiter3, ref stateMachine);
            return;
          }
label_12:
          awaiter3.GetResult();
          awaiter3 = new TaskAwaiter();
          Class73.smethod_161(Class25.class19_0, "Saklandım.Açtığım stala ilk mesajı yazan kazanır.Saklandığım bölge  " + Form1.string_20);
          awaiter4 = Task.Delay(500).GetAwaiter();
          if (!awaiter4.IsCompleted)
          {
            num = 3;
            this.int_0 = 3;
            this.taskAwaiter_0 = awaiter4;
            Form1.Class54 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class54>(ref awaiter4, ref stateMachine);
            return;
          }
label_15:
          awaiter4.GetResult();
          awaiter4 = new TaskAwaiter();
          Class73.smethod_241(Class25.class19_0);
          this.form1_0.int_6 = 0;
label_16:
          this.form1_0.listBox_0.Items.Remove(this.form1_0.listBox_0.SelectedItem);
          this.form1_0.listBox_19.Items.Clear();
          *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (this.form1_0.listBox_0.Items.Count > 0);
          if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
          {
            this.form1_0.listBox_0.SetSelected(0, true);
          }
          else
          {
            *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) (this.form1_0.listBox_0.Items.Count <= 0);
            if (*(sbyte*) ((IntPtr) voidPtr + 2) != (sbyte) 0)
              Form1.smethod_1("Gidilecek Koordinat Bulunamadı !!!", Color.Salmon);
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

    private sealed class Class55 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public Form1 form1_0;
      private TaskAwaiter taskAwaiter_0;

      void IAsyncStateMachine.MoveNext()
      {
        int int0 = this.int_0;
        try
        {
          TaskAwaiter awaiter;
          int num;
          if (int0 != 0)
          {
            Class73.smethod_241(Class25.class19_0);
            Class73.smethod_161(Class25.class19_0, "30 saniye sonra [Kayıp GM] etkinliğimizin 2. turu başlayacaktır.");
            awaiter = Task.Delay(30000).GetAwaiter();
            if (!awaiter.IsCompleted)
            {
              num = 0;
              this.int_0 = 0;
              this.taskAwaiter_0 = awaiter;
              Form1.Class55 stateMachine = this;
              this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class55>(ref awaiter, ref stateMachine);
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
          this.form1_0.timer_1.Start();
          this.form1_0.method_16();
          this.form1_0.int_6 = 0;
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

    private sealed class Class56 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public Form1 form1_0;
      private TaskAwaiter taskAwaiter_0;

      void IAsyncStateMachine.MoveNext()
      {
        int int0 = this.int_0;
        try
        {
          TaskAwaiter awaiter;
          int num;
          if (int0 != 0)
          {
            Class73.smethod_241(Class25.class19_0);
            Class73.smethod_161(Class25.class19_0, "30 saniye sonra [Kayıp GM] etkinliğimizin 3. turu başlayacaktır.");
            awaiter = Task.Delay(30000).GetAwaiter();
            if (!awaiter.IsCompleted)
            {
              num = 0;
              this.int_0 = 0;
              this.taskAwaiter_0 = awaiter;
              Form1.Class56 stateMachine = this;
              this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class56>(ref awaiter, ref stateMachine);
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
          this.form1_0.timer_1.Start();
          this.form1_0.method_16();
          this.form1_0.int_6 = 0;
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

    private sealed class Class57 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public Form1 form1_0;
      private TaskAwaiter taskAwaiter_0;

      void IAsyncStateMachine.MoveNext()
      {
        int int0 = this.int_0;
        try
        {
          TaskAwaiter awaiter;
          int num;
          if (int0 != 0)
          {
            Class73.smethod_161(Class25.class19_0, "[Kayıp GM] etkinliğimiz sona ermiştir.Başka etkinliklerde görüşmek üzere..");
            this.form1_0.checkBox_8.Checked = false;
            this.form1_0.timer_1.Stop();
            awaiter = Task.Delay(1000).GetAwaiter();
            if (!awaiter.IsCompleted)
            {
              num = 0;
              this.int_0 = 0;
              this.taskAwaiter_0 = awaiter;
              Form1.Class57 stateMachine = this;
              this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class57>(ref awaiter, ref stateMachine);
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
          Class73.smethod_206(Class25.class19_0);
          this.form1_0.int_6 = 0;
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

    private sealed class Class58 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public string string_0;
      public Form1 form1_0;
      private Exception exception_0;
      private Exception exception_1;
      private Exception exception_2;
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
          TaskAwaiter awaiter3;
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
              goto label_17;
            case 2:
              awaiter3 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_24;
            default:
              *(sbyte*) voidPtr = (sbyte) Form1.form1_0.checkBox_11.Checked;
              if (*(sbyte*) voidPtr != (sbyte) 0)
              {
                try
                {
                  new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_0 + "',1," + Form1.form1_0.textBox_32.Text + "," + Form1.form1_0.textBox_31.Text + "," + Form1.form1_0.textBox_30.Text ?? "", Class65.sqlConnection_0).ExecuteNonQuery();
                  Form1.smethod_1("ITEM ödülü teslim Edildi .", Color.DarkGreen);
                }
                catch (Exception ex)
                {
                  this.exception_0 = ex;
                  Form1.smethod_1("HATA ! İtem Ödülü teslim edilemedi!!" + this.exception_0.Message, Color.OrangeRed);
                }
              }
              *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) Form1.form1_0.checkBox_10.Checked;
              if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
              {
                try
                {
                  new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_0 + "',2,böylekalsin," + Form1.form1_0.textBox_35.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
                  Form1.smethod_1("Silk ödülü teslim edildi .", Color.DarkGreen);
                }
                catch
                {
                }
                awaiter1 = Task.Delay(500).GetAwaiter();
                if (!awaiter1.IsCompleted)
                {
                  num = 0;
                  this.int_0 = 0;
                  this.taskAwaiter_0 = awaiter1;
                  Form1.Class58 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class58>(ref awaiter1, ref stateMachine);
                  return;
                }
                break;
              }
              goto label_20;
          }
          awaiter1.GetResult();
          awaiter1 = new TaskAwaiter();
          try
          {
            new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_0 + "',3,böylekalsin," + Form1.form1_0.textBox_33.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
            Form1.smethod_1("GOLD ödülü teslim edildi. ", Color.DarkGreen);
          }
          catch (Exception ex)
          {
            this.exception_1 = ex;
            Form1.smethod_1("HATA ! Gold ödülü teslim edilemedi !! ==> " + this.exception_1.Message, Color.OrangeRed);
          }
          awaiter2 = Task.Delay(500).GetAwaiter();
          if (!awaiter2.IsCompleted)
          {
            num = 1;
            this.int_0 = 1;
            this.taskAwaiter_0 = awaiter2;
            Form1.Class58 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class58>(ref awaiter2, ref stateMachine);
            return;
          }
label_17:
          awaiter2.GetResult();
          awaiter2 = new TaskAwaiter();
          try
          {
            new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_0 + "',4,böylekalsin," + Form1.form1_0.textBox_34.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
            Form1.smethod_1("SP ödülü teslim edildi .", Color.DarkGreen);
          }
          catch (Exception ex)
          {
            this.exception_2 = ex;
            Form1.smethod_1("HATA !Sp ödülü teslim edilemedi !! ==> " + this.exception_2.Message, Color.OrangeRed);
          }
label_20:
          if ((this.form1_0.checkBox_11.Checked ? 1 : (this.form1_0.checkBox_10.Checked ? 1 : 0)) != 0)
          {
            Class73.smethod_123(Class25.class19_0, this.string_0, "Tebrikler...");
            awaiter3 = Task.Delay(1000).GetAwaiter();
            if (!awaiter3.IsCompleted)
            {
              num = 2;
              this.int_0 = 2;
              this.taskAwaiter_0 = awaiter3;
              Form1.Class58 stateMachine = this;
              this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class58>(ref awaiter3, ref stateMachine);
              return;
            }
          }
          else
            goto label_26;
label_24:
          awaiter3.GetResult();
          awaiter3 = new TaskAwaiter();
          Class73.smethod_193(Class25.class19_0, this.string_0);
        }
        catch (Exception ex)
        {
          this.int_0 = -2;
          this.asyncVoidMethodBuilder_0.SetException(ex);
          return;
        }
label_26:
        this.int_0 = -2;
        this.asyncVoidMethodBuilder_0.SetResult();
      }

      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }

    private sealed class Class59 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public object object_0;
      public EventArgs eventArgs_0;
      public Form1 form1_0;
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
              *(sbyte*) voidPtr = (sbyte) (this.form1_0.int_6 < 400);
              if (*(sbyte*) voidPtr != (sbyte) 0)
                ++this.form1_0.int_6;
              *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (this.form1_0.int_6 == 300);
              if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
              {
                Class73.smethod_161(Class25.class19_0, "5 dakika içinde beni bulan olmadığı için bu turda kazanan olmadı..");
                awaiter1 = Task.Delay(1000).GetAwaiter();
                if (!awaiter1.IsCompleted)
                {
                  num = 0;
                  this.int_0 = 0;
                  this.taskAwaiter_0 = awaiter1;
                  Form1.Class59 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class59>(ref awaiter1, ref stateMachine);
                  return;
                }
                break;
              }
              goto label_19;
          }
          awaiter1.GetResult();
          awaiter1 = new TaskAwaiter();
          this.form1_0.timer_1.Stop();
          Class73.smethod_66(Class25.class19_0);
          awaiter2 = Task.Delay(5000).GetAwaiter();
          if (!awaiter2.IsCompleted)
          {
            num = 1;
            this.int_0 = 1;
            this.taskAwaiter_0 = awaiter2;
            Form1.Class59 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class59>(ref awaiter2, ref stateMachine);
            return;
          }
label_11:
          awaiter2.GetResult();
          awaiter2 = new TaskAwaiter();
          string text = Form1.form1_0.textBox_52.Text;
          if (!(text == "1"))
          {
            if (!(text == "2"))
            {
              if (text == "3")
              {
                this.form1_0.method_19();
                this.form1_0.textBox_52.Text = "0";
                this.form1_0.checkBox_8.Checked = false;
                this.form1_0.int_6 = 0;
              }
            }
            else
            {
              this.form1_0.textBox_52.Text = "3";
              this.form1_0.method_18();
              this.form1_0.int_6 = 0;
            }
          }
          else
          {
            this.form1_0.textBox_52.Text = "2";
            this.form1_0.method_17();
            this.form1_0.int_6 = 0;
          }
          this.form1_0.int_6 = 0;
        }
        catch (Exception ex)
        {
          this.int_0 = -2;
          this.asyncVoidMethodBuilder_0.SetException(ex);
          return;
        }
label_19:
        this.int_0 = -2;
        this.asyncVoidMethodBuilder_0.SetResult();
      }

      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }

    private sealed class Class60 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public object object_0;
      public EventArgs eventArgs_0;
      public Form1 form1_0;
      private SqlDataReader sqlDataReader_0;
      private string string_0;
      private string string_1;
      private Exception exception_0;
      private Exception exception_1;
      private Exception exception_2;
      private Exception exception_3;
      private TaskAwaiter taskAwaiter_0;

      unsafe void IAsyncStateMachine.MoveNext()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(3);
        int int0 = this.int_0;
        try
        {
          switch (int0)
          {
            default:
              try
              {
                TaskAwaiter awaiter1;
                int num;
                TaskAwaiter awaiter2;
                TaskAwaiter awaiter3;
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
                    goto label_17;
                  case 2:
                    awaiter3 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num = -1;
                    this.int_0 = -1;
                    goto label_23;
                  default:
                    this.sqlDataReader_0 = new SqlCommand("SELECT top 1* FROM My_EventBot.._Hayatta_Kal where Durum = 'öldü'", Class65.sqlConnection_0).ExecuteReader();
                    this.sqlDataReader_0.Read();
                    this.string_0 = Convert.ToString(this.sqlDataReader_0["CharName"].ToString());
                    Class73.smethod_26(Class25.class19_0, this.string_0);
                    new SqlCommand("exec My_EventBot..__Hayatta_Kal '" + this.string_0 + "','PKSİL'", Class65.sqlConnection_0).ExecuteNonQuery();
                    this.form1_0.listBox_13.Items.Remove((object) this.string_0);
                    *(sbyte*) voidPtr = (sbyte) (this.form1_0.listBox_13.Items.Count == 1);
                    if (*(sbyte*) voidPtr != (sbyte) 0)
                    {
                      this.form1_0.listBox_13.SelectedIndex = 0;
                      this.string_1 = this.form1_0.listBox_13.SelectedItem.ToString();
                      Form1.smethod_0("Kazanan ==> " + this.string_1);
                      Class73.smethod_161(Class25.class19_0, "[Hayatta Kal] etkinliği sona ermiştir. Hayatta kalan son katılımcı  [" + this.string_1 + "]  olmuştur. Tebrikler.");
                      Class73.smethod_123(Class25.class19_0, this.string_1, "Tebrikler etkinliği sen kazanandın.");
                      awaiter1 = Task.Delay(1000).GetAwaiter();
                      if (!awaiter1.IsCompleted)
                      {
                        num = 0;
                        this.int_0 = 0;
                        this.taskAwaiter_0 = awaiter1;
                        Form1.Class60 stateMachine = this;
                        this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class60>(ref awaiter1, ref stateMachine);
                        return;
                      }
                      break;
                    }
                    goto label_30;
                }
                awaiter1.GetResult();
                awaiter1 = new TaskAwaiter();
                new SqlCommand("exec My_EventBot..__Hayatta_Kal '" + this.string_1 + "','PKSİL'", Class65.sqlConnection_0).ExecuteNonQuery();
                *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) Form1.form1_0.checkBox_7.Checked;
                if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
                {
                  try
                  {
                    new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_1 + "',1," + Form1.form1_0.textBox_20.Text + "," + Form1.form1_0.textBox_19.Text + "," + Form1.form1_0.textBox_18.Text ?? "", Class65.sqlConnection_0).ExecuteNonQuery();
                    Form1.smethod_1("ITEM ödülü teslim Edildi .", Color.DarkGreen);
                  }
                  catch (Exception ex)
                  {
                    this.exception_0 = ex;
                    Form1.smethod_1("HATA ! İtem Ödülü teslim edilemedi!!" + this.exception_0.Message, Color.OrangeRed);
                  }
                }
                *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) Form1.form1_0.checkBox_6.Checked;
                if (*(sbyte*) ((IntPtr) voidPtr + 2) != (sbyte) 0)
                {
                  try
                  {
                    new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_1 + "',2,böylekalsin," + Form1.form1_0.textBox_23.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
                    Form1.smethod_1("Silk ödülü teslim Edildi .", Color.DarkGreen);
                  }
                  catch (Exception ex)
                  {
                  }
                  awaiter2 = Task.Delay(500).GetAwaiter();
                  if (!awaiter2.IsCompleted)
                  {
                    num = 1;
                    this.int_0 = 1;
                    this.taskAwaiter_0 = awaiter2;
                    Form1.Class60 stateMachine = this;
                    this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class60>(ref awaiter2, ref stateMachine);
                    return;
                  }
                }
                else
                  goto label_26;
label_17:
                awaiter2.GetResult();
                awaiter2 = new TaskAwaiter();
                try
                {
                  new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_1 + "',3,böylekalsin," + Form1.form1_0.textBox_21.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
                  Form1.smethod_1("GOLD ödülü teslim Edildi. ", Color.DarkGreen);
                }
                catch (Exception ex)
                {
                  this.exception_1 = ex;
                  Form1.smethod_1("HATA ! Gold ödülü teslim edilemedi !! ==> " + this.exception_1.Message, Color.OrangeRed);
                }
                awaiter3 = Task.Delay(500).GetAwaiter();
                if (!awaiter3.IsCompleted)
                {
                  num = 2;
                  this.int_0 = 2;
                  this.taskAwaiter_0 = awaiter3;
                  Form1.Class60 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class60>(ref awaiter3, ref stateMachine);
                  return;
                }
label_23:
                awaiter3.GetResult();
                awaiter3 = new TaskAwaiter();
                try
                {
                  new SqlCommand("Exec My_EventBot.._Ödül_ver '" + this.string_1 + "',4,böylekalsin," + Form1.form1_0.textBox_22.Text + ",1", Class65.sqlConnection_0).ExecuteNonQuery();
                  Form1.smethod_1("SP ödülü teslim Edildi .", Color.DarkGreen);
                }
                catch (Exception ex)
                {
                  this.exception_2 = ex;
                  Form1.smethod_1("HATA !Sp ödülü teslim edilemedi !! ==> " + this.exception_2.Message, Color.OrangeRed);
                }
label_26:
                Class73.smethod_26(Class25.class19_0, this.string_1);
                try
                {
                  new SqlCommand("delete My_EventBot.._Hayatta_Kal", Class65.sqlConnection_0).ExecuteNonQuery();
                  new SqlCommand("delete My_EventBot.._HayattaKal_List", Class65.sqlConnection_0).ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                  this.exception_3 = ex;
                  Form1.smethod_0("[Hayatta Kal] etkinliği sonrası temizlik yapılırken bir hata oluştur.");
                  Form1.smethod_0("Hata Açıklaması ==> " + this.exception_3.Message);
                }
                Form1.list_0.Clear();
                this.form1_0.listBox_13.Items.Clear();
                this.form1_0.listBox_14.Items.Clear();
                this.form1_0.timer_12.Stop();
                this.form1_0.timer_2.Stop();
                this.form1_0.checkBox_21.Checked = false;
                this.form1_0.bool_0 = false;
                Class73.smethod_206(Class25.class19_0);
                this.string_1 = (string) null;
label_30:
                this.sqlDataReader_0 = (SqlDataReader) null;
                this.string_0 = (string) null;
                break;
              }
              catch
              {
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
        this.int_0 = -2;
        this.asyncVoidMethodBuilder_0.SetResult();
      }

      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }

    private sealed class Class61 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public object object_0;
      public EventArgs eventArgs_0;
      public Form1 form1_0;
      private SqlDataReader sqlDataReader_0;
      private long long_0;
      private TaskAwaiter taskAwaiter_0;

      unsafe void IAsyncStateMachine.MoveNext()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(2);
        int int0 = this.int_0;
        try
        {
          if (int0 != 0)
            ;
          try
          {
            TaskAwaiter awaiter;
            int num;
            if (int0 != 0)
            {
              this.sqlDataReader_0 = new SqlCommand("select Top 1* from My_EventBot.._AntiPhBot where CevapDurumu = 'cevapyok'", Class65.sqlConnection_0).ExecuteReader();
            }
            else
            {
              awaiter = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
              goto label_10;
            }
label_6:
            *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) this.sqlDataReader_0.Read();
            if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
            {
              Form1.string_34 = Convert.ToString(this.sqlDataReader_0["CharName"]);
              Form1.string_35 = Convert.ToString(this.sqlDataReader_0["CevapDurumu"]);
              this.long_0 = Convert.ToInt64(this.sqlDataReader_0["ItemSerial64"]);
              *(sbyte*) voidPtr = (sbyte) (Form1.string_35 == "cevapyok");
              if (*(sbyte*) voidPtr != (sbyte) 0)
              {
                new SqlCommand("update My_EventBot.._AntiPhBot set CevapDurumu = 'bekleniyor' where CharName='" + Form1.string_34 + "'", Class65.sqlConnection_0).ExecuteNonQuery();
                this.form1_0.listBox_17.Items.Add((object) Form1.string_34);
                Class73.smethod_123(Class25.class19_0, Form1.string_34, "İşlemine devam edebilmek için " + this.form1_0.textBox_85.Text + "saniye içinde bana bu numarayı PM olarak yolla. Numara =>  " + (object) Form1.int_0 ?? "");
              }
              awaiter = Task.Delay((int) Convert.ToInt16(this.form1_0.textBox_85.Text) * 1000).GetAwaiter();
              if (!awaiter.IsCompleted)
              {
                num = 0;
                this.int_0 = 0;
                this.taskAwaiter_0 = awaiter;
                Form1.Class61 stateMachine = this;
                this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class61>(ref awaiter, ref stateMachine);
                return;
              }
            }
            else
            {
              this.sqlDataReader_0 = (SqlDataReader) null;
              goto label_15;
            }
label_10:
            awaiter.GetResult();
            awaiter = new TaskAwaiter();
            new SqlCommand("update My_EventBot.._AntiPhBot set CevapDurumu = 'cevapgecikti' where CharName='" + Form1.string_34 + "'", Class65.sqlConnection_0).ExecuteNonQuery();
            goto label_6;
          }
          catch
          {
          }
        }
        catch (Exception ex)
        {
          this.int_0 = -2;
          this.asyncVoidMethodBuilder_0.SetException(ex);
          return;
        }
label_15:
        this.int_0 = -2;
        this.asyncVoidMethodBuilder_0.SetResult();
      }

      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }

    private sealed class Class62 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public object object_0;
      public EventArgs eventArgs_0;
      public Form1 form1_0;
      private SqlDataReader sqlDataReader_0;
      private long long_0;
      private TaskAwaiter taskAwaiter_0;

      unsafe void IAsyncStateMachine.MoveNext()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(3);
        int int0 = this.int_0;
        try
        {
          if (int0 != 0)
            ;
          try
          {
            TaskAwaiter awaiter;
            int num;
            if (int0 != 0)
            {
              this.sqlDataReader_0 = new SqlCommand("select Top 1* from My_EventBot.._AntiPhBot", Class65.sqlConnection_0).ExecuteReader();
              goto label_7;
            }
            else
            {
              awaiter = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
            }
label_6:
            awaiter.GetResult();
            awaiter = new TaskAwaiter();
            string str = "exec My_EventBot..__AntiPhBot 'item_sil','" + Form1.string_34 + "'," + (object) this.long_0;
            new SqlCommand(str == null ? "" : str, Class65.sqlConnection_0).ExecuteNonQuery();
            Class73.smethod_123(Class25.class19_0, Form1.string_34, "Verilen süre içinde dogru cevap gelmnedi.Aldıgın item kervan petinden silindi..");
            Class73.smethod_26(Class25.class19_0, Form1.string_34);
            Form1.form1_0.listBox_17.Items.Remove((object) Form1.string_34);
            new SqlCommand("delete top (1) My_EventBot.._AntiPhBot where CharName = '" + Form1.string_34 + "' and CevapDurumu ='cevapgecikti'", Class65.sqlConnection_0).ExecuteNonQuery();
            goto label_10;
label_7:
            *(sbyte*) ((IntPtr) voidPtr + 2) = (sbyte) this.sqlDataReader_0.Read();
            if (*(sbyte*) ((IntPtr) voidPtr + 2) != (sbyte) 0)
            {
              Form1.string_34 = Convert.ToString(this.sqlDataReader_0["CharName"]);
              Form1.string_35 = Convert.ToString(this.sqlDataReader_0["CevapDurumu"]);
              this.long_0 = Convert.ToInt64(this.sqlDataReader_0["ItemSerial64"]);
              *(sbyte*) voidPtr = (sbyte) (Form1.string_35 == "cevapgecikti");
              if (*(sbyte*) voidPtr != (sbyte) 0)
              {
                awaiter = Task.Delay(1000).GetAwaiter();
                if (!awaiter.IsCompleted)
                {
                  num = 0;
                  this.int_0 = 0;
                  this.taskAwaiter_0 = awaiter;
                  Form1.Class62 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class62>(ref awaiter, ref stateMachine);
                  return;
                }
                goto label_6;
              }
            }
            else
            {
              this.sqlDataReader_0 = (SqlDataReader) null;
              goto label_16;
            }
label_10:
            *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (Form1.string_35 == "yanliscevap");
            if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
            {
              new SqlCommand("exec My_EventBot..__AntiPhBot 'item_sil','" + Form1.string_34 + "'," + (object) this.long_0 ?? "", Class65.sqlConnection_0).ExecuteNonQuery();
              Class73.smethod_123(Class25.class19_0, Form1.string_34, "Yanlış cevap.Aldıgın item kervan petinden silindi..");
              Class73.smethod_26(Class25.class19_0, Form1.string_34);
              Form1.form1_0.listBox_17.Items.Remove((object) Form1.string_34);
              new SqlCommand("delete top (1) My_EventBot.._AntiPhBot where CharName = '" + Form1.string_34 + "' and CevapDurumu ='yanliscevap'", Class65.sqlConnection_0).ExecuteNonQuery();
              goto label_7;
            }
            else
              goto label_7;
          }
          catch
          {
          }
        }
        catch (Exception ex)
        {
          this.int_0 = -2;
          this.asyncVoidMethodBuilder_0.SetException(ex);
          return;
        }
label_16:
        this.int_0 = -2;
        this.asyncVoidMethodBuilder_0.SetResult();
      }

      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }

    private sealed class Class63 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public Form1 form1_0;
      private SqlDataReader sqlDataReader_0;
      private Exception exception_0;
      private Exception exception_1;
      private TaskAwaiter taskAwaiter_0;

      void IAsyncStateMachine.MoveNext()
      {
        int int0 = this.int_0;
        try
        {
          if (int0 != 0)
            ;
          try
          {
            TaskAwaiter awaiter;
            int num;
            if (int0 != 0)
            {
              this.sqlDataReader_0 = new SqlCommand("select refcommon_ID from My_EventBot.._UniqKesList order by Sıra", Class65.sqlConnection_0).ExecuteReader();
              new SqlCommand("update My_EventBot.._UniqKesList set Durum=0", Class65.sqlConnection_0).ExecuteReader();
              goto label_7;
            }
            else
            {
              awaiter = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num = -1;
              this.int_0 = -1;
            }
label_6:
            awaiter.GetResult();
            awaiter = new TaskAwaiter();
label_7:
            if (this.sqlDataReader_0.Read())
            {
              try
              {
                this.form1_0.listBoxControl_0.Items.Add((object) Convert.ToInt32(this.sqlDataReader_0[0].ToString()));
              }
              catch (Exception ex)
              {
                this.exception_0 = ex;
                Form1.smethod_0("Veritabanından çekilen UniqueID int değere çevrilemediği için listeye eklenmedi !!");
                Form1.smethod_0("HATA ==> " + this.exception_0.Message);
              }
              awaiter = Task.Delay(50).GetAwaiter();
              if (!awaiter.IsCompleted)
              {
                num = 0;
                this.int_0 = 0;
                this.taskAwaiter_0 = awaiter;
                Form1.Class63 stateMachine = this;
                this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class63>(ref awaiter, ref stateMachine);
                return;
              }
              goto label_6;
            }
            else
              this.sqlDataReader_0 = (SqlDataReader) null;
          }
          catch (Exception ex)
          {
            this.exception_1 = ex;
            Form1.smethod_0("[Unique Kesme] etkinliği listesi veritabanından çekilemedi.! HATA =>" + this.exception_1.Message);
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

    private sealed class Class64 : IAsyncStateMachine
    {
      public int int_0;
      public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;
      public Form1 form1_0;
      private int int_1;
      private int int_2;
      private SqlDataReader sqlDataReader_0;
      private Exception exception_0;
      private SqlDataReader sqlDataReader_1;
      private Exception exception_1;
      private List<string>.Enumerator enumerator_0;
      private string string_0;
      private int int_3;
      private Exception exception_2;
      private TaskAwaiter taskAwaiter_0;

      unsafe void IAsyncStateMachine.MoveNext()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(17);
        int num1 = this.int_0;
        try
        {
          TaskAwaiter awaiter1;
          int num2;
          TaskAwaiter awaiter2;
          TaskAwaiter awaiter3;
          TaskAwaiter awaiter4;
          TaskAwaiter awaiter5;
          TaskAwaiter awaiter6;
          TaskAwaiter awaiter7;
          TaskAwaiter awaiter8;
          TaskAwaiter awaiter9;
          TaskAwaiter awaiter10;
          TaskAwaiter awaiter11;
          TaskAwaiter awaiter12;
          TaskAwaiter awaiter13;
          TaskAwaiter awaiter14;
          switch (num1)
          {
            case 0:
              awaiter1 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              break;
            case 1:
              awaiter2 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_19;
            case 2:
              awaiter3 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_22;
            case 3:
              awaiter4 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_28;
            case 4:
              awaiter5 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_34;
            case 5:
label_35:
              try
              {
                TaskAwaiter awaiter15;
                if (num1 == 5)
                {
                  awaiter15 = this.taskAwaiter_0;
                  this.taskAwaiter_0 = new TaskAwaiter();
                  num1 = -1;
                  this.int_0 = -1;
                  goto label_40;
                }
label_38:
                if (this.enumerator_0.MoveNext())
                {
                  this.string_0 = this.enumerator_0.Current;
                  Class73.smethod_193(Class25.class19_0, this.string_0);
                  Form1.smethod_0(this.string_0 + " etkinlik alanına alındı.");
                  awaiter15 = Task.Delay(50).GetAwaiter();
                  if (!awaiter15.IsCompleted)
                  {
                    num1 = 5;
                    this.int_0 = 5;
                    this.taskAwaiter_0 = awaiter15;
                    Form1.Class64 stateMachine = this;
                    this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class64>(ref awaiter15, ref stateMachine);
                    return;
                  }
                }
                else
                  goto label_45;
label_40:
                awaiter15.GetResult();
                awaiter15 = new TaskAwaiter();
                Form1.list_1.Remove(this.string_0);
                this.string_0 = (string) null;
                goto label_38;
              }
              finally
              {
                if (num1 < 0)
                  this.enumerator_0.Dispose();
              }
label_45:
              this.enumerator_0 = new List<string>.Enumerator();
              *(sbyte*) ((IntPtr) voidPtr + 9) = (sbyte) (Form1.list_1.Count == 0);
              if (*(sbyte*) ((IntPtr) voidPtr + 9) != (sbyte) 0)
              {
                Form1.smethod_0("Tüm katılımcılar etkinlik alanına alındı.");
                awaiter6 = Task.Delay(5000).GetAwaiter();
                if (!awaiter6.IsCompleted)
                {
                  num2 = 6;
                  this.int_0 = 6;
                  this.taskAwaiter_0 = awaiter6;
                  Form1.Class64 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class64>(ref awaiter6, ref stateMachine);
                  return;
                }
                goto label_49;
              }
              else
                goto label_50;
            case 6:
              awaiter6 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_49;
            case 7:
              awaiter7 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_53;
            case 8:
              awaiter8 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_56;
            case 9:
              awaiter9 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_59;
            case 10:
              awaiter10 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_62;
            case 11:
              awaiter11 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_65;
            case 12:
              awaiter12 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_68;
            case 13:
              awaiter13 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_91;
            case 14:
              awaiter14 = this.taskAwaiter_0;
              this.taskAwaiter_0 = new TaskAwaiter();
              num1 = -1;
              this.int_0 = -1;
              goto label_93;
            case 15:
            case 16:
label_77:
              try
              {
                TaskAwaiter awaiter15;
                TaskAwaiter awaiter16;
                switch (num1)
                {
                  case 15:
                    awaiter15 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num1 = -1;
                    this.int_0 = -1;
                    break;
                  case 16:
                    awaiter16 = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num1 = -1;
                    this.int_0 = -1;
                    goto label_85;
                  default:
                    *(int*) voidPtr = this.int_3;
                    this.int_3 = *(int*) voidPtr + 1;
                    new SqlCommand("exec My_EventBot..__Pıyango 'Ödül','" + this.form1_0.string_22 + "','" + this.form1_0.string_21 + "',0", Class65.sqlConnection_0).ExecuteReader();
                    Form1.smethod_1("[PIYANGO] etkinliğinde çekilişi kazanan talihli => " + this.form1_0.string_22 + ". Ödülü teslim edildi.", Color.LightGreen);
                    awaiter15 = Task.Delay(500).GetAwaiter();
                    if (!awaiter15.IsCompleted)
                    {
                      num1 = 15;
                      this.int_0 = 15;
                      this.taskAwaiter_0 = awaiter15;
                      Form1.Class64 stateMachine = this;
                      this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class64>(ref awaiter15, ref stateMachine);
                      return;
                    }
                    break;
                }
                awaiter15.GetResult();
                awaiter15 = new TaskAwaiter();
                Class73.smethod_123(Class25.class19_0, this.form1_0.string_22, "Tebrikler çekilişi sen kazandın. [" + (object) Form1.long_0 + " " + this.form1_0.string_21 + "] hesabına yüklendi.3 Saniye içinde teleport olacaksın.");
                awaiter16 = Task.Delay(3000).GetAwaiter();
                if (!awaiter16.IsCompleted)
                {
                  num1 = 16;
                  this.int_0 = 16;
                  this.taskAwaiter_0 = awaiter16;
                  Form1.Class64 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class64>(ref awaiter16, ref stateMachine);
                  return;
                }
label_85:
                awaiter16.GetResult();
                awaiter16 = new TaskAwaiter();
                Class73.smethod_26(Class25.class19_0, this.form1_0.string_22);
                goto label_95;
              }
              catch (Exception ex)
              {
                this.exception_2 = ex;
                Form1.smethod_0("[PIYANGO] çekiliş ikramiyesi [" + this.form1_0.string_22 + "] isimli talihliye teslim edilemedi. HATA => " + this.exception_2.Message);
                *(sbyte*) ((IntPtr) voidPtr + 14) = (sbyte) (this.int_3 < 3);
                if (*(sbyte*) ((IntPtr) voidPtr + 14) != (sbyte) 0)
                {
                  Form1.smethod_1("İkramiye teslimi için şimdi tekrar deneniyor.", Color.Aqua);
                  goto label_94;
                }
                else
                {
                  *(sbyte*) ((IntPtr) voidPtr + 15) = (sbyte) (this.int_3 >= 3);
                  if (*(sbyte*) ((IntPtr) voidPtr + 15) != (sbyte) 0)
                  {
                    Form1.smethod_1("3 denemeye rağmen ikramiye talihliye teslim edilemedi.SQL ile ilgili problem olabilir. " + this.form1_0.string_22 + " isimli üyenin ödülünü manuel olarak teslim edebilrsiniz..", Color.Aqua);
                    goto label_95;
                  }
                  else
                    goto label_95;
                }
              }
            default:
              *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (Class73.smethod_129(this.form1_0.label_13.Text) == this.form1_0.textBox_100.Text);
              if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 5) = (sbyte) (this.form1_0.label_160.Text == "ONLİNE");
                if (*(sbyte*) ((IntPtr) voidPtr + 5) == (sbyte) 0)
                {
                  *(sbyte*) ((IntPtr) voidPtr + 6) = (sbyte) (this.form1_0.label_160.Text == "OFFLİNE");
                  if (*(sbyte*) ((IntPtr) voidPtr + 6) != (sbyte) 0)
                  {
                    this.form1_0.method_2((object) this.form1_0.button_19, new EventArgs());
                    Class73.smethod_118("[PIYANGO]", this.form1_0);
                    goto label_99;
                  }
                }
                string text = this.form1_0.comboBoxEdit_13.Text;
                if (!(text == "Silk"))
                {
                  if (!(text == "Gold"))
                  {
                    if (text == "Sp")
                      this.form1_0.string_21 = "Sp";
                  }
                  else
                    this.form1_0.string_21 = "Gold";
                }
                else
                  this.form1_0.string_21 = "Silk";
                this.form1_0.checkBox_27.Checked = true;
                this.form1_0.comboBoxEdit_13.Enabled = false;
                this.form1_0.textBox_103.Enabled = false;
                Class73.smethod_161(Class25.class19_0, "Merhaba. 5 dakika sonra [PIYANGO] etkinliği yapılacaktır.Çekiliş türü [" + this.form1_0.string_21 + " ],katılım miktarı [" + this.form1_0.textBox_103.Text + " " + this.form1_0.string_21 + "]. Başarılar");
                awaiter1 = Task.Delay(10000).GetAwaiter();
                if (!awaiter1.IsCompleted)
                {
                  num2 = 0;
                  this.int_0 = 0;
                  this.taskAwaiter_0 = awaiter1;
                  Form1.Class64 stateMachine = this;
                  this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class64>(ref awaiter1, ref stateMachine);
                  return;
                }
                break;
              }
              Class73.smethod_27(this.form1_0);
              goto label_99;
          }
          awaiter1.GetResult();
          awaiter1 = new TaskAwaiter();
          Class73.smethod_161(Class25.class19_0, "[PIYANGO] etkinliğine katılımlar başlamıştır. Katılım 5 dakika sürecek ve toplanan tüm ikramiye kazanan 1 talihliye verilecektir.");
          this.form1_0.checkBox_28.Checked = true;
          awaiter2 = Task.Delay(10000).GetAwaiter();
          if (!awaiter2.IsCompleted)
          {
            num2 = 1;
            this.int_0 = 1;
            this.taskAwaiter_0 = awaiter2;
            Form1.Class64 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class64>(ref awaiter2, ref stateMachine);
            return;
          }
label_19:
          awaiter2.GetResult();
          awaiter2 = new TaskAwaiter();
          Class73.smethod_161(Class25.class19_0, "Çekilişe katılmak için [" + this.form1_0.textEdit_18.Text + "] isimli karaktere [MP] yazınız.");
          awaiter3 = Task.Delay(170000).GetAwaiter();
          if (!awaiter3.IsCompleted)
          {
            num2 = 2;
            this.int_0 = 2;
            this.taskAwaiter_0 = awaiter3;
            Form1.Class64 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class64>(ref awaiter3, ref stateMachine);
            return;
          }
label_22:
          awaiter3.GetResult();
          awaiter3 = new TaskAwaiter();
          this.int_1 = 0;
label_23:
          try
          {
            this.sqlDataReader_0 = new SqlCommand("exec My_EventBot..__Pıyango 'Toplam','toplamıgetir','farketmez',0", Class65.sqlConnection_0).ExecuteReader();
            this.sqlDataReader_0.Read();
            Class73.smethod_161(Class25.class19_0, "[PIYANGO] etkinliğine katılım için son 2 dakika. Şuana kadar toplanan ikramiye [ " + this.sqlDataReader_0[1].ToString() + " " + this.form1_0.string_21 + " ] ");
            this.sqlDataReader_0 = (SqlDataReader) null;
          }
          catch (Exception ex)
          {
            this.exception_0 = ex;
            *(int*) voidPtr = this.int_1;
            this.int_1 = *(int*) voidPtr + 1;
            Form1.smethod_0("ilk 2 dk toplanan miktar veritabanından çekilirken hata olustu. Tekrar deneniyor. HATA => " + this.exception_0.Message);
            *(sbyte*) ((IntPtr) voidPtr + 7) = (sbyte) (this.int_1 < 3);
            if (*(sbyte*) ((IntPtr) voidPtr + 7) != (sbyte) 0)
              goto label_23;
          }
          awaiter4 = Task.Delay(120000).GetAwaiter();
          if (!awaiter4.IsCompleted)
          {
            num2 = 3;
            this.int_0 = 3;
            this.taskAwaiter_0 = awaiter4;
            Form1.Class64 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class64>(ref awaiter4, ref stateMachine);
            return;
          }
label_28:
          awaiter4.GetResult();
          awaiter4 = new TaskAwaiter();
          this.int_2 = 0;
label_29:
          try
          {
            this.sqlDataReader_1 = new SqlCommand("exec My_EventBot..__Pıyango 'Toplam','toplamıgetir','farketmez',0", Class65.sqlConnection_0).ExecuteReader();
            this.sqlDataReader_1.Read();
            Form1.long_0 = Convert.ToInt64(this.sqlDataReader_1[1].ToString());
            Class73.smethod_161(Class25.class19_0, "[PIYANGO] etkinliğine katılım sona erdi. Toplam katılımcı [" + this.sqlDataReader_1[0].ToString() + "], toplanan ikramiye [ " + this.sqlDataReader_1[1].ToString() + " " + this.form1_0.string_21 + " ]. Çekiliş başlıyor. ");
            Form1.form1_0.checkBox_28.Checked = false;
            Form1.form1_0.checkBox_27.Checked = false;
            this.sqlDataReader_1 = (SqlDataReader) null;
          }
          catch (Exception ex)
          {
            this.exception_1 = ex;
            *(int*) voidPtr = this.int_2;
            this.int_2 = *(int*) voidPtr + 1;
            Form1.smethod_0("ikinci 2 dk toplanan miktar veritabanından çekilirken hata olustu. Tekrar deneniyor. HATA => " + this.exception_1.Message);
            *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) (this.int_2 < 3);
            if (*(sbyte*) ((IntPtr) voidPtr + 8) != (sbyte) 0)
              goto label_29;
          }
          Class73.smethod_83(Class25.class19_0, 7408.0, 88.0);
          awaiter5 = Task.Delay(5000).GetAwaiter();
          if (!awaiter5.IsCompleted)
          {
            num2 = 4;
            this.int_0 = 4;
            this.taskAwaiter_0 = awaiter5;
            Form1.Class64 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class64>(ref awaiter5, ref stateMachine);
            return;
          }
label_34:
          awaiter5.GetResult();
          awaiter5 = new TaskAwaiter();
          Class73.smethod_241(Class25.class19_0);
          this.enumerator_0 = Form1.list_1.ToList<string>().GetEnumerator();
          goto label_35;
label_49:
          awaiter6.GetResult();
          awaiter6 = new TaskAwaiter();
label_50:
          Class73.smethod_218(Class25.class19_0, "Hoşgeldiniz arkadaşlar.Çekilişimiz birazdan başlayacaktır.Çekilişten önce event hakkında biraz bilgilenelim.. ");
          awaiter7 = Task.Delay(7000).GetAwaiter();
          if (!awaiter7.IsCompleted)
          {
            num2 = 7;
            this.int_0 = 7;
            this.taskAwaiter_0 = awaiter7;
            Form1.Class64 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class64>(ref awaiter7, ref stateMachine);
            return;
          }
label_53:
          awaiter7.GetResult();
          awaiter7 = new TaskAwaiter();
          Class73.smethod_218(Class25.class19_0, "1- Event tamamen program tarafından yapılır.Event sırasında GM dahil hiçbir yetkili veya 3. şahıs sonuçlara müdahale edemez.");
          awaiter8 = Task.Delay(7000).GetAwaiter();
          if (!awaiter8.IsCompleted)
          {
            num2 = 8;
            this.int_0 = 8;
            this.taskAwaiter_0 = awaiter8;
            Form1.Class64 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class64>(ref awaiter8, ref stateMachine);
            return;
          }
label_56:
          awaiter8.GetResult();
          awaiter8 = new TaskAwaiter();
          Class73.smethod_218(Class25.class19_0, "2- 1. madde de belirtildiği gibi herşeyi sistem yapar bu yüzden event sonucuna kimsenin itiraz hakkı bulunmaz.");
          awaiter9 = Task.Delay(7000).GetAwaiter();
          if (!awaiter9.IsCompleted)
          {
            num2 = 9;
            this.int_0 = 9;
            this.taskAwaiter_0 = awaiter9;
            Form1.Class64 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class64>(ref awaiter9, ref stateMachine);
            return;
          }
label_59:
          awaiter9.GetResult();
          awaiter9 = new TaskAwaiter();
          Class73.smethod_218(Class25.class19_0, "3- Toplanan tüm ikramiye 1 talihliye verilir ve yedek talihliye gerek duyulmaz.");
          awaiter10 = Task.Delay(7000).GetAwaiter();
          if (!awaiter10.IsCompleted)
          {
            num2 = 10;
            this.int_0 = 10;
            this.taskAwaiter_0 = awaiter10;
            Form1.Class64 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class64>(ref awaiter10, ref stateMachine);
            return;
          }
label_62:
          awaiter10.GetResult();
          awaiter10 = new TaskAwaiter();
          Class73.smethod_218(Class25.class19_0, "4- Kazanan kişiye ikramiye sistem tarafından verildiği için ikramiyeyi alamama gibi bir sorun oluşmaz.");
          awaiter11 = Task.Delay(7000).GetAwaiter();
          if (!awaiter11.IsCompleted)
          {
            num2 = 11;
            this.int_0 = 11;
            this.taskAwaiter_0 = awaiter11;
            Form1.Class64 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class64>(ref awaiter11, ref stateMachine);
            return;
          }
label_65:
          awaiter11.GetResult();
          awaiter11 = new TaskAwaiter();
          Class73.smethod_218(Class25.class19_0, "Hadi başlayalım. Herkese başarılar.");
          awaiter12 = Task.Delay(7000).GetAwaiter();
          if (!awaiter12.IsCompleted)
          {
            num2 = 12;
            this.int_0 = 12;
            this.taskAwaiter_0 = awaiter12;
            Form1.Class64 stateMachine = this;
            this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class64>(ref awaiter12, ref stateMachine);
            return;
          }
label_68:
          awaiter12.GetResult();
          awaiter12 = new TaskAwaiter();
          *(sbyte*) ((IntPtr) voidPtr + 10) = (sbyte) (this.form1_0.listBox_23.Items.Count <= 50);
          if (*(sbyte*) ((IntPtr) voidPtr + 10) != (sbyte) 0)
          {
            this.form1_0.int_14 = this.form1_0.listBox_23.Items.Count * 3;
          }
          else
          {
            *(sbyte*) ((IntPtr) voidPtr + 11) = (sbyte) (this.form1_0.listBox_23.Items.Count > 50);
            if (*(sbyte*) ((IntPtr) voidPtr + 11) != (sbyte) 0)
            {
              this.form1_0.int_14 = this.form1_0.listBox_23.Items.Count * 2;
            }
            else
            {
              *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) (this.form1_0.listBox_23.Items.Count >= 100);
              if (*(sbyte*) ((IntPtr) voidPtr + 12) != (sbyte) 0)
                this.form1_0.int_14 = this.form1_0.listBox_23.Items.Count * 2;
            }
          }
          this.form1_0.listBox_23.Enabled = false;
          goto label_95;
label_91:
          awaiter13.GetResult();
          awaiter13 = new TaskAwaiter();
          ++this.form1_0.int_16;
          this.form1_0.int_15 = this.form1_0.random_1.Next(0, this.form1_0.listBox_23.Items.Count);
          this.form1_0.listBox_23.SelectedIndex = this.form1_0.int_15;
          Class73.smethod_218(Class25.class19_0, this.form1_0.listBox_23.SelectedItem.ToString());
          *(sbyte*) ((IntPtr) voidPtr + 13) = (sbyte) (this.form1_0.int_16 == this.form1_0.int_14);
          if (*(sbyte*) ((IntPtr) voidPtr + 13) != (sbyte) 0)
          {
            this.form1_0.string_22 = this.form1_0.listBox_23.SelectedItem.ToString();
            Class73.smethod_161(Class25.class19_0, "[PIYANGO] çekilişi sonuçlandı. Kazanan talihli  [ " + this.form1_0.string_22 + " ]. Kazandığı ikramiye [" + (object) Form1.long_0 + " " + this.form1_0.string_21 + "]. Tebrikler.");
            awaiter14 = Task.Delay(1000).GetAwaiter();
            if (!awaiter14.IsCompleted)
            {
              num2 = 14;
              this.int_0 = 14;
              this.taskAwaiter_0 = awaiter14;
              Form1.Class64 stateMachine = this;
              this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class64>(ref awaiter14, ref stateMachine);
              return;
            }
          }
          else
            goto label_95;
label_93:
          awaiter14.GetResult();
          awaiter14 = new TaskAwaiter();
          this.form1_0.listBox_23.Items.Clear();
          Form1.list_1.Clear();
          this.form1_0.checkBox_27.Checked = false;
          this.form1_0.checkBox_28.Checked = false;
          this.form1_0.int_14 = 0;
          this.form1_0.int_16 = 0;
          this.form1_0.listBox_23.Enabled = true;
          this.form1_0.comboBoxEdit_13.Enabled = true;
          this.form1_0.textBox_103.Enabled = true;
label_94:
          this.int_3 = 0;
          goto label_77;
label_95:
          *(sbyte*) ((IntPtr) voidPtr + 16) = (sbyte) (this.form1_0.int_16 != this.form1_0.int_14);
          if (*(sbyte*) ((IntPtr) voidPtr + 16) != (sbyte) 0)
          {
            awaiter13 = Task.Delay(250).GetAwaiter();
            if (!awaiter13.IsCompleted)
            {
              num2 = 13;
              this.int_0 = 13;
              this.taskAwaiter_0 = awaiter13;
              Form1.Class64 stateMachine = this;
              this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Form1.Class64>(ref awaiter13, ref stateMachine);
              return;
            }
            goto label_91;
          }
        }
        catch (Exception ex)
        {
          this.int_0 = -2;
          this.asyncVoidMethodBuilder_0.SetException(ex);
          return;
        }
label_99:
        this.int_0 = -2;
        this.asyncVoidMethodBuilder_0.SetResult();
      }

      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }
  }
}
