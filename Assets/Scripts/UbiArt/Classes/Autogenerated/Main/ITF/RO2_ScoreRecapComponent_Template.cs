using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ScoreRecapComponent_Template : ActorComponent_Template {
		public StringID animPlayerDance;
		public StringID music;
		public uint bar;
		public float failSafeTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animPlayerDance = s.SerializeObject<StringID>(animPlayerDance, name: "animPlayerDance");
			music = s.SerializeObject<StringID>(music, name: "music");
			bar = s.Serialize<uint>(bar, name: "bar");
			failSafeTime = s.Serialize<float>(failSafeTime, name: "failSafeTime");
		}
		public override uint? ClassCRC => 0x7F5938ED;
	}
}

