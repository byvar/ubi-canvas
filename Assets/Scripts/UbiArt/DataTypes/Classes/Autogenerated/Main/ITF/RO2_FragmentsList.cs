namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_FragmentsList : CSerializable {
		public CArrayP<uint> fragments;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fragments = s.SerializeObject<CArrayP<uint>>(fragments, name: "fragments");
		}
	}
}

