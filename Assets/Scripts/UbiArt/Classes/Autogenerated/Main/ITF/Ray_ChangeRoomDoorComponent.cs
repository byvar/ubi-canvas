using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ChangeRoomDoorComponent : CSerializable {
		[Serialize("goIn" )] public int goIn;
		[Serialize("goOut")] public int goOut;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(goIn));
				SerializeField(s, nameof(goOut));
			}
		}
		public override uint? ClassCRC => 0xF7BEB94A;
	}
}

