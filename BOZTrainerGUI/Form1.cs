using MemoryTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOZTrainerGUI
{
    public partial class Form1 : Form
    {

        //Vars
        MemoryReader mreader = new MemoryReader();

        uint BaseAdress = 0x0; //Address for base game

        int PointsOffsetAdr = 0x1304c7b; //Offset adress for points
        uint Pointsoffset = 0; //Offset for points (Calculated from PointsOffsetAdr and BaseModule later)

        int KillCountOffsetAdr = 0x1304c7f; //Offset adress for Kill Count
        uint KillCountOffset = 0; //Offset for Kill Count (Calculated from KillCountOffsetAdr and BaseModule later)

        int HeadShotCountOffsetAdr = 0x1304C9F;
        uint HeadShotCountOffset = 0;

        int WeaponTwoClipOffsetAdr = 0x13034c3;
        uint WeaponTwoClipOffset = 0;

        int WeaponThreeClipOffsetAdr = 0x13034cb;
        uint WeaponThreeClipOffset = 0x0;

        int ToggleNoclipOffsetAdr = 0x1304CFF;
        uint ToggleNoclipOffset = 0;
        bool ToggleNoclipState = false; //Stores is noclip is enabled

        int ToggleGodmodeOffsetAdr = 0x1173e1b;
        uint ToggleGodmodeOffset = 0;
        bool ToggleGodmodeState = false; // stores is God mode enabled

        int WeaponOneIDOffsetAdr = 0x13032e7;
        uint WeaponOneIDOffset = 0;

        int WeaponTwoIDOffsetAdr = 0x1303317;
        uint WeaponTwoIDOffset = 0;

        int WeaponThreeIDOffsetAdr = 0x130332f;
        uint WeaponThreeIDOffset = 0;

        int IsLookingAtZombieOffsetAdr = 0x12ebf17;
        uint IsLookingAtZombieOffset = 0;


        int bytesOut = 0; //Bytes out for memory RW opperations

        Process process = Process.GetProcessesByName("BlackOps").ToList().FirstOrDefault(); //Get Handle On Process

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Console.WriteLine("Black Ops Zombies Trainer by cl0ck.");
            Console.WriteLine("This trainer may work in the campaign mode but is untested!");
            Console.WriteLine("Printing info about MemoryTools.dll");
            mreader.AboutMemoryTools();

            if (process != null)
            {
                //Exits if multiplayer exe
                if (process.MainModule.ModuleName != "BlackOps.exe")
                {
                    MessageBox.Show("This tool is not designed to support cheating on muliplayer!","Nice try fucker :P", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Application.Exit();
                }

                if (process.MainModule.ModuleMemorySize != 69693440)
                {
                    MessageBox.Show("Unpredicted game size! \nExiting to prevent online cheating and memory corruption!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }

                mreader.ReadProcess = process;
                mreader.Openprocess();

                HotKeyTimer.Enabled = true;

                //Calculate Pointsoffset
                Pointsoffset = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(BaseAdress + (uint)process.Modules[0].BaseAddress), 4, out bytesOut), 0);
                if (PointsOffsetAdr < 0)
                {
                    Pointsoffset -= (uint)Math.Abs(PointsOffsetAdr);
                }
                else
                {
                    Pointsoffset += (uint)PointsOffsetAdr;
                }

                // Calculate KillCountsoffset
                KillCountOffset = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(BaseAdress + (uint)process.Modules[0].BaseAddress), 4, out bytesOut), 0);
                if (KillCountOffsetAdr < 0)
                {
                    KillCountOffset -= (uint)Math.Abs(KillCountOffsetAdr);
                }
                else
                {
                    KillCountOffset += (uint)KillCountOffsetAdr;
                }

                //Calculate HeadShotCountOffset
                HeadShotCountOffset = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(BaseAdress + (uint)process.Modules[0].BaseAddress), 4, out bytesOut), 0);
                if (HeadShotCountOffsetAdr < 0)
                {
                    HeadShotCountOffset -= (uint)Math.Abs(HeadShotCountOffsetAdr);
                }
                else
                {
                    HeadShotCountOffset += (uint)HeadShotCountOffsetAdr;
                }

                //Calculate WeaponTwoClipOffset
                WeaponTwoClipOffset = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(BaseAdress + (uint)process.Modules[0].BaseAddress), 4, out bytesOut), 0);
                if (WeaponTwoClipOffsetAdr < 0)
                {
                    WeaponTwoClipOffset -= (uint)Math.Abs(WeaponTwoClipOffsetAdr);
                }
                else
                {
                    WeaponTwoClipOffset += (uint)WeaponTwoClipOffsetAdr;
                }

                //Calculate WeaponThreeClipOffset
                WeaponThreeClipOffset = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(BaseAdress + (uint)process.Modules[0].BaseAddress), 4, out bytesOut), 0);
                if (WeaponThreeClipOffsetAdr < 0)
                {
                    WeaponThreeClipOffset -= (uint)Math.Abs(WeaponThreeClipOffsetAdr);
                }
                else
                {
                    WeaponThreeClipOffset += (uint)WeaponThreeClipOffsetAdr;
                }

                //Calculate ToggleNoclipOffset
                ToggleNoclipOffset = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(BaseAdress + (uint)process.Modules[0].BaseAddress), 4, out bytesOut), 0);
                if (ToggleNoclipOffsetAdr < 0)
                {
                    ToggleNoclipOffset -= (uint)Math.Abs(ToggleNoclipOffsetAdr);
                }
                else
                {
                    ToggleNoclipOffset += (uint)ToggleNoclipOffsetAdr;
                }

                ToggleGodmodeOffset = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(BaseAdress + (uint)process.Modules[0].BaseAddress), 4, out bytesOut), 0);
                if (ToggleGodmodeOffsetAdr < 0)
                {
                    ToggleGodmodeOffset -= (uint)Math.Abs(ToggleGodmodeOffsetAdr);
                }
                else
                {
                    ToggleGodmodeOffset += (uint)ToggleGodmodeOffsetAdr;
                }

                //Calculate WeponOneIDOffset
                WeaponOneIDOffset = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(BaseAdress + (uint)process.Modules[0].BaseAddress), 4, out bytesOut), 0);
                if (WeaponOneIDOffsetAdr < 0)
                {
                    WeaponOneIDOffset -= (uint)Math.Abs(WeaponOneIDOffsetAdr);
                }
                else
                {
                    WeaponOneIDOffset += (uint)WeaponOneIDOffsetAdr;
                }

                //Calculate WeaponTwoIDOffset
                WeaponTwoIDOffset = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(BaseAdress + (uint)process.Modules[0].BaseAddress), 4, out bytesOut), 0);
                if (WeaponTwoIDOffsetAdr < 0)
                {
                    WeaponTwoIDOffset -= (uint)Math.Abs(WeaponTwoIDOffsetAdr);
                }
                else
                {
                    WeaponTwoIDOffset += (uint)WeaponTwoIDOffsetAdr;
                }

                //Calculate WeaponThreeIDOffset
                WeaponThreeIDOffset = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(BaseAdress + (uint)process.Modules[0].BaseAddress), 4, out bytesOut), 0);
                if (WeaponThreeIDOffsetAdr < 0)
                {
                    WeaponThreeIDOffset -= (uint)Math.Abs(WeaponThreeIDOffsetAdr);
                }
                else
                {
                    WeaponThreeIDOffset += (uint)WeaponThreeIDOffsetAdr;
                }

                //Calculate IsLookingAtZombieOffset
                IsLookingAtZombieOffset = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(BaseAdress + (uint)process.Modules[0].BaseAddress), 4, out bytesOut), 0);
                if (IsLookingAtZombieOffsetAdr < 0)
                {
                    IsLookingAtZombieOffset -= (uint)Math.Abs(IsLookingAtZombieOffsetAdr);
                }
                else
                {
                    IsLookingAtZombieOffset += (uint)IsLookingAtZombieOffsetAdr;
                }

            }
            else
            {
                MessageBox.Show("Error. Please make sure Black Ops is running before starting the trainer!", "Could not find Black Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }

            this.Text = ("Black Ops Zombies Trainer by cl0ck | Version " + ProductVersion + " | reading PID " + process.Id.ToString());
            string ttt = (int.Parse(process.Modules[0].BaseAddress.ToString(), System.Globalization.NumberStyles.Integer)).ToString("X");
            Console.WriteLine("Trainner attached to BlackOps @ PID " + process.Id.ToString() + " using the base memory adress 0x" + (int.Parse(process.Modules[0].BaseAddress.ToString(), System.Globalization.NumberStyles.Integer)).ToString("X") + " ( " + process.Modules[0].BaseAddress.ToString() + " in deciaml)");
            Console.WriteLine("Printing game details to console...");
            Console.WriteLine(process.Modules[0].FileVersionInfo);
            Console.Title = this.Text;
            this.Text = "Black Ops Zombies Trainer by cl0ck";

        }

        //Set points button
        private void SetPointsButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Writing " + PointsNUD.Value + " points to ram @ hex adress 0x" + (int.Parse(Pointsoffset.ToString(), System.Globalization.NumberStyles.Integer) + 0x0).ToString("X"));
            mreader.WriteMemory((IntPtr)Pointsoffset + 0x0, BitConverter.GetBytes(Convert.ToInt32(PointsNUD.Value)), out bytesOut);
        }

        //Set Weapon One Clip Button
        private void SeWeaponOneClipButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Writing " + WeaponOneCLipNUD.Value + " as weapon one clip ammo to ram @ hex adress 0x" + (int.Parse(Pointsoffset.ToString(), System.Globalization.NumberStyles.Integer) - 0x17c8).ToString("X"));
            mreader.WriteMemory((IntPtr)Pointsoffset - 0x17C8, BitConverter.GetBytes(Convert.ToInt32(WeaponOneCLipNUD.Value)), out bytesOut);
        }

        //Set Weapon Two Clip Button
        private void SetWeaponTwoClipButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Writing " + WeaponTwoCLipNUD.Value + " as weapon two clip ammo to ram @ hex adress 0x" + (int.Parse(WeaponTwoClipOffset.ToString(), System.Globalization.NumberStyles.Integer) - 0x0).ToString("X"));
            mreader.WriteMemory((IntPtr)WeaponTwoClipOffset + 0x0, BitConverter.GetBytes(Convert.ToInt32(WeaponTwoCLipNUD.Value)), out bytesOut);
            
        }

        //Set Weapon Three Clip Button
        private void SetWeaponThreeClipButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Writing " + WeaponThreeCLipNUD.Value + " as weapon three clip ammo to ram @ hex adress 0x" + (int.Parse(WeaponThreeClipOffset.ToString(), System.Globalization.NumberStyles.Integer) - 0x0).ToString("X"));
            mreader.WriteMemory((IntPtr)WeaponThreeClipOffset + 0x0, BitConverter.GetBytes(Convert.ToInt32(WeaponThreeCLipNUD.Value)), out bytesOut);
        }

        //Set Kill Count Button
        private void SetKillCountBUtton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Writing " + KillCountNUD.Value + " as kill count to ram @ hex adress 0x" + (int.Parse(KillCountOffset.ToString(), System.Globalization.NumberStyles.Integer) + 0x0).ToString("X"));
            mreader.WriteMemory((IntPtr)KillCountOffset + 0x0, BitConverter.GetBytes(Convert.ToInt32(KillCountNUD.Value)), out bytesOut);
        }

        //Set Head Shot Count Button
        private void SetHeadShotCountBUtton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Writing " + HeadShotCountNUD.Value + " as heashot count to ram @ hex adress 0x" + (int.Parse(HeadShotCountOffset.ToString(), System.Globalization.NumberStyles.Integer) + 0x0).ToString("X"));
            mreader.WriteMemory((IntPtr)HeadShotCountOffset + 0x0, BitConverter.GetBytes(Convert.ToInt32(HeadShotCountNUD.Value)), out bytesOut);
        }

        //Toggle noclip button
        private void ToggleNoclipButton_Click(object sender, EventArgs e)
        {
            if (ToggleNoclipState == true)
            {
                Console.WriteLine("Writing " + "0" + " as Noclip state to ram @ hex adress 0x" + (int.Parse(ToggleNoclipOffset.ToString(), System.Globalization.NumberStyles.Integer) + 0x0).ToString("X"));
                mreader.WriteMemory((IntPtr)ToggleNoclipOffset + 0x0, BitConverter.GetBytes(Convert.ToInt32(0)), out bytesOut);
                ToggleNoclipState = false;
            }
            else
            {
                Console.WriteLine("Writing " + "1" + " as Noclip state to ram @ hex adress 0x" + (int.Parse(ToggleNoclipOffset.ToString(), System.Globalization.NumberStyles.Integer) + 0x0).ToString("X"));
                mreader.WriteMemory((IntPtr)ToggleNoclipOffset + 0x0, BitConverter.GetBytes(Convert.ToInt32(1)), out bytesOut);
                ToggleNoclipState = true;
            }
            
        }

        //Toggle UFO Mode button
        private void ToggleUFOModeButton_Click(object sender, EventArgs e)
        {
            if (ToggleNoclipState == true)
            {
                Console.WriteLine("Writing " + "0" + " as Noclip state to ram @ hex adress 0x" + (int.Parse(ToggleNoclipOffset.ToString(), System.Globalization.NumberStyles.Integer) + 0x0).ToString("X"));
                mreader.WriteMemory((IntPtr)ToggleNoclipOffset + 0x0, BitConverter.GetBytes(Convert.ToInt32(0)), out bytesOut);
                ToggleNoclipState = false;
            }
            else
            {
                Console.WriteLine("Writing " + "2" + " as UFO Mode state to ram @ hex adress 0x" + (int.Parse(ToggleNoclipOffset.ToString(), System.Globalization.NumberStyles.Integer) + 0x0).ToString("X"));
                Console.WriteLine("This overwrites the Noclip State");
                mreader.WriteMemory((IntPtr)ToggleNoclipOffset + 0x0, BitConverter.GetBytes(Convert.ToInt32(2)), out bytesOut);
                ToggleNoclipState = true;
            }
        }


        private void ToggleGodmodeButton_Click(object sender, EventArgs e)
        {
            if (ToggleGodmodeState == true)
            {
                Console.WriteLine("Writing " + "32 (Single byte)" + " as God mode state to ram @ hex adress 0x" + (int.Parse(ToggleGodmodeOffset.ToString(), System.Globalization.NumberStyles.Integer) + 0x0).ToString("X"));
                mreader.WriteMemory((IntPtr)ToggleGodmodeOffset + 0x0, BitConverter.GetBytes(Convert.ToByte(32)), out bytesOut);
                ToggleGodmodeState = false;
            }
            else
            {
                Console.WriteLine("Writing " + "33 (Single byte)" + " as God mode state to ram @ hex adress 0x" + (int.Parse(ToggleGodmodeOffset.ToString(), System.Globalization.NumberStyles.Integer) + 0x0).ToString("X"));
                mreader.WriteMemory((IntPtr)ToggleGodmodeOffset + 0x0, BitConverter.GetBytes(Convert.ToByte(33)), out bytesOut);
                ToggleGodmodeState = true;
            }
        }

        private void ToggleDeathStateButton_Click(object sender, EventArgs e)
        {
            if (ToggleGodmodeState == true)
            {
                Console.WriteLine("Writing " + "32 (Single byte)" + " as God mode state to ram @ hex adress 0x" + (int.Parse(ToggleGodmodeOffset.ToString(), System.Globalization.NumberStyles.Integer) + 0x0).ToString("X"));
                mreader.WriteMemory((IntPtr)ToggleGodmodeOffset + 0x0, BitConverter.GetBytes(Convert.ToByte(32)), out bytesOut);
                ToggleGodmodeState = false;
            }
            else
            {
                Console.WriteLine("Writing " + "21 (Single byte)" + " as Death state to ram @ hex adress 0x" + (int.Parse(ToggleGodmodeOffset.ToString(), System.Globalization.NumberStyles.Integer) + 0x0).ToString("X"));
                Console.WriteLine("This overwrites the god mdoe state");
                mreader.WriteMemory((IntPtr)ToggleGodmodeOffset + 0x0, BitConverter.GetBytes(Convert.ToByte(21)), out bytesOut);
                ToggleGodmodeState = true;
            }
        }

        //Sets Weapon One ID
        private void SetWeaponOneIDButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Writing " + SetWeaponOneIDNUD.Value + "(Single byte)" + " as Weapon Two ID to ram @ hex adress 0x" + (int.Parse(WeaponOneIDOffset.ToString(), System.Globalization.NumberStyles.Integer) + 0x0).ToString("X"));
            mreader.WriteMemory((IntPtr)WeaponOneIDOffset + 0x0, BitConverter.GetBytes(Convert.ToByte(SetWeaponOneIDNUD.Value)), out bytesOut);
        }

        //Sets Weapon Two ID
        private void SetWaeponTwoIdButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Writing " + SetWeaponTwoIDNUD.Value + "(Single byte)" + " as Weapon Two ID to ram @ hex adress 0x" + (int.Parse(WeaponTwoIDOffset.ToString(), System.Globalization.NumberStyles.Integer) + 0x0).ToString("X"));
            mreader.WriteMemory((IntPtr)WeaponTwoIDOffset + 0x0, BitConverter.GetBytes(Convert.ToByte(SetWeaponTwoIDNUD.Value)), out bytesOut);
        }

        //Sets Weapon Three ID
        private void SetWaeponThreeIdButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Writing " + SetWeaponThreeIDNUD.Value + "(Single byte)" + " as Weapon Three ID to ram @ hex adress 0x" + (int.Parse(WeaponThreeIDOffset.ToString(), System.Globalization.NumberStyles.Integer) + 0x0).ToString("X"));
            mreader.WriteMemory((IntPtr)WeaponThreeIDOffset + 0x0, BitConverter.GetBytes(Convert.ToByte(SetWeaponThreeIDNUD.Value)), out bytesOut);
        }

        //used for manually overwriting data.
        private void ManualDataOverWriteButton_Click(object sender, EventArgs e)
        {
            int ManualOffsetAdr = (int)ManualPointerNUD.Value;
            uint ManualOffset = 0;

            //Calculate Pointsoffset
            ManualOffset = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(BaseAdress + (uint)process.Modules[0].BaseAddress), 4, out bytesOut), 0);
            if (ManualOffsetAdr < 0)
            {
                ManualOffset -= (uint)Math.Abs(ManualOffsetAdr);
            }
            else
            {
                ManualOffset += (uint)ManualOffsetAdr;
            }
            Console.WriteLine("Writing " + ManualOverWriteData.Value + " to ram @ hex adress 0x" + (int.Parse(ManualOffset.ToString(), System.Globalization.NumberStyles.Integer) + 0x0).ToString("X"));
            mreader.WriteMemory((IntPtr)ManualOffset + (int)ManualPointerOffsetNUD.Value, BitConverter.GetBytes(Convert.ToByte(ManualOverWriteData.Value)), out bytesOut);

        }

        private void HotKeyTimer_Tick(object sender, EventArgs e)
        {
            //Rename Window
            mreader.RenameWindow(process, "Call of Duty®: BlackOps | Cl0ck's trainer attached | PID " + process.Id.ToString() + " | Using " + process.Modules.Count + " modules in " + process.PagedMemorySize + " bytes of paged ram");

            //Byte array for the mod below
            byte[] Below = {0x01,0x02,0x20,0x5e,0x35,0x43,0x6c,0x30,0x63,0x6b,0x2c,0x20,0x5e,0x33,0x48,0x61,0x63,0x6b,0x69,0x6e,0x67,0x20,0x5e,0x32,0x74,0x68,0x69,0x73,0x20,0x5e,0x36,0x67,0x61,0x6d,0x65,0x20,0x5e,0x37,0x73,0x69,0x6e,0x63,0x65,0x20,0x5e,0x38,0x32,0x30,0x31,0x31,0x20,0x03,0x04};

            //Modify the "Balck Ops Zombie" message on the tab hud.
            mreader.WriteMemory((IntPtr)0x29D379B0 + 0x0, Below, out bytesOut);

            //Hot Keys
            if (Control.ModifierKeys == (Keys.Control | Keys.Alt))
            {
                ToggleNoclipButton.PerformClick();
            }
            if (Control.ModifierKeys == (Keys.Control | Keys.Shift))
            {
                ToggleGodmodeButton.PerformClick();
            }
            if (Control.ModifierKeys == (Keys.Shift | Keys.Alt))
            {
                //Max everything

                //Max Weapon 1 clip
                Console.WriteLine("Writing " + mreader.ReturnMaxInt32() + " as weapon one clip ammo to ram @ hex adress 0x" + (int.Parse(Pointsoffset.ToString(), System.Globalization.NumberStyles.Integer) - 0x17c8).ToString("X"));
                mreader.WriteMemory((IntPtr)Pointsoffset - 0x17C8, BitConverter.GetBytes(Convert.ToInt32(mreader.ReturnMaxInt32())), out bytesOut);

                //Max Weapon 2 clip
                Console.WriteLine("Writing " + mreader.ReturnMaxInt32() + " as weapon two clip ammo to ram @ hex adress 0x" + (int.Parse(WeaponTwoClipOffset.ToString(), System.Globalization.NumberStyles.Integer) - 0x0).ToString("X"));
                mreader.WriteMemory((IntPtr)WeaponTwoClipOffset + 0x0, BitConverter.GetBytes(Convert.ToInt32(mreader.ReturnMaxInt32())), out bytesOut);

                //Max Weapon 3 clip
                Console.WriteLine("Writing " + mreader.ReturnMaxInt32() + " as weapon three clip ammo to ram @ hex adress 0x" + (int.Parse(WeaponThreeClipOffset.ToString(), System.Globalization.NumberStyles.Integer) - 0x0).ToString("X"));
                mreader.WriteMemory((IntPtr)WeaponThreeClipOffset + 0x0, BitConverter.GetBytes(Convert.ToInt32(mreader.ReturnMaxInt32())), out bytesOut);

                //Sets money to a high number but no max to prevent rolling over into negative numbers
                Console.WriteLine("Writing " + 133700255 + " points to ram @ hex adress 0x" + (int.Parse(Pointsoffset.ToString(), System.Globalization.NumberStyles.Integer) + 0x0).ToString("X"));
                mreader.WriteMemory((IntPtr)Pointsoffset + 0x0, BitConverter.GetBytes(Convert.ToInt32(133700255)), out bytesOut);
            }
        }

        private void ShowAboutFormButton_Click(object sender, EventArgs e)
        {
            Form AbtForm= new AboutForm();
            AbtForm.Show();
        }

        private void HotKeyListButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ctrl + Shift = Toggle God Mode \nCtrl + Alt = Toggle Noclip \nAlt + Shift = Unlimited ammo in all weapons + lots of points", "Hot Key List", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AutoFire_Tick(object sender, EventArgs e)
        {
            int LookingAtZombie = BitConverter.ToInt32(mreader.ReadMemory((IntPtr)IsLookingAtZombieOffset + 0x0,4, out bytesOut), 0);
            Console.WriteLine(LookingAtZombie);
        }

    }
}
