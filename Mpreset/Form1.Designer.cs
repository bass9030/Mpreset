
namespace Mpreset
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
            this.mcPathBtn = new MetroFramework.Controls.MetroButton();
            this.mcPath = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.profilePath = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.profileBtn = new MetroFramework.Controls.MetroButton();
            this.progress = new MetroFramework.Controls.MetroProgressBar();
            this.profileList = new MetroFramework.Controls.MetroComboBox();
            this.applyrun = new MetroFramework.Controls.MetroButton();
            this.apply = new MetroFramework.Controls.MetroButton();
            this.statusText = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcPathBtn
            // 
            this.mcPathBtn.Location = new System.Drawing.Point(573, 43);
            this.mcPathBtn.Name = "mcPathBtn";
            this.mcPathBtn.Size = new System.Drawing.Size(75, 23);
            this.mcPathBtn.TabIndex = 0;
            this.mcPathBtn.Text = "폴더 선택";
            this.mcPathBtn.UseSelectable = true;
            this.mcPathBtn.Click += new System.EventHandler(this.mcPathBtn_Click);
            // 
            // mcPath
            // 
            // 
            // 
            // 
            this.mcPath.CustomButton.Image = null;
            this.mcPath.CustomButton.Location = new System.Drawing.Point(538, 1);
            this.mcPath.CustomButton.Name = "";
            this.mcPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mcPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mcPath.CustomButton.TabIndex = 1;
            this.mcPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mcPath.CustomButton.UseSelectable = true;
            this.mcPath.CustomButton.Visible = false;
            this.mcPath.Lines = new string[0];
            this.mcPath.Location = new System.Drawing.Point(7, 43);
            this.mcPath.MaxLength = 32767;
            this.mcPath.Name = "mcPath";
            this.mcPath.PasswordChar = '\0';
            this.mcPath.PromptText = ".minecraft 경로";
            this.mcPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mcPath.SelectedText = "";
            this.mcPath.SelectionLength = 0;
            this.mcPath.SelectionStart = 0;
            this.mcPath.ShortcutsEnabled = true;
            this.mcPath.Size = new System.Drawing.Size(560, 23);
            this.mcPath.TabIndex = 1;
            this.mcPath.UseSelectable = true;
            this.mcPath.WaterMark = ".minecraft 경로";
            this.mcPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mcPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.profileBtn);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.profilePath);
            this.groupBox1.Controls.Add(this.mcPathBtn);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.mcPath);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "경로 설정";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = ".minecraft 경로";
            // 
            // profilePath
            // 
            // 
            // 
            // 
            this.profilePath.CustomButton.Image = null;
            this.profilePath.CustomButton.Location = new System.Drawing.Point(538, 1);
            this.profilePath.CustomButton.Name = "";
            this.profilePath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.profilePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.profilePath.CustomButton.TabIndex = 1;
            this.profilePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.profilePath.CustomButton.UseSelectable = true;
            this.profilePath.CustomButton.Visible = false;
            this.profilePath.Lines = new string[0];
            this.profilePath.Location = new System.Drawing.Point(7, 96);
            this.profilePath.MaxLength = 32767;
            this.profilePath.Name = "profilePath";
            this.profilePath.PasswordChar = '\0';
            this.profilePath.PromptText = "프로필 저장 경로";
            this.profilePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.profilePath.SelectedText = "";
            this.profilePath.SelectionLength = 0;
            this.profilePath.SelectionStart = 0;
            this.profilePath.ShortcutsEnabled = true;
            this.profilePath.Size = new System.Drawing.Size(560, 23);
            this.profilePath.TabIndex = 3;
            this.profilePath.UseSelectable = true;
            this.profilePath.WaterMark = "프로필 저장 경로";
            this.profilePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.profilePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(7, 74);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(115, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "프로필 저장 경로";
            // 
            // profileBtn
            // 
            this.profileBtn.Location = new System.Drawing.Point(573, 96);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(75, 23);
            this.profileBtn.TabIndex = 5;
            this.profileBtn.Text = "폴더 선택";
            this.profileBtn.UseSelectable = true;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(23, 287);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(654, 10);
            this.progress.TabIndex = 3;
            // 
            // profileList
            // 
            this.profileList.FormattingEnabled = true;
            this.profileList.ItemHeight = 23;
            this.profileList.Location = new System.Drawing.Point(23, 202);
            this.profileList.Name = "profileList";
            this.profileList.Size = new System.Drawing.Size(654, 29);
            this.profileList.TabIndex = 4;
            this.profileList.UseSelectable = true;
            // 
            // applyrun
            // 
            this.applyrun.Location = new System.Drawing.Point(23, 237);
            this.applyrun.Name = "applyrun";
            this.applyrun.Size = new System.Drawing.Size(104, 23);
            this.applyrun.TabIndex = 5;
            this.applyrun.Text = "적용 및 마크시작";
            this.applyrun.UseSelectable = true;
            this.applyrun.Click += new System.EventHandler(this.applyrun_Click);
            // 
            // apply
            // 
            this.apply.Location = new System.Drawing.Point(134, 237);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(75, 23);
            this.apply.TabIndex = 6;
            this.apply.Text = "적용";
            this.apply.UseSelectable = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Location = new System.Drawing.Point(23, 263);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(0, 0);
            this.statusText.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 308);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.applyrun);
            this.Controls.Add(this.profileList);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Mpreset";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton mcPathBtn;
        private MetroFramework.Controls.MetroTextBox mcPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton profileBtn;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox profilePath;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroProgressBar progress;
        private MetroFramework.Controls.MetroComboBox profileList;
        private MetroFramework.Controls.MetroButton applyrun;
        private MetroFramework.Controls.MetroButton apply;
        private MetroFramework.Controls.MetroLabel statusText;
    }
}

