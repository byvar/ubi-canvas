namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BreakableCageComponent_Template : CSerializable {
		public StringID stage1Anim;
		public StringID stage2Anim;
		public StringID stage3Anim;
		public StringID stage1toStage2Anim;
		public StringID stage2toStage3Anim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			stage1Anim = s.SerializeObject<StringID>(stage1Anim, name: "stage1Anim");
			stage2Anim = s.SerializeObject<StringID>(stage2Anim, name: "stage2Anim");
			stage3Anim = s.SerializeObject<StringID>(stage3Anim, name: "stage3Anim");
			stage1toStage2Anim = s.SerializeObject<StringID>(stage1toStage2Anim, name: "stage1toStage2Anim");
			stage2toStage3Anim = s.SerializeObject<StringID>(stage2toStage3Anim, name: "stage2toStage3Anim");
		}
		public override uint? ClassCRC => 0x8D9BEDBC;
	}
}

