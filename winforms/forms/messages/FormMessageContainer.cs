using System.Windows.Forms;

namespace UI.Forms.Messages
{
    public partial class FormMessageContainer : Form
    {
        public FormMessageContainer()
        {
            InitializeComponent();
        }

        public FormMessageContainer(Form form)
        {
            InitializeComponent();
            MdiParent = form;
        }


        private void FormLoginContainer_Load(object sender, System.EventArgs e)
        {

        }

        private void BtnV1_Click(object sender, System.EventArgs e)
        {
            FormMessageV1 form = new FormMessageV1();
            form.ShowDialog();
        }

        private void BtnV2_Click(object sender, System.EventArgs e)
        {
            FormMessageV2 form = new FormMessageV2();
            form.ShowDialog();
        }

        private void BtnV3_Click(object sender, System.EventArgs e)
        {
            FormMessageV3 form = new FormMessageV3();
            form.ShowDialog();
        }

        private void BtnV4_Click(object sender, System.EventArgs e)
        {
            FormMessageV4 form = new FormMessageV4();
            form.ShowDialog();
        }

        private void BtnV5_Click(object sender, System.EventArgs e)
        {
            FormMessageV5 form = new FormMessageV5();
            form.ShowDialog();
        }
    }
}
