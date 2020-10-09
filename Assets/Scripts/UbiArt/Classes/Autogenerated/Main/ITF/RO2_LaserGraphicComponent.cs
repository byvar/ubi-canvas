using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_LaserGraphicComponent : GraphicComponent {
		public Path characterTexture;
		public GFXMaterialSerializable characterMaterial;
		public Color ColorNormal;
		public Color ColorDetected;
		public float AlfaOnExtremities;
		public float AlfaStart;
		public float SpeedLaser;
		public uint GraphicLayerNb;
		public int GraphicLayerForced;
		public float GraphicalLayerDelaiChange;
		public float GraphicalLayerDelaiRandom;
		public uint GraphicUVTarget;
		public float SacleY;
		public float laserBoxLeftPointCoefOffset;
		public float laserBoxRightPointCoefOffset;
		public float laserLength;
		public float textureRatio;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				characterTexture = s.SerializeObject<Path>(characterTexture, name: "characterTexture");
			}
			characterMaterial = s.SerializeObject<GFXMaterialSerializable>(characterMaterial, name: "characterMaterial");
			ColorNormal = s.SerializeObject<Color>(ColorNormal, name: "ColorNormal");
			ColorDetected = s.SerializeObject<Color>(ColorDetected, name: "ColorDetected");
			AlfaOnExtremities = s.Serialize<float>(AlfaOnExtremities, name: "AlfaOnExtremities");
			AlfaStart = s.Serialize<float>(AlfaStart, name: "AlfaStart");
			SpeedLaser = s.Serialize<float>(SpeedLaser, name: "SpeedLaser");
			GraphicLayerNb = s.Serialize<uint>(GraphicLayerNb, name: "GraphicLayerNb");
			GraphicLayerForced = s.Serialize<int>(GraphicLayerForced, name: "GraphicLayerForced");
			GraphicalLayerDelaiChange = s.Serialize<float>(GraphicalLayerDelaiChange, name: "GraphicalLayerDelaiChange");
			GraphicalLayerDelaiRandom = s.Serialize<float>(GraphicalLayerDelaiRandom, name: "GraphicalLayerDelaiRandom");
			GraphicUVTarget = s.Serialize<uint>(GraphicUVTarget, name: "GraphicUVTarget");
			SacleY = s.Serialize<float>(SacleY, name: "SacleY");
			laserBoxLeftPointCoefOffset = s.Serialize<float>(laserBoxLeftPointCoefOffset, name: "laserBoxLeftPointCoefOffset");
			laserBoxRightPointCoefOffset = s.Serialize<float>(laserBoxRightPointCoefOffset, name: "laserBoxRightPointCoefOffset");
			laserLength = s.Serialize<float>(laserLength, name: "laserLength");
			textureRatio = s.Serialize<float>(textureRatio, name: "textureRatio");
		}
		public override uint? ClassCRC => 0xC3701255;
	}
}

