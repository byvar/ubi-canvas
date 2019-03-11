using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventAddLum : CSerializable {
		[Serialize("isAccrobatic")] public bool isAccrobatic;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(isAccrobatic));
		}
		public override uint? ClassCRC => 0xFBFE1D34;
	}
}

