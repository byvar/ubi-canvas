using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AICageBehavior_Template : TemplateAIBehavior {
		public uint electoonCount;
		public float electoonAppearRadius;
		public float cageSpawnerYOffset;
		public Path electoonPath;
		public Path stayElectoonPath;
		public float durationBeforeFadeOut;
		public Path stillHeartPath;
		public float broken_generatedRewardRadius;
		public CArray<uint> broken_generatedRewards;
		public Vec3d heartOffset;
		public int lastCageIndex;
		public float alreadyOpenAlpha;
		public float stayElectoonXOffset;
		public Path cinePath;
		public Path endCinePath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			electoonCount = s.Serialize<uint>(electoonCount, name: "electoonCount");
			electoonAppearRadius = s.Serialize<float>(electoonAppearRadius, name: "electoonAppearRadius");
			cageSpawnerYOffset = s.Serialize<float>(cageSpawnerYOffset, name: "cageSpawnerYOffset");
			electoonPath = s.SerializeObject<Path>(electoonPath, name: "electoonPath");
			stayElectoonPath = s.SerializeObject<Path>(stayElectoonPath, name: "stayElectoonPath");
			durationBeforeFadeOut = s.Serialize<float>(durationBeforeFadeOut, name: "durationBeforeFadeOut");
			stillHeartPath = s.SerializeObject<Path>(stillHeartPath, name: "stillHeartPath");
			broken_generatedRewardRadius = s.Serialize<float>(broken_generatedRewardRadius, name: "broken_generatedRewardRadius");
			broken_generatedRewards = s.SerializeObject<CArray<uint>>(broken_generatedRewards, name: "broken_generatedRewards");
			heartOffset = s.SerializeObject<Vec3d>(heartOffset, name: "heartOffset");
			lastCageIndex = s.Serialize<int>(lastCageIndex, name: "lastCageIndex");
			alreadyOpenAlpha = s.Serialize<float>(alreadyOpenAlpha, name: "alreadyOpenAlpha");
			stayElectoonXOffset = s.Serialize<float>(stayElectoonXOffset, name: "stayElectoonXOffset");
			cinePath = s.SerializeObject<Path>(cinePath, name: "cinePath");
			endCinePath = s.SerializeObject<Path>(endCinePath, name: "endCinePath");
		}
		public override uint? ClassCRC => 0xD6C8FF86;
	}
}

