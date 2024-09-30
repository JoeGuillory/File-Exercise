using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Exercises
{
    internal class Game
    {

        public void Run()
        {
            TextIO text = new TextIO();
            text.Run();

            SerializeIO serialize = new SerializeIO();
            serialize.Run();
        }
    }
}
