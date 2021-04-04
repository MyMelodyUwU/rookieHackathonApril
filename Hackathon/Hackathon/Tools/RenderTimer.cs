using System.Numerics;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Hackathon.Tools
{
    public static class RenderTimer
    {
        public static int maxRadius = 200;

        /// <summary>
        /// Draw a circular progress bar/timer
        /// </summary>
        /// <param name="e">Painter event arguements from paint function</param>
        /// <param name="position">Position to draw timer</param>
        /// <param name="radius">Timer radius/size</param>
        /// <param name="text">The main timer text</param>
        /// <param name="col">Main timer arc color</param>
        /// <param name="bgCol">Background timer arc color</param>
        /// <param name="percent">Completage percent 0-100</param>
        /// <param name="subText">Subtext. Under main text</param>
        /// <param name="width">Arc line width</param>
        /// <param name="fontSize">Main text font size</param>
        /// <param name="subTextFontSize">Sub text font size</param>
        public static void DrawCircularTimer(PaintEventArgs e, Vector2 position, float radius, string text, Color col, Color bgCol, float percent = 100, string subText = "", float width = 10, int fontSize = 32, int subTextFontSize = 24)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Pen arcPen = new Pen(col, width);
            Pen arcBGPen = new Pen(bgCol, width);

            // Create start and sweep angles on ellipse.
            float startAngle = 360 * (percent / 100) - 90;
            float sweepAngle = 270 - startAngle;

            // Draw arc to screen.
            e.Graphics.DrawArc(arcBGPen, position.X - radius, position.Y - radius, radius, radius, 0, 360);
            e.Graphics.DrawArc(arcPen, position.X - radius, position.Y - radius, radius, radius, startAngle, sweepAngle);

            Font textFont = new Font("Arial Black", fontSize);
            Brush textBrush = new SolidBrush(Program.tasktraySettingsInstance.darkMode ? Color.White : Color.Black);

            float newSize = fontSize / (maxRadius / (radius-(width*2)));

            textFont = new Font("Arial Black", newSize);

            float textWidth = e.Graphics.MeasureString(text, textFont).Width;
            float textHeight = e.Graphics.MeasureString(text, textFont).Height;

            e.Graphics.DrawString(text, textFont, textBrush, position.X - (radius / 2) - (textWidth / 2), position.Y - (radius / 2) - (textHeight / 2));

            Brush subTextBrush = new SolidBrush(Program.tasktraySettingsInstance.darkMode ? Color.White : Color.Black);

            float newSubSize = subTextFontSize / (maxRadius / (radius-(width*2.5f)));
            Font subTextFont = new Font("Arial Black", newSubSize);

            float subTextWidth = e.Graphics.MeasureString(subText, subTextFont).Width;
            float subTextHeight = e.Graphics.MeasureString(subText, subTextFont).Height;


            e.Graphics.DrawString(subText, subTextFont, subTextBrush, position.X - (radius / 2) - (subTextWidth / 2), position.Y - (radius / 2) + (textHeight / 2) - (subTextHeight / 2));
        }
    }
}
