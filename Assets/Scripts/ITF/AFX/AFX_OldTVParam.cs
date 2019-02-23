using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class AFX_OldTVParam : BaseObject {
		[Serialize(0, "use")] public bool use;
		[Serialize(1, "lineFade")] public float lineFade;
		[Serialize(2, "useScanLine")] public bool useScanLine;
		[Serialize(3, "scanLineFade")] public float scanLineFade;
		[Serialize(4, "scanLineSpeed")] public float scanLineSpeed;
		[Serialize(5, "scanLineSize")] public float scanLineSize;

		public AFX_OldTVParam(Reader reader) : base(reader) {
		}
	}
}
