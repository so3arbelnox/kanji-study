using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KanjiApp.StudyForm;

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

            if (rbtn_all_random.Checked)
            {
                StudyForm sf = new StudyForm(StudyOption.ALL, 0, 0, 0);
                sf.ShowDialog();
            }
            else if (rbtn_amount.Checked)
            {
                int amount = (int)nm_amount.Value;
                int start = -1;
                int end = -1;

                if (chkBoxFromRange.Checked)
                {
                    start = (int)nm_start.Value;
                    end = (int)nm_end.Value;
                }

                StudyForm sf = new StudyForm(StudyOption.AMOUNT, start, end, amount);
                sf.ShowDialog();
            }
        }

        private void rbtn_amount_CheckedChanged(object sender, EventArgs e)
        {
            nm_start.Enabled = false;
            nm_end.Enabled = false;
            nm_amount.Enabled = true;
            chkBoxFromRange.Enabled = true;
        }

        private void rbtn_all_random_CheckedChanged(object sender, EventArgs e)
        {
            nm_amount.Enabled = false;
            chkBoxFromRange.Enabled = false;
        }

        private void grp_box_Enter(object sender, EventArgs e)
        {

        }

        private void chkBoxFromRange_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxFromRange.Checked)
            {
                nm_start.Enabled = true;
                nm_end.Enabled = true;
            }
            else
            {
                nm_start.Enabled = false;
                nm_end.Enabled = false;
            }
        }
    }
}
