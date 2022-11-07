namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_PlayerCostumeManagerComponent_Template : ActorComponent_Template {
		public CArrayO<CostumeInfo> costumes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			costumes = s.SerializeObject<CArrayO<CostumeInfo>>(costumes, name: "costumes");
		}
		public override uint? ClassCRC => 0xCCA51CCA;
	}
}

