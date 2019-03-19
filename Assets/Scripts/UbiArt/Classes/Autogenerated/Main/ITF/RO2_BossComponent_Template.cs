using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BossComponent_Template : ActorComponent_Template {
		[Serialize("camShakeType"            )] public StringID camShakeType;
		[Serialize("offsetZSwitch"           )] public float offsetZSwitch;
		[Serialize("zSwitchDuration"         )] public float zSwitchDuration;
		[Serialize("buboBone"                )] public StringID buboBone;
		[Serialize("shieldBone"              )] public StringID shieldBone;
		[Serialize("faction"                 )] public uint faction;
		[Serialize("giveHearts"              )] public bool giveHearts;
		[Serialize("hitRequiredToChangePhase")] public uint hitRequiredToChangePhase;
		[Serialize("hitRequiredResetDuration")] public float hitRequiredResetDuration;
		[Serialize("hitFxPhase01Name"        )] public StringID hitFxPhase01Name;
		[Serialize("hitFxPhase02Name"        )] public StringID hitFxPhase02Name;
		[Serialize("hitFxPhase03Name"        )] public StringID hitFxPhase03Name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(camShakeType));
				SerializeField(s, nameof(offsetZSwitch));
				SerializeField(s, nameof(zSwitchDuration));
				SerializeField(s, nameof(buboBone));
				SerializeField(s, nameof(shieldBone));
				SerializeField(s, nameof(faction));
				SerializeField(s, nameof(giveHearts), boolAsByte: true);
				SerializeField(s, nameof(hitRequiredToChangePhase));
				SerializeField(s, nameof(hitRequiredResetDuration));
				SerializeField(s, nameof(hitFxPhase01Name));
				SerializeField(s, nameof(hitFxPhase02Name));
				SerializeField(s, nameof(hitFxPhase03Name));
			} else {
				SerializeField(s, nameof(camShakeType));
				SerializeField(s, nameof(offsetZSwitch));
				SerializeField(s, nameof(zSwitchDuration));
				SerializeField(s, nameof(buboBone));
				SerializeField(s, nameof(shieldBone));
				SerializeField(s, nameof(faction));
				SerializeField(s, nameof(giveHearts));
				SerializeField(s, nameof(hitRequiredToChangePhase));
				SerializeField(s, nameof(hitRequiredResetDuration));
			}
		}
		public override uint? ClassCRC => 0xD31151C8;
	}
}

