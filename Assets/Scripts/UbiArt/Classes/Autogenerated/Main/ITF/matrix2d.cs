using UnityEngine;

namespace UbiArt.ITF {
	public partial class matrix2d : CSerializable {
		[Serialize("Col1")] public Vector2 Col1;
		[Serialize("Col2")] public Vector2 Col2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Col1));
			SerializeField(s, nameof(Col2));
		}
	}
}

