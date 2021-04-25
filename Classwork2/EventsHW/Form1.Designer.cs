
namespace EventsHW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.placeTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.typeEventComboBox = new System.Windows.Forms.ComboBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.placelbl = new System.Windows.Forms.Label();
            this.priorylbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eventsListBox = new System.Windows.Forms.ListBox();
            this.addEventButton = new System.Windows.Forms.Button();
            this.deleteSelectedBtn = new System.Windows.Forms.Button();
            this.editSelectedBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(14, 83);
            this.nameTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(226, 27);
            this.nameTxtBox.TabIndex = 0;
            // 
            // placeTextBox
            // 
            this.placeTextBox.Location = new System.Drawing.Point(14, 165);
            this.placeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.placeTextBox.Name = "placeTextBox";
            this.placeTextBox.Size = new System.Drawing.Size(228, 27);
            this.placeTextBox.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 316);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 27);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // typeEventComboBox
            // 
            this.typeEventComboBox.FormattingEnabled = true;
            this.typeEventComboBox.Location = new System.Drawing.Point(14, 245);
            this.typeEventComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.typeEventComboBox.Name = "typeEventComboBox";
            this.typeEventComboBox.Size = new System.Drawing.Size(226, 28);
            this.typeEventComboBox.TabIndex = 2;
            this.typeEventComboBox.SelectedIndexChanged += new System.EventHandler(this.typeEventComboBox_SelectedIndexChanged);
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.BackColor = System.Drawing.Color.Transparent;
            this.namelbl.Font = new System.Drawing.Font("Bebas Neue Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.namelbl.Location = new System.Drawing.Point(14, 55);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(49, 24);
            this.namelbl.TabIndex = 3;
            this.namelbl.Text = "Name:";
            // 
            // placelbl
            // 
            this.placelbl.AutoSize = true;
            this.placelbl.BackColor = System.Drawing.Color.Transparent;
            this.placelbl.Font = new System.Drawing.Font("Bebas Neue Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.placelbl.Location = new System.Drawing.Point(14, 141);
            this.placelbl.Name = "placelbl";
            this.placelbl.Size = new System.Drawing.Size(52, 24);
            this.placelbl.TabIndex = 4;
            this.placelbl.Text = "Place:";
            // 
            // priorylbl
            // 
            this.priorylbl.AutoSize = true;
            this.priorylbl.BackColor = System.Drawing.Color.Transparent;
            this.priorylbl.Font = new System.Drawing.Font("Bebas Neue Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priorylbl.Location = new System.Drawing.Point(14, 221);
            this.priorylbl.Name = "priorylbl";
            this.priorylbl.Size = new System.Drawing.Size(58, 24);
            this.priorylbl.TabIndex = 5;
            this.priorylbl.Text = "Priory:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bebas Neue Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date:";
            // 
            // eventsListBox
            // 
            this.eventsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventsListBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.ItemHeight = 24;
            this.eventsListBox.Location = new System.Drawing.Point(276, 52);
            this.eventsListBox.Margin = new System.Windows.Forms.Padding(0);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.eventsListBox.Size = new System.Drawing.Size(713, 364);
            this.eventsListBox.TabIndex = 7;
            // 
            // addEventButton
            // 
            this.addEventButton.BackColor = System.Drawing.Color.Tomato;
            this.addEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addEventButton.Font = new System.Drawing.Font("Bebas Neue Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addEventButton.ForeColor = System.Drawing.Color.SeaShell;
            this.addEventButton.Location = new System.Drawing.Point(12, 360);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(228, 58);
            this.addEventButton.TabIndex = 8;
            this.addEventButton.Text = "ADD";
            this.addEventButton.UseVisualStyleBackColor = false;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            // 
            // deleteSelectedBtn
            // 
            this.deleteSelectedBtn.BackColor = System.Drawing.Color.Tomato;
            this.deleteSelectedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteSelectedBtn.Font = new System.Drawing.Font("Bebas Neue Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedBtn.ForeColor = System.Drawing.Color.SeaShell;
            this.deleteSelectedBtn.Location = new System.Drawing.Point(276, 419);
            this.deleteSelectedBtn.Name = "deleteSelectedBtn";
            this.deleteSelectedBtn.Size = new System.Drawing.Size(228, 36);
            this.deleteSelectedBtn.TabIndex = 9;
            this.deleteSelectedBtn.Text = "Delete Selected";
            this.deleteSelectedBtn.UseVisualStyleBackColor = false;
            this.deleteSelectedBtn.Click += new System.EventHandler(this.deleteSelectedBtn_Click);
            // 
            // editSelectedBtn
            // 
            this.editSelectedBtn.BackColor = System.Drawing.Color.Tomato;
            this.editSelectedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editSelectedBtn.Font = new System.Drawing.Font("Bebas Neue Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editSelectedBtn.ForeColor = System.Drawing.Color.SeaShell;
            this.editSelectedBtn.Location = new System.Drawing.Point(761, 419);
            this.editSelectedBtn.Name = "editSelectedBtn";
            this.editSelectedBtn.Size = new System.Drawing.Size(228, 36);
            this.editSelectedBtn.TabIndex = 10;
            this.editSelectedBtn.Text = "Edit Selected";
            this.editSelectedBtn.UseVisualStyleBackColor = false;
            this.editSelectedBtn.Click += new System.EventHandler(this.editSelectedBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 489);
            this.Controls.Add(this.editSelectedBtn);
            this.Controls.Add(this.deleteSelectedBtn);
            this.Controls.Add(this.addEventButton);
            this.Controls.Add(this.eventsListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priorylbl);
            this.Controls.Add(this.placelbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.typeEventComboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.placeTextBox);
            this.Controls.Add(this.nameTxtBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox placeTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox typeEventComboBox;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label placelbl;
        private System.Windows.Forms.Label priorylbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox eventsListBox;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.Button deleteSelectedBtn;
        private System.Windows.Forms.Button editSelectedBtn;
    }
}

