using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIPerformHitAction_Template : AIAction_Template {
		[Serialize("level"       )] public uint level;
		[Serialize("type"        )] public RECEIVEDHITTYPE type;
		[Serialize("marker"      )] public StringID marker;
		[Serialize("usesAdditive")] public int usesAdditive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(level));
			SerializeField(s, nameof(type));
			SerializeField(s, nameof(marker));
			SerializeField(s, nameof(usesAdditive));
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

