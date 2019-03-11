using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_17_sub_818000 : CSerializable {
		[Serialize("modeDuration"                  )] public float modeDuration;
		[Serialize("respawnDuration"               )] public float respawnDuration;
		[Serialize("retryDelay"                    )] public float retryDelay;
		[Serialize("spawnPointDeactivationDuration")] public float spawnPointDeactivationDuration;
		[Serialize("allowCrushInMidAir"            )] public bool allowCrushInMidAir;
		[Serialize("scoreChangeBlinkDuration"      )] public float scoreChangeBlinkDuration;
		[Serialize("timeOutBlinkDuration"          )] public float timeOutBlinkDuration;
		[Serialize("onlineWanted"                  )] public bool onlineWanted;
		[Serialize("scoreColorTeamA"               )] public Color scoreColorTeamA;
		[Serialize("scoreColorTeamB"               )] public Color scoreColorTeamB;
		[Serialize("scoreAlpha"                    )] public float scoreAlpha;
		[Serialize("newPlayerTimer"                )] public float newPlayerTimer;
		[Serialize("countDownTimer"                )] public float countDownTimer;
		[Serialize("loadTime"                      )] public float loadTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(modeDuration));
			SerializeField(s, nameof(respawnDuration));
			SerializeField(s, nameof(retryDelay));
			SerializeField(s, nameof(spawnPointDeactivationDuration));
			SerializeField(s, nameof(allowCrushInMidAir));
			SerializeField(s, nameof(scoreChangeBlinkDuration));
			SerializeField(s, nameof(timeOutBlinkDuration));
			SerializeField(s, nameof(onlineWanted));
			SerializeField(s, nameof(scoreColorTeamA));
			SerializeField(s, nameof(scoreColorTeamB));
			SerializeField(s, nameof(scoreAlpha));
			SerializeField(s, nameof(newPlayerTimer));
			SerializeField(s, nameof(countDownTimer));
			SerializeField(s, nameof(loadTime));
		}
		public override uint? ClassCRC => 0x39850EED;
	}
}

