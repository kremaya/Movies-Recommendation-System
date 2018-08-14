namespace romaMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rank_pnl = new System.Windows.Forms.Panel();
            this.count_lbl = new System.Windows.Forms.Label();
            this.movieID_rank_lbl = new System.Windows.Forms.Label();
            this.skip_rank_btn = new System.Windows.Forms.Button();
            this.movieName_rank_lbl = new System.Windows.Forms.Label();
            this.chk5_rank_radio = new System.Windows.Forms.RadioButton();
            this.instruction_rank_lbl = new System.Windows.Forms.Label();
            this.chk4_rank_radio = new System.Windows.Forms.RadioButton();
            this.chk3_rank_radio = new System.Windows.Forms.RadioButton();
            this.chk2_rank_radio = new System.Windows.Forms.RadioButton();
            this.rank_rank_btn = new System.Windows.Forms.Button();
            this.chk1_rank_radio = new System.Windows.Forms.RadioButton();
            this.movie_rank_pick = new System.Windows.Forms.PictureBox();
            this.recommand_pnl = new System.Windows.Forms.Panel();
            this.pnl_hide = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.more_btn = new System.Windows.Forms.Button();
            this.new_btn = new System.Windows.Forms.Button();
            this.rcm_up_pnl = new System.Windows.Forms.Panel();
            this.recommend_lbl = new System.Windows.Forms.Label();
            this.rank_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movie_rank_pick)).BeginInit();
            this.recommand_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.rcm_up_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // rank_pnl
            // 
            this.rank_pnl.BackColor = System.Drawing.Color.Transparent;
            this.rank_pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rank_pnl.Controls.Add(this.count_lbl);
            this.rank_pnl.Controls.Add(this.movieID_rank_lbl);
            this.rank_pnl.Controls.Add(this.skip_rank_btn);
            this.rank_pnl.Controls.Add(this.movieName_rank_lbl);
            this.rank_pnl.Controls.Add(this.chk5_rank_radio);
            this.rank_pnl.Controls.Add(this.instruction_rank_lbl);
            this.rank_pnl.Controls.Add(this.chk4_rank_radio);
            this.rank_pnl.Controls.Add(this.chk3_rank_radio);
            this.rank_pnl.Controls.Add(this.chk2_rank_radio);
            this.rank_pnl.Controls.Add(this.rank_rank_btn);
            this.rank_pnl.Controls.Add(this.chk1_rank_radio);
            this.rank_pnl.Controls.Add(this.movie_rank_pick);
            this.rank_pnl.Location = new System.Drawing.Point(12, 124);
            this.rank_pnl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rank_pnl.Name = "rank_pnl";
            this.rank_pnl.Size = new System.Drawing.Size(1724, 714);
            this.rank_pnl.TabIndex = 0;
            // 
            // count_lbl
            // 
            this.count_lbl.AutoSize = true;
            this.count_lbl.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.count_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.count_lbl.Location = new System.Drawing.Point(34, 492);
            this.count_lbl.Name = "count_lbl";
            this.count_lbl.Size = new System.Drawing.Size(58, 25);
            this.count_lbl.TabIndex = 9;
            this.count_lbl.Text = "1/10";
            // 
            // movieID_rank_lbl
            // 
            this.movieID_rank_lbl.AutoSize = true;
            this.movieID_rank_lbl.Location = new System.Drawing.Point(441, 37);
            this.movieID_rank_lbl.Name = "movieID_rank_lbl";
            this.movieID_rank_lbl.Size = new System.Drawing.Size(24, 21);
            this.movieID_rank_lbl.TabIndex = 2;
            this.movieID_rank_lbl.Text = "id";
            this.movieID_rank_lbl.Visible = false;
            // 
            // skip_rank_btn
            // 
            this.skip_rank_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.skip_rank_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skip_rank_btn.FlatAppearance.BorderSize = 0;
            this.skip_rank_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skip_rank_btn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.skip_rank_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.skip_rank_btn.Location = new System.Drawing.Point(481, 420);
            this.skip_rank_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.skip_rank_btn.Name = "skip_rank_btn";
            this.skip_rank_btn.Size = new System.Drawing.Size(104, 46);
            this.skip_rank_btn.TabIndex = 8;
            this.skip_rank_btn.Text = "Skip";
            this.skip_rank_btn.UseVisualStyleBackColor = false;
            this.skip_rank_btn.Click += new System.EventHandler(this.skip_rank_btn_Click);
            // 
            // movieName_rank_lbl
            // 
            this.movieName_rank_lbl.AutoSize = true;
            this.movieName_rank_lbl.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.movieName_rank_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.movieName_rank_lbl.Location = new System.Drawing.Point(33, 58);
            this.movieName_rank_lbl.Name = "movieName_rank_lbl";
            this.movieName_rank_lbl.Size = new System.Drawing.Size(102, 37);
            this.movieName_rank_lbl.TabIndex = 1;
            this.movieName_rank_lbl.Text = "name";
            // 
            // chk5_rank_radio
            // 
            this.chk5_rank_radio.AutoSize = true;
            this.chk5_rank_radio.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.chk5_rank_radio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chk5_rank_radio.Location = new System.Drawing.Point(349, 351);
            this.chk5_rank_radio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk5_rank_radio.Name = "chk5_rank_radio";
            this.chk5_rank_radio.Size = new System.Drawing.Size(132, 29);
            this.chk5_rank_radio.TabIndex = 7;
            this.chk5_rank_radio.TabStop = true;
            this.chk5_rank_radio.Text = "5-highest";
            this.chk5_rank_radio.UseVisualStyleBackColor = true;
            // 
            // instruction_rank_lbl
            // 
            this.instruction_rank_lbl.AutoSize = true;
            this.instruction_rank_lbl.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.instruction_rank_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.instruction_rank_lbl.Location = new System.Drawing.Point(34, 7);
            this.instruction_rank_lbl.Name = "instruction_rank_lbl";
            this.instruction_rank_lbl.Size = new System.Drawing.Size(544, 30);
            this.instruction_rank_lbl.TabIndex = 0;
            this.instruction_rank_lbl.Text = "Hello, please rank 10 of the following movies";
            // 
            // chk4_rank_radio
            // 
            this.chk4_rank_radio.AutoSize = true;
            this.chk4_rank_radio.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.chk4_rank_radio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chk4_rank_radio.Location = new System.Drawing.Point(349, 292);
            this.chk4_rank_radio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk4_rank_radio.Name = "chk4_rank_radio";
            this.chk4_rank_radio.Size = new System.Drawing.Size(49, 29);
            this.chk4_rank_radio.TabIndex = 6;
            this.chk4_rank_radio.TabStop = true;
            this.chk4_rank_radio.Text = "4";
            this.chk4_rank_radio.UseVisualStyleBackColor = true;
            // 
            // chk3_rank_radio
            // 
            this.chk3_rank_radio.AutoSize = true;
            this.chk3_rank_radio.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.chk3_rank_radio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chk3_rank_radio.Location = new System.Drawing.Point(349, 232);
            this.chk3_rank_radio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk3_rank_radio.Name = "chk3_rank_radio";
            this.chk3_rank_radio.Size = new System.Drawing.Size(49, 29);
            this.chk3_rank_radio.TabIndex = 5;
            this.chk3_rank_radio.TabStop = true;
            this.chk3_rank_radio.Text = "3";
            this.chk3_rank_radio.UseVisualStyleBackColor = true;
            // 
            // chk2_rank_radio
            // 
            this.chk2_rank_radio.AutoSize = true;
            this.chk2_rank_radio.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.chk2_rank_radio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chk2_rank_radio.Location = new System.Drawing.Point(349, 171);
            this.chk2_rank_radio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk2_rank_radio.Name = "chk2_rank_radio";
            this.chk2_rank_radio.Size = new System.Drawing.Size(49, 29);
            this.chk2_rank_radio.TabIndex = 4;
            this.chk2_rank_radio.TabStop = true;
            this.chk2_rank_radio.Text = "2";
            this.chk2_rank_radio.UseVisualStyleBackColor = true;
            // 
            // rank_rank_btn
            // 
            this.rank_rank_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.rank_rank_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rank_rank_btn.FlatAppearance.BorderSize = 0;
            this.rank_rank_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rank_rank_btn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rank_rank_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rank_rank_btn.Location = new System.Drawing.Point(349, 420);
            this.rank_rank_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rank_rank_btn.Name = "rank_rank_btn";
            this.rank_rank_btn.Size = new System.Drawing.Size(107, 46);
            this.rank_rank_btn.TabIndex = 3;
            this.rank_rank_btn.Text = "Rank";
            this.rank_rank_btn.UseVisualStyleBackColor = false;
            this.rank_rank_btn.Click += new System.EventHandler(this.rank_rank_btn_Click);
            // 
            // chk1_rank_radio
            // 
            this.chk1_rank_radio.AutoSize = true;
            this.chk1_rank_radio.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.chk1_rank_radio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chk1_rank_radio.Location = new System.Drawing.Point(349, 112);
            this.chk1_rank_radio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk1_rank_radio.Name = "chk1_rank_radio";
            this.chk1_rank_radio.Size = new System.Drawing.Size(127, 29);
            this.chk1_rank_radio.TabIndex = 2;
            this.chk1_rank_radio.TabStop = true;
            this.chk1_rank_radio.Text = "1-lowest";
            this.chk1_rank_radio.UseVisualStyleBackColor = true;
            // 
            // movie_rank_pick
            // 
            this.movie_rank_pick.Location = new System.Drawing.Point(39, 112);
            this.movie_rank_pick.Margin = new System.Windows.Forms.Padding(3, 4, 6, 4);
            this.movie_rank_pick.Name = "movie_rank_pick";
            this.movie_rank_pick.Size = new System.Drawing.Size(236, 354);
            this.movie_rank_pick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movie_rank_pick.TabIndex = 1;
            this.movie_rank_pick.TabStop = false;
            // 
            // recommand_pnl
            // 
            this.recommand_pnl.BackColor = System.Drawing.Color.Transparent;
            this.recommand_pnl.Controls.Add(this.pnl_hide);
            this.recommand_pnl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommand_pnl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.recommand_pnl.Location = new System.Drawing.Point(9, 140);
            this.recommand_pnl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recommand_pnl.Name = "recommand_pnl";
            this.recommand_pnl.Size = new System.Drawing.Size(1784, 781);
            this.recommand_pnl.TabIndex = 1;
            this.recommand_pnl.Visible = false;
            // 
            // pnl_hide
            // 
            this.pnl_hide.Location = new System.Drawing.Point(6, 17);
            this.pnl_hide.Name = "pnl_hide";
            this.pnl_hide.Size = new System.Drawing.Size(1778, 788);
            this.pnl_hide.TabIndex = 0;
            this.pnl_hide.Visible = false;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(54, 28);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(1739, 78);
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            // 
            // more_btn
            // 
            this.more_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.more_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.more_btn.FlatAppearance.BorderSize = 0;
            this.more_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.more_btn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.more_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.more_btn.Location = new System.Drawing.Point(42, 4);
            this.more_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.more_btn.Name = "more_btn";
            this.more_btn.Size = new System.Drawing.Size(107, 46);
            this.more_btn.TabIndex = 4;
            this.more_btn.Text = "More";
            this.more_btn.UseVisualStyleBackColor = false;
            this.more_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // new_btn
            // 
            this.new_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.new_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_btn.FlatAppearance.BorderSize = 0;
            this.new_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_btn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.new_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.new_btn.Location = new System.Drawing.Point(179, 4);
            this.new_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(107, 46);
            this.new_btn.TabIndex = 5;
            this.new_btn.Text = "New";
            this.new_btn.UseVisualStyleBackColor = false;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // rcm_up_pnl
            // 
            this.rcm_up_pnl.BackColor = System.Drawing.Color.Transparent;
            this.rcm_up_pnl.Controls.Add(this.more_btn);
            this.rcm_up_pnl.Controls.Add(this.new_btn);
            this.rcm_up_pnl.Location = new System.Drawing.Point(725, 28);
            this.rcm_up_pnl.Name = "rcm_up_pnl";
            this.rcm_up_pnl.Size = new System.Drawing.Size(363, 63);
            this.rcm_up_pnl.TabIndex = 10;
            this.rcm_up_pnl.Visible = false;
            // 
            // recommend_lbl
            // 
            this.recommend_lbl.AutoSize = true;
            this.recommend_lbl.BackColor = System.Drawing.Color.Transparent;
            this.recommend_lbl.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.recommend_lbl.ForeColor = System.Drawing.Color.SkyBlue;
            this.recommend_lbl.Location = new System.Drawing.Point(45, 99);
            this.recommend_lbl.Name = "recommend_lbl";
            this.recommend_lbl.Size = new System.Drawing.Size(356, 37);
            this.recommend_lbl.TabIndex = 0;
            this.recommend_lbl.Text = "Recommended for you";
            this.recommend_lbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.recommend_lbl);
            this.Controls.Add(this.rcm_up_pnl);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.rank_pnl);
            this.Controls.Add(this.recommand_pnl);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1918, 1018);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ROMA MOVIES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.rank_pnl.ResumeLayout(false);
            this.rank_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movie_rank_pick)).EndInit();
            this.recommand_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.rcm_up_pnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel rank_pnl;
        private System.Windows.Forms.Panel recommand_pnl;
        private System.Windows.Forms.Button skip_rank_btn;
        private System.Windows.Forms.RadioButton chk5_rank_radio;
        private System.Windows.Forms.RadioButton chk4_rank_radio;
        private System.Windows.Forms.RadioButton chk3_rank_radio;
        private System.Windows.Forms.RadioButton chk2_rank_radio;
        private System.Windows.Forms.Button rank_rank_btn;
        private System.Windows.Forms.RadioButton chk1_rank_radio;
        private System.Windows.Forms.PictureBox movie_rank_pick;
        private System.Windows.Forms.Label instruction_rank_lbl;
        private System.Windows.Forms.Label movieName_rank_lbl;
        private System.Windows.Forms.Label movieID_rank_lbl;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label count_lbl;
        private System.Windows.Forms.Button more_btn;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.Panel rcm_up_pnl;
        private System.Windows.Forms.Panel pnl_hide;
        private System.Windows.Forms.Label recommend_lbl;
    }
}

