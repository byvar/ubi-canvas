using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PlayerDeadSoul2DComponent_Template : CSerializable {
		[Serialize("fxName")] public StringID fxName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fxName));
		}
		public override uint? ClassCRC => 0x163F2E54;
	}
}

