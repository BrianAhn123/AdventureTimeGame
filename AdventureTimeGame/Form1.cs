﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media; 

namespace AdventureTimeGame
{
    public partial class Form1 : Form
    {
        int page = 1;
        int dodge = 0;
        int save = 0;
        int explode = 0;
        int flute = 0;
        Random Random = new Random();
        public Form1()
        { 
            SoundPlayer intro = new SoundPlayer(Properties.Resources.Adventure_Time___Opening__1080p_);
            intro.Play();
            InitializeComponent();
            textBox.Text = "Press Small Blue Button to Start!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            option1Button.Enabled = true; 
            option2Button.Enabled = true;
            option3Button.Enabled = true;
            startButton.Enabled = false;
            if(page == 0)
            {
                page = 1;
            }
            displayPage();
        }

        public void displayPage()
        {
            SoundPlayer scream = new SoundPlayer(Properties.Resources.Adventure_Time___Finns_Scream);
            SoundPlayer pancake = new SoundPlayer(Properties.Resources.Bacon_Pancakes);
            SoundPlayer intro = new SoundPlayer(Properties.Resources.Adventure_Time___Opening__1080p_);


            switch (page)
            {
                case 0:
                    break;
                case 1:
                    pancake.Stop();
                    intro.Stop();
                    imageBox.Image = Properties.Resources.treehouse;
                    textBox.Text = "You Wake up in your Lovely Treehouse Do you want to go on a Adventure or go back to bed?";
                    option1Label.Text = "Red Button: Go on a Adventure";
                    option2Label.Text = "Green Button: Go back to bed";
                    break;
                case 2:
                    imageBox.Image = Properties.Resources.Map;
                    textBox.Text = "You go outside and look at Three Directions which way do you go?";
                    option1Label.Text = "Red Button: Candy Kingdom";
                    option2Label.Text = "Green Button: Ice Kingdom";
                    option3Label.Text = "Blue Button: Marceline's Cave";
                    break;
                case 3:
                    pancake.Play();
                    imageBox.Image = Properties.Resources.jake; 
                    textBox.Text = "You went back to sleep while jake makes Bacon Pancakes (You took the Tired Route) Play Again? ";
                    option1Label.Text = "Red Button: Yes";
                    option2Label.Text = "Green Button: No";
                    break;
                case 4:
                    imageBox.Image = Properties.Resources.marceline;
                    textBox.Text = "You enter the cave and hear Marceline playing her Bass in her home. Will you Interrupt her or Wait?";
                    option1Label.Text = "Red Button: Interrupt her";
                    option2Label.Text = "Green Button: Wait";
                    option3Label.Text = "";
                    break;
                case 5:
                    imageBox.Image = Properties.Resources.kidnapped;
                    textBox.Text = "You enter the Ice kingdom and its quite Chilly and you see Ice King Kidnapping LSP! Sneak Attack or Run at Him?";
                    option1Label.Text = "Red Button: Sneak Attack";
                    option2Label.Text = "Green Button: Run at Him";
                    option3Label.Text = "";
                    break;
                case 6:
                    imageBox.Image = Properties.Resources.candyking;
                    textBox.Text = "You enter the Candy Kingdom and see PB drinking some tea. Ask for a Quest or Hang out with her?";
                    option1Label.Text = "Red Button: Ask for a Quest";
                    option2Label.Text = "Green Button: Hang out with her";
                    option3Label.Text = "";
                    break;
                case 7:
                    
                    textBox.Text = "PB Gave you a quest to Save LSP from the Ice King. Accept or Don't?";
                    option1Label.Text = "Red Button: Accept the Quest";
                    option2Label.Text = "Green Button: Don't Accept";
                    break;
                case 8:
                    imageBox.Image = Properties.Resources.candylab;
                    textBox.Text = "You and PB hang out in the Lab doing Experiements. Do you help her?";
                    option1Label.Text = "Red Button: Yes";
                    option2Label.Text = "Green Button: No";
                    break;
                case 9:
                    option1Label.Text = "";
                    option2Label.Text = "";
                    textBox.Text = "You help her with the Chemicals and the tube starts shaking";
                    Refresh();
                    Thread.Sleep(2000);

                    explode = Random.Next(0, 5);
                    if (explode == 1)
                    {
                        page = 14;
                        displayPage();
                    }
                    else if (explode > 1)
                    {
                        page = 13;
                        displayPage();
                    }
                    Refresh();
                    break;
                case 10:
                    option1Label.Text = "";
                    option2Label.Text = "";
                    textBox.Text = "The Tube starts shaking in PB's Hand you run over to save her";
                    Refresh();
                    Thread.Sleep(2000);

                    save = Random.Next(1, 101);
                    if (save == 65 && save < 65)
                    {
                        page = 12;
                        displayPage();
                    }
                    else if (save >= 65)
                    {
                        page = 11;
                        displayPage();
                    }
                    break;
                case 11:
                    imageBox.Image = Properties.Resources.explodsion;
                    scream.Play();
                    textBox.Text = "The Tube explodes in her Hand and there was Gum everywhere.(You gained the Failure Route) Play again?";
                    option1Label.Text = "Red Button: Yes";
                    option2Label.Text = "Green Button: No";
                    break;
                case 12:
                    imageBox.Image = Properties.Resources.heroending;
                    textBox.Text = "You saved her from the explosion and she was glad you were there. (You won the Heroic Ending) Play Again?";
                    option1Label.Text = "Red Button: Yes";
                    option2Label.Text = "Green Button: No";
                    break;
                case 13:
                    imageBox.Image = Properties.Resources.heroending;
                    textBox.Text = "The chemicals Stabilize and you both create a new Element. (Walter White Ending) Play Again)";
                    option1Label.Text = "Red Button: Yes";
                    option2Label.Text = "Green Button: No";
                    break;
                case 14:
                    imageBox.Image = Properties.Resources.explodsion;
                    scream.Play();
                    textBox.Text = "The Chemicals create a huge explosion and you both died. (Failed Chemist Ending) Play Again?";
                    option1Label.Text = "Red Button: Yes";
                    option2Label.Text = "Green Button: No";
                    break;
                case 15:
                    imageBox.Image = Properties.Resources.finnfrozen;
                    scream.Play();
                    textBox.Text = "You Go in Loud and get frozen in Ice and ice King gets away (Frozen Ending) Play Again?";
                    option1Label.Text = "Red Button: Yes";
                    option2Label.Text = "Green Button: No";
                    break;
                case 16:
                    imageBox.Image = Properties.Resources.iceking;
                    textBox.Text = "Ice King Gets surprised and knocks you back and charges a Ice Beam Dodge it or Deflect?";
                    option1Label.Text = "Red Button: Use your Shield to Deflect";
                    option2Label.Text = "Green Button: Dodge the attack";
                    break;
                case 17:
                    textBox.Text = "You try to Dodge";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);

                    dodge = Random.Next(0, 3);

                    if (dodge <= 1)
                    {
                        page = 18;
                        displayPage();
                    }
                    else if (dodge >= 2)
                    {
                        page = 20;
                        displayPage();
                    }
                    Refresh();
                    break;
                case 18:
                    textBox.Text = "You Successfully dodged the attack and prepare to fight back";
                    option1Label.Text = "Red Button: Use your Fist?";
                    option2Label.Text = "Green Button: Use your Sword?";
                    break;
                case 19:
                    imageBox.Image = Properties.Resources.heroending;
                    textBox.Text = "Successfully Deflected the Ice beam and froze the Ice king, Lsp was saved (Heroiz Ending) Play Again"; 
                    option1Label.Text = "Red Button: Yes";
                    option2Label.Text = "Green Button: No";
                    break;
                case 20:
                    imageBox.Image = Properties.Resources.finnfrozen;
                    scream.Play();
                    textBox.Text = "You tried to dodge and get hit by the ice beam turning into a Ice Sphere (Frozen Ending) Play AGain";
                    option1Label.Text = "Red Button: Yes";
                    option2Label.Text = "Green Button: No";
                    break;
                case 21:
                    imageBox.Image = Properties.Resources.swordfinnattack;
                    scream.Play();
                    textBox.Text = "You used your sword but Ice King Freezes it and then Freezes You (Frozen ending) PLay AGain";
                    option1Label.Text = "Red Button: Yes";
                    option2Label.Text = "Green Button: No";
                    break;
                case 22:
                    imageBox.Image = Properties.Resources.finnpunch;
                    textBox.Text = "You Punch Ice King in the Face Knocking him out. Will you take him to the Candy Kingdom or go Home";
                    option1Label.Text = "Red Button: Take Ice King to the Candy Kingdom";
                    option2Label.Text = "Green Button: Go Home";
                    break;
                case 23:
                    imageBox.Image = Properties.Resources.candyking;
                    textBox.Text = "You take the Ice king to the Candy Kingdom YOU WIN (Ultimate Hero) Play Again";
                    option1Label.Text = "Red Button: Yes";
                    option2Label.Text = "Green Button: No";

                    break;
                case 24:
                    imageBox.Image = Properties.Resources.treehouse;
                    textBox.Text = "You Go Home leaving the Ice King Behind (Lazy Hero) Play Again";
                    option1Label.Text = "Red Button: Yes";
                    option2Label.Text = "Green Button: No";
                    break;
                case 25:
                    imageBox.Image = Properties.Resources.marcelinepissed;
                    textBox.Text = "You Interrupt Marceline's Song and she gets pissed at you. Calm her down or do nothing?";
                    option1Label.Text = "Red Button: Calm her Down";
                    option2Label.Text = "Green Button: Do Nothing";
                    break;
                case 26:
                    imageBox.Image = Properties.Resources.marceline;
                    textBox.Text = "You let Marceline play her song and asks you to join her band";
                    option1Label.Text = "Red Button: Accept to join her band";
                    option2Label.Text = "Green Button: Don't Accept";
                    break;
                case 27:
                    textBox.Text = "You Calm her down and she continues her song";
                    break;
                case 28:
                    imageBox.Image = Properties.Resources.nightosphere;
                    textBox.Text = "You Do Nothing and you get sent to the Nightnosphere where your soul was sucked (Souless Warrior) Play Again";
                    option1Label.Text = "Red Button: Yes";
                    option2Label.Text = "Green Button: No";
                    break;
                case 29:
                    textBox.Text = "She Shrugs it off and kicks you out of her house (Boring ending) Play Again";
                    option1Label.Text = "Red Button: Yes";
                    option2Label.Text = "Green Button: No";
                    break;
                case 30:
                    imageBox.Image = Properties.Resources.flute;
                    textBox.Text = "You start playing your flute with Marceline";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);

