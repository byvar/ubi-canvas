namespace UbiArt.Animation {
	// See: ITF::AnimPatchPoint::serialize
	public class AnimPatchPoint : CSerializable {
		public Link key;
		public uint index;
		public Vec2d uv;
		public Vec2d normal;
		public StringID sid;
		public AnimPatchPointLocal local;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			key = s.SerializeObject<Link>(key, name: "key");
			index = s.Serialize<uint>(index, name: "index");
			uv = s.SerializeObject<Vec2d>(uv, name: "uv");
			normal = s.SerializeObject<Vec2d>(normal, name: "normal");
			if (s.Settings.Game == Game.RA || s.Settings.Game == Game.RM) {
				sid = s.SerializeObject<StringID>(sid, name: "sid");
			}
			local = s.SerializeObject<AnimPatchPointLocal>(local, name: "local");
		}

		/*
		Example (Legends):
		0AD026B0 00000000 3F2AC0833F0A0675 3C397212BF7FFBCE 10BDAF20BF2043C43EA0387E3622ED493F800000
		0AD026D8 00000001 3F2BB5F23F547E39 BC3972123F7FFBCE 10BDAF20BF13E671BE899696B622ED49BF800000
		0AD02700 00000002 3F71C28F3F089E67 3C397212BF7FFBCE 10BDAF203FA37B9E3EA90F733622ED493F800000
		0AD02728 00000003 3F6DE5C13F55562A BC3972123F7FFBCE 10BDAF203F993501BE89F773B622ED49BF800000
		*/

	}
}
