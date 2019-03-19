using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_LevelTitleComponent_Template : ActorComponent_Template {
		[Serialize("textPath"   )] public Path textPath;
		[Serialize("screenPos"  )] public Vector2 screenPos;
		[Serialize("encartInFX" )] public StringID encartInFX;
		[Serialize("encartOutFX")] public StringID encartOutFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(textPath));
			SerializeField(s, nameof(screenPos));
			SerializeField(s, nameof(encartInFX));
			SerializeField(s, nameof(encartOutFX));
		}
		public override uint? ClassCRC => 0x9894A57B;
	}
}

