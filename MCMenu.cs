using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Wanqi Chin
/// 818386160
/// </summary>
namespace MissileCommandRun
{
    public partial class MCMenu : Form
    {
        
        MissileCommandGUI start_Click;
        public MCMenu()
        {
            InitializeComponent();
            

        }
       
        private void label1_Click(object sender, EventArgs e)
        {
            start_Click = new MissileCommandGUI();
            start_Click.IncomingMissileSpeed= 2;
            start_Click.DropMissileCount= int.MaxValue;
            start_Click.DefenseMissiles = 30;
            start_Click.ScoreFactor = 1;
            this.Hide();
            start_Click.Closed += (s, args) => this.Close();
            start_Click.Show();
            
        }

        private void MCMenu_Load(object sender, EventArgs e)
        {
           
        }

        private void UnlimitedMissilesMode_Click(object sender, EventArgs e)
        {
            start_Click = new MissileCommandGUI();
            start_Click.IncomingMissileSpeed = 4;
            start_Click.DropMissileCount = int.MaxValue;
            start_Click.DefenseMissiles = int.MaxValue;
            start_Click.ScoreFactor = 1;
            this.Hide();
            start_Click.Closed += (s, args) => this.Close();
            start_Click.Show();
            
        }

        private void MediumMode_Click(object sender, EventArgs e)
        {
            start_Click = new MissileCommandGUI();
            start_Click.IncomingMissileSpeed = 4;
            start_Click.DropMissileCount = int.MaxValue;
            start_Click.DefenseMissiles = 25;
            start_Click.ScoreFactor = 2;

            this.Hide();
            start_Click.Closed += (s, args) => this.Close();
            start_Click.Show();
            
        }

        private void HardMode_Click(object sender, EventArgs e)
        {
            start_Click = new MissileCommandGUI();
            start_Click.IncomingMissileSpeed = 6;
            start_Click.DropMissileCount = int.MaxValue;
            start_Click.DefenseMissiles = 20;
            start_Click.ScoreFactor = 3;
            this.Hide();
            start_Click.Closed += (s, args) => this.Close();
            start_Click.Show();
            
        }

        
        private void MissileCommandPicBox_Click(object sender, EventArgs e)
        {

        }
    }
}
