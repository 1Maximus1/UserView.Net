using System.Collections.Generic;
using UserView.Models;

namespace UserView.Services
{
    public class PhotoRequestService
    {
        public async Task<Photo> GetPhotoDataFromConsoleAsync()
        {
            
            Console.Write("Please enter path to your avatar: ");
            string imagePath = Console.ReadLine();
            if (string.IsNullOrEmpty(imagePath)) {
                imagePath = "Images/img.jpg";
                if (File.Exists(imagePath))
                {
                    var data = await File.ReadAllBytesAsync(imagePath);
                    return new Photo(data);
                }
                else
                {
                    throw new FileNotFoundException("File not found at the specified path.");
                }
            }
            else
            {
                if (File.Exists(imagePath))
                {
                    var data = await File.ReadAllBytesAsync(imagePath);
                    return new Photo(data);
                }
                else
                {
                    throw new FileNotFoundException("File not found at the specified path.");
                }
            }
            
        }
    }

}
