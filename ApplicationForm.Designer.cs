
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
            this.ColorBox1 = new System.Windows.Forms.Panel();
            this.ColorBox2 = new System.Windows.Forms.Panel();
            this.ColorBox3 = new System.Windows.Forms.Panel();
            this.ColorBox4 = new System.Windows.Forms.Panel();
            this.ColorBox5 = new System.Windows.Forms.Panel();
            this.Generate = new System.Windows.Forms.Button();
            this.SetSeedColor = new System.Windows.Forms.Button();
            this.RandomSeedColor = new System.Windows.Forms.Button();
            this.SavePallete = new System.Windows.Forms.Button();
            this.SeedColorPicker = new System.Windows.Forms.ColorDialog();
            this.colorPalleteTable.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
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
            // ColorBox1
            // 
            this.ColorBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.ColorBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorBox1.Location = new System.Drawing.Point(0, 0);
            this.ColorBox1.Margin = new System.Windows.Forms.Padding(0);
            this.ColorBox1.Name = "ColorBox1";
            this.ColorBox1.Size = new System.Drawing.Size(160, 350);
            this.ColorBox1.TabIndex = 1;
            // 
            // ColorBox2
            // 
            this.ColorBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.ColorBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorBox2.Location = new System.Drawing.Point(160, 0);
            this.ColorBox2.Margin = new System.Windows.Forms.Padding(0);
            this.ColorBox2.Name = "ColorBox2";
            this.ColorBox2.Size = new System.Drawing.Size(160, 350);
            this.ColorBox2.TabIndex = 2;
            // 
            // ColorBox3
            // 
            this.ColorBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(196)))), ((int)(((byte)(106)))));
            this.ColorBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorBox3.Location = new System.Drawing.Point(320, 0);
            this.ColorBox3.Margin = new System.Windows.Forms.Padding(0);
            this.ColorBox3.Name = "ColorBox3";
            this.ColorBox3.Size = new System.Drawing.Size(160, 350);
            this.ColorBox3.TabIndex = 3;
            // 
            // ColorBox4
            // 
            this.ColorBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.ColorBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorBox4.Location = new System.Drawing.Point(480, 0);
            this.ColorBox4.Margin = new System.Windows.Forms.Padding(0);
            this.ColorBox4.Name = "ColorBox4";
            this.ColorBox4.Size = new System.Drawing.Size(160, 350);
            this.ColorBox4.TabIndex = 4;
            // 
            // ColorBox5
            // 
            this.ColorBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(111)))), ((int)(((byte)(81)))));
            this.ColorBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorBox5.Location = new System.Drawing.Point(640, 0);
            this.ColorBox5.Margin = new System.Windows.Forms.Padding(0);
            this.ColorBox5.Name = "ColorBox5";
            this.ColorBox5.Size = new System.Drawing.Size(160, 350);
            this.ColorBox5.TabIndex = 5;
            // 
            // Generate
            // 
            this.Generate.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.Generate.Location = new System.Drawing.Point(415, 38);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(150, 30);
            this.Generate.TabIndex = 0;
            this.Generate.Text = "Generate Pallete";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // SetSeedColor
            // 
            this.SetSeedColor.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.SetSeedColor.Location = new System.Drawing.Point(210, 38);
            this.SetSeedColor.Name = "SetSeedColor";
            this.SetSeedColor.Size = new System.Drawing.Size(150, 30);
            this.SetSeedColor.TabIndex = 1;
            this.SetSeedColor.Text = "Set Seed Color";
            this.SetSeedColor.UseVisualStyleBackColor = true;
            this.SetSeedColor.Click += new System.EventHandler(this.SetSeedColor_Click);
            // 
            // RandomSeedColor
            // 
            this.RandomSeedColor.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.RandomSeedColor.Location = new System.Drawing.Point(11, 38);
            this.RandomSeedColor.Name = "RandomSeedColor";
            this.RandomSeedColor.Size = new System.Drawing.Size(150, 30);
            this.RandomSeedColor.TabIndex = 2;
            this.RandomSeedColor.Text = "Random Seed Color";
            this.RandomSeedColor.UseVisualStyleBackColor = true;
            this.RandomSeedColor.Click += new System.EventHandler(this.RandomSeedColor_Click);
            // 
            // SavePallete
            // 
            this.SavePallete.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePallete.Location = new System.Drawing.Point(636, 38);
            this.SavePallete.Name = "SavePallete";
            this.SavePallete.Size = new System.Drawing.Size(150, 30);
            this.SavePallete.TabIndex = 3;
            this.SavePallete.Text = "Save Pallete";
            this.SavePallete.UseVisualStyleBackColor = true;
            this.SavePallete.Click += new System.EventHandler(this.SavePallete_Click);
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
    }
}