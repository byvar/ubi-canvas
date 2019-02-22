using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class FillConfig : BaseObject {
		public float smoothFactor;
		public float offset;
		public Angle angle;
		public Vector2 scale;
		public StringID tex;
		public float zExtrude;
		public bool isSmooth;
		public int texIndex;

		public FillConfig(Reader reader) : base(reader) {
			smoothFactor = reader.ReadSingle();
			offset = reader.ReadSingle();
			angle = new Angle(reader);
			scale = reader.ReadVector2();
			tex = new StringID(reader);
			zExtrude = reader.ReadSingle();
			isSmooth = reader.ReadBoolean();
			texIndex = reader.ReadInt32();
		}
	}
}
