using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModListTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> _modList = new List<string>();
        private List<string> _unloadedMods = new List<string>();

        private bool _isPathValid = false;

        private void CheckPath()
        {
            if (Directory.GetCurrentDirectory().Contains("mods"))
            {
                Properties.Settings.Default.ModPath = Directory.GetCurrentDirectory();
                Properties.Settings.Default.Save();
            }

            if (Properties.Settings.Default.ModPath == null ^ !Properties.Settings.Default.ModPath.Contains("mods"))
            {
                DialogResult result = MessageBox.Show("Folder isn't set or not found!\n\nPlease select mods folder inside your Darktide folder!", "Missing folder", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    folderBrowserDialog1.ShowDialog();

                    if (folderBrowserDialog1.SelectedPath.Contains("mods"))
                    {
                        Properties.Settings.Default.ModPath = folderBrowserDialog1.SelectedPath;
                        Properties.Settings.Default.Save();

                        _isPathValid = true;
                        textPath.Text = Properties.Settings.Default.ModPath;
                        ReadModList();
                    }
                    else
                    {
                        MessageBox.Show("Chosen folder doesn't contain mods folder or action was canceled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                _isPathValid = true;
                textPath.Text = Properties.Settings.Default.ModPath;
                ReadModList();
            }
        }

        private void ListCreatedInfo()
        {
            DialogResult result = MessageBox.Show("List successfully created!\n\nClose this window?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void UpdateCounters()
        {
            textCounter.Text = listBox1.Items.Count.ToString();
            textBox1.Text = listBox2.Items.Count.ToString();
        }

        private void ToolTips()
        {
            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(this.button1, "Enable all mods and create list");
            toolTip.SetToolTip(this.button5, "Create list with only 'Active' mods enabled");
            toolTip.SetToolTip(this.button6, "Select Folder");
            toolTip.SetToolTip(this.button10, "Open Selected Folder");
        }

        private void ReadModList()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            if (_isPathValid)
            {
                if (File.Exists(Properties.Settings.Default.ModPath + "\\mod_load_order.txt"))
                {
                    using (StreamReader sr = new StreamReader(Properties.Settings.Default.ModPath + "\\mod_load_order.txt"))
                    {
                        string line = sr.ReadLine();

                        while (line != null)
                        {
                            _modList.Add(line);
                            line = sr.ReadLine();
                        }
                        sr.Close();
                    }
                    listBox1.Items.AddRange(_modList.ToArray());
                }

                string[] dir = Directory.GetDirectories(Properties.Settings.Default.ModPath);
                foreach (string item in dir)
                {
                    _unloadedMods.Add(Path.GetFileNameWithoutExtension(item));
                }

                for (int i = 0; i < _unloadedMods.Count; i++)
                {
                    if (_unloadedMods[i] == "base" ^ _unloadedMods[i] == "dmf")
                    {
                        _unloadedMods.RemoveAt(i);
                    }
                }

                IEnumerable<string> diffList = _unloadedMods.Except(_modList);
                IEnumerable<string> removedModList = _modList.Except(_unloadedMods);

                if (removedModList.Count() > 1)
                {
                    string _list = "";

                    foreach (string item in removedModList)
                    {
                        _list += ("- " + item + "\n");
                    }

                    MessageBox.Show($"{removedModList.Count()} mods is missing\n\nThis mods has been removed from the list\n{_list}", "Mod list mismatch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                foreach (var item in removedModList)
                {
                    listBox1.Items.Remove(item);
                }


                listBox2.Items.AddRange(diffList.ToArray());
                UpdateCounters();

                _modList.Clear();
                _unloadedMods.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTips();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            CheckPath();
        }

        private void QuickList(object sender, EventArgs e)
        {
            CheckPath();

            if (_isPathValid)
            {
                listBox1.Items.AddRange(listBox2.Items);
                listBox2.Items.Clear();
                UpdateCounters();

                using (StreamWriter sw = new StreamWriter(Properties.Settings.Default.ModPath + "\\mod_load_order.txt"))
                {
                    foreach (var item in listBox1.Items)
                    {
                        sw.WriteLine(item);
                    }
                    sw.Close();
                }
                ListCreatedInfo();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(Properties.Settings.Default.ModPath + "\\mod_load_order.txt"))
            {
                foreach (var item in listBox1.Items)
                {
                    sw.WriteLine(item);
                }
                sw.Close();
            }
            ListCreatedInfo();
        }

        private void EnableAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            textCounter.Text = listBox1.Items.Count.ToString();

            listBox2.Items.Clear();
            textBox1.Text = listBox2.Items.Count.ToString();
        }

        private void DisableAll_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            textBox1.Text = listBox2.Items.Count.ToString();

            listBox1.Items.Clear();
            textCounter.Text = listBox1.Items.Count.ToString();
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            foreach (var item in listBox1.Items)
            {
                list.Add(item.ToString());
            }

            list.Sort();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(list.ToArray());
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                button1.DoDragDrop(listBox1.SelectedItem, DragDropEffects.Copy | DragDropEffects.Move);
            }
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (!listBox1.Items.Contains(e.Data.GetData(DataFormats.StringFormat).ToString()))
            {
                listBox1.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
                listBox2.Items.Remove(e.Data.GetData(DataFormats.StringFormat).ToString());
            }

            textBox1.Text = listBox2.Items.Count.ToString();
            textCounter.Text = listBox1.Items.Count.ToString();
        }

        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                button1.DoDragDrop(listBox2.SelectedItem, DragDropEffects.Copy | DragDropEffects.Move);
            }
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            if (!listBox2.Items.Contains(e.Data.GetData(DataFormats.StringFormat).ToString()))
            {
                listBox2.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
                listBox1.Items.Remove(e.Data.GetData(DataFormats.StringFormat).ToString());
            }

            textBox1.Text = listBox2.Items.Count.ToString();
            textCounter.Text = listBox1.Items.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.nexusmods.com/users/20910939");
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.nexusmods.com/warhammer40kdarktide/mods/76");
        }

        private void SelectFolder(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath.Contains("mods"))
            {
                Properties.Settings.Default.ModPath = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();

                _isPathValid = true;
                textPath.Text = Properties.Settings.Default.ModPath;
                ReadModList();
            }
            else
            {
                MessageBox.Show("Chosen folder doesn't contain mods folder or action was canceled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1)
            {
                return;
            }

            Graphics g = e.Graphics;
            e.DrawBackground();

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                g.FillRectangle(new SolidBrush(Color.FromArgb(50, 50, 50)), e.Bounds);
                g.DrawString(listBox1.Items[e.Index].ToString(), e.Font, new SolidBrush(Color.White), new PointF(e.Bounds.X, e.Bounds.Y));
            }
            else
            {
                if ((e.Index % 2) == 0)
                {
                    g.FillRectangle(new SolidBrush(Color.FromArgb(172, 234, 255)), e.Bounds);
                }
                else
                {
                    g.FillRectangle(new SolidBrush(Color.FromArgb(91, 221, 255)), e.Bounds);
                }
                g.DrawString(listBox1.Items[e.Index].ToString(), e.Font, new SolidBrush(Color.Black), new PointF(e.Bounds.X, e.Bounds.Y));
            }

            e.DrawFocusRectangle();
        }

        private void listBox2_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1)
            {
                return;
            }

            e.DrawBackground();
            Graphics g = e.Graphics;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                g.FillRectangle(new SolidBrush(Color.FromArgb(50, 50, 50)), e.Bounds);
                g.DrawString(listBox2.Items[e.Index].ToString(), e.Font, new SolidBrush(Color.White), new PointF(e.Bounds.X, e.Bounds.Y));
            }
            else
            {
                if ((e.Index % 2) == 0)
                {
                    g.FillRectangle(new SolidBrush(Color.FromArgb(255, 194, 192)), e.Bounds);
                }
                else
                {
                    g.FillRectangle(new SolidBrush(Color.FromArgb(255, 148, 144)), e.Bounds);
                }
                g.DrawString(listBox2.Items[e.Index].ToString(), e.Font, new SolidBrush(Color.Black), new PointF(e.Bounds.X, e.Bounds.Y));
            }

            e.DrawFocusRectangle();
        }

        private void BTopUp_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                var selectedItem = listBox1.SelectedItem;

                listBox1.Items.Remove(selectedItem);
                listBox1.Items.Insert(0, selectedItem);
                listBox1.SetSelected(0, true);
            }
        }

        private void BUp_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                var selectedItem = listBox1.SelectedItem;
                var selectedIndex = listBox1.SelectedIndex;

                if (selectedIndex > 0)
                {
                    listBox1.Items.Remove(selectedItem);
                    listBox1.Items.Insert(selectedIndex - 1, selectedItem);
                    listBox1.SetSelected(selectedIndex - 1, true);
                }
            }
        }

        private void BBottomDown_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                var selectedItem = listBox1.SelectedItem;
                var endOfList = listBox1.Items.Count;

                listBox1.Items.Remove(selectedItem);
                listBox1.Items.Insert(endOfList - 1, selectedItem);
                listBox1.SetSelected(endOfList - 1, true);
            }
        }

        private void BDown_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                var selectedItem = listBox1.SelectedItem;
                var selectedIndex = listBox1.SelectedIndex;
                var endOfList = listBox1.Items.Count;

                if (selectedIndex < endOfList - 1)
                {
                    listBox1.Items.Remove(selectedItem);
                    listBox1.Items.Insert(selectedIndex + 1, selectedItem);
                    listBox1.SetSelected(selectedIndex + 1, true);
                }
            }
        }

        private void MoveRight(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                var selectedItem = listBox2.SelectedItem;
                var selectedIndex = listBox2.SelectedIndex;
                var listCount = listBox2.Items.Count;

                listBox1.Items.Add(selectedItem);
                listBox2.Items.Remove(selectedItem);

                if (listCount > selectedIndex + 1)
                {
                    listBox2.SetSelected(selectedIndex, true);
                }
                else if (listCount > 1)
                {
                    listBox2.SetSelected(selectedIndex - 1, true);
                }
            }
        }

        private void MoveLeft(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                var selectedItem = listBox1.SelectedItem;
                var selectedIndex = listBox1.SelectedIndex;
                var listCount = listBox1.Items.Count;

                listBox2.Items.Add(selectedItem);
                listBox1.Items.Remove(selectedItem);

                if (listCount > selectedIndex + 1)
                {
                    listBox1.SetSelected(selectedIndex, true);
                }
                else if (listCount > 1)
                {
                    listBox1.SetSelected(selectedIndex - 1, true);
                }
            }
        }

        private void FolderLocButton(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ModPath != null)
            {
                Process.Start(Properties.Settings.Default.ModPath);
            }
        }


    }
}