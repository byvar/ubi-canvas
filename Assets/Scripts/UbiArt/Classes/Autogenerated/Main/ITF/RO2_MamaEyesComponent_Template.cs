using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MamaEyesComponent_Template : ActorComponent_Template {
		[Serialize("initSpeed")] public Vec3d initSpeed;
		[Serialize("gravity"  )] public float gravity;
		[Serialize("rotation" )] public float rotation;
		[Serialize("scaleMin" )] public float scaleMin;
		[Serialize("scaleMax" )] public float scaleMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(initSpeed));
			SerializeField(s, nameof(gravity));
			SerializeField(s, nameof(rotation));
			SerializeField(s, nameof(scaleMin));
			SerializeField(s, nameof(scaleMax));
		}
		public override uint? ClassCRC => 0x06481B58;
	}
}

