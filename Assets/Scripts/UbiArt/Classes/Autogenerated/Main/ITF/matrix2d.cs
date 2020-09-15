using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class matrix2d : CSerializable {
		[Serialize("Col1")] public Vec2d Col1;
		[Serialize("Col2")] public Vec2d Col2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Col1));
			SerializeField(s, nameof(Col2));
		}
	}
}

