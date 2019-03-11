using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_403_sub_B4E120 : CSerializable {
		[Serialize("CheckFirePatch"   )] public bool CheckFirePatch;
		[Serialize("SuffocateTimer"   )] public float SuffocateTimer;
		[Serialize("DefaultFlameSize" )] public float DefaultFlameSize;
		[Serialize("LastSpitFireAngle")] public float LastSpitFireAngle;
		[Serialize("StartingState"    )] public Enum_StartingState StartingState;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(CheckFirePatch));
				SerializeField(s, nameof(SuffocateTimer));
				SerializeField(s, nameof(DefaultFlameSize));
				SerializeField(s, nameof(LastSpitFireAngle));
				SerializeField(s, nameof(StartingState));
			}
		}
		public enum Enum_StartingState {
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_10")] Value_10 = 10,
		}
		public override uint? ClassCRC => 0xE13278D3;
	}
}

