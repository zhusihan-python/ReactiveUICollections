namespace WinForms.Reactive.Client
{
	partial class ShellView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			var resources = new System.ComponentModel.ComponentResourceManager(typeof(ShellView));
			routedControlHost = new ReactiveUI.Winforms.RoutedControlHost();
			mnuMain = new MenuStrip();
			mnuMainFile = new ToolStripMenuItem();
			mnuFileClose = new ToolStripMenuItem();
			tsMain = new ToolStrip();
			btnMainItems = new ToolStripButton();
			btnMainItemsDD = new ToolStripButton();
			mnuMain.SuspendLayout();
			tsMain.SuspendLayout();
			SuspendLayout();
			// 
			// routedControlHost
			// 
			routedControlHost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			routedControlHost.DefaultContent = null;
			routedControlHost.Location = new Point(-4, 72);
			routedControlHost.Margin = new Padding(1, 1, 1, 1);
			routedControlHost.Name = "routedControlHost";
			routedControlHost.Router = null;
			routedControlHost.Size = new Size(669, 330);
			routedControlHost.TabIndex = 0;
			routedControlHost.ViewLocator = null;
			// 
			// mnuMain
			// 
			mnuMain.ImageScalingSize = new Size(40, 40);
			mnuMain.Items.AddRange(new ToolStripItem[] { mnuMainFile });
			mnuMain.Location = new Point(0, 0);
			mnuMain.Name = "mnuMain";
			mnuMain.Padding = new Padding(2, 1, 0, 1);
			mnuMain.Size = new Size(670, 24);
			mnuMain.TabIndex = 1;
			mnuMain.Text = "menuStrip1";
			// 
			// mnuMainFile
			// 
			mnuMainFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileClose });
			mnuMainFile.Name = "mnuMainFile";
			mnuMainFile.Size = new Size(39, 22);
			mnuMainFile.Text = "File";
			// 
			// mnuFileClose
			// 
			mnuFileClose.Name = "mnuFileClose";
			mnuFileClose.Size = new Size(108, 22);
			mnuFileClose.Text = "Close";
			// 
			// tsMain
			// 
			tsMain.ImageScalingSize = new Size(40, 40);
			tsMain.Items.AddRange(new ToolStripItem[] { btnMainItems, btnMainItemsDD });
			tsMain.Location = new Point(0, 24);
			tsMain.Name = "tsMain";
			tsMain.Padding = new Padding(0, 0, 0, 0);
			tsMain.Size = new Size(670, 47);
			tsMain.TabIndex = 2;
			// 
			// btnMainItems
			// 
			btnMainItems.DisplayStyle = ToolStripItemDisplayStyle.Image;
			btnMainItems.Image = (Image)resources.GetObject("btnMainItems.Image");
			btnMainItems.ImageTransparentColor = Color.Magenta;
			btnMainItems.Name = "btnMainItems";
			btnMainItems.Size = new Size(44, 44);
			btnMainItems.Text = "Items";
			// 
			// btnMainItemsDD
			// 
			btnMainItemsDD.DisplayStyle = ToolStripItemDisplayStyle.Image;
			btnMainItemsDD.Image = (Image)resources.GetObject("btnMainItemsDD.Image");
			btnMainItemsDD.ImageTransparentColor = Color.Magenta;
			btnMainItemsDD.Name = "btnMainItemsDD";
			btnMainItemsDD.Size = new Size(44, 44);
			btnMainItemsDD.Text = "ItemsDD";
			// 
			// ShellView
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(670, 407);
			Controls.Add(tsMain);
			Controls.Add(routedControlHost);
			Controls.Add(mnuMain);
			MainMenuStrip = mnuMain;
			Margin = new Padding(1, 1, 1, 1);
			Name = "ShellView";
			Text = "ShellView";
			mnuMain.ResumeLayout(false);
			mnuMain.PerformLayout();
			tsMain.ResumeLayout(false);
			tsMain.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ReactiveUI.Winforms.RoutedControlHost routedControlHost;
		private MenuStrip mnuMain;
		private ToolStripMenuItem mnuMainFile;
		private ToolStripMenuItem mnuFileClose;
		private ToolStrip tsMain;
		private ToolStripButton btnMainItems;
		private ToolStripButton btnMainItemsDD;
	}
}
