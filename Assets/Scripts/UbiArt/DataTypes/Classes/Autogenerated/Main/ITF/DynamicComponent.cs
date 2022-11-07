namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class DynamicComponent : PhysComponent {
		public CArrayO<Generic<AbstractDynModifier>> Modifiers;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Modifiers = s.SerializeObject<CArrayO<Generic<AbstractDynModifier>>>(Modifiers, name: "Modifiers");
		}
		public override uint? ClassCRC => 0x9F056DB1;
	}
}

