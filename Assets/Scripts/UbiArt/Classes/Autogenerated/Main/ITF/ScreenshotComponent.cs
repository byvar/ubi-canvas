using UnityEngine;

namespace UbiArt.ITF {
	public partial class ScreenshotComponent : ActorComponent {
		[Serialize("useText"   )] public bool useText;
		[Serialize("useLogo"   )] public bool useLogo;
		[Serialize("useDRCView")] public bool useDRCView;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(useText));
			SerializeField(s, nameof(useLogo));
			SerializeField(s, nameof(useDRCView));
		}
		public override uint? ClassCRC => 0x4D549084;
	}
}

