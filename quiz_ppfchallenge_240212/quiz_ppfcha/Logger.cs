using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logger
{
    public class Logger
    {
        #region グローバル変数

        private string logDirectory;
        private int maxLogFileCount;

        #endregion

        #region　関数

        /// <summary>
        /// ログフォルダファイル作成
        /// </summary>
        /// <param name="logDirectory">logフォルダ</param>
        /// <param name="maxLogFileCount">最大ファイル数</param>
        public Logger(string logDirectory, int maxLogFileCount = 3)
        {
            this.logDirectory = logDirectory;
            this.maxLogFileCount = maxLogFileCount;

            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }
        }

        /// <summary>
        /// ログ
        /// </summary>
        /// <param name="message">ログメッセージ</param>
        public void Log(string message)
        {
            try
            {
                string logFilePath = GetLogFilePath();
                using (StreamWriter writer = File.AppendText(logFilePath))
                {
                    writer.WriteLine($"{DateTime.Now}: {message}");
                }

                ManageLogFilesByCount();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ログの書き込み中にエラーが発生しました: {ex.Message}");
            }
        }

        /// <summary>
        /// ファイルパスの取得
        /// </summary>
        /// <returns>fileName</returns>
        private string GetLogFilePath()
        {
            string fileName = $"log_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.txt";
            return Path.Combine(logDirectory, fileName);
        }

        /// <summary>
        /// ログファイルカウント
        /// </summary>
        private void ManageLogFilesByCount()
        {
            try
            {
                // ログディレクトリ内のログファイルを取得
                DirectoryInfo dirInfo = new DirectoryInfo(logDirectory);
                FileInfo[] logFiles = dirInfo.GetFiles("log*.txt");

                // ログファイル数が最大数より多い場合、古いログファイルを削除
                if (logFiles.Length > maxLogFileCount)
                {
                    Array.Sort(logFiles, (x, y) => x.CreationTime.CompareTo(y.CreationTime)); // 作成日時で昇順ソート
                    int filesToDeleteCount = logFiles.Length - maxLogFileCount;

                    for (int i = 0; i < filesToDeleteCount; i++)
                    {
                        logFiles[i].Delete();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ログファイルの世代管理中にエラーが発生しました: {ex.Message}");
            }
        }

        #endregion

    }
}