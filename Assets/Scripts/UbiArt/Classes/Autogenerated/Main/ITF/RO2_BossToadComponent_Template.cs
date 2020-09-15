using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BossToadComponent_Template : RO2_BossComponent_Template {
		public Path projectileA;
		public Path projectileB;
		public uint projectilePrealloc;
		public uint projectileMax;
		public StringID projectileBone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			projectileA = s.SerializeObject<Path>(projectileA, name: "projectileA");
			projectileB = s.SerializeObject<Path>(projectileB, name: "projectileB");
			projectilePrealloc = s.Serialize<uint>(projectilePrealloc, name: "projectilePrealloc");
			projectileMax = s.Serialize<uint>(projectileMax, name: "projectileMax");
			projectileBone = s.SerializeObject<StringID>(projectileBone, name: "projectileBone");
		}
		public override uint? ClassCRC => 0x7287EF87;
	}
}

