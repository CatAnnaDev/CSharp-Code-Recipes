using System;
using System.Threading;

namespace GuideCSharp.MultiThreadedOperations.SynchronizationWithTheMainThread
{
	public class SynchronizationWithTheMainThread
	{
		public SynchronizationWithTheMainThread()
		{
		}
	}

    public partial class Form1 : Form
    {
        //...
        int Add(int a, int b)
        {
            Thread.Sleep(3000);
            return a + b;
        }

        public void Calculate(int a, int b)
        {
            var result = Add(a, b);
            //synchronization with the main thread
            //for update user interface
            Invoke((Action)delegate {lResult.Text = result.ToString();
            });
        }

        private void btn_Click(object sender, EventArgs e)
        {
            var action = new Action<int, int>(Calculate);
            //start new thread
            action.BeginInvoke(3, 5, null, null);
        }
    }
}

