namespace BohatecTest121222
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonAddRecord = new System.Windows.Forms.Button();
            this.buttonEditRecord = new System.Windows.Forms.Button();
            this.buttonDeleteRecord = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(486, 390);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // buttonAddRecord
            // 
            this.buttonAddRecord.Location = new System.Drawing.Point(12, 12);
            this.buttonAddRecord.Name = "buttonAddRecord";
            this.buttonAddRecord.Size = new System.Drawing.Size(89, 23);
            this.buttonAddRecord.TabIndex = 1;
            this.buttonAddRecord.Text = "Přidat záznam";
            this.buttonAddRecord.UseVisualStyleBackColor = true;
            this.buttonAddRecord.Click += new System.EventHandler(this.buttonAddRecord_Click);
            // 
            // buttonEditRecord
            // 
            this.buttonEditRecord.Location = new System.Drawing.Point(107, 12);
            this.buttonEditRecord.Name = "buttonEditRecord";
            this.buttonEditRecord.Size = new System.Drawing.Size(89, 23);
            this.buttonEditRecord.TabIndex = 2;
            this.buttonEditRecord.Text = "Upravit záznam";
            this.buttonEditRecord.UseVisualStyleBackColor = true;
            this.buttonEditRecord.Click += new System.EventHandler(this.buttonEditRecord_Click);
            // 
            // buttonDeleteRecord
            // 
            this.buttonDeleteRecord.Location = new System.Drawing.Point(202, 12);
            this.buttonDeleteRecord.Name = "buttonDeleteRecord";
            this.buttonDeleteRecord.Size = new System.Drawing.Size(90, 23);
            this.buttonDeleteRecord.TabIndex = 3;
            this.buttonDeleteRecord.Text = "Smazat záznam";
            this.buttonDeleteRecord.UseVisualStyleBackColor = true;
            this.buttonDeleteRecord.Click += new System.EventHandler(this.buttonDeleteRecord_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(298, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "AVG";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(347, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(43, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "MAX";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(396, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(43, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "MIN";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(445, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(53, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "COUNT";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Křestní jméno";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Příjmení";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Číslo";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Datum narození";
            this.columnHeader6.Width = 90;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 443);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonDeleteRecord);
            this.Controls.Add(this.buttonEditRecord);
            this.Controls.Add(this.buttonAddRecord);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonAddRecord;
        private System.Windows.Forms.Button buttonEditRecord;
        private System.Windows.Forms.Button buttonDeleteRecord;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

