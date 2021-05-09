
namespace HW_Calc
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
            this.buttonsGroupBox = new System.Windows.Forms.GroupBox();
            this.changleSymbBtn = new System.Windows.Forms.Button();
            this.displayTxtBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.clearOneBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.multBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.equalsBtn = new System.Windows.Forms.Button();
            this.comaBtn = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.littleRb = new System.Windows.Forms.RadioButton();
            this.bigRb = new System.Windows.Forms.RadioButton();
            this.modesGroupBox = new System.Windows.Forms.GroupBox();
            this.angleGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.sinBtn = new System.Windows.Forms.Button();
            this.cosBtn = new System.Windows.Forms.Button();
            this.tanBtn = new System.Windows.Forms.Button();
            this.buttonsGroupBox.SuspendLayout();
            this.modesGroupBox.SuspendLayout();
            this.angleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonsGroupBox
            // 
            this.buttonsGroupBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonsGroupBox.Controls.Add(this.changleSymbBtn);
            this.buttonsGroupBox.Controls.Add(this.displayTxtBox);
            this.buttonsGroupBox.Controls.Add(this.deleteBtn);
            this.buttonsGroupBox.Controls.Add(this.clearOneBtn);
            this.buttonsGroupBox.Controls.Add(this.divBtn);
            this.buttonsGroupBox.Controls.Add(this.multBtn);
            this.buttonsGroupBox.Controls.Add(this.minusBtn);
            this.buttonsGroupBox.Controls.Add(this.plusBtn);
            this.buttonsGroupBox.Controls.Add(this.equalsBtn);
            this.buttonsGroupBox.Controls.Add(this.comaBtn);
            this.buttonsGroupBox.Controls.Add(this.btn0);
            this.buttonsGroupBox.Controls.Add(this.btn3);
            this.buttonsGroupBox.Controls.Add(this.btn2);
            this.buttonsGroupBox.Controls.Add(this.btn1);
            this.buttonsGroupBox.Controls.Add(this.btn6);
            this.buttonsGroupBox.Controls.Add(this.btn5);
            this.buttonsGroupBox.Controls.Add(this.btn4);
            this.buttonsGroupBox.Controls.Add(this.btn9);
            this.buttonsGroupBox.Controls.Add(this.btn8);
            this.buttonsGroupBox.Controls.Add(this.btn7);
            this.buttonsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonsGroupBox.Location = new System.Drawing.Point(3, 4);
            this.buttonsGroupBox.Name = "buttonsGroupBox";
            this.buttonsGroupBox.Size = new System.Drawing.Size(362, 409);
            this.buttonsGroupBox.TabIndex = 0;
            this.buttonsGroupBox.TabStop = false;
            this.buttonsGroupBox.Text = "Buttons:";
            // 
            // changleSymbBtn
            // 
            this.changleSymbBtn.BackColor = System.Drawing.Color.Crimson;
            this.changleSymbBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.changleSymbBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changleSymbBtn.Font = new System.Drawing.Font("Bebas Neue Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changleSymbBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.changleSymbBtn.Location = new System.Drawing.Point(61, 138);
            this.changleSymbBtn.Name = "changleSymbBtn";
            this.changleSymbBtn.Size = new System.Drawing.Size(67, 47);
            this.changleSymbBtn.TabIndex = 20;
            this.changleSymbBtn.Text = "Змiнити знак";
            this.changleSymbBtn.UseVisualStyleBackColor = false;
            this.changleSymbBtn.Click += new System.EventHandler(this.changleSymbBtn_Click);
            // 
            // displayTxtBox
            // 
            this.displayTxtBox.Font = new System.Drawing.Font("Bebas Neue Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.displayTxtBox.Location = new System.Drawing.Point(16, 78);
            this.displayTxtBox.Name = "displayTxtBox";
            this.displayTxtBox.Size = new System.Drawing.Size(331, 31);
            this.displayTxtBox.TabIndex = 19;
            this.displayTxtBox.Text = "0";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Crimson;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBtn.Font = new System.Drawing.Font("Wingdings 2", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteBtn.Location = new System.Drawing.Point(134, 139);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(67, 47);
            this.deleteBtn.TabIndex = 18;
            this.deleteBtn.Text = "Q";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // clearOneBtn
            // 
            this.clearOneBtn.BackColor = System.Drawing.Color.Crimson;
            this.clearOneBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.clearOneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearOneBtn.Font = new System.Drawing.Font("Wingdings 2", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearOneBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clearOneBtn.Location = new System.Drawing.Point(207, 139);
            this.clearOneBtn.Name = "clearOneBtn";
            this.clearOneBtn.Size = new System.Drawing.Size(67, 47);
            this.clearOneBtn.TabIndex = 17;
            this.clearOneBtn.Text = "%";
            this.clearOneBtn.UseVisualStyleBackColor = false;
            this.clearOneBtn.Click += new System.EventHandler(this.clearOneBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.BackColor = System.Drawing.Color.Crimson;
            this.divBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.divBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.divBtn.Font = new System.Drawing.Font("Bebas Neue Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.divBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.divBtn.Location = new System.Drawing.Point(280, 138);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(67, 47);
            this.divBtn.TabIndex = 16;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = false;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // multBtn
            // 
            this.multBtn.BackColor = System.Drawing.Color.Crimson;
            this.multBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multBtn.Font = new System.Drawing.Font("Bebas Neue Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.multBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.multBtn.Location = new System.Drawing.Point(280, 191);
            this.multBtn.Name = "multBtn";
            this.multBtn.Size = new System.Drawing.Size(67, 47);
            this.multBtn.TabIndex = 15;
            this.multBtn.Text = "*";
            this.multBtn.UseVisualStyleBackColor = false;
            this.multBtn.Click += new System.EventHandler(this.multBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.BackColor = System.Drawing.Color.Crimson;
            this.minusBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.minusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minusBtn.Font = new System.Drawing.Font("Bebas Neue Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minusBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.minusBtn.Location = new System.Drawing.Point(280, 245);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(67, 47);
            this.minusBtn.TabIndex = 14;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = false;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.BackColor = System.Drawing.Color.Crimson;
            this.plusBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.plusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plusBtn.Font = new System.Drawing.Font("Bebas Neue Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plusBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.plusBtn.Location = new System.Drawing.Point(280, 297);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(67, 47);
            this.plusBtn.TabIndex = 13;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = false;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // equalsBtn
            // 
            this.equalsBtn.BackColor = System.Drawing.Color.Crimson;
            this.equalsBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.equalsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equalsBtn.Font = new System.Drawing.Font("Bebas Neue Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.equalsBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.equalsBtn.Location = new System.Drawing.Point(280, 350);
            this.equalsBtn.Name = "equalsBtn";
            this.equalsBtn.Size = new System.Drawing.Size(67, 47);
            this.equalsBtn.TabIndex = 12;
            this.equalsBtn.Text = "=";
            this.equalsBtn.UseVisualStyleBackColor = false;
            this.equalsBtn.Click += new System.EventHandler(this.equalsBtn_Click);
            // 
            // comaBtn
            // 
            this.comaBtn.BackColor = System.Drawing.Color.Crimson;
            this.comaBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.comaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comaBtn.Font = new System.Drawing.Font("Bebas Neue Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comaBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comaBtn.Location = new System.Drawing.Point(207, 351);
            this.comaBtn.Name = "comaBtn";
            this.comaBtn.Size = new System.Drawing.Size(67, 47);
            this.comaBtn.TabIndex = 11;
            this.comaBtn.Text = ",";
            this.comaBtn.UseVisualStyleBackColor = false;
            this.comaBtn.Click += new System.EventHandler(this.comaBtn_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Crimson;
            this.btn0.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.Font = new System.Drawing.Font("Bebas Neue Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn0.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn0.Location = new System.Drawing.Point(134, 351);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(67, 47);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Crimson;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Font = new System.Drawing.Font("Bebas Neue Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn3.Location = new System.Drawing.Point(207, 298);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(67, 47);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Crimson;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Font = new System.Drawing.Font("Bebas Neue Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn2.Location = new System.Drawing.Point(134, 298);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(67, 47);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Crimson;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("Bebas Neue Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn1.Location = new System.Drawing.Point(61, 298);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(67, 47);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Crimson;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Font = new System.Drawing.Font("Bebas Neue Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn6.Location = new System.Drawing.Point(207, 245);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(67, 47);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Crimson;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Font = new System.Drawing.Font("Bebas Neue Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn5.Location = new System.Drawing.Point(134, 245);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(67, 47);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Crimson;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Font = new System.Drawing.Font("Bebas Neue Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn4.Location = new System.Drawing.Point(61, 245);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(67, 47);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Crimson;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.Font = new System.Drawing.Font("Bebas Neue Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn9.Location = new System.Drawing.Point(207, 192);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(67, 47);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Crimson;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Font = new System.Drawing.Font("Bebas Neue Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn8.Location = new System.Drawing.Point(134, 192);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(67, 47);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Crimson;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Font = new System.Drawing.Font("Bebas Neue Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn7.Location = new System.Drawing.Point(61, 192);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(67, 47);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // littleRb
            // 
            this.littleRb.AutoSize = true;
            this.littleRb.Checked = true;
            this.littleRb.Location = new System.Drawing.Point(6, 26);
            this.littleRb.Name = "littleRb";
            this.littleRb.Size = new System.Drawing.Size(63, 24);
            this.littleRb.TabIndex = 1;
            this.littleRb.TabStop = true;
            this.littleRb.Text = "Little";
            this.littleRb.UseVisualStyleBackColor = true;
            this.littleRb.AppearanceChanged += new System.EventHandler(this.bigRb_AppearanceChanged);
            this.littleRb.CheckedChanged += new System.EventHandler(this.littleRb_CheckedChanged);
            this.littleRb.TabIndexChanged += new System.EventHandler(this.littleRb_TabIndexChanged);
            // 
            // bigRb
            // 
            this.bigRb.AutoSize = true;
            this.bigRb.Location = new System.Drawing.Point(6, 56);
            this.bigRb.Name = "bigRb";
            this.bigRb.Size = new System.Drawing.Size(52, 24);
            this.bigRb.TabIndex = 2;
            this.bigRb.Text = "Big";
            this.bigRb.UseVisualStyleBackColor = true;
            this.bigRb.AppearanceChanged += new System.EventHandler(this.bigRb_AppearanceChanged);
            this.bigRb.CheckedChanged += new System.EventHandler(this.littleRb_CheckedChanged);
            this.bigRb.TabIndexChanged += new System.EventHandler(this.littleRb_TabIndexChanged);
            // 
            // modesGroupBox
            // 
            this.modesGroupBox.Controls.Add(this.littleRb);
            this.modesGroupBox.Controls.Add(this.bigRb);
            this.modesGroupBox.Location = new System.Drawing.Point(371, 12);
            this.modesGroupBox.Name = "modesGroupBox";
            this.modesGroupBox.Size = new System.Drawing.Size(112, 103);
            this.modesGroupBox.TabIndex = 3;
            this.modesGroupBox.TabStop = false;
            this.modesGroupBox.Text = "MODES:";
            this.modesGroupBox.Enter += new System.EventHandler(this.modesGroupBox_Enter);
            // 
            // angleGroupBox
            // 
            this.angleGroupBox.Controls.Add(this.radioButton1);
            this.angleGroupBox.Controls.Add(this.radioButton2);
            this.angleGroupBox.Location = new System.Drawing.Point(368, 121);
            this.angleGroupBox.Name = "angleGroupBox";
            this.angleGroupBox.Size = new System.Drawing.Size(112, 103);
            this.angleGroupBox.TabIndex = 4;
            this.angleGroupBox.TabStop = false;
            this.angleGroupBox.Text = "ANGLE:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 24);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Degrees";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 24);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Radians";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // sinBtn
            // 
            this.sinBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.sinBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.sinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sinBtn.Font = new System.Drawing.Font("Bebas Neue Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sinBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sinBtn.Location = new System.Drawing.Point(137, 419);
            this.sinBtn.Name = "sinBtn";
            this.sinBtn.Size = new System.Drawing.Size(67, 47);
            this.sinBtn.TabIndex = 21;
            this.sinBtn.Text = "SIN";
            this.sinBtn.UseVisualStyleBackColor = false;
            this.sinBtn.Click += new System.EventHandler(this.sinBtn_Click);
            // 
            // cosBtn
            // 
            this.cosBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.cosBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.cosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cosBtn.Font = new System.Drawing.Font("Bebas Neue Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cosBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cosBtn.Location = new System.Drawing.Point(210, 419);
            this.cosBtn.Name = "cosBtn";
            this.cosBtn.Size = new System.Drawing.Size(67, 47);
            this.cosBtn.TabIndex = 22;
            this.cosBtn.Text = "COS";
            this.cosBtn.UseVisualStyleBackColor = false;
            this.cosBtn.Click += new System.EventHandler(this.cosBtn_Click);
            // 
            // tanBtn
            // 
            this.tanBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.tanBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.tanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tanBtn.Font = new System.Drawing.Font("Bebas Neue Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tanBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tanBtn.Location = new System.Drawing.Point(283, 419);
            this.tanBtn.Name = "tanBtn";
            this.tanBtn.Size = new System.Drawing.Size(67, 47);
            this.tanBtn.TabIndex = 23;
            this.tanBtn.Text = "TAN";
            this.tanBtn.UseVisualStyleBackColor = false;
            this.tanBtn.Click += new System.EventHandler(this.tanBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(500, 514);
            this.Controls.Add(this.tanBtn);
            this.Controls.Add(this.cosBtn);
            this.Controls.Add(this.sinBtn);
            this.Controls.Add(this.angleGroupBox);
            this.Controls.Add(this.modesGroupBox);
            this.Controls.Add(this.buttonsGroupBox);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "COS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.buttonsGroupBox.ResumeLayout(false);
            this.buttonsGroupBox.PerformLayout();
            this.modesGroupBox.ResumeLayout(false);
            this.modesGroupBox.PerformLayout();
            this.angleGroupBox.ResumeLayout(false);
            this.angleGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox buttonsGroupBox;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button equalsBtn;
        private System.Windows.Forms.Button comaBtn;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.TextBox displayTxtBox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button clearOneBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button multBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button changleSymbBtn;
        private System.Windows.Forms.RadioButton littleRb;
        private System.Windows.Forms.RadioButton bigRb;
        private System.Windows.Forms.GroupBox modesGroupBox;
        private System.Windows.Forms.GroupBox angleGroupBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button sinBtn;
        private System.Windows.Forms.Button cosBtn;
        private System.Windows.Forms.Button tanBtn;
    }
}

