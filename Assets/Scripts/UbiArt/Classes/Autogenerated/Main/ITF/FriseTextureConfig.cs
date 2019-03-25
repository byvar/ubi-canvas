using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class FriseTextureConfig : CSerializable {
		[Serialize("path"         )] public Path path;
		[Serialize("material"     )] public GFXMaterialSerializable material;
		[Serialize("friendly"     )] public StringID friendly;
		[Serialize("gameMaterial" )] public Path gameMaterial;
		[Serialize("color"        )] public ColorInteger color;
		[Serialize("fillingOffset")] public float fillingOffset;
		[Serialize("collision"    )] public CollisionTexture collision;
		[Serialize("scrollUV"     )] public Vector2 scrollUV;
		[Serialize("scrollAngle"  )] public float scrollAngle;
		[Serialize("useUV2"       )] public bool useUV2;
		[Serialize("scaleUV2"     )] public Vector2 scaleUV2;
		[Serialize("scrollUV2"    )] public Vector2 scrollUV2;
		[Serialize("scrollAngle2" )] public float scrollAngle2;
		[Serialize("alphaBorder"  )] public char alphaBorder;
		[Serialize("alphaUp"      )] public char alphaUp;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(path));
			}
			SerializeField(s, nameof(material));
			SerializeField(s, nameof(friendly));
			SerializeField(s, nameof(gameMaterial));
			SerializeField(s, nameof(color));
			SerializeField(s, nameof(fillingOffset));
			SerializeField(s, nameof(collision));
			SerializeField(s, nameof(scrollUV));
			SerializeField(s, nameof(scrollAngle));
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(useUV2), boolAsByte: true);
			} else {
				SerializeField(s, nameof(useUV2));
			}
			SerializeField(s, nameof(scaleUV2));
			SerializeField(s, nameof(scrollUV2));
			SerializeField(s, nameof(scrollAngle2));
			SerializeField(s, nameof(alphaBorder));
			SerializeField(s, nameof(alphaUp));
		}
	}
}

