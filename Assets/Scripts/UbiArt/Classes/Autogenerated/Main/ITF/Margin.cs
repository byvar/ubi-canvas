using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class Margin : CSerializable {
		public float left;
		public float right;
		public float top;
		public float bottom;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			left = s.Serialize<float>(left, name: "left");
			right = s.Serialize<float>(right, name: "right");
			top = s.Serialize<float>(top, name: "top");
			bottom = s.Serialize<float>(bottom, name: "bottom");
		}
	}
}

