using System;
using System.Windows.Forms;

namespace Proje
{
    class Kontrol
    {

        public static bool BosDegerKontrol(params TextBox[] texts)
        {

            foreach ( TextBox item in texts)
            {
                if (String.IsNullOrEmpty(item.Text) || String.IsNullOrWhiteSpace(item.Text) || item.Text.Length<1)
                {
                    return false;
                }
            }
            return true;


        }

        public static void TextBoxTemizle(params TextBox[] texts)
        {
            foreach (TextBox item in texts)
            {
                item.Clear();
            }

        }


    }
}
