namespace Dokobell
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bell_mero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bell_door = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.time_after_bell = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.time_before_bell = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_on = new System.Windows.Forms.Button();
            this.button_off = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenSettingFileFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.名前を付けて保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.スピーカーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton_push_button = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton_tatikawa = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.radioButton_tatikawa_plus = new System.Windows.Forms.RadioButton();
            this.radioButton_button_delay = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SelectSpeaker = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bell_mero
            // 
            this.bell_mero.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bell_mero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bell_mero.FormattingEnabled = true;
            resources.ApplyResources(this.bell_mero, "bell_mero");
            this.bell_mero.Name = "bell_mero";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bell_door);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bell_mero);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // bell_door
            // 
            this.bell_door.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bell_door.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bell_door.FormattingEnabled = true;
            resources.ApplyResources(this.bell_door, "bell_door");
            this.bell_door.Name = "bell_door";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.time_after_bell);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.time_before_bell);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.label6.UseWaitCursor = true;
            // 
            // time_after_bell
            // 
            resources.ApplyResources(this.time_after_bell, "time_after_bell");
            this.time_after_bell.Name = "time_after_bell";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.UseWaitCursor = true;
            // 
            // time_before_bell
            // 
            resources.ApplyResources(this.time_before_bell, "time_before_bell");
            this.time_before_bell.Name = "time_before_bell";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.UseWaitCursor = true;
            // 
            // button_on
            // 
            resources.ApplyResources(this.button_on, "button_on");
            this.button_on.ForeColor = System.Drawing.Color.Black;
            this.button_on.Name = "button_on";
            this.button_on.UseVisualStyleBackColor = true;
            this.button_on.Click += new System.EventHandler(this.button_on_Click);
            // 
            // button_off
            // 
            resources.ApplyResources(this.button_off, "button_off");
            this.button_off.ForeColor = System.Drawing.Color.Black;
            this.button_off.Name = "button_off";
            this.button_off.UseVisualStyleBackColor = true;
            this.button_off.Click += new System.EventHandler(this.button_off_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_on);
            this.groupBox3.Controls.Add(this.button_off);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.設定ToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenSettingFileFolder,
            this.名前を付けて保存ToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            resources.ApplyResources(this.ファイルToolStripMenuItem, "ファイルToolStripMenuItem");
            // 
            // OpenSettingFileFolder
            // 
            this.OpenSettingFileFolder.Name = "OpenSettingFileFolder";
            resources.ApplyResources(this.OpenSettingFileFolder, "OpenSettingFileFolder");
            this.OpenSettingFileFolder.Click += new System.EventHandler(this.OpenSettingFileFolder_Click);
            // 
            // 名前を付けて保存ToolStripMenuItem
            // 
            this.名前を付けて保存ToolStripMenuItem.Name = "名前を付けて保存ToolStripMenuItem";
            resources.ApplyResources(this.名前を付けて保存ToolStripMenuItem, "名前を付けて保存ToolStripMenuItem");
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.スピーカーToolStripMenuItem});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            resources.ApplyResources(this.設定ToolStripMenuItem, "設定ToolStripMenuItem");
            // 
            // スピーカーToolStripMenuItem
            // 
            this.スピーカーToolStripMenuItem.Name = "スピーカーToolStripMenuItem";
            resources.ApplyResources(this.スピーカーToolStripMenuItem, "スピーカーToolStripMenuItem");
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton5);
            this.groupBox4.Controls.Add(this.radioButton_push_button);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.radioButton_tatikawa);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.radioButton_tatikawa_plus);
            this.groupBox4.Controls.Add(this.radioButton_button_delay);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // radioButton5
            // 
            resources.ApplyResources(this.radioButton5, "radioButton5");
            this.radioButton5.Checked = true;
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.TabStop = true;
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton_push_button
            // 
            resources.ApplyResources(this.radioButton_push_button, "radioButton_push_button");
            this.radioButton_push_button.Name = "radioButton_push_button";
            this.radioButton_push_button.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.label7.UseWaitCursor = true;
            // 
            // radioButton_tatikawa
            // 
            resources.ApplyResources(this.radioButton_tatikawa, "radioButton_tatikawa");
            this.radioButton_tatikawa.Name = "radioButton_tatikawa";
            this.radioButton_tatikawa.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // radioButton_tatikawa_plus
            // 
            resources.ApplyResources(this.radioButton_tatikawa_plus, "radioButton_tatikawa_plus");
            this.radioButton_tatikawa_plus.Name = "radioButton_tatikawa_plus";
            this.radioButton_tatikawa_plus.UseVisualStyleBackColor = true;
            // 
            // radioButton_button_delay
            // 
            resources.ApplyResources(this.radioButton_button_delay, "radioButton_button_delay");
            this.radioButton_button_delay.Name = "radioButton_button_delay";
            this.radioButton_button_delay.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox1);
            this.groupBox5.Controls.Add(this.SelectSpeaker);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SelectSpeaker
            // 
            this.SelectSpeaker.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SelectSpeaker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectSpeaker.FormattingEnabled = true;
            resources.ApplyResources(this.SelectSpeaker, "SelectSpeaker");
            this.SelectSpeaker.Name = "SelectSpeaker";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusText});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // StatusText
            // 
            this.StatusText.Name = "StatusText";
            resources.ApplyResources(this.StatusText, "StatusText");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bell_mero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox bell_door;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox time_after_bell;
        private System.Windows.Forms.TextBox time_before_bell;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_on;
        private System.Windows.Forms.Button button_off;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem スピーカーToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenSettingFileFolder;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton_tatikawa_plus;
        private System.Windows.Forms.RadioButton radioButton_button_delay;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton_tatikawa;
        private System.Windows.Forms.RadioButton radioButton_push_button;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox SelectSpeaker;
        private System.Windows.Forms.ToolStripMenuItem 名前を付けて保存ToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusText;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

