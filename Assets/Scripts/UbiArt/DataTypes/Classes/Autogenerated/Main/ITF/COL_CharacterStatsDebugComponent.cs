namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_CharacterStatsDebugComponent : CSerializable {
		public uint playerLevel;
		public bool refillHPOnLevelUp;
		public bool refillMPOnLevelUp;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				playerLevel = s.Serialize<uint>(playerLevel, name: "playerLevel");
				refillHPOnLevelUp = s.Serialize<bool>(refillHPOnLevelUp, name: "refillHPOnLevelUp", options: CSerializerObject.Options.BoolAsByte);
				refillMPOnLevelUp = s.Serialize<bool>(refillMPOnLevelUp, name: "refillMPOnLevelUp", options: CSerializerObject.Options.BoolAsByte);
			}
		}
		public override uint? ClassCRC => 0xBDFF97ED;
	}
}

