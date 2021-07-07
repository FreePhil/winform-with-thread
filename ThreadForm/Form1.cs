using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadForm
{
    delegate void ThreadCounter(int counter);
    public partial class Form1 : Form
    {
        const int MaxCount = 50;
        private int counter;

        public Form1()
        {
            InitializeComponent();
        }

        private void CountWithSingleThread(object sender, EventArgs e)
        {
            numberCounter.Text = "0";
            this.Update();

            counter = 0;
            while (counter < MaxCount)
            {
                numberCounter.Text = counter.ToString();
                Thread.Sleep(100);
                counter++;
            }   
        }

        private void InvokeThread(object sender, EventArgs e)
        {
            counter = 0;
            Task.Run(() =>
            {
                while (counter < MaxCount)
                {
                    UpdateLabel(counter);
                    Thread.Sleep(100);
                    counter++;
                }
            });
        }
        private async void AwaitThread(object sender, EventArgs e)
        {
            counter = 0;

            while (counter < MaxCount)
            {
                await Task.Run(() =>
                {
                    counter++;
                    Thread.Sleep(100);
                });
                numberCounter.Text = counter.ToString();
            }
        }

        private async void AwaitThreadWithoutContextSync(object sender, EventArgs e)
        {
            counter = 0;

            try
            {
                while (counter < MaxCount)
                {
                    await Task.Run(() =>
                    {
                        counter++;
                        Thread.Sleep(100);
                    }).ConfigureAwait(false);
                    numberCounter.Text = counter.ToString();
                }
            }
            catch (Exception err)
            {
                Console.WriteLine($"error: {err.Message}");
            }
        }

        private void UpdateLabel(int no)
        {
            if (InvokeRequired)
            {
                Invoke(new ThreadCounter(UpdateLabel), new object[] { counter });
            }
            else
            {
                numberCounter.Text = counter.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
    