namespace Projekt_bazodanowy
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.odczytZXml = new System.Windows.Forms.Button();
            this.zapisXml = new System.Windows.Forms.Button();
            this.odczytJson = new System.Windows.Forms.Button();
            this.zapisJson = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox1.Controls.Add(this.listBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyświetlacz";
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(6, 21);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(653, 164);
            this.listBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Location = new System.Drawing.Point(12, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zapytania";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button6.Location = new System.Drawing.Point(457, 76);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(202, 35);
            this.button6.TabIndex = 7;
            this.button6.Text = "Usuń zawodników";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button7.Location = new System.Drawing.Point(457, 37);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(202, 35);
            this.button7.TabIndex = 6;
            this.button7.Text = "Wyświetl zawodników";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button5.Location = new System.Drawing.Point(114, 76);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 35);
            this.button5.TabIndex = 4;
            this.button5.Text = "Wyświetl prezesa";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button4.Location = new System.Drawing.Point(288, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Wyświetl trenerów";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button3.Location = new System.Drawing.Point(288, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Usuń trenerów";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button2.Location = new System.Drawing.Point(114, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Wyświetl zespół";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(6, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Załaduj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // odczytZXml
            // 
            this.odczytZXml.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odczytZXml.ForeColor = System.Drawing.SystemColors.MenuText;
            this.odczytZXml.Location = new System.Drawing.Point(707, 262);
            this.odczytZXml.Name = "odczytZXml";
            this.odczytZXml.Size = new System.Drawing.Size(127, 35);
            this.odczytZXml.TabIndex = 2;
            this.odczytZXml.Text = "Odczyt XML";
            this.odczytZXml.UseVisualStyleBackColor = true;
            this.odczytZXml.Click += new System.EventHandler(this.odczytZXml_Click);
            // 
            // zapisXml
            // 
            this.zapisXml.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zapisXml.ForeColor = System.Drawing.SystemColors.MenuText;
            this.zapisXml.Location = new System.Drawing.Point(707, 184);
            this.zapisXml.Name = "zapisXml";
            this.zapisXml.Size = new System.Drawing.Size(127, 35);
            this.zapisXml.TabIndex = 3;
            this.zapisXml.Text = "Zapis XML";
            this.zapisXml.UseVisualStyleBackColor = true;
            this.zapisXml.Click += new System.EventHandler(this.zapisXml_Click);
            // 
            // odczytJson
            // 
            this.odczytJson.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odczytJson.ForeColor = System.Drawing.SystemColors.MenuText;
            this.odczytJson.Location = new System.Drawing.Point(707, 107);
            this.odczytJson.Name = "odczytJson";
            this.odczytJson.Size = new System.Drawing.Size(127, 35);
            this.odczytJson.TabIndex = 4;
            this.odczytJson.Text = "Odczyt JASON";
            this.odczytJson.UseVisualStyleBackColor = true;
            this.odczytJson.Click += new System.EventHandler(this.odczytJson_Click);
            // 
            // zapisJson
            // 
            this.zapisJson.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zapisJson.ForeColor = System.Drawing.SystemColors.MenuText;
            this.zapisJson.Location = new System.Drawing.Point(707, 33);
            this.zapisJson.Name = "zapisJson";
            this.zapisJson.Size = new System.Drawing.Size(127, 35);
            this.zapisJson.TabIndex = 5;
            this.zapisJson.Text = "Zapis JSON";
            this.zapisJson.UseVisualStyleBackColor = true;
            this.zapisJson.Click += new System.EventHandler(this.zapisJson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(854, 355);
            this.Controls.Add(this.zapisJson);
            this.Controls.Add(this.odczytJson);
            this.Controls.Add(this.zapisXml);
            this.Controls.Add(this.odczytZXml);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Projekt Bazodanowy";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button odczytZXml;
        private System.Windows.Forms.Button zapisXml;
        private System.Windows.Forms.Button odczytJson;
        private System.Windows.Forms.Button zapisJson;
    }
}

