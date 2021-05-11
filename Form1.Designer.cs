
namespace LogicalSchemeInterpretor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanelBlocks = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBoxConsole = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanelVariables = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelDrawing = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelBlocks.SuspendLayout();
            this.panelDrawing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelBlocks
            // 
            this.flowLayoutPanelBlocks.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanelBlocks.Controls.Add(this.panel5);
            this.flowLayoutPanelBlocks.Controls.Add(this.panel1);
            this.flowLayoutPanelBlocks.Controls.Add(this.panel2);
            this.flowLayoutPanelBlocks.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelBlocks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelBlocks.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelBlocks.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelBlocks.Name = "flowLayoutPanelBlocks";
            this.flowLayoutPanelBlocks.Size = new System.Drawing.Size(310, 935);
            this.flowLayoutPanelBlocks.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Brown;
            this.panel5.Location = new System.Drawing.Point(15, 15);
            this.panel5.Margin = new System.Windows.Forms.Padding(15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(283, 144);
            this.panel5.TabIndex = 1;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyControl_MouseDown);
            this.panel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MyControl_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Location = new System.Drawing.Point(15, 189);
            this.panel1.Margin = new System.Windows.Forms.Padding(15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 144);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyControl_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MyControl_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Location = new System.Drawing.Point(15, 363);
            this.panel2.Margin = new System.Windows.Forms.Padding(15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 144);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyControl_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MyControl_MouseMove);
            // 
            // richTextBoxConsole
            // 
            this.richTextBoxConsole.BackColor = System.Drawing.Color.LightGray;
            this.richTextBoxConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxConsole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxConsole.ForeColor = System.Drawing.Color.Navy;
            this.richTextBoxConsole.Location = new System.Drawing.Point(310, 745);
            this.richTextBoxConsole.Margin = new System.Windows.Forms.Padding(10);
            this.richTextBoxConsole.Name = "richTextBoxConsole";
            this.richTextBoxConsole.Size = new System.Drawing.Size(1414, 190);
            this.richTextBoxConsole.TabIndex = 1;
            this.richTextBoxConsole.Text = "";
            // 
            // flowLayoutPanelVariables
            // 
            this.flowLayoutPanelVariables.BackColor = System.Drawing.Color.DarkGray;
            this.flowLayoutPanelVariables.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelVariables.Location = new System.Drawing.Point(1427, 0);
            this.flowLayoutPanelVariables.Name = "flowLayoutPanelVariables";
            this.flowLayoutPanelVariables.Size = new System.Drawing.Size(297, 745);
            this.flowLayoutPanelVariables.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Brown;
            this.panel3.Location = new System.Drawing.Point(95, 72);
            this.panel3.Margin = new System.Windows.Forms.Padding(15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 144);
            this.panel3.TabIndex = 1;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyControl_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MyControl_MouseMove);
            // 
            // panelDrawing
            // 
            this.panelDrawing.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panelDrawing.Controls.Add(this.panel3);
            this.panelDrawing.Controls.Add(this.pictureBox1);
            this.panelDrawing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDrawing.Location = new System.Drawing.Point(310, 0);
            this.panelDrawing.Name = "panelDrawing";
            this.panelDrawing.Size = new System.Drawing.Size(1117, 745);
            this.panelDrawing.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1117, 745);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1724, 935);
            this.Controls.Add(this.panelDrawing);
            this.Controls.Add(this.flowLayoutPanelVariables);
            this.Controls.Add(this.richTextBoxConsole);
            this.Controls.Add(this.flowLayoutPanelBlocks);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " ";
            this.flowLayoutPanelBlocks.ResumeLayout(false);
            this.panelDrawing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBlocks;
        private System.Windows.Forms.RichTextBox richTextBoxConsole;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelVariables;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelDrawing;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

