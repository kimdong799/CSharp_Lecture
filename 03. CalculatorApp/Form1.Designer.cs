namespace CalculatorApp
{
    partial class Form1
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
            this.NumScreen = new System.Windows.Forms.Label();
            this.Num1Btn = new System.Windows.Forms.Button();
            this.Num2Btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumScreen
            // 
            this.NumScreen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NumScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NumScreen.Font = new System.Drawing.Font("굴림", 15F);
            this.NumScreen.Location = new System.Drawing.Point(24, 23);
            this.NumScreen.Name = "NumScreen";
            this.NumScreen.Size = new System.Drawing.Size(475, 57);
            this.NumScreen.TabIndex = 0;
            this.NumScreen.Text = "0";
            this.NumScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Num1Btn
            // 
            this.Num1Btn.Location = new System.Drawing.Point(24, 116);
            this.Num1Btn.Name = "Num1Btn";
            this.Num1Btn.Size = new System.Drawing.Size(75, 72);
            this.Num1Btn.TabIndex = 1;
            this.Num1Btn.Text = "1";
            this.Num1Btn.UseVisualStyleBackColor = true;
            this.Num1Btn.Click += new System.EventHandler(this.Num1BtnClick);
            // 
            // Num2Btn
            // 
            this.Num2Btn.Location = new System.Drawing.Point(105, 116);
            this.Num2Btn.Name = "Num2Btn";
            this.Num2Btn.Size = new System.Drawing.Size(75, 72);
            this.Num2Btn.TabIndex = 2;
            this.Num2Btn.Text = "2";
            this.Num2Btn.UseVisualStyleBackColor = true;
            this.Num2Btn.Click += new System.EventHandler(this.Num2BtnClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(186, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 72);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Num3BtnClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(24, 194);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 72);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Num4BtnClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(105, 194);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 72);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Num5BtnClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(186, 194);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 72);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Num6BtnClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(24, 272);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 72);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Num7BtnClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(105, 272);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 72);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Num8BtnClick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(186, 272);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 72);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Num9BtnClick);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(24, 350);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 72);
            this.button10.TabIndex = 10;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Num0BtnClick);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(343, 116);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 72);
            this.button11.TabIndex = 11;
            this.button11.Text = "←";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.DelBtnClick);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(343, 194);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 72);
            this.button12.TabIndex = 12;
            this.button12.Text = "/";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.CalculateBtnClick);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(343, 272);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 72);
            this.button13.TabIndex = 13;
            this.button13.Text = "X";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.CalculateBtnClick);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(424, 194);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 72);
            this.button14.TabIndex = 14;
            this.button14.Text = "+";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.CalculateBtnClick);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(424, 272);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 72);
            this.button15.TabIndex = 15;
            this.button15.Text = "-";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.CalculateBtnClick);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(424, 116);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 72);
            this.button16.TabIndex = 16;
            this.button16.Text = "=";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.CalculateBtnClick);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(105, 350);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 72);
            this.button17.TabIndex = 17;
            this.button17.Text = "CLEAR";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.ClearBtnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Num2Btn);
            this.Controls.Add(this.Num1Btn);
            this.Controls.Add(this.NumScreen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NumScreen;
        private System.Windows.Forms.Button Num1Btn;
        private System.Windows.Forms.Button Num2Btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
    }
}

