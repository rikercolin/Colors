using System.Drawing;
namespace Colors
{
    partial class OpeningForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpeningForm));
            this.btn_Start = new System.Windows.Forms.Button();
            this.lb_WelcomeText = new System.Windows.Forms.Label();
            this.FreepikCredit = new System.Windows.Forms.LinkLabel();
            this.TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TablePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            resources.ApplyResources(this.btn_Start, "btn_Start");
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // lb_WelcomeText
            // 
            this.lb_WelcomeText.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lb_WelcomeText, "lb_WelcomeText");
            this.lb_WelcomeText.ForeColor = System.Drawing.Color.Black;
            this.lb_WelcomeText.Name = "lb_WelcomeText";
            // 
            // FreepikCredit
            // 
            this.FreepikCredit.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(111)))), ((int)(((byte)(81)))));
            resources.ApplyResources(this.FreepikCredit, "FreepikCredit");
            this.FreepikCredit.BackColor = System.Drawing.Color.Transparent;
            this.FreepikCredit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(196)))), ((int)(((byte)(106)))));
            this.FreepikCredit.LinkColor = System.Drawing.Color.White;
            this.FreepikCredit.Name = "FreepikCredit";
            this.FreepikCredit.TabStop = true;
            this.FreepikCredit.UseCompatibleTextRendering = true;
            this.FreepikCredit.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.FreepikCredit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // TablePanel
            // 
            resources.ApplyResources(this.TablePanel, "TablePanel");
            this.TablePanel.Controls.Add(this.panel5, 4, 0);
            this.TablePanel.Controls.Add(this.panel4, 3, 0);
            this.TablePanel.Controls.Add(this.panel3, 2, 0);
            this.TablePanel.Controls.Add(this.panel2, 1, 0);
            this.TablePanel.Controls.Add(this.panel1, 0, 0);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TablePanel_Paint);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.FreepikCredit);
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.panel2.Name = "panel2";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(196)))), ((int)(((byte)(106)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lb_WelcomeText);
            this.panel3.Controls.Add(this.btn_Start);
            this.panel3.Name = "panel3";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.panel4.Name = "panel4";
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(111)))), ((int)(((byte)(81)))));
            this.panel5.Name = "panel5";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.label1.Name = "label1";
            // 
            // OpeningForm
            // 
            this.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.TablePanel);
            this.Name = "OpeningForm";
            this.Load += new System.EventHandler(this.OpeningForm_Load);
            this.TablePanel.ResumeLayout(false);
            this.TablePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label lb_WelcomeText;
        private System.Windows.Forms.LinkLabel FreepikCredit;
        private System.Windows.Forms.TableLayoutPanel TablePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}

