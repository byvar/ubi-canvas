using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BossShieldComponent_Template : ActorComponent_Template {
		[Serialize("animOn"         )] public StringID animOn;
		[Serialize("animOff"        )] public StringID animOff;
		[Serialize("animDefaultOn"  )] public StringID animDefaultOn;
		[Serialize("radius"         )] public float radius;
		[Serialize("faction"        )] public uint faction;
		[Serialize("factionToRepel" )] public uint factionToRepel;
		[Serialize("factionToAccept")] public uint factionToAccept;
		[Serialize("hitActorsInside")] public bool hitActorsInside;
		[Serialize("centerBone"     )] public StringID centerBone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animOn));
			SerializeField(s, nameof(animOff));
			SerializeField(s, nameof(animDefaultOn));
			SerializeField(s, nameof(radius));
			SerializeField(s, nameof(faction));
			SerializeField(s, nameof(factionToRepel));
			SerializeField(s, nameof(factionToAccept));
			SerializeField(s, nameof(hitActorsInside));
			SerializeField(s, nameof(centerBone));
		}
		public override uint? ClassCRC => 0x8A65DEDD;
	}
}

