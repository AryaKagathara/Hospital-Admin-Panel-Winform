﻿using System.Drawing;

namespace Hospital
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchResultGridView = new System.Windows.Forms.DataGridView();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchResultGridView
            // 
            this.SearchResultGridView.AllowUserToAddRows = false;
            this.SearchResultGridView.AllowUserToDeleteRows = false;
            this.SearchResultGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SearchResultGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SearchResultGridView.ColumnHeadersHeight = 42;
            this.SearchResultGridView.ColumnHeadersVisible = false;
            this.SearchResultGridView.EnableHeadersVisualStyles = false;
            this.SearchResultGridView.Font = new System.Drawing.Font("Tahoma", 12F);
            this.SearchResultGridView.Location = new System.Drawing.Point(0, 140);
            this.SearchResultGridView.Margin = new System.Windows.Forms.Padding(4);
            this.SearchResultGridView.Name = "SearchResultGridView";
            this.SearchResultGridView.ReadOnly = true;
            this.SearchResultGridView.RowHeadersVisible = false;
            this.SearchResultGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SearchResultGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.SearchResultGridView.RowTemplate.Height = 60;
            this.SearchResultGridView.Size = new System.Drawing.Size(1128, 485);
            this.SearchResultGridView.TabIndex = 4;
            // 
            // searchTextbox
            // 
            this.searchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextbox.Location = new System.Drawing.Point(0, 41);
            this.searchTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(773, 38);
            this.searchTextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-5, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.Text = "Search Patient";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(992, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "i";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.SearchResultGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1128, 616);
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SearchResultGridView;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}
