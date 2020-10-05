using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LightOrbSpawnerComponent_Template : CSerializable {
		public Path spawnActorLua;
		public StringID FX_Shake;
		public StringID FX_OrbsRemaining;
		public StringID shakeAnimationID;
		[Description("Time before the spawner can spawn light orbs again.")]
		public float timeBeforeRefill;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				spawnActorLua = s.SerializeObject<Path>(spawnActorLua, name: "spawnActorLua");
				FX_Shake = s.SerializeObject<StringID>(FX_Shake, name: "FX_Shake");
				FX_OrbsRemaining = s.SerializeObject<StringID>(FX_OrbsRemaining, name: "FX_OrbsRemaining");
				shakeAnimationID = s.SerializeObject<StringID>(shakeAnimationID, name: "shakeAnimationID");
				timeBeforeRefill = s.Serialize<float>(timeBeforeRefill, name: "timeBeforeRefill");
			}
		}
		public override uint? ClassCRC => 0x62185118;
	}
}

