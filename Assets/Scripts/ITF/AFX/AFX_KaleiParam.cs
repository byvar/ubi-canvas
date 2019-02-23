using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class AFX_KaleiParam : BaseObject {
		[Serialize(0, "use")] public bool use;
		[Serialize(1, "pixelSize")] public float pixelSize;
		[Serialize(2, "UV1")] public Vector2 UV1;
		[Serialize(3, "UV2")] public Vector2 UV2;
		[Serialize(4, "UV3")] public Vector2 UV3;
		
		public AFX_KaleiParam(Reader reader) : base(reader) {
		}
	}
}
