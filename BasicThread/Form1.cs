using System;
using System.Threading;
using System.Windows.Forms;

namespace BasicThread
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
        }
        private void btnRunThread_Click(object sender, EventArgs e)
        {
            Console.WriteLine("- Before Starting Thread -");
            Thread ThreadA = new Thread(MyThreadClass.Thread1);
            Thread ThreadB = new Thread(MyThreadClass.Thread1);

            //Proompting user that Threads are Processing
            lblThreadStatus.Text = "- Proccessing Thread -";

            ThreadA.Name = "Thread A";
            ThreadB.Name = "Thread B";
            ThreadA.Start();
            ThreadB.Start();
            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine("- End of Thread -");
            lblThreadStatus.Text = "- End of Thread -";
        }
    }

    public class MyThreadClass
    {
        public static void Thread1()
        {
            for (int loopCount = 0; loopCount <= 5; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + loopCount);
                Thread.Sleep(1000);
                if (loopCount == 5)
                { 
                    return;
                }
            }
        }
    }
}
