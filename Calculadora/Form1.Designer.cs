namespace Calculadora
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOper = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btSoma = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.btMult = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.numOper1 = new System.Windows.Forms.NumericUpDown();
            this.numOper2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numOper1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOper2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operando 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operando 2";
            // 
            // lblOper
            // 
            this.lblOper.AutoSize = true;
            this.lblOper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOper.Location = new System.Drawing.Point(429, 127);
            this.lblOper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOper.Name = "lblOper";
            this.lblOper.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblOper.Size = new System.Drawing.Size(21, 20);
            this.lblOper.TabIndex = 2;
            this.lblOper.Text = "...";
            this.lblOper.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(-9, 294);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(763, 20);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "label4";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btSoma
            // 
            this.btSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSoma.Location = new System.Drawing.Point(281, 119);
            this.btSoma.Margin = new System.Windows.Forms.Padding(4);
            this.btSoma.Name = "btSoma";
            this.btSoma.Size = new System.Drawing.Size(29, 28);
            this.btSoma.TabIndex = 5;
            this.btSoma.Text = "+";
            this.btSoma.UseVisualStyleBackColor = true;
            this.btSoma.Click += new System.EventHandler(this.btSoma_Click);
            // 
            // btSub
            // 
            this.btSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSub.Location = new System.Drawing.Point(318, 119);
            this.btSub.Margin = new System.Windows.Forms.Padding(4);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(29, 28);
            this.btSub.TabIndex = 6;
            this.btSub.Text = "-";
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // btMult
            // 
            this.btMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMult.Location = new System.Drawing.Point(355, 119);
            this.btMult.Margin = new System.Windows.Forms.Padding(4);
            this.btMult.Name = "btMult";
            this.btMult.Size = new System.Drawing.Size(29, 28);
            this.btMult.TabIndex = 7;
            this.btMult.Text = "x";
            this.btMult.UseVisualStyleBackColor = true;
            this.btMult.Click += new System.EventHandler(this.btMult_Click);
            // 
            // btDiv
            // 
            this.btDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDiv.Location = new System.Drawing.Point(392, 119);
            this.btDiv.Margin = new System.Windows.Forms.Padding(4);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(29, 28);
            this.btDiv.TabIndex = 8;
            this.btDiv.Text = "÷";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.div_Click);
            // 
            // btIgual
            // 
            this.btIgual.Enabled = false;
            this.btIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIgual.Location = new System.Drawing.Point(318, 226);
            this.btIgual.Margin = new System.Windows.Forms.Padding(4);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(103, 28);
            this.btIgual.TabIndex = 9;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = true;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // numOper1
            // 
            this.numOper1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOper1.Location = new System.Drawing.Point(375, 62);
            this.numOper1.Margin = new System.Windows.Forms.Padding(4);
            this.numOper1.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.numOper1.Minimum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            -2147483648});
            this.numOper1.Name = "numOper1";
            this.numOper1.Size = new System.Drawing.Size(72, 26);
            this.numOper1.TabIndex = 10;
            // 
            // numOper2
            // 
            this.numOper2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOper2.Location = new System.Drawing.Point(375, 182);
            this.numOper2.Margin = new System.Windows.Forms.Padding(4);
            this.numOper2.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.numOper2.Minimum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            -2147483648});
            this.numOper2.Name = "numOper2";
            this.numOper2.Size = new System.Drawing.Size(72, 26);
            this.numOper2.TabIndex = 11;
            this.numOper2.ValueChanged += new System.EventHandler(this.numOper2_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 444);
            this.Controls.Add(this.numOper2);
            this.Controls.Add(this.numOper1);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btMult);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.btSoma);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblOper);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Calculadora ";
            ((System.ComponentModel.ISupportInitialize)(this.numOper1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOper2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOper;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btSoma;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btMult;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.NumericUpDown numOper1;
        private System.Windows.Forms.NumericUpDown numOper2;
    }
}

