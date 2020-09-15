using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PlayerDeadSoul2DComponent_Template : CSerializable {
		public StringID fxName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fxName = s.SerializeObject<StringID>(fxName, name: "fxName");
		}
		public override uint? ClassCRC => 0x163F2E54;
	}
}

