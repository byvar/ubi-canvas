using UnityEngine;

namespace UbiArt.ITF {
	public partial class BasicStateMachine_Template : CSerializable {
		[Serialize("stateList")] public CList<BasicState_Template> stateList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(stateList));
		}
		public override uint? ClassCRC => 0x81FA00D7;
	}
}

