namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_CreatureCrownComponent_Template : ActorComponent_Template {
		public TextureBankPath crownTextureBank;
		public CMap<StringID, StringID> patchChanges;
		public CMap<StringID, StringID> seasonalPatchChanges;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			crownTextureBank = s.SerializeObject<TextureBankPath>(crownTextureBank, name: "crownTextureBank");
			patchChanges = s.SerializeObject<CMap<StringID, StringID>>(patchChanges, name: "patchChanges");
			seasonalPatchChanges = s.SerializeObject<CMap<StringID, StringID>>(seasonalPatchChanges, name: "seasonalPatchChanges");
		}
		public override uint? ClassCRC => 0x6880219D;
	}
}

