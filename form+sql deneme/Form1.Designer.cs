namespace form_sql_deneme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView_ = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.btn_listele_user = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ilcelistele = new System.Windows.Forms.Button();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.but_user_cek = new System.Windows.Forms.Button();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.btn_sehirsorgula = new System.Windows.Forms.Button();
            this.city_txt = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.telnr2_txt = new System.Windows.Forms.TextBox();
            this.telnr1_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.username_submit_txt = new System.Windows.Forms.TextBox();
            this.namesurname_txt = new System.Windows.Forms.TextBox();
            this.radio_kdn = new System.Windows.Forms.RadioButton();
            this.radio_erkek = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.groupBox_Add = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_birth = new System.Windows.Forms.DateTimePicker();
            this.groupBox_dlt = new System.Windows.Forms.GroupBox();
            this.groupbox_dltonay = new System.Windows.Forms.GroupBox();
            this.btn_del_iptal = new System.Windows.Forms.Button();
            this.btn_dlt_onay = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_dly_yenile = new System.Windows.Forms.Button();
            this.btn_dlt_user = new System.Windows.Forms.Button();
            this.listView_delete = new System.Windows.Forms.ListView();
            this.groupBox_update = new System.Windows.Forms.GroupBox();
            this.btn_update_user = new System.Windows.Forms.Button();
            this.btn_update_yenile = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.update_pw_txt = new System.Windows.Forms.TextBox();
            this.Update_email_txt = new System.Windows.Forms.TextBox();
            this.update_usrname_txt = new System.Windows.Forms.TextBox();
            this.listView_update = new System.Windows.Forms.ListView();
            this.lbl_update_durum = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupbox2.SuspendLayout();
            this.groupBox_Add.SuspendLayout();
            this.groupBox_dlt.SuspendLayout();
            this.groupbox_dltonay.SuspendLayout();
            this.groupBox_update.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_
            // 
            this.listView_.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_.HideSelection = false;
            this.listView_.Location = new System.Drawing.Point(12, 54);
            this.listView_.Name = "listView_";
            this.listView_.Size = new System.Drawing.Size(653, 312);
            this.listView_.TabIndex = 1;
            this.listView_.UseCompatibleStateImageBehavior = false;
            this.listView_.View = System.Windows.Forms.View.Details;
            this.listView_.SelectedIndexChanged += new System.EventHandler(this.listView__SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name Surname";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "UserName";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Password";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "EMAIL";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ADRES SAYISI";
            this.columnHeader6.Width = 90;
            // 
            // btn_listele_user
            // 
            this.btn_listele_user.Location = new System.Drawing.Point(11, 10);
            this.btn_listele_user.Name = "btn_listele_user";
            this.btn_listele_user.Size = new System.Drawing.Size(226, 40);
            this.btn_listele_user.TabIndex = 2;
            this.btn_listele_user.Text = "Kullanıcıları Listele";
            this.btn_listele_user.UseVisualStyleBackColor = true;
            this.btn_listele_user.Click += new System.EventHandler(this.btn_listele_user_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Şehirleri Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ilcelistele
            // 
            this.btn_ilcelistele.Location = new System.Drawing.Point(443, 10);
            this.btn_ilcelistele.Name = "btn_ilcelistele";
            this.btn_ilcelistele.Size = new System.Drawing.Size(221, 40);
            this.btn_ilcelistele.TabIndex = 3;
            this.btn_ilcelistele.Text = "İlçeleri listele";
            this.btn_ilcelistele.UseVisualStyleBackColor = true;
            this.btn_ilcelistele.Click += new System.EventHandler(this.btn_ilcelistele_Click);
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(6, 22);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(188, 23);
            this.username_txt.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.but_user_cek);
            this.groupBox1.Controls.Add(this.username_txt);
            this.groupBox1.Location = new System.Drawing.Point(11, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı sorgulama";
            // 
            // but_user_cek
            // 
            this.but_user_cek.Location = new System.Drawing.Point(6, 51);
            this.but_user_cek.Name = "but_user_cek";
            this.but_user_cek.Size = new System.Drawing.Size(188, 43);
            this.but_user_cek.TabIndex = 5;
            this.but_user_cek.Text = "Goruntule";
            this.but_user_cek.UseVisualStyleBackColor = true;
            this.but_user_cek.Click += new System.EventHandler(this.but_user_cek_Click);
            // 
            // groupbox2
            // 
            this.groupbox2.Controls.Add(this.btn_sehirsorgula);
            this.groupbox2.Controls.Add(this.city_txt);
            this.groupbox2.Location = new System.Drawing.Point(237, 374);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(200, 100);
            this.groupbox2.TabIndex = 5;
            this.groupbox2.TabStop = false;
            this.groupbox2.Text = "şehir sorgulama";
            this.groupbox2.Enter += new System.EventHandler(this.btn_city_cek_Enter);
            // 
            // btn_sehirsorgula
            // 
            this.btn_sehirsorgula.Location = new System.Drawing.Point(6, 51);
            this.btn_sehirsorgula.Name = "btn_sehirsorgula";
            this.btn_sehirsorgula.Size = new System.Drawing.Size(188, 43);
            this.btn_sehirsorgula.TabIndex = 7;
            this.btn_sehirsorgula.Text = "GORUNTULE";
            this.btn_sehirsorgula.UseVisualStyleBackColor = true;
            this.btn_sehirsorgula.Click += new System.EventHandler(this.btn_sehirsorgula_Click);
            // 
            // city_txt
            // 
            this.city_txt.Location = new System.Drawing.Point(6, 22);
            this.city_txt.Name = "city_txt";
            this.city_txt.Size = new System.Drawing.Size(188, 23);
            this.city_txt.TabIndex = 4;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(463, 374);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(201, 31);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "ADD     ----->";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(464, 411);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(201, 31);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "UPDATE ----->";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(464, 448);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(201, 31);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "DELETE ----->";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // telnr2_txt
            // 
            this.telnr2_txt.Location = new System.Drawing.Point(153, 204);
            this.telnr2_txt.Name = "telnr2_txt";
            this.telnr2_txt.Size = new System.Drawing.Size(169, 23);
            this.telnr2_txt.TabIndex = 0;
            // 
            // telnr1_txt
            // 
            this.telnr1_txt.Location = new System.Drawing.Point(153, 175);
            this.telnr1_txt.Name = "telnr1_txt";
            this.telnr1_txt.Size = new System.Drawing.Size(169, 23);
            this.telnr1_txt.TabIndex = 1;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(153, 117);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(169, 23);
            this.email_txt.TabIndex = 2;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(153, 88);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(169, 23);
            this.password_txt.TabIndex = 4;
            // 
            // username_submit_txt
            // 
            this.username_submit_txt.Location = new System.Drawing.Point(153, 59);
            this.username_submit_txt.Name = "username_submit_txt";
            this.username_submit_txt.Size = new System.Drawing.Size(169, 23);
            this.username_submit_txt.TabIndex = 5;
            // 
            // namesurname_txt
            // 
            this.namesurname_txt.Location = new System.Drawing.Point(153, 30);
            this.namesurname_txt.Name = "namesurname_txt";
            this.namesurname_txt.Size = new System.Drawing.Size(169, 23);
            this.namesurname_txt.TabIndex = 6;
            this.namesurname_txt.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // radio_kdn
            // 
            this.radio_kdn.AutoSize = true;
            this.radio_kdn.Location = new System.Drawing.Point(238, 262);
            this.radio_kdn.Name = "radio_kdn";
            this.radio_kdn.Size = new System.Drawing.Size(55, 19);
            this.radio_kdn.TabIndex = 7;
            this.radio_kdn.TabStop = true;
            this.radio_kdn.Text = "Kadın";
            this.radio_kdn.UseVisualStyleBackColor = true;
            // 
            // radio_erkek
            // 
            this.radio_erkek.AutoSize = true;
            this.radio_erkek.Location = new System.Drawing.Point(238, 242);
            this.radio_erkek.Name = "radio_erkek";
            this.radio_erkek.Size = new System.Drawing.Size(53, 19);
            this.radio_erkek.TabIndex = 7;
            this.radio_erkek.TabStop = true;
            this.radio_erkek.Text = "Erkek";
            this.radio_erkek.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name Surname :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "User Name :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "E-Mail :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Birth Date(yyyy-aa-gg) :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Phone Number -1 :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Phone Number -2 :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Gender :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "label10";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(14, 340);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(308, 34);
            this.btn_submit.TabIndex = 18;
            this.btn_submit.Text = "SUBMIT";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // groupBox_Add
            // 
            this.groupBox_Add.Controls.Add(this.dateTimePicker_birth);
            this.groupBox_Add.Controls.Add(this.btn_submit);
            this.groupBox_Add.Controls.Add(this.label10);
            this.groupBox_Add.Controls.Add(this.label9);
            this.groupBox_Add.Controls.Add(this.label8);
            this.groupBox_Add.Controls.Add(this.label7);
            this.groupBox_Add.Controls.Add(this.label6);
            this.groupBox_Add.Controls.Add(this.label5);
            this.groupBox_Add.Controls.Add(this.label4);
            this.groupBox_Add.Controls.Add(this.label3);
            this.groupBox_Add.Controls.Add(this.label2);
            this.groupBox_Add.Controls.Add(this.label1);
            this.groupBox_Add.Controls.Add(this.email_txt);
            this.groupBox_Add.Controls.Add(this.radio_erkek);
            this.groupBox_Add.Controls.Add(this.radio_kdn);
            this.groupBox_Add.Controls.Add(this.namesurname_txt);
            this.groupBox_Add.Controls.Add(this.username_submit_txt);
            this.groupBox_Add.Controls.Add(this.password_txt);
            this.groupBox_Add.Controls.Add(this.telnr1_txt);
            this.groupBox_Add.Controls.Add(this.telnr2_txt);
            this.groupBox_Add.Location = new System.Drawing.Point(671, 13);
            this.groupBox_Add.Name = "groupBox_Add";
            this.groupBox_Add.Size = new System.Drawing.Size(328, 466);
            this.groupBox_Add.TabIndex = 9;
            this.groupBox_Add.TabStop = false;
            this.groupBox_Add.Visible = false;
            // 
            // dateTimePicker_birth
            // 
            this.dateTimePicker_birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_birth.Location = new System.Drawing.Point(153, 146);
            this.dateTimePicker_birth.Name = "dateTimePicker_birth";
            this.dateTimePicker_birth.Size = new System.Drawing.Size(169, 23);
            this.dateTimePicker_birth.TabIndex = 10;
            this.dateTimePicker_birth.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // groupBox_dlt
            // 
            this.groupBox_dlt.Controls.Add(this.groupbox_dltonay);
            this.groupBox_dlt.Controls.Add(this.btn_dly_yenile);
            this.groupBox_dlt.Controls.Add(this.btn_dlt_user);
            this.groupBox_dlt.Controls.Add(this.listView_delete);
            this.groupBox_dlt.Location = new System.Drawing.Point(677, 10);
            this.groupBox_dlt.Name = "groupBox_dlt";
            this.groupBox_dlt.Size = new System.Drawing.Size(328, 466);
            this.groupBox_dlt.TabIndex = 9;
            this.groupBox_dlt.TabStop = false;
            this.groupBox_dlt.Visible = false;
            // 
            // groupbox_dltonay
            // 
            this.groupbox_dltonay.Controls.Add(this.btn_del_iptal);
            this.groupbox_dltonay.Controls.Add(this.btn_dlt_onay);
            this.groupbox_dltonay.Controls.Add(this.label11);
            this.groupbox_dltonay.Location = new System.Drawing.Point(6, 352);
            this.groupbox_dltonay.Name = "groupbox_dltonay";
            this.groupbox_dltonay.Size = new System.Drawing.Size(320, 88);
            this.groupbox_dltonay.TabIndex = 13;
            this.groupbox_dltonay.TabStop = false;
            this.groupbox_dltonay.Visible = false;
            // 
            // btn_del_iptal
            // 
            this.btn_del_iptal.Location = new System.Drawing.Point(155, 33);
            this.btn_del_iptal.Name = "btn_del_iptal";
            this.btn_del_iptal.Size = new System.Drawing.Size(130, 42);
            this.btn_del_iptal.TabIndex = 13;
            this.btn_del_iptal.Text = "İptal";
            this.btn_del_iptal.UseVisualStyleBackColor = true;
            this.btn_del_iptal.Click += new System.EventHandler(this.btn_del_iptal_Click);
            // 
            // btn_dlt_onay
            // 
            this.btn_dlt_onay.Location = new System.Drawing.Point(19, 33);
            this.btn_dlt_onay.Name = "btn_dlt_onay";
            this.btn_dlt_onay.Size = new System.Drawing.Size(130, 42);
            this.btn_dlt_onay.TabIndex = 11;
            this.btn_dlt_onay.Text = "Onaylıyorum";
            this.btn_dlt_onay.UseVisualStyleBackColor = true;
            this.btn_dlt_onay.Click += new System.EventHandler(this.btn_dlt_onay_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(278, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Bu kullanıcının kaydı silinecek. Onaylıyor musunuz?";
            // 
            // btn_dly_yenile
            // 
            this.btn_dly_yenile.Location = new System.Drawing.Point(243, 352);
            this.btn_dly_yenile.Name = "btn_dly_yenile";
            this.btn_dly_yenile.Size = new System.Drawing.Size(75, 23);
            this.btn_dly_yenile.TabIndex = 14;
            this.btn_dly_yenile.Text = "yenile";
            this.btn_dly_yenile.UseVisualStyleBackColor = true;
            this.btn_dly_yenile.Click += new System.EventHandler(this.btn_dly_yenile_Click);
            // 
            // btn_dlt_user
            // 
            this.btn_dlt_user.Location = new System.Drawing.Point(14, 384);
            this.btn_dlt_user.Name = "btn_dlt_user";
            this.btn_dlt_user.Size = new System.Drawing.Size(308, 34);
            this.btn_dlt_user.TabIndex = 10;
            this.btn_dlt_user.Text = "DELETE";
            this.btn_dlt_user.UseVisualStyleBackColor = true;
            this.btn_dlt_user.Click += new System.EventHandler(this.btn_dlt_user_Click);
            // 
            // listView_delete
            // 
            this.listView_delete.HideSelection = false;
            this.listView_delete.Location = new System.Drawing.Point(6, 17);
            this.listView_delete.MultiSelect = false;
            this.listView_delete.Name = "listView_delete";
            this.listView_delete.Size = new System.Drawing.Size(312, 330);
            this.listView_delete.TabIndex = 1;
            this.listView_delete.UseCompatibleStateImageBehavior = false;
            this.listView_delete.View = System.Windows.Forms.View.Details;
            this.listView_delete.SelectedIndexChanged += new System.EventHandler(this.listView__SelectedIndexChanged);
            // 
            // groupBox_update
            // 
            this.groupBox_update.Controls.Add(this.lbl_update_durum);
            this.groupBox_update.Controls.Add(this.btn_update_user);
            this.groupBox_update.Controls.Add(this.btn_update_yenile);
            this.groupBox_update.Controls.Add(this.label14);
            this.groupBox_update.Controls.Add(this.label13);
            this.groupBox_update.Controls.Add(this.label15);
            this.groupBox_update.Controls.Add(this.update_pw_txt);
            this.groupBox_update.Controls.Add(this.Update_email_txt);
            this.groupBox_update.Controls.Add(this.update_usrname_txt);
            this.groupBox_update.Controls.Add(this.listView_update);
            this.groupBox_update.Location = new System.Drawing.Point(669, 13);
            this.groupBox_update.Name = "groupBox_update";
            this.groupBox_update.Size = new System.Drawing.Size(328, 475);
            this.groupBox_update.TabIndex = 9;
            this.groupBox_update.TabStop = false;
            this.groupBox_update.Visible = false;
            // 
            // btn_update_user
            // 
            this.btn_update_user.Location = new System.Drawing.Point(21, 414);
            this.btn_update_user.Name = "btn_update_user";
            this.btn_update_user.Size = new System.Drawing.Size(289, 41);
            this.btn_update_user.TabIndex = 22;
            this.btn_update_user.Text = "UPDATE";
            this.btn_update_user.UseVisualStyleBackColor = true;
            this.btn_update_user.Click += new System.EventHandler(this.btn_update_user_Click);
            // 
            // btn_update_yenile
            // 
            this.btn_update_yenile.Location = new System.Drawing.Point(227, 382);
            this.btn_update_yenile.Name = "btn_update_yenile";
            this.btn_update_yenile.Size = new System.Drawing.Size(75, 23);
            this.btn_update_yenile.TabIndex = 21;
            this.btn_update_yenile.Text = "Yenile";
            this.btn_update_yenile.UseVisualStyleBackColor = true;
            this.btn_update_yenile.Click += new System.EventHandler(this.btn_update_yenile_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 245);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 15);
            this.label14.TabIndex = 20;
            this.label14.Text = "Username :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 274);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 15);
            this.label13.TabIndex = 19;
            this.label13.Text = "Password";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 303);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 15);
            this.label15.TabIndex = 18;
            this.label15.Text = "E-Mail :";
            this.label15.Click += new System.EventHandler(this.label12_Click);
            // 
            // update_pw_txt
            // 
            this.update_pw_txt.Location = new System.Drawing.Point(201, 271);
            this.update_pw_txt.Name = "update_pw_txt";
            this.update_pw_txt.Size = new System.Drawing.Size(117, 23);
            this.update_pw_txt.TabIndex = 17;
            // 
            // Update_email_txt
            // 
            this.Update_email_txt.Location = new System.Drawing.Point(201, 300);
            this.Update_email_txt.Name = "Update_email_txt";
            this.Update_email_txt.Size = new System.Drawing.Size(117, 23);
            this.Update_email_txt.TabIndex = 16;
            // 
            // update_usrname_txt
            // 
            this.update_usrname_txt.Location = new System.Drawing.Point(201, 242);
            this.update_usrname_txt.Name = "update_usrname_txt";
            this.update_usrname_txt.Size = new System.Drawing.Size(117, 23);
            this.update_usrname_txt.TabIndex = 15;
            // 
            // listView_update
            // 
            this.listView_update.HideSelection = false;
            this.listView_update.Location = new System.Drawing.Point(6, 17);
            this.listView_update.MultiSelect = false;
            this.listView_update.Name = "listView_update";
            this.listView_update.Size = new System.Drawing.Size(312, 206);
            this.listView_update.TabIndex = 1;
            this.listView_update.UseCompatibleStateImageBehavior = false;
            this.listView_update.View = System.Windows.Forms.View.Details;
            this.listView_update.SelectedIndexChanged += new System.EventHandler(this.listView__SelectedIndexChanged);
            // 
            // lbl_update_durum
            // 
            this.lbl_update_durum.AutoSize = true;
            this.lbl_update_durum.Location = new System.Drawing.Point(43, 386);
            this.lbl_update_durum.Name = "lbl_update_durum";
            this.lbl_update_durum.Size = new System.Drawing.Size(0, 15);
            this.lbl_update_durum.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 775);
            this.Controls.Add(this.groupBox_update);
            this.Controls.Add(this.groupBox_dlt);
            this.Controls.Add(this.groupBox_Add);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_ilcelistele);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_listele_user);
            this.Controls.Add(this.listView_);
            this.Name = "Form1";
            this.Text = "Bağlantı Aç";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupbox2.ResumeLayout(false);
            this.groupbox2.PerformLayout();
            this.groupBox_Add.ResumeLayout(false);
            this.groupBox_Add.PerformLayout();
            this.groupBox_dlt.ResumeLayout(false);
            this.groupbox_dltonay.ResumeLayout(false);
            this.groupbox_dltonay.PerformLayout();
            this.groupBox_update.ResumeLayout(false);
            this.groupBox_update.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView_;
        private System.Windows.Forms.Button btn_listele_user;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btn_ilcelistele;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_user_cek;
        private System.Windows.Forms.GroupBox groupbox2;
        private System.Windows.Forms.TextBox city_txt;
        private System.Windows.Forms.Button btn_sehirsorgula;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox telnr2_txt;
        private System.Windows.Forms.TextBox telnr1_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox username_submit_txt;
        private System.Windows.Forms.TextBox namesurname_txt;
        private System.Windows.Forms.RadioButton radio_kdn;
        private System.Windows.Forms.RadioButton radio_erkek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.GroupBox groupBox_Add;
        private System.Windows.Forms.GroupBox groupBox_dlt;
        private System.Windows.Forms.Button btn_dlt_user;
        private System.Windows.Forms.GroupBox groupbox_dltonay;
        private System.Windows.Forms.Button btn_dlt_onay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView listView_delete;
        private System.Windows.Forms.Button btn_del_iptal;
        private System.Windows.Forms.Button btn_dly_yenile;
        private System.Windows.Forms.DateTimePicker dateTimePicker_birth;
        private System.Windows.Forms.GroupBox groupBox_update;
        private System.Windows.Forms.TextBox update_pw_txt;
        private System.Windows.Forms.TextBox Update_email_txt;
        private System.Windows.Forms.TextBox update_usrname_txt;
        private System.Windows.Forms.ListView listView_update;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_update_yenile;
        private System.Windows.Forms.Button btn_update_user;
        private System.Windows.Forms.Label lbl_update_durum;
    }
}

