using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_InteractComponent_Template : CSerializable {
		[Serialize("onInteractEvent"   )] public Placeholder onInteractEvent;
		[Serialize("onEndInteractEvent")] public Placeholder onEndInteractEvent;
		[Serialize("triggerSelf"       )] public int triggerSelf;
		[Serialize("triggerChildren"   )] public int triggerChildren;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(onInteractEvent));
			SerializeField(s, nameof(onEndInteractEvent));
			SerializeField(s, nameof(triggerSelf));
			SerializeField(s, nameof(triggerChildren));
		}
		public override uint? ClassCRC => 0xACBABA5C;
	}
}

