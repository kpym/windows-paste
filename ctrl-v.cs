// Inspired by Joel 'Jaykul' Bennett's original code from
// http://web.archive.org/web/20131124234800/http://huddledmasses.org/clipexe-and-the-missing-pasteexe
using System;
using System.Windows.Forms;

namespace Huddled {
   public class Paste {
      [STAThread]
      static void Main( string[] args )
      {
         Console.Write( Clipboard.GetText() );
      }
   }
}
