using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_GameMaterial_Template : CSerializable {
		[Serialize("climbable")] public bool climbable;
		[Serialize("dangerous")] public bool dangerous;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(climbable), boolAsByte: true);
			SerializeField(s, nameof(dangerous), boolAsByte: true);
		}
		public override uint? ClassCRC => 0xEA2A372A;
	}
}

