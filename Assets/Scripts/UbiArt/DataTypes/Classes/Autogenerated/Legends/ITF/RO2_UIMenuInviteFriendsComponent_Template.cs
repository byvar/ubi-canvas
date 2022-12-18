namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_UIMenuInviteFriendsComponent_Template : CSerializable {
		public Path checkActorPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			checkActorPath = s.SerializeObject<Path>(checkActorPath, name: "checkActorPath");
		}
		public override uint? ClassCRC => 0xDA0F4D8D;
	}
}

