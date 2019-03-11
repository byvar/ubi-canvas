using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_TurnipComponent_Template : RO2_AIComponent_Template {
		[Serialize("animIdle"        )] public StringID animIdle;
		[Serialize("animSquached"    )] public StringID animSquached;
		[Serialize("animImpact"      )] public StringID animImpact;
		[Serialize("animResist"      )] public StringID animResist;
		[Serialize("animCatch"       )] public StringID animCatch;
		[Serialize("animDeath"       )] public StringID animDeath;
		[Serialize("animOut"         )] public StringID animOut;
		[Serialize("animStun"        )] public StringID animStun;
		[Serialize("animCatchedHit"  )] public StringID animCatchedHit;
		[Serialize("animStunHit"     )] public StringID animStunHit;
		[Serialize("distMaxResist"   )] public float distMaxResist;
		[Serialize("offsetDrag"      )] public Vector2 offsetDrag;
		[Serialize("speedToLaunch"   )] public float speedToLaunch;
		[Serialize("timeMinBeforeOut")] public float timeMinBeforeOut;
		[Serialize("countLumsReward" )] public uint countLumsReward;
		[Serialize("countLumsPerHit" )] public uint countLumsPerHit;
		[Serialize("debug"           )] public bool debug;
		[Serialize("smoothFactor"    )] public float smoothFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animIdle));
			SerializeField(s, nameof(animSquached));
			SerializeField(s, nameof(animImpact));
			SerializeField(s, nameof(animResist));
			SerializeField(s, nameof(animCatch));
			SerializeField(s, nameof(animDeath));
			SerializeField(s, nameof(animOut));
			SerializeField(s, nameof(animStun));
			SerializeField(s, nameof(animCatchedHit));
			SerializeField(s, nameof(animStunHit));
			SerializeField(s, nameof(distMaxResist));
			SerializeField(s, nameof(offsetDrag));
			SerializeField(s, nameof(speedToLaunch));
			SerializeField(s, nameof(timeMinBeforeOut));
			SerializeField(s, nameof(countLumsReward));
			SerializeField(s, nameof(countLumsPerHit));
			SerializeField(s, nameof(debug));
			SerializeField(s, nameof(smoothFactor));
		}
		public override uint? ClassCRC => 0x2E1D6F9A;
	}
}

