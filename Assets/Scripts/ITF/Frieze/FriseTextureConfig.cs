using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class FriseTextureConfig : BaseObject {
		[Serialize(0, "material")] public GFXMaterialSerializable material;
		[Serialize(1, "friendly")] public StringID friendly;
		[Serialize(2, "gameMaterial")] public Path gameMaterial;
		[Serialize(3, "color")] public ColorInteger color;
		[Serialize(4, "fillingOffset")] public float fillingOffset;
		[Serialize(5, "collision")] public CollisionTexture collision;
		[Serialize(6, "scrollUV")] public Vector2 scrollUV;
		[Serialize(7, "scrollAngle")] public float scrollAngle;
		[Serialize(8, "useUV2")] public bool useUV2;
		[Serialize(9, "scaleUV2")] public Vector2 scaleUV2;
		[Serialize(10, "scrollUV2")] public Vector2 scrollUV2;
		[Serialize(11, "scrollAngle2")] public float scrollAngle2;
		[Serialize(12, "alphaBorder")] public byte alphaBorder;
		[Serialize(13, "alphaUp")] public byte alphaUp;


		public FriseTextureConfig(Reader reader) : base(reader) {
		}
	}
}
