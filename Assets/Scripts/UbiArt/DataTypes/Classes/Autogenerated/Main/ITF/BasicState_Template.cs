namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class BasicState_Template : CSerializable {
		public StringID stateName;
		public StringID defaultNextState;
		public Nullable<ImpParamHandler_Template> implementParamHandler;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			stateName = s.SerializeObject<StringID>(stateName, name: "stateName");
			defaultNextState = s.SerializeObject<StringID>(defaultNextState, name: "defaultNextState");
			implementParamHandler = s.SerializeObject<Nullable<ImpParamHandler_Template>>(implementParamHandler, name: "implementParamHandler");
		}
		public override uint? ClassCRC => 0x757E7BB4;
	}
}

