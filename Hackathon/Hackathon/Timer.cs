using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

public static class Timer
{
    public static void DrawCircularTimer(PaintEventArgs e, Vector2 position, float radius, string text, Color col, float percent = 100, string subText="", float width=10, int fontSize= 16, int subTextFontSize=12)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        Pen arcPen = new Pen(col, width);

        // Create start and sweep angles on ellipse.
        float startAngle = 360 * (percent / 100) - 90;
        float sweepAngle = 270 - startAngle;

        // Draw arc to screen.
        e.Graphics.DrawArc(arcPen, position.X - radius, position.Y - radius, radius, radius, startAngle, sweepAngle);

        Font textFont = new Font("Arial Black", fontSize);
        Brush textBrush = new SolidBrush(Color.White);

        float textWidth = e.Graphics.MeasureString(text, textFont).Width;
        float textHeight = e.Graphics.MeasureString(text, textFont).Height;
        e.Graphics.DrawString(text, textFont, textBrush, position.X - (radius / 2) - (textWidth / 2), position.Y - (radius / 2) - (textHeight / 2));

        Font subTextFont = new Font("Arial Black", subTextFontSize);
        Brush subTextBrush = new SolidBrush(Color.White);

        float subTextWidth = e.Graphics.MeasureString(subText, subTextFont).Width;
        float subTextHeight = e.Graphics.MeasureString(subText, subTextFont).Height;
        e.Graphics.DrawString(subText, subTextFont, subTextBrush, position.X - (radius / 2) - (subTextWidth / 2), position.Y - (radius / 2) + (textHeight / 2) - (subTextHeight/2));
    }
}
