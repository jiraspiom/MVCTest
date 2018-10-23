namespace Cara_pag100
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DinheiroJoe = new System.Windows.Forms.Label();
            this.DinheiroBob = new System.Windows.Forms.Label();
            this.DinheiroBanco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "De 10 para Joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "receba 5 de bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DinheiroJoe
            // 
            this.DinheiroJoe.AutoSize = true;
            this.DinheiroJoe.Location = new System.Drawing.Point(79, 74);
            this.DinheiroJoe.Name = "DinheiroJoe";
            this.DinheiroJoe.Size = new System.Drawing.Size(59, 13);
            this.DinheiroJoe.TabIndex = 2;
            this.DinheiroJoe.Text = "Joe tem 50";
            // 
            // DinheiroBob
            // 
            this.DinheiroBob.AutoSize = true;
            this.DinheiroBob.Location = new System.Drawing.Point(79, 99);
            this.DinheiroBob.Name = "DinheiroBob";
            this.DinheiroBob.Size = new System.Drawing.Size(67, 13);
            this.DinheiroBob.TabIndex = 3;
            this.DinheiroBob.Text = "Bob tem 100";
            // 
            // DinheiroBanco
            // 
            this.DinheiroBanco.AutoSize = true;
            this.DinheiroBanco.Location = new System.Drawing.Point(79, 129);
            this.DinheiroBanco.Name = "DinheiroBanco";
            this.DinheiroBanco.Size = new System.Drawing.Size(89, 13);
            this.DinheiroBanco.TabIndex = 4;
            this.DinheiroBanco.Text = "O banco tem 100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 226);
            this.Controls.Add(this.DinheiroBanco);
            this.Controls.Add(this.DinheiroBob);
            this.Controls.Add(this.DinheiroJoe);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label DinheiroJoe;
        private System.Windows.Forms.Label DinheiroBob;
        private System.Windows.Forms.Label DinheiroBanco;
    }
}

