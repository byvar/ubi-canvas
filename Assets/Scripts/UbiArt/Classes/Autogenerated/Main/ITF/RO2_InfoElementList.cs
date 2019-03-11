using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_InfoElementList : CSerializable {
		[Serialize("elements")] public CList<RO2_InfoElement> elements;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(elements));
		}
	}
}

