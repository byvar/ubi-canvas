using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class BasicState_Template : CSerializable {
		public StringID stateName;
		public StringID defaultNextState;
		public ImpParamHandler_Template implementParamHandler;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			stateName = s.SerializeObject<StringID>(stateName, name: "stateName");
			defaultNextState = s.SerializeObject<StringID>(defaultNextState, name: "defaultNextState");
			implementParamHandler = s.SerializeObject<ImpParamHandler_Template>(implementParamHandler, name: "implementParamHandler");
		}
		public override uint? ClassCRC => 0x757E7BB4;
	}
}

