using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class DJ_ReticleComponent_Template : ActorComponent_Template {
		public StringID animDie;
		public float lifeTime;
		public uint faction;
		public bool isHitable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animDie = s.SerializeObject<StringID>(animDie, name: "animDie");
			lifeTime = s.Serialize<float>(lifeTime, name: "lifeTime");
			faction = s.Serialize<uint>(faction, name: "faction");
			isHitable = s.Serialize<bool>(isHitable, name: "isHitable");
		}
		public override uint? ClassCRC => 0xAC1FEBA0;
	}
}

