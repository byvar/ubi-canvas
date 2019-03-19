using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AIExplodeAction_Template : AIAction_Template {
		[Serialize("minRadius"               )] public float minRadius;
		[Serialize("maxRadius"               )] public float maxRadius;
		[Serialize("duration"                )] public float duration;
		[Serialize("checkEnv"                )] public bool checkEnv;
		[Serialize("hitType"                 )] public RECEIVEDHITTYPE hitType;
		[Serialize("hitLevel"                )] public uint hitLevel;
		[Serialize("destroyAtEnd"            )] public bool destroyAtEnd;
		[Serialize("fxName"                  )] public StringID fxName;
		[Serialize("spawnFragmentsPath"      )] public Path spawnFragmentsPath;
		[Serialize("spawnFragmentsNb"        )] public uint spawnFragmentsNb;
		[Serialize("spawnFragmentsDeltaAngle")] public Angle spawnFragmentsDeltaAngle;
		[Serialize("spawnFragmentsStartAngle")] public Angle spawnFragmentsStartAngle;
		[Serialize("reward"                  )] public Generic<RO2_EventSpawnReward> reward;
		[Serialize("numRewards"              )] public CList<uint> numRewards;
		[Serialize("hitType"                 )] public Enum_hitType hitType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(minRadius));
				SerializeField(s, nameof(maxRadius));
				SerializeField(s, nameof(duration));
				SerializeField(s, nameof(checkEnv));
				SerializeField(s, nameof(hitType));
				SerializeField(s, nameof(hitLevel));
				SerializeField(s, nameof(destroyAtEnd));
				SerializeField(s, nameof(fxName));
				SerializeField(s, nameof(spawnFragmentsPath));
				SerializeField(s, nameof(spawnFragmentsNb));
				SerializeField(s, nameof(spawnFragmentsDeltaAngle));
				SerializeField(s, nameof(spawnFragmentsStartAngle));
				SerializeField(s, nameof(reward));
				SerializeField(s, nameof(numRewards));
			} else {
				SerializeField(s, nameof(minRadius));
				SerializeField(s, nameof(maxRadius));
				SerializeField(s, nameof(duration));
				SerializeField(s, nameof(checkEnv));
				SerializeField(s, nameof(hitType));
				SerializeField(s, nameof(hitLevel));
				SerializeField(s, nameof(destroyAtEnd));
				SerializeField(s, nameof(fxName));
				SerializeField(s, nameof(spawnFragmentsPath));
				SerializeField(s, nameof(spawnFragmentsNb));
				SerializeField(s, nameof(spawnFragmentsDeltaAngle));
				SerializeField(s, nameof(spawnFragmentsStartAngle));
				SerializeField(s, nameof(reward));
				SerializeField(s, nameof(numRewards));
			}
		}
		public enum RECEIVEDHITTYPE {
			[Serialize("RECEIVEDHITTYPE_UNKNOWN"    )] UNKNOWN = -1,
			[Serialize("RECEIVEDHITTYPE_FRONTPUNCH" )] FRONTPUNCH = 0,
			[Serialize("RECEIVEDHITTYPE_UPPUNCH"    )] UPPUNCH = 1,
			[Serialize("RECEIVEDHITTYPE_EJECTXY"    )] EJECTXY = 3,
			[Serialize("RECEIVEDHITTYPE_HURTBOUNCE" )] HURTBOUNCE = 4,
			[Serialize("RECEIVEDHITTYPE_DARKTOONIFY")] DARKTOONIFY = 5,
			[Serialize("RECEIVEDHITTYPE_EARTHQUAKE" )] EARTHQUAKE = 6,
			[Serialize("RECEIVEDHITTYPE_SHOOTER"    )] SHOOTER = 7,
		}
		public enum Enum_hitType {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
		}
		public override uint? ClassCRC => 0x81310BC3;
	}
}

