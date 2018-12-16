// Inspired by Joel 'Jaykul' Bennett's original code from
// http://web.archive.org/web/20131124234800/http://huddledmasses.org/clipexe-and-the-missing-pasteexe
using System;
using System.IO;
using System.Windows.Forms;

namespace Huddled {
   public class Clip {
      [STAThread]
      static void Main( string[] args )
      {
         string s = string.Join(" ", args);
         if (Console.IsInputRedirected) {
            using (StreamReader reader = new StreamReader(Console.OpenStandardInput(), Console.InputEncoding))
            {
               s += reader.ReadToEnd();
            }
         }
         if( s != "" ) {
            Clipboard.SetText( s );
            Console.Write( s );
         }
         else
            Clipboard.Clear();
      }
   }
}
