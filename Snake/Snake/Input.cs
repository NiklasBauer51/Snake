using System.Collections;
using System.Windows.Forms;

namespace Snake
{
    internal class Input
    {
        // Liste der verfügbaren Tastaturtasten laden
        private static Hashtable keyTable = new Hashtable();

        //Check, ob eine bestimmte Taste gedrückt wird.   
        public static bool KeyPressed(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
            }

            return (bool)keyTable[key];
        }

        // Erkennung, ob eine Tastaturtaste gedrückt wird
        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
