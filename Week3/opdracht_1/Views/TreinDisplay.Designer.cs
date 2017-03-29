namespace Opdracht1.Views
{
    partial class TreinDisplay
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
            this.lblHuidigStation = new System.Windows.Forms.Label();
            this.lblSpoor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAankomsttijd = new System.Windows.Forms.Label();
            this.lblVertrektijd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHuidigStation
            // 
            this.lblHuidigStation.AutoSize = true;
            this.lblHuidigStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuidigStation.Location = new System.Drawing.Point(193, 37);
            this.lblHuidigStation.Name = "lblHuidigStation";
            this.lblHuidigStation.Size = new System.Drawing.Size(112, 20);
            this.lblHuidigStation.TabIndex = 0;
            this.lblHuidigStation.Text = "Huidig station";
            this.lblHuidigStation.Click += new System.EventHandler(this.HuidigStation_Click);
            // 
            // lblSpoor
            // 
            this.lblSpoor.AutoSize = true;
            this.lblSpoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpoor.Location = new System.Drawing.Point(193, 81);
            this.lblSpoor.Name = "lblSpoor";
            this.lblSpoor.Size = new System.Drawing.Size(53, 20);
            this.lblSpoor.TabIndex = 1;
            this.lblSpoor.Text = "Spoor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Huidig station:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Spoor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aankomsttijd:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vertrektijd:";
            // 
            // lblAankomsttijd
            // 
            this.lblAankomsttijd.AutoSize = true;
            this.lblAankomsttijd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAankomsttijd.Location = new System.Drawing.Point(193, 119);
            this.lblAankomsttijd.Name = "lblAankomsttijd";
            this.lblAankomsttijd.Size = new System.Drawing.Size(14, 20);
            this.lblAankomsttijd.TabIndex = 7;
            this.lblAankomsttijd.Text = " ";
            // 
            // lblVertrektijd
            // 
            this.lblVertrektijd.AutoSize = true;
            this.lblVertrektijd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVertrektijd.Location = new System.Drawing.Point(193, 158);
            this.lblVertrektijd.Name = "lblVertrektijd";
            this.lblVertrektijd.Size = new System.Drawing.Size(14, 20);
            this.lblVertrektijd.TabIndex = 8;
            this.lblVertrektijd.Text = " ";
            // 
            // TreinDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 253);
            this.Controls.Add(this.lblVertrektijd);
            this.Controls.Add(this.lblAankomsttijd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSpoor);
            this.Controls.Add(this.lblHuidigStation);
            this.Name = "TreinDisplay";
            this.Text = "Treindisplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHuidigStation;
        private System.Windows.Forms.Label lblSpoor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAankomsttijd;
        private System.Windows.Forms.Label lblVertrektijd;
    }
}