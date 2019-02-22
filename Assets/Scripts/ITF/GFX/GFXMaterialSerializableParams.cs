using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class GFXMaterialSerializableParams : BaseObject {
		public float reflector_factor;
		public float hiddenMask_Z_Extrude;

		public GFXMaterialSerializableParams(Reader reader) : base(reader) {
			reflector_factor = reader.ReadSingle();
			hiddenMask_Z_Extrude = reader.ReadSingle();
		}
	}
}
