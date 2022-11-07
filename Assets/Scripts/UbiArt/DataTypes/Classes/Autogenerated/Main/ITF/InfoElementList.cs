namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class InfoElementList : CSerializable {
		public CListO<InfoElement> elements;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			elements = s.SerializeObject<CListO<InfoElement>>(elements, name: "elements");
		}
	}
}

