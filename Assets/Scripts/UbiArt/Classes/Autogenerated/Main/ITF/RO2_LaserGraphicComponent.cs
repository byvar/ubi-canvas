using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_LaserGraphicComponent : GraphicComponent {
		[Serialize("characterTexture"            )] public Path characterTexture;
		[Serialize("characterMaterial"           )] public GFXMaterialSerializable characterMaterial;
		[Serialize("ColorNormal"                 )] public Color ColorNormal;
		[Serialize("ColorDetected"               )] public Color ColorDetected;
		[Serialize("AlfaOnExtremities"           )] public float AlfaOnExtremities;
		[Serialize("AlfaStart"                   )] public float AlfaStart;
		[Serialize("SpeedLaser"                  )] public float SpeedLaser;
		[Serialize("GraphicLayerNb"              )] public uint GraphicLayerNb;
		[Serialize("GraphicLayerForced"          )] public int GraphicLayerForced;
		[Serialize("GraphicalLayerDelaiChange"   )] public float GraphicalLayerDelaiChange;
		[Serialize("GraphicalLayerDelaiRandom"   )] public float GraphicalLayerDelaiRandom;
		[Serialize("GraphicUVTarget"             )] public uint GraphicUVTarget;
		[Serialize("SacleY"                      )] public float SacleY;
		[Serialize("laserBoxLeftPointCoefOffset" )] public float laserBoxLeftPointCoefOffset;
		[Serialize("laserBoxRightPointCoefOffset")] public float laserBoxRightPointCoefOffset;
		[Serialize("laserLength"                 )] public float laserLength;
		[Serialize("textureRatio"                )] public float textureRatio;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(characterTexture));
			}
			SerializeField(s, nameof(characterMaterial));
			SerializeField(s, nameof(ColorNormal));
			SerializeField(s, nameof(ColorDetected));
			SerializeField(s, nameof(AlfaOnExtremities));
			SerializeField(s, nameof(AlfaStart));
			SerializeField(s, nameof(SpeedLaser));
			SerializeField(s, nameof(GraphicLayerNb));
			SerializeField(s, nameof(GraphicLayerForced));
			SerializeField(s, nameof(GraphicalLayerDelaiChange));
			SerializeField(s, nameof(GraphicalLayerDelaiRandom));
			SerializeField(s, nameof(GraphicUVTarget));
			SerializeField(s, nameof(SacleY));
			SerializeField(s, nameof(laserBoxLeftPointCoefOffset));
			SerializeField(s, nameof(laserBoxRightPointCoefOffset));
			SerializeField(s, nameof(laserLength));
			SerializeField(s, nameof(textureRatio));
		}
		public override uint? ClassCRC => 0xC3701255;
	}
}

