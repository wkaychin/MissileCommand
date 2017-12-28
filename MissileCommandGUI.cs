//#define My_Debug
using MissileCommandRun.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Wanqi Chin
/// 818386160
/// </summary>
namespace MissileCommandRun
{
    public partial class MissileCommandGUI : Form
    {

        int deflected_missile = 0; //stopped missile add to score
        int tickCount = 0; //ticks between timer
        bool gameOver = false;
        int level= 1; //I couldn't figure out how to implement levels into the game so I did a counter and simply changed how fast the missiles will be released after another
        
        int _incomingmissiledelay = 0; //delay between incoming missile releases
        int _firedcount = 0;//counts user missiles fired

        int mouseclick_x = 0; //x-coordinate of mouse click
        int mouseclick_y = 0;// y-coordinate of mouse click

        int incomingMissileSpeed; //set by clicks in MCMenu
        int dropMissileCount; //set by clicks in MCMenu
        int defenseMissiles; //set by clicks in MCMenu
        int defenseMissilesInit;
        int scoreFactor; //set by clicks in MCMenu, the harder the mode the more points
        int ammo; //shots left
        int score;



        //bitmaps for cities
        City city_one;
        City city_two;
        City city_three;
        City city_four;
        City city_five;
        City city_six;
        Grass grass_one;

        private List<IncomingMissiles> missiles;//stores missile objects
        private List<UserMissiles> _usermissilesupply; //stores user missiles in hindisght i think this class is pretty usesless since explosion covers all the functionality of usermissile
        private List<Blow> _explosions; //stores the blow ups that occur with mouse clicks
        private List<City> _bCities; // stores 6 city bitmaps
#if My_Debug
        int _cursX = 0;
        int _cursY = 0;
#endif

        public MissileCommandGUI()
        {
            InitializeComponent();
            

            _bCities = new List<City>();
            _bCities.Add(city_one = new City() { Left = ClientSize.Width - 100, Top = ClientSize.Height - 125 });
            _bCities.Add(city_two = new City() { Left = ClientSize.Width - 240, Top = ClientSize.Height - 125 });
            _bCities.Add(city_three = new City() { Left = ClientSize.Width - 380, Top = ClientSize.Height - 125 });
            _bCities.Add(city_four = new City() { Left = ClientSize.Width - 520, Top = ClientSize.Height - 125 });
            _bCities.Add(city_five = new City() { Left = ClientSize.Width - 660, Top = ClientSize.Height - 125 });
            _bCities.Add(city_six = new City() { Left = ClientSize.Width - 800, Top = ClientSize.Height - 125 });
            grass_one = new Grass() { Left = ClientSize.Width - 840, Top = ClientSize.Height - 100 };

            _incomingmissiledelay = 30; //delay between missile releases
            Gameplay(); //starts game
        }

        //updates game

