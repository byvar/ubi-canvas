using UbiArt.FileFormat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UbiArt {
	// Only contains data read in the header of the level file
	public class Globals {
		Dictionary<string, FileWithPointers> files;
	}
}