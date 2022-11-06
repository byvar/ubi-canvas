using UnityEngine;

namespace UbiArt.ITF {
	public partial class GFX_Vector4 {
		public Vector4 UnityVector {
			get {
				return new Vector4(x, y, z, w);
			}
		}
	}
}
