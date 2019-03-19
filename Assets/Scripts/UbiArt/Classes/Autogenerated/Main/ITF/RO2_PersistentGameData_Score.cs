using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_PersistentGameData_Score : CSerializable {
		[Serialize("playersLumCount"  )] public CList<uint> playersLumCount;
		[Serialize("treasuresLumCount")] public CList<uint> treasuresLumCount;
		[Serialize("localLumsCount"   )] public int localLumsCount;
		[Serialize("pendingLumsCount" )] public int pendingLumsCount;
		[Serialize("tempLumsCount"    )] public int tempLumsCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(playersLumCount));
			SerializeField(s, nameof(treasuresLumCount));
			SerializeField(s, nameof(localLumsCount));
			SerializeField(s, nameof(pendingLumsCount));
			SerializeField(s, nameof(tempLumsCount));
		}
	}
}

