namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionActionUnlockReward : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x23D4E470;
	}
}

