using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class EdgeProcessData : CSerializable {
		[Serialize("Id"        )] public int Id;
		[Serialize("IndexStart")] public int IndexStart;
		[Serialize("IndexEnd"  )] public int IndexEnd;
		[Serialize("PosStart"  )] public Vec2d PosStart;
		[Serialize("PosEnd"    )] public Vec2d PosEnd;
		[Serialize("PosOffset" )] public Vec2d PosOffset;
		[Serialize("Count"     )] public int Count;
		[Serialize("Normal"    )] public Vec2d Normal;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Id));
			SerializeField(s, nameof(IndexStart));
			SerializeField(s, nameof(IndexEnd));
			SerializeField(s, nameof(PosStart));
			SerializeField(s, nameof(PosEnd));
			SerializeField(s, nameof(PosOffset));
			SerializeField(s, nameof(Count));
			SerializeField(s, nameof(Normal));
		}
	}
}

