namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionActionUnlockCharacter_Template : CSerializable {
		[Description("character to unlock")]
		public StringID characterID;
		public bool unlock;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			characterID = s.SerializeObject<StringID>(characterID, name: "characterID");
			unlock = s.Serialize<bool>(unlock, name: "unlock", options: CSerializerObject.Options.BoolAsByte);
		}
		public override uint? ClassCRC => 0x14696743;
	}
}

