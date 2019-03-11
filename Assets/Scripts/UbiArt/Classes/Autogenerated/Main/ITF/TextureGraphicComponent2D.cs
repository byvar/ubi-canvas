using UnityEngine;

namespace UbiArt.ITF {
	public partial class TextureGraphicComponent2D : GraphicComponent {
		[Serialize("ALIGN"            )] public align ALIGN;
		[Serialize("SCREEN_POURCENT_X")] public float SCREEN_POURCENT_X;
		[Serialize("SCREEN_POURCENT_Y")] public float SCREEN_POURCENT_Y;
		[Serialize("texture"          )] public Path texture;
		[Serialize("quadSize"         )] public Vector2 quadSize;
		[Serialize("ALIGN"            )] public Enum_ALIGN ALIGN;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(ALIGN));
					SerializeField(s, nameof(SCREEN_POURCENT_X));
					SerializeField(s, nameof(SCREEN_POURCENT_Y));
					SerializeField(s, nameof(texture));
					SerializeField(s, nameof(quadSize));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(ALIGN));
					SerializeField(s, nameof(SCREEN_POURCENT_X));
					SerializeField(s, nameof(SCREEN_POURCENT_Y));
					SerializeField(s, nameof(texture));
					SerializeField(s, nameof(quadSize));
				}
			}
		}
		public enum align {
			[Serialize("align_free"    )] free = 0,
			[Serialize("align_centerX" )] centerX = 1,
			[Serialize("align_centerY" )] centerY = 2,
			[Serialize("align_centerXY")] centerXY = 3,
		}
		public enum Enum_ALIGN {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0x661432DC;
	}
}

