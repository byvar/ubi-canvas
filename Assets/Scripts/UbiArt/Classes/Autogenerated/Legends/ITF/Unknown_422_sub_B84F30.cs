using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_422_sub_B84F30 : CSerializable {
		[Serialize("camModifier" )] public Placeholder camModifier;
		[Serialize("transitionIN")] public Placeholder transitionIN;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(camModifier));
			SerializeField(s, nameof(transitionIN));
		}
		public override uint? ClassCRC => 0x476DE974;
	}
}

