using System;
using System.IO;
class CreatingNepal
{
    public void FolderNepal()
    {
        string folderPath;
        folderPath = "Nepal";
        Directory.CreateDirectory(folderPath);
        folderPath = @"E:\Computer Science\.Net Centric Computing\Lab\Nabin.Shrestha\Assignment2\Nepal\";
        //for(int i = 0; i<10; i++)
        //{
          //  Console.WriteLine("Enter 10 different subfolder names:");
            //string[] fileName = new string[10];
           // fileName[i] = Console.ReadLine();
           // Directory.CreateDirectory($"{folderPath}{fileName[i]}");

           
        
        var dir = @"E:\Computer Science\.Net Centric Computing\Lab\Nabin.Shrestha\Assignment2\Nepal\Pokhara"; 

        if(!Directory.Exists(dir))  // if it doesn't exist, create
        Directory.CreateDirectory(dir);

        // use Path.Combine to combine 2 strings to a path
        File.WriteAllText(Path.Combine(dir, "test.txt"), "Pokhara");


        var dir1 = @"E:\Computer Science\.Net Centric Computing\Lab\Nabin.Shrestha\Assignment2\Nepal\Kathmandu"; 
        if(!Directory.Exists(dir1))
        Directory.CreateDirectory(dir1);
        File.WriteAllText(Path.Combine(dir1, "test.txt"), "Kathmandu");


        var dir2 = @"E:\Computer Science\.Net Centric Computing\Lab\Nabin.Shrestha\Assignment2\Nepal\Bhaktapur";
        if(!Directory.Exists(dir2))
        Directory.CreateDirectory(dir2);
        File.WriteAllText(Path.Combine(dir2, "test.txt"), "Bhaktapur");


        var dir3 = @"E:\Computer Science\.Net Centric Computing\Lab\Nabin.Shrestha\Assignment2\Nepal\Lalitpur";  
        if(!Directory.Exists(dir3))
        Directory.CreateDirectory(dir3);
        File.WriteAllText(Path.Combine(dir3, "test.txt"), "Lalitpur");
        
        var dir4 = @"E:\Computer Science\.Net Centric Computing\Lab\Nabin.Shrestha\Assignment2\Nepal\Dolakha"; 
        if(!Directory.Exists(dir4))
        Directory.CreateDirectory(dir4);
        File.WriteAllText(Path.Combine(dir4, "test.txt"), "Dolakha");


        var dir5 = @"E:\Computer Science\.Net Centric Computing\Lab\Nabin.Shrestha\Assignment2\Nepal\Chitwan";
        if(!Directory.Exists(dir5))
        Directory.CreateDirectory(dir5);
        File.WriteAllText(Path.Combine(dir5, "test.txt"), "Chitwan");


    }    

}

