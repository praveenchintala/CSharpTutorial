using System;

namespace SealedDemo
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    abstract class mobileCoreOS
    {
        public abstract void Dial();
        public virtual string PhoneContact()
        {
            return "phoneContact";
        }

        public virtual void LoadPicture()
        {
            Console.WriteLine("Picture");
        }
    }

    class AndroidCore : mobileCoreOS
    {
        public override void Dial()
        {
            Console.WriteLine("Beep");
        }

        public sealed override string PhoneContact()
        {
            return "AdroidContact";
        }
        public new void LoadPicture()
        {

        }
    }

   sealed class ioCore : mobileCoreOS
    {
        public override void Dial()
        {
           
        }

        public override string PhoneContact()
        {
            return "ios.contact";
        }
    }

    class Ubuntu: AndroidCore
    {
        public void ScreenSaver()
        {
            Console.WriteLine("Screen Saver is displayed");
        }

    }

  
}
