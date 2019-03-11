using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_TouchHandler : CSerializable {
		[Serialize("shape"             )] public Generic<PhysShape> shape;
		[Serialize("endDragOnExitShape")] public bool endDragOnExitShape;
		[Serialize("startDragOnSwipe"  )] public bool startDragOnSwipe;
		[Serialize("clampToScreen"     )] public bool clampToScreen;
		[Serialize("clampRadius"       )] public uint clampRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(shape));
			SerializeField(s, nameof(endDragOnExitShape));
			SerializeField(s, nameof(startDragOnSwipe));
			SerializeField(s, nameof(clampToScreen));
			SerializeField(s, nameof(clampRadius));
		}
	}
}

