namespace Starter
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
            lblClickCounter = new Label();
            btnClickMe = new Button();
            SuspendLayout();
            // 
            // lblClickCounter
            // 
            lblClickCounter.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblClickCounter.Location = new Point(295, 174);
            lblClickCounter.Name = "lblClickCounter";
            lblClickCounter.Size = new Size(188, 15);
            lblClickCounter.TabIndex = 1;
            lblClickCounter.Text = "0";
            lblClickCounter.TextAlign = ContentAlignment.MiddleCenter;
            lblClickCounter.Click += lblClickCounter_Click;
            // 
            // btnClickMe
            // 
            btnClickMe.Location = new Point(331, 210);
            btnClickMe.Name = "btnClickMe";
            btnClickMe.Size = new Size(106, 23);
            btnClickMe.TabIndex = 2;
            btnClickMe.Text = "Hier drücken!";
            btnClickMe.UseVisualStyleBackColor = true;
            btnClickMe.Click += btnClickMe_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClickMe);
            Controls.Add(lblClickCounter);
            Name = "Form1";
            Text = "Was kommt als Nächstes?";
            ResumeLayout(false);
        }

        #endregion
        private Label lblClickCounter;
        private Button btnClickMe;
    }
}
