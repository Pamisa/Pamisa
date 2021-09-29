
namespace CalculatorApplication
{
    partial class FrmCalculator
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
            this.txtBoxInput1 = new System.Windows.Forms.TextBox();
            this.txtBoxInput2 = new System.Windows.Forms.TextBox();
            this.frstNumText = new System.Windows.Forms.Label();
            this.scndNumText = new System.Windows.Forms.Label();
            this.ansText = new System.Windows.Forms.Label();
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxInput1
            // 
            this.txtBoxInput1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxInput1.Location = new System.Drawing.Point(207, 21);
            this.txtBoxInput1.Name = "txtBoxInput1";
            this.txtBoxInput1.Size = new System.Drawing.Size(150, 29);
            this.txtBoxInput1.TabIndex = 0;
            // 
            // txtBoxInput2
            // 
            this.txtBoxInput2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxInput2.Location = new System.Drawing.Point(207, 89);
            this.txtBoxInput2.Name = "txtBoxInput2";
            this.txtBoxInput2.Size = new System.Drawing.Size(150, 29);
            this.txtBoxInput2.TabIndex = 2;
            // 
            // frstNumText
            // 
            this.frstNumText.AutoSize = true;
            this.frstNumText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frstNumText.Location = new System.Drawing.Point(25, 29);
            this.frstNumText.Name = "frstNumText";
            this.frstNumText.Size = new System.Drawing.Size(145, 21);
            this.frstNumText.TabIndex = 2;
            this.frstNumText.Text = "Enter First Number:";
            // 
            // scndNumText
            // 
            this.scndNumText.AutoSize = true;
            this.scndNumText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scndNumText.Location = new System.Drawing.Point(4, 97);
            this.scndNumText.Name = "scndNumText";
            this.scndNumText.Size = new System.Drawing.Size(166, 21);
            this.scndNumText.TabIndex = 3;
            this.scndNumText.Text = "Enter Second Number:";
            // 
            // ansText
            // 
            this.ansText.AutoSize = true;
            this.ansText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ansText.Location = new System.Drawing.Point(105, 145);
            this.ansText.Name = "ansText";
            this.ansText.Size = new System.Drawing.Size(65, 21);
            this.ansText.TabIndex = 4;
            this.ansText.Text = "Answer:";
            // 
            // cbOperator
            // 
            this.cbOperator.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.Location = new System.Drawing.Point(254, 56);
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.Size = new System.Drawing.Size(63, 27);
            this.cbOperator.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(207, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "____________________";
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEqual.Location = new System.Drawing.Point(242, 201);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(110, 32);
            this.btnEqual.TabIndex = 7;
            this.btnEqual.Text = "Calculate";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(46, 201);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 32);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.AutoSize = true;
            this.txtOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOutput.Location = new System.Drawing.Point(211, 139);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(0, 21);
            this.txtOutput.TabIndex = 9;
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 245);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOperator);
            this.Controls.Add(this.ansText);
            this.Controls.Add(this.scndNumText);
            this.Controls.Add(this.frstNumText);
            this.Controls.Add(this.txtBoxInput2);
            this.Controls.Add(this.txtBoxInput1);
            this.Name = "FrmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxInput1;
        private System.Windows.Forms.TextBox txtBoxInput2;
        private System.Windows.Forms.Label frstNumText;
        private System.Windows.Forms.Label scndNumText;
        private System.Windows.Forms.Label ansText;
        private System.Windows.Forms.ComboBox cbOperator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label txtOutput;
    }
}

