using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_355_sub_A71950 : CSerializable {
		[Serialize("detectInLight")] public bool detectInLight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(detectInLight), boolAsByte: true);
		}
		public override uint? ClassCRC => 0x952E1E18;
	}
}

