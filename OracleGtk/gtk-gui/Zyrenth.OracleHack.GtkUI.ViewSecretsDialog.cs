
// This file has been generated by the GUI designer. Do not modify.
namespace Zyrenth.OracleHack.GtkUI
{
	public partial class ViewSecretsDialog
	{
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.Label label1;
		
		private global::Zyrenth.OracleHack.GtkUI.LargeSecretWidget swGame;
		
		private global::Gtk.Label label2;
		
		private global::Zyrenth.OracleHack.GtkUI.LargeSecretWidget swRings;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.Table table1;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.Label lblMem1;
		
		private global::Gtk.Label lblMem10;
		
		private global::Gtk.Label lblMem2;
		
		private global::Gtk.Label lblMem3;
		
		private global::Gtk.Label lblMem4;
		
		private global::Gtk.Label lblMem5;
		
		private global::Gtk.Label lblMem6;
		
		private global::Gtk.Label lblMem7;
		
		private global::Gtk.Label lblMem8;
		
		private global::Gtk.Label lblMem9;
		
		private global::Zyrenth.OracleHack.GtkUI.SmallSecretWidget swMem1;
		
		private global::Zyrenth.OracleHack.GtkUI.SmallSecretWidget swMem10;
		
		private global::Zyrenth.OracleHack.GtkUI.SmallSecretWidget swMem2;
		
		private global::Zyrenth.OracleHack.GtkUI.SmallSecretWidget swMem3;
		
		private global::Zyrenth.OracleHack.GtkUI.SmallSecretWidget swMem4;
		
		private global::Zyrenth.OracleHack.GtkUI.SmallSecretWidget swMem5;
		
		private global::Zyrenth.OracleHack.GtkUI.SmallSecretWidget swMem6;
		
		private global::Zyrenth.OracleHack.GtkUI.SmallSecretWidget swMem7;
		
		private global::Zyrenth.OracleHack.GtkUI.SmallSecretWidget swMem8;
		
