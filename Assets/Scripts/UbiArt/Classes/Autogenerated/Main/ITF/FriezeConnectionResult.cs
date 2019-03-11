using UnityEngine;

namespace UbiArt.ITF {
	public partial class FriezeConnectionResult : CSerializable {
		[Serialize("pos"      )] public Vector2 pos;
		[Serialize("prevOwner")] public ObjectPath prevOwner;
		[Serialize("prevColId")] public uint prevColId;
		[Serialize("nextOwner")] public ObjectPath nextOwner;
		[Serialize("nextColId")] public uint nextColId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pos));
			SerializeField(s, nameof(prevOwner));
			SerializeField(s, nameof(prevColId));
			SerializeField(s, nameof(nextOwner));
			SerializeField(s, nameof(nextColId));
		}
	}
}

