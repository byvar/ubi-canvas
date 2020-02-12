using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.RO | GameFlags.VH)]
	public partial class PersistentGameData_Level : CSerializable {
		[Serialize("id"                 )] public StringID id;
		[Serialize("ISDs"               )] public CMapGeneric<StringID, PersistentGameData_Level> ISDs;
		[Serialize("string__1"          )] public string string__1;
		[Serialize("CArray<StringID>__2")] public CArray<StringID> CArray_StringID__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(ISDs));
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(id));
				SerializeField(s, nameof(string__1));
				if (s.HasFlags(SerializeFlags.Flags10)) {
					SerializeField(s, nameof(CArray_StringID__2));
				}
			} else {
				SerializeField(s, nameof(id));
			}
		}
		public override uint? ClassCRC => 0xABC6D60D;
	}
}

