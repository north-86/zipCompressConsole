using System.IO.Compression;
using static System.Console;

bool isOpen = true;

while (isOpen)
{
    WriteLine("Select action:\n" + "1 - create archive\n" + "2 - unpack archive\n" + "3 - exit\n");

    int choice = Convert.ToInt32(ReadLine());

    switch (choice)
    {
        case 1:
            try
            {
                Write("Name of the source directory: ");
                string sourceDirectoryName = ReadLine();
                Write("File name of the target archive: ");
                string destinationArchiveFileName = ReadLine();
                ZipFile.CreateFromDirectory(sourceDirectoryName, destinationArchiveFileName, CompressionLevel.SmallestSize, true);
                WriteLine();
                WriteLine($"The folder {sourceDirectoryName} is archived to a file {destinationArchiveFileName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            break;
        case 2:
            try
            {
                Write("Name of the source archive file: ");
                string sourceArchiveFileName = ReadLine();
                Write("Name of the target directory: ");
                string destinationDirectoryName = ReadLine();
                ZipFile.ExtractToDirectory(sourceArchiveFileName, destinationDirectoryName);
                WriteLine();
                WriteLine($"The file {sourceArchiveFileName} is unpacked to a folder {destinationDirectoryName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            break;
        case 3:
            isOpen = false;
            break;
        default:
            Console.WriteLine("Invalid command entered\n");
            break;
    }
    ReadKey();
    Clear();
}
