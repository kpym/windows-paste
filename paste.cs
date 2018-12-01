// Joel 'Jaykul' Bennett's original code from
// http://web.archive.org/web/20131124234800/http://huddledmasses.org/clipexe-and-the-missing-pasteexe
using System;
using System.Windows.Forms;
using System.Threading;

namespace Huddled {
   public class Paste {
      [STAThread]
      static void Main( string[] args )
      {
         foreach(string line in Clipboard.GetText().Split(
                                 new string[]{"\r\n","\n"},
                                 StringSplitOptions.None ))
            Console.WriteLine( line );
      }
   }
}
