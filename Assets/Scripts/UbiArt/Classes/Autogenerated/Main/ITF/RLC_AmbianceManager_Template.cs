using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_AmbianceManager_Template : TemplateObj {
		public CArray<Generic<RLC_AmbianceDetails>> ambianceDetails;
		public CArray<Generic<RLC_AmbianceConfigAdventure>> ambianceConfigs_Adventure;
		public CArray<Generic<RLC_AmbianceConfigRunner>> ambianceConfigs_Runner;
		public CArray<Generic<RLC_AmbianceConfigRunnerOverride>> ambianceConfigs_RunnerOverride;
		public CArray<Generic<RLC_AmbianceConfigCreatureTree>> ambianceConfigs_Creature_Tree;
		public CArray<Generic<RLC_AmbianceConfigCreatureRoom>> ambianceConfigs_Creature_Room;
		public CArray<Generic<RLC_AmbianceConfigNextRegionMap>> ambianceConfigs_NextRegionMap;
		public CArray<Generic<RLC_AmbianceConfigAdversarialSoccer>> ambianceConfigs_AdversarialSoccer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ambianceDetails = s.SerializeObject<CArray<Generic<RLC_AmbianceDetails>>>(ambianceDetails, name: "ambianceDetails");
			ambianceConfigs_Adventure = s.SerializeObject<CArray<Generic<RLC_AmbianceConfigAdventure>>>(ambianceConfigs_Adventure, name: "ambianceConfigs_Adventure");
			ambianceConfigs_Runner = s.SerializeObject<CArray<Generic<RLC_AmbianceConfigRunner>>>(ambianceConfigs_Runner, name: "ambianceConfigs_Runner");
			ambianceConfigs_RunnerOverride = s.SerializeObject<CArray<Generic<RLC_AmbianceConfigRunnerOverride>>>(ambianceConfigs_RunnerOverride, name: "ambianceConfigs_RunnerOverride");
			ambianceConfigs_Creature_Tree = s.SerializeObject<CArray<Generic<RLC_AmbianceConfigCreatureTree>>>(ambianceConfigs_Creature_Tree, name: "ambianceConfigs_Creature_Tree");
			ambianceConfigs_Creature_Room = s.SerializeObject<CArray<Generic<RLC_AmbianceConfigCreatureRoom>>>(ambianceConfigs_Creature_Room, name: "ambianceConfigs_Creature_Room");
			ambianceConfigs_NextRegionMap = s.SerializeObject<CArray<Generic<RLC_AmbianceConfigNextRegionMap>>>(ambianceConfigs_NextRegionMap, name: "ambianceConfigs_NextRegionMap");
			ambianceConfigs_AdversarialSoccer = s.SerializeObject<CArray<Generic<RLC_AmbianceConfigAdversarialSoccer>>>(ambianceConfigs_AdversarialSoccer, name: "ambianceConfigs_AdversarialSoccer");
		}
		public override uint? ClassCRC => 0x3583F321;
	}
}

