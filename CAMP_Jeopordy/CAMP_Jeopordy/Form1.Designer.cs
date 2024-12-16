namespace CAMP_Jeopordy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatAppearance.BorderSize = 0;
            button1.Location = new Point(276, 143);
            button1.Name = "button1";
            button1.Size = new Size(235, 72);
            button1.TabIndex = 1;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(276, 232);
            button2.Name = "button2";
            button2.Size = new Size(235, 72);
            button2.TabIndex = 2;
            button2.Text = "Rules";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft New Tai Lue", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(798, 74);
            label1.TabIndex = 3;
            label1.Text = "Welcome to CAMP Jeopardy!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "CAMP Jeopardy";
            Load += Form1_Load;
            Resize += Form1_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Label label1;
    }
}
