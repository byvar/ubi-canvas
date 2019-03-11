using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_425_sub_B85570 : CSerializable {
		[Serialize("tweenId"                    )] public Enum_tweenId tweenId;
		[Serialize("spawnActorId"               )] public Enum_spawnActorId spawnActorId;
		[Serialize("beforeCamRelativeInitialPos")] public Vector3 beforeCamRelativeInitialPos;
		[Serialize("useTutoOnFirstSpawnee"      )] public Placeholder useTutoOnFirstSpawnee;
		[Serialize("useTutoOnFirstSpawnee"      )] public bool useTutoOnFirstSpawnee;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(tweenId));
			SerializeField(s, nameof(spawnActorId));
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(beforeCamRelativeInitialPos));
			}
			SerializeField(s, nameof(useTutoOnFirstSpawnee));
			SerializeField(s, nameof(useTutoOnFirstSpawnee));
		}
		public enum Enum_tweenId {
			[Serialize("Value__1")] Value__1 = -1,
		}
		public override uint? ClassCRC => 0xF27AB10B;
	}
}

