using System;
namespace GuideCSharp.Patterns.Structuralpatterns.Proxy
{
    // https://dl.dropbox.com/s/bjc85ywp6fanjuk/19208.png
    public class Proxy
	{
		public Proxy()
		{
            //Client
            var proxy = new ImageProxy("1.png");
            //operation without creating a RealSubject
            var fileName = proxy.GetFileName();
            //forwarded to the RealSubject
            proxy.Draw();

            Console.WriteLine(fileName);
        }
	}

    //Subject
    abstract class Graphic
    {
        protected string FileName;

        public abstract void Draw();

        public string GetFileName()
        {
            return FileName;
        }
    }

    //RealSubject
    class Image : Graphic
    {

        public Image(string fileName)
        {
            FileName = fileName;
        }

        //Request()
        public override void Draw()
        {
            Console.WriteLine("draw " + FileName);
        }
    }

    //Proxy
    class ImageProxy : Graphic
    {
        Image _image;

        public ImageProxy(string fileName)
        {
            FileName = fileName;
        }

        public override void Draw()
        {
            GetImage().Draw();
        }

        private Image GetImage()
        {
            return _image ??= new Image(FileName);
        }
    }

}

