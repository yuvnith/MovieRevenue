namespace MovieRevenue
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
            this.btn_SName = new System.Windows.Forms.Button();
            this.btn_SRevenue = new System.Windows.Forms.Button();
            this.MoviesList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.inp_SearchName = new System.Windows.Forms.TextBox();
            this.cb_revenue = new System.Windows.Forms.RadioButton();
            this.cb_name = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SName
            // 
            this.btn_SName.Location = new System.Drawing.Point(20, 22);
            this.btn_SName.Name = "btn_SName";
            this.btn_SName.Size = new System.Drawing.Size(75, 57);
            this.btn_SName.TabIndex = 0;
            this.btn_SName.Text = "Sort by Name";
            this.btn_SName.UseVisualStyleBackColor = true;
            this.btn_SName.Click += new System.EventHandler(this.btn_SName_Click);
            // 
            // btn_SRevenue
            // 
            this.btn_SRevenue.Location = new System.Drawing.Point(20, 117);
            this.btn_SRevenue.Name = "btn_SRevenue";
            this.btn_SRevenue.Size = new System.Drawing.Size(75, 57);
            this.btn_SRevenue.TabIndex = 1;
            this.btn_SRevenue.Text = "Sort by Revenue";
            this.btn_SRevenue.UseVisualStyleBackColor = true;
            this.btn_SRevenue.Click += new System.EventHandler(this.btn_SRevenue_Click);
            // 
            // MoviesList
            // 
            this.MoviesList.FormattingEnabled = true;
            this.MoviesList.ItemHeight = 16;
            this.MoviesList.Location = new System.Drawing.Point(122, 22);
            this.MoviesList.Name = "MoviesList";
            this.MoviesList.Size = new System.Drawing.Size(503, 148);
            this.MoviesList.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_name);
            this.groupBox2.Controls.Add(this.cb_revenue);
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Controls.Add(this.inp_SearchName);
            this.groupBox2.Location = new System.Drawing.Point(122, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 136);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(252, 34);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // inp_SearchName
            // 
            this.inp_SearchName.Location = new System.Drawing.Point(44, 34);
            this.inp_SearchName.Name = "inp_SearchName";
            this.inp_SearchName.Size = new System.Drawing.Size(157, 22);
            this.inp_SearchName.TabIndex = 0;
            // 
            // cb_revenue
            // 
            this.cb_revenue.AutoSize = true;
            this.cb_revenue.Location = new System.Drawing.Point(203, 84);
            this.cb_revenue.Name = "cb_revenue";
            this.cb_revenue.Size = new System.Drawing.Size(106, 21);
            this.cb_revenue.TabIndex = 4;
            this.cb_revenue.TabStop = true;
            this.cb_revenue.Text = "By Revenue";
            this.cb_revenue.UseVisualStyleBackColor = true;
            // 
            // cb_name
            // 
            this.cb_name.AutoSize = true;
            this.cb_name.Location = new System.Drawing.Point(43, 83);
            this.cb_name.Name = "cb_name";
            this.cb_name.Size = new System.Drawing.Size(102, 21);
            this.cb_name.TabIndex = 5;
            this.cb_name.TabStop = true;
            this.cb_name.Text = "With Name ";
            this.cb_name.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 361);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.MoviesList);
            this.Controls.Add(this.btn_SRevenue);
            this.Controls.Add(this.btn_SName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Varun Shah";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SName;
        private System.Windows.Forms.Button btn_SRevenue;
        private System.Windows.Forms.ListBox MoviesList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox inp_SearchName;
        private System.Windows.Forms.RadioButton cb_revenue;
        private System.Windows.Forms.RadioButton cb_name;
    }
}

