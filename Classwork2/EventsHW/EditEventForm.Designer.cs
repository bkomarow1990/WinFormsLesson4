
namespace EventsHW
{
    partial class EditEventForm
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
            this.editButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.priorylbl = new System.Windows.Forms.Label();
            this.placelbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.typeEventComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.placeTextBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Tomato;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editButton.Font = new System.Drawing.Font("Bebas Neue Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editButton.ForeColor = System.Drawing.Color.SeaShell;
            this.editButton.Location = new System.Drawing.Point(285, 349);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(228, 58);
            this.editButton.TabIndex = 17;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bebas Neue Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(287, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Date:";
            // 
            // priorylbl
            // 
            this.priorylbl.AutoSize = true;
            this.priorylbl.BackColor = System.Drawing.Color.Transparent;
            this.priorylbl.Font = new System.Drawing.Font("Bebas Neue Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priorylbl.Location = new System.Drawing.Point(287, 210);
            this.priorylbl.Name = "priorylbl";
            this.priorylbl.Size = new System.Drawing.Size(58, 24);
            this.priorylbl.TabIndex = 15;
            this.priorylbl.Text = "Priory:";
            // 
            // placelbl
            // 
            this.placelbl.AutoSize = true;
            this.placelbl.BackColor = System.Drawing.Color.Transparent;
            this.placelbl.Font = new System.Drawing.Font("Bebas Neue Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.placelbl.Location = new System.Drawing.Point(287, 130);
            this.placelbl.Name = "placelbl";
            this.placelbl.Size = new System.Drawing.Size(52, 24);
            this.placelbl.TabIndex = 14;
            this.placelbl.Text = "Place:";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.BackColor = System.Drawing.Color.Transparent;
            this.namelbl.Font = new System.Drawing.Font("Bebas Neue Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.namelbl.Location = new System.Drawing.Point(287, 44);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(49, 24);
            this.namelbl.TabIndex = 13;
            this.namelbl.Text = "Name:";
            // 
            // typeEventComboBox
            // 
            this.typeEventComboBox.FormattingEnabled = true;
            this.typeEventComboBox.Location = new System.Drawing.Point(287, 234);
            this.typeEventComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.typeEventComboBox.Name = "typeEventComboBox";
            this.typeEventComboBox.Size = new System.Drawing.Size(226, 28);
            this.typeEventComboBox.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(287, 305);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 27);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // placeTextBox
            // 
            this.placeTextBox.Location = new System.Drawing.Point(287, 154);
            this.placeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.placeTextBox.Name = "placeTextBox";
            this.placeTextBox.Size = new System.Drawing.Size(228, 27);
            this.placeTextBox.TabIndex = 9;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(287, 72);
            this.nameTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(226, 27);
            this.nameTxtBox.TabIndex = 10;
            // 
            // EditEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EventsHW.Properties.Resources.flat_bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priorylbl);
            this.Controls.Add(this.placelbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.typeEventComboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.placeTextBox);
            this.Controls.Add(this.nameTxtBox);
            this.Name = "EditEventForm";
            this.Text = "EditEventForm";
            this.Load += new System.EventHandler(this.EditEventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label priorylbl;
        private System.Windows.Forms.Label placelbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.ComboBox typeEventComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox placeTextBox;
        private System.Windows.Forms.TextBox nameTxtBox;
    }
}