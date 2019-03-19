using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class DeathDetectorComponent_Template : DetectorComponent_Template {
		[Serialize("isAnd"            )] public bool isAnd;
		[Serialize("resetOnCheckpoint")] public int resetOnCheckpoint;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(resetOnCheckpoint));
				SerializeField(s, nameof(isAnd));
			} else {
				SerializeField(s, nameof(isAnd));
			}
		}
		public override uint? ClassCRC => 0x40206760;
	}
}

