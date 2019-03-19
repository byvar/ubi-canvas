using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PlayerOffScreenIconComponent_Template : CSerializable {
		[Serialize("arrowBoneName"  )] public StringID arrowBoneName;
		[Serialize("screenBorder"   )] public Vector2 screenBorder;
		[Serialize("fadeInDelay"    )] public float fadeInDelay;
		[Serialize("fadeInDuration" )] public float fadeInDuration;
		[Serialize("fadeOutDelay"   )] public float fadeOutDelay;
		[Serialize("fadeOutDuration")] public float fadeOutDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(arrowBoneName));
			SerializeField(s, nameof(screenBorder));
			SerializeField(s, nameof(fadeInDelay));
			SerializeField(s, nameof(fadeInDuration));
			SerializeField(s, nameof(fadeOutDelay));
			SerializeField(s, nameof(fadeOutDuration));
		}
		public override uint? ClassCRC => 0xA0E2BBBE;
	}
}

