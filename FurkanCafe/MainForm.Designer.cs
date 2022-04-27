
namespace FurkanCafe
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InformationPanel = new System.Windows.Forms.Panel();
            this.movePanel = new System.Windows.Forms.Panel();
            this.fieldPanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.labelClock);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 95);
            this.panel2.TabIndex = 1;
            // 
            // labelClock
            // 
            this.labelClock.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClock.Location = new System.Drawing.Point(680, 0);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(120, 95);
            this.labelClock.TabIndex = 1;
            this.labelClock.Text = "0:00";
            this.labelClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(53, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 63);
            this.label3.TabIndex = 0;
            this.label3.Text = "Press ENTER to start the game.\r\nUse the direction keys to move the product collec" +
    "tion bar.\r\nPress \"P\" to pause the game.";
            // 
            // InformationPanel
            // 
            this.InformationPanel.BackColor = System.Drawing.SystemColors.Info;
            this.InformationPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.InformationPanel.Location = new System.Drawing.Point(600, 95);
            this.InformationPanel.Name = "InformationPanel";
            this.InformationPanel.Size = new System.Drawing.Size(200, 394);
            this.InformationPanel.TabIndex = 2;
            // 
            // movePanel
            // 
            this.movePanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.movePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.movePanel.Location = new System.Drawing.Point(0, 389);
            this.movePanel.Name = "movePanel";
            this.movePanel.Size = new System.Drawing.Size(600, 100);
            this.movePanel.TabIndex = 3;
            // 
            // fieldPanel
            // 
            this.fieldPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.fieldPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldPanel.Location = new System.Drawing.Point(0, 95);
            this.fieldPanel.Name = "fieldPanel";
            this.fieldPanel.Size = new System.Drawing.Size(600, 294);
            this.fieldPanel.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.fieldPanel);
            this.Controls.Add(this.movePanel);
            this.Controls.Add(this.InformationPanel);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Panel InformationPanel;
        private System.Windows.Forms.Panel movePanel;
        private System.Windows.Forms.Panel fieldPanel;
    }
}

