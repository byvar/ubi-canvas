namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class AnimMeshVertexComponent : GraphicComponent {
		public float mergeRange = 10f;
		public AABB aabb = new AABB() { MIN = Vec2d.Infinity, MAX = Vec2d.MinusInfinity };
		public CListO<SingleAnimData> anims;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			anims = s.SerializeObject<CListO<SingleAnimData>>(anims, name: "anims");
			mergeRange = s.Serialize<float>(mergeRange, name: "mergeRange");
			aabb = s.SerializeObject<AABB>(aabb, name: "aabb");
		}
		public override uint? ClassCRC => 0x97C46CE1;
	}
}

