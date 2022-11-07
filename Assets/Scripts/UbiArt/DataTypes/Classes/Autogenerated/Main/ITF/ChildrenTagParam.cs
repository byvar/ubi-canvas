namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class ChildrenTagParam : CSerializable {
		public StringID TagName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			TagName = s.SerializeObject<StringID>(TagName, name: "TagName");
		}
	}
}

