using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LightOrbSpawnerComponent_Template : CSerializable {
		[Serialize("spawnActorLua"   )] public Path spawnActorLua;
		[Serialize("FX_Shake"        )] public StringID FX_Shake;
		[Serialize("FX_OrbsRemaining")] public StringID FX_OrbsRemaining;
		[Serialize("shakeAnimationID")] public StringID shakeAnimationID;
		[Description("Time before the spawner can spawn light orbs again.")]
		[Serialize("timeBeforeRefill")] public float timeBeforeRefill;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(spawnActorLua));
				SerializeField(s, nameof(FX_Shake));
				SerializeField(s, nameof(FX_OrbsRemaining));
				SerializeField(s, nameof(shakeAnimationID));
				SerializeField(s, nameof(timeBeforeRefill));
			}
		}
		public override uint? ClassCRC => 0x4FB77A07;
	}
}

