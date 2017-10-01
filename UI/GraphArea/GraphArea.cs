using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.GraphArea
{
    public partial class GraphArea : UserControl
    {
        public GraphArea()
        {
            InitializeComponent();
        }

        private void AddOperationClick(object sender, EventArgs e)
        {
            using (var g = this.CreateGraphics())
            {

                var mouseCoord = this.PointToClient(Cursor.Position);

                var blackPen = new Pen(Color.Black, 3);
                var rect = new Rectangle(mouseCoord, new Size(200, 50));
                g.DrawRectangle(blackPen, rect);

                blackPen.Dispose();
            }

        }
    }
}
