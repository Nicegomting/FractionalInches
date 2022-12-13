namespace FractionalInches
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.sbConvert = new System.Windows.Forms.Button();
            this.teMM = new System.Windows.Forms.TextBox();
            this.lbMM = new System.Windows.Forms.Label();
            this.lbInch = new System.Windows.Forms.Label();
            this.teInch = new System.Windows.Forms.TextBox();
            this.teFraction = new System.Windows.Forms.TextBox();
            this.lbFractional = new System.Windows.Forms.Label();
            this.grMain = new System.Windows.Forms.GroupBox();
            this.grMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // sbConvert
            // 
            this.sbConvert.Location = new System.Drawing.Point(14, 151);
            this.sbConvert.Name = "sbConvert";
            this.sbConvert.Size = new System.Drawing.Size(277, 23);
            this.sbConvert.TabIndex = 1;
            this.sbConvert.Text = "Convert";
            this.sbConvert.UseVisualStyleBackColor = true;
            this.sbConvert.Click += new System.EventHandler(this.sbConvert_Click);
            // 
            // teMM
            // 
            this.teMM.Location = new System.Drawing.Point(147, 29);
            this.teMM.Name = "teMM";
            this.teMM.Size = new System.Drawing.Size(105, 22);
            this.teMM.TabIndex = 2;
            this.teMM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbMM
            // 
            this.lbMM.AutoSize = true;
            this.lbMM.Location = new System.Drawing.Point(21, 32);
            this.lbMM.Name = "lbMM";
            this.lbMM.Size = new System.Drawing.Size(71, 14);
            this.lbMM.TabIndex = 3;
            this.lbMM.Text = "Millimeters";
            // 
            // lbInch
            // 
            this.lbInch.AutoSize = true;
            this.lbInch.Location = new System.Drawing.Point(21, 65);
            this.lbInch.Name = "lbInch";
            this.lbInch.Size = new System.Drawing.Size(43, 14);
            this.lbInch.TabIndex = 4;
            this.lbInch.Text = "Inches";
            // 
            // teInch
            // 
            this.teInch.Location = new System.Drawing.Point(147, 62);
            this.teInch.Name = "teInch";
            this.teInch.ReadOnly = true;
            this.teInch.Size = new System.Drawing.Size(105, 22);
            this.teInch.TabIndex = 5;
            this.teInch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // teFraction
            // 
            this.teFraction.Location = new System.Drawing.Point(147, 95);
            this.teFraction.Name = "teFraction";
            this.teFraction.ReadOnly = true;
            this.teFraction.Size = new System.Drawing.Size(105, 22);
            this.teFraction.TabIndex = 7;
            this.teFraction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbFractional
            // 
            this.lbFractional.AutoSize = true;
            this.lbFractional.Location = new System.Drawing.Point(21, 98);
            this.lbFractional.Name = "lbFractional";
            this.lbFractional.Size = new System.Drawing.Size(97, 14);
            this.lbFractional.TabIndex = 6;
            this.lbFractional.Text = "Inches (Fraction)";
            // 
            // grMain
            // 
            this.grMain.Controls.Add(this.lbMM);
            this.grMain.Controls.Add(this.teFraction);
            this.grMain.Controls.Add(this.teMM);
            this.grMain.Controls.Add(this.lbFractional);
            this.grMain.Controls.Add(this.lbInch);
            this.grMain.Controls.Add(this.teInch);
            this.grMain.Location = new System.Drawing.Point(14, 12);
            this.grMain.Name = "grMain";
            this.grMain.Size = new System.Drawing.Size(277, 133);
            this.grMain.TabIndex = 8;
            this.grMain.TabStop = false;
            this.grMain.Text = "Fractional Inches";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(309, 181);
            this.Controls.Add(this.grMain);
            this.Controls.Add(this.sbConvert);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.grMain.ResumeLayout(false);
            this.grMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button sbConvert;
        private System.Windows.Forms.TextBox teMM;
        private System.Windows.Forms.Label lbMM;
        private System.Windows.Forms.Label lbInch;
        private System.Windows.Forms.TextBox teInch;
        private System.Windows.Forms.TextBox teFraction;
        private System.Windows.Forms.Label lbFractional;
        private System.Windows.Forms.GroupBox grMain;
    }
}