		private global::Zyrenth.OracleHack.GtkUI.SmallSecretWidget swMem9;
		
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Zyrenth.OracleHack.GtkUI.ViewSecretsDialog
			this.Name = "Zyrenth.OracleHack.GtkUI.ViewSecretsDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Generate Secrets");
			this.Icon = global::Gdk.Pixbuf.LoadFromResource ("Zyrenth.OracleHack.GtkUI.Farore.ico");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.DestroyWithParent = true;
			// Internal child Zyrenth.OracleHack.GtkUI.ViewSecretsDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			this.hbox1.BorderWidth = ((uint)(8));
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Secret to start game:");
			this.vbox2.Add (this.label1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.swGame = new global::Zyrenth.OracleHack.GtkUI.LargeSecretWidget ();
			this.swGame.WidthRequest = 172;
			this.swGame.HeightRequest = 52;
			this.swGame.Events = ((global::Gdk.EventMask)(256));
			this.swGame.Name = "swGame";
			this.vbox2.Add (this.swGame);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.swGame]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 0F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Ring Secret:");
			this.vbox2.Add (this.label2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label2]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.swRings = new global::Zyrenth.OracleHack.GtkUI.LargeSecretWidget ();
			this.swRings.WidthRequest = 172;
			this.swRings.HeightRequest = 52;
			this.swRings.Events = ((global::Gdk.EventMask)(256));
			this.swRings.Name = "swRings";
			this.vbox2.Add (this.swRings);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.swRings]));
			w5.Position = 3;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.WidthRequest = 172;
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Memory secrets can only be used AFTER you find the corresponding person in the game.");
			this.label4.Wrap = true;
			this.vbox2.Add (this.label4);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label4]));
			w6.Position = 4;
			w6.Expand = false;
			w6.Fill = false;
			this.hbox1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox2]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(11)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(1));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Memories:");
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblMem1 = new global::Gtk.Label ();
			this.lblMem1.Name = "lblMem1";
			this.lblMem1.Xalign = 0F;
			this.lblMem1.LabelProp = global::Mono.Unix.Catalog.GetString ("label1");
			this.table1.Add (this.lblMem1);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.lblMem1]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblMem10 = new global::Gtk.Label ();
			this.lblMem10.Name = "lblMem10";
			this.lblMem10.Xalign = 0F;
			this.lblMem10.LabelProp = global::Mono.Unix.Catalog.GetString ("label10");
			this.table1.Add (this.lblMem10);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.lblMem10]));
			w10.TopAttach = ((uint)(10));
			w10.BottomAttach = ((uint)(11));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblMem2 = new global::Gtk.Label ();
			this.lblMem2.Name = "lblMem2";
			this.lblMem2.Xalign = 0F;
			this.lblMem2.LabelProp = global::Mono.Unix.Catalog.GetString ("label2");
			this.table1.Add (this.lblMem2);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.lblMem2]));
			w11.TopAttach = ((uint)(2));
			w11.BottomAttach = ((uint)(3));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblMem3 = new global::Gtk.Label ();
			this.lblMem3.Name = "lblMem3";
			this.lblMem3.Xalign = 0F;
			this.lblMem3.LabelProp = global::Mono.Unix.Catalog.GetString ("label3");
			this.table1.Add (this.lblMem3);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.lblMem3]));
			w12.TopAttach = ((uint)(3));
			w12.BottomAttach = ((uint)(4));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblMem4 = new global::Gtk.Label ();
			this.lblMem4.Name = "lblMem4";
			this.lblMem4.Xalign = 0F;
			this.lblMem4.LabelProp = global::Mono.Unix.Catalog.GetString ("label4");
			this.table1.Add (this.lblMem4);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1 [this.lblMem4]));
			w13.TopAttach = ((uint)(4));
			w13.BottomAttach = ((uint)(5));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblMem5 = new global::Gtk.Label ();
			this.lblMem5.Name = "lblMem5";
			this.lblMem5.Xalign = 0F;
			this.lblMem5.LabelProp = global::Mono.Unix.Catalog.GetString ("label5");
			this.table1.Add (this.lblMem5);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.lblMem5]));
			w14.TopAttach = ((uint)(5));
			w14.BottomAttach = ((uint)(6));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblMem6 = new global::Gtk.Label ();
			this.lblMem6.Name = "lblMem6";
			this.lblMem6.Xalign = 0F;
			this.lblMem6.LabelProp = global::Mono.Unix.Catalog.GetString ("label6");
			this.table1.Add (this.lblMem6);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1 [this.lblMem6]));
			w15.TopAttach = ((uint)(6));
			w15.BottomAttach = ((uint)(7));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblMem7 = new global::Gtk.Label ();
			this.lblMem7.Name = "lblMem7";
			this.lblMem7.Xalign = 0F;
			this.lblMem7.LabelProp = global::Mono.Unix.Catalog.GetString ("label7");
			this.table1.Add (this.lblMem7);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1 [this.lblMem7]));
			w16.TopAttach = ((uint)(7));
			w16.BottomAttach = ((uint)(8));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblMem8 = new global::Gtk.Label ();
			this.lblMem8.Name = "lblMem8";
			this.lblMem8.Xalign = 0F;
			this.lblMem8.LabelProp = global::Mono.Unix.Catalog.GetString ("label8");
			this.table1.Add (this.lblMem8);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1 [this.lblMem8]));
			w17.TopAttach = ((uint)(8));
			w17.BottomAttach = ((uint)(9));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblMem9 = new global::Gtk.Label ();
			this.lblMem9.Name = "lblMem9";
			this.lblMem9.Xalign = 0F;
			this.lblMem9.LabelProp = global::Mono.Unix.Catalog.GetString ("label9");
			this.table1.Add (this.lblMem9);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1 [this.lblMem9]));
			w18.TopAttach = ((uint)(9));
			w18.BottomAttach = ((uint)(10));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.swMem1 = new global::Zyrenth.OracleHack.GtkUI.SmallSecretWidget ();
			this.swMem1.Events = ((global::Gdk.EventMask)(256));
			this.swMem1.Name = "swMem1";
			this.table1.Add (this.swMem1);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1 [this.swMem1]));
			w19.TopAttach = ((uint)(1));
			w19.BottomAttach = ((uint)(2));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.swMem10 = new global::Zyrenth.OracleHack.GtkUI.SmallSecretWidget ();
			this.swMem10.Events = ((global::Gdk.EventMask)(256));
			this.swMem10.Name = "swMem10";
			this.table1.Add (this.swMem10);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1 [this.swMem10]));
			w20.TopAttach = ((uint)(10));
			w20.BottomAttach = ((uint)(11));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.swMem2 = new global::Zyrenth.OracleHack.GtkUI.SmallSecretWidget ();
			this.swMem2.Events = ((global::Gdk.EventMask)(256));
			this.swMem2.Name = "swMem2";
			this.table1.Add (this.swMem2);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1 [this.swMem2]));
			w21.TopAttach = ((uint)(2));
			w21.BottomAttach = ((uint)(3));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.swMem3 = new global::Zyrenth.OracleHack.GtkUI.SmallSecretWidget ();
			this.swMem3.Events = ((global::Gdk.EventMask)(256));
			this.swMem3.Name = "swMem3";
			this.table1.Add (this.swMem3);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1 [this.swMem3]));
			w22.TopAttach = ((uint)(3));
			w22.BottomAttach = ((uint)(4));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.swMem4 = new global::Zyrenth.OracleHack.GtkUI.SmallSecretWidget ();
			this.swMem4.Events = ((global::Gdk.EventMask)(256));
			this.swMem4.Name = "swMem4";
			this.table1.Add (this.swMem4);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table1 [this.swMem4]));
			w23.TopAttach = ((uint)(4));
			w23.BottomAttach = ((uint)(5));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.swMem5 = new global::Zyrenth.OracleHack.GtkUI.SmallSecretWidget ();
			this.swMem5.Events = ((global::Gdk.EventMask)(256));
			this.swMem5.Name = "swMem5";
			this.table1.Add (this.swMem5);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table1 [this.swMem5]));
			w24.TopAttach = ((uint)(5));
			w24.BottomAttach = ((uint)(6));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.swMem6 = new global::Zyrenth.OracleHack.GtkUI.SmallSecretWidget ();
			this.swMem6.Events = ((global::Gdk.EventMask)(256));
			this.swMem6.Name = "swMem6";
			this.table1.Add (this.swMem6);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table1 [this.swMem6]));
			w25.TopAttach = ((uint)(6));
			w25.BottomAttach = ((uint)(7));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.swMem7 = new global::Zyrenth.OracleHack.GtkUI.SmallSecretWidget ();
			this.swMem7.Events = ((global::Gdk.EventMask)(256));
			this.swMem7.Name = "swMem7";
			this.table1.Add (this.swMem7);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table1 [this.swMem7]));
			w26.TopAttach = ((uint)(7));
			w26.BottomAttach = ((uint)(8));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.swMem8 = new global::Zyrenth.OracleHack.GtkUI.SmallSecretWidget ();
			this.swMem8.Events = ((global::Gdk.EventMask)(256));
			this.swMem8.Name = "swMem8";
			this.table1.Add (this.swMem8);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table1 [this.swMem8]));
			w27.TopAttach = ((uint)(8));
			w27.BottomAttach = ((uint)(9));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.swMem9 = new global::Zyrenth.OracleHack.GtkUI.SmallSecretWidget ();
			this.swMem9.Events = ((global::Gdk.EventMask)(256));
			this.swMem9.Name = "swMem9";
			this.table1.Add (this.swMem9);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table1 [this.swMem9]));
			w28.TopAttach = ((uint)(9));
			w28.BottomAttach = ((uint)(10));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add (this.table1);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.table1]));
			w29.Position = 1;
			w29.Expand = false;
			w29.Fill = false;
			w1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(w1 [this.hbox1]));
			w30.Position = 0;
			w30.Expand = false;
			w30.Fill = false;
			// Internal child Zyrenth.OracleHack.GtkUI.ViewSecretsDialog.ActionArea
			global::Gtk.HButtonBox w31 = this.ActionArea;
			w31.Name = "dialog1_ActionArea";
			w31.Spacing = 10;
			w31.BorderWidth = ((uint)(5));
			w31.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w32 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w31 [this.buttonOk]));
			w32.Expand = false;
			w32.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 305;
			this.DefaultHeight = 286;
			this.Show ();
			this.buttonOk.Pressed += new global::System.EventHandler (this.OnButtonOkPressed);
		}
	}
}
