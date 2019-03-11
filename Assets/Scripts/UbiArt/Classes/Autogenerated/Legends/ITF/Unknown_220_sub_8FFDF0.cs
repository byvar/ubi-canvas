using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_220_sub_8FFDF0 : CSerializable {
		[Serialize("activateModeOnFirstActivation")] public Placeholder activateModeOnFirstActivation;
		[Serialize("activateModeOnFirstActivation")] public bool activateModeOnFirstActivation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(activateModeOnFirstActivation));
			SerializeField(s, nameof(activateModeOnFirstActivation));
		}
		public override uint? ClassCRC => 0x572E39FF;
	}
}

