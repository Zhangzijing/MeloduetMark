using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MeloduetMark.UI
{
    public class MeloduetPages : TabControl

    {
        SolidBrush DefaultBrush = new SolidBrush(Color.FromArgb(238, 238, 242));
        SolidBrush MouseEnterBrush = new SolidBrush(Color.FromArgb(28, 151, 234));
        SolidBrush SelectedBrush = new SolidBrush(Color.FromArgb(0, 122, 204));
        public MeloduetPages()
        {
            base.SetStyle(
             ControlStyles.UserPaint |                      // 控件将自行绘制，而不是通过操作系统来绘制  
             ControlStyles.OptimizedDoubleBuffer |          // 该控件首先在缓冲区中绘制，而不是直接绘制到屏幕上，这样可以减少闪烁  
             ControlStyles.AllPaintingInWmPaint |           // 控件将忽略 WM_ERASEBKGND 窗口消息以减少闪烁  
             ControlStyles.ResizeRedraw |                   // 在调整控件大小时重绘控件  
             ControlStyles.SupportsTransparentBackColor,    // 控件接受 alpha 组件小于 255 的 BackColor 以模拟透明  
             true);                                         // 设置以上值为 true  
            base.UpdateStyles();
        }

        int getTabIndexAtPoint(Point pt)
        {
            int tmp = -1;
            Rectangle rect = Rectangle.Empty;

            for (int i = 0; i < TabPages.Count; i++)
            {
                rect = GetTabRect(i);
                if (rect.Contains(pt))
                {
                    tmp = i;
                    break;
                }
            }

            return tmp;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            for (int i = 0; i < this.TabCount; i++)
            {

                if (SelectedIndex == i)
                {
                    e.Graphics.FillRectangle(SelectedBrush, GetTabRect(i));
                }

               
                

                // Calculate text position  
                Rectangle bounds = this.GetTabRect(i);
                PointF textPoint = new PointF();
                SizeF textSize = TextRenderer.MeasureText(this.TabPages[i].Text, this.Font);

                // 注意要加上每个标签的左偏移量X  
                textPoint.X
                    = bounds.X + (bounds.Width - textSize.Width) / 2;
                textPoint.Y
                    = bounds.Bottom - textSize.Height - this.Padding.Y;

                // Draw highlights  

                if (SelectedIndex == i)
                {
                    e.Graphics.DrawString(
                  this.TabPages[i].Text,
                  this.Font,
                  SystemBrushes.ButtonHighlight,    // 高光颜色  
                  textPoint.X,
                  textPoint.Y);
                }
                else
                {
                    
                    e.Graphics.DrawString(
                  this.TabPages[i].Text,
                  this.Font,
                  SystemBrushes.WindowText,    // 高光颜色  
                  textPoint.X,
                  textPoint.Y);
                }
              

                

            }
        }
    }
}
