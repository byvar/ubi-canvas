using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ShooterSpawnerComponent_Template : TimedSpawnerComponent_Template {
		[Serialize("bank"                   )] public ActorSpawnBank_Template bank;
		[Serialize("tweenInstructionSetList")] public CList<StringID> tweenInstructionSetList;
		[Serialize("cameraRelative"         )] public int cameraRelative;
		[Serialize("bindSpawnee"            )] public int bindSpawnee;
		[Serialize("rewardSpawnPath"        )] public Path rewardSpawnPath;
		[Serialize("reward5xSpawnPath"      )] public Path reward5xSpawnPath;
		[Serialize("vacuumedReward"         )] public Generic<Event> vacuumedReward;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bank));
			SerializeField(s, nameof(tweenInstructionSetList));
			SerializeField(s, nameof(cameraRelative));
			SerializeField(s, nameof(bindSpawnee));
			SerializeField(s, nameof(rewardSpawnPath));
			SerializeField(s, nameof(reward5xSpawnPath));
			SerializeField(s, nameof(vacuumedReward));
		}
		public override uint? ClassCRC => 0x5A5CA9FA;
	}
}

