using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class AnimMeshVertexPetComponent_Template : ActorComponent_Template {
		public bool allowUpdate;
		public CList<AnimMeshVertexPetData> pets;
		public CList<Vec3d> randomPets;
		public CList<AnimMeshVertexPetData> allPets;
		public CArray<string> baseParts;
		public CArray<string> animList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.VH) {
				allowUpdate = s.Serialize<bool>(allowUpdate, name: "allowUpdate");
				baseParts = s.SerializeObject<CArray<string>>(baseParts, name: "baseParts");
				animList = s.SerializeObject<CArray<string>>(animList, name: "animList");
				pets = s.SerializeObject<CList<AnimMeshVertexPetData>>(pets, name: "pets");
				randomPets = s.SerializeObject<CList<Vec3d>>(randomPets, name: "randomPets");
				allPets = s.SerializeObject<CList<AnimMeshVertexPetData>>(allPets, name: "allPets");
			} else {
				allowUpdate = s.Serialize<bool>(allowUpdate, name: "allowUpdate");
				pets = s.SerializeObject<CList<AnimMeshVertexPetData>>(pets, name: "pets");
				randomPets = s.SerializeObject<CList<Vec3d>>(randomPets, name: "randomPets");
				allPets = s.SerializeObject<CList<AnimMeshVertexPetData>>(allPets, name: "allPets");
			}
		}
		public override uint? ClassCRC => 0xBF9F2B1B;
	}
}

