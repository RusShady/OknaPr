using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oknaDZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DialogResult res;
 
        private void btn1_Click(object sender, EventArgs e)
        {
            res = MessageBox.Show("Это простое окно сообщения","", MessageBoxButtons.OK,MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            res = MessageBox.Show("Затейливое окно сообщения", "Заголовок окна сообщения", MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2 );
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            res = MessageBox.Show("Я сейчас взорвусь как 300 тонн тротила...", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            res = MessageBox.Show("Не могу удалить файл!", "Ошибка", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button3);
        }
    }
}
