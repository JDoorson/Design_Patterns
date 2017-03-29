namespace Opdracht1.Controllers
{
    partial class ControlPanel
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
            this.bttnVoegDisplayToe = new System.Windows.Forms.Button();
            this.bttnVolgendStation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnVoegDisplayToe
            // 
            this.bttnVoegDisplayToe.Location = new System.Drawing.Point(13, 26);
            this.bttnVoegDisplayToe.Name = "bttnVoegDisplayToe";
            this.bttnVoegDisplayToe.Size = new System.Drawing.Size(294, 93);
            this.bttnVoegDisplayToe.TabIndex = 0;
            this.bttnVoegDisplayToe.Text = "Voeg Display toe";
            this.bttnVoegDisplayToe.UseVisualStyleBackColor = true;
            this.bttnVoegDisplayToe.Click += new System.EventHandler(this.bttnVoegDisplayToe_Click);
            // 
            // bttnVolgendStation
            // 
            this.bttnVolgendStation.Location = new System.Drawing.Point(13, 125);
            this.bttnVolgendStation.Name = "bttnVolgendStation";
            this.bttnVolgendStation.Size = new System.Drawing.Size(294, 116);
            this.bttnVolgendStation.TabIndex = 1;
            this.bttnVolgendStation.Text = "Volgend station";
            this.bttnVolgendStation.UseVisualStyleBackColor = true;
            this.bttnVolgendStation.Click += new System.EventHandler(this.bttnVolgendStation_Click);
            // 
            // ControlPanel
            // 
            this.ClientSize = new System.Drawing.Size(319, 253);
            this.Controls.Add(this.bttnVolgendStation);
            this.Controls.Add(this.bttnVoegDisplayToe);
            this.Name = "ControlPanel";
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Button button1;
        //private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bttnVoegDisplayToe;
        public System.Windows.Forms.Button bttnVolgendStation;
    }
}