using UnityEngine;

namespace UbiArt.ITF {
	public partial class CameraNearFarFadeComponent : ActorComponent {
		[Serialize("Near")] public float Near;
		[Serialize("Fade")] public float Fade;
		[Serialize("Far" )] public float Far;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Near));
			SerializeField(s, nameof(Fade));
			SerializeField(s, nameof(Far));
		}
		public override uint? ClassCRC => 0x6F948B10;
	}
}

