void Rename(string oPath, string nName)
{
    Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(oPath, nName); // add microsoft.visualbasic reference
}
        
void RenameFolder(string oPath, string nPath)
{
    Directory.Move(oPath, nPath);
    if (Directory.Exists(nPath))
    {
        Console.WriteLine("renamed");
    }
}
