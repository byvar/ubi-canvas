using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PlayerHudScoreComponent : GraphicComponent {
		public Path characterTexture;
		public Placeholder characterMaterial;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					characterTexture = s.SerializeObject<Path>(characterTexture, name: "characterTexture");
				}
				characterMaterial = s.SerializeObject<Placeholder>(characterMaterial, name: "characterMaterial");
			} else {
			}
		}
		public override uint? ClassCRC => 0x21BC5790;
	}
}

