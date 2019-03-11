using UnityEngine;

namespace UbiArt.ITF {
	public partial class CreditsComponent : ActorComponent {
		[Serialize("width"          )] public float width;
		[Serialize("height"         )] public float height;
		[Serialize("scrollSpeed"    )] public float scrollSpeed;
		[Serialize("globalFontScale")] public float globalFontScale;
		[Serialize("interline"      )] public float interline;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(width));
			SerializeField(s, nameof(height));
			SerializeField(s, nameof(scrollSpeed));
			SerializeField(s, nameof(globalFontScale));
			SerializeField(s, nameof(interline));
		}
		public override uint? ClassCRC => 0xA9BC1BE5;
	}
}

