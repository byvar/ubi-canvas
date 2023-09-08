namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class AnimMeshVertexPetComponent_Template : ActorComponent_Template {
		public bool allowUpdate;
		public CListO<AnimMeshVertexPetData> pets;
		public CListO<Vec3d> randomPets;
		public CListO<AnimMeshVertexPetData> allPets;
		public CArrayP<string> baseParts;
		public CArrayP<string> animList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL || s.Settings.Game == Game.COL || s.Settings.Game == Game.VH) {
				allowUpdate = s.Serialize<bool>(allowUpdate, name: "allowUpdate");
				baseParts = s.SerializeObject<CArrayP<string>>(baseParts, name: "baseParts");
				animList = s.SerializeObject<CArrayP<string>>(animList, name: "animList");
				pets = s.SerializeObject<CListO<AnimMeshVertexPetData>>(pets, name: "pets");
				randomPets = s.SerializeObject<CListO<Vec3d>>(randomPets, name: "randomPets");
				allPets = s.SerializeObject<CListO<AnimMeshVertexPetData>>(allPets, name: "allPets");
			} else {
				allowUpdate = s.Serialize<bool>(allowUpdate, name: "allowUpdate");
				pets = s.SerializeObject<CListO<AnimMeshVertexPetData>>(pets, name: "pets");
				randomPets = s.SerializeObject<CListO<Vec3d>>(randomPets, name: "randomPets");
				allPets = s.SerializeObject<CListO<AnimMeshVertexPetData>>(allPets, name: "allPets");
			}
		}
		public override uint? ClassCRC => 0xBF9F2B1B;
	}
}

