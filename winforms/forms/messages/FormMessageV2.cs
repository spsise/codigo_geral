using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI.Forms.Messages
{
    public partial class FormMessageV2 : Form
    {
        #region [Variable]

        IMessageAction _messageAction;

        #endregion

        #region [Construtors]

        public FormMessageV2()
        {
            InitializeComponent();
        }

        public FormMessageV2(IMessageAction messageAction)
        {
            InitializeComponent();

            _messageAction = messageAction;

            SetMessageAction();
        }


        #endregion

        #region [Events]

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region [Methods]

        private void SetMessageAction()
        {
            SetMessage();
            SetCustomType();
        }

        private void SetMessage()
        {
            LblMessage.Text = _messageAction.Message;
        }

        private void SetCustomType()
        {
            BackColor = _messageAction.GetColor();
            BtnOk.ForeColor = _messageAction.GetColor();
            BtnClose.Image = _messageAction.GetBtnCloseImage();
            PictureBoxCenter.Image = _messageAction.GetCenterImage();
        }

        #endregion

    }

    public interface IMessageAction
    {
        string Message { get; set; }

        Color GetColor();

        Bitmap GetBtnCloseImage();

        Bitmap GetCenterImage();

    }

    public class MessageActionSuccess : IMessageAction
    {
        #region [Variable]

        public string Message { get; set; }

        #endregion

        #region [Construtors]
        
        public MessageActionSuccess()
        {

        }

        public MessageActionSuccess(string message)
        {
            Message = message;
        }

        #endregion

        #region [Methods]

        public Color GetColor()
        {
            return Color.ForestGreen;
        }

        public Bitmap GetBtnCloseImage()
        {
            return new Bitmap(UI.Properties.Resources.btn_close_green);
        }

        public Bitmap GetCenterImage()
        {
            return new Bitmap(UI.Properties.Resources.success_tick_icon);
        }

        #endregion

    }

    public class MessageActionError : IMessageAction
    {
        #region [Variable]

        public string Message { get; set; }

        #endregion

        #region [Construtors]

        public MessageActionError()
        {

        }

        public MessageActionError(string message)
        {
            Message = message;
        }

        #endregion

        #region [Methods]

        public Color GetColor()
        {
            return Color.Brown;
        }

        public Bitmap GetBtnCloseImage()
        {
            return new Bitmap(UI.Properties.Resources.sign_error_icon);
        }

        public Bitmap GetCenterImage()
        {
            return new Bitmap(UI.Properties.Resources.sign_error_icon);
        }

        #endregion

    }

    public class MessageActionAlert : IMessageAction
    {
        #region [Variable]

        public string Message { get; set; }

        #endregion

        #region [Construtors]

        public MessageActionAlert()
        {

        }

        public MessageActionAlert(string message)
        {
            Message = message;
        }

        #endregion

        #region [Methods]

        public Color GetColor()
        {
            return Color.Gold;
        }

        public Bitmap GetBtnCloseImage()
        {
            return new Bitmap(UI.Properties.Resources.btn_close);
        }

        public Bitmap GetCenterImage()
        {
            return new Bitmap(UI.Properties.Resources.exclamation);
        }

        #endregion

    }

}
