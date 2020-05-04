using System;
using System.Threading;

namespace csharp_test
{
    class VideoEncoder
    {
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            System.Console.WriteLine("Encoding: " + video.Name + " ...");
            Thread.Sleep(2000);

            OnVideoEncoded(video);
        }

        protected void OnVideoEncoded(Video video)
        {
            System.Console.WriteLine("Video " + video.Name + "Encoded");
            if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}
