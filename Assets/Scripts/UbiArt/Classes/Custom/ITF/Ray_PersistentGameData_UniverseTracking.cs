using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PersistentGameData_UniverseTracking : CSerializable {
		public CArray<float> timers;
		public CArray<uint> pafCounter;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			timers = s.SerializeObject<CArray<float>>(timers, name: "timers");
			pafCounter = s.SerializeObject<CArray<uint>>(pafCounter, name: "pafCounter");
		}
	}
}

