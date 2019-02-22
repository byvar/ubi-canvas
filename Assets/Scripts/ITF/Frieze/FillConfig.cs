using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class FillConfig : BaseObject {
		[Serialize(0, "smoothFactor")] public float smoothFactor;
		[Serialize(1, "offset")] public float offset;
		[Serialize(2, "angle")] public Angle angle;
		[Serialize(3, "scale")] public Vector2 scale;
		[Serialize(4, "tex")] public StringID tex;
		[Serialize(5, "zExtrude")] public float zExtrude;
		[Serialize(6, "isSmooth")] public bool isSmooth;
		[Serialize(7, "texIndex")] public int texIndex;

		public FillConfig(Reader reader) : base(reader) {
		}
	}
}
