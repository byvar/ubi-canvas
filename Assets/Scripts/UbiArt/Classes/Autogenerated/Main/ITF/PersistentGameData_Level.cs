using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class PersistentGameData_Level : CSerializable {
		public StringID id;
		public CMapGeneric<StringID, Ray_PersistentGameData_ISD> ISDs;
		public string string__1;
		public CArrayO<StringID> CArray_StringID__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				ISDs = s.SerializeObject<CMapGeneric<StringID, Ray_PersistentGameData_ISD>>(ISDs, name: "ISDs");
			} else if (Settings.s.game == Settings.Game.VH) {
				id = s.SerializeObject<StringID>(id, name: "id");
				string__1 = s.Serialize<string>(string__1, name: "string__1");
				if (s.HasFlags(SerializeFlags.Flags10)) {
					CArray_StringID__2 = s.SerializeObject<CArrayO<StringID>>(CArray_StringID__2, name: "CArray<StringID>__2");
				}
			} else {
				id = s.SerializeObject<StringID>(id, name: "id");
			}
		}
		public override uint? ClassCRC => 0xABC6D60D;
	}
}

