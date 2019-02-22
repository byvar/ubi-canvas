using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class FluidFriseLayer : BaseObject {
		[Serialize(0, "erosion")] public uint erosion;
		[Serialize(1, "color")] public Color color;
		[Serialize(2, "threshold")] public float threshold;
		[Serialize(3, "gameMaterial")] public Path gameMaterial;
		[Serialize(4, "backsideGameMaterial")] public Path backsideGameMaterial;
		[Serialize(5, "collisionHeight")] public float collisionHeight;
		[Serialize(6, "hasBacksideInversion")] public bool hasBacksideInversion;
		[Serialize(7, "forcedHeightWhenNotColored")] public float forcedHeightWhenNotColored;
		[Serialize(8, "hasForcedHeightWhenNotColored")] public bool hasForcedHeightWhenNotColored;

		public FluidFriseLayer(Reader reader) : base(reader) {
		}
	}
}
