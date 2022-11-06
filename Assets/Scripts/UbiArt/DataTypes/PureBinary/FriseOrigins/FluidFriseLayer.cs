using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.FriseOrigins {
	// See: ITF::FluidFriseLayer::serialize
	public class FluidFriseLayer : CSerializable {
		public uint erosion;
		public Color color;
		public float threshold;
		public Path gameMaterial;
		public Path backsideGameMaterial;
		public float collisionHeight;
		public bool hasBacksideInversion;
		public float forcedHeightWhenNotColored;
		public bool hasForcedHeightWhenNotColored;


		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			threshold = s.Serialize<float>(threshold, name: "threshold");
			color = s.SerializeObject<Color>(color, name: "color");
			gameMaterial = s.SerializeObject<Path>(gameMaterial, name: "gameMaterial");
			backsideGameMaterial = s.SerializeObject<Path>(backsideGameMaterial, name: "backsideGameMaterial");
			collisionHeight = s.Serialize<float>(collisionHeight, name: "collisionHeight");
			erosion = s.Serialize<uint>(erosion, name: "erosion");
			hasBacksideInversion = s.Serialize<bool>(hasBacksideInversion, name: "hasBacksideInversion");
			forcedHeightWhenNotColored = s.Serialize<float>(forcedHeightWhenNotColored, name: "forcedHeightWhenNotColored");
			hasForcedHeightWhenNotColored = s.Serialize<bool>(hasForcedHeightWhenNotColored, name: "hasForcedHeightWhenNotColored");
		}
	}
}
