using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileNameChange
{
    public class FilePathChanger
    {
        /// <summary>
        /// 指定應刪除的加密pattern
        /// </summary>
        public string EncryptedPattern { get; set; }

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="encryptionPattern">汙染的pattern</param>
        /// <param name="encryptionFilePathPrefixs">受汙染的檔案路徑開頭</param>
        /// <param name="backupSourcePathPrefix">備份檔案路徑開頭</param>
        public FilePathChanger(string encryptedPattern)
        {
            EncryptedPattern = encryptedPattern;
        }

        /// <summary>
        /// 方法--任務1:將受汙染的檔案路徑比對汙染的pattern並剔除pattrn
        /// </summary>
        /// <param name="EncryptionFilePath">受汙染的檔案路徑</param>
        /// <returns>剔除汙染的pattrn的路徑</returns>
        public string CaptureFilePath(string EncryptedFilePath)
        {
            Match match = Regex.Match(EncryptedFilePath, EncryptedPattern);
            if (match.Success)
            {
                return match.Groups["filePath"].Value;
            }
            else
            {
                return string.Empty;
            }
        }


        ///// <summary>
        ///// 方法--任務2:將處理過的被汙染檔案路徑加工成備分檔案路徑
        ///// </summary>
        ///// <param name="decryptedFilePath">處理過的被汙染檔案路徑</param>
        ///// <returns>備分檔案路徑</returns>
        //public string GetBackupFilePath(string decryptedFilePath, string[] EncryptionFilePathPrefixSet)
        //{
        //    string checkPath = decryptedFilePath;
        //    // 檢查檔案是否含有清單中的汙染檔案位置開頭
        //    for (int index  = 0;  index < EncryptionFilePathPrefixSet.Count(); index++)
        //    {
        //        if (decryptedFilePath.Contains(EncryptionFilePathPrefixSet[index]))
        //        {
        //            // 用備份檔來源路徑開頭更新路徑
        //            return decryptedFilePath.Replace(EncryptionFilePathPrefixSet[index], BackupSourcePathPrefix);
        //        }
        //    }

        //    return string.Empty;
        //}

        ///// <summary>
        ///// 方法--任務3:將修改好的路徑加入字典之Key
        ///// </summary>
        ///// <param name="fileChechWhetherExistDictionary">用來檢查備份檔案來源是否存在的字典</param>
        ///// <param name="backupFilePath">備分檔案路徑</param>
        //public void AddBackupFilePathIntoDictionary(Dictionary<string, string> fileChechWhetherExistDictionary, string backupFilePath)
        //{
        //    if (backupFilePath != string.Empty)
        //    {
        //        if (!fileChechWhetherExistDictionary.Keys.Contains(backupFilePath))
        //        {
        //            fileChechWhetherExistDictionary.Add(backupFilePath, string.Empty);
        //        }
        //    }
        //}

        ///// <summary>
        ///// 方法--任務4:確認備份來源中是否有所需檔案，若有則製作存放目的檔案路徑並完成搬運，再紀錄於字典 
        ///// </summary>
        ///// <param name="storageFilePathPrefix"></param>
        ///// <param name="FileMovementDictionary"></param>
        //public void MoveFile(string storageFilePathPrefix, Dictionary<string, string> FileMovementDictionary)
        //{
        //    // 取得備份來源下的所有檔案路徑
        //    string[] backupSourceFilePaths = Directory.GetFiles(BackupSourcePathPrefix, "*", SearchOption.AllDirectories);

        //    foreach (string filePath in backupSourceFilePaths)
        //    {

        //        // 如果備份檔案中的路徑是有在名單內(字典的Keys)
        //        if (FileMovementDictionary.Keys.Contains(filePath)) 
        //        {
        //            // 建立[目的地儲存檔案路徑]
        //            string destinationStorageFilePath = filePath.Replace(BackupSourcePathPrefix, storageFilePathPrefix);

        //            // 搬移檔案
        //            File.Copy(filePath, destinationStorageFilePath, true);

        //            // 將已完成搬移的[目的地儲存檔案路徑] 加入字典的對應Key之value
        //            FileMovementDictionary[filePath] = destinationStorageFilePath;
        //        }
        //    }
        //    string movementCompleteMsg = "檔案搬運成功";
        //    MessageBox.Show(movementCompleteMsg);
        //}
    }
}
