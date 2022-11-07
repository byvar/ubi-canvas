namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_RewardTrigger_FinishLevel : CSerializable {
		public StringID worldTag;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			worldTag = s.SerializeObject<StringID>(worldTag, name: "worldTag");
		}
		public override uint? ClassCRC => 0x914154F5;
	}
}

