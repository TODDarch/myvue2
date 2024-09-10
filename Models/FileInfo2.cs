namespace vue3.Models;

public class FileInfo2
{
    // public FileInfo2()
    // {
    //     this.FileName = "";
    // }
    public string? RequestId { get; set; }
    public string FileName { get; set; } = "";
    public string FileContent { get; set; } = "";

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
