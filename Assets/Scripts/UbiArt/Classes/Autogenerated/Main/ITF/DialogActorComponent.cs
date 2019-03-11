using UnityEngine;

namespace UbiArt.ITF {
	public partial class DialogActorComponent : ActorComponent {
		[Serialize("enableDialog"      )] public bool enableDialog;
		[Serialize("offset"            )] public Vector2 offset;
		[Serialize("is3D"              )] public bool is3D;
		[Serialize("widthTextAreaMax"  )] public float widthTextAreaMax;
		[Serialize("offSetCorrectionPx")] public Vector2 offSetCorrectionPx;
		[Serialize("managerOffsetDelta")] public Vector2 managerOffsetDelta;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enableDialog));
			SerializeField(s, nameof(offset));
			SerializeField(s, nameof(is3D));
			SerializeField(s, nameof(widthTextAreaMax));
			SerializeField(s, nameof(offSetCorrectionPx));
			SerializeField(s, nameof(managerOffsetDelta));
		}
		public override uint? ClassCRC => 0x19FA44DD;
	}
}

