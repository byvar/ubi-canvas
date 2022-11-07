namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_PetModel : CSerializable {
		public int familyID;
		public int animPetDataIndex;
		public uint randomCoef;
		public StringID tag;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			familyID = s.Serialize<int>(familyID, name: "familyID");
			animPetDataIndex = s.Serialize<int>(animPetDataIndex, name: "animPetDataIndex");
			randomCoef = s.Serialize<uint>(randomCoef, name: "randomCoef");
			tag = s.SerializeObject<StringID>(tag, name: "tag");
		}
	}
}

