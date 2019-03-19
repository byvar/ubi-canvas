using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_449_sub_B85570 : CSerializable {
		[Serialize("tweenId"                    )] public Enum_tweenId tweenId;
		[Serialize("spawnActorId"               )] public Enum_spawnActorId spawnActorId;
		[Serialize("beforeCamRelativeInitialPos")] public Vector3 beforeCamRelativeInitialPos;
		[Serialize("useTutoOnFirstSpawnee"      )] public bool useTutoOnFirstSpawnee;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(tweenId));
			SerializeField(s, nameof(spawnActorId));
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(beforeCamRelativeInitialPos));
			}
			SerializeField(s, nameof(useTutoOnFirstSpawnee), boolAsByte: true);
		}
		public enum Enum_tweenId {
			[Serialize("Value__1")] Value__1 = -1,
		}
		public override uint? ClassCRC => 0xF27AB10B;
	}
}

