namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class PlugSnapConfig : CSerializable {
		public float duration;
		public StringID boneName;
		public bool boneDefaultFlipped;
		public float depthOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			duration = s.Serialize<float>(duration, name: "duration");
			boneName = s.SerializeObject<StringID>(boneName, name: "boneName");
			boneDefaultFlipped = s.Serialize<bool>(boneDefaultFlipped, name: "boneDefaultFlipped");
			depthOffset = s.Serialize<float>(depthOffset, name: "depthOffset");
		}
	}
}

