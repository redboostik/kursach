namespace GraphViewer
{
    partial class form_list_of_rebrs
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textbox_list_rebr = new System.Windows.Forms.TextBox();
            this.button_build = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textbox_list_rebr
            // 
            this.textbox_list_rebr.Location = new System.Drawing.Point(12, 60);
            this.textbox_list_rebr.Multiline = true;
            this.textbox_list_rebr.Name = "textbox_list_rebr";
            this.textbox_list_rebr.Size = new System.Drawing.Size(121, 245);
            this.textbox_list_rebr.TabIndex = 1;
            this.textbox_list_rebr.TextChanged += new System.EventHandler(this.textbox_list_rebr_TextChanged);
            // 
            // button_build
            // 
            this.button_build.Location = new System.Drawing.Point(58, 311);
            this.button_build.Name = "button_build";
            this.button_build.Size = new System.Drawing.Size(75, 23);
            this.button_build.TabIndex = 2;
            this.button_build.Text = "Построить";
            this.button_build.UseVisualStyleBackColor = true;
            this.button_build.Click += new System.EventHandler(this.button_build_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "количество вершин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "начало конец масса";
            // 
            // form_list_of_rebrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(147, 344);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_build);
            this.Controls.Add(this.textbox_list_rebr);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_list_of_rebrs";
            this.Text = "Список ребер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textbox_list_rebr;
        private System.Windows.Forms.Button button_build;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}