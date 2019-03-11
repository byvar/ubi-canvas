using UnityEngine;

namespace UbiArt.ITF {
	public partial class TouchScreenInputComponent_Template : ShapeComponent_Template {
		[Serialize("priority"         )] public uint priority;
		[Serialize("ignoreZ"          )] public bool ignoreZ;
		[Serialize("interactionBoneID")] public StringID interactionBoneID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(priority));
			SerializeField(s, nameof(ignoreZ));
			SerializeField(s, nameof(interactionBoneID));
		}
		public override uint? ClassCRC => 0x866D16A7;
	}
}

