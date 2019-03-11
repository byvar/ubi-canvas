using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTTimer_Template : BTNode_Template {
		[Serialize("node"   )] public BTNodeTemplate_Ref node;
		[Serialize("minTime")] public float minTime;
		[Serialize("maxTime")] public float maxTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(node));
			SerializeField(s, nameof(minTime));
			SerializeField(s, nameof(maxTime));
		}
		public override uint? ClassCRC => 0xE180188C;
	}
}

