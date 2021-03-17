using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace form_sql_deneme
{



    public partial class Form1 : Form 
    {


        public Form1()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(685, 522);
            groupBox_Add.Visible = false;

        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ETRADE;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            listView_.Items.Clear();
            listView_.Columns.Clear();
            listView_.Columns.Add("CITY", 200);
            listView_.Columns.Add("District Count", 100);
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select CITY.CITY,COUNT(DISTRICT.DISTRICT) as ilçesayisi from CITY join DISTRICT on CITY.ID=DISTRICT.TOWNID group by CITY.CITY order by CITY.CITY";



            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();

            adap.Fill(tablo);

            for (int i = 0; i < tablo.Rows.Count; i++)
            {


                listView_.Items.Add(tablo.Rows[i]["CITY"].ToString());
                listView_.Items[i].SubItems.Add(tablo.Rows[i]["ilçesayisi"].ToString());

            }
            baglanti.Close();
        }

        private void btn_listele_user_Click(object sender, EventArgs e)
        {

            listView_.Items.Clear();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select USER_.ID,USER_.NAMESURNAME,USER_.USERNAME_,USER_.PASSWORD_,USER_.EMAIL,COUNT(ADDRES.ADDRESSTEXT) as adressayisi from USER_ left join Addres on ADDRES.USERID = USER_.ID group by USER_.ID,USER_.NAMESURNAME,USER_.USERNAME_,USER_.PASSWORD_,USER_.EMAIL   order by  USER_.ID";



            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();

            adap.Fill(tablo);

            for (int i = 0; i < tablo.Rows.Count; i++)
            {


                listView_.Items.Add(tablo.Rows[i]["ID"].ToString());
                listView_.Items[i].SubItems.Add(tablo.Rows[i]["NAMESURNAME"].ToString());
                listView_.Items[i].SubItems.Add(tablo.Rows[i]["USERNAME_"].ToString());
                listView_.Items[i].SubItems.Add(tablo.Rows[i]["PASSWORD_"].ToString());
                listView_.Items[i].SubItems.Add(tablo.Rows[i]["EMAIL"].ToString());
                listView_.Items[i].SubItems.Add(tablo.Rows[i]["adressayisi"].ToString());
            }
            baglanti.Close();
        }

        private void listView__SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                update_usrname_txt.Text = listView_update.SelectedItems[0].SubItems[2].Text;
                update_pw_txt.Text = listView_update.SelectedItems[0].SubItems[3].Text;
                Update_email_txt.Text = listView_update.SelectedItems[0].SubItems[4].Text;
            }
            catch (Exception)
            {

                
            }
            user.username = update_usrname_txt.Text ;
            user.password = update_pw_txt.Text ;
            user.email = Update_email_txt.Text;
                
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ilcelistele_Click(object sender, EventArgs e)
        {
            listView_.Items.Clear();
            listView_.Columns.Clear();
            listView_.Columns.Add("Dıstrict", 120);
            listView_.Columns.Add("Town", 120);
            listView_.Columns.Add("City", 120);

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select DISTRICT.DISTRICT,TOWN.TOWN,CITY.CITY from DISTRICT join CITY on CITY.ID=DISTRICT.TOWNID  join TOWN on TOWN.CITYID=CITY.ID order by CITY,TOWN";



            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();

            adap.Fill(tablo);

            for (int i = 0; i < tablo.Rows.Count; i++)
            {


                listView_.Items.Add(tablo.Rows[i]["DISTRICT"].ToString());
                listView_.Items[i].SubItems.Add(tablo.Rows[i]["TOWN"].ToString());
                listView_.Items[i].SubItems.Add(tablo.Rows[i]["CITY"].ToString());

            }
            baglanti.Close();
        }

        private void but_user_cek_Click(object sender, EventArgs e)
        {

            listView_.Items.Clear();
            string usr = username_txt.Text;


            listView_.Columns.Clear();
            listView_.Columns.Add("Id", 40);
            listView_.Columns.Add("NAMESURNAME", 120);
            listView_.Columns.Add("USERNAME", 120);
            listView_.Columns.Add("PASSWORD", 120);
            listView_.Columns.Add("EMAIL", 120);
            listView_.Columns.Add("COUNT ADDRES", 120);

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select USER_.ID,USER_.NAMESURNAME,USER_.USERNAME_,USER_.PASSWORD_,USER_.EMAIL,COUNT(ADDRES.ADDRESSTEXT) as adressayisi from USER_ left join Addres on ADDRES.USERID = USER_.ID where USER_.NAMESURNAME LIKE '%" + usr + "%' group by USER_.ID,USER_.NAMESURNAME,USER_.USERNAME_,USER_.PASSWORD_,USER_.EMAIL   ";



            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();

            adap.Fill(tablo);

            for (int i = 0; i < tablo.Rows.Count; i++)
            {


                listView_.Items.Add(tablo.Rows[i]["ID"].ToString());
                listView_.Items[i].SubItems.Add(tablo.Rows[i]["NAMESURNAME"].ToString());
                listView_.Items[i].SubItems.Add(tablo.Rows[i]["USERNAME_"].ToString());
                listView_.Items[i].SubItems.Add(tablo.Rows[i]["PASSWORD_"].ToString());
                listView_.Items[i].SubItems.Add(tablo.Rows[i]["EMAIL"].ToString());
                listView_.Items[i].SubItems.Add(tablo.Rows[i]["adressayisi"].ToString());
            }
            username_txt.Text = "";
        }

        private void btn_city_cek_Enter(object sender, EventArgs e)
        {
           
        }

        private void btn_sehirsorgula_Click(object sender, EventArgs e)
        {
            listView_.Items.Clear();
            listView_.Columns.Clear();
            string cty = city_txt.Text;


            listView_.Columns.Clear();
            listView_.Columns.Add("CITY", 70);
            listView_.Columns.Add("TOWN", 70);


            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select CITY.CITY,TOWN.TOWN from CITY join TOWN on TOWN.CITYID=CITY.ID  where CITY.CITY LIKE '%" + cty + "%' order by CITY  ";



            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();

            adap.Fill(tablo);

            for (int i = 0; i < tablo.Rows.Count; i++)
            {


                listView_.Items.Add(tablo.Rows[i]["CITY"].ToString());
                listView_.Items[i].SubItems.Add(tablo.Rows[i]["TOWN"].ToString());

            }
            city_txt.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (btn_update.Text=="Hide"||btn_delete.Text=="Hide")
            {
                MessageBox.Show("Önce açık sekmeleri kapatın");
            }
            else
            {
                if (btn_add.Text == "Hide")
                {
                    this.Size = new System.Drawing.Size(685, 522);
                    btn_add.Text = "ADD     ----->";
                    groupBox_Add.Visible = false;
                }
                else
                {
                    this.Size = new System.Drawing.Size(1027, 522); 
                    btn_add.Text = "Hide";
                    groupBox_Add.Visible = true;
                }
            }
            
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            

            if (btn_add.Text=="Hide"||btn_delete.Text=="Hide")
            {
                MessageBox.Show("Önce açık sekmeleri kapatınız");
            }
            else
            {
                if (btn_update.Text == "Hide")
                {
                    this.Size = new System.Drawing.Size(685, 522);
                    btn_update.Text = "UPDATE ----->";
                    groupBox_update.Visible = false;
                }
                else
                {
                    this.Size = new System.Drawing.Size(1027, 522);
                    btn_update.Text = "Hide";

                    groupBox_update.Visible = true;
                    listView_update.Items.Clear();
                    listView_update.Columns.Clear();
                    listView_update.Columns.Add("ID", 60);
                    listView_update.Columns.Add("NAME SURNAME", 130);
                    listView_update.Columns.Add("USERNAME", 130);
                    listView_update.Columns.Add("PASSWORD", 130);
                    listView_update.Columns.Add("E-MAIL", 130);
                    SqlCommand komut = new SqlCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = "select USER_.ID,USER_.NAMESURNAME,USER_.USERNAME_,USER_.PASSWORD_,USER_.EMAIL from USER_ order by USER_.ID";

                    SqlDataAdapter adap = new SqlDataAdapter(komut);
                    DataTable tablo = new DataTable();

                    adap.Fill(tablo);

                    for (int i = 0; i < tablo.Rows.Count; i++)
                    {


                        listView_update.Items.Add(tablo.Rows[i]["ID"].ToString());
                        listView_update.Items[i].SubItems.Add(tablo.Rows[i]["NAMESURNAME"].ToString());
                        listView_update.Items[i].SubItems.Add(tablo.Rows[i]["USERNAME_"].ToString());
                        listView_update.Items[i].SubItems.Add(tablo.Rows[i]["PASSWORD_"].ToString());
                        listView_update.Items[i].SubItems.Add(tablo.Rows[i]["EMAIL"].ToString());
                    }
                    baglanti.Close();

                }
            }
           
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            

            if (btn_update.Text =="Hide"||btn_add.Text=="Hide")
            {
                MessageBox.Show("Önce Açık Sekmeleri Kapatın");  
            }
            else
            {
                if (btn_delete.Text == "Hide")
                {
                    this.Size = new System.Drawing.Size(685, 522);
                    btn_delete.Text = "DELETE ----->";
                    groupBox_dlt.Visible = false;
                }
                else
                {
                    this.Size = new System.Drawing.Size(1027, 522);
                    btn_delete.Text = "Hide";
                    groupBox_dlt.Visible = true;
                    listView_delete.Items.Clear();
                    listView_delete.Columns.Clear();
                    listView_delete.Columns.Add("ID", 60);
                    listView_delete.Columns.Add("NAME SURNAME", 130);
                    listView_delete.Columns.Add("USERNAME", 130);
                    SqlCommand komut = new SqlCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = "select USER_.ID,USER_.NAMESURNAME,USER_.USERNAME_ from USER_ order by USER_.ID";

                    SqlDataAdapter adap = new SqlDataAdapter(komut);
                    DataTable tablo = new DataTable();

                    adap.Fill(tablo);

                    for (int i = 0; i < tablo.Rows.Count; i++)
                    {


                        listView_delete.Items.Add(tablo.Rows[i]["ID"].ToString());
                        listView_delete.Items[i].SubItems.Add(tablo.Rows[i]["NAMESURNAME"].ToString());
                        listView_delete.Items[i].SubItems.Add(tablo.Rows[i]["USERNAME_"].ToString());
                    }
                    baglanti.Close();
                }
            }

            
        }
        USER_ user = new USER_();
        private void btn_submit_Click(object sender, EventArgs e)
        {


            if ( namesurname_txt.Text!=string.Empty&&username_submit_txt.Text!=string.Empty && password_txt.Text!=string.Empty && email_txt.Text!=string.Empty && (telnr1_txt.Text!=string.Empty || telnr2_txt.Text!=string.Empty) || (radio_erkek.Checked != false && radio_kdn.Checked != false))
            {
               
                user.namesurname = namesurname_txt.Text;
                user.username = username_submit_txt.Text;
                user.password = password_txt.Text;
                user.birthdate = dateTimePicker_birth.Value;
                user.email = email_txt.Text;
                user.telnr1 = telnr1_txt.Text;
                user.telnr2 = telnr2_txt.Text;
                user.createddate = DateTime.Today;

                if (radio_erkek.Checked == true)
                {
                    user.gender = "E";
                }
                else if (radio_kdn.Checked == true)
                {
                    user.gender = "K";
                }
                else
                {
                    label1.Text = "lütfen cinsiyet seçiniz";
                }

                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO USER_(USERNAME_,PASSWORD_,NAMESURNAME,EMAIL,GENDER,CREATEDDATE,BIRTHDATE,TELNR1,TELNR2) VALUES(@USERNAME_, @PASSWORD_, @NAMESURNAME, @EMAIL, @GENDER, @CREATEDDATE, @BIRTHDATE, @TELNR1, @TELNR2)", baglanti);
                komut.Parameters.AddWithValue("@USERNAME_", user.username);
                komut.Parameters.AddWithValue("@PASSWORD_", user.password);
                komut.Parameters.AddWithValue("@NAMESURNAME", user.namesurname);
                komut.Parameters.AddWithValue("@EMAIL", user.email);
                komut.Parameters.AddWithValue("@GENDER", user.gender);
                komut.Parameters.AddWithValue("@CREATEDDATE", user.createddate);
                komut.Parameters.AddWithValue("@BIRTHDATE", user.birthdate);
                komut.Parameters.AddWithValue("@TELNR1", user.telnr1);
                komut.Parameters.AddWithValue("@TELNR2", user.telnr2);
                komut.ExecuteNonQuery();
                baglanti.Close();
                label1.Text = "Kayıt başarıyla eklendi";
                //Kodu bitirmeden yarıda bıraktım bunlar cozülebilecek sorunlar
            }
           
            else
            {
                label1.Text = "Eksik bilgi girildi";
            }
            
            
                

               
            
            
            
         

            namesurname_txt.Text = "";
            username_submit_txt.Text = "";
            password_txt.Text = "";
            dateTimePicker_birth.Value = new DateTime(1999,01,01);
            email_txt.Text = "";
            telnr1_txt.Text = "";
            telnr2_txt.Text = "";
            radio_erkek.Checked = false;
            radio_kdn.Checked = false;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string namesurname = namesurname_txt.Text;
             
        }

        private void btn_dlt_user_Click(object sender, EventArgs e)
        {
            groupbox_dltonay.Visible = true;
            

        }

        private void btn_dlt_onay_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("DELETE FROM USER_ WHERE USER_.ID=@ID", baglanti);
                komut.Parameters.AddWithValue("@ID", Convert.ToInt32(listView_delete.SelectedItems[0].SubItems[0].Text));
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Veri silindi");
                groupbox_dltonay.Visible = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Malesef hiçbir veriyi seçmediniz");
                groupbox_dltonay.Visible = false;

            }
            

            
        }

        private void btn_del_iptal_Click(object sender, EventArgs e)
        {
            groupbox_dltonay.Visible = false;
        }

        private void btn_dly_yenile_Click(object sender, EventArgs e)
        {
            listView_delete.Items.Clear();
            

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select USER_.ID,USER_.NAMESURNAME,USER_.USERNAME_ from USER_ order by USER_.ID";

            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();

            adap.Fill(tablo);

            for (int i = 0; i < tablo.Rows.Count; i++)
            {


                listView_delete.Items.Add(tablo.Rows[i]["ID"].ToString());
                listView_delete.Items[i].SubItems.Add(tablo.Rows[i]["NAMESURNAME"].ToString());
                listView_delete.Items[i].SubItems.Add(tablo.Rows[i]["USERNAME_"].ToString());
            }
            baglanti.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_yenile_Click(object sender, EventArgs e)
        {

            listView_update.Items.Clear();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select USER_.ID,USER_.NAMESURNAME,USER_.USERNAME_,USER_.PASSWORD_,USER_.EMAIL from USER_ order by USER_.ID";

            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();

            adap.Fill(tablo);

            for (int i = 0; i < tablo.Rows.Count; i++)
            {


                listView_update.Items.Add(tablo.Rows[i]["ID"].ToString());
                listView_update.Items[i].SubItems.Add(tablo.Rows[i]["NAMESURNAME"].ToString());
                listView_update.Items[i].SubItems.Add(tablo.Rows[i]["USERNAME_"].ToString());
                listView_update.Items[i].SubItems.Add(tablo.Rows[i]["PASSWORD_"].ToString());
                listView_update.Items[i].SubItems.Add(tablo.Rows[i]["EMAIL"].ToString());
            }
            baglanti.Close();
            lbl_update_durum.Text = null;
        }

        private void btn_update_user_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("UPDATE USER_ SET USER_.USERNAME_=@USERNAME_ , USER_.PASSWORD_=@PASSWORD_ , USER_.EMAIL=@EMAIL WHERE USER_.USERNAME_=@USERNAME_2", baglanti);
                komut.Connection = baglanti;
                
                komut.Parameters.AddWithValue("@USERNAME_", update_usrname_txt.Text);
                komut.Parameters.AddWithValue("@PASSWORD_", update_pw_txt.Text);
                komut.Parameters.AddWithValue("@EMAIL", Update_email_txt.Text);
                komut.Parameters.AddWithValue("@USERNAME_2", user.username);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("HATA");
            }
            lbl_update_durum.Text = "Güncelleme Başarılı!";
            update_usrname_txt.Text = null;
            update_pw_txt.Text = null;
            Update_email_txt.Text = null;

        }
    }
}
