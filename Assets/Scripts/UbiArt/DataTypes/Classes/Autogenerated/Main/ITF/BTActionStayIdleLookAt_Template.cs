namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class BTActionStayIdleLookAt_Template : BTActionStayIdle_Template {
		public StringID pickableFact;
		public StringID posFact;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pickableFact = s.SerializeObject<StringID>(pickableFact, name: "pickableFact");
			posFact = s.SerializeObject<StringID>(posFact, name: "posFact");
		}
		public override uint? ClassCRC => 0x2D50410F;
	}
}

