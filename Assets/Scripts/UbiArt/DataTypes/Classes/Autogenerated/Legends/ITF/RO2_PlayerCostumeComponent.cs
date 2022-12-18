namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_PlayerCostumeComponent : ActorComponent {
		public StringID costumeId;
		public int standAlone;
		public LocalisationId descriptionLocId;
		public LocalisationId nameLocId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			costumeId = s.SerializeObject<StringID>(costumeId, name: "costumeId");
			standAlone = s.Serialize<int>(standAlone, name: "standAlone");
			descriptionLocId = s.SerializeObject<LocalisationId>(descriptionLocId, name: "descriptionLocId");
			nameLocId = s.SerializeObject<LocalisationId>(nameLocId, name: "nameLocId");
		}
		public override uint? ClassCRC => 0x29BE77F0;
	}
}

