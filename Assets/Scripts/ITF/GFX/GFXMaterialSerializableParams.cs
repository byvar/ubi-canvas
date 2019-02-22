using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class GFXMaterialSerializableParams : BaseObject {
		[Serialize(0, "Reflector_factor")] public float reflector_factor;
		[Serialize(1, "HiddenMask_Z_Extrude")] public float hiddenMask_Z_Extrude;

		public GFXMaterialSerializableParams(Reader reader) : base(reader) {
		}
	}
}
