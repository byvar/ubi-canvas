using UnityEngine;

namespace UbiArt.ITF {
	public partial class InfoElementList : CSerializable {
		[Serialize("elements")] public CList<InfoElement> elements;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(elements));
		}
	}
}

