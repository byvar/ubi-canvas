using UnityEngine;

namespace UbiArt.ITF {
	public partial class MultiplePath : CSerializable {
		[Serialize("PathValues")] public CList<Path> PathValues;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(PathValues));
		}
	}
}

