using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SeaDragonComponent_Template : ActorComponent_Template {
		public bool DrawDebugHit;
		public Path BodyPath;
		public Path TailPath;
		public float LookAtDist;
		public uint MaxLookAtModule;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			DrawDebugHit = s.Serialize<bool>(DrawDebugHit, name: "DrawDebugHit");
			BodyPath = s.SerializeObject<Path>(BodyPath, name: "BodyPath");
			TailPath = s.SerializeObject<Path>(TailPath, name: "TailPath");
			LookAtDist = s.Serialize<float>(LookAtDist, name: "LookAtDist");
			MaxLookAtModule = s.Serialize<uint>(MaxLookAtModule, name: "MaxLookAtModule");
		}
		public override uint? ClassCRC => 0xBB0E14CF;
	}
}

