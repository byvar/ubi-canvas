using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_TurnipComponent_Template : RO2_AIComponent_Template {
		public StringID animIdle;
		public StringID animSquached;
		public StringID animImpact;
		public StringID animResist;
		public StringID animCatch;
		public StringID animDeath;
		public StringID animOut;
		public StringID animStun;
		public StringID animCatchedHit;
		public StringID animStunHit;
		public float distMaxResist;
		public Vec2d offsetDrag;
		public float speedToLaunch;
		public float timeMinBeforeOut;
		public uint countLumsReward;
		public uint countLumsPerHit;
		public bool debug;
		public float smoothFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animIdle = s.SerializeObject<StringID>(animIdle, name: "animIdle");
			animSquached = s.SerializeObject<StringID>(animSquached, name: "animSquached");
			animImpact = s.SerializeObject<StringID>(animImpact, name: "animImpact");
			animResist = s.SerializeObject<StringID>(animResist, name: "animResist");
			animCatch = s.SerializeObject<StringID>(animCatch, name: "animCatch");
			animDeath = s.SerializeObject<StringID>(animDeath, name: "animDeath");
			animOut = s.SerializeObject<StringID>(animOut, name: "animOut");
			animStun = s.SerializeObject<StringID>(animStun, name: "animStun");
			animCatchedHit = s.SerializeObject<StringID>(animCatchedHit, name: "animCatchedHit");
			animStunHit = s.SerializeObject<StringID>(animStunHit, name: "animStunHit");
			distMaxResist = s.Serialize<float>(distMaxResist, name: "distMaxResist");
			offsetDrag = s.SerializeObject<Vec2d>(offsetDrag, name: "offsetDrag");
			speedToLaunch = s.Serialize<float>(speedToLaunch, name: "speedToLaunch");
			timeMinBeforeOut = s.Serialize<float>(timeMinBeforeOut, name: "timeMinBeforeOut");
			countLumsReward = s.Serialize<uint>(countLumsReward, name: "countLumsReward");
			countLumsPerHit = s.Serialize<uint>(countLumsPerHit, name: "countLumsPerHit");
			debug = s.Serialize<bool>(debug, name: "debug");
			smoothFactor = s.Serialize<float>(smoothFactor, name: "smoothFactor");
		}
		public override uint? ClassCRC => 0x2E1D6F9A;
	}
}

