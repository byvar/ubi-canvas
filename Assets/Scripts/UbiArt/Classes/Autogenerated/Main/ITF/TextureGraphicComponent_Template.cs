using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class TextureGraphicComponent_Template : GraphicComponent_Template {
		public Path texture;
		public GFXMaterialSerializable material;
		public Color defaultColor;
		public Angle angleX;
		public Angle angleY;
		public Angle angleZ;
		public float speedRotX;
		public float speedRotY;
		public float speedRotZ;
		public Vec2d size;
		public float zOffset;
		public bool draw2D;
		public bool draw2DNoScreenRatio;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				texture = s.SerializeObject<Path>(texture, name: "texture");
				defaultColor = s.SerializeObject<Color>(defaultColor, name: "defaultColor");
				angleX = s.SerializeObject<Angle>(angleX, name: "angleX");
				angleY = s.SerializeObject<Angle>(angleY, name: "angleY");
				angleZ = s.SerializeObject<Angle>(angleZ, name: "angleZ");
				speedRotX = s.Serialize<float>(speedRotX, name: "speedRotX");
				speedRotY = s.Serialize<float>(speedRotY, name: "speedRotY");
				speedRotZ = s.Serialize<float>(speedRotZ, name: "speedRotZ");
			} else if (s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					texture = s.SerializeObject<Path>(texture, name: "texture");
				}
				material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
				defaultColor = s.SerializeObject<Color>(defaultColor, name: "defaultColor");
				angleX = s.SerializeObject<Angle>(angleX, name: "angleX");
				angleY = s.SerializeObject<Angle>(angleY, name: "angleY");
				angleZ = s.SerializeObject<Angle>(angleZ, name: "angleZ");
				speedRotX = s.Serialize<float>(speedRotX, name: "speedRotX");
				speedRotY = s.Serialize<float>(speedRotY, name: "speedRotY");
				speedRotZ = s.Serialize<float>(speedRotZ, name: "speedRotZ");
				size = s.SerializeObject<Vec2d>(size, name: "size");
				zOffset = s.Serialize<float>(zOffset, name: "zOffset");
				draw2D = s.Serialize<bool>(draw2D, name: "draw2D");
			} else {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					texture = s.SerializeObject<Path>(texture, name: "texture");
				}
				material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
				defaultColor = s.SerializeObject<Color>(defaultColor, name: "defaultColor");
				angleX = s.SerializeObject<Angle>(angleX, name: "angleX");
				angleY = s.SerializeObject<Angle>(angleY, name: "angleY");
				angleZ = s.SerializeObject<Angle>(angleZ, name: "angleZ");
				speedRotX = s.Serialize<float>(speedRotX, name: "speedRotX");
				speedRotY = s.Serialize<float>(speedRotY, name: "speedRotY");
				speedRotZ = s.Serialize<float>(speedRotZ, name: "speedRotZ");
				size = s.SerializeObject<Vec2d>(size, name: "size");
				zOffset = s.Serialize<float>(zOffset, name: "zOffset");
				draw2D = s.Serialize<bool>(draw2D, name: "draw2D");
				draw2DNoScreenRatio = s.Serialize<bool>(draw2DNoScreenRatio, name: "draw2DNoScreenRatio");
			}
		}
		public override uint? ClassCRC => 0x9CAE4325;
	}
}

