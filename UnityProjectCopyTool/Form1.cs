using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnityProjectCopyTool
{
    public partial class Form1 : Form
    {
        readonly string[] copyFolderNames =
        {
            "Assets","Library","ProjectSettings"
        };
        const string packagesStr = "Packages";

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFolderDialogButton_Click(object sender, EventArgs e)
        {
            // フォルダを選択するためのダイアログを表示する
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();

            // 選択されたフォルダのパスを取得する
            if (result != DialogResult.OK || string.IsNullOrWhiteSpace(dialog.SelectedPath)) return;
            string selectedPath = dialog.SelectedPath;

            // 選択されたフォルダのパスを表示する
            SelectFolderAddressTextBox.Text = selectedPath;
        }

        private void AlwaysOnTopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // チェックが入っていたら最前面表示する
            TopMost = AlwaysOnTopCheckBox.Checked;
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            // Packagesの確認
            bool includePackages = IncludePackagesCheckBox.Checked;

            string folderPass = SelectFolderAddressTextBox.Text;
            // フォルダ名の取得
            string folderName = Path.GetFileName(folderPass);
            // 子フォルダのパスを取得
            string[] subFoldersPass = Directory.GetDirectories(folderPass);

            // 選択されたフォルダの親フォルダのパスを取得する
            string parentFolderPath = Directory.GetParent(folderPass).FullName;

            // 新しいフォルダを作成する
            string newFolderName = $"{folderName}_Copy";
            string newFolderPath = Path.Combine(parentFolderPath, newFolderName);
            Directory.CreateDirectory(newFolderPath);

            foreach (string subFolderPass in subFoldersPass)
            {
                string subFolderName = Path.GetFileName(subFolderPass);
                foreach (var item in copyFolderNames)
                {
                    // フォルダ名で識別してコピーする
                    if (subFolderName != item) continue;
                    DirectoryCopy(subFolderPass, newFolderPath);
                }

                if (!includePackages) continue;
                if (subFolderName != packagesStr) continue;
                DirectoryCopy(subFolderPass, newFolderPath);
            }
        }

        private void DirectoryCopy(string sourcePath, string destinationPath)
        {
            DirectoryInfo sourceDirectory = new DirectoryInfo(sourcePath);
            DirectoryInfo destinationDirectory = new DirectoryInfo(destinationPath);

            //ファイルのコピー
            foreach (FileInfo fileInfo in sourceDirectory.GetFiles())
            {
                //同じファイルが存在していたら、常に上書きする
                fileInfo.CopyTo(destinationDirectory.FullName + @"\" + fileInfo.Name, true);
            }

            //ディレクトリのコピー（再帰を使用）
            foreach (DirectoryInfo directoryInfo in sourceDirectory.GetDirectories())
            {
                DirectoryCopy(directoryInfo.FullName, destinationDirectory.FullName + @"\" + directoryInfo.Name);
            }
        }
    }
}