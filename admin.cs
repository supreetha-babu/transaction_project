using System;
using System.Collections.Generic; using System.ComponentModel; using System.Data;
using System.Drawing; using System.Linq; using System.Text;
using System.Windows.Forms; using System.Data.SqlClient; namespace MultiFaceRec
{
public partial class Login : Form
{
SqlConnection con; public Login()
{
InitializeComponent(); string constr = @"Data
Source=.\SQLEXPRESS;AttachDbFilename=G:\FaceRecProOV\MyDb.mdf;Integrated Security=True;Connect Timeout=30";
con = new SqlConnection(constr);
}

private void button1_Click(object sender, EventArgs e)
{
string usertype = "";
string querry = "select * from Register_User where user_name='" + textBox1.Text + "' AND pwd='" + textBox3.Text + "'";
SqlCommand cmd = new SqlCommand(querry, con); con.Open();
SqlDataReader dr = cmd.ExecuteReader(); var MakeRegistered = new MakeRegistered(); if (dr.Read())
{
usertype = dr["user_type"].ToString(); MakeRegistered.Show();
}
else
{

MessageBox.Show("Invalid Credintials");

}
if (usertype.Equals("Admin"))
{

MakeRegistered mr = new MakeRegistered(); mr.Show();
}
else
{
this.Hide();
 
FrmPrincipal fp = new FrmPrincipal(); fp.Show();

}
con.Close();
}

private void Login_Load(object sender, EventArgs e)
{

}
}
}
