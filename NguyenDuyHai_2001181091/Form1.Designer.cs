
namespace NguyenDuyHai_2001181091
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiemToan = new System.Windows.Forms.TextBox();
            this.txtDiemLy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiemHoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiemRenLuyen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtXepLoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnXepLoai = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điểm toán";
            // 
            // txtDiemToan
            // 
            this.txtDiemToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemToan.Location = new System.Drawing.Point(172, 47);
            this.txtDiemToan.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiemToan.Name = "txtDiemToan";
            this.txtDiemToan.Size = new System.Drawing.Size(202, 30);
            this.txtDiemToan.TabIndex = 1;
            this.txtDiemToan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiemToan_KeyPress);
            this.txtDiemToan.Leave += new System.EventHandler(this.txtDiemToan_Leave);
            // 
            // txtDiemLy
            // 
            this.txtDiemLy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemLy.Location = new System.Drawing.Point(172, 110);
            this.txtDiemLy.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiemLy.Name = "txtDiemLy";
            this.txtDiemLy.Size = new System.Drawing.Size(202, 30);
            this.txtDiemLy.TabIndex = 3;
            this.txtDiemLy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiemLy_KeyPress);
            this.txtDiemLy.Leave += new System.EventHandler(this.txtDiemLy_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Điểm lý";
            // 
            // txtDiemHoa
            // 
            this.txtDiemHoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemHoa.Location = new System.Drawing.Point(172, 167);
            this.txtDiemHoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiemHoa.Name = "txtDiemHoa";
            this.txtDiemHoa.Size = new System.Drawing.Size(202, 30);
            this.txtDiemHoa.TabIndex = 5;
            this.txtDiemHoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiemHoa_KeyPress);
            this.txtDiemHoa.Leave += new System.EventHandler(this.txtDiemHoa_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Điểm hóa";
            // 
            // txtDiemRenLuyen
            // 
            this.txtDiemRenLuyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemRenLuyen.Location = new System.Drawing.Point(172, 222);
            this.txtDiemRenLuyen.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiemRenLuyen.Name = "txtDiemRenLuyen";
            this.txtDiemRenLuyen.Size = new System.Drawing.Size(202, 30);
            this.txtDiemRenLuyen.TabIndex = 7;
            this.txtDiemRenLuyen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiemRenLuyen_KeyPress);
            this.txtDiemRenLuyen.Leave += new System.EventHandler(this.txtDiemRenLuyen_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Điểm rèn luyện";
            // 
            // txtXepLoai
            // 
            this.txtXepLoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXepLoai.Location = new System.Drawing.Point(172, 274);
            this.txtXepLoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtXepLoai.Name = "txtXepLoai";
            this.txtXepLoai.Size = new System.Drawing.Size(202, 30);
            this.txtXepLoai.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 282);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kết quả xếp loại";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnXepLoai
            // 
            this.btnXepLoai.Location = new System.Drawing.Point(172, 336);
            this.btnXepLoai.Name = "btnXepLoai";
            this.btnXepLoai.Size = new System.Drawing.Size(91, 45);
            this.btnXepLoai.TabIndex = 10;
            this.btnXepLoai.Text = "Xếp loại";
            this.btnXepLoai.UseVisualStyleBackColor = true;
            this.btnXepLoai.Click += new System.EventHandler(this.btnXepLoai_Click);
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(283, 336);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 45);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnXepLoai;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(438, 393);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXepLoai);
            this.Controls.Add(this.txtXepLoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiemRenLuyen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiemHoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiemLy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDiemToan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiemToan;
        private System.Windows.Forms.TextBox txtDiemLy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiemHoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiemRenLuyen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtXepLoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnXepLoai;
    }
}

