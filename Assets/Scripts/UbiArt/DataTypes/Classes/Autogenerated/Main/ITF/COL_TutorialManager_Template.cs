namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_TutorialManager_Template : CSerializable {
		public int isDLCData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isDLCData = s.Serialize<int>(isDLCData, name: "isDLCData");
		}
		public override uint? ClassCRC => 0x4BD8A86F;
	}
}

