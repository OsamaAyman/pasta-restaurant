namespace pasta
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.top_panel2 = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.front_panal = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo_pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.recom_name = new System.Windows.Forms.Label();
            this.recom_pic = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.top_panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recom_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // top_panel2
            // 
            this.top_panel2.BackColor = System.Drawing.Color.Black;
            this.top_panel2.Controls.Add(this.minimize);
            this.top_panel2.Controls.Add(this.exitButton);
            this.top_panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel2.Location = new System.Drawing.Point(0, 0);
            this.top_panel2.Name = "top_panel2";
            this.top_panel2.Size = new System.Drawing.Size(967, 25);
            this.top_panel2.TabIndex = 0;
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(61)))), ((int)(((byte)(105)))));
            this.minimize.Location = new System.Drawing.Point(905, -11);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(29, 40);
            this.minimize.TabIndex = 3;
            this.minimize.Text = "-";
            this.minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(61)))), ((int)(((byte)(105)))));
            this.exitButton.Location = new System.Drawing.Point(931, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(30, 29);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // front_panal
            // 
            this.front_panal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.front_panal.Location = new System.Drawing.Point(167, 25);
            this.front_panal.Name = "front_panal";
            this.front_panal.Size = new System.Drawing.Size(800, 483);
            this.front_panal.TabIndex = 1;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.top_panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.logo_pic);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.recom_name);
            this.panel1.Controls.Add(this.recom_pic);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 483);
            this.panel1.TabIndex = 2;
            // 
            // logo_pic
            // 
            this.logo_pic.Image = global::pasta.Properties.Resources.pasta_logo5;
            this.logo_pic.Location = new System.Drawing.Point(4, 6);
            this.logo_pic.Name = "logo_pic";
            this.logo_pic.Size = new System.Drawing.Size(160, 148);
            this.logo_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_pic.TabIndex = 3;
            this.logo_pic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recommended this week";
            // 
            // recom_name
            // 
            this.recom_name.AutoSize = true;
            this.recom_name.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recom_name.Location = new System.Drawing.Point(48, 200);
            this.recom_name.Name = "recom_name";
            this.recom_name.Size = new System.Drawing.Size(59, 23);
            this.recom_name.TabIndex = 2;
            this.recom_name.Text = "label1";
            // 
            // recom_pic
            // 
            this.recom_pic.Location = new System.Drawing.Point(4, 249);
            this.recom_pic.Name = "recom_pic";
            this.recom_pic.Size = new System.Drawing.Size(158, 140);
            this.recom_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recom_pic.TabIndex = 1;
            this.recom_pic.TabStop = false;
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.Teal;
            this.backBtn.Image = global::pasta.Properties.Resources.icons8_Undo_40px_1;
            this.backBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backBtn.Location = new System.Drawing.Point(13, 410);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(123, 65);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Back";
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 508);
            this.Controls.Add(this.front_panal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.top_panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.top_panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recom_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel2;
        private System.Windows.Forms.Panel front_panal;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minimize;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label recom_name;
        private System.Windows.Forms.PictureBox recom_pic;
        private System.Windows.Forms.PictureBox logo_pic;
    }
}