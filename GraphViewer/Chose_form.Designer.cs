namespace GraphViewer
{
    partial class Chose_form
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
            this.button_drawing = new System.Windows.Forms.Button();
            this.button_list_of_rebr = new System.Windows.Forms.Button();
            this.button_graph_view = new System.Windows.Forms.Button();
            this.button_start_Deextra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_drawing
            // 
            this.button_drawing.Location = new System.Drawing.Point(12, 8);
            this.button_drawing.Name = "button_drawing";
            this.button_drawing.Size = new System.Drawing.Size(167, 23);
            this.button_drawing.TabIndex = 0;
            this.button_drawing.Text = "Рисованием";
            this.button_drawing.UseVisualStyleBackColor = true;
            this.button_drawing.Click += new System.EventHandler(this.button_drawing_Click);
            // 
            // button_list_of_rebr
            // 
            this.button_list_of_rebr.Location = new System.Drawing.Point(12, 37);
            this.button_list_of_rebr.Name = "button_list_of_rebr";
            this.button_list_of_rebr.Size = new System.Drawing.Size(167, 23);
            this.button_list_of_rebr.TabIndex = 1;
            this.button_list_of_rebr.Text = "Списком ребер";
            this.button_list_of_rebr.UseVisualStyleBackColor = true;
            this.button_list_of_rebr.Click += new System.EventHandler(this.button_list_of_rebr_Click);
            // 
            // button_graph_view
            // 
            this.button_graph_view.Location = new System.Drawing.Point(12, 66);
            this.button_graph_view.Name = "button_graph_view";
            this.button_graph_view.Size = new System.Drawing.Size(167, 23);
            this.button_graph_view.TabIndex = 2;
            this.button_graph_view.Text = "отображение\\рисование";
            this.button_graph_view.UseVisualStyleBackColor = true;
            this.button_graph_view.Click += new System.EventHandler(this.button_graph_view_Click);
            // 
            // button_start_Deextra
            // 
            this.button_start_Deextra.Location = new System.Drawing.Point(12, 95);
            this.button_start_Deextra.Name = "button_start_Deextra";
            this.button_start_Deextra.Size = new System.Drawing.Size(167, 23);
            this.button_start_Deextra.TabIndex = 3;
            this.button_start_Deextra.Text = "Алгоритм Дейкстры";
            this.button_start_Deextra.UseVisualStyleBackColor = true;
            this.button_start_Deextra.Click += new System.EventHandler(this.button_start_Deextra_Click);
            // 
            // Chose_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(191, 132);
            this.Controls.Add(this.button_start_Deextra);
            this.Controls.Add(this.button_graph_view);
            this.Controls.Add(this.button_list_of_rebr);
            this.Controls.Add(this.button_drawing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Chose_form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_drawing;
        private System.Windows.Forms.Button button_list_of_rebr;
        private System.Windows.Forms.Button button_graph_view;
        private System.Windows.Forms.Button button_start_Deextra;
    }
}