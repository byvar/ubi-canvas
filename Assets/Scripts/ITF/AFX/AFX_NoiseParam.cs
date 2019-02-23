using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class AFX_NoiseParam : BaseObject {
		[Serialize(0, "use")] public bool use;
		[Serialize(1, "blendFactor")] public float blendFactor;
		[Serialize(2, "size")] public float size;

		public AFX_NoiseParam(Reader reader) : base(reader) {
		}
	}
}
