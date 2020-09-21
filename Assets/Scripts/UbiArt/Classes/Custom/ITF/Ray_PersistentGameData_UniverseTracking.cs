using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PersistentGameData_UniverseTracking : CSerializable {
		public CArrayP<float> timers;
		public CArrayP<uint> pafCounter;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			timers = s.SerializeObject<CArrayP<float>>(timers, name: "timers");
			pafCounter = s.SerializeObject<CArrayP<uint>>(pafCounter, name: "pafCounter");
		}
	}
}

