namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class AnimPathAABB : CSerializable {
		public StringID name;
		public Path path;
		public AABB aabb;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			path = s.SerializeObject<Path>(path, name: "path");
			aabb = s.SerializeObject<AABB>(aabb, name: "aabb");
		}
	}
}

