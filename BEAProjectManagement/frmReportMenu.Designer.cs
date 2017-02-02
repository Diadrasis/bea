﻿namespace BEAProjectManagement
{
    partial class frmReportMenu
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vProjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beaDBDataSet = new BEAProjectManagement.beaDBDataSet();
            this.vProjectsTableAdapter = new BEAProjectManagement.beaDBDataSetTableAdapters.vProjectsTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vProjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::BEAProjectManagement.Properties.Resources.gears;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(59, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 64);
            this.button1.TabIndex = 3;
            this.button1.Text = "Απολογισμός Έργου";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::BEAProjectManagement.Properties.Resources.gears;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(472, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(275, 64);
            this.button2.TabIndex = 4;
            this.button2.Text = "Απασχόληση Εργαζόμενου";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = global::BEAProjectManagement.Properties.Resources.gears;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(59, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(275, 64);
            this.button3.TabIndex = 5;
            this.button3.Text = "Προγραμματισμός Έργου";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.vProjectsBindingSource;
            this.comboBox1.DisplayMember = "projTitle";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(59, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(275, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "projTitle";
            // 
            // vProjectsBindingSource
            // 
            this.vProjectsBindingSource.DataMember = "vProjects";
            this.vProjectsBindingSource.DataSource = this.beaDBDataSet;
            // 
            // beaDBDataSet
            // 
            this.beaDBDataSet.DataSetName = "beaDBDataSet";
            this.beaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vProjectsTableAdapter
            // 
            this.vProjectsTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Image = global::BEAProjectManagement.Properties.Resources.gears;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(59, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(275, 64);
            this.button4.TabIndex = 7;
            this.button4.Text = "Προγραμματισμός Δράσεων ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Image = global::BEAProjectManagement.Properties.Resources.gears;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(472, 289);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(275, 64);
            this.button5.TabIndex = 8;
            this.button5.Text = "Απασχόληση Εργαζόμενου";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmReportMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1008, 530);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmReportMenu";
            this.Load += new System.EventHandler(this.frmReportMenu_Load);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.vProjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beaDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private beaDBDataSet beaDBDataSet;
        private System.Windows.Forms.BindingSource vProjectsBindingSource;
        private beaDBDataSetTableAdapters.vProjectsTableAdapter vProjectsTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}