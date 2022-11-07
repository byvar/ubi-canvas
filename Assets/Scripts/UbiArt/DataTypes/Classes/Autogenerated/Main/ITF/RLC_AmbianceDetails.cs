namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_AmbianceDetails : CSerializable {
		public StringID AmbianceDetailsId;
		public PathRef Bank;
		public StringID WwiseGUID_Start;
		public StringID WwiseGUID_Stop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			AmbianceDetailsId = s.SerializeObject<StringID>(AmbianceDetailsId, name: "AmbianceDetailsId");
			Bank = s.SerializeObject<PathRef>(Bank, name: "Bank");
			WwiseGUID_Start = s.SerializeObject<StringID>(WwiseGUID_Start, name: "WwiseGUID_Start");
			WwiseGUID_Stop = s.SerializeObject<StringID>(WwiseGUID_Stop, name: "WwiseGUID_Stop");
		}
		public override uint? ClassCRC => 0xA1C6ED6C;
	}
}

