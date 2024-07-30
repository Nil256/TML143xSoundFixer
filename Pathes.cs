using System.IO;

namespace TML143xSoundFixer
{
    internal static class Pathes
    {
        internal static string GetApplicationFAudio144DirectoryPath()
        {
            return Path.Combine(Path.GetDirectoryName(Application.ExecutablePath) ?? "", "tMLAudioLib", "v1.4.4");
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
