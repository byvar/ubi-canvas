namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class StateImplement_Template : CSerializable {
		public CListO<Generic<BasicState_Template>> stateList;
		public StringID startState;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			stateList = s.SerializeObject<CListO<Generic<BasicState_Template>>>(stateList, name: "stateList");
			startState = s.SerializeObject<StringID>(startState, name: "startState");
		}
	}
}

