using UnityEngine;

namespace UbiArt.ITF {
	public partial class EdgeProcessData : CSerializable {
		[Serialize("Id"        )] public int Id;
		[Serialize("IndexStart")] public int IndexStart;
		[Serialize("IndexEnd"  )] public int IndexEnd;
		[Serialize("PosStart"  )] public Vector2 PosStart;
		[Serialize("PosEnd"    )] public Vector2 PosEnd;
		[Serialize("PosOffset" )] public Vector2 PosOffset;
		[Serialize("Count"     )] public int Count;
		[Serialize("Normal"    )] public Vector2 Normal;
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

