using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AIReceiveHitAction_Template : AIReceiveHitAction_Template {
		public Generic<RO2_EventSpawnReward> reward;
		public float playRateVariation;
		public bool faceHitDir;
		public bool ignoreWind;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			reward = s.SerializeObject<Generic<RO2_EventSpawnReward>>(reward, name: "reward");
			playRateVariation = s.Serialize<float>(playRateVariation, name: "playRateVariation");
			faceHitDir = s.Serialize<bool>(faceHitDir, name: "faceHitDir");
			ignoreWind = s.Serialize<bool>(ignoreWind, name: "ignoreWind");
		}
		public override uint? ClassCRC => 0x4EE51604;
	}
}

