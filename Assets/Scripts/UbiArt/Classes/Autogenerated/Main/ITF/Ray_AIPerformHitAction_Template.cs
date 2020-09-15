using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIPerformHitAction_Template : AIAction_Template {
		public uint level;
		public RECEIVEDHITTYPE type;
		public StringID marker;
		public int usesAdditive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			level = s.Serialize<uint>(level, name: "level");
			type = s.Serialize<RECEIVEDHITTYPE>(type, name: "type");
			marker = s.SerializeObject<StringID>(marker, name: "marker");
			usesAdditive = s.Serialize<int>(usesAdditive, name: "usesAdditive");
		}
		public enum RECEIVEDHITTYPE {
			[Serialize("RECEIVEDHITTYPE_FRONTPUNCH" )] FRONTPUNCH = 0,
			[Serialize("RECEIVEDHITTYPE_UPPUNCH"    )] UPPUNCH = 1,
			[Serialize("RECEIVEDHITTYPE_EJECTXY"    )] EJECTXY = 3,
			[Serialize("RECEIVEDHITTYPE_DARKTOONIFY")] DARKTOONIFY = 5,
		}
		public override uint? ClassCRC => 0x94259280;
	}
}

