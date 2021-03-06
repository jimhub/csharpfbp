using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using FBPLib;
using Components;

namespace TestNetworks.Networks
{
    public class TestInfQueue : Network
    {
        /* *
            * Copyright 2007, 2008, J. Paul Morrison.  At your option, you may copy, 
            * distribute, or make derivative works under the terms of the Clarified Artistic License, 
            * based on the Everything Development Company's Artistic License.  A document describing 
            * this License may be found at http://www.jpaulmorrison.com/fbp/artistic2.htm. 
            * THERE IS NO WARRANTY; USE THIS PRODUCT AT YOUR OWN RISK.
            * */
        public override void Define()
        {
            string filename = @"..\..\infqueue.fil";
            
            Component("Generate", typeof(GenerateTestData));
            Component("InfiniteQueue", typeof(InfiniteQueue));
            Component("Display", typeof(WriteText));
            
            Connect("Generate.OUT", "InfiniteQueue.IN");
            Connect("InfiniteQueue.OUT", "Display.IN");
            
            Initialize("100",
                Component("Generate"),
                Port("COUNT"));
            
            Stream st = Console.OpenStandardOutput();
            Initialize(st,
                Component("Display"),
                Port("DESTINATION"));

            Initialize(filename, "InfiniteQueue.READFILE");
            Initialize(filename, "InfiniteQueue.WRITEFILE");

        }
    }
}
