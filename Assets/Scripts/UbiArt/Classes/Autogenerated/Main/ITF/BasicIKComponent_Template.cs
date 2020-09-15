using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class BasicIKComponent_Template : ActorComponent_Template {
		public bool defaultProcess;
		public CArray<StringID> CArray_StringID__0;
		public bool bool__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				CArray_StringID__0 = s.SerializeObject<CArray<StringID>>(CArray_StringID__0, name: "CArray_StringID__0");
				bool__1 = s.Serialize<bool>(bool__1, name: "bool__1");
			} else {
				defaultProcess = s.Serialize<bool>(defaultProcess, name: "defaultProcess");
			}
		}
		public override uint? ClassCRC => 0xBF2A28E6;
	}
}