                    flute = Random.Next(1, 11);

                    if (flute < 7)
                    {
                        page = 32;
                        displayPage();
                    }
                    else if (flute >= 7)
                    {
                        page = 31;
                        displayPage();
                    }
                    Refresh();
                    break;
                case 31:
                    imageBox.Image = Properties.Resources.finn;
                    scream.Play();
                    textBox.Text = "You play horribly and get kicked out of the band (Mid Musician) Play Again?";
                    option1Label.Text = "Red Button: Yes";
                    option2Label.Text = "Green Button: No";
                    break;
                case 32:

                    textBox.Text = "You play pretty good and Marceline was Impressed. You're getting tired what do you do?";
                    option1Label.Text = "Red Button: Keep Playing?";
                    option2Label.Text = "Green Button: Go Home";
                    break;
                case 33:
                    imageBox.Image = Properties.Resources.midnight;
                    textBox.Text = "You and Marceline keep playing til midnight (Musical Ending) Play Again?";
                    option1Label.Text = "Red Button: Yes";
                    option2Label.Text = "Green Button: No";
                    break;
                case 34:
                    imageBox.Image = Properties.Resources.treehousenight;
                    textBox.Text = "You go home and sleep after a long day. Play Again?";
                    option1Label.Text = "Red Button: Yes";
                    option2Label.Text = "Green Button: No";
                    break;
                case 99:
                    Refresh();
                    textBox.Text = "Thank you for playing Adventure TIME!";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    Thread.Sleep(5000);
                    Close();
                    break;
                case 69:
                    imageBox.Image = Properties.Resources.secretimage;
                    
