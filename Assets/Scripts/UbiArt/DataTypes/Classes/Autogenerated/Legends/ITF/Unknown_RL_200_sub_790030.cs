namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_200_sub_790030 : CSerializable {
		public Placeholder circles;
		public Placeholder transitions;
		public Path texturePath;
		public Placeholder material;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			circles = s.SerializeObject<Placeholder>(circles, name: "circles");
			transitions = s.SerializeObject<Placeholder>(transitions, name: "transitions");
			if (s.HasFlags(SerializeFlags.Flags8)) {
				texturePath = s.SerializeObject<Path>(texturePath, name: "texturePath");
			}
			material = s.SerializeObject<Placeholder>(material, name: "material");
		}
		public override uint? ClassCRC => 0x31D38AFF;
	}
}

