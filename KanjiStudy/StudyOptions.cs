using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanjiApp
{
    public partial class StudyOptions : UserControl
    {
        public StudyOptions()
        {
            InitializeComponent();
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            frm_study_options.ActiveForm.Close();
            frm_study_options.ActiveForm.Dispose();

            if (rbtn_all_random.Checked || rbtn_all_ordered.Checked)
            {
                StudyForm sf = new StudyForm(rbtn_all_random.Checked, false, 0, 0);
                sf.ShowDialog();
            }
            else if (rbtn_range.Checked)
            {
                int start = (int)nm_start.Value;
                int end = (int)nm_end.Value;

                StudyForm sf = new StudyForm(false, true, start, end);
                sf.ShowDialog();
            }
        }

        private void rbtn_range_CheckedChanged(object sender, EventArgs e)
        {
            nm_start.Enabled = true;
            nm_end.Enabled = true;
        }

        private void rbtn_all_ordered_CheckedChanged(object sender, EventArgs e)
        {
            nm_start.Enabled = false;
            nm_end.Enabled = false;
        }

        private void rbtn_all_random_CheckedChanged(object sender, EventArgs e)
        {
            nm_start.Enabled = false;
            nm_end.Enabled = false;
        }
    }
}
