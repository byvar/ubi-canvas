using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_335_sub_A71950 : CSerializable {
		[Serialize("detectInLight")] public Placeholder detectInLight;
		[Serialize("detectInLight")] public bool detectInLight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(detectInLight));
			SerializeField(s, nameof(detectInLight));
		}
		public override uint? ClassCRC => 0x952E1E18;
	}
}

