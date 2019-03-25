using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_400_sub_B0DA80 : DetectorComponent {
		[Serialize("detectInLight")] public bool detectInLight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(detectInLight), boolAsByte: true);
		}
		public override uint? ClassCRC => 0x0607E596;
	}
}

