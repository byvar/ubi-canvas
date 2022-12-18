namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_GameObjectMessage_PlayerReady : CSerializable {
		public uint playerOnlineID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			playerOnlineID = s.Serialize<uint>(playerOnlineID, name: "playerOnlineID");
		}
		public override uint? ClassCRC => 0x8B16092A;
	}
}

