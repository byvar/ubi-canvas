using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class AFX_MosaicParam : BaseObject {
		[Serialize(0, "use")] public bool use;
		[Serialize(1, "pixelSize")] public float pixelSize;

		public AFX_MosaicParam(Reader reader) : base(reader) {
		}
	}
}
