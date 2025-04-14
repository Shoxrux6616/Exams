namespace Exam4modul.Bot.Bll.Services;

public interface IFileService
{
    public Task<byte[]> GenerateCVAsync(long botUserId);
}