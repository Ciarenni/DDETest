using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Pipes;

namespace DDETest
{
    class NamedPipeServer
    {

        NamedPipeServerStream server = new NamedPipeServerStream("OrbitronPipe", PipeDirection.Out);
        public NamedPipeServer()
        {
            //server.s
        }
    }
}
