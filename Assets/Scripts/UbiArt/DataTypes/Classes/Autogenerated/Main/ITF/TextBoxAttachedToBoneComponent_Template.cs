namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class TextBoxAttachedToBoneComponent_Template : ActorComponent_Template {
		public StringID boneName;
		public bool useBoneScale;
		public bool useBoneAngle;
		public bool useBoneAlpha;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			boneName = s.SerializeObject<StringID>(boneName, name: "boneName");
			useBoneScale = s.Serialize<bool>(useBoneScale, name: "useBoneScale");
			useBoneAngle = s.Serialize<bool>(useBoneAngle, name: "useBoneAngle");
			useBoneAlpha = s.Serialize<bool>(useBoneAlpha, name: "useBoneAlpha");
		}
		public override uint? ClassCRC => 0x50CB8E1E;
	}
}

