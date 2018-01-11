namespace WhatsAppCsharp
{
    partial class formRegister
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
            this.groupRequestCode = new System.Windows.Forms.GroupBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.txtBoxFullName = new System.Windows.Forms.TextBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.grpConfirm = new System.Windows.Forms.GroupBox();
            this.lblConfirmCode = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.groupRequestCode.SuspendLayout();
            this.grpConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupRequestCode
            // 
            this.groupRequestCode.Controls.Add(this.btnRequest);
            this.groupRequestCode.Controls.Add(this.txtBoxFullName);
            this.groupRequestCode.Controls.Add(this.labelFullName);
            this.groupRequestCode.Controls.Add(this.txtBoxPhone);
            this.groupRequestCode.Controls.Add(this.labelPhone);
            this.groupRequestCode.Location = new System.Drawing.Point(12, 12);
            this.groupRequestCode.Name = "groupRequestCode";
            this.groupRequestCode.Size = new System.Drawing.Size(339, 100);
            this.groupRequestCode.TabIndex = 1;
            this.groupRequestCode.TabStop = false;
            this.groupRequestCode.Text = "Step 1: Request Code";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(32, 22);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(38, 13);
            this.labelPhone.TabIndex = 0;
            this.labelPhone.Text = "Phone";
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(92, 19);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(191, 20);
            this.txtBoxPhone.TabIndex = 1;
            this.txtBoxPhone.TextChanged += new System.EventHandler(this.txtBoxPhone_TextChanged);
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(32, 56);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(54, 13);
            this.labelFullName.TabIndex = 2;
            this.labelFullName.Text = "Full Name";
            // 
            // txtBoxFullName
            // 
            this.txtBoxFullName.Location = new System.Drawing.Point(92, 49);
            this.txtBoxFullName.Name = "txtBoxFullName";
            this.txtBoxFullName.Size = new System.Drawing.Size(191, 20);
            this.txtBoxFullName.TabIndex = 3;
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(151, 77);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(75, 23);
            this.btnRequest.TabIndex = 4;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // grpConfirm
            // 
            this.grpConfirm.Controls.Add(this.btnConfirm);
            this.grpConfirm.Controls.Add(this.textBox1);
            this.grpConfirm.Controls.Add(this.lblConfirmCode);
            this.grpConfirm.Location = new System.Drawing.Point(12, 119);
            this.grpConfirm.Name = "grpConfirm";
            this.grpConfirm.Size = new System.Drawing.Size(339, 79);
            this.grpConfirm.TabIndex = 2;
            this.grpConfirm.TabStop = false;
            this.grpConfirm.Text = "Step 2: Confirm code";
            // 
            // lblConfirmCode
            // 
            this.lblConfirmCode.AutoSize = true;
            this.lblConfirmCode.Location = new System.Drawing.Point(38, 24);
            this.lblConfirmCode.Name = "lblConfirmCode";
            this.lblConfirmCode.Size = new System.Drawing.Size(32, 13);
            this.lblConfirmCode.TabIndex = 0;
            this.lblConfirmCode.Text = "Code";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(151, 50);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // formRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 261);
            this.Controls.Add(this.grpConfirm);
            this.Controls.Add(this.groupRequestCode);
            this.Name = "formRegister";
            this.ShowIcon = false;
            this.Text = "RegisterWhatsApp";
            this.groupRequestCode.ResumeLayout(false);
            this.groupRequestCode.PerformLayout();
            this.grpConfirm.ResumeLayout(false);
            this.grpConfirm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupRequestCode;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.TextBox txtBoxFullName;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.GroupBox grpConfirm;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblConfirmCode;
    }
}