        private void FireMissile()
        {
            //fires off missile sound
            SoundPlayer m_fire = new SoundPlayer(Resources.missilefire);
            m_fire.Play();
        }
        //override paint function
        private void Gameplay()
        {

            missiles = new List<IncomingMissiles>();
            _usermissilesupply = new List<UserMissiles>();
            _explosions = new List<Blow>();
            GameTimer.Start(); //I saw other code which created a timer from system.Timers.Timer I think that maybe smoother since it implements threading. I just used a Form timer and events from tick events

        }
        public void GameTimer_Tick(object sender, EventArgs e)
        {
            tickCount++;
            if (tickCount % _incomingmissiledelay == 0 && dropMissileCount != 0) //releases a missile if missile delay is reached and if missile count does not equal to 0
                AddMissile();
                Invalidate();
            if (tickCount % 400 == 0) //increments my level
            {
                _incomingmissiledelay -= 2;
                level += 1;
                score += (50 * defenseMissiles);
                defenseMissiles = 0;
                defenseMissiles += defenseMissilesInit;
                incomingMissileSpeed++;
                ammo = defenseMissiles;
                this.Refresh();

            }
            Invalidate();

            
        }
        /// <summary>
        /// The onPaint override idea was first taken from a mole whacking tutorial, it seemed like the easiest solution since 
        /// I was not planning on implement pictureboxes or storyboards
        /// This method invokes a lot of iteration which is not good for time complexity but I couldn't find another way to 
        /// execute the necessary actions using methods I was familiar with.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics drawing = e.Graphics;
            if (!gameOver)
            {

                foreach (var element in missiles) //draws each missile to screen
                    element.Move(drawing);
                Score();
                for (int i = _bCities.Count - 1; i >= 0; i--) //this nested loop is pretty hefty I got the idea from other missile command game instances
                {
                    for (int j = missiles.Count - 1; j >= 0; j--)
                    {
                        if (i >= 0 && _bCities[i].Hit(missiles[j].GetEndPoint()))
                        {

                            _bCities.RemoveAt(i);
                            FireMissile();
                            i--;
                            if (_bCities.Count <= 0)
                                gameOver = true;

                        }
                    }
                }
                for (int i = _usermissilesupply.Count - 1; i >= 0; i--)
                {
                    _usermissilesupply[i].missile_flicker(drawing);
                    if (_usermissilesupply[i].Done)
                    {
                        _usermissilesupply.RemoveAt(i);
                    }
                }
                for (int i = _explosions.Count - 1; i >= 0; i--)
                {
                    _explosions[i].expand(drawing);
                    for (int j = missiles.Count - 1; j >= 0; j--)
                    {
                        if (_explosions[i].Hit(missiles[j].GetEndPoint()))
                        {
                            deflected_missile++;
                            missiles.RemoveAt(j); 
                        }
                    }
                    if (_explosions[i].Stop)
                    {
                        _explosions.RemoveAt(i);

                    }
                }

                foreach (var element in _bCities)
                    element.DrawImage(drawing);
                grass_one.DrawImage(drawing);

#if My_Debug

                //sends x, y coordinates to screen for positioning of bitmaps using directives watched video for this
                TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.EndEllipsis;
                Font _font = new System.Drawing.Font("Stencil", 12, FontStyle.Regular);
                TextRenderer.DrawText(e.Graphics, "X=" + _cursX.ToString() + ":" + "Y=" + _cursY.ToString(), _font, new Rectangle(30, 75, 120, 20), SystemColors.ControlLightLight, flags);
#endif

                //"Scoreboard at right"
                TextFormatFlags score_flags = TextFormatFlags.Left;
                Font scores_font = new System.Drawing.Font("Bauhaus 93", 12, FontStyle.Regular);
                TextRenderer.DrawText(e.Graphics, $"Shots Taken:" + _firedcount.ToString(), scores_font, new Rectangle(650, 40, 200, 20), SystemColors.ControlLightLight, score_flags);
                TextRenderer.DrawText(e.Graphics, $"Shots Left: " + defenseMissiles.ToString(), scores_font, new Rectangle(650, 58, 200, 20), SystemColors.ControlLightLight, score_flags);
                TextRenderer.DrawText(e.Graphics, $"Incoming Missiles Left: " + dropMissileCount.ToString(), scores_font, new Rectangle(600, 75, 200, 20), SystemColors.ControlLightLight, score_flags);
                TextRenderer.DrawText(e.Graphics, $"Level: " + level.ToString(), scores_font, new Rectangle(600, 100 , 100, 20), SystemColors.ControlLightLight, score_flags);
                base.OnPaint(e);
            }
            else 
            {
                TextFormatFlags g_flags = TextFormatFlags.HorizontalCenter;
                Font g_Font = new System.Drawing.Font("Bauhaus 93", 45, FontStyle.Bold);
                TextRenderer.DrawText(e.Graphics, "GAME OVER", g_Font, new Rectangle(100, 150, 500, 200), SystemColors.ControlLightLight, g_flags);
                TextRenderer.DrawText(e.Graphics, $"Final Score" + score, g_Font, new Rectangle(100, 250, 500, 200), SystemColors.ControlLightLight, g_flags);
                base.OnPaint(e);
            }//pass base class
        }
        /// <summary>
        /// function to add missiles at tick counts taking into accordance delay between missile releases
        /// </summary>
        private void AddMissile()
        {
            Random rand = new Random();
            if (dropMissileCount > 0) //the if statement may be unnecessary here
            {
                missiles.Add(new IncomingMissiles(this.ClientSize.Width, this.ClientSize.Height, incomingMissileSpeed, rand));
                dropMissileCount--;
            }

        }
        /// <summary>
        /// I orginally wanted to animated this rectangle for user missile to fire from one of three "bases" or areas that I designate
        /// as the firezone. However, I couldn't figure out how to flicker the rectangle diagonally so now it just draws a small rectangle on the screen
        /// to denote where the shot was fired. 
        /// </summary>
        private void AddUserMissile()
        {
            _usermissilesupply.Add(new UserMissiles(mouseclick_x, mouseclick_y));
        }
        private void AddExplosion()
        {
            Rectangle rect = new Rectangle(mouseclick_x, mouseclick_y, 0, 0);

            if (_usermissilesupply.Count > 0)
                _explosions.Add(new Blow(mouseclick_x, mouseclick_y, rect));
        }
        /// <summary>
        /// updates score, each deflected missile starts out at 100 points and that total is scaled according to the mode of gameplay
        /// </summary>
        private void Score()
        {
            score = (scoreFactor * deflected_missile * 100);
            textBox1.Text = score.ToString();

        }

        private void MissileCommandGUI_MouseMove(object sender, MouseEventArgs e)
        {
#if My_Debug
            _cursX = e.X;
            _cursY = e.Y;
#endif 
        }

        private void MissileCommandGUI_Load(object sender, EventArgs e)
        {

        }

        private void MissileCommandGUI_MouseClick(object sender, MouseEventArgs e)
        {
            Score(); //updates score every click to check for changes
            mouseclick_x = e.X;
            mouseclick_y = e.Y;
            Rectangle clickRect = new Rectangle(mouseclick_x, mouseclick_y, 0, 0); //passes coordinates into Blow to create an explosion
            Blow click = new Blow(mouseclick_x, mouseclick_y, clickRect);
            _firedcount++; //the amount of times a shot is fired
            //ammo = defenseMissiles - _firedcount; //shots left
            if (defenseMissiles>=1)
            {
                AddUserMissile();
                _explosions.Add(click);
                FireMissile();
                defenseMissiles--;
            }
        }
        private bool GameOver()
        {
            if (_bCities.Count > 0)
                return gameOver=false;
            else return gameOver=true;
        }
        public int IncomingMissileSpeed
        {
            get { return incomingMissileSpeed;}
            set { incomingMissileSpeed = value; }
        }

        public int DropMissileCount
        {
            get { return dropMissileCount; }
            set { dropMissileCount = value; }
        }
        public int DefenseMissiles
        {
            get { return defenseMissiles; }
            set {
                defenseMissilesInit = value;
                    defenseMissiles = value;
            }
        }
        public int ScoreFactor
        {
            get { return scoreFactor; }
            set { scoreFactor = value; }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameTimer.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameTimer.Start();
        }
    }
}
