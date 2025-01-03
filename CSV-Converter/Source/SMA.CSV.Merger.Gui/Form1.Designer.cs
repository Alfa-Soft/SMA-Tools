namespace SMA.CSV.Merger
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.mBackgroundTimer = new System.Windows.Forms.Timer(this.components);
            this.panMain = new Krypton.Toolkit.KryptonSplitContainer();
            this.pMain = new Krypton.Toolkit.KryptonPanel();
            this.btnOpenFile = new Krypton.Toolkit.KryptonLinkLabel();
            this.btnOpenPath = new Krypton.Toolkit.KryptonLinkLabel();
            this.btnConvert2 = new Krypton.Toolkit.KryptonButton();
            this.btnConvert1 = new Krypton.Toolkit.KryptonButton();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.txtOutput = new AT.Windows.Controls.FileLinkInfoControl();
            this.txtInput = new AT.Windows.Controls.FileLinkInfoControl();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.panFooter = new Krypton.Toolkit.KryptonHeaderGroup();
            this.btnClearLog = new Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.txtNLog = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panMain.Panel1)).BeginInit();
            this.panMain.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panMain.Panel2)).BeginInit();
            this.panMain.Panel2.SuspendLayout();
            this.panMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pMain)).BeginInit();
            this.pMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panFooter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panFooter.Panel)).BeginInit();
            this.panFooter.Panel.SuspendLayout();
            this.panFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // mBackgroundTimer
            // 
            this.mBackgroundTimer.Enabled = true;
            this.mBackgroundTimer.Interval = 500;
            // 
            // panMain
            // 
            this.panMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 0);
            this.panMain.Name = "panMain";
            this.panMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // panMain.Panel1
            // 
            this.panMain.Panel1.Controls.Add(this.pMain);
            // 
            // panMain.Panel2
            // 
            this.panMain.Panel2.Controls.Add(this.panFooter);
            this.panMain.Size = new System.Drawing.Size(784, 740);
            this.panMain.SplitterDistance = 595;
            this.panMain.TabIndex = 4;
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.btnOpenFile);
            this.pMain.Controls.Add(this.btnOpenPath);
            this.pMain.Controls.Add(this.btnConvert2);
            this.pMain.Controls.Add(this.btnConvert1);
            this.pMain.Controls.Add(this.btnSave);
            this.pMain.Controls.Add(this.txtOutput);
            this.pMain.Controls.Add(this.txtInput);
            this.pMain.Controls.Add(this.kryptonLabel8);
            this.pMain.Controls.Add(this.kryptonLabel7);
            this.pMain.Controls.Add(this.kryptonLabel2);
            this.pMain.Controls.Add(this.kryptonLabel6);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.pMain.Size = new System.Drawing.Size(784, 595);
            this.pMain.TabIndex = 24;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(704, 518);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(62, 20);
            this.btnOpenFile.TabIndex = 15;
            this.btnOpenFile.Values.Text = "Open File";
            this.btnOpenFile.LinkClicked += new System.EventHandler(this.btnOpenFile_LinkClicked);
            // 
            // btnOpenPath
            // 
            this.btnOpenPath.Location = new System.Drawing.Point(704, 492);
            this.btnOpenPath.Name = "btnOpenPath";
            this.btnOpenPath.Size = new System.Drawing.Size(68, 20);
            this.btnOpenPath.TabIndex = 15;
            this.btnOpenPath.Values.Text = "Open Path";
            this.btnOpenPath.LinkClicked += new System.EventHandler(this.btnOpenPath_LinkClicked);
            // 
            // btnConvert2
            // 
            this.btnConvert2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConvert2.Location = new System.Drawing.Point(151, 492);
            this.btnConvert2.Name = "btnConvert2";
            this.btnConvert2.Size = new System.Drawing.Size(218, 45);
            this.btnConvert2.TabIndex = 14;
            this.btnConvert2.Values.Text = "Merge input to CSV file";
            this.btnConvert2.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnConvert1
            // 
            this.btnConvert1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConvert1.Location = new System.Drawing.Point(480, 492);
            this.btnConvert1.Name = "btnConvert1";
            this.btnConvert1.Size = new System.Drawing.Size(215, 45);
            this.btnConvert1.TabIndex = 14;
            this.btnConvert1.Values.Text = "Merge input to XLS file";
            this.btnConvert1.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Location = new System.Drawing.Point(704, 449);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(34, 22);
            this.btnSave.TabIndex = 13;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.AutoSize = true;
            this.txtOutput.EnableDelete = true;
            this.txtOutput.EnableDragDrop = true;
            this.txtOutput.EnableHighlight = false;
            this.txtOutput.EnablePaste = true;
            this.txtOutput.Location = new System.Drawing.Point(151, 449);
            this.txtOutput.MaxItems = 1;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.OpenFileOnDoubleClick = false;
            this.txtOutput.Size = new System.Drawing.Size(544, 25);
            this.txtOutput.TabIndex = 11;
            // 
            // txtInput
            // 
            this.txtInput.AutoSize = true;
            this.txtInput.EnableDelete = true;
            this.txtInput.EnableDragDrop = true;
            this.txtInput.EnableHighlight = true;
            this.txtInput.EnablePaste = true;
            this.txtInput.EnableRepairAuto = false;
            this.txtInput.EnableRepairManual = false;
            this.txtInput.Location = new System.Drawing.Point(151, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(621, 406);
            this.txtInput.TabIndex = 12;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel8.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(42, 20);
            this.kryptonLabel8.TabIndex = 9;
            this.kryptonLabel8.Values.Text = "Input";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel7.Location = new System.Drawing.Point(12, 427);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(52, 20);
            this.kryptonLabel7.TabIndex = 4;
            this.kryptonLabel7.Values.Text = "Output";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.ItalicControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 38);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(113, 84);
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "Drag and drop files\r\nor folders.\r\n\r\nSupported types:\r\n .csv";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(12, 453);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(73, 20);
            this.kryptonLabel6.TabIndex = 8;
            this.kryptonLabel6.Values.Text = "Merged file";
            // 
            // panFooter
            // 
            this.panFooter.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.btnClearLog});
            this.panFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panFooter.HeaderStylePrimary = Krypton.Toolkit.HeaderStyle.Secondary;
            this.panFooter.HeaderVisibleSecondary = false;
            this.panFooter.Location = new System.Drawing.Point(0, 0);
            this.panFooter.Name = "panFooter";
            // 
            // panFooter.Panel
            // 
            this.panFooter.Panel.Controls.Add(this.txtNLog);
            this.panFooter.Size = new System.Drawing.Size(784, 140);
            this.panFooter.TabIndex = 1;
            this.panFooter.ValuesPrimary.Heading = "Event Log";
            this.panFooter.ValuesPrimary.Image = null;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Text = "Clear";
            this.btnClearLog.UniqueName = "D4BA1733D257462F40A749A51469DE22";
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // txtNLog
            // 
            this.txtNLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNLog.Location = new System.Drawing.Point(0, 0);
            this.txtNLog.Name = "txtNLog";
            this.txtNLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtNLog.Size = new System.Drawing.Size(782, 113);
            this.txtNLog.TabIndex = 0;
            this.txtNLog.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 740);
            this.Controls.Add(this.panMain);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "SMA CSV Converter";
            this.Load += new System.EventHandler(this.Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panMain.Panel1)).EndInit();
            this.panMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panMain.Panel2)).EndInit();
            this.panMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panMain)).EndInit();
            this.panMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pMain)).EndInit();
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panFooter.Panel)).EndInit();
            this.panFooter.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panFooter)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer mBackgroundTimer;
        private Krypton.Toolkit.KryptonSplitContainer panMain;
        private Krypton.Toolkit.KryptonHeaderGroup panFooter;
        public System.Windows.Forms.RichTextBox txtNLog;
        private Krypton.Toolkit.KryptonPanel pMain;
        private Krypton.Toolkit.KryptonButton btnSave;
        private AT.Windows.Controls.FileLinkInfoControl txtOutput;
        private AT.Windows.Controls.FileLinkInfoControl txtInput;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonButton btnConvert1;
        private Krypton.Toolkit.KryptonLinkLabel btnOpenFile;
        private Krypton.Toolkit.KryptonLinkLabel btnOpenPath;
        private Krypton.Toolkit.ButtonSpecHeaderGroup btnClearLog;
        private Krypton.Toolkit.KryptonButton btnConvert2;
    }
}

