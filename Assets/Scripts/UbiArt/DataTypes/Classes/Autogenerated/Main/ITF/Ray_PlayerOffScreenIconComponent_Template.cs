using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PlayerOffScreenIconComponent_Template : CSerializable {
		public StringID arrowBoneName;
		public Vec2d screenBorder;
		public float fadeInDelay;
		public float fadeInDuration;
		public float fadeOutDelay;
		public float fadeOutDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			arrowBoneName = s.SerializeObject<StringID>(arrowBoneName, name: "arrowBoneName");
			screenBorder = s.SerializeObject<Vec2d>(screenBorder, name: "screenBorder");
			fadeInDelay = s.Serialize<float>(fadeInDelay, name: "fadeInDelay");
			fadeInDuration = s.Serialize<float>(fadeInDuration, name: "fadeInDuration");
			fadeOutDelay = s.Serialize<float>(fadeOutDelay, name: "fadeOutDelay");
			fadeOutDuration = s.Serialize<float>(fadeOutDuration, name: "fadeOutDuration");
		}
		public override uint? ClassCRC => 0xA0E2BBBE;
	}
}

