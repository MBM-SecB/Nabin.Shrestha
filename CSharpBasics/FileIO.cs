using System.IO;
public class FileIO
{
   
    public void LearnFileHandling()
    {
        //var filecontent = File.ReadAllText(@"E:\Computer Science\.Net Centric Computing\Lab\Nabin.Shrestha\README.md");
       // Console.ForegroundColor = Console.Green;

       //or

       string filepath = @"E:\Computer Science\.Net Centric Computing\Lab\Nabin.Shrestha\README.md";
       //string fileWithInProject ="Generics.cs";

       bool isFileThere = File.Exists(filepath);
       //bool isFileThere = File.Exists(fileWithInProject);

       //if(isFileThere)
       //{}

       //or
       if(File.Exists(filepath))
       {
           var filecontent = File.ReadAllText(filepath);
           //var filecontent = File.ReadAllText(fileWithInProject);
            Console.WriteLine(filecontent);
       }
    }

    public void LearnFileWriting()
    {
        string filePath = "ABC.txt";
        File.WriteLine(filepath,"This is random file content.");
    }

    public void LearnFileInfo()
    {
        string filepath ="ABC.txt";
        FileInfo fileInfo new fileInfo(filePath);

        var size = fileInfo.Length;
        var createDate = fileInfo.createTime;

        Console.WriteLine(filePath);
        Console.WriteLine($"Size: {size) bytes");
        Console.WriteLine($"Created:)

    }

    public void Learn
}

//create  a folder "Nepal", with in that create 10 sub folder , Every subfolders should contain a file Test.txt with subfolder name as a comntent. 