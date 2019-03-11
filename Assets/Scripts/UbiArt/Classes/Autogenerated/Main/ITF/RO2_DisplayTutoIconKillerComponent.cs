using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_DisplayTutoIconKillerComponent : ActorComponent {
		[Serialize("Disable_Main_Type")] public bool Disable_Main_Type;
		[Serialize("Disable_DRC_Type" )] public bool Disable_DRC_Type;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Disable_Main_Type));
			SerializeField(s, nameof(Disable_DRC_Type));
		}
		public override uint? ClassCRC => 0x897604E4;
	}
}

