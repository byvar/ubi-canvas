using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_155_sub_747080 : CSerializable {
		[Serialize("highlightTextStyle"  )] public uint highlightTextStyle;
		[Serialize("invitationIconOffset")] public Vec3d invitationIconOffset;
		[Serialize("costumeIconOffset"   )] public Vec3d costumeIconOffset;
		[Serialize("statusIconOffset"    )] public Vec3d statusIconOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(highlightTextStyle));
			SerializeField(s, nameof(invitationIconOffset));
			SerializeField(s, nameof(costumeIconOffset));
			SerializeField(s, nameof(statusIconOffset));
		}
		public override uint? ClassCRC => 0x4019F019;
	}
}

