using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Minecraft_Multiple_Command_Combiner
{
    public partial class Form1 : Form
    {
        string[] versionsList = {"1.16.x - 1.14.x","1.13.x","1.12.x - 1.11.x", "1.10.x - 1.9.x","1.8.x"};
        public Form1()
        {
            InitializeComponent();
            
        }
        string getCustomCommand(string id, string command, int type)
        {
            switch (type)
            {
                case 1:
                    return "{id:" + id + ",Command:\"" + command + "\"},";
                    break;
                case 2:
                    return "Time:1,Riding:{id:FallingSand,Block:"+id+",TileEntityData:{Command:"+command+"},";
                    break;
            }
            return "";
        }
        
        string getCompiledCommand(string version)
        {
            var lines = this.richTextBoxCommandInput.Text.Split('\n').ToList();
            var customCommands = "";
            bool DestroyAfterEx = checkBoxDestroyAEx.Checked;
            switch (version)
            {
                case "1.16.x - 1.14.x":
                    customCommands = "summon falling_block ~ ~1 ~ {Time:1,BlockState:{Name:redstone_block},Passengers:[{id:armor_stand,Health:0,Passengers:[{id:falling_block,Time:1,BlockState:{Name:activator_rail},Passengers:[";
                    customCommands = customCommands + getCustomCommand("command_block_minecart", "data merge block ~ ~-2 ~ {auto:0}",1);
                    foreach (var line in lines)
                    {
                        customCommands = customCommands + getCustomCommand("command_block_minecart", line,1);
                    }
                    if (DestroyAfterEx)
                    {
                        customCommands = customCommands + getCustomCommand("command_block_minecart", @"setblock ~ ~1 ~ command_block{auto:1,Command:"+ @"\" + "\"fill ~ ~ ~ ~ ~-2 ~ air" + @"\" + "\"}",1);
                        customCommands = customCommands + getCustomCommand("command_block_minecart", "kill @e[type=command_block_minecart,distance=..1]", 1);
                    }
                    customCommands = customCommands.Remove(customCommands.Length - 1, 1); // remove the last ","
                    customCommands = customCommands + "]}]}]}";
                    return customCommands;
                    break;
                case "1.13.x":
                    customCommands = "summon falling_block ~ ~1 ~ {BlockState:{Name:stone},Time:1,Passengers:[{id:falling_block,BlockState:{Name:redstone_block},Time:1,Passengers:[{id:falling_block,BlockState:{Name:activator_rail},Time:1,Passengers:[";
                    foreach (var line in lines)
                    {
                        customCommands = customCommands + getCustomCommand("command_block_minecart", line,1);
                    }
                    if (DestroyAfterEx)
                    {
                        customCommands = customCommands + getCustomCommand("command_block_minecart", @"setblock ~ ~ ~1 command_block{Command:" + @"\" + "\"fill ~ ~-3 ~-1 ~ ~ ~ air" + @"\" + "\"}",1);
                        customCommands = customCommands + getCustomCommand("command_block_minecart", "setblock ~ ~-1 ~1 redstone_block",1);                    customCommands = customCommands + getCustomCommand("command_block_minecart", "kill @e[type=command_block_minecart,distance=..1]",1);
                        customCommands = customCommands + getCustomCommand("command_block_minecart", "kill @e[type=command_block_minecart,distance=..1]", 1);
                    }
                    customCommands = customCommands.Remove(customCommands.Length - 1, 1); // remove the last ","
                    customCommands = customCommands + "]}]}]}";
                    return customCommands;
                    break;
                case "1.12.x - 1.11.x":
                    customCommands = "summon falling_block ~ ~1 ~ {Block:stone,Time:1,Passengers:[{id:falling_block,Block:redstone_block,Time:1,Passengers:[{id:falling_block,Block:activator_rail,Time:1,Passengers:[";
                    foreach (var line in lines)
                    {
                        customCommands = customCommands + getCustomCommand("commandblock_minecart", line,1);
                    }
                    if (DestroyAfterEx)
                    {
                        customCommands = customCommands + getCustomCommand("commandblock_minecart", @"setblock ~ ~ ~1 command_block 0 0 {Command:" + @"\" + "\"fill ~ ~-3 ~-1 ~ ~ ~ air" + @"\" + "\"}",1);
                        customCommands = customCommands + getCustomCommand("commandblock_minecart", "setblock ~ ~-1 ~1 redstone_block",1);
                        customCommands = customCommands + getCustomCommand("commandblock_minecart", "kill @e[type=commandblock_minecart,r=1]", 1);
                    }
                    customCommands = customCommands.Remove(customCommands.Length - 1, 1); // remove the last ","
                    customCommands = customCommands + "]}]}]}";
                    return customCommands;
                    break;

                case "1.10.x - 1.9.x":
                    customCommands = "summon FallingSand ~ ~1 ~ {Block:stone,Time:1,Passengers:[{id:FallingSand,Block:redstone_block,Time:1,Passengers:[{id:FallingSand,Block:activator_rail,Time:1,Passengers:[";
                    foreach (var line in lines)
                    {
                        customCommands = customCommands + getCustomCommand("MinecartCommandBlock", line,1);
                    }
                    if (DestroyAfterEx)
                    {
                        customCommands = customCommands + getCustomCommand("MinecartCommandBlock", @"setblock ~ ~ ~1 command_block 0 0 {Command:" + @"\" + "\"fill ~ ~-3 ~-1 ~ ~ ~ air" + @"\" + "\"}",1);
                        customCommands = customCommands + getCustomCommand("MinecartCommandBlock", "setblock ~ ~-1 ~1 redstone_block",1);
                        customCommands = customCommands + getCustomCommand("MinecartCommandBlock", "kill @e[type=MinecartCommandBlock,r=1]", 1);
                    }
                    customCommands = customCommands.Remove(customCommands.Length - 1, 1); // remove the last ","
                    customCommands = customCommands + "]}]}]}";
                    return customCommands;
                    break;
                case "1.8.x":
                    customCommands = "summon FallingSand ~ ~1 ~ {Block:redstone_block,";
                    int num = 3 + lines.Count;
                    customCommands = customCommands + getCustomCommand("command_block", "fill ~ ~0 ~1 ~ ~-"+ num + " ~1 redstone_block", 2);
                    customCommands = customCommands + getCustomCommand("command_block", "setblock ~ ~3 ~1 stone", 2);
                    if (DestroyAfterEx)
                    {
                        num = 7 + lines.Count;
                        customCommands = customCommands + getCustomCommand("command_block", "setblock ~ ~4 ~ command_block 0 replace {Command:fill ~ ~2 ~ ~ ~-" + num + " ~1 air}", 2);
                        num = 1;
                    }
                    else
                    {
                        num = 0;
                    }
                    foreach (var line in lines)
                    {
                        customCommands = customCommands + getCustomCommand("command_block", line,2);
                    }

                    customCommands = customCommands + "Time:1,Riding:{id:FallingSand,Block:stone,Time:1}";
                    for (int i = 0; i < 3 + lines.Count + num; i++)
                    {
                        customCommands = customCommands + "}";
                    }
                    return customCommands;
                    break;
            }
            return "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string version in versionsList)
            {
                comboBoxVersion.Items.Add(version);
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (comboBoxVersion.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a version", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                richTextBoxCommandOutput.Text = getCompiledCommand(comboBoxVersion.Text);
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (richTextBoxCommandOutput.Text.Length >= 1)
            {
                Clipboard.SetText(richTextBoxCommandOutput.Text);
                MessageBox.Show("Command copied !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonLoadInput_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var fileStream = openFileDialog1.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    richTextBoxCommandInput.Text = reader.ReadToEnd();
                }
            }
        }

        private void buttonSaveInput_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = saveFileDialog1.OpenFile();
                StreamWriter sw = new StreamWriter(fileStream);

                sw.Write(richTextBoxCommandInput.Text);

                sw.Close();
                fileStream.Close();
            }
        }

        private void buttonSaveOutput_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = saveFileDialog1.OpenFile();
                StreamWriter sw = new StreamWriter(fileStream);

                sw.Write(richTextBoxCommandOutput.Text);

                sw.Close();
                fileStream.Close();
            }
        }

        private void linkLabelGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Med367367/Minecraft-Multiple-Command-Combiner");
        }
    }
}
