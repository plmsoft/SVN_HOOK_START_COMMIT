using PLM.SharpSvnProxy;
using PLM.Start_commit_notification.BO;
using PLM.Start_commit_notification.Commands.Svn;
using PLM.Start_commit_notification.Helper;
using PLM.Start_commit_notification.Service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PLM.Start_commit_notification.Presentation
{
    internal class ViewFilePresentation : IViewFilePresentation
    {
        private readonly ListView _view;
        private readonly Label _labelCountFiles;
        private readonly string _strParam;
        private readonly IBranchCommands _branchCommands;
        private readonly IRenameFilePresentation _renameFilePresentation;
        public ViewFilePresentation(ListView view, Label labelCountFiles, string strParam, IRenameFilePresentation renameFilePresentation)
        {
            _view = view;
            _labelCountFiles = labelCountFiles;
            _strParam = strParam;
            _branchCommands = new BranchCommands(new SvnFactory());
            _renameFilePresentation = renameFilePresentation;
        }

        private int CountSelectedFiles { get { return _view.Items.OfType<ListViewItem>().Where(d=> d.Checked).ToList().Count; }}
        private int TotalFiles { get {return _view.Items.Count; } }
        private string[] CheckedFiles { get { return _view.CheckedItems.OfType<ListViewItem>().Select(item => item.Text).ToArray(); } }
        private string SelectedFile { get { return _view.SelectedItems.OfType<ListViewItem>().Select(item => item.Text).FirstOrDefault(); } }

        public void FillListViewFiles()
        {
            _view.Items.Clear();
            var filesList = GetFiles();
            foreach (var commitFile in filesList)
            {
                var item = new ListViewItem(commitFile.Location, -1);
                item.SubItems.Add(commitFile.Extension);
                item.SubItems.Add(commitFile.Status.ToString(), Color.Black, Color.White, new Font(_view.Font, FontStyle.Bold));
                _view.Items.Add(item);
            }
        }

        public void SetAppearance()
        {
            if (_view.Items.Count > 0)
            {
                _view.Items[0].Focused = true;
                _view.Items[0].Selected = true;
            }
        }

        public void ShowCountFiles()
        {
            _labelCountFiles.Text = string.Format(CultureInfo.InvariantCulture, "{0} files selected, {1} files total", CountSelectedFiles, TotalFiles);
        }

        private IEnumerable<CommitFile> GetFiles()
        {
            CommitFile[] listCommitFile;

            try
            {
                var base64EncodedBytes = Convert.FromBase64String(_strParam);
                var xml = Encoding.UTF8.GetString(base64EncodedBytes);

                listCommitFile = SerializationHelper.XmlDeserialization(xml);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new CommitFile[0];
            }

            return listCommitFile;
        }

        public void CheckedItems(bool check)
        {
            _view.Items.OfType<ListViewItem>().ToList().ForEach(item => item.Checked = check);
        }

        public void IgnoreFile()
        {
            ExecCommand(_branchCommands.IgnoreFile, CheckedFiles);
        }

        public void DeleteFile()
        {
            var cf = CheckedFiles.Length == 1 ? string.Empty : "s";
            if (MessageBox.Show(string.Format(Consts.MessageDeletefile, cf), Consts.CaptionDeleteFile, MessageBoxButtons.OKCancel) == DialogResult.OK)
                if (ExecCommand(_branchCommands.DeleteFile, CheckedFiles))
				{
					MessageBox.Show(Consts.MessageDeleteSuccess, Consts.CaptionWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
					_view.Items[0].SubItems[2].Text = Consts.FileDeleted;
				}
		}

        public void RenameFile()
        {
            if (_view.SelectedItems.Count == 0)
            {
                MessageBox.Show(Consts.MessageNoSelectedItem, Consts.CaptionWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var oldFileName = SelectedFile;
            var fi = new FileInfo(oldFileName);

            string newFileName;
            if (_renameFilePresentation.RenameFileForm(fi.Name, out newFileName))
            {
                newFileName = fi.DirectoryName + @"\" + newFileName;

                if (ExecCommand(_branchCommands.RenameFile, oldFileName, newFileName))
                {
                    var newfi = new FileInfo(newFileName);
                    _view.Items[0].Text = newFileName;
                    _view.Items[0].SubItems[1].Text = newfi.Extension;
                }
            }
        }

        public void RevertFile()
        {
            if (ExecCommand(_branchCommands.RevertFile, CheckedFiles))
			{
				MessageBox.Show(Consts.MessageRevertSuccess, Consts.CaptionWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				_view.Items[0].SubItems[2].Text = Consts.FileReverted;
			}
        }

        private bool ExecCommand(Func<string[], bool> cmd, string[] arg)
        {
            try
            {
                if (cmd(arg))
					return true;
				return false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Consts.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool ExecCommand(Func<string, string, bool> cmd, string arg1, string arg2)
        {
            try
            {
                cmd(arg1, arg2);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Consts.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void ButtonEnabled(ContextMenuStrip mnu, ToolStrip tsmnu)
        {
            if (_view.Items.Count > 0)
            {
                if (_view.CheckedItems.Count == 0)
                {
                    mnu.Items.OfType<ToolStripMenuItem>().ToList().ForEach(item => { item.Enabled = item.Tag.ToString().Equals("1") ? true : false; });
                    tsmnu.Items.OfType<ToolStripButton>().ToList().ForEach(item => { item.Enabled = item.Tag.ToString().Equals("1") ? true : false; });
                }
                else
                {
                    mnu.Items.OfType<ToolStripMenuItem>().ToList().ForEach(item => item.Enabled = true);
                    tsmnu.Items.OfType<ToolStripButton>().ToList().ForEach(item => item.Enabled = true);
                }
            }
            else
            {
                mnu.Items.OfType<ToolStripMenuItem>().ToList().ForEach(item => { item.Enabled = false; });
                tsmnu.Items.OfType<ToolStripButton>().ToList().ForEach(item => { item.Enabled = false; });
            }
        }
    }
}
