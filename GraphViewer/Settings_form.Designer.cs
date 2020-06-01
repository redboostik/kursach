namespace GraphViewer
{
    partial class Settings_form
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
            this.button_add_ver = new System.Windows.Forms.Button();
            this.button_del_ver = new System.Windows.Forms.Button();
            this.button_del_rebr = new System.Windows.Forms.Button();
            this.button_add_rebr = new System.Windows.Forms.Button();
            this.button_next_step_settings = new System.Windows.Forms.Button();
            this.Text_box_Mass = new System.Windows.Forms.TextBox();
            this.button_stop_setings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_add_ver
            // 
            this.button_add_ver.Location = new System.Drawing.Point(13, 13);
            this.button_add_ver.Name = "button_add_ver";
            this.button_add_ver.Size = new System.Drawing.Size(169, 23);
            this.button_add_ver.TabIndex = 0;
            this.button_add_ver.Text = "Добавить вершину";
            this.button_add_ver.UseVisualStyleBackColor = true;
            this.button_add_ver.Click += new System.EventHandler(this.button_add_ver_Click);
            // 
            // button_del_ver
            // 
            this.button_del_ver.Location = new System.Drawing.Point(13, 42);
            this.button_del_ver.Name = "button_del_ver";
            this.button_del_ver.Size = new System.Drawing.Size(169, 23);
            this.button_del_ver.TabIndex = 1;
            this.button_del_ver.Text = "Удалить вершину";
            this.button_del_ver.UseVisualStyleBackColor = true;
            this.button_del_ver.Click += new System.EventHandler(this.button_del_ver_Click);
            // 
            // button_del_rebr
            // 
            this.button_del_rebr.Location = new System.Drawing.Point(13, 42);
            this.button_del_rebr.Name = "button_del_rebr";
            this.button_del_rebr.Size = new System.Drawing.Size(169, 23);
            this.button_del_rebr.TabIndex = 3;
            this.button_del_rebr.Text = "Удалить ребро";
            this.button_del_rebr.UseVisualStyleBackColor = true;
            this.button_del_rebr.Visible = false;
            this.button_del_rebr.Click += new System.EventHandler(this.button_del_rebr_Click);
            // 
            // button_add_rebr
            // 
            this.button_add_rebr.Location = new System.Drawing.Point(12, 71);
            this.button_add_rebr.Name = "button_add_rebr";
            this.button_add_rebr.Size = new System.Drawing.Size(169, 23);
            this.button_add_rebr.TabIndex = 2;
            this.button_add_rebr.Text = "Добавить ребро";
            this.button_add_rebr.UseVisualStyleBackColor = true;
            this.button_add_rebr.Visible = false;
            this.button_add_rebr.Click += new System.EventHandler(this.button_add_rebr_Click);
            // 
            // button_next_step_settings
            // 
            this.button_next_step_settings.Location = new System.Drawing.Point(106, 100);
            this.button_next_step_settings.Name = "button_next_step_settings";
            this.button_next_step_settings.Size = new System.Drawing.Size(75, 23);
            this.button_next_step_settings.TabIndex = 4;
            this.button_next_step_settings.Text = "NEXT->";
            this.button_next_step_settings.UseVisualStyleBackColor = true;
            this.button_next_step_settings.Click += new System.EventHandler(this.button_next_step_settings_Click);
            // 
            // Text_box_Mass
            // 
            this.Text_box_Mass.Location = new System.Drawing.Point(12, 16);
            this.Text_box_Mass.Name = "Text_box_Mass";
            this.Text_box_Mass.Size = new System.Drawing.Size(169, 20);
            this.Text_box_Mass.TabIndex = 5;
            this.Text_box_Mass.Visible = false;
            this.Text_box_Mass.TextChanged += new System.EventHandler(this.Text_box_Mass_TextChanged);
            // 
            // button_stop_setings
            // 
            this.button_stop_setings.Location = new System.Drawing.Point(106, 100);
            this.button_stop_setings.Name = "button_stop_setings";
            this.button_stop_setings.Size = new System.Drawing.Size(75, 23);
            this.button_stop_setings.TabIndex = 6;
            this.button_stop_setings.Text = "FINISH";
            this.button_stop_setings.UseVisualStyleBackColor = true;
            this.button_stop_setings.Visible = false;
            this.button_stop_setings.Click += new System.EventHandler(this.button_stop_setings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "масса ребра";
            this.label1.Visible = false;
            // 
            // Settings_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 125);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_stop_setings);
            this.Controls.Add(this.Text_box_Mass);
            this.Controls.Add(this.button_next_step_settings);
            this.Controls.Add(this.button_del_rebr);
            this.Controls.Add(this.button_add_rebr);
            this.Controls.Add(this.button_del_ver);
            this.Controls.Add(this.button_add_ver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_add_ver;
        private System.Windows.Forms.Button button_del_ver;
        private System.Windows.Forms.Button button_del_rebr;
        private System.Windows.Forms.Button button_add_rebr;
        private System.Windows.Forms.Button button_next_step_settings;
        private System.Windows.Forms.Button button_stop_setings;
        public System.Windows.Forms.TextBox Text_box_Mass;
        private System.Windows.Forms.Label label1;
    }
}