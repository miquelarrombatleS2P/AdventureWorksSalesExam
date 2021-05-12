
namespace AdventureWorksSales
{
    partial class MainForm
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
            this.salesListBox = new System.Windows.Forms.ListBox();
            this.customersComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // salesListBox
            // 
            this.salesListBox.FormattingEnabled = true;
            this.salesListBox.Location = new System.Drawing.Point(12, 187);
            this.salesListBox.Name = "salesListBox";
            this.salesListBox.Size = new System.Drawing.Size(836, 342);
            this.salesListBox.TabIndex = 0;
            this.salesListBox.DoubleClick += new System.EventHandler(this.salesListBox_DoubleClick);
            // 
            // customersComboBox
            // 
            this.customersComboBox.FormattingEnabled = true;
            this.customersComboBox.Location = new System.Drawing.Point(12, 58);
            this.customersComboBox.Name = "customersComboBox";
            this.customersComboBox.Size = new System.Drawing.Size(390, 21);
            this.customersComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select customer>";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customersComboBox);
            this.Controls.Add(this.salesListBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox salesListBox;
        private System.Windows.Forms.ComboBox customersComboBox;
        private System.Windows.Forms.Label label1;
    }
}

