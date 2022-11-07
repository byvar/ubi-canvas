namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class GFX_GridFluidModifierList : CSerializable {
		public StringID Name;
		public bool Active;
		public bool IsExternal;
		public CListO<GFX_GridFluidModifier> ModifierList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				Name = s.SerializeObject<StringID>(Name, name: "Name");
				Active = s.Serialize<bool>(Active, name: "Active");
				IsExternal = s.Serialize<bool>(IsExternal, name: "IsExternal");
				ModifierList = s.SerializeObject<CListO<GFX_GridFluidModifier>>(ModifierList, name: "ModifierList");
			}
		}
		public override uint? ClassCRC => 0xF10E0A6A;
	}
}

