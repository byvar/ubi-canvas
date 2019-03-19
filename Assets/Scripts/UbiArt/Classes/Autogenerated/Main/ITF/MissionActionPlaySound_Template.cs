using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionActionPlaySound_Template : CSerializable {
		[Serialize("soundGUID")] public StringID soundGUID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(soundGUID));
		}
		public override uint? ClassCRC => 0x1337518F;
	}
}

