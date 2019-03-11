using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BossToadComponent_Template : RO2_BossComponent_Template {
		[Serialize("projectileA"       )] public Path projectileA;
		[Serialize("projectileB"       )] public Path projectileB;
		[Serialize("projectilePrealloc")] public uint projectilePrealloc;
		[Serialize("projectileMax"     )] public uint projectileMax;
		[Serialize("projectileBone"    )] public StringID projectileBone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(projectileA));
			SerializeField(s, nameof(projectileB));
			SerializeField(s, nameof(projectilePrealloc));
			SerializeField(s, nameof(projectileMax));
			SerializeField(s, nameof(projectileBone));
		}
		public override uint? ClassCRC => 0x7287EF87;
	}
}

