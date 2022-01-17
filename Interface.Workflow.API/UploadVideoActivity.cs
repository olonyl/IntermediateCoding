using System;

namespace Interface.Engine.API
{
    public class UploadVideoActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading video to some cloud store");
        }
    }
}
