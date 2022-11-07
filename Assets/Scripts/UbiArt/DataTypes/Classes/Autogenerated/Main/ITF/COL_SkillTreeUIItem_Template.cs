namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_SkillTreeUIItem_Template : CSerializable {
		public StringID skillUnlockFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			skillUnlockFX = s.SerializeObject<StringID>(skillUnlockFX, name: "skillUnlockFX");
		}
		public override uint? ClassCRC => 0xB0B6BFD2;
	}
}

