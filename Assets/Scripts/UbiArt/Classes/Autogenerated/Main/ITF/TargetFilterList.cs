using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RO | GameFlags.RFR | GameFlags.VH)]
	public partial class TargetFilterList : CSerializable {
		[Serialize("platform"         )] public Platform platform;
		[Serialize("objects"          )] public CArray<string> objects;
		[Serialize("CString__0"       )] public CString platformStr;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.engineVersion == Settings.EngineVersion.RO) {
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(platformStr));
					SerializeField(s, nameof(objects));
				}
			} else {
				SerializeField(s, nameof(platform));
				SerializeField(s, nameof(objects));
			}
		}
	}
}

