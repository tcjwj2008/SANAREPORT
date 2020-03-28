using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMes.Controls.AppForm
{
    public partial class FindContentForm : SMes.Controls.ExtendForm.BaseForm
    {
        DataGridView dgv;
        int currentRowIndex = 0;
        int currentColumnIndex = 0;

        public FindContentForm()
        {
            InitializeComponent();
        }


        public FindContentForm(DataGridView dgv)
            : this()
        {
            this.dgv = dgv;
            this.Left = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - this.Width - 10;
            this.Top = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 9;
        }

        private void FindContentForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                FindDown();
                e.Handled = true;
            }
        }

        private void kButtonDownFind_Click(object sender, EventArgs e)
        {
            FindDown();
        }

        private void FindDown()
        {
            string findContent = this.kComboBoxFindContent.Text.Trim();
            if (!this.kComboBoxFindContent.Items.Contains(findContent))
            {
                this.kComboBoxFindContent.Items.Add(findContent);
            }

            if (this.dgv.CurrentCell != null && this.dgv.CurrentCell.RowIndex > -1)
            {
                currentRowIndex = dgv.CurrentCell.RowIndex;
                currentColumnIndex = dgv.CurrentCell.ColumnIndex + 1;
            }
            this.dgv.Rows[dgv.CurrentCell.RowIndex].Selected = false;

            bool findOk = false;
            for (; currentRowIndex < this.dgv.Rows.Count; currentRowIndex++)
            {
                if (this.dgv.Rows[currentRowIndex].Visible == true)
                {
                    for (; currentColumnIndex < this.dgv.Columns.Count; currentColumnIndex++)
                    {
                        if (this.dgv.Columns[currentColumnIndex].Visible == true)
                        {
                            if (SMes.Core.Utility.StrUtil.ValueToString(this.dgv.Rows[currentRowIndex].Cells[currentColumnIndex].FormattedValue).Contains(findContent))
                            {
                                this.dgv.FirstDisplayedCell = this.dgv.Rows[currentRowIndex].Cells[currentColumnIndex];
                                this.dgv.CurrentCell = this.dgv.Rows[currentRowIndex].Cells[currentColumnIndex];
                                findOk = true;
                                break;
                            }
                        }
                    }
                    currentColumnIndex = 0;

                    if (findOk)
                    {
                        break;
                    }
                }
            }

            if (!findOk)
            {
                MessageBox.Show("搜索完毕，没有匹配内容", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void kButtonUpFind_Click(object sender, EventArgs e)
        {
            string findContent = this.kComboBoxFindContent.Text.Trim();

            if (this.dgv.CurrentCell != null && this.dgv.CurrentCell.RowIndex > -1)
            {
                currentRowIndex = dgv.CurrentCell.RowIndex;
                currentColumnIndex = dgv.CurrentCell.ColumnIndex - 1;
            }
            this.dgv.Rows[dgv.CurrentCell.RowIndex].Selected = false;

            bool findOk = false;
            for (; currentRowIndex > -1; currentRowIndex--)
            {
                if (this.dgv.Rows[currentRowIndex].Visible == true)
                {
                    for (; currentColumnIndex > -1; currentColumnIndex--)
                    {
                        if (this.dgv.Columns[currentColumnIndex].Visible == true)
                        {
                            if (SMes.Core.Utility.StrUtil.ValueToString(this.dgv.Rows[currentRowIndex].Cells[currentColumnIndex].FormattedValue).Contains(findContent))
                            {
                                this.dgv.FirstDisplayedCell = this.dgv.Rows[currentRowIndex].Cells[currentColumnIndex];
                                this.dgv.CurrentCell = this.dgv.Rows[currentRowIndex].Cells[currentColumnIndex];
                                findOk = true;
                                break;
                            }
                        }
                    }
                    currentColumnIndex = this.dgv.Columns.Count - 1; ;

                    if (findOk)
                    {
                        break;
                    }
                }
            }

            if (!findOk)
            {
                MessageBox.Show("搜索完毕，没有匹配内容", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
