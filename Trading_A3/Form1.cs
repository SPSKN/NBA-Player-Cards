using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trading_A3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Player> playerList = new List<Player>();
        /// <summary>
        /// A list of the players in the NBA
        /// </summary>
        //4 spaces between
        Player a = new Player("James Harden", 30, "\nHT: 6-5    \nWT: 220 lbs    GP:20    PTS:39.5    FG%:43.3    3P%:34.4    \nTeam:Houston Rockets    \nNumber:#13");
        Player b = new Player("Giannia Antetoklounmpo", 24, "\nHT: 6-11    \nWT: 242 lbs    GP:21    PTS:30.8    FG%:56.5    3P%:30.4     \nTeam:Milwaukee Bucks    \nNumber:#34");
        Player c = new Player("Luka Doncic", 20, "\nHT: 6-7    \nWT: 230 lbs    GP:20    PTS:30.7    FG%:48.4    3P%:33.5    \nTeam:Dallas Mavericks   \nNumber:#77");
        Player d = new Player("Bradley Beal", 26, "\nHT: 6-3    \nWT: 207 lbs    GP:19    PTS:28.7    FG%:47.2    3P%:34.7    \nTeam:Washington Wizards   \nNumber:#3");
        Player f = new Player("Trae Young", 21, "\nHT: 6-1    \nWT: 180 lbs    GP:21    PTS:28.7    FG%:46.3    3P%:39.3    \nTeam:Atlanta Hawks   \nNumber:#11");
        Player g = new Player("Damian Lillard", 29, "\nHT: 6-2    \nWT: 195 lbs    GP:20    PTS:26.6    FG%:44.7    3P%:36.7    \nTeam:Portland Trail Blazers   \nNumber:#0");
        Player h = new Player("Anthony Davis", 26, "\nHT: 6-10    \nWT: 253 lbs    GP:21    PTS:26.0    FG%:49.0    3P%:34.3    \nTeam:Los Angeles Lakers   \nNumber:#3");
        Player i = new Player("Karl-Anthony Towns", 24, "\nHT: 6-11    \nWT: 248 lbs    GP:18    PTS:25.9    FG%:50.3    3P%:42.7    \nTeam:Minnesota Timberwolves   \nNumber:#32");
        Player j = new Player("Brandon Ingram", 22, "\nHT: 6-7    \nWT: 190 lbs    GP:17    PTS:25.4    FG%:48.9    3P%:41.5    \nTeam:New Orleans Pelican   \nNumber:#14");
        Player r = new Player("Pascal Siakam", 25, "\nHT: 6-9    \nWT: 230 lbs    GP:20    PTS:25.1    FG%:46.7    3P%:38.4    \nTeam:Toronto Raptors   \nNumber:#43");

        private void Form1_Load(object sender, EventArgs e)
        {
            playerList.Add(a);
            playerList.Add(b);
            playerList.Add(c);
            playerList.Add(d);
            playerList.Add(f);
            playerList.Add(g);
            playerList.Add(h);
            playerList.Add(i);
            playerList.Add(j);
            playerList.Add(r);


            foreach (Player obj in playerList)
                {
                //listBox1.Items.Add(obj);
                listBox1.Items.Add(obj.Player_Name);
                
                }

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected_item = listBox1.SelectedItem.ToString();
            var selected_index = listBox1.SelectedIndex;
            ///int x=0;
            ///var myLinq = from string name in playerList[i].Player_Name
                       ///  where playerList[i].Player_Name == selected_item
                         ///select playerList[i].Player_Age.ToString() + playerList[i].Player_Stats;

            for(int i =0; i < playerList.Count; i++)
            {
                var myLinq = from Player name in playerList[i].Player_Name
                             where selected_item == playerList[i].Player_Name
                             select playerList[i].Player_Age.ToString() + playerList[i].Player_Stats;
                             
                switch(selected_index)
                {
                    case 0: pictureBox1.ImageLocation = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/1610612745/2019/260x190/201935.png"; break;
                    case 1: pictureBox1.ImageLocation = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/1610612749/2019/260x190/203507.png"; break;
                    case 2: pictureBox1.ImageLocation = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/1610612742/2019/260x190/1629029.png"; break;
                    case 3: pictureBox1.ImageLocation = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/1610612737/2019/260x190/1629027.png"; break;
                    case 4: pictureBox1.ImageLocation = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/1610612764/2019/260x190/203078.png"; break;
                    case 5: pictureBox1.ImageLocation = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/1610612757/2019/260x190/203081.png"; break;
                    case 6: pictureBox1.ImageLocation = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/1610612747/2019/260x190/203076.png"; break;
                    case 7: pictureBox1.ImageLocation = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/1610612750/2019/260x190/1626157.png"; break;
                    case 8: pictureBox1.ImageLocation = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/1610612740/2019/260x190/1627742.png"; break;
                    case 9: pictureBox1.ImageLocation = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/1610612761/2019/260x190/1627783.png"; break;

                }
                if (selected_item == playerList[i].Player_Name)
                {
                    richTextBox1.Text ="Age: " +playerList[i].Player_Age.ToString() + playerList[i].Player_Stats;
                }
                
                /*switch(selected_index)
                {
                    case: 0 return;

                }
                */
               /* foreach(Player name in myLinq)
                {
                    richTextBox1.Text = name.Player_Stats;
                }
                */
            }
            
        }
    }
    public class Player
    {
        public string Player_Name;
        public int Player_Age;
        public string Player_Stats;

        public Player(string name,int age,string stats)
        {
            Player_Name = name;
            Player_Age = age;
            Player_Stats = stats;
        }
        
    }
}
