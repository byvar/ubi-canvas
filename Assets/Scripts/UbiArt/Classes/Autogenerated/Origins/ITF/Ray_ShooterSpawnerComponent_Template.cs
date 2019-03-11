using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_ShooterSpawnerComponent_Template : TimedSpawnerComponent_Template {
		[Serialize("bank"                   )] public Placeholder bank;
		[Serialize("tweenInstructionSetList")] public Placeholder tweenInstructionSetList;
		[Serialize("cameraRelative"         )] public bool cameraRelative;
		[Serialize("bindSpawnee"            )] public bool bindSpawnee;
		[Serialize("rewardSpawnPath"        )] public Path rewardSpawnPath;
		[Serialize("reward5xSpawnPath"      )] public Path reward5xSpawnPath;
		[Serialize("vacuumedReward"         )] public Placeholder vacuumedReward;
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

