using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_22_sub_71F740 : CSerializable {
		[Serialize("ballPath"          )] public Path ballPath;
		[Serialize("goalLumCount"      )] public uint goalLumCount;
		[Serialize("goalOnFireLumCount")] public uint goalOnFireLumCount;
		[Serialize("goalRespawnDelay"  )] public float goalRespawnDelay;
		[Serialize("ballDestroyDelay"  )] public float ballDestroyDelay;
		[Serialize("maxBallCount"      )] public float maxBallCount;
		[Serialize("multiBallCooldown" )] public float multiBallCooldown;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ballPath));
			SerializeField(s, nameof(goalLumCount));
			SerializeField(s, nameof(goalOnFireLumCount));
			SerializeField(s, nameof(goalRespawnDelay));
			SerializeField(s, nameof(ballDestroyDelay));
			SerializeField(s, nameof(maxBallCount));
			SerializeField(s, nameof(multiBallCooldown));
		}
		public override uint? ClassCRC => 0x345EABDC;
	}
}

