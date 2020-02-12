using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PersistentGameData_ISD : CSerializable {
		[Serialize("pickedUpLums"        )] public CArray<PackedObjectPath> pickedUpLums;
		[Serialize("takenTooth"          )] public CArray<PackedObjectPath> takenTooth;
		[Serialize("alreadySeenCutScenes")] public CArray<PackedObjectPath> alreadySeenCutScenes;
		[Serialize("foundRelicMask"      )] public uint foundRelicMask;
		[Serialize("foundCageMask"       )] public uint foundCageMask;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pickedUpLums));
			SerializeField(s, nameof(takenTooth));
			SerializeField(s, nameof(alreadySeenCutScenes));
			SerializeField(s, nameof(foundRelicMask));
			SerializeField(s, nameof(foundCageMask));
		}
		public override uint? ClassCRC => 0xE779BB55;
	}
}

