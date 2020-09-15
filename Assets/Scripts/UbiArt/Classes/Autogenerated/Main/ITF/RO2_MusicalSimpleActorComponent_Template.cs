using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MusicalSimpleActorComponent_Template : ActorComponent_Template {
		public StringID animationIdle;
		public StringID animationMusical;
		public StringID animationTickle;
		public StringID animationMusicalToTickle;
		public StringID animationTickleToMusical;
		public StringID animationMusicalToIdle;
		public StringID animationIdleToMusical;
		public StringID animationIdleToTickle;
		public StringID animationTickleToIdle;
		public uint lumsByReward;
		public uint countMaxReward;
		public float timeBetweenRewardInSwipe;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animationIdle = s.SerializeObject<StringID>(animationIdle, name: "animationIdle");
			animationMusical = s.SerializeObject<StringID>(animationMusical, name: "animationMusical");
			animationTickle = s.SerializeObject<StringID>(animationTickle, name: "animationTickle");
			animationMusicalToTickle = s.SerializeObject<StringID>(animationMusicalToTickle, name: "animationMusicalToTickle");
			animationTickleToMusical = s.SerializeObject<StringID>(animationTickleToMusical, name: "animationTickleToMusical");
			animationMusicalToIdle = s.SerializeObject<StringID>(animationMusicalToIdle, name: "animationMusicalToIdle");
			animationIdleToMusical = s.SerializeObject<StringID>(animationIdleToMusical, name: "animationIdleToMusical");
			animationIdleToTickle = s.SerializeObject<StringID>(animationIdleToTickle, name: "animationIdleToTickle");
			animationTickleToIdle = s.SerializeObject<StringID>(animationTickleToIdle, name: "animationTickleToIdle");
			lumsByReward = s.Serialize<uint>(lumsByReward, name: "lumsByReward");
			countMaxReward = s.Serialize<uint>(countMaxReward, name: "countMaxReward");
			timeBetweenRewardInSwipe = s.Serialize<float>(timeBetweenRewardInSwipe, name: "timeBetweenRewardInSwipe");
		}
		public override uint? ClassCRC => 0xC8F79971;
	}
}

