using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace course_work_2
{
    public partial class FormLoad : Form
    {
        Decider Decider;
        Thread thr;

        private void Finish()
        {
            FormShow form = new FormShow(Decider.getHorizontalLayers(), Decider.getVerticalLayers());
            form.Show();
            Close();
        }
        private void Progress(double percent)
        {
            Invoke((Action)(() => {
                progressBar1.Value = Math.Max((int)(percent * 100) - 1, 0);
                progressBar1.Value = (int)(percent * 100);
                label2.Text = (int)(percent * 100) + "%";
            }));
        }

        public FormLoad(Decider solv)
        {
            InitializeComponent();
            
            Decider = solv;
            Decider.Finish += () => Invoke((Action)Finish);
            Decider.Process += Progress;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thr.Abort();
            Close();
        }

        private void FormLoad_Load(object sender, EventArgs e)
        {
            thr = new Thread(Decider.Start);
            thr.Start();
        }
    }
}
