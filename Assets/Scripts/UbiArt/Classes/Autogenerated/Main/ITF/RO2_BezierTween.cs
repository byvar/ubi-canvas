using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class RO2_BezierTween : CSerializable {
		public StringID set;
		public float offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			set = s.SerializeObject<StringID>(set, name: "set");
			offset = s.Serialize<float>(offset, name: "offset");
		}
	}
}

