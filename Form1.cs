using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileNameChange
{
    public partial class RegexExpressTextBox : Form
    {
        public RegexExpressTextBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 用來存放待更改路徑檔案的list
        /// </summary>
        private static List<string> ChangeFileNameList = new List<string>();

        /// <summary>
        /// 用來存放待更新檔案路徑(key)/已完成更新檔案路徑(value)的字典
        /// </summary>
        private static Dictionary<string, string> FilePathUpdateRecoredDictionary = new Dictionary<string, string>();

        /// <summary>
        /// 用來存放更新完成項目路徑的List
        /// </summary>
        private static List<string> FilePathUpdateList = new List<string>();

        private void FileReadBnt_Click(object sender, EventArgs e)
        {
            // 清空1.更改路徑檔案清單list 
            ChangeFileNameList.Clear();
            FilePathUpdateRecoredDictionary.Clear();
            FilePathUpdateList.Clear();

            // 顯示讀檔路徑並且存到變數filePath
            string filePath = ReadFileShowPathOnTextBox();

            if (filePath == string.Empty)
            {
                // 使用者防呆: 點選"讀取檔案"按鈕，卻沒有選擇檔案讀取
                // 對策: 啥都不做
            }
            else
            {
                // 讀取檔案清單
                FileReader fileReader = new FileReader(filePath);
                ChangeFileNameList = fileReader.ReadFileAndStorePath();
            }
        }

        /// <summary>
        /// 讀取檔案對話視窗抓取檔案路徑並顯示出來
        /// </summary>
        /// <returns>檔案路徑名稱</returns>
        public string ReadFileShowPathOnTextBox()
        {
            OpenFileDialog openReadFileDialog = new OpenFileDialog();

            openReadFileDialog.Title = "請開啟(.txt)檔案";
            string fileName = string.Empty;

            if (openReadFileDialog.ShowDialog() == DialogResult.OK)
            {
                //顯示路徑
                fileName = openReadFileDialog.FileName;
                FilePathTextBox.Text = fileName;
            }
            return fileName;
        }

        private void FilePathUpdateBnt_Click(object sender, EventArgs e)
        {
            string encryptionPattern = regexInputTextBox.Text;

            // 檢查是否有讀取清單
            if (ChangeFileNameList.Count() == 0)
            {
                string checkRemindMsg = "請確認是否有讀取清單";
                MessageBox.Show(checkRemindMsg);
            }
            // 來檢查Pattern輸入
            else if (encryptionPattern == string.Empty)
            {
                string inputRemindMsg = "請輸入加密Pattern";
                MessageBox.Show(inputRemindMsg);
            }
            else
            {
                FilePathChanger filePathChanger = new FilePathChanger(encryptionPattern);

                // 將更新完成的檔案路徑加入清查用的字典以及要產出清單的list
                foreach (string encrytedFilePath in ChangeFileNameList)
                {
                    string decrytedFilePath = filePathChanger.CaptureFilePath(encrytedFilePath);
                   
                    FilePathUpdateRecoredDictionary.Add(encrytedFilePath, decrytedFilePath);

                    if (decrytedFilePath != string.Empty)
                    {
                        FilePathUpdateList.Add(decrytedFilePath);
                    }
                }
                string reportMsg = "已完成檔案路徑更新";
                MessageBox.Show(reportMsg);
            }
            
        }

        private void FilePathTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FileUpdateResultBnt_Click(object sender, EventArgs e)
        {
            if (FilePathUpdateList.Count() == 0)
            {
                string checkRemindMsg = "請先確認已完成檔案路徑更新";
                MessageBox.Show(checkRemindMsg);
            }
            else
            {
                FilePathUpdateListProducer filePathUpdateListProducer = new FilePathUpdateListProducer(FilePathUpdateList);
                filePathUpdateListProducer.produceUpdatedFilePathList();

                string reportMsg = "已產出清單";
                MessageBox.Show(reportMsg);

            }         
        }
    }
}
