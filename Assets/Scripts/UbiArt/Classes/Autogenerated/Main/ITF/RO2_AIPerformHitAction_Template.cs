using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_AIPerformHitAction_Template : AIPerformHitAction_Template {
		[Serialize("level"       )] public uint level;
		[Serialize("type"        )] public RECEIVEDHITTYPE type;
		[Serialize("marker"      )] public StringID marker;
		[Serialize("usesAdditive")] public bool usesAdditive;
		[Serialize("type"        )] public Enum_type type;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(level));
				SerializeField(s, nameof(type));
				SerializeField(s, nameof(marker));
				SerializeField(s, nameof(usesAdditive));
			} else {
				SerializeField(s, nameof(level));
				SerializeField(s, nameof(type));
				SerializeField(s, nameof(marker));
				SerializeField(s, nameof(usesAdditive));
			}
		}
		public enum RECEIVEDHITTYPE {
			[Serialize("RECEIVEDHITTYPE_FRONTPUNCH" )] FRONTPUNCH = 0,
			[Serialize("RECEIVEDHITTYPE_UPPUNCH"    )] UPPUNCH = 1,
			[Serialize("RECEIVEDHITTYPE_EJECTXY"    )] EJECTXY = 3,
			[Serialize("RECEIVEDHITTYPE_DARKTOONIFY")] DARKTOONIFY = 5,
		}
		public enum Enum_type {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_5")] Value_5 = 5,
		}
		public override uint? ClassCRC => 0xE1D17D34;
	}
}

