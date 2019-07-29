namespace MoodiesTool
{
    partial class Tools
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
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.slider = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.BackgroundImage = global::MoodiesTool.Properties.Resources.color1;
            this.btnColor.Location = new System.Drawing.Point(60, 12);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(40, 38);
            this.btnColor.TabIndex = 1;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnColor_MouseClick_1);
            // 
            // slider
            // 
            this.slider.BackColor = System.Drawing.Color.Transparent;
            this.slider.BackgroundImage = global::MoodiesTool.Properties.Resources.slider3;
            this.slider.Location = new System.Drawing.Point(12, 12);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(42, 38);
            this.slider.TabIndex = 0;
            this.slider.UseVisualStyleBackColor = false;
            this.slider.Click += new System.EventHandler(this.slider_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 56);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 173);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Visible = false;
            this.trackBar1.ValueChanged += new System.EventHandler(this.Slider_ValueChanged);
            // 
            // Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(120, 825);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.slider);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Tools";
            this.Text = "Tools";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tools_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button slider;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        public System.Windows.Forms.TrackBar trackBar1;
    }
}