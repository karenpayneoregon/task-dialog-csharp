using System.ComponentModel;
using System.Windows.Forms;

namespace WinFormsExamples.Classes
{
    public class SomeLabel : Label
    {
        [DefaultValue("")]
        public override string Text
        {
            get => base.Text;
            set
            {
                base.Text = DesignMode ? "..." : value;
                Invalidate();
            }
        }
    }
}
