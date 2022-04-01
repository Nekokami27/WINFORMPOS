namespace WINFORM_PRAC
{
    partial class Auth_Page
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
            this.Add = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Input1 = new System.Windows.Forms.TextBox();
            this.Input2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IsDelItemVisible = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(475, 12);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(297, 55);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(475, 73);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(297, 55);
            this.Update.TabIndex = 1;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(475, 134);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(297, 55);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Input1
            // 
            this.Input1.Location = new System.Drawing.Point(475, 263);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(131, 22);
            this.Input1.TabIndex = 4;
            this.Input1.TextChanged += new System.EventHandler(this.Input1_TextChanged);
            // 
            // Input2
            // 
            this.Input2.Location = new System.Drawing.Point(641, 263);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(131, 22);
            this.Input2.TabIndex = 5;
            this.Input2.TextChanged += new System.EventHandler(this.Input2_TextChanged);
            this.Input2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input2_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(431, 405);
            this.dataGridView1.TabIndex = 7;
            // 
            // IsDelItemVisible
            // 
            this.IsDelItemVisible.AutoSize = true;
            this.IsDelItemVisible.Location = new System.Drawing.Point(475, 220);
            this.IsDelItemVisible.Name = "IsDelItemVisible";
            this.IsDelItemVisible.Size = new System.Drawing.Size(169, 16);
            this.IsDelItemVisible.TabIndex = 8;
            this.IsDelItemVisible.Text = "Set already deleted rows visible";
            this.IsDelItemVisible.UseVisualStyleBackColor = true;
            this.IsDelItemVisible.CheckedChanged += new System.EventHandler(this.IsDelItemVisible_CheckedChanged);
            // 
            // Auth_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IsDelItemVisible);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.Input1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Name = "Auth_Page";
            this.Text = "後台";
            this.Load += new System.EventHandler(this.Auth_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox Input1;
        private System.Windows.Forms.TextBox Input2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox IsDelItemVisible;
    }
}