using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class FluidFriseLayer : CSerializable {
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
			if (Settings.s.engineVersion == Settings.EngineVersion.RO) {
				threshold = s.Serialize<float>(threshold, name: "threshold");
				color = s.SerializeObject<Color>(color, name: "color");
				gameMaterial = s.SerializeObject<Path>(gameMaterial, name: "gameMaterial");
				backsideGameMaterial = s.SerializeObject<Path>(backsideGameMaterial, name: "backsideGameMaterial");
				forcedHeightWhenNotColored = s.Serialize<float>(forcedHeightWhenNotColored, name: "forcedHeightWhenNotColored");
				hasForcedHeightWhenNotColored = s.Serialize<bool>(hasForcedHeightWhenNotColored, name: "hasForcedHeightWhenNotColored");
			} else {
				erosion = s.Serialize<uint>(erosion, name: "erosion");
				color = s.SerializeObject<Color>(color, name: "color");
				threshold = s.Serialize<float>(threshold, name: "threshold");
				gameMaterial = s.SerializeObject<Path>(gameMaterial, name: "gameMaterial");
				backsideGameMaterial = s.SerializeObject<Path>(backsideGameMaterial, name: "backsideGameMaterial");
				collisionHeight = s.Serialize<float>(collisionHeight, name: "collisionHeight");
				hasBacksideInversion = s.Serialize<bool>(hasBacksideInversion, name: "hasBacksideInversion");
				forcedHeightWhenNotColored = s.Serialize<float>(forcedHeightWhenNotColored, name: "forcedHeightWhenNotColored");
				hasForcedHeightWhenNotColored = s.Serialize<bool>(hasForcedHeightWhenNotColored, name: "hasForcedHeightWhenNotColored");
			}
		}
	}
}

