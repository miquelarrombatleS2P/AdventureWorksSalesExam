
namespace AdventureWorksSales
{
    partial class DetallForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.orderNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.detailsInfoListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SubtotaltextBox = new System.Windows.Forms.TextBox();
            this.TaxtextBox = new System.Windows.Forms.TextBox();
            this.ShippingtextBox = new System.Windows.Forms.TextBox();
            this.totaltextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.orderNumberTextBox);
            this.groupBox1.Controls.Add(this.dateTextBox);
            this.groupBox1.Controls.Add(this.customerTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "orderHeaderInfoGroupBox";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Date";
            // 
            // customerTextBox
            // 
            this.customerTextBox.Location = new System.Drawing.Point(118, 42);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(136, 22);
            this.customerTextBox.TabIndex = 2;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(118, 88);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(136, 22);
            this.dateTextBox.TabIndex = 3;
            // 
            // orderNumberTextBox
            // 
            this.orderNumberTextBox.Location = new System.Drawing.Point(432, 84);
            this.orderNumberTextBox.Name = "orderNumberTextBox";
            this.orderNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.orderNumberTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Order Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.detailsInfoListBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1036, 397);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "orderDetailsInfoGroupBox";
            // 
            // detailsInfoListBox
            // 
            this.detailsInfoListBox.FormattingEnabled = true;
            this.detailsInfoListBox.ItemHeight = 16;
            this.detailsInfoListBox.Location = new System.Drawing.Point(7, 39);
            this.detailsInfoListBox.Name = "detailsInfoListBox";
            this.detailsInfoListBox.Size = new System.Drawing.Size(1023, 340);
            this.detailsInfoListBox.TabIndex = 0;
            this.detailsInfoListBox.SelectedIndexChanged += new System.EventHandler(this.detailsInfoListBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(811, 601);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sub Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(811, 631);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tax:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(811, 662);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Shipping:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(811, 715);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Total:";
            // 
            // SubtotaltextBox
            // 
            this.SubtotaltextBox.Location = new System.Drawing.Point(890, 601);
            this.SubtotaltextBox.Name = "SubtotaltextBox";
            this.SubtotaltextBox.Size = new System.Drawing.Size(153, 22);
            this.SubtotaltextBox.TabIndex = 6;
            // 
            // TaxtextBox
            // 
            this.TaxtextBox.Location = new System.Drawing.Point(890, 631);
            this.TaxtextBox.Name = "TaxtextBox";
            this.TaxtextBox.Size = new System.Drawing.Size(153, 22);
            this.TaxtextBox.TabIndex = 7;
       
            // 
            // ShippingtextBox
            // 
            this.ShippingtextBox.Location = new System.Drawing.Point(890, 659);
            this.ShippingtextBox.Name = "ShippingtextBox";
            this.ShippingtextBox.Size = new System.Drawing.Size(153, 22);
            this.ShippingtextBox.TabIndex = 8;
            // 
            // totaltextBox
            // 
            this.totaltextBox.Location = new System.Drawing.Point(890, 712);
            this.totaltextBox.Name = "totaltextBox";
            this.totaltextBox.Size = new System.Drawing.Size(153, 22);
            this.totaltextBox.TabIndex = 9;
            // 
            // DetallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 751);
            this.Controls.Add(this.totaltextBox);
            this.Controls.Add(this.ShippingtextBox);
            this.Controls.Add(this.TaxtextBox);
            this.Controls.Add(this.SubtotaltextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DetallForm";
            this.Text = "DetallForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox orderNumberTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox detailsInfoListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SubtotaltextBox;
        private System.Windows.Forms.TextBox TaxtextBox;
        private System.Windows.Forms.TextBox ShippingtextBox;
        private System.Windows.Forms.TextBox totaltextBox;
    }
}