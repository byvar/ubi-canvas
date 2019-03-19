using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SeaDragonComponent_Template : ActorComponent_Template {
		[Serialize("DrawDebugHit"   )] public bool DrawDebugHit;
		[Serialize("BodyPath"       )] public Path BodyPath;
		[Serialize("TailPath"       )] public Path TailPath;
		[Serialize("LookAtDist"     )] public float LookAtDist;
		[Serialize("MaxLookAtModule")] public uint MaxLookAtModule;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(DrawDebugHit));
			SerializeField(s, nameof(BodyPath));
			SerializeField(s, nameof(TailPath));
			SerializeField(s, nameof(LookAtDist));
			SerializeField(s, nameof(MaxLookAtModule));
		}
		public override uint? ClassCRC => 0xBB0E14CF;
	}
}

