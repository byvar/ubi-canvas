using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class TextureGraphicComponent : GraphicComponent {
		[Serialize("texture"                   )] public Path texture;
		[Serialize("anchor"                    )] public TEXTURE_ANCHOR anchor;
		[Serialize("material"                  )] public GFXMaterialSerializable material;
		[Serialize("Scale"                     )] public Vector2 Scale;
		[Serialize("Width"                     )] public float Width;
		[Serialize("Angle"                     )] public Angle Angle;
		[Serialize("Offset"                    )] public Vector3 Offset;
		[Serialize("UVScale"                   )] public Vector2 UVScale;
		[Serialize("UVOffset"                  )] public Vector2 UVOffset;
		[Serialize("spriteIndex"               )] public uint spriteIndex;
		[Serialize("uvRatio"                   )] public Vector2 uvRatio;
		[Serialize("uvTranslationSpeed"        )] public Vector2 uvTranslationSpeed;
		[Serialize("size"                      )] public Vector2 size;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(texture));
				}
			} else if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					if (s.HasFlags(SerializeFlags.Flags8)) {
						SerializeField(s, nameof(texture));
					}
					SerializeField(s, nameof(anchor));
					SerializeField(s, nameof(material));
					SerializeField(s, nameof(spriteIndex));
					if (!Settings.s.isCatchThemAll) {
						SerializeField(s, nameof(uvRatio));
						SerializeField(s, nameof(uvTranslationSpeed));
					}
				}
			} else if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					if (s.HasFlags(SerializeFlags.Flags8)) {
						SerializeField(s, nameof(texture));
					}
					SerializeField(s, nameof(anchor));
					SerializeField(s, nameof(material));
					SerializeField(s, nameof(spriteIndex));
					SerializeField(s, nameof(size));
					SerializeField(s, nameof(uvRatio));
					SerializeField(s, nameof(uvTranslationSpeed));
				}
			} else if (Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					if (s.HasFlags(SerializeFlags.Flags8)) {
						SerializeField(s, nameof(texture));
					}
					SerializeField(s, nameof(anchor));
					SerializeField(s, nameof(material));
					SerializeField(s, nameof(spriteIndex));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default | SerializeFlags.Flags8)) {
					SerializeField(s, nameof(texture));
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(anchor));
					SerializeField(s, nameof(material));
					SerializeField(s, nameof(Scale));
					SerializeField(s, nameof(Width));
					SerializeField(s, nameof(Angle));
					SerializeField(s, nameof(Offset));
					SerializeField(s, nameof(UVScale));
					SerializeField(s, nameof(UVOffset));
				}
			}
		}
		public enum TEXTURE_ANCHOR {
			[Serialize("TEXTURE_ANCHOR_TOP_LEFT"     )] TOP_LEFT = 0,
			[Serialize("TEXTURE_ANCHOR_MIDDLE_CENTER")] MIDDLE_CENTER = 1,
			[Serialize("TEXTURE_ANCHOR_MIDDLE_LEFT"  )] MIDDLE_LEFT = 2,
			[Serialize("TEXTURE_ANCHOR_MIDDLE_RIGHT" )] MIDDLE_RIGHT = 3,
			[Serialize("TEXTURE_ANCHOR_TOP_CENTER"   )] TOP_CENTER = 4,
			[Serialize("TEXTURE_ANCHOR_TOP_RIGHT"    )] TOP_RIGHT = 5,
			[Serialize("TEXTURE_ANCHOR_BOTTOM_CENTER")] BOTTOM_CENTER = 6,
			[Serialize("TEXTURE_ANCHOR_BOTTOM_LEFT"  )] BOTTOM_LEFT = 7,
			[Serialize("TEXTURE_ANCHOR_BOTTOM_RIGHT" )] BOTTOM_RIGHT = 8,
		}
		public override uint? ClassCRC => 0x7B48A9AE;
	}
}

