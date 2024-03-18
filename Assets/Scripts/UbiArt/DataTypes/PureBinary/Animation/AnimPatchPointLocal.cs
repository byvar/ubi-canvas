namespace UbiArt.Animation {
	// See: ITF::AnimPatchPointLocal::serialize
	public class AnimPatchPointLocal : CSerializable {
		public Link boneId;
		public Vec2d pos;
		public Vec2d normal;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			boneId = s.SerializeObject<Link>(boneId, name: "boneId");
			pos = s.SerializeObject<Vec2d>(pos, name: "pos");
			normal = s.SerializeObject<Vec2d>(normal, name: "normal");
		}

		/*
		Example:
		10BDAF20 BF2043C43EA0387E 3622ED493F800000
		10BDAF20 BF13E671BE899696 B622ED49BF800000
		10BDAF20 3FA37B9E3EA90F73 3622ED493F800000
		10BDAF20 3F993501BE89F773 B622ED49BF800000
		*/

	}
}
