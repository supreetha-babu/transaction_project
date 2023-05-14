using System;
using System.Collections.Generic; using System.ComponentModel; using System.Data;
using System.Drawing; using System.Linq; using System.Text;
using System.Windows.Forms;

namespace MultiFaceRec
{
public partial class frmHomePage : Form
{
public frmHomePage()
{
InitializeComponent();
}

private void Button1_Click(object sender, EventArgs e)
{
var frmRegister = new Register(); frmRegister.Show();
}

private void Button2_Click(object sender, EventArgs e)
{
var frmLogin = new Login(); frmLogin.Show();
}
}
}
