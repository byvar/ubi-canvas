using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class FriezeContactDetectorComponent_Template : DetectorComponent_Template {
		[Serialize("factionToDetect"  )] public uint factionToDetect;
		[Serialize("allowDeadActors"  )] public bool allowDeadActors;
		[Serialize("detectHang"       )] public bool detectHang;
		[Serialize("resetOnCheckpoint")] public int resetOnCheckpoint;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(resetOnCheckpoint));
				SerializeField(s, nameof(factionToDetect));
				SerializeField(s, nameof(allowDeadActors));
				SerializeField(s, nameof(detectHang));
			} else {
				SerializeField(s, nameof(factionToDetect));
				SerializeField(s, nameof(allowDeadActors));
				SerializeField(s, nameof(detectHang));
			}
		}
		public override uint? ClassCRC => 0xF0860387;
	}
}

