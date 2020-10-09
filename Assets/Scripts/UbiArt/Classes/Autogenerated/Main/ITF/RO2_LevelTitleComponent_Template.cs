using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_LevelTitleComponent_Template : ActorComponent_Template {
		public Path textPath;
		public Vec2d screenPos;
		public StringID encartInFX;
		public StringID encartOutFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			textPath = s.SerializeObject<Path>(textPath, name: "textPath");
			screenPos = s.SerializeObject<Vec2d>(screenPos, name: "screenPos");
			encartInFX = s.SerializeObject<StringID>(encartInFX, name: "encartInFX");
			encartOutFX = s.SerializeObject<StringID>(encartOutFX, name: "encartOutFX");
		}
		public override uint? ClassCRC => 0x9894A57B;
	}
}

