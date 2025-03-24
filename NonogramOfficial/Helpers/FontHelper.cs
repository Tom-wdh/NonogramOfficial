using System.Drawing;
using System.Windows.Forms;

namespace NonogramOfficial.Helpers
{
    public static class FontHelper
    {
        public static void ApplyGlobalFont(Control control, string fontName)
        {
            if (control == null || string.IsNullOrEmpty(fontName)) return;

            // Huidige font-grootte behouden
            float currentSize = control.Font.Size;
            control.Font = new Font(fontName, currentSize);

            // Recursief alle child-controls bijwerken
            foreach (Control child in control.Controls)
            {
                ApplyGlobalFont(child, fontName);
            }
        }
    }
}
