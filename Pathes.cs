using System.IO;

namespace TML143xSoundFixer
{
    internal static class Pathes
    {
        internal static string GetApplicationDirectory()
        {
            return Path.GetDirectoryName(Application.ExecutablePath) ?? "";
        }

        internal static string GetApplicationLogFilePath()
        {
            return Path.Combine(GetApplicationDirectory(), "tSoundFixer-Error.log");
        }

        internal static string GetApplicationFAudio144DirectoryPath()
        {
            return Path.Combine(GetApplicationDirectory(), "tMLAudioLib", "v1.4.4");
        }

        internal static string GetGetApplicationFAudio144Path()
        {
            return Path.Combine(GetApplicationFAudio144DirectoryPath(), "FAudio.dll");
        }


        internal static string GetTMLFAudioDirectoryPathFromTMLPath(string tMLPath)
        {
            return Path.Combine(tMLPath, "Libraries", "Native", "Windows");
        }

        internal static string GetTMLFAudioPathFromTMLPath(string tMLPath)
        {
            return Path.Combine(tMLPath, "Libraries", "Native", "Windows", "FAudio.dll");
        }
    }
}
