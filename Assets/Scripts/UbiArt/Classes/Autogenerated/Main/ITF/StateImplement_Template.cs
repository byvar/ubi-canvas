using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class StateImplement_Template : CSerializable {
		[Serialize("stateList" )] public CList<BasicState_Template> stateList;
		[Serialize("startState")] public StringID startState;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(stateList));
			SerializeField(s, nameof(startState));
		}
	}
}

