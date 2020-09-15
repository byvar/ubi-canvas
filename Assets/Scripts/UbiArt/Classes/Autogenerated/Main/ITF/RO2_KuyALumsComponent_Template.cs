using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_KuyALumsComponent_Template : RO2_AIComponent_Template {
		public StringID animIdle;
		public StringID animPaint;
		public StringID animSquached;
		public StringID animImpact;
		public StringID animResist;
		public StringID animExplode;
		public StringID fxStandPaint;
		public uint countLumsReward;
		public uint countLumsPaintReward;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animIdle = s.SerializeObject<StringID>(animIdle, name: "animIdle");
			animPaint = s.SerializeObject<StringID>(animPaint, name: "animPaint");
			animSquached = s.SerializeObject<StringID>(animSquached, name: "animSquached");
			animImpact = s.SerializeObject<StringID>(animImpact, name: "animImpact");
			animResist = s.SerializeObject<StringID>(animResist, name: "animResist");
			animExplode = s.SerializeObject<StringID>(animExplode, name: "animExplode");
			fxStandPaint = s.SerializeObject<StringID>(fxStandPaint, name: "fxStandPaint");
			countLumsReward = s.Serialize<uint>(countLumsReward, name: "countLumsReward");
			countLumsPaintReward = s.Serialize<uint>(countLumsPaintReward, name: "countLumsPaintReward");
		}
		public override uint? ClassCRC => 0xA445AD17;
	}
}

