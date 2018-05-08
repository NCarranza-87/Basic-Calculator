namespace BasicCalculator
{
    partial class frmBasicCalculator
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
            this.lblOperand1 = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblOperand2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOperand1
            // 
            this.lblOperand1.AutoSize = true;
            this.lblOperand1.Location = new System.Drawing.Point(46, 49);
            this.lblOperand1.Name = "lblOperand1";
            this.lblOperand1.Size = new System.Drawing.Size(60, 13);
            this.lblOperand1.TabIndex = 0;
            this.lblOperand1.Text = "Operand 1:";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(46, 78);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(51, 13);
            this.lblOperator.TabIndex = 1;
            this.lblOperator.Text = "Operator:";
            // 
            // lblOperand2
            // 
            this.lblOperand2.AutoSize = true;
            this.lblOperand2.Location = new System.Drawing.Point(46, 112);
            this.lblOperand2.Name = "lblOperand2";
            this.lblOperand2.Size = new System.Drawing.Size(60, 13);
            this.lblOperand2.TabIndex = 2;
            this.lblOperand2.Text = "Operand 2:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(46, 152);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(40, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result:";
            // 
            // txtOperand1
            // 
            this.txtOperand1.Location = new System.Drawing.Point(123, 49);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(100, 20);
            this.txtOperand1.TabIndex = 4;
            // 
            // txtOperator
            // 
            this.txtOperator.Location = new System.Drawing.Point(123, 78);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(100, 20);
            this.txtOperator.TabIndex = 5;
            // 
            // txtOperand2
            // 
            this.txtOperand2.Location = new System.Drawing.Point(122, 109);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(100, 20);
            this.txtOperand2.TabIndex = 6;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(122, 145);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(49, 183);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(147, 182);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // frmBasicCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 259);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.txtOperator);
            this.Controls.Add(this.txtOperand1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblOperand2);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblOperand1);
            this.Name = "frmBasicCalculator";
            this.Text = "Basic Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperand1;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblOperand2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtOperand1;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.TextBox txtOperand2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

