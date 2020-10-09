using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_TrainingTargetComponent_Template : ActorComponent_Template {
		public Path feedbackActorPath;
		public bool canBePainted;
		public uint reward;
		public uint paintedReward;
		public StringID animOff;
		public StringID animOffToOn;
		public StringID animOn;
		public StringID animPainted;
		public StringID animExplode;
		public StringID animExplodePainted;
		public StringID animAttack;
		public StringID fxBrickCompleted;
		public bool sendStim;
		public float stimRadius;
		public Vec2d stimOffset;
		public uint faction;
		public float offAlphaValue;
		public float alphaLerpFactor;
		public bool crushSensitive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			feedbackActorPath = s.SerializeObject<Path>(feedbackActorPath, name: "feedbackActorPath");
			canBePainted = s.Serialize<bool>(canBePainted, name: "canBePainted");
			reward = s.Serialize<uint>(reward, name: "reward");
			paintedReward = s.Serialize<uint>(paintedReward, name: "paintedReward");
			animOff = s.SerializeObject<StringID>(animOff, name: "animOff");
			animOffToOn = s.SerializeObject<StringID>(animOffToOn, name: "animOffToOn");
			animOn = s.SerializeObject<StringID>(animOn, name: "animOn");
			animPainted = s.SerializeObject<StringID>(animPainted, name: "animPainted");
			animExplode = s.SerializeObject<StringID>(animExplode, name: "animExplode");
			animExplodePainted = s.SerializeObject<StringID>(animExplodePainted, name: "animExplodePainted");
			animAttack = s.SerializeObject<StringID>(animAttack, name: "animAttack");
			fxBrickCompleted = s.SerializeObject<StringID>(fxBrickCompleted, name: "fxBrickCompleted");
			sendStim = s.Serialize<bool>(sendStim, name: "sendStim");
			stimRadius = s.Serialize<float>(stimRadius, name: "stimRadius");
			stimOffset = s.SerializeObject<Vec2d>(stimOffset, name: "stimOffset");
			faction = s.Serialize<uint>(faction, name: "faction");
			offAlphaValue = s.Serialize<float>(offAlphaValue, name: "offAlphaValue");
			alphaLerpFactor = s.Serialize<float>(alphaLerpFactor, name: "alphaLerpFactor");
			crushSensitive = s.Serialize<bool>(crushSensitive, name: "crushSensitive");
		}
		public override uint? ClassCRC => 0xA1A69415;
	}
}

