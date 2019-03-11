using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_TreeOptimGraph : CSerializable {
		[Serialize("OptimPath"   )] public Path OptimPath;
		[Serialize("OptimPos"    )] public Vector3 OptimPos;
		[Serialize("OptimLoadMin")] public float OptimLoadMin;
		[Serialize("OptimLoadMax")] public float OptimLoadMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(OptimPath));
			SerializeField(s, nameof(OptimPos));
			SerializeField(s, nameof(OptimLoadMin));
			SerializeField(s, nameof(OptimLoadMax));
		}
		public override uint? ClassCRC => 0x6EF4AFC3;
	}
}

