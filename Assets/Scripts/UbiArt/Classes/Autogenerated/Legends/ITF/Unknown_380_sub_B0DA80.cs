using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_380_sub_B0DA80 : CSerializable {
		[Serialize("detectInLight")] public Placeholder detectInLight;
		[Serialize("detectInLight")] public bool detectInLight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(detectInLight));
			SerializeField(s, nameof(detectInLight));
		}
		public override uint? ClassCRC => 0x0607E596;
	}
}

