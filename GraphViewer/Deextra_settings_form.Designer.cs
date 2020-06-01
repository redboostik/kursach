namespace GraphViewer
{
    partial class Deextra_settings_form
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
            this.textBox_start_ver = new System.Windows.Forms.TextBox();
            this.textBox_info = new System.Windows.Forms.TextBox();
            this.button_start_algo = new System.Windows.Forms.Button();
            this.DeextraTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_finish_ver = new System.Windows.Forms.TextBox();
            this.textBox_way = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_start_ver
            // 
            this.textBox_start_ver.Location = new System.Drawing.Point(13, 18);
            this.textBox_start_ver.Name = "textBox_start_ver";
            this.textBox_start_ver.Size = new System.Drawing.Size(100, 20);
            this.textBox_start_ver.TabIndex = 0;
            // 
            // textBox_info
            // 
            this.textBox_info.Location = new System.Drawing.Point(12, 82);
            this.textBox_info.Multiline = true;
            this.textBox_info.Name = "textBox_info";
            this.textBox_info.Size = new System.Drawing.Size(101, 161);
            this.textBox_info.TabIndex = 1;
            // 
            // button_start_algo
            // 
            this.button_start_algo.Location = new System.Drawing.Point(12, 419);
            this.button_start_algo.Name = "button_start_algo";
            this.button_start_algo.Size = new System.Drawing.Size(101, 23);
            this.button_start_algo.TabIndex = 1;
            this.button_start_algo.Text = "START";
            this.button_start_algo.UseVisualStyleBackColor = true;
            this.button_start_algo.Click += new System.EventHandler(this.button_start_algo_Click);
            // 
            // DeextraTimer
            // 
            this.DeextraTimer.Interval = 500;
            this.DeextraTimer.Tick += new System.EventHandler(this.DeextraTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Стартовая вершина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Конечная вершина";
            // 
            // textBox_finish_ver
            // 
            this.textBox_finish_ver.Location = new System.Drawing.Point(14, 57);
            this.textBox_finish_ver.Name = "textBox_finish_ver";
            this.textBox_finish_ver.Size = new System.Drawing.Size(100, 20);
            this.textBox_finish_ver.TabIndex = 4;
            // 
            // textBox_way
            // 
            this.textBox_way.Location = new System.Drawing.Point(12, 249);
            this.textBox_way.Multiline = true;
            this.textBox_way.Name = "textBox_way";
            this.textBox_way.Size = new System.Drawing.Size(101, 161);
            this.textBox_way.TabIndex = 6;
            // 
            // Deextra_settings_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(128, 460);
            this.Controls.Add(this.textBox_way);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_finish_ver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_start_algo);
            this.Controls.Add(this.textBox_info);
            this.Controls.Add(this.textBox_start_ver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Deextra_settings_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_start_ver;
        private System.Windows.Forms.TextBox textBox_info;
        private System.Windows.Forms.Button button_start_algo;
        private System.Windows.Forms.Timer DeextraTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_finish_ver;
        private System.Windows.Forms.TextBox textBox_way;
    }
}