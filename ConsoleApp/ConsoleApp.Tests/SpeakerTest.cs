using NUnit.Framework;

namespace ConsoleApp.Tests
{
    public class SpeakerTests
    {

        [Test]
        public void Test()
        {
            var speaker = new Speaker();
            speaker.PublicMethod();
            speaker.InternalMethod();
            // Compile Error!
            speaker.PrivateMethod();
            speaker.ProtectedMethod();
        }
    }
}