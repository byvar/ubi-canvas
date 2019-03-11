using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_PersistentGameData_ISD : CSerializable {
		[Serialize("pickedUpLums"        )] public Placeholder pickedUpLums;
		[Serialize("takenTooth"          )] public Placeholder takenTooth;
		[Serialize("alreadySeenCutScenes")] public Placeholder alreadySeenCutScenes;
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

