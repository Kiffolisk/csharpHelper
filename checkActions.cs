
// gets if path is folder or file, returns string
public static string IsDirectoryOrFile(string path)
{
  string result = "";
  if (Directory.Exists(path))
  {
    result = "folder";
  }
  else if (File.Exists(path))
  {
    result = "file";
  }
  else
  {
    result = "none";
  }
  return result;
}
