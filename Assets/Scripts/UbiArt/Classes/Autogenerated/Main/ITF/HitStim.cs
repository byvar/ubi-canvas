using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class HitStim : EventStim {
		[Serialize("level"    )] public uint level;
		[Serialize("direction")] public Vector2 direction;
		[Serialize("faction"  )] public uint faction;
		[Serialize("fxPos"    )] public Vector3 fxPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(level));
				SerializeField(s, nameof(direction));
				SerializeField(s, nameof(faction));
			} else {
				SerializeField(s, nameof(level));
				SerializeField(s, nameof(direction));
				SerializeField(s, nameof(faction));
				SerializeField(s, nameof(fxPos));
			}
		}
		public override uint? ClassCRC => 0x7E76FF34;
	}
}

