﻿namespace CitiesAndStatesFilling
{
    partial class FormCitiesReader
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
            this.buttonInsertCities = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonInsertCities
            // 
            this.buttonInsertCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertCities.Location = new System.Drawing.Point(277, 69);
            this.buttonInsertCities.Name = "buttonInsertCities";
            this.buttonInsertCities.Size = new System.Drawing.Size(174, 48);
            this.buttonInsertCities.TabIndex = 0;
            this.buttonInsertCities.Text = "Insert Cities";
            this.buttonInsertCities.UseVisualStyleBackColor = true;
            this.buttonInsertCities.Click += new System.EventHandler(this.buttonInsertCities_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(685, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click on the following button to read the file containing the cities and add them" +
    " into the database";
            // 
            // FormCitiesReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 166);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInsertCities);
            this.Name = "FormCitiesReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cities Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInsertCities;
        private System.Windows.Forms.Label label1;
    }
}

