namespace TicTacToeWinForms.Controls
{
    partial class FieldControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Properties.Settings settings1 = new Properties.Settings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FieldControl));
            headerPanel = new System.Windows.Forms.Panel();
            playerLabel = new System.Windows.Forms.Label();
            playerCaptionlabel = new System.Windows.Forms.Label();
            turnLabel = new System.Windows.Forms.Label();
            turnCaptionLabel = new System.Windows.Forms.Label();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(playerLabel);
            headerPanel.Controls.Add(playerCaptionlabel);
            headerPanel.Controls.Add(turnLabel);
            headerPanel.Controls.Add(turnCaptionLabel);
            settings1.ButtonControlSize = new System.Drawing.Size(80, 80);
            settings1.FieldSize = 3;
            settings1.InfoPanelSize = new System.Drawing.Size(354, 40);
            settings1.SettingsKey = "";
            headerPanel.DataBindings.Add(new System.Windows.Forms.Binding("Size", settings1, "InfoPanelSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(headerPanel, "headerPanel");
            headerPanel.Name = "headerPanel";
            // 
            // playerLabel
            // 
            resources.ApplyResources(playerLabel, "playerLabel");
            playerLabel.Name = "playerLabel";
            // 
            // playerCaptionlabel
            // 
            resources.ApplyResources(playerCaptionlabel, "playerCaptionlabel");
            playerCaptionlabel.Name = "playerCaptionlabel";
            // 
            // turnLabel
            // 
            resources.ApplyResources(turnLabel, "turnLabel");
            turnLabel.Name = "turnLabel";
            // 
            // turnCaptionLabel
            // 
            resources.ApplyResources(turnCaptionLabel, "turnCaptionLabel");
            turnCaptionLabel.Name = "turnCaptionLabel";
            // 
            // FieldControl
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(headerPanel);
            Name = "FieldControl";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.Label turnCaptionLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label playerCaptionlabel;
    }
}
