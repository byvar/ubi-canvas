using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_ShooterSpawnerComponent_Template : TimedSpawnerComponent_Template {
		[Serialize("bank"                   )] public ActorSpawnBank_Template bank;
		[Serialize("tweenInstructionSetList")] public CList<StringID> tweenInstructionSetList;
		[Serialize("cameraRelative"         )] public int cameraRelative;
		[Serialize("bindSpawnee"            )] public int bindSpawnee;
		[Serialize("rewardSpawnPath"        )] public Path rewardSpawnPath;
		[Serialize("reward5xSpawnPath"      )] public Path reward5xSpawnPath;
		[Serialize("vacuumedReward"         )] public Generic<Ray_EventSpawnReward> vacuumedReward;
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
		public override uint? ClassCRC => 0x94287E9C;
	}
}

