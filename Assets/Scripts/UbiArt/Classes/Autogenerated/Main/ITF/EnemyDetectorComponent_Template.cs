using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class EnemyDetectorComponent_Template : ShapeDetectorComponent_Template {
		[Serialize("faction"       )] public uint faction;
		[Serialize("noPhantomCheck")] public bool noPhantomCheck;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(faction));
			SerializeField(s, nameof(noPhantomCheck));
		}
		public override uint? ClassCRC => 0x9C2CBBEF;
	}
}

