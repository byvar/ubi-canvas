using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.FriseOrigins {
	// See: ITF::FriseTextureConfig::serialize
	public class FriseTextureConfig : CSerializable {
		[Serialize("texture1")] public CString texture1;
		[Serialize("texture2")] public CString texture2;
		[Serialize("texture3")] public CString texture3;
		[Serialize("flt3")] public float flt3;
		[Serialize("flt4")] public float flt4;
		[Serialize("flt5")] public float flt5;
		[Serialize("flt6")] public float flt6;
		[Serialize("flt7")] public float flt7;
		[Serialize("int8")] public int int8;
		[Serialize("int9")] public int int9;
		[Serialize("int10")] public int int10;
		[Serialize("color")] public ColorInteger color;
		[Serialize("vecA")] public Vector2 vecA;
		[Serialize("vecB")] public Vector2 vecB;
		[Serialize("flt8")] public float flt8;
		[Serialize("path")] public Path path;
		[Serialize("str3")] public CString str3;
		[Serialize("color2")] public ColorInteger color2;
		[Serialize("collision1")] public CollisionFrieze collision1;
		[Serialize("collision2")] public CollisionFrieze collision2;
		[Serialize("scrollUV"     )] public Vector2 scrollUV;
		[Serialize("scrollAngle"  )] public float scrollAngle;
		[Serialize("alphaBorder"  )] public byte alphaBorder;
		[Serialize("alphaUp"      )] public byte alphaUp;
		[Serialize("uint1")] public uint uint1;
		[Serialize("uint2")] public uint uint2;
		[Serialize("flt10")] public float flt10;
		[Serialize("flt11")] public float flt11;
		[Serialize("flt12")] public float flt12;
		[Serialize("flt13")] public float flt13;
		[Serialize("int0")] public int int0;
		[Serialize("int1")] public int int1;
		[Serialize("int2")] public int int2;
		[Serialize("uint3")] public uint uint3;
		[Serialize("flt14")] public float flt14;


		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(texture1));
			SerializeField(s, nameof(texture2));
			SerializeField(s, nameof(texture3));
			SerializeField(s, nameof(flt3));
			SerializeField(s, nameof(flt4));
			SerializeField(s, nameof(flt5));
			SerializeField(s, nameof(flt6));
			SerializeField(s, nameof(flt7));
			SerializeField(s, nameof(int8));
			SerializeField(s, nameof(int9));
			SerializeField(s, nameof(int10));
			SerializeField(s, nameof(color));
			SerializeField(s, nameof(vecA));
			SerializeField(s, nameof(vecB));
			SerializeField(s, nameof(flt8));
			SerializeField(s, nameof(path));
			SerializeField(s, nameof(str3));
			SerializeField(s, nameof(color2));
			SerializeField(s, nameof(collision1));
			SerializeField(s, nameof(collision2));
			SerializeField(s, nameof(scrollUV));
			SerializeField(s, nameof(scrollAngle));
			SerializeField(s, nameof(alphaBorder));
			SerializeField(s, nameof(alphaUp));
			SerializeField(s, nameof(uint1));
			SerializeField(s, nameof(uint2));
			SerializeField(s, nameof(flt10));
			SerializeField(s, nameof(flt11));
			SerializeField(s, nameof(flt12));
			SerializeField(s, nameof(flt13));
			SerializeField(s, nameof(int0));
			SerializeField(s, nameof(int1));
			SerializeField(s, nameof(int2));
			SerializeField(s, nameof(uint3));
			SerializeField(s, nameof(flt14));
		}
	}
}
