using UnityEngine;

namespace UbiArt.ITF {
	public partial class CameraSubjectComponent_Template : ActorComponent_Template {
		[Serialize("boundingBoxMin")] public Vector2 boundingBoxMin;
		[Serialize("boundingBoxMax")] public Vector2 boundingBoxMax;
		[Serialize("offset"        )] public Vector2 offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(boundingBoxMin));
			SerializeField(s, nameof(boundingBoxMax));
			SerializeField(s, nameof(offset));
		}
		public override uint? ClassCRC => 0x5B4423A1;
	}
}

