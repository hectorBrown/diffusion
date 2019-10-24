namespace Diffusion
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
            this.PB_main = new System.Windows.Forms.PictureBox();
            this.TIM_main = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PB_main)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_main
            // 
            this.PB_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_main.Location = new System.Drawing.Point(0, 0);
            this.PB_main.Name = "PB_main";
            this.PB_main.Size = new System.Drawing.Size(644, 437);
            this.PB_main.TabIndex = 0;
            this.PB_main.TabStop = false;
            this.PB_main.Paint += new System.Windows.Forms.PaintEventHandler(this.PB_main_Paint);
            // 
            // TIM_main
            // 
            this.TIM_main.Enabled = true;
            this.TIM_main.Interval = 10;
            this.TIM_main.Tick += new System.EventHandler(this.TIM_main_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 437);
            this.Controls.Add(this.PB_main);
            this.Name = "Form1";
            this.Text = "Diffusion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_main;
        private System.Windows.Forms.Timer TIM_main;
    }
}

