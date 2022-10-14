using System;
using System.Windows.Forms;

namespace UI.Forms.Messages
{
    public partial class FormMessageV1 : Form
    {
        #region [Variable]

        #endregion

        #region [Construtors]
        
        public FormMessageV1()
        {
            InitializeComponent();
        }

        #endregion

        #region [Events]
        
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        #endregion

        #region [Methods]

        #endregion

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
