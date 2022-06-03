namespace View
{
    partial class SearchForm
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
            this.labelParam1 = new System.Windows.Forms.Label();
            this.textBoxParam1 = new System.Windows.Forms.TextBox();
            this.buttonRunSearchParam1 = new System.Windows.Forms.Button();
            this.textBoxParam2 = new System.Windows.Forms.TextBox();
            this.labelParam2 = new System.Windows.Forms.Label();
            this.buttonRunSearchParam2 = new System.Windows.Forms.Button();
            this.groupBoxSearched = new System.Windows.Forms.GroupBox();
            this.listBoxObj = new System.Windows.Forms.ListBox();
            this.groupBoxSearched.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelParam1
            // 
            this.labelParam1.AutoSize = true;
            this.labelParam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelParam1.Location = new System.Drawing.Point(42, 43);
            this.labelParam1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelParam1.Name = "labelParam1";
            this.labelParam1.Size = new System.Drawing.Size(53, 20);
            this.labelParam1.TabIndex = 8;
            this.labelParam1.Text = "U | ω:";
            // 
            // textBoxParam1
            // 
            this.textBoxParam1.Location = new System.Drawing.Point(97, 43);
            this.textBoxParam1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxParam1.Name = "textBoxParam1";
            this.textBoxParam1.Size = new System.Drawing.Size(130, 26);
            this.textBoxParam1.TabIndex = 7;
            // 
            // buttonRunSearchParam1
            // 
            this.buttonRunSearchParam1.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonRunSearchParam1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonRunSearchParam1.FlatAppearance.BorderSize = 2;
            this.buttonRunSearchParam1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRunSearchParam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRunSearchParam1.Location = new System.Drawing.Point(97, 79);
            this.buttonRunSearchParam1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRunSearchParam1.Name = "buttonRunSearchParam1";
            this.buttonRunSearchParam1.Size = new System.Drawing.Size(130, 40);
            this.buttonRunSearchParam1.TabIndex = 10;
            this.buttonRunSearchParam1.Text = "Найти";
            this.buttonRunSearchParam1.UseVisualStyleBackColor = false;
            this.buttonRunSearchParam1.Click += new System.EventHandler(this.buttonRunSearchParam1_Click);
            // 
            // textBoxParam2
            // 
            this.textBoxParam2.Location = new System.Drawing.Point(97, 183);
            this.textBoxParam2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxParam2.Name = "textBoxParam2";
            this.textBoxParam2.Size = new System.Drawing.Size(130, 26);
            this.textBoxParam2.TabIndex = 7;
            // 
            // labelParam2
            // 
            this.labelParam2.AutoSize = true;
            this.labelParam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelParam2.Location = new System.Drawing.Point(18, 186);
            this.labelParam2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelParam2.Name = "labelParam2";
            this.labelParam2.Size = new System.Drawing.Size(74, 20);
            this.labelParam2.TabIndex = 8;
            this.labelParam2.Text = "I | C | L:";
            // 
            // buttonRunSearchParam2
            // 
            this.buttonRunSearchParam2.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonRunSearchParam2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonRunSearchParam2.FlatAppearance.BorderSize = 2;
            this.buttonRunSearchParam2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRunSearchParam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRunSearchParam2.Location = new System.Drawing.Point(97, 219);
            this.buttonRunSearchParam2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRunSearchParam2.Name = "buttonRunSearchParam2";
            this.buttonRunSearchParam2.Size = new System.Drawing.Size(130, 40);
            this.buttonRunSearchParam2.TabIndex = 10;
            this.buttonRunSearchParam2.Text = "Найти";
            this.buttonRunSearchParam2.UseVisualStyleBackColor = false;
            this.buttonRunSearchParam2.Click += new System.EventHandler(this.buttonRunSearchParam2_Click);
            // 
            // groupBoxSearched
            // 
            this.groupBoxSearched.Controls.Add(this.listBoxObj);
            this.groupBoxSearched.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSearched.Location = new System.Drawing.Point(245, 14);
            this.groupBoxSearched.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSearched.Name = "groupBoxSearched";
            this.groupBoxSearched.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSearched.Size = new System.Drawing.Size(369, 369);
            this.groupBoxSearched.TabIndex = 12;
            this.groupBoxSearched.TabStop = false;
            this.groupBoxSearched.Text = "Найденные объекты:";
            // 
            // listBoxObj
            // 
            this.listBoxObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxObj.FormattingEnabled = true;
            this.listBoxObj.ItemHeight = 20;
            this.listBoxObj.Location = new System.Drawing.Point(17, 29);
            this.listBoxObj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxObj.Name = "listBoxObj";
            this.listBoxObj.Size = new System.Drawing.Size(332, 324);
            this.listBoxObj.TabIndex = 12;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(643, 406);
            this.Controls.Add(this.groupBoxSearched);
            this.Controls.Add(this.buttonRunSearchParam2);
            this.Controls.Add(this.buttonRunSearchParam1);
            this.Controls.Add(this.labelParam2);
            this.Controls.Add(this.labelParam1);
            this.Controls.Add(this.textBoxParam2);
            this.Controls.Add(this.textBoxParam1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск";
            this.groupBoxSearched.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelParam1;
        private System.Windows.Forms.TextBox textBoxParam1;
        private System.Windows.Forms.Button buttonRunSearchParam1;
        private System.Windows.Forms.TextBox textBoxParam2;
        private System.Windows.Forms.Label labelParam2;
        private System.Windows.Forms.Button buttonRunSearchParam2;
        private System.Windows.Forms.GroupBox groupBoxSearched;
        private System.Windows.Forms.ListBox listBoxObj;
    }
}