// Inspired by Joel 'Jaykul' Bennett's original code from
// http://web.archive.org/web/20131124234800/http://huddledmasses.org/clipexe-and-the-missing-pasteexe
using System;
using System.Text;
using System.Windows.Forms;

namespace Huddled {
   public class Clip {
      [STAThread]
      static void Main( string[] args )
      {
         string s; // the temps string
         uint nLines = 0; // the number of lines
         StringBuilder output = new StringBuilder( string.Join(" ", args) );
         if (Console.IsInputRedirected) {
            while ((s = Console.ReadLine()) != null) {
               output.AppendLine( s );
               nLines++;
            }
         }
         s = output.ToString();
         if ( nLines == 1 ) // if single line, remove \n\r
            s = s.TrimEnd( '\r', '\n' );
         if( s != "" ) { // copy to clipboard or clear ?
            Clipboard.SetText( s );
            Console.Write( s );
         }
         else
            Clipboard.Clear();
      }
   }
}
