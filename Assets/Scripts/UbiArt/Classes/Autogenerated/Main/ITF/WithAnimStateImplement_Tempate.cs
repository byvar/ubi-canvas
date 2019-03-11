using UnityEngine;

namespace UbiArt.ITF {
	public partial class WithAnimStateImplement_Tempate : WithAnimState_Template {
		[Serialize("implementTempate")] public StateImplement_Template implementTempate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(implementTempate));
		}
		public override uint? ClassCRC => 0x29C931C9;
	}
}

