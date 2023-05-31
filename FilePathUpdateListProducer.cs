using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileNameChange
{
    public class FilePathUpdateListProducer
    {
        public List<string> FilePathUpdateList { get; set; }

        public FilePathUpdateListProducer(List<string> filePathUpdateList)
        {
            FilePathUpdateList = filePathUpdateList;
        }

        public void produceUpdatedFilePathList()
        {
            // 使用 SaveFileDialog 讓使用者指定存放位置與檔名
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TXT 檔 (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string txtPath = saveFileDialog.FileName;

                // 建立 StreamWriter 物件
                using (StreamWriter writer = new StreamWriter(txtPath))
                {
                    // 寫入每一行資料
                    foreach (string UpdatedFilePath in FilePathUpdateList)
                    {
                        writer.WriteLine($"{UpdatedFilePath}");
                    }
                }
            }
        }
    }
}
