using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PersistentGameData_ISD : CSerializable {
		public CArray<PackedObjectPath> pickedUpLums;
		public CArray<PackedObjectPath> takenTooth;
		public CArray<PackedObjectPath> alreadySeenCutScenes;
		public uint foundRelicMask;
		public uint foundCageMask;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pickedUpLums = s.SerializeObject<CArray<PackedObjectPath>>(pickedUpLums, name: "pickedUpLums");
			takenTooth = s.SerializeObject<CArray<PackedObjectPath>>(takenTooth, name: "takenTooth");
			alreadySeenCutScenes = s.SerializeObject<CArray<PackedObjectPath>>(alreadySeenCutScenes, name: "alreadySeenCutScenes");
			foundRelicMask = s.Serialize<uint>(foundRelicMask, name: "foundRelicMask");
			foundCageMask = s.Serialize<uint>(foundCageMask, name: "foundCageMask");
		}
		public override uint? ClassCRC => 0xE779BB55;
	}
}

