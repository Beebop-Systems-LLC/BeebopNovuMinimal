namespace BeebopNovuMinimal.Domain.Interfaces
{
    /// <summary>
    /// Abstraction for file system services that differ by platform.
    /// </summary>
    public interface IPlatformFileService
    {
        string GetAppDataPath();
        void SaveFile(string filename, string content);
        string ReadFile(string filename);
    }
}