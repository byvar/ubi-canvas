using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BossComponent_Template : ActorComponent_Template {
		public StringID camShakeType;
		public float offsetZSwitch;
		public float zSwitchDuration;
		public StringID buboBone;
		public StringID shieldBone;
		public uint faction;
		public bool giveHearts;
		public uint hitRequiredToChangePhase;
		public float hitRequiredResetDuration;
		public StringID hitFxPhase01Name;
		public StringID hitFxPhase02Name;
		public StringID hitFxPhase03Name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				camShakeType = s.SerializeObject<StringID>(camShakeType, name: "camShakeType");
				offsetZSwitch = s.Serialize<float>(offsetZSwitch, name: "offsetZSwitch");
				zSwitchDuration = s.Serialize<float>(zSwitchDuration, name: "zSwitchDuration");
				buboBone = s.SerializeObject<StringID>(buboBone, name: "buboBone");
				shieldBone = s.SerializeObject<StringID>(shieldBone, name: "shieldBone");
				faction = s.Serialize<uint>(faction, name: "faction");
				giveHearts = s.Serialize<bool>(giveHearts, name: "giveHearts", options: CSerializerObject.Options.BoolAsByte);
				hitRequiredToChangePhase = s.Serialize<uint>(hitRequiredToChangePhase, name: "hitRequiredToChangePhase");
				hitRequiredResetDuration = s.Serialize<float>(hitRequiredResetDuration, name: "hitRequiredResetDuration");
				hitFxPhase01Name = s.SerializeObject<StringID>(hitFxPhase01Name, name: "hitFxPhase01Name");
				hitFxPhase02Name = s.SerializeObject<StringID>(hitFxPhase02Name, name: "hitFxPhase02Name");
				hitFxPhase03Name = s.SerializeObject<StringID>(hitFxPhase03Name, name: "hitFxPhase03Name");
			} else {
				camShakeType = s.SerializeObject<StringID>(camShakeType, name: "camShakeType");
				offsetZSwitch = s.Serialize<float>(offsetZSwitch, name: "offsetZSwitch");
				zSwitchDuration = s.Serialize<float>(zSwitchDuration, name: "zSwitchDuration");
				buboBone = s.SerializeObject<StringID>(buboBone, name: "buboBone");
				shieldBone = s.SerializeObject<StringID>(shieldBone, name: "shieldBone");
				faction = s.Serialize<uint>(faction, name: "faction");
				giveHearts = s.Serialize<bool>(giveHearts, name: "giveHearts");
				hitRequiredToChangePhase = s.Serialize<uint>(hitRequiredToChangePhase, name: "hitRequiredToChangePhase");
				hitRequiredResetDuration = s.Serialize<float>(hitRequiredResetDuration, name: "hitRequiredResetDuration");
			}
		}
		public override uint? ClassCRC => 0xD31151C8;
	}
}

