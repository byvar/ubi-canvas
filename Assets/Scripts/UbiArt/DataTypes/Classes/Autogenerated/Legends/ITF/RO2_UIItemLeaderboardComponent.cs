namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_UIItemLeaderboardComponent : CSerializable {
		public uint highlightTextStyle;
		public Vec3d invitationIconOffset;
		public Vec3d costumeIconOffset;
		public Vec3d statusIconOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			highlightTextStyle = s.Serialize<uint>(highlightTextStyle, name: "highlightTextStyle");
			invitationIconOffset = s.SerializeObject<Vec3d>(invitationIconOffset, name: "invitationIconOffset");
			costumeIconOffset = s.SerializeObject<Vec3d>(costumeIconOffset, name: "costumeIconOffset");
			statusIconOffset = s.SerializeObject<Vec3d>(statusIconOffset, name: "statusIconOffset");
		}
		public override uint? ClassCRC => 0x4019F019;
	}
}

