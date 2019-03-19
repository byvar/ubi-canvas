using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_GameGlobalsEggCollectedCountCondition : online.GameGlobalsCondition {
		[Serialize("count")] public uint count;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(count));
		}
		public override uint? ClassCRC => 0x4BD2C8AE;
	}
}

