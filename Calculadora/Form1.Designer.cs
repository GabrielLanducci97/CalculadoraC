﻿namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.btnNum7 = new System.Windows.Forms.Button();
			this.btnNum8 = new System.Windows.Forms.Button();
			this.btnNum9 = new System.Windows.Forms.Button();
			this.btnOpSum = new System.Windows.Forms.Button();
			this.btnOpRes = new System.Windows.Forms.Button();
			this.btnNum6 = new System.Windows.Forms.Button();
			this.btnNum5 = new System.Windows.Forms.Button();
			this.btnNum4 = new System.Windows.Forms.Button();
			this.btnOpMul = new System.Windows.Forms.Button();
			this.btnNum3 = new System.Windows.Forms.Button();
			this.btnNum2 = new System.Windows.Forms.Button();
			this.btnNum1 = new System.Windows.Forms.Button();
			this.btnOpDiv = new System.Windows.Forms.Button();
			this.btnOpIgual = new System.Windows.Forms.Button();
			this.btnNum0 = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.textValue = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnNum7
			// 
			this.btnNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNum7.Location = new System.Drawing.Point(25, 62);
			this.btnNum7.Name = "btnNum7";
			this.btnNum7.Size = new System.Drawing.Size(115, 115);
			this.btnNum7.TabIndex = 0;
			this.btnNum7.Text = "7";
			this.btnNum7.UseVisualStyleBackColor = true;
			this.btnNum7.Click += new System.EventHandler(this.NumberAction_Click);
			// 
			// btnNum8
			// 
			this.btnNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNum8.Location = new System.Drawing.Point(146, 62);
			this.btnNum8.Name = "btnNum8";
			this.btnNum8.Size = new System.Drawing.Size(115, 115);
			this.btnNum8.TabIndex = 1;
			this.btnNum8.Text = "8";
			this.btnNum8.UseVisualStyleBackColor = true;
			this.btnNum8.Click += new System.EventHandler(this.NumberAction_Click);
			// 
			// btnNum9
			// 
			this.btnNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNum9.Location = new System.Drawing.Point(267, 62);
			this.btnNum9.Name = "btnNum9";
			this.btnNum9.Size = new System.Drawing.Size(115, 115);
			this.btnNum9.TabIndex = 2;
			this.btnNum9.Text = "9";
			this.btnNum9.UseVisualStyleBackColor = true;
			this.btnNum9.Click += new System.EventHandler(this.NumberAction_Click);
			// 
			// btnOpSum
			// 
			this.btnOpSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpSum.Location = new System.Drawing.Point(388, 62);
			this.btnOpSum.Name = "btnOpSum";
			this.btnOpSum.Size = new System.Drawing.Size(115, 115);
			this.btnOpSum.TabIndex = 3;
			this.btnOpSum.Text = "+";
			this.btnOpSum.UseVisualStyleBackColor = true;
			this.btnOpSum.Click += new System.EventHandler(this.OperatorAction_Click);
			// 
			// btnOpRes
			// 
			this.btnOpRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpRes.Location = new System.Drawing.Point(388, 183);
			this.btnOpRes.Name = "btnOpRes";
			this.btnOpRes.Size = new System.Drawing.Size(115, 115);
			this.btnOpRes.TabIndex = 7;
			this.btnOpRes.Text = "-";
			this.btnOpRes.UseVisualStyleBackColor = true;
			this.btnOpRes.Click += new System.EventHandler(this.OperatorAction_Click);
			// 
			// btnNum6
			// 
			this.btnNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNum6.Location = new System.Drawing.Point(267, 183);
			this.btnNum6.Name = "btnNum6";
			this.btnNum6.Size = new System.Drawing.Size(115, 115);
			this.btnNum6.TabIndex = 6;
			this.btnNum6.Text = "6";
			this.btnNum6.UseVisualStyleBackColor = true;
			this.btnNum6.Click += new System.EventHandler(this.NumberAction_Click);
			// 
			// btnNum5
			// 
			this.btnNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNum5.Location = new System.Drawing.Point(146, 183);
			this.btnNum5.Name = "btnNum5";
			this.btnNum5.Size = new System.Drawing.Size(115, 115);
			this.btnNum5.TabIndex = 5;
			this.btnNum5.Text = "5";
			this.btnNum5.UseVisualStyleBackColor = true;
			this.btnNum5.Click += new System.EventHandler(this.NumberAction_Click);
			// 
			// btnNum4
			// 
			this.btnNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNum4.Location = new System.Drawing.Point(25, 183);
			this.btnNum4.Name = "btnNum4";
			this.btnNum4.Size = new System.Drawing.Size(115, 115);
			this.btnNum4.TabIndex = 4;
			this.btnNum4.Text = "4";
			this.btnNum4.UseVisualStyleBackColor = true;
			this.btnNum4.Click += new System.EventHandler(this.NumberAction_Click);
			// 
			// btnOpMul
			// 
			this.btnOpMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpMul.Location = new System.Drawing.Point(388, 304);
			this.btnOpMul.Name = "btnOpMul";
			this.btnOpMul.Size = new System.Drawing.Size(115, 115);
			this.btnOpMul.TabIndex = 11;
			this.btnOpMul.Text = "x";
			this.btnOpMul.UseVisualStyleBackColor = true;
			this.btnOpMul.Click += new System.EventHandler(this.OperatorAction_Click);
			// 
			// btnNum3
			// 
			this.btnNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNum3.Location = new System.Drawing.Point(267, 304);
			this.btnNum3.Name = "btnNum3";
			this.btnNum3.Size = new System.Drawing.Size(115, 115);
			this.btnNum3.TabIndex = 10;
			this.btnNum3.Text = "3";
			this.btnNum3.UseVisualStyleBackColor = true;
			this.btnNum3.Click += new System.EventHandler(this.NumberAction_Click);
			// 
			// btnNum2
			// 
			this.btnNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNum2.Location = new System.Drawing.Point(146, 304);
			this.btnNum2.Name = "btnNum2";
			this.btnNum2.Size = new System.Drawing.Size(115, 115);
			this.btnNum2.TabIndex = 9;
			this.btnNum2.Text = "2";
			this.btnNum2.UseVisualStyleBackColor = true;
			this.btnNum2.Click += new System.EventHandler(this.NumberAction_Click);
			// 
			// btnNum1
			// 
			this.btnNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNum1.Location = new System.Drawing.Point(25, 304);
			this.btnNum1.Name = "btnNum1";
			this.btnNum1.Size = new System.Drawing.Size(115, 115);
			this.btnNum1.TabIndex = 8;
			this.btnNum1.Text = "1";
			this.btnNum1.UseVisualStyleBackColor = true;
			this.btnNum1.Click += new System.EventHandler(this.NumberAction_Click);
			// 
			// btnOpDiv
			// 
			this.btnOpDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpDiv.Location = new System.Drawing.Point(388, 424);
			this.btnOpDiv.Name = "btnOpDiv";
			this.btnOpDiv.Size = new System.Drawing.Size(115, 115);
			this.btnOpDiv.TabIndex = 15;
			this.btnOpDiv.Text = "/";
			this.btnOpDiv.UseVisualStyleBackColor = true;
			this.btnOpDiv.Click += new System.EventHandler(this.OperatorAction_Click);
			// 
			// btnOpIgual
			// 
			this.btnOpIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpIgual.Location = new System.Drawing.Point(267, 425);
			this.btnOpIgual.Name = "btnOpIgual";
			this.btnOpIgual.Size = new System.Drawing.Size(115, 115);
			this.btnOpIgual.TabIndex = 14;
			this.btnOpIgual.Text = "=";
			this.btnOpIgual.UseVisualStyleBackColor = true;
			this.btnOpIgual.Click += new System.EventHandler(this.btnOpIgual_Click);
			// 
			// btnNum0
			// 
			this.btnNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNum0.Location = new System.Drawing.Point(146, 425);
			this.btnNum0.Name = "btnNum0";
			this.btnNum0.Size = new System.Drawing.Size(115, 115);
			this.btnNum0.TabIndex = 13;
			this.btnNum0.Text = "0";
			this.btnNum0.UseVisualStyleBackColor = true;
			this.btnNum0.Click += new System.EventHandler(this.NumberAction_Click);
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(25, 425);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(115, 115);
			this.btnClear.TabIndex = 12;
			this.btnClear.Text = "C";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// textValue
			// 
			this.textValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textValue.Location = new System.Drawing.Point(25, 12);
			this.textValue.Name = "textValue";
			this.textValue.Size = new System.Drawing.Size(478, 44);
			this.textValue.TabIndex = 16;
			this.textValue.Text = "0";
			this.textValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(528, 551);
			this.Controls.Add(this.textValue);
			this.Controls.Add(this.btnOpDiv);
			this.Controls.Add(this.btnOpIgual);
			this.Controls.Add(this.btnNum0);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnOpMul);
			this.Controls.Add(this.btnNum3);
			this.Controls.Add(this.btnNum2);
			this.Controls.Add(this.btnNum1);
			this.Controls.Add(this.btnOpRes);
			this.Controls.Add(this.btnNum6);
			this.Controls.Add(this.btnNum5);
			this.Controls.Add(this.btnNum4);
			this.Controls.Add(this.btnOpSum);
			this.Controls.Add(this.btnNum9);
			this.Controls.Add(this.btnNum8);
			this.Controls.Add(this.btnNum7);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnOpSum;
        private System.Windows.Forms.Button btnOpRes;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnOpMul;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnOpDiv;
        private System.Windows.Forms.Button btnOpIgual;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textValue;
    }
}

