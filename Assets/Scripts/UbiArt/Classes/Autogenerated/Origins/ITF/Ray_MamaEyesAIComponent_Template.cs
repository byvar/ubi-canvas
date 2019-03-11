using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_MamaEyesAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("initSpeed")] public Vector3 initSpeed;
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
		public override uint? ClassCRC => 0x94F888C1;
	}
}

