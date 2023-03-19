using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООП_Инд_задание
{
    public partial class FormMen : Form
    {
        public FormMen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // такая же форма как  для клиента, только эти данные будут сохраняться с пометкой, что регистрировался менеджер

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // открывает форму для добавления аренды в список
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // переход на форму с заявками
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // открывает форму со списком клиентов и его аренды
        }
    }
}
