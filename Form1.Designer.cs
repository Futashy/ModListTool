namespace ModListTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.BDown = new System.Windows.Forms.Button();
            this.BBottomDown = new System.Windows.Forms.Button();
            this.BUp = new System.Windows.Forms.Button();
            this.BTopUp = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textPath = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textCounter = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(120, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 102);
            this.button1.TabIndex = 0;
            this.button1.Text = "  Quick    List";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.QuickList);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Locate \'mods\' folder inside your Darkide folder";
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            this.folderBrowserDialog1.Tag = "folder";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(96, 3);
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(455, 547);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.linkLabel2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(447, 521);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::ModListTool.Properties.Resources.filesnodeicon;
            this.button6.Location = new System.Drawing.Point(406, 483);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 32);
            this.button6.TabIndex = 11;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.SelectFolder);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(120, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 59);
            this.button2.TabIndex = 8;
            this.button2.Text = "Options";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(6, 483);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(45, 14);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Autor";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(6, 501);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(76, 14);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "NEXUSMODS";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.BDown);
            this.tabPage2.Controls.Add(this.BBottomDown);
            this.tabPage2.Controls.Add(this.BUp);
            this.tabPage2.Controls.Add(this.BTopUp);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.textPath);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(447, 521);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Image = global::ModListTool.Properties.Resources.foldericon;
            this.button10.Location = new System.Drawing.Point(425, 7);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.button10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button10.Size = new System.Drawing.Size(20, 20);
            this.button10.TabIndex = 17;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.FolderLocButton);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(170, 204);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(51, 51);
            this.button9.TabIndex = 16;
            this.button9.Text = "<";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.MoveLeft);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(226, 204);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(51, 51);
            this.button8.TabIndex = 15;
            this.button8.Text = ">";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.MoveRight);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(170, 90);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 25);
            this.button7.TabIndex = 14;
            this.button7.Text = "Disable All";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.DisableAll_Click);
            // 
            // BDown
            // 
            this.BDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDown.Location = new System.Drawing.Point(170, 318);
            this.BDown.Name = "BDown";
            this.BDown.Size = new System.Drawing.Size(51, 51);
            this.BDown.TabIndex = 13;
            this.BDown.Text = "↓";
            this.BDown.UseVisualStyleBackColor = false;
            this.BDown.Click += new System.EventHandler(this.BDown_Click);
            // 
            // BBottomDown
            // 
            this.BBottomDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BBottomDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBottomDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBottomDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBottomDown.Location = new System.Drawing.Point(226, 318);
            this.BBottomDown.Name = "BBottomDown";
            this.BBottomDown.Size = new System.Drawing.Size(51, 51);
            this.BBottomDown.TabIndex = 12;
            this.BBottomDown.Text = "↓↓";
            this.BBottomDown.UseVisualStyleBackColor = false;
            this.BBottomDown.Click += new System.EventHandler(this.BBottomDown_Click);
            // 
            // BUp
            // 
            this.BUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUp.Location = new System.Drawing.Point(170, 261);
            this.BUp.Name = "BUp";
            this.BUp.Size = new System.Drawing.Size(51, 51);
            this.BUp.TabIndex = 11;
            this.BUp.Text = "↑";
            this.BUp.UseVisualStyleBackColor = false;
            this.BUp.Click += new System.EventHandler(this.BUp_Click);
            // 
            // BTopUp
            // 
            this.BTopUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTopUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTopUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTopUp.Location = new System.Drawing.Point(227, 261);
            this.BTopUp.Name = "BTopUp";
            this.BTopUp.Size = new System.Drawing.Size(51, 51);
            this.BTopUp.TabIndex = 10;
            this.BTopUp.Text = "↑↑";
            this.BTopUp.UseVisualStyleBackColor = false;
            this.BTopUp.Click += new System.EventHandler(this.BTopUp_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(170, 460);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 56);
            this.button5.TabIndex = 7;
            this.button5.Text = "Create List";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(170, 59);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 25);
            this.button4.TabIndex = 5;
            this.button4.Text = "Enable All";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.EnableAll_Click);
            // 
            // listBox2
            // 
            this.listBox2.AllowDrop = true;
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(3, 59);
            this.listBox2.Name = "listBox2";
            this.listBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox2.Size = new System.Drawing.Size(161, 457);
            this.listBox2.Sorted = true;
            this.listBox2.TabIndex = 4;
            this.listBox2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox2_DrawItem);
            this.listBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox2_DragDrop);
            this.listBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox2_DragEnter);
            this.listBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseDown);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(170, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 25);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sort";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Sort_Click);
            // 
            // textPath
            // 
            this.textPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPath.Cursor = System.Windows.Forms.Cursors.Default;
            this.textPath.Location = new System.Drawing.Point(2, 7);
            this.textPath.Name = "textPath";
            this.textPath.ReadOnly = true;
            this.textPath.Size = new System.Drawing.Size(421, 20);
            this.textPath.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(283, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(161, 457);
            this.listBox1.TabIndex = 0;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 36);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inactive";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(139, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(16, 13);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.textCounter);
            this.groupBox2.Location = new System.Drawing.Point(283, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(161, 36);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Active";
            // 
            // textCounter
            // 
            this.textCounter.BackColor = System.Drawing.SystemColors.Control;
            this.textCounter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCounter.Cursor = System.Windows.Forms.Cursors.Default;
            this.textCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCounter.Location = new System.Drawing.Point(6, 0);
            this.textCounter.Name = "textCounter";
            this.textCounter.ReadOnly = true;
            this.textCounter.Size = new System.Drawing.Size(16, 13);
            this.textCounter.TabIndex = 1;
            this.textCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(455, 547);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "DARKTIDE MOD SORTING TOOL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.TextBox textCounter;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button BDown;
        private System.Windows.Forms.Button BBottomDown;
        private System.Windows.Forms.Button BUp;
        private System.Windows.Forms.Button BTopUp;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
    }
}

