using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class FriseTextureConfig : BaseObject {
		public GFXMaterialSerializable material;
		public StringID friendly;
		public Path gameMaterial;
		public ColorInteger color;
		public float fillingOffset;
		public CollisionTexture collision;
		public Vector2 scrollUV;
		public float scrollAngle;
		public bool useUV2;
		public Vector2 scaleUV2;
		public Vector2 scrollUV2;
		public float scrollAngle2;
		public byte alphaBorder;
		public byte alphaUp;


		public FriseTextureConfig(Reader reader) : base(reader) {
			material = new GFXMaterialSerializable(reader);
			friendly = new StringID(reader);
			gameMaterial = new Path(reader);
			color = new ColorInteger(reader);
			fillingOffset = reader.ReadSingle();
			collision = new CollisionTexture(reader);
			scrollUV = reader.ReadVector2();
			scrollAngle = reader.ReadSingle();
			useUV2 = reader.ReadBoolean();
			scaleUV2 = reader.ReadVector2();
			scrollUV2 = reader.ReadVector2();
			scrollAngle2 = reader.ReadSingle();
			alphaBorder = reader.ReadByte();
			alphaUp = reader.ReadByte();
		}
	}
}
