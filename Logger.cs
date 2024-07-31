namespace TML143xSoundFixer
{
    internal static class Logger
    {
        internal static void Error(Exception e, bool showDialog, string dialogText = "")
        {
            try
            {
                string time = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                string errorLog = $"[{time}] {e}{Environment.NewLine}";
                File.AppendAllText(Pathes.GetApplicationLogFilePath(), errorLog);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{dialogText}\n(エラーのログファイル生成に失敗しました。)\n{e}\nログファイル生成のエラーは以下の通り\n{ex}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (showDialog)
            {
                MessageBox.Show($"{dialogText}\n{e}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
