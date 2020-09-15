using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_GameMaterial_Template : CSerializable {
		public bool climbable;
		public bool dangerous;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			climbable = s.Serialize<bool>(climbable, name: "climbable", options: CSerializerObject.Options.BoolAsByte);
			dangerous = s.Serialize<bool>(dangerous, name: "dangerous", options: CSerializerObject.Options.BoolAsByte);
		}
		public override uint? ClassCRC => 0xEA2A372A;
	}
}

