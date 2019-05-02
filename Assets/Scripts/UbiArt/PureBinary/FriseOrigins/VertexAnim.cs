using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.FriseOrigins {
	// See: ITF::VertexAnim::serialize
	public class VertexAnim : CSerializable {
		[Serialize("flt0")] public float flt0;
		[Serialize("flt1")] public float flt1;
		[Serialize("flt2")] public float flt2;
		[Serialize("flt3")] public float flt3;
		[Serialize("flt4")] public float flt4;
		[Serialize("flt5")] public float flt5;
		[Serialize("flt6")] public float flt6;
		[Serialize("flt7")] public float flt7;
		[Serialize("flt8")] public float flt8;
		[Serialize("int9")] public int int9;
		[Serialize("flt10")] public float flt10;


		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(flt0));
			SerializeField(s, nameof(flt1));
			SerializeField(s, nameof(flt2));
			SerializeField(s, nameof(flt3));
			SerializeField(s, nameof(flt4));
			SerializeField(s, nameof(flt5));
			SerializeField(s, nameof(flt6));
			SerializeField(s, nameof(flt7));
			SerializeField(s, nameof(flt8));
			SerializeField(s, nameof(int9));
			SerializeField(s, nameof(flt10));
		}
	}
}
