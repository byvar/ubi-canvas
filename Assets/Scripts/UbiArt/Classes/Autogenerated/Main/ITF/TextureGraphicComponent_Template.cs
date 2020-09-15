using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class TextureGraphicComponent_Template : GraphicComponent_Template {
		[Serialize("texture"            )] public Path texture;
		[Serialize("material"           )] public GFXMaterialSerializable material;
		[Serialize("defaultColor"       )] public Color defaultColor;
		[Serialize("angleX"             )] public Angle angleX;
		[Serialize("angleY"             )] public Angle angleY;
		[Serialize("angleZ"             )] public Angle angleZ;
		[Serialize("speedRotX"          )] public float speedRotX;
		[Serialize("speedRotY"          )] public float speedRotY;
		[Serialize("speedRotZ"          )] public float speedRotZ;
		[Serialize("size"               )] public Vec2d size;
		[Serialize("zOffset"            )] public float zOffset;
		[Serialize("draw2D"             )] public bool draw2D;
		[Serialize("draw2DNoScreenRatio")] public bool draw2DNoScreenRatio;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(texture));
				SerializeField(s, nameof(defaultColor));
				SerializeField(s, nameof(angleX));
				SerializeField(s, nameof(angleY));
				SerializeField(s, nameof(angleZ));
				SerializeField(s, nameof(speedRotX));
				SerializeField(s, nameof(speedRotY));
				SerializeField(s, nameof(speedRotZ));
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(texture));
				}
				SerializeField(s, nameof(material));
				SerializeField(s, nameof(defaultColor));
				SerializeField(s, nameof(angleX));
				SerializeField(s, nameof(angleY));
				SerializeField(s, nameof(angleZ));
				SerializeField(s, nameof(speedRotX));
				SerializeField(s, nameof(speedRotY));
				SerializeField(s, nameof(speedRotZ));
				SerializeField(s, nameof(size));
				SerializeField(s, nameof(zOffset));
				SerializeField(s, nameof(draw2D));
			} else {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(texture));
				}
				SerializeField(s, nameof(material));
				SerializeField(s, nameof(defaultColor));
				SerializeField(s, nameof(angleX));
				SerializeField(s, nameof(angleY));
				SerializeField(s, nameof(angleZ));
				SerializeField(s, nameof(speedRotX));
				SerializeField(s, nameof(speedRotY));
				SerializeField(s, nameof(speedRotZ));
				SerializeField(s, nameof(size));
				SerializeField(s, nameof(zOffset));
				SerializeField(s, nameof(draw2D));
				SerializeField(s, nameof(draw2DNoScreenRatio));
			}
		}
		public override uint? ClassCRC => 0x9CAE4325;
	}
}

