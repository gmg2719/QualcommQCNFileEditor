
namespace QualcommQCNFileEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.DualRB = new System.Windows.Forms.RadioButton();
            this.SingleRB = new System.Windows.Forms.RadioButton();
            this.pbIMEI2Error = new System.Windows.Forms.PictureBox();
            this.pbIMEI1Error = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imei1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imei2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SelectBTN = new System.Windows.Forms.Button();
            this.TxtSource = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CreateBTN = new System.Windows.Forms.Button();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbIMEI2Error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIMEI1Error)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 150;
            // 
            // DualRB
            // 
            this.DualRB.AutoSize = true;
            this.DualRB.Checked = true;
            this.DualRB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DualRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.DualRB.Location = new System.Drawing.Point(13, 96);
            this.DualRB.Name = "DualRB";
            this.DualRB.Size = new System.Drawing.Size(98, 30);
            this.DualRB.TabIndex = 1;
            this.DualRB.TabStop = true;
            this.DualRB.Text = "DUAL IMEI\r\n(SIM1+SIM2)";
            this.toolTip1.SetToolTip(this.DualRB, "When Selected; Repairs SIM-1 and SIM-2.!");
            this.DualRB.UseVisualStyleBackColor = true;
            this.DualRB.CheckedChanged += new System.EventHandler(this.DualRB_CheckedChanged);
            // 
            // SingleRB
            // 
            this.SingleRB.AutoSize = true;
            this.SingleRB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SingleRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.SingleRB.Location = new System.Drawing.Point(13, 36);
            this.SingleRB.Name = "SingleRB";
            this.SingleRB.Size = new System.Drawing.Size(100, 30);
            this.SingleRB.TabIndex = 0;
            this.SingleRB.Text = "SINGLE IMEI\r\n(Only SIM-2)";
            this.toolTip1.SetToolTip(this.SingleRB, "When Selected; Only Repairs SIM-2.!");
            this.SingleRB.UseVisualStyleBackColor = true;
            this.SingleRB.CheckedChanged += new System.EventHandler(this.SingleRB_CheckedChanged);
            // 
            // pbIMEI2Error
            // 
            this.pbIMEI2Error.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbIMEI2Error.Location = new System.Drawing.Point(285, 42);
            this.pbIMEI2Error.Name = "pbIMEI2Error";
            this.pbIMEI2Error.Size = new System.Drawing.Size(17, 17);
            this.pbIMEI2Error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIMEI2Error.TabIndex = 18;
            this.pbIMEI2Error.TabStop = false;
            // 
            // pbIMEI1Error
            // 
            this.pbIMEI1Error.Location = new System.Drawing.Point(285, 102);
            this.pbIMEI1Error.Name = "pbIMEI1Error";
            this.pbIMEI1Error.Size = new System.Drawing.Size(17, 17);
            this.pbIMEI1Error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIMEI1Error.TabIndex = 17;
            this.pbIMEI1Error.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // imei1
            // 
            this.imei1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.imei1.ForeColor = System.Drawing.Color.DarkRed;
            this.imei1.Location = new System.Drawing.Point(10, 96);
            this.imei1.MaxLength = 15;
            this.imei1.Multiline = true;
            this.imei1.Name = "imei1";
            this.imei1.Size = new System.Drawing.Size(270, 29);
            this.imei1.TabIndex = 4;
            this.imei1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.imei1.TextChanged += new System.EventHandler(this.imei1_TextChanged);
            this.imei1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.imei1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label6.Location = new System.Drawing.Point(201, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label5.Location = new System.Drawing.Point(133, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 25;
            // 
            // imei2
            // 
            this.imei2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.imei2.ForeColor = System.Drawing.Color.DarkRed;
            this.imei2.Location = new System.Drawing.Point(10, 36);
            this.imei2.MaxLength = 15;
            this.imei2.Multiline = true;
            this.imei2.Name = "imei2";
            this.imei2.Size = new System.Drawing.Size(270, 29);
            this.imei2.TabIndex = 5;
            this.imei2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.imei2.TextChanged += new System.EventHandler(this.imei2_TextChanged);
            this.imei2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.imei2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label4.Location = new System.Drawing.Point(133, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 24;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SelectBTN);
            this.groupBox3.Controls.Add(this.TxtSource);
            this.groupBox3.Location = new System.Drawing.Point(12, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 74);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select QCN File";
            // 
            // SelectBTN
            // 
            this.SelectBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.SelectBTN.ForeColor = System.Drawing.Color.DarkRed;
            this.SelectBTN.Location = new System.Drawing.Point(10, 28);
            this.SelectBTN.Name = "SelectBTN";
            this.SelectBTN.Size = new System.Drawing.Size(75, 31);
            this.SelectBTN.TabIndex = 3;
            this.SelectBTN.Text = "Select";
            this.SelectBTN.UseVisualStyleBackColor = true;
            this.SelectBTN.Click += new System.EventHandler(this.SelectBTN_Click);
            // 
            // TxtSource
            // 
            this.TxtSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSource.Location = new System.Drawing.Point(91, 28);
            this.TxtSource.Multiline = true;
            this.TxtSource.Name = "TxtSource";
            this.TxtSource.ReadOnly = true;
            this.TxtSource.Size = new System.Drawing.Size(329, 31);
            this.TxtSource.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbIMEI2Error);
            this.groupBox2.Controls.Add(this.pbIMEI1Error);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.imei1);
            this.groupBox2.Controls.Add(this.imei2);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 159);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input IMEI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DualRB);
            this.groupBox1.Controls.Add(this.SingleRB);
            this.groupBox1.Location = new System.Drawing.Point(331, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 158);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Method";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(269, 284);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(104, 42);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // CreateBTN
            // 
            this.CreateBTN.BackColor = System.Drawing.Color.Transparent;
            this.CreateBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.CreateBTN.ForeColor = System.Drawing.Color.DarkRed;
            this.CreateBTN.Location = new System.Drawing.Point(12, 286);
            this.CreateBTN.Name = "CreateBTN";
            this.CreateBTN.Size = new System.Drawing.Size(115, 41);
            this.CreateBTN.TabIndex = 18;
            this.CreateBTN.Text = "Create";
            this.CreateBTN.UseVisualStyleBackColor = false;
            this.CreateBTN.Click += new System.EventHandler(this.CreateBTN_Click);
            // 
            // ExitBTN
            // 
            this.ExitBTN.BackColor = System.Drawing.Color.Transparent;
            this.ExitBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ExitBTN.ForeColor = System.Drawing.Color.DarkRed;
            this.ExitBTN.Location = new System.Drawing.Point(379, 285);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(69, 41);
            this.ExitBTN.TabIndex = 17;
            this.ExitBTN.Text = "Exit";
            this.ExitBTN.UseVisualStyleBackColor = false;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label3.Location = new System.Drawing.Point(133, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(461, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AboutToolStripMenuItem.Image")));
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ExitToolStripMenuItem.Image")));
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 338);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.CreateBTN);
            this.Controls.Add(this.ExitBTN);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIMEI2Error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIMEI1Error)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton DualRB;
        private System.Windows.Forms.RadioButton SingleRB;
        private System.Windows.Forms.PictureBox pbIMEI2Error;
        private System.Windows.Forms.PictureBox pbIMEI1Error;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imei1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox imei2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SelectBTN;
        private System.Windows.Forms.TextBox TxtSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button CreateBTN;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    }
}

