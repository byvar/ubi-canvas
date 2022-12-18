namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion)]
	public partial class MusicTreeNodeComposite : CSerializable {
		public Placeholder leafs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			leafs = s.SerializeObject<Placeholder>(leafs, name: "leafs");
		}
		public override uint? ClassCRC => 0x92E8BB21;
	}
}

