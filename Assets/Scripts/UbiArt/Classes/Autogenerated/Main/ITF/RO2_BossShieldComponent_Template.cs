using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BossShieldComponent_Template : ActorComponent_Template {
		public StringID animOn;
		public StringID animOff;
		public StringID animDefaultOn;
		public float radius;
		public uint faction;
		public uint factionToRepel;
		public uint factionToAccept;
		public bool hitActorsInside;
		public StringID centerBone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animOn = s.SerializeObject<StringID>(animOn, name: "animOn");
			animOff = s.SerializeObject<StringID>(animOff, name: "animOff");
			animDefaultOn = s.SerializeObject<StringID>(animDefaultOn, name: "animDefaultOn");
			radius = s.Serialize<float>(radius, name: "radius");
			faction = s.Serialize<uint>(faction, name: "faction");
			factionToRepel = s.Serialize<uint>(factionToRepel, name: "factionToRepel");
			factionToAccept = s.Serialize<uint>(factionToAccept, name: "factionToAccept");
			hitActorsInside = s.Serialize<bool>(hitActorsInside, name: "hitActorsInside");
			centerBone = s.SerializeObject<StringID>(centerBone, name: "centerBone");
		}
		public override uint? ClassCRC => 0x8A65DEDD;
	}
}

