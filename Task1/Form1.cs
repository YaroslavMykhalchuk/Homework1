using System.Diagnostics;

namespace Task1
{
    public partial class Form1 : Form
    {
        Process? process;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("ConsoleCalculator.exe");
            processStartInfo.Arguments = textBox1.Text;
            process = Process.Start(processStartInfo);
            process.WaitForExit();
        }

        private void buttonListProccess_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            listView1.View = View.Details;
            listView1.Columns.Add("Id");
            listView1.Columns.Add("ProcessName");
            listView1.Columns.Add("Count");
            listView1.Columns.Add("BasePriority");
            listView1.Columns.Add("StartInfo");
            foreach (Process item in processes)
            {
                ListViewItem viewItem = new ListViewItem(item.Id.ToString());
                viewItem.SubItems.Add(item.ProcessName.ToString());
                viewItem.SubItems.Add(item.HandleCount.ToString());
                viewItem.SubItems.Add(item.BasePriority.ToString());
                viewItem.SubItems.Add(item.Threads.Count.ToString());
                listView1.Items.Add(viewItem);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
        }
    }
}