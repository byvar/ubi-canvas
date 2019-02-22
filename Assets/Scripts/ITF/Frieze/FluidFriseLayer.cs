using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class FluidFriseLayer : BaseObject {
		public uint erosion;
		public Color color;
		public float threshold;
		public Path gameMaterial;
		public Path backsideGameMaterial;
		public float collisionHeight;
		public bool hasBacksideInversion;
		public float forcedHeightWhenNotColored;
		public bool hasForcedHeightWhenNotColored;

		public FluidFriseLayer(Reader reader) : base(reader) {
			erosion = reader.ReadUInt32();
			color = reader.ReadColor();
			threshold = reader.ReadSingle();
			gameMaterial = new Path(reader);
			backsideGameMaterial = new Path(reader);
			collisionHeight = reader.ReadSingle();
			hasBacksideInversion = reader.ReadBoolean();
			forcedHeightWhenNotColored = reader.ReadSingle();
			hasForcedHeightWhenNotColored = reader.ReadBoolean();
		}
	}
}
