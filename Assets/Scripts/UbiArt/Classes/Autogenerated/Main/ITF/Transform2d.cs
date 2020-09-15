using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class Transform2d : CSerializable {
		[Serialize("Rot")] public matrix2d Rot;
		[Serialize("Pos")] public Vec2d Pos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Rot));
			SerializeField(s, nameof(Pos));
		}
	}
}

