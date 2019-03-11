using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_FriendlyGrannyBTAIComponent_Template : RO2_FriendlyBTAIComponent_Template {
		[Serialize("health"                     )] public int health;
		[Serialize("hitHealthMalus"             )] public int hitHealthMalus;
		[Serialize("ignoreRehit"                )] public bool ignoreRehit;
		[Serialize("earthquakeBounceMultiplier" )] public float earthquakeBounceMultiplier;
		[Serialize("crushBounceMultiplier"      )] public float crushBounceMultiplier;
		[Serialize("softCollision"              )] public RO2_SoftCollision_Template softCollision;
		[Serialize("enableAutoSpawnOnCheckpoint")] public bool enableAutoSpawnOnCheckpoint;
		[Serialize("health"                     )] public bool health;
		[Serialize("hitHealthMalus"             )] public bool hitHealthMalus;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(health));
				SerializeField(s, nameof(hitHealthMalus));
				SerializeField(s, nameof(ignoreRehit));
				SerializeField(s, nameof(earthquakeBounceMultiplier));
				SerializeField(s, nameof(crushBounceMultiplier));
				SerializeField(s, nameof(softCollision));
				SerializeField(s, nameof(enableAutoSpawnOnCheckpoint));
			} else {
				SerializeField(s, nameof(health));
				SerializeField(s, nameof(hitHealthMalus));
				SerializeField(s, nameof(ignoreRehit));
				SerializeField(s, nameof(earthquakeBounceMultiplier));
				SerializeField(s, nameof(crushBounceMultiplier));
				SerializeField(s, nameof(softCollision));
				SerializeField(s, nameof(enableAutoSpawnOnCheckpoint));
			}
		}
		public override uint? ClassCRC => 0x8CCD6E30;
	}
}