                    break;
                default:
                    break;
            }
        
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            if(page == 1)
            {
                page = 2;
            }
            else if(page == 2)
            {
                page = 6; 
            }
            else if (page == 3)
            {
                page = 1;
            }
            else if (page == 4)
            {
                page = 25;
            }
            else if (page == 5)
            {
                page = 16;
            }
            else if (page == 6)
            {
                page = 7; 
            }
            else if (page == 7)
            {
                page = 5;
            }
            else if (page == 8)
            {
                page = 9;
            }
            else if (page == 9)
            {
                Refresh();
                if (explode == 0)
                {
                    page = 14;
                }
                else
                {
                    page = 13;
                }
            }
            else if (page == 10)
            {
                Refresh();
                Thread.Sleep(2000);
                if (save == 65 && save < 65)
                {
                    page = 12;
                }
                else if(save > 65)
                {
                    page = 11;
                }
            }
            else if (page == 11)
            {
                page = 1;
            }
            else if (page == 12)
            {
                page = 1;
            }
            else if (page == 13)
            {
                page = 1;
            }
            else if (page == 14)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 1;
            }
            else if (page == 16)
            {
                page = 19;
            }
            else if (page == 18)
            {
                page = 22; 
            }
            else if (page == 19)
            {
                page = 1; 
            }
            else if (page == 20)
            {
                page = 1; 
            }
            else if (page == 21)
            {
                page = 1; 
            }
            else if (page == 22)
            {
                page = 23;
            }
            else if (page == 23)
            {
                page = 1; 
            }
            else if (page == 24)
            {
                page = 1;
            }
            else if (page == 25)
            {
                page = 27;
            }
            else if (page == 26)
            {
                page = 30; 
            }
            else if (page == 27)
            {
                page = 26;
            }
            else if (page == 28)
            {
                page = 1;
            }
            else if (page == 29)
            {
                page = page = 1;
            }
            else if (page == 30)
            {
                Refresh();
                Thread.Sleep(2000);

                if (flute < 7)
                {
                    page = 32;
                    displayPage();
                }
                else if (flute > 7)
                {
                    page = 31;
                    displayPage();
                }
            }
            else if (page == 31)
            {
                page = 1;
            }
            else if (page == 32)
            {
                page = 33;
            }
            else if (page == 33)
            {
                page = 1;
            }
            else if (page == 34)
            {
                page = 1;
            }
            else if (page == 99)
            {

            }
            else if (page == 69)
            {

            }

            displayPage();
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3; 
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 3)
            {
                page = 99; 
            }
            else if (page == 4)
            {
                page = 26;
            }
            else if (page == 5)
            {
                page = 15;
            }
            else if (page == 6)
            {
                page = 8;
            }
            else if (page == 7)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 10;
            }
            else if (page == 9)
            {
                
            }
            else if (page == 10)
            {
                
            }
            else if (page == 11)
            {
                page = 99;
            }
            else if (page == 12)
            {
                page = 99; 
            }
            else if (page == 13)
            {
                page = 99;
            }
            else if (page == 14)
            {
                page = 99;
            }
            else if (page == 15)
            {
                page = 99; 
            }
            else if (page == 16)
            {
                page = 17;
            }
            else if (page == 17)
            {
                if (dodge < 1)
                {
                    page = 18;
                    displayPage();
                }
                else if (dodge > 2)
                {
                    page = 20;
                    displayPage();
                }
                Refresh();
            }
            else if (page == 18)
            {
                page = 21;
            }
            else if (page == 19)
            {
                page = 99;
            }
            else if (page == 20)
            {
                page = 99; 
            }
            else if (page == 21)
            {
                page = 99;
            }
            else if (page == 22)
            {
                page = 25;
            }
            else if (page == 23)
            {
                page = 99;
            }
            else if (page == 24)
            {

            }
            else if (page == 25)
            {
                page = 28;
            }
            else if (page == 26)
            {
                page = 29; 
            }
            else if (page == 27)
            {
                page = page = 26; 
            }
            else if (page == 28)
            {
                page = 99;
            }
            else if (page == 29)
            {
                page = page = 99;
            }
            else if (page == 30)
            {
                
            }
            else if (page == 31)
            {
                page = 99; 
            }
            else if (page == 32)
            {
                page = 34;
            }
            else if (page == 33)
            {
                page = 99;
            }
            else if (page == 34)
            {
                page = 99;
            }
            else if (page == 99)
            {

            }
            else if (page == 69)
            {

            }
            displayPage();
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 69;
            }
            else if (page == 2)
            {
                page = 4; 
            }
            else if (page == 3)
            {

            }
            else if (page == 4)
            {

            }
            else if (page == 5)
            {

            }
            else if (page == 6)
            {

            }
            else if (page == 7)
            {

            }
            else if (page == 8)
            {

            }
            else if (page == 9)
            {

            }
            else if (page == 10)
            {

            }
            else if (page == 11)
            {

            }
            else if (page == 12)
            {

            }
            else if (page == 13)
            {

            }
            else if (page == 14)
            {

            }
            else if (page == 15)
            {

            }
            else if (page == 16)
            {

            }
            else if (page == 17)
            {

            }
            else if (page == 18)
            {

            }
            else if (page == 19)
            {

            }
            else if (page == 20)
            {

            }
            else if (page == 21)
            {

            }
            else if (page == 22)
            {

            }
            else if (page == 23)
            {

            }
            else if (page == 24)
            {

            }
            else if (page == 25)
            {

            }
            else if (page == 26)
            {

            }
            else if (page == 27)
            {

            }
            else if (page == 28)
            {

            }
            else if (page == 29)
            {

            }
            else if (page == 30)
            {

            }
            else if (page == 31)
            {

            }
            else if (page == 32)
            {

            }
            else if (page == 33)
            {

            }
            else if (page == 34)
            {

            }
            else if (page == 69)
            {

            }
            displayPage();
        }

        private void textBox_Click(object sender, EventArgs e)
        {

        }
    }
}
