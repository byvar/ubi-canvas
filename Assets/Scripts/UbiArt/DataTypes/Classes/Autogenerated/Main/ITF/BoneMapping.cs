namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class BoneMapping : CSerializable {
		public StringID inputBone;
		public StringID outputBone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			inputBone = s.SerializeObject<StringID>(inputBone, name: "inputBone");
			outputBone = s.SerializeObject<StringID>(outputBone, name: "outputBone");
		}
	}
}

