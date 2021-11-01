using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace course_work_2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            textBox_size_I_TextChanged(null, null);
            textBox_size_K_TextChanged(null, null);
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (!checkInputs())
            {
                MessageBox.Show("Не корректно введены данные", "Не могу запустить расчет", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int I = Convert.ToInt32(textBox_size_I.Text);
            int K = Convert.ToInt32(textBox_size_K.Text);
            double T = Convert.ToDouble(textBox_T.Text);
            double L = Convert.ToDouble(textBox_L.Text);
            double c = Convert.ToDouble(textBox_c.Text);
            double k = Convert.ToDouble(textBox_k.Text);
            double u0 = Convert.ToDouble(textBox_u0.Text);
            double alpha = Convert.ToDouble(textBox_alpha.Text);

            List<Task> horLayers = new List<Task>();
            foreach (var x in listBox_t.Items)
                if (Convert.ToDouble(x) <= T && Convert.ToDouble(x) >= 0)
                    horLayers.Add(new Task(Convert.ToDouble(x), T, L, K + 1, I + 1));
            List<Task> vertLayers = new List<Task>();
            foreach (var x in listBox_x.Items)
                if (Convert.ToDouble(x) <= L && Convert.ToDouble(x) >= 0)
                    vertLayers.Add(new Task(Convert.ToDouble(x), L, T, I + 1, K + 1));

            Decider solv = new Decider();
            solv.Init(c, k, alpha, u0, L, T, I, K);
            solv.SetCollectors(horLayers, vertLayers);
            FormLoad form = new FormLoad(solv);
            form.Show();
        }

        bool checkInputs()
        {
            try
            {
                if (Convert.ToDouble(textBox_c.Text) <= 0) return false;
                if (Convert.ToDouble(textBox_k.Text) <= 0) return false;
                if (Convert.ToDouble(textBox_L.Text) <= 0) return false;
                if (Convert.ToDouble(textBox_T.Text) <= 0) return false;
                Convert.ToDouble(textBox_alpha.Text);
                Convert.ToDouble(textBox_u0.Text);

                if (Convert.ToInt32(textBox_size_I.Text) < 1) return false;
                if (Convert.ToInt32(textBox_size_K.Text) < 1) return false;
            }
            catch
            {
                return false;
            }

            if (listBox_t.Items.Count == 0 && listBox_x.Items.Count == 0) return false;

            return true;
        }

        private void textBox_size_I_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int I = Convert.ToInt32(textBox_size_I.Text);
                double R = Convert.ToDouble(textBox_L.Text);
                if (I > 0 && R > 0)
                    label_hr.Text = "hx = " + R / I;
                else
                    label_hr.Text = "hx = NaN";
            }
            catch
            {
                label_hr.Text = "hx = NaN";
            }
        }

        private void textBox_size_K_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int K = Convert.ToInt32(textBox_size_K.Text);
                double T = Convert.ToDouble(textBox_T.Text);
                if (K > 0 && T > 0)
                    label_ht.Text = "ht = " + T / K;
                else
                    label_ht.Text = "ht = NaN";
            }
            catch
            {
                label_ht.Text = "ht = NaN";
            }
        }

        private void textBox_T_TextChanged(object sender, EventArgs e)
        {
            textBox_size_K_TextChanged(null, null);
        }

        private void textBox_L_TextChanged(object sender, EventArgs e)
        {
            textBox_size_I_TextChanged(null, null);
        }

        private void textBox_new_x_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                try
                {
                    e.SuppressKeyPress = true;
                    listBox_x.Items.Add(textBox_new_x.Text);
                    SortListBox(listBox_x);
                }
                catch { }
        }

        private void textBox_new_t_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                try
                {
                    e.SuppressKeyPress = true;
                    listBox_t.Items.Add(textBox_new_t.Text);
                    SortListBox(listBox_t);
                }
                catch { }
        }

        private void SortListBox(ListBox list)
        {
            List<double> Sorting = new List<double>();
            foreach (var o in list.Items)
                if (!Sorting.Contains(Convert.ToDouble(o)))
                    Sorting.Add(Convert.ToDouble(o));
            Sorting.Sort();
            list.Items.Clear();
            foreach (var o in Sorting)
                list.Items.Add(o);
        }

        private void listBox_x_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true;
                listBox_x.Items.Remove(listBox_x.SelectedItem);
            }
        }

        private void listBox_t_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true;
                listBox_t.Items.Remove(listBox_t.SelectedItem);
            }
        }
    }
}
