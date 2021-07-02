
namespace MacroApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.stop = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label_x = new System.Windows.Forms.Label();
            this.label_y = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.want_x = new System.Windows.Forms.TextBox();
            this.want_y = new System.Windows.Forms.TextBox();
            this.see_no = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.see_yes = new System.Windows.Forms.Button();
            this.want_time = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.winform_close = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.LightCoral;
            this.stop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stop.Location = new System.Drawing.Point(0, 616);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(361, 40);
            this.stop.TabIndex = 0;
            this.stop.Text = "중지하려면 아무 키나 누르세요";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click_1);
            this.stop.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.stop_PreviewKeyDown);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.CornflowerBlue;
            this.start.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.start.Location = new System.Drawing.Point(0, 576);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(361, 40);
            this.start.TabIndex = 1;
            this.start.Text = "시작";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(361, 165);
            this.panel4.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Location = new System.Drawing.Point(81, 256);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(227, 1);
            this.panel5.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(55, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "X좌표를 입력하시오";
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_x.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label_x.Location = new System.Drawing.Point(55, 238);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(16, 15);
            this.label_x.TabIndex = 5;
            this.label_x.Text = "X";
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_y.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label_y.Location = new System.Drawing.Point(55, 313);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(15, 15);
            this.label_y.TabIndex = 8;
            this.label_y.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(55, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Y좌표를 입력하시오";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Location = new System.Drawing.Point(81, 331);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(227, 1);
            this.panel6.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // want_x
            // 
            this.want_x.Location = new System.Drawing.Point(159, 232);
            this.want_x.Name = "want_x";
            this.want_x.Size = new System.Drawing.Size(149, 21);
            this.want_x.TabIndex = 9;
            this.want_x.TextChanged += new System.EventHandler(this.want_x_TextChanged);
            // 
            // want_y
            // 
            this.want_y.Location = new System.Drawing.Point(159, 307);
            this.want_y.Name = "want_y";
            this.want_y.Size = new System.Drawing.Size(149, 21);
            this.want_y.TabIndex = 10;
            // 
            // see_no
            // 
            this.see_no.BackColor = System.Drawing.Color.Plum;
            this.see_no.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.see_no.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.see_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.see_no.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.see_no.Location = new System.Drawing.Point(0, 536);
            this.see_no.Name = "see_no";
            this.see_no.Size = new System.Drawing.Size(361, 40);
            this.see_no.TabIndex = 11;
            this.see_no.Text = "탐색 중지";
            this.see_no.UseVisualStyleBackColor = false;
            this.see_no.Click += new System.EventHandler(this.see_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // see_yes
            // 
            this.see_yes.BackColor = System.Drawing.Color.MediumPurple;
            this.see_yes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.see_yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.see_yes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.see_yes.Location = new System.Drawing.Point(0, 496);
            this.see_yes.Name = "see_yes";
            this.see_yes.Size = new System.Drawing.Size(361, 40);
            this.see_yes.TabIndex = 12;
            this.see_yes.Text = "탐색 시작";
            this.see_yes.UseVisualStyleBackColor = false;
            this.see_yes.Click += new System.EventHandler(this.see_yes_Click);
            // 
            // want_time
            // 
            this.want_time.Location = new System.Drawing.Point(159, 375);
            this.want_time.Name = "want_time";
            this.want_time.Size = new System.Drawing.Size(149, 21);
            this.want_time.TabIndex = 16;
            this.want_time.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label6.Location = new System.Drawing.Point(55, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "T";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(55, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "반복 시간을 입력하세요";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel7.Location = new System.Drawing.Point(81, 399);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(227, 1);
            this.panel7.TabIndex = 13;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // winform_close
            // 
            this.winform_close.BackColor = System.Drawing.Color.MediumPurple;
            this.winform_close.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.winform_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.winform_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.winform_close.Location = new System.Drawing.Point(0, 456);
            this.winform_close.Name = "winform_close";
            this.winform_close.Size = new System.Drawing.Size(361, 40);
            this.winform_close.TabIndex = 17;
            this.winform_close.Text = "윈폼 종료";
            this.winform_close.UseVisualStyleBackColor = false;
            this.winform_close.Click += new System.EventHandler(this.winform_close_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(361, 656);
            this.Controls.Add(this.winform_close);
            this.Controls.Add(this.want_time);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.see_yes);
            this.Controls.Add(this.see_no);
            this.Controls.Add(this.want_y);
            this.Controls.Add(this.want_x);
            this.Controls.Add(this.label_y);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label_x);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.start);
            this.Controls.Add(this.stop);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox want_x;
        private System.Windows.Forms.TextBox want_y;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button see_no;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button see_yes;
        private System.Windows.Forms.TextBox want_time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button winform_close;
    }
}

