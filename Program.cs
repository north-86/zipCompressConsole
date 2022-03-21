using System.IO.Compression;
using static System.Console;

WriteLine("Select action:\n" + "1 - create archive\n" + "2 - unpack archive\n");
string choice = ReadLine();
WriteLine();
switch (choice)
{
    case "1":
        Write("Name of the source directory: ");
        string sourceDirectoryName = ReadLine();
        Write("File name of the target archive: ");
        string destinationArchiveFileName = ReadLine();
        ZipFile.CreateFromDirectory(sourceDirectoryName, destinationArchiveFileName, CompressionLevel.SmallestSize, true);
        WriteLine();
        WriteLine($"The folder {sourceDirectoryName} is archived to a file {destinationArchiveFileName}");
        break;
    case "2":
        Write("Name of the source archive file: ");
        string sourceArchiveFileName = ReadLine();
        Write("Name of the target directory: ");
        string destinationDirectoryName = ReadLine();
        ZipFile.ExtractToDirectory(sourceArchiveFileName, destinationDirectoryName);
        WriteLine();
        WriteLine($"The file {sourceArchiveFileName} is unpacked to a folder {destinationDirectoryName}");
        break;
    default:
        break;
}
