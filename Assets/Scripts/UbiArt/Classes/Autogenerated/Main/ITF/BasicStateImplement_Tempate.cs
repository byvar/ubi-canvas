using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class BasicStateImplement_Tempate : BasicState_Template {
		[Serialize("implementTempate")] public StateImplement_Template implementTempate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(implementTempate));
		}
		public override uint? ClassCRC => 0x8B17155B;
	}
}

