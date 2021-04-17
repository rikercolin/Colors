
namespace Colors
{
    partial class ApplicationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationForm));
            this.colorPalleteTable = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.help_btn = new System.Windows.Forms.Button();
            this.SavePallete = new System.Windows.Forms.Button();
            this.RandomSeedColor = new System.Windows.Forms.Button();
            this.SetSeedColor = new System.Windows.Forms.Button();
            this.Generate = new System.Windows.Forms.Button();
            this.ColorBox5 = new System.Windows.Forms.Panel();
            this.ColorLabel5 = new System.Windows.Forms.Label();
            this.ColorBox4 = new System.Windows.Forms.Panel();
            this.ColorLabel4 = new System.Windows.Forms.Label();
            this.ColorBox3 = new System.Windows.Forms.Panel();
            this.ColorLabel3 = new System.Windows.Forms.Label();
            this.ColorBox2 = new System.Windows.Forms.Panel();
            this.ColorLabel2 = new System.Windows.Forms.Label();
            this.ColorBox1 = new System.Windows.Forms.Panel();
            this.ColorLabel1 = new System.Windows.Forms.Label();
            this.SeedColorPicker = new System.Windows.Forms.ColorDialog();
            this.colorPalleteTable.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.ColorBox5.SuspendLayout();
            this.ColorBox4.SuspendLayout();
            this.ColorBox3.SuspendLayout();
            this.ColorBox2.SuspendLayout();
            this.ColorBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorPalleteTable
            // 
            this.colorPalleteTable.BackColor = System.Drawing.Color.Black;
            this.colorPalleteTable.ColumnCount = 5;
            this.colorPalleteTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.colorPalleteTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.colorPalleteTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.colorPalleteTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.colorPalleteTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.colorPalleteTable.Controls.Add(this.ButtonPanel, 0, 1);
            this.colorPalleteTable.Controls.Add(this.ColorBox5, 4, 0);
            this.colorPalleteTable.Controls.Add(this.ColorBox4, 3, 0);
            this.colorPalleteTable.Controls.Add(this.ColorBox3, 2, 0);
            this.colorPalleteTable.Controls.Add(this.ColorBox2, 1, 0);
            this.colorPalleteTable.Controls.Add(this.ColorBox1, 0, 0);
            this.colorPalleteTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorPalleteTable.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPalleteTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.colorPalleteTable.Location = new System.Drawing.Point(0, 0);
            this.colorPalleteTable.Name = "colorPalleteTable";
            this.colorPalleteTable.RowCount = 2;
            this.colorPalleteTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.colorPalleteTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.colorPalleteTable.Size = new System.Drawing.Size(800, 450);
            this.colorPalleteTable.TabIndex = 0;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.Color.White;
            this.colorPalleteTable.SetColumnSpan(this.ButtonPanel, 5);
            this.ButtonPanel.Controls.Add(this.help_btn);
            this.ButtonPanel.Controls.Add(this.SavePallete);
            this.ButtonPanel.Controls.Add(this.RandomSeedColor);
            this.ButtonPanel.Controls.Add(this.SetSeedColor);
            this.ButtonPanel.Controls.Add(this.Generate);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 350);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(800, 100);
            this.ButtonPanel.TabIndex = 0;
            // 
            // help_btn
            // 
            this.help_btn.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_btn.Location = new System.Drawing.Point(30, 35);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(140, 30);
            this.help_btn.TabIndex = 4;
            this.help_btn.Text = "Instructions";
            this.help_btn.UseVisualStyleBackColor = true;
            // 
            // SavePallete
            // 
            this.SavePallete.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePallete.Location = new System.Drawing.Point(630, 35);
            this.SavePallete.Name = "SavePallete";
            this.SavePallete.Size = new System.Drawing.Size(140, 30);
            this.SavePallete.TabIndex = 3;
            this.SavePallete.Text = "Save Pallete";
            this.SavePallete.UseVisualStyleBackColor = true;
            this.SavePallete.Click += new System.EventHandler(this.SavePallete_Click);
            // 
            // RandomSeedColor
            // 
            this.RandomSeedColor.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.RandomSeedColor.Location = new System.Drawing.Point(330, 35);
            this.RandomSeedColor.Name = "RandomSeedColor";
            this.RandomSeedColor.Size = new System.Drawing.Size(140, 30);
            this.RandomSeedColor.TabIndex = 2;
            this.RandomSeedColor.Text = "Random Seed Color";
            this.RandomSeedColor.UseVisualStyleBackColor = true;
            this.RandomSeedColor.Click += new System.EventHandler(this.RandomSeedColor_Click);
            // 
            // SetSeedColor
            // 
            this.SetSeedColor.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.SetSeedColor.Location = new System.Drawing.Point(180, 35);
            this.SetSeedColor.Name = "SetSeedColor";
            this.SetSeedColor.Size = new System.Drawing.Size(140, 30);
            this.SetSeedColor.TabIndex = 1;
            this.SetSeedColor.Text = "Set Seed Color";
            this.SetSeedColor.UseVisualStyleBackColor = true;
            this.SetSeedColor.Click += new System.EventHandler(this.SetSeedColor_Click);
            // 
            // Generate
            // 
            this.Generate.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.Generate.Location = new System.Drawing.Point(480, 35);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(140, 30);
            this.Generate.TabIndex = 0;
            this.Generate.Text = "Generate Pallete";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // ColorBox5
            // 
            this.ColorBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(111)))), ((int)(((byte)(81)))));
            this.ColorBox5.Controls.Add(this.ColorLabel5);
            this.ColorBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorBox5.Location = new System.Drawing.Point(640, 0);
            this.ColorBox5.Margin = new System.Windows.Forms.Padding(0);
            this.ColorBox5.Name = "ColorBox5";
            this.ColorBox5.Size = new System.Drawing.Size(160, 350);
            this.ColorBox5.TabIndex = 5;
            // 
            // ColorLabel5
            // 
            this.ColorLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.ColorLabel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ColorLabel5.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorLabel5.ForeColor = System.Drawing.Color.White;
            this.ColorLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ColorLabel5.Location = new System.Drawing.Point(0, 300);
            this.ColorLabel5.Margin = new System.Windows.Forms.Padding(0);
            this.ColorLabel5.Name = "ColorLabel5";
            this.ColorLabel5.Padding = new System.Windows.Forms.Padding(10);
            this.ColorLabel5.Size = new System.Drawing.Size(160, 50);
            this.ColorLabel5.TabIndex = 1;
            this.ColorLabel5.Text = "#E76F51";
            this.ColorLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorBox4
            // 
            this.ColorBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.ColorBox4.Controls.Add(this.ColorLabel4);
            this.ColorBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorBox4.Location = new System.Drawing.Point(480, 0);
            this.ColorBox4.Margin = new System.Windows.Forms.Padding(0);
            this.ColorBox4.Name = "ColorBox4";
            this.ColorBox4.Size = new System.Drawing.Size(160, 350);
            this.ColorBox4.TabIndex = 4;
            // 
            // ColorLabel4
            // 
            this.ColorLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.ColorLabel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ColorLabel4.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorLabel4.ForeColor = System.Drawing.Color.Black;
            this.ColorLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ColorLabel4.Location = new System.Drawing.Point(0, 300);
            this.ColorLabel4.Margin = new System.Windows.Forms.Padding(0);
            this.ColorLabel4.Name = "ColorLabel4";
            this.ColorLabel4.Padding = new System.Windows.Forms.Padding(10);
            this.ColorLabel4.Size = new System.Drawing.Size(160, 50);
            this.ColorLabel4.TabIndex = 1;
            this.ColorLabel4.Text = "#F4A261";
            this.ColorLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorBox3
            // 
            this.ColorBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(196)))), ((int)(((byte)(106)))));
            this.ColorBox3.Controls.Add(this.ColorLabel3);
            this.ColorBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorBox3.Location = new System.Drawing.Point(320, 0);
            this.ColorBox3.Margin = new System.Windows.Forms.Padding(0);
            this.ColorBox3.Name = "ColorBox3";
            this.ColorBox3.Size = new System.Drawing.Size(160, 350);
            this.ColorBox3.TabIndex = 3;
            // 
            // ColorLabel3
            // 
            this.ColorLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.ColorLabel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ColorLabel3.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorLabel3.ForeColor = System.Drawing.Color.Black;
            this.ColorLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ColorLabel3.Location = new System.Drawing.Point(0, 300);
            this.ColorLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.ColorLabel3.Name = "ColorLabel3";
            this.ColorLabel3.Padding = new System.Windows.Forms.Padding(10);
            this.ColorLabel3.Size = new System.Drawing.Size(160, 50);
            this.ColorLabel3.TabIndex = 1;
            this.ColorLabel3.Text = "#E9C46A";
            this.ColorLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorBox2
            // 
            this.ColorBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.ColorBox2.Controls.Add(this.ColorLabel2);
            this.ColorBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorBox2.Location = new System.Drawing.Point(160, 0);
            this.ColorBox2.Margin = new System.Windows.Forms.Padding(0);
            this.ColorBox2.Name = "ColorBox2";
            this.ColorBox2.Size = new System.Drawing.Size(160, 350);
            this.ColorBox2.TabIndex = 2;
            // 
            // ColorLabel2
            // 
            this.ColorLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.ColorLabel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ColorLabel2.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorLabel2.ForeColor = System.Drawing.Color.White;
            this.ColorLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ColorLabel2.Location = new System.Drawing.Point(0, 300);
            this.ColorLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.ColorLabel2.Name = "ColorLabel2";
            this.ColorLabel2.Padding = new System.Windows.Forms.Padding(10);
            this.ColorLabel2.Size = new System.Drawing.Size(160, 50);
            this.ColorLabel2.TabIndex = 1;
            this.ColorLabel2.Text = "#2A9D8F";
            this.ColorLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorBox1
            // 
            this.ColorBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.ColorBox1.Controls.Add(this.ColorLabel1);
            this.ColorBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorBox1.Location = new System.Drawing.Point(0, 0);
            this.ColorBox1.Margin = new System.Windows.Forms.Padding(0);
            this.ColorBox1.Name = "ColorBox1";
            this.ColorBox1.Size = new System.Drawing.Size(160, 350);
            this.ColorBox1.TabIndex = 1;
            // 
            // ColorLabel1
            // 
            this.ColorLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ColorLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ColorLabel1.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorLabel1.ForeColor = System.Drawing.Color.White;
            this.ColorLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ColorLabel1.Location = new System.Drawing.Point(0, 300);
            this.ColorLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.ColorLabel1.Name = "ColorLabel1";
            this.ColorLabel1.Padding = new System.Windows.Forms.Padding(10);
            this.ColorLabel1.Size = new System.Drawing.Size(160, 50);
            this.ColorLabel1.TabIndex = 0;
            this.ColorLabel1.Text = "#264653";
            this.ColorLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colorPalleteTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApplicationForm";
            this.Text = "Colors";
            this.Load += new System.EventHandler(this.ApplicationForm_Load);
            this.colorPalleteTable.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.ColorBox5.ResumeLayout(false);
            this.ColorBox4.ResumeLayout(false);
            this.ColorBox3.ResumeLayout(false);
            this.ColorBox2.ResumeLayout(false);
            this.ColorBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel colorPalleteTable;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Panel ColorBox1;
        private System.Windows.Forms.Panel ColorBox5;
        private System.Windows.Forms.Panel ColorBox4;
        private System.Windows.Forms.Panel ColorBox3;
        private System.Windows.Forms.Panel ColorBox2;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button SetSeedColor;
        private System.Windows.Forms.Button RandomSeedColor;
        private System.Windows.Forms.Button SavePallete;
        private System.Windows.Forms.ColorDialog SeedColorPicker;
        private System.Windows.Forms.Label ColorLabel1;
        private System.Windows.Forms.Label ColorLabel5;
        private System.Windows.Forms.Label ColorLabel4;
        private System.Windows.Forms.Label ColorLabel3;
        private System.Windows.Forms.Label ColorLabel2;
        private System.Windows.Forms.Button help_btn;
    }
}