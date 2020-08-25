namespace SimpleGUICalculator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonplus = new System.Windows.Forms.Button();
            this.buttonminus = new System.Windows.Forms.Button();
            this.buttondziel = new System.Windows.Forms.Button();
            this.buttonmnoz = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labeloperator = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelwynik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 22);
            this.textBox1.TabIndex = 0;
            // 
            // buttonplus
            // 
            this.buttonplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonplus.Location = new System.Drawing.Point(12, 54);
            this.buttonplus.Name = "buttonplus";
            this.buttonplus.Size = new System.Drawing.Size(75, 75);
            this.buttonplus.TabIndex = 2;
            this.buttonplus.Text = "+";
            this.buttonplus.UseVisualStyleBackColor = true;
            this.buttonplus.Click += new System.EventHandler(this.buttonplus_Click);
            // 
            // buttonminus
            // 
            this.buttonminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonminus.Location = new System.Drawing.Point(93, 54);
            this.buttonminus.Name = "buttonminus";
            this.buttonminus.Size = new System.Drawing.Size(75, 75);
            this.buttonminus.TabIndex = 3;
            this.buttonminus.Text = "-";
            this.buttonminus.UseVisualStyleBackColor = true;
            this.buttonminus.Click += new System.EventHandler(this.buttonminus_Click);
            // 
            // buttondziel
            // 
            this.buttondziel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttondziel.Location = new System.Drawing.Point(226, 54);
            this.buttondziel.Name = "buttondziel";
            this.buttondziel.Size = new System.Drawing.Size(75, 75);
            this.buttondziel.TabIndex = 4;
            this.buttondziel.Text = "/";
            this.buttondziel.UseVisualStyleBackColor = true;
            this.buttondziel.Click += new System.EventHandler(this.buttondziel_Click);
            // 
            // buttonmnoz
            // 
            this.buttonmnoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonmnoz.Location = new System.Drawing.Point(307, 54);
            this.buttonmnoz.Name = "buttonmnoz";
            this.buttonmnoz.Size = new System.Drawing.Size(75, 75);
            this.buttonmnoz.TabIndex = 5;
            this.buttonmnoz.Text = "*";
            this.buttonmnoz.UseVisualStyleBackColor = true;
            this.buttonmnoz.Click += new System.EventHandler(this.buttonmnoz_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(226, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 22);
            this.textBox2.TabIndex = 6;
            // 
            // labeloperator
            // 
            this.labeloperator.AutoSize = true;
            this.labeloperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labeloperator.Location = new System.Drawing.Point(190, 28);
            this.labeloperator.Name = "labeloperator";
            this.labeloperator.Size = new System.Drawing.Size(63, 32);
            this.labeloperator.TabIndex = 7;
            this.labeloperator.Text = "ope";
            this.labeloperator.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(408, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 55);
            this.label2.TabIndex = 8;
            this.label2.Text = "=";
            // 
            // labelwynik
            // 
            this.labelwynik.AutoSize = true;
            this.labelwynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelwynik.Location = new System.Drawing.Point(478, 40);
            this.labelwynik.Name = "labelwynik";
            this.labelwynik.Size = new System.Drawing.Size(184, 69);
            this.labelwynik.TabIndex = 9;
            this.labelwynik.Text = "wynik";
            this.labelwynik.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 148);
            this.Controls.Add(this.labelwynik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labeloperator);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonmnoz);
            this.Controls.Add(this.buttondziel);
            this.Controls.Add(this.buttonminus);
            this.Controls.Add(this.buttonplus);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonplus;
        private System.Windows.Forms.Button buttonminus;
        private System.Windows.Forms.Button buttondziel;
        private System.Windows.Forms.Button buttonmnoz;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labeloperator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelwynik;
    }
}

