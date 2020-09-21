using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ShooterSpawnerComponent_Template : TimedSpawnerComponent_Template {
		public ActorSpawnBank_Template bank;
		public CListO<StringID> tweenInstructionSetList;
		public int cameraRelative;
		public int bindSpawnee;
		public Path rewardSpawnPath;
		public Path reward5xSpawnPath;
		public Generic<Event> vacuumedReward;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bank = s.SerializeObject<ActorSpawnBank_Template>(bank, name: "bank");
			tweenInstructionSetList = s.SerializeObject<CListO<StringID>>(tweenInstructionSetList, name: "tweenInstructionSetList");
			cameraRelative = s.Serialize<int>(cameraRelative, name: "cameraRelative");
			bindSpawnee = s.Serialize<int>(bindSpawnee, name: "bindSpawnee");
			rewardSpawnPath = s.SerializeObject<Path>(rewardSpawnPath, name: "rewardSpawnPath");
			reward5xSpawnPath = s.SerializeObject<Path>(reward5xSpawnPath, name: "reward5xSpawnPath");
			vacuumedReward = s.SerializeObject<Generic<Event>>(vacuumedReward, name: "vacuumedReward");
		}
		public override uint? ClassCRC => 0x5A5CA9FA;
	}
}

