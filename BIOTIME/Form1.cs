using BIOTIME.Models;
using BIOTIME.Wrapper;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace BIOTIME
{
    public partial class Form1 : Form
    {
        private readonly biotime_bkContext _context;

        public Form1()
        {
            InitializeComponent();
            _context = new biotime_bkContext(new DbContextOptions<biotime_bkContext>());
        }
        private async void Form1_Load_1Async(object sender, EventArgs e)
        {
            var authUsers = await _context.AuthUsers.ToListAsync();
            dataGridView1.DataSource = authUsers;
            string ipAddress = "10.234.15.34"; 
            int port = 4370; 

            if (ZkemkeeperWrapper.Connect_Net(ipAddress, port))
            {
                MessageBox.Show("Connected to device!");
            }
            else
            {
                MessageBox.Show("Failed to connect.");
            }
        }
    }
}
