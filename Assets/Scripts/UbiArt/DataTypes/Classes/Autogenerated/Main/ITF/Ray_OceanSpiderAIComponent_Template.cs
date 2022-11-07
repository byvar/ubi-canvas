namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_OceanSpiderAIComponent_Template : Ray_SimpleAIComponent_Template {
		public StringID addHitInputName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			addHitInputName = s.SerializeObject<StringID>(addHitInputName, name: "addHitInputName");
		}
		public override uint? ClassCRC => 0xC316633B;
	}
}

