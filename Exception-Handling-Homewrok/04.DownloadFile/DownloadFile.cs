using System;
using System.IO;
using System.Net;
/*
    Problem 4. Download file

    Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
    Find in Google how to download files in C#.
    Be sure to catch all exceptions and to free any used resources in the finally block.
 */
class DownloadFile
{
    static void Main()
    {
        string imageSource = @"http://telerikacademy.com/Content/Images/news-img01.png";
        string storePlace = "newpicture.png"; //"newpicture";
        using (WebClient myWebClient = new WebClient())
        {
            try
            {
                myWebClient.DownloadFile(imageSource, storePlace);
                Console.WriteLine("Download succesfull!");
                Console.WriteLine(@"You can see downloaded file in: 04.DownloadFile\bin\Debug");
            }
            catch (FileNotFoundException)
            {
                throw new Exception("The source is not found!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You cannot reach this file!");
            }
            catch (WebException)
            {
                throw new WebException("There has been a problem with tha download!");
            }
            catch
            {
                Console.WriteLine("An error occured, please try again");
            }
        }
    }
}