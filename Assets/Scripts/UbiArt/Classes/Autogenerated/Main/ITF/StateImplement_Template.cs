using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class StateImplement_Template : CSerializable {
		public CList<BasicState_Template> stateList;
		public StringID startState;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			stateList = s.SerializeObject<CList<BasicState_Template>>(stateList, name: "stateList");
			startState = s.SerializeObject<StringID>(startState, name: "startState");
		}
	}
}

