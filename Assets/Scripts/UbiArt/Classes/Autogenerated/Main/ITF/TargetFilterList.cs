using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
	public partial class TargetFilterList : CSerializable {
		[Serialize("platform"         )] public Platform platform;
		[Serialize("objects"          )] public CArray<string> objects;
		[Serialize("CString__0"       )] public CString CString__0;
		[Serialize("CList<string>__1" )] public CList<string> CList_string__1;
		[Serialize("Platform__2"      )] public Platform Platform__2;
		[Serialize("CArray<string>__3")] public CArray<string> CArray_string__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(CString__0));
					SerializeField(s, nameof(CList_string__1));
				}
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(Platform__2));
				SerializeField(s, nameof(CArray_string__3));
			} else {
				SerializeField(s, nameof(platform));
				SerializeField(s, nameof(objects));
				SerializeField(s, nameof(objects));
			}
		}
	}
}

