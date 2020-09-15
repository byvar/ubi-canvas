using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BallSpawnerComponent_Template : ActorComponent_Template {
		public Path ballPath;
		public uint ballMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ballPath = s.SerializeObject<Path>(ballPath, name: "ballPath");
			ballMax = s.Serialize<uint>(ballMax, name: "ballMax");
		}
		public override uint? ClassCRC => 0xEA4182E0;
	}
}

