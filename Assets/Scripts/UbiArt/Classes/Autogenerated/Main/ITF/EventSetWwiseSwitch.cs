using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.COL)]
	public partial class EventSetWwiseSwitch : Event {
		[Serialize("WwiseSwitchGroupGUID")] public StringID WwiseSwitchGroupGUID;
		[Serialize("WwiseSwitchGUID"     )] public StringID WwiseSwitchGUID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(WwiseSwitchGroupGUID));
			SerializeField(s, nameof(WwiseSwitchGUID));
		}
		public override uint? ClassCRC => 0x87CC5E51;
	}
}

