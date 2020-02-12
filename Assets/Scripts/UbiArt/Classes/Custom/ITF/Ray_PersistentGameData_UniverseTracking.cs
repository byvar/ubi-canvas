using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PersistentGameData_UniverseTracking : CSerializable {
		[Serialize("timers"    )] public CArray<float> timers;
		[Serialize("pafCounter")] public CArray<uint> pafCounter;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(timers));
			SerializeField(s, nameof(pafCounter));
		}
	}
}

