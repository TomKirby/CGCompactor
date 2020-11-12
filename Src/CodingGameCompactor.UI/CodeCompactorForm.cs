using CodingGameCompactor.Service;
using System;
using System.Windows.Forms;

namespace CodingGameCompactor.UI
{
    public partial class CodeCompactorForm : Form
    {
        private readonly CodeCompactor _codeCompactor;

        public CodeCompactorForm(CodeCompactor codeCompactor)
        {
            _codeCompactor = codeCompactor;
            InitializeComponent();
        }

        private void btnRegenerate_Click(object sender, EventArgs e)
        {
            CompactCode();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            CompactCode();
        }

        private void CompactCode()
        {
            tbMainOutput.Text = _codeCompactor.GenerateOutput();
            tbMainOutput.SelectAll();
        }

        private void BtnSelectAll_Click(object sender, EventArgs e)
        {
            tbMainOutput.SelectAll();
        }
    }
}
