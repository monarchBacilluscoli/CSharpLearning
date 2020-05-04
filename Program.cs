namespace csharp_test
{
    partial class Program
    {
        static void Main(string[] args)
        {
            {
                var person1 = new Person();
                var person2 = new StructPerson();
                System.Console.WriteLine(person1.ToString());
                person1.Print();
                var person3 = person1;
                person1.Age = 26;// class is ref type, person1/3 are the same
                person3.Print();
                System.Console.WriteLine(person2.ToString());
                person2.Print();
                var person4 = person2;
                person2.Age = 26;
                person4.Print();// struct is value type, person2/4 are not the same
            }
            {
                var video = new Video() { Name = "Magan_suck_my_cock.mp4" };
                var video_encoder = new VideoEncoder();
                var message_sender = new MessageSender();
                var message_sender2 = new MessageSender();
                video_encoder.VideoEncoded+=message_sender.OnVideoEncoded;
                video_encoder.VideoEncoded+=message_sender2.OnVideoEncoded;
                video_encoder.Encode(video); // 看来是一个个发的, event系统并不意味着多线程
            }
        }
    }
}
