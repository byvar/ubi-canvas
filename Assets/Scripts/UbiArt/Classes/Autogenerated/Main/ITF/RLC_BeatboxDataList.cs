using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_BeatboxDataList : CSerializable {
		[Serialize("Day"          )] public uint Day;
		[Serialize("Month"        )] public uint Month;
		[Serialize("Year"         )] public uint Year;
		[Serialize("FavoriteTrack")] public bool FavoriteTrack;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Day));
			SerializeField(s, nameof(Month));
			SerializeField(s, nameof(Year));
			SerializeField(s, nameof(FavoriteTrack));
		}
	}
}

