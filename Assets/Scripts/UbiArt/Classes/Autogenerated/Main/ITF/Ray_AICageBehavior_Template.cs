using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AICageBehavior_Template : TemplateAIBehavior {
		[Serialize("electoonCount"               )] public uint electoonCount;
		[Serialize("electoonAppearRadius"        )] public float electoonAppearRadius;
		[Serialize("cageSpawnerYOffset"          )] public float cageSpawnerYOffset;
		[Serialize("electoonPath"                )] public Path electoonPath;
		[Serialize("stayElectoonPath"            )] public Path stayElectoonPath;
		[Serialize("durationBeforeFadeOut"       )] public float durationBeforeFadeOut;
		[Serialize("stillHeartPath"              )] public Path stillHeartPath;
		[Serialize("broken_generatedRewardRadius")] public float broken_generatedRewardRadius;
		[Serialize("broken_generatedRewards"     )] public Placeholder broken_generatedRewards;
		[Serialize("heartOffset"                 )] public Vector3 heartOffset;
		[Serialize("lastCageIndex"               )] public int lastCageIndex;
		[Serialize("alreadyOpenAlpha"            )] public float alreadyOpenAlpha;
		[Serialize("stayElectoonXOffset"         )] public float stayElectoonXOffset;
		[Serialize("cinePath"                    )] public Path cinePath;
		[Serialize("endCinePath"                 )] public Path endCinePath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(electoonCount));
			SerializeField(s, nameof(electoonAppearRadius));
			SerializeField(s, nameof(cageSpawnerYOffset));
			SerializeField(s, nameof(electoonPath));
			SerializeField(s, nameof(stayElectoonPath));
			SerializeField(s, nameof(durationBeforeFadeOut));
			SerializeField(s, nameof(stillHeartPath));
			SerializeField(s, nameof(broken_generatedRewardRadius));
			SerializeField(s, nameof(broken_generatedRewards));
			SerializeField(s, nameof(heartOffset));
			SerializeField(s, nameof(lastCageIndex));
			SerializeField(s, nameof(alreadyOpenAlpha));
			SerializeField(s, nameof(stayElectoonXOffset));
			SerializeField(s, nameof(cinePath));
			SerializeField(s, nameof(endCinePath));
		}
		public override uint? ClassCRC => 0xD6C8FF86;
	}
}

