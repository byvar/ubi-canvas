using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.FriseOrigins {
	// See: ITF::FriseTextureConfig::serialize
	public class FriseTextureConfig : CSerializable {
		[Serialize("str0")] public CString str0;
		[Serialize("str1")] public CString str1;
		[Serialize("str2")] public CString str2;
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


		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(str0));
			SerializeField(s, nameof(str1));
			SerializeField(s, nameof(str2));
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
		}
	}
}
