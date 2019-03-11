using UnityEngine;

namespace UbiArt.ITF {
	public partial class BasicState_Template : CSerializable {
		[Serialize("stateName"            )] public StringID stateName;
		[Serialize("defaultNextState"     )] public StringID defaultNextState;
		[Serialize("implementParamHandler")] public ImpParamHandler_Template implementParamHandler;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(stateName));
			SerializeField(s, nameof(defaultNextState));
			SerializeField(s, nameof(implementParamHandler));
		}
		public override uint? ClassCRC => 0x757E7BB4;
	}
}

