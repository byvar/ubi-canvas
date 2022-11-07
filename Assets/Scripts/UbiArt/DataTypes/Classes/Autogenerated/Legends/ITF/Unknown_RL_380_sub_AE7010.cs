namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_380_sub_AE7010 : CSerializable {
		public uint faction;
		public float squashDeathPenetration;
		public float timeFight;
		public int disabledPhys;
		public int withShield;
		public StringID colShield;
		public StringID colShield2;
		public float timeBlockingContact;
		public int withStilts;
		public StringID colStilt01;
		public StringID colStilt02;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			faction = s.Serialize<uint>(faction, name: "faction");
			squashDeathPenetration = s.Serialize<float>(squashDeathPenetration, name: "squashDeathPenetration");
			timeFight = s.Serialize<float>(timeFight, name: "timeFight");
			disabledPhys = s.Serialize<int>(disabledPhys, name: "disabledPhys");
			withShield = s.Serialize<int>(withShield, name: "withShield");
			colShield = s.SerializeObject<StringID>(colShield, name: "colShield");
			colShield2 = s.SerializeObject<StringID>(colShield2, name: "colShield2");
			timeBlockingContact = s.Serialize<float>(timeBlockingContact, name: "timeBlockingContact");
			withStilts = s.Serialize<int>(withStilts, name: "withStilts");
			colStilt01 = s.SerializeObject<StringID>(colStilt01, name: "colStilt01");
			colStilt02 = s.SerializeObject<StringID>(colStilt02, name: "colStilt02");
		}
		public override uint? ClassCRC => 0x7E98C9A8;
	}
}

