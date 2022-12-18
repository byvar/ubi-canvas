namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_UIMapButtonComponent : CSerializable {
		public PathRef levelSelectFriendly;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			levelSelectFriendly = s.SerializeObject<PathRef>(levelSelectFriendly, name: "levelSelectFriendly");
		}
		public override uint? ClassCRC => 0xBFB1ED03;
	}
}

