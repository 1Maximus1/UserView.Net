namespace UserView.Models
{
    public class Photo
    {
        public byte[] PhotoData { get; set; }

        public Photo() { }

        public Photo(byte[] data)
        {
            PhotoData = data;
        }
    }
}
