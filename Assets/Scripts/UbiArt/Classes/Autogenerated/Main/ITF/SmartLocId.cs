using UnityEngine;

namespace UbiArt.ITF {
	public partial class SmartLocId : CSerializable {
		[Serialize("useText")] public bool useText;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(useText));
		}
	}
}

