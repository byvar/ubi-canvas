namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_136_sub_7335D0 : CSerializable {
		public PathRef levelSelectFriendly;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			levelSelectFriendly = s.SerializeObject<PathRef>(levelSelectFriendly, name: "levelSelectFriendly");
		}
		public override uint? ClassCRC => 0xBFB1ED03;
	}
}

