
namespace System.Windows
{
    internal class Forms
    {
        public static object DialogResult { get; internal set; }

        internal class ColorDialog
        {
            public ColorDialog()
            {
            }

            public object Color { get; internal set; }

            internal object ShowDialog()
            {
                throw new NotImplementedException();
            }
        }
    }
}