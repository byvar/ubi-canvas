namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PersistentGameData_ISD : CSerializable {
		public CArrayO<PackedObjectPath> pickedUpLums;
		public CArrayO<PackedObjectPath> takenTooth;
		public CArrayO<PackedObjectPath> alreadySeenCutScenes;
		public uint foundRelicMask;
		public uint foundCageMask;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pickedUpLums = s.SerializeObject<CArrayO<PackedObjectPath>>(pickedUpLums, name: "pickedUpLums");
			takenTooth = s.SerializeObject<CArrayO<PackedObjectPath>>(takenTooth, name: "takenTooth");
			alreadySeenCutScenes = s.SerializeObject<CArrayO<PackedObjectPath>>(alreadySeenCutScenes, name: "alreadySeenCutScenes");
			foundRelicMask = s.Serialize<uint>(foundRelicMask, name: "foundRelicMask");
			foundCageMask = s.Serialize<uint>(foundCageMask, name: "foundCageMask");
		}
		public override uint? ClassCRC => 0xE779BB55;
	}
}

