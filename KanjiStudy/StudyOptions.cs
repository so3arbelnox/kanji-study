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
            chkBoxHideHiragana.Enabled = false;
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            frm_study_options.ActiveForm.Close();
            frm_study_options.ActiveForm.Dispose();

            // Calculate range if checked
            int start = -1;
            int end = -1;

            bool reverseCard = chkBoxReverseCard.Checked;
            bool hideHiragana = chkBoxHideHiragana.Checked;

            if (chkBoxFromRange.Checked)
            {
                start = (int)nm_start.Value;
                end = (int)nm_end.Value;
            }

            if (chkBoxAmount.Checked)
            {
                int amount = (int)nm_amount.Value;
                StudyForm sf = new StudyForm(StudyOption.AMOUNT, start, end, amount, reverseCard, hideHiragana);
                sf.ShowDialog();
            }
            else // No options means study all cards
            {
                if (start == -1 && end == -1)
                {
                    StudyForm sf = new StudyForm(StudyOption.ALL, 0, 0, 0, reverseCard, hideHiragana);
                    sf.ShowDialog();
                }
                else
                {
                    StudyForm sf = new StudyForm(StudyOption.AMOUNT, start, end, 999999, reverseCard, hideHiragana); // TODO: Modify method to study all within range without passing amount
                    sf.ShowDialog();
                }
            }
        }

        private void grp_box_Enter(object sender, EventArgs e)
        {

        }

        private void chkBoxFromRange_CheckedChanged(object sender, EventArgs e)
        {
            nm_start.Enabled = chkBoxFromRange.Checked;
            nm_end.Enabled = chkBoxFromRange.Checked;
        }

        private void chkBoxAmount_CheckedChanged(object sender, EventArgs e)
        {
            nm_amount.Enabled = chkBoxAmount.Checked;
        }

        private void chkBoxReverseCard_CheckedChanged(object sender, EventArgs e)
        {
            chkBoxHideHiragana.Enabled = chkBoxReverseCard.Checked;
        }
    }
}
