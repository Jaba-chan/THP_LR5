namespace THP_LR5
{
    partial class Add_AND_Edit_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonSteelArms = new System.Windows.Forms.RadioButton();
            this.radioButtonFirearms = new System.Windows.Forms.RadioButton();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(30, 51);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(124, 22);
            this.textBoxName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Цена:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(30, 134);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(123, 22);
            this.textBoxPrice.TabIndex = 4;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(30, 217);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(123, 22);
            this.textBoxWeight.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Вес:";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonSave.Location = new System.Drawing.Point(44, 339);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(109, 32);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonClose.Location = new System.Drawing.Point(159, 339);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(109, 32);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox
            // 
            this.groupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox.Controls.Add(this.radioButtonSteelArms);
            this.groupBox.Controls.Add(this.radioButtonFirearms);
            this.groupBox.Location = new System.Drawing.Point(54, 245);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.groupBox.Size = new System.Drawing.Size(214, 70);
            this.groupBox.TabIndex = 9;
            this.groupBox.TabStop = false;
            // 
            // radioButtonSteelArms
            // 
            this.radioButtonSteelArms.AutoSize = true;
            this.radioButtonSteelArms.Location = new System.Drawing.Point(11, 44);
            this.radioButtonSteelArms.Name = "radioButtonSteelArms";
            this.radioButtonSteelArms.Size = new System.Drawing.Size(144, 20);
            this.radioButtonSteelArms.TabIndex = 1;
            this.radioButtonSteelArms.TabStop = true;
            this.radioButtonSteelArms.Text = "Холодное оружие";
            this.radioButtonSteelArms.UseVisualStyleBackColor = true;
            // 
            // radioButtonFirearms
            // 
            this.radioButtonFirearms.AutoSize = true;
            this.radioButtonFirearms.Checked = true;
            this.radioButtonFirearms.Location = new System.Drawing.Point(11, 18);
            this.radioButtonFirearms.Name = "radioButtonFirearms";
            this.radioButtonFirearms.Size = new System.Drawing.Size(181, 20);
            this.radioButtonFirearms.TabIndex = 0;
            this.radioButtonFirearms.TabStop = true;
            this.radioButtonFirearms.Text = "Огнестрельное оружие";
            this.radioButtonFirearms.UseVisualStyleBackColor = true;
            // 
            // Add_AND_Edit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 383);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "Add_AND_Edit_Form";
            this.Text = "Add_AND_Edit_Form";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton radioButtonSteelArms;
        private System.Windows.Forms.RadioButton radioButtonFirearms;
    }
}