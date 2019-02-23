using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class AFX_EyeFishParam : BaseObject {
		[Serialize(0, "use")] public bool use;
		[Serialize(1, "height")] public float height;
		[Serialize(2, "scale")] public float scale;

		public AFX_EyeFishParam(Reader reader) : base(reader) {
		}
	}
}
