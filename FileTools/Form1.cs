using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FileTools.Properties;

namespace FileTools
{
    public partial class mainwnd : Form
    {
        string[] filelist;
        List<string> ret;

        public mainwnd()
        {
            InitializeComponent();
            this.chbExt.Checked = Settings.Default.CheckExt;
            this.chbPath.Checked = Settings.Default.CheckPath;
        }

        private void OnFileDrop(object sender, DragEventArgs e)
        {
            filelist = e.Data.GetData(DataFormats.FileDrop) as string[];
            UpdateResult();
        }

        private void OnFileDropEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void WithExt(object sender, EventArgs e)
        {
            UpdateResult();
            CheckBox b = sender as CheckBox;
            Settings.Default.CheckExt = b.Checked;
            Settings.Default.Save();
        }

        private void CheckPath(object sender, EventArgs e)
        {
            UpdateResult();
            CheckBox b = sender as CheckBox;
            Settings.Default.CheckPath = b.Checked;
            Settings.Default.Save();
        }

        void UpdateResult()
        {
            if (filelist == null) return;
            if (filelist.Length == 0) return;

            ret = new List<string>(filelist);
            if (!this.chbPath.Checked)
            {
                for (int i = 0; i < ret.Count; i++)
                {
                    ret[i] = Path.GetFileName(ret[i]);
                }
            }
            if (!this.chbExt.Checked)
            {
                for (int i = 0; i < ret.Count; i++)
                {
                    ret[i] = Path.GetFileNameWithoutExtension(ret[i]);
                }
            }

            this.result.Text = string.Join(Environment.NewLine, ret);
        }

        private void Copy2Clipboard(object sender, EventArgs e)
        {
            Clipboard.SetText(this.result.Text);
        }

        private void OnEnterPressed(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(this.tbExt.Text))
                {
                    var strlist = new List<string>(ret);
                    for (int i = 0; i < strlist.Count; i++)
                    {
                        strlist[i] = strlist[i] + this.tbExt.Text;
                    }
                    this.result.Text = string.Join(Environment.NewLine, strlist);
                }
                else
                {
                    this.result.Text = string.Join(Environment.NewLine, ret);
                }
                e.Handled = true;
            }
        }
    }
}
