namespace Piano
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_left = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_left
            // 
            this.button_left.Location = new System.Drawing.Point(12, 12);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(75, 23);
            this.button_left.TabIndex = 0;
            this.button_left.Text = "<<";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_right
            // 
            this.button_right.Location = new System.Drawing.Point(93, 12);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(75, 23);
            this.button_right.TabIndex = 1;
            this.button_right.Text = ">>";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.button_left);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GeneratePianoButtons);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_left;
        private Button button_right;
    }
}