using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RO | GameFlags.RFR | GameFlags.VH)]
	public partial class TargetFilterList : CSerializable {
		public Platform platform;
		public CArrayP<string> objects;
		public CString platformStr;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.engineVersion == Settings.EngineVersion.RO) {
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					platformStr = s.Serialize<CString>(platformStr, name: "platformStr");
					objects = s.SerializeObject<CArrayP<string>>(objects, name: "objects");
				}
			} else {
				platform = s.SerializeObject<Platform>(platform, name: "platform");
				objects = s.SerializeObject<CArrayP<string>>(objects, name: "objects");
			}
		}
	}
}

