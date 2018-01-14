
// This file has been generated by the GUI designer. Do not modify.
namespace Zyrenth.ZoraGen.GtkUI
{
	public partial class MainWindow
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action FileAction;

		private global::Gtk.Action newAction;

		private global::Gtk.Action openAction;

		private global::Gtk.Action saveAction;

		private global::Gtk.Action saveAsAction;

		private global::Gtk.Action quitAction;

		private global::Gtk.Action SecretsAction;

		private global::Gtk.Action LoadGameSecretAction;

		private global::Gtk.Action LoadRingSecretAction;

		private global::Gtk.Action Action;

		private global::Gtk.Action GenerateSecretsAction;

		private global::Gtk.Action HelpAction;

		private global::Gtk.Action aboutAction;

		private global::Gtk.Action CheckForUpdatesAction;

		private global::Gtk.Action ImportBatteryAction;

		private global::Gtk.Action importBatteryAction;

		private global::Gtk.VBox vbox1;

		private global::Gtk.MenuBar menubar1;

		private global::Gtk.HBox hbox4;

		private global::Gtk.VBox vbox2;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Frame frmGameType;

		private global::Gtk.Alignment GtkAlignment;

		private global::Gtk.Table table1;

		private global::Gtk.Image image1;

		private global::Gtk.Image image2;

		private global::Gtk.RadioButton rdoAges;

		private global::Gtk.RadioButton rdoSeasons;

		private global::Gtk.Label GtkLabel6;

		private global::Gtk.Frame frame2;

		private global::Gtk.Alignment GtkAlignment1;

		private global::Gtk.Table table2;

		private global::Gtk.CheckButton chkHeros;

		private global::Gtk.CheckButton chkLinked;

		private global::Gtk.Image image3;

		private global::Gtk.Label GtkLabel9;

		private global::Gtk.Frame frame1;

		private global::Gtk.Alignment GtkAlignment2;

		private global::Gtk.Table table4;

		private global::Gtk.RadioButton rdoJP;

		private global::Gtk.RadioButton rdoUS;

		private global::Gtk.Label GtkLabel12;

		private global::Gtk.Table table3;

		private global::Gtk.ComboBox cmbAnimal;

		private global::Gtk.Image imgAnimal;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.Label label6;

		private global::Gtk.SpinButton spinBehavior;

		private global::Gtk.SpinButton spinID;

		private global::Gtk.Entry txtChild;

		private global::Gtk.Entry txtHero;

		private global::Gtk.VBox vbox3;

		private global::Gtk.VBox vbox4;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Button btnAllRings;

		private global::Gtk.Button btnNoRings;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.NodeView nvRings;

