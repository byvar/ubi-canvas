using UnityEngine;

namespace UbiArt.ITF {
	public partial class BreakPointDesc : CSerializable {
		[Serialize("DephtNodeID"  )] public string DephtNodeID;
		[Serialize("BreakOnDecide")] public int BreakOnDecide;
		[Serialize("BreakOnUpdate")] public int BreakOnUpdate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(DephtNodeID));
			SerializeField(s, nameof(BreakOnDecide));
			SerializeField(s, nameof(BreakOnUpdate));
		}
	}
}

