public class NonogramCell : Panel
{
    public bool IsFilled { get; set; }
    public bool IsMarked { get; set; }

    public NonogramCell()
    {
        this.DoubleBuffered = true;
        this.Margin = new Padding(0);
        this.Padding = new Padding(0);
        this.BackColor = Color.White;
        this.BorderStyle = BorderStyle.FixedSingle;
        this.MouseDown += NonogramCell_MouseDown;
    }

    private void NonogramCell_MouseDown(object? sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            IsFilled = !IsFilled;
            IsMarked = false;
        }
        else if (e.Button == MouseButtons.Right)
        {
            IsMarked = !IsMarked;
            IsFilled = false;
        }
        this.Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        if (IsFilled)
        {
            e.Graphics.FillRectangle(Brushes.Black, this.ClientRectangle);
        }
        else if (IsMarked)
        {
            e.Graphics.DrawString("X", this.Font, Brushes.Black, this.ClientRectangle, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
        }
    }
}
