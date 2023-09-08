namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeNodeBlendBranches_Template<T> : BlendTreeNodeBlend_Template<T> {
		public CListO<BlendLeaf> blendParams;
		public StringID blendInput;
		public float blendInputInterpolation;
		public float blendInputInterpoStartValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			blendParams = s.SerializeObject<CListO<BlendLeaf>>(blendParams, name: "blendParams");
			blendInput = s.SerializeObject<StringID>(blendInput, name: "blendInput");
			if (s.Settings.Game == Game.COL) {
				blendInputInterpolation = s.Serialize<float>(blendInputInterpolation, name: "blendInputInterpolation");
				blendInputInterpoStartValue = s.Serialize<float>(blendInputInterpoStartValue, name: "blendInputInterpoStartValue");
			}
		}
		public override uint? ClassCRC => 0xC1143887;

		[Games(GameFlags.All)]
		public partial class BlendLeaf : CSerializable {
			public float blendParam;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				blendParam = s.Serialize<float>(blendParam, name: "blendParam");
			}
		}
	}
}

