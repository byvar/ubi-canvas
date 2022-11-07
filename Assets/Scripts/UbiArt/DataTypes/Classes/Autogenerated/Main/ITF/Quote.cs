namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class Quote : CSerializable {
		public QuoteCondition Appear;
		public QuoteCondition Disappear;
		public float IconScale;
		public LocalisationId Idx;
		public uint ArrayIdx;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Appear = s.SerializeObject<QuoteCondition>(Appear, name: "Appear");
			Disappear = s.SerializeObject<QuoteCondition>(Disappear, name: "Disappear");
			IconScale = s.Serialize<float>(IconScale, name: "IconScale");
			Idx = s.SerializeObject<LocalisationId>(Idx, name: "Idx");
			ArrayIdx = s.Serialize<uint>(ArrayIdx, name: "ArrayIdx");
		}
	}
}

