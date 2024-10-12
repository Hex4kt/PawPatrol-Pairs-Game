namespace MatheQuiz
{
    partial class Mathequiz
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblVerbleibeneZeit = new System.Windows.Forms.Label();
            this.lblLeftNumber = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblRightNumber = new System.Windows.Forms.Label();
            this.lblGleichheitszeichen = new System.Windows.Forms.Label();
            this.numErgebnis = new System.Windows.Forms.NumericUpDown();
            this.lblLeftNumber2 = new System.Windows.Forms.Label();
            this.lblLeftNumber3 = new System.Windows.Forms.Label();
            this.lblLeftNumber4 = new System.Windows.Forms.Label();
            this.lblOperator2 = new System.Windows.Forms.Label();
            this.lblOperator3 = new System.Windows.Forms.Label();
            this.lblOperator4 = new System.Windows.Forms.Label();
            this.lblRightNumber2 = new System.Windows.Forms.Label();
            this.lblRightNumber3 = new System.Windows.Forms.Label();
            this.lblRightNumber4 = new System.Windows.Forms.Label();
            this.lblGleichheitszeichen2 = new System.Windows.Forms.Label();
            this.lblGleichheitszeichen3 = new System.Windows.Forms.Label();
            this.lblGleichheitszeichen4 = new System.Windows.Forms.Label();
            this.numErgebnis2 = new System.Windows.Forms.NumericUpDown();
            this.numErgebnis3 = new System.Windows.Forms.NumericUpDown();
            this.numErgebnis4 = new System.Windows.Forms.NumericUpDown();
            this.startQuiz = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.korrektIndikator = new System.Windows.Forms.Label();
            this.korrekt2Indikator = new System.Windows.Forms.Label();
            this.korrekt3Indikator = new System.Windows.Forms.Label();
            this.korrekt4Indikator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numErgebnis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numErgebnis2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numErgebnis3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numErgebnis4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(272, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(200, 30);
            this.lblTime.TabIndex = 0;
            // 
            // lblVerbleibeneZeit
            // 
            this.lblVerbleibeneZeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerbleibeneZeit.Location = new System.Drawing.Point(100, 10);
            this.lblVerbleibeneZeit.Name = "lblVerbleibeneZeit";
            this.lblVerbleibeneZeit.Size = new System.Drawing.Size(166, 30);
            this.lblVerbleibeneZeit.TabIndex = 1;
            this.lblVerbleibeneZeit.Text = "verbleibene Zeit";
            // 
            // lblLeftNumber
            // 
            this.lblLeftNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftNumber.Location = new System.Drawing.Point(55, 78);
            this.lblLeftNumber.Name = "lblLeftNumber";
            this.lblLeftNumber.Size = new System.Drawing.Size(60, 50);
            this.lblLeftNumber.TabIndex = 2;
            this.lblLeftNumber.Text = "?";
            this.lblLeftNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOperator
            // 
            this.lblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.Location = new System.Drawing.Point(121, 78);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(60, 50);
            this.lblOperator.TabIndex = 3;
            this.lblOperator.Text = "+";
            this.lblOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRightNumber
            // 
            this.lblRightNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightNumber.Location = new System.Drawing.Point(187, 78);
            this.lblRightNumber.Name = "lblRightNumber";
            this.lblRightNumber.Size = new System.Drawing.Size(60, 50);
            this.lblRightNumber.TabIndex = 4;
            this.lblRightNumber.Text = "?";
            this.lblRightNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGleichheitszeichen
            // 
            this.lblGleichheitszeichen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGleichheitszeichen.Location = new System.Drawing.Point(253, 75);
            this.lblGleichheitszeichen.Name = "lblGleichheitszeichen";
            this.lblGleichheitszeichen.Size = new System.Drawing.Size(60, 50);
            this.lblGleichheitszeichen.TabIndex = 5;
            this.lblGleichheitszeichen.Text = "=";
            this.lblGleichheitszeichen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numErgebnis
            // 
            this.numErgebnis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numErgebnis.Location = new System.Drawing.Point(319, 84);
            this.numErgebnis.Name = "numErgebnis";
            this.numErgebnis.Size = new System.Drawing.Size(100, 35);
            this.numErgebnis.TabIndex = 1;
            this.numErgebnis.ValueChanged += new System.EventHandler(this.answer_Changed);
            this.numErgebnis.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // lblLeftNumber2
            // 
            this.lblLeftNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftNumber2.Location = new System.Drawing.Point(55, 128);
            this.lblLeftNumber2.Name = "lblLeftNumber2";
            this.lblLeftNumber2.Size = new System.Drawing.Size(60, 50);
            this.lblLeftNumber2.TabIndex = 7;
            this.lblLeftNumber2.Text = "?";
            this.lblLeftNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLeftNumber3
            // 
            this.lblLeftNumber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftNumber3.Location = new System.Drawing.Point(55, 178);
            this.lblLeftNumber3.Name = "lblLeftNumber3";
            this.lblLeftNumber3.Size = new System.Drawing.Size(60, 50);
            this.lblLeftNumber3.TabIndex = 8;
            this.lblLeftNumber3.Text = "?";
            this.lblLeftNumber3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLeftNumber4
            // 
            this.lblLeftNumber4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftNumber4.Location = new System.Drawing.Point(55, 228);
            this.lblLeftNumber4.Name = "lblLeftNumber4";
            this.lblLeftNumber4.Size = new System.Drawing.Size(60, 50);
            this.lblLeftNumber4.TabIndex = 9;
            this.lblLeftNumber4.Text = "?";
            this.lblLeftNumber4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOperator2
            // 
            this.lblOperator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator2.Location = new System.Drawing.Point(121, 128);
            this.lblOperator2.Name = "lblOperator2";
            this.lblOperator2.Size = new System.Drawing.Size(60, 50);
            this.lblOperator2.TabIndex = 10;
            this.lblOperator2.Text = "-";
            this.lblOperator2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOperator3
            // 
            this.lblOperator3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator3.Location = new System.Drawing.Point(121, 178);
            this.lblOperator3.Name = "lblOperator3";
            this.lblOperator3.Size = new System.Drawing.Size(60, 50);
            this.lblOperator3.TabIndex = 11;
            this.lblOperator3.Text = "*";
            this.lblOperator3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOperator4
            // 
            this.lblOperator4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator4.Location = new System.Drawing.Point(121, 228);
            this.lblOperator4.Name = "lblOperator4";
            this.lblOperator4.Size = new System.Drawing.Size(60, 50);
            this.lblOperator4.TabIndex = 12;
            this.lblOperator4.Text = "/";
            this.lblOperator4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRightNumber2
            // 
            this.lblRightNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightNumber2.Location = new System.Drawing.Point(187, 128);
            this.lblRightNumber2.Name = "lblRightNumber2";
            this.lblRightNumber2.Size = new System.Drawing.Size(60, 50);
            this.lblRightNumber2.TabIndex = 13;
            this.lblRightNumber2.Text = "?";
            this.lblRightNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRightNumber3
            // 
            this.lblRightNumber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightNumber3.Location = new System.Drawing.Point(187, 178);
            this.lblRightNumber3.Name = "lblRightNumber3";
            this.lblRightNumber3.Size = new System.Drawing.Size(60, 50);
            this.lblRightNumber3.TabIndex = 14;
            this.lblRightNumber3.Text = "?";
            this.lblRightNumber3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRightNumber4
            // 
            this.lblRightNumber4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightNumber4.Location = new System.Drawing.Point(187, 228);
            this.lblRightNumber4.Name = "lblRightNumber4";
            this.lblRightNumber4.Size = new System.Drawing.Size(60, 50);
            this.lblRightNumber4.TabIndex = 15;
            this.lblRightNumber4.Text = "?";
            this.lblRightNumber4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGleichheitszeichen2
            // 
            this.lblGleichheitszeichen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGleichheitszeichen2.Location = new System.Drawing.Point(253, 128);
            this.lblGleichheitszeichen2.Name = "lblGleichheitszeichen2";
            this.lblGleichheitszeichen2.Size = new System.Drawing.Size(60, 50);
            this.lblGleichheitszeichen2.TabIndex = 16;
            this.lblGleichheitszeichen2.Text = "=";
            this.lblGleichheitszeichen2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGleichheitszeichen3
            // 
            this.lblGleichheitszeichen3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGleichheitszeichen3.Location = new System.Drawing.Point(253, 178);
            this.lblGleichheitszeichen3.Name = "lblGleichheitszeichen3";
            this.lblGleichheitszeichen3.Size = new System.Drawing.Size(60, 50);
            this.lblGleichheitszeichen3.TabIndex = 17;
            this.lblGleichheitszeichen3.Text = "=";
            this.lblGleichheitszeichen3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGleichheitszeichen4
            // 
            this.lblGleichheitszeichen4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGleichheitszeichen4.Location = new System.Drawing.Point(253, 225);
            this.lblGleichheitszeichen4.Name = "lblGleichheitszeichen4";
            this.lblGleichheitszeichen4.Size = new System.Drawing.Size(60, 50);
            this.lblGleichheitszeichen4.TabIndex = 18;
            this.lblGleichheitszeichen4.Text = "=";
            this.lblGleichheitszeichen4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numErgebnis2
            // 
            this.numErgebnis2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numErgebnis2.Location = new System.Drawing.Point(319, 137);
            this.numErgebnis2.Name = "numErgebnis2";
            this.numErgebnis2.Size = new System.Drawing.Size(100, 35);
            this.numErgebnis2.TabIndex = 2;
            this.numErgebnis2.ValueChanged += new System.EventHandler(this.answer_Changed);
            this.numErgebnis2.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // numErgebnis3
            // 
            this.numErgebnis3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numErgebnis3.Location = new System.Drawing.Point(319, 187);
            this.numErgebnis3.Name = "numErgebnis3";
            this.numErgebnis3.Size = new System.Drawing.Size(100, 35);
            this.numErgebnis3.TabIndex = 3;
            this.numErgebnis3.ValueChanged += new System.EventHandler(this.answer_Changed);
            this.numErgebnis3.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // numErgebnis4
            // 
            this.numErgebnis4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numErgebnis4.Location = new System.Drawing.Point(319, 234);
            this.numErgebnis4.Name = "numErgebnis4";
            this.numErgebnis4.Size = new System.Drawing.Size(100, 35);
            this.numErgebnis4.TabIndex = 4;
            this.numErgebnis4.ValueChanged += new System.EventHandler(this.answer_Changed);
            this.numErgebnis4.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // startQuiz
            // 
            this.startQuiz.AutoSize = true;
            this.startQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startQuiz.Location = new System.Drawing.Point(189, 300);
            this.startQuiz.Name = "startQuiz";
            this.startQuiz.Size = new System.Drawing.Size(124, 34);
            this.startQuiz.TabIndex = 0;
            this.startQuiz.Text = "Quiz starten!";
            this.startQuiz.UseVisualStyleBackColor = true;
            this.startQuiz.Click += new System.EventHandler(this.startQuiz_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // korrektIndikator
            // 
            this.korrektIndikator.AutoSize = true;
            this.korrektIndikator.Location = new System.Drawing.Point(425, 98);
            this.korrektIndikator.Name = "korrektIndikator";
            this.korrektIndikator.Size = new System.Drawing.Size(37, 13);
            this.korrektIndikator.TabIndex = 19;
            this.korrektIndikator.Text = "          ";
            // 
            // korrekt2Indikator
            // 
            this.korrekt2Indikator.AutoSize = true;
            this.korrekt2Indikator.Location = new System.Drawing.Point(425, 151);
            this.korrekt2Indikator.Name = "korrekt2Indikator";
            this.korrekt2Indikator.Size = new System.Drawing.Size(37, 13);
            this.korrekt2Indikator.TabIndex = 20;
            this.korrekt2Indikator.Text = "          ";
            // 
            // korrekt3Indikator
            // 
            this.korrekt3Indikator.AutoSize = true;
            this.korrekt3Indikator.Location = new System.Drawing.Point(425, 201);
            this.korrekt3Indikator.Name = "korrekt3Indikator";
            this.korrekt3Indikator.Size = new System.Drawing.Size(37, 13);
            this.korrekt3Indikator.TabIndex = 21;
            this.korrekt3Indikator.Text = "          ";
            // 
            // korrekt4Indikator
            // 
            this.korrekt4Indikator.AutoSize = true;
            this.korrekt4Indikator.Location = new System.Drawing.Point(425, 248);
            this.korrekt4Indikator.Name = "korrekt4Indikator";
            this.korrekt4Indikator.Size = new System.Drawing.Size(37, 13);
            this.korrekt4Indikator.TabIndex = 22;
            this.korrekt4Indikator.Text = "          ";
            // 
            // Mathequiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.korrekt4Indikator);
            this.Controls.Add(this.korrekt3Indikator);
            this.Controls.Add(this.korrekt2Indikator);
            this.Controls.Add(this.korrektIndikator);
            this.Controls.Add(this.startQuiz);
            this.Controls.Add(this.numErgebnis4);
            this.Controls.Add(this.numErgebnis3);
            this.Controls.Add(this.numErgebnis2);
            this.Controls.Add(this.lblGleichheitszeichen4);
            this.Controls.Add(this.lblGleichheitszeichen3);
            this.Controls.Add(this.lblGleichheitszeichen2);
            this.Controls.Add(this.lblRightNumber4);
            this.Controls.Add(this.lblRightNumber3);
            this.Controls.Add(this.lblRightNumber2);
            this.Controls.Add(this.lblOperator4);
            this.Controls.Add(this.lblOperator3);
            this.Controls.Add(this.lblOperator2);
            this.Controls.Add(this.lblLeftNumber4);
            this.Controls.Add(this.lblLeftNumber3);
            this.Controls.Add(this.lblLeftNumber2);
            this.Controls.Add(this.numErgebnis);
            this.Controls.Add(this.lblGleichheitszeichen);
            this.Controls.Add(this.lblRightNumber);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblLeftNumber);
            this.Controls.Add(this.lblVerbleibeneZeit);
            this.Controls.Add(this.lblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Mathequiz";
            this.Text = "Mathequiz";
            ((System.ComponentModel.ISupportInitialize)(this.numErgebnis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numErgebnis2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numErgebnis3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numErgebnis4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblVerbleibeneZeit;
        private System.Windows.Forms.Label lblLeftNumber;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblRightNumber;
        private System.Windows.Forms.Label lblGleichheitszeichen;
        private System.Windows.Forms.NumericUpDown numErgebnis;
        private System.Windows.Forms.Label lblLeftNumber2;
        private System.Windows.Forms.Label lblLeftNumber3;
        private System.Windows.Forms.Label lblLeftNumber4;
        private System.Windows.Forms.Label lblOperator2;
        private System.Windows.Forms.Label lblOperator3;
        private System.Windows.Forms.Label lblOperator4;
        private System.Windows.Forms.Label lblRightNumber2;
        private System.Windows.Forms.Label lblRightNumber3;
        private System.Windows.Forms.Label lblRightNumber4;
        private System.Windows.Forms.Label lblGleichheitszeichen2;
        private System.Windows.Forms.Label lblGleichheitszeichen3;
        private System.Windows.Forms.Label lblGleichheitszeichen4;
        private System.Windows.Forms.NumericUpDown numErgebnis2;
        private System.Windows.Forms.NumericUpDown numErgebnis3;
        private System.Windows.Forms.NumericUpDown numErgebnis4;
        private System.Windows.Forms.Button startQuiz;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label korrektIndikator;
        private System.Windows.Forms.Label korrekt2Indikator;
        private System.Windows.Forms.Label korrekt3Indikator;
        private System.Windows.Forms.Label korrekt4Indikator;
    }
}

