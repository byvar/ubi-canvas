using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_AmbianceManager_Template : TemplateObj {
		[Serialize("ambianceDetails"                  )] public CArray<Generic<RLC_AmbianceDetails>> ambianceDetails;
		[Serialize("ambianceConfigs_Adventure"        )] public CArray<Generic<RLC_AmbianceConfigAdventure>> ambianceConfigs_Adventure;
		[Serialize("ambianceConfigs_Runner"           )] public CArray<Generic<RLC_AmbianceConfigRunner>> ambianceConfigs_Runner;
		[Serialize("ambianceConfigs_RunnerOverride"   )] public CArray<Generic<RLC_AmbianceConfigRunnerOverride>> ambianceConfigs_RunnerOverride;
		[Serialize("ambianceConfigs_Creature_Tree"    )] public CArray<Generic<RLC_AmbianceConfigCreatureTree>> ambianceConfigs_Creature_Tree;
		[Serialize("ambianceConfigs_Creature_Room"    )] public CArray<Generic<RLC_AmbianceConfigCreatureRoom>> ambianceConfigs_Creature_Room;
		[Serialize("ambianceConfigs_NextRegionMap"    )] public CArray<Generic<RLC_AmbianceConfigNextRegionMap>> ambianceConfigs_NextRegionMap;
		[Serialize("ambianceConfigs_AdversarialSoccer")] public CArray<Generic<RLC_AmbianceConfigAdversarialSoccer>> ambianceConfigs_AdversarialSoccer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ambianceDetails));
			SerializeField(s, nameof(ambianceConfigs_Adventure));
			SerializeField(s, nameof(ambianceConfigs_Runner));
			SerializeField(s, nameof(ambianceConfigs_RunnerOverride));
			SerializeField(s, nameof(ambianceConfigs_Creature_Tree));
			SerializeField(s, nameof(ambianceConfigs_Creature_Room));
			SerializeField(s, nameof(ambianceConfigs_NextRegionMap));
			SerializeField(s, nameof(ambianceConfigs_AdversarialSoccer));
		}
		public override uint? ClassCRC => 0x3583F321;
	}
}

