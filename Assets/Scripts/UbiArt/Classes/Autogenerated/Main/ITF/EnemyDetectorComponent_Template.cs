using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class EnemyDetectorComponent_Template : ShapeDetectorComponent_Template {
		public uint faction;
		public bool noPhantomCheck;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			faction = s.Serialize<uint>(faction, name: "faction");
			noPhantomCheck = s.Serialize<bool>(noPhantomCheck, name: "noPhantomCheck");
		}
		public override uint? ClassCRC => 0x9C2CBBEF;
	}
}

