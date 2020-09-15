using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BattleAudioVisualComponent_Template : CSerializable {
		[Serialize("spawnOffset")] public Vec2d spawnOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(spawnOffset));
		}
		public override uint? ClassCRC => 0xB65F2B53;
	}
}

