using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class GenericDetectorComponent_Template : ShapeDetectorComponent_Template {
		public uint uint__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			uint__0 = s.Serialize<uint>(uint__0, name: "uint__0");
		}
		public override uint? ClassCRC => 0xE615B98C;
	}
}

