using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_AmbianceManager_Template : TemplateObj {
		public CArrayO<Generic<RLC_AmbianceDetails>> ambianceDetails;
		public CArrayO<Generic<RLC_AmbianceConfigAdventure>> ambianceConfigs_Adventure;
		public CArrayO<Generic<RLC_AmbianceConfigRunner>> ambianceConfigs_Runner;
		public CArrayO<Generic<RLC_AmbianceConfigRunnerOverride>> ambianceConfigs_RunnerOverride;
		public CArrayO<Generic<RLC_AmbianceConfigCreatureTree>> ambianceConfigs_Creature_Tree;
		public CArrayO<Generic<RLC_AmbianceConfigCreatureRoom>> ambianceConfigs_Creature_Room;
		public CArrayO<Generic<RLC_AmbianceConfigNextRegionMap>> ambianceConfigs_NextRegionMap;
		public CArrayO<Generic<RLC_AmbianceConfigAdversarialSoccer>> ambianceConfigs_AdversarialSoccer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ambianceDetails = s.SerializeObject<CArrayO<Generic<RLC_AmbianceDetails>>>(ambianceDetails, name: "ambianceDetails");
			ambianceConfigs_Adventure = s.SerializeObject<CArrayO<Generic<RLC_AmbianceConfigAdventure>>>(ambianceConfigs_Adventure, name: "ambianceConfigs_Adventure");
			ambianceConfigs_Runner = s.SerializeObject<CArrayO<Generic<RLC_AmbianceConfigRunner>>>(ambianceConfigs_Runner, name: "ambianceConfigs_Runner");
			ambianceConfigs_RunnerOverride = s.SerializeObject<CArrayO<Generic<RLC_AmbianceConfigRunnerOverride>>>(ambianceConfigs_RunnerOverride, name: "ambianceConfigs_RunnerOverride");
			ambianceConfigs_Creature_Tree = s.SerializeObject<CArrayO<Generic<RLC_AmbianceConfigCreatureTree>>>(ambianceConfigs_Creature_Tree, name: "ambianceConfigs_Creature_Tree");
			ambianceConfigs_Creature_Room = s.SerializeObject<CArrayO<Generic<RLC_AmbianceConfigCreatureRoom>>>(ambianceConfigs_Creature_Room, name: "ambianceConfigs_Creature_Room");
			ambianceConfigs_NextRegionMap = s.SerializeObject<CArrayO<Generic<RLC_AmbianceConfigNextRegionMap>>>(ambianceConfigs_NextRegionMap, name: "ambianceConfigs_NextRegionMap");
			ambianceConfigs_AdversarialSoccer = s.SerializeObject<CArrayO<Generic<RLC_AmbianceConfigAdversarialSoccer>>>(ambianceConfigs_AdversarialSoccer, name: "ambianceConfigs_AdversarialSoccer");
		}
		public override uint? ClassCRC => 0x3583F321;
	}
}

