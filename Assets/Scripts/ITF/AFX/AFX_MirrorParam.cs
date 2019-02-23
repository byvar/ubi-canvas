using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class AFX_MirrorParam : BaseObject {
		[Serialize(0, "use")] public bool use;
		[Serialize(1, "offsetX")] public float offsetX;
		[Serialize(2, "offsetY")] public float offsetY;
		
		public AFX_MirrorParam(Reader reader) : base(reader) {
		}
	}
}
