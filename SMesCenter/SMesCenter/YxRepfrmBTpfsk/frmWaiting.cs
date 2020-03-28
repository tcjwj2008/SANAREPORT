using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YxRepfrmBTpfsk
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
					this.SuspendLayout();
					// 
					// frmWaiting
					// 
					this.ClientSize = new System.Drawing.Size(899, 258);
					this.Name = "frmWaiting";
					this.Load += new System.EventHandler(this.frmWaiting_Load_2);
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

                private void frmWaiting_Load_2(object sender, EventArgs e)
                {

                }
    }
}
