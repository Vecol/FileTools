namespace FileTools
{
    partial class mainwnd
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
            this.result = new System.Windows.Forms.TextBox();
            this.chbPath = new System.Windows.Forms.CheckBox();
            this.chbExt = new System.Windows.Forms.CheckBox();
            this.setting = new System.Windows.Forms.GroupBox();
            this.hbox1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbExt = new System.Windows.Forms.TextBox();
            this.btncopy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.setting.SuspendLayout();
            this.hbox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.AllowDrop = true;
            this.result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result.Location = new System.Drawing.Point(0, 0);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(317, 172);
            this.result.TabIndex = 0;
            this.result.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnFileDrop);
            this.result.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnFileDropEnter);
            // 
            // chbPath
            // 
            this.chbPath.AutoSize = true;
            this.chbPath.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chbPath.Location = new System.Drawing.Point(117, 3);
            this.chbPath.Name = "chbPath";
            this.chbPath.Size = new System.Drawing.Size(78, 16);
            this.chbPath.TabIndex = 1;
            this.chbPath.Text = "with path";
            this.chbPath.UseVisualStyleBackColor = true;
            this.chbPath.CheckedChanged += new System.EventHandler(this.CheckPath);
            // 
            // chbExt
            // 
            this.chbExt.AutoSize = true;
            this.chbExt.Location = new System.Drawing.Point(3, 3);
            this.chbExt.Name = "chbExt";
            this.chbExt.Size = new System.Drawing.Size(108, 16);
            this.chbExt.TabIndex = 2;
            this.chbExt.Text = "with extension";
            this.chbExt.UseVisualStyleBackColor = true;
            this.chbExt.CheckedChanged += new System.EventHandler(this.WithExt);
            // 
            // setting
            // 
            this.setting.AutoSize = true;
            this.setting.Controls.Add(this.hbox1);
            this.setting.Controls.Add(this.panel2);
            this.setting.Dock = System.Windows.Forms.DockStyle.Top;
            this.setting.Location = new System.Drawing.Point(0, 0);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(317, 72);
            this.setting.TabIndex = 3;
            this.setting.TabStop = false;
            this.setting.Text = "setting";
            // 
            // hbox1
            // 
            this.hbox1.AutoSize = true;
            this.hbox1.Controls.Add(this.chbExt);
            this.hbox1.Controls.Add(this.chbPath);
            this.hbox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hbox1.Location = new System.Drawing.Point(3, 17);
            this.hbox1.Name = "hbox1";
            this.hbox1.Size = new System.Drawing.Size(311, 22);
            this.hbox1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbExt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 30);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "extional string";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbExt
            // 
            this.tbExt.Location = new System.Drawing.Point(141, 0);
            this.tbExt.Name = "tbExt";
            this.tbExt.Size = new System.Drawing.Size(169, 21);
            this.tbExt.TabIndex = 1;
            this.tbExt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnEnterPressed);
            // 
            // btncopy
            // 
            this.btncopy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btncopy.Location = new System.Drawing.Point(0, 72);
            this.btncopy.Name = "btncopy";
            this.btncopy.Size = new System.Drawing.Size(317, 23);
            this.btncopy.TabIndex = 4;
            this.btncopy.Text = "Copy to clipboard";
            this.btncopy.UseVisualStyleBackColor = true;
            this.btncopy.Click += new System.EventHandler(this.Copy2Clipboard);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.setting);
            this.panel1.Controls.Add(this.btncopy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 95);
            this.panel1.TabIndex = 4;
            // 
            // mainwnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 267);
            this.Controls.Add(this.result);
            this.Controls.Add(this.panel1);
            this.Name = "mainwnd";
            this.Text = "FileTools";
            this.setting.ResumeLayout(false);
            this.setting.PerformLayout();
            this.hbox1.ResumeLayout(false);
            this.hbox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.CheckBox chbPath;
        private System.Windows.Forms.CheckBox chbExt;
        private System.Windows.Forms.GroupBox setting;
        private System.Windows.Forms.FlowLayoutPanel hbox1;
        private System.Windows.Forms.Button btncopy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbExt;
    }
}

