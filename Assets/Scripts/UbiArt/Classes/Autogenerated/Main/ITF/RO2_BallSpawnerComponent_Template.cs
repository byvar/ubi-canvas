using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BallSpawnerComponent_Template : ActorComponent_Template {
		[Serialize("ballPath")] public Path ballPath;
		[Serialize("ballMax" )] public uint ballMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ballPath));
			SerializeField(s, nameof(ballMax));
		}
		public override uint? ClassCRC => 0xEA4182E0;
	}
}

