// Joel 'Jaykul' Bennett's original code from
// http://web.archive.org/web/20131124234800/http://huddledmasses.org/clipexe-and-the-missing-pasteexe
using System;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Huddled {
   public class Clip {
      [STAThread]
      static void Main( string[] args )
      {
         string s;
         StringBuilder output = new StringBuilder( string.Join(" ", args) );
         while ((s = Console.ReadLine()) != null)
            output.AppendLine(s);

         Clipboard.SetText( output.ToString() );
      }
   }
}
