
namespace Classwork2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.birthpicker = new System.Windows.Forms.DateTimePicker();
            this.nametxtbox = new System.Windows.Forms.TextBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.peoplesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // birthpicker
            // 
            this.birthpicker.Location = new System.Drawing.Point(22, 100);
            this.birthpicker.Name = "birthpicker";
            this.birthpicker.Size = new System.Drawing.Size(190, 23);
            this.birthpicker.TabIndex = 1;
            // 
            // nametxtbox
            // 
            this.nametxtbox.Location = new System.Drawing.Point(22, 34);
            this.nametxtbox.Name = "nametxtbox";
            this.nametxtbox.Size = new System.Drawing.Size(190, 23);
            this.nametxtbox.TabIndex = 2;
            // 
            // submitbtn
            // 
            this.submitbtn.Location = new System.Drawing.Point(22, 175);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(190, 38);
            this.submitbtn.TabIndex = 3;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // peoplesListBox
            // 
            this.peoplesListBox.FormattingEnabled = true;
            this.peoplesListBox.ItemHeight = 15;
            this.peoplesListBox.Items.AddRange(new object[] {
            "Dima",
            "Ann",
            "Kaban",
            "Admin"});
            this.peoplesListBox.Location = new System.Drawing.Point(236, 12);
            this.peoplesListBox.Name = "peoplesListBox";
            this.peoplesListBox.Size = new System.Drawing.Size(297, 199);
            this.peoplesListBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.peoplesListBox);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.nametxtbox);
            this.Controls.Add(this.birthpicker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker birthpicker;
        private System.Windows.Forms.TextBox nametxtbox;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.ListBox peoplesListBox;
    }
}

