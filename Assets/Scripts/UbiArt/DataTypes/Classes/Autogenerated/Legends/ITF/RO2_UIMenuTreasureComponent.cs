namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_UIMenuTreasureComponent : UIMenu {
		public StringID treasureTextFriendly;
		public StringID participationTextFriendly;
		public float treasureValueSpeed;
		public float participationValueSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			treasureTextFriendly = s.SerializeObject<StringID>(treasureTextFriendly, name: "treasureTextFriendly");
			participationTextFriendly = s.SerializeObject<StringID>(participationTextFriendly, name: "participationTextFriendly");
			treasureValueSpeed = s.Serialize<float>(treasureValueSpeed, name: "treasureValueSpeed");
			participationValueSpeed = s.Serialize<float>(participationValueSpeed, name: "participationValueSpeed");
		}
		public override uint? ClassCRC => 0x8C586D1A;
	}
}

