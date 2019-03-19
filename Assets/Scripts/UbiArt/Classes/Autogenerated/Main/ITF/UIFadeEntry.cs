using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class UIFadeEntry : CSerializable {
		[Serialize("id"          )] public StringID id;
		[Serialize("duration"    )] public float duration;
		[Serialize("color"       )] public Color color;
		[Serialize("anim"        )] public StringID anim;
		[Serialize("fadeInSound" )] public StringID fadeInSound;
		[Serialize("fadeOutSound")] public StringID fadeOutSound;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(id));
			SerializeField(s, nameof(duration));
			SerializeField(s, nameof(color));
			SerializeField(s, nameof(anim));
			SerializeField(s, nameof(fadeInSound));
			SerializeField(s, nameof(fadeOutSound));
		}
	}
}

