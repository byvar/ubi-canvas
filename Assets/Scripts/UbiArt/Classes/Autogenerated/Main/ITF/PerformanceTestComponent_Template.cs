using UnityEngine;

namespace UbiArt.ITF {
	public partial class PerformanceTestComponent_Template : ActorComponent_Template {
		[Serialize("spawns")] public CArray<Path> spawns;
		[Serialize("offset")] public Vector3 offset;
		[Serialize("limits")] public Vector3 limits;
		[Serialize("seed"  )] public uint seed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(spawns));
			SerializeField(s, nameof(offset));
			SerializeField(s, nameof(limits));
			SerializeField(s, nameof(seed));
		}
		public override uint? ClassCRC => 0x8EB59A46;
	}
}

