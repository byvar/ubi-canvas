namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_410_sub_B20F30 : RO2_SceneConfig_Base {
		public CListO<RO2_PackageDescriptor_Template> packageDescriptors;
		public CListO<RO2_CostumeDescriptor_Template> costumeDescriptors;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			packageDescriptors = s.SerializeObject<CListO<RO2_PackageDescriptor_Template>>(packageDescriptors, name: "packageDescriptors");
			costumeDescriptors = s.SerializeObject<CListO<RO2_CostumeDescriptor_Template>>(costumeDescriptors, name: "costumeDescriptors");
		}
		public override uint? ClassCRC => 0x502B8E0B;
	}
}

