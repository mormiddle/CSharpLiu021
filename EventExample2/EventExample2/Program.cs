using System;
using System.Windows.Forms;

namespace EventExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //事件拥有者
            Form form = new Form();
            //事件订阅者
            Controller controller = new Controller(form);
            form.ShowDialog();
        }
    }

    class Controller
    {
        private Form form;

        public Controller(Form form )
        {
            this.form = form;
            //click是事件
            this.form.Click += this.FormClicked;
        }

        //FormClicked是事件处理器
        private void FormClicked(object sender, EventArgs e)
        {
            this.form.Text = DateTime.Now.ToString();
        }
    }
}