		private global::Gtk.CheckButton chkFreeRingGiven;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Zyrenth.ZoraGen.GtkUI.MainWindow
			this.UIManager = new global::Gtk.UIManager();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
			this.FileAction = new global::Gtk.Action("FileAction", global::Mono.Unix.Catalog.GetString("File"), null, null);
			this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString("File");
			w1.Add(this.FileAction, null);
			this.newAction = new global::Gtk.Action("newAction", global::Mono.Unix.Catalog.GetString("_New"), null, "gtk-new");
			this.newAction.ShortLabel = global::Mono.Unix.Catalog.GetString("New");
			w1.Add(this.newAction, null);
			this.openAction = new global::Gtk.Action("openAction", global::Mono.Unix.Catalog.GetString("_Open"), null, "gtk-open");
			this.openAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Open");
			w1.Add(this.openAction, null);
			this.saveAction = new global::Gtk.Action("saveAction", global::Mono.Unix.Catalog.GetString("_Save"), null, "gtk-save");
			this.saveAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Save");
			w1.Add(this.saveAction, null);
			this.saveAsAction = new global::Gtk.Action("saveAsAction", global::Mono.Unix.Catalog.GetString("Save As"), null, "gtk-save-as");
			this.saveAsAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Save As");
			w1.Add(this.saveAsAction, null);
			this.quitAction = new global::Gtk.Action("quitAction", global::Mono.Unix.Catalog.GetString("_Quit"), null, "gtk-quit");
			this.quitAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Quit");
			w1.Add(this.quitAction, null);
			this.SecretsAction = new global::Gtk.Action("SecretsAction", global::Mono.Unix.Catalog.GetString("Secrets"), null, null);
			this.SecretsAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Secrets");
			w1.Add(this.SecretsAction, null);
			this.LoadGameSecretAction = new global::Gtk.Action("LoadGameSecretAction", global::Mono.Unix.Catalog.GetString("Load Game Secret"), null, null);
			this.LoadGameSecretAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Load Game Secret");
			w1.Add(this.LoadGameSecretAction, null);
			this.LoadRingSecretAction = new global::Gtk.Action("LoadRingSecretAction", global::Mono.Unix.Catalog.GetString("Load Ring Secret"), null, null);
			this.LoadRingSecretAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Load Ring Secret");
			w1.Add(this.LoadRingSecretAction, null);
			this.Action = new global::Gtk.Action("Action", global::Mono.Unix.Catalog.GetString("---"), null, null);
			this.Action.ShortLabel = global::Mono.Unix.Catalog.GetString("---");
			w1.Add(this.Action, null);
			this.GenerateSecretsAction = new global::Gtk.Action("GenerateSecretsAction", global::Mono.Unix.Catalog.GetString("Generate Secrets"), null, null);
			this.GenerateSecretsAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Generate Secrets");
			w1.Add(this.GenerateSecretsAction, null);
			this.HelpAction = new global::Gtk.Action("HelpAction", global::Mono.Unix.Catalog.GetString("Help"), null, null);
			this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Help");
			w1.Add(this.HelpAction, null);
			this.aboutAction = new global::Gtk.Action("aboutAction", global::Mono.Unix.Catalog.GetString("About"), null, "gtk-about");
			this.aboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString("About");
			w1.Add(this.aboutAction, null);
			this.CheckForUpdatesAction = new global::Gtk.Action("CheckForUpdatesAction", global::Mono.Unix.Catalog.GetString("Check for Updates"), null, null);
			this.CheckForUpdatesAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Check for Updates");
			w1.Add(this.CheckForUpdatesAction, null);
			this.ImportBatteryAction = new global::Gtk.Action("ImportBatteryAction", global::Mono.Unix.Catalog.GetString("Import Battery"), null, null);
			this.ImportBatteryAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Import Battery");
			w1.Add(this.ImportBatteryAction, null);
			this.importBatteryAction = new global::Gtk.Action("importBatteryAction", global::Mono.Unix.Catalog.GetString("Import Battery"), global::Mono.Unix.Catalog.GetString("Imports a VBA battery file"), null);
			this.importBatteryAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Import Battery");
			w1.Add(this.importBatteryAction, null);
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Name = "Zyrenth.ZoraGen.GtkUI.MainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("ZoraGen - Zelda Oracles Password Generator");
			this.Icon = global::Gdk.Pixbuf.LoadFromResource("Zyrenth.ZoraGen.GtkUI.Farore.ico");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Resizable = false;
			// Container child Zyrenth.ZoraGen.GtkUI.MainWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			// Container child vbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString("<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='newAction' action='newAction'/><menuitem name='openAction' action='openAction'/><menuitem name='saveAction' action='saveAction'/><menuitem name='saveAsAction' action='saveAsAction'/><separator/><menuitem name='importBatteryAction' action='importBatteryAction'/><separator/><menuitem name='quitAction' action='quitAction'/></menu><menu name='SecretsAction' action='SecretsAction'><menuitem name='LoadGameSecretAction' action='LoadGameSecretAction'/><menuitem name='LoadRingSecretAction' action='LoadRingSecretAction'/><separator/><menuitem name='GenerateSecretsAction' action='GenerateSecretsAction'/></menu><menu name='HelpAction' action='HelpAction'><menuitem name='aboutAction' action='aboutAction'/><menuitem name='CheckForUpdatesAction' action='CheckForUpdatesAction'/></menu></menubar></ui>");
			this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
			this.menubar1.Name = "menubar1";
			this.vbox1.Add(this.menubar1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.menubar1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			this.hbox4.BorderWidth = ((uint)(10));
			// Container child hbox4.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.frmGameType = new global::Gtk.Frame();
			this.frmGameType.WidthRequest = 0;
			this.frmGameType.HeightRequest = 0;
			this.frmGameType.Name = "frmGameType";
			// Container child frmGameType.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table(((uint)(2)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.BorderWidth = ((uint)(3));
			// Container child table1.Gtk.Table+TableChild
			this.image1 = new global::Gtk.Image();
			this.image1.Name = "image1";
			this.image1.Pixbuf = global::Gdk.Pixbuf.LoadFromResource("Zyrenth.ZoraGen.GtkUI.Images.Characters.Nayru.gif");
			this.table1.Add(this.image1);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.image1]));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.image2 = new global::Gtk.Image();
			this.image2.Name = "image2";
			this.image2.Pixbuf = global::Gdk.Pixbuf.LoadFromResource("Zyrenth.ZoraGen.GtkUI.Images.Characters.Din.gif");
			this.table1.Add(this.image2);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.image2]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.rdoAges = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Ages"));
			this.rdoAges.CanFocus = true;
			this.rdoAges.Name = "rdoAges";
			this.rdoAges.DrawIndicator = true;
			this.rdoAges.UseUnderline = true;
			this.rdoAges.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.table1.Add(this.rdoAges);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.rdoAges]));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.rdoSeasons = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Seasons"));
			this.rdoSeasons.CanFocus = true;
			this.rdoSeasons.Name = "rdoSeasons";
			this.rdoSeasons.DrawIndicator = true;
			this.rdoSeasons.UseUnderline = true;
			this.rdoSeasons.Group = this.rdoAges.Group;
			this.table1.Add(this.rdoSeasons);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.rdoSeasons]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment.Add(this.table1);
			this.frmGameType.Add(this.GtkAlignment);
			this.GtkLabel6 = new global::Gtk.Label();
			this.GtkLabel6.Name = "GtkLabel6";
			this.GtkLabel6.LabelProp = global::Mono.Unix.Catalog.GetString("Secret For...");
			this.GtkLabel6.UseMarkup = true;
			this.frmGameType.LabelWidget = this.GtkLabel6;
			this.hbox1.Add(this.frmGameType);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.frmGameType]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.frame2 = new global::Gtk.Frame();
			this.frame2.Name = "frame2";
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.table2 = new global::Gtk.Table(((uint)(2)), ((uint)(2)), false);
			this.table2.Name = "table2";
			this.table2.BorderWidth = ((uint)(3));
			// Container child table2.Gtk.Table+TableChild
			this.chkHeros = new global::Gtk.CheckButton();
			this.chkHeros.CanFocus = true;
			this.chkHeros.Name = "chkHeros";
			this.chkHeros.Label = global::Mono.Unix.Catalog.GetString("Hero's Quest");
			this.chkHeros.DrawIndicator = true;
			this.chkHeros.UseUnderline = true;
			this.table2.Add(this.chkHeros);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table2[this.chkHeros]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.chkLinked = new global::Gtk.CheckButton();
			this.chkLinked.CanFocus = true;
			this.chkLinked.Name = "chkLinked";
			this.chkLinked.Label = global::Mono.Unix.Catalog.GetString("Linked Game");
			this.chkLinked.DrawIndicator = true;
			this.chkLinked.UseUnderline = true;
			this.table2.Add(this.chkLinked);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table2[this.chkLinked]));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.image3 = new global::Gtk.Image();
			this.image3.Name = "image3";
			this.image3.Pixbuf = global::Gdk.Pixbuf.LoadFromResource("Zyrenth.ZoraGen.GtkUI.Images.Triforce.png");
			this.table2.Add(this.image3);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table2[this.image3]));
			w12.TopAttach = ((uint)(1));
			w12.BottomAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment1.Add(this.table2);
			this.frame2.Add(this.GtkAlignment1);
			this.GtkLabel9 = new global::Gtk.Label();
			this.GtkLabel9.Name = "GtkLabel9";
			this.GtkLabel9.LabelProp = global::Mono.Unix.Catalog.GetString("Game Type");
			this.GtkLabel9.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel9;
			this.hbox1.Add(this.frame2);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.frame2]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(2));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.table4 = new global::Gtk.Table(((uint)(2)), ((uint)(1)), false);
			this.table4.Name = "table4";
			this.table4.ColumnSpacing = ((uint)(6));
			// Container child table4.Gtk.Table+TableChild
			this.rdoJP = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("JP"));
			this.rdoJP.CanFocus = true;
			this.rdoJP.Name = "rdoJP";
			this.rdoJP.DrawIndicator = true;
			this.rdoJP.UseUnderline = true;
			this.rdoJP.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.table4.Add(this.rdoJP);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table4[this.rdoJP]));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.rdoUS = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("US/PAL"));
			this.rdoUS.CanFocus = true;
			this.rdoUS.Name = "rdoUS";
			this.rdoUS.DrawIndicator = true;
			this.rdoUS.UseUnderline = true;
			this.rdoUS.Group = this.rdoJP.Group;
			this.table4.Add(this.rdoUS);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table4[this.rdoUS]));
			w17.TopAttach = ((uint)(1));
			w17.BottomAttach = ((uint)(2));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment2.Add(this.table4);
			this.frame1.Add(this.GtkAlignment2);
			this.GtkLabel12 = new global::Gtk.Label();
			this.GtkLabel12.Name = "GtkLabel12";
			this.GtkLabel12.LabelProp = global::Mono.Unix.Catalog.GetString("Region");
			this.GtkLabel12.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel12;
			this.hbox1.Add(this.frame1);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.frame1]));
			w20.PackType = ((global::Gtk.PackType)(1));
			w20.Position = 2;
			w20.Expand = false;
			w20.Fill = false;
			this.vbox2.Add(this.hbox1);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.table3 = new global::Gtk.Table(((uint)(3)), ((uint)(4)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.cmbAnimal = global::Gtk.ComboBox.NewText();
			this.cmbAnimal.AppendText(global::Mono.Unix.Catalog.GetString("None"));
			this.cmbAnimal.AppendText(global::Mono.Unix.Catalog.GetString("Ricky"));
			this.cmbAnimal.AppendText(global::Mono.Unix.Catalog.GetString("Dimitri"));
			this.cmbAnimal.AppendText(global::Mono.Unix.Catalog.GetString("Moosh"));
			this.cmbAnimal.Name = "cmbAnimal";
			this.cmbAnimal.Active = 0;
			this.table3.Add(this.cmbAnimal);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table3[this.cmbAnimal]));
			w22.TopAttach = ((uint)(2));
			w22.BottomAttach = ((uint)(3));
			w22.LeftAttach = ((uint)(1));
			w22.RightAttach = ((uint)(2));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child table3.Gtk.Table+TableChild
			this.imgAnimal = new global::Gtk.Image();
			this.imgAnimal.Name = "imgAnimal";
			this.table3.Add(this.imgAnimal);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table3[this.imgAnimal]));
			w23.TopAttach = ((uint)(2));
			w23.BottomAttach = ((uint)(3));
			w23.LeftAttach = ((uint)(2));
			w23.RightAttach = ((uint)(3));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.Xalign = 0F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("ID");
			this.table3.Add(this.label2);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table3[this.label2]));
			w24.TopAttach = ((uint)(1));
			w24.BottomAttach = ((uint)(2));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Hero");
			this.table3.Add(this.label3);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table3[this.label3]));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Child");
			this.table3.Add(this.label4);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table3[this.label4]));
			w26.LeftAttach = ((uint)(2));
			w26.RightAttach = ((uint)(3));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.Xalign = 0F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Behavior");
			this.table3.Add(this.label5);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table3[this.label5]));
			w27.TopAttach = ((uint)(1));
			w27.BottomAttach = ((uint)(2));
			w27.LeftAttach = ((uint)(2));
			w27.RightAttach = ((uint)(3));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.Xalign = 0F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Animal");
			this.table3.Add(this.label6);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table3[this.label6]));
			w28.TopAttach = ((uint)(2));
			w28.BottomAttach = ((uint)(3));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.spinBehavior = new global::Gtk.SpinButton(0, 63, 1);
			this.spinBehavior.CanFocus = true;
			this.spinBehavior.Name = "spinBehavior";
			this.spinBehavior.Adjustment.PageIncrement = 10;
			this.spinBehavior.ClimbRate = 1;
			this.spinBehavior.Numeric = true;
			this.table3.Add(this.spinBehavior);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table3[this.spinBehavior]));
			w29.TopAttach = ((uint)(1));
			w29.BottomAttach = ((uint)(2));
			w29.LeftAttach = ((uint)(3));
			w29.RightAttach = ((uint)(4));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.spinID = new global::Gtk.SpinButton(0, 32767, 1);
			this.spinID.CanFocus = true;
			this.spinID.Name = "spinID";
			this.spinID.Adjustment.PageIncrement = 10;
			this.spinID.ClimbRate = 1;
			this.spinID.Numeric = true;
			this.table3.Add(this.spinID);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table3[this.spinID]));
			w30.TopAttach = ((uint)(1));
			w30.BottomAttach = ((uint)(2));
			w30.LeftAttach = ((uint)(1));
			w30.RightAttach = ((uint)(2));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.txtChild = new global::Gtk.Entry();
			this.txtChild.WidthRequest = 70;
			this.txtChild.CanFocus = true;
			this.txtChild.Name = "txtChild";
			this.txtChild.IsEditable = true;
			this.txtChild.MaxLength = 5;
			this.txtChild.InvisibleChar = '●';
			this.table3.Add(this.txtChild);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table3[this.txtChild]));
			w31.LeftAttach = ((uint)(3));
			w31.RightAttach = ((uint)(4));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.txtHero = new global::Gtk.Entry();
			this.txtHero.WidthRequest = 70;
			this.txtHero.CanFocus = true;
			this.txtHero.Name = "txtHero";
			this.txtHero.IsEditable = true;
			this.txtHero.MaxLength = 5;
			this.txtHero.InvisibleChar = '●';
			this.table3.Add(this.txtHero);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table3[this.txtHero]));
			w32.LeftAttach = ((uint)(1));
			w32.RightAttach = ((uint)(2));
			w32.XOptions = ((global::Gtk.AttachOptions)(4));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox2.Add(this.table3);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.table3]));
			w33.Position = 1;
			w33.Expand = false;
			w33.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			this.vbox2.Add(this.vbox3);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.vbox3]));
			w34.Position = 2;
			this.hbox4.Add(this.vbox2);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vbox2]));
			w35.Position = 0;
			w35.Expand = false;
			w35.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.btnAllRings = new global::Gtk.Button();
			this.btnAllRings.CanFocus = true;
			this.btnAllRings.Name = "btnAllRings";
			this.btnAllRings.UseUnderline = true;
			this.btnAllRings.Label = global::Mono.Unix.Catalog.GetString("All Rings");
			this.hbox2.Add(this.btnAllRings);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.btnAllRings]));
			w36.Position = 0;
			w36.Expand = false;
			w36.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.btnNoRings = new global::Gtk.Button();
			this.btnNoRings.CanFocus = true;
			this.btnNoRings.Name = "btnNoRings";
			this.btnNoRings.UseUnderline = true;
			this.btnNoRings.Label = global::Mono.Unix.Catalog.GetString("None");
			this.hbox2.Add(this.btnNoRings);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.btnNoRings]));
			w37.Position = 1;
			w37.Expand = false;
			w37.Fill = false;
			this.vbox4.Add(this.hbox2);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox2]));
			w38.Position = 0;
			w38.Expand = false;
			w38.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.WidthRequest = 170;
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.nvRings = new global::Gtk.NodeView();
			this.nvRings.CanFocus = true;
			this.nvRings.Name = "nvRings";
			this.nvRings.HeadersVisible = false;
			this.GtkScrolledWindow.Add(this.nvRings);
			this.vbox4.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.GtkScrolledWindow]));
			w40.Position = 1;
			// Container child vbox4.Gtk.Box+BoxChild
			this.chkFreeRingGiven = new global::Gtk.CheckButton();
			this.chkFreeRingGiven.TooltipMarkup = "Whether or not Vasu has given the player the free Friendship Ring";
			this.chkFreeRingGiven.CanFocus = true;
			this.chkFreeRingGiven.Name = "chkFreeRingGiven";
			this.chkFreeRingGiven.Label = global::Mono.Unix.Catalog.GetString("Free Ring Given");
			this.chkFreeRingGiven.DrawIndicator = true;
			this.chkFreeRingGiven.UseUnderline = true;
			this.vbox4.Add(this.chkFreeRingGiven);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.chkFreeRingGiven]));
			w41.Position = 2;
			w41.Expand = false;
			w41.Fill = false;
			this.hbox4.Add(this.vbox4);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vbox4]));
			w42.Position = 1;
			this.vbox1.Add(this.hbox4);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox4]));
			w43.Position = 1;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 564;
			this.DefaultHeight = 285;
			this.Show();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
			this.newAction.Activated += new global::System.EventHandler(this.OnNew);
			this.openAction.Activated += new global::System.EventHandler(this.OnOpen);
			this.saveAction.Activated += new global::System.EventHandler(this.OnSave);
			this.saveAsAction.Activated += new global::System.EventHandler(this.OnSaveAs);
			this.quitAction.Activated += new global::System.EventHandler(this.OnQuit);
			this.LoadGameSecretAction.Activated += new global::System.EventHandler(this.OnLoadGameSecret);
			this.LoadRingSecretAction.Activated += new global::System.EventHandler(this.OnLoadRingSecret);
			this.GenerateSecretsAction.Activated += new global::System.EventHandler(this.OnGenerateSecrets);
			this.aboutAction.Activated += new global::System.EventHandler(this.OnAbout);
			this.CheckForUpdatesAction.Activated += new global::System.EventHandler(this.OnCheckForUpdatesActionActivated);
			this.importBatteryAction.Activated += new global::System.EventHandler(this.OnImportBattery);
			this.chkLinked.Toggled += new global::System.EventHandler(this.OnChkLinkedToggled);
			this.chkHeros.Toggled += new global::System.EventHandler(this.OnChkHerosToggled);
			this.txtHero.Changed += new global::System.EventHandler(this.OnTxtHeroChanged);
			this.txtChild.Changed += new global::System.EventHandler(this.OnTxtChildChanged);
			this.spinID.Changed += new global::System.EventHandler(this.OnSpinIDChanged);
			this.spinBehavior.Changed += new global::System.EventHandler(this.OnCmbBehaviorChanged);
			this.cmbAnimal.Changed += new global::System.EventHandler(this.OnCmbAnimalChanged);
			this.btnAllRings.Clicked += new global::System.EventHandler(this.OnBtnAllRingsClicked);
			this.btnNoRings.Clicked += new global::System.EventHandler(this.OnBtnNoRingsClicked);
		}
	}
}
