namespace SystemGlobalizationPrzyklady
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
            this.btnKultury = new System.Windows.Forms.Button();
            this.btnRegion = new System.Windows.Forms.Button();
            this.btnModyfikacjaFormatuDaty = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCiagiZnakow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKultury
            // 
            this.btnKultury.Location = new System.Drawing.Point(45, 12);
            this.btnKultury.Name = "btnKultury";
            this.btnKultury.Size = new System.Drawing.Size(255, 23);
            this.btnKultury.TabIndex = 0;
            this.btnKultury.Text = "Wyświetl informacje o kulturach";
            this.btnKultury.UseVisualStyleBackColor = true;
            this.btnKultury.Click += new System.EventHandler(this.btnKultury_Click);
            // 
            // btnRegion
            // 
            this.btnRegion.Location = new System.Drawing.Point(45, 55);
            this.btnRegion.Name = "btnRegion";
            this.btnRegion.Size = new System.Drawing.Size(255, 23);
            this.btnRegion.TabIndex = 1;
            this.btnRegion.Text = "Wyświetl informacje o regionie";
            this.btnRegion.UseVisualStyleBackColor = true;
            this.btnRegion.Click += new System.EventHandler(this.btnRegion_Click);
            // 
            // btnModyfikacjaFormatuDaty
            // 
            this.btnModyfikacjaFormatuDaty.Location = new System.Drawing.Point(45, 94);
            this.btnModyfikacjaFormatuDaty.Name = "btnModyfikacjaFormatuDaty";
            this.btnModyfikacjaFormatuDaty.Size = new System.Drawing.Size(255, 23);
            this.btnModyfikacjaFormatuDaty.TabIndex = 2;
            this.btnModyfikacjaFormatuDaty.Text = "Modyfikuj format daty";
            this.btnModyfikacjaFormatuDaty.UseVisualStyleBackColor = true;
            this.btnModyfikacjaFormatuDaty.Click += new System.EventHandler(this.btnModyfikacjaFormatuDaty_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Separator liczb dziesiętnych i grup liczb";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCiagiZnakow
            // 
            this.btnCiagiZnakow.Location = new System.Drawing.Point(45, 178);
            this.btnCiagiZnakow.Name = "btnCiagiZnakow";
            this.btnCiagiZnakow.Size = new System.Drawing.Size(255, 23);
            this.btnCiagiZnakow.TabIndex = 4;
            this.btnCiagiZnakow.Text = "Porównaj 2 ciągi znaków(0 - identyczne)";
            this.btnCiagiZnakow.UseVisualStyleBackColor = true;
            this.btnCiagiZnakow.Click += new System.EventHandler(this.btnCiagiZnakow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 223);
            this.Controls.Add(this.btnCiagiZnakow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnModyfikacjaFormatuDaty);
            this.Controls.Add(this.btnRegion);
            this.Controls.Add(this.btnKultury);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wykład 12 - System.Globalization";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKultury;
        private System.Windows.Forms.Button btnRegion;
        private System.Windows.Forms.Button btnModyfikacjaFormatuDaty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCiagiZnakow;

    }
}

