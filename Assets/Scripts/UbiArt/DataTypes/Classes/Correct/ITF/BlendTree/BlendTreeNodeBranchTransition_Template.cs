namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeNodeBranchTransition_Template<T> : BlendTreeNodeBlend_Template<T> {
		public float blendTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			blendTime = s.Serialize<float>(blendTime, name: "blendTime");
		}
		public override uint? ClassCRC => 0xB8CF072C;
	}
}

