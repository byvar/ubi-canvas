using ITF.FileFormat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITF {
    // Only contains data read in the header of the level file
    public class Globals {
		Dictionary<string, FileWithPointers> files;
    }
}