namespace baocaodoan
{
    partial class FDanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDanhMuc));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsSP = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsTKHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.liênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhómToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "apple-event-september-7-1-17-0-screenshot.jpg");
            this.imageList1.Images.SetKeyName(1, "Actions-window-duplicate-icon.png");
            this.imageList1.Images.SetKeyName(2, "Close-icon.png");
            this.imageList1.Images.SetKeyName(3, "Programming-Minimize-Window-icon.png");
            this.imageList1.Images.SetKeyName(4, "Zoom-icon.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.liênToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsKH,
            this.mnsSP,
            this.mnsNV,
            this.mnsHD,
            this.mnsExit});
            this.danhMụcToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("danhMụcToolStripMenuItem.Image")));
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // mnsKH
            // 
            this.mnsKH.Image = ((System.Drawing.Image)(resources.GetObject("mnsKH.Image")));
            this.mnsKH.Name = "mnsKH";
            this.mnsKH.Size = new System.Drawing.Size(180, 22);
            this.mnsKH.Text = "Khách Hàng";
            this.mnsKH.Click += new System.EventHandler(this.mnsKH_Click);
            // 
            // mnsSP
            // 
            this.mnsSP.Image = ((System.Drawing.Image)(resources.GetObject("mnsSP.Image")));
            this.mnsSP.Name = "mnsSP";
            this.mnsSP.Size = new System.Drawing.Size(180, 22);
            this.mnsSP.Text = "Sản Phẩm";
            this.mnsSP.Click += new System.EventHandler(this.mnsSP_Click);
            // 
            // mnsNV
            // 
            this.mnsNV.Image = ((System.Drawing.Image)(resources.GetObject("mnsNV.Image")));
            this.mnsNV.Name = "mnsNV";
            this.mnsNV.Size = new System.Drawing.Size(180, 22);
            this.mnsNV.Text = "Nhân Viên";
            this.mnsNV.Click += new System.EventHandler(this.mnsNV_Click);
            // 
            // mnsHD
            // 
            this.mnsHD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsTKHD});
            this.mnsHD.Image = ((System.Drawing.Image)(resources.GetObject("mnsHD.Image")));
            this.mnsHD.Name = "mnsHD";
            this.mnsHD.Size = new System.Drawing.Size(180, 22);
            this.mnsHD.Text = "Hóa Đơn";
            // 
            // mnsTKHD
            // 
            this.mnsTKHD.Image = ((System.Drawing.Image)(resources.GetObject("mnsTKHD.Image")));
            this.mnsTKHD.Name = "mnsTKHD";
            this.mnsTKHD.Size = new System.Drawing.Size(180, 22);
            this.mnsTKHD.Text = "Tìm Kiếm Hóa Đơn";
            this.mnsTKHD.Click += new System.EventHandler(this.mnsTKHD_Click);
            // 
            // mnsExit
            // 
            this.mnsExit.Image = ((System.Drawing.Image)(resources.GetObject("mnsExit.Image")));
            this.mnsExit.Name = "mnsExit";
            this.mnsExit.Size = new System.Drawing.Size(180, 22);
            this.mnsExit.Text = "Exit";
            this.mnsExit.Click += new System.EventHandler(this.mnsExit_Click);
            // 
            // liênToolStripMenuItem
            // 
            this.liênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhómToolStripMenuItem});
            this.liênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("liênToolStripMenuItem.Image")));
            this.liênToolStripMenuItem.Name = "liênToolStripMenuItem";
            this.liênToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.liênToolStripMenuItem.Text = "Liên Hệ";
            // 
            // nhómToolStripMenuItem
            // 
            this.nhómToolStripMenuItem.Name = "nhómToolStripMenuItem";
            this.nhómToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.nhómToolStripMenuItem.Text = "Nhóm ";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(663, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 35);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::baocaodoan.Properties.Resources.apple_event_september_7_1_17_0_screenshot;
            this.pictureBox1.Location = new System.Drawing.Point(0, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 388);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(708, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 35);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.Location = new System.Drawing.Point(749, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 35);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FDanhMuc";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnsKH;
        private System.Windows.Forms.ToolStripMenuItem mnsSP;
        private System.Windows.Forms.ToolStripMenuItem mnsNV;
        private System.Windows.Forms.ToolStripMenuItem mnsHD;
        private System.Windows.Forms.ToolStripMenuItem mnsExit;
        private System.Windows.Forms.ToolStripMenuItem liênToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem mnsTKHD;
        private System.Windows.Forms.ToolStripMenuItem nhómToolStripMenuItem;
    }
}