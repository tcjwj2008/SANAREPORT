using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMesCenter
{
    public partial class frmWaiting : Form
    {
			private Label label1;
			private PictureBox pictureBox1;
		
        public frmWaiting()
        {
            InitializeComponent();
            //SetText("");

        }
        private delegate void SetTextHandler(string text);
        public void SetText(string text)
        {
            if (label1.InvokeRequired)
            {
                 this.Invoke(new SetTextHandler(SetText), text);
             }
            else
            {
                this.label1.Text = text;
            }


        }

          private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout(); 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(197, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 260);
            this.label1.TabIndex = 3;
            this.label1.Text = "正在处理数据，请稍候......";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
    
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::SMesCenter.Properties.Resources.正在处理;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 260);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
   
            this.ClientSize = new System.Drawing.Size(677, 260);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmWaiting";
            this.Load += new System.EventHandler(this.frmWaiting_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

     

        private void frmWaiting_Load(object sender, EventArgs e)
        {

        }

			

				private void frmWaiting_Load_1(object sender, EventArgs e)
				{

				}

				private void label1_Click(object sender, EventArgs e)
				{

				}

                private void label1_Click_1(object sender, EventArgs e)
                {

                }

                private void label1_Click_2(object sender, EventArgs e)
                {

                }
    }
}
