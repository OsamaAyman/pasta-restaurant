namespace pasta
{
    partial class menu_control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_control));
            this.menu_gridview = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.item_picture = new System.Windows.Forms.PictureBox();
            this.sound_switch = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.menu_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_gridview
            // 
            this.menu_gridview.AllowUserToAddRows = false;
            this.menu_gridview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menu_gridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.menu_gridview.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.menu_gridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menu_gridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menu_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.menu_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
           // this.menu_gridview.DoubleBuffered = true;
            this.menu_gridview.EnableHeadersVisualStyles = false;
            this.menu_gridview.Location = new System.Drawing.Point(3, 3);
            this.menu_gridview.MultiSelect = false;
            this.menu_gridview.Name = "menu_gridview";
            this.menu_gridview.ReadOnly = true;
            this.menu_gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.menu_gridview.Size = new System.Drawing.Size(354, 475);
            this.menu_gridview.TabIndex = 0;
            this.menu_gridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menu_gridview_CellClick);
            // 
            // item_picture
            // 
            this.item_picture.Location = new System.Drawing.Point(432, 72);
            this.item_picture.Name = "item_picture";
            this.item_picture.Size = new System.Drawing.Size(303, 372);
            this.item_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.item_picture.TabIndex = 1;
            this.item_picture.TabStop = false;
            // 
            // sound_switch
            // 
            this.sound_switch.BackColor = System.Drawing.Color.Transparent;
            this.sound_switch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sound_switch.BackgroundImage")));
            this.sound_switch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sound_switch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sound_switch.Location = new System.Drawing.Point(368, 48);
            this.sound_switch.Name = "sound_switch";
            this.sound_switch.OffColor = System.Drawing.Color.Gray;
            this.sound_switch.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.sound_switch.Size = new System.Drawing.Size(43, 25);
            this.sound_switch.TabIndex = 3;
            this.sound_switch.Value = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sound";
            // 
            // search_txt
            // 
            this.search_txt.AutoCompleteCustomSource.AddRange(new string[] {
            "French Toast",
            "Plain Omelette",
            "Cheese Omelettee",
            "Pancake Stack",
            "Beef Steack",
            "T-Bone Steak",
            "Satay Chicken",
            "Honey Chicken",
            "Sizzling Chicken",
            "Pasta Fettuccine",
            "Chicken Melt",
            "Super Brid Sandwitch ",
            "Burger",
            "Chicken Burger",
            "Tea",
            "Coffe",
            "Hot Chocolate",
            "Nescafe",
            "Cappuccino",
            "Fresh Juice"});
            this.search_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.search_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.search_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_txt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.Location = new System.Drawing.Point(521, 6);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(247, 20);
            this.search_txt.TabIndex = 5;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Image = global::pasta.Properties.Resources.icons8_Search_25px;
            this.search.Location = new System.Drawing.Point(463, 3);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(52, 23);
            this.search.TabIndex = 6;
            this.search.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // menu_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.search);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sound_switch);
            this.Controls.Add(this.item_picture);
            this.Controls.Add(this.menu_gridview);
            this.Name = "menu_control";
            this.Size = new System.Drawing.Size(795, 481);
            this.Load += new System.EventHandler(this.menu_control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menu_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid menu_gridview;
        private System.Windows.Forms.PictureBox item_picture;
        private Bunifu.Framework.UI.BunifuiOSSwitch sound_switch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Button search;
    }
}
