using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PlayerHudScoreComponent : GraphicComponent {
		[Serialize("characterTexture" )] public Path characterTexture;
		[Serialize("characterMaterial")] public Placeholder characterMaterial;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(characterTexture));
				}
				SerializeField(s, nameof(characterMaterial));
			} else {
			}
		}
		public override uint? ClassCRC => 0x21BC5790;
	}
}

