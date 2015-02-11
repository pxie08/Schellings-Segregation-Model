/****************************
** q526.cs
** There Goes the Neighborhood
** Patrick Xie, 5/26/2011
****************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace q526
{
    public partial class q526 : Form
    {
        /*Global Variable*/
        private Bitmap myCanvas;
        private Random rand = new Random();
        private int width;
        private int height;
        private int percentBlue;
        private int percentRed;
        private List<Point> redList = new List<Point>();
        private List<Point> blueList = new List<Point>();
        private List<Point> vacantList = new List<Point>();
        private List<Point> terrainList = new List<Point>();
        private int tolerance;
        DoubleBufferPanel DrawingPanel = new DoubleBufferPanel();
        bool mouseDown = false;
        bool addTerrain = false;

        public q526()
        {
            InitializeComponent();
            /*Adds Panel into form for double buffering the panel*/
            DrawingPanel.Parent = this;
            DrawingPanel.Location = new System.Drawing.Point(12, 12);
            DrawingPanel.Size = new System.Drawing.Size(300, 300);
            DrawingPanel.BackColor = System.Drawing.SystemColors.Control;
            DrawingPanel.Paint += new PaintEventHandler(DrawingPanel_Paint);
            DrawingPanel.MouseDown += new MouseEventHandler(DrawingPanel_MouseDown);
            DrawingPanel.MouseMove += new MouseEventHandler(DrawingPanel_MouseMove);
            DrawingPanel.MouseUp += new MouseEventHandler(DrawingPanel_MouseUp);
            this.Controls.Add(DrawingPanel);
            DrawingPanel.Show();
        }

        private void q526_Load(object sender, EventArgs e)
        {
            initialization();
            //Adds tooltip to the panel to tell use can change color
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.terrainColorPanel, "Click to change color.");

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (startButton.Text == "Start")
            {
                tolerance = int.Parse(toleranceTextbox.Text);
                timer1.Start(); //starts the timer
                startButton.Text = "Stop";
            }
            else if (startButton.Text == "Stop")
            {
                timer1.Stop();
                startButton.Text = "Start";
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(myCanvas);
            redList.Clear();
            blueList.Clear();
            vacantList.Clear();
            g.Clear(Color.Black);
            initialization();
            this.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*Goes through the whole panel to update the neighborhoods*/
            checkBox(tolerance, redList, blueList);
            checkBox(tolerance, blueList, redList);
            this.Refresh();
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.InterpolationMode = InterpolationMode.NearestNeighbor;// smooths the blown up pixel
            g.DrawImage(myCanvas, 0, 0, DrawingPanel.Width, DrawingPanel.Height);
        }

        private void terrainButton_Click(object sender, EventArgs e)
        {
            addTerrain = true;
        }

        private void terrainColorPanel_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                terrainColorPanel.BackColor = colorDialog1.Color;
            }
        }

        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
        
        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            /*
             * Adds Terrain that does not move
             *Could not make it not able to move
             */
            if (mouseDown && timer1.Enabled == false && addTerrain)
            {
                int eX = (int)Math.Round((((double)e.X * (double)width) / (double)DrawingPanel.Width));
                int eY = (int)Math.Round((((double)e.Y * (double)height) / (double)DrawingPanel.Height));
                //Checks what color to remove from list; then adds terrain to terrainlist
                if (redList.Contains(new Point(eX,eY)))
                {
                    redList.Remove(new Point(eX, eY));
                }
                else if (blueList.Contains(new Point(eX,eY)))
                {
                    blueList.Remove(new Point(eX, eY));
                }
                else if (vacantList.Contains(new Point(eX,eY)))
                {
                    vacantList.Remove(new Point(eX, eY));
                }
                myCanvas.SetPixel(eX, eY, terrainColorPanel.BackColor);
                terrainList.Add(new Point(eX, eY));
            }
            this.Refresh();
        }

        private void DrawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            addTerrain = false;
        }

        /*Checks each box for tolerance level and moves*/
        private void checkBox (int tol, List<Point> color1List, List<Point> color2List)
        {
            int count = 0;
            for (int i = 0; i < color1List.Count; i++)
            {
                //top left
                if (color2List.Contains(new Point(color1List[i].X - 1, color1List[i].Y - 1)))
                {
                    count++;
                }
                //top
                if (color2List.Contains(new Point(color1List[i].X, color1List[i].Y - 1)))
                {
                    count++;
                }
                //top right
                if (color2List.Contains(new Point(color1List[i].X + 1, color1List[i].Y - 1)))
                {
                    count++;
                }
                //left
                if (color2List.Contains(new Point(color1List[i].X - 1, color1List[i].Y)))
                {
                    count++;
                }
                //right
                if (color2List.Contains(new Point(color1List[i].X + 1, color1List[i].Y)))
                {
                    count++;
                }
                //bottom left
                if (color2List.Contains(new Point(color1List[i].X - 1, color1List[i].Y + 1)))
                {
                    count++;
                }
                //bottom
                if (color2List.Contains(new Point(color1List[i].X, color1List[i].Y + 1)))
                {
                    count++;
                }
                //bottom right
                if (color2List.Contains(new Point(color1List[i].X + 1, color1List[i].Y + 1)))
                {
                    count++;
                }
                if (count >= tolerance)
                {
                    //Sets random white space to have the new color
                    //Deletes white spot from the list
                    //Adds white space to old spot
                    //Remove old color from old spot from list
                    int randVac = rand.Next(0, vacantList.Count);
                    myCanvas.SetPixel(vacantList[randVac].X, vacantList[randVac].Y, myCanvas.GetPixel(color1List[i].X, color1List[i].Y));
                    myCanvas.SetPixel(color1List[i].X, color1List[i].Y, Color.White);
                    vacantList.Add(new Point(color1List[i].X, color1List[i].Y));
                    color1List.RemoveAt(i);
                    color1List.Add(new Point(vacantList[randVac].X, vacantList[randVac].Y));
                    vacantList.RemoveAt(randVac);
                }
                count = 0;
            }
        }
        /********End of Function************/

        /*initializes the panel to the sets set by user*/
        private void initialization()
        {
            width = int.Parse(gridwidthTextbox.Text);
            height = int.Parse(gridheightTextbox.Text);
            percentBlue = int.Parse(perblueTextbox.Text);
            percentRed = int.Parse(perredTextbox.Text);
            tolerance = int.Parse(toleranceTextbox.Text);

            myCanvas = new Bitmap(width, height,
                System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(myCanvas);
            g.Clear(Color.Black);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    int rbw = rand.Next(0, 100);
                    if (rbw < percentRed)
                    {
                        myCanvas.SetPixel(x, y, Color.FromArgb(255, 0, 0));
                        redList.Add(new Point(x, y));
                    }
                    if (rbw >= percentRed && rbw < (percentRed + percentBlue))
                    {
                        myCanvas.SetPixel(x, y, Color.FromArgb(0, 0, 255));
                        blueList.Add(new Point(x, y));
                    }
                    if (rbw >= (percentRed + percentBlue))
                    {
                        myCanvas.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        vacantList.Add(new Point(x, y));
                    }
                }
            }
        }
        /********End of Function************/  
    }

    public class DoubleBufferPanel : Panel
    {
        public DoubleBufferPanel()
        {
            // Set the value of the double-buffering style bits to true.
            // ControlStyles.UserPaint -- allows user to control painting w/o passing off the work to the operating system
            //ControlStyles.AllPaintingInWmPaint--optimize to reduce flicker but only use it if ControlStyles.UserPaint is true
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint, true);// | evaluates all conditions even if condition 1 is true
            this.UpdateStyles();//forces style to be applied
        }
    } 
}