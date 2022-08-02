using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENTITYFRAMEWORK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Database1Entities connection = new Database1Entities();

        private void Form1_Load(object sender, EventArgs e)
        {
            rbtn_personal.Checked = true;
            radiobtnselect();
        }

        private void radiobtnselect()
        {
            if (rbtn_company.Checked == true)
            {
                dataGridView1.DataSource = connection.COMPANies.ToList();
            }
            if (rbtn_personal.Checked == true)
            {
                dataGridView1.DataSource = connection.PERSONALs.ToList();
            }

        }
        private void radiobtninsert()
        {
            if (rbtn_company.Checked == true)
            {
                connection.COMPANies.Add(new COMPANY()
                {
                    PERSONID = Convert.ToInt32(txt_personid.Text),
                    NAME = txt_companyname.Text
                }); 
                connection.SaveChanges();
                MessageBox.Show("SUCCESFULLY ADDED");
            }
            if (rbtn_personal.Checked == true)
            {
                connection.PERSONALs.Add(new PERSONAL()
                {
                    NAME = txt_name.Text,
                    SURNAME = txt_surname.Text,
                    POSITION = txtposition.Text,
                    AGE = Convert.ToInt16(txt_age.Text),
                    COUNTRY = txt_country.Text, 
                }) ;
                connection.SaveChanges();
                MessageBox.Show("SUCCESFULLY ADDED");
            }

            //Linq To SQL
            //solid principles
            //design patterns
        }
        private void radiobtndelete()
        {
            if (rbtn_company.Checked == true)
            {
                int id = Convert.ToInt32(txt_personid.Text);
                var x = connection.COMPANies.Find(id);
                connection.COMPANies.Remove(x);
                connection.SaveChanges();
                MessageBox.Show("SUCCESFULLY DELETED");
            }
            if (rbtn_personal.Checked == true)
            {
                int id = Convert.ToInt32(txt_id.Text);
                var x = connection.PERSONALs.Find(id);
                connection.PERSONALs.Remove(x);
                connection.SaveChanges();
                MessageBox.Show("SUCCESFULLY DELETED");
            }
        
        }
        private void radiobtnupdate()
        {
            if (rbtn_company.Checked == true)
            {
                int id = Convert.ToInt32(txt_personid.Text);
                var x = connection.COMPANies.Find(id);
                x.PERSONID = Convert.ToInt32(txt_personid.Text);
                x.NAME = txt_companyname.Text;
                connection.SaveChanges();
                MessageBox.Show("SUCCESFULLY UPDATED");
            }
            if (rbtn_personal.Checked == true)
            {
                int id = Convert.ToInt32(txt_id.Text);
                var x = connection.PERSONALs.Find(id);
                x.NAME = txt_name.Text;
                x.SURNAME = txt_surname.Text;
                x.POSITION = txtposition.Text;
                x.AGE = Convert.ToInt16(txt_age.Text);
                x.COUNTRY = txt_country.Text;
                connection.SaveChanges();
                MessageBox.Show("SUCCESFULLY UPDATED");
            }
        }
        private void radiobtnsearch()
        {
            if (rbtn_company.Checked == true)
            {
                dataGridView1.DataSource = connection.COMPANies.Where(x => x.NAME == txt_companyname.Text).ToList();
            }
            if (rbtn_personal.Checked == true)
            {
                dataGridView1.DataSource = connection.PERSONALs.Where(x=>x.NAME==txt_name.Text || x.POSITION==txtposition.Text).ToList();
            }
        }
        private void entityfunctions()
        {
            if (rbtn_orderby.Checked==true)
            {
                List<PERSONAL> list1 = connection.PERSONALs.OrderBy(p=>p.NAME).ToList();
                dataGridView1.DataSource = list1;
            }
            if (rbtn_sum.Checked == true)
            {
                int x = connection.PERSONALs.Count();
                MessageBox.Show(x.ToString());
            }
            if (rbtn_min.Checked==true)
            {
                var min = connection.PERSONALs.Min(p => p.AGE);
                MessageBox.Show(min.ToString());
            }
            if (rbtn_max.Checked == true)
            {
                var max = connection.PERSONALs.Max(p => p.AGE);
                MessageBox.Show(max.ToString());
            }
            if (rbtn_avg.Checked == true)
            {
                var avg = connection.PERSONALs.Average(p => p.AGE);
                MessageBox.Show(avg.ToString());
            }
        }
 
     


        private void btn_select_Click(object sender, EventArgs e)
        {
            radiobtnselect();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            radiobtninsert();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            radiobtndelete();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            radiobtnupdate();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            radiobtnsearch();
        }

        private void btn_join_Click(object sender, EventArgs e)
        {
            var query = from item1 in connection.COMPANies
                        join item2 in connection.PERSONALs
                        on item1.PERSONID equals item2.ID
                        select new
                        {
                            companyname = item1.NAME,
                            personalname = item2.NAME,
                            personalage = item2.AGE
                        };            

            dataGridView1.DataSource = query.ToList();
        }

        private void rbtn_company_CheckedChanged(object sender, EventArgs e)
        {
            radiobtnselect();
        }

        private void rbtn_personal_CheckedChanged(object sender, EventArgs e)
        {
            radiobtnselect();
        }

        private void rbtn_orderby_CheckedChanged(object sender, EventArgs e)
        {
            entityfunctions();
        }

        private void rbtn_max_CheckedChanged(object sender, EventArgs e)
        {
            entityfunctions();
        }

        private void rbtn_min_CheckedChanged(object sender, EventArgs e)
        {
            entityfunctions();
        }

        private void rbtn_avg_CheckedChanged(object sender, EventArgs e)
        {
            entityfunctions();
        }

        private void rbtn_sum_CheckedChanged(object sender, EventArgs e)
        {
            entityfunctions();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Delete)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(index);
                int id = Convert.ToInt32(txt_id.Text);
                var x = connection.PERSONALs.Find(id);
                connection.PERSONALs.Remove(x);
                connection.SaveChanges();
            }
        }
        
  
    }
}
