namespace SomaSnake
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
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.levelLabelText = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.foodTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 50;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // levelLabelText
            // 
            this.levelLabelText.AutoSize = true;
            this.levelLabelText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.levelLabelText.ForeColor = System.Drawing.Color.Blue;
            this.levelLabelText.Location = new System.Drawing.Point(13, 13);
            this.levelLabelText.Name = "levelLabelText";
            this.levelLabelText.Size = new System.Drawing.Size(64, 26);
            this.levelLabelText.TabIndex = 0;
            this.levelLabelText.Text = "Szint:";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.levelLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.levelLabel.Location = new System.Drawing.Point(72, 13);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(21, 26);
            this.levelLabel.TabIndex = 1;
            this.levelLabel.Text = "1";
            // 
            // foodTimer
            // 
            this.foodTimer.Interval = 10000;
            this.foodTimer.Tick += new System.EventHandler(this.foodTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.levelLabelText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "SomaSnake v.0.4 Alpha";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Label levelLabelText;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Timer foodTimer;
    }
}

