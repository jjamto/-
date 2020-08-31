using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 가계부
{
    public partial class fLogin : Form
    {
        private void fLogin_Load(object sender, EventArgs e)
        {
            tbName.Text = "개발자";
            tbPassword.Text = "1234";
        }
        public fLogin()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            //확인 개발자 1234

            if (tbName.Text == "개발자" && tbPassword.Text == "1234")
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("암호가 일치하지 않습니다.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPassword.Focus();
                tbPassword.SelectAll();
            }
            

        }

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            //엔터를 쳤을때 패스워드 입력하는곳으로 이동
            if (e.KeyCode == Keys.Enter)
            {
                //입력값 체크
                if (tbName.Text != "")
                {
                    tbPassword.Focus();
                }
        
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //입력값 체크
                if (tbPassword.Text != "")
                {
                    btOK.Focus();
                }

            }
        }

    }
}
