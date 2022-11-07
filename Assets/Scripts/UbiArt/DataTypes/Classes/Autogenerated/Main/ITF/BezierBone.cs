namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class BezierBone : CSerializable {
		public StringID id;
		public float distance;
		public float offset;
		public bool followTangent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			id = s.SerializeObject<StringID>(id, name: "id");
			distance = s.Serialize<float>(distance, name: "distance");
			offset = s.Serialize<float>(offset, name: "offset");
			followTangent = s.Serialize<bool>(followTangent, name: "followTangent");
		}
	}
}

